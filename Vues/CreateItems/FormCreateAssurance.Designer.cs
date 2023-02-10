
namespace GestPark
{
    partial class FormCreateAssurance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateAssurance));
            this.txtAmountAssur = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxStatutAssur = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNoteAssur = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxCarAssur = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateRegisterAssur = new System.Windows.Forms.DateTimePicker();
            this.txtCodeAssur = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconBtUploadDocAssu = new FontAwesome.Sharp.IconButton();
            this.iconBtnCloseFormCreateAssur = new FontAwesome.Sharp.IconButton();
            this.iconBtnSavedAssurance = new FontAwesome.Sharp.IconButton();
            this.txtAssureur = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxTypeAssur = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAmountAssur
            // 
            this.txtAmountAssur.BackColor = System.Drawing.Color.White;
            this.txtAmountAssur.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountAssur.ForeColor = System.Drawing.Color.YellowGreen;
            this.txtAmountAssur.Location = new System.Drawing.Point(104, 220);
            this.txtAmountAssur.Name = "txtAmountAssur";
            this.txtAmountAssur.Size = new System.Drawing.Size(237, 27);
            this.txtAmountAssur.TabIndex = 34;
            this.txtAmountAssur.Text = "0";
            this.txtAmountAssur.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(8, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 33;
            this.label9.Text = "Coût *";
            // 
            // cbxStatutAssur
            // 
            this.cbxStatutAssur.BackColor = System.Drawing.Color.White;
            this.cbxStatutAssur.FormattingEnabled = true;
            this.cbxStatutAssur.Items.AddRange(new object[] {
            "",
            "En cours",
            "Assuré"});
            this.cbxStatutAssur.Location = new System.Drawing.Point(512, 55);
            this.cbxStatutAssur.Name = "cbxStatutAssur";
            this.cbxStatutAssur.Size = new System.Drawing.Size(133, 28);
            this.cbxStatutAssur.TabIndex = 32;
            this.cbxStatutAssur.Text = "En cours";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(401, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Statut";
            // 
            // txtNoteAssur
            // 
            this.txtNoteAssur.BackColor = System.Drawing.Color.White;
            this.txtNoteAssur.Location = new System.Drawing.Point(104, 274);
            this.txtNoteAssur.Name = "txtNoteAssur";
            this.txtNoteAssur.Size = new System.Drawing.Size(237, 67);
            this.txtNoteAssur.TabIndex = 30;
            this.txtNoteAssur.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(10, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Notes";
            // 
            // cbxCarAssur
            // 
            this.cbxCarAssur.BackColor = System.Drawing.Color.White;
            this.cbxCarAssur.FormattingEnabled = true;
            this.cbxCarAssur.Location = new System.Drawing.Point(104, 114);
            this.cbxCarAssur.Name = "cbxCarAssur";
            this.cbxCarAssur.Size = new System.Drawing.Size(237, 28);
            this.cbxCarAssur.TabIndex = 28;
            this.cbxCarAssur.SelectedIndexChanged += new System.EventHandler(this.cbxCarAssur_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(8, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Voiture *";
            // 
            // dateRegisterAssur
            // 
            this.dateRegisterAssur.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateRegisterAssur.Location = new System.Drawing.Point(512, 114);
            this.dateRegisterAssur.Name = "dateRegisterAssur";
            this.dateRegisterAssur.Size = new System.Drawing.Size(133, 28);
            this.dateRegisterAssur.TabIndex = 23;
            // 
            // txtCodeAssur
            // 
            this.txtCodeAssur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.txtCodeAssur.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodeAssur.ForeColor = System.Drawing.Color.Black;
            this.txtCodeAssur.Location = new System.Drawing.Point(104, 54);
            this.txtCodeAssur.Name = "txtCodeAssur";
            this.txtCodeAssur.ReadOnly = true;
            this.txtCodeAssur.Size = new System.Drawing.Size(103, 29);
            this.txtCodeAssur.TabIndex = 22;
            this.txtCodeAssur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Code";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.iconBtUploadDocAssu);
            this.panel1.Controls.Add(this.iconBtnCloseFormCreateAssur);
            this.panel1.Controls.Add(this.iconBtnSavedAssurance);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 25);
            this.panel1.TabIndex = 18;
            // 
            // iconBtUploadDocAssu
            // 
            this.iconBtUploadDocAssu.BackColor = System.Drawing.Color.White;
            this.iconBtUploadDocAssu.ForeColor = System.Drawing.Color.YellowGreen;
            this.iconBtUploadDocAssu.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.iconBtUploadDocAssu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(13)))));
            this.iconBtUploadDocAssu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtUploadDocAssu.IconSize = 20;
            this.iconBtUploadDocAssu.Location = new System.Drawing.Point(33, -2);
            this.iconBtUploadDocAssu.Name = "iconBtUploadDocAssu";
            this.iconBtUploadDocAssu.Size = new System.Drawing.Size(34, 25);
            this.iconBtUploadDocAssu.TabIndex = 3;
            this.iconBtUploadDocAssu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtUploadDocAssu.UseVisualStyleBackColor = false;
            this.iconBtUploadDocAssu.MouseHover += new System.EventHandler(this.iconBtUploadDocAssu_MouseHover);
            // 
            // iconBtnCloseFormCreateAssur
            // 
            this.iconBtnCloseFormCreateAssur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnCloseFormCreateAssur.BackColor = System.Drawing.Color.White;
            this.iconBtnCloseFormCreateAssur.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.iconBtnCloseFormCreateAssur.IconColor = System.Drawing.Color.Red;
            this.iconBtnCloseFormCreateAssur.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnCloseFormCreateAssur.IconSize = 35;
            this.iconBtnCloseFormCreateAssur.Location = new System.Drawing.Point(998, 0);
            this.iconBtnCloseFormCreateAssur.Name = "iconBtnCloseFormCreateAssur";
            this.iconBtnCloseFormCreateAssur.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.iconBtnCloseFormCreateAssur.Size = new System.Drawing.Size(40, 21);
            this.iconBtnCloseFormCreateAssur.TabIndex = 1;
            this.iconBtnCloseFormCreateAssur.UseVisualStyleBackColor = false;
            this.iconBtnCloseFormCreateAssur.Click += new System.EventHandler(this.iconBtnCloseFormCreateAssur_Click);
            // 
            // iconBtnSavedAssurance
            // 
            this.iconBtnSavedAssurance.BackColor = System.Drawing.Color.White;
            this.iconBtnSavedAssurance.ForeColor = System.Drawing.Color.YellowGreen;
            this.iconBtnSavedAssurance.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.iconBtnSavedAssurance.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(147)))), ((int)(((byte)(222)))));
            this.iconBtnSavedAssurance.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnSavedAssurance.IconSize = 20;
            this.iconBtnSavedAssurance.Location = new System.Drawing.Point(-2, -2);
            this.iconBtnSavedAssurance.Name = "iconBtnSavedAssurance";
            this.iconBtnSavedAssurance.Size = new System.Drawing.Size(29, 25);
            this.iconBtnSavedAssurance.TabIndex = 0;
            this.iconBtnSavedAssurance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnSavedAssurance.UseVisualStyleBackColor = false;
            this.iconBtnSavedAssurance.Click += new System.EventHandler(this.iconBtnSavedAssurance_Click);
            this.iconBtnSavedAssurance.MouseHover += new System.EventHandler(this.iconBtnSavedAssurance_MouseHover);
            // 
            // txtAssureur
            // 
            this.txtAssureur.BackColor = System.Drawing.Color.White;
            this.txtAssureur.Location = new System.Drawing.Point(104, 165);
            this.txtAssureur.Name = "txtAssureur";
            this.txtAssureur.Size = new System.Drawing.Size(237, 28);
            this.txtAssureur.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(11, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Assureur *";
            // 
            // cbxTypeAssur
            // 
            this.cbxTypeAssur.BackColor = System.Drawing.Color.White;
            this.cbxTypeAssur.FormattingEnabled = true;
            this.cbxTypeAssur.Items.AddRange(new object[] {
            "",
            "Tout risque"});
            this.cbxTypeAssur.Location = new System.Drawing.Point(512, 183);
            this.cbxTypeAssur.Name = "cbxTypeAssur";
            this.cbxTypeAssur.Size = new System.Drawing.Size(133, 28);
            this.cbxTypeAssur.TabIndex = 41;
            this.cbxTypeAssur.Text = "Tout risque";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Type d\'assur.";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 379);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(683, 17);
            this.panel2.TabIndex = 42;
            // 
            // FormCreateAssurance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(683, 396);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cbxTypeAssur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAssureur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAmountAssur);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxStatutAssur);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNoteAssur);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxCarAssur);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateRegisterAssur);
            this.Controls.Add(this.txtCodeAssur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCreateAssurance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saisir une assurance";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconBtUploadDocAssu;
        private FontAwesome.Sharp.IconButton iconBtnSavedAssurance;
        private System.Windows.Forms.TextBox txtAmountAssur;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxStatutAssur;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox txtNoteAssur;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateRegisterAssur;
        private System.Windows.Forms.TextBox txtCodeAssur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconBtnCloseFormCreateAssur;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAssureur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxTypeAssur;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cbxCarAssur;
        private System.Windows.Forms.Panel panel2;
    }
}