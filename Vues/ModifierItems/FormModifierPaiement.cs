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

namespace GestPark
{
    public partial class FormModifierPaiement : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataReader MyReader;
        private DataSet Ds;
        private Guid IdCardPaieMod;
        private Guid IdCardProvMod;
        private decimal OldSoldCardPMod = 0;
        private decimal OldSoldPaie = 0;
        private decimal AmountRest = 0;
        public FormModifierPaiement()
        {
            InitializeComponent();
            FillCbxTypeCardPaiementMod();
        }

        private void BtnCancelPaiementCarbMod_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtPrixTotalCarbuMod_TextChanged(object sender, EventArgs e)
        {
            TxtLitreCarbuMod.Text = string.Format("{0:0.##}", (decimal.Parse(TxtPrixTotalCarbuMod.Text) / decimal.Parse(TxtPrixUnitaireCarbuMod.Text)));
        }

        // Fill combobox vehicule
        private void FillCbxTypeCardPaiementMod()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_CARD,TPYE_CARD FROM CARDPAIEMENT", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            CbxTypCartPaieMod.Items.Add(MyReader["TPYE_CARD"].ToString());
                            CbxTypCartPaieMod.DisplayMember = (MyReader["TPYE_CARD"].ToString());
                            CbxTypCartPaieMod.ValueMember = (MyReader["ID_CARD"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbxTypCartPaieMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        // MessageBox.Show("Test");
                        SqlCmd = new SqlCommand("SELECT ID_CARD,NUM_CARD FROM CARDPAIEMENT WHERE TPYE_CARD = '" + CbxTypCartPaieMod.SelectedItem + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        //MessageBox.Show("Test");
                        while (MyReader.Read())
                        {
                            IdCardPaieMod = Guid.Parse(MyReader[0].ToString());
                            TxtNumPaieMod.Text = MyReader[1].ToString();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnValiderPaieMod_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtCodeApproMod.Text))
            {
                MessageBox.Show("Rensignez le code d'approvisionnement !!!", "GestPark: Error", MessageBoxButtons.OK);
            }
            else if (string.IsNullOrEmpty(CbxTypCartPaieMod.Text))
            {
                MessageBox.Show("Sélectionner la carte de paiement !!!", "GestPark: Error", MessageBoxButtons.OK);
            }
            else if (decimal.Parse(TxtPrixTotalCarbuMod.Text) <= 0)
            {
                MessageBox.Show("Saisir un montant supérieur à zéro !!!", "GestPark: Error", MessageBoxButtons.OK);
            }
            else
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                DialogResult result = MessageBox.Show("Voulez vous enregister ?", "GESTPARK: CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (Conn.cn)
                    {
                        if (Conn.IsConnection)
                        {
                            using (var Cmd = Conn.cn.CreateCommand())
                            {
                                if (OldSoldCardPaieMod() > decimal.Parse(TxtPrixTotalCarbuMod.Text))
                                {
                                    Cmd.CommandText = " UPDATE PAIEMENT SET ID_PROV=@ID_PROV,ID_CARD=@ID_CARD,LITRE_PAIE=@LITRE_PAIE,TOTALPRIX_PAIE=@TOTALPRIX_PAIE,DATE_PAIE=@DATE_PAIE,MODIFYDATE_PAIE=GETDATE() WHERE CODE_PAIE='" + TxtCodePaieMod.Text + "' ";
                                    Cmd.Parameters.AddWithValue("@ID_PROV", IdProvisionMod());
                                    Cmd.Parameters.AddWithValue("@ID_CARD", IdCardPaieMod);
                                    // Cmd.Parameters.AddWithValue("@CODE_PAIE", CodPaie);
                                    Cmd.Parameters.AddWithValue("@LITRE_PAIE", decimal.Parse(TxtLitreCarbuMod.Text));
                                    Cmd.Parameters.AddWithValue("@TOTALPRIX_PAIE", decimal.Parse(TxtPrixTotalCarbuMod.Text));
                                    Cmd.Parameters.AddWithValue("@DATE_PAIE", DateRegisterPaieMod.Value.ToString("dd/MM/yyyy"));
                                    Cmd.ExecuteNonQuery();

                                    // Update Card sold
                                    AmountRest = (OldSoldToPaie() - decimal.Parse(TxtPrixTotalCarbuMod.Text));

                                    //MessageBox.Show("Valeur ajoutée = " + (OldSoldToPaie() - decimal.Parse(TxtPrixTotalCarbuMod.Text)) + " Solde Card = " + (OldSoldCardPaieMod()+ AmountRest));

                                    Cmd.CommandText = " UPDATE CARDPAIEMENT SET SOLDE_CARD=@SOLDE_CARD WHERE TPYE_CARD='" + CbxTypCartPaieMod.Text + "'  ";
                                    Cmd.Parameters.AddWithValue("@SOLDE_CARD", (OldSoldCardPaieMod() + AmountRest));
                                    Cmd.ExecuteNonQuery();

                                    // Update Table carburant statut

                                    //Cmd.CommandText = " UPDATE PROVISION SET STATUT_PROV=@STATUT_PROV WHERE CODE_PROV='" + TxtCodeApproMod.Text + "'  ";
                                    //Cmd.Parameters.AddWithValue("@STATUT_PROV", "Payé");
                                    //Cmd.ExecuteNonQuery();

                                    MessageBox.Show("Paiement effectué avec succès !!!", "GestPark: Information", MessageBoxButtons.OK);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Vous n'avez pas suffisament de montant sur la carte pour le reglement", "GestPark: Avertissement !", MessageBoxButtons.OK);
                                }
                            }
                        }
                    }
                }
            }
        }

        private Guid IdProvisionMod()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_PROV FROM PROVISION WHERE CODE_PROV = '" + TxtCodeApproMod.Text + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdCardProvMod = Guid.Parse(MyReader[0].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return IdCardProvMod;
        }

        private decimal OldSoldCardPaieMod()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT SOLDE_CARD FROM CARDPAIEMENT WHERE TPYE_CARD = '" + CbxTypCartPaieMod.Text + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            OldSoldCardPMod = decimal.Parse(MyReader[0].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OldSoldCardPMod;
        }


        private decimal OldSoldToPaie()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT TOTALPRIX_PAIE FROM PAIEMENT WHERE CODE_PAIE = '" + TxtCodePaieMod.Text + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            OldSoldPaie = decimal.Parse(MyReader[0].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OldSoldPaie;
        }

    }
}
