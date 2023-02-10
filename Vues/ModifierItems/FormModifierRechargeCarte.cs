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
    public partial class FormModifierRechargeCarte : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataReader MyReader;
        private SqlDataAdapter SqlAda;
        private DataSet Ds;
        private Guid IdCardPaieRechMod;
        private decimal OldSoldCardPRechMod = 0;
        private decimal OldSoldRech = 0;
        public FormModifierRechargeCarte()
        {
            InitializeComponent();
            FillCbxTypeCardPaiementForRechargMod();
        }

        private void BtnCancelRechargMod_Click(object sender, EventArgs e)
        {
            TxtCodeRechargMod.Clear();TxtMontantRechargMod.Clear();TxtNumCardRechargMod.Clear();CbxTypeCardRechargMod.Text = null;
        }

        private void FillCbxTypeCardPaiementForRechargMod()
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
                            CbxTypeCardRechargMod.Items.Add(MyReader["TPYE_CARD"].ToString());
                            CbxTypeCardRechargMod.DisplayMember = (MyReader["TPYE_CARD"].ToString());
                            CbxTypeCardRechargMod.ValueMember = (MyReader["ID_CARD"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbxTypeCardRechargMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_CARD,NUM_CARD FROM CARDPAIEMENT WHERE TPYE_CARD = '" + CbxTypeCardRechargMod.SelectedItem + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdCardPaieRechMod = Guid.Parse(MyReader[0].ToString());
                            TxtNumCardRechargMod.Text = MyReader[1].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal OldSoldCardPaieRechMod()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT SOLDE_CARD FROM CARDPAIEMENT WHERE TPYE_CARD = '" + CbxTypeCardRechargMod.Text + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            OldSoldCardPRechMod = decimal.Parse(MyReader[0].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OldSoldCardPRechMod;
        }

        private void BtnValiderRechargMod_Click(object sender, EventArgs e)
        {
            if (decimal.Parse(TxtMontantRechargMod.Text) < 0)
            {
                MessageBox.Show("Saisir un montant supérieur à zéro !!!", "GestPark: Error", MessageBoxButtons.OK);
            }
            else if (string.IsNullOrEmpty(CbxTypeCardRechargMod.Text))
            {
                MessageBox.Show("Sélectionner la carte de paiement !!!", "GestPark: Error", MessageBoxButtons.OK);
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
                                // Calculate AmountRest
                                decimal AmountRestRech = decimal.Parse(TxtMontantRechargMod.Text) - OldSoldRechCarte();

                                Cmd.CommandText = " UPDATE RECHARGECARTE SET ID_CARD=@ID_CARD, MONTANT_RECHCARD=@MONTANT_RECHCARD,DATE_RECHCARD=@DATE_RECHCARD WHERE CODE_RECHCARD='"+ TxtCodeRechargMod.Text +"'";
                                Cmd.Parameters.AddWithValue("@ID_CARD", IdCardPaieRechMod);
                                Cmd.Parameters.AddWithValue("@MONTANT_RECHCARD", decimal.Parse(TxtMontantRechargMod.Text));
                                Cmd.Parameters.AddWithValue("@DATE_RECHCARD", DpkRegisterMod.Value.ToString("dd/MM/yyyy"));
                                Cmd.ExecuteNonQuery();

                                
                                // Recharge carte
                                Cmd.CommandText = " UPDATE CARDPAIEMENT SET SOLDE_CARD=@SOLDE_CARD WHERE TPYE_CARD='" + CbxTypeCardRechargMod.SelectedItem + "' ";
                                Cmd.Parameters.AddWithValue("@SOLDE_CARD", (OldSoldCardPaieRechMod() + AmountRestRech));
                                Cmd.ExecuteNonQuery();
                                MessageBox.Show("Votre modification a été prise en compte !!!", "GestPark: Information", MessageBoxButtons.OK);
                                this.Close();
                            }
                        }
                    }
                }
            }
        }

        // Recal the old sold of recharge
        private decimal OldSoldRechCarte()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT MONTANT_RECHCARD FROM RECHARGECARTE WHERE CODE_RECHCARD = '" + TxtCodeRechargMod.Text + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            OldSoldRech = decimal.Parse(MyReader[0].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OldSoldRech;
        }

    }
}
