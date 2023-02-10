using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using GestPark.Vues.Consult;

namespace GestPark
{
    public partial class FormSuiviVehicule : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataAdapter SqlAda;
        public FormSuiviVehicule()
        {
            InitializeComponent();
        }

        private void IbtnCloseFormSuiviVehi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IbtnSeachSuiviVehi_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT DISTINCT VEHICULE.CODE_VEHICULE, VEHICULE.ETAT_VEHICULE, VEHICULE.IMMATRICULATION_VEHICULE, VEHICULE.CARTE_GRISE_VEHICULE, VEHICULE.ASSURANCE_VEHICULE, VEHICULE.MODELE_VEHICULE, VEHICULE.PRIX_VEHICULE, VEHICULE.DATE_ACHA_VEHICULE, VEHICULE.DATE_ASSURANCE_VEHICULE, VEHICULE.DATE_VISITE_VEHICULE, TYPECONSOMMATION.DESCRIPTION_TYPCONSO, MARQUE.DESCRIPTION_MARQ, FOURNISSEUR.DESCRIPTION_FOUR, MOUVEMENTS.DATEDEPART_MVTS, MOUVEMENTS.DATEARRIVE_MVTS, MOUVEMENTS.DESCRIPTION_MVTS, MOUVEMENTS.LIEU_MVTS, PERSONNELS.DESCRIPTION_PERS, MOUVEMENTS.KILOMETRE_AVA_MVTS, MOUVEMENTS.KILO_APRES_MVTS FROM VEHICULE LEFT OUTER JOIN PARKING ON PARKING.ID_PARK=VEHICULE.ID_PARK LEFT OUTER JOIN TYPECONSOMMATION ON TYPECONSOMMATION.ID_TYPCONSO=VEHICULE.ID_TYPCONSO LEFT OUTER JOIN MARQUE ON MARQUE.ID_MARQ=VEHICULE.ID_MARQ LEFT OUTER JOIN FOURNISSEUR ON FOURNISSEUR.ID_FOUR=VEHICULE.ID_FOUR LEFT OUTER JOIN MOUVEMENTS ON VEHICULE.ID_VEHICULE = MOUVEMENTS.ID_VEHICULE LEFT OUTER JOIN PERSONNELS ON MOUVEMENTS.ID_PERS = PERSONNELS.ID_PERS", Conn.cn);
                        // SqlCmd.Parameters.AddWithValue("@IMMATRICULATION_VEHICULE", string.Format("%{0}%", TbxSearchSuiviVehi.Text));
                        SqlAda = new SqlDataAdapter(SqlCmd);
                        DataSet Tb = new DataSet();
                        SqlAda.Fill(Tb);

                        // Fill DataGridView
                        DgvSuiviVehicule.AutoGenerateColumns = false;
                        DgvSuiviVehicule.DataSource = Tb.Tables[0];
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IbtnSeachSuiviVehi_Click_1(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);

                SqlCmd = new SqlCommand("SELECT * FROM VEHICULE AS V INNER JOIN MOUVEMENTS AS M ON V.ID_VEHICULE=M.ID_VEHICULE WHERE M.STATUT_MVTS='En cours' AND V.ETAT_VEHICULE='Sortir'", Conn.cn);
                SqlAda = new SqlDataAdapter(SqlCmd);
                DataSet Tb = new DataSet();
                SqlAda.Fill(Tb);

                // Fill DataGridView
                DgvSuiviVehicule.AutoGenerateColumns = false;
                DgvSuiviVehicule.DataSource = Tb.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvSuiviVehicule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvSuiviVehicule.Columns[e.ColumnIndex].Name == "traceGPSVehi")
            {
                FormTraceGPSVehicule TraceVehicule = new FormTraceGPSVehicule();
                string addressGps = "";
                try
                {
                    StringBuilder queryGps = new StringBuilder();
                    queryGps.Append("http://maps.google.com");
                    if(addressGps != string.Empty)
                    {
                        queryGps.Append(addressGps + "," + "+");
                    }
                    TraceVehicule.webBrowserTraceGps.Navigate(queryGps.ToString());
                    TraceVehicule.ShowDialog();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Fleet: Gestion des erreurs",MessageBoxButtons.OK, MessageBoxIcon.Error);    
                }
                
            }
        }
    }
}
