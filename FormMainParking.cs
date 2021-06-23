using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestPark
{
    public partial class FormMainParking : Form
    {
        public FormMainParking()
        {
            InitializeComponent();
        }

        private System.Windows.Forms.Form activeFormParking = null;
        private void openChildFormParking(System.Windows.Forms.Form childFormParking)
        {
            if (childFormParking != null)
                //activeForm.Close();
                activeFormParking = childFormParking;
            childFormParking.TopLevel = false;
            childFormParking.FormBorderStyle = FormBorderStyle.None;
            childFormParking.Dock = DockStyle.Fill;
            PanelAddFormParcking.Controls.Add(childFormParking);
            PanelAddFormParcking.Tag = childFormParking;
            childFormParking.BringToFront();
            childFormParking.Show();
        }

        private void CreerEmplacementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildFormParking(new FormCreatePlaceParcking());
        }

        private void FermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
