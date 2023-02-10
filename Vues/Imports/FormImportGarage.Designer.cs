namespace GestPark
{
    partial class FormImportGarage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImportGarage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImportFileGarag = new FontAwesome.Sharp.IconButton();
            this.btnLoadFileExcelGarag = new FontAwesome.Sharp.IconButton();
            this.btnValidImportGarag = new FontAwesome.Sharp.IconButton();
            this.dgvImportGarage = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE_GARAGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_GARAGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEL_GARAGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportGarage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnImportFileGarag);
            this.panel1.Controls.Add(this.btnLoadFileExcelGarag);
            this.panel1.Controls.Add(this.btnValidImportGarag);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 440);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 32);
            this.panel1.TabIndex = 2;
            // 
            // btnImportFileGarag
            // 
            this.btnImportFileGarag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImportFileGarag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnImportFileGarag.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportFileGarag.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromFile;
            this.btnImportFileGarag.IconColor = System.Drawing.Color.Black;
            this.btnImportFileGarag.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImportFileGarag.IconSize = 15;
            this.btnImportFileGarag.Location = new System.Drawing.Point(-2, 3);
            this.btnImportFileGarag.Name = "btnImportFileGarag";
            this.btnImportFileGarag.Size = new System.Drawing.Size(98, 27);
            this.btnImportFileGarag.TabIndex = 3;
            this.btnImportFileGarag.Text = "Exporter";
            this.btnImportFileGarag.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImportFileGarag.UseVisualStyleBackColor = false;
            this.btnImportFileGarag.Click += new System.EventHandler(this.btnImportFileGarag_Click);
            // 
            // btnLoadFileExcelGarag
            // 
            this.btnLoadFileExcelGarag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadFileExcelGarag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnLoadFileExcelGarag.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadFileExcelGarag.IconChar = FontAwesome.Sharp.IconChar.Spinner;
            this.btnLoadFileExcelGarag.IconColor = System.Drawing.Color.Black;
            this.btnLoadFileExcelGarag.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoadFileExcelGarag.IconSize = 15;
            this.btnLoadFileExcelGarag.Location = new System.Drawing.Point(605, 3);
            this.btnLoadFileExcelGarag.Name = "btnLoadFileExcelGarag";
            this.btnLoadFileExcelGarag.Size = new System.Drawing.Size(159, 27);
            this.btnLoadFileExcelGarag.TabIndex = 1;
            this.btnLoadFileExcelGarag.Text = "Charger le fichier";
            this.btnLoadFileExcelGarag.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadFileExcelGarag.UseVisualStyleBackColor = false;
            this.btnLoadFileExcelGarag.Click += new System.EventHandler(this.btnLoadFileExcelGarag_Click);
            // 
            // btnValidImportGarag
            // 
            this.btnValidImportGarag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValidImportGarag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnValidImportGarag.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidImportGarag.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
            this.btnValidImportGarag.IconColor = System.Drawing.Color.Black;
            this.btnValidImportGarag.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnValidImportGarag.IconSize = 20;
            this.btnValidImportGarag.Location = new System.Drawing.Point(770, 3);
            this.btnValidImportGarag.Name = "btnValidImportGarag";
            this.btnValidImportGarag.Size = new System.Drawing.Size(98, 27);
            this.btnValidImportGarag.TabIndex = 2;
            this.btnValidImportGarag.Text = "Valider";
            this.btnValidImportGarag.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnValidImportGarag.UseVisualStyleBackColor = false;
            this.btnValidImportGarag.Click += new System.EventHandler(this.btnValidImportGarag_Click);
            // 
            // dgvImportGarage
            // 
            this.dgvImportGarage.AllowUserToAddRows = false;
            this.dgvImportGarage.AllowUserToDeleteRows = false;
            this.dgvImportGarage.AllowUserToOrderColumns = true;
            this.dgvImportGarage.BackgroundColor = System.Drawing.Color.White;
            this.dgvImportGarage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvImportGarage.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImportGarage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvImportGarage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImportGarage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.CODE_GARAGE,
            this.DESCRIPTION_GARAGE,
            this.TEL_GARAGE});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvImportGarage.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvImportGarage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvImportGarage.GridColor = System.Drawing.Color.White;
            this.dgvImportGarage.Location = new System.Drawing.Point(0, 0);
            this.dgvImportGarage.Name = "dgvImportGarage";
            this.dgvImportGarage.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImportGarage.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvImportGarage.RowHeadersVisible = false;
            this.dgvImportGarage.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvImportGarage.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvImportGarage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvImportGarage.Size = new System.Drawing.Size(868, 440);
            this.dgvImportGarage.TabIndex = 3;
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
            // CODE_GARAGE
            // 
            this.CODE_GARAGE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODE_GARAGE.DataPropertyName = "CODE_GARAGE";
            this.CODE_GARAGE.HeaderText = "Code";
            this.CODE_GARAGE.MinimumWidth = 6;
            this.CODE_GARAGE.Name = "CODE_GARAGE";
            this.CODE_GARAGE.ReadOnly = true;
            this.CODE_GARAGE.Width = 68;
            // 
            // DESCRIPTION_GARAGE
            // 
            this.DESCRIPTION_GARAGE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DESCRIPTION_GARAGE.DataPropertyName = "DESCRIPTION_GARAGE";
            this.DESCRIPTION_GARAGE.HeaderText = "Garage";
            this.DESCRIPTION_GARAGE.MinimumWidth = 6;
            this.DESCRIPTION_GARAGE.Name = "DESCRIPTION_GARAGE";
            this.DESCRIPTION_GARAGE.ReadOnly = true;
            this.DESCRIPTION_GARAGE.Width = 80;
            // 
            // TEL_GARAGE
            // 
            this.TEL_GARAGE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TEL_GARAGE.DataPropertyName = "TEL_GARAGE";
            this.TEL_GARAGE.HeaderText = "Tel.";
            this.TEL_GARAGE.MinimumWidth = 100;
            this.TEL_GARAGE.Name = "TEL_GARAGE";
            this.TEL_GARAGE.ReadOnly = true;
            // 
            // FormImportGarage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 472);
            this.Controls.Add(this.dgvImportGarage);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormImportGarage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Importer les garages";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportGarage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnImportFileGarag;
        private FontAwesome.Sharp.IconButton btnLoadFileExcelGarag;
        private FontAwesome.Sharp.IconButton btnValidImportGarag;
        private System.Windows.Forms.DataGridView dgvImportGarage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_GARAGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_GARAGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEL_GARAGE;
    }
}