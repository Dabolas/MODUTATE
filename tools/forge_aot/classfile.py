"""Development-only Java 17 class reader. No Java classes are loaded or executed."""
from __future__ import annotations
import struct


class Reader:
    def __init__(self, data):
        self.data, self.pos = data, 0

    def take(self, count):
        if count < 0 or self.pos + count > len(self.data):
            raise ValueError("Truncated class/attribute")
        value = self.data[self.pos:self.pos+count]
        self.pos += count
        return value

    def u1(self): return self.take(1)[0]
    def u2(self): return struct.unpack(">H", self.take(2))[0]
    def u4(self): return struct.unpack(">I", self.take(4))[0]


def mutf8(raw):
    # JVM modified UTF-8 stores UTF-16 code units, including individual surrogates.
    result, i = [], 0
    while i < len(raw):
        first = raw[i]
        if first < 128:
            result.append(chr(first)); i += 1
        elif first & 0xE0 == 0xC0:
            result.append(chr(((first & 31) << 6) | (raw[i+1] & 63))); i += 2
        elif first & 0xF0 == 0xE0:
            result.append(chr(((first & 15) << 12) | ((raw[i+1] & 63) << 6) | (raw[i+2] & 63))); i += 3
        else:
            raise ValueError("Invalid modified UTF-8")
    return "".join(result)


NAMES = ("nop aconst_null iconst_m1 iconst_0 iconst_1 iconst_2 iconst_3 iconst_4 iconst_5 lconst_0 lconst_1 "
"fconst_0 fconst_1 fconst_2 dconst_0 dconst_1 bipush sipush ldc ldc_w ldc2_w iload lload fload dload aload "
"iload_0 iload_1 iload_2 iload_3 lload_0 lload_1 lload_2 lload_3 fload_0 fload_1 fload_2 fload_3 dload_0 dload_1 dload_2 dload_3 aload_0 aload_1 aload_2 aload_3 "
"iaload laload faload daload aaload baload caload saload istore lstore fstore dstore astore "
"istore_0 istore_1 istore_2 istore_3 lstore_0 lstore_1 lstore_2 lstore_3 fstore_0 fstore_1 fstore_2 fstore_3 dstore_0 dstore_1 dstore_2 dstore_3 astore_0 astore_1 astore_2 astore_3 "
"iastore lastore fastore dastore aastore bastore castore sastore pop pop2 dup dup_x1 dup_x2 dup2 dup2_x1 dup2_x2 swap "
"iadd ladd fadd dadd isub lsub fsub dsub imul lmul fmul dmul idiv ldiv fdiv ddiv irem lrem frem drem ineg lneg fneg dneg "
"ishl lshl ishr lshr iushr lushr iand land ior lor ixor lxor iinc i2l i2f i2d l2i l2f l2d f2i f2l f2d d2i d2l d2f i2b i2c i2s lcmp fcmpl fcmpg dcmpl dcmpg "
"ifeq ifne iflt ifge ifgt ifle if_icmpeq if_icmpne if_icmplt if_icmpge if_icmpgt if_icmple if_acmpeq if_acmpne goto jsr ret tableswitch lookupswitch "
"ireturn lreturn freturn dreturn areturn return getstatic putstatic getfield putfield invokevirtual invokespecial invokestatic invokeinterface invokedynamic "
"new newarray anewarray arraylength athrow checkcast instanceof monitorenter monitorexit wide multianewarray ifnull ifnonnull goto_w jsr_w").split()
assert len(NAMES) == 202


