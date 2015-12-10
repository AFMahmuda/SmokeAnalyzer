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
        }

        internal ConfigManager ConfigManager
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}
