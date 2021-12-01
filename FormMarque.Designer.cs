
namespace GestPark
{
    partial class FormMarque
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
            this.panelMarqueTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.iconBtnCloseFormMarq = new FontAwesome.Sharp.IconButton();
            this.panelRegisterMarq = new System.Windows.Forms.Panel();
            this.btnValiderMarq = new FontAwesome.Sharp.IconButton();
            this.iconBtnAnnulerMarq = new FontAwesome.Sharp.IconButton();
            this.richTextBoxNoteMarq = new System.Windows.Forms.RichTextBox();
            this.textBoxDescriptMarq = new System.Windows.Forms.TextBox();
            this.textBxCodeMarq = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewMarq = new System.Windows.Forms.DataGridView();
            this.ID_MARQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE_MARQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_MARQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBSERVATIONS_MARQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERCREATE_MARQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATECREATE_MARQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMarqueTitle.SuspendLayout();
            this.panelRegisterMarq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarq)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMarqueTitle
            // 
            this.panelMarqueTitle.BackColor = System.Drawing.Color.Khaki;
            this.panelMarqueTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMarqueTitle.Controls.Add(this.label1);
            this.panelMarqueTitle.Controls.Add(this.iconBtnCloseFormMarq);
            this.panelMarqueTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMarqueTitle.Location = new System.Drawing.Point(0, 0);
            this.panelMarqueTitle.Name = "panelMarqueTitle";
            this.panelMarqueTitle.Size = new System.Drawing.Size(1118, 28);
            this.panelMarqueTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marque de voiture";
            // 
            // iconBtnCloseFormMarq
            // 
            this.iconBtnCloseFormMarq.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.iconBtnCloseFormMarq.BackColor = System.Drawing.Color.White;
            this.iconBtnCloseFormMarq.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnCloseFormMarq.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconBtnCloseFormMarq.IconColor = System.Drawing.Color.Red;
            this.iconBtnCloseFormMarq.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnCloseFormMarq.IconSize = 35;
            this.iconBtnCloseFormMarq.Location = new System.Drawing.Point(1087, -2);
            this.iconBtnCloseFormMarq.Name = "iconBtnCloseFormMarq";
            this.iconBtnCloseFormMarq.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.iconBtnCloseFormMarq.Size = new System.Drawing.Size(32, 30);
            this.iconBtnCloseFormMarq.TabIndex = 0;
            this.iconBtnCloseFormMarq.UseVisualStyleBackColor = false;
            this.iconBtnCloseFormMarq.Click += new System.EventHandler(this.iconBtnCloseFormMarq_Click);
            // 
            // panelRegisterMarq
            // 
            this.panelRegisterMarq.BackColor = System.Drawing.Color.Khaki;
            this.panelRegisterMarq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRegisterMarq.Controls.Add(this.btnValiderMarq);
            this.panelRegisterMarq.Controls.Add(this.iconBtnAnnulerMarq);
            this.panelRegisterMarq.Controls.Add(this.richTextBoxNoteMarq);
            this.panelRegisterMarq.Controls.Add(this.textBoxDescriptMarq);
            this.panelRegisterMarq.Controls.Add(this.textBxCodeMarq);
            this.panelRegisterMarq.Controls.Add(this.label4);
            this.panelRegisterMarq.Controls.Add(this.label3);
            this.panelRegisterMarq.Controls.Add(this.label2);
            this.panelRegisterMarq.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRegisterMarq.Location = new System.Drawing.Point(0, 28);
            this.panelRegisterMarq.Name = "panelRegisterMarq";
            this.panelRegisterMarq.Size = new System.Drawing.Size(385, 703);
            this.panelRegisterMarq.TabIndex = 1;
            // 
            // btnValiderMarq
            // 
            this.btnValiderMarq.BackColor = System.Drawing.Color.DarkGreen;
            this.btnValiderMarq.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValiderMarq.ForeColor = System.Drawing.Color.White;
            this.btnValiderMarq.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnValiderMarq.IconColor = System.Drawing.Color.White;
            this.btnValiderMarq.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnValiderMarq.IconSize = 20;
            this.btnValiderMarq.Location = new System.Drawing.Point(148, 363);
            this.btnValiderMarq.Name = "btnValiderMarq";
            this.btnValiderMarq.Size = new System.Drawing.Size(95, 30);
            this.btnValiderMarq.TabIndex = 8;
            this.btnValiderMarq.Text = "Enregistrer";
            this.btnValiderMarq.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnValiderMarq.UseVisualStyleBackColor = false;
            this.btnValiderMarq.Click += new System.EventHandler(this.btnValiderMarq_Click);
            // 
            // iconBtnAnnulerMarq
            // 
            this.iconBtnAnnulerMarq.BackColor = System.Drawing.Color.DarkOrange;
            this.iconBtnAnnulerMarq.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnAnnulerMarq.ForeColor = System.Drawing.Color.White;
            this.iconBtnAnnulerMarq.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.iconBtnAnnulerMarq.IconColor = System.Drawing.Color.White;
            this.iconBtnAnnulerMarq.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnAnnulerMarq.IconSize = 20;
            this.iconBtnAnnulerMarq.Location = new System.Drawing.Point(249, 363);
            this.iconBtnAnnulerMarq.Name = "iconBtnAnnulerMarq";
            this.iconBtnAnnulerMarq.Size = new System.Drawing.Size(95, 30);
            this.iconBtnAnnulerMarq.TabIndex = 7;
            this.iconBtnAnnulerMarq.Text = "ANNULER";
            this.iconBtnAnnulerMarq.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnAnnulerMarq.UseVisualStyleBackColor = false;
            // 
            // richTextBoxNoteMarq
            // 
            this.richTextBoxNoteMarq.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxNoteMarq.Location = new System.Drawing.Point(90, 181);
            this.richTextBoxNoteMarq.Name = "richTextBoxNoteMarq";
            this.richTextBoxNoteMarq.Size = new System.Drawing.Size(288, 149);
            this.richTextBoxNoteMarq.TabIndex = 5;
            this.richTextBoxNoteMarq.Text = "";
            // 
            // textBoxDescriptMarq
            // 
            this.textBoxDescriptMarq.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescriptMarq.Location = new System.Drawing.Point(92, 104);
            this.textBoxDescriptMarq.Name = "textBoxDescriptMarq";
            this.textBoxDescriptMarq.Size = new System.Drawing.Size(286, 25);
            this.textBoxDescriptMarq.TabIndex = 4;
            // 
            // textBxCodeMarq
            // 
            this.textBxCodeMarq.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBxCodeMarq.Location = new System.Drawing.Point(92, 38);
            this.textBxCodeMarq.Name = "textBxCodeMarq";
            this.textBxCodeMarq.Size = new System.Drawing.Size(127, 25);
            this.textBxCodeMarq.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(7, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Note :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(4, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Description :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(4, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Code :";
            // 
            // dataGridViewMarq
            // 
            this.dataGridViewMarq.AllowUserToOrderColumns = true;
            this.dataGridViewMarq.BackgroundColor = System.Drawing.Color.Khaki;
            this.dataGridViewMarq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewMarq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMarq.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_MARQ,
            this.CODE_MARQ,
            this.DESCRIPTION_MARQ,
            this.OBSERVATIONS_MARQ,
            this.USERCREATE_MARQ,
            this.DATECREATE_MARQ});
            this.dataGridViewMarq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMarq.GridColor = System.Drawing.Color.White;
            this.dataGridViewMarq.Location = new System.Drawing.Point(385, 28);
            this.dataGridViewMarq.Name = "dataGridViewMarq";
            this.dataGridViewMarq.Size = new System.Drawing.Size(733, 703);
            this.dataGridViewMarq.TabIndex = 2;
            // 
            // ID_MARQ
            // 
            this.ID_MARQ.DataPropertyName = "ID_MARQ";
            this.ID_MARQ.HeaderText = "Num";
            this.ID_MARQ.Name = "ID_MARQ";
            this.ID_MARQ.Width = 70;
            // 
            // CODE_MARQ
            // 
            this.CODE_MARQ.DataPropertyName = "CODE_MARQ";
            this.CODE_MARQ.HeaderText = "Code";
            this.CODE_MARQ.Name = "CODE_MARQ";
            this.CODE_MARQ.Width = 80;
            // 
            // DESCRIPTION_MARQ
            // 
            this.DESCRIPTION_MARQ.DataPropertyName = "DESCRIPTION_MARQ";
            this.DESCRIPTION_MARQ.HeaderText = "Description";
            this.DESCRIPTION_MARQ.Name = "DESCRIPTION_MARQ";
            this.DESCRIPTION_MARQ.Width = 150;
            // 
            // OBSERVATIONS_MARQ
            // 
            this.OBSERVATIONS_MARQ.DataPropertyName = "OBSERVATIONS_MARQ";
            this.OBSERVATIONS_MARQ.HeaderText = "Note";
            this.OBSERVATIONS_MARQ.Name = "OBSERVATIONS_MARQ";
            this.OBSERVATIONS_MARQ.Width = 200;
            // 
            // USERCREATE_MARQ
            // 
            this.USERCREATE_MARQ.DataPropertyName = "USERCREATE_MARQ";
            this.USERCREATE_MARQ.HeaderText = "Créer par";
            this.USERCREATE_MARQ.Name = "USERCREATE_MARQ";
            // 
            // DATECREATE_MARQ
            // 
            this.DATECREATE_MARQ.DataPropertyName = "DATECREATE_MARQ";
            this.DATECREATE_MARQ.HeaderText = "Créer le";
            this.DATECREATE_MARQ.Name = "DATECREATE_MARQ";
            // 
            // FormMarque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 731);
            this.Controls.Add(this.dataGridViewMarq);
            this.Controls.Add(this.panelRegisterMarq);
            this.Controls.Add(this.panelMarqueTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMarque";
            this.Text = "FormMarque";
            this.panelMarqueTitle.ResumeLayout(false);
            this.panelMarqueTitle.PerformLayout();
            this.panelRegisterMarq.ResumeLayout(false);
            this.panelRegisterMarq.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarq)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMarqueTitle;
        private FontAwesome.Sharp.IconButton iconBtnCloseFormMarq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelRegisterMarq;
        private FontAwesome.Sharp.IconButton iconBtnAnnulerMarq;
        private System.Windows.Forms.RichTextBox richTextBoxNoteMarq;
        private System.Windows.Forms.TextBox textBoxDescriptMarq;
        private System.Windows.Forms.TextBox textBxCodeMarq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewMarq;
        private FontAwesome.Sharp.IconButton btnValiderMarq;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_MARQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_MARQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_MARQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBSERVATIONS_MARQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERCREATE_MARQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATECREATE_MARQ;
    }
}