namespace GestPark
{
    partial class FormImportFournisseur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImportFournisseur));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvImportFourn = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE_FOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_FOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEL_FOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImportFileFour = new FontAwesome.Sharp.IconButton();
            this.btnLoadFileExcelFour = new FontAwesome.Sharp.IconButton();
            this.btnValidImportFour = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportFourn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnImportFileFour);
            this.panel1.Controls.Add(this.btnLoadFileExcelFour);
            this.panel1.Controls.Add(this.btnValidImportFour);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 531);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 32);
            this.panel1.TabIndex = 1;
            // 
            // dgvImportFourn
            // 
            this.dgvImportFourn.AllowUserToAddRows = false;
            this.dgvImportFourn.AllowUserToDeleteRows = false;
            this.dgvImportFourn.AllowUserToOrderColumns = true;
            this.dgvImportFourn.BackgroundColor = System.Drawing.Color.White;
            this.dgvImportFourn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvImportFourn.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImportFourn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvImportFourn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImportFourn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.CODE_FOUR,
            this.DESCRIPTION_FOUR,
            this.TEL_FOUR});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvImportFourn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvImportFourn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvImportFourn.GridColor = System.Drawing.Color.White;
            this.dgvImportFourn.Location = new System.Drawing.Point(0, 0);
            this.dgvImportFourn.Name = "dgvImportFourn";
            this.dgvImportFourn.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImportFourn.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvImportFourn.RowHeadersVisible = false;
            this.dgvImportFourn.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvImportFourn.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvImportFourn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvImportFourn.Size = new System.Drawing.Size(1056, 531);
            this.dgvImportFourn.TabIndex = 2;
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
            // CODE_FOUR
            // 
            this.CODE_FOUR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODE_FOUR.DataPropertyName = "CODE_FOUR";
            this.CODE_FOUR.HeaderText = "Code four.";
            this.CODE_FOUR.MinimumWidth = 6;
            this.CODE_FOUR.Name = "CODE_FOUR";
            this.CODE_FOUR.ReadOnly = true;
            this.CODE_FOUR.Width = 99;
            // 
            // DESCRIPTION_FOUR
            // 
            this.DESCRIPTION_FOUR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DESCRIPTION_FOUR.DataPropertyName = "DESCRIPTION_FOUR";
            this.DESCRIPTION_FOUR.HeaderText = "Fournisseur";
            this.DESCRIPTION_FOUR.MinimumWidth = 6;
            this.DESCRIPTION_FOUR.Name = "DESCRIPTION_FOUR";
            this.DESCRIPTION_FOUR.ReadOnly = true;
            this.DESCRIPTION_FOUR.Width = 105;
            // 
            // TEL_FOUR
            // 
            this.TEL_FOUR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TEL_FOUR.DataPropertyName = "TEL_FOUR";
            this.TEL_FOUR.HeaderText = "Tel.";
            this.TEL_FOUR.MinimumWidth = 100;
            this.TEL_FOUR.Name = "TEL_FOUR";
            this.TEL_FOUR.ReadOnly = true;
            // 
            // btnImportFileFour
            // 
            this.btnImportFileFour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImportFileFour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnImportFileFour.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportFileFour.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromFile;
            this.btnImportFileFour.IconColor = System.Drawing.Color.Black;
            this.btnImportFileFour.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImportFileFour.IconSize = 15;
            this.btnImportFileFour.Location = new System.Drawing.Point(-2, 0);
            this.btnImportFileFour.Name = "btnImportFileFour";
            this.btnImportFileFour.Size = new System.Drawing.Size(98, 30);
            this.btnImportFileFour.TabIndex = 3;
            this.btnImportFileFour.Text = "Exporter";
            this.btnImportFileFour.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImportFileFour.UseVisualStyleBackColor = false;
            this.btnImportFileFour.Click += new System.EventHandler(this.btnImportFileFour_Click);
            // 
            // btnLoadFileExcelFour
            // 
            this.btnLoadFileExcelFour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadFileExcelFour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnLoadFileExcelFour.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadFileExcelFour.IconChar = FontAwesome.Sharp.IconChar.Spinner;
            this.btnLoadFileExcelFour.IconColor = System.Drawing.Color.Black;
            this.btnLoadFileExcelFour.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoadFileExcelFour.IconSize = 15;
            this.btnLoadFileExcelFour.Location = new System.Drawing.Point(793, 0);
            this.btnLoadFileExcelFour.Name = "btnLoadFileExcelFour";
            this.btnLoadFileExcelFour.Size = new System.Drawing.Size(159, 30);
            this.btnLoadFileExcelFour.TabIndex = 1;
            this.btnLoadFileExcelFour.Text = "Charger le fichier";
            this.btnLoadFileExcelFour.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadFileExcelFour.UseVisualStyleBackColor = false;
            this.btnLoadFileExcelFour.Click += new System.EventHandler(this.btnLoadFileExcelFour_Click);
            // 
            // btnValidImportFour
            // 
            this.btnValidImportFour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValidImportFour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnValidImportFour.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidImportFour.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
            this.btnValidImportFour.IconColor = System.Drawing.Color.Black;
            this.btnValidImportFour.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnValidImportFour.IconSize = 20;
            this.btnValidImportFour.Location = new System.Drawing.Point(958, 0);
            this.btnValidImportFour.Name = "btnValidImportFour";
            this.btnValidImportFour.Size = new System.Drawing.Size(98, 30);
            this.btnValidImportFour.TabIndex = 2;
            this.btnValidImportFour.Text = "Valider";
            this.btnValidImportFour.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnValidImportFour.UseVisualStyleBackColor = false;
            this.btnValidImportFour.Click += new System.EventHandler(this.btnValidImportFour_Click);
            // 
            // FormImportFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1056, 563);
            this.Controls.Add(this.dgvImportFourn);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormImportFournisseur";
            this.Text = "Importer les fournisseurs";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportFourn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnImportFileFour;
        private FontAwesome.Sharp.IconButton btnLoadFileExcelFour;
        private FontAwesome.Sharp.IconButton btnValidImportFour;
        private System.Windows.Forms.DataGridView dgvImportFourn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_FOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_FOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEL_FOUR;
    }
}