using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;

//Camera
using OpenCvSharp;
using OpenCvSharp.Extensions;


namespace visit_control.Camera
{
    public class CameraController
    {
        VideoCapture capture;
        Mat frame;
        Bitmap image;
        private Thread camera;
        bool isCameraRunning;
        PictureBox photoInput;

        public CameraController(PictureBox photoInput, bool isCameraRunning)
        {
            this.photoInput = photoInput;
            this.isCameraRunning = isCameraRunning;
        }

        public void CaptureCamera()
        {
            camera = new Thread(new ThreadStart(CaptureCameraCallback));
            camera.Start();
        }

        public void stopCamera()
        {
            try
            {
                capture.Release();
                capture.Dispose();
            }
            catch (Exception e)
            {

            }
        }

        private void CaptureCameraCallback()
        {
            frame = new Mat();
            capture = new VideoCapture(0);
            capture.Open(0);

            if (capture.IsOpened())
            {
                while (isCameraRunning)
                {
                    capture.Read(frame);
                    image = BitmapConverter.ToBitmap(frame);

                    if (photoInput.BackgroundImage != null)
                    {
                        photoInput.BackgroundImage.Dispose();
                    }

                    photoInput.BackgroundImage = image;
                }
            }
        }

        public void setIsCameraRunning(bool isCameraRunning)
        {
            this.isCameraRunning = isCameraRunning;
        }
    }
}
