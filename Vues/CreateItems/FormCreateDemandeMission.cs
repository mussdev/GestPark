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
using static System.Windows.Forms.AxHost;

namespace GestPark.Vues.CreateItems
{
    public partial class FormCreateDemandeMission : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataReader MyReader;
        private Guid? IdCarMission=null, IdPersMission=null, IdConducteurMission=null;
        private SqlDataAdapter SqlAda;
        private DataSet Ds;
        public FormCreateDemandeMission()
        {
            InitializeComponent();
            ListVehicule();
            ListConducteur();
            ListPersonnel();
           // CheckVerifyEnabling();
            //MessageBox.Show("Moyen de deplacement" + " Avoin : " + ChkAvionMission.Checked + " Voiture societe : " + ChkVehiSocMission.Checked + " Voiture personnel : " + ChkVehiPersoMission.Checked);
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

        /** Methode qui permet d'enregistrer et faire la demande de mission **/
        private void IbtnRegisterMission_Click(object sender, EventArgs e)
        {
            DemandeDeMission();
            this.Close();
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

        private void ChkVehiSocMission_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkVehiSocMission.Checked)
            {
                ChkVehiPersoMission.Enabled = false;
                ChkAvionMission.Enabled = false;
            }
            else
            {
                ChkVehiPersoMission.Enabled = true;
                ChkAvionMission.Enabled = true;
            }
            
        }

