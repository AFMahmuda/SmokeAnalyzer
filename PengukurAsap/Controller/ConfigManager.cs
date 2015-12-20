using PengukurAsap.Boundary;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PengukurAsap
{
    class ConfigManager
    {

        public ConfigManager()
        {
            LoadConfig();
        }

        Config config;
        public Config Config { get { return config; } }

        void LoadConfig()
        {
            config = I_FileManager.LoadConfig();
        }

        public void SaveConfig(int time, int num)
        {
            config = new Config(time, num);
            I_FileManager.SaveConfig(config);
        }

        internal Config Default
        { get { return new Config(1, 15); } }
    }
}
