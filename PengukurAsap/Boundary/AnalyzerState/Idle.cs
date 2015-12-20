using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PengukurAsap.Boundary.AnalyzerState
{
    class Idle : ActionState
    {
        public Idle(SmokeAnalyzerManager smokeAnalyzerManager)
        {
            this.smokeAnalyzerManager = smokeAnalyzerManager;
        }

 

        public override void OpenConfig(ThreadStart thread)
        {
            new Thread(new ThreadStart(thread)).Start();
        }

        public override void OpenHistory(ThreadStart thread)
        {
            new Thread(new ThreadStart(thread)).Start();
        }

        public override void StartOrStop(State state)
        {
            smokeAnalyzerManager.StartAnalyze();
            state.actionState = new Buzy(smokeAnalyzerManager);
        }

        internal override bool GetStatus()
        {
            return false;
        }

        internal override string GetText()
        {
            return "Start!";
        }
    }
}
