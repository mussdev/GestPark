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
    public partial class FormAddPaiement : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataReader MyReader;
        private Guid IdCardPaie;
        private SqlDataAdapter SqlAda;
        private DataSet Ds;
        private Guid IdCardProv;
        private decimal SoldCardP = 0;
        public FormAddPaiement()
        {
            InitializeComponent();
            FillCbxTypeCardPaiement();
        }

        private void BtnCancelPaiementCarb_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Fill combobox typeCard
        private void FillCbxTypeCardPaiement()
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
                            CbxTypCartPaie.Items.Add(MyReader["TPYE_CARD"].ToString());
                            CbxTypCartPaie.DisplayMember = (MyReader["TPYE_CARD"].ToString());
                            CbxTypCartPaie.ValueMember = (MyReader["ID_CARD"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbxTypCartPaie_SelectedIndexChanged(object sender, EventArgs e)
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
                        SqlCmd = new SqlCommand("SELECT ID_CARD,NUM_CARD FROM CARDPAIEMENT WHERE TPYE_CARD = '" + CbxTypCartPaie.SelectedItem + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        //MessageBox.Show("Test");
                        while (MyReader.Read())
                        {
                            IdCardPaie = Guid.Parse(MyReader[0].ToString());
                            TxtNumPaie.Text = MyReader[1].ToString();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtPrixTotalCarbu_TextChanged(object sender, EventArgs e)
        {
            TxtLitreCarbu.Text = string.Format("{0:0.##}",((decimal.Parse(TxtPrixTotalCarbu.Text)) / (decimal.Parse(TxtPrixUnitaireCarbu.Text))));
        }

        // Generate code of personne
        private string generateCodePaie()
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
                        SqlCmd = new SqlCommand("SELECT CODE_PAIE FROM PAIEMENT WHERE CODE_PAIE=(SELECT MAX(CODE_PAIE) FROM PAIEMENT)", Conn.cn);
                        SqlAda = new SqlDataAdapter(SqlCmd);
                        Ds = new DataSet();
                        SqlAda.Fill(Ds);

                        if (Ds.Tables[0].Rows.Count > 0)
                        {
                            TxtCodePaie.Text = Ds.Tables[0].Rows[0]["CODE_PAIE"].ToString();
                        }
                        else
                        {
                            TxtCodePaie.Text = "PAIE0000";
                        }
                        if (!string.IsNullOrEmpty(TxtCodePaie.Text))
                        {
                            TxtCodePaie.SelectionStart = 4;
                            TxtCodePaie.SelectionLength = 4;
                            TxtCodePaie.Text = TxtCodePaie.SelectedText;
                        }
                        if (!string.IsNullOrEmpty(TxtCodePaie.Text))
                        {
                            int CodPaie = int.Parse(TxtCodePaie.Text.ToString()) + 1;
                            TxtCodePaie.Text = CodPaie.ToString("PAIE0000");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return TxtCodePaie.Text;
        }

        private void BtnValiderPaie_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtCodeAppro.Text))
            {
                MessageBox.Show("Rensignez le code d'approvisionnement !!!", "GestPark: Error", MessageBoxButtons.OK);
            }else if (string.IsNullOrEmpty(CbxTypCartPaie.Text))
            {
                MessageBox.Show("Sélectionner la carte de paiement !!!", "GestPark: Error", MessageBoxButtons.OK);
            }
            else if (decimal.Parse(TxtPrixTotalCarbu.Text) <=  0 )
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
                            string CodPaie = generateCodePaie();
                            using(var Cmd = Conn.cn.CreateCommand())
                            {
                                if(SoldCardPaie() > decimal.Parse(TxtPrixTotalCarbu.Text))
                                {
                                    Cmd.CommandText = " INSERT INTO PAIEMENT (ID_PROV,ID_CARD,CODE_PAIE,LITRE_PAIE,TOTALPRIX_PAIE,DATE_PAIE,DATECREATE_PAIE) VALUES (@ID_PROV,@ID_CARD,@CODE_PAIE,@LITRE_PAIE,@TOTALPRIX_PAIE,@DATE_PAIE,GETDATE()) ";
                                    Cmd.Parameters.AddWithValue("@ID_PROV", IdProvision());
                                    Cmd.Parameters.AddWithValue("@ID_CARD", IdCardPaie);
                                    Cmd.Parameters.AddWithValue("@CODE_PAIE", CodPaie);
                                    Cmd.Parameters.AddWithValue("@LITRE_PAIE", decimal.Parse(TxtLitreCarbu.Text));
                                    Cmd.Parameters.AddWithValue("@TOTALPRIX_PAIE", decimal.Parse(TxtPrixTotalCarbu.Text));
                                    Cmd.Parameters.AddWithValue("@DATE_PAIE", DateRegisterPaie.Value.ToString("dd/MM/yyyy"));
                                    Cmd.ExecuteNonQuery();

                                    // Update Card sold

                                    Cmd.CommandText = " UPDATE CARDPAIEMENT SET SOLDE_CARD=@SOLDE_CARD WHERE TPYE_CARD='" + CbxTypCartPaie.Text + "'  ";
                                    Cmd.Parameters.AddWithValue("@SOLDE_CARD", (SoldCardPaie() - decimal.Parse(TxtPrixTotalCarbu.Text)));
                                    Cmd.ExecuteNonQuery();

                                    // Update Table carburant statut

                                    Cmd.CommandText = " UPDATE PROVISION SET STATUT_PROV=@STATUT_PROV WHERE CODE_PROV='" + TxtCodeAppro.Text + "'  ";
                                    Cmd.Parameters.AddWithValue("@STATUT_PROV", "Payé");
                                    Cmd.ExecuteNonQuery();

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

        private Guid IdProvision()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_PROV FROM PROVISION WHERE CODE_PROV = '" + TxtCodeAppro.Text + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdCardProv = Guid.Parse(MyReader[0].ToString());
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return IdCardProv;
        }


        private decimal SoldCardPaie()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT SOLDE_CARD FROM CARDPAIEMENT WHERE TPYE_CARD = '" + CbxTypCartPaie.Text + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            SoldCardP = decimal.Parse(MyReader[0].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return SoldCardP;
        }
    }
}
