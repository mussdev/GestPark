namespace GestPark.Vues.Consult
{
    partial class FormConducteur
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConducteur));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMarqueTitle = new System.Windows.Forms.Panel();
            this.btnRafraichirConduc = new FontAwesome.Sharp.IconButton();
            this.BtnExportConduc = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnImportConduc = new FontAwesome.Sharp.IconButton();
            this.BtnCloseFormConducteur = new FontAwesome.Sharp.IconButton();
            this.panelRegisterMarq = new System.Windows.Forms.Panel();
            this.txtPermisConduc = new System.Windows.Forms.TextBox();
            this.txtIdConduc = new System.Windows.Forms.TextBox();
            this.btnEditConduc = new FontAwesome.Sharp.IconButton();
            this.btnValiderConduc = new FontAwesome.Sharp.IconButton();
            this.BtnAnnulerConduc = new FontAwesome.Sharp.IconButton();
            this.txtDescriptionConduc = new System.Windows.Forms.TextBox();
            this.TxtCodConduc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFilterConduc = new System.Windows.Forms.TextBox();
            this.txtNbrConduc = new System.Windows.Forms.Label();
            this.dgvConduc = new System.Windows.Forms.DataGridView();
            this.MenuConducteur = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemMenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxDisponibiliteMission = new System.Windows.Forms.CheckBox();
            this.txtNbrMission = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtExpConducteur = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ID_COND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE_COND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_COND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMPERMIS_COND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DISPMISSION_COND = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NBRMISSION_COND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXPERIENCE_COND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERCREATE_COND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATECREATE_COND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATEMODIFY_COND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERMODIFY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMarqueTitle.SuspendLayout();
            this.panelRegisterMarq.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConduc)).BeginInit();
            this.MenuConducteur.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMarqueTitle
            // 
            this.panelMarqueTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.panelMarqueTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMarqueTitle.Controls.Add(this.btnRafraichirConduc);
            this.panelMarqueTitle.Controls.Add(this.BtnExportConduc);
            this.panelMarqueTitle.Controls.Add(this.label1);
            this.panelMarqueTitle.Controls.Add(this.BtnImportConduc);
            this.panelMarqueTitle.Controls.Add(this.BtnCloseFormConducteur);
            this.panelMarqueTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMarqueTitle.Location = new System.Drawing.Point(0, 0);
            this.panelMarqueTitle.Margin = new System.Windows.Forms.Padding(4);
            this.panelMarqueTitle.Name = "panelMarqueTitle";
            this.panelMarqueTitle.Size = new System.Drawing.Size(1344, 25);
            this.panelMarqueTitle.TabIndex = 2;
            // 
            // btnRafraichirConduc
            // 
            this.btnRafraichirConduc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnRafraichirConduc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRafraichirConduc.ForeColor = System.Drawing.Color.Black;
            this.btnRafraichirConduc.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.btnRafraichirConduc.IconColor = System.Drawing.Color.White;
            this.btnRafraichirConduc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRafraichirConduc.IconSize = 20;
            this.btnRafraichirConduc.Location = new System.Drawing.Point(195, -2);
            this.btnRafraichirConduc.Margin = new System.Windows.Forms.Padding(4);
            this.btnRafraichirConduc.Name = "btnRafraichirConduc";
            this.btnRafraichirConduc.Size = new System.Drawing.Size(109, 25);
            this.btnRafraichirConduc.TabIndex = 14;
            this.btnRafraichirConduc.Text = "Rafraîchir";
            this.btnRafraichirConduc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRafraichirConduc.UseVisualStyleBackColor = false;
            this.btnRafraichirConduc.Click += new System.EventHandler(this.btnRafraichirConduc_Click);
            // 
            // BtnExportConduc
            // 
            this.BtnExportConduc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.BtnExportConduc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExportConduc.ForeColor = System.Drawing.Color.Black;
            this.BtnExportConduc.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromFile;
            this.BtnExportConduc.IconColor = System.Drawing.Color.White;
            this.BtnExportConduc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnExportConduc.IconSize = 20;
            this.BtnExportConduc.Location = new System.Drawing.Point(97, -2);
            this.BtnExportConduc.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExportConduc.Name = "BtnExportConduc";
            this.BtnExportConduc.Size = new System.Drawing.Size(97, 25);
            this.BtnExportConduc.TabIndex = 11;
            this.BtnExportConduc.Text = "Exporter";
            this.BtnExportConduc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExportConduc.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(750, -2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Conducteurs";
            // 
            // BtnImportConduc
            // 
            this.BtnImportConduc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.BtnImportConduc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImportConduc.ForeColor = System.Drawing.Color.Black;
            this.BtnImportConduc.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.BtnImportConduc.IconColor = System.Drawing.Color.White;
            this.BtnImportConduc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnImportConduc.IconSize = 20;
            this.BtnImportConduc.Location = new System.Drawing.Point(-2, -2);
            this.BtnImportConduc.Margin = new System.Windows.Forms.Padding(4);
            this.BtnImportConduc.Name = "BtnImportConduc";
            this.BtnImportConduc.Size = new System.Drawing.Size(97, 25);
            this.BtnImportConduc.TabIndex = 10;
            this.BtnImportConduc.Text = "Importer";
            this.BtnImportConduc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnImportConduc.UseVisualStyleBackColor = false;
            // 
            // BtnCloseFormConducteur
            // 
            this.BtnCloseFormConducteur.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnCloseFormConducteur.BackColor = System.Drawing.Color.White;
            this.BtnCloseFormConducteur.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCloseFormConducteur.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.BtnCloseFormConducteur.IconColor = System.Drawing.Color.Red;
            this.BtnCloseFormConducteur.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCloseFormConducteur.IconSize = 20;
            this.BtnCloseFormConducteur.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCloseFormConducteur.Location = new System.Drawing.Point(1312, -2);
            this.BtnCloseFormConducteur.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCloseFormConducteur.Name = "BtnCloseFormConducteur";
            this.BtnCloseFormConducteur.Size = new System.Drawing.Size(31, 25);
            this.BtnCloseFormConducteur.TabIndex = 0;
            this.BtnCloseFormConducteur.UseVisualStyleBackColor = false;
            this.BtnCloseFormConducteur.Click += new System.EventHandler(this.BtnCloseFormConducteur_Click);
            // 
            // panelRegisterMarq
            // 
            this.panelRegisterMarq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.panelRegisterMarq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelRegisterMarq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRegisterMarq.Controls.Add(this.txtExpConducteur);
            this.panelRegisterMarq.Controls.Add(this.label6);
            this.panelRegisterMarq.Controls.Add(this.txtNbrMission);
            this.panelRegisterMarq.Controls.Add(this.label5);
            this.panelRegisterMarq.Controls.Add(this.checkBoxDisponibiliteMission);
            this.panelRegisterMarq.Controls.Add(this.txtPermisConduc);
            this.panelRegisterMarq.Controls.Add(this.txtIdConduc);
            this.panelRegisterMarq.Controls.Add(this.btnEditConduc);
            this.panelRegisterMarq.Controls.Add(this.btnValiderConduc);
            this.panelRegisterMarq.Controls.Add(this.BtnAnnulerConduc);
            this.panelRegisterMarq.Controls.Add(this.txtDescriptionConduc);
            this.panelRegisterMarq.Controls.Add(this.TxtCodConduc);
            this.panelRegisterMarq.Controls.Add(this.label4);
            this.panelRegisterMarq.Controls.Add(this.label3);
            this.panelRegisterMarq.Controls.Add(this.label2);
            this.panelRegisterMarq.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRegisterMarq.Location = new System.Drawing.Point(0, 25);
            this.panelRegisterMarq.Margin = new System.Windows.Forms.Padding(4);
            this.panelRegisterMarq.Name = "panelRegisterMarq";
            this.panelRegisterMarq.Size = new System.Drawing.Size(430, 709);
            this.panelRegisterMarq.TabIndex = 4;
            // 
            // txtPermisConduc
            // 
            this.txtPermisConduc.BackColor = System.Drawing.Color.White;
            this.txtPermisConduc.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPermisConduc.Location = new System.Drawing.Point(132, 203);
            this.txtPermisConduc.Margin = new System.Windows.Forms.Padding(4);
            this.txtPermisConduc.Name = "txtPermisConduc";
            this.txtPermisConduc.Size = new System.Drawing.Size(288, 29);
            this.txtPermisConduc.TabIndex = 11;
            // 
            // txtIdConduc
            // 
            this.txtIdConduc.Location = new System.Drawing.Point(132, 8);
            this.txtIdConduc.Name = "txtIdConduc";
            this.txtIdConduc.Size = new System.Drawing.Size(127, 27);
            this.txtIdConduc.TabIndex = 10;
            this.txtIdConduc.Visible = false;
            // 
            // btnEditConduc
            // 
            this.btnEditConduc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnEditConduc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditConduc.ForeColor = System.Drawing.Color.Black;
            this.btnEditConduc.IconChar = FontAwesome.Sharp.IconChar.PencilSquare;
            this.btnEditConduc.IconColor = System.Drawing.Color.White;
            this.btnEditConduc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditConduc.IconSize = 20;
            this.btnEditConduc.Location = new System.Drawing.Point(220, 520);
            this.btnEditConduc.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditConduc.Name = "btnEditConduc";
            this.btnEditConduc.Size = new System.Drawing.Size(84, 28);
            this.btnEditConduc.TabIndex = 9;
            this.btnEditConduc.Text = "Editer";
            this.btnEditConduc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditConduc.UseVisualStyleBackColor = false;
            this.btnEditConduc.Click += new System.EventHandler(this.btnEditConduc_Click);
            // 
            // btnValiderConduc
            // 
            this.btnValiderConduc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnValiderConduc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValiderConduc.ForeColor = System.Drawing.Color.Black;
            this.btnValiderConduc.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
            this.btnValiderConduc.IconColor = System.Drawing.Color.White;
            this.btnValiderConduc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnValiderConduc.IconSize = 20;
            this.btnValiderConduc.Location = new System.Drawing.Point(125, 520);
            this.btnValiderConduc.Margin = new System.Windows.Forms.Padding(4);
            this.btnValiderConduc.Name = "btnValiderConduc";
            this.btnValiderConduc.Size = new System.Drawing.Size(87, 28);
            this.btnValiderConduc.TabIndex = 8;
            this.btnValiderConduc.Text = "Valider";
            this.btnValiderConduc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnValiderConduc.UseVisualStyleBackColor = false;
            this.btnValiderConduc.Click += new System.EventHandler(this.btnValiderConduc_Click);
            // 
            // BtnAnnulerConduc
            // 
            this.BtnAnnulerConduc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.BtnAnnulerConduc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnnulerConduc.ForeColor = System.Drawing.Color.Black;
            this.BtnAnnulerConduc.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.BtnAnnulerConduc.IconColor = System.Drawing.Color.White;
            this.BtnAnnulerConduc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAnnulerConduc.IconSize = 20;
            this.BtnAnnulerConduc.Location = new System.Drawing.Point(312, 520);
            this.BtnAnnulerConduc.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAnnulerConduc.Name = "BtnAnnulerConduc";
            this.BtnAnnulerConduc.Size = new System.Drawing.Size(91, 28);
            this.BtnAnnulerConduc.TabIndex = 7;
            this.BtnAnnulerConduc.Text = "Annuler";
            this.BtnAnnulerConduc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAnnulerConduc.UseVisualStyleBackColor = false;
            this.BtnAnnulerConduc.Click += new System.EventHandler(this.BtnAnnulerConduc_Click);
            // 
            // txtDescriptionConduc
            // 
            this.txtDescriptionConduc.BackColor = System.Drawing.Color.White;
            this.txtDescriptionConduc.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescriptionConduc.Location = new System.Drawing.Point(132, 124);
            this.txtDescriptionConduc.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescriptionConduc.Name = "txtDescriptionConduc";
            this.txtDescriptionConduc.Size = new System.Drawing.Size(288, 29);
            this.txtDescriptionConduc.TabIndex = 4;
            // 
            // TxtCodConduc
            // 
            this.TxtCodConduc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.TxtCodConduc.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodConduc.ForeColor = System.Drawing.Color.Black;
            this.TxtCodConduc.Location = new System.Drawing.Point(132, 47);
            this.TxtCodConduc.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCodConduc.Name = "TxtCodConduc";
            this.TxtCodConduc.ReadOnly = true;
            this.TxtCodConduc.Size = new System.Drawing.Size(127, 28);
            this.TxtCodConduc.TabIndex = 3;
            this.TxtCodConduc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(4, 211);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "N° Permis";
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
            this.label2.Location = new System.Drawing.Point(5, 54);
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
            this.panel1.Controls.Add(this.txtFilterConduc);
            this.panel1.Controls.Add(this.txtNbrConduc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(430, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 29);
            this.panel1.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(570, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 19);
            this.label10.TabIndex = 20;
            this.label10.Text = "Filtrer";
            // 
            // txtFilterConduc
            // 
            this.txtFilterConduc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterConduc.BackColor = System.Drawing.Color.White;
            this.txtFilterConduc.ForeColor = System.Drawing.Color.Black;
            this.txtFilterConduc.Location = new System.Drawing.Point(638, 1);
            this.txtFilterConduc.Name = "txtFilterConduc";
            this.txtFilterConduc.Size = new System.Drawing.Size(276, 27);
            this.txtFilterConduc.TabIndex = 19;
            this.txtFilterConduc.TextChanged += new System.EventHandler(this.txtFilterConduc_TextChanged);
            // 
            // txtNbrConduc
            // 
            this.txtNbrConduc.AutoSize = true;
            this.txtNbrConduc.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNbrConduc.ForeColor = System.Drawing.Color.Maroon;
            this.txtNbrConduc.Location = new System.Drawing.Point(4, 10);
            this.txtNbrConduc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtNbrConduc.Name = "txtNbrConduc";
            this.txtNbrConduc.Size = new System.Drawing.Size(147, 17);
            this.txtNbrConduc.TabIndex = 0;
            this.txtNbrConduc.Text = "Total Conducteur = 0";
            // 
            // dgvConduc
            // 
            this.dgvConduc.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvConduc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConduc.BackgroundColor = System.Drawing.Color.White;
            this.dgvConduc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConduc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConduc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConduc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_COND,
            this.CODE_COND,
            this.DESCRIPTION_COND,
            this.NUMPERMIS_COND,
            this.DISPMISSION_COND,
            this.NBRMISSION_COND,
            this.EXPERIENCE_COND,
            this.USERCREATE_COND,
            this.DATECREATE_COND,
            this.DATEMODIFY_COND,
            this.USERMODIFY});
            this.dgvConduc.ContextMenuStrip = this.MenuConducteur;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConduc.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvConduc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConduc.GridColor = System.Drawing.Color.White;
            this.dgvConduc.Location = new System.Drawing.Point(430, 54);
            this.dgvConduc.Margin = new System.Windows.Forms.Padding(4);
            this.dgvConduc.Name = "dgvConduc";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConduc.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvConduc.RowHeadersWidth = 51;
            this.dgvConduc.Size = new System.Drawing.Size(914, 680);
            this.dgvConduc.TabIndex = 6;
            this.dgvConduc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConduc_CellClick);
            this.dgvConduc.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvConduc_CellMouseUp);
            // 
            // MenuConducteur
            // 
            this.MenuConducteur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.MenuConducteur.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuConducteur.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuConducteur.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMenuDelete});
            this.MenuConducteur.Name = "MenuConducteur";
            this.MenuConducteur.Size = new System.Drawing.Size(154, 30);
            // 
            // itemMenuDelete
            // 
            this.itemMenuDelete.ForeColor = System.Drawing.Color.Black;
            this.itemMenuDelete.Image = ((System.Drawing.Image)(resources.GetObject("itemMenuDelete.Image")));
            this.itemMenuDelete.Name = "itemMenuDelete";
            this.itemMenuDelete.Size = new System.Drawing.Size(153, 26);
            this.itemMenuDelete.Text = "Supprimer";
            this.itemMenuDelete.Click += new System.EventHandler(this.itemMenuDelete_Click);
            // 
            // checkBoxDisponibiliteMission
            // 
            this.checkBoxDisponibiliteMission.AutoSize = true;
            this.checkBoxDisponibiliteMission.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxDisponibiliteMission.Location = new System.Drawing.Point(3, 287);
            this.checkBoxDisponibiliteMission.Name = "checkBoxDisponibiliteMission";
            this.checkBoxDisponibiliteMission.Size = new System.Drawing.Size(199, 23);
            this.checkBoxDisponibiliteMission.TabIndex = 12;
            this.checkBoxDisponibiliteMission.Text = "Disponible pour mission";
            this.checkBoxDisponibiliteMission.UseVisualStyleBackColor = true;
            // 
            // txtNbrMission
            // 
            this.txtNbrMission.BackColor = System.Drawing.Color.White;
            this.txtNbrMission.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNbrMission.ForeColor = System.Drawing.Color.Black;
            this.txtNbrMission.Location = new System.Drawing.Point(134, 355);
            this.txtNbrMission.Margin = new System.Windows.Forms.Padding(4);
            this.txtNbrMission.Name = "txtNbrMission";
            this.txtNbrMission.Size = new System.Drawing.Size(125, 29);
            this.txtNbrMission.TabIndex = 14;
            this.txtNbrMission.Text = "0";
            this.txtNbrMission.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 363);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nbr. de mission";
            // 
            // txtExpConducteur
            // 
            this.txtExpConducteur.BackColor = System.Drawing.Color.White;
            this.txtExpConducteur.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpConducteur.ForeColor = System.Drawing.Color.Black;
            this.txtExpConducteur.Location = new System.Drawing.Point(134, 431);
            this.txtExpConducteur.Margin = new System.Windows.Forms.Padding(4);
            this.txtExpConducteur.Name = "txtExpConducteur";
            this.txtExpConducteur.Size = new System.Drawing.Size(125, 29);
            this.txtExpConducteur.TabIndex = 16;
            this.txtExpConducteur.Text = "0";
            this.txtExpConducteur.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 439);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Expérience";
            // 
            // ID_COND
            // 
            this.ID_COND.DataPropertyName = "ID_COND";
            this.ID_COND.HeaderText = "IdConducteur";
            this.ID_COND.MinimumWidth = 6;
            this.ID_COND.Name = "ID_COND";
            this.ID_COND.ReadOnly = true;
            this.ID_COND.Visible = false;
            this.ID_COND.Width = 125;
            // 
            // CODE_COND
            // 
            this.CODE_COND.DataPropertyName = "CODE_COND";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CODE_COND.DefaultCellStyle = dataGridViewCellStyle3;
            this.CODE_COND.HeaderText = "Code";
            this.CODE_COND.MinimumWidth = 6;
            this.CODE_COND.Name = "CODE_COND";
            this.CODE_COND.Width = 80;
            // 
            // DESCRIPTION_COND
            // 
            this.DESCRIPTION_COND.DataPropertyName = "DESCRIPTION_COND";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DESCRIPTION_COND.DefaultCellStyle = dataGridViewCellStyle4;
            this.DESCRIPTION_COND.HeaderText = "Description";
            this.DESCRIPTION_COND.MinimumWidth = 6;
            this.DESCRIPTION_COND.Name = "DESCRIPTION_COND";
            this.DESCRIPTION_COND.Width = 250;
            // 
            // NUMPERMIS_COND
            // 
            this.NUMPERMIS_COND.DataPropertyName = "NUMPERMIS_COND";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.NUMPERMIS_COND.DefaultCellStyle = dataGridViewCellStyle5;
            this.NUMPERMIS_COND.HeaderText = "N° Permis";
            this.NUMPERMIS_COND.MinimumWidth = 6;
            this.NUMPERMIS_COND.Name = "NUMPERMIS_COND";
            this.NUMPERMIS_COND.Width = 250;
            // 
            // DISPMISSION_COND
            // 
            this.DISPMISSION_COND.DataPropertyName = "DISPMISSION_COND";
            this.DISPMISSION_COND.HeaderText = "Disponibilité";
            this.DISPMISSION_COND.MinimumWidth = 6;
            this.DISPMISSION_COND.Name = "DISPMISSION_COND";
            this.DISPMISSION_COND.ReadOnly = true;
            this.DISPMISSION_COND.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DISPMISSION_COND.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DISPMISSION_COND.Width = 150;
            // 
            // NBRMISSION_COND
            // 
            this.NBRMISSION_COND.DataPropertyName = "NBRMISSION_COND";
            this.NBRMISSION_COND.HeaderText = "Nbr. De Mission";
            this.NBRMISSION_COND.MinimumWidth = 6;
            this.NBRMISSION_COND.Name = "NBRMISSION_COND";
            this.NBRMISSION_COND.ReadOnly = true;
            this.NBRMISSION_COND.Width = 150;
            // 
            // EXPERIENCE_COND
            // 
            this.EXPERIENCE_COND.DataPropertyName = "EXPERIENCE_COND";
            this.EXPERIENCE_COND.HeaderText = "Expérience";
            this.EXPERIENCE_COND.MinimumWidth = 6;
            this.EXPERIENCE_COND.Name = "EXPERIENCE_COND";
            this.EXPERIENCE_COND.ReadOnly = true;
            this.EXPERIENCE_COND.Width = 150;
            // 
            // USERCREATE_COND
            // 
            this.USERCREATE_COND.DataPropertyName = "USERCREATE_COND";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.USERCREATE_COND.DefaultCellStyle = dataGridViewCellStyle6;
            this.USERCREATE_COND.HeaderText = "Créer par";
            this.USERCREATE_COND.MinimumWidth = 6;
            this.USERCREATE_COND.Name = "USERCREATE_COND";
            this.USERCREATE_COND.Width = 150;
            // 
            // DATECREATE_COND
            // 
            this.DATECREATE_COND.DataPropertyName = "DATECREATE_COND";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DATECREATE_COND.DefaultCellStyle = dataGridViewCellStyle7;
            this.DATECREATE_COND.HeaderText = "Créer le";
            this.DATECREATE_COND.MinimumWidth = 125;
            this.DATECREATE_COND.Name = "DATECREATE_COND";
            this.DATECREATE_COND.Width = 125;
            // 
            // DATEMODIFY_COND
            // 
            this.DATEMODIFY_COND.DataPropertyName = "DATEMODIFY_COND";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DATEMODIFY_COND.DefaultCellStyle = dataGridViewCellStyle8;
            this.DATEMODIFY_COND.HeaderText = "Modifié le";
            this.DATEMODIFY_COND.MinimumWidth = 6;
            this.DATEMODIFY_COND.Name = "DATEMODIFY_COND";
            this.DATEMODIFY_COND.ReadOnly = true;
            this.DATEMODIFY_COND.Width = 125;
            // 
            // USERMODIFY
            // 
            this.USERMODIFY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.USERMODIFY.DataPropertyName = "USERMODIFY";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.USERMODIFY.DefaultCellStyle = dataGridViewCellStyle9;
            this.USERMODIFY.HeaderText = "Modifié par";
            this.USERMODIFY.MinimumWidth = 125;
            this.USERMODIFY.Name = "USERMODIFY";
            this.USERMODIFY.ReadOnly = true;
            // 
            // FormConducteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1344, 734);
            this.Controls.Add(this.dgvConduc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelRegisterMarq);
            this.Controls.Add(this.panelMarqueTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormConducteur";
            this.Text = "Conducteur";
            this.panelMarqueTitle.ResumeLayout(false);
            this.panelMarqueTitle.PerformLayout();
            this.panelRegisterMarq.ResumeLayout(false);
            this.panelRegisterMarq.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConduc)).EndInit();
            this.MenuConducteur.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMarqueTitle;
        private FontAwesome.Sharp.IconButton btnRafraichirConduc;
        private FontAwesome.Sharp.IconButton BtnExportConduc;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BtnImportConduc;
        private FontAwesome.Sharp.IconButton BtnCloseFormConducteur;
        private System.Windows.Forms.Panel panelRegisterMarq;
        private System.Windows.Forms.TextBox txtIdConduc;
        private FontAwesome.Sharp.IconButton btnEditConduc;
        private FontAwesome.Sharp.IconButton btnValiderConduc;
        private FontAwesome.Sharp.IconButton BtnAnnulerConduc;
        private System.Windows.Forms.TextBox txtDescriptionConduc;
        private System.Windows.Forms.TextBox TxtCodConduc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFilterConduc;
        private System.Windows.Forms.Label txtNbrConduc;
        private System.Windows.Forms.DataGridView dgvConduc;
        private System.Windows.Forms.TextBox txtPermisConduc;
        private System.Windows.Forms.ContextMenuStrip MenuConducteur;
        private System.Windows.Forms.ToolStripMenuItem itemMenuDelete;
        private System.Windows.Forms.TextBox txtExpConducteur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNbrMission;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxDisponibiliteMission;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_COND;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_COND;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_COND;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMPERMIS_COND;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DISPMISSION_COND;
        private System.Windows.Forms.DataGridViewTextBoxColumn NBRMISSION_COND;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXPERIENCE_COND;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERCREATE_COND;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATECREATE_COND;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATEMODIFY_COND;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERMODIFY;
    }
}