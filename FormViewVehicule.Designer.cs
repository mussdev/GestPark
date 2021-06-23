
namespace GestPark
{
    partial class FormViewVehicule
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
            this.panelViewVehicule = new System.Windows.Forms.Panel();
            this.iconBtnExportVehi = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDebut = new System.Windows.Forms.DateTimePicker();
            this.checkedListBoxTypVehi = new System.Windows.Forms.CheckedListBox();
            this.comboBoxEtatVehi = new System.Windows.Forms.ComboBox();
            this.iconBtnSearchVehi = new FontAwesome.Sharp.IconButton();
            this.textBxSearchVehi = new System.Windows.Forms.TextBox();
            this.iconBtnCloseViewForm = new FontAwesome.Sharp.IconButton();
            this.DataGridViewVehi = new System.Windows.Forms.DataGridView();
            this.CODE_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ETAT_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMMATRICULATION_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CARTE_GRISE_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODELE_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRIX_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TYPE_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TYPEVITESSE_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_PARK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_TYPCONSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_MARQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_PERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_FOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTE_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_ACHA_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_VISITE_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASSURANCE_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATECREATE_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERCREATE_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelViewVehicule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVehi)).BeginInit();
            this.SuspendLayout();
            // 
            // panelViewVehicule
            // 
            this.panelViewVehicule.BackColor = System.Drawing.Color.DarkOrange;
            this.panelViewVehicule.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelViewVehicule.Controls.Add(this.iconBtnExportVehi);
            this.panelViewVehicule.Controls.Add(this.label3);
            this.panelViewVehicule.Controls.Add(this.label2);
            this.panelViewVehicule.Controls.Add(this.label1);
            this.panelViewVehicule.Controls.Add(this.dateTimePickerFin);
            this.panelViewVehicule.Controls.Add(this.dateTimePickerDebut);
            this.panelViewVehicule.Controls.Add(this.checkedListBoxTypVehi);
            this.panelViewVehicule.Controls.Add(this.comboBoxEtatVehi);
            this.panelViewVehicule.Controls.Add(this.iconBtnSearchVehi);
            this.panelViewVehicule.Controls.Add(this.textBxSearchVehi);
            this.panelViewVehicule.Controls.Add(this.iconBtnCloseViewForm);
            this.panelViewVehicule.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelViewVehicule.Location = new System.Drawing.Point(0, 0);
            this.panelViewVehicule.Name = "panelViewVehicule";
            this.panelViewVehicule.Size = new System.Drawing.Size(1118, 135);
            this.panelViewVehicule.TabIndex = 0;
            // 
            // iconBtnExportVehi
            // 
            this.iconBtnExportVehi.BackColor = System.Drawing.Color.White;
            this.iconBtnExportVehi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnExportVehi.ForeColor = System.Drawing.Color.DarkGreen;
            this.iconBtnExportVehi.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.iconBtnExportVehi.IconColor = System.Drawing.Color.DarkGreen;
            this.iconBtnExportVehi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnExportVehi.IconSize = 20;
            this.iconBtnExportVehi.Location = new System.Drawing.Point(941, 88);
            this.iconBtnExportVehi.Name = "iconBtnExportVehi";
            this.iconBtnExportVehi.Size = new System.Drawing.Size(91, 23);
            this.iconBtnExportVehi.TabIndex = 13;
            this.iconBtnExportVehi.Text = "Exporter";
            this.iconBtnExportVehi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnExportVehi.UseVisualStyleBackColor = false;
            this.iconBtnExportVehi.Click += new System.EventHandler(this.iconBtnExportVehi_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Début";
            // 
            // dateTimePickerFin
            // 
            this.dateTimePickerFin.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFin.Location = new System.Drawing.Point(65, 86);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerFin.TabIndex = 9;
            // 
            // dateTimePickerDebut
            // 
            this.dateTimePickerDebut.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDebut.Location = new System.Drawing.Point(65, 28);
            this.dateTimePickerDebut.Name = "dateTimePickerDebut";
            this.dateTimePickerDebut.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDebut.TabIndex = 8;
            // 
            // checkedListBoxTypVehi
            // 
            this.checkedListBoxTypVehi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxTypVehi.FormattingEnabled = true;
            this.checkedListBoxTypVehi.Items.AddRange(new object[] {
            "Privé",
            "Pool"});
            this.checkedListBoxTypVehi.Location = new System.Drawing.Point(299, 28);
            this.checkedListBoxTypVehi.Name = "checkedListBoxTypVehi";
            this.checkedListBoxTypVehi.Size = new System.Drawing.Size(228, 38);
            this.checkedListBoxTypVehi.TabIndex = 7;
            // 
            // comboBoxEtatVehi
            // 
            this.comboBoxEtatVehi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEtatVehi.FormattingEnabled = true;
            this.comboBoxEtatVehi.Items.AddRange(new object[] {
            "Parking",
            "Sortir",
            "Visite technique",
            "Garage"});
            this.comboBoxEtatVehi.Location = new System.Drawing.Point(299, 86);
            this.comboBoxEtatVehi.Name = "comboBoxEtatVehi";
            this.comboBoxEtatVehi.Size = new System.Drawing.Size(228, 23);
            this.comboBoxEtatVehi.TabIndex = 5;
            this.comboBoxEtatVehi.Text = "Parking";
            // 
            // iconBtnSearchVehi
            // 
            this.iconBtnSearchVehi.BackColor = System.Drawing.Color.White;
            this.iconBtnSearchVehi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnSearchVehi.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconBtnSearchVehi.IconColor = System.Drawing.Color.DarkGreen;
            this.iconBtnSearchVehi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnSearchVehi.IconSize = 25;
            this.iconBtnSearchVehi.Location = new System.Drawing.Point(976, 25);
            this.iconBtnSearchVehi.Name = "iconBtnSearchVehi";
            this.iconBtnSearchVehi.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.iconBtnSearchVehi.Size = new System.Drawing.Size(34, 25);
            this.iconBtnSearchVehi.TabIndex = 2;
            this.iconBtnSearchVehi.UseVisualStyleBackColor = false;
            this.iconBtnSearchVehi.Click += new System.EventHandler(this.iconBtnSearchVehi_Click);
            // 
            // textBxSearchVehi
            // 
            this.textBxSearchVehi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBxSearchVehi.Location = new System.Drawing.Point(714, 28);
            this.textBxSearchVehi.Name = "textBxSearchVehi";
            this.textBxSearchVehi.Size = new System.Drawing.Size(256, 22);
            this.textBxSearchVehi.TabIndex = 1;
            // 
            // iconBtnCloseViewForm
            // 
            this.iconBtnCloseViewForm.BackColor = System.Drawing.Color.White;
            this.iconBtnCloseViewForm.ForeColor = System.Drawing.Color.White;
            this.iconBtnCloseViewForm.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconBtnCloseViewForm.IconColor = System.Drawing.Color.Red;
            this.iconBtnCloseViewForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnCloseViewForm.IconSize = 35;
            this.iconBtnCloseViewForm.Location = new System.Drawing.Point(1078, -2);
            this.iconBtnCloseViewForm.Name = "iconBtnCloseViewForm";
            this.iconBtnCloseViewForm.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.iconBtnCloseViewForm.Size = new System.Drawing.Size(38, 30);
            this.iconBtnCloseViewForm.TabIndex = 0;
            this.iconBtnCloseViewForm.UseVisualStyleBackColor = false;
            this.iconBtnCloseViewForm.Click += new System.EventHandler(this.iconBtnCloseViewForm_Click);
            // 
            // DataGridViewVehi
            // 
            this.DataGridViewVehi.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridViewVehi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridViewVehi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewVehi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODE_VEHICULE,
            this.ETAT_VEHICULE,
            this.IMMATRICULATION_VEHICULE,
            this.CARTE_GRISE_VEHICULE,
            this.MODELE_VEHICULE,
            this.PRIX_VEHICULE,
            this.TYPE_VEHICULE,
            this.TYPEVITESSE_VEHICULE,
            this.DESCRIPTION_PARK,
            this.DESCRIPTION_TYPCONSO,
            this.DESCRIPTION_MARQ,
            this.DESCRIPTION_PERS,
            this.DESCRIPTION_FOUR,
            this.NOTE_VEHICULE,
            this.DATE_ACHA_VEHICULE,
            this.DATE_VISITE_VEHICULE,
            this.ASSURANCE_VEHICULE,
            this.DATECREATE_VEHICULE,
            this.USERCREATE_VEHICULE});
            this.DataGridViewVehi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewVehi.Location = new System.Drawing.Point(0, 135);
            this.DataGridViewVehi.Name = "DataGridViewVehi";
            this.DataGridViewVehi.Size = new System.Drawing.Size(1118, 596);
            this.DataGridViewVehi.TabIndex = 1;
            this.DataGridViewVehi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewVehi_CellDoubleClick);
            // 
            // CODE_VEHICULE
            // 
            this.CODE_VEHICULE.DataPropertyName = "CODE_VEHICULE";
            this.CODE_VEHICULE.HeaderText = "Code";
            this.CODE_VEHICULE.Name = "CODE_VEHICULE";
            this.CODE_VEHICULE.ReadOnly = true;
            // 
            // ETAT_VEHICULE
            // 
            this.ETAT_VEHICULE.DataPropertyName = "ETAT_VEHICULE";
            this.ETAT_VEHICULE.HeaderText = "Position";
            this.ETAT_VEHICULE.Name = "ETAT_VEHICULE";
            this.ETAT_VEHICULE.ReadOnly = true;
            // 
            // IMMATRICULATION_VEHICULE
            // 
            this.IMMATRICULATION_VEHICULE.DataPropertyName = "IMMATRICULATION_VEHICULE";
            this.IMMATRICULATION_VEHICULE.HeaderText = "Immatriculation";
            this.IMMATRICULATION_VEHICULE.Name = "IMMATRICULATION_VEHICULE";
            this.IMMATRICULATION_VEHICULE.ReadOnly = true;
            // 
            // CARTE_GRISE_VEHICULE
            // 
            this.CARTE_GRISE_VEHICULE.DataPropertyName = "CARTE_GRISE_VEHICULE";
            this.CARTE_GRISE_VEHICULE.HeaderText = "Carte grise";
            this.CARTE_GRISE_VEHICULE.Name = "CARTE_GRISE_VEHICULE";
            this.CARTE_GRISE_VEHICULE.ReadOnly = true;
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
            // TYPE_VEHICULE
            // 
            this.TYPE_VEHICULE.DataPropertyName = "TYPE_VEHICULE";
            this.TYPE_VEHICULE.HeaderText = "Type V.";
            this.TYPE_VEHICULE.Name = "TYPE_VEHICULE";
            this.TYPE_VEHICULE.ReadOnly = true;
            // 
            // TYPEVITESSE_VEHICULE
            // 
            this.TYPEVITESSE_VEHICULE.DataPropertyName = "TYPEVITESSE_VEHICULE";
            this.TYPEVITESSE_VEHICULE.HeaderText = "Vitesse";
            this.TYPEVITESSE_VEHICULE.Name = "TYPEVITESSE_VEHICULE";
            this.TYPEVITESSE_VEHICULE.ReadOnly = true;
            // 
            // DESCRIPTION_PARK
            // 
            this.DESCRIPTION_PARK.DataPropertyName = "DESCRIPTION_PARK";
            this.DESCRIPTION_PARK.HeaderText = "Emplacement";
            this.DESCRIPTION_PARK.Name = "DESCRIPTION_PARK";
            this.DESCRIPTION_PARK.ReadOnly = true;
            // 
            // DESCRIPTION_TYPCONSO
            // 
            this.DESCRIPTION_TYPCONSO.DataPropertyName = "DESCRIPTION_TYPCONSO";
            this.DESCRIPTION_TYPCONSO.HeaderText = "Conso.";
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
            // DESCRIPTION_PERS
            // 
            this.DESCRIPTION_PERS.DataPropertyName = "DESCRIPTION_PERS";
            this.DESCRIPTION_PERS.HeaderText = "Propriétaire";
            this.DESCRIPTION_PERS.Name = "DESCRIPTION_PERS";
            this.DESCRIPTION_PERS.ReadOnly = true;
            this.DESCRIPTION_PERS.Width = 200;
            // 
            // DESCRIPTION_FOUR
            // 
            this.DESCRIPTION_FOUR.DataPropertyName = "DESCRIPTION_FOUR";
            this.DESCRIPTION_FOUR.HeaderText = "Fournisseur";
            this.DESCRIPTION_FOUR.Name = "DESCRIPTION_FOUR";
            this.DESCRIPTION_FOUR.ReadOnly = true;
            // 
            // NOTE_VEHICULE
            // 
            this.NOTE_VEHICULE.DataPropertyName = "NOTE_VEHICULE";
            this.NOTE_VEHICULE.HeaderText = "Note";
            this.NOTE_VEHICULE.Name = "NOTE_VEHICULE";
            this.NOTE_VEHICULE.ReadOnly = true;
            // 
            // DATE_ACHA_VEHICULE
            // 
            this.DATE_ACHA_VEHICULE.DataPropertyName = "DATE_ACHA_VEHICULE";
            this.DATE_ACHA_VEHICULE.HeaderText = "Date achat";
            this.DATE_ACHA_VEHICULE.Name = "DATE_ACHA_VEHICULE";
            this.DATE_ACHA_VEHICULE.ReadOnly = true;
            // 
            // DATE_VISITE_VEHICULE
            // 
            this.DATE_VISITE_VEHICULE.DataPropertyName = "DATE_VISITE_VEHICULE";
            this.DATE_VISITE_VEHICULE.HeaderText = "Date visi. tech.";
            this.DATE_VISITE_VEHICULE.Name = "DATE_VISITE_VEHICULE";
            this.DATE_VISITE_VEHICULE.ReadOnly = true;
            // 
            // ASSURANCE_VEHICULE
            // 
            this.ASSURANCE_VEHICULE.DataPropertyName = "ASSURANCE_VEHICULE";
            this.ASSURANCE_VEHICULE.HeaderText = "Date assu.";
            this.ASSURANCE_VEHICULE.Name = "ASSURANCE_VEHICULE";
            this.ASSURANCE_VEHICULE.ReadOnly = true;
            // 
            // DATECREATE_VEHICULE
            // 
            this.DATECREATE_VEHICULE.DataPropertyName = "DATECREATE_VEHICULE";
            this.DATECREATE_VEHICULE.HeaderText = "Créer le";
            this.DATECREATE_VEHICULE.Name = "DATECREATE_VEHICULE";
            this.DATECREATE_VEHICULE.ReadOnly = true;
            // 
            // USERCREATE_VEHICULE
            // 
            this.USERCREATE_VEHICULE.DataPropertyName = "USERCREATE_VEHICULE";
            this.USERCREATE_VEHICULE.HeaderText = "Créer par";
            this.USERCREATE_VEHICULE.Name = "USERCREATE_VEHICULE";
            this.USERCREATE_VEHICULE.ReadOnly = true;
            // 
            // FormViewVehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 731);
            this.Controls.Add(this.DataGridViewVehi);
            this.Controls.Add(this.panelViewVehicule);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormViewVehicule";
            this.Text = "FormViewVehicule";
            this.panelViewVehicule.ResumeLayout(false);
            this.panelViewVehicule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVehi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelViewVehicule;
        private FontAwesome.Sharp.IconButton iconBtnCloseViewForm;
        private System.Windows.Forms.DateTimePicker dateTimePickerFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerDebut;
        private System.Windows.Forms.CheckedListBox checkedListBoxTypVehi;
        private System.Windows.Forms.ComboBox comboBoxEtatVehi;
        private FontAwesome.Sharp.IconButton iconBtnSearchVehi;
        private System.Windows.Forms.TextBox textBxSearchVehi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DataGridViewVehi;
        private FontAwesome.Sharp.IconButton iconBtnExportVehi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ETAT_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMMATRICULATION_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CARTE_GRISE_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODELE_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRIX_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TYPE_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TYPEVITESSE_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_PARK;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_TYPCONSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_MARQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_PERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_FOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTE_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_ACHA_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_VISITE_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASSURANCE_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATECREATE_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERCREATE_VEHICULE;
    }
}