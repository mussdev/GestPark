
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
            this.BtnJoindreDocVdge = new FontAwesome.Sharp.IconButton();
            this.BtnSaveVdge = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCodeVdge = new System.Windows.Forms.TextBox();
            this.DatePickerCreateVdge = new System.Windows.Forms.DateTimePicker();
            this.CbxGarageMaint = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RtxtNotesVdge = new System.Windows.Forms.RichTextBox();
            this.TxtPrixVdge = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtStationVdge = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCarVdge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.BtnJoindreDocVdge);
            this.panel1.Controls.Add(this.BtnSaveVdge);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 24);
            this.panel1.TabIndex = 0;
            // 
            // BtnJoindreDocVdge
            // 
            this.BtnJoindreDocVdge.BackColor = System.Drawing.Color.White;
            this.BtnJoindreDocVdge.ForeColor = System.Drawing.Color.YellowGreen;
            this.BtnJoindreDocVdge.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.BtnJoindreDocVdge.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(13)))));
            this.BtnJoindreDocVdge.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnJoindreDocVdge.IconSize = 20;
            this.BtnJoindreDocVdge.Location = new System.Drawing.Point(34, -2);
            this.BtnJoindreDocVdge.Name = "BtnJoindreDocVdge";
            this.BtnJoindreDocVdge.Size = new System.Drawing.Size(30, 24);
            this.BtnJoindreDocVdge.TabIndex = 3;
            this.BtnJoindreDocVdge.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnJoindreDocVdge.UseVisualStyleBackColor = false;
            this.BtnJoindreDocVdge.MouseHover += new System.EventHandler(this.BtnJoindreDoc_MouseHover);
            // 
            // BtnSaveVdge
            // 
            this.BtnSaveVdge.BackColor = System.Drawing.Color.White;
            this.BtnSaveVdge.ForeColor = System.Drawing.Color.YellowGreen;
            this.BtnSaveVdge.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.BtnSaveVdge.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(147)))), ((int)(((byte)(222)))));
            this.BtnSaveVdge.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSaveVdge.IconSize = 20;
            this.BtnSaveVdge.Location = new System.Drawing.Point(-2, -2);
            this.BtnSaveVdge.Name = "BtnSaveVdge";
            this.BtnSaveVdge.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnSaveVdge.Size = new System.Drawing.Size(30, 24);
            this.BtnSaveVdge.TabIndex = 0;
            this.BtnSaveVdge.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSaveVdge.UseVisualStyleBackColor = false;
            this.BtnSaveVdge.Click += new System.EventHandler(this.BtnSaveEntretien_Click);
            this.BtnSaveVdge.MouseHover += new System.EventHandler(this.BtnSaveEntretien_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(14, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Garage ";
            // 
            // TxtCodeVdge
            // 
            this.TxtCodeVdge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.TxtCodeVdge.Location = new System.Drawing.Point(118, 59);
            this.TxtCodeVdge.Name = "TxtCodeVdge";
            this.TxtCodeVdge.ReadOnly = true;
            this.TxtCodeVdge.Size = new System.Drawing.Size(136, 28);
            this.TxtCodeVdge.TabIndex = 4;
            // 
            // DatePickerCreateVdge
            // 
            this.DatePickerCreateVdge.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePickerCreateVdge.Location = new System.Drawing.Point(496, 56);
            this.DatePickerCreateVdge.Name = "DatePickerCreateVdge";
            this.DatePickerCreateVdge.Size = new System.Drawing.Size(143, 28);
            this.DatePickerCreateVdge.TabIndex = 5;
            // 
            // CbxGarageMaint
            // 
            this.CbxGarageMaint.BackColor = System.Drawing.Color.White;
            this.CbxGarageMaint.FormattingEnabled = true;
            this.CbxGarageMaint.Location = new System.Drawing.Point(118, 225);
            this.CbxGarageMaint.Name = "CbxGarageMaint";
            this.CbxGarageMaint.Size = new System.Drawing.Size(253, 28);
            this.CbxGarageMaint.TabIndex = 6;
            this.CbxGarageMaint.SelectedIndexChanged += new System.EventHandler(this.CbxGarageMaint_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(14, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Voiture *";
            // 
            // RtxtNotesVdge
            // 
            this.RtxtNotesVdge.BackColor = System.Drawing.Color.White;
            this.RtxtNotesVdge.Location = new System.Drawing.Point(399, 132);
            this.RtxtNotesVdge.Name = "RtxtNotesVdge";
            this.RtxtNotesVdge.Size = new System.Drawing.Size(240, 60);
            this.RtxtNotesVdge.TabIndex = 13;
            this.RtxtNotesVdge.Text = "";
            // 
            // TxtPrixVdge
            // 
            this.TxtPrixVdge.BackColor = System.Drawing.Color.White;
            this.TxtPrixVdge.ForeColor = System.Drawing.Color.YellowGreen;
            this.TxtPrixVdge.Location = new System.Drawing.Point(118, 165);
            this.TxtPrixVdge.Name = "TxtPrixVdge";
            this.TxtPrixVdge.Size = new System.Drawing.Size(253, 28);
            this.TxtPrixVdge.TabIndex = 17;
            this.TxtPrixVdge.Text = "0";
            this.TxtPrixVdge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(14, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Coût *";
            // 
            // TxtStationVdge
            // 
            this.TxtStationVdge.BackColor = System.Drawing.Color.White;
            this.TxtStationVdge.Location = new System.Drawing.Point(118, 285);
            this.TxtStationVdge.Name = "TxtStationVdge";
            this.TxtStationVdge.Size = new System.Drawing.Size(253, 28);
            this.TxtStationVdge.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(14, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Station ";
            // 
            // txtCarVdge
            // 
            this.txtCarVdge.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtCarVdge.Location = new System.Drawing.Point(118, 114);
            this.txtCarVdge.Name = "txtCarVdge";
            this.txtCarVdge.ReadOnly = true;
            this.txtCarVdge.Size = new System.Drawing.Size(253, 28);
            this.txtCarVdge.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(395, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "Observations";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 340);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(720, 19);
            this.flowLayoutPanel1.TabIndex = 24;
            // 
            // FormCreateEntretien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(720, 359);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCarVdge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DatePickerCreateVdge);
            this.Controls.Add(this.TxtStationVdge);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtPrixVdge);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.RtxtNotesVdge);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CbxGarageMaint);
            this.Controls.Add(this.TxtCodeVdge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCreateEntretien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saisir une vidange de véhicule";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton BtnSaveVdge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCodeVdge;
        private FontAwesome.Sharp.IconButton BtnJoindreDocVdge;
        private System.Windows.Forms.DateTimePicker DatePickerCreateVdge;
        private System.Windows.Forms.ComboBox CbxGarageMaint;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox RtxtNotesVdge;
        private System.Windows.Forms.TextBox TxtPrixVdge;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtStationVdge;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtCarVdge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}