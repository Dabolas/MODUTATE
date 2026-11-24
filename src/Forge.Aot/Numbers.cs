using System;

namespace Planeswalker.ForgeAot
{
    public static class JNumbers
    {
        public static JValue Narrow(string descriptor,JValue value)
        {
            unchecked{switch(descriptor){case "Z":return JValue.I(value.Int&1);case "B":return JValue.I((sbyte)value.Int);case "C":return JValue.I((char)value.Int);case "S":return JValue.I((short)value.Int);default:return value;}}
        }
        private static int DivI(int a,int b)=>a==int.MinValue&&b==-1?int.MinValue:a/b;
        private static long DivL(long a,long b)=>a==long.MinValue&&b==-1?long.MinValue:a/b;
        private static int RemI(int a,int b)=>a==int.MinValue&&b==-1?0:a%b;
        private static long RemL(long a,long b)=>a==long.MinValue&&b==-1?0:a%b;
        public static JValue Binary(JRuntime rt,string op,JValue a,JValue b)
        {
            unchecked
            {
                if((op=="idiv"||op=="irem")&&b.Int==0||(op=="ldiv"||op=="lrem")&&b.Long==0)throw rt.Fault("java/lang/ArithmeticException","/ by zero");
                switch(op)
                {
                    case "iadd":return JValue.I(a.Int+b.Int);case "ladd":return JValue.L(a.Long+b.Long);case "fadd":return JValue.F(a.Float+b.Float);case "dadd":return JValue.D(a.Double+b.Double);
                    case "isub":return JValue.I(a.Int-b.Int);case "lsub":return JValue.L(a.Long-b.Long);case "fsub":return JValue.F(a.Float-b.Float);case "dsub":return JValue.D(a.Double-b.Double);
                    case "imul":return JValue.I(a.Int*b.Int);case "lmul":return JValue.L(a.Long*b.Long);case "fmul":return JValue.F(a.Float*b.Float);case "dmul":return JValue.D(a.Double*b.Double);
                    case "idiv":return JValue.I(DivI(a.Int,b.Int));case "ldiv":return JValue.L(DivL(a.Long,b.Long));case "fdiv":return JValue.F(a.Float/b.Float);case "ddiv":return JValue.D(a.Double/b.Double);
                    case "irem":return JValue.I(RemI(a.Int,b.Int));case "lrem":return JValue.L(RemL(a.Long,b.Long));case "frem":return JValue.F(a.Float%b.Float);case "drem":return JValue.D(a.Double%b.Double);
                    case "ishl":return JValue.I(a.Int<<(b.Int&31));case "lshl":return JValue.L(a.Long<<(b.Int&63));case "ishr":return JValue.I(a.Int>>(b.Int&31));case "lshr":return JValue.L(a.Long>>(b.Int&63));
                    case "iushr":return JValue.I((int)((uint)a.Int>>(b.Int&31)));case "lushr":return JValue.L((long)((ulong)a.Long>>(b.Int&63)));
                    case "iand":return JValue.I(a.Int&b.Int);case "land":return JValue.L(a.Long&b.Long);case "ior":return JValue.I(a.Int|b.Int);case "lor":return JValue.L(a.Long|b.Long);case "ixor":return JValue.I(a.Int^b.Int);case "lxor":return JValue.L(a.Long^b.Long);
                    case "lcmp":return JValue.I(a.Long<b.Long?-1:a.Long>b.Long?1:0);
                    case "fcmpl":case "fcmpg":return JValue.I(float.IsNaN(a.Float)||float.IsNaN(b.Float)?(op=="fcmpl"?-1:1):a.Float<b.Float?-1:a.Float>b.Float?1:0);
                    case "dcmpl":case "dcmpg":return JValue.I(double.IsNaN(a.Double)||double.IsNaN(b.Double)?(op=="dcmpl"?-1:1):a.Double<b.Double?-1:a.Double>b.Double?1:0);
                }
                throw new PortGap("Unmapped arithmetic: "+op);
            }
        }
        private static int ToI(double v)=>double.IsNaN(v)?0:v>=int.MaxValue?int.MaxValue:v<=int.MinValue?int.MinValue:(int)v;
        private static long ToL(double v)=>double.IsNaN(v)?0:v>=long.MaxValue?long.MaxValue:v<=long.MinValue?long.MinValue:(long)v;
        public static JValue Unary(string op,JValue a)
        {
            unchecked
            {
                switch(op)
                {
                    case "ineg":return JValue.I(-a.Int);case "lneg":return JValue.L(-a.Long);case "fneg":return JValue.F(-a.Float);case "dneg":return JValue.D(-a.Double);
                    case "i2l":return JValue.L(a.Int);case "i2f":return JValue.F(a.Int);case "i2d":return JValue.D(a.Int);
                    case "l2i":return JValue.I((int)a.Long);case "l2f":return JValue.F(a.Long);case "l2d":return JValue.D(a.Long);
                    case "f2i":return JValue.I(ToI(a.Float));case "f2l":return JValue.L(ToL(a.Float));case "f2d":return JValue.D(a.Float);
                    case "d2i":return JValue.I(ToI(a.Double));case "d2l":return JValue.L(ToL(a.Double));case "d2f":return JValue.F((float)a.Double);
                    case "i2b":return JValue.I((sbyte)a.Int);case "i2c":return JValue.I((char)a.Int);case "i2s":return JValue.I((short)a.Int);
                }
                throw new PortGap("Unmapped conversion: "+op);
            }
        }
    }
}
