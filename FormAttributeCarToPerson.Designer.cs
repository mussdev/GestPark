
namespace GestPark
{
    partial class FormAttributeCarToPerson
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
            this.panelTitleMainAttribute = new System.Windows.Forms.Panel();
            this.IbtnCloseFormMainAttribute = new FontAwesome.Sharp.IconButton();
            this.IbtnCreateAttribute = new FontAwesome.Sharp.IconButton();
            this.TbxSearchAttribute = new System.Windows.Forms.TextBox();
            this.panelSearchAttribute = new System.Windows.Forms.Panel();
            this.dataGridViewAttributeCar = new System.Windows.Forms.DataGridView();
            this.ID_APP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE_ATTRI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMMATRICULATION_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_PERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTE_ATTRI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_ATTRI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_DEBUT_ATTRI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_FIN_ATTRI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IbtnSearchCarAttribute = new FontAwesome.Sharp.IconButton();
            this.panelTitleMainAttribute.SuspendLayout();
            this.panelSearchAttribute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttributeCar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleMainAttribute
            // 
            this.panelTitleMainAttribute.BackColor = System.Drawing.Color.DarkOrange;
            this.panelTitleMainAttribute.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTitleMainAttribute.Controls.Add(this.IbtnCloseFormMainAttribute);
            this.panelTitleMainAttribute.Controls.Add(this.IbtnCreateAttribute);
            this.panelTitleMainAttribute.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleMainAttribute.Location = new System.Drawing.Point(0, 0);
            this.panelTitleMainAttribute.Name = "panelTitleMainAttribute";
            this.panelTitleMainAttribute.Size = new System.Drawing.Size(1118, 27);
            this.panelTitleMainAttribute.TabIndex = 0;
            // 
            // IbtnCloseFormMainAttribute
            // 
            this.IbtnCloseFormMainAttribute.BackColor = System.Drawing.Color.White;
            this.IbtnCloseFormMainAttribute.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.IbtnCloseFormMainAttribute.IconColor = System.Drawing.Color.Red;
            this.IbtnCloseFormMainAttribute.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnCloseFormMainAttribute.IconSize = 30;
            this.IbtnCloseFormMainAttribute.Location = new System.Drawing.Point(1085, -2);
            this.IbtnCloseFormMainAttribute.Name = "IbtnCloseFormMainAttribute";
            this.IbtnCloseFormMainAttribute.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.IbtnCloseFormMainAttribute.Size = new System.Drawing.Size(31, 29);
            this.IbtnCloseFormMainAttribute.TabIndex = 1;
            this.IbtnCloseFormMainAttribute.UseVisualStyleBackColor = false;
            this.IbtnCloseFormMainAttribute.Click += new System.EventHandler(this.IbtnCloseFormMainAttribute_Click);
            // 
            // IbtnCreateAttribute
            // 
            this.IbtnCreateAttribute.BackColor = System.Drawing.Color.White;
            this.IbtnCreateAttribute.ForeColor = System.Drawing.Color.DarkGreen;
            this.IbtnCreateAttribute.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.IbtnCreateAttribute.IconColor = System.Drawing.Color.DarkGreen;
            this.IbtnCreateAttribute.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnCreateAttribute.IconSize = 25;
            this.IbtnCreateAttribute.Location = new System.Drawing.Point(-2, -2);
            this.IbtnCreateAttribute.Name = "IbtnCreateAttribute";
            this.IbtnCreateAttribute.Size = new System.Drawing.Size(77, 27);
            this.IbtnCreateAttribute.TabIndex = 0;
            this.IbtnCreateAttribute.Text = "Créer";
            this.IbtnCreateAttribute.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IbtnCreateAttribute.UseVisualStyleBackColor = false;
            this.IbtnCreateAttribute.Click += new System.EventHandler(this.IbtnCreateAttribute_Click);
            // 
            // TbxSearchAttribute
            // 
            this.TbxSearchAttribute.Location = new System.Drawing.Point(575, 42);
            this.TbxSearchAttribute.Name = "TbxSearchAttribute";
            this.TbxSearchAttribute.Size = new System.Drawing.Size(272, 22);
            this.TbxSearchAttribute.TabIndex = 0;
            // 
            // panelSearchAttribute
            // 
            this.panelSearchAttribute.BackColor = System.Drawing.Color.DarkOrange;
            this.panelSearchAttribute.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSearchAttribute.Controls.Add(this.IbtnSearchCarAttribute);
            this.panelSearchAttribute.Controls.Add(this.TbxSearchAttribute);
            this.panelSearchAttribute.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchAttribute.Location = new System.Drawing.Point(0, 27);
            this.panelSearchAttribute.Name = "panelSearchAttribute";
            this.panelSearchAttribute.Size = new System.Drawing.Size(1118, 100);
            this.panelSearchAttribute.TabIndex = 3;
            // 
            // dataGridViewAttributeCar
            // 
            this.dataGridViewAttributeCar.AllowUserToOrderColumns = true;
            this.dataGridViewAttributeCar.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAttributeCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAttributeCar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_APP,
            this.CODE_ATTRI,
            this.IMMATRICULATION_VEHICULE,
            this.DESCRIPTION_PERS,
            this.NOTE_ATTRI,
            this.DATE_ATTRI,
            this.DATE_DEBUT_ATTRI,
            this.DATE_FIN_ATTRI});
            this.dataGridViewAttributeCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAttributeCar.GridColor = System.Drawing.Color.DimGray;
            this.dataGridViewAttributeCar.Location = new System.Drawing.Point(0, 127);
            this.dataGridViewAttributeCar.Name = "dataGridViewAttributeCar";
            this.dataGridViewAttributeCar.Size = new System.Drawing.Size(1118, 604);
            this.dataGridViewAttributeCar.TabIndex = 33;
            this.dataGridViewAttributeCar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAttributeCar_CellDoubleClick);
            // 
            // ID_APP
            // 
            this.ID_APP.DataPropertyName = "ID_APP";
            this.ID_APP.HeaderText = "Num";
            this.ID_APP.Name = "ID_APP";
            this.ID_APP.ReadOnly = true;
            this.ID_APP.Width = 50;
            // 
            // CODE_ATTRI
            // 
            this.CODE_ATTRI.DataPropertyName = "CODE_ATTRI";
            this.CODE_ATTRI.HeaderText = "Code";
            this.CODE_ATTRI.Name = "CODE_ATTRI";
            this.CODE_ATTRI.ReadOnly = true;
            // 
            // IMMATRICULATION_VEHICULE
            // 
            this.IMMATRICULATION_VEHICULE.DataPropertyName = "IMMATRICULATION_VEHICULE";
            this.IMMATRICULATION_VEHICULE.HeaderText = "Immatri. vehi.";
            this.IMMATRICULATION_VEHICULE.Name = "IMMATRICULATION_VEHICULE";
            this.IMMATRICULATION_VEHICULE.ReadOnly = true;
            this.IMMATRICULATION_VEHICULE.Width = 150;
            // 
            // DESCRIPTION_PERS
            // 
            this.DESCRIPTION_PERS.DataPropertyName = "DESCRIPTION_PERS";
            this.DESCRIPTION_PERS.HeaderText = "Propriétaire";
            this.DESCRIPTION_PERS.Name = "DESCRIPTION_PERS";
            this.DESCRIPTION_PERS.ReadOnly = true;
            this.DESCRIPTION_PERS.Width = 200;
            // 
            // NOTE_ATTRI
            // 
            this.NOTE_ATTRI.DataPropertyName = "NOTE_ATTRI";
            this.NOTE_ATTRI.HeaderText = "Note";
            this.NOTE_ATTRI.Name = "NOTE_ATTRI";
            this.NOTE_ATTRI.ReadOnly = true;
            this.NOTE_ATTRI.Width = 200;
            // 
            // DATE_ATTRI
            // 
            this.DATE_ATTRI.DataPropertyName = "DATE_ATTRI";
            this.DATE_ATTRI.HeaderText = "Date";
            this.DATE_ATTRI.Name = "DATE_ATTRI";
            this.DATE_ATTRI.ReadOnly = true;
            // 
            // DATE_DEBUT_ATTRI
            // 
            this.DATE_DEBUT_ATTRI.DataPropertyName = "DATE_DEBUT_ATTRI";
            this.DATE_DEBUT_ATTRI.HeaderText = "Date attri. véhi.";
            this.DATE_DEBUT_ATTRI.Name = "DATE_DEBUT_ATTRI";
            this.DATE_DEBUT_ATTRI.ReadOnly = true;
            this.DATE_DEBUT_ATTRI.Width = 150;
            // 
            // DATE_FIN_ATTRI
            // 
            this.DATE_FIN_ATTRI.DataPropertyName = "DATE_FIN_ATTRI";
            this.DATE_FIN_ATTRI.HeaderText = "Date fin attri.";
            this.DATE_FIN_ATTRI.Name = "DATE_FIN_ATTRI";
            this.DATE_FIN_ATTRI.ReadOnly = true;
            this.DATE_FIN_ATTRI.Width = 150;
            // 
            // IbtnSearchCarAttribute
            // 
            this.IbtnSearchCarAttribute.BackColor = System.Drawing.Color.White;
            this.IbtnSearchCarAttribute.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.IbtnSearchCarAttribute.IconColor = System.Drawing.Color.DarkGreen;
            this.IbtnSearchCarAttribute.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnSearchCarAttribute.IconSize = 25;
            this.IbtnSearchCarAttribute.Location = new System.Drawing.Point(853, 42);
            this.IbtnSearchCarAttribute.Name = "IbtnSearchCarAttribute";
            this.IbtnSearchCarAttribute.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.IbtnSearchCarAttribute.Size = new System.Drawing.Size(52, 23);
            this.IbtnSearchCarAttribute.TabIndex = 3;
            this.IbtnSearchCarAttribute.UseVisualStyleBackColor = false;
            this.IbtnSearchCarAttribute.Click += new System.EventHandler(this.IbtnSearchCarAttribute_Click);
            // 
            // FormAttributeCarToPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1118, 731);
            this.Controls.Add(this.dataGridViewAttributeCar);
            this.Controls.Add(this.panelSearchAttribute);
            this.Controls.Add(this.panelTitleMainAttribute);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAttributeCarToPerson";
            this.Text = "FormAttributeCarToPerson";
            this.panelTitleMainAttribute.ResumeLayout(false);
            this.panelSearchAttribute.ResumeLayout(false);
            this.panelSearchAttribute.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttributeCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleMainAttribute;
        private FontAwesome.Sharp.IconButton IbtnCloseFormMainAttribute;
        private FontAwesome.Sharp.IconButton IbtnCreateAttribute;
        private System.Windows.Forms.TextBox TbxSearchAttribute;
        private System.Windows.Forms.Panel panelSearchAttribute;
        private System.Windows.Forms.DataGridView dataGridViewAttributeCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_APP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_ATTRI;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMMATRICULATION_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_PERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTE_ATTRI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_ATTRI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_DEBUT_ATTRI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_FIN_ATTRI;
        private FontAwesome.Sharp.IconButton IbtnSearchCarAttribute;
    }
}