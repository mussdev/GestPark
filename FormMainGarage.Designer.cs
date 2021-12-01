
namespace GestPark
{
    partial class FormMainGarage
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
            this.PanelTitleFormGarage = new System.Windows.Forms.Panel();
            this.IcBtnCloseFormGarage = new FontAwesome.Sharp.IconButton();
            this.panelSearchFormGarage = new System.Windows.Forms.Panel();
            this.IbtnModifyGarage = new FontAwesome.Sharp.IconButton();
            this.IbtnRegisterGarage = new FontAwesome.Sharp.IconButton();
            this.RichTextBoxNoteGar = new System.Windows.Forms.RichTextBox();
            this.TbxTelGar = new System.Windows.Forms.TextBox();
            this.TbxProprioGar = new System.Windows.Forms.TextBox();
            this.TbxDescriptionGar = new System.Windows.Forms.TextBox();
            this.TbxGarCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewGarage = new System.Windows.Forms.DataGridView();
            this.ID_GARAGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE_GARAGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_GARAGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROPRIETAIRE_GARAGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEL_GARAGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBSERVATIONS_GARAGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERCREATE_GARAGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATECREATE_GARAGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelTitleFormGarage.SuspendLayout();
            this.panelSearchFormGarage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGarage)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTitleFormGarage
            // 
            this.PanelTitleFormGarage.BackColor = System.Drawing.Color.Khaki;
            this.PanelTitleFormGarage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelTitleFormGarage.Controls.Add(this.IcBtnCloseFormGarage);
            this.PanelTitleFormGarage.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitleFormGarage.Location = new System.Drawing.Point(0, 0);
            this.PanelTitleFormGarage.Name = "PanelTitleFormGarage";
            this.PanelTitleFormGarage.Size = new System.Drawing.Size(1118, 23);
            this.PanelTitleFormGarage.TabIndex = 0;
            // 
            // IcBtnCloseFormGarage
            // 
            this.IcBtnCloseFormGarage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IcBtnCloseFormGarage.BackColor = System.Drawing.Color.White;
            this.IcBtnCloseFormGarage.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.IcBtnCloseFormGarage.IconColor = System.Drawing.Color.Red;
            this.IcBtnCloseFormGarage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcBtnCloseFormGarage.IconSize = 30;
            this.IcBtnCloseFormGarage.Location = new System.Drawing.Point(1084, 0);
            this.IcBtnCloseFormGarage.Name = "IcBtnCloseFormGarage";
            this.IcBtnCloseFormGarage.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.IcBtnCloseFormGarage.Size = new System.Drawing.Size(30, 19);
            this.IcBtnCloseFormGarage.TabIndex = 1;
            this.IcBtnCloseFormGarage.UseVisualStyleBackColor = false;
            this.IcBtnCloseFormGarage.Click += new System.EventHandler(this.IcBtnCloseFormGarage_Click);
            // 
            // panelSearchFormGarage
            // 
            this.panelSearchFormGarage.BackColor = System.Drawing.Color.Khaki;
            this.panelSearchFormGarage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSearchFormGarage.Controls.Add(this.IbtnModifyGarage);
            this.panelSearchFormGarage.Controls.Add(this.IbtnRegisterGarage);
            this.panelSearchFormGarage.Controls.Add(this.RichTextBoxNoteGar);
            this.panelSearchFormGarage.Controls.Add(this.TbxTelGar);
            this.panelSearchFormGarage.Controls.Add(this.TbxProprioGar);
            this.panelSearchFormGarage.Controls.Add(this.TbxDescriptionGar);
            this.panelSearchFormGarage.Controls.Add(this.TbxGarCode);
            this.panelSearchFormGarage.Controls.Add(this.label5);
            this.panelSearchFormGarage.Controls.Add(this.label4);
            this.panelSearchFormGarage.Controls.Add(this.label3);
            this.panelSearchFormGarage.Controls.Add(this.label2);
            this.panelSearchFormGarage.Controls.Add(this.label1);
            this.panelSearchFormGarage.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSearchFormGarage.Location = new System.Drawing.Point(0, 23);
            this.panelSearchFormGarage.Name = "panelSearchFormGarage";
            this.panelSearchFormGarage.Size = new System.Drawing.Size(405, 708);
            this.panelSearchFormGarage.TabIndex = 1;
            // 
            // IbtnModifyGarage
            // 
            this.IbtnModifyGarage.BackColor = System.Drawing.Color.DarkOrange;
            this.IbtnModifyGarage.ForeColor = System.Drawing.Color.White;
            this.IbtnModifyGarage.IconChar = FontAwesome.Sharp.IconChar.Registered;
            this.IbtnModifyGarage.IconColor = System.Drawing.Color.White;
            this.IbtnModifyGarage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnModifyGarage.IconSize = 20;
            this.IbtnModifyGarage.Location = new System.Drawing.Point(134, 483);
            this.IbtnModifyGarage.Name = "IbtnModifyGarage";
            this.IbtnModifyGarage.Size = new System.Drawing.Size(95, 32);
            this.IbtnModifyGarage.TabIndex = 11;
            this.IbtnModifyGarage.Text = "Modifier";
            this.IbtnModifyGarage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IbtnModifyGarage.UseVisualStyleBackColor = false;
            // 
            // IbtnRegisterGarage
            // 
            this.IbtnRegisterGarage.BackColor = System.Drawing.Color.DarkGreen;
            this.IbtnRegisterGarage.ForeColor = System.Drawing.Color.White;
            this.IbtnRegisterGarage.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.IbtnRegisterGarage.IconColor = System.Drawing.Color.White;
            this.IbtnRegisterGarage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnRegisterGarage.IconSize = 20;
            this.IbtnRegisterGarage.Location = new System.Drawing.Point(249, 483);
            this.IbtnRegisterGarage.Name = "IbtnRegisterGarage";
            this.IbtnRegisterGarage.Size = new System.Drawing.Size(95, 32);
            this.IbtnRegisterGarage.TabIndex = 10;
            this.IbtnRegisterGarage.Text = "Enregistrer";
            this.IbtnRegisterGarage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IbtnRegisterGarage.UseVisualStyleBackColor = false;
            this.IbtnRegisterGarage.Click += new System.EventHandler(this.IbtnRegisterGarage_Click);
            // 
            // RichTextBoxNoteGar
            // 
            this.RichTextBoxNoteGar.Location = new System.Drawing.Point(88, 264);
            this.RichTextBoxNoteGar.Name = "RichTextBoxNoteGar";
            this.RichTextBoxNoteGar.Size = new System.Drawing.Size(299, 179);
            this.RichTextBoxNoteGar.TabIndex = 9;
            this.RichTextBoxNoteGar.Text = "";
            // 
            // TbxTelGar
            // 
            this.TbxTelGar.Location = new System.Drawing.Point(88, 198);
            this.TbxTelGar.Name = "TbxTelGar";
            this.TbxTelGar.Size = new System.Drawing.Size(299, 22);
            this.TbxTelGar.TabIndex = 8;
            // 
            // TbxProprioGar
            // 
            this.TbxProprioGar.Location = new System.Drawing.Point(88, 145);
            this.TbxProprioGar.Name = "TbxProprioGar";
            this.TbxProprioGar.Size = new System.Drawing.Size(299, 22);
            this.TbxProprioGar.TabIndex = 7;
            // 
            // TbxDescriptionGar
            // 
            this.TbxDescriptionGar.Location = new System.Drawing.Point(88, 85);
            this.TbxDescriptionGar.Name = "TbxDescriptionGar";
            this.TbxDescriptionGar.Size = new System.Drawing.Size(299, 22);
            this.TbxDescriptionGar.TabIndex = 6;
            // 
            // TbxGarCode
            // 
            this.TbxGarCode.BackColor = System.Drawing.Color.YellowGreen;
            this.TbxGarCode.Location = new System.Drawing.Point(88, 31);
            this.TbxGarCode.Name = "TbxGarCode";
            this.TbxGarCode.ReadOnly = true;
            this.TbxGarCode.Size = new System.Drawing.Size(158, 22);
            this.TbxGarCode.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Note";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tél";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Propriétaire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // dataGridViewGarage
            // 
            this.dataGridViewGarage.BackgroundColor = System.Drawing.Color.Khaki;
            this.dataGridViewGarage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewGarage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGarage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_GARAGE,
            this.CODE_GARAGE,
            this.DESCRIPTION_GARAGE,
            this.PROPRIETAIRE_GARAGE,
            this.TEL_GARAGE,
            this.OBSERVATIONS_GARAGE,
            this.USERCREATE_GARAGE,
            this.DATECREATE_GARAGE});
            this.dataGridViewGarage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewGarage.Location = new System.Drawing.Point(405, 23);
            this.dataGridViewGarage.Name = "dataGridViewGarage";
            this.dataGridViewGarage.Size = new System.Drawing.Size(713, 708);
            this.dataGridViewGarage.TabIndex = 2;
            // 
            // ID_GARAGE
            // 
            this.ID_GARAGE.DataPropertyName = "ID_GARAGE";
            this.ID_GARAGE.HeaderText = "Num";
            this.ID_GARAGE.Name = "ID_GARAGE";
            this.ID_GARAGE.ReadOnly = true;
            this.ID_GARAGE.Width = 50;
            // 
            // CODE_GARAGE
            // 
            this.CODE_GARAGE.DataPropertyName = "CODE_GARAGE";
            this.CODE_GARAGE.HeaderText = "Code";
            this.CODE_GARAGE.Name = "CODE_GARAGE";
            this.CODE_GARAGE.ReadOnly = true;
            this.CODE_GARAGE.Width = 70;
            // 
            // DESCRIPTION_GARAGE
            // 
            this.DESCRIPTION_GARAGE.DataPropertyName = "DESCRIPTION_GARAGE";
            this.DESCRIPTION_GARAGE.HeaderText = "Description";
            this.DESCRIPTION_GARAGE.Name = "DESCRIPTION_GARAGE";
            this.DESCRIPTION_GARAGE.ReadOnly = true;
            // 
            // PROPRIETAIRE_GARAGE
            // 
            this.PROPRIETAIRE_GARAGE.DataPropertyName = "PROPRIETAIRE_GARAGE";
            this.PROPRIETAIRE_GARAGE.HeaderText = "Propriétaire";
            this.PROPRIETAIRE_GARAGE.Name = "PROPRIETAIRE_GARAGE";
            this.PROPRIETAIRE_GARAGE.ReadOnly = true;
            // 
            // TEL_GARAGE
            // 
            this.TEL_GARAGE.DataPropertyName = "TEL_GARAGE";
            this.TEL_GARAGE.HeaderText = "Tél";
            this.TEL_GARAGE.Name = "TEL_GARAGE";
            this.TEL_GARAGE.ReadOnly = true;
            // 
            // OBSERVATIONS_GARAGE
            // 
            this.OBSERVATIONS_GARAGE.DataPropertyName = "OBSERVATIONS_GARAGE";
            this.OBSERVATIONS_GARAGE.HeaderText = "Note";
            this.OBSERVATIONS_GARAGE.Name = "OBSERVATIONS_GARAGE";
            this.OBSERVATIONS_GARAGE.ReadOnly = true;
            // 
            // USERCREATE_GARAGE
            // 
            this.USERCREATE_GARAGE.DataPropertyName = "USERCREATE_GARAGE";
            this.USERCREATE_GARAGE.HeaderText = "Créer par";
            this.USERCREATE_GARAGE.Name = "USERCREATE_GARAGE";
            this.USERCREATE_GARAGE.ReadOnly = true;
            // 
            // DATECREATE_GARAGE
            // 
            this.DATECREATE_GARAGE.DataPropertyName = "DATECREATE_GARAGE";
            this.DATECREATE_GARAGE.HeaderText = "Créer le";
            this.DATECREATE_GARAGE.Name = "DATECREATE_GARAGE";
            this.DATECREATE_GARAGE.ReadOnly = true;
            // 
            // FormMainGarage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1118, 731);
            this.Controls.Add(this.dataGridViewGarage);
            this.Controls.Add(this.panelSearchFormGarage);
            this.Controls.Add(this.PanelTitleFormGarage);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMainGarage";
            this.Text = "FormMainGarage";
            this.PanelTitleFormGarage.ResumeLayout(false);
            this.panelSearchFormGarage.ResumeLayout(false);
            this.panelSearchFormGarage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGarage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTitleFormGarage;
        private FontAwesome.Sharp.IconButton IcBtnCloseFormGarage;
        private System.Windows.Forms.Panel panelSearchFormGarage;
        private System.Windows.Forms.RichTextBox RichTextBoxNoteGar;
        private System.Windows.Forms.TextBox TbxTelGar;
        private System.Windows.Forms.TextBox TbxProprioGar;
        private System.Windows.Forms.TextBox TbxDescriptionGar;
        private System.Windows.Forms.TextBox TbxGarCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton IbtnModifyGarage;
        private FontAwesome.Sharp.IconButton IbtnRegisterGarage;
        private System.Windows.Forms.DataGridView dataGridViewGarage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_GARAGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_GARAGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_GARAGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROPRIETAIRE_GARAGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEL_GARAGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBSERVATIONS_GARAGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERCREATE_GARAGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATECREATE_GARAGE;
    }
}