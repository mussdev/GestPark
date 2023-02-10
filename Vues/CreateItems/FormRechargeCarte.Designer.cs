
namespace GestPark
{
    partial class FormRechargeCarte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRechargeCarte));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCodeRecharg = new System.Windows.Forms.TextBox();
            this.TxtNumCardRecharg = new System.Windows.Forms.TextBox();
            this.TxtMontantRecharg = new System.Windows.Forms.TextBox();
            this.CbxTypeCardRecharg = new System.Windows.Forms.ComboBox();
            this.BtnValiderRecharg = new FontAwesome.Sharp.IconButton();
            this.BtnCancelRecharg = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.DpkRegister = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(25, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Carte *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(25, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "N° carte *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(25, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Montant *";
            // 
            // TxtCodeRecharg
            // 
            this.TxtCodeRecharg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.TxtCodeRecharg.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodeRecharg.ForeColor = System.Drawing.Color.White;
            this.TxtCodeRecharg.Location = new System.Drawing.Point(116, 21);
            this.TxtCodeRecharg.Name = "TxtCodeRecharg";
            this.TxtCodeRecharg.ReadOnly = true;
            this.TxtCodeRecharg.Size = new System.Drawing.Size(96, 29);
            this.TxtCodeRecharg.TabIndex = 4;
            this.TxtCodeRecharg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtNumCardRecharg
            // 
            this.TxtNumCardRecharg.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.TxtNumCardRecharg.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumCardRecharg.Location = new System.Drawing.Point(116, 135);
            this.TxtNumCardRecharg.Name = "TxtNumCardRecharg";
            this.TxtNumCardRecharg.ReadOnly = true;
            this.TxtNumCardRecharg.Size = new System.Drawing.Size(255, 28);
            this.TxtNumCardRecharg.TabIndex = 5;
            // 
            // TxtMontantRecharg
            // 
            this.TxtMontantRecharg.BackColor = System.Drawing.Color.White;
            this.TxtMontantRecharg.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMontantRecharg.ForeColor = System.Drawing.Color.YellowGreen;
            this.TxtMontantRecharg.Location = new System.Drawing.Point(116, 194);
            this.TxtMontantRecharg.Name = "TxtMontantRecharg";
            this.TxtMontantRecharg.Size = new System.Drawing.Size(255, 28);
            this.TxtMontantRecharg.TabIndex = 2;
            this.TxtMontantRecharg.Text = "0.0";
            this.TxtMontantRecharg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CbxTypeCardRecharg
            // 
            this.CbxTypeCardRecharg.BackColor = System.Drawing.Color.White;
            this.CbxTypeCardRecharg.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxTypeCardRecharg.FormattingEnabled = true;
            this.CbxTypeCardRecharg.Location = new System.Drawing.Point(116, 80);
            this.CbxTypeCardRecharg.Name = "CbxTypeCardRecharg";
            this.CbxTypeCardRecharg.Size = new System.Drawing.Size(255, 28);
            this.CbxTypeCardRecharg.TabIndex = 1;
            this.CbxTypeCardRecharg.SelectedIndexChanged += new System.EventHandler(this.CbxTypeCardRecharg_SelectedIndexChanged);
            // 
            // BtnValiderRecharg
            // 
            this.BtnValiderRecharg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.BtnValiderRecharg.ForeColor = System.Drawing.Color.Black;
            this.BtnValiderRecharg.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.BtnValiderRecharg.IconColor = System.Drawing.Color.White;
            this.BtnValiderRecharg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnValiderRecharg.IconSize = 20;
            this.BtnValiderRecharg.Location = new System.Drawing.Point(151, 241);
            this.BtnValiderRecharg.Name = "BtnValiderRecharg";
            this.BtnValiderRecharg.Size = new System.Drawing.Size(77, 24);
            this.BtnValiderRecharg.TabIndex = 4;
            this.BtnValiderRecharg.Text = "Valider";
            this.BtnValiderRecharg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnValiderRecharg.UseVisualStyleBackColor = false;
            this.BtnValiderRecharg.Click += new System.EventHandler(this.BtnValiderRecharg_Click);
            // 
            // BtnCancelRecharg
            // 
            this.BtnCancelRecharg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.BtnCancelRecharg.ForeColor = System.Drawing.Color.Black;
            this.BtnCancelRecharg.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.BtnCancelRecharg.IconColor = System.Drawing.Color.White;
            this.BtnCancelRecharg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCancelRecharg.IconSize = 20;
            this.BtnCancelRecharg.Location = new System.Drawing.Point(244, 241);
            this.BtnCancelRecharg.Name = "BtnCancelRecharg";
            this.BtnCancelRecharg.Size = new System.Drawing.Size(87, 24);
            this.BtnCancelRecharg.TabIndex = 9;
            this.BtnCancelRecharg.Text = "Annuler";
            this.BtnCancelRecharg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelRecharg.UseVisualStyleBackColor = false;
            this.BtnCancelRecharg.Click += new System.EventHandler(this.BtnCancelRecharg_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(218, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date";
            // 
            // DpkRegister
            // 
            this.DpkRegister.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DpkRegister.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DpkRegister.Location = new System.Drawing.Point(266, 21);
            this.DpkRegister.Name = "DpkRegister";
            this.DpkRegister.Size = new System.Drawing.Size(105, 28);
            this.DpkRegister.TabIndex = 11;
            // 
            // FormRechargeCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(395, 279);
            this.Controls.Add(this.DpkRegister);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnCancelRecharg);
            this.Controls.Add(this.BtnValiderRecharg);
            this.Controls.Add(this.CbxTypeCardRecharg);
            this.Controls.Add(this.TxtMontantRecharg);
            this.Controls.Add(this.TxtNumCardRecharg);
            this.Controls.Add(this.TxtCodeRecharg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRechargeCarte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recharger une carte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCodeRecharg;
        private System.Windows.Forms.TextBox TxtNumCardRecharg;
        private System.Windows.Forms.TextBox TxtMontantRecharg;
        private System.Windows.Forms.ComboBox CbxTypeCardRecharg;
        private FontAwesome.Sharp.IconButton BtnValiderRecharg;
        private FontAwesome.Sharp.IconButton BtnCancelRecharg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DpkRegister;
    }
}