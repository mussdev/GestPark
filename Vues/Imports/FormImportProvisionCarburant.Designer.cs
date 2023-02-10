namespace GestPark
{
    partial class FormImportProvisionCarburant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImportProvisionCarburant));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoadImpProv = new FontAwesome.Sharp.IconButton();
            this.btnValImpProv = new FontAwesome.Sharp.IconButton();
            this.btnExpImpProv = new FontAwesome.Sharp.IconButton();
            this.dgvImpProv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMMATRICULATION_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE_PROV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KILO_AVANT_VIDENGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONTANT_PROV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LITRE_PROV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRIX_LITRE_PROV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_PROV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpProv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnLoadImpProv);
            this.panel1.Controls.Add(this.btnValImpProv);
            this.panel1.Controls.Add(this.btnExpImpProv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 537);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1157, 29);
            this.panel1.TabIndex = 0;
            // 
            // btnLoadImpProv
            // 
            this.btnLoadImpProv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadImpProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnLoadImpProv.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadImpProv.IconChar = FontAwesome.Sharp.IconChar.Spinner;
            this.btnLoadImpProv.IconColor = System.Drawing.Color.White;
            this.btnLoadImpProv.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoadImpProv.IconSize = 20;
            this.btnLoadImpProv.Location = new System.Drawing.Point(913, -2);
            this.btnLoadImpProv.Name = "btnLoadImpProv";
            this.btnLoadImpProv.Size = new System.Drawing.Size(118, 29);
            this.btnLoadImpProv.TabIndex = 2;
            this.btnLoadImpProv.Text = "Charger";
            this.btnLoadImpProv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadImpProv.UseVisualStyleBackColor = false;
            this.btnLoadImpProv.Click += new System.EventHandler(this.btnLoadImpProv_Click);
            // 
            // btnValImpProv
            // 
            this.btnValImpProv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValImpProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnValImpProv.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValImpProv.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
            this.btnValImpProv.IconColor = System.Drawing.Color.White;
            this.btnValImpProv.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnValImpProv.IconSize = 20;
            this.btnValImpProv.Location = new System.Drawing.Point(1037, -2);
            this.btnValImpProv.Name = "btnValImpProv";
            this.btnValImpProv.Size = new System.Drawing.Size(118, 29);
            this.btnValImpProv.TabIndex = 1;
            this.btnValImpProv.Text = "Valider";
            this.btnValImpProv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnValImpProv.UseVisualStyleBackColor = false;
            this.btnValImpProv.Click += new System.EventHandler(this.btnValImpProv_Click);
            // 
            // btnExpImpProv
            // 
            this.btnExpImpProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnExpImpProv.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpImpProv.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnExpImpProv.IconColor = System.Drawing.Color.White;
            this.btnExpImpProv.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExpImpProv.IconSize = 20;
            this.btnExpImpProv.Location = new System.Drawing.Point(-2, -2);
            this.btnExpImpProv.Name = "btnExpImpProv";
            this.btnExpImpProv.Size = new System.Drawing.Size(108, 29);
            this.btnExpImpProv.TabIndex = 0;
            this.btnExpImpProv.Text = "Exporter";
            this.btnExpImpProv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExpImpProv.UseVisualStyleBackColor = false;
            this.btnExpImpProv.Click += new System.EventHandler(this.btnExpImpProv_Click);
            // 
            // dgvImpProv
            // 
            this.dgvImpProv.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImpProv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvImpProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImpProv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.IMMATRICULATION_VEHICULE,
            this.CODE_PROV,
            this.KILO_AVANT_VIDENGE,
            this.MONTANT_PROV,
            this.LITRE_PROV,
            this.PRIX_LITRE_PROV,
            this.DATE_PROV});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvImpProv.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvImpProv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvImpProv.GridColor = System.Drawing.Color.White;
            this.dgvImpProv.Location = new System.Drawing.Point(0, 0);
            this.dgvImpProv.Name = "dgvImpProv";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImpProv.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvImpProv.RowHeadersWidth = 51;
            this.dgvImpProv.RowTemplate.Height = 24;
            this.dgvImpProv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvImpProv.Size = new System.Drawing.Size(1157, 537);
            this.dgvImpProv.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "N°";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // IMMATRICULATION_VEHICULE
            // 
            this.IMMATRICULATION_VEHICULE.DataPropertyName = "IMMATRICULATION_VEHICULE";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.IMMATRICULATION_VEHICULE.DefaultCellStyle = dataGridViewCellStyle2;
            this.IMMATRICULATION_VEHICULE.HeaderText = "Matricule véhicule";
            this.IMMATRICULATION_VEHICULE.MinimumWidth = 6;
            this.IMMATRICULATION_VEHICULE.Name = "IMMATRICULATION_VEHICULE";
            this.IMMATRICULATION_VEHICULE.ReadOnly = true;
            this.IMMATRICULATION_VEHICULE.Width = 200;
            // 
            // CODE_PROV
            // 
            this.CODE_PROV.DataPropertyName = "CODE_PROV";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CODE_PROV.DefaultCellStyle = dataGridViewCellStyle3;
            this.CODE_PROV.HeaderText = "Code prov.";
            this.CODE_PROV.MinimumWidth = 6;
            this.CODE_PROV.Name = "CODE_PROV";
            this.CODE_PROV.ReadOnly = true;
            this.CODE_PROV.Width = 125;
            // 
            // KILO_AVANT_VIDENGE
            // 
            this.KILO_AVANT_VIDENGE.DataPropertyName = "KILO_AVANT_VIDENGE";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.KILO_AVANT_VIDENGE.DefaultCellStyle = dataGridViewCellStyle4;
            this.KILO_AVANT_VIDENGE.HeaderText = "Kilometrage ava. prov.";
            this.KILO_AVANT_VIDENGE.MinimumWidth = 6;
            this.KILO_AVANT_VIDENGE.Name = "KILO_AVANT_VIDENGE";
            this.KILO_AVANT_VIDENGE.ReadOnly = true;
            this.KILO_AVANT_VIDENGE.Width = 200;
            // 
            // MONTANT_PROV
            // 
            this.MONTANT_PROV.DataPropertyName = "MONTANT_PROV";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.MONTANT_PROV.DefaultCellStyle = dataGridViewCellStyle5;
            this.MONTANT_PROV.HeaderText = "Montant net à payer";
            this.MONTANT_PROV.MinimumWidth = 6;
            this.MONTANT_PROV.Name = "MONTANT_PROV";
            this.MONTANT_PROV.ReadOnly = true;
            this.MONTANT_PROV.Width = 200;
            // 
            // LITRE_PROV
            // 
            this.LITRE_PROV.DataPropertyName = "LITRE_PROV";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.LITRE_PROV.DefaultCellStyle = dataGridViewCellStyle6;
            this.LITRE_PROV.HeaderText = "Litre conso.";
            this.LITRE_PROV.MinimumWidth = 6;
            this.LITRE_PROV.Name = "LITRE_PROV";
            this.LITRE_PROV.ReadOnly = true;
            this.LITRE_PROV.Width = 125;
            // 
            // PRIX_LITRE_PROV
            // 
            this.PRIX_LITRE_PROV.DataPropertyName = "PRIX_LITRE_PROV";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.PRIX_LITRE_PROV.DefaultCellStyle = dataGridViewCellStyle7;
            this.PRIX_LITRE_PROV.HeaderText = "Prix du litre";
            this.PRIX_LITRE_PROV.MinimumWidth = 6;
            this.PRIX_LITRE_PROV.Name = "PRIX_LITRE_PROV";
            this.PRIX_LITRE_PROV.ReadOnly = true;
            this.PRIX_LITRE_PROV.Width = 125;
            // 
            // DATE_PROV
            // 
            this.DATE_PROV.DataPropertyName = "DATE_PROV";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DATE_PROV.DefaultCellStyle = dataGridViewCellStyle8;
            this.DATE_PROV.HeaderText = "Date";
            this.DATE_PROV.MinimumWidth = 6;
            this.DATE_PROV.Name = "DATE_PROV";
            this.DATE_PROV.ReadOnly = true;
            this.DATE_PROV.Width = 125;
            // 
            // FormImportProvisionCarburant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1157, 566);
            this.Controls.Add(this.dgvImpProv);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormImportProvisionCarburant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Importer les ravitaillements en carburant";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpProv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnLoadImpProv;
        private FontAwesome.Sharp.IconButton btnValImpProv;
        private FontAwesome.Sharp.IconButton btnExpImpProv;
        private System.Windows.Forms.DataGridView dgvImpProv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMMATRICULATION_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_PROV;
        private System.Windows.Forms.DataGridViewTextBoxColumn KILO_AVANT_VIDENGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTANT_PROV;
        private System.Windows.Forms.DataGridViewTextBoxColumn LITRE_PROV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRIX_LITRE_PROV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_PROV;
    }
}