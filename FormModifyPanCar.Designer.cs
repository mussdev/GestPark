﻿
namespace GestPark
{
    partial class FormModifyPanCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModifyPanCar));
            this.CbxEtatModifyPanCar = new System.Windows.Forms.ComboBox();
            this.RichTxtoutheInfosModifyPanCar = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RtxtNoteModifyPanCar = new System.Windows.Forms.RichTextBox();
            this.DateRegisterModifyPanCar = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtDescriptionModifyPanCar = new System.Windows.Forms.TextBox();
            this.TxtCodeModifyPanCar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelMenuConsoCarb = new System.Windows.Forms.Panel();
            this.JointDocModifyPanCar = new FontAwesome.Sharp.IconButton();
            this.IcBtnSavedModifyPanCar = new FontAwesome.Sharp.IconButton();
            this.IbtnRepaiCarPan = new FontAwesome.Sharp.IconButton();
            this.LbGarage = new System.Windows.Forms.Label();
            this.LbMeacn = new System.Windows.Forms.Label();
            this.CbxGarage = new System.Windows.Forms.ComboBox();
            this.TxtMecanicien = new System.Windows.Forms.TextBox();
            this.CbxVehiModifyPanCar = new System.Windows.Forms.ComboBox();
            this.PanelMenuConsoCarb.SuspendLayout();
            this.SuspendLayout();
            // 
            // CbxEtatModifyPanCar
            // 
            this.CbxEtatModifyPanCar.FormattingEnabled = true;
            this.CbxEtatModifyPanCar.Items.AddRange(new object[] {
            "",
            "Panne",
            "En cours de reparation",
            "Bon"});
            this.CbxEtatModifyPanCar.Location = new System.Drawing.Point(95, 106);
            this.CbxEtatModifyPanCar.Name = "CbxEtatModifyPanCar";
            this.CbxEtatModifyPanCar.Size = new System.Drawing.Size(240, 23);
            this.CbxEtatModifyPanCar.TabIndex = 61;
            this.CbxEtatModifyPanCar.Text = "Panne";
            this.CbxEtatModifyPanCar.SelectedIndexChanged += new System.EventHandler(this.CbxEtatModifyPanCar_SelectedIndexChanged);
            // 
            // RichTxtoutheInfosModifyPanCar
            // 
            this.RichTxtoutheInfosModifyPanCar.Location = new System.Drawing.Point(505, 56);
            this.RichTxtoutheInfosModifyPanCar.Name = "RichTxtoutheInfosModifyPanCar";
            this.RichTxtoutheInfosModifyPanCar.Size = new System.Drawing.Size(292, 108);
            this.RichTxtoutheInfosModifyPanCar.TabIndex = 59;
            this.RichTxtoutheInfosModifyPanCar.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(17, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 60;
            this.label5.Text = "Etat :";
            // 
            // RtxtNoteModifyPanCar
            // 
            this.RtxtNoteModifyPanCar.Location = new System.Drawing.Point(95, 333);
            this.RtxtNoteModifyPanCar.Name = "RtxtNoteModifyPanCar";
            this.RtxtNoteModifyPanCar.Size = new System.Drawing.Size(702, 130);
            this.RtxtNoteModifyPanCar.TabIndex = 57;
            this.RtxtNoteModifyPanCar.Text = "";
            // 
            // DateRegisterModifyPanCar
            // 
            this.DateRegisterModifyPanCar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateRegisterModifyPanCar.Location = new System.Drawing.Point(95, 273);
            this.DateRegisterModifyPanCar.Name = "DateRegisterModifyPanCar";
            this.DateRegisterModifyPanCar.Size = new System.Drawing.Size(240, 22);
            this.DateRegisterModifyPanCar.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 55;
            this.label6.Text = "Date :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 54;
            this.label8.Text = "Note :";
            // 
            // TxtDescriptionModifyPanCar
            // 
            this.TxtDescriptionModifyPanCar.Location = new System.Drawing.Point(95, 160);
            this.TxtDescriptionModifyPanCar.Name = "TxtDescriptionModifyPanCar";
            this.TxtDescriptionModifyPanCar.Size = new System.Drawing.Size(240, 22);
            this.TxtDescriptionModifyPanCar.TabIndex = 53;
            // 
            // TxtCodeModifyPanCar
            // 
            this.TxtCodeModifyPanCar.BackColor = System.Drawing.Color.YellowGreen;
            this.TxtCodeModifyPanCar.Location = new System.Drawing.Point(95, 56);
            this.TxtCodeModifyPanCar.Name = "TxtCodeModifyPanCar";
            this.TxtCodeModifyPanCar.ReadOnly = true;
            this.TxtCodeModifyPanCar.Size = new System.Drawing.Size(148, 22);
            this.TxtCodeModifyPanCar.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(13, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 51;
            this.label3.Text = "Vehicule :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 50;
            this.label2.Text = "Description :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(13, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 49;
            this.label1.Text = "Code :";
            // 
            // PanelMenuConsoCarb
            // 
            this.PanelMenuConsoCarb.BackColor = System.Drawing.Color.Khaki;
            this.PanelMenuConsoCarb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelMenuConsoCarb.Controls.Add(this.JointDocModifyPanCar);
            this.PanelMenuConsoCarb.Controls.Add(this.IcBtnSavedModifyPanCar);
            this.PanelMenuConsoCarb.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelMenuConsoCarb.Location = new System.Drawing.Point(0, 0);
            this.PanelMenuConsoCarb.Name = "PanelMenuConsoCarb";
            this.PanelMenuConsoCarb.Size = new System.Drawing.Size(809, 27);
            this.PanelMenuConsoCarb.TabIndex = 48;
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
            this.JointDocModifyPanCar.Size = new System.Drawing.Size(110, 27);
            this.JointDocModifyPanCar.TabIndex = 2;
            this.JointDocModifyPanCar.Text = "Joindre doc.";
            this.JointDocModifyPanCar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.JointDocModifyPanCar.UseVisualStyleBackColor = false;
            // 
            // IcBtnSavedModifyPanCar
            // 
            this.IcBtnSavedModifyPanCar.BackColor = System.Drawing.Color.White;
            this.IcBtnSavedModifyPanCar.ForeColor = System.Drawing.Color.DarkGreen;
            this.IcBtnSavedModifyPanCar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.IcBtnSavedModifyPanCar.IconColor = System.Drawing.Color.DarkGreen;
            this.IcBtnSavedModifyPanCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcBtnSavedModifyPanCar.IconSize = 20;
            this.IcBtnSavedModifyPanCar.Location = new System.Drawing.Point(-2, -2);
            this.IcBtnSavedModifyPanCar.Name = "IcBtnSavedModifyPanCar";
            this.IcBtnSavedModifyPanCar.Size = new System.Drawing.Size(103, 27);
            this.IcBtnSavedModifyPanCar.TabIndex = 1;
            this.IcBtnSavedModifyPanCar.Text = "Enregistrer";
            this.IcBtnSavedModifyPanCar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IcBtnSavedModifyPanCar.UseVisualStyleBackColor = false;
            this.IcBtnSavedModifyPanCar.Click += new System.EventHandler(this.IcBtnSavedModifyPanCar_Click);
            // 
            // IbtnRepaiCarPan
            // 
            this.IbtnRepaiCarPan.BackColor = System.Drawing.Color.White;
            this.IbtnRepaiCarPan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IbtnRepaiCarPan.ForeColor = System.Drawing.Color.DarkGreen;
            this.IbtnRepaiCarPan.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.IbtnRepaiCarPan.IconColor = System.Drawing.Color.DarkGreen;
            this.IbtnRepaiCarPan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnRepaiCarPan.IconSize = 20;
            this.IbtnRepaiCarPan.Location = new System.Drawing.Point(505, 288);
            this.IbtnRepaiCarPan.Name = "IbtnRepaiCarPan";
            this.IbtnRepaiCarPan.Size = new System.Drawing.Size(94, 23);
            this.IbtnRepaiCarPan.TabIndex = 62;
            this.IbtnRepaiCarPan.Text = "Reparer";
            this.IbtnRepaiCarPan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IbtnRepaiCarPan.UseVisualStyleBackColor = false;
            this.IbtnRepaiCarPan.Click += new System.EventHandler(this.IbtnRepaiCarPan_Click);
            // 
            // LbGarage
            // 
            this.LbGarage.AutoSize = true;
            this.LbGarage.Location = new System.Drawing.Point(502, 197);
            this.LbGarage.Name = "LbGarage";
            this.LbGarage.Size = new System.Drawing.Size(50, 15);
            this.LbGarage.TabIndex = 63;
            this.LbGarage.Text = "Garage :";
            // 
            // LbMeacn
            // 
            this.LbMeacn.AutoSize = true;
            this.LbMeacn.Location = new System.Drawing.Point(502, 240);
            this.LbMeacn.Name = "LbMeacn";
            this.LbMeacn.Size = new System.Drawing.Size(75, 15);
            this.LbMeacn.TabIndex = 64;
            this.LbMeacn.Text = "Mécanicien :";
            // 
            // CbxGarage
            // 
            this.CbxGarage.FormattingEnabled = true;
            this.CbxGarage.Location = new System.Drawing.Point(597, 189);
            this.CbxGarage.Name = "CbxGarage";
            this.CbxGarage.Size = new System.Drawing.Size(200, 23);
            this.CbxGarage.TabIndex = 65;
            this.CbxGarage.SelectedIndexChanged += new System.EventHandler(this.CbxGarage_SelectedIndexChanged);
            // 
            // TxtMecanicien
            // 
            this.TxtMecanicien.Location = new System.Drawing.Point(597, 240);
            this.TxtMecanicien.Name = "TxtMecanicien";
            this.TxtMecanicien.Size = new System.Drawing.Size(200, 22);
            this.TxtMecanicien.TabIndex = 66;
            // 
            // CbxVehiModifyPanCar
            // 
            this.CbxVehiModifyPanCar.FormattingEnabled = true;
            this.CbxVehiModifyPanCar.Location = new System.Drawing.Point(95, 212);
            this.CbxVehiModifyPanCar.Name = "CbxVehiModifyPanCar";
            this.CbxVehiModifyPanCar.Size = new System.Drawing.Size(240, 23);
            this.CbxVehiModifyPanCar.TabIndex = 67;
            this.CbxVehiModifyPanCar.SelectedIndexChanged += new System.EventHandler(this.CbxVehiModifyPanCar_SelectedIndexChanged);
            // 
            // FormModifyPanCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(809, 469);
            this.Controls.Add(this.CbxVehiModifyPanCar);
            this.Controls.Add(this.TxtMecanicien);
            this.Controls.Add(this.CbxGarage);
            this.Controls.Add(this.LbMeacn);
            this.Controls.Add(this.LbGarage);
            this.Controls.Add(this.IbtnRepaiCarPan);
            this.Controls.Add(this.CbxEtatModifyPanCar);
            this.Controls.Add(this.RichTxtoutheInfosModifyPanCar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RtxtNoteModifyPanCar);
            this.Controls.Add(this.DateRegisterModifyPanCar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtDescriptionModifyPanCar);
            this.Controls.Add(this.TxtCodeModifyPanCar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelMenuConsoCarb);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormModifyPanCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editer une panne de vehicule";
            this.Load += new System.EventHandler(this.FormModifyPanCar_Load);
            this.PanelMenuConsoCarb.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton JointDocModifyPanCar;
        private FontAwesome.Sharp.IconButton IcBtnSavedModifyPanCar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelMenuConsoCarb;
        public System.Windows.Forms.ComboBox CbxEtatModifyPanCar;
        public System.Windows.Forms.RichTextBox RichTxtoutheInfosModifyPanCar;
        public System.Windows.Forms.RichTextBox RtxtNoteModifyPanCar;
        public System.Windows.Forms.DateTimePicker DateRegisterModifyPanCar;
        public System.Windows.Forms.TextBox TxtDescriptionModifyPanCar;
        public System.Windows.Forms.TextBox TxtCodeModifyPanCar;
        private FontAwesome.Sharp.IconButton IbtnRepaiCarPan;
        private System.Windows.Forms.Label LbGarage;
        private System.Windows.Forms.Label LbMeacn;
        private System.Windows.Forms.ComboBox CbxGarage;
        private System.Windows.Forms.TextBox TxtMecanicien;
        public System.Windows.Forms.ComboBox CbxVehiModifyPanCar;
    }
}