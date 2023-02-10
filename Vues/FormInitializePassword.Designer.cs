
namespace GestPark
{
    partial class FormInitializePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInitializePassword));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPassworInit = new System.Windows.Forms.TextBox();
            this.TxtConfirPasswordInit = new System.Windows.Forms.TextBox();
            this.BtnValidPassword = new FontAwesome.Sharp.IconButton();
            this.BtnCloseFormInitPassword = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mot de passe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Confirmer mot de passe";
            // 
            // TxtPassworInit
            // 
            this.TxtPassworInit.Location = new System.Drawing.Point(152, 11);
            this.TxtPassworInit.Name = "TxtPassworInit";
            this.TxtPassworInit.PasswordChar = '*';
            this.TxtPassworInit.Size = new System.Drawing.Size(166, 20);
            this.TxtPassworInit.TabIndex = 2;
            // 
            // TxtConfirPasswordInit
            // 
            this.TxtConfirPasswordInit.Location = new System.Drawing.Point(152, 56);
            this.TxtConfirPasswordInit.Name = "TxtConfirPasswordInit";
            this.TxtConfirPasswordInit.PasswordChar = '*';
            this.TxtConfirPasswordInit.Size = new System.Drawing.Size(166, 20);
            this.TxtConfirPasswordInit.TabIndex = 3;
            // 
            // BtnValidPassword
            // 
            this.BtnValidPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.BtnValidPassword.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnValidPassword.ForeColor = System.Drawing.Color.Black;
            this.BtnValidPassword.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnValidPassword.IconColor = System.Drawing.Color.Black;
            this.BtnValidPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnValidPassword.Location = new System.Drawing.Point(71, 103);
            this.BtnValidPassword.Name = "BtnValidPassword";
            this.BtnValidPassword.Size = new System.Drawing.Size(75, 25);
            this.BtnValidPassword.TabIndex = 4;
            this.BtnValidPassword.Text = "Exécuter";
            this.BtnValidPassword.UseVisualStyleBackColor = false;
            this.BtnValidPassword.Click += new System.EventHandler(this.BtnValidPassword_Click);
            // 
            // BtnCloseFormInitPassword
            // 
            this.BtnCloseFormInitPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(222)))), ((int)(((byte)(132)))));
            this.BtnCloseFormInitPassword.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCloseFormInitPassword.ForeColor = System.Drawing.Color.Black;
            this.BtnCloseFormInitPassword.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnCloseFormInitPassword.IconColor = System.Drawing.Color.Black;
            this.BtnCloseFormInitPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCloseFormInitPassword.Location = new System.Drawing.Point(152, 103);
            this.BtnCloseFormInitPassword.Name = "BtnCloseFormInitPassword";
            this.BtnCloseFormInitPassword.Size = new System.Drawing.Size(74, 25);
            this.BtnCloseFormInitPassword.TabIndex = 5;
            this.BtnCloseFormInitPassword.Text = "Annuler";
            this.BtnCloseFormInitPassword.UseVisualStyleBackColor = false;
            this.BtnCloseFormInitPassword.Click += new System.EventHandler(this.BtnCloseFormInitPassword_Click);
            // 
            // FormInitializePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(326, 136);
            this.Controls.Add(this.BtnCloseFormInitPassword);
            this.Controls.Add(this.BtnValidPassword);
            this.Controls.Add(this.TxtConfirPasswordInit);
            this.Controls.Add(this.TxtPassworInit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInitializePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rénitialiser mot de passe";
            this.Load += new System.EventHandler(this.FormInitializePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPassworInit;
        private System.Windows.Forms.TextBox TxtConfirPasswordInit;
        private FontAwesome.Sharp.IconButton BtnValidPassword;
        private FontAwesome.Sharp.IconButton BtnCloseFormInitPassword;
    }
}