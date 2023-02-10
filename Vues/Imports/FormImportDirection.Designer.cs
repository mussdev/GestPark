namespace GestPark
{
    partial class FormImportDirection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImportDirection));
            this.dgvImportDirection = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImportFileDirec = new FontAwesome.Sharp.IconButton();
            this.btnLoadFileExcelDirec = new FontAwesome.Sharp.IconButton();
            this.btnValidImportDirec = new FontAwesome.Sharp.IconButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE_DIR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_DIR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportDirection)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvImportDirection
            // 
            this.dgvImportDirection.AllowUserToAddRows = false;
            this.dgvImportDirection.AllowUserToDeleteRows = false;
            this.dgvImportDirection.AllowUserToOrderColumns = true;
            this.dgvImportDirection.BackgroundColor = System.Drawing.Color.White;
            this.dgvImportDirection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvImportDirection.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImportDirection.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvImportDirection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImportDirection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.CODE_DIR,
            this.DESCRIPTION_DIR});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvImportDirection.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvImportDirection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvImportDirection.GridColor = System.Drawing.Color.White;
            this.dgvImportDirection.Location = new System.Drawing.Point(0, 0);
            this.dgvImportDirection.Name = "dgvImportDirection";
            this.dgvImportDirection.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImportDirection.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvImportDirection.RowHeadersVisible = false;
            this.dgvImportDirection.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvImportDirection.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvImportDirection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvImportDirection.Size = new System.Drawing.Size(874, 498);
            this.dgvImportDirection.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnImportFileDirec);
            this.panel1.Controls.Add(this.btnLoadFileExcelDirec);
            this.panel1.Controls.Add(this.btnValidImportDirec);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 498);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 32);
            this.panel1.TabIndex = 4;
            // 
            // btnImportFileDirec
            // 
            this.btnImportFileDirec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImportFileDirec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnImportFileDirec.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportFileDirec.IconChar = FontAwesome.Sharp.IconChar.FileExport;
            this.btnImportFileDirec.IconColor = System.Drawing.Color.Black;
            this.btnImportFileDirec.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImportFileDirec.IconSize = 15;
            this.btnImportFileDirec.Location = new System.Drawing.Point(-2, 0);
            this.btnImportFileDirec.Name = "btnImportFileDirec";
            this.btnImportFileDirec.Size = new System.Drawing.Size(98, 30);
            this.btnImportFileDirec.TabIndex = 3;
            this.btnImportFileDirec.Text = "Exporter";
            this.btnImportFileDirec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImportFileDirec.UseVisualStyleBackColor = false;
            this.btnImportFileDirec.Click += new System.EventHandler(this.btnImportFileDirec_Click);
            // 
            // btnLoadFileExcelDirec
            // 
            this.btnLoadFileExcelDirec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadFileExcelDirec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnLoadFileExcelDirec.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadFileExcelDirec.IconChar = FontAwesome.Sharp.IconChar.Spinner;
            this.btnLoadFileExcelDirec.IconColor = System.Drawing.Color.Black;
            this.btnLoadFileExcelDirec.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoadFileExcelDirec.IconSize = 15;
            this.btnLoadFileExcelDirec.Location = new System.Drawing.Point(611, 0);
            this.btnLoadFileExcelDirec.Name = "btnLoadFileExcelDirec";
            this.btnLoadFileExcelDirec.Size = new System.Drawing.Size(159, 30);
            this.btnLoadFileExcelDirec.TabIndex = 1;
            this.btnLoadFileExcelDirec.Text = "Charger le fichier";
            this.btnLoadFileExcelDirec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadFileExcelDirec.UseVisualStyleBackColor = false;
            this.btnLoadFileExcelDirec.Click += new System.EventHandler(this.btnLoadFileExcelDirec_Click);
            // 
            // btnValidImportDirec
            // 
            this.btnValidImportDirec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValidImportDirec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnValidImportDirec.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidImportDirec.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
            this.btnValidImportDirec.IconColor = System.Drawing.Color.Black;
            this.btnValidImportDirec.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnValidImportDirec.IconSize = 20;
            this.btnValidImportDirec.Location = new System.Drawing.Point(776, 0);
            this.btnValidImportDirec.Name = "btnValidImportDirec";
            this.btnValidImportDirec.Size = new System.Drawing.Size(98, 30);
            this.btnValidImportDirec.TabIndex = 2;
            this.btnValidImportDirec.Text = "Valider";
            this.btnValidImportDirec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnValidImportDirec.UseVisualStyleBackColor = false;
            this.btnValidImportDirec.Click += new System.EventHandler(this.btnValidImportDirec_Click);
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
            // CODE_DIR
            // 
            this.CODE_DIR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODE_DIR.DataPropertyName = "CODE_DIR";
            this.CODE_DIR.HeaderText = "Code serv.";
            this.CODE_DIR.MinimumWidth = 50;
            this.CODE_DIR.Name = "CODE_DIR";
            this.CODE_DIR.ReadOnly = true;
            // 
            // DESCRIPTION_DIR
            // 
            this.DESCRIPTION_DIR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DESCRIPTION_DIR.DataPropertyName = "DESCRIPTION_DIR";
            this.DESCRIPTION_DIR.HeaderText = "Description";
            this.DESCRIPTION_DIR.MinimumWidth = 200;
            this.DESCRIPTION_DIR.Name = "DESCRIPTION_DIR";
            this.DESCRIPTION_DIR.ReadOnly = true;
            // 
            // FormImportDirection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 530);
            this.Controls.Add(this.dgvImportDirection);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormImportDirection";
            this.Text = "Importation des directions";
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportDirection)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvImportDirection;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_DIR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_DIR;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnImportFileDirec;
        private FontAwesome.Sharp.IconButton btnLoadFileExcelDirec;
        private FontAwesome.Sharp.IconButton btnValidImportDirec;
    }
}