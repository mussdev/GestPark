namespace GestPark
{
    partial class FormDirection
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDirection));
            this.panelMarqueTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRegisterMarq = new System.Windows.Forms.Panel();
            this.txtIdDir = new System.Windows.Forms.TextBox();
            this.RTxtNoteDir = new System.Windows.Forms.RichTextBox();
            this.DescriptionDir = new System.Windows.Forms.TextBox();
            this.TxtCodDir = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFilterDir = new System.Windows.Forms.TextBox();
            this.TotalDir = new System.Windows.Forms.Label();
            this.dgvDir = new System.Windows.Forms.DataGridView();
            this.ID_DIR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE_DIR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_DIR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTE_DIR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERCREATE_DIR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_DIR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuDeleteDir = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ItemMenuDeleteDir = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditDir = new FontAwesome.Sharp.IconButton();
            this.btnValiderDir = new FontAwesome.Sharp.IconButton();
            this.BtnAnnulerDir = new FontAwesome.Sharp.IconButton();
            this.btnRafraichirDir = new FontAwesome.Sharp.IconButton();
            this.BtnExportDirection = new FontAwesome.Sharp.IconButton();
            this.BtnImportDirec = new FontAwesome.Sharp.IconButton();
            this.BtnCloseFormDir = new FontAwesome.Sharp.IconButton();
            this.panelMarqueTitle.SuspendLayout();
            this.panelRegisterMarq.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDir)).BeginInit();
            this.menuDeleteDir.SuspendLayout();
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
            this.panelMarqueTitle.Controls.Add(this.BtnCloseFormDir);
            this.panelMarqueTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMarqueTitle.Location = new System.Drawing.Point(0, 0);
            this.panelMarqueTitle.Margin = new System.Windows.Forms.Padding(4);
            this.panelMarqueTitle.Name = "panelMarqueTitle";
            this.panelMarqueTitle.Size = new System.Drawing.Size(1381, 25);
            this.panelMarqueTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(750, -2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Directions";
            // 
            // panelRegisterMarq
            // 
            this.panelRegisterMarq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.panelRegisterMarq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelRegisterMarq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRegisterMarq.Controls.Add(this.txtIdDir);
            this.panelRegisterMarq.Controls.Add(this.btnEditDir);
            this.panelRegisterMarq.Controls.Add(this.btnValiderDir);
            this.panelRegisterMarq.Controls.Add(this.BtnAnnulerDir);
            this.panelRegisterMarq.Controls.Add(this.RTxtNoteDir);
            this.panelRegisterMarq.Controls.Add(this.DescriptionDir);
            this.panelRegisterMarq.Controls.Add(this.TxtCodDir);
            this.panelRegisterMarq.Controls.Add(this.label4);
            this.panelRegisterMarq.Controls.Add(this.label3);
            this.panelRegisterMarq.Controls.Add(this.label2);
            this.panelRegisterMarq.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRegisterMarq.Location = new System.Drawing.Point(0, 25);
            this.panelRegisterMarq.Margin = new System.Windows.Forms.Padding(4);
            this.panelRegisterMarq.Name = "panelRegisterMarq";
            this.panelRegisterMarq.Size = new System.Drawing.Size(430, 668);
            this.panelRegisterMarq.TabIndex = 3;
            // 
            // txtIdDir
            // 
            this.txtIdDir.Location = new System.Drawing.Point(132, 8);
            this.txtIdDir.Name = "txtIdDir";
            this.txtIdDir.Size = new System.Drawing.Size(127, 28);
            this.txtIdDir.TabIndex = 10;
            this.txtIdDir.Visible = false;
            // 
            // RTxtNoteDir
            // 
            this.RTxtNoteDir.BackColor = System.Drawing.Color.White;
            this.RTxtNoteDir.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTxtNoteDir.Location = new System.Drawing.Point(132, 203);
            this.RTxtNoteDir.Margin = new System.Windows.Forms.Padding(4);
            this.RTxtNoteDir.Name = "RTxtNoteDir";
            this.RTxtNoteDir.Size = new System.Drawing.Size(288, 82);
            this.RTxtNoteDir.TabIndex = 5;
            this.RTxtNoteDir.Text = "";
            // 
            // DescriptionDir
            // 
            this.DescriptionDir.BackColor = System.Drawing.Color.White;
            this.DescriptionDir.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionDir.Location = new System.Drawing.Point(132, 124);
            this.DescriptionDir.Margin = new System.Windows.Forms.Padding(4);
            this.DescriptionDir.Name = "DescriptionDir";
            this.DescriptionDir.Size = new System.Drawing.Size(288, 29);
            this.DescriptionDir.TabIndex = 4;
            // 
            // TxtCodDir
            // 
            this.TxtCodDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.TxtCodDir.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodDir.ForeColor = System.Drawing.Color.Black;
            this.TxtCodDir.Location = new System.Drawing.Point(132, 47);
            this.TxtCodDir.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCodDir.Name = "TxtCodDir";
            this.TxtCodDir.ReadOnly = true;
            this.TxtCodDir.Size = new System.Drawing.Size(127, 28);
            this.TxtCodDir.TabIndex = 3;
            this.TxtCodDir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(5, 206);
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
            this.panel1.Controls.Add(this.txtFilterDir);
            this.panel1.Controls.Add(this.TotalDir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(430, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 29);
            this.panel1.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(607, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 19);
            this.label10.TabIndex = 20;
            this.label10.Text = "Filtrer";
            // 
            // txtFilterDir
            // 
            this.txtFilterDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterDir.BackColor = System.Drawing.Color.White;
            this.txtFilterDir.ForeColor = System.Drawing.Color.Black;
            this.txtFilterDir.Location = new System.Drawing.Point(675, 1);
            this.txtFilterDir.Name = "txtFilterDir";
            this.txtFilterDir.Size = new System.Drawing.Size(276, 28);
            this.txtFilterDir.TabIndex = 19;
            this.txtFilterDir.TextChanged += new System.EventHandler(this.txtFilterDir_TextChanged);
            // 
            // TotalDir
            // 
            this.TotalDir.AutoSize = true;
            this.TotalDir.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalDir.ForeColor = System.Drawing.Color.Maroon;
            this.TotalDir.Location = new System.Drawing.Point(4, 10);
            this.TotalDir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalDir.Name = "TotalDir";
            this.TotalDir.Size = new System.Drawing.Size(128, 17);
            this.TotalDir.TabIndex = 0;
            this.TotalDir.Text = "Total direction = 0";
            // 
            // dgvDir
            // 
            this.dgvDir.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDir.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDir.BackgroundColor = System.Drawing.Color.White;
            this.dgvDir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDir.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDir.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_DIR,
            this.CODE_DIR,
            this.DESCRIPTION_DIR,
            this.NOTE_DIR,
            this.USERCREATE_DIR,
            this.DATE_DIR});
            this.dgvDir.ContextMenuStrip = this.menuDeleteDir;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDir.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDir.GridColor = System.Drawing.Color.White;
            this.dgvDir.Location = new System.Drawing.Point(430, 54);
            this.dgvDir.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDir.Name = "dgvDir";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDir.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDir.RowHeadersWidth = 51;
            this.dgvDir.Size = new System.Drawing.Size(951, 639);
            this.dgvDir.TabIndex = 5;
            this.dgvDir.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDir_CellClick);
            this.dgvDir.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewDir_CellMouseUp);
            // 
            // ID_DIR
            // 
            this.ID_DIR.DataPropertyName = "ID_DIR";
            this.ID_DIR.HeaderText = "IdDirection";
            this.ID_DIR.MinimumWidth = 6;
            this.ID_DIR.Name = "ID_DIR";
            this.ID_DIR.ReadOnly = true;
            this.ID_DIR.Visible = false;
            this.ID_DIR.Width = 125;
            // 
            // CODE_DIR
            // 
            this.CODE_DIR.DataPropertyName = "CODE_DIR";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CODE_DIR.DefaultCellStyle = dataGridViewCellStyle3;
            this.CODE_DIR.HeaderText = "Code";
            this.CODE_DIR.MinimumWidth = 6;
            this.CODE_DIR.Name = "CODE_DIR";
            this.CODE_DIR.Width = 80;
            // 
            // DESCRIPTION_DIR
            // 
            this.DESCRIPTION_DIR.DataPropertyName = "DESCRIPTION_DIR";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DESCRIPTION_DIR.DefaultCellStyle = dataGridViewCellStyle4;
            this.DESCRIPTION_DIR.HeaderText = "Description";
            this.DESCRIPTION_DIR.MinimumWidth = 6;
            this.DESCRIPTION_DIR.Name = "DESCRIPTION_DIR";
            this.DESCRIPTION_DIR.Width = 350;
            // 
            // NOTE_DIR
            // 
            this.NOTE_DIR.DataPropertyName = "NOTE_DIR";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.NOTE_DIR.DefaultCellStyle = dataGridViewCellStyle5;
            this.NOTE_DIR.HeaderText = "Note";
            this.NOTE_DIR.MinimumWidth = 6;
            this.NOTE_DIR.Name = "NOTE_DIR";
            this.NOTE_DIR.Width = 500;
            // 
            // USERCREATE_DIR
            // 
            this.USERCREATE_DIR.DataPropertyName = "USERCREATE_DIR";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.USERCREATE_DIR.DefaultCellStyle = dataGridViewCellStyle6;
            this.USERCREATE_DIR.HeaderText = "Créer par";
            this.USERCREATE_DIR.MinimumWidth = 6;
            this.USERCREATE_DIR.Name = "USERCREATE_DIR";
            this.USERCREATE_DIR.Width = 150;
            // 
            // DATE_DIR
            // 
            this.DATE_DIR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DATE_DIR.DataPropertyName = "DATE_DIR";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DATE_DIR.DefaultCellStyle = dataGridViewCellStyle7;
            this.DATE_DIR.HeaderText = "Créer le";
            this.DATE_DIR.MinimumWidth = 125;
            this.DATE_DIR.Name = "DATE_DIR";
            // 
            // menuDeleteDir
            // 
            this.menuDeleteDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.menuDeleteDir.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuDeleteDir.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuDeleteDir.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemMenuDeleteDir});
            this.menuDeleteDir.Name = "menuDeleteDir";
            this.menuDeleteDir.Size = new System.Drawing.Size(141, 30);
            // 
            // ItemMenuDeleteDir
            // 
            this.ItemMenuDeleteDir.Image = ((System.Drawing.Image)(resources.GetObject("ItemMenuDeleteDir.Image")));
            this.ItemMenuDeleteDir.Name = "ItemMenuDeleteDir";
            this.ItemMenuDeleteDir.Size = new System.Drawing.Size(140, 26);
            this.ItemMenuDeleteDir.Text = "Supprimer";
            this.ItemMenuDeleteDir.Click += new System.EventHandler(this.ItemMenuDeleteDir_Click);
            // 
            // btnEditDir
            // 
            this.btnEditDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnEditDir.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDir.ForeColor = System.Drawing.Color.Black;
            this.btnEditDir.IconChar = FontAwesome.Sharp.IconChar.PencilSquare;
            this.btnEditDir.IconColor = System.Drawing.Color.White;
            this.btnEditDir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditDir.IconSize = 20;
            this.btnEditDir.Location = new System.Drawing.Point(202, 330);
            this.btnEditDir.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditDir.Name = "btnEditDir";
            this.btnEditDir.Size = new System.Drawing.Size(84, 28);
            this.btnEditDir.TabIndex = 9;
            this.btnEditDir.Text = "Editer";
            this.btnEditDir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditDir.UseVisualStyleBackColor = false;
            this.btnEditDir.Click += new System.EventHandler(this.btnEditDir_Click);
            // 
            // btnValiderDir
            // 
            this.btnValiderDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnValiderDir.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValiderDir.ForeColor = System.Drawing.Color.Black;
            this.btnValiderDir.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
            this.btnValiderDir.IconColor = System.Drawing.Color.White;
            this.btnValiderDir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnValiderDir.IconSize = 20;
            this.btnValiderDir.Location = new System.Drawing.Point(107, 330);
            this.btnValiderDir.Margin = new System.Windows.Forms.Padding(4);
            this.btnValiderDir.Name = "btnValiderDir";
            this.btnValiderDir.Size = new System.Drawing.Size(87, 28);
            this.btnValiderDir.TabIndex = 8;
            this.btnValiderDir.Text = "Valider";
            this.btnValiderDir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnValiderDir.UseVisualStyleBackColor = false;
            this.btnValiderDir.Click += new System.EventHandler(this.btnValiderMarq_Click);
            // 
            // BtnAnnulerDir
            // 
            this.BtnAnnulerDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.BtnAnnulerDir.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnnulerDir.ForeColor = System.Drawing.Color.Black;
            this.BtnAnnulerDir.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.BtnAnnulerDir.IconColor = System.Drawing.Color.White;
            this.BtnAnnulerDir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAnnulerDir.IconSize = 20;
            this.BtnAnnulerDir.Location = new System.Drawing.Point(294, 330);
            this.BtnAnnulerDir.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAnnulerDir.Name = "BtnAnnulerDir";
            this.BtnAnnulerDir.Size = new System.Drawing.Size(91, 28);
            this.BtnAnnulerDir.TabIndex = 7;
            this.BtnAnnulerDir.Text = "Annuler";
            this.BtnAnnulerDir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAnnulerDir.UseVisualStyleBackColor = false;
            this.BtnAnnulerDir.Click += new System.EventHandler(this.BtnAnnulerDir_Click);
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
            this.BtnExportDirection.Click += new System.EventHandler(this.BtnExportDirection_Click);
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
            this.BtnImportDirec.Click += new System.EventHandler(this.BtnImportDirec_Click);
            // 
            // BtnCloseFormDir
            // 
            this.BtnCloseFormDir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnCloseFormDir.BackColor = System.Drawing.Color.Honeydew;
            this.BtnCloseFormDir.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCloseFormDir.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.BtnCloseFormDir.IconColor = System.Drawing.Color.Red;
            this.BtnCloseFormDir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCloseFormDir.IconSize = 20;
            this.BtnCloseFormDir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCloseFormDir.Location = new System.Drawing.Point(1349, -2);
            this.BtnCloseFormDir.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCloseFormDir.Name = "BtnCloseFormDir";
            this.BtnCloseFormDir.Size = new System.Drawing.Size(31, 25);
            this.BtnCloseFormDir.TabIndex = 0;
            this.BtnCloseFormDir.UseVisualStyleBackColor = false;
            this.BtnCloseFormDir.Click += new System.EventHandler(this.BtnCloseFormDir_Click);
            // 
            // FormDirection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1381, 693);
            this.Controls.Add(this.dgvDir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelRegisterMarq);
            this.Controls.Add(this.panelMarqueTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormDirection";
            this.Text = "Direction";
            this.panelMarqueTitle.ResumeLayout(false);
            this.panelMarqueTitle.PerformLayout();
            this.panelRegisterMarq.ResumeLayout(false);
            this.panelRegisterMarq.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDir)).EndInit();
            this.menuDeleteDir.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMarqueTitle;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BtnCloseFormDir;
        private System.Windows.Forms.Panel panelRegisterMarq;
        private FontAwesome.Sharp.IconButton btnValiderDir;
        private FontAwesome.Sharp.IconButton BtnAnnulerDir;
        private System.Windows.Forms.RichTextBox RTxtNoteDir;
        private System.Windows.Forms.TextBox DescriptionDir;
        private System.Windows.Forms.TextBox TxtCodDir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TotalDir;
        private System.Windows.Forms.DataGridView dgvDir;
        private FontAwesome.Sharp.IconButton btnEditDir;
        private FontAwesome.Sharp.IconButton BtnImportDirec;
        private FontAwesome.Sharp.IconButton BtnExportDirection;
        private FontAwesome.Sharp.IconButton btnRafraichirDir;
        private System.Windows.Forms.ContextMenuStrip menuDeleteDir;
        private System.Windows.Forms.ToolStripMenuItem ItemMenuDeleteDir;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFilterDir;
        private System.Windows.Forms.TextBox txtIdDir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_DIR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_DIR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_DIR;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTE_DIR;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERCREATE_DIR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_DIR;
    }
}