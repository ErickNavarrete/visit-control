namespace visit_control.Forms
{
    partial class scrRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(scrRecord));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbSearchValue = new System.Windows.Forms.TextBox();
            this.dtpF1 = new System.Windows.Forms.DateTimePicker();
            this.dtpF2 = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvVisit = new System.Windows.Forms.DataGridView();
            this.cmsPrint = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.printTicket = new System.Windows.Forms.ToolStripMenuItem();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisit)).BeginInit();
            this.cmsPrint.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSearchValue
            // 
            this.tbSearchValue.Location = new System.Drawing.Point(12, 72);
            this.tbSearchValue.Name = "tbSearchValue";
            this.tbSearchValue.Size = new System.Drawing.Size(321, 20);
            this.tbSearchValue.TabIndex = 0;
            // 
            // dtpF1
            // 
            this.dtpF1.CustomFormat = "dd/MMMM/yyyy";
            this.dtpF1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpF1.Location = new System.Drawing.Point(349, 72);
            this.dtpF1.Name = "dtpF1";
            this.dtpF1.Size = new System.Drawing.Size(137, 20);
            this.dtpF1.TabIndex = 1;
            // 
            // dtpF2
            // 
            this.dtpF2.CustomFormat = "dd/MMMM/yyyy";
            this.dtpF2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpF2.Location = new System.Drawing.Point(492, 72);
            this.dtpF2.Name = "dtpF2";
            this.dtpF2.Size = new System.Drawing.Size(137, 20);
            this.dtpF2.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(635, 72);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(22, 20);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvVisit
            // 
            this.dgvVisit.AllowUserToAddRows = false;
            this.dgvVisit.AllowUserToDeleteRows = false;
            this.dgvVisit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVisit.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvVisit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column7,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6});
            this.dgvVisit.ContextMenuStrip = this.cmsPrint;
            this.dgvVisit.Location = new System.Drawing.Point(12, 107);
            this.dgvVisit.Name = "dgvVisit";
            this.dgvVisit.ReadOnly = true;
            this.dgvVisit.Size = new System.Drawing.Size(776, 331);
            this.dgvVisit.TabIndex = 53;
            // 
            // cmsPrint
            // 
            this.cmsPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmsPrint.Depth = 0;
            this.cmsPrint.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printTicket});
            this.cmsPrint.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmsPrint.Name = "cmsPrint";
            this.cmsPrint.Size = new System.Drawing.Size(166, 26);
            // 
            // printTicket
            // 
            this.printTicket.Name = "printTicket";
            this.printTicket.Size = new System.Drawing.Size(165, 22);
            this.printTicket.Text = "IMPRIMIR TICKET";
            this.printTicket.Click += new System.EventHandler(this.printTicket_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "NOMBRE";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "APELLIDO PATERNO";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "APELLIDO MATERNO";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "DEPARTAMENTO";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            dataGridViewCellStyle1.Format = "G";
            dataGridViewCellStyle1.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column3.HeaderText = "FECHA DE ENTRADA";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "RAZÓN";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "OBSERVACIONES";
            this.Column6.MinimumWidth = 150;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // scrRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvVisit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtpF2);
            this.Controls.Add(this.dtpF1);
            this.Controls.Add(this.tbSearchValue);
            this.Name = "scrRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.scrRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisit)).EndInit();
            this.cmsPrint.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearchValue;
        private System.Windows.Forms.DateTimePicker dtpF1;
        private System.Windows.Forms.DateTimePicker dtpF2;
        internal System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvVisit;
        private MaterialSkin.Controls.MaterialContextMenuStrip cmsPrint;
        private System.Windows.Forms.ToolStripMenuItem printTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}