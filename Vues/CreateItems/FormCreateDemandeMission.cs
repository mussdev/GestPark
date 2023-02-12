using GestPark.Vues.Consult;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GestPark.Vues.CreateItems
{
    public partial class FormCreateDemandeMission : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataReader MyReader;
        private Guid IdCarMission, IdPersMission, IdConducteurMission;
        private SqlDataAdapter SqlAda;
        private DataSet Ds;
        public FormCreateDemandeMission()
        {
            InitializeComponent();
            ListVehicule();
            ListConducteur();
            ListPersonnel();
        }

        private void ListVehicule()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                FormConsultStatutDemandeCar CallFallAskCar = new FormConsultStatutDemandeCar();
                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("SELECT * FROM VEHICULE WHERE SANTE_VEHICULE='Bon'", Conn.cn);
                    MyReader = SqlCmd.ExecuteReader();

                    while (MyReader.Read())
                    {
                        cbxImmatVehicule_miss.Items.Add(new KeyValuePair<Guid, string>((Guid)MyReader["ID_VEHICULE"], (string)MyReader["IMMATRICULATION_VEHICULE"].ToString()));
                        cbxImmatVehicule_miss.DisplayMember = "Value";
                        cbxImmatVehicule_miss.ValueMember = "Key"; ;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListConducteur()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                FormConsultStatutDemandeCar CallFallAskCar = new FormConsultStatutDemandeCar();
                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("SELECT * FROM CONDUCTEURS WHERE DISPMISSION_COND <> '0' ", Conn.cn);
                    MyReader = SqlCmd.ExecuteReader();

                    while (MyReader.Read())
                    {
                        cbxConducteurMission.Items.Add(new KeyValuePair<Guid, string>((Guid)MyReader["ID_COND"], (string)MyReader["DESCRIPTION_COND"].ToString()));
                        cbxConducteurMission.DisplayMember = "Value";
                        cbxConducteurMission.ValueMember = "Key"; ;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListPersonnel()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                FormConsultStatutDemandeCar CallFallAskCar = new FormConsultStatutDemandeCar();
                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("SELECT * FROM PERSONNELS ", Conn.cn);
                    MyReader = SqlCmd.ExecuteReader();

                    while (MyReader.Read())
                    {
                        cbxDemandeurMission.Items.Add(new KeyValuePair<Guid, string>((Guid)MyReader["ID_PERS"], (string)MyReader["DESCRIPTION_PERS"].ToString()));
                        cbxDemandeurMission.DisplayMember = "Value";
                        cbxDemandeurMission.ValueMember = "Key"; ;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxImmatVehicule_miss_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        if (!string.IsNullOrEmpty(cbxImmatVehicule_miss.Text))
                        {
                            SqlCmd = new SqlCommand("SELECT ID_VEHICULE FROM VEHICULE WHERE IMMATRICULATION_VEHICULE = '" + cbxImmatVehicule_miss.SelectedItem + "' ", Conn.cn);
                            MyReader = SqlCmd.ExecuteReader();
                            while (MyReader.Read())
                            {
                                IdCarMission = Guid.Parse(MyReader["ID_VEHICULE"].ToString());
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxConducteurMission_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        if (!string.IsNullOrEmpty(cbxConducteurMission.Text))
                        {
                            SqlCmd = new SqlCommand("SELECT * FROM CONDUCTEURS WHERE DESCRIPTION_COND = '" + cbxConducteurMission.Text + "' ", Conn.cn);
                            MyReader = SqlCmd.ExecuteReader();
                            while (MyReader.Read())
                            {
                                IdConducteurMission = Guid.Parse(MyReader["ID_COND"].ToString());
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxDemandeurMission_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        if (!string.IsNullOrEmpty(cbxDemandeurMission.Text))
                        {
                            SqlCmd = new SqlCommand("SELECT * FROM PERSONNELS WHERE DESCRIPTION_PERS = '" + cbxDemandeurMission.Text + "' ", Conn.cn);
                            MyReader = SqlCmd.ExecuteReader();
                            while (MyReader.Read())
                            {
                                IdPersMission = Guid.Parse(MyReader["ID_PERS"].ToString());
                                TxtNameDemandeur.Text = MyReader["NOM_PERS"].ToString();
                                txtFirstNameDemandeur.Text = MyReader["PRENOM_PERS"].ToString();
                                TxtFonctionDemandeur.Text = MyReader["FONCTION_PERS"].ToString();
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Generate code of mission
        private string generateCodeMission()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        // Generate code attribution car to person
                        SqlCmd = new SqlCommand("SELECT CODE_MISS FROM MISSION WHERE CODE_MISS=(SELECT MAX(CODE_MISS) FROM MISSION)", Conn.cn);
                        SqlAda = new SqlDataAdapter(SqlCmd);
                        Ds = new DataSet();
                        SqlAda.Fill(Ds);

                        if (Ds.Tables[0].Rows.Count > 0)
                        {
                            TxtCodeMission.Text = Ds.Tables[0].Rows[0]["CODE_MISS"].ToString();
                        }
                        else
                        {
                            TxtCodeMission.Text = "MISS0000";
                        }
                        if (!string.IsNullOrEmpty(TxtCodeMission.Text))
                        {
                            TxtCodeMission.SelectionStart = 4;
                            TxtCodeMission.SelectionLength = 4;
                            TxtCodeMission.Text = TxtCodeMission.SelectedText;
                        }
                        if (!string.IsNullOrEmpty(TxtCodeMission.Text))
                        {
                            int codeCarMvt = int.Parse(TxtCodeMission.Text.ToString()) + 1;
                            TxtCodeMission.Text = codeCarMvt.ToString("MISS0000");
                        }
                    }
                    else
                        MessageBox.Show("Veillez réviser les paramètres de connexion à la base de données !", "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return TxtCodeMission.Text;
        }
    }
}
