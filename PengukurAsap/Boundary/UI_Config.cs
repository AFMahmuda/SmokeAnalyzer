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
    public partial class UI_Config : Form
    {
        public UI_Config()
        {
            InitializeComponent();
            ConfigManager = new ConfigManager();
            Config curr = ConfigManager.Config;
            numericUpDown_time.Value = curr.Time;
            numericUpDown_num.Value = curr.Num;
        }

        ConfigManager ConfigManager;

        private void buttonOK_Click(object sender, EventArgs e)
        {
            int time = (int)numericUpDown_time.Value;
            int num = (int)numericUpDown_num.Value;
            ConfigManager.SaveConfig(time, num);
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonDefault_Click(object sender, EventArgs e)
        {
            Config myConfig = ConfigManager.Default;
            numericUpDown_time.Value = ConfigManager.Default.Time;
            numericUpDown_num.Value = ConfigManager.Default.Num;

        }
    }
}
