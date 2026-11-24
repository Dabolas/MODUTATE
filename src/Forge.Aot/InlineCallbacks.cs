using System;
using System.Linq;
using System.Collections.Generic;
namespace Planeswalker.ForgeAot
{
    public sealed partial class JRuntime
    {
        private int inlineDepth;
        private readonly Dictionary<(string,string,string,string),JMethod> inlineEntries=new();
        public bool CanPauseForInput => inlineDepth == 0;
        public int SynchronousInstructionLimit {get;set;}=1000000;
        // equals/compareTo are synchronous Java contracts. Execute their original generated
        // methods in a bounded nested frame scope. The outer frame must never be stepped or
        // unwound by this scope, and user interaction inside these callbacks is unsupported.
        public JValue InvokeSynchronous(string owner,string name,string descriptor,JValue receiver,JValue[] arguments,string kind="invokevirtual")=>InlineCall(owner,name,descriptor,receiver,arguments,kind);
        public JValue InvokeSynchronousWithBudget(string owner,string name,string descriptor,JValue receiver,JValue[] arguments,int instructionBudget,string kind="invokevirtual")=>InlineCall(owner,name,descriptor,receiver,arguments,kind,instructionBudget);
        private JValue InlineCall(string owner,string name,string descriptor,JValue receiver,JValue[] arguments,string kind="invokevirtual",int? callBudget=null)
        {
            if(inlineDepth>=128)throw Fault("java/lang/StackOverflowError");
            int boundary=frames.Count,savedInstructions=instructions;var savedState=State;var savedResult=Result;int used=0;
            var key=(owner,name,descriptor,kind);
            if(!inlineEntries.TryGetValue(key,out var entry)){
                string returns=descriptor.Substring(descriptor.IndexOf(')')+1);
                entry=new JMethod(-106,"java/lang/Object","<native-synchronous-callback>","()"+returns,8,0,arguments.Length+2,Array.Empty<JHandler>(),(r,f)=>
                {if(!r.Tick())return JStep.Yield;if(f.Pc==1)return returns=="V"?JStep.ReturnVoid:JStep.Return(f.Pop());return r.Call(f,owner,name,descriptor,kind,1);});
                inlineEntries.Add(key,entry);
            }
            var entryFrame=new JFrame(entry,default,Array.Empty<JValue>());
            if(kind!="invokestatic")entryFrame.Push(receiver);
            foreach(var value in arguments)entryFrame.Push(value);
            entryFrame.Pc=2;
            frames.Add(entryFrame);inlineDepth++;
            try
            {
                State=JRunState.Running;
                int budget=callBudget??SynchronousInstructionLimit;
                if(budget<=0)throw new ArgumentOutOfRangeException(nameof(SynchronousInstructionLimit));
                var state=RunScoped(budget,boundary);used=budget-instructions;
                if(state==JRunState.Waiting)throw new PortGap("Synchronous Java callback attempted host interaction: "+owner+"."+name);
                if(frames.Count!=boundary){Trace?.Invoke("INSTRUCTION LIMIT\nJAVA STACK\n"+string.Join("\n",frames.AsEnumerable().Reverse().Select(f=>f.Method.Key+" pc="+f.LastPc)));throw new PortGap("Synchronous Java callback exceeded instruction limit: "+owner+"."+name);}
                return Result;
            }
            finally{inlineDepth--;instructions=savedInstructions-used;State=savedState;Result=savedResult;}
        }
        private void InlineVoid(string owner,string name,string descriptor,JValue receiver,JValue[] arguments)=>InlineCall(owner,name,descriptor,receiver,arguments);
    }
}