def decode(code):
    result, r = [], Reader(code)
    while r.pos < len(code):
        pc, op = r.pos, r.u1()
        if op >= len(NAMES):
            raise ValueError(f"Reserved opcode {op} at {pc}")
        item = {"pc": pc, "op": NAMES[op], "args": []}
        if op in {16}:
            item["args"] = [struct.unpack(">b", r.take(1))[0]]
        elif op == 17:
            item["args"] = [struct.unpack(">h", r.take(2))[0]]
        elif op == 18 or 21 <= op <= 25 or 54 <= op <= 58 or op in {169,188}:
            item["args"] = [r.u1()]
        elif op in {19,20,178,179,180,181,182,183,184,187,189,192,193}:
            item["args"] = [r.u2()]
        elif op == 132:
            item["args"] = [r.u1(), struct.unpack(">b", r.take(1))[0]]
        elif 153 <= op <= 168 or op in {198,199}:
            item["args"] = [pc + struct.unpack(">h", r.take(2))[0]]
        elif op in {200,201}:
            item["args"] = [pc + struct.unpack(">i", r.take(4))[0]]
        elif op in {185,186}:
            item["args"] = [r.u2(), r.u1(), r.u1()]
        elif op == 197:
            item["args"] = [r.u2(), r.u1()]
        elif op == 196:
            nested = r.u1()
            if nested not in {21,22,23,24,25,54,55,56,57,58,132,169}:
                raise ValueError("Invalid wide instruction")
            item["op"] = NAMES[nested]
            item["wide"] = True
            item["args"] = [r.u2()]
            if nested == 132:
                item["args"].append(struct.unpack(">h", r.take(2))[0])
        elif op in {170,171}:
            r.take((-r.pos) % 4)
            default = pc + struct.unpack(">i", r.take(4))[0]
            pairs = []
            if op == 170:
                low, high = struct.unpack(">ii", r.take(8))
                if high < low or high - low > len(code):
                    raise ValueError("Invalid tableswitch")
                pairs = [(i, pc + struct.unpack(">i", r.take(4))[0]) for i in range(low, high+1)]
            else:
                count = struct.unpack(">i", r.take(4))[0]
                if count < 0 or count > len(code):
                    raise ValueError("Invalid lookupswitch")
                for _ in range(count):
                    key, offset = struct.unpack(">ii", r.take(8))
                    pairs.append((key, pc + offset))
            item["default"], item["pairs"] = default, pairs
        item["next"] = r.pos
        result.append(item)
    boundaries = {item["pc"] for item in result}
    for item in result:
        if item["op"].startswith("if") or item["op"] in {"goto","goto_w","jsr","jsr_w"}:
            if item["args"][0] not in boundaries:
                raise ValueError("Branch outside instruction boundaries")
        if item["op"] in {"tableswitch","lookupswitch"}:
            if any(target not in boundaries for target in [item["default"]] + [p[1] for p in item["pairs"]]):
                raise ValueError("Switch outside instruction boundaries")
    return result


def descriptor(text):
    def one(index):
        start = index
        while text[index] == "[": index += 1
        if text[index] == "L":
            index = text.index(";", index) + 1
        elif text[index] in "VZBCSIJFD":
            index += 1
        else:
            raise ValueError("Invalid JVM descriptor: " + text)
        return text[start:index], index
    if text.startswith("("):
        index, args = 1, []
        while text[index] != ")":
            value, index = one(index); args.append(value)
        ret, end = one(index+1)
        if end != len(text): raise ValueError("Trailing descriptor data")
        return args, ret
    field, end = one(0)
    if end != len(text): raise ValueError("Trailing field descriptor data")
    return field


