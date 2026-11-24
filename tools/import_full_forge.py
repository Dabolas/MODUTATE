#!/usr/bin/env python3
"""Lossless Forge import and merge. No JVM, game, match or subprocess is started.

JSON is an interchange representation of Forge's DSL, not a Java-to-C# compiler.
Unknown expressions are deliberately preserved and routed to the upstream engine.
"""
from __future__ import annotations

import argparse
from collections import Counter
import hashlib
import json
import os
from pathlib import Path
import re
import tempfile
import zipfile

ROOT = Path(__file__).resolve().parents[1]
DATA = ROOT / "data/forge"
SOURCE = ROOT / "bridge/generated/forge-full"
SCHEMA = 1
SHARD_SIZE = 128
SKIP = {".git", "target", "bin", "obj"}
REGISTRIES = {
    "triggers": "forge-game/src/main/java/forge/game/trigger/TriggerType.java",
    "replacements": "forge-game/src/main/java/forge/game/replacement/ReplacementType.java",
    "effects": "forge-game/src/main/java/forge/game/ability/ApiType.java",
}


def sha(data: bytes) -> str:
    return hashlib.sha256(data).hexdigest()


def encode(value) -> bytes:
    return (json.dumps(value, ensure_ascii=False, separators=(",", ":")) + "\n").encode("utf-8")


def files(root: Path):
    for directory, dirs, names in os.walk(root, followlinks=False):
        dirs[:] = sorted(d for d in dirs if d not in SKIP)
        for name in sorted(names):
            path = Path(directory) / name
            if path.is_symlink():
                raise ValueError(f"Symlink in source tree: {path}")
            yield path


def program(value: str) -> list[dict]:
    """Ordered attributes; never split on '$' more than once or evaluate an expression."""
    result = []
    for part in value.split("|"):
        key, mark, expression = part.partition("$")
        result.append({"key": key.strip() if mark else "", "value": expression.strip() if mark else part,
                       "raw": part})
    return result


def parse_script(text: str) -> list[dict]:
    """Duplicate keys, face delimiters, comments and opaque lines all survive."""
    fields = []
    for number, line in enumerate(text.splitlines(), 1):
        key, colon, value = line.partition(":")
        field = {"line": number, "key": key if colon else "", "value": value if colon else line}
        if colon and key in {"A", "T", "R", "S"}:
            field["attributes"] = program(value)
        elif colon and key == "SVar":
            name, separator, body = value.partition(":")
            field["variable"] = name
            field["attributes"] = program(body if separator else value)
        fields.append(field)
    return fields


def registry(text: str) -> list[dict]:
    # Source syntax at the pinned version: EnumName(Implementation.class).
    # Strip comments to avoid registering commented-out implementations.
    clean = re.sub(r"/\*.*?\*/|//[^\n]*", "", text, flags=re.S)
    enum = clean.split("public enum ", 1)[1].split("{", 1)[1].split(";", 1)[0]
    pattern = r"\b(\w+)\s*\(\s*(\w+)\.class\s*(?:,\s*(?:true|false)\s*)?\)"
    entries = [{"name": m[0], "implementation": m[1]} for m in re.findall(pattern, enum)]
    if not entries or len({e["name"] for e in entries}) != len(entries):
        raise ValueError("Upstream registry syntax changed; refusing a partial registry")
    residue = re.sub(pattern + r"\s*,?", "", enum).strip(" \r\n\t,")
    if residue:
        raise ValueError(f"Unparsed registry declaration: {residue[:120]}")
    return entries


def make_record(path: Path, forge: Path, kind: str, legacy: dict) -> dict:
    raw = path.read_bytes()
    text = raw.decode("utf-8-sig")
    fields = parse_script(text) if path.suffix.lower() == ".txt" else []
    native = json.loads(text) if path.suffix.lower() == ".json" else None
    names = [f["value"].strip() for f in fields if f["key"] == "Name"]
    relative = path.relative_to(forge).as_posix()
    old = legacy.get(relative)
    if old and old["sha256"] != sha(raw):
        raise ValueError(f"Legacy data is stale; run migrate-forge.mjs first: {relative}")
    old_status = old["status"] if old else "pending"
    return {"id": relative, "path": relative, "kind": kind,
            "name": names[0] if names else path.stem, "faces": names,
            "tokenId": path.stem if kind == "tokenscripts" else "", "sha256": sha(raw),
            "script": text, "fields": fields, "json": native,
            "execution": {"managedStatus": old_status,
                          "managedPlayable": old_status in ("implemented-explicit", "implemented-safe-subset"),
                          "upstreamEngine": "forge-jvm", "requiresEngineHost": True},
            "blockers": old.get("blockers", []) if old else ["not-in-managed-catalogue"]}


