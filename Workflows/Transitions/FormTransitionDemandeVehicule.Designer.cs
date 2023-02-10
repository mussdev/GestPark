namespace GestPark.Validations
{
    partial class FormTransitionDemandeVehicule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransitionDemandeVehicule));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCloseTransition = new FontAwesome.Sharp.IconButton();
            this.btnRafraichirTransMvt = new FontAwesome.Sharp.IconButton();
            this.BtnExportTransMvt = new FontAwesome.Sharp.IconButton();
            this.BtnImportTransMvt = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvTransitionDemandeVehi = new System.Windows.Forms.DataGridView();
            this.ID_TRANSASKCAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_TRANSASKCAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUT_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUT_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_NIVVAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATECREATE_TRANSASKCAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERCREATE_TRANSASKCAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATEMODIFY_TRANSASKCAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERMODIFY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFilterTransition = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.checkedListBoxRoleTrans = new System.Windows.Forms.CheckedListBox();
            this.cbxNiveauTransMvt = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxFinTransMvt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDTransMvt = new System.Windows.Forms.TextBox();
            this.cbxDebutTransMvt = new System.Windows.Forms.ComboBox();
            this.txtDescriptionTransMvt = new System.Windows.Forms.TextBox();
            this.btnEditTransMvt = new FontAwesome.Sharp.IconButton();
            this.btnValiderTransMvt = new FontAwesome.Sharp.IconButton();
            this.BtnAnnulerTransMvt = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransitionDemandeVehi)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 918);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1237, 21);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.panel2.Controls.Add(this.btnCloseTransition);
            this.panel2.Controls.Add(this.btnRafraichirTransMvt);
            this.panel2.Controls.Add(this.BtnExportTransMvt);
            this.panel2.Controls.Add(this.BtnImportTransMvt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1237, 25);
            this.panel2.TabIndex = 2;
            // 
            // btnCloseTransition
            // 
            this.btnCloseTransition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseTransition.BackColor = System.Drawing.Color.White;
            this.btnCloseTransition.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.btnCloseTransition.IconColor = System.Drawing.Color.Red;
            this.btnCloseTransition.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseTransition.IconSize = 15;
            this.btnCloseTransition.Location = new System.Drawing.Point(1206, 0);
            this.btnCloseTransition.Name = "btnCloseTransition";
            this.btnCloseTransition.Size = new System.Drawing.Size(31, 25);
            this.btnCloseTransition.TabIndex = 18;
            this.btnCloseTransition.UseVisualStyleBackColor = false;
            this.btnCloseTransition.Click += new System.EventHandler(this.btnCloseTransition_Click);
            // 
            // btnRafraichirTransMvt
            // 
            this.btnRafraichirTransMvt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnRafraichirTransMvt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRafraichirTransMvt.ForeColor = System.Drawing.Color.Black;
            this.btnRafraichirTransMvt.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.btnRafraichirTransMvt.IconColor = System.Drawing.Color.White;
            this.btnRafraichirTransMvt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRafraichirTransMvt.IconSize = 20;
            this.btnRafraichirTransMvt.Location = new System.Drawing.Point(197, 0);
            this.btnRafraichirTransMvt.Margin = new System.Windows.Forms.Padding(4);
            this.btnRafraichirTransMvt.Name = "btnRafraichirTransMvt";
            this.btnRafraichirTransMvt.Size = new System.Drawing.Size(109, 25);
            this.btnRafraichirTransMvt.TabIndex = 17;
            this.btnRafraichirTransMvt.Text = "Rafraîchir";
            this.btnRafraichirTransMvt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRafraichirTransMvt.UseVisualStyleBackColor = false;
            this.btnRafraichirTransMvt.Click += new System.EventHandler(this.btnRafraichirTransMvt_Click);
            // 
            // BtnExportTransMvt
            // 
            this.BtnExportTransMvt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.BtnExportTransMvt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExportTransMvt.ForeColor = System.Drawing.Color.Black;
            this.BtnExportTransMvt.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromFile;
            this.BtnExportTransMvt.IconColor = System.Drawing.Color.White;
            this.BtnExportTransMvt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnExportTransMvt.IconSize = 20;
            this.BtnExportTransMvt.Location = new System.Drawing.Point(99, 0);
            this.BtnExportTransMvt.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExportTransMvt.Name = "BtnExportTransMvt";
            this.BtnExportTransMvt.Size = new System.Drawing.Size(97, 25);
            this.BtnExportTransMvt.TabIndex = 16;
            this.BtnExportTransMvt.Text = "Exporter";
            this.BtnExportTransMvt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExportTransMvt.UseVisualStyleBackColor = false;
            // 
            // BtnImportTransMvt
            // 
            this.BtnImportTransMvt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.BtnImportTransMvt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImportTransMvt.ForeColor = System.Drawing.Color.Black;
            this.BtnImportTransMvt.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.BtnImportTransMvt.IconColor = System.Drawing.Color.White;
            this.BtnImportTransMvt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnImportTransMvt.IconSize = 20;
            this.BtnImportTransMvt.Location = new System.Drawing.Point(0, 0);
            this.BtnImportTransMvt.Margin = new System.Windows.Forms.Padding(4);
            this.BtnImportTransMvt.Name = "BtnImportTransMvt";
            this.BtnImportTransMvt.Size = new System.Drawing.Size(97, 25);
            this.BtnImportTransMvt.TabIndex = 15;
            this.BtnImportTransMvt.Text = "Importer";
            this.BtnImportTransMvt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnImportTransMvt.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvTransitionDemandeVehi);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1237, 893);
            this.panel3.TabIndex = 3;
            // 
            // dgvTransitionDemandeVehi
            // 
            this.dgvTransitionDemandeVehi.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvTransitionDemandeVehi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTransitionDemandeVehi.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransitionDemandeVehi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTransitionDemandeVehi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransitionDemandeVehi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_TRANSASKCAR,
            this.DESCRIPTION_TRANSASKCAR,
            this.STATUT_1,
            this.STATUT_2,
            this.DESCRIPTION_NIVVAL,
            this.DATECREATE_TRANSASKCAR,
            this.USERCREATE_TRANSASKCAR,
            this.DATEMODIFY_TRANSASKCAR,
            this.USERMODIFY});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransitionDemandeVehi.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvTransitionDemandeVehi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransitionDemandeVehi.GridColor = System.Drawing.Color.White;
            this.dgvTransitionDemandeVehi.Location = new System.Drawing.Point(416, 31);
            this.dgvTransitionDemandeVehi.Name = "dgvTransitionDemandeVehi";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransitionDemandeVehi.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvTransitionDemandeVehi.RowHeadersWidth = 51;
            this.dgvTransitionDemandeVehi.RowTemplate.Height = 24;
            this.dgvTransitionDemandeVehi.Size = new System.Drawing.Size(821, 862);
            this.dgvTransitionDemandeVehi.TabIndex = 2;
            this.dgvTransitionDemandeVehi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransitionDemandeVehi_CellClick);
            // 
            // ID_TRANSASKCAR
            // 
            this.ID_TRANSASKCAR.DataPropertyName = "ID_TRANSASKCAR";
            this.ID_TRANSASKCAR.HeaderText = "IdTransition";
            this.ID_TRANSASKCAR.MinimumWidth = 6;
            this.ID_TRANSASKCAR.Name = "ID_TRANSASKCAR";
            this.ID_TRANSASKCAR.ReadOnly = true;
            this.ID_TRANSASKCAR.Visible = false;
            this.ID_TRANSASKCAR.Width = 125;
            // 
            // DESCRIPTION_TRANSASKCAR
            // 
            this.DESCRIPTION_TRANSASKCAR.DataPropertyName = "DESCRIPTION_TRANSASKCAR";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DESCRIPTION_TRANSASKCAR.DefaultCellStyle = dataGridViewCellStyle3;
            this.DESCRIPTION_TRANSASKCAR.HeaderText = "Description";
            this.DESCRIPTION_TRANSASKCAR.MinimumWidth = 6;
            this.DESCRIPTION_TRANSASKCAR.Name = "DESCRIPTION_TRANSASKCAR";
            this.DESCRIPTION_TRANSASKCAR.ReadOnly = true;
            this.DESCRIPTION_TRANSASKCAR.Width = 125;
            // 
            // STATUT_1
            // 
            this.STATUT_1.DataPropertyName = "STATUT_1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.STATUT_1.DefaultCellStyle = dataGridViewCellStyle4;
            this.STATUT_1.HeaderText = "Début de transition";
            this.STATUT_1.MinimumWidth = 6;
            this.STATUT_1.Name = "STATUT_1";
            this.STATUT_1.ReadOnly = true;
            this.STATUT_1.Width = 200;
            // 
            // STATUT_2
            // 
            this.STATUT_2.DataPropertyName = "STATUT_2";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.STATUT_2.DefaultCellStyle = dataGridViewCellStyle5;
            this.STATUT_2.HeaderText = "Fin de transition";
            this.STATUT_2.MinimumWidth = 6;
            this.STATUT_2.Name = "STATUT_2";
            this.STATUT_2.ReadOnly = true;
            this.STATUT_2.Width = 200;
            // 
            // DESCRIPTION_NIVVAL
            // 
            this.DESCRIPTION_NIVVAL.DataPropertyName = "DESCRIPTION_NIVVAL";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DESCRIPTION_NIVVAL.DefaultCellStyle = dataGridViewCellStyle6;
            this.DESCRIPTION_NIVVAL.HeaderText = "Niveau";
            this.DESCRIPTION_NIVVAL.MinimumWidth = 6;
            this.DESCRIPTION_NIVVAL.Name = "DESCRIPTION_NIVVAL";
            this.DESCRIPTION_NIVVAL.ReadOnly = true;
            this.DESCRIPTION_NIVVAL.Width = 125;
            // 
            // DATECREATE_TRANSASKCAR
            // 
            this.DATECREATE_TRANSASKCAR.DataPropertyName = "DATECREATE_TRANSASKCAR";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DATECREATE_TRANSASKCAR.DefaultCellStyle = dataGridViewCellStyle7;
            this.DATECREATE_TRANSASKCAR.HeaderText = "Créer le";
            this.DATECREATE_TRANSASKCAR.MinimumWidth = 6;
            this.DATECREATE_TRANSASKCAR.Name = "DATECREATE_TRANSASKCAR";
            this.DATECREATE_TRANSASKCAR.ReadOnly = true;
            this.DATECREATE_TRANSASKCAR.Width = 125;
            // 
            // USERCREATE_TRANSASKCAR
            // 
            this.USERCREATE_TRANSASKCAR.DataPropertyName = "USERCREATE_TRANSASKCAR";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.USERCREATE_TRANSASKCAR.DefaultCellStyle = dataGridViewCellStyle8;
            this.USERCREATE_TRANSASKCAR.HeaderText = "Créer par";
            this.USERCREATE_TRANSASKCAR.MinimumWidth = 6;
            this.USERCREATE_TRANSASKCAR.Name = "USERCREATE_TRANSASKCAR";
            this.USERCREATE_TRANSASKCAR.ReadOnly = true;
            this.USERCREATE_TRANSASKCAR.Width = 125;
            // 
            // DATEMODIFY_TRANSASKCAR
            // 
            this.DATEMODIFY_TRANSASKCAR.DataPropertyName = "DATEMODIFY_TRANSASKCAR";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DATEMODIFY_TRANSASKCAR.DefaultCellStyle = dataGridViewCellStyle9;
            this.DATEMODIFY_TRANSASKCAR.HeaderText = "Modifier le";
            this.DATEMODIFY_TRANSASKCAR.MinimumWidth = 6;
            this.DATEMODIFY_TRANSASKCAR.Name = "DATEMODIFY_TRANSASKCAR";
            this.DATEMODIFY_TRANSASKCAR.ReadOnly = true;
            this.DATEMODIFY_TRANSASKCAR.Width = 125;
            // 
            // USERMODIFY
            // 
            this.USERMODIFY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.USERMODIFY.DataPropertyName = "USERMODIFY";
            this.USERMODIFY.HeaderText = "Modifier par";
            this.USERMODIFY.MinimumWidth = 150;
            this.USERMODIFY.Name = "USERMODIFY";
            this.USERMODIFY.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.txtFilterTransition);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(416, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(821, 31);
            this.panel5.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(6, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(270, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Transition de demande de véhicules";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(517, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Filtrer";
            // 
            // txtFilterTransition
            // 
            this.txtFilterTransition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterTransition.Location = new System.Drawing.Point(585, 3);
            this.txtFilterTransition.Name = "txtFilterTransition";
            this.txtFilterTransition.Size = new System.Drawing.Size(236, 27);
            this.txtFilterTransition.TabIndex = 0;
            this.txtFilterTransition.TextChanged += new System.EventHandler(this.txtFilterTransition_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.checkedListBoxRoleTrans);
            this.panel4.Controls.Add(this.cbxNiveauTransMvt);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.cbxFinTransMvt);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtIDTransMvt);
            this.panel4.Controls.Add(this.cbxDebutTransMvt);
            this.panel4.Controls.Add(this.txtDescriptionTransMvt);
            this.panel4.Controls.Add(this.btnEditTransMvt);
            this.panel4.Controls.Add(this.btnValiderTransMvt);
            this.panel4.Controls.Add(this.BtnAnnulerTransMvt);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(416, 893);
            this.panel4.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "Rôle";
            // 
            // checkedListBoxRoleTrans
            // 
            this.checkedListBoxRoleTrans.FormattingEnabled = true;
            this.checkedListBoxRoleTrans.Location = new System.Drawing.Point(127, 320);
            this.checkedListBoxRoleTrans.Name = "checkedListBoxRoleTrans";
            this.checkedListBoxRoleTrans.Size = new System.Drawing.Size(276, 246);
            this.checkedListBoxRoleTrans.TabIndex = 31;
            // 
            // cbxNiveauTransMvt
            // 
            this.cbxNiveauTransMvt.ForeColor = System.Drawing.Color.Black;
            this.cbxNiveauTransMvt.FormattingEnabled = true;
            this.cbxNiveauTransMvt.Items.AddRange(new object[] {
            ""});
            this.cbxNiveauTransMvt.Location = new System.Drawing.Point(127, 249);
            this.cbxNiveauTransMvt.Name = "cbxNiveauTransMvt";
            this.cbxNiveauTransMvt.Size = new System.Drawing.Size(278, 27);
            this.cbxNiveauTransMvt.TabIndex = 30;
            this.cbxNiveauTransMvt.SelectedIndexChanged += new System.EventHandler(this.cbxNiveauTransMvt_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(14, 255);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 21);
            this.label5.TabIndex = 29;
            this.label5.Text = "Niveau* :";
            // 
            // cbxFinTransMvt
            // 
            this.cbxFinTransMvt.ForeColor = System.Drawing.Color.Black;
            this.cbxFinTransMvt.FormattingEnabled = true;
            this.cbxFinTransMvt.Items.AddRange(new object[] {
            ""});
            this.cbxFinTransMvt.Location = new System.Drawing.Point(127, 179);
            this.cbxFinTransMvt.Name = "cbxFinTransMvt";
            this.cbxFinTransMvt.Size = new System.Drawing.Size(278, 27);
            this.cbxFinTransMvt.TabIndex = 28;
            this.cbxFinTransMvt.SelectedIndexChanged += new System.EventHandler(this.cbxFinTransMvt_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(14, 185);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "A * :";
            // 
            // txtIDTransMvt
            // 
            this.txtIDTransMvt.BackColor = System.Drawing.Color.White;
            this.txtIDTransMvt.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDTransMvt.Location = new System.Drawing.Point(127, 6);
            this.txtIDTransMvt.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDTransMvt.Name = "txtIDTransMvt";
            this.txtIDTransMvt.ReadOnly = true;
            this.txtIDTransMvt.Size = new System.Drawing.Size(126, 29);
            this.txtIDTransMvt.TabIndex = 24;
            this.txtIDTransMvt.Visible = false;
            // 
            // cbxDebutTransMvt
            // 
            this.cbxDebutTransMvt.ForeColor = System.Drawing.Color.Black;
            this.cbxDebutTransMvt.FormattingEnabled = true;
            this.cbxDebutTransMvt.Items.AddRange(new object[] {
            ""});
            this.cbxDebutTransMvt.Location = new System.Drawing.Point(127, 112);
            this.cbxDebutTransMvt.Name = "cbxDebutTransMvt";
            this.cbxDebutTransMvt.Size = new System.Drawing.Size(278, 27);
            this.cbxDebutTransMvt.TabIndex = 23;
            this.cbxDebutTransMvt.SelectedIndexChanged += new System.EventHandler(this.cbxDebutTransMvt_SelectedIndexChanged);
            // 
            // txtDescriptionTransMvt
            // 
            this.txtDescriptionTransMvt.BackColor = System.Drawing.Color.White;
            this.txtDescriptionTransMvt.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescriptionTransMvt.ForeColor = System.Drawing.Color.Black;
            this.txtDescriptionTransMvt.Location = new System.Drawing.Point(127, 43);
            this.txtDescriptionTransMvt.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescriptionTransMvt.Name = "txtDescriptionTransMvt";
            this.txtDescriptionTransMvt.Size = new System.Drawing.Size(278, 29);
            this.txtDescriptionTransMvt.TabIndex = 22;
            // 
            // btnEditTransMvt
            // 
            this.btnEditTransMvt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnEditTransMvt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTransMvt.ForeColor = System.Drawing.Color.Black;
            this.btnEditTransMvt.IconChar = FontAwesome.Sharp.IconChar.PencilSquare;
            this.btnEditTransMvt.IconColor = System.Drawing.Color.White;
            this.btnEditTransMvt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditTransMvt.IconSize = 20;
            this.btnEditTransMvt.Location = new System.Drawing.Point(220, 613);
            this.btnEditTransMvt.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditTransMvt.Name = "btnEditTransMvt";
            this.btnEditTransMvt.Size = new System.Drawing.Size(84, 28);
            this.btnEditTransMvt.TabIndex = 21;
            this.btnEditTransMvt.Text = "Editer";
            this.btnEditTransMvt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditTransMvt.UseVisualStyleBackColor = false;
            this.btnEditTransMvt.Click += new System.EventHandler(this.btnEditTransMvt_Click);
            // 
            // btnValiderTransMvt
            // 
            this.btnValiderTransMvt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnValiderTransMvt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValiderTransMvt.ForeColor = System.Drawing.Color.Black;
            this.btnValiderTransMvt.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
            this.btnValiderTransMvt.IconColor = System.Drawing.Color.White;
            this.btnValiderTransMvt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnValiderTransMvt.IconSize = 20;
            this.btnValiderTransMvt.Location = new System.Drawing.Point(125, 613);
            this.btnValiderTransMvt.Margin = new System.Windows.Forms.Padding(4);
            this.btnValiderTransMvt.Name = "btnValiderTransMvt";
            this.btnValiderTransMvt.Size = new System.Drawing.Size(87, 28);
            this.btnValiderTransMvt.TabIndex = 20;
            this.btnValiderTransMvt.Text = "Valider";
            this.btnValiderTransMvt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnValiderTransMvt.UseVisualStyleBackColor = false;
            this.btnValiderTransMvt.Click += new System.EventHandler(this.btnValiderTransMvt_Click);
            // 
            // BtnAnnulerTransMvt
            // 
            this.BtnAnnulerTransMvt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.BtnAnnulerTransMvt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnnulerTransMvt.ForeColor = System.Drawing.Color.Black;
            this.BtnAnnulerTransMvt.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.BtnAnnulerTransMvt.IconColor = System.Drawing.Color.White;
            this.BtnAnnulerTransMvt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAnnulerTransMvt.IconSize = 20;
            this.BtnAnnulerTransMvt.Location = new System.Drawing.Point(312, 613);
            this.BtnAnnulerTransMvt.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAnnulerTransMvt.Name = "BtnAnnulerTransMvt";
            this.BtnAnnulerTransMvt.Size = new System.Drawing.Size(91, 28);
            this.BtnAnnulerTransMvt.TabIndex = 19;
            this.BtnAnnulerTransMvt.Text = "Annuler";
            this.BtnAnnulerTransMvt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAnnulerTransMvt.UseVisualStyleBackColor = false;
            this.BtnAnnulerTransMvt.Click += new System.EventHandler(this.BtnAnnulerTransMvt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(14, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "De * :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(14, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Description*:";
            // 
            // FormTransitionDemandeVehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1237, 939);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormTransitionDemandeVehicule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter une transition de demande de véhicule";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransitionDemandeVehi)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnRafraichirTransMvt;
        private FontAwesome.Sharp.IconButton BtnExportTransMvt;
        private FontAwesome.Sharp.IconButton BtnImportTransMvt;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbxFinTransMvt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDTransMvt;
        private System.Windows.Forms.ComboBox cbxDebutTransMvt;
        private System.Windows.Forms.TextBox txtDescriptionTransMvt;
        private FontAwesome.Sharp.IconButton btnEditTransMvt;
        private FontAwesome.Sharp.IconButton btnValiderTransMvt;
        private FontAwesome.Sharp.IconButton BtnAnnulerTransMvt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxNiveauTransMvt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox checkedListBoxRoleTrans;
        private System.Windows.Forms.DataGridView dgvTransitionDemandeVehi;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton btnCloseTransition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFilterTransition;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TRANSASKCAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_TRANSASKCAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUT_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUT_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_NIVVAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATECREATE_TRANSASKCAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERCREATE_TRANSASKCAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATEMODIFY_TRANSASKCAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERMODIFY;
        private System.Windows.Forms.Label label7;
    }
}