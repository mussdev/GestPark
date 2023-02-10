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
    public partial class FormModifyMouvement : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataReader MyReader;
        private SqlDataAdapter SqlAda;
        private Guid? IdVehiculeMod = null, IdPersDemaMod = null, IdConducMod = null, IdValMod = null, IdConducteurMvtMod = null;
        public static FormModifyMouvement frmModifyMouvement;

        private void CbxVehiculeMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_VEHICULE, IMMATRICULATION_VEHICULE  FROM VEHICULE WHERE IMMATRICULATION_VEHICULE = '" + CbxVehiculeMod.Text + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdVehiculeMod = Guid.Parse(MyReader["ID_VEHICULE"].ToString());
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FormModifyMouvement()
        {
            InitializeComponent();
            fillCbxCarPool();
            fillPersDemandeur();
            frmModifyMouvement = this;
            AllConducteurMod();
        }

        private void CbxDemandeurMvtMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        if (!string.IsNullOrEmpty(CbxDemandeurMvtMod.Text))
                        {
                            SqlCmd = new SqlCommand("SELECT ID_PERS, DESCRIPTION_SERV,DESCRIPTION_DIR FROM PERSONNELS INNER JOIN SERVICESENT ON SERVICESENT.ID_SERV=PERSONNELS.ID_SERV INNER JOIN DIRECTION ON DIRECTION.ID_DIR=SERVICESENT.ID_DIR WHERE DESCRIPTION_PERS = '" + CbxDemandeurMvtMod.SelectedItem + "' ", Conn.cn);
                            MyReader = SqlCmd.ExecuteReader();
                            while (MyReader.Read())
                            {
                                IdPersDemaMod = Guid.Parse(MyReader["ID_PERS"].ToString());
                                TxtServiceMvtMod.Text = MyReader["DESCRIPTION_SERV"].ToString();
                                TxtDirMvtMod.Text = MyReader["DESCRIPTION_DIR"].ToString();
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

        private void IbtnRegisterMvtTbxCodMvtMod_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                Guid? guidValidation = null;
                guidValidation = IdValidationMod();
                DialogResult result = MessageBox.Show("Voulez vous enregister les modificattions ?", "Fleet: Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (Conn.cn)
                    {
                        if (Conn.IsConnection)
                        {
                            string CodMvts = TbxCodMvtMod.Text;

                            if (!string.IsNullOrEmpty(CbxVehiculeMod.Text) && !string.IsNullOrEmpty(cbxConducteurMod.Text) && txtValMvtMod.Text.Equals("Valide Chef Section Parc Auto") && CbxStatutMvtMod.Text.Equals("En cours"))
                            {
                                SqlCmd = new SqlCommand("UPDATE MOUVEMENTS SET ID_PERS=@ID_PERS,ID_VEHICULE=@ID_VEHICULE,ID_VALMVT=@ID_VALMVT,ID_COND=@ID_COND, STATUT_MVTS=@STATUT_MVTS, LIEU_MVTS=@LIEU_MVTS,NOTE_MVTS=@NOTE_MVTS,DATEDEPARTSOUHAITE_MVTS=@DATEDEPARTSOUHAITE_MVTS, TIMESTART_MVTS=@TIMESTART_MVTS,TIMEEND_MVTS=@TIMEEND_MVTS,DATEEXECUTION=@DATEEXECUTION,DATERETOURPROBABLE=@DATERETOURPROBABLE,DATERETOURREEL=@DATERETOURREEL,DATEMODIFY_MVTS=GETDATE() WHERE CODE_MVTS = '" + CodMvts + "' ", Conn.cn);
                                if (IdPersDemaMod.HasValue)
                                    SqlCmd.Parameters.AddWithValue("@ID_PERS", IdPersDemaMod);
                                else
                                    SqlCmd.Parameters.AddWithValue("@ID_PERS", DBNull.Value);

                                if (IdVehiculeMod.HasValue)
                                    SqlCmd.Parameters.AddWithValue("@ID_VEHICULE", IdVehiculeMod.Value);
                                else
                                    SqlCmd.Parameters.AddWithValue("@ID_VEHICULE", DBNull.Value);

                                if (IdConducMod.HasValue)
                                    SqlCmd.Parameters.AddWithValue("@ID_COND", IdConducMod.Value);
                                else
                                    SqlCmd.Parameters.AddWithValue("@ID_COND", DBNull.Value);
                                //SqlCmd.Parameters.AddWithValue("@ID_PERS", IdPersDemaMod);
                                //SqlCmd.Parameters.AddWithValue("@ID_VEHICULE", IdVehiculeMod);
                                SqlCmd.Parameters.AddWithValue("@ID_VALMVT", guidValidation);
                                SqlCmd.Parameters.AddWithValue("@STATUT_MVTS", CbxStatutMvtMod.Text);
                                SqlCmd.Parameters.AddWithValue("@LIEU_MVTS", CbxLieuMvtsMod.Text);
                                //SqlCmd.Parameters.AddWithValue("@ID_COND", IdConducMod);
                                SqlCmd.Parameters.AddWithValue("@NOTE_MVTS", RtbxNoteMvtMod.Text);
                                SqlCmd.Parameters.AddWithValue("@DATEDEPARTSOUHAITE_MVTS", DateDepartSouhMvtMod.Value.ToString("dd/MM/yyyy"));
                                SqlCmd.Parameters.AddWithValue("@TIMESTART_MVTS", TimeStartMvtModi.Value.ToString("HH:mm"));
                                SqlCmd.Parameters.AddWithValue("@TIMEEND_MVTS", TimeEndMvtModi.Value.ToString("HH:mm"));
                                SqlCmd.Parameters.AddWithValue("@DATEEXECUTION", DateExecutionMod.Value.ToString("dd/MM/yyyy"));
                                SqlCmd.Parameters.AddWithValue("@DATERETOURPROBABLE", DateRetouProbMvtMod.Value.ToString("dd/MM/yyyy"));
                                SqlCmd.Parameters.AddWithValue("@DATERETOURREEL", DateRetouReelMod.Value.ToString("dd/MM/yyyy"));
                                SqlCmd.ExecuteNonQuery();
                                MessageBox.Show("Les informations ont été modifiées avec succès !", "Fleet: Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                /**
                                 * Changer le statut du véhicule pool lorsque le gestionnaire valide
                                 */
                                SqlCmd = new SqlCommand("UPDATE VEHICULE SET ETAT_VEHICULE=@ETAT_VEHICULE WHERE ID_VEHICULE='" + IdVehiculeMod + "'", Conn.cn);
                                SqlCmd.Parameters.AddWithValue("@ETAT_VEHICULE", "Sortir");
                                SqlCmd.ExecuteNonQuery();
                            }else if (!string.IsNullOrEmpty(CbxVehiculeMod.Text) && !string.IsNullOrEmpty(cbxConducteurMod.Text) && txtValMvtMod.Text.Equals("Valide Chef Section Parc Auto") && CbxStatutMvtMod.Text.Equals("Effectuée"))
                            {
                                SqlCmd = new SqlCommand("UPDATE MOUVEMENTS SET ID_PERS=@ID_PERS,ID_VEHICULE=@ID_VEHICULE,ID_VALMVT=@ID_VALMVT,ID_COND=@ID_COND, STATUT_MVTS=@STATUT_MVTS, LIEU_MVTS=@LIEU_MVTS,NOTE_MVTS=@NOTE_MVTS,DATEDEPARTSOUHAITE_MVTS=@DATEDEPARTSOUHAITE_MVTS, TIMESTART_MVTS=@TIMESTART_MVTS,TIMEEND_MVTS=@TIMEEND_MVTS,DATEEXECUTION=@DATEEXECUTION,DATERETOURPROBABLE=@DATERETOURPROBABLE,DATERETOURREEL=@DATERETOURREEL,DATEMODIFY_MVTS=GETDATE() WHERE CODE_MVTS = '" + CodMvts + "' ", Conn.cn);
                                if (IdPersDemaMod.HasValue)
                                    SqlCmd.Parameters.AddWithValue("@ID_PERS", IdPersDemaMod);
                                else
                                    SqlCmd.Parameters.AddWithValue("@ID_PERS", DBNull.Value);

                                if (IdVehiculeMod.HasValue)
                                    SqlCmd.Parameters.AddWithValue("@ID_VEHICULE", IdVehiculeMod.Value);
                                else
                                    SqlCmd.Parameters.AddWithValue("@ID_VEHICULE", DBNull.Value);

                                if (IdConducMod.HasValue)
                                    SqlCmd.Parameters.AddWithValue("@ID_COND", IdConducMod.Value);
                                else
                                    SqlCmd.Parameters.AddWithValue("@ID_COND", DBNull.Value);
                                //SqlCmd.Parameters.AddWithValue("@ID_PERS", IdPersDemaMod);
                                //SqlCmd.Parameters.AddWithValue("@ID_VEHICULE", IdVehiculeMod);
                                SqlCmd.Parameters.AddWithValue("@ID_VALMVT", guidValidation);
                                SqlCmd.Parameters.AddWithValue("@STATUT_MVTS", CbxStatutMvtMod.Text);
                                SqlCmd.Parameters.AddWithValue("@LIEU_MVTS", CbxLieuMvtsMod.Text);
                                //SqlCmd.Parameters.AddWithValue("@ID_COND", IdConducMod);
                                SqlCmd.Parameters.AddWithValue("@NOTE_MVTS", RtbxNoteMvtMod.Text);
                                SqlCmd.Parameters.AddWithValue("@DATEDEPARTSOUHAITE_MVTS", DateDepartSouhMvtMod.Value.ToString("dd/MM/yyyy"));
                                SqlCmd.Parameters.AddWithValue("@TIMESTART_MVTS", TimeStartMvtModi.Value.ToString("HH:mm"));
                                SqlCmd.Parameters.AddWithValue("@TIMEEND_MVTS", TimeEndMvtModi.Value.ToString("HH:mm"));
                                SqlCmd.Parameters.AddWithValue("@DATEEXECUTION", DateExecutionMod.Value.ToString("dd/MM/yyyy"));
                                SqlCmd.Parameters.AddWithValue("@DATERETOURPROBABLE", DateRetouProbMvtMod.Value.ToString("dd/MM/yyyy"));
                                SqlCmd.Parameters.AddWithValue("@DATERETOURREEL", DateRetouReelMod.Value.ToString("dd/MM/yyyy"));
                                SqlCmd.ExecuteNonQuery();
                                MessageBox.Show("Les informations ont été modifiées avec succès !", "Fleet: Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                /**
                                 * Changer le statut du véhicule pool lorsque le gestionnaire valide
                                 */
                                SqlCmd = new SqlCommand("UPDATE VEHICULE SET ETAT_VEHICULE=@ETAT_VEHICULE WHERE ID_VEHICULE='" + IdVehiculeMod + "'", Conn.cn);
                                SqlCmd.Parameters.AddWithValue("@ETAT_VEHICULE", "Parking");
                                SqlCmd.ExecuteNonQuery();
                            }
                            else
                            {
                                SqlCmd = new SqlCommand("UPDATE MOUVEMENTS SET ID_PERS=@ID_PERS,ID_VEHICULE=@ID_VEHICULE,ID_VALMVT=@ID_VALMVT,ID_COND=@ID_COND, STATUT_MVTS=@STATUT_MVTS, LIEU_MVTS=@LIEU_MVTS,NOTE_MVTS=@NOTE_MVTS,DATEDEPARTSOUHAITE_MVTS=@DATEDEPARTSOUHAITE_MVTS, TIMESTART_MVTS=@TIMESTART_MVTS,TIMEEND_MVTS=@TIMEEND_MVTS,DATEEXECUTION=@DATEEXECUTION,DATERETOURPROBABLE=@DATERETOURPROBABLE,DATERETOURREEL=@DATERETOURREEL,DATEMODIFY_MVTS=GETDATE() WHERE CODE_MVTS = '" + CodMvts + "' ", Conn.cn);
                                if (IdPersDemaMod.HasValue)
                                    SqlCmd.Parameters.AddWithValue("@ID_PERS", IdPersDemaMod);
                                else
                                    SqlCmd.Parameters.AddWithValue("@ID_PERS", DBNull.Value);

                                if (IdVehiculeMod.HasValue)
                                    SqlCmd.Parameters.AddWithValue("@ID_VEHICULE", IdVehiculeMod.Value);
                                else
                                    SqlCmd.Parameters.AddWithValue("@ID_VEHICULE", DBNull.Value);

                                if (IdConducMod.HasValue)
                                    SqlCmd.Parameters.AddWithValue("@ID_COND", IdConducMod.Value);
                                else
                                    SqlCmd.Parameters.AddWithValue("@ID_COND", DBNull.Value);
                                //SqlCmd.Parameters.AddWithValue("@ID_PERS", IdPersDemaMod);
                                //SqlCmd.Parameters.AddWithValue("@ID_VEHICULE", IdVehiculeMod);
                                SqlCmd.Parameters.AddWithValue("@ID_VALMVT", guidValidation);
                                SqlCmd.Parameters.AddWithValue("@STATUT_MVTS", CbxStatutMvtMod.Text);
                                SqlCmd.Parameters.AddWithValue("@LIEU_MVTS", CbxLieuMvtsMod.Text);
                                //SqlCmd.Parameters.AddWithValue("@ID_COND", IdConducMod);
                                SqlCmd.Parameters.AddWithValue("@NOTE_MVTS", RtbxNoteMvtMod.Text);
                                SqlCmd.Parameters.AddWithValue("@DATEDEPARTSOUHAITE_MVTS", DateDepartSouhMvtMod.Value.ToString("dd/MM/yyyy"));
                                SqlCmd.Parameters.AddWithValue("@TIMESTART_MVTS", TimeStartMvtModi.Value.ToString("HH:mm"));
                                SqlCmd.Parameters.AddWithValue("@TIMEEND_MVTS", TimeEndMvtModi.Value.ToString("HH:mm"));
                                SqlCmd.Parameters.AddWithValue("@DATEEXECUTION", DateExecutionMod.Value.ToString("dd/MM/yyyy"));
                                SqlCmd.Parameters.AddWithValue("@DATERETOURPROBABLE", DateRetouProbMvtMod.Value.ToString("dd/MM/yyyy"));
                                SqlCmd.Parameters.AddWithValue("@DATERETOURREEL", DateRetouReelMod.Value.ToString("dd/MM/yyyy"));
                                SqlCmd.ExecuteNonQuery();
                                MessageBox.Show("Les informations ont été modifiées avec succès !", "Fleet: Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                    }
                    // Close the form
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IbtnRegisterMvtTbxCodMvtMod_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnCreateCar = new ToolTip();
            ToolTipBtnCreateCar.AutoPopDelay = 5000;
            ToolTipBtnCreateCar.InitialDelay = 1000;
            ToolTipBtnCreateCar.ReshowDelay = 500;
            ToolTipBtnCreateCar.ShowAlways = true;
            ToolTipBtnCreateCar.SetToolTip(this.IbtnRegisterMvtTbxCodMvtMod, "Enregistrer");
        }

        private void BtnPrinterCarModi_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnCreateCar = new ToolTip();
            ToolTipBtnCreateCar.AutoPopDelay = 5000;
            ToolTipBtnCreateCar.InitialDelay = 1000;
            ToolTipBtnCreateCar.ReshowDelay = 500;
            ToolTipBtnCreateCar.ShowAlways = true;
            ToolTipBtnCreateCar.SetToolTip(this.BtnPrinterCarModi, "Imprimer");
        }

        private void btnChoiceStatutCarMod_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                FormConsultStatutDemandeCarMod CallFallAskCarMod = new FormConsultStatutDemandeCarMod();
                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("SELECT*FROM VALIDATIONMOUVEMENTCAR AS V INNER JOIN TRANSITIONDEMANDEVEHICULE AS T ON V.ID_VALMVT=T.ID_FIN_TRANSASKCAR INNER JOIN ROLESTRANSITIONDEMANDEVEHICULE AS RT ON T.ID_TRANSASKCAR=RT.ID_TRANSASKCAR  INNER JOIN ROLES AS R ON RT.ID_ROLE=R.ID_ROLE WHERE R.DESCRIPTION_ROLE='" + FormConnectionUser.rolesUser.ToString() + "' ", Conn.cn);
                    MyReader = SqlCmd.ExecuteReader();

                    while (MyReader.Read())
                    {
                        CallFallAskCarMod.listBoxDemandeCarMod.Items.Add(new KeyValuePair<Guid, string>((Guid)MyReader["ID_VALMVT"], (string)MyReader["DESCRIPTION_VALMVT"].ToString()));
                        CallFallAskCarMod.listBoxDemandeCarMod.DisplayMember = "Value";
                        CallFallAskCarMod.listBoxDemandeCarMod.ValueMember = "Key"; ;
                    }
                    CallFallAskCarMod.ShowDialog();
                }
                else
                    MessageBox.Show("Veillez réviser les paramètres de connexion à la base de données !", "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnImportDocModi_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnCreateCar = new ToolTip();
            ToolTipBtnCreateCar.AutoPopDelay = 5000;
            ToolTipBtnCreateCar.InitialDelay = 1000;
            ToolTipBtnCreateCar.ReshowDelay = 500;
            ToolTipBtnCreateCar.ShowAlways = true;
            ToolTipBtnCreateCar.SetToolTip(this.BtnImportDocModi, "Joindre doc.");
        }

        private void cbxConducteurMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_COND FROM CONDUCTEURS WHERE DESCRIPTION_COND = '" + cbxConducteurMod.Text + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdConducteurMvtMod = Guid.Parse(MyReader["ID_COND"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fillPersDemandeur()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_PERS, DESCRIPTION_PERS FROM PERSONNELS ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            CbxDemandeurMvtMod.Items.Add(MyReader["DESCRIPTION_PERS"].ToString());
                            CbxDemandeurMvtMod.DisplayMember = (MyReader["DESCRIPTION_PERS"].ToString());
                            CbxDemandeurMvtMod.ValueMember = (MyReader["ID_PERS"].ToString());
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fillCbxCarPool()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_VEHICULE, IMMATRICULATION_VEHICULE FROM VEHICULE WHERE TYPE_VEHICULE = 'pool' AND SANTE_VEHICULE ='Bon'", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            CbxVehiculeMod.Items.Add(MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            CbxVehiculeMod.DisplayMember = (MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            CbxVehiculeMod.ValueMember = (MyReader["ID_VEHICULE"].ToString());
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /**
         *  Methode qui renvoie l'id de l'état de la demande de véhicule
         */
        private Guid? IdValidationMod()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {
                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("SELECT ID_VALMVT FROM VALIDATIONMOUVEMENTCAR WHERE DESCRIPTION_VALMVT ='" + txtValMvtMod.Text + "'", Conn.cn);
                    MyReader = SqlCmd.ExecuteReader();
                    while (MyReader.Read())
                    {
                        IdValMod = Guid.Parse(MyReader["ID_VALMVT"].ToString());
                    }
                    MyReader.Close();
                }
                else
                    MessageBox.Show("Veillez réviser les paramètres de connexion à la base de données !", "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return (Guid)IdValMod;
        }

        // Methode pour remplir le combobox des conducteurs
        private void AllConducteurMod()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {
                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("SELECT * FROM CONDUCTEURS ORDER BY DESCRIPTION_COND ASC ", Conn.cn);
                    MyReader = SqlCmd.ExecuteReader();
                    while (MyReader.Read())
                    {
                        cbxConducteurMod.Items.Add(new KeyValuePair<Guid, string>((Guid)MyReader["ID_COND"], MyReader["DESCRIPTION_COND"].ToString()));
                        cbxConducteurMod.DisplayMember = "Value";
                        cbxConducteurMod.ValueMember = "Key";
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
