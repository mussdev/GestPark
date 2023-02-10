namespace GestPark
{
    partial class FormAlerteVidange
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlerteVidange));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCloseAlertVidange = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvVidange = new System.Windows.Forms.DataGridView();
            this.Vidange = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IMMATRICULATION_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODELE_MARQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATEMISEENSERVICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_FOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTALKILOMETRAGE_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEUIL_KILO_VDGE_MARQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KILOMETRAGE_VIDENGE_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVidange)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnCloseAlertVidange);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1151, 26);
            this.panel1.TabIndex = 2;
            // 
            // btnCloseAlertVidange
            // 
            this.btnCloseAlertVidange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseAlertVidange.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.btnCloseAlertVidange.IconColor = System.Drawing.Color.Red;
            this.btnCloseAlertVidange.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseAlertVidange.IconSize = 20;
            this.btnCloseAlertVidange.Location = new System.Drawing.Point(1126, -2);
            this.btnCloseAlertVidange.Name = "btnCloseAlertVidange";
            this.btnCloseAlertVidange.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnCloseAlertVidange.Size = new System.Drawing.Size(23, 26);
            this.btnCloseAlertVidange.TabIndex = 2;
            this.btnCloseAlertVidange.UseVisualStyleBackColor = true;
            this.btnCloseAlertVidange.Click += new System.EventHandler(this.btnCloseAlertVidange_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(581, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alerte vidange de véhicule";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 665);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1151, 19);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1061, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ParcAuto@2021";
            // 
            // DgvVidange
            // 
            this.DgvVidange.AllowUserToAddRows = false;
            this.DgvVidange.AllowUserToDeleteRows = false;
            this.DgvVidange.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DgvVidange.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvVidange.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.DgvVidange.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvVidange.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvVidange.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVidange.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Vidange,
            this.IMMATRICULATION_VEHICULE,
            this.MODELE_MARQ,
            this.DATEMISEENSERVICE,
            this.DESCRIPTION_FOUR,
            this.TOTALKILOMETRAGE_VEHICULE,
            this.SEUIL_KILO_VDGE_MARQ,
            this.KILOMETRAGE_VIDENGE_VEHICULE});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvVidange.DefaultCellStyle = dataGridViewCellStyle10;
            this.DgvVidange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvVidange.GridColor = System.Drawing.Color.White;
            this.DgvVidange.Location = new System.Drawing.Point(0, 26);
            this.DgvVidange.Name = "DgvVidange";
            this.DgvVidange.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvVidange.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.DgvVidange.RowHeadersWidth = 51;
            this.DgvVidange.Size = new System.Drawing.Size(1151, 639);
            this.DgvVidange.TabIndex = 4;
            this.DgvVidange.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVidange_CellContentClick);
            // 
            // Vidange
            // 
            this.Vidange.HeaderText = "Vidange";
            this.Vidange.MinimumWidth = 6;
            this.Vidange.Name = "Vidange";
            this.Vidange.ReadOnly = true;
            this.Vidange.Text = "Faire la vidange";
            this.Vidange.UseColumnTextForButtonValue = true;
            this.Vidange.Width = 125;
            // 
            // IMMATRICULATION_VEHICULE
            // 
            this.IMMATRICULATION_VEHICULE.DataPropertyName = "IMMATRICULATION_VEHICULE";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.IMMATRICULATION_VEHICULE.DefaultCellStyle = dataGridViewCellStyle3;
            this.IMMATRICULATION_VEHICULE.HeaderText = "Matricule véhicule";
            this.IMMATRICULATION_VEHICULE.MinimumWidth = 100;
            this.IMMATRICULATION_VEHICULE.Name = "IMMATRICULATION_VEHICULE";
            this.IMMATRICULATION_VEHICULE.ReadOnly = true;
            this.IMMATRICULATION_VEHICULE.Width = 200;
            // 
            // MODELE_MARQ
            // 
            this.MODELE_MARQ.DataPropertyName = "MODELE_MARQ";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.MODELE_MARQ.DefaultCellStyle = dataGridViewCellStyle4;
            this.MODELE_MARQ.HeaderText = "Modèle";
            this.MODELE_MARQ.MinimumWidth = 100;
            this.MODELE_MARQ.Name = "MODELE_MARQ";
            this.MODELE_MARQ.ReadOnly = true;
            this.MODELE_MARQ.Width = 200;
            // 
            // DATEMISEENSERVICE
            // 
            this.DATEMISEENSERVICE.DataPropertyName = "DATEMISEENSERVICE";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DATEMISEENSERVICE.DefaultCellStyle = dataGridViewCellStyle5;
            this.DATEMISEENSERVICE.HeaderText = "Date de mise en service";
            this.DATEMISEENSERVICE.MinimumWidth = 100;
            this.DATEMISEENSERVICE.Name = "DATEMISEENSERVICE";
            this.DATEMISEENSERVICE.ReadOnly = true;
            this.DATEMISEENSERVICE.Width = 200;
            // 
            // DESCRIPTION_FOUR
            // 
            this.DESCRIPTION_FOUR.DataPropertyName = "DESCRIPTION_FOUR";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DESCRIPTION_FOUR.DefaultCellStyle = dataGridViewCellStyle6;
            this.DESCRIPTION_FOUR.HeaderText = "Concessionnaire";
            this.DESCRIPTION_FOUR.MinimumWidth = 100;
            this.DESCRIPTION_FOUR.Name = "DESCRIPTION_FOUR";
            this.DESCRIPTION_FOUR.ReadOnly = true;
            this.DESCRIPTION_FOUR.Width = 200;
            // 
            // TOTALKILOMETRAGE_VEHICULE
            // 
            this.TOTALKILOMETRAGE_VEHICULE.DataPropertyName = "TOTALKILOMETRAGE_VEHICULE";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TOTALKILOMETRAGE_VEHICULE.DefaultCellStyle = dataGridViewCellStyle7;
            this.TOTALKILOMETRAGE_VEHICULE.HeaderText = "Kilométrage total";
            this.TOTALKILOMETRAGE_VEHICULE.MinimumWidth = 100;
            this.TOTALKILOMETRAGE_VEHICULE.Name = "TOTALKILOMETRAGE_VEHICULE";
            this.TOTALKILOMETRAGE_VEHICULE.ReadOnly = true;
            this.TOTALKILOMETRAGE_VEHICULE.Width = 200;
            // 
            // SEUIL_KILO_VDGE_MARQ
            // 
            this.SEUIL_KILO_VDGE_MARQ.DataPropertyName = "SEUIL_KILO_VDGE_MARQ";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.SEUIL_KILO_VDGE_MARQ.DefaultCellStyle = dataGridViewCellStyle8;
            this.SEUIL_KILO_VDGE_MARQ.HeaderText = "Kilométrage seuil vidange";
            this.SEUIL_KILO_VDGE_MARQ.MinimumWidth = 100;
            this.SEUIL_KILO_VDGE_MARQ.Name = "SEUIL_KILO_VDGE_MARQ";
            this.SEUIL_KILO_VDGE_MARQ.ReadOnly = true;
            this.SEUIL_KILO_VDGE_MARQ.Width = 200;
            // 
            // KILOMETRAGE_VIDENGE_VEHICULE
            // 
            this.KILOMETRAGE_VIDENGE_VEHICULE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KILOMETRAGE_VIDENGE_VEHICULE.DataPropertyName = "KILOMETRAGE_VIDENGE_VEHICULE";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.KILOMETRAGE_VIDENGE_VEHICULE.DefaultCellStyle = dataGridViewCellStyle9;
            this.KILOMETRAGE_VIDENGE_VEHICULE.HeaderText = "Compteur vidange";
            this.KILOMETRAGE_VIDENGE_VEHICULE.MinimumWidth = 200;
            this.KILOMETRAGE_VIDENGE_VEHICULE.Name = "KILOMETRAGE_VIDENGE_VEHICULE";
            this.KILOMETRAGE_VIDENGE_VEHICULE.ReadOnly = true;
            // 
            // FormAlerteVidange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1151, 684);
            this.Controls.Add(this.DgvVidange);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormAlerteVidange";
            this.Text = "FormAlerteVidange";
            this.Load += new System.EventHandler(this.FormAlerteVidange_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVidange)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnCloseAlertVidange;
        public System.Windows.Forms.DataGridView DgvVidange;
        private System.Windows.Forms.DataGridViewButtonColumn Vidange;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMMATRICULATION_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODELE_MARQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATEMISEENSERVICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_FOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTALKILOMETRAGE_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEUIL_KILO_VDGE_MARQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn KILOMETRAGE_VIDENGE_VEHICULE;
    }
}