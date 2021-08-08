
namespace GestPark
{
    partial class FormConnectionUser
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
            this.TxtPasswordFanConUser = new System.Windows.Forms.TextBox();
            this.TxtUsernameFanConUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IcbtnCancelFanCon = new FontAwesome.Sharp.IconButton();
            this.IcbtnValidFanCon = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.IcbtnCloseFanCon = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtPasswordFanConUser
            // 
            this.TxtPasswordFanConUser.Location = new System.Drawing.Point(110, 81);
            this.TxtPasswordFanConUser.Name = "TxtPasswordFanConUser";
            this.TxtPasswordFanConUser.PasswordChar = '*';
            this.TxtPasswordFanConUser.Size = new System.Drawing.Size(258, 21);
            this.TxtPasswordFanConUser.TabIndex = 2;
            // 
            // TxtUsernameFanConUser
            // 
            this.TxtUsernameFanConUser.Location = new System.Drawing.Point(110, 27);
            this.TxtUsernameFanConUser.Name = "TxtUsernameFanConUser";
            this.TxtUsernameFanConUser.Size = new System.Drawing.Size(258, 21);
            this.TxtUsernameFanConUser.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mot de passe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nom utilisateur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "GESTION DE PARC AUTO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.TxtPasswordFanConUser);
            this.panel1.Controls.Add(this.TxtUsernameFanConUser);
            this.panel1.Controls.Add(this.IcbtnCancelFanCon);
            this.panel1.Controls.Add(this.IcbtnValidFanCon);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(25, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 178);
            this.panel1.TabIndex = 0;
            // 
            // IcbtnCancelFanCon
            // 
            this.IcbtnCancelFanCon.BackColor = System.Drawing.Color.White;
            this.IcbtnCancelFanCon.ForeColor = System.Drawing.Color.DarkOrange;
            this.IcbtnCancelFanCon.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.IcbtnCancelFanCon.IconColor = System.Drawing.Color.DarkOrange;
            this.IcbtnCancelFanCon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcbtnCancelFanCon.IconSize = 20;
            this.IcbtnCancelFanCon.Location = new System.Drawing.Point(222, 132);
            this.IcbtnCancelFanCon.Name = "IcbtnCancelFanCon";
            this.IcbtnCancelFanCon.Size = new System.Drawing.Size(93, 23);
            this.IcbtnCancelFanCon.TabIndex = 4;
            this.IcbtnCancelFanCon.Text = "ANNULER";
            this.IcbtnCancelFanCon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IcbtnCancelFanCon.UseVisualStyleBackColor = false;
            // 
            // IcbtnValidFanCon
            // 
            this.IcbtnValidFanCon.BackColor = System.Drawing.Color.White;
            this.IcbtnValidFanCon.ForeColor = System.Drawing.Color.DarkGreen;
            this.IcbtnValidFanCon.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.IcbtnValidFanCon.IconColor = System.Drawing.Color.DarkGreen;
            this.IcbtnValidFanCon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcbtnValidFanCon.IconSize = 20;
            this.IcbtnValidFanCon.Location = new System.Drawing.Point(131, 132);
            this.IcbtnValidFanCon.Name = "IcbtnValidFanCon";
            this.IcbtnValidFanCon.Size = new System.Drawing.Size(85, 23);
            this.IcbtnValidFanCon.TabIndex = 3;
            this.IcbtnValidFanCon.Text = "VALIDER";
            this.IcbtnValidFanCon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IcbtnValidFanCon.UseVisualStyleBackColor = false;
            this.IcbtnValidFanCon.Click += new System.EventHandler(this.IcbtnValidFanCon_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "GestPark@2021";
            // 
            // IcbtnCloseFanCon
            // 
            this.IcbtnCloseFanCon.FlatAppearance.BorderSize = 3;
            this.IcbtnCloseFanCon.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IcbtnCloseFanCon.ForeColor = System.Drawing.Color.Red;
            this.IcbtnCloseFanCon.IconChar = FontAwesome.Sharp.IconChar.None;
            this.IcbtnCloseFanCon.IconColor = System.Drawing.Color.Black;
            this.IcbtnCloseFanCon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcbtnCloseFanCon.Location = new System.Drawing.Point(353, 0);
            this.IcbtnCloseFanCon.Name = "IcbtnCloseFanCon";
            this.IcbtnCloseFanCon.Size = new System.Drawing.Size(75, 23);
            this.IcbtnCloseFanCon.TabIndex = 1;
            this.IcbtnCloseFanCon.Text = "FERMER";
            this.IcbtnCloseFanCon.UseVisualStyleBackColor = true;
            this.IcbtnCloseFanCon.Click += new System.EventHandler(this.IcbtnCloseFanCon_Click);
            // 
            // FormConnectionUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(428, 246);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IcbtnCloseFanCon);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConnectionUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConnectionUser";
            this.Load += new System.EventHandler(this.FormConnectionUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtPasswordFanConUser;
        private System.Windows.Forms.TextBox TxtUsernameFanConUser;
        private FontAwesome.Sharp.IconButton IcbtnCancelFanCon;
        private FontAwesome.Sharp.IconButton IcbtnValidFanCon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton IcbtnCloseFanCon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
    }
}