
namespace GestPark
{
    partial class FormMainFournisseur
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainFournisseur));
            this.textBoxRecheFour = new System.Windows.Forms.TextBox();
            this.PanelTitleFour = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvProvider = new System.Windows.Forms.DataGridView();
            this.CODE_FOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_FOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEL_FOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAIL_FOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTE_FOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REGICOM_FOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPTCONTRIB_FOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAYS_FOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VILLE_FOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADRESSE_FOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODEPOSTA_FOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_FOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AUTREINFO_FOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERCREATE_FOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATECREATION_FOUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconBtnSearchFourn = new FontAwesome.Sharp.IconButton();
            this.BtnImportFourn = new FontAwesome.Sharp.IconButton();
            this.BtnExportFourn = new FontAwesome.Sharp.IconButton();
            this.iconBtnCloseFormMainFour = new FontAwesome.Sharp.IconButton();
            this.iconBtnCreateFourn = new FontAwesome.Sharp.IconButton();
            this.MenuDeleteFour = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ItemMenuDeleteFour = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelTitleFour.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProvider)).BeginInit();
            this.MenuDeleteFour.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxRecheFour
            // 
            this.textBoxRecheFour.BackColor = System.Drawing.Color.White;
            this.textBoxRecheFour.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRecheFour.Location = new System.Drawing.Point(740, 29);
            this.textBoxRecheFour.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxRecheFour.Name = "textBoxRecheFour";
            this.textBoxRecheFour.Size = new System.Drawing.Size(300, 26);
            this.textBoxRecheFour.TabIndex = 0;
            // 
            // PanelTitleFour
            // 
            this.PanelTitleFour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.PanelTitleFour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelTitleFour.Controls.Add(this.label3);
            this.PanelTitleFour.Controls.Add(this.BtnImportFourn);
            this.PanelTitleFour.Controls.Add(this.BtnExportFourn);
            this.PanelTitleFour.Controls.Add(this.iconBtnCloseFormMainFour);
            this.PanelTitleFour.Controls.Add(this.iconBtnCreateFourn);
            this.PanelTitleFour.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitleFour.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelTitleFour.Location = new System.Drawing.Point(0, 0);
            this.PanelTitleFour.Margin = new System.Windows.Forms.Padding(5);
            this.PanelTitleFour.Name = "PanelTitleFour";
            this.PanelTitleFour.Size = new System.Drawing.Size(1869, 26);
            this.PanelTitleFour.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(761, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fournisseurs de véhicule ";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBoxRecheFour);
            this.panel2.Controls.Add(this.iconBtnSearchFourn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 26);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1869, 165);
            this.panel2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(912, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Rechercher";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(595, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Rech. multicritère";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 191);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1869, 24);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total = 0";
            // 
            // DgvProvider
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DgvProvider.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvProvider.BackgroundColor = System.Drawing.Color.White;
            this.DgvProvider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvProvider.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvProvider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProvider.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODE_FOUR,
            this.DESCRIPTION_FOUR,
            this.TEL_FOUR,
            this.MAIL_FOUR,
            this.NOTE_FOUR,
            this.REGICOM_FOUR,
            this.CPTCONTRIB_FOUR,
            this.PAYS_FOUR,
            this.VILLE_FOUR,
            this.ADRESSE_FOUR,
            this.CODEPOSTA_FOUR,
            this.DATE_FOUR,
            this.AUTREINFO_FOUR,
            this.USERCREATE_FOUR,
            this.DATECREATION_FOUR});
            this.DgvProvider.ContextMenuStrip = this.MenuDeleteFour;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvProvider.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvProvider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvProvider.GridColor = System.Drawing.Color.White;
            this.DgvProvider.Location = new System.Drawing.Point(0, 215);
            this.DgvProvider.Margin = new System.Windows.Forms.Padding(5);
            this.DgvProvider.Name = "DgvProvider";
            this.DgvProvider.ReadOnly = true;
            this.DgvProvider.RowHeadersWidth = 51;
            this.DgvProvider.RowTemplate.ReadOnly = true;
            this.DgvProvider.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProvider.Size = new System.Drawing.Size(1869, 751);
            this.DgvProvider.TabIndex = 5;
            this.DgvProvider.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvProvider_CellMouseUp);
            this.DgvProvider.DoubleClick += new System.EventHandler(this.DgvProvider_DoubleClick);
            // 
            // CODE_FOUR
            // 
            this.CODE_FOUR.DataPropertyName = "CODE_FOUR";
            this.CODE_FOUR.HeaderText = "Code";
            this.CODE_FOUR.MinimumWidth = 6;
            this.CODE_FOUR.Name = "CODE_FOUR";
            this.CODE_FOUR.ReadOnly = true;
            this.CODE_FOUR.Width = 50;
            // 
            // DESCRIPTION_FOUR
            // 
            this.DESCRIPTION_FOUR.DataPropertyName = "DESCRIPTION_FOUR";
            this.DESCRIPTION_FOUR.HeaderText = "Description";
            this.DESCRIPTION_FOUR.MinimumWidth = 6;
            this.DESCRIPTION_FOUR.Name = "DESCRIPTION_FOUR";
            this.DESCRIPTION_FOUR.ReadOnly = true;
            this.DESCRIPTION_FOUR.Width = 200;
            // 
            // TEL_FOUR
            // 
            this.TEL_FOUR.DataPropertyName = "TEL_FOUR";
            this.TEL_FOUR.HeaderText = "Telephone";
            this.TEL_FOUR.MinimumWidth = 6;
            this.TEL_FOUR.Name = "TEL_FOUR";
            this.TEL_FOUR.ReadOnly = true;
            this.TEL_FOUR.Width = 125;
            // 
            // MAIL_FOUR
            // 
            this.MAIL_FOUR.DataPropertyName = "MAIL_FOUR";
            this.MAIL_FOUR.HeaderText = "Mail";
            this.MAIL_FOUR.MinimumWidth = 6;
            this.MAIL_FOUR.Name = "MAIL_FOUR";
            this.MAIL_FOUR.ReadOnly = true;
            this.MAIL_FOUR.Width = 125;
            // 
            // NOTE_FOUR
            // 
            this.NOTE_FOUR.DataPropertyName = "NOTE_FOUR";
            this.NOTE_FOUR.HeaderText = "Note";
            this.NOTE_FOUR.MinimumWidth = 6;
            this.NOTE_FOUR.Name = "NOTE_FOUR";
            this.NOTE_FOUR.ReadOnly = true;
            this.NOTE_FOUR.Width = 125;
            // 
            // REGICOM_FOUR
            // 
            this.REGICOM_FOUR.DataPropertyName = "REGICOM_FOUR";
            this.REGICOM_FOUR.HeaderText = "Regis com.";
            this.REGICOM_FOUR.MinimumWidth = 6;
            this.REGICOM_FOUR.Name = "REGICOM_FOUR";
            this.REGICOM_FOUR.ReadOnly = true;
            this.REGICOM_FOUR.Width = 125;
            // 
            // CPTCONTRIB_FOUR
            // 
            this.CPTCONTRIB_FOUR.DataPropertyName = "CPTCONTRIB_FOUR";
            this.CPTCONTRIB_FOUR.HeaderText = "Compte contrib.";
            this.CPTCONTRIB_FOUR.MinimumWidth = 6;
            this.CPTCONTRIB_FOUR.Name = "CPTCONTRIB_FOUR";
            this.CPTCONTRIB_FOUR.ReadOnly = true;
            this.CPTCONTRIB_FOUR.Width = 200;
            // 
            // PAYS_FOUR
            // 
            this.PAYS_FOUR.DataPropertyName = "PAYS_FOUR";
            this.PAYS_FOUR.HeaderText = "Pays";
            this.PAYS_FOUR.MinimumWidth = 6;
            this.PAYS_FOUR.Name = "PAYS_FOUR";
            this.PAYS_FOUR.ReadOnly = true;
            this.PAYS_FOUR.Width = 125;
            // 
            // VILLE_FOUR
            // 
            this.VILLE_FOUR.DataPropertyName = "VILLE_FOUR";
            this.VILLE_FOUR.HeaderText = "Ville";
            this.VILLE_FOUR.MinimumWidth = 6;
            this.VILLE_FOUR.Name = "VILLE_FOUR";
            this.VILLE_FOUR.ReadOnly = true;
            this.VILLE_FOUR.Width = 125;
            // 
            // ADRESSE_FOUR
            // 
            this.ADRESSE_FOUR.DataPropertyName = "ADRESSE_FOUR";
            this.ADRESSE_FOUR.HeaderText = "Adresse";
            this.ADRESSE_FOUR.MinimumWidth = 6;
            this.ADRESSE_FOUR.Name = "ADRESSE_FOUR";
            this.ADRESSE_FOUR.ReadOnly = true;
            this.ADRESSE_FOUR.Width = 125;
            // 
            // CODEPOSTA_FOUR
            // 
            this.CODEPOSTA_FOUR.DataPropertyName = "CODEPOSTA_FOUR";
            this.CODEPOSTA_FOUR.HeaderText = "Code post.";
            this.CODEPOSTA_FOUR.MinimumWidth = 6;
            this.CODEPOSTA_FOUR.Name = "CODEPOSTA_FOUR";
            this.CODEPOSTA_FOUR.ReadOnly = true;
            this.CODEPOSTA_FOUR.Width = 125;
            // 
            // DATE_FOUR
            // 
            this.DATE_FOUR.DataPropertyName = "DATE_FOUR";
            this.DATE_FOUR.HeaderText = "Date enr.";
            this.DATE_FOUR.MinimumWidth = 6;
            this.DATE_FOUR.Name = "DATE_FOUR";
            this.DATE_FOUR.ReadOnly = true;
            this.DATE_FOUR.Width = 125;
            // 
            // AUTREINFO_FOUR
            // 
            this.AUTREINFO_FOUR.DataPropertyName = "AUTREINFO_FOUR";
            this.AUTREINFO_FOUR.HeaderText = "Note 1";
            this.AUTREINFO_FOUR.MinimumWidth = 6;
            this.AUTREINFO_FOUR.Name = "AUTREINFO_FOUR";
            this.AUTREINFO_FOUR.ReadOnly = true;
            this.AUTREINFO_FOUR.Width = 200;
            // 
            // USERCREATE_FOUR
            // 
            this.USERCREATE_FOUR.DataPropertyName = "USERCREATE_FOUR";
            this.USERCREATE_FOUR.HeaderText = "Créer par";
            this.USERCREATE_FOUR.MinimumWidth = 6;
            this.USERCREATE_FOUR.Name = "USERCREATE_FOUR";
            this.USERCREATE_FOUR.ReadOnly = true;
            this.USERCREATE_FOUR.Width = 125;
            // 
            // DATECREATION_FOUR
            // 
            this.DATECREATION_FOUR.DataPropertyName = "DATECREATION_FOUR";
            this.DATECREATION_FOUR.HeaderText = "Créer le";
            this.DATECREATION_FOUR.MinimumWidth = 6;
            this.DATECREATION_FOUR.Name = "DATECREATION_FOUR";
            this.DATECREATION_FOUR.ReadOnly = true;
            this.DATECREATION_FOUR.Width = 125;
            // 
            // iconBtnSearchFourn
            // 
            this.iconBtnSearchFourn.BackColor = System.Drawing.Color.White;
            this.iconBtnSearchFourn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnSearchFourn.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconBtnSearchFourn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.iconBtnSearchFourn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnSearchFourn.IconSize = 25;
            this.iconBtnSearchFourn.Location = new System.Drawing.Point(1011, 85);
            this.iconBtnSearchFourn.Margin = new System.Windows.Forms.Padding(5);
            this.iconBtnSearchFourn.Name = "iconBtnSearchFourn";
            this.iconBtnSearchFourn.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.iconBtnSearchFourn.Size = new System.Drawing.Size(29, 30);
            this.iconBtnSearchFourn.TabIndex = 1;
            this.iconBtnSearchFourn.UseVisualStyleBackColor = false;
            this.iconBtnSearchFourn.Click += new System.EventHandler(this.iconBtnSearchFourn_Click);
            // 
            // BtnImportFourn
            // 
            this.BtnImportFourn.BackColor = System.Drawing.Color.White;
            this.BtnImportFourn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImportFourn.ForeColor = System.Drawing.Color.Black;
            this.BtnImportFourn.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.BtnImportFourn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(147)))), ((int)(((byte)(222)))));
            this.BtnImportFourn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnImportFourn.IconSize = 20;
            this.BtnImportFourn.Location = new System.Drawing.Point(197, -2);
            this.BtnImportFourn.Margin = new System.Windows.Forms.Padding(5);
            this.BtnImportFourn.Name = "BtnImportFourn";
            this.BtnImportFourn.Size = new System.Drawing.Size(101, 26);
            this.BtnImportFourn.TabIndex = 4;
            this.BtnImportFourn.Text = "Impoter";
            this.BtnImportFourn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnImportFourn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnImportFourn.UseVisualStyleBackColor = false;
            this.BtnImportFourn.Click += new System.EventHandler(this.BtnImportFourn_Click);
            this.BtnImportFourn.MouseHover += new System.EventHandler(this.BtnImportFourn_MouseHover);
            // 
            // BtnExportFourn
            // 
            this.BtnExportFourn.BackColor = System.Drawing.Color.White;
            this.BtnExportFourn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExportFourn.ForeColor = System.Drawing.Color.Black;
            this.BtnExportFourn.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromFile;
            this.BtnExportFourn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(13)))));
            this.BtnExportFourn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnExportFourn.IconSize = 20;
            this.BtnExportFourn.Location = new System.Drawing.Point(89, 0);
            this.BtnExportFourn.Margin = new System.Windows.Forms.Padding(5);
            this.BtnExportFourn.Name = "BtnExportFourn";
            this.BtnExportFourn.Size = new System.Drawing.Size(107, 24);
            this.BtnExportFourn.TabIndex = 3;
            this.BtnExportFourn.Text = "Exporter";
            this.BtnExportFourn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExportFourn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExportFourn.UseVisualStyleBackColor = false;
            this.BtnExportFourn.Click += new System.EventHandler(this.BtnExportFourn_Click);
            this.BtnExportFourn.MouseHover += new System.EventHandler(this.BtnExportFourn_MouseHover);
            // 
            // iconBtnCloseFormMainFour
            // 
            this.iconBtnCloseFormMainFour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnCloseFormMainFour.BackColor = System.Drawing.Color.White;
            this.iconBtnCloseFormMainFour.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.iconBtnCloseFormMainFour.IconColor = System.Drawing.Color.Red;
            this.iconBtnCloseFormMainFour.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnCloseFormMainFour.IconSize = 20;
            this.iconBtnCloseFormMainFour.Location = new System.Drawing.Point(1840, -2);
            this.iconBtnCloseFormMainFour.Margin = new System.Windows.Forms.Padding(5);
            this.iconBtnCloseFormMainFour.Name = "iconBtnCloseFormMainFour";
            this.iconBtnCloseFormMainFour.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.iconBtnCloseFormMainFour.Size = new System.Drawing.Size(29, 26);
            this.iconBtnCloseFormMainFour.TabIndex = 2;
            this.iconBtnCloseFormMainFour.UseVisualStyleBackColor = false;
            this.iconBtnCloseFormMainFour.Click += new System.EventHandler(this.iconBtnCloseFormMainFour_Click);
            // 
            // iconBtnCreateFourn
            // 
            this.iconBtnCreateFourn.BackColor = System.Drawing.Color.White;
            this.iconBtnCreateFourn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnCreateFourn.ForeColor = System.Drawing.Color.Black;
            this.iconBtnCreateFourn.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconBtnCreateFourn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.iconBtnCreateFourn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnCreateFourn.IconSize = 20;
            this.iconBtnCreateFourn.Location = new System.Drawing.Point(-4, -2);
            this.iconBtnCreateFourn.Margin = new System.Windows.Forms.Padding(5);
            this.iconBtnCreateFourn.Name = "iconBtnCreateFourn";
            this.iconBtnCreateFourn.Size = new System.Drawing.Size(92, 26);
            this.iconBtnCreateFourn.TabIndex = 1;
            this.iconBtnCreateFourn.Text = "Saisir";
            this.iconBtnCreateFourn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnCreateFourn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnCreateFourn.UseVisualStyleBackColor = false;
            this.iconBtnCreateFourn.Click += new System.EventHandler(this.iconBtnCreateFourn_Click);
            this.iconBtnCreateFourn.MouseHover += new System.EventHandler(this.iconBtnCreateFourn_MouseHover);
            // 
            // MenuDeleteFour
            // 
            this.MenuDeleteFour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.MenuDeleteFour.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuDeleteFour.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemMenuDeleteFour});
            this.MenuDeleteFour.Name = "MenuDeleteFour";
            this.MenuDeleteFour.Size = new System.Drawing.Size(215, 58);
            // 
            // ItemMenuDeleteFour
            // 
            this.ItemMenuDeleteFour.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemMenuDeleteFour.Image = ((System.Drawing.Image)(resources.GetObject("ItemMenuDeleteFour.Image")));
            this.ItemMenuDeleteFour.Name = "ItemMenuDeleteFour";
            this.ItemMenuDeleteFour.Size = new System.Drawing.Size(214, 26);
            this.ItemMenuDeleteFour.Text = "Supprimer";
            this.ItemMenuDeleteFour.Click += new System.EventHandler(this.ItemMenuDeleteFour_Click);
            // 
            // FormMainFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1869, 966);
            this.Controls.Add(this.DgvProvider);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PanelTitleFour);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormMainFournisseur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMainFournisseur";
            this.PanelTitleFour.ResumeLayout(false);
            this.PanelTitleFour.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProvider)).EndInit();
            this.MenuDeleteFour.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton iconBtnCreateFourn;
        private FontAwesome.Sharp.IconButton iconBtnSearchFourn;
        private System.Windows.Forms.TextBox textBoxRecheFour;
        private System.Windows.Forms.Panel PanelTitleFour;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconBtnCloseFormMainFour;
        private FontAwesome.Sharp.IconButton BtnImportFourn;
        private FontAwesome.Sharp.IconButton BtnExportFourn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView DgvProvider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_FOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_FOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEL_FOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAIL_FOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTE_FOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn REGICOM_FOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPTCONTRIB_FOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAYS_FOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn VILLE_FOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADRESSE_FOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODEPOSTA_FOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_FOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn AUTREINFO_FOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERCREATE_FOUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATECREATION_FOUR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip MenuDeleteFour;
        private System.Windows.Forms.ToolStripMenuItem ItemMenuDeleteFour;
    }
}