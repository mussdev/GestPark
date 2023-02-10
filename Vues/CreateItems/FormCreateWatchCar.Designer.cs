
namespace GestPark
{
    partial class FormCreateWatchCar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateWatchCar));
            this.CbxVehiculeWatchCar = new System.Windows.Forms.ComboBox();
            this.DatePikerWatchCar = new System.Windows.Forms.DateTimePicker();
            this.TbxCodeWatchCar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnJoindreWatchCar = new FontAwesome.Sharp.IconButton();
            this.IBtnRegisterWatchCar = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtBMontant = new System.Windows.Forms.TextBox();
            this.TxtBLieuWatchCar = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvCarLineWatch = new System.Windows.Forms.DataGridView();
            this.ID_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMMATRICULATION_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CARTE_GRISE_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODELE_MARQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNetAPayerCarWatch = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAddCarWatch = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAddCardPaie = new FontAwesome.Sharp.IconButton();
            this.txtAmountDebite = new System.Windows.Forms.TextBox();
            this.cbxWatchCardPaie = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvPaieWatchCar = new System.Windows.Forms.DataGridView();
            this.ID_CARD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM_CARD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLDE_CARD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountDebite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.datePaieWatch = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarLineWatch)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaieWatchCar)).BeginInit();
            this.SuspendLayout();
            // 
            // CbxVehiculeWatchCar
            // 
            this.CbxVehiculeWatchCar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbxVehiculeWatchCar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbxVehiculeWatchCar.BackColor = System.Drawing.Color.White;
            this.CbxVehiculeWatchCar.FormattingEnabled = true;
            this.CbxVehiculeWatchCar.Items.AddRange(new object[] {
            ""});
            this.CbxVehiculeWatchCar.Location = new System.Drawing.Point(106, 13);
            this.CbxVehiculeWatchCar.Name = "CbxVehiculeWatchCar";
            this.CbxVehiculeWatchCar.Size = new System.Drawing.Size(240, 28);
            this.CbxVehiculeWatchCar.TabIndex = 30;
            this.CbxVehiculeWatchCar.SelectedIndexChanged += new System.EventHandler(this.CbxVehiculeWatchCar_SelectedIndexChanged);
            // 
            // DatePikerWatchCar
            // 
            this.DatePikerWatchCar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePikerWatchCar.Location = new System.Drawing.Point(769, 42);
            this.DatePikerWatchCar.Name = "DatePikerWatchCar";
            this.DatePikerWatchCar.Size = new System.Drawing.Size(116, 28);
            this.DatePikerWatchCar.TabIndex = 26;
            // 
            // TbxCodeWatchCar
            // 
            this.TbxCodeWatchCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.TbxCodeWatchCar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxCodeWatchCar.ForeColor = System.Drawing.Color.Black;
            this.TbxCodeWatchCar.Location = new System.Drawing.Point(69, 45);
            this.TbxCodeWatchCar.Name = "TbxCodeWatchCar";
            this.TbxCodeWatchCar.Size = new System.Drawing.Size(118, 29);
            this.TbxCodeWatchCar.TabIndex = 25;
            this.TbxCodeWatchCar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(246, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Lieu *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(669, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Date appro.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(345, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Net à payer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(11, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Vehicule *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Code";
            // 
            // BtnJoindreWatchCar
            // 
            this.BtnJoindreWatchCar.BackColor = System.Drawing.Color.White;
            this.BtnJoindreWatchCar.ForeColor = System.Drawing.Color.YellowGreen;
            this.BtnJoindreWatchCar.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.BtnJoindreWatchCar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(13)))));
            this.BtnJoindreWatchCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnJoindreWatchCar.IconSize = 20;
            this.BtnJoindreWatchCar.Location = new System.Drawing.Point(30, -2);
            this.BtnJoindreWatchCar.Name = "BtnJoindreWatchCar";
            this.BtnJoindreWatchCar.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.BtnJoindreWatchCar.Size = new System.Drawing.Size(28, 28);
            this.BtnJoindreWatchCar.TabIndex = 3;
            this.BtnJoindreWatchCar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnJoindreWatchCar.UseVisualStyleBackColor = false;
            this.BtnJoindreWatchCar.MouseHover += new System.EventHandler(this.BtnJoindreWatchCar_MouseHover);
            // 
            // IBtnRegisterWatchCar
            // 
            this.IBtnRegisterWatchCar.BackColor = System.Drawing.Color.White;
            this.IBtnRegisterWatchCar.ForeColor = System.Drawing.Color.YellowGreen;
            this.IBtnRegisterWatchCar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.IBtnRegisterWatchCar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(147)))), ((int)(((byte)(222)))));
            this.IBtnRegisterWatchCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBtnRegisterWatchCar.IconSize = 20;
            this.IBtnRegisterWatchCar.Location = new System.Drawing.Point(-2, -2);
            this.IBtnRegisterWatchCar.Name = "IBtnRegisterWatchCar";
            this.IBtnRegisterWatchCar.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.IBtnRegisterWatchCar.Size = new System.Drawing.Size(26, 28);
            this.IBtnRegisterWatchCar.TabIndex = 2;
            this.IBtnRegisterWatchCar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBtnRegisterWatchCar.UseVisualStyleBackColor = false;
            this.IBtnRegisterWatchCar.Click += new System.EventHandler(this.IBtnRegisterWatchCar_Click);
            this.IBtnRegisterWatchCar.MouseHover += new System.EventHandler(this.IBtnRegisterWatchCar_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.BtnJoindreWatchCar);
            this.panel1.Controls.Add(this.IBtnRegisterWatchCar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 28);
            this.panel1.TabIndex = 17;
            // 
            // TxtBMontant
            // 
            this.TxtBMontant.BackColor = System.Drawing.Color.White;
            this.TxtBMontant.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBMontant.ForeColor = System.Drawing.Color.Red;
            this.TxtBMontant.Location = new System.Drawing.Point(440, 145);
            this.TxtBMontant.Name = "TxtBMontant";
            this.TxtBMontant.Size = new System.Drawing.Size(119, 28);
            this.TxtBMontant.TabIndex = 31;
            this.TxtBMontant.Text = "0";
            this.TxtBMontant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtBLieuWatchCar
            // 
            this.TxtBLieuWatchCar.Location = new System.Drawing.Point(307, 45);
            this.TxtBLieuWatchCar.Name = "TxtBLieuWatchCar";
            this.TxtBLieuWatchCar.Size = new System.Drawing.Size(274, 28);
            this.TxtBLieuWatchCar.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 574);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(903, 17);
            this.panel2.TabIndex = 33;
            // 
            // dgvCarLineWatch
            // 
            this.dgvCarLineWatch.AllowUserToOrderColumns = true;
            this.dgvCarLineWatch.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCarLineWatch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCarLineWatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarLineWatch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_VEHICULE,
            this.IMMATRICULATION_VEHICULE,
            this.CARTE_GRISE_VEHICULE,
            this.MODELE_MARQ});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCarLineWatch.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCarLineWatch.GridColor = System.Drawing.Color.White;
            this.dgvCarLineWatch.Location = new System.Drawing.Point(15, 58);
            this.dgvCarLineWatch.Name = "dgvCarLineWatch";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCarLineWatch.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCarLineWatch.RowHeadersWidth = 51;
            this.dgvCarLineWatch.RowTemplate.Height = 24;
            this.dgvCarLineWatch.Size = new System.Drawing.Size(849, 169);
            this.dgvCarLineWatch.TabIndex = 34;
            // 
            // ID_VEHICULE
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ID_VEHICULE.DefaultCellStyle = dataGridViewCellStyle2;
            this.ID_VEHICULE.HeaderText = "Car Key";
            this.ID_VEHICULE.MinimumWidth = 6;
            this.ID_VEHICULE.Name = "ID_VEHICULE";
            this.ID_VEHICULE.ReadOnly = true;
            this.ID_VEHICULE.Visible = false;
            this.ID_VEHICULE.Width = 125;
            // 
            // IMMATRICULATION_VEHICULE
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.IMMATRICULATION_VEHICULE.DefaultCellStyle = dataGridViewCellStyle3;
            this.IMMATRICULATION_VEHICULE.HeaderText = "Matricule";
            this.IMMATRICULATION_VEHICULE.MinimumWidth = 6;
            this.IMMATRICULATION_VEHICULE.Name = "IMMATRICULATION_VEHICULE";
            this.IMMATRICULATION_VEHICULE.ReadOnly = true;
            this.IMMATRICULATION_VEHICULE.Width = 250;
            // 
            // CARTE_GRISE_VEHICULE
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CARTE_GRISE_VEHICULE.DefaultCellStyle = dataGridViewCellStyle4;
            this.CARTE_GRISE_VEHICULE.HeaderText = "Carte grise";
            this.CARTE_GRISE_VEHICULE.MinimumWidth = 6;
            this.CARTE_GRISE_VEHICULE.Name = "CARTE_GRISE_VEHICULE";
            this.CARTE_GRISE_VEHICULE.ReadOnly = true;
            this.CARTE_GRISE_VEHICULE.Width = 200;
            // 
            // MODELE_MARQ
            // 
            this.MODELE_MARQ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.MODELE_MARQ.DefaultCellStyle = dataGridViewCellStyle5;
            this.MODELE_MARQ.HeaderText = "Modèle";
            this.MODELE_MARQ.MinimumWidth = 6;
            this.MODELE_MARQ.Name = "MODELE_MARQ";
            this.MODELE_MARQ.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.txtNetAPayerCarWatch);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.btnAddCarWatch);
            this.panel3.Controls.Add(this.CbxVehiculeWatchCar);
            this.panel3.Controls.Add(this.dgvCarLineWatch);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(27, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(871, 263);
            this.panel3.TabIndex = 35;
            // 
            // txtNetAPayerCarWatch
            // 
            this.txtNetAPayerCarWatch.BackColor = System.Drawing.Color.White;
            this.txtNetAPayerCarWatch.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetAPayerCarWatch.ForeColor = System.Drawing.Color.Red;
            this.txtNetAPayerCarWatch.Location = new System.Drawing.Point(750, 233);
            this.txtNetAPayerCarWatch.Name = "txtNetAPayerCarWatch";
            this.txtNetAPayerCarWatch.Size = new System.Drawing.Size(119, 28);
            this.txtNetAPayerCarWatch.TabIndex = 37;
            this.txtNetAPayerCarWatch.Text = "0";
            this.txtNetAPayerCarWatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNetAPayerCarWatch.TextChanged += new System.EventHandler(this.txtNetAPayerCarWatch_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(651, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 20);
            this.label11.TabIndex = 36;
            this.label11.Text = "Net à payer";
            // 
            // btnAddCarWatch
            // 
            this.btnAddCarWatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnAddCarWatch.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddCarWatch.IconColor = System.Drawing.Color.White;
            this.btnAddCarWatch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddCarWatch.IconSize = 20;
            this.btnAddCarWatch.Location = new System.Drawing.Point(352, 12);
            this.btnAddCarWatch.Name = "btnAddCarWatch";
            this.btnAddCarWatch.Size = new System.Drawing.Size(110, 29);
            this.btnAddCarWatch.TabIndex = 35;
            this.btnAddCarWatch.Text = "Ajouter";
            this.btnAddCarWatch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCarWatch.UseVisualStyleBackColor = false;
            this.btnAddCarWatch.Click += new System.EventHandler(this.btnAddCarWatch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(16, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Sélectionner les véhicules pour le lavage";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btnAddCardPaie);
            this.panel4.Controls.Add(this.txtAmountDebite);
            this.panel4.Controls.Add(this.cbxWatchCardPaie);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(20, 446);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(301, 125);
            this.panel4.TabIndex = 37;
            // 
            // btnAddCardPaie
            // 
            this.btnAddCardPaie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnAddCardPaie.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddCardPaie.IconColor = System.Drawing.Color.White;
            this.btnAddCardPaie.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddCardPaie.IconSize = 20;
            this.btnAddCardPaie.Location = new System.Drawing.Point(183, 93);
            this.btnAddCardPaie.Name = "btnAddCardPaie";
            this.btnAddCardPaie.Size = new System.Drawing.Size(110, 29);
            this.btnAddCardPaie.TabIndex = 36;
            this.btnAddCardPaie.Text = "Ajouter";
            this.btnAddCardPaie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCardPaie.UseVisualStyleBackColor = false;
            this.btnAddCardPaie.Click += new System.EventHandler(this.btnAddCardPaie_Click);
            // 
            // txtAmountDebite
            // 
            this.txtAmountDebite.BackColor = System.Drawing.Color.White;
            this.txtAmountDebite.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountDebite.ForeColor = System.Drawing.Color.Red;
            this.txtAmountDebite.Location = new System.Drawing.Point(79, 58);
            this.txtAmountDebite.Name = "txtAmountDebite";
            this.txtAmountDebite.Size = new System.Drawing.Size(214, 28);
            this.txtAmountDebite.TabIndex = 33;
            this.txtAmountDebite.Text = "0";
            this.txtAmountDebite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountDebite.TextChanged += new System.EventHandler(this.txtAmountDebite_TextChanged);
            // 
            // cbxWatchCardPaie
            // 
            this.cbxWatchCardPaie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxWatchCardPaie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxWatchCardPaie.BackColor = System.Drawing.Color.White;
            this.cbxWatchCardPaie.FormattingEnabled = true;
            this.cbxWatchCardPaie.Items.AddRange(new object[] {
            ""});
            this.cbxWatchCardPaie.Location = new System.Drawing.Point(79, 14);
            this.cbxWatchCardPaie.Name = "cbxWatchCardPaie";
            this.cbxWatchCardPaie.Size = new System.Drawing.Size(214, 28);
            this.cbxWatchCardPaie.TabIndex = 37;
            this.cbxWatchCardPaie.SelectedIndexChanged += new System.EventHandler(this.cbxWatchCardPaie_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(3, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "Montant";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(3, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Carte *";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.dgvPaieWatchCar);
            this.panel5.Controls.Add(this.TxtBMontant);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(327, 389);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(564, 182);
            this.panel5.TabIndex = 38;
            // 
            // dgvPaieWatchCar
            // 
            this.dgvPaieWatchCar.AllowUserToOrderColumns = true;
            this.dgvPaieWatchCar.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaieWatchCar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPaieWatchCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaieWatchCar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_CARD,
            this.NUM_CARD,
            this.SOLDE_CARD,
            this.AmountDebite});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPaieWatchCar.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvPaieWatchCar.GridColor = System.Drawing.Color.White;
            this.dgvPaieWatchCar.Location = new System.Drawing.Point(3, 0);
            this.dgvPaieWatchCar.Name = "dgvPaieWatchCar";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaieWatchCar.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvPaieWatchCar.RowHeadersWidth = 51;
            this.dgvPaieWatchCar.RowTemplate.Height = 24;
            this.dgvPaieWatchCar.Size = new System.Drawing.Size(557, 139);
            this.dgvPaieWatchCar.TabIndex = 0;
            // 
            // ID_CARD
            // 
            this.ID_CARD.DataPropertyName = "ID_CARD";
            this.ID_CARD.HeaderText = "Card Key";
            this.ID_CARD.MinimumWidth = 6;
            this.ID_CARD.Name = "ID_CARD";
            this.ID_CARD.ReadOnly = true;
            this.ID_CARD.Visible = false;
            this.ID_CARD.Width = 125;
            // 
            // NUM_CARD
            // 
            this.NUM_CARD.DataPropertyName = "NUM_CARD";
            this.NUM_CARD.HeaderText = "N° Carte paiement";
            this.NUM_CARD.MinimumWidth = 6;
            this.NUM_CARD.Name = "NUM_CARD";
            this.NUM_CARD.ReadOnly = true;
            this.NUM_CARD.Width = 200;
            // 
            // SOLDE_CARD
            // 
            this.SOLDE_CARD.DataPropertyName = "SOLDE_CARD";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            this.SOLDE_CARD.DefaultCellStyle = dataGridViewCellStyle9;
            this.SOLDE_CARD.HeaderText = "Solde carte";
            this.SOLDE_CARD.MinimumWidth = 6;
            this.SOLDE_CARD.Name = "SOLDE_CARD";
            this.SOLDE_CARD.ReadOnly = true;
            this.SOLDE_CARD.Width = 125;
            // 
            // AmountDebite
            // 
            this.AmountDebite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AmountDebite.DataPropertyName = "AmountDebite";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = null;
            this.AmountDebite.DefaultCellStyle = dataGridViewCellStyle10;
            this.AmountDebite.HeaderText = "Mont. à débiter";
            this.AmountDebite.MinimumWidth = 6;
            this.AmountDebite.Name = "AmountDebite";
            this.AmountDebite.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(16, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(260, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "Sélectionner les cartes pour la paie";
            // 
            // datePaieWatch
            // 
            this.datePaieWatch.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePaieWatch.Location = new System.Drawing.Point(99, 379);
            this.datePaieWatch.Name = "datePaieWatch";
            this.datePaieWatch.Size = new System.Drawing.Size(116, 28);
            this.datePaieWatch.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(16, 385);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 40;
            this.label10.Text = "Date paie";
            // 
            // FormCreateWatchCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(903, 591);
            this.Controls.Add(this.datePaieWatch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DatePikerWatchCar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtBLieuWatchCar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TbxCodeWatchCar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCreateWatchCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enregistrer un véhicule lavé";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarLineWatch)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaieWatchCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbxVehiculeWatchCar;
        private System.Windows.Forms.DateTimePicker DatePikerWatchCar;
        private System.Windows.Forms.TextBox TbxCodeWatchCar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BtnJoindreWatchCar;
        private FontAwesome.Sharp.IconButton IBtnRegisterWatchCar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtBMontant;
        private System.Windows.Forms.TextBox TxtBLieuWatchCar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvCarLineWatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMMATRICULATION_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CARTE_GRISE_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODELE_MARQ;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnAddCarWatch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnAddCardPaie;
        private System.Windows.Forms.TextBox txtAmountDebite;
        private System.Windows.Forms.ComboBox cbxWatchCardPaie;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvPaieWatchCar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker datePaieWatch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNetAPayerCarWatch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CARD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_CARD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLDE_CARD;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountDebite;
    }
}