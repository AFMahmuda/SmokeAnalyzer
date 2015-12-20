using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;

namespace PengukurAsap.Entity
{
    class SmokeAnalyzer
    {
        SmokeClassifier smokeClassifier;

        public SmokeAnalyzer()
        {
            smokeClassifier = new SmokeClassifier();
        }

        internal Smoke AnalizeImage(Image<Gray, byte> image)
        {
            double averageColor = image.GetAverage().Intensity;
            int smokeType = smokeClassifier.GetType(averageColor);
            image = image.Resize(.25, Emgu.CV.CvEnum.Inter.Linear);
            Smoke newSMoke = new Smoke(image.ToBitmap(), smokeType);
            return newSMoke;

        }

        internal Report AnalyzeAll(List<Smoke> smokes)
        {

            int averageType = 0;
            foreach (Smoke smoke in smokes)
            {
                averageType += smoke.Type;
            }
            averageType /= smokes.Count;
            return new Report(averageType, smokes);
        }
    }
}
