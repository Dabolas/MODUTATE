using System;
using System.Collections.Generic;

namespace Planeswalker.ForgeAot
{
    public enum JKind : byte { Empty, Int, Long, Float, Double, Reference, ReturnAddress }
    public readonly struct JValue
    {
        public readonly JKind Kind;
        public readonly long Bits;
        public readonly JObject? Reference;
        private JValue(JKind kind,long bits=0,JObject? reference=null){Kind=kind;Bits=bits;Reference=reference;}
        public int Int=>unchecked((int)Bits);
        public long Long=>Bits;
        public float Float=>BitConverter.Int32BitsToSingle(Int);
        public double Double=>BitConverter.Int64BitsToDouble(Bits);
        public bool Wide=>Kind==JKind.Long||Kind==JKind.Double;
        public static JValue I(int value)=>new JValue(JKind.Int,value);
        public static JValue L(long value)=>new JValue(JKind.Long,value);
        public static JValue F(float value)=>new JValue(JKind.Float,BitConverter.SingleToInt32Bits(value));
        public static JValue D(double value)=>new JValue(JKind.Double,BitConverter.DoubleToInt64Bits(value));
        public static JValue R(JObject? value)=>new JValue(JKind.Reference,reference:value);
        public static JValue Address(int pc)=>new JValue(JKind.ReturnAddress,pc);
        public static JValue Default(string descriptor)=>descriptor[0]=='J'?L(0):descriptor[0]=='F'?F(0):descriptor[0]=='D'?D(0):descriptor[0]=='L'||descriptor[0]=='['?R(null):I(0);
    }
    public class JObject
    {
        public string ClassName { get; }
        public int Identity { get; }
        internal readonly Dictionary<string,JValue> Fields=new Dictionary<string,JValue>(StringComparer.Ordinal);
        internal string? Text;
        internal string? RepresentedClass;
        internal JRuleFactory? Factory;
        internal JValue? Boxed;
        internal JLambdaValue? Lambda;
        internal bool HostStorage;
        internal object? Payload;
        internal JObject(string name,int identity){ClassName=name;Identity=identity;}
    }
    public sealed class JArray : JObject
    {
        public JValue[] Items { get; }
        public string Component { get; }
        internal JArray(string component,int length,int identity):base("["+component,identity)
        {
            Component=component;Items=new JValue[length];
            var empty=JValue.Default(component);for(int i=0;i<length;i++)Items[i]=empty;
        }
    }
    public sealed class JavaFault : Exception
    {
        public JObject Value { get; }
        public JavaFault(JObject value,string message=""):base(message){Value=value;}
        public override string ToString()=>Value.ClassName+": "+base.ToString();
    }
    // Unimplemented host/runtime operations escape Java handlers instead of becoming a rule no-op.
    public sealed class PortGap : Exception { public PortGap(string message):base(message){} }
}
