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

namespace visit_control.Forms
{
    public partial class scrCapturePhoto : MaterialForm
    {
       
        private CameraController controllerCamera;
        bool isCameraRunning = false;

        public scrCapturePhoto()
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

            controllerCamera = new CameraController(photoInput, isCameraRunning);
        }

        private void BtnStartCamera_Click(object sender, EventArgs e)
        {
            if(btnStartCamera.Text.Equals("INICIAR CAMARA"))
            {
                controllerCamera.CaptureCamera();
                btnStartCamera.Text = "DETENER CAMARA";
                isCameraRunning = true;
            }
            else
            {
                controllerCamera.CaptureCamera();
                btnStartCamera.Text = "INICIAR CAMARA";
                isCameraRunning = false;
            }

        }

        private void BtnCapturePhoto_Click(object sender, EventArgs e)
        {
            if (isCameraRunning)
            {
                Bitmap snapshot = new Bitmap(photoInput.BackgroundImage);
            }
            else
            {
                Console.WriteLine("Cannot take picture if the camera isn't capturing image!");
            }
        }
    }
}
