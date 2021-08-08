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
    public partial class FormModifyConsoCarbCar : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataAdapter SqlAda;
        private SqlDataReader MyReader;
        private int IdCarCarbMod;

        public FormModifyConsoCarbCar()
        {
            InitializeComponent();
            FillCarCarburant();
        }

        private void FillCarCarburant()
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
                            CbxVehiConsoCabModi.Items.Add(MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            CbxVehiConsoCabModi.DisplayMember = (MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            CbxVehiConsoCabModi.ValueMember = (MyReader["ID_VEHICULE"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbxVehiConsoCabModi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_VEHICULE FROM VEHICULE WHERE IMMATRICULATION_VEHICULE = '" + CbxVehiConsoCabModi.SelectedItem + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdCarCarbMod = int.Parse(MyReader[0].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IcBtnSavedConsoCarbModi_Click(object sender, EventArgs e)
        {
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
                                SqlCmd = new SqlCommand("UPDATE PROVISION SET ID_VEHICULE=@ID_VEHICULE,DESCRIPTION_PROV=@DESCRIPTION_PROV,MONTANT_PROV=@MONTANT_PROV,QTELITRE_PROV=@QTELITRE_PROV,STATION_PROV=@STATION_PROV,NOTE_PROV=@NOTE_PROV,DATE_PROV=@DATE_PROV,DATEMODIFY=GETDATE() WHERE CODE_PROV='" + TxtCodeConsoCarbModi.Text + "'", Conn.cn);
                                SqlCmd.Parameters.AddWithValue("@ID_VEHICULE",IdCarCarbMod);
                                SqlCmd.Parameters.AddWithValue("@DESCRIPTION_PROV",TxtDescriptionConsoCarbModi.Text);
                                SqlCmd.Parameters.AddWithValue("@MONTANT_PROV",decimal.Parse(TxtAmountConsoCarbModi.Text));
                                SqlCmd.Parameters.AddWithValue("@QTELITRE_PROV",decimal.Parse(TxtLiterConsoCarbModi.Text));
                                SqlCmd.Parameters.AddWithValue("@STATION_PROV",TxtStationConsoCarbModi.Text);
                                SqlCmd.Parameters.AddWithValue("@NOTE_PROV",RtxtNoteConsoCarbModi.Text);
                                SqlCmd.Parameters.AddWithValue("@DATE_PROV", DateRegisterConsoCarbModi.Value.ToString("dd/MM/yyyy"));
                                SqlCmd.ExecuteNonQuery();
                                MessageBox.Show("Enregistré avec succès");
                                this.Close();
                            }
                        }
                    }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark : GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
