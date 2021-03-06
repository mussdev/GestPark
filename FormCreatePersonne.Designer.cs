
namespace GestPark
{
    partial class FormCreatePersonne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreatePersonne));
            this.paneltitlePerson = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconBtnSavedPerson = new FontAwesome.Sharp.IconButton();
            this.panelInformationPerson = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxCountryPers = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxTownPers = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxAdressPers = new System.Windows.Forms.TextBox();
            this.textBoxCodePostalPers = new System.Windows.Forms.TextBox();
            this.textBxTelPers = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBoxLieuNaissPers = new System.Windows.Forms.ComboBox();
            this.comboBoxTypPers = new System.Windows.Forms.ComboBox();
            this.comboBoxTypPiecPers = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDateNaissPers = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDateCreate = new System.Windows.Forms.DateTimePicker();
            this.textBoxNumPieceIdentPers = new System.Windows.Forms.TextBox();
            this.textBoxNumPermisPers = new System.Windows.Forms.TextBox();
            this.textBxPrenPers = new System.Windows.Forms.TextBox();
            this.textBxNomPers = new System.Windows.Forms.TextBox();
            this.textBxCodePers = new System.Windows.Forms.TextBox();
            this.richTextBoxNotePers = new System.Windows.Forms.RichTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.paneltitlePerson.SuspendLayout();
            this.panelInformationPerson.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneltitlePerson
            // 
            this.paneltitlePerson.BackColor = System.Drawing.Color.DarkOrange;
            this.paneltitlePerson.Controls.Add(this.iconButton1);
            this.paneltitlePerson.Controls.Add(this.iconBtnSavedPerson);
            this.paneltitlePerson.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitlePerson.Location = new System.Drawing.Point(0, 0);
            this.paneltitlePerson.Name = "paneltitlePerson";
            this.paneltitlePerson.Size = new System.Drawing.Size(853, 25);
            this.paneltitlePerson.TabIndex = 0;
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
            this.iconButton1.Location = new System.Drawing.Point(123, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(104, 28);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.Text = "Joindre doc.";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconBtnSavedPerson
            // 
            this.iconBtnSavedPerson.BackColor = System.Drawing.Color.White;
            this.iconBtnSavedPerson.ForeColor = System.Drawing.Color.DarkGreen;
            this.iconBtnSavedPerson.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.iconBtnSavedPerson.IconColor = System.Drawing.Color.DarkGreen;
            this.iconBtnSavedPerson.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnSavedPerson.IconSize = 20;
            this.iconBtnSavedPerson.Location = new System.Drawing.Point(0, 0);
            this.iconBtnSavedPerson.Name = "iconBtnSavedPerson";
            this.iconBtnSavedPerson.Size = new System.Drawing.Size(117, 28);
            this.iconBtnSavedPerson.TabIndex = 1;
            this.iconBtnSavedPerson.Text = "Enregistrer";
            this.iconBtnSavedPerson.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnSavedPerson.UseVisualStyleBackColor = false;
            this.iconBtnSavedPerson.Click += new System.EventHandler(this.iconBtnSavedPerson_Click);
            // 
            // panelInformationPerson
            // 
            this.panelInformationPerson.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelInformationPerson.Controls.Add(this.panel1);
            this.panelInformationPerson.Controls.Add(this.textBxTelPers);
            this.panelInformationPerson.Controls.Add(this.label17);
            this.panelInformationPerson.Controls.Add(this.comboBoxLieuNaissPers);
            this.panelInformationPerson.Controls.Add(this.comboBoxTypPers);
            this.panelInformationPerson.Controls.Add(this.comboBoxTypPiecPers);
            this.panelInformationPerson.Controls.Add(this.dateTimePickerDateNaissPers);
            this.panelInformationPerson.Controls.Add(this.dateTimePickerDateCreate);
            this.panelInformationPerson.Controls.Add(this.textBoxNumPieceIdentPers);
            this.panelInformationPerson.Controls.Add(this.textBoxNumPermisPers);
            this.panelInformationPerson.Controls.Add(this.textBxPrenPers);
            this.panelInformationPerson.Controls.Add(this.textBxNomPers);
            this.panelInformationPerson.Controls.Add(this.textBxCodePers);
            this.panelInformationPerson.Controls.Add(this.richTextBoxNotePers);
            this.panelInformationPerson.Controls.Add(this.label15);
            this.panelInformationPerson.Controls.Add(this.label14);
            this.panelInformationPerson.Controls.Add(this.label13);
            this.panelInformationPerson.Controls.Add(this.label8);
            this.panelInformationPerson.Controls.Add(this.label7);
            this.panelInformationPerson.Controls.Add(this.label6);
            this.panelInformationPerson.Controls.Add(this.label5);
            this.panelInformationPerson.Controls.Add(this.label4);
            this.panelInformationPerson.Controls.Add(this.label3);
            this.panelInformationPerson.Controls.Add(this.label2);
            this.panelInformationPerson.Controls.Add(this.label1);
            this.panelInformationPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInformationPerson.Location = new System.Drawing.Point(0, 25);
            this.panelInformationPerson.Name = "panelInformationPerson";
            this.panelInformationPerson.Size = new System.Drawing.Size(853, 414);
            this.panelInformationPerson.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.comboBoxCountryPers);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.comboBoxTownPers);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.textBoxAdressPers);
            this.panel1.Controls.Add(this.textBoxCodePostalPers);
            this.panel1.Location = new System.Drawing.Point(502, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 196);
            this.panel1.TabIndex = 17;
            // 
            // comboBoxCountryPers
            // 
            this.comboBoxCountryPers.FormattingEnabled = true;
            this.comboBoxCountryPers.Items.AddRange(new object[] {
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
            this.comboBoxCountryPers.Location = new System.Drawing.Point(108, 13);
            this.comboBoxCountryPers.Name = "comboBoxCountryPers";
            this.comboBoxCountryPers.Size = new System.Drawing.Size(205, 25);
            this.comboBoxCountryPers.TabIndex = 13;
            this.comboBoxCountryPers.Text = "Côte d\'ivoire";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(13, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Adresse :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(14, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Pays :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(13, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Ville :";
            // 
            // comboBoxTownPers
            // 
            this.comboBoxTownPers.FormattingEnabled = true;
            this.comboBoxTownPers.Items.AddRange(new object[] {
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
            this.comboBoxTownPers.Location = new System.Drawing.Point(108, 61);
            this.comboBoxTownPers.Name = "comboBoxTownPers";
            this.comboBoxTownPers.Size = new System.Drawing.Size(205, 25);
            this.comboBoxTownPers.TabIndex = 14;
            this.comboBoxTownPers.Text = "Abidjan";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(13, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "Code postale :";
            // 
            // textBoxAdressPers
            // 
            this.textBoxAdressPers.Location = new System.Drawing.Point(108, 106);
            this.textBoxAdressPers.Name = "textBoxAdressPers";
            this.textBoxAdressPers.Size = new System.Drawing.Size(205, 25);
            this.textBoxAdressPers.TabIndex = 12;
            // 
            // textBoxCodePostalPers
            // 
            this.textBoxCodePostalPers.Location = new System.Drawing.Point(108, 149);
            this.textBoxCodePostalPers.Name = "textBoxCodePostalPers";
            this.textBoxCodePostalPers.Size = new System.Drawing.Size(205, 25);
            this.textBoxCodePostalPers.TabIndex = 15;
            // 
            // textBxTelPers
            // 
            this.textBxTelPers.Location = new System.Drawing.Point(119, 146);
            this.textBxTelPers.Name = "textBxTelPers";
            this.textBxTelPers.Size = new System.Drawing.Size(223, 25);
            this.textBxTelPers.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(7, 157);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 17);
            this.label17.TabIndex = 16;
            this.label17.Text = "Tél :";
            // 
            // comboBoxLieuNaissPers
            // 
            this.comboBoxLieuNaissPers.FormattingEnabled = true;
            this.comboBoxLieuNaissPers.Items.AddRange(new object[] {
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
            this.comboBoxLieuNaissPers.Location = new System.Drawing.Point(119, 239);
            this.comboBoxLieuNaissPers.Name = "comboBoxLieuNaissPers";
            this.comboBoxLieuNaissPers.Size = new System.Drawing.Size(223, 25);
            this.comboBoxLieuNaissPers.TabIndex = 6;
            // 
            // comboBoxTypPers
            // 
            this.comboBoxTypPers.FormattingEnabled = true;
            this.comboBoxTypPers.Items.AddRange(new object[] {
            "Propriétaire",
            "Conducteur"});
            this.comboBoxTypPers.Location = new System.Drawing.Point(610, 70);
            this.comboBoxTypPers.Name = "comboBoxTypPers";
            this.comboBoxTypPers.Size = new System.Drawing.Size(205, 25);
            this.comboBoxTypPers.TabIndex = 11;
            // 
            // comboBoxTypPiecPers
            // 
            this.comboBoxTypPiecPers.FormattingEnabled = true;
            this.comboBoxTypPiecPers.Items.AddRange(new object[] {
            "Attestation d\'identité",
            "Carte d\'identité",
            "Passeport",
            "Carte consulaire",
            "Permis de conduite",
            "Carte résidence"});
            this.comboBoxTypPiecPers.Location = new System.Drawing.Point(119, 281);
            this.comboBoxTypPiecPers.Name = "comboBoxTypPiecPers";
            this.comboBoxTypPiecPers.Size = new System.Drawing.Size(223, 25);
            this.comboBoxTypPiecPers.TabIndex = 7;
            // 
            // dateTimePickerDateNaissPers
            // 
            this.dateTimePickerDateNaissPers.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateNaissPers.Location = new System.Drawing.Point(119, 193);
            this.dateTimePickerDateNaissPers.Name = "dateTimePickerDateNaissPers";
            this.dateTimePickerDateNaissPers.Size = new System.Drawing.Size(223, 25);
            this.dateTimePickerDateNaissPers.TabIndex = 5;
            // 
            // dateTimePickerDateCreate
            // 
            this.dateTimePickerDateCreate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateCreate.Location = new System.Drawing.Point(610, 18);
            this.dateTimePickerDateCreate.Name = "dateTimePickerDateCreate";
            this.dateTimePickerDateCreate.Size = new System.Drawing.Size(205, 25);
            this.dateTimePickerDateCreate.TabIndex = 10;
            // 
            // textBoxNumPieceIdentPers
            // 
            this.textBoxNumPieceIdentPers.Location = new System.Drawing.Point(119, 325);
            this.textBoxNumPieceIdentPers.Name = "textBoxNumPieceIdentPers";
            this.textBoxNumPieceIdentPers.Size = new System.Drawing.Size(223, 25);
            this.textBoxNumPieceIdentPers.TabIndex = 8;
            // 
            // textBoxNumPermisPers
            // 
            this.textBoxNumPermisPers.Location = new System.Drawing.Point(119, 369);
            this.textBoxNumPermisPers.Name = "textBoxNumPermisPers";
            this.textBoxNumPermisPers.Size = new System.Drawing.Size(223, 25);
            this.textBoxNumPermisPers.TabIndex = 9;
            // 
            // textBxPrenPers
            // 
            this.textBxPrenPers.Location = new System.Drawing.Point(119, 99);
            this.textBxPrenPers.Name = "textBxPrenPers";
            this.textBxPrenPers.Size = new System.Drawing.Size(223, 25);
            this.textBxPrenPers.TabIndex = 3;
            // 
            // textBxNomPers
            // 
            this.textBxNomPers.Location = new System.Drawing.Point(119, 55);
            this.textBxNomPers.Name = "textBxNomPers";
            this.textBxNomPers.Size = new System.Drawing.Size(223, 25);
            this.textBxNomPers.TabIndex = 2;
            // 
            // textBxCodePers
            // 
            this.textBxCodePers.BackColor = System.Drawing.Color.Khaki;
            this.textBxCodePers.Location = new System.Drawing.Point(119, 12);
            this.textBxCodePers.Name = "textBxCodePers";
            this.textBxCodePers.ReadOnly = true;
            this.textBxCodePers.Size = new System.Drawing.Size(100, 25);
            this.textBxCodePers.TabIndex = 1;
            // 
            // richTextBoxNotePers
            // 
            this.richTextBoxNotePers.Location = new System.Drawing.Point(610, 333);
            this.richTextBoxNotePers.Name = "richTextBoxNotePers";
            this.richTextBoxNotePers.Size = new System.Drawing.Size(225, 61);
            this.richTextBoxNotePers.TabIndex = 16;
            this.richTextBoxNotePers.Text = "";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(4, 377);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 17);
            this.label15.TabIndex = 14;
            this.label15.Text = "N° de permis :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(516, 336);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 17);
            this.label14.TabIndex = 13;
            this.label14.Text = "Note :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(501, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "Date :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(501, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Type de pers. :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(4, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "N° pièce d\'ident. :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(4, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Type Pièce :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(4, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lieu de Naiss. :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date de Naiss. :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(4, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prénom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(4, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code :";
            // 
            // FormCreatePersonne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 439);
            this.Controls.Add(this.panelInformationPerson);
            this.Controls.Add(this.paneltitlePerson);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCreatePersonne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Créer un personnel";
            this.paneltitlePerson.ResumeLayout(false);
            this.panelInformationPerson.ResumeLayout(false);
            this.panelInformationPerson.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltitlePerson;
        private FontAwesome.Sharp.IconButton iconBtnSavedPerson;
        private System.Windows.Forms.Panel panelInformationPerson;
        private System.Windows.Forms.ComboBox comboBoxLieuNaissPers;
        private System.Windows.Forms.ComboBox comboBoxTownPers;
        private System.Windows.Forms.ComboBox comboBoxCountryPers;
        private System.Windows.Forms.ComboBox comboBoxTypPers;
        private System.Windows.Forms.ComboBox comboBoxTypPiecPers;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateNaissPers;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateCreate;
        private System.Windows.Forms.TextBox textBoxNumPieceIdentPers;
        private System.Windows.Forms.TextBox textBoxNumPermisPers;
        private System.Windows.Forms.TextBox textBoxCodePostalPers;
        private System.Windows.Forms.TextBox textBoxAdressPers;
        private System.Windows.Forms.TextBox textBxPrenPers;
        private System.Windows.Forms.TextBox textBxNomPers;
        private System.Windows.Forms.TextBox textBxCodePers;
        private System.Windows.Forms.RichTextBox richTextBoxNotePers;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBxTelPers;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}