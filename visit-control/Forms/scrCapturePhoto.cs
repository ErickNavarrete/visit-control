using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using visit_control.Camera;
using System.Drawing.Imaging;
using System.IO;

namespace visit_control.Forms
{
    public partial class scrCapturePhoto : MaterialForm
    {
       
        private CameraController controllerCamera;
        bool isCameraRunning = false;
        private PictureBox picture;

        public scrCapturePhoto(PictureBox picture)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red900, //Color dialog 
                Primary.Red900, //Color control buttons
                Primary.Blue400,
                Accent.LightBlue200,
                TextShade.WHITE
            );

            this.picture = picture;
            controllerCamera = new CameraController(photoInput, isCameraRunning);
            controllerCamera.CaptureCamera();
            isCameraRunning = true;
            controllerCamera.setIsCameraRunning(isCameraRunning);
        }
        

        private void BtnCapturePhoto_Click_1(object sender, EventArgs e)
        {
            if (isCameraRunning)
            {
                if (photoInput.BackgroundImage != null)
                {
                    Bitmap bitmap = new Bitmap(photoInput.BackgroundImage);
                    MemoryStream stream = new MemoryStream();
                    bitmap.Save(stream, ImageFormat.Jpeg);
                    picture.BackgroundImage = Image.FromStream(stream);
                    controllerCamera.setIsCameraRunning(false);
                    controllerCamera.stopCamera();
                    this.Close();
                }
                else
                {
                    Console.WriteLine("No contiene imagen");
                }
            }
            else
            {
                Console.WriteLine("Cannot take picture if the camera isn't capturing image!");
            }
        }

        private void ScrCapturePhoto_FormClosing(object sender, FormClosingEventArgs e)
        {
            controllerCamera.stopCamera();
            isCameraRunning = false;
            controllerCamera.setIsCameraRunning(isCameraRunning);
            Console.WriteLine("CAMARA DETENIDA");
        }
    }
}
