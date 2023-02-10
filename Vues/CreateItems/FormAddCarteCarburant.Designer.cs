
namespace GestPark
{
    partial class FormAddCarteCarburant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddCarteCarburant));
            this.BtnSavedCreateCard = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnRechargeCard = new FontAwesome.Sharp.IconButton();
            this.CbxTypeCard = new System.Windows.Forms.ComboBox();
            this.TxtStationCard = new System.Windows.Forms.TextBox();
            this.TxtSoldeCard = new System.Windows.Forms.TextBox();
            this.TxtNumCard = new System.Windows.Forms.TextBox();
            this.TxtCodeCard = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSavedCreateCard
            // 
            this.BtnSavedCreateCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.BtnSavedCreateCard.ForeColor = System.Drawing.Color.Black;
            this.BtnSavedCreateCard.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.BtnSavedCreateCard.IconColor = System.Drawing.Color.White;
            this.BtnSavedCreateCard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSavedCreateCard.IconSize = 20;
            this.BtnSavedCreateCard.Location = new System.Drawing.Point(97, 273);
            this.BtnSavedCreateCard.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSavedCreateCard.Name = "BtnSavedCreateCard";
            this.BtnSavedCreateCard.Size = new System.Drawing.Size(95, 29);
            this.BtnSavedCreateCard.TabIndex = 0;
            this.BtnSavedCreateCard.Text = "Valider";
            this.BtnSavedCreateCard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSavedCreateCard.UseVisualStyleBackColor = false;
            this.BtnSavedCreateCard.Click += new System.EventHandler(this.BtnSavedCreateCard_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.BtnRechargeCard);
            this.panel2.Controls.Add(this.BtnSavedCreateCard);
            this.panel2.Controls.Add(this.CbxTypeCard);
            this.panel2.Controls.Add(this.TxtStationCard);
            this.panel2.Controls.Add(this.TxtSoldeCard);
            this.panel2.Controls.Add(this.TxtNumCard);
            this.panel2.Controls.Add(this.TxtCodeCard);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 319);
            this.panel2.TabIndex = 1;
            // 
            // BtnRechargeCard
            // 
            this.BtnRechargeCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.BtnRechargeCard.ForeColor = System.Drawing.Color.Black;
            this.BtnRechargeCard.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.BtnRechargeCard.IconColor = System.Drawing.Color.White;
            this.BtnRechargeCard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRechargeCard.IconSize = 20;
            this.BtnRechargeCard.Location = new System.Drawing.Point(200, 273);
            this.BtnRechargeCard.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRechargeCard.Name = "BtnRechargeCard";
            this.BtnRechargeCard.Size = new System.Drawing.Size(97, 29);
            this.BtnRechargeCard.TabIndex = 10;
            this.BtnRechargeCard.Text = "Annuler";
            this.BtnRechargeCard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRechargeCard.UseVisualStyleBackColor = false;
            // 
            // CbxTypeCard
            // 
            this.CbxTypeCard.BackColor = System.Drawing.Color.White;
            this.CbxTypeCard.FormattingEnabled = true;
            this.CbxTypeCard.Items.AddRange(new object[] {
            "",
            "Pool 1",
            "Pool 2",
            "Pool 3",
            "Pool 4",
            "Pool 5",
            "Personnelle"});
            this.CbxTypeCard.Location = new System.Drawing.Point(126, 223);
            this.CbxTypeCard.Margin = new System.Windows.Forms.Padding(4);
            this.CbxTypeCard.Name = "CbxTypeCard";
            this.CbxTypeCard.Size = new System.Drawing.Size(220, 28);
            this.CbxTypeCard.TabIndex = 9;
            // 
            // TxtStationCard
            // 
            this.TxtStationCard.BackColor = System.Drawing.Color.White;
            this.TxtStationCard.Location = new System.Drawing.Point(126, 171);
            this.TxtStationCard.Margin = new System.Windows.Forms.Padding(4);
            this.TxtStationCard.Name = "TxtStationCard";
            this.TxtStationCard.Size = new System.Drawing.Size(222, 28);
            this.TxtStationCard.TabIndex = 8;
            // 
            // TxtSoldeCard
            // 
            this.TxtSoldeCard.BackColor = System.Drawing.Color.White;
            this.TxtSoldeCard.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSoldeCard.ForeColor = System.Drawing.Color.DarkGreen;
            this.TxtSoldeCard.Location = new System.Drawing.Point(126, 120);
            this.TxtSoldeCard.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSoldeCard.Name = "TxtSoldeCard";
            this.TxtSoldeCard.Size = new System.Drawing.Size(222, 25);
            this.TxtSoldeCard.TabIndex = 7;
            this.TxtSoldeCard.Text = "0.0";
            this.TxtSoldeCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtNumCard
            // 
            this.TxtNumCard.BackColor = System.Drawing.Color.White;
            this.TxtNumCard.Location = new System.Drawing.Point(126, 68);
            this.TxtNumCard.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNumCard.Name = "TxtNumCard";
            this.TxtNumCard.Size = new System.Drawing.Size(222, 28);
            this.TxtNumCard.TabIndex = 6;
            // 
            // TxtCodeCard
            // 
            this.TxtCodeCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.TxtCodeCard.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodeCard.Location = new System.Drawing.Point(126, 18);
            this.TxtCodeCard.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCodeCard.Name = "TxtCodeCard";
            this.TxtCodeCard.ReadOnly = true;
            this.TxtCodeCard.Size = new System.Drawing.Size(117, 29);
            this.TxtCodeCard.TabIndex = 5;
            this.TxtCodeCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(31, 230);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Type *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(29, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Station *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(28, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Solde *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(29, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "N° *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // FormAddCarteCarburant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(379, 319);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAddCarteCarburant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carte de  carburant";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton BtnSavedCreateCard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtNumCard;
        private System.Windows.Forms.TextBox TxtCodeCard;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbxTypeCard;
        private System.Windows.Forms.TextBox TxtStationCard;
        private System.Windows.Forms.TextBox TxtSoldeCard;
        private FontAwesome.Sharp.IconButton BtnRechargeCard;
    }
}