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
    public partial class FormCreateWatchCar : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataAdapter SqlAda;
        private SqlDataReader MyReader;
        private DataSet Ds;
        private int IdVehiWatch;
        public FormCreateWatchCar()
        {
            InitializeComponent();
            FillComboboxVehiculeToWatch();
        }

        private void BtnCloseFormWatchCar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Methode to generate code for watching
        private string generateCodeCar()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {
                // Generate code of car
                SqlCmd = new SqlCommand("SELECT CODE_WTCH FROM LAVAGE WHERE ID_WTCH=(SELECT MAX(ID_WTCH) FROM LAVAGE)", Conn.cn);
                SqlAda = new SqlDataAdapter(SqlCmd);
                Ds = new DataSet();
                SqlAda.Fill(Ds);

                if (Ds.Tables[0].Rows.Count > 0)
                {
                    TbxCodeWatchCar.Text = Ds.Tables[0].Rows[0]["CODE_WTCH"].ToString();
                }
                else
                {
                    TbxCodeWatchCar.Text = "LAV0000";
                }
                if (!string.IsNullOrEmpty(TbxCodeWatchCar.Text))
                {
                    TbxCodeWatchCar.SelectionStart = 3;
                    TbxCodeWatchCar.SelectionLength = 4;
                    TbxCodeWatchCar.Text = TbxCodeWatchCar.SelectedText;
                }
                if (!string.IsNullOrEmpty(TbxCodeWatchCar.Text))
                {
                    int CodeWatch = int.Parse(TbxCodeWatchCar.Text.ToString()) + 1;
                    TbxCodeWatchCar.Text = CodeWatch.ToString("LAV0000");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark : GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return TbxCodeWatchCar.Text;
        }

        // Fill combobox vehicule
        private void FillComboboxVehiculeToWatch()
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
                            CbxVehiculeWatchCar.Items.Add(MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            CbxVehiculeWatchCar.DisplayMember = (MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            CbxVehiculeWatchCar.ValueMember = (MyReader["ID_VEHICULE"].ToString());

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbxVehiculeWatchCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_VEHICULE FROM VEHICULE WHERE IMMATRICULATION_VEHICULE = '" + CbxVehiculeWatchCar.SelectedItem + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdVehiWatch = int.Parse(MyReader[0].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IBtnRegisterWatchCar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CbxVehiculeWatchCar.Text))
            {
                MessageBox.Show("Identifier le vehicule lavé !");
            } else if (string.IsNullOrEmpty(TxtBMontant.Text))
            {
                MessageBox.Show("Saisir le montant !");
            } else if (string.IsNullOrEmpty(TxtBLieuWatchCar.Text))
            {
                MessageBox.Show("Saisir le lieu !");
            }
            else
            {
                try {
                    string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                    ConnectDB Conn = new ConnectDB(connectionString);
                    DialogResult result = MessageBox.Show("Voulez vous enregister ?", "GESTPARK: CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string CodLav = generateCodeCar();
                        using (Conn.cn)
                        {
                            if (Conn.IsConnection)
                            {
                                SqlCmd = new SqlCommand("INSERT INTO LAVAGE(ID_VEHICULE,CODE_WTCH,MONTANT_WTCH,LIEU_WTCH,NOTE_WTCH,DATEREGISTER,DATECREATE_WTCH) VALUES (@ID_VEHICULE,@CODE_WTCH,@MONTANT_WTCH,@LIEU_WTCH,@NOTE_WTCH,@DATEREGISTER,GETDATE())", Conn.cn);
                                SqlCmd.Parameters.AddWithValue("@ID_VEHICULE", IdVehiWatch);
                                SqlCmd.Parameters.AddWithValue("@CODE_WTCH", CodLav);
                                SqlCmd.Parameters.AddWithValue("@MONTANT_WTCH", decimal.Parse(TxtBMontant.Text));
                                SqlCmd.Parameters.AddWithValue("@LIEU_WTCH", TxtBLieuWatchCar.Text);
                                SqlCmd.Parameters.AddWithValue("@NOTE_WTCH", RbtxNoteWatchCar.Text);
                                SqlCmd.Parameters.AddWithValue("@DATEREGISTER", DatePikerWatchCar.Value.ToString("dd/MM/yyyy"));
                                SqlCmd.ExecuteNonQuery();
                                MessageBox.Show("Enregistré avec succès !");

                                // Clear the field
                                TxtBLieuWatchCar.Clear(); TxtBMontant.Clear(); TbxCodeWatchCar.Clear(); RbtxNoteWatchCar.Clear(); CbxVehiculeWatchCar.SelectedItem = null;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                
        }
    }
}
