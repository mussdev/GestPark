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
    public partial class FormModifyWatchCar : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataAdapter SqlAda;
        private SqlDataReader MyReader;
        private int IdWatchCarModif;
        public FormModifyWatchCar()
        {
            InitializeComponent();
            FillComboboxCar();
        }

   

        private void CbxVehiculeWatchCarModi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_VEHICULE FROM VEHICULE WHERE IMMATRICULATION_VEHICULE = '" + CbxVehiculeWatchCarModi.SelectedItem + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdWatchCarModif = int.Parse(MyReader[0].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IbtnRegisterWatchCarModi_Click(object sender, EventArgs e)
        {
            string ImmatCar = CbxVehiculeWatchCarModi.Text ;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                DialogResult result = MessageBox.Show("Voulez vous enregister les modifications ?", "GESTPARK: CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (Conn.cn)
                    {
                        if (Conn.IsConnection)
                        {
                            if(ImmatCar == TbxCodeWatchCarModi.Text)
                            {
                                SqlCmd = new SqlCommand("UPDATE LAVAGE SET MONTANT_WTCH=@MONTANT_WTCH,LIEU_WTCH=@LIEU_WTCH,NOTE_WTCH=@NOTE_WTCH,DATEREGISTER=@DATEREGISTER,DATEMODIFY=GETDATE() WHERE CODE_WTCH='" + TbxCodeWatchCarModi.Text + "'", Conn.cn);
                                SqlCmd.Parameters.AddWithValue("@MONTANT_WTCH", TxtBMontantModi.Text);
                                SqlCmd.Parameters.AddWithValue("@LIEU_WTCH", TxtBLieuWatchCarModi.Text);
                                SqlCmd.Parameters.AddWithValue("@NOTE_WTCH", RbtxNoteWatchCarModi.Text);
                                SqlCmd.Parameters.AddWithValue("@DATEREGISTER", DatePikerWatchCarModi.Value.ToString("dd/MM/yyyy"));
                                SqlCmd.ExecuteNonQuery();
                                MessageBox.Show("Enregistré avec succès");
                                this.Close();
                            }
                            else
                            {
                                SqlCmd = new SqlCommand("UPDATE LAVAGE SET ID_VEHICULE=@ID_VEHICULE,MONTANT_WTCH=@MONTANT_WTCH,LIEU_WTCH=@LIEU_WTCH,NOTE_WTCH=@NOTE_WTCH,DATEREGISTER=@DATEREGISTER,DATEMODIFY=GETDATE() WHERE CODE_WTCH='" + TbxCodeWatchCarModi.Text + "'", Conn.cn);
                                SqlCmd.Parameters.AddWithValue("@ID_VEHICULE", IdWatchCarModif);
                                SqlCmd.Parameters.AddWithValue("@MONTANT_WTCH", TxtBMontantModi.Text);
                                SqlCmd.Parameters.AddWithValue("@LIEU_WTCH", TxtBLieuWatchCarModi.Text);
                                SqlCmd.Parameters.AddWithValue("@NOTE_WTCH", RbtxNoteWatchCarModi.Text);
                                SqlCmd.Parameters.AddWithValue("@DATEREGISTER", DatePikerWatchCarModi.Value.ToString("dd/MM/yyyy"));
                                SqlCmd.ExecuteNonQuery();
                                MessageBox.Show("Enregistré avec succès");
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark : GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to fill the combobox car

        private void FillComboboxCar()
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
                            CbxVehiculeWatchCarModi.Items.Add(MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            CbxVehiculeWatchCarModi.DisplayMember = (MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            CbxVehiculeWatchCarModi.ValueMember = (MyReader["ID_VEHICULE"].ToString());
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
