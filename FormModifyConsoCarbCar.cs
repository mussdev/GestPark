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
        private SqlDataReader MyReader, Reader;
        private int IdCarCarbMod;
        private string CodeCar;
        private decimal OldMeleageAffect = 0;

        public FormModifyConsoCarbCar()
        {
            InitializeComponent();
            FillCarCarburant();
            VerifyFuelSatut();
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
                        SqlCmd = new SqlCommand("SELECT ID_VEHICULE,TOTALKILOMETRAGE_VEHICULE,KILOMETRAGE_VIDENGE_VEHICULE,CODE_VEHICULE FROM VEHICULE WHERE IMMATRICULATION_VEHICULE = '" + CbxVehiConsoCabModi.SelectedItem + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdCarCarbMod = int.Parse(MyReader[0].ToString());
                            TxtKilometrageTotal.Text = MyReader[1].ToString();
                            TxtKiloVidengeCarb.Text = MyReader[2].ToString();
                            CodeCar = MyReader[3].ToString();
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
                                using(var Cmd = Conn.cn.CreateCommand())
                                {         
                                    
                                    Cmd.CommandText = "UPDATE PROVISION SET ID_VEHICULE=@ID_VEHICULE,DESCRIPTION_PROV=@DESCRIPTION_PROV,NOTE_PROV=@NOTE_PROV,DATE_PROV=@DATE_PROV,KILO_AVANT=@KILO_AVANT,KILOMETRAGE_EFFECT_HEBDO_VEHICULE=@KILOMETRAGE_EFFECT_HEBDO_VEHICULE,DATEMODIFY=GETDATE() WHERE CODE_PROV='" + TxtCodeConsoCarbModi.Text + "'";
                                    Cmd.Parameters.AddWithValue("@ID_VEHICULE", IdCarCarbMod);
                                    Cmd.Parameters.AddWithValue("@DESCRIPTION_PROV", TxtDescriptionConsoCarbModi.Text);
                                    Cmd.Parameters.AddWithValue("@NOTE_PROV", RtxtNoteConsoCarbModi.Text);
                                    Cmd.Parameters.AddWithValue("@KILO_AVANT", decimal.Parse(TxtKiloAvantCarMod.Text));
                                    //MessageBox.Show(" Ancienne valeur kilo effect" + OldMeleageAffect + " Nouvelle valeur kilo = " + (OldMeleageAffect + decimal.Parse(TxtKilometrageEffectHebdo.Text))) ;
                                    Cmd.Parameters.AddWithValue("@KILOMETRAGE_EFFECT_HEBDO_VEHICULE", (CalOldValueOfMeleageEffect() + decimal.Parse(TxtKilometrageEffectHebdo.Text)));
                                    Cmd.Parameters.AddWithValue("@DATE_PROV", DateRegisterConsoCarbModi.Value.ToString("dd/MM/yyyy"));
                                    Cmd.ExecuteNonQuery();

                                    // Update car meleage
                                    Cmd.CommandText = "UPDATE VEHICULE SET TOTALKILOMETRAGE_VEHICULE=@TOTALKILOMETRAGE_VEHICULE, KILOMETRAGE_VIDENGE_VEHICULE=@KILOMETRAGE_VIDENGE_VEHICULE  WHERE CODE_VEHICULE='" + CodeCar + "' ";
                                    Cmd.Parameters.AddWithValue("@TOTALKILOMETRAGE_VEHICULE", decimal.Parse(TxtKiloAvantCarMod.Text));
                                    Cmd.Parameters.AddWithValue("@KILOMETRAGE_VIDENGE_VEHICULE", (decimal.Parse(TxtKiloVidengeCarb.Text) + decimal.Parse(TxtKilometrageEffectHebdo.Text)));
                                    Cmd.ExecuteNonQuery();
                                    MessageBox.Show("Enregistré avec succès !", "GestPark : Informations", MessageBoxButtons.OK);
                                    this.Close();
                                    Conn.cn.Close();
                                   
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

        // Verify fuel statut
        private void VerifyFuelSatut()
        {
            if (CbxStatutCarbMod.Text == "En cours")
            {
                BtnPaiementCarb.Visible = true;
            }
            else if (CbxStatutCarbMod.Text == "Payé")
            {
                BtnPaiementCarb.Visible = false;
            }

        }

        private void TxtKiloAvantCarMod_TextChanged(object sender, EventArgs e)
        {
            TxtKilometrageEffectHebdo.Text = (decimal.Parse(TxtKiloAvantCarMod.Text) - decimal.Parse(TxtKilometrageTotal.Text)).ToString();
        }

        private void BtnPaiementCarb_Click(object sender, EventArgs e)
        {
            FormAddPaiement AddPaie = new FormAddPaiement();
            AddPaie.ShowDialog();
        }

        private decimal CalOldValueOfMeleageEffect()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        using(var Cmd = Conn.cn.CreateCommand())
                        {
                            Cmd.CommandText = "SELECT KILOMETRAGE_EFFECT_HEBDO_VEHICULE FROM PROVISION WHERE CODE_PROV = '" + TxtCodeConsoCarbModi.Text + "'";
                            Reader = Cmd.ExecuteReader();
                            while (Reader.Read())
                            {
                                OldMeleageAffect = decimal.Parse(Reader[0].ToString());
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"GestPark : Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return OldMeleageAffect;
        }

    }
}
