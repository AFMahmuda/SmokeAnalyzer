using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PengukurAsap.Entity
{
    [Serializable]
    public class Smoke
    {
        private byte[] rawImage;
        private int smokeType;
        public int Type { get { return smokeType; } }

        public Bitmap Bitmap
        {
            get
            {
                using (var ms = new MemoryStream(rawImage))
                { return new Bitmap(ms); }
            }
        }

        public Smoke(Bitmap bitmap, int smokeType)
        {
            ImageConverter converter = new ImageConverter();          
            rawImage = (byte[])converter.ConvertTo(bitmap, typeof(byte[]));
            this.smokeType = smokeType;
        }
    }
}
