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
    public partial class FormEtatChargeDesVehicule : Form
    {
        public FormEtatChargeDesVehicule()
        {
            InitializeComponent();
        }

        private void FormEtatChargeDesVehicule_Load(object sender, EventArgs e)
        {

            this.reportViewerChargeVehicule.RefreshReport();
        }
    }
}
