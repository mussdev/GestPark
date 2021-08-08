
namespace GestPark
{
    partial class FormCreateMouvement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateMouvement));
            this.paneltitleFormCreateMvt = new System.Windows.Forms.Panel();
            this.IbtnRegisterMvt = new FontAwesome.Sharp.IconButton();
            this.PanelFormMvt = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CbxVehicule = new System.Windows.Forms.ComboBox();
            this.TbxKiloParcouApresMvt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TbxKilometreAvantMvt = new System.Windows.Forms.TextBox();
            this.DateArriveeMvt = new System.Windows.Forms.DateTimePicker();
            this.DateDepartMvt = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CbxLieuMvts = new System.Windows.Forms.ComboBox();
            this.RtbxNoteMvt = new System.Windows.Forms.RichTextBox();
            this.CbxStatutMvt = new System.Windows.Forms.ComboBox();
            this.CbxConducMvt = new System.Windows.Forms.ComboBox();
            this.TbxDescriptionMvt = new System.Windows.Forms.TextBox();
            this.TbxCodMvt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.paneltitleFormCreateMvt.SuspendLayout();
            this.PanelFormMvt.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneltitleFormCreateMvt
            // 
            this.paneltitleFormCreateMvt.BackColor = System.Drawing.Color.DarkOrange;
            this.paneltitleFormCreateMvt.Controls.Add(this.IbtnRegisterMvt);
            this.paneltitleFormCreateMvt.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitleFormCreateMvt.Location = new System.Drawing.Point(0, 0);
            this.paneltitleFormCreateMvt.Name = "paneltitleFormCreateMvt";
            this.paneltitleFormCreateMvt.Size = new System.Drawing.Size(933, 30);
            this.paneltitleFormCreateMvt.TabIndex = 0;
            // 
            // IbtnRegisterMvt
            // 
            this.IbtnRegisterMvt.BackColor = System.Drawing.Color.White;
            this.IbtnRegisterMvt.ForeColor = System.Drawing.Color.DarkGreen;
            this.IbtnRegisterMvt.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.IbtnRegisterMvt.IconColor = System.Drawing.Color.DarkGreen;
            this.IbtnRegisterMvt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnRegisterMvt.IconSize = 25;
            this.IbtnRegisterMvt.Location = new System.Drawing.Point(0, 0);
            this.IbtnRegisterMvt.Name = "IbtnRegisterMvt";
            this.IbtnRegisterMvt.Size = new System.Drawing.Size(107, 30);
            this.IbtnRegisterMvt.TabIndex = 0;
            this.IbtnRegisterMvt.Text = "Enregistrer";
            this.IbtnRegisterMvt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IbtnRegisterMvt.UseVisualStyleBackColor = false;
            this.IbtnRegisterMvt.Click += new System.EventHandler(this.IbtnRegisterMvt_Click);
            // 
            // PanelFormMvt
            // 
            this.PanelFormMvt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelFormMvt.Controls.Add(this.panel1);
            this.PanelFormMvt.Controls.Add(this.CbxLieuMvts);
            this.PanelFormMvt.Controls.Add(this.RtbxNoteMvt);
            this.PanelFormMvt.Controls.Add(this.CbxStatutMvt);
            this.PanelFormMvt.Controls.Add(this.CbxConducMvt);
            this.PanelFormMvt.Controls.Add(this.TbxDescriptionMvt);
            this.PanelFormMvt.Controls.Add(this.TbxCodMvt);
            this.PanelFormMvt.Controls.Add(this.label11);
            this.PanelFormMvt.Controls.Add(this.label5);
            this.PanelFormMvt.Controls.Add(this.label4);
            this.PanelFormMvt.Controls.Add(this.label3);
            this.PanelFormMvt.Controls.Add(this.label2);
            this.PanelFormMvt.Controls.Add(this.label1);
            this.PanelFormMvt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormMvt.Location = new System.Drawing.Point(0, 30);
            this.PanelFormMvt.Name = "PanelFormMvt";
            this.PanelFormMvt.Size = new System.Drawing.Size(933, 489);
            this.PanelFormMvt.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.CbxVehicule);
            this.panel1.Controls.Add(this.TbxKiloParcouApresMvt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TbxKilometreAvantMvt);
            this.panel1.Controls.Add(this.DateArriveeMvt);
            this.panel1.Controls.Add(this.DateDepartMvt);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(519, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 277);
            this.panel1.TabIndex = 24;
            // 
            // CbxVehicule
            // 
            this.CbxVehicule.FormattingEnabled = true;
            this.CbxVehicule.Location = new System.Drawing.Point(120, 230);
            this.CbxVehicule.Name = "CbxVehicule";
            this.CbxVehicule.Size = new System.Drawing.Size(274, 23);
            this.CbxVehicule.TabIndex = 46;
            this.CbxVehicule.SelectedIndexChanged += new System.EventHandler(this.CbxVehicule_SelectedIndexChanged);
            // 
            // TbxKiloParcouApresMvt
            // 
            this.TbxKiloParcouApresMvt.Location = new System.Drawing.Point(120, 184);
            this.TbxKiloParcouApresMvt.Name = "TbxKiloParcouApresMvt";
            this.TbxKiloParcouApresMvt.Size = new System.Drawing.Size(274, 22);
            this.TbxKiloParcouApresMvt.TabIndex = 45;
            this.TbxKiloParcouApresMvt.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(4, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 44;
            this.label6.Text = "Kilomètre après";
            // 
            // TbxKilometreAvantMvt
            // 
            this.TbxKilometreAvantMvt.Location = new System.Drawing.Point(120, 130);
            this.TbxKilometreAvantMvt.Name = "TbxKilometreAvantMvt";
            this.TbxKilometreAvantMvt.Size = new System.Drawing.Size(274, 22);
            this.TbxKilometreAvantMvt.TabIndex = 42;
            this.TbxKilometreAvantMvt.Text = "0";
            // 
            // DateArriveeMvt
            // 
            this.DateArriveeMvt.Location = new System.Drawing.Point(120, 77);
            this.DateArriveeMvt.Name = "DateArriveeMvt";
            this.DateArriveeMvt.Size = new System.Drawing.Size(274, 22);
            this.DateArriveeMvt.TabIndex = 41;
            // 
            // DateDepartMvt
            // 
            this.DateDepartMvt.Location = new System.Drawing.Point(120, 24);
            this.DateDepartMvt.Name = "DateDepartMvt";
            this.DateDepartMvt.Size = new System.Drawing.Size(274, 22);
            this.DateDepartMvt.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(4, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 15);
            this.label10.TabIndex = 39;
            this.label10.Text = "Voiture";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(4, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 15);
            this.label9.TabIndex = 38;
            this.label9.Text = "Kilomètre avant";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(4, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 37;
            this.label8.Text = "Date arrivée";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(4, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 36;
            this.label7.Text = "Date départ";
            // 
            // CbxLieuMvts
            // 
            this.CbxLieuMvts.FormattingEnabled = true;
            this.CbxLieuMvts.Items.AddRange(new object[] {
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
            this.CbxLieuMvts.Location = new System.Drawing.Point(119, 183);
            this.CbxLieuMvts.Name = "CbxLieuMvts";
            this.CbxLieuMvts.Size = new System.Drawing.Size(278, 23);
            this.CbxLieuMvts.TabIndex = 23;
            // 
            // RtbxNoteMvt
            // 
            this.RtbxNoteMvt.Location = new System.Drawing.Point(119, 313);
            this.RtbxNoteMvt.Name = "RtbxNoteMvt";
            this.RtbxNoteMvt.Size = new System.Drawing.Size(802, 142);
            this.RtbxNoteMvt.TabIndex = 22;
            this.RtbxNoteMvt.Text = "";
            // 
            // CbxStatutMvt
            // 
            this.CbxStatutMvt.FormattingEnabled = true;
            this.CbxStatutMvt.Items.AddRange(new object[] {
            "",
            "Sortir"});
            this.CbxStatutMvt.Location = new System.Drawing.Point(119, 77);
            this.CbxStatutMvt.Name = "CbxStatutMvt";
            this.CbxStatutMvt.Size = new System.Drawing.Size(278, 23);
            this.CbxStatutMvt.TabIndex = 16;
            this.CbxStatutMvt.Text = "Sortir";
            // 
            // CbxConducMvt
            // 
            this.CbxConducMvt.FormattingEnabled = true;
            this.CbxConducMvt.Location = new System.Drawing.Point(119, 238);
            this.CbxConducMvt.Name = "CbxConducMvt";
            this.CbxConducMvt.Size = new System.Drawing.Size(278, 23);
            this.CbxConducMvt.TabIndex = 15;
            this.CbxConducMvt.SelectedIndexChanged += new System.EventHandler(this.CbxConducMvt_SelectedIndexChanged);
            // 
            // TbxDescriptionMvt
            // 
            this.TbxDescriptionMvt.Location = new System.Drawing.Point(119, 130);
            this.TbxDescriptionMvt.Name = "TbxDescriptionMvt";
            this.TbxDescriptionMvt.Size = new System.Drawing.Size(278, 22);
            this.TbxDescriptionMvt.TabIndex = 13;
            // 
            // TbxCodMvt
            // 
            this.TbxCodMvt.BackColor = System.Drawing.Color.Khaki;
            this.TbxCodMvt.Location = new System.Drawing.Point(119, 27);
            this.TbxCodMvt.Name = "TbxCodMvt";
            this.TbxCodMvt.ReadOnly = true;
            this.TbxCodMvt.Size = new System.Drawing.Size(169, 22);
            this.TbxCodMvt.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(26, 304);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "Note";
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
            // FormCreateMouvement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.PanelFormMvt);
            this.Controls.Add(this.paneltitleFormCreateMvt);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCreateMouvement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCreateMouvement";
            this.paneltitleFormCreateMvt.ResumeLayout(false);
            this.PanelFormMvt.ResumeLayout(false);
            this.PanelFormMvt.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltitleFormCreateMvt;
        private FontAwesome.Sharp.IconButton IbtnRegisterMvt;
        private System.Windows.Forms.Panel PanelFormMvt;
        private System.Windows.Forms.RichTextBox RtbxNoteMvt;
        private System.Windows.Forms.ComboBox CbxStatutMvt;
        private System.Windows.Forms.ComboBox CbxConducMvt;
        private System.Windows.Forms.TextBox TbxDescriptionMvt;
        private System.Windows.Forms.TextBox TbxCodMvt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbxLieuMvts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TbxKiloParcouApresMvt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbxKilometreAvantMvt;
        private System.Windows.Forms.DateTimePicker DateArriveeMvt;
        private System.Windows.Forms.DateTimePicker DateDepartMvt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CbxVehicule;
    }
}