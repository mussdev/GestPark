
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
            this.iconBtUploadDocMaint = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.iconBtnSavedMaint = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCodeMaint = new System.Windows.Forms.TextBox();
            this.DatePickerCreateMaint = new System.Windows.Forms.DateTimePicker();
            this.CbxGarageMaint = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CbxCarMaint = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RtxtNotesMaint = new System.Windows.Forms.RichTextBox();
            this.CbxStatutMaint = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtPrixMaint = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CbxTypeEntretienMaint = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtStationMaint = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.iconBtUploadDocMaint);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.iconBtnSavedMaint);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 27);
            this.panel1.TabIndex = 0;
            // 
            // iconBtUploadDocMaint
            // 
            this.iconBtUploadDocMaint.BackColor = System.Drawing.Color.White;
            this.iconBtUploadDocMaint.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.iconBtUploadDocMaint.IconColor = System.Drawing.Color.DarkGreen;
            this.iconBtUploadDocMaint.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtUploadDocMaint.IconSize = 20;
            this.iconBtUploadDocMaint.Location = new System.Drawing.Point(115, -2);
            this.iconBtUploadDocMaint.Name = "iconBtUploadDocMaint";
            this.iconBtUploadDocMaint.Size = new System.Drawing.Size(109, 26);
            this.iconBtUploadDocMaint.TabIndex = 3;
            this.iconBtUploadDocMaint.Text = "Joindre doc.";
            this.iconBtUploadDocMaint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtUploadDocMaint.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(310, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(314, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Entretenir votre voiture pour une meilleur visite technique";
            // 
            // iconBtnSavedMaint
            // 
            this.iconBtnSavedMaint.BackColor = System.Drawing.Color.White;
            this.iconBtnSavedMaint.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.iconBtnSavedMaint.IconColor = System.Drawing.Color.DarkGreen;
            this.iconBtnSavedMaint.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnSavedMaint.IconSize = 20;
            this.iconBtnSavedMaint.Location = new System.Drawing.Point(-2, -2);
            this.iconBtnSavedMaint.Name = "iconBtnSavedMaint";
            this.iconBtnSavedMaint.Size = new System.Drawing.Size(111, 26);
            this.iconBtnSavedMaint.TabIndex = 0;
            this.iconBtnSavedMaint.Text = "Enregistrer";
            this.iconBtnSavedMaint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnSavedMaint.UseVisualStyleBackColor = false;
            this.iconBtnSavedMaint.Click += new System.EventHandler(this.iconBtnSavedMaint_Click);
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
            // TxtCodeMaint
            // 
            this.TxtCodeMaint.BackColor = System.Drawing.Color.Khaki;
            this.TxtCodeMaint.Location = new System.Drawing.Point(72, 56);
            this.TxtCodeMaint.Name = "TxtCodeMaint";
            this.TxtCodeMaint.ReadOnly = true;
            this.TxtCodeMaint.Size = new System.Drawing.Size(154, 22);
            this.TxtCodeMaint.TabIndex = 4;
            // 
            // DatePickerCreateMaint
            // 
            this.DatePickerCreateMaint.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePickerCreateMaint.Location = new System.Drawing.Point(150, 62);
            this.DatePickerCreateMaint.Name = "DatePickerCreateMaint";
            this.DatePickerCreateMaint.Size = new System.Drawing.Size(236, 22);
            this.DatePickerCreateMaint.TabIndex = 5;
            // 
            // CbxGarageMaint
            // 
            this.CbxGarageMaint.FormattingEnabled = true;
            this.CbxGarageMaint.Location = new System.Drawing.Point(72, 110);
            this.CbxGarageMaint.Name = "CbxGarageMaint";
            this.CbxGarageMaint.Size = new System.Drawing.Size(288, 23);
            this.CbxGarageMaint.TabIndex = 6;
            this.CbxGarageMaint.SelectedIndexChanged += new System.EventHandler(this.CbxGarageMaint_SelectedIndexChanged);
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
            // CbxCarMaint
            // 
            this.CbxCarMaint.FormattingEnabled = true;
            this.CbxCarMaint.Location = new System.Drawing.Point(72, 163);
            this.CbxCarMaint.Name = "CbxCarMaint";
            this.CbxCarMaint.Size = new System.Drawing.Size(288, 23);
            this.CbxCarMaint.TabIndex = 10;
            this.CbxCarMaint.SelectedIndexChanged += new System.EventHandler(this.CbxCarMaint_SelectedIndexChanged);
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
            this.label7.Location = new System.Drawing.Point(13, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Notes";
            // 
            // RtxtNotesMaint
            // 
            this.RtxtNotesMaint.Location = new System.Drawing.Point(72, 362);
            this.RtxtNotesMaint.Name = "RtxtNotesMaint";
            this.RtxtNotesMaint.Size = new System.Drawing.Size(849, 101);
            this.RtxtNotesMaint.TabIndex = 13;
            this.RtxtNotesMaint.Text = "";
            // 
            // CbxStatutMaint
            // 
            this.CbxStatutMaint.FormattingEnabled = true;
            this.CbxStatutMaint.Items.AddRange(new object[] {
            "En cours"});
            this.CbxStatutMaint.Location = new System.Drawing.Point(150, 9);
            this.CbxStatutMaint.Name = "CbxStatutMaint";
            this.CbxStatutMaint.Size = new System.Drawing.Size(146, 23);
            this.CbxStatutMaint.TabIndex = 15;
            this.CbxStatutMaint.Text = "En cours";
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
            // TxtPrixMaint
            // 
            this.TxtPrixMaint.Location = new System.Drawing.Point(72, 212);
            this.TxtPrixMaint.Name = "TxtPrixMaint";
            this.TxtPrixMaint.Size = new System.Drawing.Size(288, 22);
            this.TxtPrixMaint.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 219);
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
            this.panel2.Controls.Add(this.DatePickerCreateMaint);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.CbxStatutMaint);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(505, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 171);
            this.panel2.TabIndex = 19;
            // 
            // TxtStationMaint
            // 
            this.TxtStationMaint.Location = new System.Drawing.Point(72, 262);
            this.TxtStationMaint.Name = "TxtStationMaint";
            this.TxtStationMaint.Size = new System.Drawing.Size(288, 22);
            this.TxtStationMaint.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Station";
            // 
            // FormCreateEntretien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.TxtStationMaint);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TxtPrixMaint);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.RtxtNotesMaint);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CbxCarMaint);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CbxGarageMaint);
            this.Controls.Add(this.TxtCodeMaint);
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
        private FontAwesome.Sharp.IconButton iconBtnSavedMaint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCodeMaint;
        private FontAwesome.Sharp.IconButton iconBtUploadDocMaint;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DatePickerCreateMaint;
        private System.Windows.Forms.ComboBox CbxGarageMaint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbxCarMaint;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox RtxtNotesMaint;
        private System.Windows.Forms.ComboBox CbxStatutMaint;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtPrixMaint;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CbxTypeEntretienMaint;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtStationMaint;
        private System.Windows.Forms.Label label10;
    }
}