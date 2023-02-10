
namespace GestPark
{
    partial class FormCreatePreparVisit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreatePreparVisit));
            this.panelCreateFormFournTitle = new System.Windows.Forms.Panel();
            this.BtnImportPrepaVisit = new FontAwesome.Sharp.IconButton();
            this.BtnSavedPrepaVisit = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RTxtNotePrepaVisit = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ChekPneusPrepaVisit = new System.Windows.Forms.CheckBox();
            this.CheckGazEchappPrepaVisit = new System.Windows.Forms.CheckBox();
            this.CheckFreinagePrepaVisit = new System.Windows.Forms.CheckBox();
            this.CheckReglagePharePrepaVisit = new System.Windows.Forms.CheckBox();
            this.CheckParallelismePrepaVisit = new System.Windows.Forms.CheckBox();
            this.DatePikerRegisterPrepaVisit = new System.Windows.Forms.DateTimePicker();
            this.CbxGaragePrepaVisit = new System.Windows.Forms.ComboBox();
            this.CbxCarPrepaVisit = new System.Windows.Forms.ComboBox();
            this.TxtMontantPrepaVisit = new System.Windows.Forms.TextBox();
            this.TxtMecanicienPrepaVisit = new System.Windows.Forms.TextBox();
            this.TxtCodePrepaVisit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelCreateFormFournTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCreateFormFournTitle
            // 
            this.panelCreateFormFournTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.panelCreateFormFournTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCreateFormFournTitle.Controls.Add(this.BtnImportPrepaVisit);
            this.panelCreateFormFournTitle.Controls.Add(this.BtnSavedPrepaVisit);
            this.panelCreateFormFournTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCreateFormFournTitle.Location = new System.Drawing.Point(0, 0);
            this.panelCreateFormFournTitle.Name = "panelCreateFormFournTitle";
            this.panelCreateFormFournTitle.Size = new System.Drawing.Size(685, 24);
            this.panelCreateFormFournTitle.TabIndex = 3;
            // 
            // BtnImportPrepaVisit
            // 
            this.BtnImportPrepaVisit.BackColor = System.Drawing.Color.White;
            this.BtnImportPrepaVisit.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImportPrepaVisit.ForeColor = System.Drawing.Color.YellowGreen;
            this.BtnImportPrepaVisit.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.BtnImportPrepaVisit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(13)))));
            this.BtnImportPrepaVisit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnImportPrepaVisit.IconSize = 20;
            this.BtnImportPrepaVisit.Location = new System.Drawing.Point(34, -2);
            this.BtnImportPrepaVisit.Name = "BtnImportPrepaVisit";
            this.BtnImportPrepaVisit.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.BtnImportPrepaVisit.Size = new System.Drawing.Size(32, 24);
            this.BtnImportPrepaVisit.TabIndex = 3;
            this.BtnImportPrepaVisit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnImportPrepaVisit.UseVisualStyleBackColor = false;
            this.BtnImportPrepaVisit.MouseHover += new System.EventHandler(this.BtnImportPrepaVisit_MouseHover);
            // 
            // BtnSavedPrepaVisit
            // 
            this.BtnSavedPrepaVisit.BackColor = System.Drawing.Color.White;
            this.BtnSavedPrepaVisit.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSavedPrepaVisit.ForeColor = System.Drawing.Color.YellowGreen;
            this.BtnSavedPrepaVisit.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.BtnSavedPrepaVisit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(147)))), ((int)(((byte)(222)))));
            this.BtnSavedPrepaVisit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSavedPrepaVisit.IconSize = 20;
            this.BtnSavedPrepaVisit.Location = new System.Drawing.Point(-2, -2);
            this.BtnSavedPrepaVisit.Name = "BtnSavedPrepaVisit";
            this.BtnSavedPrepaVisit.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.BtnSavedPrepaVisit.Size = new System.Drawing.Size(30, 24);
            this.BtnSavedPrepaVisit.TabIndex = 1;
            this.BtnSavedPrepaVisit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSavedPrepaVisit.UseVisualStyleBackColor = false;
            this.BtnSavedPrepaVisit.Click += new System.EventHandler(this.BtnSavedPrepaVisit_Click);
            this.BtnSavedPrepaVisit.MouseHover += new System.EventHandler(this.BtnSavedPrepaVisit_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.RTxtNotePrepaVisit);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.ChekPneusPrepaVisit);
            this.panel1.Controls.Add(this.CheckGazEchappPrepaVisit);
            this.panel1.Controls.Add(this.CheckFreinagePrepaVisit);
            this.panel1.Controls.Add(this.CheckReglagePharePrepaVisit);
            this.panel1.Controls.Add(this.CheckParallelismePrepaVisit);
            this.panel1.Controls.Add(this.DatePikerRegisterPrepaVisit);
            this.panel1.Controls.Add(this.CbxGaragePrepaVisit);
            this.panel1.Controls.Add(this.CbxCarPrepaVisit);
            this.panel1.Controls.Add(this.TxtMontantPrepaVisit);
            this.panel1.Controls.Add(this.TxtMecanicienPrepaVisit);
            this.panel1.Controls.Add(this.TxtCodePrepaVisit);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 386);
            this.panel1.TabIndex = 4;
            // 
            // RTxtNotePrepaVisit
            // 
            this.RTxtNotePrepaVisit.BackColor = System.Drawing.Color.White;
            this.RTxtNotePrepaVisit.Location = new System.Drawing.Point(102, 296);
            this.RTxtNotePrepaVisit.Name = "RTxtNotePrepaVisit";
            this.RTxtNotePrepaVisit.Size = new System.Drawing.Size(242, 50);
            this.RTxtNotePrepaVisit.TabIndex = 43;
            this.RTxtNotePrepaVisit.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 19);
            this.label8.TabIndex = 42;
            this.label8.Text = "Note";
            // 
            // ChekPneusPrepaVisit
            // 
            this.ChekPneusPrepaVisit.AutoSize = true;
            this.ChekPneusPrepaVisit.Location = new System.Drawing.Point(393, 287);
            this.ChekPneusPrepaVisit.Name = "ChekPneusPrepaVisit";
            this.ChekPneusPrepaVisit.Size = new System.Drawing.Size(90, 21);
            this.ChekPneusPrepaVisit.TabIndex = 41;
            this.ChekPneusPrepaVisit.Text = "Les pneus";
            this.ChekPneusPrepaVisit.UseVisualStyleBackColor = true;
            this.ChekPneusPrepaVisit.MouseHover += new System.EventHandler(this.ChekPneusPrepaVisit_MouseHover);
            // 
            // CheckGazEchappPrepaVisit
            // 
            this.CheckGazEchappPrepaVisit.AutoSize = true;
            this.CheckGazEchappPrepaVisit.Location = new System.Drawing.Point(393, 230);
            this.CheckGazEchappPrepaVisit.Name = "CheckGazEchappPrepaVisit";
            this.CheckGazEchappPrepaVisit.Size = new System.Drawing.Size(145, 21);
            this.CheckGazEchappPrepaVisit.TabIndex = 40;
            this.CheckGazEchappPrepaVisit.Text = "Gaz d\'échappement";
            this.CheckGazEchappPrepaVisit.UseVisualStyleBackColor = true;
            this.CheckGazEchappPrepaVisit.MouseHover += new System.EventHandler(this.CheckGazEchappPrepaVisit_MouseHover);
            // 
            // CheckFreinagePrepaVisit
            // 
            this.CheckFreinagePrepaVisit.AutoSize = true;
            this.CheckFreinagePrepaVisit.Location = new System.Drawing.Point(393, 188);
            this.CheckFreinagePrepaVisit.Name = "CheckFreinagePrepaVisit";
            this.CheckFreinagePrepaVisit.Size = new System.Drawing.Size(81, 21);
            this.CheckFreinagePrepaVisit.TabIndex = 39;
            this.CheckFreinagePrepaVisit.Text = "Freinage";
            this.CheckFreinagePrepaVisit.UseVisualStyleBackColor = true;
            this.CheckFreinagePrepaVisit.MouseHover += new System.EventHandler(this.CheckFreinagePrepaVisit_MouseHover);
            // 
            // CheckReglagePharePrepaVisit
            // 
            this.CheckReglagePharePrepaVisit.AutoSize = true;
            this.CheckReglagePharePrepaVisit.Location = new System.Drawing.Point(393, 139);
            this.CheckReglagePharePrepaVisit.Name = "CheckReglagePharePrepaVisit";
            this.CheckReglagePharePrepaVisit.Size = new System.Drawing.Size(145, 21);
            this.CheckReglagePharePrepaVisit.TabIndex = 38;
            this.CheckReglagePharePrepaVisit.Text = "Réglage des phares";
            this.CheckReglagePharePrepaVisit.UseVisualStyleBackColor = true;
            this.CheckReglagePharePrepaVisit.MouseHover += new System.EventHandler(this.CheckReglagePharePrepaVisit_MouseHover);
            // 
            // CheckParallelismePrepaVisit
            // 
            this.CheckParallelismePrepaVisit.AutoSize = true;
            this.CheckParallelismePrepaVisit.BackColor = System.Drawing.Color.Honeydew;
            this.CheckParallelismePrepaVisit.Location = new System.Drawing.Point(393, 93);
            this.CheckParallelismePrepaVisit.Name = "CheckParallelismePrepaVisit";
            this.CheckParallelismePrepaVisit.Size = new System.Drawing.Size(243, 21);
            this.CheckParallelismePrepaVisit.TabIndex = 37;
            this.CheckParallelismePrepaVisit.Text = "Parallélisme et équilibrage des roues";
            this.CheckParallelismePrepaVisit.UseVisualStyleBackColor = false;
            this.CheckParallelismePrepaVisit.MouseHover += new System.EventHandler(this.CheckParallelismePrepaVisit_MouseHover);
            // 
            // DatePikerRegisterPrepaVisit
            // 
            this.DatePikerRegisterPrepaVisit.CalendarMonthBackground = System.Drawing.Color.Honeydew;
            this.DatePikerRegisterPrepaVisit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePikerRegisterPrepaVisit.Location = new System.Drawing.Point(564, 22);
            this.DatePikerRegisterPrepaVisit.Name = "DatePikerRegisterPrepaVisit";
            this.DatePikerRegisterPrepaVisit.Size = new System.Drawing.Size(107, 25);
            this.DatePikerRegisterPrepaVisit.TabIndex = 36;
            // 
            // CbxGaragePrepaVisit
            // 
            this.CbxGaragePrepaVisit.BackColor = System.Drawing.Color.White;
            this.CbxGaragePrepaVisit.FormattingEnabled = true;
            this.CbxGaragePrepaVisit.Location = new System.Drawing.Point(102, 134);
            this.CbxGaragePrepaVisit.Name = "CbxGaragePrepaVisit";
            this.CbxGaragePrepaVisit.Size = new System.Drawing.Size(242, 25);
            this.CbxGaragePrepaVisit.TabIndex = 35;
            this.CbxGaragePrepaVisit.SelectedIndexChanged += new System.EventHandler(this.CbxGaragePrepaVisit_SelectedIndexChanged);
            // 
            // CbxCarPrepaVisit
            // 
            this.CbxCarPrepaVisit.BackColor = System.Drawing.Color.White;
            this.CbxCarPrepaVisit.FormattingEnabled = true;
            this.CbxCarPrepaVisit.Location = new System.Drawing.Point(102, 84);
            this.CbxCarPrepaVisit.Name = "CbxCarPrepaVisit";
            this.CbxCarPrepaVisit.Size = new System.Drawing.Size(240, 25);
            this.CbxCarPrepaVisit.TabIndex = 34;
            this.CbxCarPrepaVisit.SelectedIndexChanged += new System.EventHandler(this.CbxCarPrepaVisit_SelectedIndexChanged);
            // 
            // TxtMontantPrepaVisit
            // 
            this.TxtMontantPrepaVisit.BackColor = System.Drawing.Color.White;
            this.TxtMontantPrepaVisit.ForeColor = System.Drawing.Color.YellowGreen;
            this.TxtMontantPrepaVisit.Location = new System.Drawing.Point(102, 239);
            this.TxtMontantPrepaVisit.Name = "TxtMontantPrepaVisit";
            this.TxtMontantPrepaVisit.Size = new System.Drawing.Size(240, 25);
            this.TxtMontantPrepaVisit.TabIndex = 32;
            this.TxtMontantPrepaVisit.Text = "0.0";
            this.TxtMontantPrepaVisit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtMecanicienPrepaVisit
            // 
            this.TxtMecanicienPrepaVisit.BackColor = System.Drawing.Color.White;
            this.TxtMecanicienPrepaVisit.Location = new System.Drawing.Point(102, 183);
            this.TxtMecanicienPrepaVisit.Name = "TxtMecanicienPrepaVisit";
            this.TxtMecanicienPrepaVisit.ReadOnly = true;
            this.TxtMecanicienPrepaVisit.Size = new System.Drawing.Size(242, 25);
            this.TxtMecanicienPrepaVisit.TabIndex = 31;
            // 
            // TxtCodePrepaVisit
            // 
            this.TxtCodePrepaVisit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.TxtCodePrepaVisit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodePrepaVisit.Location = new System.Drawing.Point(102, 33);
            this.TxtCodePrepaVisit.Name = "TxtCodePrepaVisit";
            this.TxtCodePrepaVisit.Size = new System.Drawing.Size(113, 26);
            this.TxtCodePrepaVisit.TabIndex = 30;
            this.TxtCodePrepaVisit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(12, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Coût *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(507, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Mécanicien";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(13, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Garage *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(10, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Véhicule *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Code";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 364);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(681, 18);
            this.panel2.TabIndex = 44;
            // 
            // FormCreatePreparVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(685, 410);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelCreateFormFournTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCreatePreparVisit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Préparation de visite";
            this.panelCreateFormFournTitle.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCreateFormFournTitle;
        private FontAwesome.Sharp.IconButton BtnImportPrepaVisit;
        private FontAwesome.Sharp.IconButton BtnSavedPrepaVisit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox CheckGazEchappPrepaVisit;
        private System.Windows.Forms.CheckBox CheckFreinagePrepaVisit;
        private System.Windows.Forms.CheckBox CheckReglagePharePrepaVisit;
        private System.Windows.Forms.CheckBox CheckParallelismePrepaVisit;
        private System.Windows.Forms.DateTimePicker DatePikerRegisterPrepaVisit;
        private System.Windows.Forms.ComboBox CbxGaragePrepaVisit;
        private System.Windows.Forms.ComboBox CbxCarPrepaVisit;
        private System.Windows.Forms.TextBox TxtMontantPrepaVisit;
        private System.Windows.Forms.TextBox TxtMecanicienPrepaVisit;
        private System.Windows.Forms.TextBox TxtCodePrepaVisit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ChekPneusPrepaVisit;
        private System.Windows.Forms.RichTextBox RTxtNotePrepaVisit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
    }
}