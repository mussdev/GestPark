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
    public partial class FormConsultStatutDemandeCar : Form
    {
        public FormConsultStatutDemandeCar()
        {
            InitializeComponent();
        }

        private void listValidationDemandeCar_DoubleClick(object sender, EventArgs e)
        {
            FormCreateMouvement.formCreateMouvement.txtValMvt.Text = listValidationDemandeCar.Text;
            this.Close();
        }
    }
}
