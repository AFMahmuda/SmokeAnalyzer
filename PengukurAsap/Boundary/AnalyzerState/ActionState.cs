using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PengukurAsap.Boundary.AnalyzerState
{
    public abstract class ActionState
    {
        protected SmokeAnalyzerManager smokeAnalyzerManager;
        public abstract void StartOrStop(State state);
        public abstract void OpenConfig(ThreadStart thread);
        public abstract void OpenHistory(ThreadStart thread);
        internal abstract string GetText();
        internal abstract bool GetStatus();
    }
}
