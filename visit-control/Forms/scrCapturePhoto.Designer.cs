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
            this.photoInput = new System.Windows.Forms.PictureBox();
            this.btnCapturePhoto = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnCapture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.photoInput)).BeginInit();
            this.SuspendLayout();
            // 
            // photoInput
            // 
            this.photoInput.Location = new System.Drawing.Point(13, 79);
            this.photoInput.Name = "photoInput";
            this.photoInput.Size = new System.Drawing.Size(581, 388);
            this.photoInput.TabIndex = 0;
            this.photoInput.TabStop = false;
            // 
            // btnCapturePhoto
            // 
            this.btnCapturePhoto.AutoSize = true;
            this.btnCapturePhoto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCapturePhoto.Depth = 0;
            this.btnCapturePhoto.Location = new System.Drawing.Point(74, 382);
            this.btnCapturePhoto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCapturePhoto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCapturePhoto.Name = "btnCapturePhoto";
            this.btnCapturePhoto.Primary = false;
            this.btnCapturePhoto.Size = new System.Drawing.Size(98, 36);
            this.btnCapturePhoto.TabIndex = 3;
            this.btnCapturePhoto.Text = "Tomar foto";
            this.btnCapturePhoto.UseVisualStyleBackColor = true;
            this.btnCapturePhoto.Visible = false;
            this.btnCapturePhoto.Click += new System.EventHandler(this.BtnCapturePhoto_Click_1);
            // 
            // btnCapture
            // 
            this.btnCapture.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCapture.Location = new System.Drawing.Point(13, 486);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(581, 36);
            this.btnCapture.TabIndex = 4;
            this.btnCapture.Text = "TOMAR FOTO";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // scrCapturePhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 547);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.btnCapturePhoto);
            this.Controls.Add(this.photoInput);
            this.MaximizeBox = false;
            this.Name = "scrCapturePhoto";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capturar foto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScrCapturePhoto_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.photoInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox photoInput;
        private MaterialSkin.Controls.MaterialFlatButton btnCapturePhoto;
        private System.Windows.Forms.Button btnCapture;
    }
}