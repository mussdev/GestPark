
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.IbtnExporterRole = new FontAwesome.Sharp.IconButton();
            this.IbtnCloseFormRole = new FontAwesome.Sharp.IconButton();
            this.IbtnAddRole = new FontAwesome.Sharp.IconButton();
            this.PaneSearchUser = new System.Windows.Forms.Panel();
            this.IbtnSearchRole = new FontAwesome.Sharp.IconButton();
            this.TxtSearchRole = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.PaneSearchUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.IbtnExporterRole);
            this.panel1.Controls.Add(this.IbtnCloseFormRole);
            this.panel1.Controls.Add(this.IbtnAddRole);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 28);
            this.panel1.TabIndex = 1;
            // 
            // IbtnExporterRole
            // 
            this.IbtnExporterRole.BackColor = System.Drawing.Color.White;
            this.IbtnExporterRole.ForeColor = System.Drawing.Color.DarkGreen;
            this.IbtnExporterRole.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.IbtnExporterRole.IconColor = System.Drawing.Color.DarkGreen;
            this.IbtnExporterRole.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnExporterRole.IconSize = 25;
            this.IbtnExporterRole.Location = new System.Drawing.Point(88, -2);
            this.IbtnExporterRole.Name = "IbtnExporterRole";
            this.IbtnExporterRole.Size = new System.Drawing.Size(84, 28);
            this.IbtnExporterRole.TabIndex = 2;
            this.IbtnExporterRole.Text = "Exporter";
            this.IbtnExporterRole.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IbtnExporterRole.UseVisualStyleBackColor = false;
            // 
            // IbtnCloseFormRole
            // 
            this.IbtnCloseFormRole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IbtnCloseFormRole.BackColor = System.Drawing.Color.White;
            this.IbtnCloseFormRole.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.IbtnCloseFormRole.IconColor = System.Drawing.Color.Red;
            this.IbtnCloseFormRole.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnCloseFormRole.IconSize = 25;
            this.IbtnCloseFormRole.Location = new System.Drawing.Point(1083, 0);
            this.IbtnCloseFormRole.Name = "IbtnCloseFormRole";
            this.IbtnCloseFormRole.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.IbtnCloseFormRole.Size = new System.Drawing.Size(31, 26);
            this.IbtnCloseFormRole.TabIndex = 1;
            this.IbtnCloseFormRole.UseVisualStyleBackColor = false;
            this.IbtnCloseFormRole.Click += new System.EventHandler(this.IbtnCloseFormRole_Click);
            // 
            // IbtnAddRole
            // 
            this.IbtnAddRole.BackColor = System.Drawing.Color.White;
            this.IbtnAddRole.ForeColor = System.Drawing.Color.DarkGreen;
            this.IbtnAddRole.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.IbtnAddRole.IconColor = System.Drawing.Color.DarkGreen;
            this.IbtnAddRole.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnAddRole.IconSize = 25;
            this.IbtnAddRole.Location = new System.Drawing.Point(-2, -2);
            this.IbtnAddRole.Name = "IbtnAddRole";
            this.IbtnAddRole.Size = new System.Drawing.Size(84, 28);
            this.IbtnAddRole.TabIndex = 0;
            this.IbtnAddRole.Text = "Ajouter";
            this.IbtnAddRole.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IbtnAddRole.UseVisualStyleBackColor = false;
            // 
            // PaneSearchUser
            // 
            this.PaneSearchUser.BackColor = System.Drawing.Color.Khaki;
            this.PaneSearchUser.Controls.Add(this.IbtnSearchRole);
            this.PaneSearchUser.Controls.Add(this.TxtSearchRole);
            this.PaneSearchUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.PaneSearchUser.Location = new System.Drawing.Point(0, 28);
            this.PaneSearchUser.Name = "PaneSearchUser";
            this.PaneSearchUser.Size = new System.Drawing.Size(1118, 113);
            this.PaneSearchUser.TabIndex = 2;
            // 
            // IbtnSearchRole
            // 
            this.IbtnSearchRole.BackColor = System.Drawing.Color.White;
            this.IbtnSearchRole.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.IbtnSearchRole.IconColor = System.Drawing.Color.DarkGreen;
            this.IbtnSearchRole.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnSearchRole.IconSize = 20;
            this.IbtnSearchRole.Location = new System.Drawing.Point(888, 53);
            this.IbtnSearchRole.Name = "IbtnSearchRole";
            this.IbtnSearchRole.Size = new System.Drawing.Size(38, 23);
            this.IbtnSearchRole.TabIndex = 1;
            this.IbtnSearchRole.UseVisualStyleBackColor = false;
            // 
            // TxtSearchRole
            // 
            this.TxtSearchRole.Location = new System.Drawing.Point(566, 53);
            this.TxtSearchRole.Name = "TxtSearchRole";
            this.TxtSearchRole.Size = new System.Drawing.Size(315, 22);
            this.TxtSearchRole.TabIndex = 0;
            // 
            // FormRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 731);
            this.Controls.Add(this.PaneSearchUser);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRoles";
            this.Text = "FormRoles";
            this.panel1.ResumeLayout(false);
            this.PaneSearchUser.ResumeLayout(false);
            this.PaneSearchUser.PerformLayout();
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
    }
}