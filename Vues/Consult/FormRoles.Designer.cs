
namespace GestPark
{
    partial class FormRoles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRoles));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnImportRole = new FontAwesome.Sharp.IconButton();
            this.IbtnExporterRole = new FontAwesome.Sharp.IconButton();
            this.IbtnCloseFormRole = new FontAwesome.Sharp.IconButton();
            this.IbtnAddRole = new FontAwesome.Sharp.IconButton();
            this.PaneSearchUser = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IbtnSearchRole = new FontAwesome.Sharp.IconButton();
            this.TxtSearchRole = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.ID_ROLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE_ROLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_ROLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTE_ROLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODULEADMIN_ROLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODULEPARAM_ROLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODULEGESTPOOL_ROLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODULESUIVIVEHI_ROLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODULETABLBORD_ROLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATECREATE_ROLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERCREATE_ROLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATEMODIFIER_ROLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERMODIFIER_ROLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.PaneSearchUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.BtnImportRole);
            this.panel1.Controls.Add(this.IbtnExporterRole);
            this.panel1.Controls.Add(this.IbtnCloseFormRole);
            this.panel1.Controls.Add(this.IbtnAddRole);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1261, 28);
            this.panel1.TabIndex = 1;
            // 
            // BtnImportRole
            // 
            this.BtnImportRole.BackColor = System.Drawing.Color.White;
            this.BtnImportRole.ForeColor = System.Drawing.Color.Black;
            this.BtnImportRole.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.BtnImportRole.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(147)))), ((int)(((byte)(222)))));
            this.BtnImportRole.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnImportRole.IconSize = 17;
            this.BtnImportRole.Location = new System.Drawing.Point(202, 0);
            this.BtnImportRole.Name = "BtnImportRole";
            this.BtnImportRole.Size = new System.Drawing.Size(96, 26);
            this.BtnImportRole.TabIndex = 3;
            this.BtnImportRole.Text = "Importer";
            this.BtnImportRole.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnImportRole.UseVisualStyleBackColor = false;
            // 
            // IbtnExporterRole
            // 
            this.IbtnExporterRole.BackColor = System.Drawing.Color.White;
            this.IbtnExporterRole.ForeColor = System.Drawing.Color.Black;
            this.IbtnExporterRole.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.IbtnExporterRole.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(13)))));
            this.IbtnExporterRole.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnExporterRole.IconSize = 17;
            this.IbtnExporterRole.Location = new System.Drawing.Point(100, -2);
            this.IbtnExporterRole.Name = "IbtnExporterRole";
            this.IbtnExporterRole.Size = new System.Drawing.Size(96, 29);
            this.IbtnExporterRole.TabIndex = 2;
            this.IbtnExporterRole.Text = "Exporter";
            this.IbtnExporterRole.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IbtnExporterRole.UseVisualStyleBackColor = false;
            // 
            // IbtnCloseFormRole
            // 
            this.IbtnCloseFormRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IbtnCloseFormRole.BackColor = System.Drawing.Color.White;
            this.IbtnCloseFormRole.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.IbtnCloseFormRole.IconColor = System.Drawing.Color.Red;
            this.IbtnCloseFormRole.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnCloseFormRole.IconSize = 15;
            this.IbtnCloseFormRole.Location = new System.Drawing.Point(1231, 0);
            this.IbtnCloseFormRole.Name = "IbtnCloseFormRole";
            this.IbtnCloseFormRole.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.IbtnCloseFormRole.Size = new System.Drawing.Size(26, 26);
            this.IbtnCloseFormRole.TabIndex = 1;
            this.IbtnCloseFormRole.UseVisualStyleBackColor = false;
            this.IbtnCloseFormRole.Click += new System.EventHandler(this.IbtnCloseFormRole_Click);
            // 
            // IbtnAddRole
            // 
            this.IbtnAddRole.BackColor = System.Drawing.Color.White;
            this.IbtnAddRole.ForeColor = System.Drawing.Color.Black;
            this.IbtnAddRole.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.IbtnAddRole.IconColor = System.Drawing.Color.YellowGreen;
            this.IbtnAddRole.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnAddRole.IconSize = 17;
            this.IbtnAddRole.Location = new System.Drawing.Point(-2, -2);
            this.IbtnAddRole.Name = "IbtnAddRole";
            this.IbtnAddRole.Size = new System.Drawing.Size(96, 28);
            this.IbtnAddRole.TabIndex = 0;
            this.IbtnAddRole.Text = "Ajouter";
            this.IbtnAddRole.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IbtnAddRole.UseVisualStyleBackColor = false;
            this.IbtnAddRole.Click += new System.EventHandler(this.IbtnAddRole_Click);
            // 
            // PaneSearchUser
            // 
            this.PaneSearchUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.PaneSearchUser.Controls.Add(this.label2);
            this.PaneSearchUser.Controls.Add(this.label1);
            this.PaneSearchUser.Controls.Add(this.IbtnSearchRole);
            this.PaneSearchUser.Controls.Add(this.TxtSearchRole);
            this.PaneSearchUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.PaneSearchUser.Location = new System.Drawing.Point(0, 28);
            this.PaneSearchUser.Name = "PaneSearchUser";
            this.PaneSearchUser.Size = new System.Drawing.Size(1261, 192);
            this.PaneSearchUser.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(749, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rechercher";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(450, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Recherche multi-critère";
            // 
            // IbtnSearchRole
            // 
            this.IbtnSearchRole.BackColor = System.Drawing.Color.White;
            this.IbtnSearchRole.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.IbtnSearchRole.IconColor = System.Drawing.Color.YellowGreen;
            this.IbtnSearchRole.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnSearchRole.IconSize = 20;
            this.IbtnSearchRole.Location = new System.Drawing.Point(843, 113);
            this.IbtnSearchRole.Name = "IbtnSearchRole";
            this.IbtnSearchRole.Size = new System.Drawing.Size(38, 23);
            this.IbtnSearchRole.TabIndex = 1;
            this.IbtnSearchRole.UseVisualStyleBackColor = false;
            this.IbtnSearchRole.Click += new System.EventHandler(this.IbtnSearchRole_Click);
            // 
            // TxtSearchRole
            // 
            this.TxtSearchRole.BackColor = System.Drawing.Color.White;
            this.TxtSearchRole.ForeColor = System.Drawing.Color.Black;
            this.TxtSearchRole.Location = new System.Drawing.Point(630, 53);
            this.TxtSearchRole.Name = "TxtSearchRole";
            this.TxtSearchRole.Size = new System.Drawing.Size(251, 26);
            this.TxtSearchRole.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 220);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1261, 20);
            this.panel2.TabIndex = 3;
            // 
            // dgvRoles
            // 
            this.dgvRoles.AllowUserToDeleteRows = false;
            this.dgvRoles.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvRoles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRoles.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_ROLE,
            this.CODE_ROLE,
            this.DESCRIPTION_ROLE,
            this.NOTE_ROLE,
            this.MODULEADMIN_ROLE,
            this.MODULEPARAM_ROLE,
            this.MODULEGESTPOOL_ROLE,
            this.MODULESUIVIVEHI_ROLE,
            this.MODULETABLBORD_ROLE,
            this.DATECREATE_ROLE,
            this.USERCREATE_ROLE,
            this.DATEMODIFIER_ROLE,
            this.USERMODIFIER_ROLE});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoles.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoles.GridColor = System.Drawing.Color.White;
            this.dgvRoles.Location = new System.Drawing.Point(0, 240);
            this.dgvRoles.Name = "dgvRoles";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoles.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvRoles.RowHeadersWidth = 51;
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            this.dgvRoles.RowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvRoles.Size = new System.Drawing.Size(1261, 437);
            this.dgvRoles.TabIndex = 4;
            this.dgvRoles.DoubleClick += new System.EventHandler(this.dgvRoles_DoubleClick);
            // 
            // ID_ROLE
            // 
            this.ID_ROLE.DataPropertyName = "ID_ROLE";
            this.ID_ROLE.HeaderText = "IdRole";
            this.ID_ROLE.MinimumWidth = 6;
            this.ID_ROLE.Name = "ID_ROLE";
            this.ID_ROLE.ReadOnly = true;
            this.ID_ROLE.Visible = false;
            this.ID_ROLE.Width = 125;
            // 
            // CODE_ROLE
            // 
            this.CODE_ROLE.DataPropertyName = "CODE_ROLE";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CODE_ROLE.DefaultCellStyle = dataGridViewCellStyle3;
            this.CODE_ROLE.HeaderText = "Code";
            this.CODE_ROLE.MinimumWidth = 6;
            this.CODE_ROLE.Name = "CODE_ROLE";
            this.CODE_ROLE.ReadOnly = true;
            this.CODE_ROLE.Width = 125;
            // 
            // DESCRIPTION_ROLE
            // 
            this.DESCRIPTION_ROLE.DataPropertyName = "DESCRIPTION_ROLE";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DESCRIPTION_ROLE.DefaultCellStyle = dataGridViewCellStyle4;
            this.DESCRIPTION_ROLE.HeaderText = "Description";
            this.DESCRIPTION_ROLE.MinimumWidth = 6;
            this.DESCRIPTION_ROLE.Name = "DESCRIPTION_ROLE";
            this.DESCRIPTION_ROLE.ReadOnly = true;
            this.DESCRIPTION_ROLE.Width = 125;
            // 
            // NOTE_ROLE
            // 
            this.NOTE_ROLE.DataPropertyName = "NOTE_ROLE";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.NOTE_ROLE.DefaultCellStyle = dataGridViewCellStyle5;
            this.NOTE_ROLE.HeaderText = "Note";
            this.NOTE_ROLE.MinimumWidth = 6;
            this.NOTE_ROLE.Name = "NOTE_ROLE";
            this.NOTE_ROLE.ReadOnly = true;
            this.NOTE_ROLE.Width = 125;
            // 
            // MODULEADMIN_ROLE
            // 
            this.MODULEADMIN_ROLE.DataPropertyName = "MODULEADMIN_ROLE";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MODULEADMIN_ROLE.DefaultCellStyle = dataGridViewCellStyle6;
            this.MODULEADMIN_ROLE.HeaderText = "Module Administration";
            this.MODULEADMIN_ROLE.MinimumWidth = 6;
            this.MODULEADMIN_ROLE.Name = "MODULEADMIN_ROLE";
            this.MODULEADMIN_ROLE.ReadOnly = true;
            this.MODULEADMIN_ROLE.Width = 200;
            // 
            // MODULEPARAM_ROLE
            // 
            this.MODULEPARAM_ROLE.DataPropertyName = "MODULEPARAM_ROLE";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MODULEPARAM_ROLE.DefaultCellStyle = dataGridViewCellStyle7;
            this.MODULEPARAM_ROLE.HeaderText = "Module paramètres";
            this.MODULEPARAM_ROLE.MinimumWidth = 6;
            this.MODULEPARAM_ROLE.Name = "MODULEPARAM_ROLE";
            this.MODULEPARAM_ROLE.ReadOnly = true;
            this.MODULEPARAM_ROLE.Width = 200;
            // 
            // MODULEGESTPOOL_ROLE
            // 
            this.MODULEGESTPOOL_ROLE.DataPropertyName = "MODULEGESTPOOL_ROLE";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MODULEGESTPOOL_ROLE.DefaultCellStyle = dataGridViewCellStyle8;
            this.MODULEGESTPOOL_ROLE.HeaderText = "Module gest. vehi. pool";
            this.MODULEGESTPOOL_ROLE.MinimumWidth = 6;
            this.MODULEGESTPOOL_ROLE.Name = "MODULEGESTPOOL_ROLE";
            this.MODULEGESTPOOL_ROLE.ReadOnly = true;
            this.MODULEGESTPOOL_ROLE.Width = 250;
            // 
            // MODULESUIVIVEHI_ROLE
            // 
            this.MODULESUIVIVEHI_ROLE.DataPropertyName = "MODULESUIVIVEHI_ROLE";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MODULESUIVIVEHI_ROLE.DefaultCellStyle = dataGridViewCellStyle9;
            this.MODULESUIVIVEHI_ROLE.HeaderText = "Module Suivi de vehi.";
            this.MODULESUIVIVEHI_ROLE.MinimumWidth = 6;
            this.MODULESUIVIVEHI_ROLE.Name = "MODULESUIVIVEHI_ROLE";
            this.MODULESUIVIVEHI_ROLE.ReadOnly = true;
            this.MODULESUIVIVEHI_ROLE.Width = 200;
            // 
            // MODULETABLBORD_ROLE
            // 
            this.MODULETABLBORD_ROLE.DataPropertyName = "MODULETABLBORD_ROLE";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MODULETABLBORD_ROLE.DefaultCellStyle = dataGridViewCellStyle10;
            this.MODULETABLBORD_ROLE.HeaderText = "Module tabl. bord";
            this.MODULETABLBORD_ROLE.MinimumWidth = 6;
            this.MODULETABLBORD_ROLE.Name = "MODULETABLBORD_ROLE";
            this.MODULETABLBORD_ROLE.ReadOnly = true;
            this.MODULETABLBORD_ROLE.Width = 200;
            // 
            // DATECREATE_ROLE
            // 
            this.DATECREATE_ROLE.DataPropertyName = "DATECREATE_ROLE";
            this.DATECREATE_ROLE.HeaderText = "Créer le ";
            this.DATECREATE_ROLE.MinimumWidth = 6;
            this.DATECREATE_ROLE.Name = "DATECREATE_ROLE";
            this.DATECREATE_ROLE.ReadOnly = true;
            this.DATECREATE_ROLE.Width = 125;
            // 
            // USERCREATE_ROLE
            // 
            this.USERCREATE_ROLE.DataPropertyName = "USERCREATE_ROLE";
            this.USERCREATE_ROLE.HeaderText = "Créer par";
            this.USERCREATE_ROLE.MinimumWidth = 6;
            this.USERCREATE_ROLE.Name = "USERCREATE_ROLE";
            this.USERCREATE_ROLE.ReadOnly = true;
            this.USERCREATE_ROLE.Width = 125;
            // 
            // DATEMODIFIER_ROLE
            // 
            this.DATEMODIFIER_ROLE.DataPropertyName = "DATEMODIFIER_ROLE";
            this.DATEMODIFIER_ROLE.HeaderText = "Modifier le";
            this.DATEMODIFIER_ROLE.MinimumWidth = 6;
            this.DATEMODIFIER_ROLE.Name = "DATEMODIFIER_ROLE";
            this.DATEMODIFIER_ROLE.ReadOnly = true;
            this.DATEMODIFIER_ROLE.Width = 150;
            // 
            // USERMODIFIER_ROLE
            // 
            this.USERMODIFIER_ROLE.DataPropertyName = "USERMODIFIER_ROLE";
            this.USERMODIFIER_ROLE.HeaderText = "Modifier par";
            this.USERMODIFIER_ROLE.MinimumWidth = 50;
            this.USERMODIFIER_ROLE.Name = "USERMODIFIER_ROLE";
            this.USERMODIFIER_ROLE.ReadOnly = true;
            this.USERMODIFIER_ROLE.Width = 150;
            // 
            // FormRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1261, 677);
            this.Controls.Add(this.dgvRoles);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PaneSearchUser);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRoles";
            this.Text = "FormRoles";
            this.panel1.ResumeLayout(false);
            this.PaneSearchUser.ResumeLayout(false);
            this.PaneSearchUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton IbtnExporterRole;
        private FontAwesome.Sharp.IconButton IbtnCloseFormRole;
        private FontAwesome.Sharp.IconButton IbtnAddRole;
        private System.Windows.Forms.Panel PaneSearchUser;
        private FontAwesome.Sharp.IconButton IbtnSearchRole;
        private System.Windows.Forms.TextBox TxtSearchRole;
        private FontAwesome.Sharp.IconButton BtnImportRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_ROLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_ROLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_ROLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTE_ROLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODULEADMIN_ROLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODULEPARAM_ROLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODULEGESTPOOL_ROLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODULESUIVIVEHI_ROLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODULETABLBORD_ROLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATECREATE_ROLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERCREATE_ROLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATEMODIFIER_ROLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERMODIFIER_ROLE;
    }
}