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
    public partial class FormCreateRepairCar : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataAdapter SqlAda;
        private DataSet Ds;
        private SqlDataReader MyReader;
        int IdRepairCarPan, IdGarage;
        public FormCreateRepairCar()
        {
            InitializeComponent();
            FillComboboxGarage();
        }

        // Fill combobox vehicule
        private void FillComboboxVehicule()
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
                            CbxRepaiCar.Items.Add(MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            CbxRepaiCar.DisplayMember = (MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            CbxRepaiCar.ValueMember = (MyReader["ID_VEHICULE"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Fill combobox garage
        private void FillComboboxGarage()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT * FROM GARAGE", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            CbxGarageRepairCar.Items.Add(MyReader["DESCRIPTION_GARAGE"].ToString());
                            CbxGarageRepairCar.DisplayMember = (MyReader["DESCRIPTION_GARAGE"].ToString());
                            CbxGarageRepairCar.ValueMember = (MyReader["ID_GARAGE"].ToString());

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private string generateCodeRepairCar()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {
                // Generate code of car
                SqlCmd = new SqlCommand("SELECT CODE_REPAR FROM REPARATION WHERE ID_REPAR=(SELECT MAX(ID_REPAR) FROM REPARATION)", Conn.cn);
                SqlAda = new SqlDataAdapter(SqlCmd);
                Ds = new DataSet();
                SqlAda.Fill(Ds);

                if (Ds.Tables[0].Rows.Count > 0)
                {
                    TxtCodeRepaiCar.Text = Ds.Tables[0].Rows[0]["CODE_REPAR"].ToString();
                }
                else
                {
                    TxtCodeRepaiCar.Text = "REPAIR0000";
                }
                if (!string.IsNullOrEmpty(TxtCodeRepaiCar.Text))
                {
                    TxtCodeRepaiCar.SelectionStart = 6;
                    TxtCodeRepaiCar.SelectionLength = 4;
                    TxtCodeRepaiCar.Text = TxtCodeRepaiCar.SelectedText;
                }
                if (!string.IsNullOrEmpty(TxtCodeRepaiCar.Text))
                {
                    int CodeRepair = int.Parse(TxtCodeRepaiCar.Text.ToString()) + 1;
                    TxtCodeRepaiCar.Text = CodeRepair.ToString("REPAIR0000");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark : GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return TxtCodeRepaiCar.Text;
        }

        private void CbxRepaiCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_PAN FROM PANNE LEFT OUTER JOIN VEHICULE ON PANNE.ID_VEHICULE=VEHICULE.ID_VEHICULE WHERE IMMATRICULATION_VEHICULE = '" + CbxRepaiCar.SelectedItem + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
  
                        while (MyReader.Read())
                        {
                            IdRepairCarPan = int.Parse(MyReader[0].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IcBtnSavedRepaiCar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CbxRepaiCar.Text))
            {
                MessageBox.Show("Identifier le vehicule reparé !!!");
            }else if (string.IsNullOrEmpty(TxtAmountRepair.Text))
            {
                MessageBox.Show("Saisir le coût de reparation !!!");
            }
            else
            {
                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                    ConnectDB Conn = new ConnectDB(connectionString);
                    if (Conn.IsConnection) {
                        DialogResult result = MessageBox.Show("Voulez vous enregister ?", "GESTPARK: CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            using (Conn.cn)
                            {
                                SqlCmd = new SqlCommand("INSERT INTO REPARATION (ID_PAN,ID_GARAGE,CODE_REPAR,DESCRIPTION_REPAR,PRIX_REPAR,NOTE_REPAR,DATE_REPAR,DATECREATE_REPAR) VALUES (@ID_PAN,@ID_GARAGE,@CODE_REPAR,@DESCRIPTION_REPAR,@PRIX_REPAR,@NOTE_REPAR,@DATE_REPAR,GETDATE())", Conn.cn);
                                SqlCmd.Parameters.AddWithValue("@ID_PAN", IdRepairCarPan);
                                SqlCmd.Parameters.AddWithValue("@ID_GARAGE",IdGarage);
                                SqlCmd.Parameters.AddWithValue("@CODE_REPAR",generateCodeRepairCar());
                                SqlCmd.Parameters.AddWithValue("@DESCRIPTION_REPAR",TxtDescripRepaiCar.Text);
                                SqlCmd.Parameters.AddWithValue("@PRIX_REPAR",decimal.Parse(TxtAmountRepair.Text));
                                SqlCmd.Parameters.AddWithValue("@NOTE_REPAR", RtxtNoteRepairCar.Text);
                                SqlCmd.Parameters.AddWithValue("@DATE_REPAR", DateRegisterRepairCar.Value.ToString("dd/MM/yyyy"));
                                SqlCmd.ExecuteNonQuery();

                                // Clear the fields
                                TxtAmountRepair.Clear();TxtCodeRepaiCar.Clear();TxtDescripRepaiCar.Clear();CbxRepaiCar.Text = null; CbxGarageRepairCar.Text = null;
                               // Console.WriteLine("IdCarPan = " + IdRepairCarPan);
                                
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "GestPark: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CbxGarageRepairCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_GARAGE FROM GARAGE WHERE DESCRIPTION_GARAGE = '" + CbxRepaiCar.SelectedItem + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdGarage = int.Parse(MyReader[0].ToString());
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
