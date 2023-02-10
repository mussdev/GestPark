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
    public partial class FormAlerteVisiteTechnique : Form
    {
        private DataTable Dt;
        private SqlDataAdapter SqlAda;
        public FormAlerteVisiteTechnique()
        {
            InitializeComponent();
            listCarOfVisitTech();
            DgvVisitTech.Columns["DATEALERTEVISITETECH"].DefaultCellStyle.ForeColor = Color.Red;
            DgvVisitTech.Columns["VisitTech"].DefaultCellStyle.ForeColor = Color.Blue;
            DgvVisitTech.Columns["DATEPROCHAINEVISITETECH"].DefaultCellStyle.ForeColor = Color.FromArgb(52, 255, 10);
        }

        private void btnCloseAlertVisitTech_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listCarOfVisitTech()
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
                        DgvVisitTech.AutoGenerateColumns = false;
                        DgvVisitTech.DataSource = Dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ParcAuto: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void DgvVisitTech_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvVisitTech.Columns[e.ColumnIndex].Name == "VisitTech")
            {
                FormCreateVisitTechCar CreateVisit = new FormCreateVisitTechCar();
                CreateVisit.cbxCarVisitTech.Text = this.DgvVisitTech.CurrentRow.Cells["IMMATRICULATION_VEHICULE"].Value.ToString();
                CreateVisit.ShowDialog();
            }
        }
    }
}
