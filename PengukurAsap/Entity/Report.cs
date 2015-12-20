using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PengukurAsap.Entity;

namespace PengukurAsap
{
    [Serializable]
    public class Report
    {
        string filename;
        public string Filename { get { return filename; } }

        private List<Smoke> smokes;
        public List<Smoke> Smokes { get { return smokes; } }

        int type;
        public int Type { get { return type; } }

        long tick;
        public DateTime dateTime { get { return new DateTime(tick); } }

        public Report(int averageType, List<Smoke> smokes)
        {
            DateTime now = DateTime.Now;
            tick = now.Ticks;
            filename = "Report " + now.ToString("yy-MM-dd HH-mm") + ".rpt";
            this.type = averageType;
            this.smokes = smokes;
        }
    }
}
