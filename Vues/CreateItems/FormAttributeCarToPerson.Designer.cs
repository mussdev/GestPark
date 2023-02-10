
namespace GestPark
{
    partial class FormAttributeCarToPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAttributeCarToPerson));
            this.panelTitleMainAttribute = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnImportAffect = new FontAwesome.Sharp.IconButton();
            this.BtnExportAffect = new FontAwesome.Sharp.IconButton();
            this.IbtnCloseFormMainAttribute = new FontAwesome.Sharp.IconButton();
            this.IbtnCreateAttribute = new FontAwesome.Sharp.IconButton();
            this.TbxSearchAttribute = new System.Windows.Forms.TextBox();
            this.panelSearchAttribute = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxPeriodAttri = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateAttriTo = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxCarAttriSearch = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxPersonSearch = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateAttrFromiSearch = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.IbtnSearchCarAttribute = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewAttributeCar = new System.Windows.Forms.DataGridView();
            this.CODE_ATTRI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMMATRICULATION_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_PERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_ATTRI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_DEBUT_ATTRI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_FIN_ATTRI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTE_ATTRI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTitleMainAttribute.SuspendLayout();
            this.panelSearchAttribute.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttributeCar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleMainAttribute
            // 
            this.panelTitleMainAttribute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.panelTitleMainAttribute.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTitleMainAttribute.Controls.Add(this.label6);
            this.panelTitleMainAttribute.Controls.Add(this.BtnImportAffect);
            this.panelTitleMainAttribute.Controls.Add(this.BtnExportAffect);
            this.panelTitleMainAttribute.Controls.Add(this.IbtnCloseFormMainAttribute);
            this.panelTitleMainAttribute.Controls.Add(this.IbtnCreateAttribute);
            this.panelTitleMainAttribute.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleMainAttribute.Location = new System.Drawing.Point(0, 0);
            this.panelTitleMainAttribute.Name = "panelTitleMainAttribute";
            this.panelTitleMainAttribute.Size = new System.Drawing.Size(1289, 28);
            this.panelTitleMainAttribute.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(603, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Attributions de véhicule de fonction";
            // 
            // BtnImportAffect
            // 
            this.BtnImportAffect.BackColor = System.Drawing.Color.White;
            this.BtnImportAffect.ForeColor = System.Drawing.Color.Black;
            this.BtnImportAffect.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.BtnImportAffect.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(34)))), ((int)(((byte)(4)))));
            this.BtnImportAffect.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnImportAffect.IconSize = 20;
            this.BtnImportAffect.Location = new System.Drawing.Point(228, -1);
            this.BtnImportAffect.Name = "BtnImportAffect";
            this.BtnImportAffect.Size = new System.Drawing.Size(109, 27);
            this.BtnImportAffect.TabIndex = 3;
            this.BtnImportAffect.Text = "Importer";
            this.BtnImportAffect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnImportAffect.UseVisualStyleBackColor = false;
            this.BtnImportAffect.MouseHover += new System.EventHandler(this.BtnImportAffect_MouseHover);
            // 
            // BtnExportAffect
            // 
            this.BtnExportAffect.BackColor = System.Drawing.Color.White;
            this.BtnExportAffect.ForeColor = System.Drawing.Color.Black;
            this.BtnExportAffect.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.BtnExportAffect.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(13)))));
            this.BtnExportAffect.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnExportAffect.IconSize = 20;
            this.BtnExportAffect.Location = new System.Drawing.Point(113, -1);
            this.BtnExportAffect.Name = "BtnExportAffect";
            this.BtnExportAffect.Size = new System.Drawing.Size(109, 27);
            this.BtnExportAffect.TabIndex = 2;
            this.BtnExportAffect.Text = "Exporter";
            this.BtnExportAffect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExportAffect.UseVisualStyleBackColor = false;
            this.BtnExportAffect.Click += new System.EventHandler(this.BtnExportAffect_Click);
            this.BtnExportAffect.MouseHover += new System.EventHandler(this.BtnExportAffect_MouseHover);
            // 
            // IbtnCloseFormMainAttribute
            // 
            this.IbtnCloseFormMainAttribute.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IbtnCloseFormMainAttribute.BackColor = System.Drawing.Color.White;
            this.IbtnCloseFormMainAttribute.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.IbtnCloseFormMainAttribute.IconColor = System.Drawing.Color.Red;
            this.IbtnCloseFormMainAttribute.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnCloseFormMainAttribute.IconSize = 20;
            this.IbtnCloseFormMainAttribute.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IbtnCloseFormMainAttribute.Location = new System.Drawing.Point(1257, -1);
            this.IbtnCloseFormMainAttribute.Name = "IbtnCloseFormMainAttribute";
            this.IbtnCloseFormMainAttribute.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.IbtnCloseFormMainAttribute.Size = new System.Drawing.Size(30, 27);
            this.IbtnCloseFormMainAttribute.TabIndex = 1;
            this.IbtnCloseFormMainAttribute.UseVisualStyleBackColor = false;
            this.IbtnCloseFormMainAttribute.Click += new System.EventHandler(this.IbtnCloseFormMainAttribute_Click);
            // 
            // IbtnCreateAttribute
            // 
            this.IbtnCreateAttribute.BackColor = System.Drawing.Color.White;
            this.IbtnCreateAttribute.ForeColor = System.Drawing.Color.Black;
            this.IbtnCreateAttribute.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.IbtnCreateAttribute.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.IbtnCreateAttribute.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnCreateAttribute.IconSize = 20;
            this.IbtnCreateAttribute.Location = new System.Drawing.Point(-2, -1);
            this.IbtnCreateAttribute.Name = "IbtnCreateAttribute";
            this.IbtnCreateAttribute.Size = new System.Drawing.Size(109, 27);
            this.IbtnCreateAttribute.TabIndex = 0;
            this.IbtnCreateAttribute.Text = "Saisir";
            this.IbtnCreateAttribute.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IbtnCreateAttribute.UseVisualStyleBackColor = false;
            this.IbtnCreateAttribute.Click += new System.EventHandler(this.IbtnCreateAttribute_Click);
            this.IbtnCreateAttribute.MouseHover += new System.EventHandler(this.IbtnCreateAttribute_MouseHover);
            // 
            // TbxSearchAttribute
            // 
            this.TbxSearchAttribute.BackColor = System.Drawing.Color.White;
            this.TbxSearchAttribute.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxSearchAttribute.Location = new System.Drawing.Point(725, 20);
            this.TbxSearchAttribute.Name = "TbxSearchAttribute";
            this.TbxSearchAttribute.Size = new System.Drawing.Size(302, 26);
            this.TbxSearchAttribute.TabIndex = 0;
            // 
            // panelSearchAttribute
            // 
            this.panelSearchAttribute.AutoScroll = true;
            this.panelSearchAttribute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.panelSearchAttribute.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSearchAttribute.Controls.Add(this.label9);
            this.panelSearchAttribute.Controls.Add(this.cbxPeriodAttri);
            this.panelSearchAttribute.Controls.Add(this.label8);
            this.panelSearchAttribute.Controls.Add(this.dateAttriTo);
            this.panelSearchAttribute.Controls.Add(this.label7);
            this.panelSearchAttribute.Controls.Add(this.cbxCarAttriSearch);
            this.panelSearchAttribute.Controls.Add(this.label5);
            this.panelSearchAttribute.Controls.Add(this.cbxPersonSearch);
            this.panelSearchAttribute.Controls.Add(this.label4);
            this.panelSearchAttribute.Controls.Add(this.label3);
            this.panelSearchAttribute.Controls.Add(this.dateAttrFromiSearch);
            this.panelSearchAttribute.Controls.Add(this.label1);
            this.panelSearchAttribute.Controls.Add(this.IbtnSearchCarAttribute);
            this.panelSearchAttribute.Controls.Add(this.TbxSearchAttribute);
            this.panelSearchAttribute.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchAttribute.Location = new System.Drawing.Point(0, 28);
            this.panelSearchAttribute.Name = "panelSearchAttribute";
            this.panelSearchAttribute.Size = new System.Drawing.Size(1289, 169);
            this.panelSearchAttribute.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(7, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "Période";
            // 
            // cbxPeriodAttri
            // 
            this.cbxPeriodAttri.FormattingEnabled = true;
            this.cbxPeriodAttri.Items.AddRange(new object[] {
            "",
            "Aujourd\'hui",
            "Mois en cours",
            "Mois précédent",
            "Année en cours",
            "Année précédente",
            "Personnalisée"});
            this.cbxPeriodAttri.Location = new System.Drawing.Point(10, 20);
            this.cbxPeriodAttri.Name = "cbxPeriodAttri";
            this.cbxPeriodAttri.Size = new System.Drawing.Size(213, 28);
            this.cbxPeriodAttri.TabIndex = 14;
            this.cbxPeriodAttri.SelectedIndexChanged += new System.EventHandler(this.cbxPeriodAttri_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(118, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Fin";
            // 
            // dateAttriTo
            // 
            this.dateAttriTo.Enabled = false;
            this.dateAttriTo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateAttriTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateAttriTo.Location = new System.Drawing.Point(121, 68);
            this.dateAttriTo.Name = "dateAttriTo";
            this.dateAttriTo.Size = new System.Drawing.Size(102, 26);
            this.dateAttriTo.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(275, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Véhicules";
            // 
            // cbxCarAttriSearch
            // 
            this.cbxCarAttriSearch.FormattingEnabled = true;
            this.cbxCarAttriSearch.Location = new System.Drawing.Point(278, 68);
            this.cbxCarAttriSearch.Name = "cbxCarAttriSearch";
            this.cbxCarAttriSearch.Size = new System.Drawing.Size(222, 28);
            this.cbxCarAttriSearch.TabIndex = 10;
            this.cbxCarAttriSearch.SelectedIndexChanged += new System.EventHandler(this.cbxCarAttriSearch_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(275, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Personnels";
            // 
            // cbxPersonSearch
            // 
            this.cbxPersonSearch.FormattingEnabled = true;
            this.cbxPersonSearch.Location = new System.Drawing.Point(278, 20);
            this.cbxPersonSearch.Name = "cbxPersonSearch";
            this.cbxPersonSearch.Size = new System.Drawing.Size(222, 28);
            this.cbxPersonSearch.TabIndex = 8;
            this.cbxPersonSearch.SelectedIndexChanged += new System.EventHandler(this.cbxPersonSearch_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(908, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rechercher";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(577, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Reche. multicritère";
            // 
            // dateAttrFromiSearch
            // 
            this.dateAttrFromiSearch.Enabled = false;
            this.dateAttrFromiSearch.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateAttrFromiSearch.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateAttrFromiSearch.Location = new System.Drawing.Point(12, 68);
            this.dateAttrFromiSearch.Name = "dateAttrFromiSearch";
            this.dateAttrFromiSearch.Size = new System.Drawing.Size(103, 26);
            this.dateAttrFromiSearch.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Début";
            // 
            // IbtnSearchCarAttribute
            // 
            this.IbtnSearchCarAttribute.BackColor = System.Drawing.Color.White;
            this.IbtnSearchCarAttribute.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.IbtnSearchCarAttribute.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.IbtnSearchCarAttribute.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnSearchCarAttribute.IconSize = 20;
            this.IbtnSearchCarAttribute.Location = new System.Drawing.Point(1002, 68);
            this.IbtnSearchCarAttribute.Name = "IbtnSearchCarAttribute";
            this.IbtnSearchCarAttribute.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.IbtnSearchCarAttribute.Size = new System.Drawing.Size(25, 25);
            this.IbtnSearchCarAttribute.TabIndex = 3;
            this.IbtnSearchCarAttribute.UseVisualStyleBackColor = false;
            this.IbtnSearchCarAttribute.Click += new System.EventHandler(this.IbtnSearchCarAttribute_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 197);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1289, 24);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total = 0";
            // 
            // dataGridViewAttributeCar
            // 
            this.dataGridViewAttributeCar.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewAttributeCar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAttributeCar.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAttributeCar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAttributeCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAttributeCar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODE_ATTRI,
            this.IMMATRICULATION_VEHICULE,
            this.DESCRIPTION_PERS,
            this.DATE_ATTRI,
            this.DATE_DEBUT_ATTRI,
            this.DATE_FIN_ATTRI,
            this.NOTE_ATTRI});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAttributeCar.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewAttributeCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAttributeCar.GridColor = System.Drawing.Color.White;
            this.dataGridViewAttributeCar.Location = new System.Drawing.Point(0, 221);
            this.dataGridViewAttributeCar.Name = "dataGridViewAttributeCar";
            this.dataGridViewAttributeCar.RowHeadersWidth = 51;
            this.dataGridViewAttributeCar.Size = new System.Drawing.Size(1289, 548);
            this.dataGridViewAttributeCar.TabIndex = 34;
            this.dataGridViewAttributeCar.DoubleClick += new System.EventHandler(this.dataGridViewAttributeCar_DoubleClick);
            // 
            // CODE_ATTRI
            // 
            this.CODE_ATTRI.DataPropertyName = "CODE_ATTRI";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CODE_ATTRI.DefaultCellStyle = dataGridViewCellStyle3;
            this.CODE_ATTRI.HeaderText = "Code";
            this.CODE_ATTRI.MinimumWidth = 6;
            this.CODE_ATTRI.Name = "CODE_ATTRI";
            this.CODE_ATTRI.ReadOnly = true;
            this.CODE_ATTRI.Width = 125;
            // 
            // IMMATRICULATION_VEHICULE
            // 
            this.IMMATRICULATION_VEHICULE.DataPropertyName = "IMMATRICULATION_VEHICULE";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.IMMATRICULATION_VEHICULE.DefaultCellStyle = dataGridViewCellStyle4;
            this.IMMATRICULATION_VEHICULE.HeaderText = "Immatri. vehi.";
            this.IMMATRICULATION_VEHICULE.MinimumWidth = 6;
            this.IMMATRICULATION_VEHICULE.Name = "IMMATRICULATION_VEHICULE";
            this.IMMATRICULATION_VEHICULE.ReadOnly = true;
            this.IMMATRICULATION_VEHICULE.Width = 320;
            // 
            // DESCRIPTION_PERS
            // 
            this.DESCRIPTION_PERS.DataPropertyName = "DESCRIPTION_PERS";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DESCRIPTION_PERS.DefaultCellStyle = dataGridViewCellStyle5;
            this.DESCRIPTION_PERS.HeaderText = "Propriétaire";
            this.DESCRIPTION_PERS.MinimumWidth = 6;
            this.DESCRIPTION_PERS.Name = "DESCRIPTION_PERS";
            this.DESCRIPTION_PERS.ReadOnly = true;
            this.DESCRIPTION_PERS.Width = 350;
            // 
            // DATE_ATTRI
            // 
            this.DATE_ATTRI.DataPropertyName = "DATE_ATTRI";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DATE_ATTRI.DefaultCellStyle = dataGridViewCellStyle6;
            this.DATE_ATTRI.HeaderText = "Date";
            this.DATE_ATTRI.MinimumWidth = 6;
            this.DATE_ATTRI.Name = "DATE_ATTRI";
            this.DATE_ATTRI.ReadOnly = true;
            this.DATE_ATTRI.Width = 125;
            // 
            // DATE_DEBUT_ATTRI
            // 
            this.DATE_DEBUT_ATTRI.DataPropertyName = "DATE_DEBUT_ATTRI";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DATE_DEBUT_ATTRI.DefaultCellStyle = dataGridViewCellStyle7;
            this.DATE_DEBUT_ATTRI.HeaderText = "Date attri. véhi.";
            this.DATE_DEBUT_ATTRI.MinimumWidth = 6;
            this.DATE_DEBUT_ATTRI.Name = "DATE_DEBUT_ATTRI";
            this.DATE_DEBUT_ATTRI.ReadOnly = true;
            this.DATE_DEBUT_ATTRI.Width = 150;
            // 
            // DATE_FIN_ATTRI
            // 
            this.DATE_FIN_ATTRI.DataPropertyName = "DATE_FIN_ATTRI";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DATE_FIN_ATTRI.DefaultCellStyle = dataGridViewCellStyle8;
            this.DATE_FIN_ATTRI.HeaderText = "Date fin attri.";
            this.DATE_FIN_ATTRI.MinimumWidth = 6;
            this.DATE_FIN_ATTRI.Name = "DATE_FIN_ATTRI";
            this.DATE_FIN_ATTRI.ReadOnly = true;
            this.DATE_FIN_ATTRI.Width = 150;
            // 
            // NOTE_ATTRI
            // 
            this.NOTE_ATTRI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOTE_ATTRI.DataPropertyName = "NOTE_ATTRI";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.NOTE_ATTRI.DefaultCellStyle = dataGridViewCellStyle9;
            this.NOTE_ATTRI.HeaderText = "Note";
            this.NOTE_ATTRI.MinimumWidth = 6;
            this.NOTE_ATTRI.Name = "NOTE_ATTRI";
            this.NOTE_ATTRI.ReadOnly = true;
            // 
            // FormAttributeCarToPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1289, 769);
            this.Controls.Add(this.dataGridViewAttributeCar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSearchAttribute);
            this.Controls.Add(this.panelTitleMainAttribute);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAttributeCarToPerson";
            this.Text = "FormAttributeCarToPerson";
            this.panelTitleMainAttribute.ResumeLayout(false);
            this.panelTitleMainAttribute.PerformLayout();
            this.panelSearchAttribute.ResumeLayout(false);
            this.panelSearchAttribute.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttributeCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleMainAttribute;
        private FontAwesome.Sharp.IconButton IbtnCloseFormMainAttribute;
        private FontAwesome.Sharp.IconButton IbtnCreateAttribute;
        private System.Windows.Forms.TextBox TbxSearchAttribute;
        private System.Windows.Forms.Panel panelSearchAttribute;
        private FontAwesome.Sharp.IconButton IbtnSearchCarAttribute;
        private FontAwesome.Sharp.IconButton BtnImportAffect;
        private FontAwesome.Sharp.IconButton BtnExportAffect;
        private System.Windows.Forms.DateTimePicker dateAttrFromiSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewAttributeCar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxPersonSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxCarAttriSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxPeriodAttri;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateAttriTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_ATTRI;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMMATRICULATION_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_PERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_ATTRI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_DEBUT_ATTRI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_FIN_ATTRI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTE_ATTRI;
    }
}