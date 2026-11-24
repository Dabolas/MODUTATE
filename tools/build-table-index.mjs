// Rebuild after running import_full_forge.py. The index refers to byte ranges in the
// original, hash-verified JSON. No second rules dataset is shipped.
import fs from 'node:fs';
import path from 'node:path';
import crypto from 'node:crypto';
import { fileURLToPath } from 'node:url';

const dir = fileURLToPath(new URL('../data/forge/', import.meta.url));
const manifestBytes = fs.readFileSync(path.join(dir, 'manifest.json'));
const digest = buffer => crypto.createHash('sha256').update(buffer).digest('hex');
const manifest = JSON.parse(manifestBytes);
const rows = [];
function row(...values) {
    if (values.some(v => /[\r\n\t]/.test(String(v)))) throw Error('Unexpected control character in lookup metadata');
    rows.push(values.join('\t'));
}
for (const shard of manifest.shards) {
    const bytes = fs.readFileSync(path.join(dir, shard.path));
    if (digest(bytes) !== shard.sha256) throw Error('Wrong shard: ' + shard.path);
    row('#', shard.path);
    const prefix = '{"schema":1,"records":[';
    if (!bytes.subarray(0, prefix.length).equals(Buffer.from(prefix))) throw Error('Unexpected shard header');
    let start = prefix.length;
    for (let i = 0; i < shard.records; ++i) {
        let at = start, depth = 0, quoted = false;
        if (bytes[at] !== 123) throw Error('Missing record: ' + shard.path);
        do {
            const c = bytes[at++];
            if (c === undefined) throw Error('Truncated shard');
            if (quoted && c === 92) at++;
            else if (c === 34) quoted = !quoted;
            else if (!quoted && c === 123) depth++;
            else if (!quoted && c === 125) depth--;
        } while (depth !== 0);
        const record = JSON.parse(bytes.subarray(start, at).toString('utf8'));
        if (record.kind === 'tokenscripts') row('T', record.tokenId, start, at - start);
        else {
            const value = key => record.fields.find(f => f.key === key)?.value;
            const basic = (value('Types') ?? '').split(/\s+/).includes('Basic');
            row(basic ? 'B' : 'C', record.name, start, at - start);
            const faces = record.fields.filter(f => f.key === 'Name').map(f => f.value);
            if (faces.length !== 1 || faces[0] !== record.name) row('F', ...faces);
            const names = record.fields.filter(f => f.key === 'Name' || f.key === 'CopyFaceFrom').map(f => f.value);
            if (value('AlternateMode') === 'Split') row('P', names.slice(0,2).join(' // '));
            const extra = new Set(names.filter(n => !faces.includes(n)));
            for (const f of record.fields) {
                if (f.key === 'FlavorName') extra.add(f.value);
                if (f.key === 'Variant') {
                    const match = /^[^:]*:FlavorName:(.*)$/.exec(f.value);
                    if (match) extra.add(match[1]);
                }
            }
            if (extra.size) row('A', ...extra);
        }
        if (bytes[at] !== (i === shard.records-1 ? 93 : 44)) throw Error('Record boundary mismatch');
        start = at+1;
    }
}
const body = Buffer.from(rows.join('\n')+'\n','utf8');
fs.writeFileSync(path.join(dir,'table-index.txt'), Buffer.concat([Buffer.from(['1',digest(manifestBytes),digest(body)].join('\t')+'\n'), body]));
