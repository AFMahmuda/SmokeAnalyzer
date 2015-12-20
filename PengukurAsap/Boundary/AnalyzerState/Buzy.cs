using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PengukurAsap.Boundary.AnalyzerState
{
    class Buzy : ActionState
    {
        public Buzy(SmokeAnalyzerManager smokeAnalyzerManager)
        {
            this.smokeAnalyzerManager = smokeAnalyzerManager;
        }

        public override void OpenConfig(ThreadStart thread)
        { }

        public override void OpenHistory(ThreadStart thread)
        { }

        public override void StartOrStop(State state)
        {

            smokeAnalyzerManager.StopAnalyze();
            state.actionState = new Idle(smokeAnalyzerManager);
        }

        internal override bool GetStatus()
        { return true; }

        internal override string GetText()
        {
            return "Stop!";
        }


    }
}
