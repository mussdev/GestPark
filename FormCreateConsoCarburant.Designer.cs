
namespace GestPark
{
    partial class FormCreateConsoCarburant
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
            this.PanelMenuConsoCarb = new System.Windows.Forms.Panel();
            this.JointDocConsoCarb = new FontAwesome.Sharp.IconButton();
            this.IcBtnSavedConsoCarb = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCodeConsoCarb = new System.Windows.Forms.TextBox();
            this.TxtDescriptionConsoCarb = new System.Windows.Forms.TextBox();
            this.TxtStationConsoCarb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DateRegisterConsoCarb = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.RtxtNoteConsoCarb = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtAmountConsoCarb = new System.Windows.Forms.TextBox();
            this.TxtLiterConsoCarb = new System.Windows.Forms.TextBox();
            this.CbxVehiConsoCab = new System.Windows.Forms.ComboBox();
            this.TxtTypConsoCarb = new System.Windows.Forms.TextBox();
            this.PanelMenuConsoCarb.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenuConsoCarb
            // 
            this.PanelMenuConsoCarb.BackColor = System.Drawing.Color.DarkOrange;
            this.PanelMenuConsoCarb.Controls.Add(this.JointDocConsoCarb);
            this.PanelMenuConsoCarb.Controls.Add(this.IcBtnSavedConsoCarb);
            this.PanelMenuConsoCarb.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelMenuConsoCarb.Location = new System.Drawing.Point(0, 0);
            this.PanelMenuConsoCarb.Name = "PanelMenuConsoCarb";
            this.PanelMenuConsoCarb.Size = new System.Drawing.Size(700, 30);
            this.PanelMenuConsoCarb.TabIndex = 0;
            // 
            // JointDocConsoCarb
            // 
            this.JointDocConsoCarb.BackColor = System.Drawing.Color.White;
            this.JointDocConsoCarb.ForeColor = System.Drawing.Color.DarkGreen;
            this.JointDocConsoCarb.IconChar = FontAwesome.Sharp.IconChar.FileUpload;
            this.JointDocConsoCarb.IconColor = System.Drawing.Color.DarkGreen;
            this.JointDocConsoCarb.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.JointDocConsoCarb.IconSize = 25;
            this.JointDocConsoCarb.Location = new System.Drawing.Point(95, 0);
            this.JointDocConsoCarb.Name = "JointDocConsoCarb";
            this.JointDocConsoCarb.Size = new System.Drawing.Size(119, 30);
            this.JointDocConsoCarb.TabIndex = 2;
            this.JointDocConsoCarb.Text = "Joindre fichier";
            this.JointDocConsoCarb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.JointDocConsoCarb.UseVisualStyleBackColor = false;
            // 
            // IcBtnSavedConsoCarb
            // 
            this.IcBtnSavedConsoCarb.BackColor = System.Drawing.Color.White;
            this.IcBtnSavedConsoCarb.ForeColor = System.Drawing.Color.DarkGreen;
            this.IcBtnSavedConsoCarb.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.IcBtnSavedConsoCarb.IconColor = System.Drawing.Color.DarkGreen;
            this.IcBtnSavedConsoCarb.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcBtnSavedConsoCarb.IconSize = 25;
            this.IcBtnSavedConsoCarb.Location = new System.Drawing.Point(0, 0);
            this.IcBtnSavedConsoCarb.Name = "IcBtnSavedConsoCarb";
            this.IcBtnSavedConsoCarb.Size = new System.Drawing.Size(101, 30);
            this.IcBtnSavedConsoCarb.TabIndex = 1;
            this.IcBtnSavedConsoCarb.Text = "Enregistrer";
            this.IcBtnSavedConsoCarb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IcBtnSavedConsoCarb.UseVisualStyleBackColor = false;
            this.IcBtnSavedConsoCarb.Click += new System.EventHandler(this.IcBtnSavedConsoCarb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Code :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Station :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(13, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vehicule :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Type conso. :";
            // 
            // TxtCodeConsoCarb
            // 
            this.TxtCodeConsoCarb.BackColor = System.Drawing.Color.Khaki;
            this.TxtCodeConsoCarb.Location = new System.Drawing.Point(95, 41);
            this.TxtCodeConsoCarb.Name = "TxtCodeConsoCarb";
            this.TxtCodeConsoCarb.ReadOnly = true;
            this.TxtCodeConsoCarb.Size = new System.Drawing.Size(100, 22);
            this.TxtCodeConsoCarb.TabIndex = 6;
            // 
            // TxtDescriptionConsoCarb
            // 
            this.TxtDescriptionConsoCarb.Location = new System.Drawing.Point(95, 91);
            this.TxtDescriptionConsoCarb.Name = "TxtDescriptionConsoCarb";
            this.TxtDescriptionConsoCarb.Size = new System.Drawing.Size(240, 22);
            this.TxtDescriptionConsoCarb.TabIndex = 7;
            // 
            // TxtStationConsoCarb
            // 
            this.TxtStationConsoCarb.Location = new System.Drawing.Point(95, 144);
            this.TxtStationConsoCarb.Name = "TxtStationConsoCarb";
            this.TxtStationConsoCarb.Size = new System.Drawing.Size(240, 22);
            this.TxtStationConsoCarb.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Note :";
            // 
            // DateRegisterConsoCarb
            // 
            this.DateRegisterConsoCarb.Location = new System.Drawing.Point(452, 41);
            this.DateRegisterConsoCarb.Name = "DateRegisterConsoCarb";
            this.DateRegisterConsoCarb.Size = new System.Drawing.Size(236, 22);
            this.DateRegisterConsoCarb.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Date :";
            // 
            // RtxtNoteConsoCarb
            // 
            this.RtxtNoteConsoCarb.Location = new System.Drawing.Point(95, 318);
            this.RtxtNoteConsoCarb.Name = "RtxtNoteConsoCarb";
            this.RtxtNoteConsoCarb.Size = new System.Drawing.Size(593, 130);
            this.RtxtNoteConsoCarb.TabIndex = 17;
            this.RtxtNoteConsoCarb.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(380, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Montant :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(380, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Litre carb. :";
            // 
            // TxtAmountConsoCarb
            // 
            this.TxtAmountConsoCarb.Location = new System.Drawing.Point(452, 91);
            this.TxtAmountConsoCarb.Name = "TxtAmountConsoCarb";
            this.TxtAmountConsoCarb.Size = new System.Drawing.Size(236, 22);
            this.TxtAmountConsoCarb.TabIndex = 20;
            // 
            // TxtLiterConsoCarb
            // 
            this.TxtLiterConsoCarb.Location = new System.Drawing.Point(452, 144);
            this.TxtLiterConsoCarb.Name = "TxtLiterConsoCarb";
            this.TxtLiterConsoCarb.Size = new System.Drawing.Size(236, 22);
            this.TxtLiterConsoCarb.TabIndex = 21;
            // 
            // CbxVehiConsoCab
            // 
            this.CbxVehiConsoCab.FormattingEnabled = true;
            this.CbxVehiConsoCab.Location = new System.Drawing.Point(95, 196);
            this.CbxVehiConsoCab.Name = "CbxVehiConsoCab";
            this.CbxVehiConsoCab.Size = new System.Drawing.Size(240, 23);
            this.CbxVehiConsoCab.TabIndex = 22;
            this.CbxVehiConsoCab.SelectedIndexChanged += new System.EventHandler(this.CbxVehiConsoCab_SelectedIndexChanged);
            // 
            // TxtTypConsoCarb
            // 
            this.TxtTypConsoCarb.BackColor = System.Drawing.Color.Khaki;
            this.TxtTypConsoCarb.Location = new System.Drawing.Point(95, 253);
            this.TxtTypConsoCarb.Name = "TxtTypConsoCarb";
            this.TxtTypConsoCarb.ReadOnly = true;
            this.TxtTypConsoCarb.Size = new System.Drawing.Size(240, 22);
            this.TxtTypConsoCarb.TabIndex = 23;
            // 
            // FormCreateConsoCarburant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(700, 469);
            this.Controls.Add(this.TxtTypConsoCarb);
            this.Controls.Add(this.CbxVehiConsoCab);
            this.Controls.Add(this.TxtLiterConsoCarb);
            this.Controls.Add(this.TxtAmountConsoCarb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RtxtNoteConsoCarb);
            this.Controls.Add(this.DateRegisterConsoCarb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtStationConsoCarb);
            this.Controls.Add(this.TxtDescriptionConsoCarb);
            this.Controls.Add(this.TxtCodeConsoCarb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelMenuConsoCarb);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCreateConsoCarburant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCreateConsoCarburant";
            this.PanelMenuConsoCarb.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenuConsoCarb;
        private FontAwesome.Sharp.IconButton IcBtnSavedConsoCarb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCodeConsoCarb;
        private System.Windows.Forms.TextBox TxtDescriptionConsoCarb;
        private System.Windows.Forms.TextBox TxtStationConsoCarb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DateRegisterConsoCarb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox RtxtNoteConsoCarb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtAmountConsoCarb;
        private System.Windows.Forms.TextBox TxtLiterConsoCarb;
        private FontAwesome.Sharp.IconButton JointDocConsoCarb;
        private System.Windows.Forms.ComboBox CbxVehiConsoCab;
        private System.Windows.Forms.TextBox TxtTypConsoCarb;
    }
}