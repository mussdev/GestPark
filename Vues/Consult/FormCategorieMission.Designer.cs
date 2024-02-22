namespace GestPark.Vues.Consult
{
    partial class FormCategorieMission
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategorieMission));
            this.panelMarqueTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRegisterMarq = new System.Windows.Forms.Panel();
            this.CbxCategProfFonct = new System.Windows.Forms.ComboBox();
            this.TxtMontant = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CbxType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CbxPaysContinent = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdCategMiss = new System.Windows.Forms.TextBox();
            this.RTxtNoteType = new System.Windows.Forms.RichTextBox();
            this.TxtCodCateg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFilterCateg = new System.Windows.Forms.TextBox();
            this.TotalCateg = new System.Windows.Forms.Label();
            this.dgvCategMission = new System.Windows.Forms.DataGridView();
            this.ID_CATEG_MISS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE_CATEG_MISS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_CATEG_MISS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TYPE_CATEG_MISS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAYS_CONTICATEG_MISS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONTANT_CATEG_MISS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTE_CATEG_MISS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERCREATE_DIR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATECREATE_CATEG_MISS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATEMODIFIER_CATEG_MISS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuDeleteCateg = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditCategMission = new FontAwesome.Sharp.IconButton();
            this.btnValiderCategMission = new FontAwesome.Sharp.IconButton();
            this.BtnAnnulerCategMission = new FontAwesome.Sharp.IconButton();
            this.btnRafraichirDir = new FontAwesome.Sharp.IconButton();
            this.BtnExportDirection = new FontAwesome.Sharp.IconButton();
            this.BtnImportDirec = new FontAwesome.Sharp.IconButton();
            this.BtnCloseFormCategMission = new FontAwesome.Sharp.IconButton();
            this.panelMarqueTitle.SuspendLayout();
            this.panelRegisterMarq.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategMission)).BeginInit();
            this.MenuDeleteCateg.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMarqueTitle
            // 
            this.panelMarqueTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.panelMarqueTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMarqueTitle.Controls.Add(this.btnRafraichirDir);
            this.panelMarqueTitle.Controls.Add(this.BtnExportDirection);
            this.panelMarqueTitle.Controls.Add(this.label1);
            this.panelMarqueTitle.Controls.Add(this.BtnImportDirec);
            this.panelMarqueTitle.Controls.Add(this.BtnCloseFormCategMission);
            this.panelMarqueTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMarqueTitle.Location = new System.Drawing.Point(0, 0);
            this.panelMarqueTitle.Margin = new System.Windows.Forms.Padding(4);
            this.panelMarqueTitle.Name = "panelMarqueTitle";
            this.panelMarqueTitle.Size = new System.Drawing.Size(1217, 25);
            this.panelMarqueTitle.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(672, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Catégorie de mission";
            // 
            // panelRegisterMarq
            // 
            this.panelRegisterMarq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.panelRegisterMarq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelRegisterMarq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRegisterMarq.Controls.Add(this.CbxCategProfFonct);
            this.panelRegisterMarq.Controls.Add(this.TxtMontant);
            this.panelRegisterMarq.Controls.Add(this.label7);
            this.panelRegisterMarq.Controls.Add(this.CbxType);
            this.panelRegisterMarq.Controls.Add(this.label6);
            this.panelRegisterMarq.Controls.Add(this.CbxPaysContinent);
            this.panelRegisterMarq.Controls.Add(this.label5);
            this.panelRegisterMarq.Controls.Add(this.txtIdCategMiss);
            this.panelRegisterMarq.Controls.Add(this.btnEditCategMission);
            this.panelRegisterMarq.Controls.Add(this.btnValiderCategMission);
            this.panelRegisterMarq.Controls.Add(this.BtnAnnulerCategMission);
            this.panelRegisterMarq.Controls.Add(this.RTxtNoteType);
            this.panelRegisterMarq.Controls.Add(this.TxtCodCateg);
            this.panelRegisterMarq.Controls.Add(this.label4);
            this.panelRegisterMarq.Controls.Add(this.label3);
            this.panelRegisterMarq.Controls.Add(this.label2);
            this.panelRegisterMarq.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRegisterMarq.ForeColor = System.Drawing.Color.Black;
            this.panelRegisterMarq.Location = new System.Drawing.Point(0, 25);
            this.panelRegisterMarq.Margin = new System.Windows.Forms.Padding(4);
            this.panelRegisterMarq.Name = "panelRegisterMarq";
            this.panelRegisterMarq.Size = new System.Drawing.Size(430, 741);
            this.panelRegisterMarq.TabIndex = 5;
            // 
            // CbxCategProfFonct
            // 
            this.CbxCategProfFonct.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxCategProfFonct.ForeColor = System.Drawing.Color.Black;
            this.CbxCategProfFonct.FormattingEnabled = true;
            this.CbxCategProfFonct.Items.AddRange(new object[] {
            "",
            "",
            "PCA",
            "DG",
            "DGA",
            "Administrateur",
            "Chef de Service et assimilié",
            "Autre Cadre",
            "Agent de maîtrise",
            "Employé"});
            this.CbxCategProfFonct.Location = new System.Drawing.Point(157, 129);
            this.CbxCategProfFonct.Name = "CbxCategProfFonct";
            this.CbxCategProfFonct.Size = new System.Drawing.Size(263, 27);
            this.CbxCategProfFonct.TabIndex = 17;
            // 
            // TxtMontant
            // 
            this.TxtMontant.BackColor = System.Drawing.Color.White;
            this.TxtMontant.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMontant.Location = new System.Drawing.Point(157, 314);
            this.TxtMontant.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMontant.Name = "TxtMontant";
            this.TxtMontant.Size = new System.Drawing.Size(263, 29);
            this.TxtMontant.TabIndex = 16;
            this.TxtMontant.Text = "0";
            this.TxtMontant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(7, 322);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Montant * :";
            // 
            // CbxType
            // 
            this.CbxType.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxType.ForeColor = System.Drawing.Color.Black;
            this.CbxType.FormattingEnabled = true;
            this.CbxType.Items.AddRange(new object[] {
            "",
            "Nuitée",
            "Sans nuitée"});
            this.CbxType.Location = new System.Drawing.Point(157, 190);
            this.CbxType.Name = "CbxType";
            this.CbxType.Size = new System.Drawing.Size(263, 27);
            this.CbxType.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(7, 190);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Type * :";
            // 
            // CbxPaysContinent
            // 
            this.CbxPaysContinent.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxPaysContinent.ForeColor = System.Drawing.Color.Black;
            this.CbxPaysContinent.FormattingEnabled = true;
            this.CbxPaysContinent.Items.AddRange(new object[] {
            "",
            "Côte d\'ivoire",
            "Autres Afrique",
            "Afrique du Nord",
            "Afrique du Sud",
            "Afrique Australe",
            "Afrique de l\'Est",
            "Europe",
            "Amerique",
            "Asie"});
            this.CbxPaysContinent.Location = new System.Drawing.Point(157, 254);
            this.CbxPaysContinent.Name = "CbxPaysContinent";
            this.CbxPaysContinent.Size = new System.Drawing.Size(263, 27);
            this.CbxPaysContinent.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(4, 257);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Pays/Continent * :";
            // 
            // txtIdCategMiss
            // 
            this.txtIdCategMiss.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCategMiss.ForeColor = System.Drawing.Color.Black;
            this.txtIdCategMiss.Location = new System.Drawing.Point(157, 8);
            this.txtIdCategMiss.Name = "txtIdCategMiss";
            this.txtIdCategMiss.Size = new System.Drawing.Size(127, 27);
            this.txtIdCategMiss.TabIndex = 10;
            this.txtIdCategMiss.Visible = false;
            // 
            // RTxtNoteType
            // 
            this.RTxtNoteType.BackColor = System.Drawing.Color.White;
            this.RTxtNoteType.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTxtNoteType.Location = new System.Drawing.Point(157, 383);
            this.RTxtNoteType.Margin = new System.Windows.Forms.Padding(4);
            this.RTxtNoteType.Name = "RTxtNoteType";
            this.RTxtNoteType.Size = new System.Drawing.Size(265, 82);
            this.RTxtNoteType.TabIndex = 5;
            this.RTxtNoteType.Text = "";
            // 
            // TxtCodCateg
            // 
            this.TxtCodCateg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.TxtCodCateg.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodCateg.ForeColor = System.Drawing.Color.Black;
            this.TxtCodCateg.Location = new System.Drawing.Point(157, 51);
            this.TxtCodCateg.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCodCateg.Name = "TxtCodCateg";
            this.TxtCodCateg.ReadOnly = true;
            this.TxtCodCateg.Size = new System.Drawing.Size(127, 28);
            this.TxtCodCateg.TabIndex = 3;
            this.TxtCodCateg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(7, 386);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Note :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(5, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Description * :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(4, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Code * :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtFilterCateg);
            this.panel1.Controls.Add(this.TotalCateg);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(430, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 29);
            this.panel1.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(443, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 19);
            this.label10.TabIndex = 20;
            this.label10.Text = "Filtrer";
            // 
            // txtFilterCateg
            // 
            this.txtFilterCateg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterCateg.BackColor = System.Drawing.Color.White;
            this.txtFilterCateg.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterCateg.ForeColor = System.Drawing.Color.Black;
            this.txtFilterCateg.Location = new System.Drawing.Point(511, 1);
            this.txtFilterCateg.Name = "txtFilterCateg";
            this.txtFilterCateg.Size = new System.Drawing.Size(276, 27);
            this.txtFilterCateg.TabIndex = 19;
            this.txtFilterCateg.TextChanged += new System.EventHandler(this.txtFilterCateg_TextChanged);
            // 
            // TotalCateg
            // 
            this.TotalCateg.AutoSize = true;
            this.TotalCateg.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCateg.ForeColor = System.Drawing.Color.Maroon;
            this.TotalCateg.Location = new System.Drawing.Point(4, 10);
            this.TotalCateg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalCateg.Name = "TotalCateg";
            this.TotalCateg.Size = new System.Drawing.Size(135, 17);
            this.TotalCateg.TabIndex = 0;
            this.TotalCateg.Text = "Total Catégorie = 0";
            // 
            // dgvCategMission
            // 
            this.dgvCategMission.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvCategMission.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategMission.BackgroundColor = System.Drawing.Color.White;
            this.dgvCategMission.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategMission.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCategMission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategMission.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_CATEG_MISS,
            this.CODE_CATEG_MISS,
            this.DESCRIPTION_CATEG_MISS,
            this.TYPE_CATEG_MISS,
            this.PAYS_CONTICATEG_MISS,
            this.MONTANT_CATEG_MISS,
            this.NOTE_CATEG_MISS,
            this.USERCREATE_DIR,
            this.DATECREATE_CATEG_MISS,
            this.DATEMODIFIER_CATEG_MISS});
            this.dgvCategMission.ContextMenuStrip = this.MenuDeleteCateg;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategMission.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCategMission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategMission.GridColor = System.Drawing.Color.White;
            this.dgvCategMission.Location = new System.Drawing.Point(430, 54);
            this.dgvCategMission.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCategMission.Name = "dgvCategMission";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategMission.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCategMission.RowHeadersWidth = 51;
            this.dgvCategMission.Size = new System.Drawing.Size(787, 712);
            this.dgvCategMission.TabIndex = 7;
            this.dgvCategMission.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategMission_CellClick);
            this.dgvCategMission.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCategMission_CellMouseUp);
            // 
            // ID_CATEG_MISS
            // 
            this.ID_CATEG_MISS.DataPropertyName = "ID_CATEG_MISS";
            this.ID_CATEG_MISS.HeaderText = "IdCategMission";
            this.ID_CATEG_MISS.MinimumWidth = 6;
            this.ID_CATEG_MISS.Name = "ID_CATEG_MISS";
            this.ID_CATEG_MISS.ReadOnly = true;
            this.ID_CATEG_MISS.Visible = false;
            this.ID_CATEG_MISS.Width = 125;
            // 
            // CODE_CATEG_MISS
            // 
            this.CODE_CATEG_MISS.DataPropertyName = "CODE_CATEG_MISS";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CODE_CATEG_MISS.DefaultCellStyle = dataGridViewCellStyle3;
            this.CODE_CATEG_MISS.HeaderText = "Code";
            this.CODE_CATEG_MISS.MinimumWidth = 6;
            this.CODE_CATEG_MISS.Name = "CODE_CATEG_MISS";
            this.CODE_CATEG_MISS.Width = 80;
            // 
            // DESCRIPTION_CATEG_MISS
            // 
            this.DESCRIPTION_CATEG_MISS.DataPropertyName = "DESCRIPTION_CATEG_MISS";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DESCRIPTION_CATEG_MISS.DefaultCellStyle = dataGridViewCellStyle4;
            this.DESCRIPTION_CATEG_MISS.HeaderText = "Description";
            this.DESCRIPTION_CATEG_MISS.MinimumWidth = 6;
            this.DESCRIPTION_CATEG_MISS.Name = "DESCRIPTION_CATEG_MISS";
            this.DESCRIPTION_CATEG_MISS.Width = 200;
            // 
            // TYPE_CATEG_MISS
            // 
            this.TYPE_CATEG_MISS.DataPropertyName = "TYPE_CATEG_MISS";
            this.TYPE_CATEG_MISS.HeaderText = "Type";
            this.TYPE_CATEG_MISS.MinimumWidth = 6;
            this.TYPE_CATEG_MISS.Name = "TYPE_CATEG_MISS";
            this.TYPE_CATEG_MISS.ReadOnly = true;
            this.TYPE_CATEG_MISS.Width = 150;
            // 
            // PAYS_CONTICATEG_MISS
            // 
            this.PAYS_CONTICATEG_MISS.DataPropertyName = "PAYS_CONTICATEG_MISS";
            this.PAYS_CONTICATEG_MISS.HeaderText = "PaysContinent";
            this.PAYS_CONTICATEG_MISS.MinimumWidth = 6;
            this.PAYS_CONTICATEG_MISS.Name = "PAYS_CONTICATEG_MISS";
            this.PAYS_CONTICATEG_MISS.ReadOnly = true;
            this.PAYS_CONTICATEG_MISS.Width = 150;
            // 
            // MONTANT_CATEG_MISS
            // 
            this.MONTANT_CATEG_MISS.DataPropertyName = "MONTANT_CATEG_MISS";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.MONTANT_CATEG_MISS.DefaultCellStyle = dataGridViewCellStyle5;
            this.MONTANT_CATEG_MISS.HeaderText = "Montant";
            this.MONTANT_CATEG_MISS.MinimumWidth = 6;
            this.MONTANT_CATEG_MISS.Name = "MONTANT_CATEG_MISS";
            this.MONTANT_CATEG_MISS.ReadOnly = true;
            this.MONTANT_CATEG_MISS.Width = 150;
            // 
            // NOTE_CATEG_MISS
            // 
            this.NOTE_CATEG_MISS.DataPropertyName = "NOTE_CATEG_MISS";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.NOTE_CATEG_MISS.DefaultCellStyle = dataGridViewCellStyle6;
            this.NOTE_CATEG_MISS.HeaderText = "Note";
            this.NOTE_CATEG_MISS.MinimumWidth = 6;
            this.NOTE_CATEG_MISS.Name = "NOTE_CATEG_MISS";
            this.NOTE_CATEG_MISS.Width = 250;
            // 
            // USERCREATE_DIR
            // 
            this.USERCREATE_DIR.DataPropertyName = "USERCREATE_DIR";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.USERCREATE_DIR.DefaultCellStyle = dataGridViewCellStyle7;
            this.USERCREATE_DIR.HeaderText = "Créer par";
            this.USERCREATE_DIR.MinimumWidth = 6;
            this.USERCREATE_DIR.Name = "USERCREATE_DIR";
            this.USERCREATE_DIR.Width = 150;
            // 
            // DATECREATE_CATEG_MISS
            // 
            this.DATECREATE_CATEG_MISS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DATECREATE_CATEG_MISS.DataPropertyName = "DATECREATE_CATEG_MISS";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DATECREATE_CATEG_MISS.DefaultCellStyle = dataGridViewCellStyle8;
            this.DATECREATE_CATEG_MISS.HeaderText = "Créer le";
            this.DATECREATE_CATEG_MISS.MinimumWidth = 125;
            this.DATECREATE_CATEG_MISS.Name = "DATECREATE_CATEG_MISS";
            // 
            // DATEMODIFIER_CATEG_MISS
            // 
            this.DATEMODIFIER_CATEG_MISS.DataPropertyName = "DATEMODIFIER_CATEG_MISS";
            this.DATEMODIFIER_CATEG_MISS.HeaderText = "Modifier le";
            this.DATEMODIFIER_CATEG_MISS.MinimumWidth = 6;
            this.DATEMODIFIER_CATEG_MISS.Name = "DATEMODIFIER_CATEG_MISS";
            this.DATEMODIFIER_CATEG_MISS.ReadOnly = true;
            this.DATEMODIFIER_CATEG_MISS.Width = 150;
            // 
            // MenuDeleteCateg
            // 
            this.MenuDeleteCateg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.MenuDeleteCateg.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuDeleteCateg.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuDeleteCateg.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supprimerToolStripMenuItem});
            this.MenuDeleteCateg.Name = "MenuDeleteCateg";
            this.MenuDeleteCateg.Size = new System.Drawing.Size(154, 30);
            this.MenuDeleteCateg.Click += new System.EventHandler(this.MenuDeleteCateg_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.supprimerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("supprimerToolStripMenuItem.Image")));
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            // 
            // btnEditCategMission
            // 
            this.btnEditCategMission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnEditCategMission.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCategMission.ForeColor = System.Drawing.Color.Black;
            this.btnEditCategMission.IconChar = FontAwesome.Sharp.IconChar.PencilSquare;
            this.btnEditCategMission.IconColor = System.Drawing.Color.White;
            this.btnEditCategMission.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditCategMission.IconSize = 20;
            this.btnEditCategMission.Location = new System.Drawing.Point(204, 510);
            this.btnEditCategMission.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditCategMission.Name = "btnEditCategMission";
            this.btnEditCategMission.Size = new System.Drawing.Size(84, 28);
            this.btnEditCategMission.TabIndex = 9;
            this.btnEditCategMission.Text = "Editer";
            this.btnEditCategMission.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditCategMission.UseVisualStyleBackColor = false;
            this.btnEditCategMission.Click += new System.EventHandler(this.btnEditCategMission_Click);
            // 
            // btnValiderCategMission
            // 
            this.btnValiderCategMission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnValiderCategMission.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValiderCategMission.ForeColor = System.Drawing.Color.Black;
            this.btnValiderCategMission.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
            this.btnValiderCategMission.IconColor = System.Drawing.Color.White;
            this.btnValiderCategMission.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnValiderCategMission.IconSize = 20;
            this.btnValiderCategMission.Location = new System.Drawing.Point(109, 510);
            this.btnValiderCategMission.Margin = new System.Windows.Forms.Padding(4);
            this.btnValiderCategMission.Name = "btnValiderCategMission";
            this.btnValiderCategMission.Size = new System.Drawing.Size(87, 28);
            this.btnValiderCategMission.TabIndex = 8;
            this.btnValiderCategMission.Text = "Valider";
            this.btnValiderCategMission.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnValiderCategMission.UseVisualStyleBackColor = false;
            this.btnValiderCategMission.Click += new System.EventHandler(this.btnValiderCategMission_Click);
            // 
            // BtnAnnulerCategMission
            // 
            this.BtnAnnulerCategMission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.BtnAnnulerCategMission.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnnulerCategMission.ForeColor = System.Drawing.Color.Black;
            this.BtnAnnulerCategMission.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.BtnAnnulerCategMission.IconColor = System.Drawing.Color.White;
            this.BtnAnnulerCategMission.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAnnulerCategMission.IconSize = 20;
            this.BtnAnnulerCategMission.Location = new System.Drawing.Point(296, 510);
            this.BtnAnnulerCategMission.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAnnulerCategMission.Name = "BtnAnnulerCategMission";
            this.BtnAnnulerCategMission.Size = new System.Drawing.Size(91, 28);
            this.BtnAnnulerCategMission.TabIndex = 7;
            this.BtnAnnulerCategMission.Text = "Annuler";
            this.BtnAnnulerCategMission.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAnnulerCategMission.UseVisualStyleBackColor = false;
            // 
            // btnRafraichirDir
            // 
            this.btnRafraichirDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnRafraichirDir.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRafraichirDir.ForeColor = System.Drawing.Color.Black;
            this.btnRafraichirDir.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.btnRafraichirDir.IconColor = System.Drawing.Color.White;
            this.btnRafraichirDir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRafraichirDir.IconSize = 20;
            this.btnRafraichirDir.Location = new System.Drawing.Point(195, -2);
            this.btnRafraichirDir.Margin = new System.Windows.Forms.Padding(4);
            this.btnRafraichirDir.Name = "btnRafraichirDir";
            this.btnRafraichirDir.Size = new System.Drawing.Size(109, 25);
            this.btnRafraichirDir.TabIndex = 14;
            this.btnRafraichirDir.Text = "Rafraîchir";
            this.btnRafraichirDir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRafraichirDir.UseVisualStyleBackColor = false;
            this.btnRafraichirDir.Click += new System.EventHandler(this.btnRafraichirDir_Click);
            // 
            // BtnExportDirection
            // 
            this.BtnExportDirection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.BtnExportDirection.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExportDirection.ForeColor = System.Drawing.Color.Black;
            this.BtnExportDirection.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromFile;
            this.BtnExportDirection.IconColor = System.Drawing.Color.White;
            this.BtnExportDirection.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnExportDirection.IconSize = 20;
            this.BtnExportDirection.Location = new System.Drawing.Point(97, -2);
            this.BtnExportDirection.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExportDirection.Name = "BtnExportDirection";
            this.BtnExportDirection.Size = new System.Drawing.Size(97, 25);
            this.BtnExportDirection.TabIndex = 11;
            this.BtnExportDirection.Text = "Exporter";
            this.BtnExportDirection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExportDirection.UseVisualStyleBackColor = false;
            // 
            // BtnImportDirec
            // 
            this.BtnImportDirec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.BtnImportDirec.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImportDirec.ForeColor = System.Drawing.Color.Black;
            this.BtnImportDirec.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.BtnImportDirec.IconColor = System.Drawing.Color.White;
            this.BtnImportDirec.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnImportDirec.IconSize = 20;
            this.BtnImportDirec.Location = new System.Drawing.Point(-2, -2);
            this.BtnImportDirec.Margin = new System.Windows.Forms.Padding(4);
            this.BtnImportDirec.Name = "BtnImportDirec";
            this.BtnImportDirec.Size = new System.Drawing.Size(97, 25);
            this.BtnImportDirec.TabIndex = 10;
            this.BtnImportDirec.Text = "Importer";
            this.BtnImportDirec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnImportDirec.UseVisualStyleBackColor = false;
            // 
            // BtnCloseFormCategMission
            // 
            this.BtnCloseFormCategMission.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnCloseFormCategMission.BackColor = System.Drawing.Color.White;
            this.BtnCloseFormCategMission.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCloseFormCategMission.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.BtnCloseFormCategMission.IconColor = System.Drawing.Color.Red;
            this.BtnCloseFormCategMission.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCloseFormCategMission.IconSize = 20;
            this.BtnCloseFormCategMission.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCloseFormCategMission.Location = new System.Drawing.Point(1185, -2);
            this.BtnCloseFormCategMission.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCloseFormCategMission.Name = "BtnCloseFormCategMission";
            this.BtnCloseFormCategMission.Size = new System.Drawing.Size(31, 25);
            this.BtnCloseFormCategMission.TabIndex = 0;
            this.BtnCloseFormCategMission.UseVisualStyleBackColor = false;
            this.BtnCloseFormCategMission.Click += new System.EventHandler(this.BtnCloseFormCategMission_Click);
            // 
            // FormCategorieMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 766);
            this.Controls.Add(this.dgvCategMission);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelRegisterMarq);
            this.Controls.Add(this.panelMarqueTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCategorieMission";
            this.Text = "Catégorie de mission";
            this.panelMarqueTitle.ResumeLayout(false);
            this.panelMarqueTitle.PerformLayout();
            this.panelRegisterMarq.ResumeLayout(false);
            this.panelRegisterMarq.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategMission)).EndInit();
            this.MenuDeleteCateg.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMarqueTitle;
        private FontAwesome.Sharp.IconButton btnRafraichirDir;
        private FontAwesome.Sharp.IconButton BtnExportDirection;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BtnImportDirec;
        private FontAwesome.Sharp.IconButton BtnCloseFormCategMission;
        private System.Windows.Forms.Panel panelRegisterMarq;
        private System.Windows.Forms.TextBox txtIdCategMiss;
        private FontAwesome.Sharp.IconButton btnEditCategMission;
        private FontAwesome.Sharp.IconButton btnValiderCategMission;
        private FontAwesome.Sharp.IconButton BtnAnnulerCategMission;
        private System.Windows.Forms.RichTextBox RTxtNoteType;
        private System.Windows.Forms.TextBox TxtCodCateg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFilterCateg;
        private System.Windows.Forms.Label TotalCateg;
        private System.Windows.Forms.DataGridView dgvCategMission;
        private System.Windows.Forms.TextBox TxtMontant;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CbxType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CbxPaysContinent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbxCategProfFonct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CATEG_MISS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_CATEG_MISS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_CATEG_MISS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TYPE_CATEG_MISS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAYS_CONTICATEG_MISS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTANT_CATEG_MISS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTE_CATEG_MISS;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERCREATE_DIR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATECREATE_CATEG_MISS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATEMODIFIER_CATEG_MISS;
        private System.Windows.Forms.ContextMenuStrip MenuDeleteCateg;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
    }
}