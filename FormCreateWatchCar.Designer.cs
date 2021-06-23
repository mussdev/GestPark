
namespace GestPark
{
    partial class FormCreateWatchCar
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
            this.CbxVehiculeWatchCar = new System.Windows.Forms.ComboBox();
            this.RbtxNoteWatchCar = new System.Windows.Forms.RichTextBox();
            this.DatePikerWatchCar = new System.Windows.Forms.DateTimePicker();
            this.TbxCodeWatchCar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnJoindreWatchCar = new FontAwesome.Sharp.IconButton();
            this.IBtnRegisterWatchCar = new FontAwesome.Sharp.IconButton();
            this.BtnCloseFormWatchCar = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtBMontant = new System.Windows.Forms.TextBox();
            this.TxtBLieuWatchCar = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CbxVehiculeWatchCar
            // 
            this.CbxVehiculeWatchCar.FormattingEnabled = true;
            this.CbxVehiculeWatchCar.Items.AddRange(new object[] {
            ""});
            this.CbxVehiculeWatchCar.Location = new System.Drawing.Point(98, 128);
            this.CbxVehiculeWatchCar.Name = "CbxVehiculeWatchCar";
            this.CbxVehiculeWatchCar.Size = new System.Drawing.Size(257, 23);
            this.CbxVehiculeWatchCar.TabIndex = 30;
            this.CbxVehiculeWatchCar.SelectedIndexChanged += new System.EventHandler(this.CbxVehiculeWatchCar_SelectedIndexChanged);
            // 
            // RbtxNoteWatchCar
            // 
            this.RbtxNoteWatchCar.Location = new System.Drawing.Point(98, 265);
            this.RbtxNoteWatchCar.Name = "RbtxNoteWatchCar";
            this.RbtxNoteWatchCar.Size = new System.Drawing.Size(601, 128);
            this.RbtxNoteWatchCar.TabIndex = 29;
            this.RbtxNoteWatchCar.Text = "";
            // 
            // DatePikerWatchCar
            // 
            this.DatePikerWatchCar.Location = new System.Drawing.Point(499, 61);
            this.DatePikerWatchCar.Name = "DatePikerWatchCar";
            this.DatePikerWatchCar.Size = new System.Drawing.Size(200, 22);
            this.DatePikerWatchCar.TabIndex = 26;
            // 
            // TbxCodeWatchCar
            // 
            this.TbxCodeWatchCar.BackColor = System.Drawing.Color.Khaki;
            this.TbxCodeWatchCar.Location = new System.Drawing.Point(98, 61);
            this.TbxCodeWatchCar.Name = "TbxCodeWatchCar";
            this.TbxCodeWatchCar.Size = new System.Drawing.Size(119, 22);
            this.TbxCodeWatchCar.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(423, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Lieu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(423, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(13, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Montant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(13, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Vehicule";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Code";
            // 
            // BtnJoindreWatchCar
            // 
            this.BtnJoindreWatchCar.BackColor = System.Drawing.Color.White;
            this.BtnJoindreWatchCar.ForeColor = System.Drawing.Color.DarkGreen;
            this.BtnJoindreWatchCar.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.BtnJoindreWatchCar.IconColor = System.Drawing.Color.DarkGreen;
            this.BtnJoindreWatchCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnJoindreWatchCar.IconSize = 25;
            this.BtnJoindreWatchCar.Location = new System.Drawing.Point(98, 0);
            this.BtnJoindreWatchCar.Name = "BtnJoindreWatchCar";
            this.BtnJoindreWatchCar.Size = new System.Drawing.Size(99, 30);
            this.BtnJoindreWatchCar.TabIndex = 3;
            this.BtnJoindreWatchCar.Text = "Joindre";
            this.BtnJoindreWatchCar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnJoindreWatchCar.UseVisualStyleBackColor = false;
            // 
            // IBtnRegisterWatchCar
            // 
            this.IBtnRegisterWatchCar.BackColor = System.Drawing.Color.White;
            this.IBtnRegisterWatchCar.ForeColor = System.Drawing.Color.DarkGreen;
            this.IBtnRegisterWatchCar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.IBtnRegisterWatchCar.IconColor = System.Drawing.Color.DarkGreen;
            this.IBtnRegisterWatchCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBtnRegisterWatchCar.IconSize = 25;
            this.IBtnRegisterWatchCar.Location = new System.Drawing.Point(0, 0);
            this.IBtnRegisterWatchCar.Name = "IBtnRegisterWatchCar";
            this.IBtnRegisterWatchCar.Size = new System.Drawing.Size(99, 30);
            this.IBtnRegisterWatchCar.TabIndex = 2;
            this.IBtnRegisterWatchCar.Text = "Enregistrer";
            this.IBtnRegisterWatchCar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBtnRegisterWatchCar.UseVisualStyleBackColor = false;
            this.IBtnRegisterWatchCar.Click += new System.EventHandler(this.IBtnRegisterWatchCar_Click);
            // 
            // BtnCloseFormWatchCar
            // 
            this.BtnCloseFormWatchCar.BackColor = System.Drawing.Color.White;
            this.BtnCloseFormWatchCar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.BtnCloseFormWatchCar.IconColor = System.Drawing.Color.Red;
            this.BtnCloseFormWatchCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCloseFormWatchCar.IconSize = 35;
            this.BtnCloseFormWatchCar.Location = new System.Drawing.Point(672, 0);
            this.BtnCloseFormWatchCar.Name = "BtnCloseFormWatchCar";
            this.BtnCloseFormWatchCar.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.BtnCloseFormWatchCar.Size = new System.Drawing.Size(35, 30);
            this.BtnCloseFormWatchCar.TabIndex = 1;
            this.BtnCloseFormWatchCar.UseVisualStyleBackColor = false;
            this.BtnCloseFormWatchCar.Click += new System.EventHandler(this.BtnCloseFormWatchCar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Note";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.BtnJoindreWatchCar);
            this.panel1.Controls.Add(this.IBtnRegisterWatchCar);
            this.panel1.Controls.Add(this.BtnCloseFormWatchCar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 30);
            this.panel1.TabIndex = 17;
            // 
            // TxtBMontant
            // 
            this.TxtBMontant.Location = new System.Drawing.Point(98, 192);
            this.TxtBMontant.Name = "TxtBMontant";
            this.TxtBMontant.Size = new System.Drawing.Size(257, 22);
            this.TxtBMontant.TabIndex = 31;
            // 
            // TxtBLieuWatchCar
            // 
            this.TxtBLieuWatchCar.Location = new System.Drawing.Point(495, 130);
            this.TxtBLieuWatchCar.Name = "TxtBLieuWatchCar";
            this.TxtBLieuWatchCar.Size = new System.Drawing.Size(204, 22);
            this.TxtBLieuWatchCar.TabIndex = 32;
            // 
            // FormCreateWatchCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(707, 399);
            this.Controls.Add(this.TxtBLieuWatchCar);
            this.Controls.Add(this.TxtBMontant);
            this.Controls.Add(this.CbxVehiculeWatchCar);
            this.Controls.Add(this.RbtxNoteWatchCar);
            this.Controls.Add(this.DatePikerWatchCar);
            this.Controls.Add(this.TbxCodeWatchCar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCreateWatchCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCreateWatchCar";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbxVehiculeWatchCar;
        private System.Windows.Forms.RichTextBox RbtxNoteWatchCar;
        private System.Windows.Forms.DateTimePicker DatePikerWatchCar;
        private System.Windows.Forms.TextBox TbxCodeWatchCar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton BtnJoindreWatchCar;
        private FontAwesome.Sharp.IconButton IBtnRegisterWatchCar;
        private FontAwesome.Sharp.IconButton BtnCloseFormWatchCar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtBMontant;
        private System.Windows.Forms.TextBox TxtBLieuWatchCar;
    }
}