def archive_sources(forge: Path, stage: Path) -> tuple[list[dict], list[dict], str]:
    java, resources = [], []
    rule_chunk, rule_shards = [], []
    (stage / "rules").mkdir()

    def flush_rules():
        if not rule_chunk:
            return
        relative = f"rules/{len(rule_shards):04d}.json"
        raw = encode({"schema": SCHEMA, "language": "java", "executionBackend": "forge-jvm", "rules": rule_chunk})
        (stage / relative).write_bytes(raw)
        rule_shards.append({"path": relative, "sha256": sha(raw), "records": len(rule_chunk)})
        rule_chunk.clear()

    archive = stage / "sources.zip"
    with zipfile.ZipFile(archive, "w", compression=zipfile.ZIP_DEFLATED, compresslevel=6) as bundle:
        for path in files(forge):
            relative = path.relative_to(forge).as_posix()
            is_java = path.suffix == ".java"
            is_resource = ("/res/" in relative or "/src/main/resources/" in relative) and path.suffix.lower() in {
                ".txt", ".json", ".properties", ".xml", ".csv", ".dck", ".dat"}
            is_build = path.name == "pom.xml" or path.name.upper().startswith(("LICENSE", "NOTICE", "COPYING"))
            if not (is_java or is_resource or is_build):
                continue
            raw = path.read_bytes()
            item = {"path": relative, "sha256": sha(raw), "bytes": len(raw)}
            if is_java:
                text = raw.decode("utf-8-sig")
                package = re.search(r"^\s*package\s+([\w.]+)\s*;", text, re.M)
                item.update(module=relative.split("/")[0], package=package[1] if package else "",
                            role="test-source" if "/src/test/" in relative else "engine-source",
                            convertedSource=f"rules/{len(rule_shards):04d}.json", slot=len(rule_chunk))
                rule_chunk.append({**item, "language": "java", "source": text,
                                   "imports": re.findall(r"^\s*import\s+([^;]+);", text, re.M)})
                java.append(item)
                if len(rule_chunk) == 32:
                    flush_rules()
            elif is_resource:
                resources.append(item)
            entry = zipfile.ZipInfo(relative, date_time=(1980, 1, 1, 0, 0, 0))
            entry.compress_type = zipfile.ZIP_DEFLATED
            entry.external_attr = 0o100644 << 16
            bundle.writestr(entry, raw)
    flush_rules()
    (stage / "rules-index.json").write_bytes(encode({"schema": SCHEMA, "language": "java",
        "compiledToClr": False, "shards": rule_shards,
        "warning": "Source interchange only. Execution requires the original Forge engine and its dependencies."}))
    return java, resources, sha(archive.read_bytes())


