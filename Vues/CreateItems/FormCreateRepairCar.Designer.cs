
namespace GestPark
{
    partial class FormCreateRepairCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateRepairCar));
            this.CbxRepaiCar = new System.Windows.Forms.ComboBox();
            this.RtxtNoteRepairCar = new System.Windows.Forms.RichTextBox();
            this.DateRegisterRepairCar = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtCodeRepaiCar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelMenuConsoCarb = new System.Windows.Forms.Panel();
            this.JointDocModifyPanCar = new FontAwesome.Sharp.IconButton();
            this.IcBtnSavedRepaiCar = new FontAwesome.Sharp.IconButton();
            this.CbxGarageRepairCar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtAmountRepair = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtMecanicienRepairCar = new System.Windows.Forms.TextBox();
            this.cbxEtatCarRepair = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelMenuConsoCarb.SuspendLayout();
            this.SuspendLayout();
            // 
            // CbxRepaiCar
            // 
            this.CbxRepaiCar.BackColor = System.Drawing.Color.White;
            this.CbxRepaiCar.FormattingEnabled = true;
            this.CbxRepaiCar.Location = new System.Drawing.Point(137, 117);
            this.CbxRepaiCar.Name = "CbxRepaiCar";
            this.CbxRepaiCar.Size = new System.Drawing.Size(202, 28);
            this.CbxRepaiCar.TabIndex = 73;
            this.CbxRepaiCar.SelectedIndexChanged += new System.EventHandler(this.CbxRepaiCar_SelectedIndexChanged);
            // 
            // RtxtNoteRepairCar
            // 
            this.RtxtNoteRepairCar.BackColor = System.Drawing.Color.White;
            this.RtxtNoteRepairCar.Location = new System.Drawing.Point(469, 175);
            this.RtxtNoteRepairCar.Name = "RtxtNoteRepairCar";
            this.RtxtNoteRepairCar.Size = new System.Drawing.Size(168, 51);
            this.RtxtNoteRepairCar.TabIndex = 72;
            this.RtxtNoteRepairCar.Text = "";
            // 
            // DateRegisterRepairCar
            // 
            this.DateRegisterRepairCar.CalendarMonthBackground = System.Drawing.Color.White;
            this.DateRegisterRepairCar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateRegisterRepairCar.Location = new System.Drawing.Point(469, 63);
            this.DateRegisterRepairCar.Name = "DateRegisterRepairCar";
            this.DateRegisterRepairCar.Size = new System.Drawing.Size(168, 28);
            this.DateRegisterRepairCar.TabIndex = 71;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 70;
            this.label6.Text = "Date :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(379, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 69;
            this.label8.Text = "Causes :";
            // 
            // TxtCodeRepaiCar
            // 
            this.TxtCodeRepaiCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.TxtCodeRepaiCar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodeRepaiCar.ForeColor = System.Drawing.Color.Black;
            this.TxtCodeRepaiCar.Location = new System.Drawing.Point(137, 61);
            this.TxtCodeRepaiCar.Name = "TxtCodeRepaiCar";
            this.TxtCodeRepaiCar.ReadOnly = true;
            this.TxtCodeRepaiCar.Size = new System.Drawing.Size(119, 29);
            this.TxtCodeRepaiCar.TabIndex = 67;
            this.TxtCodeRepaiCar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(14, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 66;
            this.label3.Text = "Vehicule * :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(14, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 64;
            this.label1.Text = "Code * :";
            // 
            // PanelMenuConsoCarb
            // 
            this.PanelMenuConsoCarb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.PanelMenuConsoCarb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelMenuConsoCarb.Controls.Add(this.JointDocModifyPanCar);
            this.PanelMenuConsoCarb.Controls.Add(this.IcBtnSavedRepaiCar);
            this.PanelMenuConsoCarb.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelMenuConsoCarb.Location = new System.Drawing.Point(0, 0);
            this.PanelMenuConsoCarb.Name = "PanelMenuConsoCarb";
            this.PanelMenuConsoCarb.Size = new System.Drawing.Size(684, 24);
            this.PanelMenuConsoCarb.TabIndex = 63;
            // 
            // JointDocModifyPanCar
            // 
            this.JointDocModifyPanCar.BackColor = System.Drawing.Color.White;
            this.JointDocModifyPanCar.ForeColor = System.Drawing.Color.YellowGreen;
            this.JointDocModifyPanCar.IconChar = FontAwesome.Sharp.IconChar.FileUpload;
            this.JointDocModifyPanCar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(13)))));
            this.JointDocModifyPanCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.JointDocModifyPanCar.IconSize = 20;
            this.JointDocModifyPanCar.Location = new System.Drawing.Point(31, -2);
            this.JointDocModifyPanCar.Name = "JointDocModifyPanCar";
            this.JointDocModifyPanCar.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.JointDocModifyPanCar.Size = new System.Drawing.Size(28, 24);
            this.JointDocModifyPanCar.TabIndex = 2;
            this.JointDocModifyPanCar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.JointDocModifyPanCar.UseVisualStyleBackColor = false;
            this.JointDocModifyPanCar.MouseHover += new System.EventHandler(this.JointDocModifyPanCar_MouseHover);
            // 
            // IcBtnSavedRepaiCar
            // 
            this.IcBtnSavedRepaiCar.BackColor = System.Drawing.Color.White;
            this.IcBtnSavedRepaiCar.ForeColor = System.Drawing.Color.YellowGreen;
            this.IcBtnSavedRepaiCar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.IcBtnSavedRepaiCar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(147)))), ((int)(((byte)(222)))));
            this.IcBtnSavedRepaiCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcBtnSavedRepaiCar.IconSize = 20;
            this.IcBtnSavedRepaiCar.Location = new System.Drawing.Point(-2, -2);
            this.IcBtnSavedRepaiCar.Name = "IcBtnSavedRepaiCar";
            this.IcBtnSavedRepaiCar.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.IcBtnSavedRepaiCar.Size = new System.Drawing.Size(27, 24);
            this.IcBtnSavedRepaiCar.TabIndex = 1;
            this.IcBtnSavedRepaiCar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IcBtnSavedRepaiCar.UseVisualStyleBackColor = false;
            this.IcBtnSavedRepaiCar.Click += new System.EventHandler(this.IcBtnSavedRepaiCar_Click);
            this.IcBtnSavedRepaiCar.MouseHover += new System.EventHandler(this.IcBtnSavedRepaiCar_MouseHover);
            // 
            // CbxGarageRepairCar
            // 
            this.CbxGarageRepairCar.BackColor = System.Drawing.Color.White;
            this.CbxGarageRepairCar.FormattingEnabled = true;
            this.CbxGarageRepairCar.Location = new System.Drawing.Point(137, 173);
            this.CbxGarageRepairCar.Name = "CbxGarageRepairCar";
            this.CbxGarageRepairCar.Size = new System.Drawing.Size(202, 28);
            this.CbxGarageRepairCar.TabIndex = 76;
            this.CbxGarageRepairCar.SelectedIndexChanged += new System.EventHandler(this.CbxGarageRepairCar_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(14, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 75;
            this.label4.Text = "Garage * :";
            // 
            // TxtAmountRepair
            // 
            this.TxtAmountRepair.BackColor = System.Drawing.Color.White;
            this.TxtAmountRepair.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAmountRepair.ForeColor = System.Drawing.Color.YellowGreen;
            this.TxtAmountRepair.Location = new System.Drawing.Point(137, 288);
            this.TxtAmountRepair.Name = "TxtAmountRepair";
            this.TxtAmountRepair.Size = new System.Drawing.Size(202, 28);
            this.TxtAmountRepair.TabIndex = 80;
            this.TxtAmountRepair.Text = "0";
            this.TxtAmountRepair.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(14, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 79;
            this.label7.Text = "Coût * :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 77;
            this.label5.Text = "Mecanicien :";
            // 
            // TxtMecanicienRepairCar
            // 
            this.TxtMecanicienRepairCar.BackColor = System.Drawing.Color.White;
            this.TxtMecanicienRepairCar.Location = new System.Drawing.Point(137, 227);
            this.TxtMecanicienRepairCar.Name = "TxtMecanicienRepairCar";
            this.TxtMecanicienRepairCar.ReadOnly = true;
            this.TxtMecanicienRepairCar.Size = new System.Drawing.Size(202, 28);
            this.TxtMecanicienRepairCar.TabIndex = 78;
            // 
            // cbxEtatCarRepair
            // 
            this.cbxEtatCarRepair.BackColor = System.Drawing.Color.White;
            this.cbxEtatCarRepair.FormattingEnabled = true;
            this.cbxEtatCarRepair.Items.AddRange(new object[] {
            "",
            "Bon"});
            this.cbxEtatCarRepair.Location = new System.Drawing.Point(469, 122);
            this.cbxEtatCarRepair.Name = "cbxEtatCarRepair";
            this.cbxEtatCarRepair.Size = new System.Drawing.Size(168, 28);
            this.cbxEtatCarRepair.TabIndex = 82;
            this.cbxEtatCarRepair.Text = "Bon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(382, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 81;
            this.label2.Text = "Etat :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 336);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 17);
            this.panel1.TabIndex = 83;
            // 
            // FormCreateRepairCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 353);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbxEtatCarRepair);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateRegisterRepairCar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtAmountRepair);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtMecanicienRepairCar);
            this.Controls.Add(this.CbxGarageRepairCar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CbxRepaiCar);
            this.Controls.Add(this.RtxtNoteRepairCar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtCodeRepaiCar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelMenuConsoCarb);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCreateRepairCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Créer une réparation de vehicule";
            this.PanelMenuConsoCarb.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton JointDocModifyPanCar;
        private FontAwesome.Sharp.IconButton IcBtnSavedRepaiCar;
        public System.Windows.Forms.ComboBox CbxRepaiCar;
        public System.Windows.Forms.RichTextBox RtxtNoteRepairCar;
        public System.Windows.Forms.DateTimePicker DateRegisterRepairCar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox TxtCodeRepaiCar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelMenuConsoCarb;
        public System.Windows.Forms.ComboBox CbxGarageRepairCar;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TxtAmountRepair;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox TxtMecanicienRepairCar;
        public System.Windows.Forms.ComboBox cbxEtatCarRepair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}