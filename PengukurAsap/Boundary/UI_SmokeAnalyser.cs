using PengukurAsap.Boundary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace PengukurAsap
{
    public partial class UI_SmokeAnalyser : Form
    {
        SmokeAnalyzerManager smokeAnalyzerManager;
        I_Camera camera;
        bool isBusy = false;
        public bool IsBusy
        {
            set
            {
                isBusy = value;
                if (!value) { camera.Start(); startButton.Text = "Start Analize"; }
                else { camera.Stop(); startButton.Text = "Stop Analize"; }
            }
        }

        internal void ShowReport(Report report)
        {
            MessageBox.Show("Success");

            //TO DO add implementation

        }
        public UI_SmokeAnalyser()
        {
            InitializeComponent();
            camera = new I_Camera();
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
            if (!isBusy)
            {
                IsBusy = true;
                smokeAnalyzerManager = new SmokeAnalyzerManager(this);
                smokeAnalyzerManager.StartAnalyze();
            }
            else
            {
                IsBusy = false;
                smokeAnalyzerManager.StopAnalyze();
            }

        }

        private void configButton_Click(object sender, EventArgs e)
        {
            if (!isBusy)
                new Thread(new ThreadStart(RunUI_Config)).Start();
        }

        private void RunUI_Config()
        {
            Application.Run(new UI_Config());
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            if (!isBusy)
                new Thread(new ThreadStart(RunUI_History)).Start();
        }

        private void RunUI_History()
        {

            Application.Run(new UI_Report());
        }
    }
}
