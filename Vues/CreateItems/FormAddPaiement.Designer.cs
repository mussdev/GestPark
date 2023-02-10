
namespace GestPark
{
    partial class FormAddPaiement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddPaiement));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCodePaie = new System.Windows.Forms.TextBox();
            this.TxtNumPaie = new System.Windows.Forms.TextBox();
            this.TxtPrixUnitaireCarbu = new System.Windows.Forms.TextBox();
            this.BtnValiderPaie = new FontAwesome.Sharp.IconButton();
            this.BtnCancelPaiementCarb = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.CbxTypCartPaie = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DateRegisterPaie = new System.Windows.Forms.DateTimePicker();
            this.TxtLitreCarbu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtPrixTotalCarbu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtCodeAppro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "N° Carte paie.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 249);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prix uni.";
            // 
            // TxtCodePaie
            // 
            this.TxtCodePaie.BackColor = System.Drawing.Color.YellowGreen;
            this.TxtCodePaie.Location = new System.Drawing.Point(188, 13);
            this.TxtCodePaie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtCodePaie.Name = "TxtCodePaie";
            this.TxtCodePaie.ReadOnly = true;
            this.TxtCodePaie.Size = new System.Drawing.Size(124, 28);
            this.TxtCodePaie.TabIndex = 4;
            // 
            // TxtNumPaie
            // 
            this.TxtNumPaie.BackColor = System.Drawing.Color.YellowGreen;
            this.TxtNumPaie.Location = new System.Drawing.Point(188, 154);
            this.TxtNumPaie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtNumPaie.Name = "TxtNumPaie";
            this.TxtNumPaie.ReadOnly = true;
            this.TxtNumPaie.Size = new System.Drawing.Size(324, 28);
            this.TxtNumPaie.TabIndex = 3;
            // 
            // TxtPrixUnitaireCarbu
            // 
            this.TxtPrixUnitaireCarbu.BackColor = System.Drawing.Color.YellowGreen;
            this.TxtPrixUnitaireCarbu.Location = new System.Drawing.Point(188, 242);
            this.TxtPrixUnitaireCarbu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtPrixUnitaireCarbu.Name = "TxtPrixUnitaireCarbu";
            this.TxtPrixUnitaireCarbu.Size = new System.Drawing.Size(324, 28);
            this.TxtPrixUnitaireCarbu.TabIndex = 4;
            this.TxtPrixUnitaireCarbu.Text = "0.00";
            this.TxtPrixUnitaireCarbu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnValiderPaie
            // 
            this.BtnValiderPaie.BackColor = System.Drawing.Color.White;
            this.BtnValiderPaie.ForeColor = System.Drawing.Color.DarkGreen;
            this.BtnValiderPaie.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.BtnValiderPaie.IconColor = System.Drawing.Color.DarkGreen;
            this.BtnValiderPaie.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnValiderPaie.IconSize = 20;
            this.BtnValiderPaie.Location = new System.Drawing.Point(246, 336);
            this.BtnValiderPaie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnValiderPaie.Name = "BtnValiderPaie";
            this.BtnValiderPaie.Size = new System.Drawing.Size(94, 27);
            this.BtnValiderPaie.TabIndex = 7;
            this.BtnValiderPaie.Text = "Valider";
            this.BtnValiderPaie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnValiderPaie.UseVisualStyleBackColor = false;
            this.BtnValiderPaie.Click += new System.EventHandler(this.BtnValiderPaie_Click);
            // 
            // BtnCancelPaiementCarb
            // 
            this.BtnCancelPaiementCarb.BackColor = System.Drawing.Color.White;
            this.BtnCancelPaiementCarb.ForeColor = System.Drawing.Color.DarkGreen;
            this.BtnCancelPaiementCarb.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.BtnCancelPaiementCarb.IconColor = System.Drawing.Color.DarkGreen;
            this.BtnCancelPaiementCarb.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCancelPaiementCarb.IconSize = 20;
            this.BtnCancelPaiementCarb.Location = new System.Drawing.Point(348, 336);
            this.BtnCancelPaiementCarb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCancelPaiementCarb.Name = "BtnCancelPaiementCarb";
            this.BtnCancelPaiementCarb.Size = new System.Drawing.Size(94, 27);
            this.BtnCancelPaiementCarb.TabIndex = 9;
            this.BtnCancelPaiementCarb.Text = "Annuler";
            this.BtnCancelPaiementCarb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelPaiementCarb.UseVisualStyleBackColor = false;
            this.BtnCancelPaiementCarb.Click += new System.EventHandler(this.BtnCancelPaiementCarb_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 107);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Type cart.";
            // 
            // CbxTypCartPaie
            // 
            this.CbxTypCartPaie.BackColor = System.Drawing.Color.GhostWhite;
            this.CbxTypCartPaie.FormattingEnabled = true;
            this.CbxTypCartPaie.Location = new System.Drawing.Point(188, 107);
            this.CbxTypCartPaie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbxTypCartPaie.Name = "CbxTypCartPaie";
            this.CbxTypCartPaie.Size = new System.Drawing.Size(324, 28);
            this.CbxTypCartPaie.TabIndex = 2;
            this.CbxTypCartPaie.SelectedIndexChanged += new System.EventHandler(this.CbxTypCartPaie_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Date";
            // 
            // DateRegisterPaie
            // 
            this.DateRegisterPaie.CalendarMonthBackground = System.Drawing.Color.GhostWhite;
            this.DateRegisterPaie.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateRegisterPaie.Location = new System.Drawing.Point(366, 13);
            this.DateRegisterPaie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DateRegisterPaie.Name = "DateRegisterPaie";
            this.DateRegisterPaie.Size = new System.Drawing.Size(145, 28);
            this.DateRegisterPaie.TabIndex = 14;
            // 
            // TxtLitreCarbu
            // 
            this.TxtLitreCarbu.BackColor = System.Drawing.Color.YellowGreen;
            this.TxtLitreCarbu.Location = new System.Drawing.Point(188, 198);
            this.TxtLitreCarbu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtLitreCarbu.Name = "TxtLitreCarbu";
            this.TxtLitreCarbu.Size = new System.Drawing.Size(324, 28);
            this.TxtLitreCarbu.TabIndex = 16;
            this.TxtLitreCarbu.Text = "0.00";
            this.TxtLitreCarbu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 205);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Litre";
            // 
            // TxtPrixTotalCarbu
            // 
            this.TxtPrixTotalCarbu.BackColor = System.Drawing.Color.GhostWhite;
            this.TxtPrixTotalCarbu.Location = new System.Drawing.Point(188, 289);
            this.TxtPrixTotalCarbu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtPrixTotalCarbu.Name = "TxtPrixTotalCarbu";
            this.TxtPrixTotalCarbu.Size = new System.Drawing.Size(324, 28);
            this.TxtPrixTotalCarbu.TabIndex = 18;
            this.TxtPrixTotalCarbu.Text = "0.00";
            this.TxtPrixTotalCarbu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtPrixTotalCarbu.TextChanged += new System.EventHandler(this.TxtPrixTotalCarbu_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 296);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Prix tot.";
            // 
            // TxtCodeAppro
            // 
            this.TxtCodeAppro.BackColor = System.Drawing.Color.YellowGreen;
            this.TxtCodeAppro.Location = new System.Drawing.Point(188, 62);
            this.TxtCodeAppro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtCodeAppro.Name = "TxtCodeAppro";
            this.TxtCodeAppro.ReadOnly = true;
            this.TxtCodeAppro.Size = new System.Drawing.Size(324, 28);
            this.TxtCodeAppro.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 69);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Code approv.";
            // 
            // FormAddPaiement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(594, 367);
            this.Controls.Add(this.TxtCodeAppro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtPrixTotalCarbu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtLitreCarbu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DateRegisterPaie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CbxTypCartPaie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnCancelPaiementCarb);
            this.Controls.Add(this.BtnValiderPaie);
            this.Controls.Add(this.TxtPrixUnitaireCarbu);
            this.Controls.Add(this.TxtNumPaie);
            this.Controls.Add(this.TxtCodePaie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAddPaiement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payer le carburant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCodePaie;
        private System.Windows.Forms.TextBox TxtNumPaie;
        private FontAwesome.Sharp.IconButton BtnValiderPaie;
        private FontAwesome.Sharp.IconButton BtnCancelPaiementCarb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbxTypCartPaie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DateRegisterPaie;
        private System.Windows.Forms.TextBox TxtLitreCarbu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtPrixTotalCarbu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox TxtCodeAppro;
        public System.Windows.Forms.TextBox TxtPrixUnitaireCarbu;
    }
}