
namespace GestPark
{
    partial class FormMainRechargeCarte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainRechargeCarte));
            this.panelTitleFormMouvt = new System.Windows.Forms.Panel();
            this.BtnImport = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAddRecharge = new FontAwesome.Sharp.IconButton();
            this.IbtnExportRecharge = new FontAwesome.Sharp.IconButton();
            this.IbtnCloseFormRecharge = new FontAwesome.Sharp.IconButton();
            this.PanelSearchMvt = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IbtnSearchRecharge = new FontAwesome.Sharp.IconButton();
            this.TbxSearchRecharge = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTotalAmountRecha = new System.Windows.Forms.Label();
            this.LbNbrRech = new System.Windows.Forms.Label();
            this.DgvRecharge = new System.Windows.Forms.DataGridView();
            this.CODE_RECHCARD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONTANT_RECHCARD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TPYE_CARD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM_CARD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_RECHCARD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERCREATE_RECHCARD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATECREATE_PAIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATEMODIFY_RECHCARD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTitleFormMouvt.SuspendLayout();
            this.PanelSearchMvt.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRecharge)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleFormMouvt
            // 
            this.panelTitleFormMouvt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.panelTitleFormMouvt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTitleFormMouvt.Controls.Add(this.BtnImport);
            this.panelTitleFormMouvt.Controls.Add(this.label1);
            this.panelTitleFormMouvt.Controls.Add(this.BtnAddRecharge);
            this.panelTitleFormMouvt.Controls.Add(this.IbtnExportRecharge);
            this.panelTitleFormMouvt.Controls.Add(this.IbtnCloseFormRecharge);
            this.panelTitleFormMouvt.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleFormMouvt.Location = new System.Drawing.Point(0, 0);
            this.panelTitleFormMouvt.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitleFormMouvt.Name = "panelTitleFormMouvt";
            this.panelTitleFormMouvt.Size = new System.Drawing.Size(1403, 26);
            this.panelTitleFormMouvt.TabIndex = 2;
            // 
            // BtnImport
            // 
            this.BtnImport.BackColor = System.Drawing.Color.White;
            this.BtnImport.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImport.ForeColor = System.Drawing.Color.Black;
            this.BtnImport.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.BtnImport.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(13)))));
            this.BtnImport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnImport.IconSize = 20;
            this.BtnImport.Location = new System.Drawing.Point(212, -2);
            this.BtnImport.Margin = new System.Windows.Forms.Padding(4);
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.Size = new System.Drawing.Size(107, 26);
            this.BtnImport.TabIndex = 5;
            this.BtnImport.Text = "Importer";
            this.BtnImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnImport.UseVisualStyleBackColor = false;
            this.BtnImport.MouseHover += new System.EventHandler(this.BtnImport_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(658, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Réchargements de carte carburant";
            // 
            // BtnAddRecharge
            // 
            this.BtnAddRecharge.BackColor = System.Drawing.Color.White;
            this.BtnAddRecharge.ForeColor = System.Drawing.Color.Black;
            this.BtnAddRecharge.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnAddRecharge.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.BtnAddRecharge.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAddRecharge.IconSize = 20;
            this.BtnAddRecharge.Location = new System.Drawing.Point(-2, -2);
            this.BtnAddRecharge.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAddRecharge.Name = "BtnAddRecharge";
            this.BtnAddRecharge.Size = new System.Drawing.Size(107, 26);
            this.BtnAddRecharge.TabIndex = 3;
            this.BtnAddRecharge.Text = "Saisir";
            this.BtnAddRecharge.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddRecharge.UseVisualStyleBackColor = false;
            this.BtnAddRecharge.Click += new System.EventHandler(this.BtnAddRecharge_Click);
            this.BtnAddRecharge.MouseHover += new System.EventHandler(this.BtnAddRecharge_MouseHover);
            // 
            // IbtnExportRecharge
            // 
            this.IbtnExportRecharge.BackColor = System.Drawing.Color.White;
            this.IbtnExportRecharge.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IbtnExportRecharge.ForeColor = System.Drawing.Color.Black;
            this.IbtnExportRecharge.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.IbtnExportRecharge.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(147)))), ((int)(((byte)(222)))));
            this.IbtnExportRecharge.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnExportRecharge.IconSize = 20;
            this.IbtnExportRecharge.Location = new System.Drawing.Point(105, -2);
            this.IbtnExportRecharge.Margin = new System.Windows.Forms.Padding(4);
            this.IbtnExportRecharge.Name = "IbtnExportRecharge";
            this.IbtnExportRecharge.Size = new System.Drawing.Size(107, 26);
            this.IbtnExportRecharge.TabIndex = 2;
            this.IbtnExportRecharge.Text = "Exporter";
            this.IbtnExportRecharge.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IbtnExportRecharge.UseVisualStyleBackColor = false;
            this.IbtnExportRecharge.MouseHover += new System.EventHandler(this.IbtnExportRecharge_MouseHover);
            // 
            // IbtnCloseFormRecharge
            // 
            this.IbtnCloseFormRecharge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IbtnCloseFormRecharge.BackColor = System.Drawing.Color.White;
            this.IbtnCloseFormRecharge.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.IbtnCloseFormRecharge.IconColor = System.Drawing.Color.Red;
            this.IbtnCloseFormRecharge.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnCloseFormRecharge.IconSize = 20;
            this.IbtnCloseFormRecharge.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IbtnCloseFormRecharge.Location = new System.Drawing.Point(1371, -2);
            this.IbtnCloseFormRecharge.Margin = new System.Windows.Forms.Padding(4);
            this.IbtnCloseFormRecharge.Name = "IbtnCloseFormRecharge";
            this.IbtnCloseFormRecharge.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.IbtnCloseFormRecharge.Size = new System.Drawing.Size(29, 24);
            this.IbtnCloseFormRecharge.TabIndex = 1;
            this.IbtnCloseFormRecharge.UseVisualStyleBackColor = false;
            this.IbtnCloseFormRecharge.Click += new System.EventHandler(this.IbtnCloseFormRecharge_Click);
            // 
            // PanelSearchMvt
            // 
            this.PanelSearchMvt.AutoScroll = true;
            this.PanelSearchMvt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.PanelSearchMvt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelSearchMvt.Controls.Add(this.label3);
            this.PanelSearchMvt.Controls.Add(this.label2);
            this.PanelSearchMvt.Controls.Add(this.IbtnSearchRecharge);
            this.PanelSearchMvt.Controls.Add(this.TbxSearchRecharge);
            this.PanelSearchMvt.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSearchMvt.Location = new System.Drawing.Point(0, 26);
            this.PanelSearchMvt.Margin = new System.Windows.Forms.Padding(4);
            this.PanelSearchMvt.Name = "PanelSearchMvt";
            this.PanelSearchMvt.Size = new System.Drawing.Size(1403, 149);
            this.PanelSearchMvt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(976, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rechercher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(616, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rechercher multicritère";
            // 
            // IbtnSearchRecharge
            // 
            this.IbtnSearchRecharge.BackColor = System.Drawing.Color.White;
            this.IbtnSearchRecharge.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.IbtnSearchRecharge.IconColor = System.Drawing.Color.YellowGreen;
            this.IbtnSearchRecharge.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnSearchRecharge.IconSize = 25;
            this.IbtnSearchRecharge.Location = new System.Drawing.Point(1071, 69);
            this.IbtnSearchRecharge.Margin = new System.Windows.Forms.Padding(4);
            this.IbtnSearchRecharge.Name = "IbtnSearchRecharge";
            this.IbtnSearchRecharge.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.IbtnSearchRecharge.Size = new System.Drawing.Size(36, 24);
            this.IbtnSearchRecharge.TabIndex = 1;
            this.IbtnSearchRecharge.UseVisualStyleBackColor = false;
            this.IbtnSearchRecharge.Click += new System.EventHandler(this.IbtnSearchRecharge_Click);
            // 
            // TbxSearchRecharge
            // 
            this.TbxSearchRecharge.BackColor = System.Drawing.Color.White;
            this.TbxSearchRecharge.Location = new System.Drawing.Point(797, 23);
            this.TbxSearchRecharge.Margin = new System.Windows.Forms.Padding(4);
            this.TbxSearchRecharge.Name = "TbxSearchRecharge";
            this.TbxSearchRecharge.Size = new System.Drawing.Size(310, 28);
            this.TbxSearchRecharge.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.panel1.Controls.Add(this.LblTotalAmountRecha);
            this.panel1.Controls.Add(this.LbNbrRech);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 175);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1403, 25);
            this.panel1.TabIndex = 4;
            // 
            // LblTotalAmountRecha
            // 
            this.LblTotalAmountRecha.AutoSize = true;
            this.LblTotalAmountRecha.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalAmountRecha.ForeColor = System.Drawing.Color.Red;
            this.LblTotalAmountRecha.Location = new System.Drawing.Point(286, 6);
            this.LblTotalAmountRecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTotalAmountRecha.Name = "LblTotalAmountRecha";
            this.LblTotalAmountRecha.Size = new System.Drawing.Size(98, 17);
            this.LblTotalAmountRecha.TabIndex = 1;
            this.LblTotalAmountRecha.Text = "Coût total = 0";
            // 
            // LbNbrRech
            // 
            this.LbNbrRech.AutoSize = true;
            this.LbNbrRech.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNbrRech.ForeColor = System.Drawing.Color.Red;
            this.LbNbrRech.Location = new System.Drawing.Point(4, 6);
            this.LbNbrRech.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbNbrRech.Name = "LbNbrRech";
            this.LbNbrRech.Size = new System.Drawing.Size(181, 17);
            this.LbNbrRech.TabIndex = 0;
            this.LbNbrRech.Text = "Total de rechargement = 0";
            // 
            // DgvRecharge
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DgvRecharge.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvRecharge.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvRecharge.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvRecharge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRecharge.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODE_RECHCARD,
            this.MONTANT_RECHCARD,
            this.TPYE_CARD,
            this.NUM_CARD,
            this.DATE_RECHCARD,
            this.USERCREATE_RECHCARD,
            this.DATECREATE_PAIE,
            this.DATEMODIFY_RECHCARD});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvRecharge.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvRecharge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvRecharge.GridColor = System.Drawing.Color.White;
            this.DgvRecharge.Location = new System.Drawing.Point(0, 200);
            this.DgvRecharge.Margin = new System.Windows.Forms.Padding(4);
            this.DgvRecharge.Name = "DgvRecharge";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvRecharge.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvRecharge.RowHeadersWidth = 51;
            this.DgvRecharge.Size = new System.Drawing.Size(1403, 493);
            this.DgvRecharge.TabIndex = 5;
            // 
            // CODE_RECHCARD
            // 
            this.CODE_RECHCARD.DataPropertyName = "CODE_RECHCARD";
            this.CODE_RECHCARD.HeaderText = "Code";
            this.CODE_RECHCARD.MinimumWidth = 6;
            this.CODE_RECHCARD.Name = "CODE_RECHCARD";
            this.CODE_RECHCARD.ReadOnly = true;
            this.CODE_RECHCARD.Width = 150;
            // 
            // MONTANT_RECHCARD
            // 
            this.MONTANT_RECHCARD.DataPropertyName = "MONTANT_RECHCARD";
            this.MONTANT_RECHCARD.HeaderText = "Montant";
            this.MONTANT_RECHCARD.MinimumWidth = 6;
            this.MONTANT_RECHCARD.Name = "MONTANT_RECHCARD";
            this.MONTANT_RECHCARD.ReadOnly = true;
            this.MONTANT_RECHCARD.Width = 150;
            // 
            // TPYE_CARD
            // 
            this.TPYE_CARD.DataPropertyName = "TPYE_CARD";
            this.TPYE_CARD.HeaderText = "Carte";
            this.TPYE_CARD.MinimumWidth = 6;
            this.TPYE_CARD.Name = "TPYE_CARD";
            this.TPYE_CARD.ReadOnly = true;
            this.TPYE_CARD.Width = 200;
            // 
            // NUM_CARD
            // 
            this.NUM_CARD.DataPropertyName = "NUM_CARD";
            this.NUM_CARD.HeaderText = "N° carte";
            this.NUM_CARD.MinimumWidth = 6;
            this.NUM_CARD.Name = "NUM_CARD";
            this.NUM_CARD.ReadOnly = true;
            this.NUM_CARD.Width = 300;
            // 
            // DATE_RECHCARD
            // 
            this.DATE_RECHCARD.DataPropertyName = "DATE_RECHCARD";
            this.DATE_RECHCARD.HeaderText = "Date";
            this.DATE_RECHCARD.MinimumWidth = 6;
            this.DATE_RECHCARD.Name = "DATE_RECHCARD";
            this.DATE_RECHCARD.ReadOnly = true;
            this.DATE_RECHCARD.Width = 150;
            // 
            // USERCREATE_RECHCARD
            // 
            this.USERCREATE_RECHCARD.DataPropertyName = "USERCREATE_RECHCARD";
            this.USERCREATE_RECHCARD.HeaderText = "Créer par";
            this.USERCREATE_RECHCARD.MinimumWidth = 6;
            this.USERCREATE_RECHCARD.Name = "USERCREATE_RECHCARD";
            this.USERCREATE_RECHCARD.ReadOnly = true;
            this.USERCREATE_RECHCARD.Width = 125;
            // 
            // DATECREATE_PAIE
            // 
            this.DATECREATE_PAIE.DataPropertyName = "DATECREATE_PAIE";
            this.DATECREATE_PAIE.HeaderText = "Créer le";
            this.DATECREATE_PAIE.MinimumWidth = 6;
            this.DATECREATE_PAIE.Name = "DATECREATE_PAIE";
            this.DATECREATE_PAIE.ReadOnly = true;
            this.DATECREATE_PAIE.Width = 125;
            // 
            // DATEMODIFY_RECHCARD
            // 
            this.DATEMODIFY_RECHCARD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DATEMODIFY_RECHCARD.DataPropertyName = "DATEMODIFY_RECHCARD";
            this.DATEMODIFY_RECHCARD.HeaderText = "Modifier le";
            this.DATEMODIFY_RECHCARD.MinimumWidth = 150;
            this.DATEMODIFY_RECHCARD.Name = "DATEMODIFY_RECHCARD";
            this.DATEMODIFY_RECHCARD.ReadOnly = true;
            // 
            // FormMainRechargeCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1403, 693);
            this.Controls.Add(this.DgvRecharge);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelSearchMvt);
            this.Controls.Add(this.panelTitleFormMouvt);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMainRechargeCarte";
            this.Text = "Rechargement de carte";
            this.panelTitleFormMouvt.ResumeLayout(false);
            this.panelTitleFormMouvt.PerformLayout();
            this.PanelSearchMvt.ResumeLayout(false);
            this.PanelSearchMvt.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRecharge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleFormMouvt;
        private FontAwesome.Sharp.IconButton IbtnExportRecharge;
        private FontAwesome.Sharp.IconButton IbtnCloseFormRecharge;
        private System.Windows.Forms.Panel PanelSearchMvt;
        private FontAwesome.Sharp.IconButton IbtnSearchRecharge;
        private System.Windows.Forms.TextBox TbxSearchRecharge;
        private FontAwesome.Sharp.IconButton BtnAddRecharge;
        private FontAwesome.Sharp.IconButton BtnImport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DgvRecharge;
        private System.Windows.Forms.Label LblTotalAmountRecha;
        private System.Windows.Forms.Label LbNbrRech;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_RECHCARD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTANT_RECHCARD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TPYE_CARD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_CARD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_RECHCARD;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERCREATE_RECHCARD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATECREATE_PAIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATEMODIFY_RECHCARD;
    }
}