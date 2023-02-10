namespace GestPark
{
    partial class FormImportService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImportService));
            this.dgvImportServ = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_DIR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE_SERV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_SERV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImportFileServ = new FontAwesome.Sharp.IconButton();
            this.btnLoadFileExcelServ = new FontAwesome.Sharp.IconButton();
            this.btnValidImportServ = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportServ)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvImportServ
            // 
            this.dgvImportServ.AllowUserToAddRows = false;
            this.dgvImportServ.AllowUserToDeleteRows = false;
            this.dgvImportServ.AllowUserToOrderColumns = true;
            this.dgvImportServ.BackgroundColor = System.Drawing.Color.White;
            this.dgvImportServ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvImportServ.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImportServ.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvImportServ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImportServ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.DESCRIPTION_DIR,
            this.CODE_SERV,
            this.DESCRIPTION_SERV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvImportServ.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvImportServ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvImportServ.GridColor = System.Drawing.Color.White;
            this.dgvImportServ.Location = new System.Drawing.Point(0, 0);
            this.dgvImportServ.Name = "dgvImportServ";
            this.dgvImportServ.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImportServ.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvImportServ.RowHeadersVisible = false;
            this.dgvImportServ.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvImportServ.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvImportServ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvImportServ.Size = new System.Drawing.Size(977, 501);
            this.dgvImportServ.TabIndex = 3;
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
            // DESCRIPTION_DIR
            // 
            this.DESCRIPTION_DIR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DESCRIPTION_DIR.DataPropertyName = "DESCRIPTION_DIR";
            this.DESCRIPTION_DIR.HeaderText = "Direction";
            this.DESCRIPTION_DIR.MinimumWidth = 6;
            this.DESCRIPTION_DIR.Name = "DESCRIPTION_DIR";
            this.DESCRIPTION_DIR.ReadOnly = true;
            this.DESCRIPTION_DIR.Width = 91;
            // 
            // CODE_SERV
            // 
            this.CODE_SERV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODE_SERV.DataPropertyName = "CODE_SERV";
            this.CODE_SERV.HeaderText = "Code serv.";
            this.CODE_SERV.MinimumWidth = 6;
            this.CODE_SERV.Name = "CODE_SERV";
            this.CODE_SERV.ReadOnly = true;
            // 
            // DESCRIPTION_SERV
            // 
            this.DESCRIPTION_SERV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DESCRIPTION_SERV.DataPropertyName = "DESCRIPTION_SERV";
            this.DESCRIPTION_SERV.HeaderText = "Description";
            this.DESCRIPTION_SERV.MinimumWidth = 200;
            this.DESCRIPTION_SERV.Name = "DESCRIPTION_SERV";
            this.DESCRIPTION_SERV.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnImportFileServ);
            this.panel1.Controls.Add(this.btnLoadFileExcelServ);
            this.panel1.Controls.Add(this.btnValidImportServ);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 501);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 26);
            this.panel1.TabIndex = 2;
            // 
            // btnImportFileServ
            // 
            this.btnImportFileServ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImportFileServ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnImportFileServ.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportFileServ.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromFile;
            this.btnImportFileServ.IconColor = System.Drawing.Color.White;
            this.btnImportFileServ.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImportFileServ.IconSize = 15;
            this.btnImportFileServ.Location = new System.Drawing.Point(-2, 0);
            this.btnImportFileServ.Name = "btnImportFileServ";
            this.btnImportFileServ.Size = new System.Drawing.Size(98, 24);
            this.btnImportFileServ.TabIndex = 3;
            this.btnImportFileServ.Text = "Exporter";
            this.btnImportFileServ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImportFileServ.UseVisualStyleBackColor = false;
            this.btnImportFileServ.Click += new System.EventHandler(this.btnImportFileServ_Click);
            // 
            // btnLoadFileExcelServ
            // 
            this.btnLoadFileExcelServ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadFileExcelServ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnLoadFileExcelServ.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadFileExcelServ.IconChar = FontAwesome.Sharp.IconChar.Spinner;
            this.btnLoadFileExcelServ.IconColor = System.Drawing.Color.White;
            this.btnLoadFileExcelServ.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoadFileExcelServ.IconSize = 15;
            this.btnLoadFileExcelServ.Location = new System.Drawing.Point(714, 0);
            this.btnLoadFileExcelServ.Name = "btnLoadFileExcelServ";
            this.btnLoadFileExcelServ.Size = new System.Drawing.Size(159, 24);
            this.btnLoadFileExcelServ.TabIndex = 1;
            this.btnLoadFileExcelServ.Text = "Charger le fichier";
            this.btnLoadFileExcelServ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadFileExcelServ.UseVisualStyleBackColor = false;
            this.btnLoadFileExcelServ.Click += new System.EventHandler(this.btnLoadFileExcelServ_Click);
            // 
            // btnValidImportServ
            // 
            this.btnValidImportServ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValidImportServ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnValidImportServ.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidImportServ.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
            this.btnValidImportServ.IconColor = System.Drawing.Color.White;
            this.btnValidImportServ.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnValidImportServ.IconSize = 20;
            this.btnValidImportServ.Location = new System.Drawing.Point(879, 0);
            this.btnValidImportServ.Name = "btnValidImportServ";
            this.btnValidImportServ.Size = new System.Drawing.Size(98, 24);
            this.btnValidImportServ.TabIndex = 2;
            this.btnValidImportServ.Text = "Valider";
            this.btnValidImportServ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnValidImportServ.UseVisualStyleBackColor = false;
            this.btnValidImportServ.Click += new System.EventHandler(this.btnValidImportServ_Click);
            // 
            // FormImportService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 527);
            this.Controls.Add(this.dgvImportServ);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormImportService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Importation des services";
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportServ)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvImportServ;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnImportFileServ;
        private FontAwesome.Sharp.IconButton btnLoadFileExcelServ;
        private FontAwesome.Sharp.IconButton btnValidImportServ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_DIR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_SERV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_SERV;
    }
}