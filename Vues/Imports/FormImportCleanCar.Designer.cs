namespace GestPark.Vues.Imports
{
    partial class FormImportCleanCar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImportCleanCar));
            this.btnLoadImpCleanCar = new FontAwesome.Sharp.IconButton();
            this.btnExpCleanCar = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnValImpCleanCar = new FontAwesome.Sharp.IconButton();
            this.dgvImpCleanCar = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMMATRICULATION_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE_WTCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LIEU_WTCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONTANT_WTCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATEREGISTER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATECREATE_WTCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpCleanCar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadImpCleanCar
            // 
            this.btnLoadImpCleanCar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadImpCleanCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnLoadImpCleanCar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadImpCleanCar.IconChar = FontAwesome.Sharp.IconChar.Spinner;
            this.btnLoadImpCleanCar.IconColor = System.Drawing.Color.White;
            this.btnLoadImpCleanCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoadImpCleanCar.IconSize = 20;
            this.btnLoadImpCleanCar.Location = new System.Drawing.Point(756, -2);
            this.btnLoadImpCleanCar.Name = "btnLoadImpCleanCar";
            this.btnLoadImpCleanCar.Size = new System.Drawing.Size(118, 29);
            this.btnLoadImpCleanCar.TabIndex = 2;
            this.btnLoadImpCleanCar.Text = "Charger";
            this.btnLoadImpCleanCar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadImpCleanCar.UseVisualStyleBackColor = false;
            this.btnLoadImpCleanCar.Click += new System.EventHandler(this.btnLoadImpCleanCar_Click);
            // 
            // btnExpCleanCar
            // 
            this.btnExpCleanCar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExpCleanCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnExpCleanCar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpCleanCar.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnExpCleanCar.IconColor = System.Drawing.Color.White;
            this.btnExpCleanCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExpCleanCar.IconSize = 20;
            this.btnExpCleanCar.Location = new System.Drawing.Point(-2, -2);
            this.btnExpCleanCar.Name = "btnExpCleanCar";
            this.btnExpCleanCar.Size = new System.Drawing.Size(108, 29);
            this.btnExpCleanCar.TabIndex = 0;
            this.btnExpCleanCar.Text = "Exporter";
            this.btnExpCleanCar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExpCleanCar.UseVisualStyleBackColor = false;
            this.btnExpCleanCar.Click += new System.EventHandler(this.btnExpCleanCar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnLoadImpCleanCar);
            this.panel1.Controls.Add(this.btnValImpCleanCar);
            this.panel1.Controls.Add(this.btnExpCleanCar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 534);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 29);
            this.panel1.TabIndex = 4;
            // 
            // btnValImpCleanCar
            // 
            this.btnValImpCleanCar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValImpCleanCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnValImpCleanCar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValImpCleanCar.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
            this.btnValImpCleanCar.IconColor = System.Drawing.Color.White;
            this.btnValImpCleanCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnValImpCleanCar.IconSize = 20;
            this.btnValImpCleanCar.Location = new System.Drawing.Point(880, -2);
            this.btnValImpCleanCar.Name = "btnValImpCleanCar";
            this.btnValImpCleanCar.Size = new System.Drawing.Size(118, 29);
            this.btnValImpCleanCar.TabIndex = 1;
            this.btnValImpCleanCar.Text = "Valider";
            this.btnValImpCleanCar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnValImpCleanCar.UseVisualStyleBackColor = false;
            this.btnValImpCleanCar.Click += new System.EventHandler(this.btnValImpCleanCar_Click);
            // 
            // dgvImpCleanCar
            // 
            this.dgvImpCleanCar.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImpCleanCar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvImpCleanCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImpCleanCar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.IMMATRICULATION_VEHICULE,
            this.CODE_WTCH,
            this.LIEU_WTCH,
            this.MONTANT_WTCH,
            this.DATEREGISTER,
            this.DATECREATE_WTCH});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvImpCleanCar.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvImpCleanCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvImpCleanCar.GridColor = System.Drawing.Color.White;
            this.dgvImpCleanCar.Location = new System.Drawing.Point(0, 0);
            this.dgvImpCleanCar.Name = "dgvImpCleanCar";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImpCleanCar.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvImpCleanCar.RowHeadersWidth = 51;
            this.dgvImpCleanCar.RowTemplate.Height = 24;
            this.dgvImpCleanCar.Size = new System.Drawing.Size(1000, 563);
            this.dgvImpCleanCar.TabIndex = 5;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "N°";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // IMMATRICULATION_VEHICULE
            // 
            this.IMMATRICULATION_VEHICULE.DataPropertyName = "IMMATRICULATION_VEHICULE";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.IMMATRICULATION_VEHICULE.DefaultCellStyle = dataGridViewCellStyle3;
            this.IMMATRICULATION_VEHICULE.HeaderText = "Véhicule";
            this.IMMATRICULATION_VEHICULE.MinimumWidth = 6;
            this.IMMATRICULATION_VEHICULE.Name = "IMMATRICULATION_VEHICULE";
            this.IMMATRICULATION_VEHICULE.ReadOnly = true;
            this.IMMATRICULATION_VEHICULE.Width = 200;
            // 
            // CODE_WTCH
            // 
            this.CODE_WTCH.DataPropertyName = "CODE_WTCH";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CODE_WTCH.DefaultCellStyle = dataGridViewCellStyle4;
            this.CODE_WTCH.HeaderText = "Code";
            this.CODE_WTCH.MinimumWidth = 6;
            this.CODE_WTCH.Name = "CODE_WTCH";
            this.CODE_WTCH.ReadOnly = true;
            this.CODE_WTCH.Width = 125;
            // 
            // LIEU_WTCH
            // 
            this.LIEU_WTCH.DataPropertyName = "LIEU_WTCH";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.LIEU_WTCH.DefaultCellStyle = dataGridViewCellStyle5;
            this.LIEU_WTCH.HeaderText = "Lieu";
            this.LIEU_WTCH.MinimumWidth = 6;
            this.LIEU_WTCH.Name = "LIEU_WTCH";
            this.LIEU_WTCH.ReadOnly = true;
            this.LIEU_WTCH.Width = 125;
            // 
            // MONTANT_WTCH
            // 
            this.MONTANT_WTCH.DataPropertyName = "MONTANT_WTCH";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.MONTANT_WTCH.DefaultCellStyle = dataGridViewCellStyle6;
            this.MONTANT_WTCH.HeaderText = "Montant";
            this.MONTANT_WTCH.MinimumWidth = 6;
            this.MONTANT_WTCH.Name = "MONTANT_WTCH";
            this.MONTANT_WTCH.ReadOnly = true;
            this.MONTANT_WTCH.Width = 200;
            // 
            // DATEREGISTER
            // 
            this.DATEREGISTER.DataPropertyName = "DATEREGISTER";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DATEREGISTER.DefaultCellStyle = dataGridViewCellStyle7;
            this.DATEREGISTER.HeaderText = "Date effective";
            this.DATEREGISTER.MinimumWidth = 6;
            this.DATEREGISTER.Name = "DATEREGISTER";
            this.DATEREGISTER.ReadOnly = true;
            this.DATEREGISTER.Width = 200;
            // 
            // DATECREATE_WTCH
            // 
            this.DATECREATE_WTCH.DataPropertyName = "DATECREATE_WTCH";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DATECREATE_WTCH.DefaultCellStyle = dataGridViewCellStyle8;
            this.DATECREATE_WTCH.HeaderText = "Date de création";
            this.DATECREATE_WTCH.MinimumWidth = 6;
            this.DATECREATE_WTCH.Name = "DATECREATE_WTCH";
            this.DATECREATE_WTCH.ReadOnly = true;
            this.DATECREATE_WTCH.Width = 200;
            // 
            // FormImportCleanCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1000, 563);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvImpCleanCar);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormImportCleanCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Importation des données de lavage de véhicule";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpCleanCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnLoadImpCleanCar;
        private FontAwesome.Sharp.IconButton btnExpCleanCar;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnValImpCleanCar;
        private System.Windows.Forms.DataGridView dgvImpCleanCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMMATRICULATION_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_WTCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn LIEU_WTCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTANT_WTCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATEREGISTER;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATECREATE_WTCH;
    }
}