
namespace GestPark
{
    partial class FormUtilisateur
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
            this.IbtnExporterRole = new FontAwesome.Sharp.IconButton();
            this.IbtnCloseFormUser = new FontAwesome.Sharp.IconButton();
            this.IbtnAddUser = new FontAwesome.Sharp.IconButton();
            this.PaneSearchUser = new System.Windows.Forms.Panel();
            this.IbtnSearchUser = new FontAwesome.Sharp.IconButton();
            this.TxtSearchUser = new System.Windows.Forms.TextBox();
            this.DgvUser = new System.Windows.Forms.DataGridView();
            this.PSEUDO_USERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_USER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL_USERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEL_USERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_ROLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACTIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATECREATE_USERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.PaneSearchUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.IbtnExporterRole);
            this.panel1.Controls.Add(this.IbtnCloseFormUser);
            this.panel1.Controls.Add(this.IbtnAddUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 28);
            this.panel1.TabIndex = 0;
            // 
            // IbtnExporterRole
            // 
            this.IbtnExporterRole.BackColor = System.Drawing.Color.White;
            this.IbtnExporterRole.ForeColor = System.Drawing.Color.DarkGreen;
            this.IbtnExporterRole.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.IbtnExporterRole.IconColor = System.Drawing.Color.DarkGreen;
            this.IbtnExporterRole.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnExporterRole.IconSize = 25;
            this.IbtnExporterRole.Location = new System.Drawing.Point(79, 0);
            this.IbtnExporterRole.Name = "IbtnExporterRole";
            this.IbtnExporterRole.Size = new System.Drawing.Size(84, 28);
            this.IbtnExporterRole.TabIndex = 2;
            this.IbtnExporterRole.Text = "Exporter";
            this.IbtnExporterRole.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IbtnExporterRole.UseVisualStyleBackColor = false;
            // 
            // IbtnCloseFormUser
            // 
            this.IbtnCloseFormUser.BackColor = System.Drawing.Color.White;
            this.IbtnCloseFormUser.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.IbtnCloseFormUser.IconColor = System.Drawing.Color.Red;
            this.IbtnCloseFormUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnCloseFormUser.IconSize = 25;
            this.IbtnCloseFormUser.Location = new System.Drawing.Point(1083, 0);
            this.IbtnCloseFormUser.Name = "IbtnCloseFormUser";
            this.IbtnCloseFormUser.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.IbtnCloseFormUser.Size = new System.Drawing.Size(35, 28);
            this.IbtnCloseFormUser.TabIndex = 1;
            this.IbtnCloseFormUser.UseVisualStyleBackColor = false;
            this.IbtnCloseFormUser.Click += new System.EventHandler(this.IbtnCloseFormUser_Click);
            // 
            // IbtnAddUser
            // 
            this.IbtnAddUser.BackColor = System.Drawing.Color.White;
            this.IbtnAddUser.ForeColor = System.Drawing.Color.DarkGreen;
            this.IbtnAddUser.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.IbtnAddUser.IconColor = System.Drawing.Color.DarkGreen;
            this.IbtnAddUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnAddUser.IconSize = 25;
            this.IbtnAddUser.Location = new System.Drawing.Point(0, 0);
            this.IbtnAddUser.Name = "IbtnAddUser";
            this.IbtnAddUser.Size = new System.Drawing.Size(82, 28);
            this.IbtnAddUser.TabIndex = 0;
            this.IbtnAddUser.Text = "Ajouter";
            this.IbtnAddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IbtnAddUser.UseVisualStyleBackColor = false;
            this.IbtnAddUser.Click += new System.EventHandler(this.IbtnAddUser_Click);
            // 
            // PaneSearchUser
            // 
            this.PaneSearchUser.AutoScroll = true;
            this.PaneSearchUser.BackColor = System.Drawing.Color.DarkOrange;
            this.PaneSearchUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PaneSearchUser.Controls.Add(this.IbtnSearchUser);
            this.PaneSearchUser.Controls.Add(this.TxtSearchUser);
            this.PaneSearchUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.PaneSearchUser.Location = new System.Drawing.Point(0, 28);
            this.PaneSearchUser.Name = "PaneSearchUser";
            this.PaneSearchUser.Size = new System.Drawing.Size(1118, 104);
            this.PaneSearchUser.TabIndex = 1;
            // 
            // IbtnSearchUser
            // 
            this.IbtnSearchUser.BackColor = System.Drawing.Color.White;
            this.IbtnSearchUser.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.IbtnSearchUser.IconColor = System.Drawing.Color.DarkGreen;
            this.IbtnSearchUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnSearchUser.IconSize = 20;
            this.IbtnSearchUser.Location = new System.Drawing.Point(907, 43);
            this.IbtnSearchUser.Name = "IbtnSearchUser";
            this.IbtnSearchUser.Size = new System.Drawing.Size(38, 23);
            this.IbtnSearchUser.TabIndex = 1;
            this.IbtnSearchUser.UseVisualStyleBackColor = false;
            this.IbtnSearchUser.Click += new System.EventHandler(this.IbtnSearchUser_Click);
            // 
            // TxtSearchUser
            // 
            this.TxtSearchUser.Location = new System.Drawing.Point(585, 43);
            this.TxtSearchUser.Name = "TxtSearchUser";
            this.TxtSearchUser.Size = new System.Drawing.Size(315, 22);
            this.TxtSearchUser.TabIndex = 0;
            // 
            // DgvUser
            // 
            this.DgvUser.AllowUserToOrderColumns = true;
            this.DgvUser.BackgroundColor = System.Drawing.Color.White;
            this.DgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PSEUDO_USERS,
            this.DESCRIPTION_USER,
            this.EMAIL_USERS,
            this.TEL_USERS,
            this.ID_ROLE,
            this.ACTIF,
            this.DATECREATE_USERS});
            this.DgvUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvUser.GridColor = System.Drawing.Color.Gainsboro;
            this.DgvUser.Location = new System.Drawing.Point(0, 132);
            this.DgvUser.Name = "DgvUser";
            this.DgvUser.Size = new System.Drawing.Size(1118, 599);
            this.DgvUser.TabIndex = 2;
            this.DgvUser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUser_CellDoubleClick);
            // 
            // PSEUDO_USERS
            // 
            this.PSEUDO_USERS.DataPropertyName = "PSEUDO_USERS";
            this.PSEUDO_USERS.HeaderText = "Utilisateur";
            this.PSEUDO_USERS.Name = "PSEUDO_USERS";
            this.PSEUDO_USERS.ReadOnly = true;
            // 
            // DESCRIPTION_USER
            // 
            this.DESCRIPTION_USER.DataPropertyName = "DESCRIPTION_USER";
            this.DESCRIPTION_USER.HeaderText = "Description";
            this.DESCRIPTION_USER.Name = "DESCRIPTION_USER";
            this.DESCRIPTION_USER.ReadOnly = true;
            this.DESCRIPTION_USER.Width = 200;
            // 
            // EMAIL_USERS
            // 
            this.EMAIL_USERS.DataPropertyName = "EMAIL_USERS";
            this.EMAIL_USERS.HeaderText = "Mail";
            this.EMAIL_USERS.Name = "EMAIL_USERS";
            this.EMAIL_USERS.ReadOnly = true;
            this.EMAIL_USERS.Width = 250;
            // 
            // TEL_USERS
            // 
            this.TEL_USERS.DataPropertyName = "TEL_USERS";
            this.TEL_USERS.HeaderText = "Tél.";
            this.TEL_USERS.Name = "TEL_USERS";
            this.TEL_USERS.ReadOnly = true;
            this.TEL_USERS.Width = 150;
            // 
            // ID_ROLE
            // 
            this.ID_ROLE.DataPropertyName = "ID_ROLE";
            this.ID_ROLE.HeaderText = "Rôles";
            this.ID_ROLE.Name = "ID_ROLE";
            this.ID_ROLE.ReadOnly = true;
            this.ID_ROLE.Width = 200;
            // 
            // ACTIF
            // 
            this.ACTIF.DataPropertyName = "ACTIF";
            this.ACTIF.HeaderText = "Statut";
            this.ACTIF.Name = "ACTIF";
            this.ACTIF.ReadOnly = true;
            // 
            // DATECREATE_USERS
            // 
            this.DATECREATE_USERS.DataPropertyName = "DATECREATE_USERS";
            this.DATECREATE_USERS.HeaderText = "Créer le";
            this.DATECREATE_USERS.Name = "DATECREATE_USERS";
            this.DATECREATE_USERS.ReadOnly = true;
            this.DATECREATE_USERS.Width = 150;
            // 
            // FormUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 731);
            this.Controls.Add(this.DgvUser);
            this.Controls.Add(this.PaneSearchUser);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUtilisateur";
            this.Text = "Utilisateur";
            this.panel1.ResumeLayout(false);
            this.PaneSearchUser.ResumeLayout(false);
            this.PaneSearchUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton IbtnAddUser;
        private FontAwesome.Sharp.IconButton IbtnCloseFormUser;
        private FontAwesome.Sharp.IconButton IbtnExporterRole;
        private System.Windows.Forms.Panel PaneSearchUser;
        private FontAwesome.Sharp.IconButton IbtnSearchUser;
        private System.Windows.Forms.TextBox TxtSearchUser;
        private System.Windows.Forms.DataGridView DgvUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn PSEUDO_USERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_USER;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL_USERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEL_USERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_ROLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACTIF;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATECREATE_USERS;
    }
}