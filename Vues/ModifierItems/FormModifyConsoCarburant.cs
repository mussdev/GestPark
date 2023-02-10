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
using System.Globalization;

namespace GestPark
{
    public partial class FormModifyConsoCarburant : Form
    {
        private SqlDataReader MyReader;
        private Guid IdVehiCarbMod, IdCardApproMod, IdApproMod;
        private decimal SoldeCardMod=0, HoldKilometerCarMod=0, HoldKilometerVidengeMod=0 , AmountRestCardPaie=0, PrixLitreConso=0, HoldAmountToPayProv=0;
        private SqlCommand SqlCmd;
        private string NumCardMod;
        public FormModifyConsoCarburant()
        {
            InitializeComponent();
            FillCbxCardPaieMod();
            FillComboboxVehiculeCarbMod();
        }

        private void BtnSavedConsoCarbMod_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Voulez vous enregister les modifications ?", "Fleet: CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                    ConnectDB Conn = new ConnectDB(connectionString);

                    using (Conn.cn)
                    {
                        if (Conn.IsConnection)
                        {
                            using (var Cmd = Conn.cn.CreateCommand())
                            {
                                // Déterminer le id de la provision
                                Cmd.CommandText = "SELECT ID_PROV FROM PROVISION WHERE CODE_PROV='" + TxtCodeConsoCarbMod.Text + "'";
                                MyReader = Cmd.ExecuteReader();
                                while (MyReader.Read())
                                {
                                    IdApproMod = Guid.Parse(MyReader["ID_PROV"].ToString());
                                }
                                MyReader.Close();
                            }

                            using (var Cmd = Conn.cn.CreateCommand())
                            {
                                // Mis à jour de la table provision
                                Cmd.CommandText = "UPDATE PROVISION SET MONTANT_PROV=@MONTANT_PROV, DATE_PROV=@DATE_PROV WHERE ID_PROV='" + IdApproMod + "' ";
                                Cmd.Parameters.AddWithValue("@DATE_PROV", DateRegisterConsoCarbMod.Value.ToString("dd/MM/yyyy"));
                                Cmd.Parameters.AddWithValue("@MONTANT_PROV", decimal.Parse(TxtTotalConsoCarMod.Text));
                                Cmd.ExecuteNonQuery();
                            }

                            using (var Cmd = Conn.cn.CreateCommand())
                            {
                                for (int i = 0; i < DvgCarApproMod.Rows.Count - 1; i++)
                                {
                                    // Rappeler les véhicules approvisionnés
                                    string queryProv = "SELECT V.ID_VEHICULE FROM PROVISIONLINE AS P INNER JOIN VEHICULE AS V ON P.ID_VEHICULE=V.ID_VEHICULE WHERE P.ID_PROV = '" + IdApproMod + "' AND V.ID_VEHICULE = '"+ DvgCarApproMod.Rows[i].Cells["IdCarRavi"].Value + "'";
                                    SqlDataAdapter SqlAdaProv = new SqlDataAdapter(queryProv, Conn.cn);
                                    DataTable DtaProv = new DataTable();
                                    SqlAdaProv.Fill(DtaProv);

                                    if (DtaProv.Rows.Count == 1)
                                    {
                                        //MessageBox.Show("Provision Code : " + TxtCodeConsoCarbMod.Text + "Id véhicule existant : " + DtaProv.Rows[0][0].ToString() + " Matricule du véhicule : " + DvgCarApproMod.Rows[i].Cells["ImmatCarMod"].Value + "Id véhicule : " + DvgCarApproMod.Rows[i].Cells["IdCarRavi"].Value);
                                        Cmd.CommandText = "UPDATE PROVISIONLINE SET MONTANT_PROV=@MONTANT_PROV,LITRE_PROV=@LITRE_PROV,KILO_AVANT_VIDENGE=@KILO_AVANT_VIDENGE,KILO_TOTAL_OLD_PROV=@KILO_TOTAL_OLD_PROV WHERE PROVISIONLINE.ID_VEHICULE='" + DvgCarApproMod.Rows[i].Cells["IdCarRavi"].Value + "' AND PROVISIONLINE.ID_PROV = '" + IdApproMod + "' ";
                                        Cmd.Parameters.AddWithValue("@MONTANT_PROV", Convert.ToDecimal(DvgCarApproMod.Rows[i].Cells["AmountCarb"].Value));
                                        Cmd.Parameters.AddWithValue("@LITRE_PROV", (Convert.ToDecimal(DvgCarApproMod.Rows[i].Cells["AmountCarb"].Value) / Convert.ToDecimal(DvgCarApproMod.Rows[i].Cells["PrixLitreCarb"].Value)));
                                        Cmd.Parameters.AddWithValue("@KILO_AVANT_VIDENGE", DvgCarApproMod.Rows[i].Cells["KilometrageVidangeAva"].Value ?? DBNull.Value);
                                        Cmd.Parameters.AddWithValue("@KILO_TOTAL_OLD_PROV", DvgCarApproMod.Rows[i].Cells["kilometrageTotalCar"].Value ?? DBNull.Value);
                                        //Cmd.Parameters.AddWithValue("@DATE_PROV", DateRegisterConsoCarbMod.Value.ToString("dd/MM/yyyy"));
                                        Cmd.ExecuteNonQuery();
                                        Cmd.Parameters.Clear();

                                        // Update car meleage
                                        Decimal OnlyCarKilomHebdoMod = Convert.ToDecimal(DvgCarApproMod.Rows[i].Cells["KilometrageVidangeAva"].Value);
                                        Decimal HoldKilometerToVdgeMod = Convert.ToDecimal(DvgCarApproMod.Rows[i].Cells["KilometrageTotalCar"].Value);
                                        Decimal KilometreEffectMod = (OnlyCarKilomHebdoMod - HoldKilometerToVdgeMod);
                                        
                                        Cmd.CommandText = "UPDATE VEHICULE SET KILOMETRAGE_VIDENGE_VEHICULE=@KILOMETRAGE_VIDENGE_VEHICULE,TOTALKILOMETRAGE_VEHICULE=@TOTALKILOMETRAGE_VEHICULE WHERE ID_VEHICULE='" + DvgCarApproMod.Rows[i].Cells["IdCarRavi"].Value + "' ";
                                        Cmd.Parameters.AddWithValue("@KILOMETRAGE_VIDENGE_VEHICULE", (Convert.ToDecimal(DvgCarApproMod.Rows[i].Cells["AncienCompteurVidange"].Value) + KilometreEffectMod));
                                        Cmd.Parameters.AddWithValue("@TOTALKILOMETRAGE_VEHICULE", Convert.ToDecimal(DvgCarApproMod.Rows[i].Cells["KilometrageVidangeAva"].Value));
                                        Cmd.ExecuteNonQuery();

                                    }
                                    else
                                    {
                                        //MessageBox.Show("Matricule du nouveau véhicule ajoute : " + DvgCarApproMod.Rows[i].Cells["ImmatCarMod"].Value);
                                        Cmd.CommandText = "INSERT INTO PROVISIONLINE (ID_VEHICULE,ID_PROV,KILO_AVANT_VIDENGE,MONTANT_PROV,LITRE_PROV,KILO_TOTAL_OLD_PROV,ANCIEN_COUNT_VIDANGE_PROV,PRIX_LITRE_PROV,DATECREATE_PROV) VALUES (@ID_VEHICULE,@ID_PROV,@KILO_AVANT_VIDENGE,@MONTANT_PROV,@LITRE_PROV,@KILO_TOTAL_OLD_PROV,@ANCIEN_COUNT_VIDANGE_PROV,@PRIX_LITRE_PROV,GETDATE())";
                                        Cmd.Parameters.AddWithValue("@ID_VEHICULE", DvgCarApproMod.Rows[i].Cells["IdCarRavi"].Value ?? DBNull.Value);
                                        Cmd.Parameters.AddWithValue("@ID_PROV", IdApproMod);
                                        Cmd.Parameters.AddWithValue("@MONTANT_PROV", Convert.ToDecimal(DvgCarApproMod.Rows[i].Cells["AmountCarb"].Value));
                                        Cmd.Parameters.AddWithValue("@LITRE_PROV", (Convert.ToDecimal(DvgCarApproMod.Rows[i].Cells["AmountCarb"].Value) / Convert.ToDecimal(DvgCarApproMod.Rows[i].Cells["PrixLitreCarb"].Value)));
                                        Cmd.Parameters.AddWithValue("@KILO_AVANT_VIDENGE", Convert.ToDecimal(DvgCarApproMod.Rows[i].Cells["KilometrageVidangeAva"].Value));
                                        Cmd.Parameters.AddWithValue("@KILO_TOTAL_OLD_PROV", Convert.ToDecimal(DvgCarApproMod.Rows[i].Cells["kilometrageTotalCar"].Value));
                                        Cmd.Parameters.AddWithValue("@ANCIEN_COUNT_VIDANGE_PROV", Convert.ToDecimal(DvgCarApproMod.Rows[i].Cells["AncienCompteurVidange"].Value));
                                        //Cmd.Parameters.AddWithValue("@DATE_PROV", DateRegisterConsoCarbMod.Value.ToString("dd/MM/yyyy"));
                                        Cmd.Parameters.AddWithValue("@PRIX_LITRE_PROV", Convert.ToDecimal(DvgCarApproMod.Rows[i].Cells["PrixLitreCarb"].Value));
                                        Cmd.ExecuteNonQuery();
                                        Cmd.Parameters.Clear();

                                        // Update car meleage
                                        Decimal OnlyCarKilomHebdo = Convert.ToDecimal(DvgCarApproMod.Rows[i].Cells["KilometrageVidangeAva"].Value);
                                        Decimal HoldKilometer = Convert.ToDecimal(DvgCarApproMod.Rows[i].Cells["KilometrageTotalCar"].Value);
                                        Decimal KilometreEffect = (OnlyCarKilomHebdo - HoldKilometer);
                                        
                                        Cmd.CommandText = "UPDATE VEHICULE SET KILOMETRAGE_VIDENGE_VEHICULE=@KILOMETRAGE_VIDENGE_VEHICULE,TOTALKILOMETRAGE_VEHICULE=@TOTALKILOMETRAGE_VEHICULE WHERE ID_VEHICULE='" + DvgCarApproMod.Rows[i].Cells["IdCarRavi"].Value + "' ";
                                        Cmd.Parameters.AddWithValue("@KILOMETRAGE_VIDENGE_VEHICULE", (Convert.ToDecimal(DvgCarApproMod.Rows[i].Cells["AncienCompteurVidange"].Value) + KilometreEffect));
                                        Cmd.Parameters.AddWithValue("@TOTALKILOMETRAGE_VEHICULE", (HoldKilometer + KilometreEffect));
                                        Cmd.ExecuteNonQuery();

                                    }

                                }

                                // Code qui gère la mise à jour les paiements des approvisionnements des véhicules en carburant

                                for (int j = 0; j < DgvPaieMod.Rows.Count - 1; j++)
                                {
                                    // Rappeler les cartes qui ont servi de paiement
                                    string queryPaie = "SELECT * FROM PAIEMENT AS PAIE INNER JOIN PROVISION AS PROV ON PAIE.ID_PROV=PROV.ID_PROV INNER JOIN CARDPAIEMENT AS CARDP ON PAIE.ID_CARD=CARDP.ID_CARD WHERE PROV.CODE_PROV = '" + TxtCodeConsoCarbMod.Text + "' AND CARDP.ID_CARD='" + DgvPaieMod.Rows[j].Cells["IdCard"].Value + "' ";
                                    SqlDataAdapter SqlAdaPaie = new SqlDataAdapter(queryPaie, Conn.cn);
                                    DataTable dtaPaie = new DataTable();
                                    SqlAdaPaie.Fill(dtaPaie);

                                    if(dtaPaie.Rows.Count == 1)
                                    {
                                        // Recuperer l'ancien montant débité
                                        Cmd.CommandText = "SELECT TOTALPRIX_PAIE FROM PAIEMENT WHERE ID_PROV='" + IdApproMod + "' AND ID_CARD='" + Guid.Parse(DgvPaieMod.Rows[j].Cells["IdCard"].Value.ToString()) + "'";
                                        MyReader = Cmd.ExecuteReader();
                                        while (MyReader.Read())
                                        {
                                            HoldAmountToPayProv = decimal.Parse(MyReader["TOTALPRIX_PAIE"].ToString());
                                        }
                                        MyReader.Close();

                                        //MessageBox.Show("Anciennne carte : " + DgvPaieMod.Rows[j].Cells["IdCard"].Value + "Ancien montant debité : " + DgvPaieMod.Rows[j].Cells["holdAmountCard"].Value + " Nouveau montant à débite : " + DgvPaieMod.Rows[j].Cells["AmountCard"].Value + " Id provision = " + IdApproMod + "\n" + " Id paie : " + DgvPaieMod.Rows[j].Cells["IdPaie"].Value);
                                        Cmd.CommandText = "UPDATE PAIEMENT SET TOTALPRIX_PAIE=@TOTALPRIX_PAIE,DATE_PAIE=@DATE_PAIE,MODIFYDATE_PAIE=GETDATE() WHERE ID_PAIE='" + DgvPaieMod.Rows[j].Cells["IdPaie"].Value + "' ";
                                        Cmd.Parameters.AddWithValue("@TOTALPRIX_PAIE", Convert.ToDecimal(DgvPaieMod.Rows[j].Cells["AmountCard"].Value) );
                                        Cmd.Parameters.AddWithValue("@DATE_PAIE", datePaieMod.Value.ToString("dd/MM/yyyy"));
                                        Cmd.ExecuteNonQuery();
                                        Cmd.Parameters.Clear();

                                        //MessageBox.Show("Ancien paiement : " + HoldAmountToPayProv);
                                        // Calculer la valeur ajoutée
                                        Decimal ValueAddProv = (HoldAmountToPayProv - Convert.ToDecimal(DgvPaieMod.Rows[j].Cells["AmountCard"].Value.ToString()));
                                        // Récuperer le montant de la carte qui a servi le paiement
                                        Decimal totalAmountCard = Convert.ToDecimal(DgvPaieMod.Rows[j].Cells["SoldeReel"].Value.ToString()) + ValueAddProv;

                                        // MessageBox.Show("Valeur ajoutée = " + ValueAddProv + " Solde Carte = " + totalAmountCard);

                                        // Mise à jour du solde de la carte des paiements de carburant
                                        Cmd.CommandText = "UPDATE CARDPAIEMENT SET SOLDE_CARD=@SOLDE_CARD WHERE ID_CARD='" + DgvPaieMod.Rows[j].Cells["IdCard"].Value + "'";
                                        Cmd.Parameters.AddWithValue("@SOLDE_CARD", totalAmountCard);
                                        Cmd.ExecuteNonQuery();
                                    }
                                    else
                                    {
                                        // MessageBox.Show("Nouvelle carte ajoutée : " + DgvPaieMod.Rows[j].Cells["CardNum"].Value + "");
                                        // Inserer une nouvelle carte pour les paiements de l'approvisionnement
                                        // Recuperer le montant de la carte qui a servi le paiement
                                        Cmd.CommandText = "SELECT SOLDE_CARD FROM CARDPAIEMENT WHERE ID_CARD='" + DgvPaieMod.Rows[j].Cells["IdCard"].Value + "'";
                                        MyReader = Cmd.ExecuteReader();
                                        while (MyReader.Read())
                                        {
                                            AmountRestCardPaie = decimal.Parse(MyReader["SOLDE_CARD"].ToString());
                                        }
                                        MyReader.Close();
                                        // MessageBox.Show("IdCard : " + IdApproMod + " AncienSolde : " + AmountRestCardPaie + " Id Carte : " + DgvPaieMod.Rows[j].Cells["IdCard"].Value + "Code provision : " + TxtCodeConsoCarbMod.Text);
                                        Cmd.CommandText = "INSERT INTO PAIEMENT (ID_PROV,ID_CARD,TOTALPRIX_PAIE,ANCIEN_SOLDE_CARTE_PAIE,DATECREATE_PAIE) VALUES (@ID_PROV,@ID_CARD,@TOTALPRIX_PAIE,@ANCIEN_SOLDE_CARTE_PAIE,GETDATE())";
                                        Cmd.Parameters.AddWithValue("@ID_PROV", IdApproMod);
                                        Cmd.Parameters.AddWithValue("@ID_CARD", DgvPaieMod.Rows[j].Cells["IdCard"].Value ?? DBNull.Value);
                                        Cmd.Parameters.AddWithValue("@TOTALPRIX_PAIE", DgvPaieMod.Rows[j].Cells["AmountCard"].Value ?? DBNull.Value);
                                        Cmd.Parameters.AddWithValue("@ANCIEN_SOLDE_CARTE_PAIE", AmountRestCardPaie);
                                        Cmd.Parameters.AddWithValue("@DATE_PAIE", datePaieMod.Value.ToString("dd/MM/yyyy"));
                                        Cmd.ExecuteNonQuery();
                                        Cmd.Parameters.Clear();

                                        // Mise à jour du solde de la carte des paiements de carburant
                                        decimal totalAmountCard = AmountRestCardPaie - decimal.Parse(DgvPaieMod.Rows[j].Cells["AmountCard"].Value.ToString());
                                        Cmd.CommandText = "UPDATE CARDPAIEMENT SET SOLDE_CARD=@SOLDE_CARD WHERE ID_CARD='" + DgvPaieMod.Rows[j].Cells["IdCard"].Value + "'";
                                        Cmd.Parameters.AddWithValue("@SOLDE_CARD", totalAmountCard);
                                        Cmd.ExecuteNonQuery();

                                    }

                                }

                                MessageBox.Show("Vos modifications ont été enregistrées avec succès !", "Fleet: Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
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

        private int rowIndex = 0;
        private void DvgCarApproMod_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.DvgCarApproMod.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.DvgCarApproMod.CurrentCell = this.DvgCarApproMod.Rows[e.RowIndex].Cells[1];
                this.MenuDeleteProv.Show(this.DvgCarApproMod, e.Location);
                MenuDeleteProv.Show(Cursor.Position);
            }
        }

        //private int rowIndexPaie = 0;
        private void DgvPaieMod_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.DgvPaieMod.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.DgvPaieMod.CurrentCell = this.DgvPaieMod.Rows[e.RowIndex].Cells[1];
                this.MenuDeletePaie.Show(this.DgvPaieMod, e.Location);
                MenuDeletePaie.Show(Cursor.Position);
            }
        }

