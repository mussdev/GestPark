
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
            this.BtnRechargeCard = new FontAwesome.Sharp.IconButton();
            this.IbtnCloseFormCard = new FontAwesome.Sharp.IconButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSavedCreateCard
            // 
            this.BtnSavedCreateCard.BackColor = System.Drawing.Color.White;
            this.BtnSavedCreateCard.ForeColor = System.Drawing.Color.DarkGreen;
            this.BtnSavedCreateCard.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.BtnSavedCreateCard.IconColor = System.Drawing.Color.DarkGreen;
            this.BtnSavedCreateCard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSavedCreateCard.IconSize = 20;
            this.BtnSavedCreateCard.Location = new System.Drawing.Point(145, 293);
            this.BtnSavedCreateCard.Name = "BtnSavedCreateCard";
            this.BtnSavedCreateCard.Size = new System.Drawing.Size(88, 25);
            this.BtnSavedCreateCard.TabIndex = 0;
            this.BtnSavedCreateCard.Text = "Enregistrer";
            this.BtnSavedCreateCard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSavedCreateCard.UseVisualStyleBackColor = false;
            this.BtnSavedCreateCard.Click += new System.EventHandler(this.BtnSavedCreateCard_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Khaki;
            this.panel2.Controls.Add(this.IbtnCloseFormCard);
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
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 334);
            this.panel2.TabIndex = 1;
            // 
            // CbxTypeCard
            // 
            this.CbxTypeCard.FormattingEnabled = true;
            this.CbxTypeCard.Items.AddRange(new object[] {
            "",
            "Pool 1",
            "Pool 2",
            "Pool 3",
            "Pool 4",
            "Pool 5"});
            this.CbxTypeCard.Location = new System.Drawing.Point(160, 231);
            this.CbxTypeCard.Name = "CbxTypeCard";
            this.CbxTypeCard.Size = new System.Drawing.Size(250, 23);
            this.CbxTypeCard.TabIndex = 9;
            // 
            // TxtStationCard
            // 
            this.TxtStationCard.Location = new System.Drawing.Point(158, 180);
            this.TxtStationCard.Name = "TxtStationCard";
            this.TxtStationCard.Size = new System.Drawing.Size(252, 21);
            this.TxtStationCard.TabIndex = 8;
            // 
            // TxtSoldeCard
            // 
            this.TxtSoldeCard.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSoldeCard.ForeColor = System.Drawing.Color.DarkGreen;
            this.TxtSoldeCard.Location = new System.Drawing.Point(158, 124);
            this.TxtSoldeCard.Name = "TxtSoldeCard";
            this.TxtSoldeCard.Size = new System.Drawing.Size(252, 21);
            this.TxtSoldeCard.TabIndex = 7;
            this.TxtSoldeCard.Text = "0.0";
            this.TxtSoldeCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtNumCard
            // 
            this.TxtNumCard.Location = new System.Drawing.Point(158, 75);
            this.TxtNumCard.Name = "TxtNumCard";
            this.TxtNumCard.Size = new System.Drawing.Size(252, 21);
            this.TxtNumCard.TabIndex = 6;
            // 
            // TxtCodeCard
            // 
            this.TxtCodeCard.BackColor = System.Drawing.Color.YellowGreen;
            this.TxtCodeCard.Location = new System.Drawing.Point(158, 28);
            this.TxtCodeCard.Name = "TxtCodeCard";
            this.TxtCodeCard.ReadOnly = true;
            this.TxtCodeCard.Size = new System.Drawing.Size(129, 21);
            this.TxtCodeCard.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Station";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Solde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "N°";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // BtnRechargeCard
            // 
            this.BtnRechargeCard.BackColor = System.Drawing.Color.White;
            this.BtnRechargeCard.ForeColor = System.Drawing.Color.DarkGreen;
            this.BtnRechargeCard.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnRechargeCard.IconColor = System.Drawing.Color.DarkGreen;
            this.BtnRechargeCard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRechargeCard.IconSize = 20;
            this.BtnRechargeCard.Location = new System.Drawing.Point(249, 293);
            this.BtnRechargeCard.Name = "BtnRechargeCard";
            this.BtnRechargeCard.Size = new System.Drawing.Size(97, 25);
            this.BtnRechargeCard.TabIndex = 10;
            this.BtnRechargeCard.Text = "Recharger";
            this.BtnRechargeCard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRechargeCard.UseVisualStyleBackColor = false;
            // 
            // IbtnCloseFormCard
            // 
            this.IbtnCloseFormCard.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.IbtnCloseFormCard.BackColor = System.Drawing.Color.White;
            this.IbtnCloseFormCard.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.IbtnCloseFormCard.IconColor = System.Drawing.Color.Red;
            this.IbtnCloseFormCard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnCloseFormCard.IconSize = 20;
            this.IbtnCloseFormCard.Location = new System.Drawing.Point(441, 0);
            this.IbtnCloseFormCard.Name = "IbtnCloseFormCard";
            this.IbtnCloseFormCard.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.IbtnCloseFormCard.Size = new System.Drawing.Size(23, 24);
            this.IbtnCloseFormCard.TabIndex = 12;
            this.IbtnCloseFormCard.UseVisualStyleBackColor = false;
            this.IbtnCloseFormCard.Click += new System.EventHandler(this.IbtnCloseFormCard_Click);
            // 
            // FormAddCarteCarburant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 334);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddCarteCarburant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carte de rechargement carburant";
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
        private FontAwesome.Sharp.IconButton IbtnCloseFormCard;
    }
}