
namespace GestPark
{
    partial class FormConnexionGestPark
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
            this.cbxServer = new System.Windows.Forms.ComboBox();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.icbtnCancelCon = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.IcbtnConnected = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.IcbtnTestConn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxServer
            // 
            this.cbxServer.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxServer.FormattingEnabled = true;
            this.cbxServer.Location = new System.Drawing.Point(154, 65);
            this.cbxServer.Name = "cbxServer";
            this.cbxServer.Size = new System.Drawing.Size(276, 23);
            this.cbxServer.TabIndex = 0;
            // 
            // txtDB
            // 
            this.txtDB.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDB.Location = new System.Drawing.Point(154, 106);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(276, 21);
            this.txtDB.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(154, 146);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(276, 21);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(154, 192);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(276, 21);
            this.txtPassword.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Server name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Database";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // icbtnCancelCon
            // 
            this.icbtnCancelCon.BackColor = System.Drawing.Color.DarkOrange;
            this.icbtnCancelCon.ForeColor = System.Drawing.Color.White;
            this.icbtnCancelCon.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.icbtnCancelCon.IconColor = System.Drawing.Color.White;
            this.icbtnCancelCon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtnCancelCon.IconSize = 20;
            this.icbtnCancelCon.Location = new System.Drawing.Point(288, 239);
            this.icbtnCancelCon.Name = "icbtnCancelCon";
            this.icbtnCancelCon.Size = new System.Drawing.Size(99, 29);
            this.icbtnCancelCon.TabIndex = 9;
            this.icbtnCancelCon.Text = "CANCEL";
            this.icbtnCancelCon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtnCancelCon.UseVisualStyleBackColor = false;
            this.icbtnCancelCon.Click += new System.EventHandler(this.icbtnCancelCon_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.DarkGreen;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.iconPictureBox1.IconColor = System.Drawing.Color.DarkGreen;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 47;
            this.iconPictureBox1.Location = new System.Drawing.Point(1, 9);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(47, 48);
            this.iconPictureBox1.TabIndex = 10;
            this.iconPictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(133, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "CONNEXION TO DATABASE";
            // 
            // IcbtnConnected
            // 
            this.IcbtnConnected.BackColor = System.Drawing.Color.DarkGreen;
            this.IcbtnConnected.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IcbtnConnected.ForeColor = System.Drawing.Color.White;
            this.IcbtnConnected.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.IcbtnConnected.IconColor = System.Drawing.Color.White;
            this.IcbtnConnected.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcbtnConnected.IconSize = 20;
            this.IcbtnConnected.Location = new System.Drawing.Point(182, 239);
            this.IcbtnConnected.Name = "IcbtnConnected";
            this.IcbtnConnected.Size = new System.Drawing.Size(100, 29);
            this.IcbtnConnected.TabIndex = 12;
            this.IcbtnConnected.Text = "VALIDE";
            this.IcbtnConnected.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IcbtnConnected.UseVisualStyleBackColor = false;
            this.IcbtnConnected.Click += new System.EventHandler(this.IcbtnConnected_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "GestPark";
            // 
            // IcbtnTestConn
            // 
            this.IcbtnTestConn.BackColor = System.Drawing.Color.DarkGray;
            this.IcbtnTestConn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IcbtnTestConn.ForeColor = System.Drawing.Color.White;
            this.IcbtnTestConn.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.IcbtnTestConn.IconColor = System.Drawing.Color.White;
            this.IcbtnTestConn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcbtnTestConn.IconSize = 20;
            this.IcbtnTestConn.Location = new System.Drawing.Point(76, 238);
            this.IcbtnTestConn.Name = "IcbtnTestConn";
            this.IcbtnTestConn.Size = new System.Drawing.Size(100, 29);
            this.IcbtnTestConn.TabIndex = 14;
            this.IcbtnTestConn.Text = "TEST";
            this.IcbtnTestConn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IcbtnTestConn.UseVisualStyleBackColor = false;
            this.IcbtnTestConn.Click += new System.EventHandler(this.IcbtnTestConn_Click);
            // 
            // FormConnexionGestPark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 297);
            this.Controls.Add(this.IcbtnTestConn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.IcbtnConnected);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.icbtnCancelCon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtDB);
            this.Controls.Add(this.cbxServer);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormConnexionGestPark";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConnexionDatabaseGestPark";
            this.Load += new System.EventHandler(this.FormConnexionGestPark_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton icbtnCancelCon;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton IcbtnConnected;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton IcbtnTestConn;
        public System.Windows.Forms.ComboBox cbxServer;
        public System.Windows.Forms.TextBox txtDB;
        public System.Windows.Forms.TextBox txtUsername;
        public System.Windows.Forms.TextBox txtPassword;
    }
}