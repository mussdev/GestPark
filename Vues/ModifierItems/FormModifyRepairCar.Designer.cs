namespace GestPark
{
    partial class FormModifyRepairCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModifyRepairCar));
            this.PanelMenuConsoCarb = new System.Windows.Forms.Panel();
            this.JointDocModifyRepairCarMod = new FontAwesome.Sharp.IconButton();
            this.IcBtnSavedRepaiCarMod = new FontAwesome.Sharp.IconButton();
            this.cbxEtatCarRepairMod = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DateRegisterRepairCarMod = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtAmountRepairMod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtMecanicienRepairCarMod = new System.Windows.Forms.TextBox();
            this.CbxGarageRepairCarMod = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CbxRepaiCarMod = new System.Windows.Forms.ComboBox();
            this.RtxtNoteRepairCarMod = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtCodeRepaiCarMod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PanelMenuConsoCarb.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenuConsoCarb
            // 
            this.PanelMenuConsoCarb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.PanelMenuConsoCarb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelMenuConsoCarb.Controls.Add(this.JointDocModifyRepairCarMod);
            this.PanelMenuConsoCarb.Controls.Add(this.IcBtnSavedRepaiCarMod);
            this.PanelMenuConsoCarb.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelMenuConsoCarb.Location = new System.Drawing.Point(0, 0);
            this.PanelMenuConsoCarb.Name = "PanelMenuConsoCarb";
            this.PanelMenuConsoCarb.Size = new System.Drawing.Size(643, 29);
            this.PanelMenuConsoCarb.TabIndex = 64;
            // 
            // JointDocModifyRepairCarMod
            // 
            this.JointDocModifyRepairCarMod.BackColor = System.Drawing.Color.White;
            this.JointDocModifyRepairCarMod.ForeColor = System.Drawing.Color.YellowGreen;
            this.JointDocModifyRepairCarMod.IconChar = FontAwesome.Sharp.IconChar.FileUpload;
            this.JointDocModifyRepairCarMod.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(13)))));
            this.JointDocModifyRepairCarMod.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.JointDocModifyRepairCarMod.IconSize = 20;
            this.JointDocModifyRepairCarMod.Location = new System.Drawing.Point(29, -2);
            this.JointDocModifyRepairCarMod.Name = "JointDocModifyRepairCarMod";
            this.JointDocModifyRepairCarMod.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.JointDocModifyRepairCarMod.Size = new System.Drawing.Size(24, 29);
            this.JointDocModifyRepairCarMod.TabIndex = 2;
            this.JointDocModifyRepairCarMod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.JointDocModifyRepairCarMod.UseVisualStyleBackColor = false;
            // 
            // IcBtnSavedRepaiCarMod
            // 
            this.IcBtnSavedRepaiCarMod.BackColor = System.Drawing.Color.White;
            this.IcBtnSavedRepaiCarMod.ForeColor = System.Drawing.Color.YellowGreen;
            this.IcBtnSavedRepaiCarMod.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.IcBtnSavedRepaiCarMod.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(147)))), ((int)(((byte)(222)))));
            this.IcBtnSavedRepaiCarMod.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcBtnSavedRepaiCarMod.IconSize = 20;
            this.IcBtnSavedRepaiCarMod.Location = new System.Drawing.Point(-2, -2);
            this.IcBtnSavedRepaiCarMod.Name = "IcBtnSavedRepaiCarMod";
            this.IcBtnSavedRepaiCarMod.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.IcBtnSavedRepaiCarMod.Size = new System.Drawing.Size(25, 29);
            this.IcBtnSavedRepaiCarMod.TabIndex = 1;
            this.IcBtnSavedRepaiCarMod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IcBtnSavedRepaiCarMod.UseVisualStyleBackColor = false;
            this.IcBtnSavedRepaiCarMod.Click += new System.EventHandler(this.IcBtnSavedRepaiCarMod_Click);
            // 
            // cbxEtatCarRepairMod
            // 
            this.cbxEtatCarRepairMod.BackColor = System.Drawing.Color.White;
            this.cbxEtatCarRepairMod.FormattingEnabled = true;
            this.cbxEtatCarRepairMod.Items.AddRange(new object[] {
            "",
            "Bon"});
            this.cbxEtatCarRepairMod.Location = new System.Drawing.Point(497, 123);
            this.cbxEtatCarRepairMod.Name = "cbxEtatCarRepairMod";
            this.cbxEtatCarRepairMod.Size = new System.Drawing.Size(114, 27);
            this.cbxEtatCarRepairMod.TabIndex = 98;
            this.cbxEtatCarRepairMod.Text = "Bon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(440, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 97;
            this.label2.Text = "Etat :";
            // 
            // DateRegisterRepairCarMod
            // 
            this.DateRegisterRepairCarMod.CalendarMonthBackground = System.Drawing.Color.White;
            this.DateRegisterRepairCarMod.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateRegisterRepairCarMod.Location = new System.Drawing.Point(497, 72);
            this.DateRegisterRepairCarMod.Name = "DateRegisterRepairCarMod";
            this.DateRegisterRepairCarMod.Size = new System.Drawing.Size(114, 27);
            this.DateRegisterRepairCarMod.TabIndex = 88;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(440, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 19);
            this.label6.TabIndex = 87;
            this.label6.Text = "Date :";
            // 
            // TxtAmountRepairMod
            // 
            this.TxtAmountRepairMod.BackColor = System.Drawing.Color.White;
            this.TxtAmountRepairMod.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAmountRepairMod.ForeColor = System.Drawing.Color.YellowGreen;
            this.TxtAmountRepairMod.Location = new System.Drawing.Point(143, 285);
            this.TxtAmountRepairMod.Name = "TxtAmountRepairMod";
            this.TxtAmountRepairMod.Size = new System.Drawing.Size(235, 28);
            this.TxtAmountRepairMod.TabIndex = 96;
            this.TxtAmountRepairMod.Text = "0";
            this.TxtAmountRepairMod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 19);
            this.label5.TabIndex = 93;
            this.label5.Text = "Mecanicien :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(20, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 95;
            this.label7.Text = "Coût * :";
            // 
            // TxtMecanicienRepairCarMod
            // 
            this.TxtMecanicienRepairCarMod.BackColor = System.Drawing.Color.White;
            this.TxtMecanicienRepairCarMod.Location = new System.Drawing.Point(143, 230);
            this.TxtMecanicienRepairCarMod.Name = "TxtMecanicienRepairCarMod";
            this.TxtMecanicienRepairCarMod.ReadOnly = true;
            this.TxtMecanicienRepairCarMod.Size = new System.Drawing.Size(235, 27);
            this.TxtMecanicienRepairCarMod.TabIndex = 94;
            // 
            // CbxGarageRepairCarMod
            // 
            this.CbxGarageRepairCarMod.BackColor = System.Drawing.Color.White;
            this.CbxGarageRepairCarMod.FormattingEnabled = true;
            this.CbxGarageRepairCarMod.Location = new System.Drawing.Point(143, 176);
            this.CbxGarageRepairCarMod.Name = "CbxGarageRepairCarMod";
            this.CbxGarageRepairCarMod.Size = new System.Drawing.Size(235, 27);
            this.CbxGarageRepairCarMod.TabIndex = 92;
            this.CbxGarageRepairCarMod.SelectedIndexChanged += new System.EventHandler(this.CbxGarageRepairCarMod_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(20, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 91;
            this.label4.Text = "Garage * :";
            // 
            // CbxRepaiCarMod
            // 
            this.CbxRepaiCarMod.BackColor = System.Drawing.Color.White;
            this.CbxRepaiCarMod.FormattingEnabled = true;
            this.CbxRepaiCarMod.Location = new System.Drawing.Point(143, 123);
            this.CbxRepaiCarMod.Name = "CbxRepaiCarMod";
            this.CbxRepaiCarMod.Size = new System.Drawing.Size(235, 27);
            this.CbxRepaiCarMod.TabIndex = 90;
            this.CbxRepaiCarMod.SelectedIndexChanged += new System.EventHandler(this.CbxRepaiCarMod_SelectedIndexChanged);
            // 
            // RtxtNoteRepairCarMod
            // 
            this.RtxtNoteRepairCarMod.BackColor = System.Drawing.Color.White;
            this.RtxtNoteRepairCarMod.Location = new System.Drawing.Point(143, 336);
            this.RtxtNoteRepairCarMod.Name = "RtxtNoteRepairCarMod";
            this.RtxtNoteRepairCarMod.Size = new System.Drawing.Size(468, 54);
            this.RtxtNoteRepairCarMod.TabIndex = 89;
            this.RtxtNoteRepairCarMod.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 19);
            this.label8.TabIndex = 86;
            this.label8.Text = "Causes :";
            // 
            // TxtCodeRepaiCarMod
            // 
            this.TxtCodeRepaiCarMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.TxtCodeRepaiCarMod.Location = new System.Drawing.Point(143, 74);
            this.TxtCodeRepaiCarMod.Name = "TxtCodeRepaiCarMod";
            this.TxtCodeRepaiCarMod.ReadOnly = true;
            this.TxtCodeRepaiCarMod.Size = new System.Drawing.Size(123, 27);
            this.TxtCodeRepaiCarMod.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(20, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 84;
            this.label3.Text = "Vehicule * :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(20, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 83;
            this.label1.Text = "Code * :";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 402);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(643, 15);
            this.panel3.TabIndex = 99;
            // 
            // FormModifyRepairCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(643, 417);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cbxEtatCarRepairMod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateRegisterRepairCarMod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtAmountRepairMod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtMecanicienRepairCarMod);
            this.Controls.Add(this.CbxGarageRepairCarMod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CbxRepaiCarMod);
            this.Controls.Add(this.RtxtNoteRepairCarMod);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtCodeRepaiCarMod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelMenuConsoCarb);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormModifyRepairCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifier une réparation";
            this.PanelMenuConsoCarb.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenuConsoCarb;
        private FontAwesome.Sharp.IconButton JointDocModifyRepairCarMod;
        private FontAwesome.Sharp.IconButton IcBtnSavedRepaiCarMod;
        public System.Windows.Forms.ComboBox cbxEtatCarRepairMod;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker DateRegisterRepairCarMod;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox TxtAmountRepairMod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox TxtMecanicienRepairCarMod;
        public System.Windows.Forms.ComboBox CbxGarageRepairCarMod;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox CbxRepaiCarMod;
        public System.Windows.Forms.RichTextBox RtxtNoteRepairCarMod;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox TxtCodeRepaiCarMod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
    }
}