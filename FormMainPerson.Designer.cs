
namespace GestPark
{
    partial class FormMainPerson
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnExportPerson = new FontAwesome.Sharp.IconButton();
            this.iconBtnCloseFormPers = new FontAwesome.Sharp.IconButton();
            this.iconBtnCreatePers = new FontAwesome.Sharp.IconButton();
            this.panelSearchPers = new System.Windows.Forms.Panel();
            this.iconBtnSearchPers = new FontAwesome.Sharp.IconButton();
            this.textBxSearchPers = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panelDisplayPers = new System.Windows.Forms.Panel();
            this.DgvPerson = new System.Windows.Forms.DataGridView();
            this.ID_PERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE_PERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOM_PERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRENOM_PERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATENAISS_PERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LIEUNAISS_PERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEL_PERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMPERMIS_PERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TYPEPIECE_PERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMPIECEIDENT_PERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TYPE_PERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAYS_PERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VILLE_PERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADRESSE_PERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODEPOSTAL_PERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_FOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTE_PERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERCREATE_PERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATECREATE_PERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panelSearchPers.SuspendLayout();
            this.panelDisplayPers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.BtnExportPerson);
            this.panel1.Controls.Add(this.iconBtnCloseFormPers);
            this.panel1.Controls.Add(this.iconBtnCreatePers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 26);
            this.panel1.TabIndex = 0;
            // 
            // BtnExportPerson
            // 
            this.BtnExportPerson.BackColor = System.Drawing.Color.White;
            this.BtnExportPerson.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExportPerson.ForeColor = System.Drawing.Color.DarkGreen;
            this.BtnExportPerson.IconChar = FontAwesome.Sharp.IconChar.FileExport;
            this.BtnExportPerson.IconColor = System.Drawing.Color.DarkGreen;
            this.BtnExportPerson.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnExportPerson.IconSize = 20;
            this.BtnExportPerson.Location = new System.Drawing.Point(92, -3);
            this.BtnExportPerson.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExportPerson.Name = "BtnExportPerson";
            this.BtnExportPerson.Size = new System.Drawing.Size(88, 27);
            this.BtnExportPerson.TabIndex = 2;
            this.BtnExportPerson.Text = "Exporter";
            this.BtnExportPerson.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExportPerson.UseVisualStyleBackColor = false;
            // 
            // iconBtnCloseFormPers
            // 
            this.iconBtnCloseFormPers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnCloseFormPers.BackColor = System.Drawing.Color.White;
            this.iconBtnCloseFormPers.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconBtnCloseFormPers.IconColor = System.Drawing.Color.Red;
            this.iconBtnCloseFormPers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnCloseFormPers.IconSize = 20;
            this.iconBtnCloseFormPers.Location = new System.Drawing.Point(1085, -2);
            this.iconBtnCloseFormPers.Name = "iconBtnCloseFormPers";
            this.iconBtnCloseFormPers.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.iconBtnCloseFormPers.Size = new System.Drawing.Size(33, 28);
            this.iconBtnCloseFormPers.TabIndex = 1;
            this.iconBtnCloseFormPers.UseVisualStyleBackColor = false;
            this.iconBtnCloseFormPers.Click += new System.EventHandler(this.iconBtnCloseFormPers_Click);
            // 
            // iconBtnCreatePers
            // 
            this.iconBtnCreatePers.BackColor = System.Drawing.Color.White;
            this.iconBtnCreatePers.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnCreatePers.ForeColor = System.Drawing.Color.DarkGreen;
            this.iconBtnCreatePers.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconBtnCreatePers.IconColor = System.Drawing.Color.DarkGreen;
            this.iconBtnCreatePers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnCreatePers.IconSize = 20;
            this.iconBtnCreatePers.Location = new System.Drawing.Point(-2, -2);
            this.iconBtnCreatePers.Margin = new System.Windows.Forms.Padding(4);
            this.iconBtnCreatePers.Name = "iconBtnCreatePers";
            this.iconBtnCreatePers.Size = new System.Drawing.Size(91, 27);
            this.iconBtnCreatePers.TabIndex = 0;
            this.iconBtnCreatePers.Text = "Créer";
            this.iconBtnCreatePers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnCreatePers.UseVisualStyleBackColor = false;
            this.iconBtnCreatePers.Click += new System.EventHandler(this.iconBtnCreatePers_Click);
            // 
            // panelSearchPers
            // 
            this.panelSearchPers.AutoScroll = true;
            this.panelSearchPers.BackColor = System.Drawing.Color.Khaki;
            this.panelSearchPers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSearchPers.Controls.Add(this.iconBtnSearchPers);
            this.panelSearchPers.Controls.Add(this.textBxSearchPers);
            this.panelSearchPers.Controls.Add(this.checkBox2);
            this.panelSearchPers.Controls.Add(this.checkBox1);
            this.panelSearchPers.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchPers.Location = new System.Drawing.Point(0, 26);
            this.panelSearchPers.Name = "panelSearchPers";
            this.panelSearchPers.Size = new System.Drawing.Size(1118, 100);
            this.panelSearchPers.TabIndex = 1;
            // 
            // iconBtnSearchPers
            // 
            this.iconBtnSearchPers.BackColor = System.Drawing.Color.White;
            this.iconBtnSearchPers.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconBtnSearchPers.IconColor = System.Drawing.Color.DarkGreen;
            this.iconBtnSearchPers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnSearchPers.IconSize = 22;
            this.iconBtnSearchPers.Location = new System.Drawing.Point(712, 34);
            this.iconBtnSearchPers.Name = "iconBtnSearchPers";
            this.iconBtnSearchPers.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.iconBtnSearchPers.Size = new System.Drawing.Size(34, 24);
            this.iconBtnSearchPers.TabIndex = 3;
            this.iconBtnSearchPers.UseVisualStyleBackColor = false;
            this.iconBtnSearchPers.Click += new System.EventHandler(this.iconBtnSearchPers_Click);
            // 
            // textBxSearchPers
            // 
            this.textBxSearchPers.Location = new System.Drawing.Point(397, 34);
            this.textBxSearchPers.Name = "textBxSearchPers";
            this.textBxSearchPers.Size = new System.Drawing.Size(309, 25);
            this.textBxSearchPers.TabIndex = 2;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.ForeColor = System.Drawing.Color.DarkGreen;
            this.checkBox2.Location = new System.Drawing.Point(10, 57);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(95, 21);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Conducteur";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.DarkGreen;
            this.checkBox1.Location = new System.Drawing.Point(10, 16);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Propriétaire";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panelDisplayPers
            // 
            this.panelDisplayPers.Controls.Add(this.DgvPerson);
            this.panelDisplayPers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDisplayPers.Location = new System.Drawing.Point(0, 126);
            this.panelDisplayPers.Name = "panelDisplayPers";
            this.panelDisplayPers.Size = new System.Drawing.Size(1118, 605);
            this.panelDisplayPers.TabIndex = 2;
            // 
            // DgvPerson
            // 
            this.DgvPerson.AllowUserToOrderColumns = true;
            this.DgvPerson.BackgroundColor = System.Drawing.Color.Khaki;
            this.DgvPerson.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PERS,
            this.CODE_PERS,
            this.NOM_PERS,
            this.PRENOM_PERS,
            this.DATENAISS_PERS,
            this.LIEUNAISS_PERS,
            this.TEL_PERS,
            this.NUMPERMIS_PERS,
            this.TYPEPIECE_PERS,
            this.NUMPIECEIDENT_PERS,
            this.TYPE_PERS,
            this.PAYS_PERS,
            this.VILLE_PERS,
            this.ADRESSE_PERS,
            this.CODEPOSTAL_PERS,
            this.DATE_FOUR,
            this.NOTE_PERS,
            this.USERCREATE_PERS,
            this.DATECREATE_PERS});
            this.DgvPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvPerson.Location = new System.Drawing.Point(0, 0);
            this.DgvPerson.Name = "DgvPerson";
            this.DgvPerson.Size = new System.Drawing.Size(1118, 605);
            this.DgvPerson.TabIndex = 0;
            this.DgvPerson.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerson_CellDoubleClick);
            // 
            // ID_PERS
            // 
            this.ID_PERS.DataPropertyName = "ID_PERS";
            this.ID_PERS.HeaderText = "N°";
            this.ID_PERS.Name = "ID_PERS";
            this.ID_PERS.Width = 50;
            // 
            // CODE_PERS
            // 
            this.CODE_PERS.DataPropertyName = "CODE_PERS";
            this.CODE_PERS.HeaderText = "Code";
            this.CODE_PERS.Name = "CODE_PERS";
            this.CODE_PERS.ReadOnly = true;
            // 
            // NOM_PERS
            // 
            this.NOM_PERS.DataPropertyName = "NOM_PERS";
            this.NOM_PERS.HeaderText = "Nom";
            this.NOM_PERS.Name = "NOM_PERS";
            // 
            // PRENOM_PERS
            // 
            this.PRENOM_PERS.DataPropertyName = "PRENOM_PERS";
            this.PRENOM_PERS.HeaderText = "Prénoms";
            this.PRENOM_PERS.Name = "PRENOM_PERS";
            // 
            // DATENAISS_PERS
            // 
            this.DATENAISS_PERS.DataPropertyName = "DATENAISS_PERS";
            this.DATENAISS_PERS.HeaderText = "Date naiss.";
            this.DATENAISS_PERS.Name = "DATENAISS_PERS";
            // 
            // LIEUNAISS_PERS
            // 
            this.LIEUNAISS_PERS.DataPropertyName = "LIEUNAISS_PERS";
            this.LIEUNAISS_PERS.HeaderText = "Lieu naiss.";
            this.LIEUNAISS_PERS.Name = "LIEUNAISS_PERS";
            // 
            // TEL_PERS
            // 
            this.TEL_PERS.DataPropertyName = "TEL_PERS";
            this.TEL_PERS.HeaderText = "Tél";
            this.TEL_PERS.Name = "TEL_PERS";
            // 
            // NUMPERMIS_PERS
            // 
            this.NUMPERMIS_PERS.DataPropertyName = "NUMPERMIS_PERS";
            this.NUMPERMIS_PERS.HeaderText = "N° Permis";
            this.NUMPERMIS_PERS.Name = "NUMPERMIS_PERS";
            // 
            // TYPEPIECE_PERS
            // 
            this.TYPEPIECE_PERS.DataPropertyName = "TYPEPIECE_PERS";
            this.TYPEPIECE_PERS.HeaderText = "Type pièce";
            this.TYPEPIECE_PERS.Name = "TYPEPIECE_PERS";
            // 
            // NUMPIECEIDENT_PERS
            // 
            this.NUMPIECEIDENT_PERS.DataPropertyName = "NUMPIECEIDENT_PERS";
            this.NUMPIECEIDENT_PERS.HeaderText = "N° pièce";
            this.NUMPIECEIDENT_PERS.Name = "NUMPIECEIDENT_PERS";
            // 
            // TYPE_PERS
            // 
            this.TYPE_PERS.DataPropertyName = "TYPE_PERS";
            this.TYPE_PERS.HeaderText = "Type";
            this.TYPE_PERS.Name = "TYPE_PERS";
            // 
            // PAYS_PERS
            // 
            this.PAYS_PERS.DataPropertyName = "PAYS_PERS";
            this.PAYS_PERS.HeaderText = "Pays";
            this.PAYS_PERS.Name = "PAYS_PERS";
            // 
            // VILLE_PERS
            // 
            this.VILLE_PERS.DataPropertyName = "VILLE_PERS";
            this.VILLE_PERS.HeaderText = "Ville";
            this.VILLE_PERS.Name = "VILLE_PERS";
            // 
            // ADRESSE_PERS
            // 
            this.ADRESSE_PERS.DataPropertyName = "ADRESSE_PERS";
            this.ADRESSE_PERS.HeaderText = "Adresse";
            this.ADRESSE_PERS.Name = "ADRESSE_PERS";
            // 
            // CODEPOSTAL_PERS
            // 
            this.CODEPOSTAL_PERS.DataPropertyName = "CODEPOSTAL_PERS";
            this.CODEPOSTAL_PERS.HeaderText = "Code Post.";
            this.CODEPOSTAL_PERS.Name = "CODEPOSTAL_PERS";
            // 
            // DATE_FOUR
            // 
            this.DATE_FOUR.DataPropertyName = "DATE_FOUR";
            this.DATE_FOUR.HeaderText = "Date";
            this.DATE_FOUR.Name = "DATE_FOUR";
            // 
            // NOTE_PERS
            // 
            this.NOTE_PERS.DataPropertyName = "NOTE_PERS";
            this.NOTE_PERS.HeaderText = "Note";
            this.NOTE_PERS.Name = "NOTE_PERS";
            // 
            // USERCREATE_PERS
            // 
            this.USERCREATE_PERS.DataPropertyName = "USERCREATE_PERS";
            this.USERCREATE_PERS.HeaderText = "Créer par";
            this.USERCREATE_PERS.Name = "USERCREATE_PERS";
            // 
            // DATECREATE_PERS
            // 
            this.DATECREATE_PERS.DataPropertyName = "DATECREATE_PERS";
            this.DATECREATE_PERS.HeaderText = "Créer le";
            this.DATECREATE_PERS.Name = "DATECREATE_PERS";
            // 
            // FormMainPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 731);
            this.Controls.Add(this.panelDisplayPers);
            this.Controls.Add(this.panelSearchPers);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMainPerson";
            this.Text = "FormMainPerson";
            this.panel1.ResumeLayout(false);
            this.panelSearchPers.ResumeLayout(false);
            this.panelSearchPers.PerformLayout();
            this.panelDisplayPers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPerson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconBtnCreatePers;
        private FontAwesome.Sharp.IconButton iconBtnCloseFormPers;
        private System.Windows.Forms.Panel panelSearchPers;
        private FontAwesome.Sharp.IconButton iconBtnSearchPers;
        private System.Windows.Forms.TextBox textBxSearchPers;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panelDisplayPers;
        private System.Windows.Forms.DataGridView DgvPerson;
        private FontAwesome.Sharp.IconButton BtnExportPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_PERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM_PERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRENOM_PERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATENAISS_PERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn LIEUNAISS_PERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEL_PERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMPERMIS_PERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TYPEPIECE_PERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMPIECEIDENT_PERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TYPE_PERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAYS_PERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn VILLE_PERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADRESSE_PERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODEPOSTAL_PERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_FOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTE_PERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERCREATE_PERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATECREATE_PERS;
    }
}