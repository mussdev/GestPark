
namespace GestPark
{
    partial class FormTypeConsommation
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
            this.panelTypConsoTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.iconBtnCloseFormTypConso = new FontAwesome.Sharp.IconButton();
            this.panelRegisterTypConso = new System.Windows.Forms.Panel();
            this.iconBtnAnnulerTypConso = new FontAwesome.Sharp.IconButton();
            this.iconBtnValiderTypConso = new FontAwesome.Sharp.IconButton();
            this.richTextBoxNoteTypConso = new System.Windows.Forms.RichTextBox();
            this.textBoxDescripTypConso = new System.Windows.Forms.TextBox();
            this.textBoxCodTypConso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewTypConso = new System.Windows.Forms.DataGridView();
            this.ID_TYPCONSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE_TYPCONSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_TYPCONSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBSERVATION_TYPCONSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERCREATE_TYPCONSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATECREATE_TYPCONSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTypConsoTitle.SuspendLayout();
            this.panelRegisterTypConso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTypConso)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTypConsoTitle
            // 
            this.panelTypConsoTitle.BackColor = System.Drawing.Color.DarkOrange;
            this.panelTypConsoTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTypConsoTitle.Controls.Add(this.label1);
            this.panelTypConsoTitle.Controls.Add(this.iconBtnCloseFormTypConso);
            this.panelTypConsoTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTypConsoTitle.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTypConsoTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTypConsoTitle.Name = "panelTypConsoTitle";
            this.panelTypConsoTitle.Size = new System.Drawing.Size(924, 32);
            this.panelTypConsoTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Les types de consommations";
            // 
            // iconBtnCloseFormTypConso
            // 
            this.iconBtnCloseFormTypConso.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconBtnCloseFormTypConso.IconColor = System.Drawing.Color.Red;
            this.iconBtnCloseFormTypConso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnCloseFormTypConso.IconSize = 35;
            this.iconBtnCloseFormTypConso.Location = new System.Drawing.Point(1054, -2);
            this.iconBtnCloseFormTypConso.Name = "iconBtnCloseFormTypConso";
            this.iconBtnCloseFormTypConso.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.iconBtnCloseFormTypConso.Size = new System.Drawing.Size(39, 32);
            this.iconBtnCloseFormTypConso.TabIndex = 0;
            this.iconBtnCloseFormTypConso.UseVisualStyleBackColor = true;
            this.iconBtnCloseFormTypConso.Click += new System.EventHandler(this.iconBtnCloseFormTypConso_Click);
            // 
            // panelRegisterTypConso
            // 
            this.panelRegisterTypConso.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelRegisterTypConso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRegisterTypConso.Controls.Add(this.iconBtnAnnulerTypConso);
            this.panelRegisterTypConso.Controls.Add(this.iconBtnValiderTypConso);
            this.panelRegisterTypConso.Controls.Add(this.richTextBoxNoteTypConso);
            this.panelRegisterTypConso.Controls.Add(this.textBoxDescripTypConso);
            this.panelRegisterTypConso.Controls.Add(this.textBoxCodTypConso);
            this.panelRegisterTypConso.Controls.Add(this.label4);
            this.panelRegisterTypConso.Controls.Add(this.label3);
            this.panelRegisterTypConso.Controls.Add(this.label2);
            this.panelRegisterTypConso.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRegisterTypConso.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelRegisterTypConso.Location = new System.Drawing.Point(0, 32);
            this.panelRegisterTypConso.Name = "panelRegisterTypConso";
            this.panelRegisterTypConso.Size = new System.Drawing.Size(383, 507);
            this.panelRegisterTypConso.TabIndex = 1;
            // 
            // iconBtnAnnulerTypConso
            // 
            this.iconBtnAnnulerTypConso.BackColor = System.Drawing.Color.White;
            this.iconBtnAnnulerTypConso.ForeColor = System.Drawing.Color.DarkOrange;
            this.iconBtnAnnulerTypConso.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconBtnAnnulerTypConso.IconColor = System.Drawing.Color.Black;
            this.iconBtnAnnulerTypConso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnAnnulerTypConso.Location = new System.Drawing.Point(242, 396);
            this.iconBtnAnnulerTypConso.Name = "iconBtnAnnulerTypConso";
            this.iconBtnAnnulerTypConso.Size = new System.Drawing.Size(95, 33);
            this.iconBtnAnnulerTypConso.TabIndex = 5;
            this.iconBtnAnnulerTypConso.Text = "ANNULER";
            this.iconBtnAnnulerTypConso.UseVisualStyleBackColor = false;
            // 
            // iconBtnValiderTypConso
            // 
            this.iconBtnValiderTypConso.BackColor = System.Drawing.Color.White;
            this.iconBtnValiderTypConso.ForeColor = System.Drawing.Color.DarkGreen;
            this.iconBtnValiderTypConso.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconBtnValiderTypConso.IconColor = System.Drawing.Color.Black;
            this.iconBtnValiderTypConso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnValiderTypConso.Location = new System.Drawing.Point(122, 396);
            this.iconBtnValiderTypConso.Name = "iconBtnValiderTypConso";
            this.iconBtnValiderTypConso.Size = new System.Drawing.Size(98, 33);
            this.iconBtnValiderTypConso.TabIndex = 4;
            this.iconBtnValiderTypConso.Text = "VALIDER";
            this.iconBtnValiderTypConso.UseVisualStyleBackColor = false;
            this.iconBtnValiderTypConso.Click += new System.EventHandler(this.iconBtnValiderTypConso_Click);
            // 
            // richTextBoxNoteTypConso
            // 
            this.richTextBoxNoteTypConso.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxNoteTypConso.Location = new System.Drawing.Point(113, 198);
            this.richTextBoxNoteTypConso.Name = "richTextBoxNoteTypConso";
            this.richTextBoxNoteTypConso.Size = new System.Drawing.Size(263, 155);
            this.richTextBoxNoteTypConso.TabIndex = 5;
            this.richTextBoxNoteTypConso.Text = "";
            // 
            // textBoxDescripTypConso
            // 
            this.textBoxDescripTypConso.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescripTypConso.Location = new System.Drawing.Point(113, 120);
            this.textBoxDescripTypConso.Name = "textBoxDescripTypConso";
            this.textBoxDescripTypConso.Size = new System.Drawing.Size(263, 25);
            this.textBoxDescripTypConso.TabIndex = 2;
            // 
            // textBoxCodTypConso
            // 
            this.textBoxCodTypConso.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodTypConso.Location = new System.Drawing.Point(113, 46);
            this.textBoxCodTypConso.Name = "textBoxCodTypConso";
            this.textBoxCodTypConso.Size = new System.Drawing.Size(129, 25);
            this.textBoxCodTypConso.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(10, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Note :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(6, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Description :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Code :";
            // 
            // dataGridViewTypConso
            // 
            this.dataGridViewTypConso.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridViewTypConso.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTypConso.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewTypConso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewTypConso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTypConso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_TYPCONSO,
            this.CODE_TYPCONSO,
            this.DESCRIPTION_TYPCONSO,
            this.OBSERVATION_TYPCONSO,
            this.USERCREATE_TYPCONSO,
            this.DATECREATE_TYPCONSO});
            this.dataGridViewTypConso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTypConso.GridColor = System.Drawing.Color.White;
            this.dataGridViewTypConso.Location = new System.Drawing.Point(383, 32);
            this.dataGridViewTypConso.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewTypConso.Name = "dataGridViewTypConso";
            this.dataGridViewTypConso.Size = new System.Drawing.Size(541, 507);
            this.dataGridViewTypConso.TabIndex = 4;
            // 
            // ID_TYPCONSO
            // 
            this.ID_TYPCONSO.DataPropertyName = "ID_TYPCONSO";
            this.ID_TYPCONSO.HeaderText = "Num";
            this.ID_TYPCONSO.Name = "ID_TYPCONSO";
            this.ID_TYPCONSO.Width = 50;
            // 
            // CODE_TYPCONSO
            // 
            this.CODE_TYPCONSO.DataPropertyName = "CODE_TYPCONSO";
            this.CODE_TYPCONSO.HeaderText = "Code";
            this.CODE_TYPCONSO.Name = "CODE_TYPCONSO";
            this.CODE_TYPCONSO.Width = 50;
            // 
            // DESCRIPTION_TYPCONSO
            // 
            this.DESCRIPTION_TYPCONSO.DataPropertyName = "DESCRIPTION_TYPCONSO";
            this.DESCRIPTION_TYPCONSO.HeaderText = "Description";
            this.DESCRIPTION_TYPCONSO.Name = "DESCRIPTION_TYPCONSO";
            // 
            // OBSERVATION_TYPCONSO
            // 
            this.OBSERVATION_TYPCONSO.DataPropertyName = "OBSERVATION_TYPCONSO";
            this.OBSERVATION_TYPCONSO.HeaderText = "Note";
            this.OBSERVATION_TYPCONSO.Name = "OBSERVATION_TYPCONSO";
            this.OBSERVATION_TYPCONSO.Width = 120;
            // 
            // USERCREATE_TYPCONSO
            // 
            this.USERCREATE_TYPCONSO.DataPropertyName = "USERCREATE_TYPCONSO";
            this.USERCREATE_TYPCONSO.HeaderText = "Créer par";
            this.USERCREATE_TYPCONSO.Name = "USERCREATE_TYPCONSO";
            this.USERCREATE_TYPCONSO.Width = 80;
            // 
            // DATECREATE_TYPCONSO
            // 
            this.DATECREATE_TYPCONSO.DataPropertyName = "DATECREATE_TYPCONSO";
            this.DATECREATE_TYPCONSO.HeaderText = "Créer le";
            this.DATECREATE_TYPCONSO.Name = "DATECREATE_TYPCONSO";
            // 
            // FormTypeConsommation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 539);
            this.Controls.Add(this.dataGridViewTypConso);
            this.Controls.Add(this.panelRegisterTypConso);
            this.Controls.Add(this.panelTypConsoTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTypeConsommation";
            this.Text = "FormTypeConsommation";
            this.panelTypConsoTitle.ResumeLayout(false);
            this.panelTypConsoTitle.PerformLayout();
            this.panelRegisterTypConso.ResumeLayout(false);
            this.panelRegisterTypConso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTypConso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTypConsoTitle;
        private FontAwesome.Sharp.IconButton iconBtnCloseFormTypConso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelRegisterTypConso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconBtnAnnulerTypConso;
        private FontAwesome.Sharp.IconButton iconBtnValiderTypConso;
        private System.Windows.Forms.RichTextBox richTextBoxNoteTypConso;
        private System.Windows.Forms.TextBox textBoxDescripTypConso;
        private System.Windows.Forms.TextBox textBoxCodTypConso;
        private System.Windows.Forms.DataGridView dataGridViewTypConso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TYPCONSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_TYPCONSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_TYPCONSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBSERVATION_TYPCONSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERCREATE_TYPCONSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATECREATE_TYPCONSO;
    }
}