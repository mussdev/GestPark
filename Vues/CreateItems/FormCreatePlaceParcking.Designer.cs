
namespace GestPark
{
    partial class FormCreatePlaceParcking
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.IbtnModifier = new FontAwesome.Sharp.IconButton();
            this.IconBtnEnregistreParc = new FontAwesome.Sharp.IconButton();
            this.CboBoxTypeParc = new System.Windows.Forms.ComboBox();
            this.RichTextBoxNoteParc = new System.Windows.Forms.RichTextBox();
            this.TextBoxDescriptionParc = new System.Windows.Forms.TextBox();
            this.TextBoxCodeParc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridViewParking = new System.Windows.Forms.DataGridView();
            this.ID_PARK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE_PARK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_PARK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TYPE_PARK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBSERVATION_PARK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATECREATE_PARK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERCREATE_PARK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewParking)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1242, 24);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Khaki;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.IbtnModifier);
            this.panel2.Controls.Add(this.IconBtnEnregistreParc);
            this.panel2.Controls.Add(this.CboBoxTypeParc);
            this.panel2.Controls.Add(this.RichTextBoxNoteParc);
            this.panel2.Controls.Add(this.TextBoxDescriptionParc);
            this.panel2.Controls.Add(this.TextBoxCodeParc);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(487, 745);
            this.panel2.TabIndex = 3;
            // 
            // IbtnModifier
            // 
            this.IbtnModifier.BackColor = System.Drawing.Color.Honeydew;
            this.IbtnModifier.ForeColor = System.Drawing.Color.DarkOrange;
            this.IbtnModifier.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.IbtnModifier.IconColor = System.Drawing.Color.DarkOrange;
            this.IbtnModifier.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnModifier.IconSize = 20;
            this.IbtnModifier.Location = new System.Drawing.Point(193, 403);
            this.IbtnModifier.Name = "IbtnModifier";
            this.IbtnModifier.Size = new System.Drawing.Size(107, 28);
            this.IbtnModifier.TabIndex = 9;
            this.IbtnModifier.Text = "Modifier";
            this.IbtnModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IbtnModifier.UseVisualStyleBackColor = false;
            // 
            // IconBtnEnregistreParc
            // 
            this.IconBtnEnregistreParc.BackColor = System.Drawing.Color.Honeydew;
            this.IconBtnEnregistreParc.ForeColor = System.Drawing.Color.YellowGreen;
            this.IconBtnEnregistreParc.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.IconBtnEnregistreParc.IconColor = System.Drawing.Color.YellowGreen;
            this.IconBtnEnregistreParc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconBtnEnregistreParc.IconSize = 20;
            this.IconBtnEnregistreParc.Location = new System.Drawing.Point(307, 403);
            this.IconBtnEnregistreParc.Name = "IconBtnEnregistreParc";
            this.IconBtnEnregistreParc.Size = new System.Drawing.Size(108, 28);
            this.IconBtnEnregistreParc.TabIndex = 8;
            this.IconBtnEnregistreParc.Text = "Enregistrer";
            this.IconBtnEnregistreParc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IconBtnEnregistreParc.UseVisualStyleBackColor = false;
            this.IconBtnEnregistreParc.Click += new System.EventHandler(this.IconBtnEnregistreParc_Click);
            // 
            // CboBoxTypeParc
            // 
            this.CboBoxTypeParc.BackColor = System.Drawing.Color.Honeydew;
            this.CboBoxTypeParc.FormattingEnabled = true;
            this.CboBoxTypeParc.Items.AddRange(new object[] {
            "Public",
            "Privé"});
            this.CboBoxTypeParc.Location = new System.Drawing.Point(124, 164);
            this.CboBoxTypeParc.Name = "CboBoxTypeParc";
            this.CboBoxTypeParc.Size = new System.Drawing.Size(343, 28);
            this.CboBoxTypeParc.TabIndex = 7;
            // 
            // RichTextBoxNoteParc
            // 
            this.RichTextBoxNoteParc.BackColor = System.Drawing.Color.Honeydew;
            this.RichTextBoxNoteParc.Location = new System.Drawing.Point(124, 233);
            this.RichTextBoxNoteParc.Name = "RichTextBoxNoteParc";
            this.RichTextBoxNoteParc.Size = new System.Drawing.Size(343, 131);
            this.RichTextBoxNoteParc.TabIndex = 6;
            this.RichTextBoxNoteParc.Text = "";
            // 
            // TextBoxDescriptionParc
            // 
            this.TextBoxDescriptionParc.BackColor = System.Drawing.Color.Honeydew;
            this.TextBoxDescriptionParc.Location = new System.Drawing.Point(124, 103);
            this.TextBoxDescriptionParc.Name = "TextBoxDescriptionParc";
            this.TextBoxDescriptionParc.Size = new System.Drawing.Size(343, 28);
            this.TextBoxDescriptionParc.TabIndex = 5;
            // 
            // TextBoxCodeParc
            // 
            this.TextBoxCodeParc.BackColor = System.Drawing.Color.Honeydew;
            this.TextBoxCodeParc.Location = new System.Drawing.Point(124, 38);
            this.TextBoxCodeParc.Name = "TextBoxCodeParc";
            this.TextBoxCodeParc.Size = new System.Drawing.Size(176, 28);
            this.TextBoxCodeParc.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Note";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // DataGridViewParking
            // 
            this.DataGridViewParking.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.DataGridViewParking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewParking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewParking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PARK,
            this.CODE_PARK,
            this.DESCRIPTION_PARK,
            this.TYPE_PARK,
            this.OBSERVATION_PARK,
            this.DATECREATE_PARK,
            this.USERCREATE_PARK});
            this.DataGridViewParking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewParking.Location = new System.Drawing.Point(487, 24);
            this.DataGridViewParking.Name = "DataGridViewParking";
            this.DataGridViewParking.RowHeadersWidth = 51;
            this.DataGridViewParking.Size = new System.Drawing.Size(755, 745);
            this.DataGridViewParking.TabIndex = 4;
            // 
            // ID_PARK
            // 
            this.ID_PARK.DataPropertyName = "ID_PARK";
            this.ID_PARK.HeaderText = "Num";
            this.ID_PARK.MinimumWidth = 6;
            this.ID_PARK.Name = "ID_PARK";
            this.ID_PARK.ReadOnly = true;
            this.ID_PARK.Width = 50;
            // 
            // CODE_PARK
            // 
            this.CODE_PARK.DataPropertyName = "CODE_PARK";
            this.CODE_PARK.HeaderText = "Code";
            this.CODE_PARK.MinimumWidth = 6;
            this.CODE_PARK.Name = "CODE_PARK";
            this.CODE_PARK.ReadOnly = true;
            this.CODE_PARK.Width = 70;
            // 
            // DESCRIPTION_PARK
            // 
            this.DESCRIPTION_PARK.DataPropertyName = "DESCRIPTION_PARK";
            this.DESCRIPTION_PARK.HeaderText = "Description";
            this.DESCRIPTION_PARK.MinimumWidth = 6;
            this.DESCRIPTION_PARK.Name = "DESCRIPTION_PARK";
            this.DESCRIPTION_PARK.ReadOnly = true;
            this.DESCRIPTION_PARK.Width = 125;
            // 
            // TYPE_PARK
            // 
            this.TYPE_PARK.DataPropertyName = "TYPE_PARK";
            this.TYPE_PARK.HeaderText = "Type";
            this.TYPE_PARK.MinimumWidth = 6;
            this.TYPE_PARK.Name = "TYPE_PARK";
            this.TYPE_PARK.ReadOnly = true;
            this.TYPE_PARK.Width = 125;
            // 
            // OBSERVATION_PARK
            // 
            this.OBSERVATION_PARK.DataPropertyName = "OBSERVATION_PARK";
            this.OBSERVATION_PARK.HeaderText = "Note";
            this.OBSERVATION_PARK.MinimumWidth = 6;
            this.OBSERVATION_PARK.Name = "OBSERVATION_PARK";
            this.OBSERVATION_PARK.ReadOnly = true;
            this.OBSERVATION_PARK.Width = 150;
            // 
            // DATECREATE_PARK
            // 
            this.DATECREATE_PARK.DataPropertyName = "DATECREATE_PARK";
            this.DATECREATE_PARK.HeaderText = "Créer le";
            this.DATECREATE_PARK.MinimumWidth = 6;
            this.DATECREATE_PARK.Name = "DATECREATE_PARK";
            this.DATECREATE_PARK.ReadOnly = true;
            this.DATECREATE_PARK.Width = 125;
            // 
            // USERCREATE_PARK
            // 
            this.USERCREATE_PARK.DataPropertyName = "USERCREATE_PARK";
            this.USERCREATE_PARK.HeaderText = "Créer par";
            this.USERCREATE_PARK.MinimumWidth = 6;
            this.USERCREATE_PARK.Name = "USERCREATE_PARK";
            this.USERCREATE_PARK.ReadOnly = true;
            this.USERCREATE_PARK.Width = 125;
            // 
            // FormCreatePlaceParcking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1242, 769);
            this.Controls.Add(this.DataGridViewParking);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCreatePlaceParcking";
            this.Text = "FormCreatePlaceParcking";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewParking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton IconBtnEnregistreParc;
        private System.Windows.Forms.ComboBox CboBoxTypeParc;
        private System.Windows.Forms.RichTextBox RichTextBoxNoteParc;
        private System.Windows.Forms.TextBox TextBoxDescriptionParc;
        private System.Windows.Forms.TextBox TextBoxCodeParc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridViewParking;
        private FontAwesome.Sharp.IconButton IbtnModifier;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PARK;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_PARK;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_PARK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TYPE_PARK;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBSERVATION_PARK;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATECREATE_PARK;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERCREATE_PARK;
    }
}