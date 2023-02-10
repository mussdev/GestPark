
namespace GestPark
{
    partial class FormMainVisiteTech
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainVisiteTech));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateVisitTechTo = new System.Windows.Forms.DateTimePicker();
            this.cbxPeriodSearch = new System.Windows.Forms.ComboBox();
            this.cbxCarVisitTech = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateVisiteTechFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.iconBtnSearchFormVisit = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.iconBtnExportReportCarVist = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconBtnCloseFormVisit = new FontAwesome.Sharp.IconButton();
            this.iconBtnCreateVisit = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LblTotalGaragiste = new System.Windows.Forms.Label();
            this.LblTotalVignette = new System.Windows.Forms.Label();
            this.LblTotalFraisDossier = new System.Windows.Forms.Label();
            this.LblTotalVisit = new System.Windows.Forms.Label();
            this.dgvVisitTech = new System.Windows.Forms.DataGridView();
            this.CODE_VISIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMMATRICULATION_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FRAIS_DOSSIER_VISIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRIX_VIGNET_VISIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FRAIS_GARAGISTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENTREPRISE_VISIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTE_VISIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_VISIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATECREATE_VISIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERCREATE_VISIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATEMODIFIER_VISIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERMODIFIER_VISIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitTech)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dateVisitTechTo);
            this.panel2.Controls.Add(this.cbxPeriodSearch);
            this.panel2.Controls.Add(this.cbxCarVisitTech);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dateVisiteTechFrom);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.iconBtnSearchFormVisit);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1376, 175);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(147, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Fin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Début";
            // 
            // dateVisitTechTo
            // 
            this.dateVisitTechTo.Enabled = false;
            this.dateVisitTechTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateVisitTechTo.Location = new System.Drawing.Point(151, 80);
            this.dateVisitTechTo.Name = "dateVisitTechTo";
            this.dateVisitTechTo.Size = new System.Drawing.Size(120, 26);
            this.dateVisitTechTo.TabIndex = 12;
            // 
            // cbxPeriodSearch
            // 
            this.cbxPeriodSearch.FormattingEnabled = true;
            this.cbxPeriodSearch.Items.AddRange(new object[] {
            "",
            "Aujourd\'hui",
            "Mois en cours",
            "Mois précédent",
            "Année en cous",
            "Année précédente",
            "Personnalisé"});
            this.cbxPeriodSearch.Location = new System.Drawing.Point(14, 28);
            this.cbxPeriodSearch.Name = "cbxPeriodSearch";
            this.cbxPeriodSearch.Size = new System.Drawing.Size(257, 27);
            this.cbxPeriodSearch.TabIndex = 11;
            this.cbxPeriodSearch.SelectedIndexChanged += new System.EventHandler(this.cbxPeriodSearch_SelectedIndexChanged);
            // 
            // cbxCarVisitTech
            // 
            this.cbxCarVisitTech.FormattingEnabled = true;
            this.cbxCarVisitTech.Items.AddRange(new object[] {
            ""});
            this.cbxCarVisitTech.Location = new System.Drawing.Point(290, 27);
            this.cbxCarVisitTech.Name = "cbxCarVisitTech";
            this.cbxCarVisitTech.Size = new System.Drawing.Size(232, 27);
            this.cbxCarVisitTech.TabIndex = 10;
            this.cbxCarVisitTech.SelectedIndexChanged += new System.EventHandler(this.cbxCarVisitTech_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(287, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Véhicule";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(952, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rechercher";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(662, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rech. multicritère";
            // 
            // dateVisiteTechFrom
            // 
            this.dateVisiteTechFrom.Enabled = false;
            this.dateVisiteTechFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateVisiteTechFrom.Location = new System.Drawing.Point(18, 80);
            this.dateVisiteTechFrom.Name = "dateVisiteTechFrom";
            this.dateVisiteTechFrom.Size = new System.Drawing.Size(127, 26);
            this.dateVisiteTechFrom.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Période";
            // 
            // iconBtnSearchFormVisit
            // 
            this.iconBtnSearchFormVisit.BackColor = System.Drawing.Color.White;
            this.iconBtnSearchFormVisit.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconBtnSearchFormVisit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.iconBtnSearchFormVisit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnSearchFormVisit.IconSize = 20;
            this.iconBtnSearchFormVisit.Location = new System.Drawing.Point(1046, 74);
            this.iconBtnSearchFormVisit.Name = "iconBtnSearchFormVisit";
            this.iconBtnSearchFormVisit.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.iconBtnSearchFormVisit.Size = new System.Drawing.Size(30, 27);
            this.iconBtnSearchFormVisit.TabIndex = 4;
            this.iconBtnSearchFormVisit.UseVisualStyleBackColor = false;
            this.iconBtnSearchFormVisit.Click += new System.EventHandler(this.iconBtnSearchFormVisit_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(802, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 26);
            this.textBox1.TabIndex = 3;
            // 
            // iconBtnExportReportCarVist
            // 
            this.iconBtnExportReportCarVist.BackColor = System.Drawing.Color.White;
            this.iconBtnExportReportCarVist.ForeColor = System.Drawing.Color.Black;
            this.iconBtnExportReportCarVist.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.iconBtnExportReportCarVist.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(13)))));
            this.iconBtnExportReportCarVist.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnExportReportCarVist.IconSize = 20;
            this.iconBtnExportReportCarVist.Location = new System.Drawing.Point(105, -2);
            this.iconBtnExportReportCarVist.Name = "iconBtnExportReportCarVist";
            this.iconBtnExportReportCarVist.Size = new System.Drawing.Size(107, 26);
            this.iconBtnExportReportCarVist.TabIndex = 5;
            this.iconBtnExportReportCarVist.Text = "Exporter";
            this.iconBtnExportReportCarVist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnExportReportCarVist.UseVisualStyleBackColor = false;
            this.iconBtnExportReportCarVist.Click += new System.EventHandler(this.iconBtnExportReportCarVist_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.iconBtnExportReportCarVist);
            this.panel1.Controls.Add(this.iconBtnCloseFormVisit);
            this.panel1.Controls.Add(this.iconBtnCreateVisit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1376, 26);
            this.panel1.TabIndex = 2;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.White;
            this.iconButton1.ForeColor = System.Drawing.Color.Black;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(147)))), ((int)(((byte)(222)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(212, -2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(107, 26);
            this.iconButton1.TabIndex = 6;
            this.iconButton1.Text = "Importer";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconBtnCloseFormVisit
            // 
            this.iconBtnCloseFormVisit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnCloseFormVisit.BackColor = System.Drawing.Color.White;
            this.iconBtnCloseFormVisit.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.iconBtnCloseFormVisit.IconColor = System.Drawing.Color.Red;
            this.iconBtnCloseFormVisit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnCloseFormVisit.IconSize = 25;
            this.iconBtnCloseFormVisit.Location = new System.Drawing.Point(1341, -2);
            this.iconBtnCloseFormVisit.Name = "iconBtnCloseFormVisit";
            this.iconBtnCloseFormVisit.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.iconBtnCloseFormVisit.Size = new System.Drawing.Size(31, 26);
            this.iconBtnCloseFormVisit.TabIndex = 5;
            this.iconBtnCloseFormVisit.UseVisualStyleBackColor = false;
            this.iconBtnCloseFormVisit.Click += new System.EventHandler(this.iconBtnCloseFormVisit_Click);
            // 
            // iconBtnCreateVisit
            // 
            this.iconBtnCreateVisit.BackColor = System.Drawing.Color.White;
            this.iconBtnCreateVisit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnCreateVisit.ForeColor = System.Drawing.Color.Black;
            this.iconBtnCreateVisit.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconBtnCreateVisit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.iconBtnCreateVisit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnCreateVisit.IconSize = 20;
            this.iconBtnCreateVisit.Location = new System.Drawing.Point(-2, -2);
            this.iconBtnCreateVisit.Name = "iconBtnCreateVisit";
            this.iconBtnCreateVisit.Size = new System.Drawing.Size(107, 26);
            this.iconBtnCreateVisit.TabIndex = 3;
            this.iconBtnCreateVisit.Text = "Saisir";
            this.iconBtnCreateVisit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnCreateVisit.UseVisualStyleBackColor = false;
            this.iconBtnCreateVisit.Click += new System.EventHandler(this.iconBtnCreateVisit_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.panel3.Controls.Add(this.LblTotalGaragiste);
            this.panel3.Controls.Add(this.LblTotalVignette);
            this.panel3.Controls.Add(this.LblTotalFraisDossier);
            this.panel3.Controls.Add(this.LblTotalVisit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 201);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1376, 23);
            this.panel3.TabIndex = 4;
            // 
            // LblTotalGaragiste
            // 
            this.LblTotalGaragiste.AutoSize = true;
            this.LblTotalGaragiste.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalGaragiste.ForeColor = System.Drawing.Color.Red;
            this.LblTotalGaragiste.Location = new System.Drawing.Point(1051, 2);
            this.LblTotalGaragiste.Name = "LblTotalGaragiste";
            this.LblTotalGaragiste.Size = new System.Drawing.Size(184, 19);
            this.LblTotalGaragiste.TabIndex = 3;
            this.LblTotalGaragiste.Text = "Total frais garagiste = 0";
            // 
            // LblTotalVignette
            // 
            this.LblTotalVignette.AutoSize = true;
            this.LblTotalVignette.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalVignette.ForeColor = System.Drawing.Color.Red;
            this.LblTotalVignette.Location = new System.Drawing.Point(720, 2);
            this.LblTotalVignette.Name = "LblTotalVignette";
            this.LblTotalVignette.Size = new System.Drawing.Size(175, 19);
            this.LblTotalVignette.TabIndex = 2;
            this.LblTotalVignette.Text = "Total frais vignette = 0";
            // 
            // LblTotalFraisDossier
            // 
            this.LblTotalFraisDossier.AutoSize = true;
            this.LblTotalFraisDossier.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalFraisDossier.ForeColor = System.Drawing.Color.Red;
            this.LblTotalFraisDossier.Location = new System.Drawing.Point(396, 4);
            this.LblTotalFraisDossier.Name = "LblTotalFraisDossier";
            this.LblTotalFraisDossier.Size = new System.Drawing.Size(169, 19);
            this.LblTotalFraisDossier.TabIndex = 1;
            this.LblTotalFraisDossier.Text = "Total frais dossier = 0";
            // 
            // LblTotalVisit
            // 
            this.LblTotalVisit.AutoSize = true;
            this.LblTotalVisit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalVisit.ForeColor = System.Drawing.Color.Red;
            this.LblTotalVisit.Location = new System.Drawing.Point(12, 3);
            this.LblTotalVisit.Name = "LblTotalVisit";
            this.LblTotalVisit.Size = new System.Drawing.Size(73, 19);
            this.LblTotalVisit.TabIndex = 0;
            this.LblTotalVisit.Text = "Total = 0";
            // 
            // dgvVisitTech
            // 
            this.dgvVisitTech.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVisitTech.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVisitTech.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisitTech.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODE_VISIT,
            this.IMMATRICULATION_VEHICULE,
            this.FRAIS_DOSSIER_VISIT,
            this.PRIX_VIGNET_VISIT,
            this.FRAIS_GARAGISTE,
            this.ENTREPRISE_VISIT,
            this.NOTE_VISIT,
            this.DATE_VISIT,
            this.DATECREATE_VISIT,
            this.USERCREATE_VISIT,
            this.DATEMODIFIER_VISIT,
            this.USERMODIFIER_VISIT});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVisitTech.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVisitTech.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVisitTech.GridColor = System.Drawing.Color.White;
            this.dgvVisitTech.Location = new System.Drawing.Point(0, 224);
            this.dgvVisitTech.Name = "dgvVisitTech";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVisitTech.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVisitTech.RowHeadersWidth = 51;
            this.dgvVisitTech.Size = new System.Drawing.Size(1376, 507);
            this.dgvVisitTech.TabIndex = 5;
            this.dgvVisitTech.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVisitTech_CellDoubleClick);
            // 
            // CODE_VISIT
            // 
            this.CODE_VISIT.DataPropertyName = "CODE_VISIT";
            this.CODE_VISIT.HeaderText = "Code";
            this.CODE_VISIT.MinimumWidth = 6;
            this.CODE_VISIT.Name = "CODE_VISIT";
            this.CODE_VISIT.ReadOnly = true;
            this.CODE_VISIT.Width = 150;
            // 
            // IMMATRICULATION_VEHICULE
            // 
            this.IMMATRICULATION_VEHICULE.DataPropertyName = "IMMATRICULATION_VEHICULE";
            this.IMMATRICULATION_VEHICULE.HeaderText = "Véhicule";
            this.IMMATRICULATION_VEHICULE.MinimumWidth = 6;
            this.IMMATRICULATION_VEHICULE.Name = "IMMATRICULATION_VEHICULE";
            this.IMMATRICULATION_VEHICULE.ReadOnly = true;
            this.IMMATRICULATION_VEHICULE.Width = 200;
            // 
            // FRAIS_DOSSIER_VISIT
            // 
            this.FRAIS_DOSSIER_VISIT.DataPropertyName = "FRAIS_DOSSIER_VISIT";
            this.FRAIS_DOSSIER_VISIT.HeaderText = "Frais de dossier";
            this.FRAIS_DOSSIER_VISIT.MinimumWidth = 6;
            this.FRAIS_DOSSIER_VISIT.Name = "FRAIS_DOSSIER_VISIT";
            this.FRAIS_DOSSIER_VISIT.ReadOnly = true;
            this.FRAIS_DOSSIER_VISIT.Width = 300;
            // 
            // PRIX_VIGNET_VISIT
            // 
            this.PRIX_VIGNET_VISIT.DataPropertyName = "PRIX_VIGNET_VISIT";
            this.PRIX_VIGNET_VISIT.HeaderText = "Frais de vignette";
            this.PRIX_VIGNET_VISIT.MinimumWidth = 6;
            this.PRIX_VIGNET_VISIT.Name = "PRIX_VIGNET_VISIT";
            this.PRIX_VIGNET_VISIT.ReadOnly = true;
            this.PRIX_VIGNET_VISIT.Width = 300;
            // 
            // FRAIS_GARAGISTE
            // 
            this.FRAIS_GARAGISTE.DataPropertyName = "FRAIS_GARAGISTE";
            this.FRAIS_GARAGISTE.HeaderText = "Frais garagiste";
            this.FRAIS_GARAGISTE.MinimumWidth = 6;
            this.FRAIS_GARAGISTE.Name = "FRAIS_GARAGISTE";
            this.FRAIS_GARAGISTE.ReadOnly = true;
            this.FRAIS_GARAGISTE.Width = 250;
            // 
            // ENTREPRISE_VISIT
            // 
            this.ENTREPRISE_VISIT.DataPropertyName = "ENTREPRISE_VISIT";
            this.ENTREPRISE_VISIT.HeaderText = "Entreprise";
            this.ENTREPRISE_VISIT.MinimumWidth = 6;
            this.ENTREPRISE_VISIT.Name = "ENTREPRISE_VISIT";
            this.ENTREPRISE_VISIT.ReadOnly = true;
            this.ENTREPRISE_VISIT.Width = 250;
            // 
            // NOTE_VISIT
            // 
            this.NOTE_VISIT.DataPropertyName = "NOTE_VISIT";
            this.NOTE_VISIT.HeaderText = "Note";
            this.NOTE_VISIT.MinimumWidth = 6;
            this.NOTE_VISIT.Name = "NOTE_VISIT";
            this.NOTE_VISIT.ReadOnly = true;
            this.NOTE_VISIT.Width = 300;
            // 
            // DATE_VISIT
            // 
            this.DATE_VISIT.DataPropertyName = "DATE_VISIT";
            this.DATE_VISIT.HeaderText = "Date";
            this.DATE_VISIT.MinimumWidth = 6;
            this.DATE_VISIT.Name = "DATE_VISIT";
            this.DATE_VISIT.ReadOnly = true;
            this.DATE_VISIT.Width = 125;
            // 
            // DATECREATE_VISIT
            // 
            this.DATECREATE_VISIT.DataPropertyName = "DATECREATE_VISIT";
            this.DATECREATE_VISIT.HeaderText = "Créer le";
            this.DATECREATE_VISIT.MinimumWidth = 6;
            this.DATECREATE_VISIT.Name = "DATECREATE_VISIT";
            this.DATECREATE_VISIT.ReadOnly = true;
            this.DATECREATE_VISIT.Width = 150;
            // 
            // USERCREATE_VISIT
            // 
            this.USERCREATE_VISIT.DataPropertyName = "USERCREATE_VISIT";
            this.USERCREATE_VISIT.HeaderText = "Créer par";
            this.USERCREATE_VISIT.MinimumWidth = 6;
            this.USERCREATE_VISIT.Name = "USERCREATE_VISIT";
            this.USERCREATE_VISIT.ReadOnly = true;
            this.USERCREATE_VISIT.Width = 200;
            // 
            // DATEMODIFIER_VISIT
            // 
            this.DATEMODIFIER_VISIT.DataPropertyName = "DATEMODIFIER_VISIT";
            this.DATEMODIFIER_VISIT.HeaderText = "Modifier le";
            this.DATEMODIFIER_VISIT.MinimumWidth = 6;
            this.DATEMODIFIER_VISIT.Name = "DATEMODIFIER_VISIT";
            this.DATEMODIFIER_VISIT.ReadOnly = true;
            this.DATEMODIFIER_VISIT.Width = 200;
            // 
            // USERMODIFIER_VISIT
            // 
            this.USERMODIFIER_VISIT.DataPropertyName = "USERMODIFIER_VISIT";
            this.USERMODIFIER_VISIT.HeaderText = "Modier par";
            this.USERMODIFIER_VISIT.MinimumWidth = 6;
            this.USERMODIFIER_VISIT.Name = "USERMODIFIER_VISIT";
            this.USERMODIFIER_VISIT.ReadOnly = true;
            this.USERMODIFIER_VISIT.Width = 200;
            // 
            // FormMainVisiteTech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 731);
            this.Controls.Add(this.dgvVisitTech);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMainVisiteTech";
            this.Text = "FormMainVisiteTech";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitTech)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconBtnExportReportCarVist;
        private FontAwesome.Sharp.IconButton iconBtnSearchFormVisit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconBtnCloseFormVisit;
        private FontAwesome.Sharp.IconButton iconBtnCreateVisit;
        private System.Windows.Forms.DateTimePicker dateVisiteTechFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblTotalFraisDossier;
        private System.Windows.Forms.Label LblTotalVisit;
        private System.Windows.Forms.DataGridView dgvVisitTech;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateVisitTechTo;
        private System.Windows.Forms.ComboBox cbxPeriodSearch;
        private System.Windows.Forms.ComboBox cbxCarVisitTech;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_VISIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMMATRICULATION_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FRAIS_DOSSIER_VISIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRIX_VIGNET_VISIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn FRAIS_GARAGISTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENTREPRISE_VISIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTE_VISIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_VISIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATECREATE_VISIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERCREATE_VISIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATEMODIFIER_VISIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERMODIFIER_VISIT;
        private System.Windows.Forms.Label LblTotalGaragiste;
        private System.Windows.Forms.Label LblTotalVignette;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}