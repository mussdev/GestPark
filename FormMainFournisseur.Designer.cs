
namespace GestPark
{
    partial class FormMainFournisseur
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
            this.textBoxRecheFour = new System.Windows.Forms.TextBox();
            this.PanelTitleFour = new System.Windows.Forms.Panel();
            this.iconBtnCloseFormMainFour = new FontAwesome.Sharp.IconButton();
            this.iconBtnCreateFourn = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconBtnSearchFourn = new FontAwesome.Sharp.IconButton();
            this.DgvProvider = new System.Windows.Forms.DataGridView();
            this.ID_FOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE_FOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_FOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEL_FOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAIL_FOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTE_FOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REGICOM_FOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPTCONTRIB_FOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAYS_FOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VILLE_FOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADRESSE_FOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODEPOSTA_FOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_FOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AUTREINFO_FOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERCREATE_FOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATECREATION_FOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelTitleFour.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxRecheFour
            // 
            this.textBoxRecheFour.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRecheFour.Location = new System.Drawing.Point(364, 32);
            this.textBoxRecheFour.Name = "textBoxRecheFour";
            this.textBoxRecheFour.Size = new System.Drawing.Size(325, 26);
            this.textBoxRecheFour.TabIndex = 0;
            // 
            // PanelTitleFour
            // 
            this.PanelTitleFour.BackColor = System.Drawing.Color.Khaki;
            this.PanelTitleFour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelTitleFour.Controls.Add(this.iconBtnCloseFormMainFour);
            this.PanelTitleFour.Controls.Add(this.iconBtnCreateFourn);
            this.PanelTitleFour.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitleFour.Location = new System.Drawing.Point(0, 0);
            this.PanelTitleFour.Name = "PanelTitleFour";
            this.PanelTitleFour.Size = new System.Drawing.Size(1118, 25);
            this.PanelTitleFour.TabIndex = 2;
            // 
            // iconBtnCloseFormMainFour
            // 
            this.iconBtnCloseFormMainFour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnCloseFormMainFour.BackColor = System.Drawing.Color.White;
            this.iconBtnCloseFormMainFour.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconBtnCloseFormMainFour.IconColor = System.Drawing.Color.Red;
            this.iconBtnCloseFormMainFour.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnCloseFormMainFour.IconSize = 20;
            this.iconBtnCloseFormMainFour.Location = new System.Drawing.Point(1087, -2);
            this.iconBtnCloseFormMainFour.Name = "iconBtnCloseFormMainFour";
            this.iconBtnCloseFormMainFour.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.iconBtnCloseFormMainFour.Size = new System.Drawing.Size(29, 25);
            this.iconBtnCloseFormMainFour.TabIndex = 2;
            this.iconBtnCloseFormMainFour.UseVisualStyleBackColor = false;
            this.iconBtnCloseFormMainFour.Click += new System.EventHandler(this.iconBtnCloseFormMainFour_Click);
            // 
            // iconBtnCreateFourn
            // 
            this.iconBtnCreateFourn.BackColor = System.Drawing.Color.White;
            this.iconBtnCreateFourn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnCreateFourn.ForeColor = System.Drawing.Color.DarkGreen;
            this.iconBtnCreateFourn.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconBtnCreateFourn.IconColor = System.Drawing.Color.DarkGreen;
            this.iconBtnCreateFourn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnCreateFourn.IconSize = 20;
            this.iconBtnCreateFourn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnCreateFourn.Location = new System.Drawing.Point(-2, -2);
            this.iconBtnCreateFourn.Name = "iconBtnCreateFourn";
            this.iconBtnCreateFourn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.iconBtnCreateFourn.Size = new System.Drawing.Size(123, 26);
            this.iconBtnCreateFourn.TabIndex = 1;
            this.iconBtnCreateFourn.Text = "Créer fournisseur";
            this.iconBtnCreateFourn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconBtnCreateFourn.UseVisualStyleBackColor = false;
            this.iconBtnCreateFourn.Click += new System.EventHandler(this.iconBtnCreateFourn_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Khaki;
            this.panel2.Controls.Add(this.textBoxRecheFour);
            this.panel2.Controls.Add(this.iconBtnSearchFourn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1118, 86);
            this.panel2.TabIndex = 3;
            // 
            // iconBtnSearchFourn
            // 
            this.iconBtnSearchFourn.BackColor = System.Drawing.Color.White;
            this.iconBtnSearchFourn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnSearchFourn.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconBtnSearchFourn.IconColor = System.Drawing.Color.DarkGreen;
            this.iconBtnSearchFourn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnSearchFourn.IconSize = 25;
            this.iconBtnSearchFourn.Location = new System.Drawing.Point(695, 32);
            this.iconBtnSearchFourn.Name = "iconBtnSearchFourn";
            this.iconBtnSearchFourn.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.iconBtnSearchFourn.Size = new System.Drawing.Size(36, 26);
            this.iconBtnSearchFourn.TabIndex = 1;
            this.iconBtnSearchFourn.UseVisualStyleBackColor = false;
            this.iconBtnSearchFourn.Click += new System.EventHandler(this.iconBtnSearchFourn_Click);
            // 
            // DgvProvider
            // 
            this.DgvProvider.BackgroundColor = System.Drawing.Color.Khaki;
            this.DgvProvider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvProvider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProvider.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_FOUR,
            this.CODE_FOUR,
            this.DESCRIPTION_FOUR,
            this.TEL_FOUR,
            this.MAIL_FOUR,
            this.NOTE_FOUR,
            this.REGICOM_FOUR,
            this.CPTCONTRIB_FOUR,
            this.PAYS_FOUR,
            this.VILLE_FOUR,
            this.ADRESSE_FOUR,
            this.CODEPOSTA_FOUR,
            this.DATE_FOUR,
            this.AUTREINFO_FOUR,
            this.USERCREATE_FOUR,
            this.DATECREATION_FOUR});
            this.DgvProvider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvProvider.Location = new System.Drawing.Point(0, 111);
            this.DgvProvider.Name = "DgvProvider";
            this.DgvProvider.ReadOnly = true;
            this.DgvProvider.RowTemplate.ReadOnly = true;
            this.DgvProvider.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProvider.Size = new System.Drawing.Size(1118, 620);
            this.DgvProvider.TabIndex = 4;
            this.DgvProvider.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProvider_CellDoubleClick);
            // 
            // ID_FOUR
            // 
            this.ID_FOUR.DataPropertyName = "ID_FOUR";
            this.ID_FOUR.HeaderText = "Num";
            this.ID_FOUR.Name = "ID_FOUR";
            this.ID_FOUR.ReadOnly = true;
            this.ID_FOUR.Width = 50;
            // 
            // CODE_FOUR
            // 
            this.CODE_FOUR.DataPropertyName = "CODE_FOUR";
            this.CODE_FOUR.HeaderText = "Code";
            this.CODE_FOUR.Name = "CODE_FOUR";
            this.CODE_FOUR.ReadOnly = true;
            this.CODE_FOUR.Width = 50;
            // 
            // DESCRIPTION_FOUR
            // 
            this.DESCRIPTION_FOUR.DataPropertyName = "DESCRIPTION_FOUR";
            this.DESCRIPTION_FOUR.HeaderText = "Description";
            this.DESCRIPTION_FOUR.Name = "DESCRIPTION_FOUR";
            this.DESCRIPTION_FOUR.ReadOnly = true;
            this.DESCRIPTION_FOUR.Width = 200;
            // 
            // TEL_FOUR
            // 
            this.TEL_FOUR.DataPropertyName = "TEL_FOUR";
            this.TEL_FOUR.HeaderText = "Telephone";
            this.TEL_FOUR.Name = "TEL_FOUR";
            this.TEL_FOUR.ReadOnly = true;
            // 
            // MAIL_FOUR
            // 
            this.MAIL_FOUR.DataPropertyName = "MAIL_FOUR";
            this.MAIL_FOUR.HeaderText = "Mail";
            this.MAIL_FOUR.Name = "MAIL_FOUR";
            this.MAIL_FOUR.ReadOnly = true;
            // 
            // NOTE_FOUR
            // 
            this.NOTE_FOUR.DataPropertyName = "NOTE_FOUR";
            this.NOTE_FOUR.HeaderText = "Note";
            this.NOTE_FOUR.Name = "NOTE_FOUR";
            this.NOTE_FOUR.ReadOnly = true;
            // 
            // REGICOM_FOUR
            // 
            this.REGICOM_FOUR.DataPropertyName = "REGICOM_FOUR";
            this.REGICOM_FOUR.HeaderText = "Regis com.";
            this.REGICOM_FOUR.Name = "REGICOM_FOUR";
            this.REGICOM_FOUR.ReadOnly = true;
            // 
            // CPTCONTRIB_FOUR
            // 
            this.CPTCONTRIB_FOUR.DataPropertyName = "CPTCONTRIB_FOUR";
            this.CPTCONTRIB_FOUR.HeaderText = "Compte contrib.";
            this.CPTCONTRIB_FOUR.Name = "CPTCONTRIB_FOUR";
            this.CPTCONTRIB_FOUR.ReadOnly = true;
            this.CPTCONTRIB_FOUR.Width = 150;
            // 
            // PAYS_FOUR
            // 
            this.PAYS_FOUR.DataPropertyName = "PAYS_FOUR";
            this.PAYS_FOUR.HeaderText = "Pays";
            this.PAYS_FOUR.Name = "PAYS_FOUR";
            this.PAYS_FOUR.ReadOnly = true;
            // 
            // VILLE_FOUR
            // 
            this.VILLE_FOUR.DataPropertyName = "VILLE_FOUR";
            this.VILLE_FOUR.HeaderText = "Ville";
            this.VILLE_FOUR.Name = "VILLE_FOUR";
            this.VILLE_FOUR.ReadOnly = true;
            // 
            // ADRESSE_FOUR
            // 
            this.ADRESSE_FOUR.DataPropertyName = "ADRESSE_FOUR";
            this.ADRESSE_FOUR.HeaderText = "Adresse";
            this.ADRESSE_FOUR.Name = "ADRESSE_FOUR";
            this.ADRESSE_FOUR.ReadOnly = true;
            // 
            // CODEPOSTA_FOUR
            // 
            this.CODEPOSTA_FOUR.DataPropertyName = "CODEPOSTA_FOUR";
            this.CODEPOSTA_FOUR.HeaderText = "Code post.";
            this.CODEPOSTA_FOUR.Name = "CODEPOSTA_FOUR";
            this.CODEPOSTA_FOUR.ReadOnly = true;
            // 
            // DATE_FOUR
            // 
            this.DATE_FOUR.DataPropertyName = "DATE_FOUR";
            this.DATE_FOUR.HeaderText = "Date enr.";
            this.DATE_FOUR.Name = "DATE_FOUR";
            this.DATE_FOUR.ReadOnly = true;
            // 
            // AUTREINFO_FOUR
            // 
            this.AUTREINFO_FOUR.DataPropertyName = "AUTREINFO_FOUR";
            this.AUTREINFO_FOUR.HeaderText = "Note 1";
            this.AUTREINFO_FOUR.Name = "AUTREINFO_FOUR";
            this.AUTREINFO_FOUR.ReadOnly = true;
            this.AUTREINFO_FOUR.Width = 200;
            // 
            // USERCREATE_FOUR
            // 
            this.USERCREATE_FOUR.DataPropertyName = "USERCREATE_FOUR";
            this.USERCREATE_FOUR.HeaderText = "Créer par";
            this.USERCREATE_FOUR.Name = "USERCREATE_FOUR";
            this.USERCREATE_FOUR.ReadOnly = true;
            // 
            // DATECREATION_FOUR
            // 
            this.DATECREATION_FOUR.DataPropertyName = "DATECREATION_FOUR";
            this.DATECREATION_FOUR.HeaderText = "Créer le";
            this.DATECREATION_FOUR.Name = "DATECREATION_FOUR";
            this.DATECREATION_FOUR.ReadOnly = true;
            // 
            // FormMainFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1118, 731);
            this.Controls.Add(this.DgvProvider);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PanelTitleFour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMainFournisseur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMainFournisseur";
            this.PanelTitleFour.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton iconBtnCreateFourn;
        private FontAwesome.Sharp.IconButton iconBtnSearchFourn;
        private System.Windows.Forms.TextBox textBoxRecheFour;
        private System.Windows.Forms.Panel PanelTitleFour;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconBtnCloseFormMainFour;
        public System.Windows.Forms.DataGridView DgvProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_FOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_FOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_FOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEL_FOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAIL_FOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTE_FOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn REGICOM_FOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPTCONTRIB_FOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAYS_FOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn VILLE_FOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADRESSE_FOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODEPOSTA_FOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_FOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn AUTREINFO_FOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERCREATE_FOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATECREATION_FOUR;
    }
}