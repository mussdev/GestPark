namespace GestPark.Vues.Imports
{
    partial class FormImportRepairCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImportRepairCar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvImpCleanCar = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMMATRICULATION_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_GARAGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE_REPAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRIX_REPAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_REPAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAUSE_REPAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoadRepaiCar = new FontAwesome.Sharp.IconButton();
            this.btnValImpRepaiCar = new FontAwesome.Sharp.IconButton();
            this.btnExpRepaiCar = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpCleanCar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnLoadRepaiCar);
            this.panel1.Controls.Add(this.btnValImpRepaiCar);
            this.panel1.Controls.Add(this.btnExpRepaiCar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 545);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 29);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.DESCRIPTION_GARAGE,
            this.CODE_REPAR,
            this.PRIX_REPAR,
            this.DATE_REPAR,
            this.CAUSE_REPAR});
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
            this.dgvImpCleanCar.Size = new System.Drawing.Size(1005, 574);
            this.dgvImpCleanCar.TabIndex = 7;
            this.dgvImpCleanCar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImpCleanCar_CellContentClick);
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
            // DESCRIPTION_GARAGE
            // 
            this.DESCRIPTION_GARAGE.DataPropertyName = "DESCRIPTION_GARAGE";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DESCRIPTION_GARAGE.DefaultCellStyle = dataGridViewCellStyle4;
            this.DESCRIPTION_GARAGE.HeaderText = "Garage";
            this.DESCRIPTION_GARAGE.MinimumWidth = 6;
            this.DESCRIPTION_GARAGE.Name = "DESCRIPTION_GARAGE";
            this.DESCRIPTION_GARAGE.ReadOnly = true;
            this.DESCRIPTION_GARAGE.Width = 125;
            // 
            // CODE_REPAR
            // 
            this.CODE_REPAR.DataPropertyName = "CODE_REPAR";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CODE_REPAR.DefaultCellStyle = dataGridViewCellStyle5;
            this.CODE_REPAR.HeaderText = "Code";
            this.CODE_REPAR.MinimumWidth = 6;
            this.CODE_REPAR.Name = "CODE_REPAR";
            this.CODE_REPAR.ReadOnly = true;
            this.CODE_REPAR.Width = 125;
            // 
            // PRIX_REPAR
            // 
            this.PRIX_REPAR.DataPropertyName = "PRIX_REPAR";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.PRIX_REPAR.DefaultCellStyle = dataGridViewCellStyle6;
            this.PRIX_REPAR.HeaderText = "Montant";
            this.PRIX_REPAR.MinimumWidth = 6;
            this.PRIX_REPAR.Name = "PRIX_REPAR";
            this.PRIX_REPAR.ReadOnly = true;
            this.PRIX_REPAR.Width = 200;
            // 
            // DATE_REPAR
            // 
            this.DATE_REPAR.DataPropertyName = "DATE_REPAR";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DATE_REPAR.DefaultCellStyle = dataGridViewCellStyle7;
            this.DATE_REPAR.HeaderText = "Date effective";
            this.DATE_REPAR.MinimumWidth = 6;
            this.DATE_REPAR.Name = "DATE_REPAR";
            this.DATE_REPAR.ReadOnly = true;
            this.DATE_REPAR.Width = 200;
            // 
            // CAUSE_REPAR
            // 
            this.CAUSE_REPAR.DataPropertyName = "CAUSE_REPAR";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CAUSE_REPAR.DefaultCellStyle = dataGridViewCellStyle8;
            this.CAUSE_REPAR.HeaderText = "Cause de répar.";
            this.CAUSE_REPAR.MinimumWidth = 6;
            this.CAUSE_REPAR.Name = "CAUSE_REPAR";
            this.CAUSE_REPAR.ReadOnly = true;
            this.CAUSE_REPAR.Width = 200;
            // 
            // btnLoadRepaiCar
            // 
            this.btnLoadRepaiCar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadRepaiCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnLoadRepaiCar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadRepaiCar.IconChar = FontAwesome.Sharp.IconChar.Spinner;
            this.btnLoadRepaiCar.IconColor = System.Drawing.Color.White;
            this.btnLoadRepaiCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoadRepaiCar.IconSize = 20;
            this.btnLoadRepaiCar.Location = new System.Drawing.Point(761, -2);
            this.btnLoadRepaiCar.Name = "btnLoadRepaiCar";
            this.btnLoadRepaiCar.Size = new System.Drawing.Size(118, 29);
            this.btnLoadRepaiCar.TabIndex = 2;
            this.btnLoadRepaiCar.Text = "Charger";
            this.btnLoadRepaiCar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadRepaiCar.UseVisualStyleBackColor = false;
            this.btnLoadRepaiCar.Click += new System.EventHandler(this.btnLoadRepaiCar_Click);
            // 
            // btnValImpRepaiCar
            // 
            this.btnValImpRepaiCar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValImpRepaiCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnValImpRepaiCar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValImpRepaiCar.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
            this.btnValImpRepaiCar.IconColor = System.Drawing.Color.White;
            this.btnValImpRepaiCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnValImpRepaiCar.IconSize = 20;
            this.btnValImpRepaiCar.Location = new System.Drawing.Point(885, -2);
            this.btnValImpRepaiCar.Name = "btnValImpRepaiCar";
            this.btnValImpRepaiCar.Size = new System.Drawing.Size(118, 29);
            this.btnValImpRepaiCar.TabIndex = 1;
            this.btnValImpRepaiCar.Text = "Valider";
            this.btnValImpRepaiCar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnValImpRepaiCar.UseVisualStyleBackColor = false;
            this.btnValImpRepaiCar.Click += new System.EventHandler(this.btnValImpRepaiCar_Click);
            // 
            // btnExpRepaiCar
            // 
            this.btnExpRepaiCar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExpRepaiCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnExpRepaiCar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpRepaiCar.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnExpRepaiCar.IconColor = System.Drawing.Color.White;
            this.btnExpRepaiCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExpRepaiCar.IconSize = 20;
            this.btnExpRepaiCar.Location = new System.Drawing.Point(-2, -2);
            this.btnExpRepaiCar.Name = "btnExpRepaiCar";
            this.btnExpRepaiCar.Size = new System.Drawing.Size(108, 29);
            this.btnExpRepaiCar.TabIndex = 0;
            this.btnExpRepaiCar.Text = "Exporter";
            this.btnExpRepaiCar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExpRepaiCar.UseVisualStyleBackColor = false;
            this.btnExpRepaiCar.Click += new System.EventHandler(this.btnExpImpRepaiCar_Click);
            // 
            // FormImportRepairCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1005, 574);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvImpCleanCar);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormImportRepairCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Importation des données de réparation de véhicules";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpCleanCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnLoadRepaiCar;
        private FontAwesome.Sharp.IconButton btnValImpRepaiCar;
        private FontAwesome.Sharp.IconButton btnExpRepaiCar;
        private System.Windows.Forms.DataGridView dgvImpCleanCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMMATRICULATION_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_GARAGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_REPAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRIX_REPAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_REPAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAUSE_REPAR;
    }
}