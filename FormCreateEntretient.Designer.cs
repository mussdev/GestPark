
namespace GestPark
{
    partial class FormCreateEntretien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateEntretien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconBtUploadDocMaintModi = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.iconBtnSavedMaintModi = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCodeMaintModi = new System.Windows.Forms.TextBox();
            this.DatePickerCreateMaintModi = new System.Windows.Forms.DateTimePicker();
            this.CbxGarageMaintModi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CbxCarMaintModi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RtxtNotesMaintModi = new System.Windows.Forms.RichTextBox();
            this.CbxStatutMaintModi = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtPrixMaintModi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CbxTypeEntretienMaint = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtStationMaintModi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtKiloVidengeModi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.iconBtUploadDocMaintModi);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.iconBtnSavedMaintModi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 27);
            this.panel1.TabIndex = 0;
            // 
            // iconBtUploadDocMaintModi
            // 
            this.iconBtUploadDocMaintModi.BackColor = System.Drawing.Color.White;
            this.iconBtUploadDocMaintModi.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.iconBtUploadDocMaintModi.IconColor = System.Drawing.Color.DarkGreen;
            this.iconBtUploadDocMaintModi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtUploadDocMaintModi.IconSize = 20;
            this.iconBtUploadDocMaintModi.Location = new System.Drawing.Point(115, -2);
            this.iconBtUploadDocMaintModi.Name = "iconBtUploadDocMaintModi";
            this.iconBtUploadDocMaintModi.Size = new System.Drawing.Size(109, 26);
            this.iconBtUploadDocMaintModi.TabIndex = 3;
            this.iconBtUploadDocMaintModi.Text = "Joindre doc.";
            this.iconBtUploadDocMaintModi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtUploadDocMaintModi.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Khaki;
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(310, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(314, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Entretenir votre voiture pour une meilleur visite technique";
            // 
            // iconBtnSavedMaintModi
            // 
            this.iconBtnSavedMaintModi.BackColor = System.Drawing.Color.White;
            this.iconBtnSavedMaintModi.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.iconBtnSavedMaintModi.IconColor = System.Drawing.Color.DarkGreen;
            this.iconBtnSavedMaintModi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnSavedMaintModi.IconSize = 20;
            this.iconBtnSavedMaintModi.Location = new System.Drawing.Point(-2, -2);
            this.iconBtnSavedMaintModi.Name = "iconBtnSavedMaintModi";
            this.iconBtnSavedMaintModi.Size = new System.Drawing.Size(111, 26);
            this.iconBtnSavedMaintModi.TabIndex = 0;
            this.iconBtnSavedMaintModi.Text = "Enregistrer";
            this.iconBtnSavedMaintModi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnSavedMaintModi.UseVisualStyleBackColor = false;
            this.iconBtnSavedMaintModi.Click += new System.EventHandler(this.iconBtnSavedMaint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(13, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Garage";
            // 
            // TxtCodeMaintModi
            // 
            this.TxtCodeMaintModi.BackColor = System.Drawing.Color.YellowGreen;
            this.TxtCodeMaintModi.Location = new System.Drawing.Point(72, 56);
            this.TxtCodeMaintModi.Name = "TxtCodeMaintModi";
            this.TxtCodeMaintModi.ReadOnly = true;
            this.TxtCodeMaintModi.Size = new System.Drawing.Size(154, 22);
            this.TxtCodeMaintModi.TabIndex = 4;
            // 
            // DatePickerCreateMaintModi
            // 
            this.DatePickerCreateMaintModi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePickerCreateMaintModi.Location = new System.Drawing.Point(150, 62);
            this.DatePickerCreateMaintModi.Name = "DatePickerCreateMaintModi";
            this.DatePickerCreateMaintModi.Size = new System.Drawing.Size(236, 22);
            this.DatePickerCreateMaintModi.TabIndex = 5;
            // 
            // CbxGarageMaintModi
            // 
            this.CbxGarageMaintModi.FormattingEnabled = true;
            this.CbxGarageMaintModi.Location = new System.Drawing.Point(72, 110);
            this.CbxGarageMaintModi.Name = "CbxGarageMaintModi";
            this.CbxGarageMaintModi.Size = new System.Drawing.Size(288, 23);
            this.CbxGarageMaintModi.TabIndex = 6;
            this.CbxGarageMaintModi.SelectedIndexChanged += new System.EventHandler(this.CbxGarageMaint_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Type d\'entretien";
            // 
            // CbxCarMaintModi
            // 
            this.CbxCarMaintModi.FormattingEnabled = true;
            this.CbxCarMaintModi.Location = new System.Drawing.Point(72, 163);
            this.CbxCarMaintModi.Name = "CbxCarMaintModi";
            this.CbxCarMaintModi.Size = new System.Drawing.Size(288, 23);
            this.CbxCarMaintModi.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(13, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Voiture";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(13, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Notes";
            // 
            // RtxtNotesMaintModi
            // 
            this.RtxtNotesMaintModi.Location = new System.Drawing.Point(72, 374);
            this.RtxtNotesMaintModi.Name = "RtxtNotesMaintModi";
            this.RtxtNotesMaintModi.Size = new System.Drawing.Size(849, 101);
            this.RtxtNotesMaintModi.TabIndex = 13;
            this.RtxtNotesMaintModi.Text = "";
            // 
            // CbxStatutMaintModi
            // 
            this.CbxStatutMaintModi.FormattingEnabled = true;
            this.CbxStatutMaintModi.Items.AddRange(new object[] {
            "En cours"});
            this.CbxStatutMaintModi.Location = new System.Drawing.Point(150, 9);
            this.CbxStatutMaintModi.Name = "CbxStatutMaintModi";
            this.CbxStatutMaintModi.Size = new System.Drawing.Size(146, 23);
            this.CbxStatutMaintModi.TabIndex = 15;
            this.CbxStatutMaintModi.Text = "En cours";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Statut";
            // 
            // TxtPrixMaintModi
            // 
            this.TxtPrixMaintModi.Location = new System.Drawing.Point(72, 260);
            this.TxtPrixMaintModi.Name = "TxtPrixMaintModi";
            this.TxtPrixMaintModi.Size = new System.Drawing.Size(288, 22);
            this.TxtPrixMaintModi.TabIndex = 17;
            this.TxtPrixMaintModi.Text = "0.00";
            this.TxtPrixMaintModi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Prix";
            // 
            // CbxTypeEntretienMaint
            // 
            this.CbxTypeEntretienMaint.FormattingEnabled = true;
            this.CbxTypeEntretienMaint.Items.AddRange(new object[] {
            "",
            "Videnge",
            "Visite technique",
            "Autre"});
            this.CbxTypeEntretienMaint.Location = new System.Drawing.Point(150, 115);
            this.CbxTypeEntretienMaint.Name = "CbxTypeEntretienMaint";
            this.CbxTypeEntretienMaint.Size = new System.Drawing.Size(236, 23);
            this.CbxTypeEntretienMaint.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.CbxTypeEntretienMaint);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.DatePickerCreateMaintModi);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.CbxStatutMaintModi);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(505, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 171);
            this.panel2.TabIndex = 19;
            // 
            // TxtStationMaintModi
            // 
            this.TxtStationMaintModi.Location = new System.Drawing.Point(72, 310);
            this.TxtStationMaintModi.Name = "TxtStationMaintModi";
            this.TxtStationMaintModi.Size = new System.Drawing.Size(288, 22);
            this.TxtStationMaintModi.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 317);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Station";
            // 
            // TxtKiloVidengeModi
            // 
            this.TxtKiloVidengeModi.BackColor = System.Drawing.Color.YellowGreen;
            this.TxtKiloVidengeModi.Location = new System.Drawing.Point(72, 212);
            this.TxtKiloVidengeModi.Name = "TxtKiloVidengeModi";
            this.TxtKiloVidengeModi.ReadOnly = true;
            this.TxtKiloVidengeModi.Size = new System.Drawing.Size(288, 22);
            this.TxtKiloVidengeModi.TabIndex = 23;
            this.TxtKiloVidengeModi.Text = "0.00";
            this.TxtKiloVidengeModi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 219);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "Kilo. vdge";
            // 
            // FormCreateEntretien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.TxtKiloVidengeModi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtStationMaintModi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TxtPrixMaintModi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.RtxtNotesMaintModi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CbxCarMaintModi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CbxGarageMaintModi);
            this.Controls.Add(this.TxtCodeMaintModi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCreateEntretien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entretien de véhicule";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconBtnSavedMaintModi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCodeMaintModi;
        private FontAwesome.Sharp.IconButton iconBtUploadDocMaintModi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DatePickerCreateMaintModi;
        private System.Windows.Forms.ComboBox CbxGarageMaintModi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox RtxtNotesMaintModi;
        private System.Windows.Forms.ComboBox CbxStatutMaintModi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtPrixMaintModi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CbxTypeEntretienMaint;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtStationMaintModi;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox CbxCarMaintModi;
        private System.Windows.Forms.TextBox TxtKiloVidengeModi;
        private System.Windows.Forms.Label label11;
    }
}