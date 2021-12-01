
namespace GestPark
{
    partial class FormModifyMouvement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModifyMouvement));
            this.CbxLieuMvtsMod = new System.Windows.Forms.ComboBox();
            this.CbxStatutMvtMod = new System.Windows.Forms.ComboBox();
            this.CbxConducMvtMod = new System.Windows.Forms.ComboBox();
            this.TbxDescriptionMvtMod = new System.Windows.Forms.TextBox();
            this.TbxCodMvtMod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelFormMvt = new System.Windows.Forms.Panel();
            this.CbxVehiculeMod = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.RtbxNoteMvtMod = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TimeEndMvtModi = new System.Windows.Forms.DateTimePicker();
            this.TimeStartMvtModi = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DateArriveeMvtMod = new System.Windows.Forms.DateTimePicker();
            this.DateDepartMvtMod = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.paneltitleFormCreateMvt = new System.Windows.Forms.Panel();
            this.BtnImportDocModi = new FontAwesome.Sharp.IconButton();
            this.BtnPrinterCarModi = new FontAwesome.Sharp.IconButton();
            this.IbtnRegisterMvtTbxCodMvtMod = new FontAwesome.Sharp.IconButton();
            this.PanelFormMvt.SuspendLayout();
            this.panel1.SuspendLayout();
            this.paneltitleFormCreateMvt.SuspendLayout();
            this.SuspendLayout();
            // 
            // CbxLieuMvtsMod
            // 
            this.CbxLieuMvtsMod.FormattingEnabled = true;
            this.CbxLieuMvtsMod.Items.AddRange(new object[] {
            "",
            "Abengourou",
            "Abidjan",
            "Adzopé",
            "Agboville",
            "Agnibilékrou",
            "Akoupé",
            "Anyama",
            "Bingerville",
            "Bondoukou",
            "Bouaflé",
            "Bouaké",
            "Boundiali",
            "Dabou",
            "Daloa",
            "Danané",
            "Daoukro",
            "Dimbokro1",
            "Divo",
            "Duékoué",
            "Ferkessedougou",
            "Gagnoa",
            "Grand-Bassam",
            "Guiglo",
            "Issia",
            "Katiola",
            "Korhogo",
            "Lakota",
            "Man",
            "Odienné",
            "Oumé",
            "San-Pédro",
            "Séguéla",
            "Sinfra",
            "Soubré",
            "Tiassalé",
            "Tingréla",
            "Toumodi",
            "Vavoua",
            "Yamoussoukro",
            "Zuénoula"});
            this.CbxLieuMvtsMod.Location = new System.Drawing.Point(119, 183);
            this.CbxLieuMvtsMod.Name = "CbxLieuMvtsMod";
            this.CbxLieuMvtsMod.Size = new System.Drawing.Size(278, 23);
            this.CbxLieuMvtsMod.TabIndex = 23;
            // 
            // CbxStatutMvtMod
            // 
            this.CbxStatutMvtMod.FormattingEnabled = true;
            this.CbxStatutMvtMod.Items.AddRange(new object[] {
            "",
            "Parking"});
            this.CbxStatutMvtMod.Location = new System.Drawing.Point(119, 77);
            this.CbxStatutMvtMod.Name = "CbxStatutMvtMod";
            this.CbxStatutMvtMod.Size = new System.Drawing.Size(278, 23);
            this.CbxStatutMvtMod.TabIndex = 16;
            // 
            // CbxConducMvtMod
            // 
            this.CbxConducMvtMod.FormattingEnabled = true;
            this.CbxConducMvtMod.Location = new System.Drawing.Point(119, 238);
            this.CbxConducMvtMod.Name = "CbxConducMvtMod";
            this.CbxConducMvtMod.Size = new System.Drawing.Size(278, 23);
            this.CbxConducMvtMod.TabIndex = 15;
            this.CbxConducMvtMod.SelectedIndexChanged += new System.EventHandler(this.CbxConducMvtMod_SelectedIndexChanged);
            // 
            // TbxDescriptionMvtMod
            // 
            this.TbxDescriptionMvtMod.Location = new System.Drawing.Point(119, 130);
            this.TbxDescriptionMvtMod.Name = "TbxDescriptionMvtMod";
            this.TbxDescriptionMvtMod.Size = new System.Drawing.Size(278, 22);
            this.TbxDescriptionMvtMod.TabIndex = 13;
            // 
            // TbxCodMvtMod
            // 
            this.TbxCodMvtMod.BackColor = System.Drawing.Color.YellowGreen;
            this.TbxCodMvtMod.Location = new System.Drawing.Point(119, 27);
            this.TbxCodMvtMod.Name = "TbxCodMvtMod";
            this.TbxCodMvtMod.ReadOnly = true;
            this.TbxCodMvtMod.Size = new System.Drawing.Size(169, 22);
            this.TbxCodMvtMod.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(25, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Conducteur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(25, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lieu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(25, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(26, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Statut";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // PanelFormMvt
            // 
            this.PanelFormMvt.BackColor = System.Drawing.Color.Khaki;
            this.PanelFormMvt.Controls.Add(this.CbxVehiculeMod);
            this.PanelFormMvt.Controls.Add(this.label10);
            this.PanelFormMvt.Controls.Add(this.RtbxNoteMvtMod);
            this.PanelFormMvt.Controls.Add(this.panel1);
            this.PanelFormMvt.Controls.Add(this.label11);
            this.PanelFormMvt.Controls.Add(this.CbxLieuMvtsMod);
            this.PanelFormMvt.Controls.Add(this.CbxStatutMvtMod);
            this.PanelFormMvt.Controls.Add(this.CbxConducMvtMod);
            this.PanelFormMvt.Controls.Add(this.TbxDescriptionMvtMod);
            this.PanelFormMvt.Controls.Add(this.TbxCodMvtMod);
            this.PanelFormMvt.Controls.Add(this.label5);
            this.PanelFormMvt.Controls.Add(this.label4);
            this.PanelFormMvt.Controls.Add(this.label3);
            this.PanelFormMvt.Controls.Add(this.label2);
            this.PanelFormMvt.Controls.Add(this.label1);
            this.PanelFormMvt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormMvt.Location = new System.Drawing.Point(0, 24);
            this.PanelFormMvt.Name = "PanelFormMvt";
            this.PanelFormMvt.Size = new System.Drawing.Size(933, 495);
            this.PanelFormMvt.TabIndex = 3;
            // 
            // CbxVehiculeMod
            // 
            this.CbxVehiculeMod.FormattingEnabled = true;
            this.CbxVehiculeMod.Location = new System.Drawing.Point(608, 226);
            this.CbxVehiculeMod.Name = "CbxVehiculeMod";
            this.CbxVehiculeMod.Size = new System.Drawing.Size(278, 23);
            this.CbxVehiculeMod.TabIndex = 38;
            this.CbxVehiculeMod.SelectedIndexChanged += new System.EventHandler(this.CbxVehiculeMod_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(492, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 15);
            this.label10.TabIndex = 37;
            this.label10.Text = "Voiture";
            // 
            // RtbxNoteMvtMod
            // 
            this.RtbxNoteMvtMod.Location = new System.Drawing.Point(125, 307);
            this.RtbxNoteMvtMod.Name = "RtbxNoteMvtMod";
            this.RtbxNoteMvtMod.Size = new System.Drawing.Size(797, 105);
            this.RtbxNoteMvtMod.TabIndex = 38;
            this.RtbxNoteMvtMod.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.TimeEndMvtModi);
            this.panel1.Controls.Add(this.TimeStartMvtModi);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.DateArriveeMvtMod);
            this.panel1.Controls.Add(this.DateDepartMvtMod);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(462, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 189);
            this.panel1.TabIndex = 25;
            // 
            // TimeEndMvtModi
            // 
            this.TimeEndMvtModi.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimeEndMvtModi.Location = new System.Drawing.Point(148, 151);
            this.TimeEndMvtModi.Name = "TimeEndMvtModi";
            this.TimeEndMvtModi.Size = new System.Drawing.Size(274, 22);
            this.TimeEndMvtModi.TabIndex = 36;
            // 
            // TimeStartMvtModi
            // 
            this.TimeStartMvtModi.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimeStartMvtModi.Location = new System.Drawing.Point(148, 111);
            this.TimeStartMvtModi.Name = "TimeStartMvtModi";
            this.TimeStartMvtModi.Size = new System.Drawing.Size(274, 22);
            this.TimeStartMvtModi.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(32, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 34;
            this.label6.Text = "Heure arrivée";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(32, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 15);
            this.label9.TabIndex = 33;
            this.label9.Text = "Heure départ";
            // 
            // DateArriveeMvtMod
            // 
            this.DateArriveeMvtMod.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateArriveeMvtMod.Location = new System.Drawing.Point(148, 67);
            this.DateArriveeMvtMod.Name = "DateArriveeMvtMod";
            this.DateArriveeMvtMod.Size = new System.Drawing.Size(274, 22);
            this.DateArriveeMvtMod.TabIndex = 32;
            // 
            // DateDepartMvtMod
            // 
            this.DateDepartMvtMod.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateDepartMvtMod.Location = new System.Drawing.Point(148, 15);
            this.DateDepartMvtMod.Name = "DateDepartMvtMod";
            this.DateDepartMvtMod.Size = new System.Drawing.Size(274, 22);
            this.DateDepartMvtMod.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(32, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 28;
            this.label8.Text = "Date arrivée";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(32, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "Date départ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(32, 307);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 15);
            this.label11.TabIndex = 37;
            this.label11.Text = "Note";
            // 
            // paneltitleFormCreateMvt
            // 
            this.paneltitleFormCreateMvt.BackColor = System.Drawing.Color.Khaki;
            this.paneltitleFormCreateMvt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paneltitleFormCreateMvt.Controls.Add(this.BtnImportDocModi);
            this.paneltitleFormCreateMvt.Controls.Add(this.BtnPrinterCarModi);
            this.paneltitleFormCreateMvt.Controls.Add(this.IbtnRegisterMvtTbxCodMvtMod);
            this.paneltitleFormCreateMvt.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitleFormCreateMvt.Location = new System.Drawing.Point(0, 0);
            this.paneltitleFormCreateMvt.Name = "paneltitleFormCreateMvt";
            this.paneltitleFormCreateMvt.Size = new System.Drawing.Size(933, 24);
            this.paneltitleFormCreateMvt.TabIndex = 2;
            // 
            // BtnImportDocModi
            // 
            this.BtnImportDocModi.BackColor = System.Drawing.Color.White;
            this.BtnImportDocModi.ForeColor = System.Drawing.Color.DarkGreen;
            this.BtnImportDocModi.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.BtnImportDocModi.IconColor = System.Drawing.Color.DarkGreen;
            this.BtnImportDocModi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnImportDocModi.IconSize = 20;
            this.BtnImportDocModi.Location = new System.Drawing.Point(201, -2);
            this.BtnImportDocModi.Name = "BtnImportDocModi";
            this.BtnImportDocModi.Size = new System.Drawing.Size(103, 24);
            this.BtnImportDocModi.TabIndex = 2;
            this.BtnImportDocModi.Text = "Joindre doc.";
            this.BtnImportDocModi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnImportDocModi.UseVisualStyleBackColor = false;
            // 
            // BtnPrinterCarModi
            // 
            this.BtnPrinterCarModi.BackColor = System.Drawing.Color.White;
            this.BtnPrinterCarModi.ForeColor = System.Drawing.Color.DarkGreen;
            this.BtnPrinterCarModi.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.BtnPrinterCarModi.IconColor = System.Drawing.Color.DarkGreen;
            this.BtnPrinterCarModi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPrinterCarModi.IconSize = 20;
            this.BtnPrinterCarModi.Location = new System.Drawing.Point(99, -2);
            this.BtnPrinterCarModi.Name = "BtnPrinterCarModi";
            this.BtnPrinterCarModi.Size = new System.Drawing.Size(96, 24);
            this.BtnPrinterCarModi.TabIndex = 1;
            this.BtnPrinterCarModi.Text = "Imprimer";
            this.BtnPrinterCarModi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPrinterCarModi.UseVisualStyleBackColor = false;
            // 
            // IbtnRegisterMvtTbxCodMvtMod
            // 
            this.IbtnRegisterMvtTbxCodMvtMod.BackColor = System.Drawing.Color.White;
            this.IbtnRegisterMvtTbxCodMvtMod.ForeColor = System.Drawing.Color.DarkGreen;
            this.IbtnRegisterMvtTbxCodMvtMod.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.IbtnRegisterMvtTbxCodMvtMod.IconColor = System.Drawing.Color.DarkGreen;
            this.IbtnRegisterMvtTbxCodMvtMod.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnRegisterMvtTbxCodMvtMod.IconSize = 20;
            this.IbtnRegisterMvtTbxCodMvtMod.Location = new System.Drawing.Point(-2, -2);
            this.IbtnRegisterMvtTbxCodMvtMod.Name = "IbtnRegisterMvtTbxCodMvtMod";
            this.IbtnRegisterMvtTbxCodMvtMod.Size = new System.Drawing.Size(95, 24);
            this.IbtnRegisterMvtTbxCodMvtMod.TabIndex = 0;
            this.IbtnRegisterMvtTbxCodMvtMod.Text = "Enregistrer";
            this.IbtnRegisterMvtTbxCodMvtMod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IbtnRegisterMvtTbxCodMvtMod.UseVisualStyleBackColor = false;
            this.IbtnRegisterMvtTbxCodMvtMod.Click += new System.EventHandler(this.IbtnRegisterMvtTbxCodMvtMod_Click);
            // 
            // FormModifyMouvement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.PanelFormMvt);
            this.Controls.Add(this.paneltitleFormCreateMvt);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormModifyMouvement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editer un mouvement";
            this.PanelFormMvt.ResumeLayout(false);
            this.PanelFormMvt.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.paneltitleFormCreateMvt.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton IbtnRegisterMvtTbxCodMvtMod;
        private System.Windows.Forms.Panel PanelFormMvt;
        private System.Windows.Forms.Panel paneltitleFormCreateMvt;
        public System.Windows.Forms.ComboBox CbxLieuMvtsMod;
        public System.Windows.Forms.ComboBox CbxStatutMvtMod;
        public System.Windows.Forms.ComboBox CbxConducMvtMod;
        public System.Windows.Forms.TextBox TbxDescriptionMvtMod;
        public System.Windows.Forms.TextBox TbxCodMvtMod;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DateTimePicker DateArriveeMvtMod;
        public System.Windows.Forms.DateTimePicker DateDepartMvtMod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.RichTextBox RtbxNoteMvtMod;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.ComboBox CbxVehiculeMod;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton BtnImportDocModi;
        private FontAwesome.Sharp.IconButton BtnPrinterCarModi;
        public System.Windows.Forms.DateTimePicker TimeEndMvtModi;
        public System.Windows.Forms.DateTimePicker TimeStartMvtModi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
    }
}