        private void CbxVehiConsoCabMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_VEHICULE, TOTALKILOMETRAGE_VEHICULE,KILOMETRAGE_VIDENGE_VEHICULE,CODE_VEHICULE,PRIXLITRE_TYPCONSO FROM VEHICULE LEFT OUTER JOIN TYPECONSOMMATION ON VEHICULE.ID_TYPCONSO=TYPECONSOMMATION.ID_TYPCONSO WHERE IMMATRICULATION_VEHICULE = '" + CbxVehiConsoCabMod.SelectedItem + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdVehiCarbMod = Guid.Parse(MyReader["ID_VEHICULE"].ToString());
                            HoldKilometerCarMod = decimal.Parse(MyReader["TOTALKILOMETRAGE_VEHICULE"].ToString());
                            HoldKilometerVidengeMod = decimal.Parse(MyReader["KILOMETRAGE_VIDENGE_VEHICULE"].ToString());
                            PrixLitreConso = decimal.Parse(MyReader["PRIXLITRE_TYPCONSO"].ToString());
                            txtKiloTotalMod.Text = string.Format(CultureInfo.GetCultureInfo("fr"), "{0:n}", MyReader["TOTALKILOMETRAGE_VEHICULE"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbxCartPaieApproMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        
                        SqlCmd = new SqlCommand("SELECT ID_CARD,NUM_CARD,SOLDE_CARD FROM CARDPAIEMENT WHERE TPYE_CARD = '" + CbxCartPaieApproMod.Text + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();

                        while (MyReader.Read())
                        {
                            IdCardApproMod = Guid.Parse(MyReader["ID_CARD"].ToString());
                            NumCardMod = MyReader["NUM_CARD"].ToString();
                            SoldeCardMod = decimal.Parse(MyReader["SOLDE_CARD"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAddCarMod_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CbxVehiConsoCabMod.Text))
            {
                if (decimal.Parse(TxtAmountConsoOnlyCarApproMod.Text) > 0)
                {
                    if (decimal.Parse(TxtkilometrageHebdoCarbMod.Text) > 0 && decimal.Parse(TxtkilometrageHebdoCarbMod.Text) > HoldKilometerCarMod)
                    {
                        DataTable dataTableProv = (DataTable)DvgCarApproMod.DataSource;
                        DataRow drToAddProv = dataTableProv.NewRow();
                        // Definir les colonnes de la table
                        drToAddProv["IdCarRavi"] = IdVehiCarbMod;
                        drToAddProv["ImmatCarMod"] = CbxVehiConsoCabMod.Text;
                        drToAddProv["kilometrageTotalCar"] = decimal.Parse(txtKiloTotalMod.Text);
                        drToAddProv["KilometrageVidangeAva"] = decimal.Parse(TxtkilometrageHebdoCarbMod.Text);
                        drToAddProv["AmountCarb"] = decimal.Parse(TxtAmountConsoOnlyCarApproMod.Text);
                        drToAddProv["AncienCompteurVidange"] = HoldKilometerVidengeMod;
                        drToAddProv["PrixLitreCarb"] = PrixLitreConso;
                        dataTableProv.Rows.Add(drToAddProv);
                        dataTableProv.AcceptChanges();

                        // Calculer le montant total debité sur la carte
                        totalAmountRavitaillementCarb();
                        CbxVehiConsoCabMod.Text = null; txtKiloTotalMod.Clear(); TxtkilometrageHebdoCarbMod.Clear(); TxtAmountConsoOnlyCarApproMod.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Veillez saisir une valeur positive ou la valeur doit être supérieure au kilomètre total !!!", "Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Veillez saisi un montant positif !!!", "Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Fleet: Avertissement", "Veillez sélectionner le véhicule svp !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MenuItemDeletePaie_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(string.Format("Voulez vous supprimer ce paiement ?" /*DgvPaieMod.Cells["IdCard"].Value*/), "Confirmation",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                    ConnectDB Conn = new ConnectDB(connectionString);

                    using (Conn.cn)
                    {
                        if (Conn.IsConnection)
                        {
                            Guid KeyPaieDelete = Guid.Parse(DgvPaieMod.SelectedRows[0].Cells[4].Value.ToString());
                            decimal holdAmountOfCard = decimal.Parse(DgvPaieMod.SelectedRows[0].Cells[2].Value.ToString());
                            Guid KeyCard = Guid.Parse(DgvPaieMod.SelectedRows[0].Cells[0].Value.ToString());
                            //MessageBox.Show("Le paiement sélectionné est : " + KeyPaieDelete + " Ancien solde de la carte : " + holdAmountOfCard + " Id Carte : " + KeyCard);
                            
                            using (var Cmd = Conn.cn.CreateCommand())
                            {
                                Cmd.CommandText = "DELETE FROM PAIEMENT WHERE ID_PAIE = '" + KeyPaieDelete + "' ";
                                Cmd.ExecuteNonQuery();
                            }

                            // Mettre à jour la carte de paiement
                            using (var Cmd = Conn.cn.CreateCommand())
                            {
                                Cmd.CommandText = "UPDATE CARDPAIEMENT SET SOLDE_CARD=@paramSoldCard WHERE ID_CARD=@paramIdCard ";
                                Cmd.Parameters.AddWithValue("@paramSoldCard", holdAmountOfCard);
                                Cmd.Parameters.AddWithValue("@paramIdCard", KeyCard);
                                Cmd.ExecuteNonQuery();
                            }
                               
                            // Effacer la ligne supprimer dans le datagridview
                            int rowIndex = DgvPaieMod.CurrentCell.RowIndex;
                            DgvPaieMod.Rows.RemoveAt(rowIndex);

                            MessageBox.Show("Vous venez de supprimer un paiement ou une carte de paiement avec succès", "Fleet: Informations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Fleet : Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnAddCardApproMod_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CbxCartPaieApproMod.Text) && !string.IsNullOrEmpty(TxtAmountApproMod.Text))
            {
                DataTable dataTablePaie = (DataTable)DgvPaieMod.DataSource;
                DataRow drToAddPaie = dataTablePaie.NewRow();
                // Definir les colonnes de la table
                drToAddPaie["IdCard"] = IdCardApproMod;
                drToAddPaie["CardNum"] = NumCardMod;
                drToAddPaie["AmountCard"] = decimal.Parse(TxtAmountApproMod.Text);
                drToAddPaie["holdAmountCard"] = SoldeCardMod;
                dataTablePaie.Rows.Add(drToAddPaie);
                dataTablePaie.AcceptChanges();

                // Calculer le montant total debité sur la carte
                totalToPay();

                // Nettoyer les champs
                CbxCartPaieApproMod.Text=null; TxtAmountApproMod.Clear();
            }
            else
                MessageBox.Show("Veillez choisir carte à débiter ou saisir le montant à débiter sur la carte !", "Fleet: Gestion des erreurs !", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
        }

        // Fill combobox vehicule
        private void FillCbxCardPaieMod()
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
                            CbxCartPaieApproMod.Items.Add(MyReader["TPYE_CARD"].ToString());
                            CbxCartPaieApproMod.DisplayMember = (MyReader["TPYE_CARD"].ToString());
                            CbxCartPaieApproMod.ValueMember = (MyReader["ID_CARD"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtAmountConsoOnlyCarApproMod_TextChanged(object sender, EventArgs e)
        {
            if (TxtAmountConsoOnlyCarApproMod.Text == "" || TxtAmountConsoOnlyCarApproMod.Text == "0") return;
            decimal price;
            price = decimal.Parse(TxtAmountConsoOnlyCarApproMod.Text, System.Globalization.NumberStyles.Currency);
            TxtAmountConsoOnlyCarApproMod.Text = price.ToString("#,#");
            TxtAmountConsoOnlyCarApproMod.SelectionStart = TxtAmountConsoOnlyCarApproMod.Text.Length;
        }

        private void MenuItemDeletProv_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("Voulez vous rétirer ce véhicule de l'approvisionnement ?"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                    ConnectDB Conn = new ConnectDB(connectionString);
                    using (Conn.cn)
                    {
                        if (Conn.IsConnection)
                        {
                            //string KeyCarDelete = DgvPaieMod.SelectedRows[0].Cells[4].Value.ToString();
                            decimal holdKilometrage = decimal.Parse(DvgCarApproMod.SelectedRows[0].Cells["kilometrageTotalCar"].Value.ToString());
                            decimal holdCompteurVidange = decimal.Parse(DvgCarApproMod.SelectedRows[0].Cells["AncienCompteurVidange"].Value.ToString());
                            Guid KeyVehi = Guid.Parse(DvgCarApproMod.SelectedRows[0].Cells["IdCarRavi"].Value.ToString());
                            //MessageBox.Show("Le paiement sélectionné est : " + KeyPaieDelete + " Ancien solde de la carte : " + holdAmountOfCard + " Id Carte : " + KeyCard);

                            using (var Cmd = Conn.cn.CreateCommand())
                            {
                                Cmd.CommandText = "DELETE FROM PROVISION WHERE ID_VEHICULE = '" + KeyVehi + "' AND CODE_PROV = '" +TxtCodeConsoCarbMod.Text+ "' ";
                                Cmd.ExecuteNonQuery();
                            }

                            // Mettre à jour la carte de paiement
                            using (var Cmd = Conn.cn.CreateCommand())
                            {
                                Cmd.CommandText = "UPDATE VEHICULE SET TOTALKILOMETRAGE_VEHICULE=@paramHoldKilo, KILOMETRAGE_VIDENGE_VEHICULE=@paramHoldCptVidange WHERE ID_VEHICULE=@paramIdVehi ";
                                Cmd.Parameters.AddWithValue("@paramHoldKilo", holdKilometrage);
                                Cmd.Parameters.AddWithValue("@paramHoldCptVidange", holdCompteurVidange);
                                Cmd.Parameters.AddWithValue("@paramIdVehi", KeyVehi);
                                Cmd.ExecuteNonQuery();
                            }

                            // Effacer la ligne supprimer dans le datagridview
                            int rowIndex = DvgCarApproMod.CurrentCell.RowIndex;
                            DvgCarApproMod.Rows.RemoveAt(rowIndex);

                            MessageBox.Show("Vous venez de rétirer le véhicule de l'approvisionnement !!!", "Fleet: Informations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Fleet : Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TxtkilometrageHebdoCarbMod_TextChanged(object sender, EventArgs e)
        {
            if (TxtkilometrageHebdoCarbMod.Text == "" || TxtkilometrageHebdoCarbMod.Text == "0") return;
            decimal price;
            price = decimal.Parse(TxtkilometrageHebdoCarbMod.Text, System.Globalization.NumberStyles.Currency);
            TxtkilometrageHebdoCarbMod.Text = price.ToString("#,#");
            TxtkilometrageHebdoCarbMod.SelectionStart = TxtkilometrageHebdoCarbMod.Text.Length;
        }

        private void TxtAmountApproMod_TextChanged(object sender, EventArgs e)
        {
            if (TxtAmountApproMod.Text == "" || TxtAmountApproMod.Text == "0") return;
            decimal price;
            price = decimal.Parse(TxtAmountApproMod.Text, System.Globalization.NumberStyles.Currency);
            TxtAmountApproMod.Text = price.ToString("#,#");
            TxtAmountApproMod.SelectionStart = TxtAmountApproMod.Text.Length;
        }


        // Fill combobox vehicule
        private void FillComboboxVehiculeCarbMod()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT * FROM VEHICULE WHERE TYPE_VEHICULE <> 'Affecté'", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            CbxVehiConsoCabMod.Items.Add(MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            CbxVehiConsoCabMod.DisplayMember = (MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            CbxVehiConsoCabMod.ValueMember = (MyReader["ID_VEHICULE"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void TotalAmountConsoCarbu()
        {
            int Mont = 0;
            for (int i = 0; i < DvgCarApproMod.Rows.Count; ++i)
            {
                Mont += Convert.ToInt32(DvgCarApproMod.Rows[i].Cells["AmountCarb"].Value);
            }
            
            TxtTotalConsoCarMod.Text = string.Format(CultureInfo.GetCultureInfo("fr"), "{0:n}", Mont);
        }

        public void TotalAmountPaieCard()
        {
            Decimal Mont = 0;
            for (int i = 0; i < DgvPaieMod.Rows.Count; ++i)
            {
                Mont += Convert.ToInt32(DgvPaieMod.Rows[i].Cells["AmountCard"].Value);
            }

            TxtTotalAmountCardMod.Text = string.Format(CultureInfo.GetCultureInfo("fr"), "{0:n}", Mont);
        }

        // Methode qui calcule la somme totale débitée sur les cartes de carburant
        private void totalToPay()
        {
            decimal Mont = 0;
            for (int i = 0; i < DgvPaieMod.Rows.Count; ++i)
            {
                Mont += Convert.ToDecimal(DgvPaieMod.Rows[i].Cells["AmountCard"].Value);
            }

            TxtTotalAmountCardMod.Text = string.Format(CultureInfo.GetCultureInfo("fr"), "{0:n}", Mont);
        }

        // Methode qui calcule le montant total de ravitaillement en carburant
        private void totalAmountRavitaillementCarb()
        {
            decimal Mont = 0;
            for (int i = 0; i < DvgCarApproMod.Rows.Count; ++i)
            {
                Mont += Convert.ToDecimal(DvgCarApproMod.Rows[i].Cells["AmountCarb"].Value);
            }

            TxtTotalConsoCarMod.Text = string.Format(CultureInfo.GetCultureInfo("fr"), "{0:n}", Mont);
        }

    }
}
