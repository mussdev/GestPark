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
    public partial class FormRechargeCarte : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataReader MyReader;
        private Guid IdCardPaieRech;
        private DataSet Ds;
        private SqlDataAdapter SqlAda;
        private decimal OldSoldCardPRech = 0;
        public FormRechargeCarte()
        {
            InitializeComponent();
            FillCbxTypeCardPaiementForRecharg();
        }

        private void BtnCancelRecharg_Click(object sender, EventArgs e)
        {
            TxtCodeRecharg.Clear();TxtMontantRecharg.Clear();TxtNumCardRecharg.Clear();CbxTypeCardRecharg.Text = null;
        }

        private void FillCbxTypeCardPaiementForRecharg()
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
                            CbxTypeCardRecharg.Items.Add(MyReader["TPYE_CARD"].ToString());
                            CbxTypeCardRecharg.DisplayMember = (MyReader["TPYE_CARD"].ToString());
                            CbxTypeCardRecharg.ValueMember = (MyReader["ID_CARD"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbxTypeCardRecharg_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_CARD,NUM_CARD FROM CARDPAIEMENT WHERE TPYE_CARD = '" + CbxTypeCardRecharg.SelectedItem + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdCardPaieRech = Guid.Parse(MyReader[0].ToString());
                            TxtNumCardRecharg.Text = MyReader[1].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Generate code of personne
        private string generateCodeRechgCarte()
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
                        SqlCmd = new SqlCommand("SELECT CODE_RECHCARD FROM RECHARGECARTE WHERE CODE_RECHCARD=(SELECT MAX(CODE_RECHCARD) FROM RECHARGECARTE)", Conn.cn);
                        SqlAda = new SqlDataAdapter(SqlCmd);
                        Ds = new DataSet();
                        SqlAda.Fill(Ds);

                        if (Ds.Tables[0].Rows.Count > 0)
                        {
                            TxtCodeRecharg.Text = Ds.Tables[0].Rows[0]["CODE_RECHCARD"].ToString();
                        }
                        else
                        {
                            TxtCodeRecharg.Text = "RECH0000";
                        }
                        if (!string.IsNullOrEmpty(TxtCodeRecharg.Text))
                        {
                            TxtCodeRecharg.SelectionStart = 4;
                            TxtCodeRecharg.SelectionLength = 4;
                            TxtCodeRecharg.Text = TxtCodeRecharg.SelectedText;
                        }
                        if (!string.IsNullOrEmpty(TxtCodeRecharg.Text))
                        {
                            int codeRechCard = int.Parse(TxtCodeRecharg.Text.ToString()) + 1;
                            TxtCodeRecharg.Text = codeRechCard.ToString("RECH0000");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return TxtCodeRecharg.Text;
        }

        private void BtnValiderRecharg_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtMontantRecharg.Text) && decimal.Parse(TxtMontantRecharg.Text) < 0)
            {
                MessageBox.Show("Saisir un montant supérieur à zéro !!!", "GestParc: Gestion des erreurs", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(CbxTypeCardRecharg.Text))
            {
                MessageBox.Show("Sélectionner la carte de paiement !!!", "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                DialogResult result = MessageBox.Show("Voulez vous enregister ?", "GESTPARC: CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (Conn.cn)
                    {
                        if (Conn.IsConnection)
                        {
                            string CodRechCarte = generateCodeRechgCarte();
                            using (var Cmd = Conn.cn.CreateCommand())
                            {
                                Cmd.CommandText = " INSERT INTO RECHARGECARTE (ID_CARD,CODE_RECHCARD,MONTANT_RECHCARD,DATE_RECHCARD,DATECREATE_RECHCARD) VALUES (@ID_CARD,@CODE_RECHCARD,@MONTANT_RECHCARD,@DATE_RECHCARD,GETDATE()) ";
                                Cmd.Parameters.AddWithValue("@ID_CARD", IdCardPaieRech);
                                Cmd.Parameters.AddWithValue("@CODE_RECHCARD", CodRechCarte);
                                Cmd.Parameters.AddWithValue("@MONTANT_RECHCARD", decimal.Parse(TxtMontantRecharg.Text));
                                Cmd.Parameters.AddWithValue("@DATE_RECHCARD", DpkRegister.Value.ToString("dd/MM/yyyy"));
                                Cmd.ExecuteNonQuery();

                                // Recharge carte
                                Cmd.CommandText = " UPDATE CARDPAIEMENT SET SOLDE_CARD=@SOLDE_CARD WHERE TPYE_CARD='"+ CbxTypeCardRecharg.SelectedItem +"' ";
                                Cmd.Parameters.AddWithValue("@SOLDE_CARD", (OldSoldCardPaieRech() + decimal.Parse(TxtMontantRecharg.Text)));
                                Cmd.ExecuteNonQuery();

                                MessageBox.Show("Rechargement effectué avec succès !!!", "GestParc: Information", MessageBoxButtons.OK,MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                    }
                }
            }
        }

        private decimal OldSoldCardPaieRech()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT SOLDE_CARD FROM CARDPAIEMENT WHERE TPYE_CARD = '" + CbxTypeCardRecharg.Text + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            OldSoldCardPRech = decimal.Parse(MyReader[0].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return OldSoldCardPRech;
        }

        private void btnCloseFormRechCard_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
