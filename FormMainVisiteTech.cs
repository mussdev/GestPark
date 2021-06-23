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
    public partial class FormMainVisiteTech : Form
    {
        public FormMainVisiteTech()
        {
            InitializeComponent();
        }

        private void iconBtnCloseFormVisit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconBtnCreateVisit_Click(object sender, EventArgs e)
        {
            Form CreateVisit = new FormCreateVisit();
            CreateVisit.ShowDialog();
        }
    }
}
