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
    public partial class FormAddCarteCarburant : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataAdapter SqlAda;
        private DataSet Ds;
        public FormAddCarteCarburant()
        {
            InitializeComponent();
        }

        private void BtnSavedCreateCard_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(TxtNumCard.Text))
            {
                MessageBox.Show("Veillez saisir le numéro de la carte", "GestPark: Avertissement", MessageBoxButtons.OK);
            }
            else if (string.IsNullOrEmpty(TxtStationCard.Text))
            {
                MessageBox.Show("Veillez saisir le station de la carte", "GestPark: Avertissement", MessageBoxButtons.OK);
            }
            else if (string.IsNullOrEmpty(TxtSoldeCard.Text))
            {
                MessageBox.Show("Veillez saisir le solde de la carte", "GestPark: Avertissement", MessageBoxButtons.OK);
            }
            else if (string.IsNullOrEmpty(CbxTypeCard.Text))
            {
                MessageBox.Show("Veillez sélectionner le type de la carte", "GestPark: Avertissement", MessageBoxButtons.OK);
            }
            else
            {
                try
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
                                string CodCardCar = generateCardCode();
                                SqlCmd = new SqlCommand("INSERT INTO CARDPAIEMENT (CODE_CARD,NUM_CARD,SOLDE_CARD,TPYE_CARD,STATION_CARD,DATECREATE_CARD) VALUES (@CODE_CARD,@NUM_CARD,@SOLDE_CARD,@TPYE_CARD,@STATION_CARD,GETDATE()) ", Conn.cn);
                                SqlCmd.Parameters.AddWithValue("@CODE_CARD", CodCardCar);
                                SqlCmd.Parameters.AddWithValue("@NUM_CARD", TxtNumCard.Text);
                                SqlCmd.Parameters.AddWithValue("@SOLDE_CARD", decimal.Parse(TxtSoldeCard.Text));
                                SqlCmd.Parameters.AddWithValue("@TPYE_CARD", CbxTypeCard.Text);
                                SqlCmd.Parameters.AddWithValue("@STATION_CARD", TxtStationCard.Text);
                                SqlCmd.ExecuteNonQuery();
                                MessageBox.Show("Enregistré avec succès !!!","GestPark: Information",MessageBoxButtons.OK);
                                // Clear the fields
                                TxtCodeCard.Clear(); TxtNumCard.Clear(); TxtSoldeCard.Clear(); CbxTypeCard.SelectedItem = null; TxtStationCard.Clear();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "GestPark: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        // Generate code of personne
        private string generateCardCode()
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
                        SqlCmd = new SqlCommand("SELECT CODE_CARD FROM CARDPAIEMENT WHERE CODE_CARD=(SELECT MAX(CODE_CARD) FROM CARDPAIEMENT)", Conn.cn);
                        SqlAda = new SqlDataAdapter(SqlCmd);
                        Ds = new DataSet();
                        SqlAda.Fill(Ds);

                        if (Ds.Tables[0].Rows.Count > 0)
                        {
                            TxtCodeCard.Text = Ds.Tables[0].Rows[0]["CODE_CARD"].ToString();
                        }
                        else
                        {
                            TxtCodeCard.Text = "POOL0000";
                        }
                        if (!string.IsNullOrEmpty(TxtCodeCard.Text))
                        {
                            TxtCodeCard.SelectionStart = 4;
                            TxtCodeCard.SelectionLength = 4;
                            TxtCodeCard.Text = TxtCodeCard.SelectedText;
                        }
                        if (!string.IsNullOrEmpty(TxtCodeCard.Text))
                        {
                            int CodCard = int.Parse(TxtCodeCard.Text.ToString()) + 1;
                            TxtCodeCard.Text = CodCard.ToString("POOL0000");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return TxtCodeCard.Text;
        }
    }
}
