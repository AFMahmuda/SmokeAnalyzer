using Emgu.CV;
using Emgu.CV.Structure;
using PengukurAsap.Boundary;
using PengukurAsap.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Threading;


namespace PengukurAsap
{
    class SmokeAnalyzerManager
    {
        I_Camera camera;
        Config config;
        int photoTaken;
        int period;
        UI_SmokeAnalyser uI_SmokeAnalyser;
        SmokeAnalyzer smokeAnalyzer;
        DispatcherTimer timer;
        List<Smoke> smokes = new List<Smoke>();

        public SmokeAnalyzerManager(UI_SmokeAnalyser uI_SmokeAnalyser)
        {
            this.uI_SmokeAnalyser = uI_SmokeAnalyser;
            smokeAnalyzer = new SmokeAnalyzer();
            camera = new I_Camera();
            period = 0;
            photoTaken = 0;
        }



        public void StartAnalyze()
        {
            config = new ConfigManager().Config;

            camera.Start();
            period = config.Time * 60000 / config.Num;
            uI_SmokeAnalyser.setLabel1("image taken : " +
                            photoTaken.ToString() + "/ " + config.Num +
                            ", taking image per :" + (period / 1000.0) + " s"); DateTime start = DateTime.Now;

            timer = new DispatcherTimer();
            timer.Tick += Analyze;
            timer.Interval = new TimeSpan(0, 0, 0, 0, period);
            timer.Start();

        }

        public void StopAnalyze()
        {
            timer.Stop();
            camera.Stop();

            Report report = smokeAnalyzer.AnalyzeAll(smokes);
            new ReportManager().SaveReport(report);
            uI_SmokeAnalyser.ShowReport(report);
            uI_SmokeAnalyser.IsBusy = false;
        }

        private void Analyze(object sender, EventArgs e)
        {
            photoTaken++;
            Image<Gray, byte> image = camera.GetImage();
            uI_SmokeAnalyser.setImage(image);
            uI_SmokeAnalyser.setLabel1("image taken : " +
                photoTaken.ToString() + "/ " + config.Num +
                ", taking image per :" + (period / 1000.0) + " s");

            Smoke newSmoke = smokeAnalyzer.AnalizeImage(image);
            smokes.Add(newSmoke);
            if (photoTaken == config.Num)
                StopAnalyze();

        }
    }
}
