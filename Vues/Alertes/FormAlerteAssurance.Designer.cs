namespace GestPark
{
    partial class FormAlerteAssurance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlerteAssurance));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCloseAlertAssur = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvAssur = new System.Windows.Forms.DataGridView();
            this.AssuranceAuto = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ASSURANCE_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATEALERTEASSURANCE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATEPROCHAINEASSURANCE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATEMISEENSERVICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMMATRICULATION_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODELE_MARQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_FOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAssur)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnCloseAlertAssur);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1238, 26);
            this.panel1.TabIndex = 1;
            // 
            // btnCloseAlertAssur
            // 
            this.btnCloseAlertAssur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseAlertAssur.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.btnCloseAlertAssur.IconColor = System.Drawing.Color.Red;
            this.btnCloseAlertAssur.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseAlertAssur.IconSize = 20;
            this.btnCloseAlertAssur.Location = new System.Drawing.Point(1213, -2);
            this.btnCloseAlertAssur.Name = "btnCloseAlertAssur";
            this.btnCloseAlertAssur.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnCloseAlertAssur.Size = new System.Drawing.Size(23, 26);
            this.btnCloseAlertAssur.TabIndex = 3;
            this.btnCloseAlertAssur.UseVisualStyleBackColor = true;
            this.btnCloseAlertAssur.Click += new System.EventHandler(this.btnCloseAlertAssur_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(610, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alerte assurance de véhicule";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 640);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1238, 19);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1148, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ParcAuto@2021";
            // 
            // DgvAssur
            // 
            this.DgvAssur.AllowUserToAddRows = false;
            this.DgvAssur.AllowUserToDeleteRows = false;
            this.DgvAssur.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DgvAssur.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvAssur.BackgroundColor = System.Drawing.Color.White;
            this.DgvAssur.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvAssur.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvAssur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAssur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssuranceAuto,
            this.ASSURANCE_VEHICULE,
            this.DATEALERTEASSURANCE,
            this.DATEPROCHAINEASSURANCE,
            this.DATEMISEENSERVICE,
            this.IMMATRICULATION_VEHICULE,
            this.MODELE_MARQ,
            this.DESCRIPTION_FOUR});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvAssur.DefaultCellStyle = dataGridViewCellStyle10;
            this.DgvAssur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvAssur.GridColor = System.Drawing.Color.White;
            this.DgvAssur.Location = new System.Drawing.Point(0, 26);
            this.DgvAssur.Name = "DgvAssur";
            this.DgvAssur.ReadOnly = true;
            this.DgvAssur.RowHeadersWidth = 51;
            this.DgvAssur.Size = new System.Drawing.Size(1238, 614);
            this.DgvAssur.TabIndex = 6;
            this.DgvAssur.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAssur_CellContentClick);
            // 
            // AssuranceAuto
            // 
            this.AssuranceAuto.HeaderText = "Assurer";
            this.AssuranceAuto.MinimumWidth = 250;
            this.AssuranceAuto.Name = "AssuranceAuto";
            this.AssuranceAuto.ReadOnly = true;
            this.AssuranceAuto.Text = "Cliquez pour Assurer le véhicule";
            this.AssuranceAuto.UseColumnTextForButtonValue = true;
            this.AssuranceAuto.Width = 250;
            // 
            // ASSURANCE_VEHICULE
            // 
            this.ASSURANCE_VEHICULE.DataPropertyName = "ASSURANCE_VEHICULE";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ASSURANCE_VEHICULE.DefaultCellStyle = dataGridViewCellStyle3;
            this.ASSURANCE_VEHICULE.HeaderText = "Date dernière assurance";
            this.ASSURANCE_VEHICULE.MinimumWidth = 100;
            this.ASSURANCE_VEHICULE.Name = "ASSURANCE_VEHICULE";
            this.ASSURANCE_VEHICULE.ReadOnly = true;
            this.ASSURANCE_VEHICULE.Width = 200;
            // 
            // DATEALERTEASSURANCE
            // 
            this.DATEALERTEASSURANCE.DataPropertyName = "DATEALERTEASSURANCE";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DATEALERTEASSURANCE.DefaultCellStyle = dataGridViewCellStyle4;
            this.DATEALERTEASSURANCE.HeaderText = "Alerte";
            this.DATEALERTEASSURANCE.MinimumWidth = 100;
            this.DATEALERTEASSURANCE.Name = "DATEALERTEASSURANCE";
            this.DATEALERTEASSURANCE.ReadOnly = true;
            this.DATEALERTEASSURANCE.Width = 200;
            // 
            // DATEPROCHAINEASSURANCE
            // 
            this.DATEPROCHAINEASSURANCE.DataPropertyName = "DATEPROCHAINEASSURANCE";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DATEPROCHAINEASSURANCE.DefaultCellStyle = dataGridViewCellStyle5;
            this.DATEPROCHAINEASSURANCE.HeaderText = "Date nouvelle assurance";
            this.DATEPROCHAINEASSURANCE.MinimumWidth = 100;
            this.DATEPROCHAINEASSURANCE.Name = "DATEPROCHAINEASSURANCE";
            this.DATEPROCHAINEASSURANCE.ReadOnly = true;
            this.DATEPROCHAINEASSURANCE.Width = 200;
            // 
            // DATEMISEENSERVICE
            // 
            this.DATEMISEENSERVICE.DataPropertyName = "DATEMISEENSERVICE";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DATEMISEENSERVICE.DefaultCellStyle = dataGridViewCellStyle6;
            this.DATEMISEENSERVICE.HeaderText = "Date de mise en service";
            this.DATEMISEENSERVICE.MinimumWidth = 100;
            this.DATEMISEENSERVICE.Name = "DATEMISEENSERVICE";
            this.DATEMISEENSERVICE.ReadOnly = true;
            this.DATEMISEENSERVICE.Width = 200;
            // 
            // IMMATRICULATION_VEHICULE
            // 
            this.IMMATRICULATION_VEHICULE.DataPropertyName = "IMMATRICULATION_VEHICULE";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.IMMATRICULATION_VEHICULE.DefaultCellStyle = dataGridViewCellStyle7;
            this.IMMATRICULATION_VEHICULE.HeaderText = "Matricule véhicule";
            this.IMMATRICULATION_VEHICULE.MinimumWidth = 100;
            this.IMMATRICULATION_VEHICULE.Name = "IMMATRICULATION_VEHICULE";
            this.IMMATRICULATION_VEHICULE.ReadOnly = true;
            this.IMMATRICULATION_VEHICULE.Width = 200;
            // 
            // MODELE_MARQ
            // 
            this.MODELE_MARQ.DataPropertyName = "MODELE_MARQ";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.MODELE_MARQ.DefaultCellStyle = dataGridViewCellStyle8;
            this.MODELE_MARQ.HeaderText = "Modèle";
            this.MODELE_MARQ.MinimumWidth = 100;
            this.MODELE_MARQ.Name = "MODELE_MARQ";
            this.MODELE_MARQ.ReadOnly = true;
            this.MODELE_MARQ.Width = 200;
            // 
            // DESCRIPTION_FOUR
            // 
            this.DESCRIPTION_FOUR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DESCRIPTION_FOUR.DataPropertyName = "DESCRIPTION_FOUR";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DESCRIPTION_FOUR.DefaultCellStyle = dataGridViewCellStyle9;
            this.DESCRIPTION_FOUR.HeaderText = "Concessionnaire";
            this.DESCRIPTION_FOUR.MinimumWidth = 200;
            this.DESCRIPTION_FOUR.Name = "DESCRIPTION_FOUR";
            this.DESCRIPTION_FOUR.ReadOnly = true;
            // 
            // FormAlerteAssurance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1238, 659);
            this.Controls.Add(this.DgvAssur);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormAlerteAssurance";
            this.Text = "FormAlerteAssurance";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAssur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnCloseAlertAssur;
        private System.Windows.Forms.DataGridView DgvAssur;
        private System.Windows.Forms.DataGridViewButtonColumn AssuranceAuto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASSURANCE_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATEALERTEASSURANCE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATEPROCHAINEASSURANCE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATEMISEENSERVICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMMATRICULATION_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODELE_MARQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_FOUR;
    }
}