
namespace GestPark
{
    partial class FormCreateVisitTechCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateVisitTechCar));
            this.txtEntreprise = new System.Windows.Forms.TextBox();
            this.txtFraisGaragiste = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxStatutVisitTech = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rtxtNote = new System.Windows.Forms.RichTextBox();
            this.cbxCarVisitTech = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateRegisterVisitTech = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodVisitTech = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconBtUploadDocVisit = new FontAwesome.Sharp.IconButton();
            this.iconBtnSavedVisit = new FontAwesome.Sharp.IconButton();
            this.txtFraisDossierVisit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFraisVignette = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxGaragistre = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGarageVisit = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEntreprise
            // 
            this.txtEntreprise.BackColor = System.Drawing.Color.White;
            this.txtEntreprise.Location = new System.Drawing.Point(164, 161);
            this.txtEntreprise.Name = "txtEntreprise";
            this.txtEntreprise.Size = new System.Drawing.Size(238, 28);
            this.txtEntreprise.TabIndex = 57;
            // 
            // txtFraisGaragiste
            // 
            this.txtFraisGaragiste.BackColor = System.Drawing.Color.White;
            this.txtFraisGaragiste.ForeColor = System.Drawing.Color.YellowGreen;
            this.txtFraisGaragiste.Location = new System.Drawing.Point(164, 325);
            this.txtFraisGaragiste.Name = "txtFraisGaragiste";
            this.txtFraisGaragiste.Size = new System.Drawing.Size(238, 28);
            this.txtFraisGaragiste.TabIndex = 56;
            this.txtFraisGaragiste.Text = "0";
            this.txtFraisGaragiste.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(13, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 20);
            this.label9.TabIndex = 55;
            this.label9.Text = "Frais garagistre *";
            // 
            // cbxStatutVisitTech
            // 
            this.cbxStatutVisitTech.BackColor = System.Drawing.Color.White;
            this.cbxStatutVisitTech.FormattingEnabled = true;
            this.cbxStatutVisitTech.Items.AddRange(new object[] {
            "En cours",
            "Succès",
            "Echec"});
            this.cbxStatutVisitTech.Location = new System.Drawing.Point(90, 17);
            this.cbxStatutVisitTech.Name = "cbxStatutVisitTech";
            this.cbxStatutVisitTech.Size = new System.Drawing.Size(205, 28);
            this.cbxStatutVisitTech.TabIndex = 54;
            this.cbxStatutVisitTech.Text = "En cours";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 53;
            this.label8.Text = "Statut";
            // 
            // rtxtNote
            // 
            this.rtxtNote.BackColor = System.Drawing.Color.White;
            this.rtxtNote.Location = new System.Drawing.Point(437, 330);
            this.rtxtNote.Name = "rtxtNote";
            this.rtxtNote.Size = new System.Drawing.Size(282, 62);
            this.rtxtNote.TabIndex = 52;
            this.rtxtNote.Text = "";
            // 
            // cbxCarVisitTech
            // 
            this.cbxCarVisitTech.BackColor = System.Drawing.Color.White;
            this.cbxCarVisitTech.FormattingEnabled = true;
            this.cbxCarVisitTech.Location = new System.Drawing.Point(164, 107);
            this.cbxCarVisitTech.Name = "cbxCarVisitTech";
            this.cbxCarVisitTech.Size = new System.Drawing.Size(238, 28);
            this.cbxCarVisitTech.TabIndex = 50;
            this.cbxCarVisitTech.SelectedIndexChanged += new System.EventHandler(this.cbxCarVisitTech_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(14, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "Voiture *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(14, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Entreprise *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Date";
            // 
            // dateRegisterVisitTech
            // 
            this.dateRegisterVisitTech.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateRegisterVisitTech.Location = new System.Drawing.Point(90, 82);
            this.dateRegisterVisitTech.Name = "dateRegisterVisitTech";
            this.dateRegisterVisitTech.Size = new System.Drawing.Size(205, 28);
            this.dateRegisterVisitTech.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Code";
            // 
            // txtCodVisitTech
            // 
            this.txtCodVisitTech.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.txtCodVisitTech.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodVisitTech.ForeColor = System.Drawing.Color.Black;
            this.txtCodVisitTech.Location = new System.Drawing.Point(164, 50);
            this.txtCodVisitTech.Name = "txtCodVisitTech";
            this.txtCodVisitTech.ReadOnly = true;
            this.txtCodVisitTech.Size = new System.Drawing.Size(125, 29);
            this.txtCodVisitTech.TabIndex = 45;
            this.txtCodVisitTech.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.iconBtUploadDocVisit);
            this.panel1.Controls.Add(this.iconBtnSavedVisit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 29);
            this.panel1.TabIndex = 41;
            // 
            // iconBtUploadDocVisit
            // 
            this.iconBtUploadDocVisit.BackColor = System.Drawing.Color.White;
            this.iconBtUploadDocVisit.ForeColor = System.Drawing.Color.YellowGreen;
            this.iconBtUploadDocVisit.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.iconBtUploadDocVisit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(13)))));
            this.iconBtUploadDocVisit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtUploadDocVisit.IconSize = 20;
            this.iconBtUploadDocVisit.Location = new System.Drawing.Point(34, -2);
            this.iconBtUploadDocVisit.Name = "iconBtUploadDocVisit";
            this.iconBtUploadDocVisit.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.iconBtUploadDocVisit.Size = new System.Drawing.Size(32, 29);
            this.iconBtUploadDocVisit.TabIndex = 3;
            this.iconBtUploadDocVisit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtUploadDocVisit.UseVisualStyleBackColor = false;
            this.iconBtUploadDocVisit.MouseHover += new System.EventHandler(this.iconBtUploadDocVisit_MouseHover);
            // 
            // iconBtnSavedVisit
            // 
            this.iconBtnSavedVisit.BackColor = System.Drawing.Color.White;
            this.iconBtnSavedVisit.ForeColor = System.Drawing.Color.YellowGreen;
            this.iconBtnSavedVisit.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.iconBtnSavedVisit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(147)))), ((int)(((byte)(222)))));
            this.iconBtnSavedVisit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnSavedVisit.IconSize = 20;
            this.iconBtnSavedVisit.Location = new System.Drawing.Point(0, -2);
            this.iconBtnSavedVisit.Name = "iconBtnSavedVisit";
            this.iconBtnSavedVisit.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.iconBtnSavedVisit.Size = new System.Drawing.Size(28, 29);
            this.iconBtnSavedVisit.TabIndex = 0;
            this.iconBtnSavedVisit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnSavedVisit.UseVisualStyleBackColor = false;
            this.iconBtnSavedVisit.Click += new System.EventHandler(this.iconBtnSavedVisit_Click);
            this.iconBtnSavedVisit.MouseHover += new System.EventHandler(this.iconBtnSavedVisit_MouseHover);
            // 
            // txtFraisDossierVisit
            // 
            this.txtFraisDossierVisit.BackColor = System.Drawing.Color.White;
            this.txtFraisDossierVisit.ForeColor = System.Drawing.Color.YellowGreen;
            this.txtFraisDossierVisit.Location = new System.Drawing.Point(164, 217);
            this.txtFraisDossierVisit.Name = "txtFraisDossierVisit";
            this.txtFraisDossierVisit.Size = new System.Drawing.Size(238, 28);
            this.txtFraisDossierVisit.TabIndex = 59;
            this.txtFraisDossierVisit.Text = "0";
            this.txtFraisDossierVisit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(12, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 58;
            this.label4.Text = "Frais de dossier *";
            // 
            // txtFraisVignette
            // 
            this.txtFraisVignette.BackColor = System.Drawing.Color.White;
            this.txtFraisVignette.ForeColor = System.Drawing.Color.YellowGreen;
            this.txtFraisVignette.Location = new System.Drawing.Point(164, 272);
            this.txtFraisVignette.Name = "txtFraisVignette";
            this.txtFraisVignette.Size = new System.Drawing.Size(238, 28);
            this.txtFraisVignette.TabIndex = 61;
            this.txtFraisVignette.Text = "0";
            this.txtFraisVignette.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(12, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 20);
            this.label6.TabIndex = 60;
            this.label6.Text = "Frais de vignette *";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.cbxStatutVisitTech);
            this.panel2.Controls.Add(this.dateRegisterVisitTech);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(422, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 139);
            this.panel2.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(418, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 63;
            this.label7.Text = "Garagiste *";
            // 
            // cbxGaragistre
            // 
            this.cbxGaragistre.FormattingEnabled = true;
            this.cbxGaragistre.Location = new System.Drawing.Point(514, 222);
            this.cbxGaragistre.Name = "cbxGaragistre";
            this.cbxGaragistre.Size = new System.Drawing.Size(205, 28);
            this.cbxGaragistre.TabIndex = 64;
            this.cbxGaragistre.SelectedIndexChanged += new System.EventHandler(this.cbxGaragistre_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(418, 285);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 65;
            this.label10.Text = "Garage";
            // 
            // txtGarageVisit
            // 
            this.txtGarageVisit.BackColor = System.Drawing.Color.White;
            this.txtGarageVisit.Location = new System.Drawing.Point(514, 277);
            this.txtGarageVisit.Name = "txtGarageVisit";
            this.txtGarageVisit.Size = new System.Drawing.Size(205, 28);
            this.txtGarageVisit.TabIndex = 66;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(0, 410);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(760, 20);
            this.panel3.TabIndex = 67;
            // 
            // FormCreateVisitTechCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(760, 430);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtGarageVisit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbxGaragistre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtFraisVignette);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFraisDossierVisit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEntreprise);
            this.Controls.Add(this.txtFraisGaragiste);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rtxtNote);
            this.Controls.Add(this.cbxCarVisitTech);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodVisitTech);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCreateVisitTechCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saisir une visite technique";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEntreprise;
        private System.Windows.Forms.TextBox txtFraisGaragiste;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxStatutVisitTech;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtxtNote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconBtUploadDocVisit;
        private FontAwesome.Sharp.IconButton iconBtnSavedVisit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateRegisterVisitTech;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodVisitTech;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFraisDossierVisit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFraisVignette;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxGaragistre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGarageVisit;
        public System.Windows.Forms.ComboBox cbxCarVisitTech;
        private System.Windows.Forms.Panel panel3;
    }
}