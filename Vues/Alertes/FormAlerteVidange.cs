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
    public partial class FormAlerteVidange : Form
    {
        private SqlDataAdapter SqlAda;
        private DataTable Dt;
        public FormAlerteVidange()
        {
            InitializeComponent();
            listCarOfVidange();
        }

        private void btnCloseAlertVidange_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listCarOfVidange()
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
                        SqlAda = new SqlDataAdapter("select*from vehicule left outer join marque on vehicule.id_marq=marque.id_marq left outer join typeconsommation on typeconsommation.id_typconso=vehicule.id_typconso left outer join fournisseur on fournisseur.id_four=vehicule.id_four where vehicule.KILOMETRAGE_VIDENGE_VEHICULE>=MARQUE.SEUIL_KILO_VDGE_MARQ", Conn.cn);
                        Dt = new DataTable();
                        SqlAda.Fill(Dt);
                        DgvVidange.AutoGenerateColumns = false;
                        DgvVidange.DataSource = Dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ParcAuto: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void FormAlerteVidange_Load(object sender, EventArgs e)
        {
            listCarOfVidange();
            DgvVidange.Columns["KILOMETRAGE_VIDENGE_VEHICULE"].DefaultCellStyle.ForeColor = Color.Maroon;
            DgvVidange.Columns["Vidange"].DefaultCellStyle.ForeColor = Color.Blue;
            //DgvVidange.Columns["Vidange"].DefaultCellStyle.BackColor = Color.Blue;
        }

        private void DgvVidange_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvVidange.Columns[e.ColumnIndex].Name == "Vidange")
            {
                FormCreateEntretien CreateEntretien = new FormCreateEntretien();
                CreateEntretien.txtCarVdge.Text = this.DgvVidange.CurrentRow.Cells["IMMATRICULATION_VEHICULE"].Value.ToString();
                CreateEntretien.ShowDialog();
            }
        }
    }
}
