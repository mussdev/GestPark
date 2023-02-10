
namespace GestPark
{
    partial class FormTypeConsommation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTypeConsommation));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTypConsoTitle = new System.Windows.Forms.Panel();
            this.BtnExportTypEnerg = new FontAwesome.Sharp.IconButton();
            this.BtnImportTypEnerg = new FontAwesome.Sharp.IconButton();
            this.BtnRafraichirTypEnerg = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.iconBtnCloseFormTypConso = new FontAwesome.Sharp.IconButton();
            this.panelRegisterTypConso = new System.Windows.Forms.Panel();
            this.btnEditEnergy = new FontAwesome.Sharp.IconButton();
            this.TxtPrixLitre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.iconBtnAnnulerTypConso = new FontAwesome.Sharp.IconButton();
            this.iconBtnValiderTypConso = new FontAwesome.Sharp.IconButton();
            this.richTextBoxNoteTypConso = new System.Windows.Forms.RichTextBox();
            this.textBoxDescripTypConso = new System.Windows.Forms.TextBox();
            this.textBoxCodTypConso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TotalEnergie = new System.Windows.Forms.Label();
            this.DgvTypConso = new System.Windows.Forms.DataGridView();
            this.menuEnergy = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteEnergy = new System.Windows.Forms.ToolStripMenuItem();
            this.txtIdEnergie = new System.Windows.Forms.TextBox();
            this.txtFilterEnergie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ID_TYPCONSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE_TYPCONSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_TYPCONSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRIXLITRE_TYPCONSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBSERVATION_TYPCONSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERCREATE_TYPCONSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATECREATE_TYPCONSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTypConsoTitle.SuspendLayout();
            this.panelRegisterTypConso.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTypConso)).BeginInit();
            this.menuEnergy.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTypConsoTitle
            // 
            this.panelTypConsoTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.panelTypConsoTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTypConsoTitle.Controls.Add(this.BtnExportTypEnerg);
            this.panelTypConsoTitle.Controls.Add(this.BtnImportTypEnerg);
            this.panelTypConsoTitle.Controls.Add(this.BtnRafraichirTypEnerg);
            this.panelTypConsoTitle.Controls.Add(this.label1);
            this.panelTypConsoTitle.Controls.Add(this.iconBtnCloseFormTypConso);
            this.panelTypConsoTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTypConsoTitle.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTypConsoTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTypConsoTitle.Margin = new System.Windows.Forms.Padding(4);
            this.panelTypConsoTitle.Name = "panelTypConsoTitle";
            this.panelTypConsoTitle.Size = new System.Drawing.Size(1294, 26);
            this.panelTypConsoTitle.TabIndex = 0;
            // 
            // BtnExportTypEnerg
            // 
            this.BtnExportTypEnerg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.BtnExportTypEnerg.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExportTypEnerg.ForeColor = System.Drawing.Color.Black;
            this.BtnExportTypEnerg.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromFile;
            this.BtnExportTypEnerg.IconColor = System.Drawing.Color.White;
            this.BtnExportTypEnerg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnExportTypEnerg.IconSize = 20;
            this.BtnExportTypEnerg.Location = new System.Drawing.Point(114, -2);
            this.BtnExportTypEnerg.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExportTypEnerg.Name = "BtnExportTypEnerg";
            this.BtnExportTypEnerg.Size = new System.Drawing.Size(116, 26);
            this.BtnExportTypEnerg.TabIndex = 25;
            this.BtnExportTypEnerg.Text = "Exporter";
            this.BtnExportTypEnerg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExportTypEnerg.UseVisualStyleBackColor = false;
            // 
            // BtnImportTypEnerg
            // 
            this.BtnImportTypEnerg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.BtnImportTypEnerg.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImportTypEnerg.ForeColor = System.Drawing.Color.Black;
            this.BtnImportTypEnerg.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.BtnImportTypEnerg.IconColor = System.Drawing.Color.White;
            this.BtnImportTypEnerg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnImportTypEnerg.IconSize = 20;
            this.BtnImportTypEnerg.Location = new System.Drawing.Point(-2, -2);
            this.BtnImportTypEnerg.Margin = new System.Windows.Forms.Padding(4);
            this.BtnImportTypEnerg.Name = "BtnImportTypEnerg";
            this.BtnImportTypEnerg.Size = new System.Drawing.Size(116, 25);
            this.BtnImportTypEnerg.TabIndex = 24;
            this.BtnImportTypEnerg.Text = "Importer";
            this.BtnImportTypEnerg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnImportTypEnerg.UseVisualStyleBackColor = false;
            // 
            // BtnRafraichirTypEnerg
            // 
            this.BtnRafraichirTypEnerg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.BtnRafraichirTypEnerg.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRafraichirTypEnerg.ForeColor = System.Drawing.Color.Black;
            this.BtnRafraichirTypEnerg.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.BtnRafraichirTypEnerg.IconColor = System.Drawing.Color.White;
            this.BtnRafraichirTypEnerg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRafraichirTypEnerg.IconSize = 20;
            this.BtnRafraichirTypEnerg.Location = new System.Drawing.Point(232, -2);
            this.BtnRafraichirTypEnerg.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRafraichirTypEnerg.Name = "BtnRafraichirTypEnerg";
            this.BtnRafraichirTypEnerg.Size = new System.Drawing.Size(122, 26);
            this.BtnRafraichirTypEnerg.TabIndex = 23;
            this.BtnRafraichirTypEnerg.Text = "Rafraîchir";
            this.BtnRafraichirTypEnerg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRafraichirTypEnerg.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(625, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Les types d\'energie";
            // 
            // iconBtnCloseFormTypConso
            // 
            this.iconBtnCloseFormTypConso.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.iconBtnCloseFormTypConso.BackColor = System.Drawing.Color.Honeydew;
            this.iconBtnCloseFormTypConso.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.iconBtnCloseFormTypConso.IconColor = System.Drawing.Color.Red;
            this.iconBtnCloseFormTypConso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnCloseFormTypConso.IconSize = 20;
            this.iconBtnCloseFormTypConso.Location = new System.Drawing.Point(1266, -2);
            this.iconBtnCloseFormTypConso.Margin = new System.Windows.Forms.Padding(4);
            this.iconBtnCloseFormTypConso.Name = "iconBtnCloseFormTypConso";
            this.iconBtnCloseFormTypConso.Size = new System.Drawing.Size(27, 26);
            this.iconBtnCloseFormTypConso.TabIndex = 0;
            this.iconBtnCloseFormTypConso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconBtnCloseFormTypConso.UseVisualStyleBackColor = false;
            this.iconBtnCloseFormTypConso.Click += new System.EventHandler(this.iconBtnCloseFormTypConso_Click);
            // 
            // panelRegisterTypConso
            // 
            this.panelRegisterTypConso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.panelRegisterTypConso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelRegisterTypConso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRegisterTypConso.Controls.Add(this.txtIdEnergie);
            this.panelRegisterTypConso.Controls.Add(this.btnEditEnergy);
            this.panelRegisterTypConso.Controls.Add(this.TxtPrixLitre);
            this.panelRegisterTypConso.Controls.Add(this.label5);
            this.panelRegisterTypConso.Controls.Add(this.iconBtnAnnulerTypConso);
            this.panelRegisterTypConso.Controls.Add(this.iconBtnValiderTypConso);
            this.panelRegisterTypConso.Controls.Add(this.richTextBoxNoteTypConso);
            this.panelRegisterTypConso.Controls.Add(this.textBoxDescripTypConso);
            this.panelRegisterTypConso.Controls.Add(this.textBoxCodTypConso);
            this.panelRegisterTypConso.Controls.Add(this.label4);
            this.panelRegisterTypConso.Controls.Add(this.label3);
            this.panelRegisterTypConso.Controls.Add(this.label2);
            this.panelRegisterTypConso.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRegisterTypConso.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelRegisterTypConso.Location = new System.Drawing.Point(0, 26);
            this.panelRegisterTypConso.Margin = new System.Windows.Forms.Padding(4);
            this.panelRegisterTypConso.Name = "panelRegisterTypConso";
            this.panelRegisterTypConso.Size = new System.Drawing.Size(356, 660);
            this.panelRegisterTypConso.TabIndex = 1;
            // 
            // btnEditEnergy
            // 
            this.btnEditEnergy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnEditEnergy.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEnergy.ForeColor = System.Drawing.Color.Black;
            this.btnEditEnergy.IconChar = FontAwesome.Sharp.IconChar.PencilSquare;
            this.btnEditEnergy.IconColor = System.Drawing.Color.White;
            this.btnEditEnergy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditEnergy.IconSize = 20;
            this.btnEditEnergy.Location = new System.Drawing.Point(132, 357);
            this.btnEditEnergy.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditEnergy.Name = "btnEditEnergy";
            this.btnEditEnergy.Size = new System.Drawing.Size(82, 25);
            this.btnEditEnergy.TabIndex = 14;
            this.btnEditEnergy.Text = "Editer";
            this.btnEditEnergy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditEnergy.UseVisualStyleBackColor = false;
            this.btnEditEnergy.Click += new System.EventHandler(this.btnEditEnergy_Click);
            // 
            // TxtPrixLitre
            // 
            this.TxtPrixLitre.BackColor = System.Drawing.Color.White;
            this.TxtPrixLitre.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrixLitre.ForeColor = System.Drawing.Color.DarkGreen;
            this.TxtPrixLitre.Location = new System.Drawing.Point(112, 177);
            this.TxtPrixLitre.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPrixLitre.Name = "TxtPrixLitre";
            this.TxtPrixLitre.Size = new System.Drawing.Size(224, 28);
            this.TxtPrixLitre.TabIndex = 7;
            this.TxtPrixLitre.Text = "615";
            this.TxtPrixLitre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(5, 186);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Prix du litre *:";
            // 
            // iconBtnAnnulerTypConso
            // 
            this.iconBtnAnnulerTypConso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.iconBtnAnnulerTypConso.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnAnnulerTypConso.ForeColor = System.Drawing.Color.Black;
            this.iconBtnAnnulerTypConso.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.iconBtnAnnulerTypConso.IconColor = System.Drawing.Color.White;
            this.iconBtnAnnulerTypConso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnAnnulerTypConso.IconSize = 18;
            this.iconBtnAnnulerTypConso.Location = new System.Drawing.Point(222, 357);
            this.iconBtnAnnulerTypConso.Margin = new System.Windows.Forms.Padding(4);
            this.iconBtnAnnulerTypConso.Name = "iconBtnAnnulerTypConso";
            this.iconBtnAnnulerTypConso.Size = new System.Drawing.Size(91, 25);
            this.iconBtnAnnulerTypConso.TabIndex = 5;
            this.iconBtnAnnulerTypConso.Text = "Annuler";
            this.iconBtnAnnulerTypConso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnAnnulerTypConso.UseVisualStyleBackColor = false;
            this.iconBtnAnnulerTypConso.Click += new System.EventHandler(this.iconBtnAnnulerTypConso_Click);
            // 
            // iconBtnValiderTypConso
            // 
            this.iconBtnValiderTypConso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.iconBtnValiderTypConso.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnValiderTypConso.ForeColor = System.Drawing.Color.Black;
            this.iconBtnValiderTypConso.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
            this.iconBtnValiderTypConso.IconColor = System.Drawing.Color.White;
            this.iconBtnValiderTypConso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnValiderTypConso.IconSize = 18;
            this.iconBtnValiderTypConso.Location = new System.Drawing.Point(39, 357);
            this.iconBtnValiderTypConso.Margin = new System.Windows.Forms.Padding(4);
            this.iconBtnValiderTypConso.Name = "iconBtnValiderTypConso";
            this.iconBtnValiderTypConso.Size = new System.Drawing.Size(85, 25);
            this.iconBtnValiderTypConso.TabIndex = 4;
            this.iconBtnValiderTypConso.Text = "Valider";
            this.iconBtnValiderTypConso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnValiderTypConso.UseVisualStyleBackColor = false;
            this.iconBtnValiderTypConso.Click += new System.EventHandler(this.iconBtnValiderTypConso_Click);
            // 
            // richTextBoxNoteTypConso
            // 
            this.richTextBoxNoteTypConso.BackColor = System.Drawing.Color.White;
            this.richTextBoxNoteTypConso.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxNoteTypConso.Location = new System.Drawing.Point(112, 245);
            this.richTextBoxNoteTypConso.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxNoteTypConso.Name = "richTextBoxNoteTypConso";
            this.richTextBoxNoteTypConso.Size = new System.Drawing.Size(224, 69);
            this.richTextBoxNoteTypConso.TabIndex = 5;
            this.richTextBoxNoteTypConso.Text = "";
            // 
            // textBoxDescripTypConso
            // 
            this.textBoxDescripTypConso.BackColor = System.Drawing.Color.White;
            this.textBoxDescripTypConso.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescripTypConso.Location = new System.Drawing.Point(112, 107);
            this.textBoxDescripTypConso.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDescripTypConso.Name = "textBoxDescripTypConso";
            this.textBoxDescripTypConso.Size = new System.Drawing.Size(224, 28);
            this.textBoxDescripTypConso.TabIndex = 2;
            // 
            // textBoxCodTypConso
            // 
            this.textBoxCodTypConso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.textBoxCodTypConso.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodTypConso.ForeColor = System.Drawing.Color.Black;
            this.textBoxCodTypConso.Location = new System.Drawing.Point(112, 41);
            this.textBoxCodTypConso.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCodTypConso.Name = "textBoxCodTypConso";
            this.textBoxCodTypConso.ReadOnly = true;
            this.textBoxCodTypConso.Size = new System.Drawing.Size(103, 28);
            this.textBoxCodTypConso.TabIndex = 1;
            this.textBoxCodTypConso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(9, 248);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Note :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(5, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Description *:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(5, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Code *:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtFilterEnergie);
            this.panel1.Controls.Add(this.TotalEnergie);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(356, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 33);
            this.panel1.TabIndex = 2;
            // 
            // TotalEnergie
            // 
            this.TotalEnergie.AutoSize = true;
            this.TotalEnergie.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalEnergie.ForeColor = System.Drawing.Color.Maroon;
            this.TotalEnergie.Location = new System.Drawing.Point(4, 11);
            this.TotalEnergie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalEnergie.Name = "TotalEnergie";
            this.TotalEnergie.Size = new System.Drawing.Size(133, 19);
            this.TotalEnergie.TabIndex = 0;
            this.TotalEnergie.Text = "Total energie = 0";
            // 
            // DgvTypConso
            // 
            this.DgvTypConso.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            this.DgvTypConso.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvTypConso.BackgroundColor = System.Drawing.Color.White;
            this.DgvTypConso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvTypConso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvTypConso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTypConso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_TYPCONSO,
            this.CODE_TYPCONSO,
            this.DESCRIPTION_TYPCONSO,
            this.PRIXLITRE_TYPCONSO,
            this.OBSERVATION_TYPCONSO,
            this.USERCREATE_TYPCONSO,
            this.DATECREATE_TYPCONSO});
            this.DgvTypConso.ContextMenuStrip = this.menuEnergy;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvTypConso.DefaultCellStyle = dataGridViewCellStyle9;
            this.DgvTypConso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvTypConso.GridColor = System.Drawing.Color.White;
            this.DgvTypConso.Location = new System.Drawing.Point(356, 59);
            this.DgvTypConso.Margin = new System.Windows.Forms.Padding(5);
            this.DgvTypConso.Name = "DgvTypConso";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvTypConso.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DgvTypConso.RowHeadersWidth = 51;
            this.DgvTypConso.Size = new System.Drawing.Size(938, 627);
            this.DgvTypConso.TabIndex = 5;
            this.DgvTypConso.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTypConso_CellClick);
            this.DgvTypConso.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvTypConso_CellMouseUp);
            // 
            // menuEnergy
            // 
            this.menuEnergy.BackColor = System.Drawing.Color.Honeydew;
            this.menuEnergy.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuEnergy.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuEnergy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteEnergy});
            this.menuEnergy.Name = "menuEnergy";
            this.menuEnergy.Size = new System.Drawing.Size(154, 30);
            // 
            // deleteEnergy
            // 
            this.deleteEnergy.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteEnergy.ForeColor = System.Drawing.Color.YellowGreen;
            this.deleteEnergy.Image = ((System.Drawing.Image)(resources.GetObject("deleteEnergy.Image")));
            this.deleteEnergy.Name = "deleteEnergy";
            this.deleteEnergy.Size = new System.Drawing.Size(153, 26);
            this.deleteEnergy.Text = "Supprimer";
            this.deleteEnergy.Click += new System.EventHandler(this.deleteEnergy_Click);
            // 
            // txtIdEnergie
            // 
            this.txtIdEnergie.Location = new System.Drawing.Point(115, 5);
            this.txtIdEnergie.Name = "txtIdEnergie";
            this.txtIdEnergie.Size = new System.Drawing.Size(100, 29);
            this.txtIdEnergie.TabIndex = 15;
            this.txtIdEnergie.Visible = false;
            // 
            // txtFilterEnergie
            // 
            this.txtFilterEnergie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterEnergie.ForeColor = System.Drawing.Color.Black;
            this.txtFilterEnergie.Location = new System.Drawing.Point(713, 3);
            this.txtFilterEnergie.Name = "txtFilterEnergie";
            this.txtFilterEnergie.Size = new System.Drawing.Size(226, 28);
            this.txtFilterEnergie.TabIndex = 1;
            this.txtFilterEnergie.TextChanged += new System.EventHandler(this.txtFilterEnergie_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(644, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Filtrer";
            // 
            // ID_TYPCONSO
            // 
            this.ID_TYPCONSO.DataPropertyName = "ID_TYPCONSO";
            this.ID_TYPCONSO.Frozen = true;
            this.ID_TYPCONSO.HeaderText = "IdEnergie";
            this.ID_TYPCONSO.MinimumWidth = 6;
            this.ID_TYPCONSO.Name = "ID_TYPCONSO";
            this.ID_TYPCONSO.ReadOnly = true;
            this.ID_TYPCONSO.Visible = false;
            this.ID_TYPCONSO.Width = 125;
            // 
            // CODE_TYPCONSO
            // 
            this.CODE_TYPCONSO.DataPropertyName = "CODE_TYPCONSO";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CODE_TYPCONSO.DefaultCellStyle = dataGridViewCellStyle3;
            this.CODE_TYPCONSO.Frozen = true;
            this.CODE_TYPCONSO.HeaderText = "Code";
            this.CODE_TYPCONSO.MinimumWidth = 6;
            this.CODE_TYPCONSO.Name = "CODE_TYPCONSO";
            this.CODE_TYPCONSO.Width = 70;
            // 
            // DESCRIPTION_TYPCONSO
            // 
            this.DESCRIPTION_TYPCONSO.DataPropertyName = "DESCRIPTION_TYPCONSO";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DESCRIPTION_TYPCONSO.DefaultCellStyle = dataGridViewCellStyle4;
            this.DESCRIPTION_TYPCONSO.HeaderText = "Description";
            this.DESCRIPTION_TYPCONSO.MinimumWidth = 6;
            this.DESCRIPTION_TYPCONSO.Name = "DESCRIPTION_TYPCONSO";
            this.DESCRIPTION_TYPCONSO.Width = 250;
            // 
            // PRIXLITRE_TYPCONSO
            // 
            this.PRIXLITRE_TYPCONSO.DataPropertyName = "PRIXLITRE_TYPCONSO";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.PRIXLITRE_TYPCONSO.DefaultCellStyle = dataGridViewCellStyle5;
            this.PRIXLITRE_TYPCONSO.HeaderText = "Prix du litre";
            this.PRIXLITRE_TYPCONSO.MinimumWidth = 6;
            this.PRIXLITRE_TYPCONSO.Name = "PRIXLITRE_TYPCONSO";
            this.PRIXLITRE_TYPCONSO.ReadOnly = true;
            this.PRIXLITRE_TYPCONSO.Width = 150;
            // 
            // OBSERVATION_TYPCONSO
            // 
            this.OBSERVATION_TYPCONSO.DataPropertyName = "OBSERVATION_TYPCONSO";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.OBSERVATION_TYPCONSO.DefaultCellStyle = dataGridViewCellStyle6;
            this.OBSERVATION_TYPCONSO.HeaderText = "Note";
            this.OBSERVATION_TYPCONSO.MinimumWidth = 6;
            this.OBSERVATION_TYPCONSO.Name = "OBSERVATION_TYPCONSO";
            this.OBSERVATION_TYPCONSO.Width = 400;
            // 
            // USERCREATE_TYPCONSO
            // 
            this.USERCREATE_TYPCONSO.DataPropertyName = "USERCREATE_TYPCONSO";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.USERCREATE_TYPCONSO.DefaultCellStyle = dataGridViewCellStyle7;
            this.USERCREATE_TYPCONSO.HeaderText = "Créer par";
            this.USERCREATE_TYPCONSO.MinimumWidth = 6;
            this.USERCREATE_TYPCONSO.Name = "USERCREATE_TYPCONSO";
            this.USERCREATE_TYPCONSO.Width = 150;
            // 
            // DATECREATE_TYPCONSO
            // 
            this.DATECREATE_TYPCONSO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DATECREATE_TYPCONSO.DataPropertyName = "DATECREATE_TYPCONSO";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DATECREATE_TYPCONSO.DefaultCellStyle = dataGridViewCellStyle8;
            this.DATECREATE_TYPCONSO.HeaderText = "Créer le";
            this.DATECREATE_TYPCONSO.MinimumWidth = 125;
            this.DATECREATE_TYPCONSO.Name = "DATECREATE_TYPCONSO";
            // 
            // FormTypeConsommation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 686);
            this.Controls.Add(this.DgvTypConso);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelRegisterTypConso);
            this.Controls.Add(this.panelTypConsoTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTypeConsommation";
            this.Text = "FormTypeConsommation";
            this.panelTypConsoTitle.ResumeLayout(false);
            this.panelTypConsoTitle.PerformLayout();
            this.panelRegisterTypConso.ResumeLayout(false);
            this.panelRegisterTypConso.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTypConso)).EndInit();
            this.menuEnergy.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTypConsoTitle;
        private FontAwesome.Sharp.IconButton iconBtnCloseFormTypConso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelRegisterTypConso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconBtnAnnulerTypConso;
        private FontAwesome.Sharp.IconButton iconBtnValiderTypConso;
        private System.Windows.Forms.RichTextBox richTextBoxNoteTypConso;
        private System.Windows.Forms.TextBox textBoxDescripTypConso;
        private System.Windows.Forms.TextBox textBoxCodTypConso;
        private System.Windows.Forms.TextBox TxtPrixLitre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TotalEnergie;
        private System.Windows.Forms.DataGridView DgvTypConso;
        private FontAwesome.Sharp.IconButton btnEditEnergy;
        private System.Windows.Forms.ContextMenuStrip menuEnergy;
        private System.Windows.Forms.ToolStripMenuItem deleteEnergy;
        private FontAwesome.Sharp.IconButton BtnExportTypEnerg;
        private FontAwesome.Sharp.IconButton BtnImportTypEnerg;
        private FontAwesome.Sharp.IconButton BtnRafraichirTypEnerg;
        private System.Windows.Forms.TextBox txtIdEnergie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFilterEnergie;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TYPCONSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_TYPCONSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_TYPCONSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRIXLITRE_TYPCONSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBSERVATION_TYPCONSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERCREATE_TYPCONSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATECREATE_TYPCONSO;
    }
}