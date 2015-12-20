using Emgu.CV;
using Emgu.CV.Structure;
using PengukurAsap.Boundary;
using PengukurAsap.Boundary.AnalyzerState;
using System;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Threading;

namespace PengukurAsap
{
    public partial class UI_SmokeAnalyser : Form
    {
        SmokeAnalyzerManager smokeAnalyzerManager;
        I_Camera camera;
        DateTime startTime;
        public State State;

        bool isBusy = false;
        public bool IsBusy
        {
            set
            {
                isBusy = value;
                if (!value) { camera.Start(); }
                else { camera.Stop(); startTime = DateTime.Now; }
            }
        }


        internal void ShowReport(Report report)
        {
            simpleReportLabel.Text = "Last Session : \n" +
                                    "Time \t: " + report.dateTime + "\n" +
                                    "Duration \t: " + (DateTime.Now - startTime).ToString() + "\n" +
                                    "Image Count \t: " + report.Smokes.Count + "\n" +
                                    "Result :\n" +
                                    "Average Type\t: " + report.Type;
        }
        public UI_SmokeAnalyser()
        {
            InitializeComponent();
            camera = new I_Camera();
            smokeAnalyzerManager = new SmokeAnalyzerManager(this);
            State = new State(this, smokeAnalyzerManager);
            IsBusy = false;

            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += ShowImage;
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            timer.Start();
        }

        private void ShowImage(object sender, EventArgs e)
        {
            if (!isBusy)
                imageBox.Image = camera.GetImage();
        }


        private void startButton_Click(object sender, EventArgs e)
        {
            State.StartOrStop();
        }

        private void configButton_Click(object sender, EventArgs e)
        {
            State.OpenConfig(RunUI_Config);
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            State.OpenHistory(RunUI_History);
        }

        private void RunUI_Config()
        {
            Application.Run(new UI_Config());
        }

        private void RunUI_History()
        {
            Application.Run(new UI_Report());
        }

        internal void SetButtonText(string text)
        {
            startButton.Text = text;
        }


        internal void setImage(Image<Gray, byte> image)
        {
            imageBox.Image = image;
        }

        internal void setStatusLabel(string line)
        {
            status.Text = line;
        }


    }
}
