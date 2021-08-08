
namespace GestPark
{
    partial class FormSuiviVehicule
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
            this.IbtnExportSuiviVehi = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckListTypVehiculeSuiviVehi = new System.Windows.Forms.CheckedListBox();
            this.IbtnSeachSuiviVehi = new FontAwesome.Sharp.IconButton();
            this.TbxSearchSuiviVehi = new System.Windows.Forms.TextBox();
            this.IbtnCloseFormSuiviVehi = new FontAwesome.Sharp.IconButton();
            this.panelViewVehicule = new System.Windows.Forms.Panel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.DgvSuiviVehicule = new System.Windows.Forms.DataGridView();
            this.CODE_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ETAT_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMMATRICULATION_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CARTE_GRISE_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASSURANCE_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODELE_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRIX_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_ACHA_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_ASSURANCE_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_VISITE_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_TYPCONSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_MARQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_FOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATEDEPART_MVTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATEARRIVE_MVTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_MVTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LIEU_MVTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_PERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KILOMETRE_AVA_MVTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KILO_APRES_MVTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelViewVehicule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSuiviVehicule)).BeginInit();
            this.SuspendLayout();
            // 
            // IbtnExportSuiviVehi
            // 
            this.IbtnExportSuiviVehi.BackColor = System.Drawing.Color.White;
            this.IbtnExportSuiviVehi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IbtnExportSuiviVehi.ForeColor = System.Drawing.Color.DarkGreen;
            this.IbtnExportSuiviVehi.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.IbtnExportSuiviVehi.IconColor = System.Drawing.Color.DarkGreen;
            this.IbtnExportSuiviVehi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnExportSuiviVehi.IconSize = 20;
            this.IbtnExportSuiviVehi.Location = new System.Drawing.Point(941, 88);
            this.IbtnExportSuiviVehi.Name = "IbtnExportSuiviVehi";
            this.IbtnExportSuiviVehi.Size = new System.Drawing.Size(91, 23);
            this.IbtnExportSuiviVehi.TabIndex = 13;
            this.IbtnExportSuiviVehi.Text = "Exporter";
            this.IbtnExportSuiviVehi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IbtnExportSuiviVehi.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(568, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Recherche multi-critère";
            // 
            // CheckListTypVehiculeSuiviVehi
            // 
            this.CheckListTypVehiculeSuiviVehi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckListTypVehiculeSuiviVehi.FormattingEnabled = true;
            this.CheckListTypVehiculeSuiviVehi.Items.AddRange(new object[] {
            "Privé",
            "Pool"});
            this.CheckListTypVehiculeSuiviVehi.Location = new System.Drawing.Point(298, 10);
            this.CheckListTypVehiculeSuiviVehi.Name = "CheckListTypVehiculeSuiviVehi";
            this.CheckListTypVehiculeSuiviVehi.Size = new System.Drawing.Size(228, 38);
            this.CheckListTypVehiculeSuiviVehi.TabIndex = 7;
            // 
            // IbtnSeachSuiviVehi
            // 
            this.IbtnSeachSuiviVehi.BackColor = System.Drawing.Color.White;
            this.IbtnSeachSuiviVehi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IbtnSeachSuiviVehi.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.IbtnSeachSuiviVehi.IconColor = System.Drawing.Color.DarkGreen;
            this.IbtnSeachSuiviVehi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnSeachSuiviVehi.IconSize = 25;
            this.IbtnSeachSuiviVehi.Location = new System.Drawing.Point(976, 25);
            this.IbtnSeachSuiviVehi.Name = "IbtnSeachSuiviVehi";
            this.IbtnSeachSuiviVehi.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.IbtnSeachSuiviVehi.Size = new System.Drawing.Size(34, 25);
            this.IbtnSeachSuiviVehi.TabIndex = 2;
            this.IbtnSeachSuiviVehi.UseVisualStyleBackColor = false;
            this.IbtnSeachSuiviVehi.Click += new System.EventHandler(this.IbtnSeachSuiviVehi_Click);
            // 
            // TbxSearchSuiviVehi
            // 
            this.TbxSearchSuiviVehi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxSearchSuiviVehi.Location = new System.Drawing.Point(714, 28);
            this.TbxSearchSuiviVehi.Name = "TbxSearchSuiviVehi";
            this.TbxSearchSuiviVehi.Size = new System.Drawing.Size(256, 22);
            this.TbxSearchSuiviVehi.TabIndex = 1;
            // 
            // IbtnCloseFormSuiviVehi
            // 
            this.IbtnCloseFormSuiviVehi.BackColor = System.Drawing.Color.White;
            this.IbtnCloseFormSuiviVehi.ForeColor = System.Drawing.Color.White;
            this.IbtnCloseFormSuiviVehi.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.IbtnCloseFormSuiviVehi.IconColor = System.Drawing.Color.Red;
            this.IbtnCloseFormSuiviVehi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnCloseFormSuiviVehi.IconSize = 35;
            this.IbtnCloseFormSuiviVehi.Location = new System.Drawing.Point(1084, -2);
            this.IbtnCloseFormSuiviVehi.Name = "IbtnCloseFormSuiviVehi";
            this.IbtnCloseFormSuiviVehi.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.IbtnCloseFormSuiviVehi.Size = new System.Drawing.Size(32, 30);
            this.IbtnCloseFormSuiviVehi.TabIndex = 0;
            this.IbtnCloseFormSuiviVehi.UseVisualStyleBackColor = false;
            this.IbtnCloseFormSuiviVehi.Click += new System.EventHandler(this.IbtnCloseFormSuiviVehi_Click);
            // 
            // panelViewVehicule
            // 
            this.panelViewVehicule.AutoScroll = true;
            this.panelViewVehicule.BackColor = System.Drawing.Color.DarkOrange;
            this.panelViewVehicule.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelViewVehicule.Controls.Add(this.checkedListBox1);
            this.panelViewVehicule.Controls.Add(this.IbtnExportSuiviVehi);
            this.panelViewVehicule.Controls.Add(this.label3);
            this.panelViewVehicule.Controls.Add(this.CheckListTypVehiculeSuiviVehi);
            this.panelViewVehicule.Controls.Add(this.IbtnSeachSuiviVehi);
            this.panelViewVehicule.Controls.Add(this.TbxSearchSuiviVehi);
            this.panelViewVehicule.Controls.Add(this.IbtnCloseFormSuiviVehi);
            this.panelViewVehicule.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelViewVehicule.Location = new System.Drawing.Point(0, 0);
            this.panelViewVehicule.Name = "panelViewVehicule";
            this.panelViewVehicule.Size = new System.Drawing.Size(1118, 135);
            this.panelViewVehicule.TabIndex = 2;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Parking",
            "Sortir",
            "Arrivée"});
            this.checkedListBox1.Location = new System.Drawing.Point(298, 56);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(228, 55);
            this.checkedListBox1.TabIndex = 14;
            // 
            // DgvSuiviVehicule
            // 
            this.DgvSuiviVehicule.AllowUserToOrderColumns = true;
            this.DgvSuiviVehicule.BackgroundColor = System.Drawing.Color.White;
            this.DgvSuiviVehicule.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvSuiviVehicule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSuiviVehicule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODE_VEHICULE,
            this.ETAT_VEHICULE,
            this.IMMATRICULATION_VEHICULE,
            this.CARTE_GRISE_VEHICULE,
            this.ASSURANCE_VEHICULE,
            this.MODELE_VEHICULE,
            this.PRIX_VEHICULE,
            this.DATE_ACHA_VEHICULE,
            this.DATE_ASSURANCE_VEHICULE,
            this.DATE_VISITE_VEHICULE,
            this.DESCRIPTION_TYPCONSO,
            this.DESCRIPTION_MARQ,
            this.DESCRIPTION_FOUR,
            this.DATEDEPART_MVTS,
            this.DATEARRIVE_MVTS,
            this.DESCRIPTION_MVTS,
            this.LIEU_MVTS,
            this.DESCRIPTION_PERS,
            this.KILOMETRE_AVA_MVTS,
            this.KILO_APRES_MVTS});
            this.DgvSuiviVehicule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvSuiviVehicule.Location = new System.Drawing.Point(0, 135);
            this.DgvSuiviVehicule.Name = "DgvSuiviVehicule";
            this.DgvSuiviVehicule.Size = new System.Drawing.Size(1118, 596);
            this.DgvSuiviVehicule.TabIndex = 3;
            // 
            // CODE_VEHICULE
            // 
            this.CODE_VEHICULE.DataPropertyName = "CODE_VEHICULE";
            this.CODE_VEHICULE.HeaderText = "Code veh.";
            this.CODE_VEHICULE.Name = "CODE_VEHICULE";
            this.CODE_VEHICULE.ReadOnly = true;
            // 
            // ETAT_VEHICULE
            // 
            this.ETAT_VEHICULE.DataPropertyName = "ETAT_VEHICULE";
            this.ETAT_VEHICULE.HeaderText = "Statut";
            this.ETAT_VEHICULE.Name = "ETAT_VEHICULE";
            this.ETAT_VEHICULE.ReadOnly = true;
            // 
            // IMMATRICULATION_VEHICULE
            // 
            this.IMMATRICULATION_VEHICULE.DataPropertyName = "IMMATRICULATION_VEHICULE";
            this.IMMATRICULATION_VEHICULE.HeaderText = "Immatriculation";
            this.IMMATRICULATION_VEHICULE.Name = "IMMATRICULATION_VEHICULE";
            this.IMMATRICULATION_VEHICULE.ReadOnly = true;
            this.IMMATRICULATION_VEHICULE.Width = 150;
            // 
            // CARTE_GRISE_VEHICULE
            // 
            this.CARTE_GRISE_VEHICULE.DataPropertyName = "CARTE_GRISE_VEHICULE";
            this.CARTE_GRISE_VEHICULE.HeaderText = "Carte grise vehicule";
            this.CARTE_GRISE_VEHICULE.Name = "CARTE_GRISE_VEHICULE";
            this.CARTE_GRISE_VEHICULE.ReadOnly = true;
            this.CARTE_GRISE_VEHICULE.Width = 150;
            // 
            // ASSURANCE_VEHICULE
            // 
            this.ASSURANCE_VEHICULE.DataPropertyName = "ASSURANCE_VEHICULE";
            this.ASSURANCE_VEHICULE.HeaderText = "Assurance";
            this.ASSURANCE_VEHICULE.Name = "ASSURANCE_VEHICULE";
            this.ASSURANCE_VEHICULE.ReadOnly = true;
            // 
            // MODELE_VEHICULE
            // 
            this.MODELE_VEHICULE.DataPropertyName = "MODELE_VEHICULE";
            this.MODELE_VEHICULE.HeaderText = "Modèle";
            this.MODELE_VEHICULE.Name = "MODELE_VEHICULE";
            this.MODELE_VEHICULE.ReadOnly = true;
            // 
            // PRIX_VEHICULE
            // 
            this.PRIX_VEHICULE.DataPropertyName = "PRIX_VEHICULE";
            this.PRIX_VEHICULE.HeaderText = "Prix";
            this.PRIX_VEHICULE.Name = "PRIX_VEHICULE";
            this.PRIX_VEHICULE.ReadOnly = true;
            // 
            // DATE_ACHA_VEHICULE
            // 
            this.DATE_ACHA_VEHICULE.DataPropertyName = "DATE_ACHA_VEHICULE";
            this.DATE_ACHA_VEHICULE.HeaderText = "Date achat";
            this.DATE_ACHA_VEHICULE.Name = "DATE_ACHA_VEHICULE";
            this.DATE_ACHA_VEHICULE.ReadOnly = true;
            // 
            // DATE_ASSURANCE_VEHICULE
            // 
            this.DATE_ASSURANCE_VEHICULE.DataPropertyName = "DATE_ASSURANCE_VEHICULE";
            this.DATE_ASSURANCE_VEHICULE.HeaderText = "Date ass.";
            this.DATE_ASSURANCE_VEHICULE.Name = "DATE_ASSURANCE_VEHICULE";
            this.DATE_ASSURANCE_VEHICULE.ReadOnly = true;
            this.DATE_ASSURANCE_VEHICULE.Width = 150;
            // 
            // DATE_VISITE_VEHICULE
            // 
            this.DATE_VISITE_VEHICULE.DataPropertyName = "DATE_VISITE_VEHICULE";
            this.DATE_VISITE_VEHICULE.HeaderText = "Date visit. tech.";
            this.DATE_VISITE_VEHICULE.Name = "DATE_VISITE_VEHICULE";
            this.DATE_VISITE_VEHICULE.ReadOnly = true;
            this.DATE_VISITE_VEHICULE.Width = 150;
            // 
            // DESCRIPTION_TYPCONSO
            // 
            this.DESCRIPTION_TYPCONSO.DataPropertyName = "DESCRIPTION_TYPCONSO";
            this.DESCRIPTION_TYPCONSO.HeaderText = "Type conso.";
            this.DESCRIPTION_TYPCONSO.Name = "DESCRIPTION_TYPCONSO";
            this.DESCRIPTION_TYPCONSO.ReadOnly = true;
            // 
            // DESCRIPTION_MARQ
            // 
            this.DESCRIPTION_MARQ.DataPropertyName = "DESCRIPTION_MARQ";
            this.DESCRIPTION_MARQ.HeaderText = "Marque";
            this.DESCRIPTION_MARQ.Name = "DESCRIPTION_MARQ";
            this.DESCRIPTION_MARQ.ReadOnly = true;
            // 
            // DESCRIPTION_FOUR
            // 
            this.DESCRIPTION_FOUR.DataPropertyName = "DESCRIPTION_FOUR";
            this.DESCRIPTION_FOUR.HeaderText = "Fournisseur";
            this.DESCRIPTION_FOUR.Name = "DESCRIPTION_FOUR";
            this.DESCRIPTION_FOUR.ReadOnly = true;
            this.DESCRIPTION_FOUR.Width = 150;
            // 
            // DATEDEPART_MVTS
            // 
            this.DATEDEPART_MVTS.DataPropertyName = "DATEDEPART_MVTS";
            this.DATEDEPART_MVTS.HeaderText = "Date depart";
            this.DATEDEPART_MVTS.Name = "DATEDEPART_MVTS";
            this.DATEDEPART_MVTS.ReadOnly = true;
            // 
            // DATEARRIVE_MVTS
            // 
            this.DATEARRIVE_MVTS.DataPropertyName = "DATEARRIVE_MVTS";
            this.DATEARRIVE_MVTS.HeaderText = "Date arrivée";
            this.DATEARRIVE_MVTS.Name = "DATEARRIVE_MVTS";
            this.DATEARRIVE_MVTS.ReadOnly = true;
            // 
            // DESCRIPTION_MVTS
            // 
            this.DESCRIPTION_MVTS.DataPropertyName = "DESCRIPTION_MVTS";
            this.DESCRIPTION_MVTS.HeaderText = "Description mouv.";
            this.DESCRIPTION_MVTS.Name = "DESCRIPTION_MVTS";
            this.DESCRIPTION_MVTS.ReadOnly = true;
            this.DESCRIPTION_MVTS.Width = 200;
            // 
            // LIEU_MVTS
            // 
            this.LIEU_MVTS.DataPropertyName = "LIEU_MVTS";
            this.LIEU_MVTS.HeaderText = "Lieu";
            this.LIEU_MVTS.Name = "LIEU_MVTS";
            this.LIEU_MVTS.ReadOnly = true;
            this.LIEU_MVTS.Width = 150;
            // 
            // DESCRIPTION_PERS
            // 
            this.DESCRIPTION_PERS.DataPropertyName = "DESCRIPTION_PERS";
            this.DESCRIPTION_PERS.HeaderText = "Conducteur";
            this.DESCRIPTION_PERS.Name = "DESCRIPTION_PERS";
            this.DESCRIPTION_PERS.ReadOnly = true;
            this.DESCRIPTION_PERS.Width = 150;
            // 
            // KILOMETRE_AVA_MVTS
            // 
            this.KILOMETRE_AVA_MVTS.DataPropertyName = "KILOMETRE_AVA_MVTS";
            this.KILOMETRE_AVA_MVTS.HeaderText = "Kilo. ava.";
            this.KILOMETRE_AVA_MVTS.Name = "KILOMETRE_AVA_MVTS";
            this.KILOMETRE_AVA_MVTS.ReadOnly = true;
            // 
            // KILO_APRES_MVTS
            // 
            this.KILO_APRES_MVTS.DataPropertyName = "KILO_APRES_MVTS";
            this.KILO_APRES_MVTS.HeaderText = "Kilo apr";
            this.KILO_APRES_MVTS.Name = "KILO_APRES_MVTS";
            this.KILO_APRES_MVTS.ReadOnly = true;
            // 
            // FormSuiviVehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 731);
            this.Controls.Add(this.DgvSuiviVehicule);
            this.Controls.Add(this.panelViewVehicule);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSuiviVehicule";
            this.Text = "FormSuiviVehicule";
            this.panelViewVehicule.ResumeLayout(false);
            this.panelViewVehicule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSuiviVehicule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton IbtnExportSuiviVehi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox CheckListTypVehiculeSuiviVehi;
        private FontAwesome.Sharp.IconButton IbtnSeachSuiviVehi;
        private System.Windows.Forms.TextBox TbxSearchSuiviVehi;
        private FontAwesome.Sharp.IconButton IbtnCloseFormSuiviVehi;
        private System.Windows.Forms.Panel panelViewVehicule;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.DataGridView DgvSuiviVehicule;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ETAT_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMMATRICULATION_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CARTE_GRISE_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASSURANCE_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODELE_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRIX_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_ACHA_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_ASSURANCE_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_VISITE_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_TYPCONSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_MARQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_FOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATEDEPART_MVTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATEARRIVE_MVTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_MVTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn LIEU_MVTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_PERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn KILOMETRE_AVA_MVTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn KILO_APRES_MVTS;
    }
}