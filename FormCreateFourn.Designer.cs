
namespace GestPark
{
    partial class FormCreateFourn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateFourn));
            this.panelCreateFormFournTitle = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconBtnSavedFourn = new FontAwesome.Sharp.IconButton();
            this.panelContainerFourn = new System.Windows.Forms.Panel();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.comboBoxTown = new System.Windows.Forms.ComboBox();
            this.textBxCodPostalFourn = new System.Windows.Forms.TextBox();
            this.textBoxOtherFieldFourn = new System.Windows.Forms.TextBox();
            this.richTextBoxNoteFourn = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxRCFourn = new System.Windows.Forms.TextBox();
            this.textBxCCFourn = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePickerFourn = new System.Windows.Forms.DateTimePicker();
            this.textBxRueFourn = new System.Windows.Forms.TextBox();
            this.textBxMailFourn = new System.Windows.Forms.TextBox();
            this.textBxTelFourn = new System.Windows.Forms.TextBox();
            this.textBxDescripFourn = new System.Windows.Forms.TextBox();
            this.textBxCodFourn = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelCreateFormFournTitle.SuspendLayout();
            this.panelContainerFourn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCreateFormFournTitle
            // 
            this.panelCreateFormFournTitle.BackColor = System.Drawing.Color.Khaki;
            this.panelCreateFormFournTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCreateFormFournTitle.Controls.Add(this.iconButton1);
            this.panelCreateFormFournTitle.Controls.Add(this.iconBtnSavedFourn);
            this.panelCreateFormFournTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCreateFormFournTitle.Location = new System.Drawing.Point(0, 0);
            this.panelCreateFormFournTitle.Name = "panelCreateFormFournTitle";
            this.panelCreateFormFournTitle.Size = new System.Drawing.Size(771, 28);
            this.panelCreateFormFournTitle.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.White;
            this.iconButton1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.DarkGreen;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.iconButton1.IconColor = System.Drawing.Color.DarkGreen;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(100, -2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(104, 28);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.Text = "Joindre doc.";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconBtnSavedFourn
            // 
            this.iconBtnSavedFourn.BackColor = System.Drawing.Color.White;
            this.iconBtnSavedFourn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnSavedFourn.ForeColor = System.Drawing.Color.DarkGreen;
            this.iconBtnSavedFourn.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.iconBtnSavedFourn.IconColor = System.Drawing.Color.DarkGreen;
            this.iconBtnSavedFourn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnSavedFourn.IconSize = 20;
            this.iconBtnSavedFourn.Location = new System.Drawing.Point(-2, -2);
            this.iconBtnSavedFourn.Name = "iconBtnSavedFourn";
            this.iconBtnSavedFourn.Size = new System.Drawing.Size(96, 29);
            this.iconBtnSavedFourn.TabIndex = 1;
            this.iconBtnSavedFourn.Text = "Enregistrer";
            this.iconBtnSavedFourn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnSavedFourn.UseVisualStyleBackColor = false;
            this.iconBtnSavedFourn.Click += new System.EventHandler(this.iconBtnSavedFourn_Click);
            // 
            // panelContainerFourn
            // 
            this.panelContainerFourn.BackColor = System.Drawing.Color.Khaki;
            this.panelContainerFourn.Controls.Add(this.comboBoxCountry);
            this.panelContainerFourn.Controls.Add(this.comboBoxTown);
            this.panelContainerFourn.Controls.Add(this.textBxCodPostalFourn);
            this.panelContainerFourn.Controls.Add(this.textBoxOtherFieldFourn);
            this.panelContainerFourn.Controls.Add(this.richTextBoxNoteFourn);
            this.panelContainerFourn.Controls.Add(this.label13);
            this.panelContainerFourn.Controls.Add(this.textBoxRCFourn);
            this.panelContainerFourn.Controls.Add(this.textBxCCFourn);
            this.panelContainerFourn.Controls.Add(this.label12);
            this.panelContainerFourn.Controls.Add(this.label11);
            this.panelContainerFourn.Controls.Add(this.dateTimePickerFourn);
            this.panelContainerFourn.Controls.Add(this.textBxRueFourn);
            this.panelContainerFourn.Controls.Add(this.textBxMailFourn);
            this.panelContainerFourn.Controls.Add(this.textBxTelFourn);
            this.panelContainerFourn.Controls.Add(this.textBxDescripFourn);
            this.panelContainerFourn.Controls.Add(this.textBxCodFourn);
            this.panelContainerFourn.Controls.Add(this.label10);
            this.panelContainerFourn.Controls.Add(this.label9);
            this.panelContainerFourn.Controls.Add(this.label8);
            this.panelContainerFourn.Controls.Add(this.label7);
            this.panelContainerFourn.Controls.Add(this.label6);
            this.panelContainerFourn.Controls.Add(this.label5);
            this.panelContainerFourn.Controls.Add(this.label4);
            this.panelContainerFourn.Controls.Add(this.label3);
            this.panelContainerFourn.Controls.Add(this.label2);
            this.panelContainerFourn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainerFourn.Location = new System.Drawing.Point(0, 28);
            this.panelContainerFourn.Name = "panelContainerFourn";
            this.panelContainerFourn.Size = new System.Drawing.Size(771, 386);
            this.panelContainerFourn.TabIndex = 1;
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.DisplayMember = "DESCRIPTIONPAYS";
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Items.AddRange(new object[] {
            "Afrique du Sud",
            "Afghanistan",
            "Albanie",
            "Algérie",
            "Allemagne",
            "Andorre",
            "Angola",
            "Arabie saoudite",
            "Argentine",
            "Arménie",
            "Australie",
            "Autriche",
            "Azerbaïdjan",
            "Bahamas",
            "Bahreïn",
            "Bangladesh",
            "Barbade",
            "Bélarus",
            "Belgique",
            "Bélize",
            "Bénin",
            "Bhoutan",
            "Birmanie",
            "Bolivie",
            "Bosnie-Herzégovine",
            "Botswana",
            "Brésil",
            "Brunéi Darussalam",
            "Bulgarie",
            "Burkina Faso",
            "Burundi",
            "Cameroun",
            "Canada",
            "Chili",
            "Chine",
            "Chypre",
            "Colombie",
            "Comores",
            "Congo",
            "Corée du Nord",
            "Corée du Sud",
            "Costa Rica",
            "Côte d’Ivoire",
            "Croatie",
            "Cuba",
            "Danemark",
            "Djibouti",
            "Dominique",
            "Égypte",
            "Émirats arabes unis",
            "Équateur",
            "Érythrée",
            "Espagne",
            "Estonie",
            "États-Unis d’Amérique",
            "Éthiopie",
            "Fidji",
            "Finlande",
            "France",
            "Gabon",
            "Gambie",
            "Géorgie",
            "Ghana",
            "Grèce",
            "Grenade",
            "Guatemala",
            "Guinée",
            "Guinée-Bissau",
            "Guinée équatoriale",
            "Guyana",
            "Haïti",
            "Honduras",
            "Hongrie",
            "Île Maurice",
            "Îles Marshall",
            "Îles Salomon",
            "Inde",
            "Indonésie",
            "Iran",
            "Iraq",
            "Irlande",
            "Islande",
            "Israël",
            "Italie",
            "Jamaïque",
            "Japon",
            "Jordanie",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Kirghizistan",
            "Kosovo",
            "Koweït",
            "Laos",
            "Lesotho",
            "Lettonie",
            "Liban",
            "Libéria",
            "Libye",
            "Liechtenstein",
            "Lituanie",
            "Luxembourg",
            "Macédoine",
            "Madagascar",
            "Malaisie",
            "Malawi",
            "Maldives",
            "Mali",
            "Malte",
            "Maroc",
            "Mauritanie",
            "Mexique",
            "Micronésie",
            "Moldavie",
            "Monaco",
            "Monténégro",
            "Mozambique",
            "Namibie",
            "Nauru",
            "Népal",
            "Nicaragua",
            "Niger",
            "Nigéria",
            "Norvège",
            "Nouvelle-Zélande",
            "Oman",
            "Ouganda",
            "Ouzbékistan",
            "Pakistan",
            "Palaos",
            "Panamá",
            "Papouasie-Nouvelle-Guinée",
            "Paraguay",
            "Pays-Bas",
            "Pérou",
            "Philippines",
            "Pologne",
            "Portugal",
            "Qatar",
            "République centrafricaine",
            "République démocratique du Congo",
            "République dominicaine",
            "République tchèque",
            "Roumanie",
            "Royaume-Uni",
            "Russie",
            "Rwanda",
            "Saint-Kitts-et-Nevis",
            "Sainte-Lucie",
            "Saint-Marin",
            "Saint-Vincent-et-les Grenadines",
            "Saint-Siège",
            "Salvador",
            "Samoa",
            "Sao Tomé-et-Principe",
            "Sénégal",
            "Serbie",
            "Seychelles",
            "Sierra Leone",
            "Singapour",
            "Slovaquie",
            "Slovénie",
            "Somalie",
            "Soudan",
            "Soudan du Sud",
            "Sri Lanka",
            "Suède",
            "Suisse",
            "Suriname",
            "Swaziland",
            "Syrie",
            "Tadjikistan",
            "Taïwan",
            "Tanzanie",
            "Tchad",
            "Thaïlande",
            "Timor-Oriental",
            "Togo",
            "Tonga",
            "Trinité-et-Tobago",
            "Tunisie",
            "Turquie",
            "Turkménistan",
            "Tuvalu",
            "Ukraine",
            "Uruguay",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Yémen",
            "Zambie",
            "Zimbabwe"});
            this.comboBoxCountry.Location = new System.Drawing.Point(506, 204);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(249, 23);
            this.comboBoxCountry.TabIndex = 24;
            this.comboBoxCountry.Text = "Côte d\'ivoire";
            this.comboBoxCountry.ValueMember = "DESCRIPTIONPAYS";
            // 
            // comboBoxTown
            // 
            this.comboBoxTown.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTown.FormattingEnabled = true;
            this.comboBoxTown.Items.AddRange(new object[] {
            "Abengourou",
            "Abidjan",
            "Adzopé",
            "Agboville",
            "Agnibilékrou",
            "Akoupé",
            "Anyama",
            "Bingerville",
            "Bondoukou",
            "Bouaflé",
            "Bouaké",
            "Boundiali",
            "Dabou",
            "Daloa",
            "Danané",
            "Daoukro",
            "Dimbokro1",
            "Divo",
            "Duékoué",
            "Ferkessedougou",
            "Gagnoa",
            "Grand-Bassam",
            "Guiglo",
            "Issia",
            "Katiola",
            "Korhogo",
            "Lakota",
            "Man",
            "Odienné",
            "Oumé",
            "San-Pédro",
            "Séguéla",
            "Sinfra",
            "Soubré",
            "Tiassalé",
            "Tingréla",
            "Toumodi",
            "Vavoua",
            "Yamoussoukro",
            "Zuénoula"});
            this.comboBoxTown.Location = new System.Drawing.Point(506, 160);
            this.comboBoxTown.Name = "comboBoxTown";
            this.comboBoxTown.Size = new System.Drawing.Size(249, 23);
            this.comboBoxTown.TabIndex = 23;
            this.comboBoxTown.Text = "Abidjan";
            // 
            // textBxCodPostalFourn
            // 
            this.textBxCodPostalFourn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBxCodPostalFourn.Location = new System.Drawing.Point(507, 114);
            this.textBxCodPostalFourn.Name = "textBxCodPostalFourn";
            this.textBxCodPostalFourn.Size = new System.Drawing.Size(249, 22);
            this.textBxCodPostalFourn.TabIndex = 9;
            // 
            // textBoxOtherFieldFourn
            // 
            this.textBoxOtherFieldFourn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOtherFieldFourn.Location = new System.Drawing.Point(506, 245);
            this.textBoxOtherFieldFourn.Name = "textBoxOtherFieldFourn";
            this.textBoxOtherFieldFourn.Size = new System.Drawing.Size(249, 22);
            this.textBoxOtherFieldFourn.TabIndex = 12;
            // 
            // richTextBoxNoteFourn
            // 
            this.richTextBoxNoteFourn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxNoteFourn.Location = new System.Drawing.Point(127, 296);
            this.richTextBoxNoteFourn.Name = "richTextBoxNoteFourn";
            this.richTextBoxNoteFourn.Size = new System.Drawing.Size(628, 70);
            this.richTextBoxNoteFourn.TabIndex = 13;
            this.richTextBoxNoteFourn.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(14, 296);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 17);
            this.label13.TabIndex = 22;
            this.label13.Text = "Note :";
            // 
            // textBoxRCFourn
            // 
            this.textBoxRCFourn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRCFourn.Location = new System.Drawing.Point(127, 247);
            this.textBoxRCFourn.Name = "textBoxRCFourn";
            this.textBoxRCFourn.Size = new System.Drawing.Size(261, 22);
            this.textBoxRCFourn.TabIndex = 6;
            // 
            // textBxCCFourn
            // 
            this.textBxCCFourn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBxCCFourn.Location = new System.Drawing.Point(127, 204);
            this.textBxCCFourn.Name = "textBxCCFourn";
            this.textBxCCFourn.Size = new System.Drawing.Size(261, 22);
            this.textBxCCFourn.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(15, 247);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "R.C :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(15, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "C.C :";
            // 
            // dateTimePickerFourn
            // 
            this.dateTimePickerFourn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFourn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFourn.Location = new System.Drawing.Point(506, 26);
            this.dateTimePickerFourn.Name = "dateTimePickerFourn";
            this.dateTimePickerFourn.Size = new System.Drawing.Size(249, 22);
            this.dateTimePickerFourn.TabIndex = 7;
            // 
            // textBxRueFourn
            // 
            this.textBxRueFourn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBxRueFourn.Location = new System.Drawing.Point(506, 68);
            this.textBxRueFourn.Name = "textBxRueFourn";
            this.textBxRueFourn.Size = new System.Drawing.Size(249, 22);
            this.textBxRueFourn.TabIndex = 8;
            // 
            // textBxMailFourn
            // 
            this.textBxMailFourn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBxMailFourn.Location = new System.Drawing.Point(128, 159);
            this.textBxMailFourn.Name = "textBxMailFourn";
            this.textBxMailFourn.Size = new System.Drawing.Size(261, 22);
            this.textBxMailFourn.TabIndex = 4;
            // 
            // textBxTelFourn
            // 
            this.textBxTelFourn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBxTelFourn.Location = new System.Drawing.Point(127, 114);
            this.textBxTelFourn.Name = "textBxTelFourn";
            this.textBxTelFourn.Size = new System.Drawing.Size(261, 22);
            this.textBxTelFourn.TabIndex = 3;
            // 
            // textBxDescripFourn
            // 
            this.textBxDescripFourn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBxDescripFourn.Location = new System.Drawing.Point(127, 68);
            this.textBxDescripFourn.Name = "textBxDescripFourn";
            this.textBxDescripFourn.Size = new System.Drawing.Size(261, 22);
            this.textBxDescripFourn.TabIndex = 2;
            // 
            // textBxCodFourn
            // 
            this.textBxCodFourn.BackColor = System.Drawing.Color.YellowGreen;
            this.textBxCodFourn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBxCodFourn.Location = new System.Drawing.Point(127, 24);
            this.textBxCodFourn.Name = "textBxCodFourn";
            this.textBxCodFourn.Size = new System.Drawing.Size(144, 22);
            this.textBxCodFourn.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(402, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Pays :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(399, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Ville :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(396, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Code postal :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(395, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Adresse :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(392, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(15, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mail :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(14, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tel. :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(14, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Description :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Code :";
            // 
            // FormCreateFourn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(771, 414);
            this.Controls.Add(this.panelContainerFourn);
            this.Controls.Add(this.panelCreateFormFournTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCreateFourn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Créer un fournisseur";
            this.panelCreateFormFournTitle.ResumeLayout(false);
            this.panelContainerFourn.ResumeLayout(false);
            this.panelContainerFourn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCreateFormFournTitle;
        private FontAwesome.Sharp.IconButton iconBtnSavedFourn;
        private System.Windows.Forms.Panel panelContainerFourn;
        private System.Windows.Forms.TextBox textBxCodPostalFourn;
        private System.Windows.Forms.TextBox textBoxOtherFieldFourn;
        private System.Windows.Forms.RichTextBox richTextBoxNoteFourn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxRCFourn;
        private System.Windows.Forms.TextBox textBxCCFourn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePickerFourn;
        private System.Windows.Forms.TextBox textBxRueFourn;
        private System.Windows.Forms.TextBox textBxMailFourn;
        private System.Windows.Forms.TextBox textBxTelFourn;
        private System.Windows.Forms.TextBox textBxDescripFourn;
        private System.Windows.Forms.TextBox textBxCodFourn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTown;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}