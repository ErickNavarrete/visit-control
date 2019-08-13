using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using OpenCvSharp;
using OpenCvSharp.Extensions;
namespace visit_control.Controllers
{

    public class Camera
    {

        private camera()
        {
            Console.WriteLine("Iniciando camara");
        }

        VideoCapture videoCapture;
        Mat frame;
        Bitmap image;
        private Thread camera;
        bool isCameraRunning;

        private void CaptureCamera()
        {
            camera = new Thread(new ThreadStart(CaptureCameraCallback));
            camera.Start();
        }

        private void CaptureCameraCallback()
        {
            frame = new Mat();
            image = new VideoCapture(0);
            camera.Open(0);
        }
    }
}
