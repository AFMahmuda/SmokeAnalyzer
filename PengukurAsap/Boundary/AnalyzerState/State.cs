using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PengukurAsap.Boundary.AnalyzerState
{
    public class State
    {
        public State(UI_SmokeAnalyser uI_SmokeAnalyzer, SmokeAnalyzerManager smokeAnalyzerManager)
        {
            this.uI_SmokeAnalyzer = uI_SmokeAnalyzer;
            this.smokeAnalyzerManager = smokeAnalyzerManager;
            actionState = new Idle(smokeAnalyzerManager);
        }
        UI_SmokeAnalyser uI_SmokeAnalyzer;
        public ActionState actionState;
        SmokeAnalyzerManager smokeAnalyzerManager;

        public void StartOrStop()
        {
            actionState.StartOrStop(this);

            string text = actionState.GetText();
            bool status = actionState.GetStatus();
            uI_SmokeAnalyzer.SetButtonText(text);
        }

        public void OpenHistory(ThreadStart thread)
        {
            actionState.OpenHistory(thread);
        }

        public void OpenConfig(ThreadStart thread)
        {
            actionState.OpenConfig(thread);
        }

    }
}
