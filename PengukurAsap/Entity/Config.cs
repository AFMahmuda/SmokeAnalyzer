using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PengukurAsap
{
    [Serializable]
    class Config
    {
        private int time;
        private int num;
        public int Time { get { return time; } }
        public int Num { get { return num; } }

        public Config(int time, int num)
        {
            this.time = time;
            this.num = num;
        }
    }
}
