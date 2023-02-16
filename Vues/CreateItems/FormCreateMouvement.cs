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
    public partial class FormCreateMouvement : Form
    {
        private SqlCommand SqlCmd;
        private DataSet Ds;
        private SqlDataAdapter SqlAda;
        private SqlDataReader MyReader;
        private Guid? IdCarMvt = null,IdPersDema = null, IdVal = null, IdConducteurMvt = null;
        public static FormCreateMouvement formCreateMouvement;
        public FormCreateMouvement()
        {
            InitializeComponent();
            fillCbxCarPool();
            fillPersDemandeur();
            formCreateMouvement = this;
            AllConducteur();
        }

        // Generate code of personne
        private string generateCodeMvt()
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
                        SqlCmd = new SqlCommand("SELECT CODE_MVTS FROM MOUVEMENTS WHERE CODE_MVTS=(SELECT MAX(CODE_MVTS) FROM MOUVEMENTS)", Conn.cn);
                        SqlAda = new SqlDataAdapter(SqlCmd);
                        Ds = new DataSet();
                        SqlAda.Fill(Ds);

                        if (Ds.Tables[0].Rows.Count > 0)
                        {
                            TbxCodMvt.Text = Ds.Tables[0].Rows[0]["CODE_MVTS"].ToString();
                        }
                        else
                        {
                            TbxCodMvt.Text = "MVTS0000";
                        }
                        if (!string.IsNullOrEmpty(TbxCodMvt.Text))
                        {
                            TbxCodMvt.SelectionStart = 4;
                            TbxCodMvt.SelectionLength = 4;
                            TbxCodMvt.Text = TbxCodMvt.SelectedText;
                        }
                        if (!string.IsNullOrEmpty(TbxCodMvt.Text))
                        {
                            int codeCarMvt = int.Parse(TbxCodMvt.Text.ToString()) + 1;
                            TbxCodMvt.Text = codeCarMvt.ToString("MVTS0000");
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
            return TbxCodMvt.Text;
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
                        SqlCmd = new SqlCommand("SELECT ID_VEHICULE, IMMATRICULATION_VEHICULE FROM VEHICULE WHERE TYPE_VEHICULE = 'pool' AND ETAT_VEHICULE='Parking' AND SANTE_VEHICULE ='Bon'", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            CbxVehiculeMvt.Items.Add(MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            CbxVehiculeMvt.DisplayMember = (MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            CbxVehiculeMvt.ValueMember = (MyReader["ID_VEHICULE"].ToString());
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbxDemandeurMvt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        if (!string.IsNullOrEmpty(CbxDemandeurMvt.Text))
                        {
                            SqlCmd = new SqlCommand("SELECT ID_PERS, DESCRIPTION_SERV,DESCRIPTION_DIR FROM PERSONNELS INNER JOIN SERVICESENT ON SERVICESENT.ID_SERV=PERSONNELS.ID_SERV INNER JOIN DIRECTION ON DIRECTION.ID_DIR=SERVICESENT.ID_DIR WHERE DESCRIPTION_PERS = '" + CbxDemandeurMvt.SelectedItem + "' ", Conn.cn);
                            MyReader = SqlCmd.ExecuteReader();
                            while (MyReader.Read())
                            {
                                IdPersDema = Guid.Parse(MyReader[0].ToString());
                                TxtServiceMvt.Text = MyReader[1].ToString();
                                TxtDirMvt.Text= MyReader[2].ToString();
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
                        if (!string.IsNullOrEmpty(CbxVehiculeMvt.Text))
                        {
                            SqlCmd = new SqlCommand("SELECT ID_VEHICULE FROM VEHICULE WHERE IMMATRICULATION_VEHICULE = '" + CbxVehiculeMvt.SelectedItem + "' ", Conn.cn);
                            MyReader = SqlCmd.ExecuteReader();
                            while (MyReader.Read())
                            {
                                IdCarMvt = Guid.Parse(MyReader["ID_VEHICULE"].ToString());
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

        private void IbtnRegisterMvtTbxCodMvt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtLieuMvt.Text))
            {
                MessageBox.Show("Saisir le lieu svp !!!", "Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(string.IsNullOrEmpty(CbxDemandeurMvt.Text))
            {
                MessageBox.Show("Sélectionner le demandeur de véhicule svp !!!", "Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                DialogResult result = MessageBox.Show("Voulez vous enregister ?", "Fleet: CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (Conn.cn)
                    {
                        if (Conn.IsConnection)
                        {
                            string CodMvt = generateCodeMvt();

                            using (var Cmd = Conn.cn.CreateCommand())
                            {
                                //MessageBox.Show("Id véhicule : " + IdCarMvt + " Id cond : " + IdConducteurMvt + " Id de la validation : " + IdValidation());
                                Cmd.CommandText = "INSERT INTO [dbo].[MOUVEMENTS] (ID_PERS,ID_VALMVT,ID_COND,ID_VEHICULE,CODE_MVTS,STATUT_MVTS,LIEU_MVTS,NOTE_MVTS,DATEDEPARTSOUHAITE_MVTS,DATECREATE_MVTS,TIMESTART_MVTS,TIMEEND_MVTS,DATEEXECUTION,DATERETOURPROBABLE,DATERETOURREEL) VALUES (@ID_PERS,@ID_VALMVT,@ID_COND,@ID_VEHICULE,@CODE_MVTS,@STATUT_MVTS,@LIEU_MVTS,@NOTE_MVTS,@DATEDEPARTSOUHAITE_MVTS,GETDATE(),@TIMESTART_MVTS,@TIMEEND_MVTS,@DATEEXECUTION,@DATERETOURPROBABLE,@DATERETOURREEL)";

                                if (IdPersDema.HasValue)
                                    Cmd.Parameters.AddWithValue("@ID_PERS", IdPersDema.Value);
                                else
                                    Cmd.Parameters.AddWithValue("@ID_PERS", DBNull.Value);

                                if (IdCarMvt.HasValue)
                                    Cmd.Parameters.AddWithValue("@ID_VEHICULE", IdCarMvt.Value);
                                else
                                    Cmd.Parameters.AddWithValue("@ID_VEHICULE", DBNull.Value);

                                if (IdConducteurMvt.HasValue)
                                    Cmd.Parameters.AddWithValue("@ID_COND", IdConducteurMvt.Value);
                                else
                                    Cmd.Parameters.AddWithValue("@ID_COND", DBNull.Value);

                                //Cmd.Parameters.AddWithValue("@ID_PERS", IdPersDema);
                                //Cmd.Parameters.AddWithValue("@ID_VEHICULE", IdCarMvt);
                                Cmd.Parameters.AddWithValue("@ID_VALMVT", IdValidation());
                                Cmd.Parameters.AddWithValue("@CODE_MVTS", CodMvt);
                                Cmd.Parameters.AddWithValue("@STATUT_MVTS", CbxStatutMvt.Text);
                                Cmd.Parameters.AddWithValue("@LIEU_MVTS", TxtLieuMvt.Text);
                                //Cmd.Parameters.AddWithValue("@ID_COND", IdConducteurMvt);
                                Cmd.Parameters.AddWithValue("@NOTE_MVTS", RtbxNoteMvt.Text);
                                Cmd.Parameters.AddWithValue("@DATEDEPARTSOUHAITE_MVTS", DateDepartShouhaiteMvt.Value.ToString("dd/MM/yyyy"));
                                Cmd.Parameters.AddWithValue("@TIMESTART_MVTS", TimeStartMvt.Value.ToString("HH:mm"));
                                Cmd.Parameters.AddWithValue("@TIMEEND_MVTS", TimeEndMvt.Value.ToString("HH:mm"));
                                Cmd.Parameters.AddWithValue("@DATEEXECUTION", DateExecution.Value.ToString("dd/MM/yyyy"));
                                Cmd.Parameters.AddWithValue("@DATERETOURPROBABLE", DateRetourProbMvt.Value.ToString("dd/MM/yyyy"));
                                Cmd.Parameters.AddWithValue("@DATERETOURREEL", DateRetourReelMvt.Value.ToString("dd/MM/yyyy"));
                                Cmd.ExecuteNonQuery();

                                // Update Table carburant statut

                                if (IdCarMvt.HasValue)
                                {
                                    Cmd.CommandText = " UPDATE VEHICULE SET ETAT_VEHICULE=@ETAT_VEHICULE WHERE ID_VEHICULE='" + IdCarMvt.Value + "' ";
                                    Cmd.Parameters.AddWithValue("@ETAT_VEHICULE", CbxStatutMvt.Text);
                                    Cmd.ExecuteNonQuery();
                                }

                                MessageBox.Show("Mouvement enregistré avec succès !!!", "Fleet: Information", MessageBoxButtons.OK);
                                this.Close();

                            }
                        }
                        else
                            MessageBox.Show("Veillez réviser les paramètres de connexion à la base de données !", "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void IbtnRegisterMvtTbxCodMvt_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnCreateCar = new ToolTip();
            ToolTipBtnCreateCar.AutoPopDelay = 5000;
            ToolTipBtnCreateCar.InitialDelay = 1000;
            ToolTipBtnCreateCar.ReshowDelay = 500;
            ToolTipBtnCreateCar.ShowAlways = true;
            ToolTipBtnCreateCar.SetToolTip(this.IbtnRegisterMvt, "Enregistrer");
        }

        private void BtnPrinterCarModi_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnCreateCar = new ToolTip();
            ToolTipBtnCreateCar.AutoPopDelay = 5000;
            ToolTipBtnCreateCar.InitialDelay = 1000;
            ToolTipBtnCreateCar.ReshowDelay = 500;
            ToolTipBtnCreateCar.ShowAlways = true;
            ToolTipBtnCreateCar.SetToolTip(this.BtnPrinterCarMvt, "Imprimer");
        }

        private void btnChoiceStatutCar_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                FormConsultStatutDemandeCar CallFallAskCar = new FormConsultStatutDemandeCar();
                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("SELECT * FROM VALIDATIONMOUVEMENTCAR AS V INNER JOIN TRANSITIONDEMANDEVEHICULE AS T ON V.ID_VALMVT=T.ID_FIN_TRANSASKCAR INNER JOIN ROLESTRANSITIONDEMANDEVEHICULE AS RT ON T.ID_TRANSASKCAR=RT.ID_TRANSASKCAR  INNER JOIN ROLES AS R ON RT.ID_ROLE=R.ID_ROLE WHERE R.DESCRIPTION_ROLE='" + FormConnectionUser.rolesUser.ToString() + "' ", Conn.cn);
                    MyReader = SqlCmd.ExecuteReader();

                    while (MyReader.Read())
                    {
                        CallFallAskCar.listValidationDemandeCar.Items.Add(new KeyValuePair<Guid, string>((Guid)MyReader["ID_VALMVT"], (string)MyReader["DESCRIPTION_VALMVT"].ToString()));
                        CallFallAskCar.listValidationDemandeCar.DisplayMember = "Value";
                        CallFallAskCar.listValidationDemandeCar.ValueMember = "Key";;
                    }
                    CallFallAskCar.ShowDialog();
                }
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
            ToolTipBtnCreateCar.SetToolTip(this.BtnImportDocMvt, "Joindre doc.");
        }

        private void cbxConducteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_COND FROM CONDUCTEURS WHERE DESCRIPTION_COND = '" + cbxConducteur.Text + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdConducteurMvt = Guid.Parse(MyReader["ID_COND"].ToString());
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
                        SqlCmd = new SqlCommand("SELECT ID_PERS, DESCRIPTION_PERS FROM PERSONNELS ORDER BY DESCRIPTION_PERS ASC", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            CbxDemandeurMvt.Items.Add(MyReader["DESCRIPTION_PERS"].ToString());
                            CbxDemandeurMvt.DisplayMember = (MyReader["DESCRIPTION_PERS"].ToString());
                            CbxDemandeurMvt.ValueMember = (MyReader["ID_PERS"].ToString());
                        }
                    }
                    else
                        MessageBox.Show("Veillez réviser les paramètres de connexion à la base de données !", "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private Guid? IdValidation()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {
                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("SELECT ID_VALMVT FROM VALIDATIONMOUVEMENTCAR WHERE DESCRIPTION_VALMVT ='" + txtValMvt.Text+"'", Conn.cn);
                    MyReader = SqlCmd.ExecuteReader();
                    while (MyReader.Read())
                    {
                        IdVal = Guid.Parse(MyReader["ID_VALMVT"].ToString());
                    }
                }
                else
                    MessageBox.Show("Veillez réviser les paramètres de connexion à la base de données !", "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return IdVal;
        }

        // Methode pour remplir le combobox des conducteurs
        private void AllConducteur()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {
                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("SELECT * FROM CONDUCTEURS", Conn.cn);
                    MyReader = SqlCmd.ExecuteReader();
                    while (MyReader.Read())
                    {
                        cbxConducteur.Items.Add(new KeyValuePair<Guid, string>((Guid)MyReader["ID_COND"], MyReader["DESCRIPTION_COND"].ToString()));
                        cbxConducteur.DisplayMember = "Value";
                        cbxConducteur.ValueMember = "Key";
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
