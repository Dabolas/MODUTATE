using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Planeswalker.ForgeAot
{
    public sealed partial class JRuntime
    {
        private sealed class RandomState {internal long Seed;}
        private readonly Dictionary<int,RandomState> randomStates=new Dictionary<int,RandomState>();
        private ulong? ambientSeed;
        private readonly Dictionary<int,JValue> threadRandoms=new Dictionary<int,JValue>();
        public void SetDeterministicAmbientSeed(long seed){if(threadRandoms.Count!=0)throw new InvalidOperationException("Ambient RNG already in use");ambientSeed=unchecked((ulong)seed);}
        private long AmbientRandomSeed()
        {
            if(ambientSeed.HasValue){ulong z=ambientSeed.Value+0x9E3779B97F4A7C15UL;ambientSeed=z;z=(z^(z>>30))*0xBF58476D1CE4E5B9UL;z=(z^(z>>27))*0x94D049BB133111EBUL;return unchecked((long)(z^(z>>31)));}
            var bytes=new byte[8];using(var rng=RandomNumberGenerator.Create())rng.GetBytes(bytes);return BitConverter.ToInt64(bytes,0);
        }
        private void InstallRandom()
        {
            const string type="java/util/Random";NativeClass(type);
            foreach(string descriptor in new[]{"()V","(J)V"})StandardBind(type,"<init>",descriptor,(r,s,a)=>
            {long seed=a.Length!=0?a[0].Long:r.AmbientRandomSeed();r.randomStates[r.NonNull(s).Identity]=new RandomState{Seed=(seed^0x5deece66dL)&((1L<<48)-1)};return Done();});
            StandardBind(type,"setSeed","(J)V",(r,s,a)=>{r.randomStates[r.NonNull(s).Identity].Seed=(a[0].Long^0x5deece66dL)&((1L<<48)-1);return Done();});
            StandardBind(type,"next","(I)I",(r,s,a)=>{int bits=a[0].Int;if(bits<1||bits>32)throw new PortGap("Random.next bits outside contract");var state=r.randomStates[r.NonNull(s).Identity];lock(state){state.Seed=unchecked(state.Seed*0x5deece66dL+0xbL)&((1L<<48)-1);return Done(JValue.I(unchecked((int)(state.Seed>>(48-bits)))));}});
            foreach(var operation in new[]{("nextInt","()I"),("nextInt","(I)I"),("nextBoolean","()Z"),("nextLong","()J"),("nextFloat","()F"),("nextDouble","()D")})StandardBind(type,operation.Item1,operation.Item2,(r,s,a)=>r.RandomDraw(s,operation.Item1,a));
            const string local="java/util/concurrent/ThreadLocalRandom";NativeClass(local,type);
            StandardBind(local,"current","()L"+local+";",(r,s,a)=>{int thread=Environment.CurrentManagedThreadId;if(!r.threadRandoms.TryGetValue(thread,out var value)){value=JValue.R(r.Allocate(local));r.randomStates[value.Reference!.Identity]=new RandomState{Seed=(r.AmbientRandomSeed()^0x5deece66dL)&((1L<<48)-1)};r.threadRandoms.Add(thread,value);}return Done(value);});
            StandardBind(local,"setSeed","(J)V",(r,s,a)=>throw r.Fault("java/lang/UnsupportedOperationException"));
        }
        private JHostResult RandomDraw(JValue receiver,string operation,JValue[] arguments)
        {
            int bound=arguments.Length==0?0:arguments[0].Int;if(arguments.Length!=0&&bound<=0)throw Fault("java/lang/IllegalArgumentException","bound must be positive");
            int bits=operation=="nextBoolean"?1:operation=="nextFloat"?24:operation=="nextDouble"?26:arguments.Length!=0?31:32;int first=0;
            string returns=operation=="nextLong"?"J":operation=="nextFloat"?"F":operation=="nextDouble"?"D":"I";
            var method=new JMethod(-104,"java/lang/Object","<random-draw>","()"+returns,8,0,3,Array.Empty<JHandler>(),(r,f)=>
            {
                if(!r.Tick())return JStep.Yield;
                if(f.Pc==0){f.Push(receiver);f.Push(JValue.I(bits));f.Pc=10;}
                if(f.Pc==10)return r.Call(f,"java/util/Random","next","(I)I","invokevirtual",1);
                if(f.Pc==1)
                {
                    int value=f.Pop().Int;
                    if(operation=="nextBoolean")return JStep.Return(JValue.I(value!=0?1:0));
                    if(operation=="nextFloat")return JStep.Return(JValue.F(value/(float)(1<<24)));
                    if(operation=="nextInt")
                    {if(arguments.Length==0)return JStep.Return(JValue.I(value));if((bound&-bound)==bound)return JStep.Return(JValue.I((int)((bound*(long)value)>>31)));int result=value%bound;if(unchecked(value-result+(bound-1))<0){f.Pc=0;return JStep.Continue;}return JStep.Return(JValue.I(result));}
                    first=value;f.Push(receiver);f.Push(JValue.I(operation=="nextDouble"?27:32));f.Pc=20;
                }
                if(f.Pc==20)return r.Call(f,"java/util/Random","next","(I)I","invokevirtual",2);
                int second=f.Pop().Int;return JStep.Return(operation=="nextLong"?JValue.L(unchecked(((long)first<<32)+second)):JValue.D((((long)first<<27)+second)/(double)(1L<<53)));
            });return JHostResult.Schedule(new JFrame(method,default,Array.Empty<JValue>()));
        }
    }
}