        private void ChkVehiPersoMission_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkVehiPersoMission.Checked)
            {
                ChkVehiSocMission.Enabled = false;
                ChkAvionMission.Enabled = false;
            }
            else
            {
                ChkVehiSocMission.Enabled = true;
                ChkAvionMission.Enabled = true;
            }
            
        }

        private void checkBoxSignAgentSupMission_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSignAgentSupMission.Checked)
            {
                checkBoxAnnulAgentSupMission.Enabled= false;
            }
            else
            {
                checkBoxAnnulAgentSupMission.Enabled = true;
            }
        }

        private void checkBoxAnnulAgentSupMission_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAnnulAgentSupMission.Checked)
            {
                checkBoxSignAgentSupMission.Enabled = false;
            }
            else
            {
                checkBoxSignAgentSupMission.Enabled = true;
            }
        }

        private void checkBoxSignDirecDepMission_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSignDirecDepMission.Checked)
            {
                checkBoxAnnulDirDepMission.Enabled = false;
            }
            else
            {
                checkBoxAnnulDirDepMission.Enabled= true;
            }
        }

        private void checkBoxAnnulDirDepMission_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAnnulDirDepMission.Checked)
            {
                checkBoxSignDirecDepMission.Enabled = false;
            }
            else
            {
                checkBoxSignDirecDepMission.Enabled = true;
            }
        }

        private void checkBoxSignDarhMission_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSignDarhMission.Checked)
            {
                checkBoxAnnulDarhMission.Enabled = false;
            }
            else
            {
                checkBoxAnnulDarhMission.Enabled = true;
            }
        }

        private void checkBoxAnnulDarhMission_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAnnulDarhMission.Checked)
            {
                checkBoxSignDarhMission.Enabled = false;
            }
            else
            {
                checkBoxSignDarhMission.Enabled = true;
            }
        }

        private void checkBoxSignDirMission_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSignDGMission.Checked)
            {
                checkBoxAnnulDGMission.Enabled = false;
            }
            else
            {
                checkBoxAnnulDGMission.Enabled= true;
            }
        }

        private void checkBoxAnnulDirMission_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAnnulDGMission.Checked)
            {
                checkBoxSignDGMission.Enabled = false;
            }
            else
            {
                checkBoxSignDGMission.Enabled = true;
            }
        }

        private void ChkAvionMission_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkAvionMission.Checked)
            {
                ChkVehiSocMission.Enabled = false;
                ChkVehiPersoMission.Enabled = false;
            }
            else
            {
                ChkVehiSocMission.Enabled = true;
                ChkVehiPersoMission.Enabled = true;
            }
            
        }

        /**
         * Methode qui permet de soumettre plusieurs projets de missions
         */
        private void BtnRegisterMission_Click(object sender, EventArgs e)
        {
            DemandeDeMission();
            CleanFieldsMIssion();
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

        private void BtnRefreshMission_Click(object sender, EventArgs e)
        {
            CleanFieldsMIssion();
        }

        /**
         * Methode qui permet de soumettre un projet de mission !
         * **/
        private void DemandeDeMission()
        {
            if (string.IsNullOrEmpty(cbxDemandeurMission.Text))
            {
                MessageBox.Show("Sélectionner le demandeur de mission svp !!!", "Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtDestinationMission.Text))
            {
                MessageBox.Show("Saisir le lieu de destination svp !!!", "Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(RtxtObjetMission.Text))
            {
                MessageBox.Show("Saisir l'objet de votre mission svp !!!", "Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                    ConnectDB Conn = new ConnectDB(connectionString);

                    using (Conn.cn)
                    {
                        if (Conn.IsConnection)
                        {
                            string CodProjectMission = generateCodeMission();

                            using (var Cmd = Conn.cn.CreateCommand())
                            {
                                Cmd.CommandText = "INSERT INTO MISSION (ID_VEHI,ID_CONDUC,ID_PERS,CODE_MISS,OBJET_MISS,MOYEN_DEPLA_AVION_MISS,MOYEN_DEPLA_VEHI_SOC_MISS,MOYEN_DEPLA_VEHI_PERS_MISS,DESTINATION_MISS,DATE_DEBUT_MISS,DATE_FIN_MISS,DATEREGISTER_MISS,DATECREATE_MISS,SIGN_DEMANDEUR_MISS,SIGN_CHEF_SERV_MISS,SIGN_DIR_MISS,SIGN_DARH_DARH_MISS,SIGN_DG_MISS,AUTRE_MOYEN_DEPLAC,ANNULE_SUP_HIERACHIQ,ANNULE_DIR_DEPART,ANNULE_DARH,ANNULE_DIR) VALUES (@ID_VEHI,@ID_CONDUC,@ID_PERS,@CODE_MISS,@OBJET_MISS,@MOYEN_DEPLA_AVION_MISS,@MOYEN_DEPLA_VEHI_SOC_MISS,@MOYEN_DEPLA_VEHI_PERS_MISS,@DESTINATION_MISS,@DATE_DEBUT_MISS,@DATE_FIN_MISS,@DATEREGISTER_MISS,GETDATE(),@SIGN_DEMANDEUR_MISS,@SIGN_CHEF_SERV_MISS,@SIGN_DIR_MISS,@SIGN_DARH_DARH_MISS,@SIGN_DG_MISS,@AUTRE_MOYEN_DEPLAC,@ANNULE_SUP_HIERACHIQ,@ANNULE_DIR_DEPART,@ANNULE_DARH,@ANNULE_DIR)";

                                if (IdCarMission.HasValue)
                                    Cmd.Parameters.AddWithValue("@ID_VEHI", IdCarMission.Value);
                                else
                                    Cmd.Parameters.AddWithValue("@ID_VEHI", DBNull.Value);

                                if (IdPersMission.HasValue)
                                    Cmd.Parameters.AddWithValue("@ID_PERS", IdPersMission.Value);
                                else
                                    Cmd.Parameters.AddWithValue("@ID_PERS", DBNull.Value);

                                if (IdConducteurMission.HasValue)
                                    Cmd.Parameters.AddWithValue("@ID_CONDUC", IdConducteurMission.Value);
                                else
                                    Cmd.Parameters.AddWithValue("@ID_CONDUC", DBNull.Value);

                                Cmd.Parameters.AddWithValue("@CODE_MISS", CodProjectMission);
                                Cmd.Parameters.AddWithValue("@OBJET_MISS", RtxtObjetMission.Text);
                                Cmd.Parameters.AddWithValue("@MOYEN_DEPLA_AVION_MISS", ChkAvionMission.Checked);
                                Cmd.Parameters.AddWithValue("@MOYEN_DEPLA_VEHI_SOC_MISS", ChkVehiSocMission.Checked);
                                Cmd.Parameters.AddWithValue("@MOYEN_DEPLA_VEHI_PERS_MISS", ChkVehiPersoMission.Checked);
                                Cmd.Parameters.AddWithValue("@DESTINATION_MISS", TxtDestinationMission.Text);
                                Cmd.Parameters.AddWithValue("@DATE_DEBUT_MISS", DateDebutMission.Value.ToString("dd/MM/yyy"));
                                Cmd.Parameters.AddWithValue("@DATE_FIN_MISS", DateFinMission.Value.ToString("dd/MM/yyy"));
                                Cmd.Parameters.AddWithValue("@DATEREGISTER_MISS", DateRegisterMission.Value.ToString("dd/MM/yyy"));
                                Cmd.Parameters.AddWithValue("@AUTRE_MOYEN_DEPLAC", TxtAutreMoyenDeplacMission.Text);
                                Cmd.Parameters.AddWithValue("@SIGN_DEMANDEUR_MISS", checkBoxSignAgentMission.Checked);
                                Cmd.Parameters.AddWithValue("@SIGN_CHEF_SERV_MISS", checkBoxSignAgentSupMission.Checked);
                                Cmd.Parameters.AddWithValue("@SIGN_DIR_MISS", checkBoxSignDirecDepMission.Checked);
                                Cmd.Parameters.AddWithValue("@SIGN_DARH_DARH_MISS", checkBoxSignDarhMission.Checked);
                                Cmd.Parameters.AddWithValue("@SIGN_DG_MISS", checkBoxSignDGMission.Checked);
                                Cmd.Parameters.AddWithValue("@ANNULE_SUP_HIERACHIQ", checkBoxAnnulAgentSupMission.Checked);
                                Cmd.Parameters.AddWithValue("@ANNULE_DIR_DEPART", checkBoxAnnulDirDepMission.Checked);
                                Cmd.Parameters.AddWithValue("@ANNULE_DARH", checkBoxAnnulDarhMission.Checked);
                                Cmd.Parameters.AddWithValue("@ANNULE_DIR", checkBoxAnnulDGMission.Checked);
                                Cmd.ExecuteNonQuery();
                                MessageBox.Show("Votre projet de mission a été soumis avec succès !!!" + "\n" + "Veillez vous connecter regulièrement pour le suivi. Merci", "Fleet: Information", MessageBoxButtons.OK);
                                //this.Close();
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

        /**
         * Methode qui efface le contenu des champs saisis par l'utilisateur
         */
        private void CleanFieldsMIssion()
        {
            cbxConducteurMission.Items.Clear();cbxDemandeurMission.Items.Clear();cbxImmatVehicule_miss.Items.Clear();TxtCodeMission.Clear();TxtNameDemandeur.Clear();txtFirstNameDemandeur.Clear(); TxtDestinationMission.Clear();  TxtFonctionDemandeur.Clear();RtxtObjetMission.Clear(); TxtAutreMoyenDeplacMission.Clear(); ChkAvionMission.Refresh();   ChkVehiPersoMission.Refresh();  ChkVehiSocMission.Refresh(); ChkVehiPersoMission.Refresh();
            checkBoxAnnulAgentSupMission.Checked = false;checkBoxAnnulDarhMission.Checked = false;checkBoxAnnulAgentSupMission.Checked=false; checkBoxAnnulDirDepMission.Checked = false;   
            checkBoxSignAgentMission.Checked = false; checkBoxSignAgentSupMission.Checked = false;checkBoxSignDarhMission.Checked=false; checkBoxSignDGMission.Checked = false; checkBoxAnnulDGMission.Checked=false;
        }

    }
}
