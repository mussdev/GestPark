namespace GestPark.Vues.Imports
{
    partial class FormImportPaiement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImportPaiement));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoadImpPaieProv = new FontAwesome.Sharp.IconButton();
            this.btnValImpPaieProv = new FontAwesome.Sharp.IconButton();
            this.btnExpImpPaieProv = new FontAwesome.Sharp.IconButton();
            this.dgvImpPaieProv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM_CARD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE_PROV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTALPRIX_PAIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_PAIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpPaieProv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnLoadImpPaieProv);
            this.panel1.Controls.Add(this.btnValImpPaieProv);
            this.panel1.Controls.Add(this.btnExpImpPaieProv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 525);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 29);
            this.panel1.TabIndex = 8;
            // 
            // btnLoadImpPaieProv
            // 
            this.btnLoadImpPaieProv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadImpPaieProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnLoadImpPaieProv.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadImpPaieProv.IconChar = FontAwesome.Sharp.IconChar.Spinner;
            this.btnLoadImpPaieProv.IconColor = System.Drawing.Color.White;
            this.btnLoadImpPaieProv.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoadImpPaieProv.IconSize = 20;
            this.btnLoadImpPaieProv.Location = new System.Drawing.Point(774, -2);
            this.btnLoadImpPaieProv.Name = "btnLoadImpPaieProv";
            this.btnLoadImpPaieProv.Size = new System.Drawing.Size(118, 29);
            this.btnLoadImpPaieProv.TabIndex = 2;
            this.btnLoadImpPaieProv.Text = "Charger";
            this.btnLoadImpPaieProv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadImpPaieProv.UseVisualStyleBackColor = false;
            this.btnLoadImpPaieProv.Click += new System.EventHandler(this.btnLoadImpPaieProv_Click);
            // 
            // btnValImpPaieProv
            // 
            this.btnValImpPaieProv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValImpPaieProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnValImpPaieProv.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValImpPaieProv.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
            this.btnValImpPaieProv.IconColor = System.Drawing.Color.White;
            this.btnValImpPaieProv.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnValImpPaieProv.IconSize = 20;
            this.btnValImpPaieProv.Location = new System.Drawing.Point(898, -2);
            this.btnValImpPaieProv.Name = "btnValImpPaieProv";
            this.btnValImpPaieProv.Size = new System.Drawing.Size(118, 29);
            this.btnValImpPaieProv.TabIndex = 1;
            this.btnValImpPaieProv.Text = "Valider";
            this.btnValImpPaieProv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnValImpPaieProv.UseVisualStyleBackColor = false;
            this.btnValImpPaieProv.Click += new System.EventHandler(this.btnValImpPaieProv_Click);
            // 
            // btnExpImpPaieProv
            // 
            this.btnExpImpPaieProv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExpImpPaieProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnExpImpPaieProv.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpImpPaieProv.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnExpImpPaieProv.IconColor = System.Drawing.Color.White;
            this.btnExpImpPaieProv.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExpImpPaieProv.IconSize = 20;
            this.btnExpImpPaieProv.Location = new System.Drawing.Point(-2, -2);
            this.btnExpImpPaieProv.Name = "btnExpImpPaieProv";
            this.btnExpImpPaieProv.Size = new System.Drawing.Size(108, 29);
            this.btnExpImpPaieProv.TabIndex = 0;
            this.btnExpImpPaieProv.Text = "Exporter";
            this.btnExpImpPaieProv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExpImpPaieProv.UseVisualStyleBackColor = false;
            this.btnExpImpPaieProv.Click += new System.EventHandler(this.btnExpImpPaieProv_Click);
            // 
            // dgvImpPaieProv
            // 
            this.dgvImpPaieProv.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImpPaieProv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvImpPaieProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImpPaieProv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.NUM_CARD,
            this.CODE_PROV,
            this.TOTALPRIX_PAIE,
            this.DATE_PAIE});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvImpPaieProv.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvImpPaieProv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvImpPaieProv.GridColor = System.Drawing.Color.White;
            this.dgvImpPaieProv.Location = new System.Drawing.Point(0, 0);
            this.dgvImpPaieProv.Name = "dgvImpPaieProv";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImpPaieProv.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvImpPaieProv.RowHeadersWidth = 51;
            this.dgvImpPaieProv.RowTemplate.Height = 24;
            this.dgvImpPaieProv.Size = new System.Drawing.Size(1018, 554);
            this.dgvImpPaieProv.TabIndex = 9;
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
            // NUM_CARD
            // 
            this.NUM_CARD.DataPropertyName = "NUM_CARD";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.NUM_CARD.DefaultCellStyle = dataGridViewCellStyle3;
            this.NUM_CARD.HeaderText = "N° de la cate de paiement";
            this.NUM_CARD.MinimumWidth = 6;
            this.NUM_CARD.Name = "NUM_CARD";
            this.NUM_CARD.ReadOnly = true;
            this.NUM_CARD.Width = 250;
            // 
            // CODE_PROV
            // 
            this.CODE_PROV.DataPropertyName = "CODE_PROV";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CODE_PROV.DefaultCellStyle = dataGridViewCellStyle4;
            this.CODE_PROV.HeaderText = "Provision";
            this.CODE_PROV.MinimumWidth = 6;
            this.CODE_PROV.Name = "CODE_PROV";
            this.CODE_PROV.ReadOnly = true;
            this.CODE_PROV.Width = 125;
            // 
            // TOTALPRIX_PAIE
            // 
            this.TOTALPRIX_PAIE.DataPropertyName = "TOTALPRIX_PAIE";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.TOTALPRIX_PAIE.DefaultCellStyle = dataGridViewCellStyle5;
            this.TOTALPRIX_PAIE.HeaderText = "Montant debité";
            this.TOTALPRIX_PAIE.MinimumWidth = 6;
            this.TOTALPRIX_PAIE.Name = "TOTALPRIX_PAIE";
            this.TOTALPRIX_PAIE.ReadOnly = true;
            this.TOTALPRIX_PAIE.Width = 200;
            // 
            // DATE_PAIE
            // 
            this.DATE_PAIE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DATE_PAIE.DataPropertyName = "DATE_PAIE";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DATE_PAIE.DefaultCellStyle = dataGridViewCellStyle6;
            this.DATE_PAIE.HeaderText = "Date paie";
            this.DATE_PAIE.MinimumWidth = 150;
            this.DATE_PAIE.Name = "DATE_PAIE";
            this.DATE_PAIE.ReadOnly = true;
            // 
            // FormImportPaiement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1018, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvImpPaieProv);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormImportPaiement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Importation des paiements de carburant";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpPaieProv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnLoadImpPaieProv;
        private FontAwesome.Sharp.IconButton btnValImpPaieProv;
        private FontAwesome.Sharp.IconButton btnExpImpPaieProv;
        private System.Windows.Forms.DataGridView dgvImpPaieProv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_CARD;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_PROV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTALPRIX_PAIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_PAIE;
    }
}