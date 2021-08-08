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
    public partial class FormModifyMouvement : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataReader MyReader;
        private SqlDataAdapter SqlAda;
        private string IdConducteurMod, IdVehiculeMod, IdMvtsMod;
        private decimal KilometreAvantMvt = 0, KilometreApreMvt = 0;
        public FormModifyMouvement()
        {
            InitializeComponent();
            FillComboboxVehiculeMod();
            FillComboboxConducteurMod();
        }

        private void CbxConducMvtMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_PERS FROM PERSONNELS WHERE TYPE_PERS = 'Conducteur' AND DESCRIPTION_PERS = '" + CbxConducMvtMod.SelectedItem + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdConducteurMod = MyReader[0].ToString();
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbxVehiculeMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_VEHICULE FROM VEHICULE WHERE IMMATRICULATION_VEHICULE = '" + CbxVehiculeMod.SelectedItem + "' ", Conn.cn);
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

        private void IbtnRegisterMvtTbxCodMvtMod_Click(object sender, EventArgs e)
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
                            string CodMvts = TbxCodMvtMod.Text;
                            decimal kiloAprMvt = decimal.Parse(TbxKilometreMvtApresMod.Text);
                            // Console.WriteLine(kiloAprMvt);
                            SqlCmd = new SqlCommand("UPDATE MOUVEMENTS SET ID_PERS=@ID_PERS,ID_VEHICULE=@ID_VEHICULE, STATUT_MVTS =@STATUT_MVTS, KILOMETRE_AVA_MVTS =@KILOMETRE_AVA_MVTS, KILO_APRES_MVTS=@KILO_APRES_MVTS , DESCRIPTION_MVTS =@DESCRIPTION_MVTS, LIEU_MVTS =@LIEU_MVTS, NOTE_MVTS =@NOTE_MVTS,DATEDEPART_MVTS=@DATEDEPART_MVTS, DATEARRIVE_MVTS=@DATEARRIVE_MVTS WHERE CODE_MVTS = '" + CodMvts + "' ", Conn.cn);
                            SqlCmd.Parameters.AddWithValue("@ID_PERS", IdConducteurMod);
                            SqlCmd.Parameters.AddWithValue("@ID_VEHICULE", IdVehiculeMod);
                            SqlCmd.Parameters.AddWithValue("@STATUT_MVTS", CbxStatutMvtMod.Text);
                            SqlCmd.Parameters.AddWithValue("@KILOMETRE_AVA_MVTS", TbxKilometreMvtAvantMod.Text);
                            SqlCmd.Parameters.AddWithValue("@KILO_APRES_MVTS", TbxKilometreMvtApresMod.Text);
                            SqlCmd.Parameters.AddWithValue("@DESCRIPTION_MVTS", TbxDescriptionMvtMod.Text);
                            SqlCmd.Parameters.AddWithValue("@LIEU_MVTS", CbxLieuMvtsMod.Text);
                            SqlCmd.Parameters.AddWithValue("@NOTE_MVTS", RtbxNoteMvtMod.Text);
                            SqlCmd.Parameters.AddWithValue("@DATEDEPART_MVTS", DateDepartMvtMod.Value.ToString("dd/MM/yyyy"));
                            SqlCmd.Parameters.AddWithValue("@DATEARRIVE_MVTS", DateArriveeMvtMod.Value.ToString("dd/MM/yyyy"));
                            SqlCmd.ExecuteNonQuery();
                            MessageBox.Show("Les informations ont été modifiées avec succès !");

                            // Update state car
                            SqlCmd = new SqlCommand("UPDATE VEHICULE SET ETAT_VEHICULE=@ETAT_VEHICULE WHERE ID_VEHICULE='" + IdVehiculeMod + "'", Conn.cn);
                            SqlCmd.Parameters.AddWithValue("@ETAT_VEHICULE", CbxStatutMvtMod.Text);
                            SqlCmd.ExecuteNonQuery();
                        }
                    }
                    // Close the form
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Fill combobox vehicule
        private void FillComboboxVehiculeMod()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT * FROM VEHICULE WHERE TYPE_VEHICULE = 'Pool' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            CbxVehiculeMod.Items.Add(MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            CbxVehiculeMod.DisplayMember = (MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            CbxVehiculeMod.ValueMember = (MyReader["ID_VEHICULE"].ToString());
                        }
                    }
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Fill combobox conducteur
        private void FillComboboxConducteurMod()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT * FROM PERSONNELS WHERE TYPE_PERS = 'Conducteur' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            CbxConducMvtMod.Items.Add(MyReader["DESCRIPTION_PERS"].ToString());
                            CbxConducMvtMod.DisplayMember = (MyReader["DESCRIPTION_PERS"].ToString());
                            CbxConducMvtMod.ValueMember = (MyReader["ID_PERS"].ToString());

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
