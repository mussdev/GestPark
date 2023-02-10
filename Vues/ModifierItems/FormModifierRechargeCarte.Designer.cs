
namespace GestPark
{
    partial class FormModifierRechargeCarte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModifierRechargeCarte));
            this.DpkRegisterMod = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.CbxTypeCardRechargMod = new System.Windows.Forms.ComboBox();
            this.TxtMontantRechargMod = new System.Windows.Forms.TextBox();
            this.TxtNumCardRechargMod = new System.Windows.Forms.TextBox();
            this.TxtCodeRechargMod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCancelRechargMod = new FontAwesome.Sharp.IconButton();
            this.BtnValiderRechargMod = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // DpkRegisterMod
            // 
            this.DpkRegisterMod.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DpkRegisterMod.Location = new System.Drawing.Point(286, 23);
            this.DpkRegisterMod.Margin = new System.Windows.Forms.Padding(4);
            this.DpkRegisterMod.Name = "DpkRegisterMod";
            this.DpkRegisterMod.Size = new System.Drawing.Size(111, 28);
            this.DpkRegisterMod.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Date";
            // 
            // CbxTypeCardRechargMod
            // 
            this.CbxTypeCardRechargMod.BackColor = System.Drawing.Color.White;
            this.CbxTypeCardRechargMod.FormattingEnabled = true;
            this.CbxTypeCardRechargMod.Location = new System.Drawing.Point(111, 75);
            this.CbxTypeCardRechargMod.Margin = new System.Windows.Forms.Padding(4);
            this.CbxTypeCardRechargMod.Name = "CbxTypeCardRechargMod";
            this.CbxTypeCardRechargMod.Size = new System.Drawing.Size(286, 28);
            this.CbxTypeCardRechargMod.TabIndex = 13;
            this.CbxTypeCardRechargMod.SelectedIndexChanged += new System.EventHandler(this.CbxTypeCardRechargMod_SelectedIndexChanged);
            // 
            // TxtMontantRechargMod
            // 
            this.TxtMontantRechargMod.BackColor = System.Drawing.Color.White;
            this.TxtMontantRechargMod.ForeColor = System.Drawing.Color.Black;
            this.TxtMontantRechargMod.Location = new System.Drawing.Point(111, 177);
            this.TxtMontantRechargMod.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMontantRechargMod.Name = "TxtMontantRechargMod";
            this.TxtMontantRechargMod.Size = new System.Drawing.Size(286, 28);
            this.TxtMontantRechargMod.TabIndex = 15;
            this.TxtMontantRechargMod.Text = "0.0";
            this.TxtMontantRechargMod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtNumCardRechargMod
            // 
            this.TxtNumCardRechargMod.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.TxtNumCardRechargMod.Location = new System.Drawing.Point(111, 121);
            this.TxtNumCardRechargMod.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNumCardRechargMod.Name = "TxtNumCardRechargMod";
            this.TxtNumCardRechargMod.ReadOnly = true;
            this.TxtNumCardRechargMod.Size = new System.Drawing.Size(286, 28);
            this.TxtNumCardRechargMod.TabIndex = 20;
            // 
            // TxtCodeRechargMod
            // 
            this.TxtCodeRechargMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.TxtCodeRechargMod.Location = new System.Drawing.Point(111, 23);
            this.TxtCodeRechargMod.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCodeRechargMod.Name = "TxtCodeRechargMod";
            this.TxtCodeRechargMod.ReadOnly = true;
            this.TxtCodeRechargMod.Size = new System.Drawing.Size(124, 28);
            this.TxtCodeRechargMod.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(19, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Montant *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(19, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "N° carte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(19, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Carte *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Code";
            // 
            // BtnCancelRechargMod
            // 
            this.BtnCancelRechargMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.BtnCancelRechargMod.ForeColor = System.Drawing.Color.Black;
            this.BtnCancelRechargMod.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.BtnCancelRechargMod.IconColor = System.Drawing.Color.White;
            this.BtnCancelRechargMod.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCancelRechargMod.IconSize = 20;
            this.BtnCancelRechargMod.Location = new System.Drawing.Point(228, 221);
            this.BtnCancelRechargMod.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancelRechargMod.Name = "BtnCancelRechargMod";
            this.BtnCancelRechargMod.Size = new System.Drawing.Size(94, 27);
            this.BtnCancelRechargMod.TabIndex = 21;
            this.BtnCancelRechargMod.Text = "Annuler";
            this.BtnCancelRechargMod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelRechargMod.UseVisualStyleBackColor = false;
            this.BtnCancelRechargMod.Click += new System.EventHandler(this.BtnCancelRechargMod_Click);
            // 
            // BtnValiderRechargMod
            // 
            this.BtnValiderRechargMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.BtnValiderRechargMod.ForeColor = System.Drawing.Color.Black;
            this.BtnValiderRechargMod.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.BtnValiderRechargMod.IconColor = System.Drawing.Color.White;
            this.BtnValiderRechargMod.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnValiderRechargMod.IconSize = 20;
            this.BtnValiderRechargMod.Location = new System.Drawing.Point(127, 221);
            this.BtnValiderRechargMod.Margin = new System.Windows.Forms.Padding(4);
            this.BtnValiderRechargMod.Name = "BtnValiderRechargMod";
            this.BtnValiderRechargMod.Size = new System.Drawing.Size(94, 27);
            this.BtnValiderRechargMod.TabIndex = 18;
            this.BtnValiderRechargMod.Text = "Valider";
            this.BtnValiderRechargMod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnValiderRechargMod.UseVisualStyleBackColor = false;
            this.BtnValiderRechargMod.Click += new System.EventHandler(this.BtnValiderRechargMod_Click);
            // 
            // FormModifierRechargeCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(410, 277);
            this.Controls.Add(this.DpkRegisterMod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnCancelRechargMod);
            this.Controls.Add(this.BtnValiderRechargMod);
            this.Controls.Add(this.CbxTypeCardRechargMod);
            this.Controls.Add(this.TxtMontantRechargMod);
            this.Controls.Add(this.TxtNumCardRechargMod);
            this.Controls.Add(this.TxtCodeRechargMod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormModifierRechargeCarte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recharger une carte de carburant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton BtnCancelRechargMod;
        private FontAwesome.Sharp.IconButton BtnValiderRechargMod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker DpkRegisterMod;
        public System.Windows.Forms.ComboBox CbxTypeCardRechargMod;
        public System.Windows.Forms.TextBox TxtMontantRechargMod;
        public System.Windows.Forms.TextBox TxtNumCardRechargMod;
        public System.Windows.Forms.TextBox TxtCodeRechargMod;
    }
}