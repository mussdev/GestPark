namespace GestPark.Workflows.NiveauTransition
{
    partial class FormNiveauTransitionDemandeCar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNiveauTransitionDemandeCar));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCloseNiveau = new FontAwesome.Sharp.IconButton();
            this.btnRafraichirTransMvt = new FontAwesome.Sharp.IconButton();
            this.BtnExportTransMvt = new FontAwesome.Sharp.IconButton();
            this.BtnImportTransMvt = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxObserNiveau = new System.Windows.Forms.RichTextBox();
            this.txtIDNiveauTransMvt = new System.Windows.Forms.TextBox();
            this.txtDescriptionNiveauTransMvt = new System.Windows.Forms.TextBox();
            this.btnEditNiveauTransMvt = new FontAwesome.Sharp.IconButton();
            this.btnNiveauTransMvt = new FontAwesome.Sharp.IconButton();
            this.BtnAnnulerNiveauTransMvt = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvNiveauTransitionVehi = new System.Windows.Forms.DataGridView();
            this.ID_NIVVAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_NIVVAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATECREATE_NIVVAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERCREATE_NIVVAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATEMODIFY_NIVVAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERMODIFY_NIVVAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBSERVATION_NIVVAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuNiveau = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemDeleteNiveau = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiveauTransitionVehi)).BeginInit();
            this.MenuNiveau.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 750);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1230, 16);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.panel2.Controls.Add(this.btnCloseNiveau);
            this.panel2.Controls.Add(this.btnRafraichirTransMvt);
            this.panel2.Controls.Add(this.BtnExportTransMvt);
            this.panel2.Controls.Add(this.BtnImportTransMvt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1230, 25);
            this.panel2.TabIndex = 3;
            // 
            // btnCloseNiveau
            // 
            this.btnCloseNiveau.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseNiveau.BackColor = System.Drawing.Color.White;
            this.btnCloseNiveau.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.btnCloseNiveau.IconColor = System.Drawing.Color.Red;
            this.btnCloseNiveau.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseNiveau.IconSize = 15;
            this.btnCloseNiveau.Location = new System.Drawing.Point(1199, 0);
            this.btnCloseNiveau.Name = "btnCloseNiveau";
            this.btnCloseNiveau.Size = new System.Drawing.Size(31, 25);
            this.btnCloseNiveau.TabIndex = 19;
            this.btnCloseNiveau.UseVisualStyleBackColor = false;
            this.btnCloseNiveau.Click += new System.EventHandler(this.btnCloseNiveau_Click);
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.richTextBoxObserNiveau);
            this.panel4.Controls.Add(this.txtIDNiveauTransMvt);
            this.panel4.Controls.Add(this.txtDescriptionNiveauTransMvt);
            this.panel4.Controls.Add(this.btnEditNiveauTransMvt);
            this.panel4.Controls.Add(this.btnNiveauTransMvt);
            this.panel4.Controls.Add(this.BtnAnnulerNiveauTransMvt);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(422, 725);
            this.panel4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "Observation";
            // 
            // richTextBoxObserNiveau
            // 
            this.richTextBoxObserNiveau.Location = new System.Drawing.Point(127, 111);
            this.richTextBoxObserNiveau.Name = "richTextBoxObserNiveau";
            this.richTextBoxObserNiveau.Size = new System.Drawing.Size(272, 96);
            this.richTextBoxObserNiveau.TabIndex = 25;
            this.richTextBoxObserNiveau.Text = "";
            // 
            // txtIDNiveauTransMvt
            // 
            this.txtIDNiveauTransMvt.BackColor = System.Drawing.Color.White;
            this.txtIDNiveauTransMvt.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDNiveauTransMvt.Location = new System.Drawing.Point(127, 6);
            this.txtIDNiveauTransMvt.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDNiveauTransMvt.Name = "txtIDNiveauTransMvt";
            this.txtIDNiveauTransMvt.ReadOnly = true;
            this.txtIDNiveauTransMvt.Size = new System.Drawing.Size(126, 29);
            this.txtIDNiveauTransMvt.TabIndex = 24;
            this.txtIDNiveauTransMvt.Visible = false;
            // 
            // txtDescriptionNiveauTransMvt
            // 
            this.txtDescriptionNiveauTransMvt.BackColor = System.Drawing.Color.White;
            this.txtDescriptionNiveauTransMvt.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescriptionNiveauTransMvt.Location = new System.Drawing.Point(127, 43);
            this.txtDescriptionNiveauTransMvt.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescriptionNiveauTransMvt.Name = "txtDescriptionNiveauTransMvt";
            this.txtDescriptionNiveauTransMvt.Size = new System.Drawing.Size(278, 29);
            this.txtDescriptionNiveauTransMvt.TabIndex = 22;
            // 
            // btnEditNiveauTransMvt
            // 
            this.btnEditNiveauTransMvt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnEditNiveauTransMvt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditNiveauTransMvt.ForeColor = System.Drawing.Color.Black;
            this.btnEditNiveauTransMvt.IconChar = FontAwesome.Sharp.IconChar.PencilSquare;
            this.btnEditNiveauTransMvt.IconColor = System.Drawing.Color.White;
            this.btnEditNiveauTransMvt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditNiveauTransMvt.IconSize = 20;
            this.btnEditNiveauTransMvt.Location = new System.Drawing.Point(222, 235);
            this.btnEditNiveauTransMvt.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditNiveauTransMvt.Name = "btnEditNiveauTransMvt";
            this.btnEditNiveauTransMvt.Size = new System.Drawing.Size(84, 28);
            this.btnEditNiveauTransMvt.TabIndex = 21;
            this.btnEditNiveauTransMvt.Text = "Editer";
            this.btnEditNiveauTransMvt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditNiveauTransMvt.UseVisualStyleBackColor = false;
            this.btnEditNiveauTransMvt.Click += new System.EventHandler(this.btnEditNiveauTransMvt_Click);
            // 
            // btnNiveauTransMvt
            // 
            this.btnNiveauTransMvt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnNiveauTransMvt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNiveauTransMvt.ForeColor = System.Drawing.Color.Black;
            this.btnNiveauTransMvt.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
            this.btnNiveauTransMvt.IconColor = System.Drawing.Color.White;
            this.btnNiveauTransMvt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNiveauTransMvt.IconSize = 20;
            this.btnNiveauTransMvt.Location = new System.Drawing.Point(127, 235);
            this.btnNiveauTransMvt.Margin = new System.Windows.Forms.Padding(4);
            this.btnNiveauTransMvt.Name = "btnNiveauTransMvt";
            this.btnNiveauTransMvt.Size = new System.Drawing.Size(87, 28);
            this.btnNiveauTransMvt.TabIndex = 20;
            this.btnNiveauTransMvt.Text = "Valider";
            this.btnNiveauTransMvt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNiveauTransMvt.UseVisualStyleBackColor = false;
            this.btnNiveauTransMvt.Click += new System.EventHandler(this.btnNiveauTransMvt_Click);
            // 
            // BtnAnnulerNiveauTransMvt
            // 
            this.BtnAnnulerNiveauTransMvt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.BtnAnnulerNiveauTransMvt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnnulerNiveauTransMvt.ForeColor = System.Drawing.Color.Black;
            this.BtnAnnulerNiveauTransMvt.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.BtnAnnulerNiveauTransMvt.IconColor = System.Drawing.Color.White;
            this.BtnAnnulerNiveauTransMvt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAnnulerNiveauTransMvt.IconSize = 20;
            this.BtnAnnulerNiveauTransMvt.Location = new System.Drawing.Point(314, 235);
            this.BtnAnnulerNiveauTransMvt.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAnnulerNiveauTransMvt.Name = "BtnAnnulerNiveauTransMvt";
            this.BtnAnnulerNiveauTransMvt.Size = new System.Drawing.Size(91, 28);
            this.BtnAnnulerNiveauTransMvt.TabIndex = 19;
            this.BtnAnnulerNiveauTransMvt.Text = "Annuler";
            this.BtnAnnulerNiveauTransMvt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAnnulerNiveauTransMvt.UseVisualStyleBackColor = false;
            this.BtnAnnulerNiveauTransMvt.Click += new System.EventHandler(this.BtnAnnulerNiveauTransMvt_Click);
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
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(422, 25);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(808, 19);
            this.panel5.TabIndex = 5;
            // 
            // dgvNiveauTransitionVehi
            // 
            this.dgvNiveauTransitionVehi.AllowUserToOrderColumns = true;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            this.dgvNiveauTransitionVehi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvNiveauTransitionVehi.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNiveauTransitionVehi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvNiveauTransitionVehi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNiveauTransitionVehi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_NIVVAL,
            this.DESCRIPTION_NIVVAL,
            this.DATECREATE_NIVVAL,
            this.USERCREATE_NIVVAL,
            this.DATEMODIFY_NIVVAL,
            this.USERMODIFY_NIVVAL,
            this.OBSERVATION_NIVVAL});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNiveauTransitionVehi.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvNiveauTransitionVehi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNiveauTransitionVehi.GridColor = System.Drawing.Color.White;
            this.dgvNiveauTransitionVehi.Location = new System.Drawing.Point(422, 44);
            this.dgvNiveauTransitionVehi.Name = "dgvNiveauTransitionVehi";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNiveauTransitionVehi.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvNiveauTransitionVehi.RowHeadersWidth = 51;
            this.dgvNiveauTransitionVehi.RowTemplate.Height = 24;
            this.dgvNiveauTransitionVehi.Size = new System.Drawing.Size(808, 706);
            this.dgvNiveauTransitionVehi.TabIndex = 6;
            this.dgvNiveauTransitionVehi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransitionDemandeVehi_CellClick);
            // 
            // ID_NIVVAL
            // 
            this.ID_NIVVAL.DataPropertyName = "ID_NIVVAL";
            this.ID_NIVVAL.HeaderText = "IdNiveau";
            this.ID_NIVVAL.MinimumWidth = 6;
            this.ID_NIVVAL.Name = "ID_NIVVAL";
            this.ID_NIVVAL.ReadOnly = true;
            this.ID_NIVVAL.Visible = false;
            this.ID_NIVVAL.Width = 125;
            // 
            // DESCRIPTION_NIVVAL
            // 
            this.DESCRIPTION_NIVVAL.DataPropertyName = "DESCRIPTION_NIVVAL";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DESCRIPTION_NIVVAL.DefaultCellStyle = dataGridViewCellStyle19;
            this.DESCRIPTION_NIVVAL.HeaderText = "Description";
            this.DESCRIPTION_NIVVAL.MinimumWidth = 6;
            this.DESCRIPTION_NIVVAL.Name = "DESCRIPTION_NIVVAL";
            this.DESCRIPTION_NIVVAL.ReadOnly = true;
            this.DESCRIPTION_NIVVAL.Width = 125;
            // 
            // DATECREATE_NIVVAL
            // 
            this.DATECREATE_NIVVAL.DataPropertyName = "DATECREATE_NIVVAL";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DATECREATE_NIVVAL.DefaultCellStyle = dataGridViewCellStyle20;
            this.DATECREATE_NIVVAL.HeaderText = "Créer le";
            this.DATECREATE_NIVVAL.MinimumWidth = 6;
            this.DATECREATE_NIVVAL.Name = "DATECREATE_NIVVAL";
            this.DATECREATE_NIVVAL.ReadOnly = true;
            this.DATECREATE_NIVVAL.Width = 125;
            // 
            // USERCREATE_NIVVAL
            // 
            this.USERCREATE_NIVVAL.DataPropertyName = "USERCREATE_NIVVAL";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.USERCREATE_NIVVAL.DefaultCellStyle = dataGridViewCellStyle21;
            this.USERCREATE_NIVVAL.HeaderText = "Créer par";
            this.USERCREATE_NIVVAL.MinimumWidth = 6;
            this.USERCREATE_NIVVAL.Name = "USERCREATE_NIVVAL";
            this.USERCREATE_NIVVAL.ReadOnly = true;
            this.USERCREATE_NIVVAL.Width = 125;
            // 
            // DATEMODIFY_NIVVAL
            // 
            this.DATEMODIFY_NIVVAL.DataPropertyName = "DATEMODIFY_NIVVAL";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DATEMODIFY_NIVVAL.DefaultCellStyle = dataGridViewCellStyle22;
            this.DATEMODIFY_NIVVAL.HeaderText = "Modifier le";
            this.DATEMODIFY_NIVVAL.MinimumWidth = 6;
            this.DATEMODIFY_NIVVAL.Name = "DATEMODIFY_NIVVAL";
            this.DATEMODIFY_NIVVAL.ReadOnly = true;
            this.DATEMODIFY_NIVVAL.Width = 125;
            // 
            // USERMODIFY_NIVVAL
            // 
            this.USERMODIFY_NIVVAL.DataPropertyName = "USERMODIFY_NIVVAL";
            this.USERMODIFY_NIVVAL.HeaderText = "Modifier par";
            this.USERMODIFY_NIVVAL.MinimumWidth = 50;
            this.USERMODIFY_NIVVAL.Name = "USERMODIFY_NIVVAL";
            this.USERMODIFY_NIVVAL.ReadOnly = true;
            this.USERMODIFY_NIVVAL.Width = 150;
            // 
            // OBSERVATION_NIVVAL
            // 
            this.OBSERVATION_NIVVAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OBSERVATION_NIVVAL.DataPropertyName = "OBSERVATION_NIVVAL";
            this.OBSERVATION_NIVVAL.HeaderText = "Observation";
            this.OBSERVATION_NIVVAL.MinimumWidth = 50;
            this.OBSERVATION_NIVVAL.Name = "OBSERVATION_NIVVAL";
            this.OBSERVATION_NIVVAL.ReadOnly = true;
            // 
            // MenuNiveau
            // 
            this.MenuNiveau.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuNiveau.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemDeleteNiveau});
            this.MenuNiveau.Name = "MenuNiveau";
            this.MenuNiveau.Size = new System.Drawing.Size(154, 30);
            // 
            // MenuItemDeleteNiveau
            // 
            this.MenuItemDeleteNiveau.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuItemDeleteNiveau.ForeColor = System.Drawing.Color.Black;
            this.MenuItemDeleteNiveau.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemDeleteNiveau.Image")));
            this.MenuItemDeleteNiveau.Name = "MenuItemDeleteNiveau";
            this.MenuItemDeleteNiveau.Size = new System.Drawing.Size(153, 26);
            this.MenuItemDeleteNiveau.Text = "Supprimer";
            this.MenuItemDeleteNiveau.Click += new System.EventHandler(this.MenuItemDeleteNiveau_Click);
            // 
            // FormNiveauTransitionDemandeCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 766);
            this.Controls.Add(this.dgvNiveauTransitionVehi);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormNiveauTransitionDemandeCar";
            this.Text = "FormNiveauTransitionDemandeCar";
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiveauTransitionVehi)).EndInit();
            this.MenuNiveau.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnRafraichirTransMvt;
        private FontAwesome.Sharp.IconButton BtnExportTransMvt;
        private FontAwesome.Sharp.IconButton BtnImportTransMvt;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtIDNiveauTransMvt;
        private System.Windows.Forms.TextBox txtDescriptionNiveauTransMvt;
        private FontAwesome.Sharp.IconButton btnEditNiveauTransMvt;
        private FontAwesome.Sharp.IconButton btnNiveauTransMvt;
        private FontAwesome.Sharp.IconButton BtnAnnulerNiveauTransMvt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvNiveauTransitionVehi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxObserNiveau;
        private System.Windows.Forms.ContextMenuStrip MenuNiveau;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDeleteNiveau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_NIVVAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_NIVVAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATECREATE_NIVVAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERCREATE_NIVVAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATEMODIFY_NIVVAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERMODIFY_NIVVAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBSERVATION_NIVVAL;
        private FontAwesome.Sharp.IconButton btnCloseNiveau;
    }
}