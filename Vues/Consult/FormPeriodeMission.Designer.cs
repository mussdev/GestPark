namespace GestPark.Vues.Consult
{
    partial class FormPeriodeMission
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPeriodeMission));
            this.panelMarqueTitle = new System.Windows.Forms.Panel();
            this.btnRafraichirPeriodMission = new FontAwesome.Sharp.IconButton();
            this.BtnExportPeriodMission = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnImportPeriodMission = new FontAwesome.Sharp.IconButton();
            this.BtnCloseFormCategMission = new FontAwesome.Sharp.IconButton();
            this.panelRegisterMarq = new System.Windows.Forms.Panel();
            this.ChkPeriodeLongueMiss = new System.Windows.Forms.CheckBox();
            this.ChkPeriodeMoyenneMiss = new System.Windows.Forms.CheckBox();
            this.ChkPeriodeCourteMiss = new System.Windows.Forms.CheckBox();
            this.TxtMontantPeriodMiss = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdPeriodMiss = new System.Windows.Forms.TextBox();
            this.btnEditPeriodMission = new FontAwesome.Sharp.IconButton();
            this.btnValiderPeriodMission = new FontAwesome.Sharp.IconButton();
            this.BtnAnnulerPeriodMission = new FontAwesome.Sharp.IconButton();
            this.RTxtNotePeriodMiss = new System.Windows.Forms.RichTextBox();
            this.TxtCodPeriodMiss = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFilterPeriodMiss = new System.Windows.Forms.TextBox();
            this.TotalCateg = new System.Windows.Forms.Label();
            this.dgvPeriodMission = new System.Windows.Forms.DataGridView();
            this.ID_PERIODMISS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE_PERIODMISS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONTANT_PERIODMISS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PERIODECOURTE_PERIODMISS = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PERIODEMOYENNE_PERIODMISS = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PERIODELONGUE_PERIODMISS = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NOTE_PERIODMISS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATECREATE_PERIODMISS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATEMODIFIER_CATEG_MISS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuDeletePeriodeMiss = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemDeletePeriodMiss = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMarqueTitle.SuspendLayout();
            this.panelRegisterMarq.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodMission)).BeginInit();
            this.MenuDeletePeriodeMiss.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMarqueTitle
            // 
            this.panelMarqueTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.panelMarqueTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMarqueTitle.Controls.Add(this.btnRafraichirPeriodMission);
            this.panelMarqueTitle.Controls.Add(this.BtnExportPeriodMission);
            this.panelMarqueTitle.Controls.Add(this.label1);
            this.panelMarqueTitle.Controls.Add(this.BtnImportPeriodMission);
            this.panelMarqueTitle.Controls.Add(this.BtnCloseFormCategMission);
            this.panelMarqueTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMarqueTitle.Location = new System.Drawing.Point(0, 0);
            this.panelMarqueTitle.Margin = new System.Windows.Forms.Padding(4);
            this.panelMarqueTitle.Name = "panelMarqueTitle";
            this.panelMarqueTitle.Size = new System.Drawing.Size(1369, 25);
            this.panelMarqueTitle.TabIndex = 4;
            // 
            // btnRafraichirPeriodMission
            // 
            this.btnRafraichirPeriodMission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnRafraichirPeriodMission.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRafraichirPeriodMission.ForeColor = System.Drawing.Color.Black;
            this.btnRafraichirPeriodMission.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.btnRafraichirPeriodMission.IconColor = System.Drawing.Color.White;
            this.btnRafraichirPeriodMission.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRafraichirPeriodMission.IconSize = 20;
            this.btnRafraichirPeriodMission.Location = new System.Drawing.Point(195, -2);
            this.btnRafraichirPeriodMission.Margin = new System.Windows.Forms.Padding(4);
            this.btnRafraichirPeriodMission.Name = "btnRafraichirPeriodMission";
            this.btnRafraichirPeriodMission.Size = new System.Drawing.Size(109, 25);
            this.btnRafraichirPeriodMission.TabIndex = 14;
            this.btnRafraichirPeriodMission.Text = "Rafraîchir";
            this.btnRafraichirPeriodMission.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRafraichirPeriodMission.UseVisualStyleBackColor = false;
            this.btnRafraichirPeriodMission.Click += new System.EventHandler(this.btnRafraichirPeriodMission_Click);
            // 
            // BtnExportPeriodMission
            // 
            this.BtnExportPeriodMission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.BtnExportPeriodMission.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExportPeriodMission.ForeColor = System.Drawing.Color.Black;
            this.BtnExportPeriodMission.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromFile;
            this.BtnExportPeriodMission.IconColor = System.Drawing.Color.White;
            this.BtnExportPeriodMission.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnExportPeriodMission.IconSize = 20;
            this.BtnExportPeriodMission.Location = new System.Drawing.Point(97, -2);
            this.BtnExportPeriodMission.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExportPeriodMission.Name = "BtnExportPeriodMission";
            this.BtnExportPeriodMission.Size = new System.Drawing.Size(97, 25);
            this.BtnExportPeriodMission.TabIndex = 11;
            this.BtnExportPeriodMission.Text = "Exporter";
            this.BtnExportPeriodMission.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExportPeriodMission.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(632, -2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Période de mission";
            // 
            // BtnImportPeriodMission
            // 
            this.BtnImportPeriodMission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.BtnImportPeriodMission.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImportPeriodMission.ForeColor = System.Drawing.Color.Black;
            this.BtnImportPeriodMission.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.BtnImportPeriodMission.IconColor = System.Drawing.Color.White;
            this.BtnImportPeriodMission.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnImportPeriodMission.IconSize = 20;
            this.BtnImportPeriodMission.Location = new System.Drawing.Point(-2, -2);
            this.BtnImportPeriodMission.Margin = new System.Windows.Forms.Padding(4);
            this.BtnImportPeriodMission.Name = "BtnImportPeriodMission";
            this.BtnImportPeriodMission.Size = new System.Drawing.Size(97, 25);
            this.BtnImportPeriodMission.TabIndex = 10;
            this.BtnImportPeriodMission.Text = "Importer";
            this.BtnImportPeriodMission.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnImportPeriodMission.UseVisualStyleBackColor = false;
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
            this.BtnCloseFormCategMission.Location = new System.Drawing.Point(1337, -2);
            this.BtnCloseFormCategMission.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCloseFormCategMission.Name = "BtnCloseFormCategMission";
            this.BtnCloseFormCategMission.Size = new System.Drawing.Size(31, 25);
            this.BtnCloseFormCategMission.TabIndex = 0;
            this.BtnCloseFormCategMission.UseVisualStyleBackColor = false;
            // 
            // panelRegisterMarq
            // 
            this.panelRegisterMarq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.panelRegisterMarq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelRegisterMarq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRegisterMarq.Controls.Add(this.ChkPeriodeLongueMiss);
            this.panelRegisterMarq.Controls.Add(this.ChkPeriodeMoyenneMiss);
            this.panelRegisterMarq.Controls.Add(this.ChkPeriodeCourteMiss);
            this.panelRegisterMarq.Controls.Add(this.TxtMontantPeriodMiss);
            this.panelRegisterMarq.Controls.Add(this.label7);
            this.panelRegisterMarq.Controls.Add(this.txtIdPeriodMiss);
            this.panelRegisterMarq.Controls.Add(this.btnEditPeriodMission);
            this.panelRegisterMarq.Controls.Add(this.btnValiderPeriodMission);
            this.panelRegisterMarq.Controls.Add(this.BtnAnnulerPeriodMission);
            this.panelRegisterMarq.Controls.Add(this.RTxtNotePeriodMiss);
            this.panelRegisterMarq.Controls.Add(this.TxtCodPeriodMiss);
            this.panelRegisterMarq.Controls.Add(this.label4);
            this.panelRegisterMarq.Controls.Add(this.label2);
            this.panelRegisterMarq.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRegisterMarq.ForeColor = System.Drawing.Color.Black;
            this.panelRegisterMarq.Location = new System.Drawing.Point(0, 25);
            this.panelRegisterMarq.Margin = new System.Windows.Forms.Padding(4);
            this.panelRegisterMarq.Name = "panelRegisterMarq";
            this.panelRegisterMarq.Size = new System.Drawing.Size(430, 885);
            this.panelRegisterMarq.TabIndex = 6;
            // 
            // ChkPeriodeLongueMiss
            // 
            this.ChkPeriodeLongueMiss.AutoSize = true;
            this.ChkPeriodeLongueMiss.Location = new System.Drawing.Point(10, 244);
            this.ChkPeriodeLongueMiss.Name = "ChkPeriodeLongueMiss";
            this.ChkPeriodeLongueMiss.Size = new System.Drawing.Size(142, 23);
            this.ChkPeriodeLongueMiss.TabIndex = 20;
            this.ChkPeriodeLongueMiss.Text = "Plus de 21 jours";
            this.ChkPeriodeLongueMiss.UseVisualStyleBackColor = true;
            this.ChkPeriodeLongueMiss.CheckedChanged += new System.EventHandler(this.ChkPeriodeLongueMiss_CheckedChanged);
            // 
            // ChkPeriodeMoyenneMiss
            // 
            this.ChkPeriodeMoyenneMiss.AutoSize = true;
            this.ChkPeriodeMoyenneMiss.Location = new System.Drawing.Point(8, 183);
            this.ChkPeriodeMoyenneMiss.Name = "ChkPeriodeMoyenneMiss";
            this.ChkPeriodeMoyenneMiss.Size = new System.Drawing.Size(121, 23);
            this.ChkPeriodeMoyenneMiss.TabIndex = 19;
            this.ChkPeriodeMoyenneMiss.Text = "16 à 21 jours";
            this.ChkPeriodeMoyenneMiss.UseVisualStyleBackColor = true;
            this.ChkPeriodeMoyenneMiss.CheckedChanged += new System.EventHandler(this.ChkPeriodeMoyenneMiss_CheckedChanged);
            // 
            // ChkPeriodeCourteMiss
            // 
            this.ChkPeriodeCourteMiss.AutoSize = true;
            this.ChkPeriodeCourteMiss.Location = new System.Drawing.Point(8, 126);
            this.ChkPeriodeCourteMiss.Name = "ChkPeriodeCourteMiss";
            this.ChkPeriodeCourteMiss.Size = new System.Drawing.Size(124, 23);
            this.ChkPeriodeCourteMiss.TabIndex = 18;
            this.ChkPeriodeCourteMiss.Text = "0 à 15 jour(s)";
            this.ChkPeriodeCourteMiss.UseVisualStyleBackColor = true;
            this.ChkPeriodeCourteMiss.CheckedChanged += new System.EventHandler(this.ChkPeriodeCourteMiss_CheckedChanged);
            // 
            // TxtMontantPeriodMiss
            // 
            this.TxtMontantPeriodMiss.BackColor = System.Drawing.Color.White;
            this.TxtMontantPeriodMiss.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMontantPeriodMiss.Location = new System.Drawing.Point(155, 300);
            this.TxtMontantPeriodMiss.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMontantPeriodMiss.Name = "TxtMontantPeriodMiss";
            this.TxtMontantPeriodMiss.Size = new System.Drawing.Size(265, 29);
            this.TxtMontantPeriodMiss.TabIndex = 16;
            this.TxtMontantPeriodMiss.Text = "0";
            this.TxtMontantPeriodMiss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(7, 308);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Montant * :";
            // 
            // txtIdPeriodMiss
            // 
            this.txtIdPeriodMiss.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPeriodMiss.ForeColor = System.Drawing.Color.Black;
            this.txtIdPeriodMiss.Location = new System.Drawing.Point(157, 8);
            this.txtIdPeriodMiss.Name = "txtIdPeriodMiss";
            this.txtIdPeriodMiss.Size = new System.Drawing.Size(127, 27);
            this.txtIdPeriodMiss.TabIndex = 10;
            this.txtIdPeriodMiss.Visible = false;
            // 
            // btnEditPeriodMission
            // 
            this.btnEditPeriodMission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnEditPeriodMission.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPeriodMission.ForeColor = System.Drawing.Color.Black;
            this.btnEditPeriodMission.IconChar = FontAwesome.Sharp.IconChar.PencilSquare;
            this.btnEditPeriodMission.IconColor = System.Drawing.Color.White;
            this.btnEditPeriodMission.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditPeriodMission.IconSize = 20;
            this.btnEditPeriodMission.Location = new System.Drawing.Point(200, 510);
            this.btnEditPeriodMission.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditPeriodMission.Name = "btnEditPeriodMission";
            this.btnEditPeriodMission.Size = new System.Drawing.Size(84, 28);
            this.btnEditPeriodMission.TabIndex = 9;
            this.btnEditPeriodMission.Text = "Editer";
            this.btnEditPeriodMission.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditPeriodMission.UseVisualStyleBackColor = false;
            this.btnEditPeriodMission.Click += new System.EventHandler(this.btnEditPeriodMission_Click);
            // 
            // btnValiderPeriodMission
            // 
            this.btnValiderPeriodMission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnValiderPeriodMission.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValiderPeriodMission.ForeColor = System.Drawing.Color.Black;
            this.btnValiderPeriodMission.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
            this.btnValiderPeriodMission.IconColor = System.Drawing.Color.White;
            this.btnValiderPeriodMission.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnValiderPeriodMission.IconSize = 20;
            this.btnValiderPeriodMission.Location = new System.Drawing.Point(105, 510);
            this.btnValiderPeriodMission.Margin = new System.Windows.Forms.Padding(4);
            this.btnValiderPeriodMission.Name = "btnValiderPeriodMission";
            this.btnValiderPeriodMission.Size = new System.Drawing.Size(87, 28);
            this.btnValiderPeriodMission.TabIndex = 8;
            this.btnValiderPeriodMission.Text = "Valider";
            this.btnValiderPeriodMission.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnValiderPeriodMission.UseVisualStyleBackColor = false;
            this.btnValiderPeriodMission.Click += new System.EventHandler(this.btnValiderPeriodMission_Click);
            // 
            // BtnAnnulerPeriodMission
            // 
            this.BtnAnnulerPeriodMission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.BtnAnnulerPeriodMission.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnnulerPeriodMission.ForeColor = System.Drawing.Color.Black;
            this.BtnAnnulerPeriodMission.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.BtnAnnulerPeriodMission.IconColor = System.Drawing.Color.White;
            this.BtnAnnulerPeriodMission.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAnnulerPeriodMission.IconSize = 20;
            this.BtnAnnulerPeriodMission.Location = new System.Drawing.Point(292, 510);
            this.BtnAnnulerPeriodMission.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAnnulerPeriodMission.Name = "BtnAnnulerPeriodMission";
            this.BtnAnnulerPeriodMission.Size = new System.Drawing.Size(91, 28);
            this.BtnAnnulerPeriodMission.TabIndex = 7;
            this.BtnAnnulerPeriodMission.Text = "Annuler";
            this.BtnAnnulerPeriodMission.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAnnulerPeriodMission.UseVisualStyleBackColor = false;
            this.BtnAnnulerPeriodMission.Click += new System.EventHandler(this.BtnAnnulerPeriodMission_Click);
            // 
            // RTxtNotePeriodMiss
            // 
            this.RTxtNotePeriodMiss.BackColor = System.Drawing.Color.White;
            this.RTxtNotePeriodMiss.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTxtNotePeriodMiss.Location = new System.Drawing.Point(155, 376);
            this.RTxtNotePeriodMiss.Margin = new System.Windows.Forms.Padding(4);
            this.RTxtNotePeriodMiss.Name = "RTxtNotePeriodMiss";
            this.RTxtNotePeriodMiss.Size = new System.Drawing.Size(265, 82);
            this.RTxtNotePeriodMiss.TabIndex = 5;
            this.RTxtNotePeriodMiss.Text = "";
            // 
            // TxtCodPeriodMiss
            // 
            this.TxtCodPeriodMiss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.TxtCodPeriodMiss.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodPeriodMiss.ForeColor = System.Drawing.Color.Black;
            this.TxtCodPeriodMiss.Location = new System.Drawing.Point(157, 51);
            this.TxtCodPeriodMiss.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCodPeriodMiss.Name = "TxtCodPeriodMiss";
            this.TxtCodPeriodMiss.ReadOnly = true;
            this.TxtCodPeriodMiss.Size = new System.Drawing.Size(127, 28);
            this.TxtCodPeriodMiss.TabIndex = 3;
            this.TxtCodPeriodMiss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(5, 379);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Note :";
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
            this.panel1.Controls.Add(this.txtFilterPeriodMiss);
            this.panel1.Controls.Add(this.TotalCateg);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(430, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 29);
            this.panel1.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(595, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 19);
            this.label10.TabIndex = 20;
            this.label10.Text = "Filtrer";
            // 
            // txtFilterPeriodMiss
            // 
            this.txtFilterPeriodMiss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterPeriodMiss.BackColor = System.Drawing.Color.White;
            this.txtFilterPeriodMiss.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterPeriodMiss.ForeColor = System.Drawing.Color.Black;
            this.txtFilterPeriodMiss.Location = new System.Drawing.Point(663, 1);
            this.txtFilterPeriodMiss.Name = "txtFilterPeriodMiss";
            this.txtFilterPeriodMiss.Size = new System.Drawing.Size(276, 27);
            this.txtFilterPeriodMiss.TabIndex = 19;
            this.txtFilterPeriodMiss.Text = "0";
            this.txtFilterPeriodMiss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFilterPeriodMiss.TextChanged += new System.EventHandler(this.txtFilterPeriodMiss_TextChanged);
            // 
            // TotalCateg
            // 
            this.TotalCateg.AutoSize = true;
            this.TotalCateg.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCateg.ForeColor = System.Drawing.Color.Maroon;
            this.TotalCateg.Location = new System.Drawing.Point(4, 10);
            this.TotalCateg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalCateg.Name = "TotalCateg";
            this.TotalCateg.Size = new System.Drawing.Size(120, 17);
            this.TotalCateg.TabIndex = 0;
            this.TotalCateg.Text = "Total période = 0";
            // 
            // dgvPeriodMission
            // 
            this.dgvPeriodMission.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvPeriodMission.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPeriodMission.BackgroundColor = System.Drawing.Color.White;
            this.dgvPeriodMission.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeriodMission.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPeriodMission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeriodMission.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PERIODMISS,
            this.CODE_PERIODMISS,
            this.MONTANT_PERIODMISS,
            this.PERIODECOURTE_PERIODMISS,
            this.PERIODEMOYENNE_PERIODMISS,
            this.PERIODELONGUE_PERIODMISS,
            this.NOTE_PERIODMISS,
            this.DATECREATE_PERIODMISS,
            this.DATEMODIFIER_CATEG_MISS});
            this.dgvPeriodMission.ContextMenuStrip = this.MenuDeletePeriodeMiss;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPeriodMission.DefaultCellStyle = dataGridViewCellStyle19;
            this.dgvPeriodMission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPeriodMission.GridColor = System.Drawing.Color.White;
            this.dgvPeriodMission.Location = new System.Drawing.Point(430, 54);
            this.dgvPeriodMission.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPeriodMission.Name = "dgvPeriodMission";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeriodMission.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvPeriodMission.RowHeadersWidth = 51;
            this.dgvPeriodMission.Size = new System.Drawing.Size(939, 856);
            this.dgvPeriodMission.TabIndex = 8;
            this.dgvPeriodMission.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeriodMission_CellClick);
            this.dgvPeriodMission.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPeriodMission_CellMouseUp);
            // 
            // ID_PERIODMISS
            // 
            this.ID_PERIODMISS.DataPropertyName = "ID_PERIODMISS";
            this.ID_PERIODMISS.HeaderText = "IdPeriodeMission";
            this.ID_PERIODMISS.MinimumWidth = 6;
            this.ID_PERIODMISS.Name = "ID_PERIODMISS";
            this.ID_PERIODMISS.ReadOnly = true;
            this.ID_PERIODMISS.Visible = false;
            this.ID_PERIODMISS.Width = 125;
            // 
            // CODE_PERIODMISS
            // 
            this.CODE_PERIODMISS.DataPropertyName = "CODE_PERIODMISS";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CODE_PERIODMISS.DefaultCellStyle = dataGridViewCellStyle7;
            this.CODE_PERIODMISS.HeaderText = "Code";
            this.CODE_PERIODMISS.MinimumWidth = 6;
            this.CODE_PERIODMISS.Name = "CODE_PERIODMISS";
            this.CODE_PERIODMISS.Width = 80;
            // 
            // MONTANT_PERIODMISS
            // 
            this.MONTANT_PERIODMISS.DataPropertyName = "MONTANT_PERIODMISS";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle8.Format = "N0";
            dataGridViewCellStyle8.NullValue = null;
            this.MONTANT_PERIODMISS.DefaultCellStyle = dataGridViewCellStyle8;
            this.MONTANT_PERIODMISS.HeaderText = "Montant";
            this.MONTANT_PERIODMISS.MinimumWidth = 6;
            this.MONTANT_PERIODMISS.Name = "MONTANT_PERIODMISS";
            this.MONTANT_PERIODMISS.ReadOnly = true;
            this.MONTANT_PERIODMISS.Width = 150;
            // 
            // PERIODECOURTE_PERIODMISS
            // 
            this.PERIODECOURTE_PERIODMISS.DataPropertyName = "PERIODECOURTE_PERIODMISS";
            this.PERIODECOURTE_PERIODMISS.HeaderText = "Période de 0 à 15 jr(s)";
            this.PERIODECOURTE_PERIODMISS.MinimumWidth = 6;
            this.PERIODECOURTE_PERIODMISS.Name = "PERIODECOURTE_PERIODMISS";
            this.PERIODECOURTE_PERIODMISS.ReadOnly = true;
            this.PERIODECOURTE_PERIODMISS.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PERIODECOURTE_PERIODMISS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PERIODECOURTE_PERIODMISS.Width = 200;
            // 
            // PERIODEMOYENNE_PERIODMISS
            // 
            this.PERIODEMOYENNE_PERIODMISS.DataPropertyName = "PERIODEMOYENNE_PERIODMISS";
            this.PERIODEMOYENNE_PERIODMISS.HeaderText = "Période de 16 à 21 jrs";
            this.PERIODEMOYENNE_PERIODMISS.MinimumWidth = 6;
            this.PERIODEMOYENNE_PERIODMISS.Name = "PERIODEMOYENNE_PERIODMISS";
            this.PERIODEMOYENNE_PERIODMISS.ReadOnly = true;
            this.PERIODEMOYENNE_PERIODMISS.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PERIODEMOYENNE_PERIODMISS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PERIODEMOYENNE_PERIODMISS.Width = 200;
            // 
            // PERIODELONGUE_PERIODMISS
            // 
            this.PERIODELONGUE_PERIODMISS.DataPropertyName = "PERIODELONGUE_PERIODMISS";
            this.PERIODELONGUE_PERIODMISS.HeaderText = "Plus de 21 jrs";
            this.PERIODELONGUE_PERIODMISS.MinimumWidth = 6;
            this.PERIODELONGUE_PERIODMISS.Name = "PERIODELONGUE_PERIODMISS";
            this.PERIODELONGUE_PERIODMISS.ReadOnly = true;
            this.PERIODELONGUE_PERIODMISS.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PERIODELONGUE_PERIODMISS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PERIODELONGUE_PERIODMISS.Width = 210;
            // 
            // NOTE_PERIODMISS
            // 
            this.NOTE_PERIODMISS.DataPropertyName = "NOTE_PERIODMISS";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.NOTE_PERIODMISS.DefaultCellStyle = dataGridViewCellStyle17;
            this.NOTE_PERIODMISS.HeaderText = "Note";
            this.NOTE_PERIODMISS.MinimumWidth = 6;
            this.NOTE_PERIODMISS.Name = "NOTE_PERIODMISS";
            this.NOTE_PERIODMISS.Width = 250;
            // 
            // DATECREATE_PERIODMISS
            // 
            this.DATECREATE_PERIODMISS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DATECREATE_PERIODMISS.DataPropertyName = "DATECREATE_CATEG_MISS";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DATECREATE_PERIODMISS.DefaultCellStyle = dataGridViewCellStyle18;
            this.DATECREATE_PERIODMISS.HeaderText = "Créer le";
            this.DATECREATE_PERIODMISS.MinimumWidth = 125;
            this.DATECREATE_PERIODMISS.Name = "DATECREATE_PERIODMISS";
            // 
            // DATEMODIFIER_CATEG_MISS
            // 
            this.DATEMODIFIER_CATEG_MISS.DataPropertyName = "DATEMODIFIER_PERIODMISS";
            this.DATEMODIFIER_CATEG_MISS.HeaderText = "Modifier le";
            this.DATEMODIFIER_CATEG_MISS.MinimumWidth = 6;
            this.DATEMODIFIER_CATEG_MISS.Name = "DATEMODIFIER_CATEG_MISS";
            this.DATEMODIFIER_CATEG_MISS.ReadOnly = true;
            this.DATEMODIFIER_CATEG_MISS.Width = 150;
            // 
            // MenuDeletePeriodeMiss
            // 
            this.MenuDeletePeriodeMiss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.MenuDeletePeriodeMiss.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuDeletePeriodeMiss.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuDeletePeriodeMiss.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemDeletePeriodMiss});
            this.MenuDeletePeriodeMiss.Name = "MenuDeletePeriodeMiss";
            this.MenuDeletePeriodeMiss.Size = new System.Drawing.Size(154, 30);
            // 
            // MenuItemDeletePeriodMiss
            // 
            this.MenuItemDeletePeriodMiss.ForeColor = System.Drawing.Color.Red;
            this.MenuItemDeletePeriodMiss.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemDeletePeriodMiss.Image")));
            this.MenuItemDeletePeriodMiss.Name = "MenuItemDeletePeriodMiss";
            this.MenuItemDeletePeriodMiss.Size = new System.Drawing.Size(153, 26);
            this.MenuItemDeletePeriodMiss.Text = "Supprimer";
            this.MenuItemDeletePeriodMiss.Click += new System.EventHandler(this.MenuItemDeletePeriodMiss_Click);
            // 
            // FormPeriodeMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 910);
            this.Controls.Add(this.dgvPeriodMission);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelRegisterMarq);
            this.Controls.Add(this.panelMarqueTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormPeriodeMission";
            this.Text = "Définir les périodes de mission";
            this.panelMarqueTitle.ResumeLayout(false);
            this.panelMarqueTitle.PerformLayout();
            this.panelRegisterMarq.ResumeLayout(false);
            this.panelRegisterMarq.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodMission)).EndInit();
            this.MenuDeletePeriodeMiss.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMarqueTitle;
        private FontAwesome.Sharp.IconButton btnRafraichirPeriodMission;
        private FontAwesome.Sharp.IconButton BtnExportPeriodMission;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BtnImportPeriodMission;
        private FontAwesome.Sharp.IconButton BtnCloseFormCategMission;
        private System.Windows.Forms.Panel panelRegisterMarq;
        private System.Windows.Forms.TextBox TxtMontantPeriodMiss;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdPeriodMiss;
        private FontAwesome.Sharp.IconButton btnEditPeriodMission;
        private FontAwesome.Sharp.IconButton btnValiderPeriodMission;
        private FontAwesome.Sharp.IconButton BtnAnnulerPeriodMission;
        private System.Windows.Forms.RichTextBox RTxtNotePeriodMiss;
        private System.Windows.Forms.TextBox TxtCodPeriodMiss;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFilterPeriodMiss;
        private System.Windows.Forms.Label TotalCateg;
        private System.Windows.Forms.CheckBox ChkPeriodeLongueMiss;
        private System.Windows.Forms.CheckBox ChkPeriodeMoyenneMiss;
        private System.Windows.Forms.CheckBox ChkPeriodeCourteMiss;
        private System.Windows.Forms.DataGridView dgvPeriodMission;
        private System.Windows.Forms.ContextMenuStrip MenuDeletePeriodeMiss;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDeletePeriodMiss;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PERIODMISS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_PERIODMISS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTANT_PERIODMISS;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PERIODECOURTE_PERIODMISS;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PERIODEMOYENNE_PERIODMISS;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PERIODELONGUE_PERIODMISS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTE_PERIODMISS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATECREATE_PERIODMISS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATEMODIFIER_CATEG_MISS;
    }
}