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
    public partial class FormAttributeCarModify : Form
    {
        private SqlCommand SqlCmd;
        private string IdVehiculeMod, IdProprioMod;
        private SqlDataAdapter SqlAda;
        private DataSet Ds;
        private SqlDataReader MyReader;
        public FormAttributeCarModify()
        {
            InitializeComponent();
            FillComboboxVehicule();
            FillComboboxProprietor();
        }

        private void CbxVehiculeAttrMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_VEHICULE FROM VEHICULE WHERE IMMATRICULATION_VEHICULE = '" + CbxVehiculeAttrMod.SelectedItem + "'", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdVehiculeMod = MyReader[0].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbxProprietAttrMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);

                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_PERS FROM PERSONNELS WHERE TYPE_PERS = 'Propriétaire' AND DESCRIPTION_PERS = '" + CbxProprietAttrMod.SelectedItem + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdProprioMod = MyReader[0].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IbtnRegisterAttributeCarToPersMod_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                DialogResult result = MessageBox.Show("Voulez vous enregister les modificattions ?", "GESTPARK: CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (Conn.cn)
                    {
                        if (Conn.IsConnection)
                        {
                            SqlCmd = new SqlCommand("UPDATE APPARTENIR SET ID_PERS=@ID_PERS, ID_VEHICULE=@ID_VEHICULE, DATE_DEBUT_ATTRI=@DATE_DEBUT_ATTRI, DATE_FIN_ATTRI =@DATE_FIN_ATTRI, DATE_ATTRI=@DATE_ATTRI, NOTE_ATTRI=@NOTE_ATTRI WHERE CODE_ATTRI = '" + TbxCodeAttr.Text + "' ", Conn.cn);
                            SqlCmd.Parameters.AddWithValue("@ID_PERS", IdProprioMod);
                            SqlCmd.Parameters.AddWithValue("@ID_VEHICULE", IdVehiculeMod);
                            SqlCmd.Parameters.AddWithValue("@DATE_DEBUT_ATTRI", DateAttrVehi.Value.ToString("dd/MM/yyyy"));
                            SqlCmd.Parameters.AddWithValue("@DATE_FIN_ATTRI", DateFinAttVehi.Value.ToString("dd/MM/yyyy"));
                            SqlCmd.Parameters.AddWithValue("@DATE_ATTRI", DatePikerCreateAttr.Value.ToString("dd/MM/yyyy"));
                            SqlCmd.Parameters.AddWithValue("@NOTE_ATTRI", RbtxNoteAttr.Text);
                            SqlCmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillComboboxProprietor()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        string typePerson = "Propriétaire";
                        SqlCmd = new SqlCommand("SELECT ID_PERS, DESCRIPTION_PERS FROM PERSONNELS WHERE TYPE_PERS='" + typePerson + "'", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            CbxProprietAttrMod.Items.Add(MyReader["DESCRIPTION_PERS"].ToString());
                            CbxProprietAttrMod.DisplayMember = (MyReader["DESCRIPTION_PERS"].ToString());
                            CbxProprietAttrMod.ValueMember = (MyReader["ID_PERS"].ToString());
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                        SqlCmd = new SqlCommand("SELECT * FROM VEHICULE WHERE TYPE_VEHICULE = 'Privé' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            CbxVehiculeAttrMod.Items.Add(MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            CbxVehiculeAttrMod.DisplayMember = (MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            CbxVehiculeAttrMod.ValueMember = (MyReader["ID_VEHICULE"].ToString());

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
