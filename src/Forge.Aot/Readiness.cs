using System;
using System.Collections.Generic;

namespace Planeswalker.ForgeAot
{
    public sealed class JPortReadiness
    {
        public readonly int MissingMethods,MissingFields,BootstrapAdapters;
        public readonly bool RuntimeVerified,InputsComplete,LoaderVerified;
        public JPortReadiness(int missingMethods,int missingFields,int bootstrapAdapters,bool runtimeVerified,bool inputsComplete,bool loaderVerified)
        {MissingMethods=missingMethods;MissingFields=missingFields;BootstrapAdapters=bootstrapAdapters;RuntimeVerified=runtimeVerified;InputsComplete=inputsComplete;LoaderVerified=loaderVerified;}
        public bool Ready=>MissingMethods==0&&MissingFields==0&&BootstrapAdapters==0&&RuntimeVerified&&InputsComplete&&LoaderVerified;
        public void RequireReady()
        {
            if(Ready)return;
            throw new PortGap("The complete Forge port cannot start a game: "+MissingMethods+" method references, "+MissingFields+" fields, "+BootstrapAdapters+" bootstrap adapters remain; runtime/input/loader verification is incomplete.");
        }
    }
}
