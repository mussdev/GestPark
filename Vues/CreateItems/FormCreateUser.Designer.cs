
namespace GestPark
{
    partial class FormCreateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateUser));
            this.PaneInfosAccount = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtUserCode = new System.Windows.Forms.TextBox();
            this.CbxActifUser = new System.Windows.Forms.CheckBox();
            this.CbxChangePasswordAtFirstConnexion = new System.Windows.Forms.CheckBox();
            this.TxtConfirmPassword = new System.Windows.Forms.TextBox();
            this.TxtPasswordUser = new System.Windows.Forms.TextBox();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtDescriptionUser = new System.Windows.Forms.TextBox();
            this.TxtTelUser = new System.Windows.Forms.TextBox();
            this.TxtMailUser = new System.Windows.Forms.TextBox();
            this.PanelInfosIdentityUser = new System.Windows.Forms.Panel();
            this.BtnValideUser = new FontAwesome.Sharp.IconButton();
            this.cbxRolesUser = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPersonnelUser = new FontAwesome.Sharp.IconButton();
            this.txtPersonnelUser = new System.Windows.Forms.TextBox();
            this.PaneInfosAccount.SuspendLayout();
            this.PanelInfosIdentityUser.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PaneInfosAccount
            // 
            this.PaneInfosAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.PaneInfosAccount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PaneInfosAccount.Controls.Add(this.label5);
            this.PaneInfosAccount.Controls.Add(this.TxtUserCode);
            this.PaneInfosAccount.Controls.Add(this.CbxActifUser);
            this.PaneInfosAccount.Controls.Add(this.CbxChangePasswordAtFirstConnexion);
            this.PaneInfosAccount.Controls.Add(this.TxtConfirmPassword);
            this.PaneInfosAccount.Controls.Add(this.TxtPasswordUser);
            this.PaneInfosAccount.Controls.Add(this.TxtUserName);
            this.PaneInfosAccount.Controls.Add(this.label3);
            this.PaneInfosAccount.Controls.Add(this.label2);
            this.PaneInfosAccount.Controls.Add(this.label1);
            this.PaneInfosAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.PaneInfosAccount.Location = new System.Drawing.Point(0, 0);
            this.PaneInfosAccount.Name = "PaneInfosAccount";
            this.PaneInfosAccount.Size = new System.Drawing.Size(989, 188);
            this.PaneInfosAccount.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Code";
            // 
            // TxtUserCode
            // 
            this.TxtUserCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.TxtUserCode.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserCode.ForeColor = System.Drawing.Color.Black;
            this.TxtUserCode.Location = new System.Drawing.Point(162, 11);
            this.TxtUserCode.Name = "TxtUserCode";
            this.TxtUserCode.ReadOnly = true;
            this.TxtUserCode.Size = new System.Drawing.Size(142, 29);
            this.TxtUserCode.TabIndex = 18;
            this.TxtUserCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CbxActifUser
            // 
            this.CbxActifUser.AutoSize = true;
            this.CbxActifUser.BackColor = System.Drawing.Color.White;
            this.CbxActifUser.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxActifUser.Location = new System.Drawing.Point(908, 155);
            this.CbxActifUser.Name = "CbxActifUser";
            this.CbxActifUser.Size = new System.Drawing.Size(69, 25);
            this.CbxActifUser.TabIndex = 7;
            this.CbxActifUser.Text = "Actif";
            this.CbxActifUser.UseVisualStyleBackColor = false;
            // 
            // CbxChangePasswordAtFirstConnexion
            // 
            this.CbxChangePasswordAtFirstConnexion.AutoSize = true;
            this.CbxChangePasswordAtFirstConnexion.BackColor = System.Drawing.Color.White;
            this.CbxChangePasswordAtFirstConnexion.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxChangePasswordAtFirstConnexion.Location = new System.Drawing.Point(20, 155);
            this.CbxChangePasswordAtFirstConnexion.Name = "CbxChangePasswordAtFirstConnexion";
            this.CbxChangePasswordAtFirstConnexion.Size = new System.Drawing.Size(415, 25);
            this.CbxChangePasswordAtFirstConnexion.TabIndex = 6;
            this.CbxChangePasswordAtFirstConnexion.Text = "Changer de mot de passse à la première connection";
            this.CbxChangePasswordAtFirstConnexion.UseVisualStyleBackColor = false;
            // 
            // TxtConfirmPassword
            // 
            this.TxtConfirmPassword.BackColor = System.Drawing.Color.White;
            this.TxtConfirmPassword.Location = new System.Drawing.Point(735, 74);
            this.TxtConfirmPassword.Name = "TxtConfirmPassword";
            this.TxtConfirmPassword.PasswordChar = '*';
            this.TxtConfirmPassword.Size = new System.Drawing.Size(242, 28);
            this.TxtConfirmPassword.TabIndex = 5;
            // 
            // TxtPasswordUser
            // 
            this.TxtPasswordUser.BackColor = System.Drawing.Color.White;
            this.TxtPasswordUser.Location = new System.Drawing.Point(735, 15);
            this.TxtPasswordUser.Name = "TxtPasswordUser";
            this.TxtPasswordUser.PasswordChar = '*';
            this.TxtPasswordUser.Size = new System.Drawing.Size(242, 28);
            this.TxtPasswordUser.TabIndex = 4;
            // 
            // TxtUserName
            // 
            this.TxtUserName.BackColor = System.Drawing.Color.White;
            this.TxtUserName.Location = new System.Drawing.Point(162, 77);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(330, 28);
            this.TxtUserName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(520, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirmer mot de passe * :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(520, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe * :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(16, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Non utilisateur * :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(10, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Description * :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(525, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Rôles";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tél :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 21);
            this.label8.TabIndex = 11;
            this.label8.Text = "Email :";
            // 
            // TxtDescriptionUser
            // 
            this.TxtDescriptionUser.BackColor = System.Drawing.Color.White;
            this.TxtDescriptionUser.Location = new System.Drawing.Point(149, 26);
            this.TxtDescriptionUser.Name = "TxtDescriptionUser";
            this.TxtDescriptionUser.Size = new System.Drawing.Size(330, 28);
            this.TxtDescriptionUser.TabIndex = 8;
            // 
            // TxtTelUser
            // 
            this.TxtTelUser.BackColor = System.Drawing.Color.White;
            this.TxtTelUser.Location = new System.Drawing.Point(149, 87);
            this.TxtTelUser.Name = "TxtTelUser";
            this.TxtTelUser.Size = new System.Drawing.Size(330, 28);
            this.TxtTelUser.TabIndex = 13;
            // 
            // TxtMailUser
            // 
            this.TxtMailUser.BackColor = System.Drawing.Color.White;
            this.TxtMailUser.Location = new System.Drawing.Point(149, 147);
            this.TxtMailUser.Name = "TxtMailUser";
            this.TxtMailUser.Size = new System.Drawing.Size(330, 28);
            this.TxtMailUser.TabIndex = 14;
            // 
            // PanelInfosIdentityUser
            // 
            this.PanelInfosIdentityUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.PanelInfosIdentityUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelInfosIdentityUser.Controls.Add(this.TxtDescriptionUser);
            this.PanelInfosIdentityUser.Controls.Add(this.label4);
            this.PanelInfosIdentityUser.Controls.Add(this.TxtMailUser);
            this.PanelInfosIdentityUser.Controls.Add(this.label7);
            this.PanelInfosIdentityUser.Controls.Add(this.TxtTelUser);
            this.PanelInfosIdentityUser.Controls.Add(this.label8);
            this.PanelInfosIdentityUser.Location = new System.Drawing.Point(13, 67);
            this.PanelInfosIdentityUser.Name = "PanelInfosIdentityUser";
            this.PanelInfosIdentityUser.Size = new System.Drawing.Size(497, 217);
            this.PanelInfosIdentityUser.TabIndex = 16;
            // 
            // BtnValideUser
            // 
            this.BtnValideUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.BtnValideUser.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnValideUser.ForeColor = System.Drawing.Color.Black;
            this.BtnValideUser.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.BtnValideUser.IconColor = System.Drawing.Color.White;
            this.BtnValideUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnValideUser.IconSize = 20;
            this.BtnValideUser.Location = new System.Drawing.Point(395, 303);
            this.BtnValideUser.Name = "BtnValideUser";
            this.BtnValideUser.Size = new System.Drawing.Size(115, 34);
            this.BtnValideUser.TabIndex = 19;
            this.BtnValideUser.Text = "VALIDER";
            this.BtnValideUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnValideUser.UseVisualStyleBackColor = false;
            this.BtnValideUser.Click += new System.EventHandler(this.BtnValideUser_Click);
            // 
            // cbxRolesUser
            // 
            this.cbxRolesUser.ForeColor = System.Drawing.Color.Black;
            this.cbxRolesUser.FormattingEnabled = true;
            this.cbxRolesUser.Location = new System.Drawing.Point(529, 50);
            this.cbxRolesUser.Name = "cbxRolesUser";
            this.cbxRolesUser.Size = new System.Drawing.Size(338, 28);
            this.cbxRolesUser.TabIndex = 20;
            this.cbxRolesUser.SelectedIndexChanged += new System.EventHandler(this.cbxRolesUser_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnPersonnelUser);
            this.panel1.Controls.Add(this.txtPersonnelUser);
            this.panel1.Controls.Add(this.PanelInfosIdentityUser);
            this.panel1.Controls.Add(this.cbxRolesUser);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.BtnValideUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 351);
            this.panel1.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(24, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 21);
            this.label9.TabIndex = 23;
            this.label9.Text = "Personnel :";
            // 
            // btnPersonnelUser
            // 
            this.btnPersonnelUser.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPersonnelUser.IconColor = System.Drawing.Color.Black;
            this.btnPersonnelUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPersonnelUser.Location = new System.Drawing.Point(449, 17);
            this.btnPersonnelUser.Name = "btnPersonnelUser";
            this.btnPersonnelUser.Size = new System.Drawing.Size(40, 28);
            this.btnPersonnelUser.TabIndex = 22;
            this.btnPersonnelUser.Text = "...";
            this.btnPersonnelUser.UseVisualStyleBackColor = true;
            this.btnPersonnelUser.Click += new System.EventHandler(this.btnPersonnelUser_Click);
            // 
            // txtPersonnelUser
            // 
            this.txtPersonnelUser.BackColor = System.Drawing.Color.White;
            this.txtPersonnelUser.ForeColor = System.Drawing.Color.Black;
            this.txtPersonnelUser.Location = new System.Drawing.Point(164, 17);
            this.txtPersonnelUser.Name = "txtPersonnelUser";
            this.txtPersonnelUser.ReadOnly = true;
            this.txtPersonnelUser.Size = new System.Drawing.Size(279, 28);
            this.txtPersonnelUser.TabIndex = 21;
            // 
            // FormCreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(989, 539);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PaneInfosAccount);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCreateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Créer un utilisateur";
            this.PaneInfosAccount.ResumeLayout(false);
            this.PaneInfosAccount.PerformLayout();
            this.PanelInfosIdentityUser.ResumeLayout(false);
            this.PanelInfosIdentityUser.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PaneInfosAccount;
        private System.Windows.Forms.CheckBox CbxActifUser;
        private System.Windows.Forms.CheckBox CbxChangePasswordAtFirstConnexion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel PanelInfosIdentityUser;
        public System.Windows.Forms.TextBox TxtConfirmPassword;
        public System.Windows.Forms.TextBox TxtPasswordUser;
        public System.Windows.Forms.TextBox TxtUserName;
        public System.Windows.Forms.TextBox TxtDescriptionUser;
        public System.Windows.Forms.TextBox TxtTelUser;
        public System.Windows.Forms.TextBox TxtMailUser;
        private FontAwesome.Sharp.IconButton BtnValideUser;
        private System.Windows.Forms.TextBox TxtUserCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxRolesUser;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnPersonnelUser;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtPersonnelUser;
    }
}