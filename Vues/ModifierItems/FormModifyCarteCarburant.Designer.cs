
namespace GestPark
{
    partial class FormModifyCarteCarburant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModifyCarteCarburant));
            this.BtnRechargeCardMod = new FontAwesome.Sharp.IconButton();
            this.BtnSavedCreateCardMod = new FontAwesome.Sharp.IconButton();
            this.CbxTypeCardMod = new System.Windows.Forms.ComboBox();
            this.TxtStationCardMod = new System.Windows.Forms.TextBox();
            this.TxtSoldeCardMod = new System.Windows.Forms.TextBox();
            this.TxtNumCardMod = new System.Windows.Forms.TextBox();
            this.TxtCodeCardMod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnRechargeCardMod
            // 
            this.BtnRechargeCardMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.BtnRechargeCardMod.ForeColor = System.Drawing.Color.Black;
            this.BtnRechargeCardMod.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnRechargeCardMod.IconColor = System.Drawing.Color.White;
            this.BtnRechargeCardMod.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRechargeCardMod.IconSize = 20;
            this.BtnRechargeCardMod.Location = new System.Drawing.Point(226, 264);
            this.BtnRechargeCardMod.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRechargeCardMod.Name = "BtnRechargeCardMod";
            this.BtnRechargeCardMod.Size = new System.Drawing.Size(113, 29);
            this.BtnRechargeCardMod.TabIndex = 22;
            this.BtnRechargeCardMod.Text = "Recharger";
            this.BtnRechargeCardMod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRechargeCardMod.UseVisualStyleBackColor = false;
            this.BtnRechargeCardMod.Click += new System.EventHandler(this.BtnRechargeCardMod_Click);
            // 
            // BtnSavedCreateCardMod
            // 
            this.BtnSavedCreateCardMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.BtnSavedCreateCardMod.ForeColor = System.Drawing.Color.Black;
            this.BtnSavedCreateCardMod.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.BtnSavedCreateCardMod.IconColor = System.Drawing.Color.White;
            this.BtnSavedCreateCardMod.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSavedCreateCardMod.IconSize = 20;
            this.BtnSavedCreateCardMod.Location = new System.Drawing.Point(121, 264);
            this.BtnSavedCreateCardMod.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSavedCreateCardMod.Name = "BtnSavedCreateCardMod";
            this.BtnSavedCreateCardMod.Size = new System.Drawing.Size(102, 29);
            this.BtnSavedCreateCardMod.TabIndex = 11;
            this.BtnSavedCreateCardMod.Text = "Valider";
            this.BtnSavedCreateCardMod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSavedCreateCardMod.UseVisualStyleBackColor = false;
            this.BtnSavedCreateCardMod.Click += new System.EventHandler(this.BtnSavedCreateCardMod_Click);
            // 
            // CbxTypeCardMod
            // 
            this.CbxTypeCardMod.BackColor = System.Drawing.Color.White;
            this.CbxTypeCardMod.FormattingEnabled = true;
            this.CbxTypeCardMod.Items.AddRange(new object[] {
            "",
            "Pool 1",
            "Pool 2",
            "Pool 3",
            "Pool 4",
            "Pool 5"});
            this.CbxTypeCardMod.Location = new System.Drawing.Point(102, 221);
            this.CbxTypeCardMod.Margin = new System.Windows.Forms.Padding(4);
            this.CbxTypeCardMod.Name = "CbxTypeCardMod";
            this.CbxTypeCardMod.Size = new System.Drawing.Size(251, 28);
            this.CbxTypeCardMod.TabIndex = 21;
            // 
            // TxtStationCardMod
            // 
            this.TxtStationCardMod.BackColor = System.Drawing.Color.White;
            this.TxtStationCardMod.Location = new System.Drawing.Point(102, 168);
            this.TxtStationCardMod.Margin = new System.Windows.Forms.Padding(4);
            this.TxtStationCardMod.Name = "TxtStationCardMod";
            this.TxtStationCardMod.Size = new System.Drawing.Size(253, 28);
            this.TxtStationCardMod.TabIndex = 20;
            // 
            // TxtSoldeCardMod
            // 
            this.TxtSoldeCardMod.BackColor = System.Drawing.Color.White;
            this.TxtSoldeCardMod.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSoldeCardMod.ForeColor = System.Drawing.Color.DarkGreen;
            this.TxtSoldeCardMod.Location = new System.Drawing.Point(102, 115);
            this.TxtSoldeCardMod.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSoldeCardMod.Name = "TxtSoldeCardMod";
            this.TxtSoldeCardMod.Size = new System.Drawing.Size(253, 27);
            this.TxtSoldeCardMod.TabIndex = 19;
            this.TxtSoldeCardMod.Text = "0.0";
            this.TxtSoldeCardMod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtNumCardMod
            // 
            this.TxtNumCardMod.BackColor = System.Drawing.Color.White;
            this.TxtNumCardMod.Location = new System.Drawing.Point(105, 65);
            this.TxtNumCardMod.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNumCardMod.Name = "TxtNumCardMod";
            this.TxtNumCardMod.Size = new System.Drawing.Size(253, 28);
            this.TxtNumCardMod.TabIndex = 18;
            // 
            // TxtCodeCardMod
            // 
            this.TxtCodeCardMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.TxtCodeCardMod.Location = new System.Drawing.Point(102, 19);
            this.TxtCodeCardMod.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCodeCardMod.Name = "TxtCodeCardMod";
            this.TxtCodeCardMod.ReadOnly = true;
            this.TxtCodeCardMod.Size = new System.Drawing.Size(116, 28);
            this.TxtCodeCardMod.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(21, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Type *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Station";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(20, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Solde *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(24, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "N° *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Code";
            // 
            // FormModifyCarteCarburant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(383, 304);
            this.Controls.Add(this.BtnRechargeCardMod);
            this.Controls.Add(this.BtnSavedCreateCardMod);
            this.Controls.Add(this.CbxTypeCardMod);
            this.Controls.Add(this.TxtStationCardMod);
            this.Controls.Add(this.TxtSoldeCardMod);
            this.Controls.Add(this.TxtNumCardMod);
            this.Controls.Add(this.TxtCodeCardMod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormModifyCarteCarburant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifier les informations de la carte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnRechargeCardMod;
        private FontAwesome.Sharp.IconButton BtnSavedCreateCardMod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox CbxTypeCardMod;
        public System.Windows.Forms.TextBox TxtStationCardMod;
        public System.Windows.Forms.TextBox TxtSoldeCardMod;
        public System.Windows.Forms.TextBox TxtNumCardMod;
        public System.Windows.Forms.TextBox TxtCodeCardMod;
    }
}