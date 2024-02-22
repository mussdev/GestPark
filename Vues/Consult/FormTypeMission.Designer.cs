namespace GestPark.Vues.Consult
{
    partial class FormTypeMission
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTypeMission));
            this.panelMarqueTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRegisterMarq = new System.Windows.Forms.Panel();
            this.txtIdType = new System.Windows.Forms.TextBox();
            this.RTxtNoteType = new System.Windows.Forms.RichTextBox();
            this.DescriptionType = new System.Windows.Forms.TextBox();
            this.TxtCodType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFilterType = new System.Windows.Forms.TextBox();
            this.TotalType = new System.Windows.Forms.Label();
            this.btnEditType = new FontAwesome.Sharp.IconButton();
            this.btnValiderType = new FontAwesome.Sharp.IconButton();
            this.BtnAnnulerType = new FontAwesome.Sharp.IconButton();
            this.btnRafraichirDir = new FontAwesome.Sharp.IconButton();
            this.BtnExportDirection = new FontAwesome.Sharp.IconButton();
            this.BtnImportDirec = new FontAwesome.Sharp.IconButton();
            this.BtnCloseFormDir = new FontAwesome.Sharp.IconButton();
            this.dgvDir = new System.Windows.Forms.DataGridView();
            this.ID_DIR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE_DIR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_DIR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTE_DIR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERCREATE_DIR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_DIR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMarqueTitle.SuspendLayout();
            this.panelRegisterMarq.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDir)).BeginInit();
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
            this.panelMarqueTitle.Size = new System.Drawing.Size(1255, 25);
            this.panelMarqueTitle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(750, -2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type de mission";
            // 
            // panelRegisterMarq
            // 
            this.panelRegisterMarq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.panelRegisterMarq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelRegisterMarq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRegisterMarq.Controls.Add(this.txtIdType);
            this.panelRegisterMarq.Controls.Add(this.btnEditType);
            this.panelRegisterMarq.Controls.Add(this.btnValiderType);
            this.panelRegisterMarq.Controls.Add(this.BtnAnnulerType);
            this.panelRegisterMarq.Controls.Add(this.RTxtNoteType);
            this.panelRegisterMarq.Controls.Add(this.DescriptionType);
            this.panelRegisterMarq.Controls.Add(this.TxtCodType);
            this.panelRegisterMarq.Controls.Add(this.label4);
            this.panelRegisterMarq.Controls.Add(this.label3);
            this.panelRegisterMarq.Controls.Add(this.label2);
            this.panelRegisterMarq.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRegisterMarq.Location = new System.Drawing.Point(0, 25);
            this.panelRegisterMarq.Margin = new System.Windows.Forms.Padding(4);
            this.panelRegisterMarq.Name = "panelRegisterMarq";
            this.panelRegisterMarq.Size = new System.Drawing.Size(430, 792);
            this.panelRegisterMarq.TabIndex = 4;
            // 
            // txtIdType
            // 
            this.txtIdType.Location = new System.Drawing.Point(132, 8);
            this.txtIdType.Name = "txtIdType";
            this.txtIdType.Size = new System.Drawing.Size(127, 22);
            this.txtIdType.TabIndex = 10;
            this.txtIdType.Visible = false;
            // 
            // RTxtNoteType
            // 
            this.RTxtNoteType.BackColor = System.Drawing.Color.White;
            this.RTxtNoteType.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTxtNoteType.Location = new System.Drawing.Point(132, 203);
            this.RTxtNoteType.Margin = new System.Windows.Forms.Padding(4);
            this.RTxtNoteType.Name = "RTxtNoteType";
            this.RTxtNoteType.Size = new System.Drawing.Size(288, 82);
            this.RTxtNoteType.TabIndex = 5;
            this.RTxtNoteType.Text = "";
            // 
            // DescriptionType
            // 
            this.DescriptionType.BackColor = System.Drawing.Color.White;
            this.DescriptionType.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionType.Location = new System.Drawing.Point(132, 124);
            this.DescriptionType.Margin = new System.Windows.Forms.Padding(4);
            this.DescriptionType.Name = "DescriptionType";
            this.DescriptionType.Size = new System.Drawing.Size(288, 29);
            this.DescriptionType.TabIndex = 4;
            // 
            // TxtCodType
            // 
            this.TxtCodType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.TxtCodType.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodType.ForeColor = System.Drawing.Color.Black;
            this.TxtCodType.Location = new System.Drawing.Point(132, 47);
            this.TxtCodType.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCodType.Name = "TxtCodType";
            this.TxtCodType.ReadOnly = true;
            this.TxtCodType.Size = new System.Drawing.Size(127, 28);
            this.TxtCodType.TabIndex = 3;
            this.TxtCodType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.panel1.Controls.Add(this.txtFilterType);
            this.panel1.Controls.Add(this.TotalType);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(430, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 29);
            this.panel1.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(481, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 19);
            this.label10.TabIndex = 20;
            this.label10.Text = "Filtrer";
            // 
            // txtFilterType
            // 
            this.txtFilterType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterType.BackColor = System.Drawing.Color.White;
            this.txtFilterType.ForeColor = System.Drawing.Color.Black;
            this.txtFilterType.Location = new System.Drawing.Point(549, 1);
            this.txtFilterType.Name = "txtFilterType";
            this.txtFilterType.Size = new System.Drawing.Size(276, 22);
            this.txtFilterType.TabIndex = 19;
            // 
            // TotalType
            // 
            this.TotalType.AutoSize = true;
            this.TotalType.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalType.ForeColor = System.Drawing.Color.Maroon;
            this.TotalType.Location = new System.Drawing.Point(4, 10);
            this.TotalType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalType.Name = "TotalType";
            this.TotalType.Size = new System.Drawing.Size(98, 17);
            this.TotalType.TabIndex = 0;
            this.TotalType.Text = "Total type = 0";
            // 
            // btnEditType
            // 
            this.btnEditType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnEditType.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditType.ForeColor = System.Drawing.Color.Black;
            this.btnEditType.IconChar = FontAwesome.Sharp.IconChar.PencilSquare;
            this.btnEditType.IconColor = System.Drawing.Color.White;
            this.btnEditType.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditType.IconSize = 20;
            this.btnEditType.Location = new System.Drawing.Point(202, 330);
            this.btnEditType.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditType.Name = "btnEditType";
            this.btnEditType.Size = new System.Drawing.Size(84, 28);
            this.btnEditType.TabIndex = 9;
            this.btnEditType.Text = "Editer";
            this.btnEditType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditType.UseVisualStyleBackColor = false;
            // 
            // btnValiderType
            // 
            this.btnValiderType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnValiderType.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValiderType.ForeColor = System.Drawing.Color.Black;
            this.btnValiderType.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
            this.btnValiderType.IconColor = System.Drawing.Color.White;
            this.btnValiderType.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnValiderType.IconSize = 20;
            this.btnValiderType.Location = new System.Drawing.Point(107, 330);
            this.btnValiderType.Margin = new System.Windows.Forms.Padding(4);
            this.btnValiderType.Name = "btnValiderType";
            this.btnValiderType.Size = new System.Drawing.Size(87, 28);
            this.btnValiderType.TabIndex = 8;
            this.btnValiderType.Text = "Valider";
            this.btnValiderType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnValiderType.UseVisualStyleBackColor = false;
            // 
            // BtnAnnulerType
            // 
            this.BtnAnnulerType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.BtnAnnulerType.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnnulerType.ForeColor = System.Drawing.Color.Black;
            this.BtnAnnulerType.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.BtnAnnulerType.IconColor = System.Drawing.Color.White;
            this.BtnAnnulerType.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAnnulerType.IconSize = 20;
            this.BtnAnnulerType.Location = new System.Drawing.Point(294, 330);
            this.BtnAnnulerType.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAnnulerType.Name = "BtnAnnulerType";
            this.BtnAnnulerType.Size = new System.Drawing.Size(91, 28);
            this.BtnAnnulerType.TabIndex = 7;
            this.BtnAnnulerType.Text = "Annuler";
            this.BtnAnnulerType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAnnulerType.UseVisualStyleBackColor = false;
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
            this.BtnCloseFormDir.Location = new System.Drawing.Point(1223, -2);
            this.BtnCloseFormDir.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCloseFormDir.Name = "BtnCloseFormDir";
            this.BtnCloseFormDir.Size = new System.Drawing.Size(31, 25);
            this.BtnCloseFormDir.TabIndex = 0;
            this.BtnCloseFormDir.UseVisualStyleBackColor = false;
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
            this.dgvDir.Size = new System.Drawing.Size(825, 763);
            this.dgvDir.TabIndex = 6;
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
            // FormTypeMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 817);
            this.Controls.Add(this.dgvDir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelRegisterMarq);
            this.Controls.Add(this.panelMarqueTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTypeMission";
            this.Text = "Type de mission";
            this.panelMarqueTitle.ResumeLayout(false);
            this.panelMarqueTitle.PerformLayout();
            this.panelRegisterMarq.ResumeLayout(false);
            this.panelRegisterMarq.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMarqueTitle;
        private FontAwesome.Sharp.IconButton btnRafraichirDir;
        private FontAwesome.Sharp.IconButton BtnExportDirection;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BtnImportDirec;
        private FontAwesome.Sharp.IconButton BtnCloseFormDir;
        private System.Windows.Forms.Panel panelRegisterMarq;
        private System.Windows.Forms.TextBox txtIdType;
        private FontAwesome.Sharp.IconButton btnEditType;
        private FontAwesome.Sharp.IconButton btnValiderType;
        private FontAwesome.Sharp.IconButton BtnAnnulerType;
        private System.Windows.Forms.RichTextBox RTxtNoteType;
        private System.Windows.Forms.TextBox DescriptionType;
        private System.Windows.Forms.TextBox TxtCodType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFilterType;
        private System.Windows.Forms.Label TotalType;
        private System.Windows.Forms.DataGridView dgvDir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_DIR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_DIR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_DIR;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTE_DIR;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERCREATE_DIR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_DIR;
    }
}