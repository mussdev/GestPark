
namespace GestPark
{
    partial class FormRepairCar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRepairCar));
            this.PanelSearchRepairCar = new System.Windows.Forms.Panel();
            this.cbxPeriodeRepar = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxGarageSearch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateFinRepairCar = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxCarRepairSearch = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateDebutRepairCar = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.IbtnSearchRepairCar = new FontAwesome.Sharp.IconButton();
            this.TxtSeachRepairCar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnImportRepaiCar = new FontAwesome.Sharp.IconButton();
            this.BtnCreateRepaiCar = new FontAwesome.Sharp.IconButton();
            this.IbtnExportRepairCar = new FontAwesome.Sharp.IconButton();
            this.IbtnCloseFanRepairCar = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.totalAmountReapir = new System.Windows.Forms.Label();
            this.TotalRepair = new System.Windows.Forms.Label();
            this.DgvCarRepair = new System.Windows.Forms.DataGridView();
            this.CODE_REPAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMMATRICULATION_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRIX_REPAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_GARAGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAUSE_REPAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROPRIETAIRE_GARAGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEL_GARAGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUT_REPAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_REPAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATECREATE_REPAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERCREATE_REPAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFilterRepairCar = new System.Windows.Forms.TextBox();
            this.PanelSearchRepairCar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCarRepair)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelSearchRepairCar
            // 
            this.PanelSearchRepairCar.AutoScroll = true;
            this.PanelSearchRepairCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.PanelSearchRepairCar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelSearchRepairCar.Controls.Add(this.label9);
            this.PanelSearchRepairCar.Controls.Add(this.txtFilterRepairCar);
            this.PanelSearchRepairCar.Controls.Add(this.cbxPeriodeRepar);
            this.PanelSearchRepairCar.Controls.Add(this.label8);
            this.PanelSearchRepairCar.Controls.Add(this.cbxGarageSearch);
            this.PanelSearchRepairCar.Controls.Add(this.label2);
            this.PanelSearchRepairCar.Controls.Add(this.label1);
            this.PanelSearchRepairCar.Controls.Add(this.dateFinRepairCar);
            this.PanelSearchRepairCar.Controls.Add(this.label6);
            this.PanelSearchRepairCar.Controls.Add(this.cbxCarRepairSearch);
            this.PanelSearchRepairCar.Controls.Add(this.label5);
            this.PanelSearchRepairCar.Controls.Add(this.label4);
            this.PanelSearchRepairCar.Controls.Add(this.dateDebutRepairCar);
            this.PanelSearchRepairCar.Controls.Add(this.label3);
            this.PanelSearchRepairCar.Controls.Add(this.IbtnSearchRepairCar);
            this.PanelSearchRepairCar.Controls.Add(this.TxtSeachRepairCar);
            this.PanelSearchRepairCar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSearchRepairCar.Location = new System.Drawing.Point(0, 28);
            this.PanelSearchRepairCar.Name = "PanelSearchRepairCar";
            this.PanelSearchRepairCar.Size = new System.Drawing.Size(1263, 187);
            this.PanelSearchRepairCar.TabIndex = 3;
            // 
            // cbxPeriodeRepar
            // 
            this.cbxPeriodeRepar.FormattingEnabled = true;
            this.cbxPeriodeRepar.Items.AddRange(new object[] {
            "",
            "Aujourd\'hui",
            "Mois en cours",
            "Mois précédent",
            "Année en cours",
            "Année précédente",
            "Personnalisée"});
            this.cbxPeriodeRepar.Location = new System.Drawing.Point(15, 27);
            this.cbxPeriodeRepar.Name = "cbxPeriodeRepar";
            this.cbxPeriodeRepar.Size = new System.Drawing.Size(239, 27);
            this.cbxPeriodeRepar.TabIndex = 16;
            this.cbxPeriodeRepar.SelectedIndexChanged += new System.EventHandler(this.cbxPeriodeRepar_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(11, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Période";
            // 
            // cbxGarageSearch
            // 
            this.cbxGarageSearch.FormattingEnabled = true;
            this.cbxGarageSearch.Items.AddRange(new object[] {
            ""});
            this.cbxGarageSearch.Location = new System.Drawing.Point(319, 87);
            this.cbxGarageSearch.Name = "cbxGarageSearch";
            this.cbxGarageSearch.Size = new System.Drawing.Size(251, 27);
            this.cbxGarageSearch.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(315, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Garage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(989, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Rechercher";
            // 
            // dateFinRepairCar
            // 
            this.dateFinRepairCar.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateFinRepairCar.CustomFormat = " ";
            this.dateFinRepairCar.Enabled = false;
            this.dateFinRepairCar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFinRepairCar.Location = new System.Drawing.Point(142, 87);
            this.dateFinRepairCar.Name = "dateFinRepairCar";
            this.dateFinRepairCar.Size = new System.Drawing.Size(112, 26);
            this.dateFinRepairCar.TabIndex = 11;
            this.dateFinRepairCar.ValueChanged += new System.EventHandler(this.dateFinRepairCar_ValueChanged);
            this.dateFinRepairCar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateFinRepairCar_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(138, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fin";
            // 
            // cbxCarRepairSearch
            // 
            this.cbxCarRepairSearch.FormattingEnabled = true;
            this.cbxCarRepairSearch.Items.AddRange(new object[] {
            ""});
            this.cbxCarRepairSearch.Location = new System.Drawing.Point(319, 28);
            this.cbxCarRepairSearch.Name = "cbxCarRepairSearch";
            this.cbxCarRepairSearch.Size = new System.Drawing.Size(251, 27);
            this.cbxCarRepairSearch.TabIndex = 9;
            this.cbxCarRepairSearch.SelectedIndexChanged += new System.EventHandler(this.cbxCarRepairSearch_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(315, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Véhicule";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(682, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Recherche multi-critère";
            // 
            // dateDebutRepairCar
            // 
            this.dateDebutRepairCar.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateDebutRepairCar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dateDebutRepairCar.CustomFormat = " ";
            this.dateDebutRepairCar.Enabled = false;
            this.dateDebutRepairCar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDebutRepairCar.Location = new System.Drawing.Point(15, 87);
            this.dateDebutRepairCar.Name = "dateDebutRepairCar";
            this.dateDebutRepairCar.Size = new System.Drawing.Size(121, 26);
            this.dateDebutRepairCar.TabIndex = 6;
            this.dateDebutRepairCar.ValueChanged += new System.EventHandler(this.dateDebutRepairCar_ValueChanged);
            this.dateDebutRepairCar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateDebutRepairCar_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(11, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Début";
            // 
            // IbtnSearchRepairCar
            // 
            this.IbtnSearchRepairCar.BackColor = System.Drawing.Color.White;
            this.IbtnSearchRepairCar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.IbtnSearchRepairCar.IconColor = System.Drawing.Color.Maroon;
            this.IbtnSearchRepairCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnSearchRepairCar.IconSize = 20;
            this.IbtnSearchRepairCar.Location = new System.Drawing.Point(1083, 75);
            this.IbtnSearchRepairCar.Name = "IbtnSearchRepairCar";
            this.IbtnSearchRepairCar.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.IbtnSearchRepairCar.Size = new System.Drawing.Size(34, 26);
            this.IbtnSearchRepairCar.TabIndex = 4;
            this.IbtnSearchRepairCar.UseVisualStyleBackColor = false;
            this.IbtnSearchRepairCar.Click += new System.EventHandler(this.IbtnSearchRepairCar_Click);
            // 
            // TxtSeachRepairCar
            // 
            this.TxtSeachRepairCar.BackColor = System.Drawing.Color.White;
            this.TxtSeachRepairCar.Location = new System.Drawing.Point(862, 29);
            this.TxtSeachRepairCar.Name = "TxtSeachRepairCar";
            this.TxtSeachRepairCar.Size = new System.Drawing.Size(255, 26);
            this.TxtSeachRepairCar.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.BtnImportRepaiCar);
            this.panel1.Controls.Add(this.BtnCreateRepaiCar);
            this.panel1.Controls.Add(this.IbtnExportRepairCar);
            this.panel1.Controls.Add(this.IbtnCloseFanRepairCar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1263, 28);
            this.panel1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(581, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Réparation de véhicule";
            // 
            // BtnImportRepaiCar
            // 
            this.BtnImportRepaiCar.BackColor = System.Drawing.Color.White;
            this.BtnImportRepaiCar.ForeColor = System.Drawing.Color.Black;
            this.BtnImportRepaiCar.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.BtnImportRepaiCar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(147)))), ((int)(((byte)(222)))));
            this.BtnImportRepaiCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnImportRepaiCar.IconSize = 20;
            this.BtnImportRepaiCar.Location = new System.Drawing.Point(190, -2);
            this.BtnImportRepaiCar.Name = "BtnImportRepaiCar";
            this.BtnImportRepaiCar.Size = new System.Drawing.Size(98, 29);
            this.BtnImportRepaiCar.TabIndex = 7;
            this.BtnImportRepaiCar.Text = "Importer";
            this.BtnImportRepaiCar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnImportRepaiCar.UseVisualStyleBackColor = false;
            this.BtnImportRepaiCar.Click += new System.EventHandler(this.BtnImportRepaiCar_Click);
            this.BtnImportRepaiCar.MouseHover += new System.EventHandler(this.BtnImportRepaiCar_MouseHover);
            // 
            // BtnCreateRepaiCar
            // 
            this.BtnCreateRepaiCar.BackColor = System.Drawing.Color.White;
            this.BtnCreateRepaiCar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreateRepaiCar.ForeColor = System.Drawing.Color.Black;
            this.BtnCreateRepaiCar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnCreateRepaiCar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.BtnCreateRepaiCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCreateRepaiCar.IconSize = 20;
            this.BtnCreateRepaiCar.Location = new System.Drawing.Point(-2, -1);
            this.BtnCreateRepaiCar.Name = "BtnCreateRepaiCar";
            this.BtnCreateRepaiCar.Size = new System.Drawing.Size(82, 28);
            this.BtnCreateRepaiCar.TabIndex = 6;
            this.BtnCreateRepaiCar.Text = "Saisir";
            this.BtnCreateRepaiCar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCreateRepaiCar.UseVisualStyleBackColor = false;
            this.BtnCreateRepaiCar.Click += new System.EventHandler(this.BtnCreateRepaiCar_Click);
            this.BtnCreateRepaiCar.MouseHover += new System.EventHandler(this.BtnCreateRepaiCar_MouseHover);
            // 
            // IbtnExportRepairCar
            // 
            this.IbtnExportRepairCar.BackColor = System.Drawing.Color.White;
            this.IbtnExportRepairCar.ForeColor = System.Drawing.Color.Black;
            this.IbtnExportRepairCar.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.IbtnExportRepairCar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(13)))));
            this.IbtnExportRepairCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnExportRepairCar.IconSize = 20;
            this.IbtnExportRepairCar.Location = new System.Drawing.Point(86, -1);
            this.IbtnExportRepairCar.Name = "IbtnExportRepairCar";
            this.IbtnExportRepairCar.Size = new System.Drawing.Size(98, 27);
            this.IbtnExportRepairCar.TabIndex = 5;
            this.IbtnExportRepairCar.Text = "Exporter";
            this.IbtnExportRepairCar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IbtnExportRepairCar.UseVisualStyleBackColor = false;
            this.IbtnExportRepairCar.Click += new System.EventHandler(this.IbtnExportRepairCar_Click);
            this.IbtnExportRepairCar.MouseHover += new System.EventHandler(this.IbtnExportRepairCar_MouseHover);
            // 
            // IbtnCloseFanRepairCar
            // 
            this.IbtnCloseFanRepairCar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.IbtnCloseFanRepairCar.BackColor = System.Drawing.Color.White;
            this.IbtnCloseFanRepairCar.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.IbtnCloseFanRepairCar.IconColor = System.Drawing.Color.Red;
            this.IbtnCloseFanRepairCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnCloseFanRepairCar.IconSize = 20;
            this.IbtnCloseFanRepairCar.Location = new System.Drawing.Point(1232, -1);
            this.IbtnCloseFanRepairCar.Name = "IbtnCloseFanRepairCar";
            this.IbtnCloseFanRepairCar.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.IbtnCloseFanRepairCar.Size = new System.Drawing.Size(27, 26);
            this.IbtnCloseFanRepairCar.TabIndex = 5;
            this.IbtnCloseFanRepairCar.UseVisualStyleBackColor = false;
            this.IbtnCloseFanRepairCar.Click += new System.EventHandler(this.IbtnCloseFanRepairCar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.panel2.Controls.Add(this.totalAmountReapir);
            this.panel2.Controls.Add(this.TotalRepair);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 215);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1263, 24);
            this.panel2.TabIndex = 4;
            // 
            // totalAmountReapir
            // 
            this.totalAmountReapir.AutoSize = true;
            this.totalAmountReapir.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmountReapir.ForeColor = System.Drawing.Color.Maroon;
            this.totalAmountReapir.Location = new System.Drawing.Point(318, 6);
            this.totalAmountReapir.Name = "totalAmountReapir";
            this.totalAmountReapir.Size = new System.Drawing.Size(126, 19);
            this.totalAmountReapir.TabIndex = 1;
            this.totalAmountReapir.Text = "Montant net = 0";
            // 
            // TotalRepair
            // 
            this.TotalRepair.AutoSize = true;
            this.TotalRepair.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalRepair.ForeColor = System.Drawing.Color.Maroon;
            this.TotalRepair.Location = new System.Drawing.Point(3, 6);
            this.TotalRepair.Name = "TotalRepair";
            this.TotalRepair.Size = new System.Drawing.Size(73, 19);
            this.TotalRepair.TabIndex = 0;
            this.TotalRepair.Text = "Total = 0";
            // 
            // DgvCarRepair
            // 
            this.DgvCarRepair.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DgvCarRepair.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvCarRepair.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCarRepair.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvCarRepair.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCarRepair.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODE_REPAR,
            this.IMMATRICULATION_VEHICULE,
            this.PRIX_REPAR,
            this.DESCRIPTION_GARAGE,
            this.CAUSE_REPAR,
            this.PROPRIETAIRE_GARAGE,
            this.TEL_GARAGE,
            this.STATUT_REPAR,
            this.DATE_REPAR,
            this.DATECREATE_REPAR,
            this.USERCREATE_REPAR});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvCarRepair.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvCarRepair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvCarRepair.GridColor = System.Drawing.Color.White;
            this.DgvCarRepair.Location = new System.Drawing.Point(0, 239);
            this.DgvCarRepair.Name = "DgvCarRepair";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCarRepair.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvCarRepair.RowHeadersWidth = 51;
            this.DgvCarRepair.Size = new System.Drawing.Size(1263, 417);
            this.DgvCarRepair.TabIndex = 5;
            this.DgvCarRepair.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCarRepair_CellDoubleClick);
            // 
            // CODE_REPAR
            // 
            this.CODE_REPAR.DataPropertyName = "CODE_REPAR";
            this.CODE_REPAR.HeaderText = "Code";
            this.CODE_REPAR.MinimumWidth = 6;
            this.CODE_REPAR.Name = "CODE_REPAR";
            this.CODE_REPAR.ReadOnly = true;
            this.CODE_REPAR.Width = 150;
            // 
            // IMMATRICULATION_VEHICULE
            // 
            this.IMMATRICULATION_VEHICULE.DataPropertyName = "IMMATRICULATION_VEHICULE";
            this.IMMATRICULATION_VEHICULE.HeaderText = "Véhicule";
            this.IMMATRICULATION_VEHICULE.MinimumWidth = 6;
            this.IMMATRICULATION_VEHICULE.Name = "IMMATRICULATION_VEHICULE";
            this.IMMATRICULATION_VEHICULE.ReadOnly = true;
            this.IMMATRICULATION_VEHICULE.Width = 300;
            // 
            // PRIX_REPAR
            // 
            this.PRIX_REPAR.DataPropertyName = "PRIX_REPAR";
            this.PRIX_REPAR.HeaderText = "Montant";
            this.PRIX_REPAR.MinimumWidth = 6;
            this.PRIX_REPAR.Name = "PRIX_REPAR";
            this.PRIX_REPAR.ReadOnly = true;
            this.PRIX_REPAR.Width = 150;
            // 
            // DESCRIPTION_GARAGE
            // 
            this.DESCRIPTION_GARAGE.DataPropertyName = "DESCRIPTION_GARAGE";
            this.DESCRIPTION_GARAGE.HeaderText = "Garage";
            this.DESCRIPTION_GARAGE.MinimumWidth = 6;
            this.DESCRIPTION_GARAGE.Name = "DESCRIPTION_GARAGE";
            this.DESCRIPTION_GARAGE.ReadOnly = true;
            this.DESCRIPTION_GARAGE.Width = 200;
            // 
            // CAUSE_REPAR
            // 
            this.CAUSE_REPAR.DataPropertyName = "CAUSE_REPAR";
            this.CAUSE_REPAR.HeaderText = "Causes";
            this.CAUSE_REPAR.MinimumWidth = 6;
            this.CAUSE_REPAR.Name = "CAUSE_REPAR";
            this.CAUSE_REPAR.ReadOnly = true;
            this.CAUSE_REPAR.Width = 300;
            // 
            // PROPRIETAIRE_GARAGE
            // 
            this.PROPRIETAIRE_GARAGE.DataPropertyName = "PROPRIETAIRE_GARAGE";
            this.PROPRIETAIRE_GARAGE.HeaderText = "Proprio. garage";
            this.PROPRIETAIRE_GARAGE.MinimumWidth = 6;
            this.PROPRIETAIRE_GARAGE.Name = "PROPRIETAIRE_GARAGE";
            this.PROPRIETAIRE_GARAGE.ReadOnly = true;
            this.PROPRIETAIRE_GARAGE.Width = 200;
            // 
            // TEL_GARAGE
            // 
            this.TEL_GARAGE.DataPropertyName = "TEL_GARAGE";
            this.TEL_GARAGE.HeaderText = "Tél. garage";
            this.TEL_GARAGE.MinimumWidth = 6;
            this.TEL_GARAGE.Name = "TEL_GARAGE";
            this.TEL_GARAGE.ReadOnly = true;
            this.TEL_GARAGE.Width = 125;
            // 
            // STATUT_REPAR
            // 
            this.STATUT_REPAR.DataPropertyName = "STATUT_REPAR";
            this.STATUT_REPAR.HeaderText = "Etat véhicule";
            this.STATUT_REPAR.MinimumWidth = 6;
            this.STATUT_REPAR.Name = "STATUT_REPAR";
            this.STATUT_REPAR.ReadOnly = true;
            this.STATUT_REPAR.Width = 150;
            // 
            // DATE_REPAR
            // 
            this.DATE_REPAR.DataPropertyName = "DATE_REPAR";
            this.DATE_REPAR.HeaderText = "Reparér le";
            this.DATE_REPAR.MinimumWidth = 6;
            this.DATE_REPAR.Name = "DATE_REPAR";
            this.DATE_REPAR.ReadOnly = true;
            this.DATE_REPAR.Width = 125;
            // 
            // DATECREATE_REPAR
            // 
            this.DATECREATE_REPAR.DataPropertyName = "DATECREATE_REPAR";
            this.DATECREATE_REPAR.HeaderText = "Créer le";
            this.DATECREATE_REPAR.MinimumWidth = 6;
            this.DATECREATE_REPAR.Name = "DATECREATE_REPAR";
            this.DATECREATE_REPAR.ReadOnly = true;
            this.DATECREATE_REPAR.Width = 150;
            // 
            // USERCREATE_REPAR
            // 
            this.USERCREATE_REPAR.DataPropertyName = "USERCREATE_REPAR";
            this.USERCREATE_REPAR.HeaderText = "Créer par";
            this.USERCREATE_REPAR.MinimumWidth = 6;
            this.USERCREATE_REPAR.Name = "USERCREATE_REPAR";
            this.USERCREATE_REPAR.ReadOnly = true;
            this.USERCREATE_REPAR.Width = 150;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(803, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "Filtrer";
            // 
            // txtFilterRepairCar
            // 
            this.txtFilterRepairCar.BackColor = System.Drawing.Color.White;
            this.txtFilterRepairCar.Location = new System.Drawing.Point(862, 125);
            this.txtFilterRepairCar.Name = "txtFilterRepairCar";
            this.txtFilterRepairCar.Size = new System.Drawing.Size(255, 26);
            this.txtFilterRepairCar.TabIndex = 17;
            this.txtFilterRepairCar.TextChanged += new System.EventHandler(this.txtFilterRepairCar_TextChanged);
            // 
            // FormRepairCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1263, 656);
            this.Controls.Add(this.DgvCarRepair);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PanelSearchRepairCar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRepairCar";
            this.Text = "FormRepairCar";
            this.PanelSearchRepairCar.ResumeLayout(false);
            this.PanelSearchRepairCar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCarRepair)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSearchRepairCar;
        private FontAwesome.Sharp.IconButton IbtnExportRepairCar;
        private FontAwesome.Sharp.IconButton IbtnSearchRepairCar;
        private System.Windows.Forms.TextBox TxtSeachRepairCar;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton IbtnCloseFanRepairCar;
        private FontAwesome.Sharp.IconButton BtnImportRepaiCar;
        private FontAwesome.Sharp.IconButton BtnCreateRepaiCar;
        private System.Windows.Forms.DateTimePicker dateDebutRepairCar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label totalAmountReapir;
        private System.Windows.Forms.Label TotalRepair;
        private System.Windows.Forms.DataGridView DgvCarRepair;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxCarRepairSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateFinRepairCar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_REPAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMMATRICULATION_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRIX_REPAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_GARAGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAUSE_REPAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROPRIETAIRE_GARAGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEL_GARAGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUT_REPAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_REPAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATECREATE_REPAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERCREATE_REPAR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxGarageSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxPeriodeRepar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFilterRepairCar;
    }
}