﻿namespace visit_control
{
    partial class scrLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(scrLogin));
            this.btLogin = new MaterialSkin.Controls.MaterialFlatButton();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.pbLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // btLogin
            // 
            this.btLogin.AutoSize = true;
            this.btLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btLogin.Depth = 0;
            this.btLogin.Location = new System.Drawing.Point(142, 301);
            this.btLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btLogin.Name = "btLogin";
            this.btLogin.Primary = false;
            this.btLogin.Size = new System.Drawing.Size(64, 36);
            this.btLogin.TabIndex = 5;
            this.btLogin.Text = "Entrar";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPassword.Location = new System.Drawing.Point(86, 272);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(186, 20);
            this.tbPassword.TabIndex = 4;
            // 
            // pbLogin
            // 
            this.pbLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbLogin.Image = ((System.Drawing.Image)(resources.GetObject("pbLogin.Image")));
            this.pbLogin.Location = new System.Drawing.Point(86, 93);
            this.pbLogin.Name = "pbLogin";
            this.pbLogin.Size = new System.Drawing.Size(186, 169);
            this.pbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogin.TabIndex = 6;
            this.pbLogin.TabStop = false;
            // 
            // scrLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 354);
            this.Controls.Add(this.pbLogin);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.tbPassword);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "scrLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrar al sistema";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton btLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.PictureBox pbLogin;
    }
}
