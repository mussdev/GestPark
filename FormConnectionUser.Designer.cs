
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtPasswordFanConUser = new System.Windows.Forms.TextBox();
            this.TxtUsernameFanConUser = new System.Windows.Forms.TextBox();
            this.IcbtnCancelFanCon = new FontAwesome.Sharp.IconButton();
            this.IcbtnValidFanCon = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IcbtnCloseFanCon = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(50, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 178);
            this.panel1.TabIndex = 0;
            // 
            // TxtPasswordFanConUser
            // 
            this.TxtPasswordFanConUser.Location = new System.Drawing.Point(110, 81);
            this.TxtPasswordFanConUser.Name = "TxtPasswordFanConUser";
            this.TxtPasswordFanConUser.Size = new System.Drawing.Size(258, 21);
            this.TxtPasswordFanConUser.TabIndex = 23;
            // 
            // TxtUsernameFanConUser
            // 
            this.TxtUsernameFanConUser.Location = new System.Drawing.Point(110, 27);
            this.TxtUsernameFanConUser.Name = "TxtUsernameFanConUser";
            this.TxtUsernameFanConUser.Size = new System.Drawing.Size(258, 21);
            this.TxtUsernameFanConUser.TabIndex = 22;
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
            this.IcbtnCancelFanCon.TabIndex = 21;
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
            this.IcbtnValidFanCon.TabIndex = 20;
            this.IcbtnValidFanCon.Text = "VALIDER";
            this.IcbtnValidFanCon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IcbtnValidFanCon.UseVisualStyleBackColor = false;
            this.IcbtnValidFanCon.Click += new System.EventHandler(this.IcbtnValidFanCon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
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
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nom utilisateur";
            // 
            // IcbtnCloseFanCon
            // 
            this.IcbtnCloseFanCon.FlatAppearance.BorderSize = 3;
            this.IcbtnCloseFanCon.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IcbtnCloseFanCon.ForeColor = System.Drawing.Color.Red;
            this.IcbtnCloseFanCon.IconChar = FontAwesome.Sharp.IconChar.None;
            this.IcbtnCloseFanCon.IconColor = System.Drawing.Color.Black;
            this.IcbtnCloseFanCon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcbtnCloseFanCon.Location = new System.Drawing.Point(408, 0);
            this.IcbtnCloseFanCon.Name = "IcbtnCloseFanCon";
            this.IcbtnCloseFanCon.Size = new System.Drawing.Size(75, 23);
            this.IcbtnCloseFanCon.TabIndex = 1;
            this.IcbtnCloseFanCon.Text = "FERMER";
            this.IcbtnCloseFanCon.UseVisualStyleBackColor = true;
            this.IcbtnCloseFanCon.Click += new System.EventHandler(this.IcbtnCloseFanCon_Click);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "GestPark";
            // 
            // FormConnectionUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestPark.Properties.Resources.logoCon;
            this.ClientSize = new System.Drawing.Size(483, 313);
            this.Controls.Add(this.label4);
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

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtPasswordFanConUser;
        private System.Windows.Forms.TextBox TxtUsernameFanConUser;
        private FontAwesome.Sharp.IconButton IcbtnCancelFanCon;
        private FontAwesome.Sharp.IconButton IcbtnValidFanCon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton IcbtnCloseFanCon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}