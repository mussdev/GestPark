
namespace GestPark
{
    partial class FormConsommationCarburant
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
            this.PanelSearchConsoCarbu = new System.Windows.Forms.Panel();
            this.IbtnSearchConsoCarbu = new FontAwesome.Sharp.IconButton();
            this.TbxSearchConsoCar = new System.Windows.Forms.TextBox();
            this.IcBtnExportConsoCarb = new FontAwesome.Sharp.IconButton();
            this.PanelTitleMenuConsoCarb = new System.Windows.Forms.Panel();
            this.IbtnCloseFormConsoCar = new FontAwesome.Sharp.IconButton();
            this.IbtnCreateConsoCar = new FontAwesome.Sharp.IconButton();
            this.dataGridViewAttributeCar = new System.Windows.Forms.DataGridView();
            this.ID_APP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE_ATTRI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMMATRICULATION_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_PERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTE_ATTRI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_ATTRI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_DEBUT_ATTRI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_FIN_ATTRI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewConsoCar = new System.Windows.Forms.DataGridView();
            this.ID_PROV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE_PROV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_PROV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMMAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TYPCONSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KILO_AVANT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KILOMETRAGE_EFFECT_HEBDO_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTE_PROV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUT_PROV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_PROV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATECREATE_PROV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERCREATE_PROV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelSearchConsoCarbu.SuspendLayout();
            this.PanelTitleMenuConsoCarb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttributeCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewConsoCar)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelSearchConsoCarbu
            // 
            this.PanelSearchConsoCarbu.BackColor = System.Drawing.Color.Khaki;
            this.PanelSearchConsoCarbu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelSearchConsoCarbu.Controls.Add(this.IbtnSearchConsoCarbu);
            this.PanelSearchConsoCarbu.Controls.Add(this.TbxSearchConsoCar);
            this.PanelSearchConsoCarbu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSearchConsoCarbu.Location = new System.Drawing.Point(0, 27);
            this.PanelSearchConsoCarbu.Name = "PanelSearchConsoCarbu";
            this.PanelSearchConsoCarbu.Size = new System.Drawing.Size(1118, 100);
            this.PanelSearchConsoCarbu.TabIndex = 35;
            // 
            // IbtnSearchConsoCarbu
            // 
            this.IbtnSearchConsoCarbu.BackColor = System.Drawing.Color.White;
            this.IbtnSearchConsoCarbu.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.IbtnSearchConsoCarbu.IconColor = System.Drawing.Color.DarkGreen;
            this.IbtnSearchConsoCarbu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnSearchConsoCarbu.IconSize = 25;
            this.IbtnSearchConsoCarbu.Location = new System.Drawing.Point(853, 42);
            this.IbtnSearchConsoCarbu.Name = "IbtnSearchConsoCarbu";
            this.IbtnSearchConsoCarbu.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.IbtnSearchConsoCarbu.Size = new System.Drawing.Size(52, 23);
            this.IbtnSearchConsoCarbu.TabIndex = 3;
            this.IbtnSearchConsoCarbu.UseVisualStyleBackColor = false;
            this.IbtnSearchConsoCarbu.Click += new System.EventHandler(this.IbtnSearchConsoCarbu_Click);
            // 
            // TbxSearchConsoCar
            // 
            this.TbxSearchConsoCar.Location = new System.Drawing.Point(575, 42);
            this.TbxSearchConsoCar.Name = "TbxSearchConsoCar";
            this.TbxSearchConsoCar.Size = new System.Drawing.Size(272, 22);
            this.TbxSearchConsoCar.TabIndex = 0;
            // 
            // IcBtnExportConsoCarb
            // 
            this.IcBtnExportConsoCarb.BackColor = System.Drawing.Color.White;
            this.IcBtnExportConsoCarb.ForeColor = System.Drawing.Color.DarkGreen;
            this.IcBtnExportConsoCarb.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.IcBtnExportConsoCarb.IconColor = System.Drawing.Color.DarkGreen;
            this.IcBtnExportConsoCarb.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcBtnExportConsoCarb.IconSize = 20;
            this.IcBtnExportConsoCarb.Location = new System.Drawing.Point(100, -2);
            this.IcBtnExportConsoCarb.Name = "IcBtnExportConsoCarb";
            this.IcBtnExportConsoCarb.Size = new System.Drawing.Size(95, 27);
            this.IcBtnExportConsoCarb.TabIndex = 2;
            this.IcBtnExportConsoCarb.Text = "Exporter";
            this.IcBtnExportConsoCarb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IcBtnExportConsoCarb.UseVisualStyleBackColor = false;
            // 
            // PanelTitleMenuConsoCarb
            // 
            this.PanelTitleMenuConsoCarb.BackColor = System.Drawing.Color.Khaki;
            this.PanelTitleMenuConsoCarb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelTitleMenuConsoCarb.Controls.Add(this.IcBtnExportConsoCarb);
            this.PanelTitleMenuConsoCarb.Controls.Add(this.IbtnCloseFormConsoCar);
            this.PanelTitleMenuConsoCarb.Controls.Add(this.IbtnCreateConsoCar);
            this.PanelTitleMenuConsoCarb.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitleMenuConsoCarb.Location = new System.Drawing.Point(0, 0);
            this.PanelTitleMenuConsoCarb.Name = "PanelTitleMenuConsoCarb";
            this.PanelTitleMenuConsoCarb.Size = new System.Drawing.Size(1118, 27);
            this.PanelTitleMenuConsoCarb.TabIndex = 34;
            // 
            // IbtnCloseFormConsoCar
            // 
            this.IbtnCloseFormConsoCar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IbtnCloseFormConsoCar.BackColor = System.Drawing.Color.White;
            this.IbtnCloseFormConsoCar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.IbtnCloseFormConsoCar.IconColor = System.Drawing.Color.Red;
            this.IbtnCloseFormConsoCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnCloseFormConsoCar.IconSize = 30;
            this.IbtnCloseFormConsoCar.Location = new System.Drawing.Point(1085, -2);
            this.IbtnCloseFormConsoCar.Name = "IbtnCloseFormConsoCar";
            this.IbtnCloseFormConsoCar.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.IbtnCloseFormConsoCar.Size = new System.Drawing.Size(31, 29);
            this.IbtnCloseFormConsoCar.TabIndex = 1;
            this.IbtnCloseFormConsoCar.UseVisualStyleBackColor = false;
            this.IbtnCloseFormConsoCar.Click += new System.EventHandler(this.IbtnCloseFormConsoCar_Click);
            // 
            // IbtnCreateConsoCar
            // 
            this.IbtnCreateConsoCar.BackColor = System.Drawing.Color.White;
            this.IbtnCreateConsoCar.ForeColor = System.Drawing.Color.DarkGreen;
            this.IbtnCreateConsoCar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.IbtnCreateConsoCar.IconColor = System.Drawing.Color.DarkGreen;
            this.IbtnCreateConsoCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnCreateConsoCar.IconSize = 25;
            this.IbtnCreateConsoCar.Location = new System.Drawing.Point(-2, -2);
            this.IbtnCreateConsoCar.Name = "IbtnCreateConsoCar";
            this.IbtnCreateConsoCar.Size = new System.Drawing.Size(96, 27);
            this.IbtnCreateConsoCar.TabIndex = 0;
            this.IbtnCreateConsoCar.Text = "Créer";
            this.IbtnCreateConsoCar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IbtnCreateConsoCar.UseVisualStyleBackColor = false;
            this.IbtnCreateConsoCar.Click += new System.EventHandler(this.IbtnCreateConsoCar_Click);
            // 
            // dataGridViewAttributeCar
            // 
            this.dataGridViewAttributeCar.AllowUserToOrderColumns = true;
            this.dataGridViewAttributeCar.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAttributeCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAttributeCar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_APP,
            this.CODE_ATTRI,
            this.IMMATRICULATION_VEHICULE,
            this.DESCRIPTION_PERS,
            this.NOTE_ATTRI,
            this.DATE_ATTRI,
            this.DATE_DEBUT_ATTRI,
            this.DATE_FIN_ATTRI});
            this.dataGridViewAttributeCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAttributeCar.GridColor = System.Drawing.Color.DimGray;
            this.dataGridViewAttributeCar.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAttributeCar.Name = "dataGridViewAttributeCar";
            this.dataGridViewAttributeCar.Size = new System.Drawing.Size(1118, 731);
            this.dataGridViewAttributeCar.TabIndex = 36;
            // 
            // ID_APP
            // 
            this.ID_APP.DataPropertyName = "ID_APP";
            this.ID_APP.HeaderText = "Num";
            this.ID_APP.Name = "ID_APP";
            this.ID_APP.ReadOnly = true;
            this.ID_APP.Width = 50;
            // 
            // CODE_ATTRI
            // 
            this.CODE_ATTRI.DataPropertyName = "CODE_ATTRI";
            this.CODE_ATTRI.HeaderText = "Code";
            this.CODE_ATTRI.Name = "CODE_ATTRI";
            this.CODE_ATTRI.ReadOnly = true;
            // 
            // IMMATRICULATION_VEHICULE
            // 
            this.IMMATRICULATION_VEHICULE.DataPropertyName = "IMMATRICULATION_VEHICULE";
            this.IMMATRICULATION_VEHICULE.HeaderText = "Immatri. vehi.";
            this.IMMATRICULATION_VEHICULE.Name = "IMMATRICULATION_VEHICULE";
            this.IMMATRICULATION_VEHICULE.ReadOnly = true;
            this.IMMATRICULATION_VEHICULE.Width = 150;
            // 
            // DESCRIPTION_PERS
            // 
            this.DESCRIPTION_PERS.DataPropertyName = "DESCRIPTION_PERS";
            this.DESCRIPTION_PERS.HeaderText = "Propriétaire";
            this.DESCRIPTION_PERS.Name = "DESCRIPTION_PERS";
            this.DESCRIPTION_PERS.ReadOnly = true;
            this.DESCRIPTION_PERS.Width = 200;
            // 
            // NOTE_ATTRI
            // 
            this.NOTE_ATTRI.DataPropertyName = "NOTE_ATTRI";
            this.NOTE_ATTRI.HeaderText = "Note";
            this.NOTE_ATTRI.Name = "NOTE_ATTRI";
            this.NOTE_ATTRI.ReadOnly = true;
            this.NOTE_ATTRI.Width = 200;
            // 
            // DATE_ATTRI
            // 
            this.DATE_ATTRI.DataPropertyName = "DATE_ATTRI";
            this.DATE_ATTRI.HeaderText = "Date";
            this.DATE_ATTRI.Name = "DATE_ATTRI";
            this.DATE_ATTRI.ReadOnly = true;
            // 
            // DATE_DEBUT_ATTRI
            // 
            this.DATE_DEBUT_ATTRI.DataPropertyName = "DATE_DEBUT_ATTRI";
            this.DATE_DEBUT_ATTRI.HeaderText = "Date attri. véhi.";
            this.DATE_DEBUT_ATTRI.Name = "DATE_DEBUT_ATTRI";
            this.DATE_DEBUT_ATTRI.ReadOnly = true;
            this.DATE_DEBUT_ATTRI.Width = 150;
            // 
            // DATE_FIN_ATTRI
            // 
            this.DATE_FIN_ATTRI.DataPropertyName = "DATE_FIN_ATTRI";
            this.DATE_FIN_ATTRI.HeaderText = "Date fin attri.";
            this.DATE_FIN_ATTRI.Name = "DATE_FIN_ATTRI";
            this.DATE_FIN_ATTRI.ReadOnly = true;
            this.DATE_FIN_ATTRI.Width = 150;
            // 
            // DataGridViewConsoCar
            // 
            this.DataGridViewConsoCar.AllowUserToOrderColumns = true;
            this.DataGridViewConsoCar.BackgroundColor = System.Drawing.Color.Khaki;
            this.DataGridViewConsoCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewConsoCar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PROV,
            this.CODE_PROV,
            this.DESCRIPTION_PROV,
            this.IMMAT,
            this.TYPCONSO,
            this.KILO_AVANT,
            this.KILOMETRAGE_EFFECT_HEBDO_VEHICULE,
            this.NOTE_PROV,
            this.STATUT_PROV,
            this.DATE_PROV,
            this.DATECREATE_PROV,
            this.USERCREATE_PROV});
            this.DataGridViewConsoCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewConsoCar.Location = new System.Drawing.Point(0, 127);
            this.DataGridViewConsoCar.Name = "DataGridViewConsoCar";
            this.DataGridViewConsoCar.Size = new System.Drawing.Size(1118, 604);
            this.DataGridViewConsoCar.TabIndex = 37;
            this.DataGridViewConsoCar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewConsoCar_CellDoubleClick);
            // 
            // ID_PROV
            // 
            this.ID_PROV.DataPropertyName = "ID_PROV";
            this.ID_PROV.HeaderText = "Num";
            this.ID_PROV.Name = "ID_PROV";
            this.ID_PROV.ReadOnly = true;
            this.ID_PROV.Width = 50;
            // 
            // CODE_PROV
            // 
            this.CODE_PROV.DataPropertyName = "CODE_PROV";
            this.CODE_PROV.HeaderText = "Code";
            this.CODE_PROV.Name = "CODE_PROV";
            this.CODE_PROV.ReadOnly = true;
            // 
            // DESCRIPTION_PROV
            // 
            this.DESCRIPTION_PROV.DataPropertyName = "DESCRIPTION_PROV";
            this.DESCRIPTION_PROV.HeaderText = "Descption";
            this.DESCRIPTION_PROV.Name = "DESCRIPTION_PROV";
            this.DESCRIPTION_PROV.ReadOnly = true;
            // 
            // IMMAT
            // 
            this.IMMAT.DataPropertyName = "IMMAT";
            this.IMMAT.HeaderText = "Vehicule";
            this.IMMAT.Name = "IMMAT";
            this.IMMAT.ReadOnly = true;
            // 
            // TYPCONSO
            // 
            this.TYPCONSO.DataPropertyName = "TYPCONSO";
            this.TYPCONSO.HeaderText = "Typ. Conso.";
            this.TYPCONSO.Name = "TYPCONSO";
            this.TYPCONSO.ReadOnly = true;
            // 
            // KILO_AVANT
            // 
            this.KILO_AVANT.DataPropertyName = "KILO_AVANT";
            this.KILO_AVANT.HeaderText = "Kilo. ava.";
            this.KILO_AVANT.Name = "KILO_AVANT";
            this.KILO_AVANT.ReadOnly = true;
            // 
            // KILOMETRAGE_EFFECT_HEBDO_VEHICULE
            // 
            this.KILOMETRAGE_EFFECT_HEBDO_VEHICULE.DataPropertyName = "KILOMETRAGE_EFFECT_HEBDO_VEHICULE";
            this.KILOMETRAGE_EFFECT_HEBDO_VEHICULE.HeaderText = "Kilo. effect.";
            this.KILOMETRAGE_EFFECT_HEBDO_VEHICULE.Name = "KILOMETRAGE_EFFECT_HEBDO_VEHICULE";
            this.KILOMETRAGE_EFFECT_HEBDO_VEHICULE.ReadOnly = true;
            // 
            // NOTE_PROV
            // 
            this.NOTE_PROV.DataPropertyName = "NOTE_PROV";
            this.NOTE_PROV.HeaderText = "Note";
            this.NOTE_PROV.Name = "NOTE_PROV";
            this.NOTE_PROV.ReadOnly = true;
            this.NOTE_PROV.Width = 150;
            // 
            // STATUT_PROV
            // 
            this.STATUT_PROV.DataPropertyName = "STATUT_PROV";
            this.STATUT_PROV.HeaderText = "Statut";
            this.STATUT_PROV.Name = "STATUT_PROV";
            this.STATUT_PROV.ReadOnly = true;
            // 
            // DATE_PROV
            // 
            this.DATE_PROV.DataPropertyName = "DATE_PROV";
            this.DATE_PROV.HeaderText = "Date";
            this.DATE_PROV.Name = "DATE_PROV";
            this.DATE_PROV.ReadOnly = true;
            // 
            // DATECREATE_PROV
            // 
            this.DATECREATE_PROV.DataPropertyName = "DATECREATE_PROV";
            this.DATECREATE_PROV.HeaderText = "Créé le";
            this.DATECREATE_PROV.Name = "DATECREATE_PROV";
            this.DATECREATE_PROV.ReadOnly = true;
            // 
            // USERCREATE_PROV
            // 
            this.USERCREATE_PROV.DataPropertyName = "USERCREATE_PROV";
            this.USERCREATE_PROV.HeaderText = "Créer par";
            this.USERCREATE_PROV.Name = "USERCREATE_PROV";
            this.USERCREATE_PROV.ReadOnly = true;
            // 
            // FormConsommationCarburant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 731);
            this.Controls.Add(this.DataGridViewConsoCar);
            this.Controls.Add(this.PanelSearchConsoCarbu);
            this.Controls.Add(this.PanelTitleMenuConsoCarb);
            this.Controls.Add(this.dataGridViewAttributeCar);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConsommationCarburant";
            this.Text = "FormConsommationCarburant";
            this.PanelSearchConsoCarbu.ResumeLayout(false);
            this.PanelSearchConsoCarbu.PerformLayout();
            this.PanelTitleMenuConsoCarb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttributeCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewConsoCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSearchConsoCarbu;
        private FontAwesome.Sharp.IconButton IcBtnExportConsoCarb;
        private FontAwesome.Sharp.IconButton IbtnSearchConsoCarbu;
        private System.Windows.Forms.TextBox TbxSearchConsoCar;
        private System.Windows.Forms.Panel PanelTitleMenuConsoCarb;
        private FontAwesome.Sharp.IconButton IbtnCloseFormConsoCar;
        private FontAwesome.Sharp.IconButton IbtnCreateConsoCar;
        private System.Windows.Forms.DataGridView dataGridViewAttributeCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_APP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_ATTRI;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMMATRICULATION_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_PERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTE_ATTRI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_ATTRI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_DEBUT_ATTRI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_FIN_ATTRI;
        private System.Windows.Forms.DataGridView DataGridViewConsoCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PROV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_PROV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_PROV;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMMAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TYPCONSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn KILO_AVANT;
        private System.Windows.Forms.DataGridViewTextBoxColumn KILOMETRAGE_EFFECT_HEBDO_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTE_PROV;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUT_PROV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_PROV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATECREATE_PROV;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERCREATE_PROV;
    }
}