using GestPark.Vues.Consult;
using GestPark.Vues.CreateItems;
using Microsoft.Office.Core;
using Stimulsoft.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GestPark.Vues.ModifierItems
{
    public partial class FormModifierProjetMission : Form
    {
        //FormCreateDemandeMission CreateDemandeMission = new FormCreateDemandeMission();
        private SqlCommand SqlCmd;
        private SqlDataReader MyReader;
        public static string DescriptionDemandeur;
        private Guid IdMissionMod;
        public FormModifierProjetMission()
        {
            InitializeComponent();
            //CreateDemandeMission.ListConducteurs();
            ListPersonnel();
            ListConducteur();
            ListVehicule();
        }

        private void SubMenuFicheProjetMissMod_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtCodeMissionMod.Text))
            {
                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                    ConnectDB conn = new ConnectDB(connectionString);
                    
                    using (conn.cn)
                    {
                        if (conn.IsConnection)
                        {
                            using(var Cmd = conn.cn.CreateCommand())
                            {
                                Cmd.CommandText = "SELECT ID_MISS FROM MISSION WHERE CODE_MISS='"+TxtCodeMissionMod.Text+"'";
                                MyReader = Cmd.ExecuteReader();

                                while(MyReader.Read())
                                {
                                    IdMissionMod = Guid.Parse(MyReader["ID_MISS"].ToString());
                                }
                                MessageBox.Show("Id mission : " + IdMissionMod);
                                //MessageBox.Show("Id mission : " + KeyMission);
                                var reportFicheProjetMiss = new StiReport();
                                reportFicheProjetMiss.Load("FicheProjetMission.mrt");
                                reportFicheProjetMiss.Dictionary.Synchronize();
                                reportFicheProjetMiss.Compile();
                                reportFicheProjetMiss["MainID"] = IdMissionMod;
                                //reportFicheProjetMiss.Design();
                                //report.Show();
                                reportFicheProjetMiss.Show();
                                //reportFicheProjetMiss.Show();
                            }
                        }
                    }
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(),"Fleet: Gestion des erreurs !",MessageBoxButtons.OK, MessageBoxIcon.Error);   
                }
            }
            else
            {
                //DemandeDeMission();
            }
        }

        private void SubMenuOrdreMissMod_Click(object sender, EventArgs e)
        {
            var reportFicheOrdreMiss = new StiReport();
            
            reportFicheOrdreMiss.Load("FicheOrdreMission.mrt");
            //report.Show();
            //reportFicheOrdreMiss.Dictionary.Synchronize();
            //reportFicheOrdreMiss.Compile();
            //reportFicheOrdreMiss.Show(true);
            reportFicheOrdreMiss.Design();
        }

        private void ChkVehiSocMissionMod_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkVehiSocMissionMod.Checked)
            {
                ChkAvionMissionMod.Enabled = false;
                ChkVehiPersoMissionMod.Enabled = false;
            }
            else
            {
                ChkAvionMissionMod.Enabled = true;
                ChkVehiPersoMissionMod.Enabled = true;
            }
        }

        private void ChkVehiPersoMissionMod_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkVehiPersoMissionMod.Checked)
            {
                ChkAvionMissionMod.Enabled = false;
                ChkVehiSocMissionMod.Enabled = false;
            }
            else
            {
                ChkAvionMissionMod.Enabled = true;
                ChkVehiSocMissionMod.Enabled = true;
            }
        }

        private void ChkAvionMissionMod_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkAvionMissionMod.Checked)
            {
                ChkVehiPersoMissionMod.Enabled = false;
                ChkVehiSocMissionMod.Enabled = false;
            }
            else
            {
                ChkVehiPersoMissionMod.Enabled = true;
                ChkVehiSocMissionMod.Enabled = true;
            }
        }

        private void checkBoxSignAgentSupMissionMod_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSignAgentSupMissionMod.Checked)
                checkBoxAnnulAgentSupMissionMod.Enabled = false;
            else
                checkBoxAnnulAgentSupMissionMod.Enabled = true;
        }

        private void checkBoxAnnulAgentSupMissionMod_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxAnnulAgentSupMissionMod.Checked)
                checkBoxSignAgentSupMissionMod.Enabled=false;
            else
                checkBoxSignAgentSupMissionMod.Enabled=true;
        }

        private void checkBoxSignDirecDepMissionMod_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxSignDirecDepMissionMod.Checked)
                checkBoxAnnulDirDepMissionMod.Enabled= false;
            else
                checkBoxAnnulDirDepMissionMod.Enabled=true;
        }

        private void checkBoxAnnulDirDepMissionMod_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxAnnulDirDepMissionMod.Checked)
                checkBoxSignDirecDepMissionMod.Enabled=false;
            else
                checkBoxSignDirecDepMissionMod.Enabled=true;
        }

        private void checkBoxSignDarhMissionMod_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSignDarhMissionMod.Checked)
                checkBoxAnnulDarhMissionMod.Enabled = false;
            else
                checkBoxAnnulDarhMissionMod.Enabled = true;
        }

        private void checkBoxAnnulDarhMissionMod_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAnnulDarhMissionMod.Checked)
                checkBoxSignDarhMissionMod.Enabled = false;
            else
                checkBoxSignDarhMissionMod.Enabled = true;
        }

        private void checkBoxSignDGMissionMod_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSignDGMissionMod.Checked)
                checkBoxAnnulDGMissionMod.Enabled = false;
            else
                checkBoxAnnulDGMissionMod.Enabled = true;
        }

        public void ListVehicule()
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
                        cbxImmatVehicule_missMod.Items.Add(new KeyValuePair<Guid, string>((Guid)MyReader["ID_VEHICULE"], (string)MyReader["IMMATRICULATION_VEHICULE"].ToString()));
                        cbxImmatVehicule_missMod.DisplayMember = "Value";
                        cbxImmatVehicule_missMod.ValueMember = "Key"; ;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ListConducteur()
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
                        cbxConducteurMissionMod.Items.Add(new KeyValuePair<Guid, string>((Guid)MyReader["ID_COND"], (string)MyReader["DESCRIPTION_COND"].ToString()));
                        cbxConducteurMissionMod.DisplayMember = "Value";
                        cbxConducteurMissionMod.ValueMember = "Key"; ;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ListPersonnel()
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
                        cbxDemandeurMissionMod.Items.Add(new KeyValuePair<Guid, string>((Guid)MyReader["ID_PERS"], (string)MyReader["DESCRIPTION_PERS"].ToString()));
                        cbxDemandeurMissionMod.DisplayMember = "Value";
                        cbxDemandeurMissionMod.ValueMember = "Key"; ;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnPrimeMissionMod_Click(object sender, EventArgs e)
        {
            // Faire afficher le nom du demandeur sur la fenêtre de calcul de prime
            DescriptionDemandeur = cbxDemandeurMissionMod.Text;

            FormOrdreDecision ordreDecision= new FormOrdreDecision();
            ordreDecision.Show();
        }
    }
}
