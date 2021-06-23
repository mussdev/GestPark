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
    public partial class FormCreatePanneCar : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataAdapter SqlAda;
        private DataSet Ds;
        private SqlDataReader MyReader;
        private int IdVehiculePan;
        public FormCreatePanneCar()
        {
            InitializeComponent();
            FillComboboxVehiculePan();
        }

        private void IcBtnCloseFanCreatePanCarb_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Fill combobox vehicule
        private void FillComboboxVehiculePan()
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
                            CbxVehiPanCar.Items.Add(MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            CbxVehiPanCar.DisplayMember = (MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            CbxVehiPanCar.ValueMember = (MyReader["ID_VEHICULE"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Methode te generate code
        private string generateCodeCarPan()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {
                // Generate code of car
                SqlCmd = new SqlCommand("SELECT CODE_PAN FROM PANNE WHERE ID_PAN=(SELECT MAX(ID_PAN) FROM PANNE)", Conn.cn);
                SqlAda = new SqlDataAdapter(SqlCmd);
                Ds = new DataSet();
                SqlAda.Fill(Ds);

                if (Ds.Tables[0].Rows.Count > 0)
                {
                    TxtCodePanCar.Text = Ds.Tables[0].Rows[0]["CODE_PAN"].ToString();
                }
                else
                {
                    TxtCodePanCar.Text = "PAN0000";
                }
                if (!string.IsNullOrEmpty(TxtCodePanCar.Text))
                {
                    TxtCodePanCar.SelectionStart = 3;
                    TxtCodePanCar.SelectionLength = 4;
                    TxtCodePanCar.Text = TxtCodePanCar.SelectedText;
                }
                if (!string.IsNullOrEmpty(TxtCodePanCar.Text))
                {
                    int CodePan = int.Parse(TxtCodePanCar.Text.ToString()) + 1;
                    TxtCodePanCar.Text = CodePan.ToString("PAN0000");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark : GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return TxtCodePanCar.Text;
        }

        private void IcBtnSavedPanCar_Click(object sender, EventArgs e)
        {
            generateCodeCarPan();
            if (string.IsNullOrEmpty(CbxVehiPanCar.Text))
            {
                MessageBox.Show("Veillez identifier la voiture !");
            }else if (string.IsNullOrEmpty(TxtDescriptionPanCar.Text))
            {
                MessageBox.Show("Identifier la panne svp !");
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

                        string CodPan = generateCodeCarPan();
                        using (Conn.cn)
                        {
                            if (Conn.IsConnection)
                            {
                                SqlCmd = new SqlCommand("INSERT INTO PANNE (ID_VEHICULE,CODE_PAN,ETAT_PAN,DESCRIPTION_PAN,NOTE_PAN,INFOS_PAN,DATE_PAN,DATECREATE_PAN) VALUES (@ID_VEHICULE,@CODE_PAN,@ETAT_PAN,@DESCRIPTION_PAN,@NOTE_PAN,@INFOS_PAN,@DATE_PAN,GETDATE())", Conn.cn);
                                SqlCmd.Parameters.AddWithValue("@ID_VEHICULE", IdVehiculePan);
                                SqlCmd.Parameters.AddWithValue("@CODE_PAN", CodPan);
                                SqlCmd.Parameters.AddWithValue("@ETAT_PAN", CbxEtatCarPan.Text);
                                SqlCmd.Parameters.AddWithValue("@DESCRIPTION_PAN", TxtDescriptionPanCar.Text);
                                SqlCmd.Parameters.AddWithValue("@NOTE_PAN", RtxtNotePanCar.Text);
                                SqlCmd.Parameters.AddWithValue("@INFOS_PAN", RichTxtoutheInfos.Text);
                                SqlCmd.Parameters.AddWithValue("@DATE_PAN", DateRegisterPanCar.Value.ToString("dd/MM/yyyy"));
                                SqlCmd.ExecuteNonQuery();
                                MessageBox.Show("Enregistré avec succès !");

                                TxtCodePanCar.Clear(); TxtDescriptionPanCar.Clear(); RtxtNotePanCar.Clear(); RichTxtoutheInfos.Clear();

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

        private void CbxVehiPanCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_VEHICULE FROM VEHICULE WHERE IMMATRICULATION_VEHICULE = '" + CbxVehiPanCar.SelectedItem + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        //Console.WriteLine(MyReader[0].ToString());
                        while (MyReader.Read())
                        {
                            IdVehiculePan = int.Parse(MyReader[0].ToString());
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
