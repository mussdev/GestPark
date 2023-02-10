namespace GestPark
{
    partial class FormImportPerson
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImportPerson));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvImportPerson = new System.Windows.Forms.DataGridView();
            this.openFileDialogImportPers = new System.Windows.Forms.OpenFileDialog();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE_PERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOM_PERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRENOM_PERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_PERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FONCTION_PERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_SERV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEL_PERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMPERMIS_PERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TYPEPIECE_PERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMPIECEIDENT_PERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImportFilePers = new FontAwesome.Sharp.IconButton();
            this.btnLoadFileExcelPers = new FontAwesome.Sharp.IconButton();
            this.btnValidImportPers = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnImportFilePers);
            this.panel1.Controls.Add(this.btnLoadFileExcelPers);
            this.panel1.Controls.Add(this.btnValidImportPers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 505);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 32);
            this.panel1.TabIndex = 0;
            // 
            // dgvImportPerson
            // 
            this.dgvImportPerson.AllowUserToAddRows = false;
            this.dgvImportPerson.AllowUserToDeleteRows = false;
            this.dgvImportPerson.AllowUserToOrderColumns = true;
            this.dgvImportPerson.BackgroundColor = System.Drawing.Color.White;
            this.dgvImportPerson.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvImportPerson.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImportPerson.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvImportPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImportPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.CODE_PERS,
            this.NOM_PERS,
            this.PRENOM_PERS,
            this.DESCRIPTION_PERS,
            this.FONCTION_PERS,
            this.DESCRIPTION_SERV,
            this.TEL_PERS,
            this.NUMPERMIS_PERS,
            this.TYPEPIECE_PERS,
            this.NUMPIECEIDENT_PERS});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvImportPerson.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvImportPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvImportPerson.GridColor = System.Drawing.Color.White;
            this.dgvImportPerson.Location = new System.Drawing.Point(0, 0);
            this.dgvImportPerson.Name = "dgvImportPerson";
            this.dgvImportPerson.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImportPerson.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvImportPerson.RowHeadersVisible = false;
            this.dgvImportPerson.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvImportPerson.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvImportPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvImportPerson.Size = new System.Drawing.Size(1129, 505);
            this.dgvImportPerson.TabIndex = 1;
            // 
            // openFileDialogImportPers
            // 
            this.openFileDialogImportPers.FileName = "openFileDialog1";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "#";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 45;
            // 
            // CODE_PERS
            // 
            this.CODE_PERS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODE_PERS.DataPropertyName = "CODE_PERS";
            this.CODE_PERS.HeaderText = "Code pers.";
            this.CODE_PERS.MinimumWidth = 6;
            this.CODE_PERS.Name = "CODE_PERS";
            this.CODE_PERS.ReadOnly = true;
            this.CODE_PERS.Width = 101;
            // 
            // NOM_PERS
            // 
            this.NOM_PERS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NOM_PERS.DataPropertyName = "NOM_PERS";
            this.NOM_PERS.HeaderText = "Nom";
            this.NOM_PERS.MinimumWidth = 6;
            this.NOM_PERS.Name = "NOM_PERS";
            this.NOM_PERS.ReadOnly = true;
            this.NOM_PERS.Width = 66;
            // 
            // PRENOM_PERS
            // 
            this.PRENOM_PERS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PRENOM_PERS.DataPropertyName = "PRENOM_PERS";
            this.PRENOM_PERS.HeaderText = "Prenom";
            this.PRENOM_PERS.MinimumWidth = 6;
            this.PRENOM_PERS.Name = "PRENOM_PERS";
            this.PRENOM_PERS.ReadOnly = true;
            this.PRENOM_PERS.Width = 83;
            // 
            // DESCRIPTION_PERS
            // 
            this.DESCRIPTION_PERS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DESCRIPTION_PERS.DataPropertyName = "DESCRIPTION_PERS";
            this.DESCRIPTION_PERS.HeaderText = "Description";
            this.DESCRIPTION_PERS.MinimumWidth = 6;
            this.DESCRIPTION_PERS.Name = "DESCRIPTION_PERS";
            this.DESCRIPTION_PERS.ReadOnly = true;
            this.DESCRIPTION_PERS.Width = 104;
            // 
            // FONCTION_PERS
            // 
            this.FONCTION_PERS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FONCTION_PERS.DataPropertyName = "FONCTION_PERS";
            this.FONCTION_PERS.HeaderText = "Fonction";
            this.FONCTION_PERS.MinimumWidth = 6;
            this.FONCTION_PERS.Name = "FONCTION_PERS";
            this.FONCTION_PERS.ReadOnly = true;
            this.FONCTION_PERS.Width = 87;
            // 
            // DESCRIPTION_SERV
            // 
            this.DESCRIPTION_SERV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DESCRIPTION_SERV.DataPropertyName = "DESCRIPTION_SERV";
            this.DESCRIPTION_SERV.HeaderText = "Service";
            this.DESCRIPTION_SERV.MinimumWidth = 6;
            this.DESCRIPTION_SERV.Name = "DESCRIPTION_SERV";
            this.DESCRIPTION_SERV.ReadOnly = true;
            this.DESCRIPTION_SERV.Width = 81;
            // 
            // TEL_PERS
            // 
            this.TEL_PERS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TEL_PERS.DataPropertyName = "TEL_PERS";
            this.TEL_PERS.HeaderText = "Tel.";
            this.TEL_PERS.MinimumWidth = 6;
            this.TEL_PERS.Name = "TEL_PERS";
            this.TEL_PERS.ReadOnly = true;
            this.TEL_PERS.Width = 59;
            // 
            // NUMPERMIS_PERS
            // 
            this.NUMPERMIS_PERS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NUMPERMIS_PERS.DataPropertyName = "NUMPERMIS_PERS";
            this.NUMPERMIS_PERS.HeaderText = "N° permis";
            this.NUMPERMIS_PERS.MinimumWidth = 6;
            this.NUMPERMIS_PERS.Name = "NUMPERMIS_PERS";
            this.NUMPERMIS_PERS.ReadOnly = true;
            this.NUMPERMIS_PERS.Width = 97;
            // 
            // TYPEPIECE_PERS
            // 
            this.TYPEPIECE_PERS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TYPEPIECE_PERS.DataPropertyName = "TYPEPIECE_PERS";
            this.TYPEPIECE_PERS.HeaderText = "Type de pièce";
            this.TYPEPIECE_PERS.MinimumWidth = 6;
            this.TYPEPIECE_PERS.Name = "TYPEPIECE_PERS";
            this.TYPEPIECE_PERS.ReadOnly = true;
            this.TYPEPIECE_PERS.Width = 119;
            // 
            // NUMPIECEIDENT_PERS
            // 
            this.NUMPIECEIDENT_PERS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NUMPIECEIDENT_PERS.DataPropertyName = "NUMPIECEIDENT_PERS";
            this.NUMPIECEIDENT_PERS.HeaderText = "N° pièce";
            this.NUMPIECEIDENT_PERS.MinimumWidth = 6;
            this.NUMPIECEIDENT_PERS.Name = "NUMPIECEIDENT_PERS";
            this.NUMPIECEIDENT_PERS.ReadOnly = true;
            // 
            // btnImportFilePers
            // 
            this.btnImportFilePers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImportFilePers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnImportFilePers.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportFilePers.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromFile;
            this.btnImportFilePers.IconColor = System.Drawing.Color.Black;
            this.btnImportFilePers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImportFilePers.IconSize = 15;
            this.btnImportFilePers.Location = new System.Drawing.Point(-2, -2);
            this.btnImportFilePers.Name = "btnImportFilePers";
            this.btnImportFilePers.Size = new System.Drawing.Size(98, 32);
            this.btnImportFilePers.TabIndex = 3;
            this.btnImportFilePers.Text = "Exporter";
            this.btnImportFilePers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImportFilePers.UseVisualStyleBackColor = false;
            this.btnImportFilePers.Click += new System.EventHandler(this.btnImportFilePers_Click);
            // 
            // btnLoadFileExcelPers
            // 
            this.btnLoadFileExcelPers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadFileExcelPers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnLoadFileExcelPers.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadFileExcelPers.IconChar = FontAwesome.Sharp.IconChar.Spinner;
            this.btnLoadFileExcelPers.IconColor = System.Drawing.Color.Black;
            this.btnLoadFileExcelPers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoadFileExcelPers.IconSize = 15;
            this.btnLoadFileExcelPers.Location = new System.Drawing.Point(866, 0);
            this.btnLoadFileExcelPers.Name = "btnLoadFileExcelPers";
            this.btnLoadFileExcelPers.Size = new System.Drawing.Size(159, 30);
            this.btnLoadFileExcelPers.TabIndex = 1;
            this.btnLoadFileExcelPers.Text = "Charger le fichier";
            this.btnLoadFileExcelPers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadFileExcelPers.UseVisualStyleBackColor = false;
            this.btnLoadFileExcelPers.Click += new System.EventHandler(this.btnLoadFileExcelPers_Click);
            // 
            // btnValidImportPers
            // 
            this.btnValidImportPers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValidImportPers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnValidImportPers.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidImportPers.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
            this.btnValidImportPers.IconColor = System.Drawing.Color.Black;
            this.btnValidImportPers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnValidImportPers.IconSize = 20;
            this.btnValidImportPers.Location = new System.Drawing.Point(1031, 0);
            this.btnValidImportPers.Name = "btnValidImportPers";
            this.btnValidImportPers.Size = new System.Drawing.Size(98, 30);
            this.btnValidImportPers.TabIndex = 2;
            this.btnValidImportPers.Text = "Valider";
            this.btnValidImportPers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnValidImportPers.UseVisualStyleBackColor = false;
            this.btnValidImportPers.Click += new System.EventHandler(this.btnValidImportPers_Click);
            // 
            // FormImportPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1129, 537);
            this.Controls.Add(this.dgvImportPerson);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormImportPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Importer des personnes";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportPerson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnLoadFileExcelPers;
        private FontAwesome.Sharp.IconButton btnValidImportPers;
        private System.Windows.Forms.DataGridView dgvImportPerson;
        private System.Windows.Forms.OpenFileDialog openFileDialogImportPers;
        private FontAwesome.Sharp.IconButton btnImportFilePers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_PERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM_PERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRENOM_PERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_PERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn FONCTION_PERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_SERV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEL_PERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMPERMIS_PERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TYPEPIECE_PERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMPIECEIDENT_PERS;
    }
}