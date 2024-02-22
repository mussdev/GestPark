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
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GestPark.Vues.CreateItems
{
    public partial class FormProjetDeMissionGroupe : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataReader MyReader;
        private Guid IdPersMissGrp, IdCarMissGrp, IdConducteurMissGrp;
        private string DemandeurFonction, DemandeurCategorie;
        public FormProjetDeMissionGroupe()
        {
            InitializeComponent();
            ListVehiculeMissGrp();
            ListConducteurMissGrp();
            ListPersonnelMissGrp();
        }

        private void ListVehiculeMissGrp()
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
                        cbxImmatVehiculeMissGrp.Items.Add(new KeyValuePair<Guid, string>((Guid)MyReader["ID_VEHICULE"], (string)MyReader["IMMATRICULATION_VEHICULE"].ToString()));
                        cbxImmatVehiculeMissGrp.DisplayMember = "Value";
                        cbxImmatVehiculeMissGrp.ValueMember = "Key"; ;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListConducteurMissGrp()
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
                        cbxConducteurMissGrp.Items.Add(new KeyValuePair<Guid, string>((Guid)MyReader["ID_COND"], (string)MyReader["DESCRIPTION_COND"].ToString()));
                        cbxConducteurMissGrp.DisplayMember = "Value";
                        cbxConducteurMissGrp.ValueMember = "Key"; ;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListPersonnelMissGrp()
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
                        CbxDemandeurMissGrp.Items.Add(new KeyValuePair<Guid, string>((Guid)MyReader["ID_PERS"], (string)MyReader["DESCRIPTION_PERS"].ToString()));
                        CbxDemandeurMissGrp.DisplayMember = "Value";
                        CbxDemandeurMissGrp.ValueMember = "Key"; ;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /**
         * Methode qui efface le contenu des champs saisis par l'utilisateur
         */
        private void CleanFieldsMissGrp()
        {
            TxtCodeMissGrp.Clear(); RtxtObjetMissGrp.Clear(); TxtDestinationMissGrp.Clear(); CbxDemandeurMissGrp.Text = null; cbxConducteurMissGrp.Text = null; cbxImmatVehiculeMissGrp.Text = null; TxtAutreMoyenDeplacMissGrp.Clear();
            ChkAvionMissGrp.Checked = false; ChkVehiPersoMissGrp.Checked = false;ChkVehiSocMissGrp.Checked = false; checkBoxSignAgentMissGrp.Checked=false; checkBoxAnnulAgentSupMissGrp.Checked = false;   checkBoxAnnulDarhMissGrp.Checked = false;   checkBoxAnnulDGMissGrp.Checked = false; checkBoxAnnulDirDepMissGrp.Checked = false; 
            checkBoxSignAgentSupMissGrp.Checked= false;checkBoxSignDarhMissGrp.Checked = false;checkBoxSignDGMissGrp.Checked = false;   checkBoxSignDirecDepMissGrp.Checked = false;    
        }

        private void BtnRefreshMissGrp_Click(object sender, EventArgs e)
        {
            CleanFieldsMissGrp();
        }

        private void ChkVehiSocMissGrp_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkVehiSocMissGrp.Checked)
            {
                ChkVehiPersoMissGrp.Enabled = false;
                ChkAvionMissGrp.Enabled = false;
            }
            else
            {
                ChkVehiPersoMissGrp.Enabled = true;
                ChkAvionMissGrp.Enabled = true;
            }
        }

        private void ChkVehiPersoMissGrp_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkVehiPersoMissGrp.Checked)
            {
                ChkVehiSocMissGrp.Enabled = false;
                ChkAvionMissGrp.Enabled = false;
            }
            else
            {
                ChkVehiSocMissGrp.Enabled = true;
                ChkAvionMissGrp.Enabled = true;
            }
        }

        private void ChkAvionMissGrp_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkAvionMissGrp.Checked)
            {
                ChkVehiSocMissGrp.Enabled = false;
                ChkVehiPersoMissGrp.Enabled = false;
            }
            else
            {
                ChkVehiSocMissGrp.Enabled = true;
                ChkVehiPersoMissGrp.Enabled = true;
            }
        }

        private void checkBoxSignAgentSupMissGrp_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSignAgentSupMissGrp.Checked)
                checkBoxAnnulAgentSupMissGrp.Enabled = false;
            else
                checkBoxAnnulAgentSupMissGrp.Enabled = true;
        }

        private void checkBoxSignDirecDepMissGrp_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSignDirecDepMissGrp.Checked)
                checkBoxAnnulDirDepMissGrp.Enabled = false;
            else
                checkBoxAnnulDirDepMissGrp.Enabled = true;
        }

        private void checkBoxSignDarhMissGrp_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxSignDarhMissGrp.Checked)
                checkBoxAnnulDarhMissGrp.Enabled = false;
            else
                checkBoxAnnulDarhMissGrp.Enabled = true;
        }

        private void checkBoxSignDGMissGrp_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSignDGMissGrp.Checked)
                checkBoxAnnulDGMissGrp.Enabled = false;
            else
                checkBoxAnnulDGMissGrp.Enabled = true;
        }

        private void cbxConducteurMissGrp_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        if (!string.IsNullOrEmpty(cbxConducteurMissGrp.Text))
                        {
                            SqlCmd = new SqlCommand("SELECT * FROM CONDUCTEURS WHERE DESCRIPTION_COND = '" + cbxConducteurMissGrp.Text + "' ", Conn.cn);
                            MyReader = SqlCmd.ExecuteReader();
                            while (MyReader.Read())
                            {
                                IdConducteurMissGrp = Guid.Parse(MyReader["ID_COND"].ToString());
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

        private void cbxImmatVehiculeMissGrp_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        if (!string.IsNullOrEmpty(cbxImmatVehiculeMissGrp.Text))
                        {
                            SqlCmd = new SqlCommand("SELECT ID_VEHICULE FROM VEHICULE WHERE IMMATRICULATION_VEHICULE = '" + cbxImmatVehiculeMissGrp.SelectedItem + "' ", Conn.cn);
                            MyReader = SqlCmd.ExecuteReader();
                            while (MyReader.Read())
                            {
                                IdCarMissGrp = Guid.Parse(MyReader["ID_VEHICULE"].ToString());
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

        private void CbxDemandeurMissGrp_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        if (!string.IsNullOrEmpty(CbxDemandeurMissGrp.Text))
                        {
                            SqlCmd = new SqlCommand("SELECT * FROM PERSONNELS WHERE DESCRIPTION_PERS = '" + CbxDemandeurMissGrp.Text + "' ", Conn.cn);
                            MyReader = SqlCmd.ExecuteReader();
                            while (MyReader.Read())
                            {
                                IdPersMissGrp = Guid.Parse(MyReader["ID_PERS"].ToString());
                                DemandeurCategorie = MyReader["CATEGORIE_PERS"].ToString();
                                DemandeurFonction = MyReader["FONCTION_PERS"].ToString();
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
    }
}
