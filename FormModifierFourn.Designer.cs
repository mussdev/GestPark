
namespace GestPark
{
    partial class FormModifierFourn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModifierFourn));
            this.BtnImportMod = new FontAwesome.Sharp.IconButton();
            this.BtnSavedFournMod = new FontAwesome.Sharp.IconButton();
            this.CbxCountryMod = new System.Windows.Forms.ComboBox();
            this.CbxTownMod = new System.Windows.Forms.ComboBox();
            this.TxtCodPostalFournMod = new System.Windows.Forms.TextBox();
            this.TxtOtherFieldFournMod = new System.Windows.Forms.TextBox();
            this.RtxtNoteFournMod = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtRCFournMod = new System.Windows.Forms.TextBox();
            this.TxtCCFournMod = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DtpRegisterFournMod = new System.Windows.Forms.DateTimePicker();
            this.TxtAdressFournMod = new System.Windows.Forms.TextBox();
            this.TxtMailFournMod = new System.Windows.Forms.TextBox();
            this.TxtTelFournMod = new System.Windows.Forms.TextBox();
            this.TxtDescripFournMod = new System.Windows.Forms.TextBox();
            this.TxtCodFournMod = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelContainerFourn = new System.Windows.Forms.Panel();
            this.panelCreateFormFournTitle = new System.Windows.Forms.Panel();
            this.panelContainerFourn.SuspendLayout();
            this.panelCreateFormFournTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnImportMod
            // 
            this.BtnImportMod.BackColor = System.Drawing.Color.White;
            this.BtnImportMod.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImportMod.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.BtnImportMod.IconColor = System.Drawing.Color.DarkGreen;
            this.BtnImportMod.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnImportMod.IconSize = 20;
            this.BtnImportMod.Location = new System.Drawing.Point(100, -2);
            this.BtnImportMod.Name = "BtnImportMod";
            this.BtnImportMod.Size = new System.Drawing.Size(104, 28);
            this.BtnImportMod.TabIndex = 3;
            this.BtnImportMod.Text = "Joindre doc.";
            this.BtnImportMod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnImportMod.UseVisualStyleBackColor = false;
            // 
            // BtnSavedFournMod
            // 
            this.BtnSavedFournMod.BackColor = System.Drawing.Color.White;
            this.BtnSavedFournMod.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSavedFournMod.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.BtnSavedFournMod.IconColor = System.Drawing.Color.DarkGreen;
            this.BtnSavedFournMod.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSavedFournMod.IconSize = 20;
            this.BtnSavedFournMod.Location = new System.Drawing.Point(-2, -2);
            this.BtnSavedFournMod.Name = "BtnSavedFournMod";
            this.BtnSavedFournMod.Size = new System.Drawing.Size(96, 29);
            this.BtnSavedFournMod.TabIndex = 1;
            this.BtnSavedFournMod.Text = "Enregistrer";
            this.BtnSavedFournMod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSavedFournMod.UseVisualStyleBackColor = false;
            this.BtnSavedFournMod.Click += new System.EventHandler(this.BtnSavedFournMod_Click);
            // 
            // CbxCountryMod
            // 
            this.CbxCountryMod.DisplayMember = "DESCRIPTIONPAYS";
            this.CbxCountryMod.FormattingEnabled = true;
            this.CbxCountryMod.Items.AddRange(new object[] {
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
            this.CbxCountryMod.Location = new System.Drawing.Point(506, 204);
            this.CbxCountryMod.Name = "CbxCountryMod";
            this.CbxCountryMod.Size = new System.Drawing.Size(249, 23);
            this.CbxCountryMod.TabIndex = 24;
            this.CbxCountryMod.Text = "Côte d\'ivoire";
            this.CbxCountryMod.ValueMember = "DESCRIPTIONPAYS";
            // 
            // CbxTownMod
            // 
            this.CbxTownMod.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxTownMod.FormattingEnabled = true;
            this.CbxTownMod.Items.AddRange(new object[] {
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
            this.CbxTownMod.Location = new System.Drawing.Point(506, 160);
            this.CbxTownMod.Name = "CbxTownMod";
            this.CbxTownMod.Size = new System.Drawing.Size(249, 23);
            this.CbxTownMod.TabIndex = 23;
            this.CbxTownMod.Text = "Abidjan";
            // 
            // TxtCodPostalFournMod
            // 
            this.TxtCodPostalFournMod.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodPostalFournMod.Location = new System.Drawing.Point(507, 114);
            this.TxtCodPostalFournMod.Name = "TxtCodPostalFournMod";
            this.TxtCodPostalFournMod.Size = new System.Drawing.Size(249, 22);
            this.TxtCodPostalFournMod.TabIndex = 9;
            // 
            // TxtOtherFieldFournMod
            // 
            this.TxtOtherFieldFournMod.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOtherFieldFournMod.Location = new System.Drawing.Point(506, 245);
            this.TxtOtherFieldFournMod.Name = "TxtOtherFieldFournMod";
            this.TxtOtherFieldFournMod.Size = new System.Drawing.Size(249, 22);
            this.TxtOtherFieldFournMod.TabIndex = 12;
            // 
            // RtxtNoteFournMod
            // 
            this.RtxtNoteFournMod.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtxtNoteFournMod.Location = new System.Drawing.Point(127, 296);
            this.RtxtNoteFournMod.Name = "RtxtNoteFournMod";
            this.RtxtNoteFournMod.Size = new System.Drawing.Size(628, 70);
            this.RtxtNoteFournMod.TabIndex = 13;
            this.RtxtNoteFournMod.Text = "";
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
            // TxtRCFournMod
            // 
            this.TxtRCFournMod.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRCFournMod.Location = new System.Drawing.Point(127, 247);
            this.TxtRCFournMod.Name = "TxtRCFournMod";
            this.TxtRCFournMod.Size = new System.Drawing.Size(261, 22);
            this.TxtRCFournMod.TabIndex = 6;
            // 
            // TxtCCFournMod
            // 
            this.TxtCCFournMod.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCCFournMod.Location = new System.Drawing.Point(127, 204);
            this.TxtCCFournMod.Name = "TxtCCFournMod";
            this.TxtCCFournMod.Size = new System.Drawing.Size(261, 22);
            this.TxtCCFournMod.TabIndex = 5;
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
            // DtpRegisterFournMod
            // 
            this.DtpRegisterFournMod.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpRegisterFournMod.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpRegisterFournMod.Location = new System.Drawing.Point(506, 26);
            this.DtpRegisterFournMod.Name = "DtpRegisterFournMod";
            this.DtpRegisterFournMod.Size = new System.Drawing.Size(249, 22);
            this.DtpRegisterFournMod.TabIndex = 7;
            // 
            // TxtAdressFournMod
            // 
            this.TxtAdressFournMod.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAdressFournMod.Location = new System.Drawing.Point(506, 68);
            this.TxtAdressFournMod.Name = "TxtAdressFournMod";
            this.TxtAdressFournMod.Size = new System.Drawing.Size(249, 22);
            this.TxtAdressFournMod.TabIndex = 8;
            // 
            // TxtMailFournMod
            // 
            this.TxtMailFournMod.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMailFournMod.Location = new System.Drawing.Point(128, 159);
            this.TxtMailFournMod.Name = "TxtMailFournMod";
            this.TxtMailFournMod.Size = new System.Drawing.Size(261, 22);
            this.TxtMailFournMod.TabIndex = 4;
            // 
            // TxtTelFournMod
            // 
            this.TxtTelFournMod.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelFournMod.Location = new System.Drawing.Point(127, 114);
            this.TxtTelFournMod.Name = "TxtTelFournMod";
            this.TxtTelFournMod.Size = new System.Drawing.Size(261, 22);
            this.TxtTelFournMod.TabIndex = 3;
            // 
            // TxtDescripFournMod
            // 
            this.TxtDescripFournMod.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripFournMod.Location = new System.Drawing.Point(127, 68);
            this.TxtDescripFournMod.Name = "TxtDescripFournMod";
            this.TxtDescripFournMod.Size = new System.Drawing.Size(261, 22);
            this.TxtDescripFournMod.TabIndex = 2;
            // 
            // TxtCodFournMod
            // 
            this.TxtCodFournMod.BackColor = System.Drawing.Color.Khaki;
            this.TxtCodFournMod.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodFournMod.Location = new System.Drawing.Point(127, 24);
            this.TxtCodFournMod.Name = "TxtCodFournMod";
            this.TxtCodFournMod.ReadOnly = true;
            this.TxtCodFournMod.Size = new System.Drawing.Size(144, 22);
            this.TxtCodFournMod.TabIndex = 1;
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
            // panelContainerFourn
            // 
            this.panelContainerFourn.BackColor = System.Drawing.Color.LightGreen;
            this.panelContainerFourn.Controls.Add(this.CbxCountryMod);
            this.panelContainerFourn.Controls.Add(this.CbxTownMod);
            this.panelContainerFourn.Controls.Add(this.TxtCodPostalFournMod);
            this.panelContainerFourn.Controls.Add(this.TxtOtherFieldFournMod);
            this.panelContainerFourn.Controls.Add(this.RtxtNoteFournMod);
            this.panelContainerFourn.Controls.Add(this.label13);
            this.panelContainerFourn.Controls.Add(this.TxtRCFournMod);
            this.panelContainerFourn.Controls.Add(this.TxtCCFournMod);
            this.panelContainerFourn.Controls.Add(this.label12);
            this.panelContainerFourn.Controls.Add(this.label11);
            this.panelContainerFourn.Controls.Add(this.DtpRegisterFournMod);
            this.panelContainerFourn.Controls.Add(this.TxtAdressFournMod);
            this.panelContainerFourn.Controls.Add(this.TxtMailFournMod);
            this.panelContainerFourn.Controls.Add(this.TxtTelFournMod);
            this.panelContainerFourn.Controls.Add(this.TxtDescripFournMod);
            this.panelContainerFourn.Controls.Add(this.TxtCodFournMod);
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
            this.panelContainerFourn.Size = new System.Drawing.Size(933, 491);
            this.panelContainerFourn.TabIndex = 3;
            // 
            // panelCreateFormFournTitle
            // 
            this.panelCreateFormFournTitle.BackColor = System.Drawing.Color.DarkOrange;
            this.panelCreateFormFournTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCreateFormFournTitle.Controls.Add(this.BtnImportMod);
            this.panelCreateFormFournTitle.Controls.Add(this.BtnSavedFournMod);
            this.panelCreateFormFournTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCreateFormFournTitle.Location = new System.Drawing.Point(0, 0);
            this.panelCreateFormFournTitle.Name = "panelCreateFormFournTitle";
            this.panelCreateFormFournTitle.Size = new System.Drawing.Size(933, 28);
            this.panelCreateFormFournTitle.TabIndex = 2;
            // 
            // FormModifierFourn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.panelContainerFourn);
            this.Controls.Add(this.panelCreateFormFournTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormModifierFourn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifier les informations d\'un fournisseur";
            this.panelContainerFourn.ResumeLayout(false);
            this.panelContainerFourn.PerformLayout();
            this.panelCreateFormFournTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnImportMod;
        private FontAwesome.Sharp.IconButton BtnSavedFournMod;
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
        private System.Windows.Forms.Panel panelContainerFourn;
        private System.Windows.Forms.Panel panelCreateFormFournTitle;
        public System.Windows.Forms.ComboBox CbxCountryMod;
        public System.Windows.Forms.ComboBox CbxTownMod;
        public System.Windows.Forms.TextBox TxtCodPostalFournMod;
        public System.Windows.Forms.TextBox TxtOtherFieldFournMod;
        public System.Windows.Forms.RichTextBox RtxtNoteFournMod;
        public System.Windows.Forms.TextBox TxtRCFournMod;
        public System.Windows.Forms.TextBox TxtCCFournMod;
        public System.Windows.Forms.DateTimePicker DtpRegisterFournMod;
        public System.Windows.Forms.TextBox TxtAdressFournMod;
        public System.Windows.Forms.TextBox TxtMailFournMod;
        public System.Windows.Forms.TextBox TxtTelFournMod;
        public System.Windows.Forms.TextBox TxtDescripFournMod;
        public System.Windows.Forms.TextBox TxtCodFournMod;
    }
}