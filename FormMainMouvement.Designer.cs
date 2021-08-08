
namespace GestPark
{
    partial class FormMainMouvement
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
            this.panelTitleFormMouvt = new System.Windows.Forms.Panel();
            this.IbtnCloseFormMvt = new FontAwesome.Sharp.IconButton();
            this.IbtnRegisterMvt = new FontAwesome.Sharp.IconButton();
            this.PanelSearchMvt = new System.Windows.Forms.Panel();
            this.IbtnExportMvt = new FontAwesome.Sharp.IconButton();
            this.IbtnSearchMvt = new FontAwesome.Sharp.IconButton();
            this.TbxSearchMvt = new System.Windows.Forms.TextBox();
            this.DataGridViewMvt = new System.Windows.Forms.DataGridView();
            this.ID_MVTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUT_MVTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE_MVTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMMATRICULATION_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_MVTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LIEU_MVTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_PERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KILOMETRE_AVA_MVTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KILO_APRES_MVTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATEDEPART_MVTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATEARRIVE_MVTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTE_MVTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERCREATE_MVTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATECREATE_MVTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTitleFormMouvt.SuspendLayout();
            this.PanelSearchMvt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMvt)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleFormMouvt
            // 
            this.panelTitleFormMouvt.BackColor = System.Drawing.Color.DarkOrange;
            this.panelTitleFormMouvt.Controls.Add(this.IbtnCloseFormMvt);
            this.panelTitleFormMouvt.Controls.Add(this.IbtnRegisterMvt);
            this.panelTitleFormMouvt.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleFormMouvt.Location = new System.Drawing.Point(0, 0);
            this.panelTitleFormMouvt.Name = "panelTitleFormMouvt";
            this.panelTitleFormMouvt.Size = new System.Drawing.Size(1118, 32);
            this.panelTitleFormMouvt.TabIndex = 0;
            // 
            // IbtnCloseFormMvt
            // 
            this.IbtnCloseFormMvt.BackColor = System.Drawing.Color.White;
            this.IbtnCloseFormMvt.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.IbtnCloseFormMvt.IconColor = System.Drawing.Color.Red;
            this.IbtnCloseFormMvt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnCloseFormMvt.IconSize = 30;
            this.IbtnCloseFormMvt.Location = new System.Drawing.Point(1082, 0);
            this.IbtnCloseFormMvt.Name = "IbtnCloseFormMvt";
            this.IbtnCloseFormMvt.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.IbtnCloseFormMvt.Size = new System.Drawing.Size(37, 32);
            this.IbtnCloseFormMvt.TabIndex = 1;
            this.IbtnCloseFormMvt.UseVisualStyleBackColor = false;
            this.IbtnCloseFormMvt.Click += new System.EventHandler(this.IbtnCloseFormMvt_Click);
            // 
            // IbtnRegisterMvt
            // 
            this.IbtnRegisterMvt.BackColor = System.Drawing.Color.White;
            this.IbtnRegisterMvt.ForeColor = System.Drawing.Color.DarkGreen;
            this.IbtnRegisterMvt.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.IbtnRegisterMvt.IconColor = System.Drawing.Color.DarkGreen;
            this.IbtnRegisterMvt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnRegisterMvt.IconSize = 30;
            this.IbtnRegisterMvt.Location = new System.Drawing.Point(0, 0);
            this.IbtnRegisterMvt.Name = "IbtnRegisterMvt";
            this.IbtnRegisterMvt.Size = new System.Drawing.Size(158, 32);
            this.IbtnRegisterMvt.TabIndex = 0;
            this.IbtnRegisterMvt.Text = "Créer un mouvement";
            this.IbtnRegisterMvt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IbtnRegisterMvt.UseVisualStyleBackColor = false;
            this.IbtnRegisterMvt.Click += new System.EventHandler(this.IbtnRegisterMvt_Click);
            // 
            // PanelSearchMvt
            // 
            this.PanelSearchMvt.AutoScroll = true;
            this.PanelSearchMvt.BackColor = System.Drawing.Color.DarkOrange;
            this.PanelSearchMvt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelSearchMvt.Controls.Add(this.IbtnExportMvt);
            this.PanelSearchMvt.Controls.Add(this.IbtnSearchMvt);
            this.PanelSearchMvt.Controls.Add(this.TbxSearchMvt);
            this.PanelSearchMvt.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSearchMvt.Location = new System.Drawing.Point(0, 32);
            this.PanelSearchMvt.Name = "PanelSearchMvt";
            this.PanelSearchMvt.Size = new System.Drawing.Size(1118, 109);
            this.PanelSearchMvt.TabIndex = 1;
            // 
            // IbtnExportMvt
            // 
            this.IbtnExportMvt.BackColor = System.Drawing.Color.White;
            this.IbtnExportMvt.ForeColor = System.Drawing.Color.DarkGreen;
            this.IbtnExportMvt.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.IbtnExportMvt.IconColor = System.Drawing.Color.DarkGreen;
            this.IbtnExportMvt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnExportMvt.IconSize = 20;
            this.IbtnExportMvt.Location = new System.Drawing.Point(970, 83);
            this.IbtnExportMvt.Name = "IbtnExportMvt";
            this.IbtnExportMvt.Size = new System.Drawing.Size(101, 23);
            this.IbtnExportMvt.TabIndex = 2;
            this.IbtnExportMvt.Text = "Exporter";
            this.IbtnExportMvt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IbtnExportMvt.UseVisualStyleBackColor = false;
            // 
            // IbtnSearchMvt
            // 
            this.IbtnSearchMvt.BackColor = System.Drawing.Color.White;
            this.IbtnSearchMvt.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.IbtnSearchMvt.IconColor = System.Drawing.Color.DarkGreen;
            this.IbtnSearchMvt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnSearchMvt.IconSize = 25;
            this.IbtnSearchMvt.Location = new System.Drawing.Point(858, 37);
            this.IbtnSearchMvt.Name = "IbtnSearchMvt";
            this.IbtnSearchMvt.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.IbtnSearchMvt.Size = new System.Drawing.Size(41, 23);
            this.IbtnSearchMvt.TabIndex = 1;
            this.IbtnSearchMvt.UseVisualStyleBackColor = false;
            this.IbtnSearchMvt.Click += new System.EventHandler(this.IbtnSearchMvt_Click);
            // 
            // TbxSearchMvt
            // 
            this.TbxSearchMvt.Location = new System.Drawing.Point(602, 37);
            this.TbxSearchMvt.Name = "TbxSearchMvt";
            this.TbxSearchMvt.Size = new System.Drawing.Size(249, 22);
            this.TbxSearchMvt.TabIndex = 0;
            // 
            // DataGridViewMvt
            // 
            this.DataGridViewMvt.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridViewMvt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewMvt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_MVTS,
            this.STATUT_MVTS,
            this.CODE_MVTS,
            this.IMMATRICULATION_VEHICULE,
            this.DESCRIPTION_MVTS,
            this.LIEU_MVTS,
            this.DESCRIPTION_PERS,
            this.KILOMETRE_AVA_MVTS,
            this.KILO_APRES_MVTS,
            this.DATEDEPART_MVTS,
            this.DATEARRIVE_MVTS,
            this.NOTE_MVTS,
            this.USERCREATE_MVTS,
            this.DATECREATE_MVTS});
            this.DataGridViewMvt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewMvt.Location = new System.Drawing.Point(0, 141);
            this.DataGridViewMvt.Name = "DataGridViewMvt";
            this.DataGridViewMvt.Size = new System.Drawing.Size(1118, 590);
            this.DataGridViewMvt.TabIndex = 2;
            this.DataGridViewMvt.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewMvt_CellDoubleClick);
            // 
            // ID_MVTS
            // 
            this.ID_MVTS.DataPropertyName = "ID_MVTS";
            this.ID_MVTS.HeaderText = "Num";
            this.ID_MVTS.Name = "ID_MVTS";
            this.ID_MVTS.ReadOnly = true;
            this.ID_MVTS.Width = 50;
            // 
            // STATUT_MVTS
            // 
            this.STATUT_MVTS.DataPropertyName = "STATUT_MVTS";
            this.STATUT_MVTS.HeaderText = "Statut";
            this.STATUT_MVTS.Name = "STATUT_MVTS";
            this.STATUT_MVTS.ReadOnly = true;
            // 
            // CODE_MVTS
            // 
            this.CODE_MVTS.DataPropertyName = "CODE_MVTS";
            this.CODE_MVTS.HeaderText = "Code";
            this.CODE_MVTS.Name = "CODE_MVTS";
            this.CODE_MVTS.ReadOnly = true;
            // 
            // IMMATRICULATION_VEHICULE
            // 
            this.IMMATRICULATION_VEHICULE.DataPropertyName = "IMMATRICULATION_VEHICULE";
            this.IMMATRICULATION_VEHICULE.FillWeight = 150F;
            this.IMMATRICULATION_VEHICULE.HeaderText = "Véhicule Immat.";
            this.IMMATRICULATION_VEHICULE.Name = "IMMATRICULATION_VEHICULE";
            this.IMMATRICULATION_VEHICULE.ReadOnly = true;
            this.IMMATRICULATION_VEHICULE.Width = 150;
            // 
            // DESCRIPTION_MVTS
            // 
            this.DESCRIPTION_MVTS.DataPropertyName = "DESCRIPTION_MVTS";
            this.DESCRIPTION_MVTS.FillWeight = 155F;
            this.DESCRIPTION_MVTS.HeaderText = "Description";
            this.DESCRIPTION_MVTS.Name = "DESCRIPTION_MVTS";
            this.DESCRIPTION_MVTS.ReadOnly = true;
            this.DESCRIPTION_MVTS.Width = 170;
            // 
            // LIEU_MVTS
            // 
            this.LIEU_MVTS.DataPropertyName = "LIEU_MVTS";
            this.LIEU_MVTS.FillWeight = 150F;
            this.LIEU_MVTS.HeaderText = "Lieu";
            this.LIEU_MVTS.Name = "LIEU_MVTS";
            this.LIEU_MVTS.ReadOnly = true;
            this.LIEU_MVTS.Width = 150;
            // 
            // DESCRIPTION_PERS
            // 
            this.DESCRIPTION_PERS.DataPropertyName = "DESCRIPTION_PERS";
            this.DESCRIPTION_PERS.HeaderText = "Conducteur";
            this.DESCRIPTION_PERS.Name = "DESCRIPTION_PERS";
            this.DESCRIPTION_PERS.ReadOnly = true;
            this.DESCRIPTION_PERS.Width = 150;
            // 
            // KILOMETRE_AVA_MVTS
            // 
            this.KILOMETRE_AVA_MVTS.DataPropertyName = "KILOMETRE_AVA_MVTS";
            this.KILOMETRE_AVA_MVTS.HeaderText = "Kilo. av.";
            this.KILOMETRE_AVA_MVTS.Name = "KILOMETRE_AVA_MVTS";
            this.KILOMETRE_AVA_MVTS.ReadOnly = true;
            this.KILOMETRE_AVA_MVTS.Width = 150;
            // 
            // KILO_APRES_MVTS
            // 
            this.KILO_APRES_MVTS.DataPropertyName = "KILO_APRES_MVTS";
            this.KILO_APRES_MVTS.HeaderText = "Kilomètre apr.";
            this.KILO_APRES_MVTS.Name = "KILO_APRES_MVTS";
            this.KILO_APRES_MVTS.ReadOnly = true;
            this.KILO_APRES_MVTS.Width = 150;
            // 
            // DATEDEPART_MVTS
            // 
            this.DATEDEPART_MVTS.DataPropertyName = "DATEDEPART_MVTS";
            this.DATEDEPART_MVTS.HeaderText = "Aller le";
            this.DATEDEPART_MVTS.Name = "DATEDEPART_MVTS";
            this.DATEDEPART_MVTS.ReadOnly = true;
            // 
            // DATEARRIVE_MVTS
            // 
            this.DATEARRIVE_MVTS.DataPropertyName = "DATEARRIVE_MVTS";
            this.DATEARRIVE_MVTS.HeaderText = "Arrivée le";
            this.DATEARRIVE_MVTS.Name = "DATEARRIVE_MVTS";
            this.DATEARRIVE_MVTS.ReadOnly = true;
            // 
            // NOTE_MVTS
            // 
            this.NOTE_MVTS.DataPropertyName = "NOTE_MVTS";
            this.NOTE_MVTS.HeaderText = "Note";
            this.NOTE_MVTS.Name = "NOTE_MVTS";
            this.NOTE_MVTS.ReadOnly = true;
            this.NOTE_MVTS.Width = 150;
            // 
            // USERCREATE_MVTS
            // 
            this.USERCREATE_MVTS.DataPropertyName = "USERCREATE_MVTS";
            this.USERCREATE_MVTS.HeaderText = "Créer par";
            this.USERCREATE_MVTS.Name = "USERCREATE_MVTS";
            this.USERCREATE_MVTS.ReadOnly = true;
            // 
            // DATECREATE_MVTS
            // 
            this.DATECREATE_MVTS.DataPropertyName = "DATECREATE_MVTS";
            this.DATECREATE_MVTS.HeaderText = "Créer le";
            this.DATECREATE_MVTS.Name = "DATECREATE_MVTS";
            this.DATECREATE_MVTS.ReadOnly = true;
            // 
            // FormMainMouvement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1118, 731);
            this.Controls.Add(this.DataGridViewMvt);
            this.Controls.Add(this.PanelSearchMvt);
            this.Controls.Add(this.panelTitleFormMouvt);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMainMouvement";
            this.Text = "FormMainMouvement";
            this.panelTitleFormMouvt.ResumeLayout(false);
            this.PanelSearchMvt.ResumeLayout(false);
            this.PanelSearchMvt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMvt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleFormMouvt;
        private FontAwesome.Sharp.IconButton IbtnCloseFormMvt;
        private FontAwesome.Sharp.IconButton IbtnRegisterMvt;
        private System.Windows.Forms.Panel PanelSearchMvt;
        private FontAwesome.Sharp.IconButton IbtnExportMvt;
        private FontAwesome.Sharp.IconButton IbtnSearchMvt;
        private System.Windows.Forms.TextBox TbxSearchMvt;
        private System.Windows.Forms.DataGridView DataGridViewMvt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_MVTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUT_MVTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_MVTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMMATRICULATION_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_MVTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn LIEU_MVTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_PERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn KILOMETRE_AVA_MVTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn KILO_APRES_MVTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATEDEPART_MVTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATEARRIVE_MVTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTE_MVTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERCREATE_MVTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATECREATE_MVTS;
    }
}