
namespace GestPark
{
    partial class FormModifierEntretien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModifierEntretien));
            this.TxtMontantVdgeMod = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.RtxtNotesVdgeModi = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CbxGarageVdgeModi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCodeVdgeModi = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconBtUploadDoc = new FontAwesome.Sharp.IconButton();
            this.iconBtnSavedEntretien = new FontAwesome.Sharp.IconButton();
            this.TxtStationVdgeMod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DatePickerCreateVdgeMod = new System.Windows.Forms.DateTimePicker();
            this.txtVehiculeVdge = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtMontantVdgeMod
            // 
            this.TxtMontantVdgeMod.Location = new System.Drawing.Point(101, 166);
            this.TxtMontantVdgeMod.Name = "TxtMontantVdgeMod";
            this.TxtMontantVdgeMod.Size = new System.Drawing.Size(229, 26);
            this.TxtMontantVdgeMod.TabIndex = 34;
            this.TxtMontantVdgeMod.Text = "0.0";
            this.TxtMontantVdgeMod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(18, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 19);
            this.label9.TabIndex = 33;
            this.label9.Text = "Coût *";
            // 
            // RtxtNotesVdgeModi
            // 
            this.RtxtNotesVdgeModi.Location = new System.Drawing.Point(359, 96);
            this.RtxtNotesVdgeModi.Name = "RtxtNotesVdgeModi";
            this.RtxtNotesVdgeModi.Size = new System.Drawing.Size(267, 59);
            this.RtxtNotesVdgeModi.TabIndex = 30;
            this.RtxtNotesVdgeModi.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(18, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "Voiture *";
            // 
            // CbxGarageVdgeModi
            // 
            this.CbxGarageVdgeModi.FormattingEnabled = true;
            this.CbxGarageVdgeModi.Location = new System.Drawing.Point(101, 225);
            this.CbxGarageVdgeModi.Name = "CbxGarageVdgeModi";
            this.CbxGarageVdgeModi.Size = new System.Drawing.Size(229, 27);
            this.CbxGarageVdgeModi.TabIndex = 25;
            this.CbxGarageVdgeModi.SelectedIndexChanged += new System.EventHandler(this.CbxGarageVdgeModi_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(18, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Garage *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Code";
            // 
            // TxtCodeVdgeModi
            // 
            this.TxtCodeVdgeModi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.TxtCodeVdgeModi.Location = new System.Drawing.Point(101, 54);
            this.TxtCodeVdgeModi.Name = "TxtCodeVdgeModi";
            this.TxtCodeVdgeModi.ReadOnly = true;
            this.TxtCodeVdgeModi.Size = new System.Drawing.Size(117, 26);
            this.TxtCodeVdgeModi.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.iconBtUploadDoc);
            this.panel1.Controls.Add(this.iconBtnSavedEntretien);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 27);
            this.panel1.TabIndex = 19;
            // 
            // iconBtUploadDoc
            // 
            this.iconBtUploadDoc.BackColor = System.Drawing.Color.White;
            this.iconBtUploadDoc.ForeColor = System.Drawing.Color.YellowGreen;
            this.iconBtUploadDoc.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.iconBtUploadDoc.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(13)))));
            this.iconBtUploadDoc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtUploadDoc.IconSize = 20;
            this.iconBtUploadDoc.Location = new System.Drawing.Point(34, -2);
            this.iconBtUploadDoc.Name = "iconBtUploadDoc";
            this.iconBtUploadDoc.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.iconBtUploadDoc.Size = new System.Drawing.Size(29, 26);
            this.iconBtUploadDoc.TabIndex = 3;
            this.iconBtUploadDoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtUploadDoc.UseVisualStyleBackColor = false;
            this.iconBtUploadDoc.MouseHover += new System.EventHandler(this.iconBtUploadDoc_MouseHover);
            // 
            // iconBtnSavedEntretien
            // 
            this.iconBtnSavedEntretien.BackColor = System.Drawing.Color.White;
            this.iconBtnSavedEntretien.ForeColor = System.Drawing.Color.YellowGreen;
            this.iconBtnSavedEntretien.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.iconBtnSavedEntretien.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(147)))), ((int)(((byte)(222)))));
            this.iconBtnSavedEntretien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnSavedEntretien.IconSize = 20;
            this.iconBtnSavedEntretien.Location = new System.Drawing.Point(-2, -2);
            this.iconBtnSavedEntretien.Name = "iconBtnSavedEntretien";
            this.iconBtnSavedEntretien.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.iconBtnSavedEntretien.Size = new System.Drawing.Size(30, 26);
            this.iconBtnSavedEntretien.TabIndex = 0;
            this.iconBtnSavedEntretien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnSavedEntretien.UseVisualStyleBackColor = false;
            this.iconBtnSavedEntretien.Click += new System.EventHandler(this.iconBtnSavedEntretien_Click);
            this.iconBtnSavedEntretien.MouseHover += new System.EventHandler(this.iconBtnSavedEntretien_MouseHover);
            // 
            // TxtStationVdgeMod
            // 
            this.TxtStationVdgeMod.Location = new System.Drawing.Point(101, 284);
            this.TxtStationVdgeMod.Name = "TxtStationVdgeMod";
            this.TxtStationVdgeMod.Size = new System.Drawing.Size(229, 26);
            this.TxtStationVdgeMod.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 35;
            this.label4.Text = "Station";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(356, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 19);
            this.label10.TabIndex = 2;
            this.label10.Text = "Date";
            // 
            // DatePickerCreateVdgeMod
            // 
            this.DatePickerCreateVdgeMod.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePickerCreateVdgeMod.Location = new System.Drawing.Point(484, 50);
            this.DatePickerCreateVdgeMod.Name = "DatePickerCreateVdgeMod";
            this.DatePickerCreateVdgeMod.Size = new System.Drawing.Size(142, 26);
            this.DatePickerCreateVdgeMod.TabIndex = 5;
            // 
            // txtVehiculeVdge
            // 
            this.txtVehiculeVdge.Location = new System.Drawing.Point(101, 106);
            this.txtVehiculeVdge.Name = "txtVehiculeVdge";
            this.txtVehiculeVdge.ReadOnly = true;
            this.txtVehiculeVdge.Size = new System.Drawing.Size(229, 26);
            this.txtVehiculeVdge.TabIndex = 41;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 354);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(672, 15);
            this.panel3.TabIndex = 45;
            // 
            // FormModifierEntretien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(672, 369);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtVehiculeVdge);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DatePickerCreateVdgeMod);
            this.Controls.Add(this.TxtStationVdgeMod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtMontantVdgeMod);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.RtxtNotesVdgeModi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CbxGarageVdgeModi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCodeVdgeModi);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormModifierEntretien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifier une révision de véhicule";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconBtUploadDoc;
        private FontAwesome.Sharp.IconButton iconBtnSavedEntretien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox TxtCodeVdgeModi;
        public System.Windows.Forms.DateTimePicker DatePickerCreateVdgeMod;
        public System.Windows.Forms.TextBox TxtMontantVdgeMod;
        public System.Windows.Forms.ComboBox CbxGarageVdgeModi;
        public System.Windows.Forms.TextBox TxtStationVdgeMod;
        public System.Windows.Forms.RichTextBox RtxtNotesVdgeModi;
        public System.Windows.Forms.TextBox txtVehiculeVdge;
        private System.Windows.Forms.Panel panel3;
    }
}