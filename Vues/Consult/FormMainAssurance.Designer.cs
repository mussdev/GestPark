
namespace GestPark
{
    partial class FormMainAssurance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainAssurance));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.iconBtnExportReportCarAss = new FontAwesome.Sharp.IconButton();
            this.iconBtnCloseFormAssur = new FontAwesome.Sharp.IconButton();
            this.iconBtnCreateAssur = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxVehiculeAssur = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconBtnSearchFormAssur = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbltotalAmoutAssur = new System.Windows.Forms.Label();
            this.lblNbrAssur = new System.Windows.Forms.Label();
            this.DgvAssur = new System.Windows.Forms.DataGridView();
            this.CODE_ASSUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMMATRICULATION_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COUT_ASSUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASSUREUR_ASSUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TYPEASSURANCE_ASSUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUT_ASSUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTE_ASSUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATEASSUR_ASSUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERCREATE_ASSUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATECREATE_ASSUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATEMODIFIER_ASSUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERMODIFY_ASSUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAssur)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.iconBtnExportReportCarAss);
            this.panel1.Controls.Add(this.iconBtnCloseFormAssur);
            this.panel1.Controls.Add(this.iconBtnCreateAssur);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1290, 27);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(662, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Assurance";
            // 
            // iconBtnExportReportCarAss
            // 
            this.iconBtnExportReportCarAss.BackColor = System.Drawing.Color.White;
            this.iconBtnExportReportCarAss.ForeColor = System.Drawing.Color.Black;
            this.iconBtnExportReportCarAss.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromFile;
            this.iconBtnExportReportCarAss.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(13)))));
            this.iconBtnExportReportCarAss.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnExportReportCarAss.IconSize = 20;
            this.iconBtnExportReportCarAss.Location = new System.Drawing.Point(96, -1);
            this.iconBtnExportReportCarAss.Name = "iconBtnExportReportCarAss";
            this.iconBtnExportReportCarAss.Size = new System.Drawing.Size(106, 27);
            this.iconBtnExportReportCarAss.TabIndex = 5;
            this.iconBtnExportReportCarAss.Text = "Expoter";
            this.iconBtnExportReportCarAss.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnExportReportCarAss.UseVisualStyleBackColor = false;
            this.iconBtnExportReportCarAss.Click += new System.EventHandler(this.iconBtnExportReportCarAss_Click);
            this.iconBtnExportReportCarAss.MouseHover += new System.EventHandler(this.iconBtnExportReportCarAss_MouseHover);
            // 
            // iconBtnCloseFormAssur
            // 
            this.iconBtnCloseFormAssur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnCloseFormAssur.BackColor = System.Drawing.Color.White;
            this.iconBtnCloseFormAssur.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.iconBtnCloseFormAssur.IconColor = System.Drawing.Color.Red;
            this.iconBtnCloseFormAssur.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnCloseFormAssur.IconSize = 20;
            this.iconBtnCloseFormAssur.Location = new System.Drawing.Point(1250, -2);
            this.iconBtnCloseFormAssur.Name = "iconBtnCloseFormAssur";
            this.iconBtnCloseFormAssur.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.iconBtnCloseFormAssur.Size = new System.Drawing.Size(38, 27);
            this.iconBtnCloseFormAssur.TabIndex = 5;
            this.iconBtnCloseFormAssur.UseVisualStyleBackColor = false;
            this.iconBtnCloseFormAssur.Click += new System.EventHandler(this.iconBtnCloseFormAssur_Click);
            // 
            // iconBtnCreateAssur
            // 
            this.iconBtnCreateAssur.BackColor = System.Drawing.Color.White;
            this.iconBtnCreateAssur.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnCreateAssur.ForeColor = System.Drawing.Color.Black;
            this.iconBtnCreateAssur.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconBtnCreateAssur.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.iconBtnCreateAssur.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnCreateAssur.IconSize = 20;
            this.iconBtnCreateAssur.Location = new System.Drawing.Point(0, 0);
            this.iconBtnCreateAssur.Name = "iconBtnCreateAssur";
            this.iconBtnCreateAssur.Size = new System.Drawing.Size(90, 25);
            this.iconBtnCreateAssur.TabIndex = 3;
            this.iconBtnCreateAssur.Text = "Saisir";
            this.iconBtnCreateAssur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnCreateAssur.UseVisualStyleBackColor = false;
            this.iconBtnCreateAssur.Click += new System.EventHandler(this.iconBtnCreateAssur_Click);
            this.iconBtnCreateAssur.MouseHover += new System.EventHandler(this.iconBtnCreateAssur_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cbxVehiculeAssur);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.iconBtnSearchFormAssur);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1290, 171);
            this.panel2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(267, 27);
            this.comboBox1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(8, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Période";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(955, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Rechercher";
            // 
            // cbxVehiculeAssur
            // 
            this.cbxVehiculeAssur.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxVehiculeAssur.FormattingEnabled = true;
            this.cbxVehiculeAssur.Location = new System.Drawing.Point(333, 24);
            this.cbxVehiculeAssur.Name = "cbxVehiculeAssur";
            this.cbxVehiculeAssur.Size = new System.Drawing.Size(267, 27);
            this.cbxVehiculeAssur.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(621, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Rech. multi-critère";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(330, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Véhicule";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(146, 84);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(132, 28);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 84);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(128, 28);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(142, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Début";
            // 
            // iconBtnSearchFormAssur
            // 
            this.iconBtnSearchFormAssur.BackColor = System.Drawing.Color.White;
            this.iconBtnSearchFormAssur.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconBtnSearchFormAssur.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.iconBtnSearchFormAssur.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnSearchFormAssur.IconSize = 20;
            this.iconBtnSearchFormAssur.Location = new System.Drawing.Point(1052, 75);
            this.iconBtnSearchFormAssur.Name = "iconBtnSearchFormAssur";
            this.iconBtnSearchFormAssur.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.iconBtnSearchFormAssur.Size = new System.Drawing.Size(31, 28);
            this.iconBtnSearchFormAssur.TabIndex = 4;
            this.iconBtnSearchFormAssur.UseVisualStyleBackColor = false;
            this.iconBtnSearchFormAssur.Click += new System.EventHandler(this.iconBtnSearchFormAssur_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(770, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(313, 26);
            this.textBox1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.panel3.Controls.Add(this.lbltotalAmoutAssur);
            this.panel3.Controls.Add(this.lblNbrAssur);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 198);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1290, 25);
            this.panel3.TabIndex = 2;
            // 
            // lbltotalAmoutAssur
            // 
            this.lbltotalAmoutAssur.AutoSize = true;
            this.lbltotalAmoutAssur.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalAmoutAssur.ForeColor = System.Drawing.Color.Red;
            this.lbltotalAmoutAssur.Location = new System.Drawing.Point(284, 3);
            this.lbltotalAmoutAssur.Name = "lbltotalAmoutAssur";
            this.lbltotalAmoutAssur.Size = new System.Drawing.Size(98, 17);
            this.lbltotalAmoutAssur.TabIndex = 1;
            this.lbltotalAmoutAssur.Text = "Coût total = 0";
            // 
            // lblNbrAssur
            // 
            this.lblNbrAssur.AutoSize = true;
            this.lblNbrAssur.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbrAssur.ForeColor = System.Drawing.Color.Red;
            this.lblNbrAssur.Location = new System.Drawing.Point(3, 3);
            this.lblNbrAssur.Name = "lblNbrAssur";
            this.lblNbrAssur.Size = new System.Drawing.Size(133, 17);
            this.lblNbrAssur.TabIndex = 0;
            this.lblNbrAssur.Text = "Nbr. Assurance = 0";
            // 
            // DgvAssur
            // 
            this.DgvAssur.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvAssur.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvAssur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAssur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODE_ASSUR,
            this.IMMATRICULATION_VEHICULE,
            this.COUT_ASSUR,
            this.ASSUREUR_ASSUR,
            this.TYPEASSURANCE_ASSUR,
            this.STATUT_ASSUR,
            this.NOTE_ASSUR,
            this.DATEASSUR_ASSUR,
            this.USERCREATE_ASSUR,
            this.DATECREATE_ASSUR,
            this.DATEMODIFIER_ASSUR,
            this.USERMODIFY_ASSUR});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvAssur.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvAssur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvAssur.GridColor = System.Drawing.Color.White;
            this.DgvAssur.Location = new System.Drawing.Point(0, 223);
            this.DgvAssur.Name = "DgvAssur";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvAssur.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvAssur.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DgvAssur.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvAssur.Size = new System.Drawing.Size(1290, 547);
            this.DgvAssur.TabIndex = 3;
            this.DgvAssur.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAssur_CellDoubleClick);
            // 
            // CODE_ASSUR
            // 
            this.CODE_ASSUR.DataPropertyName = "CODE_ASSUR";
            this.CODE_ASSUR.HeaderText = "Code";
            this.CODE_ASSUR.MinimumWidth = 6;
            this.CODE_ASSUR.Name = "CODE_ASSUR";
            this.CODE_ASSUR.ReadOnly = true;
            this.CODE_ASSUR.Width = 125;
            // 
            // IMMATRICULATION_VEHICULE
            // 
            this.IMMATRICULATION_VEHICULE.DataPropertyName = "IMMATRICULATION_VEHICULE";
            this.IMMATRICULATION_VEHICULE.HeaderText = "Véhicule";
            this.IMMATRICULATION_VEHICULE.MinimumWidth = 6;
            this.IMMATRICULATION_VEHICULE.Name = "IMMATRICULATION_VEHICULE";
            this.IMMATRICULATION_VEHICULE.ReadOnly = true;
            this.IMMATRICULATION_VEHICULE.Width = 200;
            // 
            // COUT_ASSUR
            // 
            this.COUT_ASSUR.DataPropertyName = "COUT_ASSUR";
            this.COUT_ASSUR.HeaderText = "Montant";
            this.COUT_ASSUR.MinimumWidth = 6;
            this.COUT_ASSUR.Name = "COUT_ASSUR";
            this.COUT_ASSUR.ReadOnly = true;
            this.COUT_ASSUR.Width = 125;
            // 
            // ASSUREUR_ASSUR
            // 
            this.ASSUREUR_ASSUR.DataPropertyName = "ASSUREUR_ASSUR";
            this.ASSUREUR_ASSUR.HeaderText = "Assureur";
            this.ASSUREUR_ASSUR.MinimumWidth = 6;
            this.ASSUREUR_ASSUR.Name = "ASSUREUR_ASSUR";
            this.ASSUREUR_ASSUR.ReadOnly = true;
            this.ASSUREUR_ASSUR.Width = 150;
            // 
            // TYPEASSURANCE_ASSUR
            // 
            this.TYPEASSURANCE_ASSUR.DataPropertyName = "TYPEASSURANCE_ASSUR";
            this.TYPEASSURANCE_ASSUR.HeaderText = "Type assur.";
            this.TYPEASSURANCE_ASSUR.MinimumWidth = 6;
            this.TYPEASSURANCE_ASSUR.Name = "TYPEASSURANCE_ASSUR";
            this.TYPEASSURANCE_ASSUR.ReadOnly = true;
            this.TYPEASSURANCE_ASSUR.Width = 150;
            // 
            // STATUT_ASSUR
            // 
            this.STATUT_ASSUR.DataPropertyName = "STATUT_ASSUR";
            this.STATUT_ASSUR.HeaderText = "Statut";
            this.STATUT_ASSUR.MinimumWidth = 6;
            this.STATUT_ASSUR.Name = "STATUT_ASSUR";
            this.STATUT_ASSUR.ReadOnly = true;
            this.STATUT_ASSUR.Width = 150;
            // 
            // NOTE_ASSUR
            // 
            this.NOTE_ASSUR.DataPropertyName = "NOTE_ASSUR";
            this.NOTE_ASSUR.HeaderText = "Note";
            this.NOTE_ASSUR.MinimumWidth = 6;
            this.NOTE_ASSUR.Name = "NOTE_ASSUR";
            this.NOTE_ASSUR.ReadOnly = true;
            this.NOTE_ASSUR.Width = 300;
            // 
            // DATEASSUR_ASSUR
            // 
            this.DATEASSUR_ASSUR.DataPropertyName = "DATEASSUR_ASSUR";
            this.DATEASSUR_ASSUR.HeaderText = "Date";
            this.DATEASSUR_ASSUR.MinimumWidth = 6;
            this.DATEASSUR_ASSUR.Name = "DATEASSUR_ASSUR";
            this.DATEASSUR_ASSUR.ReadOnly = true;
            this.DATEASSUR_ASSUR.Width = 125;
            // 
            // USERCREATE_ASSUR
            // 
            this.USERCREATE_ASSUR.DataPropertyName = "USERCREATE_ASSUR";
            this.USERCREATE_ASSUR.HeaderText = "Créer par";
            this.USERCREATE_ASSUR.MinimumWidth = 6;
            this.USERCREATE_ASSUR.Name = "USERCREATE_ASSUR";
            this.USERCREATE_ASSUR.ReadOnly = true;
            this.USERCREATE_ASSUR.Width = 125;
            // 
            // DATECREATE_ASSUR
            // 
            this.DATECREATE_ASSUR.DataPropertyName = "DATECREATE_ASSUR";
            this.DATECREATE_ASSUR.HeaderText = "Créer le";
            this.DATECREATE_ASSUR.MinimumWidth = 6;
            this.DATECREATE_ASSUR.Name = "DATECREATE_ASSUR";
            this.DATECREATE_ASSUR.ReadOnly = true;
            this.DATECREATE_ASSUR.Width = 125;
            // 
            // DATEMODIFIER_ASSUR
            // 
            this.DATEMODIFIER_ASSUR.DataPropertyName = "DATEMODIFIER_ASSUR";
            this.DATEMODIFIER_ASSUR.HeaderText = "Modifier le";
            this.DATEMODIFIER_ASSUR.MinimumWidth = 6;
            this.DATEMODIFIER_ASSUR.Name = "DATEMODIFIER_ASSUR";
            this.DATEMODIFIER_ASSUR.ReadOnly = true;
            this.DATEMODIFIER_ASSUR.Width = 150;
            // 
            // USERMODIFY_ASSUR
            // 
            this.USERMODIFY_ASSUR.DataPropertyName = "USERMODIFY_ASSUR";
            this.USERMODIFY_ASSUR.HeaderText = "Modifier par";
            this.USERMODIFY_ASSUR.MinimumWidth = 6;
            this.USERMODIFY_ASSUR.Name = "USERMODIFY_ASSUR";
            this.USERMODIFY_ASSUR.ReadOnly = true;
            this.USERMODIFY_ASSUR.Width = 150;
            // 
            // FormMainAssurance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 770);
            this.Controls.Add(this.DgvAssur);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMainAssurance";
            this.Text = "FormMainAssurance";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAssur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconBtnCreateAssur;
        private FontAwesome.Sharp.IconButton iconBtnExportReportCarAss;
        private FontAwesome.Sharp.IconButton iconBtnSearchFormAssur;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton iconBtnCloseFormAssur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbltotalAmoutAssur;
        private System.Windows.Forms.Label lblNbrAssur;
        private System.Windows.Forms.DataGridView DgvAssur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxVehiculeAssur;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_ASSUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMMATRICULATION_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn COUT_ASSUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASSUREUR_ASSUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn TYPEASSURANCE_ASSUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUT_ASSUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTE_ASSUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATEASSUR_ASSUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERCREATE_ASSUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATECREATE_ASSUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATEMODIFIER_ASSUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERMODIFY_ASSUR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
    }
}