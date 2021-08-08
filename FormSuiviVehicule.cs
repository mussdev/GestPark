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
                MessageBox.Show(ex.ToString(), "GestPark : GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
