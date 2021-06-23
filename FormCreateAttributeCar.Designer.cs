
namespace GestPark
{
    partial class FormCreateAttributeCar
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
            this.IbtnJoindreDocAttr = new FontAwesome.Sharp.IconButton();
            this.IbtnRegisterAttributeCarToPersonn = new FontAwesome.Sharp.IconButton();
            this.IbtnCloseFormCreateAttribute = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TbxCodeAttr = new System.Windows.Forms.TextBox();
            this.DatePikerCreateAttr = new System.Windows.Forms.DateTimePicker();
            this.DateAttrVehi = new System.Windows.Forms.DateTimePicker();
            this.DateFinAttVehi = new System.Windows.Forms.DateTimePicker();
            this.RbtxNoteAttr = new System.Windows.Forms.RichTextBox();
            this.CbxVehiculeAttr = new System.Windows.Forms.ComboBox();
            this.CbxProprietAttr = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.IbtnJoindreDocAttr);
            this.panel1.Controls.Add(this.IbtnRegisterAttributeCarToPersonn);
            this.panel1.Controls.Add(this.IbtnCloseFormCreateAttribute);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 30);
            this.panel1.TabIndex = 0;
            // 
            // IbtnJoindreDocAttr
            // 
            this.IbtnJoindreDocAttr.BackColor = System.Drawing.Color.White;
            this.IbtnJoindreDocAttr.ForeColor = System.Drawing.Color.DarkGreen;
            this.IbtnJoindreDocAttr.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.IbtnJoindreDocAttr.IconColor = System.Drawing.Color.DarkGreen;
            this.IbtnJoindreDocAttr.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnJoindreDocAttr.IconSize = 25;
            this.IbtnJoindreDocAttr.Location = new System.Drawing.Point(98, 0);
            this.IbtnJoindreDocAttr.Name = "IbtnJoindreDocAttr";
            this.IbtnJoindreDocAttr.Size = new System.Drawing.Size(99, 30);
            this.IbtnJoindreDocAttr.TabIndex = 3;
            this.IbtnJoindreDocAttr.Text = "Joindre";
            this.IbtnJoindreDocAttr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IbtnJoindreDocAttr.UseVisualStyleBackColor = false;
            // 
            // IbtnRegisterAttributeCarToPersonn
            // 
            this.IbtnRegisterAttributeCarToPersonn.BackColor = System.Drawing.Color.White;
            this.IbtnRegisterAttributeCarToPersonn.ForeColor = System.Drawing.Color.DarkGreen;
            this.IbtnRegisterAttributeCarToPersonn.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.IbtnRegisterAttributeCarToPersonn.IconColor = System.Drawing.Color.DarkGreen;
            this.IbtnRegisterAttributeCarToPersonn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnRegisterAttributeCarToPersonn.IconSize = 25;
            this.IbtnRegisterAttributeCarToPersonn.Location = new System.Drawing.Point(0, 0);
            this.IbtnRegisterAttributeCarToPersonn.Name = "IbtnRegisterAttributeCarToPersonn";
            this.IbtnRegisterAttributeCarToPersonn.Size = new System.Drawing.Size(99, 30);
            this.IbtnRegisterAttributeCarToPersonn.TabIndex = 2;
            this.IbtnRegisterAttributeCarToPersonn.Text = "Enregistrer";
            this.IbtnRegisterAttributeCarToPersonn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IbtnRegisterAttributeCarToPersonn.UseVisualStyleBackColor = false;
            this.IbtnRegisterAttributeCarToPersonn.Click += new System.EventHandler(this.IbtnRegisterAttributeCarToPersonn_Click);
            // 
            // IbtnCloseFormCreateAttribute
            // 
            this.IbtnCloseFormCreateAttribute.BackColor = System.Drawing.Color.White;
            this.IbtnCloseFormCreateAttribute.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.IbtnCloseFormCreateAttribute.IconColor = System.Drawing.Color.Red;
            this.IbtnCloseFormCreateAttribute.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnCloseFormCreateAttribute.IconSize = 35;
            this.IbtnCloseFormCreateAttribute.Location = new System.Drawing.Point(672, 0);
            this.IbtnCloseFormCreateAttribute.Name = "IbtnCloseFormCreateAttribute";
            this.IbtnCloseFormCreateAttribute.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.IbtnCloseFormCreateAttribute.Size = new System.Drawing.Size(35, 30);
            this.IbtnCloseFormCreateAttribute.TabIndex = 1;
            this.IbtnCloseFormCreateAttribute.UseVisualStyleBackColor = false;
            this.IbtnCloseFormCreateAttribute.Click += new System.EventHandler(this.IbtnCloseFormCreateAttribute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(13, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vehicule";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(13, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Propriétaire";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Note";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(388, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(388, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Date d\'attribution";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(388, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Date fin attribution";
            // 
            // TbxCodeAttr
            // 
            this.TbxCodeAttr.Location = new System.Drawing.Point(98, 55);
            this.TbxCodeAttr.Name = "TbxCodeAttr";
            this.TbxCodeAttr.Size = new System.Drawing.Size(119, 22);
            this.TbxCodeAttr.TabIndex = 8;
            // 
            // DatePikerCreateAttr
            // 
            this.DatePikerCreateAttr.Location = new System.Drawing.Point(499, 55);
            this.DatePikerCreateAttr.Name = "DatePikerCreateAttr";
            this.DatePikerCreateAttr.Size = new System.Drawing.Size(200, 22);
            this.DatePikerCreateAttr.TabIndex = 11;
            // 
            // DateAttrVehi
            // 
            this.DateAttrVehi.Location = new System.Drawing.Point(499, 120);
            this.DateAttrVehi.Name = "DateAttrVehi";
            this.DateAttrVehi.Size = new System.Drawing.Size(200, 22);
            this.DateAttrVehi.TabIndex = 12;
            // 
            // DateFinAttVehi
            // 
            this.DateFinAttVehi.Location = new System.Drawing.Point(499, 186);
            this.DateFinAttVehi.Name = "DateFinAttVehi";
            this.DateFinAttVehi.Size = new System.Drawing.Size(200, 22);
            this.DateFinAttVehi.TabIndex = 13;
            // 
            // RbtxNoteAttr
            // 
            this.RbtxNoteAttr.Location = new System.Drawing.Point(98, 259);
            this.RbtxNoteAttr.Name = "RbtxNoteAttr";
            this.RbtxNoteAttr.Size = new System.Drawing.Size(601, 128);
            this.RbtxNoteAttr.TabIndex = 14;
            this.RbtxNoteAttr.Text = "";
            // 
            // CbxVehiculeAttr
            // 
            this.CbxVehiculeAttr.FormattingEnabled = true;
            this.CbxVehiculeAttr.Location = new System.Drawing.Point(98, 122);
            this.CbxVehiculeAttr.Name = "CbxVehiculeAttr";
            this.CbxVehiculeAttr.Size = new System.Drawing.Size(257, 23);
            this.CbxVehiculeAttr.TabIndex = 15;
            this.CbxVehiculeAttr.SelectedIndexChanged += new System.EventHandler(this.CbxVehiculeAttr_SelectedIndexChanged);
            // 
            // CbxProprietAttr
            // 
            this.CbxProprietAttr.FormattingEnabled = true;
            this.CbxProprietAttr.Location = new System.Drawing.Point(98, 184);
            this.CbxProprietAttr.Name = "CbxProprietAttr";
            this.CbxProprietAttr.Size = new System.Drawing.Size(257, 23);
            this.CbxProprietAttr.TabIndex = 16;
            this.CbxProprietAttr.SelectedIndexChanged += new System.EventHandler(this.CbxProprietAttr_SelectedIndexChanged);
            // 
            // FormCreateAttributeCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(707, 399);
            this.Controls.Add(this.CbxProprietAttr);
            this.Controls.Add(this.CbxVehiculeAttr);
            this.Controls.Add(this.RbtxNoteAttr);
            this.Controls.Add(this.DateFinAttVehi);
            this.Controls.Add(this.DateAttrVehi);
            this.Controls.Add(this.DatePikerCreateAttr);
            this.Controls.Add(this.TbxCodeAttr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCreateAttributeCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCreateAttributeCar";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton IbtnCloseFormCreateAttribute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TbxCodeAttr;
        private System.Windows.Forms.DateTimePicker DatePikerCreateAttr;
        private System.Windows.Forms.DateTimePicker DateAttrVehi;
        private System.Windows.Forms.DateTimePicker DateFinAttVehi;
        private System.Windows.Forms.RichTextBox RbtxNoteAttr;
        private FontAwesome.Sharp.IconButton IbtnRegisterAttributeCarToPersonn;
        private System.Windows.Forms.ComboBox CbxVehiculeAttr;
        private System.Windows.Forms.ComboBox CbxProprietAttr;
        private FontAwesome.Sharp.IconButton IbtnJoindreDocAttr;
    }
}