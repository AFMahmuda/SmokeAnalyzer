using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PengukurAsap
{
    public partial class UI_SmokeAnalyser : Form
    {
        public UI_SmokeAnalyser()
        {
            InitializeComponent();
        }

        public UI_Report UI_Report { get; set; }

        public UI_Config UI_Config { get; set; }

        internal SmokeAnalyzerManager SmokeAnalyzerManager { get; set; }


        private void startButton_Click(object sender, EventArgs e)
        {

        }

        private void configButton_Click(object sender, EventArgs e)
        {

        }

        private void historyButton_Click(object sender, EventArgs e)
        {

        }
    }
}
