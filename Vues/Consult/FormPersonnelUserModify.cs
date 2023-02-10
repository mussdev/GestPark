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
    public partial class FormPersonnelUserModify : Form
    {
        public FormPersonnelUserModify()
        {
            InitializeComponent();
        }

        private void listBoxPersMod_DoubleClick(object sender, EventArgs e)
        {
            FormModifyUser.modifyUser.txtPersonnelUserMod.Text = listBoxPersMod.Text;
            FormModifyUser.modifyUser.TxtDescriptionUserEdit.Text = listBoxPersMod.Text;
            this.Close();
        }
    }
}
