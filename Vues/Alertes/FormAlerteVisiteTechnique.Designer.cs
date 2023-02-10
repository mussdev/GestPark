namespace GestPark
{
    partial class FormAlerteVisiteTechnique
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlerteVisiteTechnique));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCloseAlertVisitTech = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvVisitTech = new System.Windows.Forms.DataGridView();
            this.VisitTech = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DATE_VISITE_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATEALERTEVISITETECH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATEPROCHAINEVISITETECH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMMATRICULATION_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODELE_MARQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_FOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVisitTech)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnCloseAlertVisitTech);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 26);
            this.panel1.TabIndex = 0;
            // 
            // btnCloseAlertVisitTech
            // 
            this.btnCloseAlertVisitTech.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseAlertVisitTech.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.btnCloseAlertVisitTech.IconColor = System.Drawing.Color.Red;
            this.btnCloseAlertVisitTech.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseAlertVisitTech.IconSize = 20;
            this.btnCloseAlertVisitTech.Location = new System.Drawing.Point(1017, -2);
            this.btnCloseAlertVisitTech.Name = "btnCloseAlertVisitTech";
            this.btnCloseAlertVisitTech.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnCloseAlertVisitTech.Size = new System.Drawing.Size(23, 26);
            this.btnCloseAlertVisitTech.TabIndex = 3;
            this.btnCloseAlertVisitTech.UseVisualStyleBackColor = true;
            this.btnCloseAlertVisitTech.Click += new System.EventHandler(this.btnCloseAlertVisitTech_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(480, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alerte visite technique  des véhicules";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 662);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1042, 19);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(952, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ParcAuto@2021";
            // 
            // DgvVisitTech
            // 
            this.DgvVisitTech.AllowUserToAddRows = false;
            this.DgvVisitTech.AllowUserToDeleteRows = false;
            this.DgvVisitTech.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DgvVisitTech.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvVisitTech.BackgroundColor = System.Drawing.Color.White;
            this.DgvVisitTech.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvVisitTech.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvVisitTech.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVisitTech.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VisitTech,
            this.DATE_VISITE_VEHICULE,
            this.DATEALERTEVISITETECH,
            this.DATEPROCHAINEVISITETECH,
            this.IMMATRICULATION_VEHICULE,
            this.MODELE_MARQ,
            this.Column3,
            this.DESCRIPTION_FOUR});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvVisitTech.DefaultCellStyle = dataGridViewCellStyle10;
            this.DgvVisitTech.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvVisitTech.Location = new System.Drawing.Point(0, 26);
            this.DgvVisitTech.Name = "DgvVisitTech";
            this.DgvVisitTech.ReadOnly = true;
            this.DgvVisitTech.RowHeadersWidth = 51;
            this.DgvVisitTech.Size = new System.Drawing.Size(1042, 636);
            this.DgvVisitTech.TabIndex = 5;
            this.DgvVisitTech.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVisitTech_CellContentClick);
            // 
            // VisitTech
            // 
            this.VisitTech.HeaderText = "Visite technique";
            this.VisitTech.MinimumWidth = 220;
            this.VisitTech.Name = "VisitTech";
            this.VisitTech.ReadOnly = true;
            this.VisitTech.Text = "Cliquez pour faire la visite technique";
            this.VisitTech.UseColumnTextForButtonValue = true;
            this.VisitTech.Width = 220;
            // 
            // DATE_VISITE_VEHICULE
            // 
            this.DATE_VISITE_VEHICULE.DataPropertyName = "DATE_VISITE_VEHICULE";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DATE_VISITE_VEHICULE.DefaultCellStyle = dataGridViewCellStyle3;
            this.DATE_VISITE_VEHICULE.HeaderText = "Date dern visite tech.";
            this.DATE_VISITE_VEHICULE.MinimumWidth = 6;
            this.DATE_VISITE_VEHICULE.Name = "DATE_VISITE_VEHICULE";
            this.DATE_VISITE_VEHICULE.ReadOnly = true;
            this.DATE_VISITE_VEHICULE.Width = 200;
            // 
            // DATEALERTEVISITETECH
            // 
            this.DATEALERTEVISITETECH.DataPropertyName = "DATEALERTEVISITETECH";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DATEALERTEVISITETECH.DefaultCellStyle = dataGridViewCellStyle4;
            this.DATEALERTEVISITETECH.HeaderText = "Alerte";
            this.DATEALERTEVISITETECH.MinimumWidth = 150;
            this.DATEALERTEVISITETECH.Name = "DATEALERTEVISITETECH";
            this.DATEALERTEVISITETECH.ReadOnly = true;
            this.DATEALERTEVISITETECH.Width = 150;
            // 
            // DATEPROCHAINEVISITETECH
            // 
            this.DATEPROCHAINEVISITETECH.DataPropertyName = "DATEPROCHAINEVISITETECH";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DATEPROCHAINEVISITETECH.DefaultCellStyle = dataGridViewCellStyle5;
            this.DATEPROCHAINEVISITETECH.HeaderText = "Date nouvelle visite";
            this.DATEPROCHAINEVISITETECH.MinimumWidth = 6;
            this.DATEPROCHAINEVISITETECH.Name = "DATEPROCHAINEVISITETECH";
            this.DATEPROCHAINEVISITETECH.ReadOnly = true;
            this.DATEPROCHAINEVISITETECH.Width = 200;
            // 
            // IMMATRICULATION_VEHICULE
            // 
            this.IMMATRICULATION_VEHICULE.DataPropertyName = "IMMATRICULATION_VEHICULE";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.IMMATRICULATION_VEHICULE.DefaultCellStyle = dataGridViewCellStyle6;
            this.IMMATRICULATION_VEHICULE.HeaderText = "Matricule véhicule";
            this.IMMATRICULATION_VEHICULE.MinimumWidth = 100;
            this.IMMATRICULATION_VEHICULE.Name = "IMMATRICULATION_VEHICULE";
            this.IMMATRICULATION_VEHICULE.ReadOnly = true;
            this.IMMATRICULATION_VEHICULE.Width = 200;
            // 
            // MODELE_MARQ
            // 
            this.MODELE_MARQ.DataPropertyName = "MODELE_MARQ";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.MODELE_MARQ.DefaultCellStyle = dataGridViewCellStyle7;
            this.MODELE_MARQ.HeaderText = "Modèle";
            this.MODELE_MARQ.MinimumWidth = 100;
            this.MODELE_MARQ.Name = "MODELE_MARQ";
            this.MODELE_MARQ.ReadOnly = true;
            this.MODELE_MARQ.Width = 200;
            // 
            // Column3
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column3.HeaderText = "Date de mise en service";
            this.Column3.MinimumWidth = 100;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // DESCRIPTION_FOUR
            // 
            this.DESCRIPTION_FOUR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DESCRIPTION_FOUR.DataPropertyName = "DESCRIPTION_FOUR";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DESCRIPTION_FOUR.DefaultCellStyle = dataGridViewCellStyle9;
            this.DESCRIPTION_FOUR.HeaderText = "Concessionnaire";
            this.DESCRIPTION_FOUR.MinimumWidth = 100;
            this.DESCRIPTION_FOUR.Name = "DESCRIPTION_FOUR";
            this.DESCRIPTION_FOUR.ReadOnly = true;
            // 
            // FormAlerteVisiteTechnique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1042, 681);
            this.Controls.Add(this.DgvVisitTech);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormAlerteVisiteTechnique";
            this.Text = "FormAlerteVisiteTechnique";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVisitTech)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnCloseAlertVisitTech;
        private System.Windows.Forms.DataGridView DgvVisitTech;
        private System.Windows.Forms.DataGridViewButtonColumn VisitTech;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_VISITE_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATEALERTEVISITETECH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATEPROCHAINEVISITETECH;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMMATRICULATION_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODELE_MARQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_FOUR;
    }
}