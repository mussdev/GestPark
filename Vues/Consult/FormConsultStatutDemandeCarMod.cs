using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestPark.Vues.Consult
{
    public partial class FormConsultStatutDemandeCarMod : Form
    {
        public FormConsultStatutDemandeCarMod()
        {
            InitializeComponent();
        }

        private void listBoxDemandeCarMod_DoubleClick(object sender, EventArgs e)
        {
            FormModifyMouvement.frmModifyMouvement.txtValMvtMod.Text = listBoxDemandeCarMod.Text;
            this.Close();  
        }
    }
}
