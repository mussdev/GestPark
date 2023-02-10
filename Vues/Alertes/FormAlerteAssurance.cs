using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace GestPark
{
    public partial class FormAlerteAssurance : Form
    {
        private SqlDataAdapter SqlAda;
        private DataTable Dt;
        public FormAlerteAssurance()
        {
            InitializeComponent();
            listCarOfAssurance();
            DgvAssur.Columns["DATEALERTEASSURANCE"].DefaultCellStyle.ForeColor = Color.Red;
            DgvAssur.Columns["AssuranceAuto"].DefaultCellStyle.ForeColor = Color.Blue;
            DgvAssur.Columns["DATEPROCHAINEASSURANCE"].DefaultCellStyle.ForeColor = Color.FromArgb(52, 255, 10);
        }

        private void btnCloseAlertAssur_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listCarOfAssurance()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        // Display data in datagridview
                        SqlAda = new SqlDataAdapter("select*from vehicule left outer join marque on vehicule.id_marq=marque.id_marq left outer join typeconsommation on typeconsommation.id_typconso=vehicule.id_typconso left outer join fournisseur on fournisseur.id_four=vehicule.id_four", Conn.cn);
                        Dt = new DataTable();
                        SqlAda.Fill(Dt);
                        DgvAssur.AutoGenerateColumns = false;
                        DgvAssur.DataSource = Dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ParcAuto: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void DgvAssur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvAssur.Columns[e.ColumnIndex].Name == "AssuranceAuto")
            {
                FormCreateAssurance CreateAssur = new FormCreateAssurance();
                CreateAssur.cbxCarAssur.Text = this.DgvAssur.CurrentRow.Cells["IMMATRICULATION_VEHICULE"].Value.ToString();
                CreateAssur.ShowDialog();
            }
        }
    }
}
