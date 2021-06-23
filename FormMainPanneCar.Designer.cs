
namespace GestPark
{
    partial class FormMainPanneCar
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
            this.IcBtnExportPanCarb = new FontAwesome.Sharp.IconButton();
            this.IbtnSearchPanCar = new FontAwesome.Sharp.IconButton();
            this.TbxSearchPanCar = new System.Windows.Forms.TextBox();
            this.PanelTitleMenuConsoCarb = new System.Windows.Forms.Panel();
            this.IbtnCloseFormPanCar = new FontAwesome.Sharp.IconButton();
            this.IbtnCreatePanCar = new FontAwesome.Sharp.IconButton();
            this.dataGridViewAttributeCar = new System.Windows.Forms.DataGridView();
            this.ID_APP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE_ATTRI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMMATRICULATION_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_PERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTE_ATTRI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_ATTRI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_DEBUT_ATTRI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_FIN_ATTRI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewCarPan = new System.Windows.Forms.DataGridView();
            this.ID_PAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE_PAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImmatCar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ETAT_PAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_PAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTE_PAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INFOS_PAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_PAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATECREATE_PAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERCREATE_PAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelSearchConsoCarbu.SuspendLayout();
            this.PanelTitleMenuConsoCarb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttributeCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCarPan)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelSearchConsoCarbu
            // 
            this.PanelSearchConsoCarbu.BackColor = System.Drawing.Color.DarkOrange;
            this.PanelSearchConsoCarbu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelSearchConsoCarbu.Controls.Add(this.IcBtnExportPanCarb);
            this.PanelSearchConsoCarbu.Controls.Add(this.IbtnSearchPanCar);
            this.PanelSearchConsoCarbu.Controls.Add(this.TbxSearchPanCar);
            this.PanelSearchConsoCarbu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSearchConsoCarbu.Location = new System.Drawing.Point(0, 27);
            this.PanelSearchConsoCarbu.Name = "PanelSearchConsoCarbu";
            this.PanelSearchConsoCarbu.Size = new System.Drawing.Size(1118, 100);
            this.PanelSearchConsoCarbu.TabIndex = 38;
            // 
            // IcBtnExportPanCarb
            // 
            this.IcBtnExportPanCarb.BackColor = System.Drawing.Color.White;
            this.IcBtnExportPanCarb.ForeColor = System.Drawing.Color.DarkGreen;
            this.IcBtnExportPanCarb.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.IcBtnExportPanCarb.IconColor = System.Drawing.Color.DarkGreen;
            this.IcBtnExportPanCarb.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcBtnExportPanCarb.IconSize = 20;
            this.IcBtnExportPanCarb.Location = new System.Drawing.Point(1021, 71);
            this.IcBtnExportPanCarb.Name = "IcBtnExportPanCarb";
            this.IcBtnExportPanCarb.Size = new System.Drawing.Size(90, 27);
            this.IcBtnExportPanCarb.TabIndex = 2;
            this.IcBtnExportPanCarb.Text = "Exporter";
            this.IcBtnExportPanCarb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IcBtnExportPanCarb.UseVisualStyleBackColor = false;
            // 
            // IbtnSearchPanCar
            // 
            this.IbtnSearchPanCar.BackColor = System.Drawing.Color.White;
            this.IbtnSearchPanCar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.IbtnSearchPanCar.IconColor = System.Drawing.Color.DarkGreen;
            this.IbtnSearchPanCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnSearchPanCar.IconSize = 25;
            this.IbtnSearchPanCar.Location = new System.Drawing.Point(853, 42);
            this.IbtnSearchPanCar.Name = "IbtnSearchPanCar";
            this.IbtnSearchPanCar.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.IbtnSearchPanCar.Size = new System.Drawing.Size(52, 23);
            this.IbtnSearchPanCar.TabIndex = 3;
            this.IbtnSearchPanCar.UseVisualStyleBackColor = false;
            this.IbtnSearchPanCar.Click += new System.EventHandler(this.IbtnSearchPanCar_Click);
            // 
            // TbxSearchPanCar
            // 
            this.TbxSearchPanCar.Location = new System.Drawing.Point(575, 42);
            this.TbxSearchPanCar.Name = "TbxSearchPanCar";
            this.TbxSearchPanCar.Size = new System.Drawing.Size(272, 22);
            this.TbxSearchPanCar.TabIndex = 0;
            // 
            // PanelTitleMenuConsoCarb
            // 
            this.PanelTitleMenuConsoCarb.BackColor = System.Drawing.Color.DarkOrange;
            this.PanelTitleMenuConsoCarb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelTitleMenuConsoCarb.Controls.Add(this.IbtnCloseFormPanCar);
            this.PanelTitleMenuConsoCarb.Controls.Add(this.IbtnCreatePanCar);
            this.PanelTitleMenuConsoCarb.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitleMenuConsoCarb.Location = new System.Drawing.Point(0, 0);
            this.PanelTitleMenuConsoCarb.Name = "PanelTitleMenuConsoCarb";
            this.PanelTitleMenuConsoCarb.Size = new System.Drawing.Size(1118, 27);
            this.PanelTitleMenuConsoCarb.TabIndex = 37;
            // 
            // IbtnCloseFormPanCar
            // 
            this.IbtnCloseFormPanCar.BackColor = System.Drawing.Color.White;
            this.IbtnCloseFormPanCar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.IbtnCloseFormPanCar.IconColor = System.Drawing.Color.Red;
            this.IbtnCloseFormPanCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnCloseFormPanCar.IconSize = 30;
            this.IbtnCloseFormPanCar.Location = new System.Drawing.Point(1085, -2);
            this.IbtnCloseFormPanCar.Name = "IbtnCloseFormPanCar";
            this.IbtnCloseFormPanCar.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.IbtnCloseFormPanCar.Size = new System.Drawing.Size(31, 29);
            this.IbtnCloseFormPanCar.TabIndex = 1;
            this.IbtnCloseFormPanCar.UseVisualStyleBackColor = false;
            this.IbtnCloseFormPanCar.Click += new System.EventHandler(this.IbtnCloseFormPanCar_Click);
            // 
            // IbtnCreatePanCar
            // 
            this.IbtnCreatePanCar.BackColor = System.Drawing.Color.White;
            this.IbtnCreatePanCar.ForeColor = System.Drawing.Color.DarkGreen;
            this.IbtnCreatePanCar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.IbtnCreatePanCar.IconColor = System.Drawing.Color.DarkGreen;
            this.IbtnCreatePanCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnCreatePanCar.IconSize = 25;
            this.IbtnCreatePanCar.Location = new System.Drawing.Point(-2, -2);
            this.IbtnCreatePanCar.Name = "IbtnCreatePanCar";
            this.IbtnCreatePanCar.Size = new System.Drawing.Size(77, 27);
            this.IbtnCreatePanCar.TabIndex = 0;
            this.IbtnCreatePanCar.Text = "Créer";
            this.IbtnCreatePanCar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IbtnCreatePanCar.UseVisualStyleBackColor = false;
            this.IbtnCreatePanCar.Click += new System.EventHandler(this.IbtnCreatePanCar_Click);
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
            this.dataGridViewAttributeCar.TabIndex = 39;
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
            // DataGridViewCarPan
            // 
            this.DataGridViewCarPan.AllowUserToOrderColumns = true;
            this.DataGridViewCarPan.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridViewCarPan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewCarPan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PAN,
            this.CODE_PAN,
            this.ImmatCar,
            this.ETAT_PAN,
            this.DESCRIPTION_PAN,
            this.NOTE_PAN,
            this.INFOS_PAN,
            this.DATE_PAN,
            this.DATECREATE_PAN,
            this.USERCREATE_PAN});
            this.DataGridViewCarPan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewCarPan.Location = new System.Drawing.Point(0, 127);
            this.DataGridViewCarPan.Name = "DataGridViewCarPan";
            this.DataGridViewCarPan.Size = new System.Drawing.Size(1118, 604);
            this.DataGridViewCarPan.TabIndex = 40;
            this.DataGridViewCarPan.DoubleClick += new System.EventHandler(this.DataGridViewCarPan_DoubleClick);
            // 
            // ID_PAN
            // 
            this.ID_PAN.DataPropertyName = "ID_PAN";
            this.ID_PAN.HeaderText = "Num";
            this.ID_PAN.Name = "ID_PAN";
            this.ID_PAN.ReadOnly = true;
            this.ID_PAN.Width = 50;
            // 
            // CODE_PAN
            // 
            this.CODE_PAN.DataPropertyName = "CODE_PAN";
            this.CODE_PAN.HeaderText = "Code";
            this.CODE_PAN.Name = "CODE_PAN";
            this.CODE_PAN.ReadOnly = true;
            // 
            // ImmatCar
            // 
            this.ImmatCar.DataPropertyName = "ImmatCar";
            this.ImmatCar.HeaderText = "Vehicule";
            this.ImmatCar.Name = "ImmatCar";
            this.ImmatCar.ReadOnly = true;
            // 
            // ETAT_PAN
            // 
            this.ETAT_PAN.DataPropertyName = "ETAT_PAN";
            this.ETAT_PAN.HeaderText = "Etat";
            this.ETAT_PAN.Name = "ETAT_PAN";
            this.ETAT_PAN.ReadOnly = true;
            // 
            // DESCRIPTION_PAN
            // 
            this.DESCRIPTION_PAN.DataPropertyName = "DESCRIPTION_PAN";
            this.DESCRIPTION_PAN.HeaderText = "Description";
            this.DESCRIPTION_PAN.Name = "DESCRIPTION_PAN";
            this.DESCRIPTION_PAN.ReadOnly = true;
            this.DESCRIPTION_PAN.Width = 200;
            // 
            // NOTE_PAN
            // 
            this.NOTE_PAN.DataPropertyName = "NOTE_PAN";
            this.NOTE_PAN.HeaderText = "Note";
            this.NOTE_PAN.Name = "NOTE_PAN";
            this.NOTE_PAN.ReadOnly = true;
            this.NOTE_PAN.Width = 150;
            // 
            // INFOS_PAN
            // 
            this.INFOS_PAN.DataPropertyName = "INFOS_PAN";
            this.INFOS_PAN.HeaderText = "Infos.";
            this.INFOS_PAN.Name = "INFOS_PAN";
            this.INFOS_PAN.ReadOnly = true;
            // 
            // DATE_PAN
            // 
            this.DATE_PAN.DataPropertyName = "DATE_PAN";
            this.DATE_PAN.HeaderText = "Date";
            this.DATE_PAN.Name = "DATE_PAN";
            this.DATE_PAN.ReadOnly = true;
            // 
            // DATECREATE_PAN
            // 
            this.DATECREATE_PAN.DataPropertyName = "DATECREATE_PAN";
            this.DATECREATE_PAN.HeaderText = "Créer le";
            this.DATECREATE_PAN.Name = "DATECREATE_PAN";
            this.DATECREATE_PAN.ReadOnly = true;
            // 
            // USERCREATE_PAN
            // 
            this.USERCREATE_PAN.DataPropertyName = "USERCREATE_PAN";
            this.USERCREATE_PAN.HeaderText = "Créer par";
            this.USERCREATE_PAN.Name = "USERCREATE_PAN";
            this.USERCREATE_PAN.ReadOnly = true;
            // 
            // FormMainPanneCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1118, 731);
            this.Controls.Add(this.DataGridViewCarPan);
            this.Controls.Add(this.PanelSearchConsoCarbu);
            this.Controls.Add(this.PanelTitleMenuConsoCarb);
            this.Controls.Add(this.dataGridViewAttributeCar);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMainPanneCar";
            this.Text = "FormMainPanneCar";
            this.PanelSearchConsoCarbu.ResumeLayout(false);
            this.PanelSearchConsoCarbu.PerformLayout();
            this.PanelTitleMenuConsoCarb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttributeCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCarPan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSearchConsoCarbu;
        private FontAwesome.Sharp.IconButton IcBtnExportPanCarb;
        private FontAwesome.Sharp.IconButton IbtnSearchPanCar;
        private System.Windows.Forms.TextBox TbxSearchPanCar;
        private System.Windows.Forms.Panel PanelTitleMenuConsoCarb;
        private FontAwesome.Sharp.IconButton IbtnCloseFormPanCar;
        private FontAwesome.Sharp.IconButton IbtnCreatePanCar;
        private System.Windows.Forms.DataGridView dataGridViewAttributeCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_APP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_ATTRI;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMMATRICULATION_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_PERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTE_ATTRI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_ATTRI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_DEBUT_ATTRI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_FIN_ATTRI;
        private System.Windows.Forms.DataGridView DataGridViewCarPan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_PAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImmatCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ETAT_PAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_PAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTE_PAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn INFOS_PAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_PAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATECREATE_PAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERCREATE_PAN;
    }
}