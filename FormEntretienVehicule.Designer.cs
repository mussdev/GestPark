
namespace GestPark
{
    partial class FormEntretienVehicule
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
            this.panelTitleEntretien = new System.Windows.Forms.Panel();
            this.BtnExportCarEntretien = new FontAwesome.Sharp.IconButton();
            this.iconBtnCloseFormEntretien = new FontAwesome.Sharp.IconButton();
            this.iconBtnCreateEntretien = new FontAwesome.Sharp.IconButton();
            this.panelSearchFormEntretien = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.iconBtnSearchFormEntretien = new FontAwesome.Sharp.IconButton();
            this.TxtSearchEntretienCar = new System.Windows.Forms.TextBox();
            this.DgvEntretien = new System.Windows.Forms.DataGridView();
            this.ID_MAINT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE_MAINT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUT_MAINT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMMATRICULATION_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRIX_MAINT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_MAINT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TYPE_MAINT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATTION_MAINT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTE_MAINT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATECREATE_MAINT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERCREATE_MAINT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATEMODIFIER_MAINT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTitleEntretien.SuspendLayout();
            this.panelSearchFormEntretien.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEntretien)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleEntretien
            // 
            this.panelTitleEntretien.BackColor = System.Drawing.Color.Khaki;
            this.panelTitleEntretien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTitleEntretien.Controls.Add(this.BtnExportCarEntretien);
            this.panelTitleEntretien.Controls.Add(this.iconBtnCloseFormEntretien);
            this.panelTitleEntretien.Controls.Add(this.iconBtnCreateEntretien);
            this.panelTitleEntretien.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleEntretien.Location = new System.Drawing.Point(0, 0);
            this.panelTitleEntretien.Name = "panelTitleEntretien";
            this.panelTitleEntretien.Size = new System.Drawing.Size(1118, 27);
            this.panelTitleEntretien.TabIndex = 0;
            // 
            // BtnExportCarEntretien
            // 
            this.BtnExportCarEntretien.BackColor = System.Drawing.Color.White;
            this.BtnExportCarEntretien.ForeColor = System.Drawing.Color.DarkGreen;
            this.BtnExportCarEntretien.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.BtnExportCarEntretien.IconColor = System.Drawing.Color.DarkGreen;
            this.BtnExportCarEntretien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnExportCarEntretien.IconSize = 20;
            this.BtnExportCarEntretien.Location = new System.Drawing.Point(127, -2);
            this.BtnExportCarEntretien.Name = "BtnExportCarEntretien";
            this.BtnExportCarEntretien.Size = new System.Drawing.Size(96, 27);
            this.BtnExportCarEntretien.TabIndex = 2;
            this.BtnExportCarEntretien.Text = "Exporter";
            this.BtnExportCarEntretien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExportCarEntretien.UseVisualStyleBackColor = false;
            this.BtnExportCarEntretien.Click += new System.EventHandler(this.BtnExportCarEntretien_Click);
            // 
            // iconBtnCloseFormEntretien
            // 
            this.iconBtnCloseFormEntretien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnCloseFormEntretien.BackColor = System.Drawing.Color.White;
            this.iconBtnCloseFormEntretien.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconBtnCloseFormEntretien.IconColor = System.Drawing.Color.Red;
            this.iconBtnCloseFormEntretien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnCloseFormEntretien.IconSize = 20;
            this.iconBtnCloseFormEntretien.Location = new System.Drawing.Point(1085, 0);
            this.iconBtnCloseFormEntretien.Name = "iconBtnCloseFormEntretien";
            this.iconBtnCloseFormEntretien.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.iconBtnCloseFormEntretien.Size = new System.Drawing.Size(29, 23);
            this.iconBtnCloseFormEntretien.TabIndex = 2;
            this.iconBtnCloseFormEntretien.UseVisualStyleBackColor = false;
            this.iconBtnCloseFormEntretien.Click += new System.EventHandler(this.iconBtnCloseFormEntretien_Click_1);
            // 
            // iconBtnCreateEntretien
            // 
            this.iconBtnCreateEntretien.BackColor = System.Drawing.Color.White;
            this.iconBtnCreateEntretien.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnCreateEntretien.ForeColor = System.Drawing.Color.DarkGreen;
            this.iconBtnCreateEntretien.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconBtnCreateEntretien.IconColor = System.Drawing.Color.DarkGreen;
            this.iconBtnCreateEntretien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnCreateEntretien.IconSize = 20;
            this.iconBtnCreateEntretien.Location = new System.Drawing.Point(-2, -2);
            this.iconBtnCreateEntretien.Name = "iconBtnCreateEntretien";
            this.iconBtnCreateEntretien.Size = new System.Drawing.Size(123, 27);
            this.iconBtnCreateEntretien.TabIndex = 0;
            this.iconBtnCreateEntretien.Text = "Saisir entretien";
            this.iconBtnCreateEntretien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnCreateEntretien.UseVisualStyleBackColor = false;
            this.iconBtnCreateEntretien.Click += new System.EventHandler(this.iconBtnCreateEntretien_Click);
            // 
            // panelSearchFormEntretien
            // 
            this.panelSearchFormEntretien.BackColor = System.Drawing.Color.Khaki;
            this.panelSearchFormEntretien.Controls.Add(this.panel1);
            this.panelSearchFormEntretien.Controls.Add(this.label2);
            this.panelSearchFormEntretien.Controls.Add(this.label1);
            this.panelSearchFormEntretien.Controls.Add(this.dateTimePicker2);
            this.panelSearchFormEntretien.Controls.Add(this.dateTimePicker1);
            this.panelSearchFormEntretien.Controls.Add(this.iconBtnSearchFormEntretien);
            this.panelSearchFormEntretien.Controls.Add(this.TxtSearchEntretienCar);
            this.panelSearchFormEntretien.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchFormEntretien.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSearchFormEntretien.Location = new System.Drawing.Point(0, 27);
            this.panelSearchFormEntretien.Name = "panelSearchFormEntretien";
            this.panelSearchFormEntretien.Size = new System.Drawing.Size(1118, 142);
            this.panelSearchFormEntretien.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Location = new System.Drawing.Point(388, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 87);
            this.panel1.TabIndex = 8;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(22, 17);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 19);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Garage";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(22, 58);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(64, 19);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Station";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date début";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(99, 91);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(99, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // iconBtnSearchFormEntretien
            // 
            this.iconBtnSearchFormEntretien.BackColor = System.Drawing.Color.White;
            this.iconBtnSearchFormEntretien.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconBtnSearchFormEntretien.IconColor = System.Drawing.Color.DarkGreen;
            this.iconBtnSearchFormEntretien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnSearchFormEntretien.IconSize = 20;
            this.iconBtnSearchFormEntretien.Location = new System.Drawing.Point(979, 53);
            this.iconBtnSearchFormEntretien.Name = "iconBtnSearchFormEntretien";
            this.iconBtnSearchFormEntretien.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.iconBtnSearchFormEntretien.Size = new System.Drawing.Size(44, 23);
            this.iconBtnSearchFormEntretien.TabIndex = 1;
            this.iconBtnSearchFormEntretien.UseVisualStyleBackColor = false;
            this.iconBtnSearchFormEntretien.Click += new System.EventHandler(this.iconBtnSearchFormEntretien_Click);
            // 
            // TxtSearchEntretienCar
            // 
            this.TxtSearchEntretienCar.Location = new System.Drawing.Point(719, 53);
            this.TxtSearchEntretienCar.Name = "TxtSearchEntretienCar";
            this.TxtSearchEntretienCar.Size = new System.Drawing.Size(254, 22);
            this.TxtSearchEntretienCar.TabIndex = 0;
            // 
            // DgvEntretien
            // 
            this.DgvEntretien.AllowUserToOrderColumns = true;
            this.DgvEntretien.BackgroundColor = System.Drawing.Color.Khaki;
            this.DgvEntretien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEntretien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_MAINT,
            this.CODE_MAINT,
            this.STATUT_MAINT,
            this.IMMATRICULATION_VEHICULE,
            this.Column2,
            this.PRIX_MAINT,
            this.DATE_MAINT,
            this.TYPE_MAINT,
            this.STATTION_MAINT,
            this.NOTE_MAINT,
            this.DATECREATE_MAINT,
            this.USERCREATE_MAINT,
            this.DATEMODIFIER_MAINT});
            this.DgvEntretien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvEntretien.Location = new System.Drawing.Point(0, 169);
            this.DgvEntretien.Name = "DgvEntretien";
            this.DgvEntretien.Size = new System.Drawing.Size(1118, 562);
            this.DgvEntretien.TabIndex = 2;
            this.DgvEntretien.DoubleClick += new System.EventHandler(this.DgvEntretien_DoubleClick);
            // 
            // ID_MAINT
            // 
            this.ID_MAINT.DataPropertyName = "ID_MAINT";
            this.ID_MAINT.HeaderText = "Num";
            this.ID_MAINT.Name = "ID_MAINT";
            this.ID_MAINT.ReadOnly = true;
            // 
            // CODE_MAINT
            // 
            this.CODE_MAINT.DataPropertyName = "CODE_MAINT";
            this.CODE_MAINT.HeaderText = "Code";
            this.CODE_MAINT.Name = "CODE_MAINT";
            this.CODE_MAINT.ReadOnly = true;
            // 
            // STATUT_MAINT
            // 
            this.STATUT_MAINT.DataPropertyName = "STATUT_MAINT";
            this.STATUT_MAINT.HeaderText = "Statut";
            this.STATUT_MAINT.Name = "STATUT_MAINT";
            this.STATUT_MAINT.ReadOnly = true;
            // 
            // IMMATRICULATION_VEHICULE
            // 
            this.IMMATRICULATION_VEHICULE.DataPropertyName = "IMMATRICULATION_VEHICULE";
            this.IMMATRICULATION_VEHICULE.HeaderText = "Immat. véhicule";
            this.IMMATRICULATION_VEHICULE.Name = "IMMATRICULATION_VEHICULE";
            this.IMMATRICULATION_VEHICULE.ReadOnly = true;
            this.IMMATRICULATION_VEHICULE.Width = 250;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Garage";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 250;
            // 
            // PRIX_MAINT
            // 
            this.PRIX_MAINT.DataPropertyName = "PRIX_MAINT";
            this.PRIX_MAINT.HeaderText = "Montant";
            this.PRIX_MAINT.Name = "PRIX_MAINT";
            this.PRIX_MAINT.ReadOnly = true;
            // 
            // DATE_MAINT
            // 
            this.DATE_MAINT.DataPropertyName = "DATE_MAINT";
            this.DATE_MAINT.HeaderText = "Date";
            this.DATE_MAINT.Name = "DATE_MAINT";
            this.DATE_MAINT.ReadOnly = true;
            // 
            // TYPE_MAINT
            // 
            this.TYPE_MAINT.DataPropertyName = "TYPE_MAINT";
            this.TYPE_MAINT.HeaderText = "Type";
            this.TYPE_MAINT.Name = "TYPE_MAINT";
            this.TYPE_MAINT.ReadOnly = true;
            // 
            // STATTION_MAINT
            // 
            this.STATTION_MAINT.HeaderText = "Station";
            this.STATTION_MAINT.Name = "STATTION_MAINT";
            this.STATTION_MAINT.ReadOnly = true;
            this.STATTION_MAINT.Width = 250;
            // 
            // NOTE_MAINT
            // 
            this.NOTE_MAINT.DataPropertyName = "NOTE_MAINT";
            this.NOTE_MAINT.HeaderText = "Note";
            this.NOTE_MAINT.Name = "NOTE_MAINT";
            this.NOTE_MAINT.ReadOnly = true;
            this.NOTE_MAINT.Width = 300;
            // 
            // DATECREATE_MAINT
            // 
            this.DATECREATE_MAINT.DataPropertyName = "DATECREATE_MAINT";
            this.DATECREATE_MAINT.HeaderText = "Créer le";
            this.DATECREATE_MAINT.Name = "DATECREATE_MAINT";
            this.DATECREATE_MAINT.ReadOnly = true;
            // 
            // USERCREATE_MAINT
            // 
            this.USERCREATE_MAINT.DataPropertyName = "USERCREATE_MAINT";
            this.USERCREATE_MAINT.HeaderText = "Créer par";
            this.USERCREATE_MAINT.Name = "USERCREATE_MAINT";
            this.USERCREATE_MAINT.ReadOnly = true;
            // 
            // DATEMODIFIER_MAINT
            // 
            this.DATEMODIFIER_MAINT.DataPropertyName = "DATEMODIFIER_MAINT";
            this.DATEMODIFIER_MAINT.HeaderText = "Modifier le";
            this.DATEMODIFIER_MAINT.Name = "DATEMODIFIER_MAINT";
            this.DATEMODIFIER_MAINT.ReadOnly = true;
            // 
            // FormEntretienVehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 731);
            this.Controls.Add(this.DgvEntretien);
            this.Controls.Add(this.panelSearchFormEntretien);
            this.Controls.Add(this.panelTitleEntretien);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEntretienVehicule";
            this.Text = "FormEntretienVehicule";
            this.panelTitleEntretien.ResumeLayout(false);
            this.panelSearchFormEntretien.ResumeLayout(false);
            this.panelSearchFormEntretien.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEntretien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleEntretien;
        private FontAwesome.Sharp.IconButton iconBtnCreateEntretien;
        private System.Windows.Forms.Panel panelSearchFormEntretien;
        private FontAwesome.Sharp.IconButton iconBtnSearchFormEntretien;
        private System.Windows.Forms.TextBox TxtSearchEntretienCar;
        private FontAwesome.Sharp.IconButton iconBtnCloseFormEntretien;
        private FontAwesome.Sharp.IconButton BtnExportCarEntretien;
        private System.Windows.Forms.DataGridView DgvEntretien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_MAINT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_MAINT;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUT_MAINT;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMMATRICULATION_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRIX_MAINT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_MAINT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TYPE_MAINT;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATTION_MAINT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTE_MAINT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATECREATE_MAINT;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERCREATE_MAINT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATEMODIFIER_MAINT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}