def run(forge: Path, data: Path, source: Path) -> dict:
    forge = forge.resolve(strict=True)
    legacy_path = ROOT / "data/legacy-forge/catalogue.json"
    legacy_bytes = legacy_path.read_bytes()
    legacy_doc = json.loads(legacy_bytes)
    legacy = {r["path"]: r for r in legacy_doc["records"]}
    commit = json.loads((ROOT / "bridge/toolchain.lock.json").read_text(encoding="utf-8-sig"))["forgeCommit"]
    if legacy_doc["source"]["commit"] != commit:
        raise ValueError("Forge and managed catalogue commits disagree")
    # Only generated locations within this workspace may be replaced.
    for target in (data, source):
        target.resolve().relative_to(ROOT)
        if target.resolve() == ROOT or target.resolve().is_relative_to(forge):
            raise ValueError("Output must not replace the workspace or upstream checkout")
    data.mkdir(parents=True, exist_ok=True)
    source.mkdir(parents=True, exist_ok=True)
    with tempfile.TemporaryDirectory(prefix="forge-import-", dir=ROOT / "tools") as temporary:
        stage = Path(temporary)
        staged_data = stage / "data"
        (staged_data / "records").mkdir(parents=True)
        registrations = {}
        for key, relative in REGISTRIES.items():
            text = (forge / relative).read_text(encoding="utf-8-sig")
            registrations[key] = {"source": relative, "entries": registry(text)}
            for entry in registrations[key]["entries"]:
                implementation = Path(relative).parent / (entry["implementation"] + ".java")
                if key == "effects":
                    implementation = Path(relative).parent / "effects" / (entry["implementation"] + ".java")
                if not (forge / implementation).is_file():
                    raise ValueError(f"Missing upstream implementation: {implementation}")
                entry["source"] = implementation.as_posix()
                entry["sha256"] = sha((forge / implementation).read_bytes())
        (staged_data / "registries.json").write_bytes(encode({"schema": SCHEMA, **registrations}))
        index, chunk, shards, modes = [], [], [], Counter()

        def flush():
            if not chunk:
                return
            relative = f"records/{len(shards):04d}.json"
            raw = encode({"schema": SCHEMA, "records": chunk})
            (staged_data / relative).write_bytes(raw)
            shards.append({"path": relative, "sha256": sha(raw), "records": len(chunk)})
            for slot, record in enumerate(chunk):
                index.append({k: record[k] for k in ("id", "path", "kind", "name", "faces", "tokenId", "sha256", "execution")}
                             | {"shard": relative, "slot": slot})
            chunk.clear()

        for kind in ("cardsfolder", "tokenscripts"):
            directory = forge / "forge-gui/res" / kind
            if not directory.is_dir():
                raise ValueError(f"Missing full upstream data directory: {kind}")
            for path in files(directory):
                if path.suffix.lower() not in (".txt", ".json"):
                    continue
                record = make_record(path, forge, kind, legacy)
                chunk.append(record)
                for field in record["fields"]:
                    for attribute in field.get("attributes", []):
                        if attribute["key"] in ("Mode", "Event", "DB", "SP", "AB"):
                            modes[(field["key"], attribute["key"], attribute["value"])] += 1
                if len(chunk) == SHARD_SIZE:
                    flush()
        flush()
        if set(legacy) != {r["path"] for r in index}:
            raise ValueError("Card/token source set differs from legacy; refresh the managed import before merging")
        java, resources, archive_hash = archive_sources(forge, stage)
        (stage / "java-sources.json").write_bytes(encode({"schema": SCHEMA, "files": java}))
        (stage / "resources.json").write_bytes(encode({"schema": SCHEMA, "files": resources}))
        (staged_data / "index.json").write_bytes(encode({"schema": SCHEMA, "records": index}))
        (staged_data / "dsl-inventory.json").write_bytes(encode({"schema": SCHEMA, "expressions": [
            {"field": k[0], "key": k[1], "value": k[2], "occurrences": count}
            for k, count in sorted(modes.items())]}))
        counts = {"cards": sum(r["kind"] == "cardsfolder" for r in index),
                  "tokens": sum(r["kind"] == "tokenscripts" for r in index),
                  "managedCards": sum(r["kind"] == "cardsfolder" and r["execution"]["managedPlayable"] for r in index),
                  "managedTokens": sum(r["kind"] == "tokenscripts" and r["execution"]["managedPlayable"] for r in index),
                  "javaSources": len(java), "resourceFiles": len(resources),
                  **{key: len(value["entries"]) for key, value in registrations.items()}}
        outputs = [{"path": p.relative_to(staged_data).as_posix(), "sha256": sha(p.read_bytes())}
                   for p in sorted(staged_data.rglob("*.json"))]
        manifest = {"schema": SCHEMA, "source": {"repository": "https://github.com/Card-Forge/forge", "commit": commit},
                    "counts": counts, "legacyCatalogueSha256": sha(legacy_bytes),
                    "registries": "registries.json", "index": "index.json", "shards": shards, "outputs": outputs,
                    "sourceArchive": {"path": "bridge/generated/forge-full/sources.zip", "sha256": archive_hash},
                    "execution": {"fullDataImported": True, "fullRulesExecutableInMod": False,
                                  "upstreamEngine": "forge-jvm", "workshopOnlyFullEngineAvailable": False,
                                  "managedEngine": "existing-safe-subset", "autoLaunchExternalProcess": False},
                    "warning": "Java source and DSL preservation is not CLR rule execution. Unknown rules require the original JVM engine."}
        # Manifest is the commit marker. An interrupted multi-file update is detected by its hashes.
        for path in sorted(staged_data.rglob("*.json")):
            dest = data / path.relative_to(staged_data)
            dest.parent.mkdir(parents=True, exist_ok=True)
            os.replace(path, dest)
        for name in ("sources.zip", "java-sources.json", "resources.json", "rules-index.json"):
            os.replace(stage / name, source / name)
        (source / "rules").mkdir(exist_ok=True)
        for path in sorted((stage / "rules").glob("*.json")):
            os.replace(path, source / "rules" / path.name)
        (data / "LICENSE.txt").write_bytes((forge / "LICENSE").read_bytes())
        temp_manifest = data / "manifest.json.tmp"
        temp_manifest.write_bytes(encode(manifest))
        os.replace(temp_manifest, data / "manifest.json")
        return manifest


if __name__ == "__main__":
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--forge", type=Path, default=ROOT / "external/forge")
    parser.add_argument("--data-output", type=Path, default=DATA)
    parser.add_argument("--source-output", type=Path, default=SOURCE)
    args = parser.parse_args()
    result = run(args.forge, args.data_output, args.source_output)
    print(json.dumps({"imported": result["counts"], "execution": result["execution"]}, ensure_ascii=False))
