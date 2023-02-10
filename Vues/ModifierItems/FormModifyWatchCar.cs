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
    public partial class FormModifyWatchCar : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataAdapter SqlAda;
        private SqlDataReader MyReader;
        private Guid IdWatchCarModif, IdCardWatchMod,IdWatchOldCar;
        private String CartePaieMod, MatriculeCar, CarteGriseCar, ModelCar;
        private Decimal SoldeCarteMod=0;
        private static Decimal HoldAmountToPay = 0;
        public FormModifyWatchCar()
        {
            InitializeComponent();
            FillComboboxCar();
            FillCbxCardPaieCleanModMod();
            totalAmountCleanCar();

        }

   

        private void CbxVehiculeWatchCarModi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT * FROM VEHICULE AS V INNER JOIN MARQUE AS M ON V.ID_MARQ=M.ID_MARQ WHERE V.IMMATRICULATION_VEHICULE = '" + CbxVehiculeWatchCarModi.Text + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdWatchCarModif = Guid.Parse(MyReader["ID_VEHICULE"].ToString());
                            MatriculeCar = MyReader["IMMATRICULATION_VEHICULE"].ToString();
                            CarteGriseCar = MyReader["CARTE_GRISE_VEHICULE"].ToString();
                            ModelCar = MyReader["MODELE_MARQ"].ToString();
                            //MessageBox.Show("Id car : " + IdVehiWatch + "Matricule : " + MatriculeCar + "Carte grise : " + CarteGriseCar + " Modèle véhicule : " + ModelCar);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IbtnRegisterWatchCarModi_Click(object sender, EventArgs e)
        {
            string ImmatCar = CbxVehiculeWatchCarModi.Text ;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                DialogResult result = MessageBox.Show("Voulez vous enregister les modifications apportées ?", "Fleet: CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (Conn.cn)
                    {
                        if (Conn.IsConnection)
                        {
                            if (!string.IsNullOrEmpty(TxtBLieuWatchCarModi.Text) && Convert.ToDecimal(txtNetAPayerCarWatchMod.Text) > 0)
                            {
                                // Déterminer le id de la provision
                                using (var Cmd = Conn.cn.CreateCommand())
                                {
                                    Cmd.CommandText = "SELECT ID_WATCH FROM LAVAGE WHERE CODE_WATCH='" + TbxCodeWatchCarModi.Text + "'";
                                    MyReader = Cmd.ExecuteReader();
                                    while (MyReader.Read())
                                    {
                                        IdWatchOldCar = Guid.Parse(MyReader["ID_WATCH"].ToString());
                                    }
                                    MyReader.Close();
                                }

                                // Mettre à jour la table lavage
                                using (var Cmd = Conn.cn.CreateCommand())
                                {
                                    Cmd.CommandText = "UPDATE LAVAGE SET LIEU_WATCH=@LIEU_WATCH,DATE_WATCH=@DATE_WATCH,MONTANT_WATCH=@MONTANT_WATCH WHERE ID_WATCH='" + IdWatchOldCar + "'";
                                    Cmd.Parameters.AddWithValue("@LIEU_WATCH", TxtBLieuWatchCarModi.Text.Trim());
                                    Cmd.Parameters.AddWithValue("@DATE_WATCH", DatePikerWatchCarModi.Value.ToString("dd/MM/yyyy"));
                                    Cmd.Parameters.AddWithValue("@MONTANT_WATCH", decimal.Parse(txtNetAPayerCarWatchMod.Text));
                                    Cmd.ExecuteNonQuery();
                                }

                                // Mettre à jour la table lavageLine
                                using (var Cmd = Conn.cn.CreateCommand())
                                {
                                    for (int i = 0; i < dgvCarLineWatchMod.Rows.Count - 1; i++)
                                    {
                                        // Rappeler les véhicules approvisionnés
                                        string queryProv = "SELECT * FROM VEHICULE AS V INNER JOIN LAVAGELINE AS LAVLINE ON V.ID_VEHICULE=LAVLINE.ID_VEHICULE INNER JOIN LAVAGE AS LAV ON LAVLINE.ID_WATCH=LAV.ID_WATCH WHERE LAV.ID_WATCH='"+IdWatchOldCar+"' AND V.ID_VEHICULE='"+ Guid.Parse(dgvCarLineWatchMod.Rows[i].Cells["ID_VEHICULE"].Value.ToString()) + "'";
                                        SqlDataAdapter SqlAdaProv = new SqlDataAdapter(queryProv, Conn.cn);
                                        DataTable DtaProv = new DataTable();
                                        SqlAdaProv.Fill(DtaProv);

                                        if (DtaProv.Rows.Count == 1)
                                        {
                                            //MessageBox.Show("Provision Code : " + TxtCodeConsoCarbMod.Text + "Id véhicule existant : " + DtaProv.Rows[0][0].ToString() + " Matricule du véhicule : " + DvgCarApproMod.Rows[i].Cells["ImmatCarMod"].Value + "Id véhicule : " + DvgCarApproMod.Rows[i].Cells["IdCarRavi"].Value);
                                            Cmd.CommandText = "UPDATE LAVAGELINE SET ID_VEHICULE=@ID_VEHICULE WHERE ID_VEHICULE='" + Guid.Parse(dgvCarLineWatchMod.Rows[i].Cells["ID_VEHICULE"].Value.ToString()) + "' AND ID_WATCH='" + IdWatchOldCar + "' ";
                                            Cmd.Parameters.AddWithValue("@ID_VEHICULE", Guid.Parse(dgvCarLineWatchMod.Rows[i].Cells["ID_VEHICULE"].Value.ToString()));
                                            Cmd.ExecuteNonQuery();
                                            Cmd.Parameters.Clear();
                                        }
                                        else
                                        {
                                            Cmd.CommandText = "INSERT INTO LAVAGELINE (ID_VEHICULE,ID_WATCH) VALUES (@ID_VEHICULE,@ID_WATCH)";
                                            Cmd.Parameters.AddWithValue("@ID_VEHICULE", dgvCarLineWatchMod.Rows[i].Cells["ID_VEHICULE"].Value ?? DBNull.Value);
                                            Cmd.Parameters.AddWithValue("@ID_WATCH", IdWatchOldCar);
                                            Cmd.ExecuteNonQuery();
                                            Cmd.Parameters.Clear();
                                        }
                                    }

                                    // La gestion de la paie des véhicules lavés
                                    for (int j = 0; j < dgvPaieWatchCarMod.Rows.Count - 1; j++)
                                    {
                                        // Rappeler les cartes qui ont servi de paiement
                                        string queryPaie = "SELECT * FROM PAIEMENT AS PAIE INNER JOIN LAVAGE AS LAV ON PAIE.ID_WATCH=LAV.ID_WATCH INNER JOIN CARDPAIEMENT AS CARDP ON PAIE.ID_CARD=CARDP.ID_CARD WHERE LAV.CODE_WATCH = '" + TbxCodeWatchCarModi.Text + "' AND CARDP.ID_CARD='" + dgvPaieWatchCarMod.Rows[j].Cells["ID_CARD"].Value + "' ";
                                        SqlDataAdapter SqlAdaPaie = new SqlDataAdapter(queryPaie, Conn.cn);
                                        DataTable dtaPaie = new DataTable();
                                        SqlAdaPaie.Fill(dtaPaie);

                                        if (dtaPaie.Rows.Count == 1)
                                        {
                                            // Recuperer l'ancien montant débité
                                            Cmd.CommandText = "SELECT TOTALPRIX_PAIE FROM PAIEMENT WHERE ID_WATCH='" + IdWatchOldCar + "' AND ID_CARD='" + Guid.Parse(dgvPaieWatchCarMod.Rows[j].Cells["ID_CARD"].Value.ToString()) + "'";
                                            MyReader = Cmd.ExecuteReader();
                                            while (MyReader.Read())
                                            {
                                                HoldAmountToPay = decimal.Parse(MyReader["TOTALPRIX_PAIE"].ToString());
                                            }
                                            MyReader.Close();

                                            // Mettre à jour la table paiement
                                            Cmd.CommandText = "UPDATE PAIEMENT SET TOTALPRIX_PAIE=@TOTALPRIX_PAIE,DATE_PAIE=@DATE_PAIE,MODIFYDATE_PAIE=GETDATE() WHERE ID_PAIE='" + dgvPaieWatchCarMod.Rows[j].Cells["ID_PAIE"].Value + "' ";
                                            Cmd.Parameters.AddWithValue("@TOTALPRIX_PAIE", Convert.ToDecimal(dgvPaieWatchCarMod.Rows[j].Cells["TOTALPRIX_PAIE"].Value));
                                            Cmd.Parameters.AddWithValue("@DATE_PAIE", datePaieWatchMod.Value.ToString("dd/MM/yyyy"));
                                            Cmd.ExecuteNonQuery();
                                            Cmd.Parameters.Clear();

                                            //HoldAmountToPay = Convert.ToDecimal(dgvPaieWatchCarMod.Rows[j].Cells["MontantDebiteHold"].Value.ToString());
                                            Decimal valueAdd = (HoldAmountToPay - Convert.ToDecimal(dgvPaieWatchCarMod.Rows[j].Cells["TOTALPRIX_PAIE"].Value.ToString()));
                                            // Recuperer le montant de la carte qui a servi le paiement
                                            decimal totalAmountCard = (Convert.ToDecimal(dgvPaieWatchCarMod.Rows[j].Cells["SoldeReelCarte"].Value.ToString()) + valueAdd);
                                            // MessageBox.Show("Ancien montant = " + HoldAmountToPay + "Nouveau montant = " + dgvPaieWatchCarMod.Rows[j].Cells["TOTALPRIX_PAIE"].Value + " Anc - New = " + valueAdd + " Solde Réel : " + totalAmountCard);
                                            // Mise à jour du solde de la carte des paiements de carburant
                                            Cmd.CommandText = "UPDATE CARDPAIEMENT SET SOLDE_CARD=@SOLDE_CARD WHERE ID_CARD='" + dgvPaieWatchCarMod.Rows[j].Cells["ID_CARD"].Value + "'";
                                            Cmd.Parameters.AddWithValue("@SOLDE_CARD", totalAmountCard);
                                            Cmd.ExecuteNonQuery();
                                        }
                                        else
                                        {
                                            Cmd.CommandText = "INSERT INTO PAIEMENT (ID_WATCH,ID_CARD,TOTALPRIX_PAIE,DATE_PAIE,DATECREATE_PAIE,ANCIEN_SOLDE_CARTE_PAIE) VALUES (@ID_WATCH,@ID_CARD,@TOTALPRIX_PAIE,@DATE_PAIE,GETDATE(),@ANCIEN_SOLDE_CARTE_PAIE)";
                                            Cmd.Parameters.AddWithValue("@ID_WATCH", IdWatchOldCar);
                                            Cmd.Parameters.AddWithValue("@ID_CARD", Guid.Parse(dgvPaieWatchCarMod.Rows[j].Cells["ID_CARD"].Value.ToString()));
                                            Cmd.Parameters.AddWithValue("@TOTALPRIX_PAIE", decimal.Parse(dgvPaieWatchCarMod.Rows[j].Cells["TOTALPRIX_PAIE"].Value.ToString()));
                                            Cmd.Parameters.AddWithValue("@DATE_PAIE", datePaieWatchMod.Value.ToString("dd/MM/yyyy"));
                                            Cmd.Parameters.AddWithValue("@ANCIEN_SOLDE_CARTE_PAIE", decimal.Parse(dgvPaieWatchCarMod.Rows[j].Cells["SOLDE_CARD"].Value.ToString()));
                                            Cmd.ExecuteNonQuery();

                                            // Mise à jour de la carte
                                            // Recuperer le montant de la carte qui a servi le paiement
                                            decimal totalAmountCard = Convert.ToDecimal(dgvPaieWatchCarMod.Rows[j].Cells["SOLDE_CARD"].Value.ToString()) - Convert.ToDecimal(dgvPaieWatchCarMod.Rows[j].Cells["TOTALPRIX_PAIE"].Value.ToString());

                                            // Mise à jour du solde de la carte des paiements de carburant
                                            Cmd.CommandText = "UPDATE CARDPAIEMENT SET SOLDE_CARD=@SOLDE_CARD WHERE ID_CARD='" + dgvPaieWatchCarMod.Rows[j].Cells["ID_CARD"].Value + "'";
                                            Cmd.Parameters.AddWithValue("@SOLDE_CARD", totalAmountCard);
                                            Cmd.ExecuteNonQuery();
                                        }
                                    }
                                }

                                this.Close();

                            }
                            else
                            {
                                MessageBox.Show("Veillez saisir lieu où les véhicules ont été lavés !"+'\n'+"Ou saisir le coût du lavage des véhicules !","Fleet: Gestion des erreurs",MessageBoxButtons.OK,MessageBoxIcon.Error);
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

        // Method to fill the combobox car

        private void FillComboboxCar()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT * FROM VEHICULE", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            CbxVehiculeWatchCarModi.Items.Add(MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            CbxVehiculeWatchCarModi.DisplayMember = (MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            CbxVehiculeWatchCarModi.ValueMember = (MyReader["ID_VEHICULE"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddCarWatchMod_Click(object sender, EventArgs e)
        {
            DataTable dataTableCarWatch = (DataTable)dgvCarLineWatchMod.DataSource;
            DataRow drToAddCarWatch = dataTableCarWatch.NewRow();
            // Definir les colonnes de la table
            drToAddCarWatch["ID_VEHICULE"] = IdWatchCarModif;
            drToAddCarWatch["IMMATRICULATION_VEHICULE"] = MatriculeCar;
            drToAddCarWatch["CARTE_GRISE_VEHICULE"] = CarteGriseCar;
            drToAddCarWatch["MODELE_MARQ"] = ModelCar;
            dataTableCarWatch.Rows.Add(drToAddCarWatch);
            dataTableCarWatch.AcceptChanges();

            CbxVehiculeWatchCarModi.Text = "";
        }

        private void btnAddCardPaieMod_Click(object sender, EventArgs e)
        {
            DataTable dataTablePaieCarWatch = (DataTable)dgvPaieWatchCarMod.DataSource;
            DataRow drToAddPaieCarWatch = dataTablePaieCarWatch.NewRow();
            // Definir les colonnes de la table
            drToAddPaieCarWatch["ID_CARD"] = IdCardWatchMod;
            drToAddPaieCarWatch["NUM_CARD"] = CartePaieMod;
            drToAddPaieCarWatch["SOLDE_CARD"] = SoldeCarteMod;
            drToAddPaieCarWatch["TOTALPRIX_PAIE"] = decimal.Parse(TxtBMontantModi.Text);
            dataTablePaieCarWatch.Rows.Add(drToAddPaieCarWatch);
            dataTablePaieCarWatch.AcceptChanges();

            TxtBMontantModi.Clear(); cbxWatchCardPaieMod.Text = null;
            totalAmountCleanCar();
        }

        private void IbtnRegisterWatchCarModi_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnCreateCar = new ToolTip();
            ToolTipBtnCreateCar.AutoPopDelay = 5000;
            ToolTipBtnCreateCar.InitialDelay = 1000;
            ToolTipBtnCreateCar.ReshowDelay = 500;
            ToolTipBtnCreateCar.ShowAlways = true;
            ToolTipBtnCreateCar.SetToolTip(this.IbtnRegisterWatchCarModi, "Enregistrer");
        }

        private void BtnJoindreWatchCarModi_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnCreateCar = new ToolTip();
            ToolTipBtnCreateCar.AutoPopDelay = 5000;
            ToolTipBtnCreateCar.InitialDelay = 1000;
            ToolTipBtnCreateCar.ReshowDelay = 500;
            ToolTipBtnCreateCar.ShowAlways = true;
            ToolTipBtnCreateCar.SetToolTip(this.BtnJoindreWatchCarModi, "Joindre doc.");
        }

        private void cbxWatchCardPaieMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT * FROM CARDPAIEMENT WHERE TPYE_CARD = '" + cbxWatchCardPaieMod.Text + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdCardWatchMod = Guid.Parse(MyReader["ID_CARD"].ToString());
                            CartePaieMod = MyReader["NUM_CARD"].ToString();
                            SoldeCarteMod = decimal.Parse(MyReader["SOLDE_CARD"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Fill combobox vehicule
        private void FillCbxCardPaieCleanModMod()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT * FROM CARDPAIEMENT", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            cbxWatchCardPaieMod.Items.Add(MyReader["TPYE_CARD"].ToString());
                            cbxWatchCardPaieMod.DisplayMember = (MyReader["TPYE_CARD"].ToString());
                            cbxWatchCardPaieMod.ValueMember = (MyReader["ID_CARD"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Methode qui calcule le montant total de ravitaillement en carburant
        public void totalAmountCleanCar()
        {
            decimal Mont = 0;
            for (int i = 0; i < dgvPaieWatchCarMod.Rows.Count; ++i)
            {
                Mont += Convert.ToDecimal(dgvPaieWatchCarMod.Rows[i].Cells["TOTALPRIX_PAIE"].Value);
            }

            TxtTotalPaieMod.Text = $"{Mont.ToString("### ### ### ###")} ";
        }
    }
}