class ClassFile:
    def __init__(self, raw):
        r = Reader(raw)
        if r.u4() != 0xCAFEBABE: raise ValueError("Not a class file")
        self.minor, self.major = r.u2(), r.u2()
        self.cp = [None] * r.u2()
        i = 1
        while i < len(self.cp):
            tag = r.u1()
            if tag == 1: value = mutf8(r.take(r.u2()))
            elif tag in {3,4}: value = struct.unpack(">i" if tag == 3 else ">f", r.take(4))[0]
            elif tag in {5,6}: value = struct.unpack(">q" if tag == 5 else ">d", r.take(8))[0]
            elif tag in {7,8,16,19,20}: value = r.u2()
            elif tag in {9,10,11,12,17,18}: value = (r.u2(), r.u2())
            elif tag == 15: value = (r.u1(), r.u2())
            else: raise ValueError(f"Unknown constant pool tag {tag}")
            self.cp[i] = (tag, value)
            i += 2 if tag in {5,6} else 1
        self.access, this_class, super_class = r.u2(), r.u2(), r.u2()
        self.name = self.class_name(this_class)
        self.super = self.class_name(super_class) if super_class else ""
        self.interfaces = [self.class_name(r.u2()) for _ in range(r.u2())]
        self.fields = self.members(r, False)
        self.methods = self.members(r, True)
        attrs = self.attributes(r)
        self.source = self.utf(Reader(attrs["SourceFile"]).u2()) if "SourceFile" in attrs else ""
        self.simple_name = self.name.rsplit("/",1)[-1]
        if "InnerClasses" in attrs:
            inner = Reader(attrs["InnerClasses"])
            for _ in range(inner.u2()):
                class_index,outer_index,name_index,flags = inner.u2(),inner.u2(),inner.u2(),inner.u2()
                if class_index == this_class and name_index:self.simple_name=self.utf(name_index)
        self.bootstrap = []
        if "BootstrapMethods" in attrs:
            a = Reader(attrs["BootstrapMethods"])
            self.bootstrap = [{"handle": a.u2(), "arguments": [a.u2() for _ in range(a.u2())]} for _ in range(a.u2())]
        if r.pos != len(raw): raise ValueError("Trailing class data")

    def utf(self, index):
        tag, value = self.cp[index]
        if tag != 1: raise ValueError("Expected UTF8 constant")
        return value

    def class_name(self, index):
        tag, value = self.cp[index]
        if tag != 7: raise ValueError("Expected class constant")
        return self.utf(value)

    def member_ref(self, index):
        tag, (owner, nt) = self.cp[index]
        if tag not in {9,10,11}: raise ValueError("Expected member reference")
        ntag, (name, desc) = self.cp[nt]
        if ntag != 12: raise ValueError("Expected name/type")
        return self.class_name(owner), self.utf(name), self.utf(desc)

    def dynamic(self, index):
        tag, (bootstrap, nt) = self.cp[index]
        if tag not in {17,18}: raise ValueError("Expected dynamic constant")
        name, desc = self.cp[nt][1]
        record = self.bootstrap[bootstrap]
        handle_kind, member = self.cp[record["handle"]][1]
        return {"name": self.utf(name), "descriptor": self.utf(desc), "bootstrapKind": handle_kind,
                "bootstrap": self.member_ref(member), "arguments": record["arguments"]}

    def attributes(self, reader):
        attrs = {}
        for _ in range(reader.u2()):
            name, length = self.utf(reader.u2()), reader.u4()
            if name in attrs: raise ValueError("Duplicate class attribute: " + name)
            attrs[name] = reader.take(length)
        return attrs

    def members(self, reader, methods):
        result = []
        for _ in range(reader.u2()):
            access, name, desc = reader.u2(), self.utf(reader.u2()), self.utf(reader.u2())
            attrs = self.attributes(reader)
            item = {"access": access, "name": name, "descriptor": desc}
            descriptor(desc)
            if methods and "Code" in attrs:
                code = Reader(attrs["Code"])
                item["maxStack"], item["maxLocals"] = code.u2(), code.u2()
                raw_code = code.take(code.u4())
                item["instructions"] = decode(raw_code)
                item["handlers"] = []
                for _ in range(code.u2()):
                    start, end, handler, catch = code.u2(), code.u2(), code.u2(), code.u2()
                    item["handlers"].append({"start": start, "end": end, "handler": handler, "type": self.class_name(catch) if catch else ""})
                item["debugAttributes"] = sorted(self.attributes(code))
                if code.pos != len(attrs["Code"]): raise ValueError("Trailing Code attribute data")
            if not methods and "ConstantValue" in attrs:
                item["constantIndex"] = Reader(attrs["ConstantValue"]).u2()
            result.append(item)
        return result
