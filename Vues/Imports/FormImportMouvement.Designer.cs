namespace GestPark.Vues.Imports
{
    partial class FormImportMouvement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImportMouvement));
            this.dgvImpMvt = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_VALMVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE_MVTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMMATRICULATION_VEHICULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_PERS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION_COND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LIEU_MVTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATEDEPARTSOUHAITE_MVTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATEEXECUTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATERETOURPROBABLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATERETOURREEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIMESTART_MVTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIMEEND_MVTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoadImpMvt = new FontAwesome.Sharp.IconButton();
            this.btnValImpMvt = new FontAwesome.Sharp.IconButton();
            this.btnExpImpMvt = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpMvt)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvImpMvt
            // 
            this.dgvImpMvt.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImpMvt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvImpMvt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImpMvt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.DESCRIPTION_VALMVT,
            this.CODE_MVTS,
            this.IMMATRICULATION_VEHICULE,
            this.DESCRIPTION_PERS,
            this.DESCRIPTION_COND,
            this.LIEU_MVTS,
            this.DATEDEPARTSOUHAITE_MVTS,
            this.DATEEXECUTION,
            this.DATERETOURPROBABLE,
            this.DATERETOURREEL,
            this.TIMESTART_MVTS,
            this.TIMEEND_MVTS});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvImpMvt.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvImpMvt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvImpMvt.GridColor = System.Drawing.Color.White;
            this.dgvImpMvt.Location = new System.Drawing.Point(0, 0);
            this.dgvImpMvt.Name = "dgvImpMvt";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImpMvt.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvImpMvt.RowHeadersWidth = 51;
            this.dgvImpMvt.RowTemplate.Height = 24;
            this.dgvImpMvt.Size = new System.Drawing.Size(1155, 569);
            this.dgvImpMvt.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnLoadImpMvt);
            this.panel1.Controls.Add(this.btnValImpMvt);
            this.panel1.Controls.Add(this.btnExpImpMvt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 569);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 29);
            this.panel1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "N°";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // DESCRIPTION_VALMVT
            // 
            this.DESCRIPTION_VALMVT.DataPropertyName = "DESCRIPTION_VALMVT";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.DESCRIPTION_VALMVT.DefaultCellStyle = dataGridViewCellStyle2;
            this.DESCRIPTION_VALMVT.HeaderText = "Statut de demande";
            this.DESCRIPTION_VALMVT.MinimumWidth = 6;
            this.DESCRIPTION_VALMVT.Name = "DESCRIPTION_VALMVT";
            this.DESCRIPTION_VALMVT.ReadOnly = true;
            this.DESCRIPTION_VALMVT.Width = 200;
            // 
            // CODE_MVTS
            // 
            this.CODE_MVTS.DataPropertyName = "CODE_MVTS";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.CODE_MVTS.DefaultCellStyle = dataGridViewCellStyle3;
            this.CODE_MVTS.HeaderText = "Code";
            this.CODE_MVTS.MinimumWidth = 6;
            this.CODE_MVTS.Name = "CODE_MVTS";
            this.CODE_MVTS.ReadOnly = true;
            this.CODE_MVTS.Width = 125;
            // 
            // IMMATRICULATION_VEHICULE
            // 
            this.IMMATRICULATION_VEHICULE.DataPropertyName = "IMMATRICULATION_VEHICULE";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.IMMATRICULATION_VEHICULE.DefaultCellStyle = dataGridViewCellStyle4;
            this.IMMATRICULATION_VEHICULE.HeaderText = "Véhicule";
            this.IMMATRICULATION_VEHICULE.MinimumWidth = 6;
            this.IMMATRICULATION_VEHICULE.Name = "IMMATRICULATION_VEHICULE";
            this.IMMATRICULATION_VEHICULE.ReadOnly = true;
            this.IMMATRICULATION_VEHICULE.Width = 200;
            // 
            // DESCRIPTION_PERS
            // 
            this.DESCRIPTION_PERS.DataPropertyName = "DESCRIPTION_PERS";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DESCRIPTION_PERS.DefaultCellStyle = dataGridViewCellStyle5;
            this.DESCRIPTION_PERS.HeaderText = "Demandeur";
            this.DESCRIPTION_PERS.MinimumWidth = 6;
            this.DESCRIPTION_PERS.Name = "DESCRIPTION_PERS";
            this.DESCRIPTION_PERS.ReadOnly = true;
            this.DESCRIPTION_PERS.Width = 125;
            // 
            // DESCRIPTION_COND
            // 
            this.DESCRIPTION_COND.DataPropertyName = "DESCRIPTION_COND";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.DESCRIPTION_COND.DefaultCellStyle = dataGridViewCellStyle6;
            this.DESCRIPTION_COND.HeaderText = "Conducteur";
            this.DESCRIPTION_COND.MinimumWidth = 6;
            this.DESCRIPTION_COND.Name = "DESCRIPTION_COND";
            this.DESCRIPTION_COND.ReadOnly = true;
            this.DESCRIPTION_COND.Width = 200;
            // 
            // LIEU_MVTS
            // 
            this.LIEU_MVTS.DataPropertyName = "LIEU_MVTS";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.LIEU_MVTS.DefaultCellStyle = dataGridViewCellStyle7;
            this.LIEU_MVTS.HeaderText = "Lieu";
            this.LIEU_MVTS.MinimumWidth = 6;
            this.LIEU_MVTS.Name = "LIEU_MVTS";
            this.LIEU_MVTS.ReadOnly = true;
            this.LIEU_MVTS.Width = 125;
            // 
            // DATEDEPARTSOUHAITE_MVTS
            // 
            this.DATEDEPARTSOUHAITE_MVTS.DataPropertyName = "DATEDEPARTSOUHAITE_MVTS";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DATEDEPARTSOUHAITE_MVTS.DefaultCellStyle = dataGridViewCellStyle8;
            this.DATEDEPARTSOUHAITE_MVTS.HeaderText = "Date départ souhaitée";
            this.DATEDEPARTSOUHAITE_MVTS.MinimumWidth = 6;
            this.DATEDEPARTSOUHAITE_MVTS.Name = "DATEDEPARTSOUHAITE_MVTS";
            this.DATEDEPARTSOUHAITE_MVTS.ReadOnly = true;
            this.DATEDEPARTSOUHAITE_MVTS.Width = 200;
            // 
            // DATEEXECUTION
            // 
            this.DATEEXECUTION.DataPropertyName = "DATEEXECUTION";
            this.DATEEXECUTION.HeaderText = "Date exécution";
            this.DATEEXECUTION.MinimumWidth = 6;
            this.DATEEXECUTION.Name = "DATEEXECUTION";
            this.DATEEXECUTION.ReadOnly = true;
            this.DATEEXECUTION.Width = 200;
            // 
            // DATERETOURPROBABLE
            // 
            this.DATERETOURPROBABLE.DataPropertyName = "DATERETOURPROBABLE";
            this.DATERETOURPROBABLE.HeaderText = "Date retour probable";
            this.DATERETOURPROBABLE.MinimumWidth = 6;
            this.DATERETOURPROBABLE.Name = "DATERETOURPROBABLE";
            this.DATERETOURPROBABLE.ReadOnly = true;
            this.DATERETOURPROBABLE.Width = 200;
            // 
            // DATERETOURREEL
            // 
            this.DATERETOURREEL.DataPropertyName = "DATERETOURREEL";
            this.DATERETOURREEL.HeaderText = "Date retour réel";
            this.DATERETOURREEL.MinimumWidth = 6;
            this.DATERETOURREEL.Name = "DATERETOURREEL";
            this.DATERETOURREEL.ReadOnly = true;
            this.DATERETOURREEL.Width = 125;
            // 
            // TIMESTART_MVTS
            // 
            this.TIMESTART_MVTS.DataPropertyName = "TIMESTART_MVTS";
            this.TIMESTART_MVTS.HeaderText = "Heure départ";
            this.TIMESTART_MVTS.MinimumWidth = 6;
            this.TIMESTART_MVTS.Name = "TIMESTART_MVTS";
            this.TIMESTART_MVTS.ReadOnly = true;
            this.TIMESTART_MVTS.Width = 125;
            // 
            // TIMEEND_MVTS
            // 
            this.TIMEEND_MVTS.DataPropertyName = "TIMEEND_MVTS";
            this.TIMEEND_MVTS.HeaderText = "Heure retour";
            this.TIMEEND_MVTS.MinimumWidth = 6;
            this.TIMEEND_MVTS.Name = "TIMEEND_MVTS";
            this.TIMEEND_MVTS.ReadOnly = true;
            this.TIMEEND_MVTS.Width = 125;
            // 
            // btnLoadImpMvt
            // 
            this.btnLoadImpMvt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnLoadImpMvt.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadImpMvt.IconChar = FontAwesome.Sharp.IconChar.Spinner;
            this.btnLoadImpMvt.IconColor = System.Drawing.Color.White;
            this.btnLoadImpMvt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoadImpMvt.IconSize = 20;
            this.btnLoadImpMvt.Location = new System.Drawing.Point(913, -2);
            this.btnLoadImpMvt.Name = "btnLoadImpMvt";
            this.btnLoadImpMvt.Size = new System.Drawing.Size(118, 29);
            this.btnLoadImpMvt.TabIndex = 2;
            this.btnLoadImpMvt.Text = "Charger";
            this.btnLoadImpMvt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadImpMvt.UseVisualStyleBackColor = false;
            this.btnLoadImpMvt.Click += new System.EventHandler(this.btnLoadImpMvt_Click);
            // 
            // btnValImpMvt
            // 
            this.btnValImpMvt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnValImpMvt.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValImpMvt.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
            this.btnValImpMvt.IconColor = System.Drawing.Color.White;
            this.btnValImpMvt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnValImpMvt.IconSize = 20;
            this.btnValImpMvt.Location = new System.Drawing.Point(1037, -2);
            this.btnValImpMvt.Name = "btnValImpMvt";
            this.btnValImpMvt.Size = new System.Drawing.Size(118, 29);
            this.btnValImpMvt.TabIndex = 1;
            this.btnValImpMvt.Text = "Valider";
            this.btnValImpMvt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnValImpMvt.UseVisualStyleBackColor = false;
            this.btnValImpMvt.Click += new System.EventHandler(this.btnValImpMvt_Click);
            // 
            // btnExpImpMvt
            // 
            this.btnExpImpMvt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.btnExpImpMvt.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpImpMvt.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnExpImpMvt.IconColor = System.Drawing.Color.White;
            this.btnExpImpMvt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExpImpMvt.IconSize = 20;
            this.btnExpImpMvt.Location = new System.Drawing.Point(-2, -2);
            this.btnExpImpMvt.Name = "btnExpImpMvt";
            this.btnExpImpMvt.Size = new System.Drawing.Size(108, 29);
            this.btnExpImpMvt.TabIndex = 0;
            this.btnExpImpMvt.Text = "Exporter";
            this.btnExpImpMvt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExpImpMvt.UseVisualStyleBackColor = false;
            this.btnExpImpMvt.Click += new System.EventHandler(this.btnExpImpMvt_Click);
            // 
            // FormImportMouvement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 598);
            this.Controls.Add(this.dgvImpMvt);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormImportMouvement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Importation des courses de véhicules";
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpMvt)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvImpMvt;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnLoadImpMvt;
        private FontAwesome.Sharp.IconButton btnValImpMvt;
        private FontAwesome.Sharp.IconButton btnExpImpMvt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_VALMVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_MVTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMMATRICULATION_VEHICULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_PERS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION_COND;
        private System.Windows.Forms.DataGridViewTextBoxColumn LIEU_MVTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATEDEPARTSOUHAITE_MVTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATEEXECUTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATERETOURPROBABLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATERETOURREEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIMESTART_MVTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIMEEND_MVTS;
    }
}