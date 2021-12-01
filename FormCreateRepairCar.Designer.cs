
namespace GestPark
{
    partial class FormCreateRepairCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateRepairCar));
            this.CbxRepaiCar = new System.Windows.Forms.ComboBox();
            this.RtxtNoteRepairCar = new System.Windows.Forms.RichTextBox();
            this.DateRegisterRepairCar = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtDescripRepaiCar = new System.Windows.Forms.TextBox();
            this.TxtCodeRepaiCar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelMenuConsoCarb = new System.Windows.Forms.Panel();
            this.JointDocModifyPanCar = new FontAwesome.Sharp.IconButton();
            this.IcBtnSavedRepaiCar = new FontAwesome.Sharp.IconButton();
            this.CbxGarageRepairCar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtAmountRepair = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtMecanicienRepairCar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelMenuConsoCarb.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CbxRepaiCar
            // 
            this.CbxRepaiCar.FormattingEnabled = true;
            this.CbxRepaiCar.Location = new System.Drawing.Point(95, 162);
            this.CbxRepaiCar.Name = "CbxRepaiCar";
            this.CbxRepaiCar.Size = new System.Drawing.Size(240, 23);
            this.CbxRepaiCar.TabIndex = 73;
            this.CbxRepaiCar.SelectedIndexChanged += new System.EventHandler(this.CbxRepaiCar_SelectedIndexChanged);
            // 
            // RtxtNoteRepairCar
            // 
            this.RtxtNoteRepairCar.Location = new System.Drawing.Point(95, 333);
            this.RtxtNoteRepairCar.Name = "RtxtNoteRepairCar";
            this.RtxtNoteRepairCar.Size = new System.Drawing.Size(665, 91);
            this.RtxtNoteRepairCar.TabIndex = 72;
            this.RtxtNoteRepairCar.Text = "";
            // 
            // DateRegisterRepairCar
            // 
            this.DateRegisterRepairCar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateRegisterRepairCar.Location = new System.Drawing.Point(95, 23);
            this.DateRegisterRepairCar.Name = "DateRegisterRepairCar";
            this.DateRegisterRepairCar.Size = new System.Drawing.Size(240, 22);
            this.DateRegisterRepairCar.TabIndex = 71;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 70;
            this.label6.Text = "Date :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 69;
            this.label8.Text = "Note :";
            // 
            // TxtDescripRepaiCar
            // 
            this.TxtDescripRepaiCar.Location = new System.Drawing.Point(95, 112);
            this.TxtDescripRepaiCar.Name = "TxtDescripRepaiCar";
            this.TxtDescripRepaiCar.Size = new System.Drawing.Size(240, 22);
            this.TxtDescripRepaiCar.TabIndex = 68;
            // 
            // TxtCodeRepaiCar
            // 
            this.TxtCodeRepaiCar.BackColor = System.Drawing.Color.YellowGreen;
            this.TxtCodeRepaiCar.Location = new System.Drawing.Point(95, 59);
            this.TxtCodeRepaiCar.Name = "TxtCodeRepaiCar";
            this.TxtCodeRepaiCar.ReadOnly = true;
            this.TxtCodeRepaiCar.Size = new System.Drawing.Size(148, 22);
            this.TxtCodeRepaiCar.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(13, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 66;
            this.label3.Text = "Vehicule :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 65;
            this.label2.Text = "Description :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(13, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 64;
            this.label1.Text = "Code :";
            // 
            // PanelMenuConsoCarb
            // 
            this.PanelMenuConsoCarb.BackColor = System.Drawing.Color.Khaki;
            this.PanelMenuConsoCarb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelMenuConsoCarb.Controls.Add(this.JointDocModifyPanCar);
            this.PanelMenuConsoCarb.Controls.Add(this.IcBtnSavedRepaiCar);
            this.PanelMenuConsoCarb.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelMenuConsoCarb.Location = new System.Drawing.Point(0, 0);
            this.PanelMenuConsoCarb.Name = "PanelMenuConsoCarb";
            this.PanelMenuConsoCarb.Size = new System.Drawing.Size(772, 28);
            this.PanelMenuConsoCarb.TabIndex = 63;
            // 
            // JointDocModifyPanCar
            // 
            this.JointDocModifyPanCar.BackColor = System.Drawing.Color.White;
            this.JointDocModifyPanCar.ForeColor = System.Drawing.Color.DarkGreen;
            this.JointDocModifyPanCar.IconChar = FontAwesome.Sharp.IconChar.FileUpload;
            this.JointDocModifyPanCar.IconColor = System.Drawing.Color.DarkGreen;
            this.JointDocModifyPanCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.JointDocModifyPanCar.IconSize = 20;
            this.JointDocModifyPanCar.Location = new System.Drawing.Point(107, -2);
            this.JointDocModifyPanCar.Name = "JointDocModifyPanCar";
            this.JointDocModifyPanCar.Size = new System.Drawing.Size(128, 28);
            this.JointDocModifyPanCar.TabIndex = 2;
            this.JointDocModifyPanCar.Text = "Joindre fichier";
            this.JointDocModifyPanCar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.JointDocModifyPanCar.UseVisualStyleBackColor = false;
            // 
            // IcBtnSavedRepaiCar
            // 
            this.IcBtnSavedRepaiCar.BackColor = System.Drawing.Color.White;
            this.IcBtnSavedRepaiCar.ForeColor = System.Drawing.Color.DarkGreen;
            this.IcBtnSavedRepaiCar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.IcBtnSavedRepaiCar.IconColor = System.Drawing.Color.DarkGreen;
            this.IcBtnSavedRepaiCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcBtnSavedRepaiCar.IconSize = 20;
            this.IcBtnSavedRepaiCar.Location = new System.Drawing.Point(-2, -2);
            this.IcBtnSavedRepaiCar.Name = "IcBtnSavedRepaiCar";
            this.IcBtnSavedRepaiCar.Size = new System.Drawing.Size(103, 28);
            this.IcBtnSavedRepaiCar.TabIndex = 1;
            this.IcBtnSavedRepaiCar.Text = "Enregistrer";
            this.IcBtnSavedRepaiCar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IcBtnSavedRepaiCar.UseVisualStyleBackColor = false;
            this.IcBtnSavedRepaiCar.Click += new System.EventHandler(this.IcBtnSavedRepaiCar_Click);
            // 
            // CbxGarageRepairCar
            // 
            this.CbxGarageRepairCar.FormattingEnabled = true;
            this.CbxGarageRepairCar.Location = new System.Drawing.Point(95, 212);
            this.CbxGarageRepairCar.Name = "CbxGarageRepairCar";
            this.CbxGarageRepairCar.Size = new System.Drawing.Size(240, 23);
            this.CbxGarageRepairCar.TabIndex = 76;
            this.CbxGarageRepairCar.SelectedIndexChanged += new System.EventHandler(this.CbxGarageRepairCar_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(13, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 75;
            this.label4.Text = "Garage :";
            // 
            // TxtAmountRepair
            // 
            this.TxtAmountRepair.Location = new System.Drawing.Point(95, 265);
            this.TxtAmountRepair.Name = "TxtAmountRepair";
            this.TxtAmountRepair.Size = new System.Drawing.Size(240, 22);
            this.TxtAmountRepair.TabIndex = 80;
            this.TxtAmountRepair.Text = "0";
            this.TxtAmountRepair.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(13, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 79;
            this.label7.Text = "Montant :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 77;
            this.label5.Text = "Mecanicien :";
            // 
            // TxtMecanicienRepairCar
            // 
            this.TxtMecanicienRepairCar.BackColor = System.Drawing.Color.YellowGreen;
            this.TxtMecanicienRepairCar.Location = new System.Drawing.Point(95, 79);
            this.TxtMecanicienRepairCar.Name = "TxtMecanicienRepairCar";
            this.TxtMecanicienRepairCar.ReadOnly = true;
            this.TxtMecanicienRepairCar.Size = new System.Drawing.Size(240, 22);
            this.TxtMecanicienRepairCar.TabIndex = 78;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.DateRegisterRepairCar);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TxtMecanicienRepairCar);
            this.panel1.Location = new System.Drawing.Point(402, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 141);
            this.panel1.TabIndex = 81;
            // 
            // FormCreateRepairCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(772, 469);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtAmountRepair);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CbxGarageRepairCar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CbxRepaiCar);
            this.Controls.Add(this.RtxtNoteRepairCar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtDescripRepaiCar);
            this.Controls.Add(this.TxtCodeRepaiCar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelMenuConsoCarb);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCreateRepairCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Créer une reparation de vehicule";
            this.PanelMenuConsoCarb.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton JointDocModifyPanCar;
        private FontAwesome.Sharp.IconButton IcBtnSavedRepaiCar;
        public System.Windows.Forms.ComboBox CbxRepaiCar;
        public System.Windows.Forms.RichTextBox RtxtNoteRepairCar;
        public System.Windows.Forms.DateTimePicker DateRegisterRepairCar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox TxtDescripRepaiCar;
        public System.Windows.Forms.TextBox TxtCodeRepaiCar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelMenuConsoCarb;
        public System.Windows.Forms.ComboBox CbxGarageRepairCar;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TxtAmountRepair;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox TxtMecanicienRepairCar;
        private System.Windows.Forms.Panel panel1;
    }
}