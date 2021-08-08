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
    public partial class FormCreateConsoCarburant : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataAdapter SqlAda;
        private DataSet Ds;
        private SqlDataReader MyReader;
        private int IdVehiCarb;
        public FormCreateConsoCarburant()
        {
            InitializeComponent();
            FillComboboxVehiculeCarb();
        }

        // Methode te generate code
        private string generateCodeProvCarb()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {
                // Generate code of car
                SqlCmd = new SqlCommand("SELECT CODE_PROV FROM PROVISION WHERE ID_PROV=(SELECT MAX(ID_PROV) FROM PROVISION)", Conn.cn);
                SqlAda = new SqlDataAdapter(SqlCmd);
                Ds = new DataSet();
                SqlAda.Fill(Ds);

                if (Ds.Tables[0].Rows.Count > 0)
                {
                    TxtCodeConsoCarb.Text = Ds.Tables[0].Rows[0]["CODE_PROV"].ToString();
                }
                else
                {
                    TxtCodeConsoCarb.Text = "PROV0000";
                }
                if (!string.IsNullOrEmpty(TxtCodeConsoCarb.Text))
                {
                    TxtCodeConsoCarb.SelectionStart = 4;
                    TxtCodeConsoCarb.SelectionLength = 4;
                    TxtCodeConsoCarb.Text = TxtCodeConsoCarb.SelectedText;
                }
                if (!string.IsNullOrEmpty(TxtCodeConsoCarb.Text))
                {
                    int CodeFour = int.Parse(TxtCodeConsoCarb.Text.ToString()) + 1;
                    TxtCodeConsoCarb.Text = CodeFour.ToString("PROV0000");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark : GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return TxtCodeConsoCarb.Text;
        }

        // Fill combobox vehicule
        private void FillComboboxVehiculeCarb()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT*FROM VEHICULE", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            CbxVehiConsoCab.Items.Add(MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            CbxVehiConsoCab.DisplayMember = (MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            CbxVehiConsoCab.ValueMember = (MyReader["ID_VEHICULE"].ToString());

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbxVehiConsoCab_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_VEHICULE, TYPECONSOMMATION.DESCRIPTION_TYPCONSO AS DescriptionConso FROM VEHICULE LEFT OUTER JOIN TYPECONSOMMATION ON VEHICULE.ID_TYPCONSO=TYPECONSOMMATION.ID_TYPCONSO WHERE IMMATRICULATION_VEHICULE = '" + CbxVehiConsoCab.SelectedItem + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                       // Console.WriteLine(MyReader[0].ToString());
                        while (MyReader.Read())
                        {
                            IdVehiCarb = int.Parse(MyReader[0].ToString());
                            TxtTypConsoCarb.Text = MyReader[1].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IcBtnSavedConsoCarb_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CbxVehiConsoCab.Text))
            {
                MessageBox.Show("Veillez choisir un vehicule !");
            }else if (string.IsNullOrEmpty(TxtAmountConsoCarb.Text))
            {
                MessageBox.Show("Veillez saisir le montant !");
            }else if (string.IsNullOrEmpty(TxtLiterConsoCarb.Text))
            {
                MessageBox.Show("Veillez saisir le nombre de litre de carburant");
            }
            else
            {
                try
                {
                    DialogResult result = MessageBox.Show("Voulez vous enregister ?", "GESTPARK: CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                        ConnectDB Conn = new ConnectDB(connectionString);
                        string CodVehCarb = generateCodeProvCarb();

                        using (Conn.cn)
                        {
                            if (Conn.IsConnection)
                            {
                                SqlCmd = new SqlCommand("INSERT INTO PROVISION (ID_VEHICULE,CODE_PROV,DESCRIPTION_PROV,MONTANT_PROV,QTELITRE_PROV,STATION_PROV,NOTE_PROV,DATE_PROV,DATECREATE_PROV) VALUES (@ID_VEHICULE,@CODE_PROV,@DESCRIPTION_PROV,@MONTANT_PROV,@QTELITRE_PROV,@STATION_PROV,@NOTE_PROV,@DATE_PROV,GETDATE()) ", Conn.cn);
                                SqlCmd.Parameters.AddWithValue("@ID_VEHICULE", IdVehiCarb);
                                SqlCmd.Parameters.AddWithValue("@CODE_PROV", CodVehCarb);
                                SqlCmd.Parameters.AddWithValue("@DESCRIPTION_PROV", TxtDescriptionConsoCarb.Text);
                                SqlCmd.Parameters.AddWithValue("@MONTANT_PROV", decimal.Parse(TxtAmountConsoCarb.Text));
                                SqlCmd.Parameters.AddWithValue("@QTELITRE_PROV", decimal.Parse(TxtLiterConsoCarb.Text));
                                SqlCmd.Parameters.AddWithValue("@STATION_PROV", TxtStationConsoCarb.Text);
                                SqlCmd.Parameters.AddWithValue("@NOTE_PROV", RtxtNoteConsoCarb.Text);
                                SqlCmd.Parameters.AddWithValue("@DATE_PROV", DateRegisterConsoCarb.Value.ToString("dd/MM/yyyy"));
                                SqlCmd.ExecuteNonQuery();
                                MessageBox.Show("Enregistré avec succès !");
                                TxtCodeConsoCarb.Clear(); TxtDescriptionConsoCarb.Clear(); TxtStationConsoCarb.Clear(); TxtAmountConsoCarb.Clear(); TxtLiterConsoCarb.Clear();
                                RtxtNoteConsoCarb.Clear();
                            }
                        }                      
                    }

                   
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
