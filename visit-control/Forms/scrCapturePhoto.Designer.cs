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
            this.btnCapturePhoto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCapturePhoto.Depth = 0;
            this.btnCapturePhoto.Location = new System.Drawing.Point(61, 498);
            this.btnCapturePhoto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCapturePhoto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCapturePhoto.Name = "btnCapturePhoto";
            this.btnCapturePhoto.Primary = false;
            this.btnCapturePhoto.Size = new System.Drawing.Size(435, 62);
            this.btnCapturePhoto.TabIndex = 3;
            this.btnCapturePhoto.Text = "Tomar foto";
            this.btnCapturePhoto.UseVisualStyleBackColor = true;
            this.btnCapturePhoto.Click += new System.EventHandler(this.BtnCapturePhoto_Click_1);
            // 
            // scrCapturePhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 604);
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

        }

        #endregion

        private System.Windows.Forms.PictureBox photoInput;
        private MaterialSkin.Controls.MaterialFlatButton btnCapturePhoto;
    }
}