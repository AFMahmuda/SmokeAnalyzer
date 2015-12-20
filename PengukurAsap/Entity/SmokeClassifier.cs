using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PengukurAsap.Entity
{
    class SmokeClassifier
    {
        int classNumber = 5;

        internal int GetType(double averageColor)
        {
            int div = 255 / classNumber;
            int type = (int)Math.Round(averageColor / div);

            return type;
        }
    }
}
