
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUtilisateur));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnImportUser = new FontAwesome.Sharp.IconButton();
            this.IbtnExporterUser = new FontAwesome.Sharp.IconButton();
            this.IbtnCloseFormUser = new FontAwesome.Sharp.IconButton();
            this.IbtnAddUser = new FontAwesome.Sharp.IconButton();
            this.PaneSearchUser = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IbtnSearchUser = new FontAwesome.Sharp.IconButton();
            this.TxtSearchUser = new System.Windows.Forms.TextBox();
            this.DgvUser = new System.Windows.Forms.DataGridView();
            this.CODE_USER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PSEUDO_USERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_USER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL_USERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEL_USERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_ROLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACTIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATECREATE_USERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTPASS_USERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.PaneSearchUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.BtnImportUser);
            this.panel1.Controls.Add(this.IbtnExporterUser);
            this.panel1.Controls.Add(this.IbtnCloseFormUser);
            this.panel1.Controls.Add(this.IbtnAddUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1235, 27);
            this.panel1.TabIndex = 0;
            // 
            // BtnImportUser
            // 
            this.BtnImportUser.BackColor = System.Drawing.Color.White;
            this.BtnImportUser.ForeColor = System.Drawing.Color.Black;
            this.BtnImportUser.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.BtnImportUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(147)))), ((int)(((byte)(222)))));
            this.BtnImportUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnImportUser.IconSize = 20;
            this.BtnImportUser.Location = new System.Drawing.Point(206, 0);
            this.BtnImportUser.Name = "BtnImportUser";
            this.BtnImportUser.Size = new System.Drawing.Size(100, 25);
            this.BtnImportUser.TabIndex = 3;
            this.BtnImportUser.Text = "Importer";
            this.BtnImportUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnImportUser.UseVisualStyleBackColor = false;
            // 
            // IbtnExporterUser
            // 
            this.IbtnExporterUser.BackColor = System.Drawing.Color.White;
            this.IbtnExporterUser.ForeColor = System.Drawing.Color.Black;
            this.IbtnExporterUser.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.IbtnExporterUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(13)))));
            this.IbtnExporterUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnExporterUser.IconSize = 20;
            this.IbtnExporterUser.Location = new System.Drawing.Point(100, 0);
            this.IbtnExporterUser.Name = "IbtnExporterUser";
            this.IbtnExporterUser.Size = new System.Drawing.Size(100, 25);
            this.IbtnExporterUser.TabIndex = 2;
            this.IbtnExporterUser.Text = "Exporter";
            this.IbtnExporterUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IbtnExporterUser.UseVisualStyleBackColor = false;
            this.IbtnExporterUser.Click += new System.EventHandler(this.IbtnExporterUser_Click);
            // 
            // IbtnCloseFormUser
            // 
            this.IbtnCloseFormUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.IbtnCloseFormUser.BackColor = System.Drawing.Color.White;
            this.IbtnCloseFormUser.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.IbtnCloseFormUser.IconColor = System.Drawing.Color.Red;
            this.IbtnCloseFormUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnCloseFormUser.IconSize = 20;
            this.IbtnCloseFormUser.Location = new System.Drawing.Point(1196, -2);
            this.IbtnCloseFormUser.Name = "IbtnCloseFormUser";
            this.IbtnCloseFormUser.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.IbtnCloseFormUser.Size = new System.Drawing.Size(35, 27);
            this.IbtnCloseFormUser.TabIndex = 1;
            this.IbtnCloseFormUser.UseVisualStyleBackColor = false;
            this.IbtnCloseFormUser.Click += new System.EventHandler(this.IbtnCloseFormUser_Click);
            // 
            // IbtnAddUser
            // 
            this.IbtnAddUser.BackColor = System.Drawing.Color.White;
            this.IbtnAddUser.ForeColor = System.Drawing.Color.Black;
            this.IbtnAddUser.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.IbtnAddUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.IbtnAddUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnAddUser.IconSize = 20;
            this.IbtnAddUser.Location = new System.Drawing.Point(-2, -2);
            this.IbtnAddUser.Name = "IbtnAddUser";
            this.IbtnAddUser.Size = new System.Drawing.Size(96, 27);
            this.IbtnAddUser.TabIndex = 0;
            this.IbtnAddUser.Text = "Ajouter";
            this.IbtnAddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IbtnAddUser.UseVisualStyleBackColor = false;
            this.IbtnAddUser.Click += new System.EventHandler(this.IbtnAddUser_Click);
            // 
            // PaneSearchUser
            // 
            this.PaneSearchUser.AutoScroll = true;
            this.PaneSearchUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.PaneSearchUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PaneSearchUser.Controls.Add(this.label2);
            this.PaneSearchUser.Controls.Add(this.label1);
            this.PaneSearchUser.Controls.Add(this.IbtnSearchUser);
            this.PaneSearchUser.Controls.Add(this.TxtSearchUser);
            this.PaneSearchUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.PaneSearchUser.Location = new System.Drawing.Point(0, 27);
            this.PaneSearchUser.Name = "PaneSearchUser";
            this.PaneSearchUser.Size = new System.Drawing.Size(1235, 180);
            this.PaneSearchUser.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(768, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rechercher";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(445, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rech. multicritère";
            // 
            // IbtnSearchUser
            // 
            this.IbtnSearchUser.BackColor = System.Drawing.Color.White;
            this.IbtnSearchUser.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.IbtnSearchUser.IconColor = System.Drawing.Color.DarkGreen;
            this.IbtnSearchUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnSearchUser.IconSize = 20;
            this.IbtnSearchUser.Location = new System.Drawing.Point(862, 108);
            this.IbtnSearchUser.Name = "IbtnSearchUser";
            this.IbtnSearchUser.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.IbtnSearchUser.Size = new System.Drawing.Size(38, 26);
            this.IbtnSearchUser.TabIndex = 1;
            this.IbtnSearchUser.UseVisualStyleBackColor = false;
            this.IbtnSearchUser.Click += new System.EventHandler(this.IbtnSearchUser_Click);
            // 
            // TxtSearchUser
            // 
            this.TxtSearchUser.BackColor = System.Drawing.Color.White;
            this.TxtSearchUser.Location = new System.Drawing.Point(585, 43);
            this.TxtSearchUser.Name = "TxtSearchUser";
            this.TxtSearchUser.Size = new System.Drawing.Size(315, 26);
            this.TxtSearchUser.TabIndex = 0;
            // 
            // DgvUser
            // 
            this.DgvUser.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DgvUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvUser.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODE_USER,
            this.PSEUDO_USERS,
            this.DESCRIPTION_USER,
            this.EMAIL_USERS,
            this.TEL_USERS,
            this.DESCRIPTION_ROLE,
            this.ACTIF,
            this.DATECREATE_USERS,
            this.MOTPASS_USERS,
            this.Column3,
            this.Column1,
            this.Column2});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvUser.DefaultCellStyle = dataGridViewCellStyle14;
            this.DgvUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvUser.GridColor = System.Drawing.Color.White;
            this.DgvUser.Location = new System.Drawing.Point(0, 207);
            this.DgvUser.Name = "DgvUser";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.DgvUser.RowHeadersWidth = 51;
            this.DgvUser.Size = new System.Drawing.Size(1235, 421);
            this.DgvUser.TabIndex = 2;
            this.DgvUser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUser_CellDoubleClick);
            // 
            // CODE_USER
            // 
            this.CODE_USER.DataPropertyName = "CODE_USER";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CODE_USER.DefaultCellStyle = dataGridViewCellStyle3;
            this.CODE_USER.Frozen = true;
            this.CODE_USER.HeaderText = "Code";
            this.CODE_USER.MinimumWidth = 6;
            this.CODE_USER.Name = "CODE_USER";
            this.CODE_USER.ReadOnly = true;
            this.CODE_USER.Width = 125;
            // 
            // PSEUDO_USERS
            // 
            this.PSEUDO_USERS.DataPropertyName = "PSEUDO_USERS";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.PSEUDO_USERS.DefaultCellStyle = dataGridViewCellStyle4;
            this.PSEUDO_USERS.Frozen = true;
            this.PSEUDO_USERS.HeaderText = "Utilisateur";
            this.PSEUDO_USERS.MinimumWidth = 6;
            this.PSEUDO_USERS.Name = "PSEUDO_USERS";
            this.PSEUDO_USERS.ReadOnly = true;
            this.PSEUDO_USERS.Width = 125;
            // 
            // DESCRIPTION_USER
            // 
            this.DESCRIPTION_USER.DataPropertyName = "DESCRIPTION_USER";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DESCRIPTION_USER.DefaultCellStyle = dataGridViewCellStyle5;
            this.DESCRIPTION_USER.Frozen = true;
            this.DESCRIPTION_USER.HeaderText = "Description";
            this.DESCRIPTION_USER.MinimumWidth = 6;
            this.DESCRIPTION_USER.Name = "DESCRIPTION_USER";
            this.DESCRIPTION_USER.ReadOnly = true;
            this.DESCRIPTION_USER.Width = 200;
            // 
            // EMAIL_USERS
            // 
            this.EMAIL_USERS.DataPropertyName = "EMAIL_USERS";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.EMAIL_USERS.DefaultCellStyle = dataGridViewCellStyle6;
            this.EMAIL_USERS.Frozen = true;
            this.EMAIL_USERS.HeaderText = "Mail";
            this.EMAIL_USERS.MinimumWidth = 6;
            this.EMAIL_USERS.Name = "EMAIL_USERS";
            this.EMAIL_USERS.ReadOnly = true;
            this.EMAIL_USERS.Width = 250;
            // 
            // TEL_USERS
            // 
            this.TEL_USERS.DataPropertyName = "TEL_USERS";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TEL_USERS.DefaultCellStyle = dataGridViewCellStyle7;
            this.TEL_USERS.Frozen = true;
            this.TEL_USERS.HeaderText = "Tél.";
            this.TEL_USERS.MinimumWidth = 6;
            this.TEL_USERS.Name = "TEL_USERS";
            this.TEL_USERS.ReadOnly = true;
            this.TEL_USERS.Width = 150;
            // 
            // DESCRIPTION_ROLE
            // 
            this.DESCRIPTION_ROLE.DataPropertyName = "DESCRIPTION_ROLE";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DESCRIPTION_ROLE.DefaultCellStyle = dataGridViewCellStyle8;
            this.DESCRIPTION_ROLE.Frozen = true;
            this.DESCRIPTION_ROLE.HeaderText = "Rôles";
            this.DESCRIPTION_ROLE.MinimumWidth = 6;
            this.DESCRIPTION_ROLE.Name = "DESCRIPTION_ROLE";
            this.DESCRIPTION_ROLE.ReadOnly = true;
            this.DESCRIPTION_ROLE.Width = 200;
            // 
            // ACTIF
            // 
            this.ACTIF.DataPropertyName = "ACTIF";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ACTIF.DefaultCellStyle = dataGridViewCellStyle9;
            this.ACTIF.Frozen = true;
            this.ACTIF.HeaderText = "Statut";
            this.ACTIF.MinimumWidth = 6;
            this.ACTIF.Name = "ACTIF";
            this.ACTIF.ReadOnly = true;
            this.ACTIF.Width = 125;
            // 
            // DATECREATE_USERS
            // 
            this.DATECREATE_USERS.DataPropertyName = "DATECREATE_USERS";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DATECREATE_USERS.DefaultCellStyle = dataGridViewCellStyle10;
            this.DATECREATE_USERS.Frozen = true;
            this.DATECREATE_USERS.HeaderText = "Créer le";
            this.DATECREATE_USERS.MinimumWidth = 6;
            this.DATECREATE_USERS.Name = "DATECREATE_USERS";
            this.DATECREATE_USERS.ReadOnly = true;
            this.DATECREATE_USERS.Width = 150;
            // 
            // MOTPASS_USERS
            // 
            this.MOTPASS_USERS.DataPropertyName = "MOTPASS_USERS";
            this.MOTPASS_USERS.Frozen = true;
            this.MOTPASS_USERS.HeaderText = "Mot de passe";
            this.MOTPASS_USERS.MinimumWidth = 6;
            this.MOTPASS_USERS.Name = "MOTPASS_USERS";
            this.MOTPASS_USERS.ReadOnly = true;
            this.MOTPASS_USERS.Visible = false;
            this.MOTPASS_USERS.Width = 125;
            // 
            // Column3
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle11;
            this.Column3.HeaderText = "Créer par";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column1
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle12;
            this.Column1.HeaderText = "Modifier le";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle13;
            this.Column2.HeaderText = "Modifier par";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // FormUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 628);
            this.Controls.Add(this.DgvUser);
            this.Controls.Add(this.PaneSearchUser);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private FontAwesome.Sharp.IconButton IbtnExporterUser;
        private System.Windows.Forms.Panel PaneSearchUser;
        private FontAwesome.Sharp.IconButton IbtnSearchUser;
        private System.Windows.Forms.TextBox TxtSearchUser;
        private System.Windows.Forms.DataGridView DgvUser;
        private FontAwesome.Sharp.IconButton BtnImportUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_USER;
        private System.Windows.Forms.DataGridViewTextBoxColumn PSEUDO_USERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_USER;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL_USERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEL_USERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_ROLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACTIF;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATECREATE_USERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTPASS_USERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}