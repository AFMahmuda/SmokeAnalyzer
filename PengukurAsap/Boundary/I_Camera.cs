using Emgu.CV;
using Emgu.CV.Structure;

namespace PengukurAsap.Boundary
{
    class I_Camera
    {

        Capture camera;
        public I_Camera()
        {

            camera = new Capture(1);
            if (camera.Height == 0)
                camera = new Capture();

        }

        public void Start()
        {
            camera.Start();
        }

        public void Stop()
        {
            camera.Stop();
        }

        public Image<Gray, byte> GetImage()
        {
            return camera.QueryFrame().ToImage<Gray, byte>();
        }


    }
}
