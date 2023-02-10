
namespace GestPark
{
    partial class FormMarque
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMarque));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMarqueTitle = new System.Windows.Forms.Panel();
            this.BtnExportMarq = new FontAwesome.Sharp.IconButton();
            this.BtnImportMarq = new FontAwesome.Sharp.IconButton();
            this.BtnRafraichirMarq = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCloseFormMarq = new FontAwesome.Sharp.IconButton();
            this.panelRegisterMarq = new System.Windows.Forms.Panel();
            this.cbxSeuilKiloVdge = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEditMarq = new FontAwesome.Sharp.IconButton();
            this.txTKiloVidange = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtModelMarq = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnValiderMarq = new FontAwesome.Sharp.IconButton();
            this.iconBtnAnnulerMarq = new FontAwesome.Sharp.IconButton();
            this.richTextBoxNoteMarq = new System.Windows.Forms.RichTextBox();
            this.textBoxDescriptMarq = new System.Windows.Forms.TextBox();
            this.textBxCodeMarq = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFiltrerMarq = new System.Windows.Forms.TextBox();
            this.TotalModelMarq = new System.Windows.Forms.Label();
            this.dataGridViewMarq = new System.Windows.Forms.DataGridView();
            this.menuMarq = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteMarq = new System.Windows.Forms.ToolStripMenuItem();
            this.txtIdMarque = new System.Windows.Forms.TextBox();
            this.ID_MARQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE_MARQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_MARQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODELE_MARQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KILO_VIDANGE_MARQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEUIL_KILO_VDGE_MARQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBSERVATIONS_MARQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERCREATE_MARQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATECREATE_MARQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMarqueTitle.SuspendLayout();
            this.panelRegisterMarq.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarq)).BeginInit();
            this.menuMarq.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMarqueTitle
            // 
            this.panelMarqueTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.panelMarqueTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMarqueTitle.Controls.Add(this.BtnExportMarq);
            this.panelMarqueTitle.Controls.Add(this.BtnImportMarq);
            this.panelMarqueTitle.Controls.Add(this.BtnRafraichirMarq);
            this.panelMarqueTitle.Controls.Add(this.label1);
            this.panelMarqueTitle.Controls.Add(this.BtnCloseFormMarq);
            this.panelMarqueTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMarqueTitle.Location = new System.Drawing.Point(0, 0);
            this.panelMarqueTitle.Name = "panelMarqueTitle";
            this.panelMarqueTitle.Size = new System.Drawing.Size(1216, 24);
            this.panelMarqueTitle.TabIndex = 0;
            // 
            // BtnExportMarq
            // 
            this.BtnExportMarq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.BtnExportMarq.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExportMarq.ForeColor = System.Drawing.Color.Black;
            this.BtnExportMarq.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromFile;
            this.BtnExportMarq.IconColor = System.Drawing.Color.White;
            this.BtnExportMarq.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnExportMarq.IconSize = 20;
            this.BtnExportMarq.Location = new System.Drawing.Point(96, -2);
            this.BtnExportMarq.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExportMarq.Name = "BtnExportMarq";
            this.BtnExportMarq.Size = new System.Drawing.Size(98, 24);
            this.BtnExportMarq.TabIndex = 22;
            this.BtnExportMarq.Text = "Exporter";
            this.BtnExportMarq.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExportMarq.UseVisualStyleBackColor = false;
            // 
            // BtnImportMarq
            // 
            this.BtnImportMarq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.BtnImportMarq.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImportMarq.ForeColor = System.Drawing.Color.Black;
            this.BtnImportMarq.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.BtnImportMarq.IconColor = System.Drawing.Color.White;
            this.BtnImportMarq.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnImportMarq.IconSize = 20;
            this.BtnImportMarq.Location = new System.Drawing.Point(-2, -2);
            this.BtnImportMarq.Margin = new System.Windows.Forms.Padding(4);
            this.BtnImportMarq.Name = "BtnImportMarq";
            this.BtnImportMarq.Size = new System.Drawing.Size(97, 24);
            this.BtnImportMarq.TabIndex = 21;
            this.BtnImportMarq.Text = "Importer";
            this.BtnImportMarq.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnImportMarq.UseVisualStyleBackColor = false;
            // 
            // BtnRafraichirMarq
            // 
            this.BtnRafraichirMarq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.BtnRafraichirMarq.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRafraichirMarq.ForeColor = System.Drawing.Color.Black;
            this.BtnRafraichirMarq.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.BtnRafraichirMarq.IconColor = System.Drawing.Color.White;
            this.BtnRafraichirMarq.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRafraichirMarq.IconSize = 20;
            this.BtnRafraichirMarq.Location = new System.Drawing.Point(193, -2);
            this.BtnRafraichirMarq.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRafraichirMarq.Name = "BtnRafraichirMarq";
            this.BtnRafraichirMarq.Size = new System.Drawing.Size(115, 24);
            this.BtnRafraichirMarq.TabIndex = 20;
            this.BtnRafraichirMarq.Text = "Rafraîchir";
            this.BtnRafraichirMarq.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRafraichirMarq.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(563, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marque de voiture";
            // 
            // BtnCloseFormMarq
            // 
            this.BtnCloseFormMarq.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnCloseFormMarq.BackColor = System.Drawing.Color.Honeydew;
            this.BtnCloseFormMarq.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCloseFormMarq.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.BtnCloseFormMarq.IconColor = System.Drawing.Color.Red;
            this.BtnCloseFormMarq.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCloseFormMarq.IconSize = 20;
            this.BtnCloseFormMarq.Location = new System.Drawing.Point(1189, -4);
            this.BtnCloseFormMarq.Name = "BtnCloseFormMarq";
            this.BtnCloseFormMarq.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.BtnCloseFormMarq.Size = new System.Drawing.Size(25, 28);
            this.BtnCloseFormMarq.TabIndex = 0;
            this.BtnCloseFormMarq.UseVisualStyleBackColor = false;
            this.BtnCloseFormMarq.Click += new System.EventHandler(this.BtnCloseFormMarq_Click);
            // 
            // panelRegisterMarq
            // 
            this.panelRegisterMarq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.panelRegisterMarq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelRegisterMarq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRegisterMarq.Controls.Add(this.txtIdMarque);
            this.panelRegisterMarq.Controls.Add(this.cbxSeuilKiloVdge);
            this.panelRegisterMarq.Controls.Add(this.label7);
            this.panelRegisterMarq.Controls.Add(this.btnEditMarq);
            this.panelRegisterMarq.Controls.Add(this.txTKiloVidange);
            this.panelRegisterMarq.Controls.Add(this.label6);
            this.panelRegisterMarq.Controls.Add(this.TxtModelMarq);
            this.panelRegisterMarq.Controls.Add(this.label5);
            this.panelRegisterMarq.Controls.Add(this.btnValiderMarq);
            this.panelRegisterMarq.Controls.Add(this.iconBtnAnnulerMarq);
            this.panelRegisterMarq.Controls.Add(this.richTextBoxNoteMarq);
            this.panelRegisterMarq.Controls.Add(this.textBoxDescriptMarq);
            this.panelRegisterMarq.Controls.Add(this.textBxCodeMarq);
            this.panelRegisterMarq.Controls.Add(this.label4);
            this.panelRegisterMarq.Controls.Add(this.label3);
            this.panelRegisterMarq.Controls.Add(this.label2);
            this.panelRegisterMarq.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRegisterMarq.Location = new System.Drawing.Point(0, 24);
            this.panelRegisterMarq.Name = "panelRegisterMarq";
            this.panelRegisterMarq.Size = new System.Drawing.Size(339, 604);
            this.panelRegisterMarq.TabIndex = 1;
            // 
            // cbxSeuilKiloVdge
            // 
            this.cbxSeuilKiloVdge.BackColor = System.Drawing.Color.White;
            this.cbxSeuilKiloVdge.FormattingEnabled = true;
            this.cbxSeuilKiloVdge.Items.AddRange(new object[] {
            "0",
            "4000",
            "9000"});
            this.cbxSeuilKiloVdge.Location = new System.Drawing.Point(129, 327);
            this.cbxSeuilKiloVdge.Name = "cbxSeuilKiloVdge";
            this.cbxSeuilKiloVdge.Size = new System.Drawing.Size(202, 29);
            this.cbxSeuilKiloVdge.TabIndex = 15;
            this.cbxSeuilKiloVdge.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(4, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Seuil kilo. vdg :";
            // 
            // btnEditMarq
            // 
            this.btnEditMarq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnEditMarq.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMarq.ForeColor = System.Drawing.Color.Black;
            this.btnEditMarq.IconChar = FontAwesome.Sharp.IconChar.PencilSquare;
            this.btnEditMarq.IconColor = System.Drawing.Color.White;
            this.btnEditMarq.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditMarq.IconSize = 18;
            this.btnEditMarq.Location = new System.Drawing.Point(130, 515);
            this.btnEditMarq.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditMarq.Name = "btnEditMarq";
            this.btnEditMarq.Size = new System.Drawing.Size(80, 23);
            this.btnEditMarq.TabIndex = 13;
            this.btnEditMarq.Text = "Editer";
            this.btnEditMarq.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditMarq.UseVisualStyleBackColor = false;
            this.btnEditMarq.Click += new System.EventHandler(this.btnEditMarq_Click);
            // 
            // txTKiloVidange
            // 
            this.txTKiloVidange.BackColor = System.Drawing.Color.White;
            this.txTKiloVidange.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTKiloVidange.ForeColor = System.Drawing.Color.DarkGreen;
            this.txTKiloVidange.Location = new System.Drawing.Point(129, 260);
            this.txTKiloVidange.Name = "txTKiloVidange";
            this.txTKiloVidange.Size = new System.Drawing.Size(202, 28);
            this.txTKiloVidange.TabIndex = 12;
            this.txTKiloVidange.Text = "0";
            this.txTKiloVidange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(4, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Kilo. vid. :";
            // 
            // TxtModelMarq
            // 
            this.TxtModelMarq.BackColor = System.Drawing.Color.White;
            this.TxtModelMarq.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtModelMarq.Location = new System.Drawing.Point(129, 188);
            this.TxtModelMarq.Name = "TxtModelMarq";
            this.TxtModelMarq.Size = new System.Drawing.Size(202, 29);
            this.TxtModelMarq.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(4, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Modèle :";
            // 
            // btnValiderMarq
            // 
            this.btnValiderMarq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnValiderMarq.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValiderMarq.ForeColor = System.Drawing.Color.Black;
            this.btnValiderMarq.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
            this.btnValiderMarq.IconColor = System.Drawing.Color.White;
            this.btnValiderMarq.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnValiderMarq.IconSize = 18;
            this.btnValiderMarq.Location = new System.Drawing.Point(37, 515);
            this.btnValiderMarq.Name = "btnValiderMarq";
            this.btnValiderMarq.Size = new System.Drawing.Size(86, 23);
            this.btnValiderMarq.TabIndex = 8;
            this.btnValiderMarq.Text = "Valider";
            this.btnValiderMarq.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnValiderMarq.UseVisualStyleBackColor = false;
            this.btnValiderMarq.Click += new System.EventHandler(this.btnValiderMarq_Click);
            // 
            // iconBtnAnnulerMarq
            // 
            this.iconBtnAnnulerMarq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.iconBtnAnnulerMarq.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnAnnulerMarq.ForeColor = System.Drawing.Color.Black;
            this.iconBtnAnnulerMarq.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.iconBtnAnnulerMarq.IconColor = System.Drawing.Color.White;
            this.iconBtnAnnulerMarq.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnAnnulerMarq.IconSize = 18;
            this.iconBtnAnnulerMarq.Location = new System.Drawing.Point(217, 515);
            this.iconBtnAnnulerMarq.Name = "iconBtnAnnulerMarq";
            this.iconBtnAnnulerMarq.Size = new System.Drawing.Size(91, 23);
            this.iconBtnAnnulerMarq.TabIndex = 7;
            this.iconBtnAnnulerMarq.Text = "Annuler";
            this.iconBtnAnnulerMarq.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnAnnulerMarq.UseVisualStyleBackColor = false;
            this.iconBtnAnnulerMarq.Click += new System.EventHandler(this.iconBtnAnnulerMarq_Click);
            // 
            // richTextBoxNoteMarq
            // 
            this.richTextBoxNoteMarq.BackColor = System.Drawing.Color.White;
            this.richTextBoxNoteMarq.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxNoteMarq.Location = new System.Drawing.Point(128, 387);
            this.richTextBoxNoteMarq.Name = "richTextBoxNoteMarq";
            this.richTextBoxNoteMarq.Size = new System.Drawing.Size(203, 78);
            this.richTextBoxNoteMarq.TabIndex = 5;
            this.richTextBoxNoteMarq.Text = "";
            // 
            // textBoxDescriptMarq
            // 
            this.textBoxDescriptMarq.BackColor = System.Drawing.Color.White;
            this.textBoxDescriptMarq.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescriptMarq.Location = new System.Drawing.Point(130, 113);
            this.textBoxDescriptMarq.Name = "textBoxDescriptMarq";
            this.textBoxDescriptMarq.Size = new System.Drawing.Size(202, 29);
            this.textBoxDescriptMarq.TabIndex = 4;
            // 
            // textBxCodeMarq
            // 
            this.textBxCodeMarq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.textBxCodeMarq.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBxCodeMarq.ForeColor = System.Drawing.Color.Black;
            this.textBxCodeMarq.Location = new System.Drawing.Point(129, 38);
            this.textBxCodeMarq.Name = "textBxCodeMarq";
            this.textBxCodeMarq.ReadOnly = true;
            this.textBxCodeMarq.Size = new System.Drawing.Size(96, 27);
            this.textBxCodeMarq.TabIndex = 3;
            this.textBxCodeMarq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(7, 387);
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
            this.label3.Location = new System.Drawing.Point(3, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Description :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(4, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Code :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtFiltrerMarq);
            this.panel1.Controls.Add(this.TotalModelMarq);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(339, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 32);
            this.panel1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(520, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "Filtrer";
            // 
            // txtFiltrerMarq
            // 
            this.txtFiltrerMarq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltrerMarq.Location = new System.Drawing.Point(580, 0);
            this.txtFiltrerMarq.Name = "txtFiltrerMarq";
            this.txtFiltrerMarq.Size = new System.Drawing.Size(294, 29);
            this.txtFiltrerMarq.TabIndex = 1;
            this.txtFiltrerMarq.TextChanged += new System.EventHandler(this.txtFiltrerMarq_TextChanged);
            // 
            // TotalModelMarq
            // 
            this.TotalModelMarq.AutoSize = true;
            this.TotalModelMarq.ForeColor = System.Drawing.Color.Maroon;
            this.TotalModelMarq.Location = new System.Drawing.Point(6, 8);
            this.TotalModelMarq.Name = "TotalModelMarq";
            this.TotalModelMarq.Size = new System.Drawing.Size(225, 21);
            this.TotalModelMarq.TabIndex = 0;
            this.TotalModelMarq.Text = "Total modèle de véhicule = 0";
            // 
            // dataGridViewMarq
            // 
            this.dataGridViewMarq.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewMarq.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMarq.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMarq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMarq.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMarq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMarq.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_MARQ,
            this.CODE_MARQ,
            this.DESCRIPTION_MARQ,
            this.MODELE_MARQ,
            this.KILO_VIDANGE_MARQ,
            this.SEUIL_KILO_VDGE_MARQ,
            this.OBSERVATIONS_MARQ,
            this.USERCREATE_MARQ,
            this.DATECREATE_MARQ});
            this.dataGridViewMarq.ContextMenuStrip = this.menuMarq;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMarq.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewMarq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMarq.GridColor = System.Drawing.Color.White;
            this.dataGridViewMarq.Location = new System.Drawing.Point(339, 56);
            this.dataGridViewMarq.Name = "dataGridViewMarq";
            this.dataGridViewMarq.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMarq.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewMarq.RowHeadersWidth = 51;
            this.dataGridViewMarq.Size = new System.Drawing.Size(877, 572);
            this.dataGridViewMarq.TabIndex = 3;
            this.dataGridViewMarq.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMarq_CellClick);
            this.dataGridViewMarq.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewMarq_CellMouseUp);
            // 
            // menuMarq
            // 
            this.menuMarq.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMarq.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuMarq.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteMarq});
            this.menuMarq.Name = "menuMarq";
            this.menuMarq.Size = new System.Drawing.Size(158, 30);
            // 
            // deleteMarq
            // 
            this.deleteMarq.BackColor = System.Drawing.Color.Honeydew;
            this.deleteMarq.ForeColor = System.Drawing.Color.YellowGreen;
            this.deleteMarq.Image = ((System.Drawing.Image)(resources.GetObject("deleteMarq.Image")));
            this.deleteMarq.Name = "deleteMarq";
            this.deleteMarq.Size = new System.Drawing.Size(157, 26);
            this.deleteMarq.Text = "Supprimer";
            this.deleteMarq.Click += new System.EventHandler(this.deleteMarq_Click);
            // 
            // txtIdMarque
            // 
            this.txtIdMarque.Location = new System.Drawing.Point(130, -2);
            this.txtIdMarque.Name = "txtIdMarque";
            this.txtIdMarque.Size = new System.Drawing.Size(95, 29);
            this.txtIdMarque.TabIndex = 16;
            this.txtIdMarque.Visible = false;
            // 
            // ID_MARQ
            // 
            this.ID_MARQ.DataPropertyName = "ID_MARQ";
            this.ID_MARQ.Frozen = true;
            this.ID_MARQ.HeaderText = "IdMarq";
            this.ID_MARQ.MinimumWidth = 6;
            this.ID_MARQ.Name = "ID_MARQ";
            this.ID_MARQ.ReadOnly = true;
            this.ID_MARQ.Visible = false;
            this.ID_MARQ.Width = 125;
            // 
            // CODE_MARQ
            // 
            this.CODE_MARQ.DataPropertyName = "CODE_MARQ";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CODE_MARQ.DefaultCellStyle = dataGridViewCellStyle3;
            this.CODE_MARQ.Frozen = true;
            this.CODE_MARQ.HeaderText = "Code";
            this.CODE_MARQ.MinimumWidth = 6;
            this.CODE_MARQ.Name = "CODE_MARQ";
            this.CODE_MARQ.Width = 80;
            // 
            // DESCRIPTION_MARQ
            // 
            this.DESCRIPTION_MARQ.DataPropertyName = "DESCRIPTION_MARQ";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DESCRIPTION_MARQ.DefaultCellStyle = dataGridViewCellStyle4;
            this.DESCRIPTION_MARQ.HeaderText = "Description";
            this.DESCRIPTION_MARQ.MinimumWidth = 6;
            this.DESCRIPTION_MARQ.Name = "DESCRIPTION_MARQ";
            this.DESCRIPTION_MARQ.Width = 200;
            // 
            // MODELE_MARQ
            // 
            this.MODELE_MARQ.DataPropertyName = "MODELE_MARQ";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.MODELE_MARQ.DefaultCellStyle = dataGridViewCellStyle5;
            this.MODELE_MARQ.HeaderText = "Modèle";
            this.MODELE_MARQ.MinimumWidth = 6;
            this.MODELE_MARQ.Name = "MODELE_MARQ";
            this.MODELE_MARQ.ReadOnly = true;
            this.MODELE_MARQ.Width = 250;
            // 
            // KILO_VIDANGE_MARQ
            // 
            this.KILO_VIDANGE_MARQ.DataPropertyName = "KILO_VIDANGE_MARQ";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.KILO_VIDANGE_MARQ.DefaultCellStyle = dataGridViewCellStyle6;
            this.KILO_VIDANGE_MARQ.HeaderText = "Kilo. vidange";
            this.KILO_VIDANGE_MARQ.MinimumWidth = 6;
            this.KILO_VIDANGE_MARQ.Name = "KILO_VIDANGE_MARQ";
            this.KILO_VIDANGE_MARQ.ReadOnly = true;
            this.KILO_VIDANGE_MARQ.Width = 200;
            // 
            // SEUIL_KILO_VDGE_MARQ
            // 
            this.SEUIL_KILO_VDGE_MARQ.DataPropertyName = "SEUIL_KILO_VDGE_MARQ";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SEUIL_KILO_VDGE_MARQ.DefaultCellStyle = dataGridViewCellStyle7;
            this.SEUIL_KILO_VDGE_MARQ.HeaderText = "Seuil kilo. vdge.";
            this.SEUIL_KILO_VDGE_MARQ.MinimumWidth = 6;
            this.SEUIL_KILO_VDGE_MARQ.Name = "SEUIL_KILO_VDGE_MARQ";
            this.SEUIL_KILO_VDGE_MARQ.ReadOnly = true;
            this.SEUIL_KILO_VDGE_MARQ.Width = 200;
            // 
            // OBSERVATIONS_MARQ
            // 
            this.OBSERVATIONS_MARQ.DataPropertyName = "OBSERVATIONS_MARQ";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.OBSERVATIONS_MARQ.DefaultCellStyle = dataGridViewCellStyle8;
            this.OBSERVATIONS_MARQ.HeaderText = "Note";
            this.OBSERVATIONS_MARQ.MinimumWidth = 6;
            this.OBSERVATIONS_MARQ.Name = "OBSERVATIONS_MARQ";
            this.OBSERVATIONS_MARQ.Width = 350;
            // 
            // USERCREATE_MARQ
            // 
            this.USERCREATE_MARQ.DataPropertyName = "USERCREATE_MARQ";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.USERCREATE_MARQ.DefaultCellStyle = dataGridViewCellStyle9;
            this.USERCREATE_MARQ.HeaderText = "Créer par";
            this.USERCREATE_MARQ.MinimumWidth = 6;
            this.USERCREATE_MARQ.Name = "USERCREATE_MARQ";
            this.USERCREATE_MARQ.Width = 125;
            // 
            // DATECREATE_MARQ
            // 
            this.DATECREATE_MARQ.DataPropertyName = "DATECREATE_MARQ";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DATECREATE_MARQ.DefaultCellStyle = dataGridViewCellStyle10;
            this.DATECREATE_MARQ.HeaderText = "Créer le";
            this.DATECREATE_MARQ.MinimumWidth = 6;
            this.DATECREATE_MARQ.Name = "DATECREATE_MARQ";
            this.DATECREATE_MARQ.Width = 125;
            // 
            // FormMarque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1216, 628);
            this.Controls.Add(this.dataGridViewMarq);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelRegisterMarq);
            this.Controls.Add(this.panelMarqueTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMarque";
            this.Text = "FormMarque";
            this.panelMarqueTitle.ResumeLayout(false);
            this.panelMarqueTitle.PerformLayout();
            this.panelRegisterMarq.ResumeLayout(false);
            this.panelRegisterMarq.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarq)).EndInit();
            this.menuMarq.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMarqueTitle;
        private FontAwesome.Sharp.IconButton BtnCloseFormMarq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelRegisterMarq;
        private FontAwesome.Sharp.IconButton iconBtnAnnulerMarq;
        private System.Windows.Forms.RichTextBox richTextBoxNoteMarq;
        private System.Windows.Forms.TextBox textBoxDescriptMarq;
        private System.Windows.Forms.TextBox textBxCodeMarq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnValiderMarq;
        private System.Windows.Forms.TextBox TxtModelMarq;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TotalModelMarq;
        private System.Windows.Forms.DataGridView dataGridViewMarq;
        private System.Windows.Forms.TextBox txTKiloVidange;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton btnEditMarq;
        private System.Windows.Forms.ContextMenuStrip menuMarq;
        private System.Windows.Forms.ToolStripMenuItem deleteMarq;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxSeuilKiloVdge;
        private FontAwesome.Sharp.IconButton BtnRafraichirMarq;
        private FontAwesome.Sharp.IconButton BtnExportMarq;
        private FontAwesome.Sharp.IconButton BtnImportMarq;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFiltrerMarq;
        private System.Windows.Forms.TextBox txtIdMarque;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_MARQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_MARQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_MARQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODELE_MARQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn KILO_VIDANGE_MARQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEUIL_KILO_VDGE_MARQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBSERVATIONS_MARQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERCREATE_MARQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATECREATE_MARQ;
    }
}