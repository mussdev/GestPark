
namespace GestPark
{
    partial class FormRepairCar
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
            this.PanelSearchRepairCar = new System.Windows.Forms.Panel();
            this.IbtnSearchRepairCar = new FontAwesome.Sharp.IconButton();
            this.TxtSeachRepairCar = new System.Windows.Forms.TextBox();
            this.IbtnExportRepairCar = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IbtnCloseFanRepairCar = new FontAwesome.Sharp.IconButton();
            this.DgvCarRepair = new System.Windows.Forms.DataGridView();
            this.ID_REPAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE_REPAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_GARAGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_REPAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRIX_REPAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTE_REPAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_REPAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATECREATE_REPAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERCREATE_REPAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelSearchRepairCar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCarRepair)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelSearchRepairCar
            // 
            this.PanelSearchRepairCar.AutoScroll = true;
            this.PanelSearchRepairCar.BackColor = System.Drawing.Color.Khaki;
            this.PanelSearchRepairCar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelSearchRepairCar.Controls.Add(this.IbtnSearchRepairCar);
            this.PanelSearchRepairCar.Controls.Add(this.TxtSeachRepairCar);
            this.PanelSearchRepairCar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSearchRepairCar.Location = new System.Drawing.Point(0, 26);
            this.PanelSearchRepairCar.Name = "PanelSearchRepairCar";
            this.PanelSearchRepairCar.Size = new System.Drawing.Size(1118, 115);
            this.PanelSearchRepairCar.TabIndex = 3;
            // 
            // IbtnSearchRepairCar
            // 
            this.IbtnSearchRepairCar.BackColor = System.Drawing.Color.White;
            this.IbtnSearchRepairCar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.IbtnSearchRepairCar.IconColor = System.Drawing.Color.DarkGreen;
            this.IbtnSearchRepairCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnSearchRepairCar.IconSize = 20;
            this.IbtnSearchRepairCar.Location = new System.Drawing.Point(868, 38);
            this.IbtnSearchRepairCar.Name = "IbtnSearchRepairCar";
            this.IbtnSearchRepairCar.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.IbtnSearchRepairCar.Size = new System.Drawing.Size(34, 24);
            this.IbtnSearchRepairCar.TabIndex = 4;
            this.IbtnSearchRepairCar.UseVisualStyleBackColor = false;
            this.IbtnSearchRepairCar.Click += new System.EventHandler(this.IbtnSearchRepairCar_Click);
            // 
            // TxtSeachRepairCar
            // 
            this.TxtSeachRepairCar.Location = new System.Drawing.Point(607, 38);
            this.TxtSeachRepairCar.Name = "TxtSeachRepairCar";
            this.TxtSeachRepairCar.Size = new System.Drawing.Size(255, 22);
            this.TxtSeachRepairCar.TabIndex = 3;
            // 
            // IbtnExportRepairCar
            // 
            this.IbtnExportRepairCar.BackColor = System.Drawing.Color.White;
            this.IbtnExportRepairCar.ForeColor = System.Drawing.Color.DarkGreen;
            this.IbtnExportRepairCar.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.IbtnExportRepairCar.IconColor = System.Drawing.Color.DarkGreen;
            this.IbtnExportRepairCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnExportRepairCar.IconSize = 20;
            this.IbtnExportRepairCar.Location = new System.Drawing.Point(-2, -1);
            this.IbtnExportRepairCar.Name = "IbtnExportRepairCar";
            this.IbtnExportRepairCar.Size = new System.Drawing.Size(93, 25);
            this.IbtnExportRepairCar.TabIndex = 5;
            this.IbtnExportRepairCar.Text = "Exporter";
            this.IbtnExportRepairCar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IbtnExportRepairCar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.IbtnExportRepairCar);
            this.panel1.Controls.Add(this.IbtnCloseFanRepairCar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 26);
            this.panel1.TabIndex = 2;
            // 
            // IbtnCloseFanRepairCar
            // 
            this.IbtnCloseFanRepairCar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IbtnCloseFanRepairCar.BackColor = System.Drawing.Color.White;
            this.IbtnCloseFanRepairCar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.IbtnCloseFanRepairCar.IconColor = System.Drawing.Color.Red;
            this.IbtnCloseFanRepairCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnCloseFanRepairCar.IconSize = 20;
            this.IbtnCloseFanRepairCar.Location = new System.Drawing.Point(1084, -2);
            this.IbtnCloseFanRepairCar.Name = "IbtnCloseFanRepairCar";
            this.IbtnCloseFanRepairCar.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.IbtnCloseFanRepairCar.Size = new System.Drawing.Size(30, 24);
            this.IbtnCloseFanRepairCar.TabIndex = 5;
            this.IbtnCloseFanRepairCar.UseVisualStyleBackColor = false;
            this.IbtnCloseFanRepairCar.Click += new System.EventHandler(this.IbtnCloseFanRepairCar_Click);
            // 
            // DgvCarRepair
            // 
            this.DgvCarRepair.AllowUserToOrderColumns = true;
            this.DgvCarRepair.BackgroundColor = System.Drawing.Color.Khaki;
            this.DgvCarRepair.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCarRepair.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_REPAR,
            this.CODE_REPAR,
            this.ID_PAN,
            this.ID_GARAGE,
            this.DESCRIPTION_REPAR,
            this.PRIX_REPAR,
            this.NOTE_REPAR,
            this.DATE_REPAR,
            this.DATECREATE_REPAR,
            this.USERCREATE_REPAR});
            this.DgvCarRepair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvCarRepair.Location = new System.Drawing.Point(0, 141);
            this.DgvCarRepair.Name = "DgvCarRepair";
            this.DgvCarRepair.Size = new System.Drawing.Size(1118, 590);
            this.DgvCarRepair.TabIndex = 4;
            // 
            // ID_REPAR
            // 
            this.ID_REPAR.HeaderText = "Num";
            this.ID_REPAR.Name = "ID_REPAR";
            this.ID_REPAR.ReadOnly = true;
            this.ID_REPAR.Width = 50;
            // 
            // CODE_REPAR
            // 
            this.CODE_REPAR.HeaderText = "Code";
            this.CODE_REPAR.Name = "CODE_REPAR";
            this.CODE_REPAR.ReadOnly = true;
            // 
            // ID_PAN
            // 
            this.ID_PAN.HeaderText = "Description pan.";
            this.ID_PAN.Name = "ID_PAN";
            this.ID_PAN.ReadOnly = true;
            this.ID_PAN.Width = 250;
            // 
            // ID_GARAGE
            // 
            this.ID_GARAGE.HeaderText = "Garage";
            this.ID_GARAGE.Name = "ID_GARAGE";
            this.ID_GARAGE.ReadOnly = true;
            // 
            // DESCRIPTION_REPAR
            // 
            this.DESCRIPTION_REPAR.HeaderText = "Description rep.";
            this.DESCRIPTION_REPAR.Name = "DESCRIPTION_REPAR";
            this.DESCRIPTION_REPAR.ReadOnly = true;
            this.DESCRIPTION_REPAR.Width = 250;
            // 
            // PRIX_REPAR
            // 
            this.PRIX_REPAR.HeaderText = "Prix";
            this.PRIX_REPAR.Name = "PRIX_REPAR";
            this.PRIX_REPAR.ReadOnly = true;
            // 
            // NOTE_REPAR
            // 
            this.NOTE_REPAR.HeaderText = "Note";
            this.NOTE_REPAR.Name = "NOTE_REPAR";
            this.NOTE_REPAR.ReadOnly = true;
            // 
            // DATE_REPAR
            // 
            this.DATE_REPAR.HeaderText = "Reparér le";
            this.DATE_REPAR.Name = "DATE_REPAR";
            this.DATE_REPAR.ReadOnly = true;
            // 
            // DATECREATE_REPAR
            // 
            this.DATECREATE_REPAR.HeaderText = "Créer le";
            this.DATECREATE_REPAR.Name = "DATECREATE_REPAR";
            this.DATECREATE_REPAR.ReadOnly = true;
            // 
            // USERCREATE_REPAR
            // 
            this.USERCREATE_REPAR.HeaderText = "Créer par";
            this.USERCREATE_REPAR.Name = "USERCREATE_REPAR";
            this.USERCREATE_REPAR.ReadOnly = true;
            // 
            // FormRepairCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1118, 731);
            this.Controls.Add(this.DgvCarRepair);
            this.Controls.Add(this.PanelSearchRepairCar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRepairCar";
            this.Text = "FormRepairCar";
            this.PanelSearchRepairCar.ResumeLayout(false);
            this.PanelSearchRepairCar.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCarRepair)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSearchRepairCar;
        private FontAwesome.Sharp.IconButton IbtnExportRepairCar;
        private FontAwesome.Sharp.IconButton IbtnSearchRepairCar;
        private System.Windows.Forms.TextBox TxtSeachRepairCar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DgvCarRepair;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_REPAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_REPAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_GARAGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_REPAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRIX_REPAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTE_REPAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_REPAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATECREATE_REPAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERCREATE_REPAR;
        private FontAwesome.Sharp.IconButton IbtnCloseFanRepairCar;
    }
}