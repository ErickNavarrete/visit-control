namespace visit_control.Forms
{
    partial class scrCapturePhoto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStartCamera = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnCapturePhoto = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 275);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnStartCamera
            // 
            this.btnStartCamera.AutoSize = true;
            this.btnStartCamera.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStartCamera.Depth = 0;
            this.btnStartCamera.Location = new System.Drawing.Point(48, 390);
            this.btnStartCamera.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStartCamera.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStartCamera.Name = "btnStartCamera";
            this.btnStartCamera.Primary = false;
            this.btnStartCamera.Size = new System.Drawing.Size(117, 36);
            this.btnStartCamera.TabIndex = 1;
            this.btnStartCamera.Text = "Inicar camara";
            this.btnStartCamera.UseVisualStyleBackColor = true;
            // 
            // btnCapturePhoto
            // 
            this.btnCapturePhoto.AutoSize = true;
            this.btnCapturePhoto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCapturePhoto.Depth = 0;
            this.btnCapturePhoto.Location = new System.Drawing.Point(340, 390);
            this.btnCapturePhoto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCapturePhoto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCapturePhoto.Name = "btnCapturePhoto";
            this.btnCapturePhoto.Primary = false;
            this.btnCapturePhoto.Size = new System.Drawing.Size(98, 36);
            this.btnCapturePhoto.TabIndex = 2;
            this.btnCapturePhoto.Text = "Tomar foto";
            this.btnCapturePhoto.UseVisualStyleBackColor = true;
            // 
            // scrCapturePhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 459);
            this.Controls.Add(this.btnCapturePhoto);
            this.Controls.Add(this.btnStartCamera);
            this.Controls.Add(this.pictureBox1);
            this.Name = "scrCapturePhoto";
            this.Text = "Capturar foto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialFlatButton btnStartCamera;
        private MaterialSkin.Controls.MaterialFlatButton btnCapturePhoto;
    }
}