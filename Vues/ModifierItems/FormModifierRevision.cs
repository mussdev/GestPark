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
    public partial class FormModifierEntretien : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataReader MyReader;
        private Guid? IdGarageVdgeMod=null;
        public FormModifierEntretien()
        {
            InitializeComponent();
            //ListeVehiculeRev();
        }

        private void iconBtnSavedEntretien_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnCreateCar = new ToolTip();
            ToolTipBtnCreateCar.AutoPopDelay = 5000;
            ToolTipBtnCreateCar.InitialDelay = 1000;
            ToolTipBtnCreateCar.ReshowDelay = 500;
            ToolTipBtnCreateCar.ShowAlways = true;
            ToolTipBtnCreateCar.SetToolTip(this.iconBtnSavedEntretien, "Enregistrer");
        }

        private void iconBtUploadDoc_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnCreateCar = new ToolTip();
            ToolTipBtnCreateCar.AutoPopDelay = 5000;
            ToolTipBtnCreateCar.InitialDelay = 1000;
            ToolTipBtnCreateCar.ReshowDelay = 500;
            ToolTipBtnCreateCar.ShowAlways = true;
            ToolTipBtnCreateCar.SetToolTip(this.iconBtUploadDoc, "Joindre doc.");
        }

        private void iconBtnSavedEntretien_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (!string.IsNullOrEmpty(TxtMontantVdgeMod.Text) && decimal.Parse(TxtMontantVdgeMod.Text) > 0)
                {
                    DialogResult result = MessageBox.Show("Voulez vous enregister cette prise de vidange ?", "GestParc: Questions", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        using (Conn.cn)
                        {
                            if (Conn.IsConnection)
                            {
                                using (var Cmd = Conn.cn.CreateCommand())
                                {
                                    Cmd.CommandText = "UPDATE VIDANGE SET ID_GARAGE=@ID_GARAGE,PRIX_MAINT=@PRIX_MAINT,NOTE_MAINT=@NOTE_MAINT,STATTION_MAINT=@STATTION_MAINT,DATE_MAINT=@DATE_MAINT,DATEMODIFIER_MAINT=GETDATE() WHERE CODE_MAINT='"+ TxtCodeVdgeModi.Text + "' ";

                                    if (IdGarageVdgeMod.HasValue)
                                    {
                                        Cmd.Parameters.AddWithValue("@ID_GARAGE", IdGarageVdgeMod);
                                    }
                                    else
                                        Cmd.Parameters.AddWithValue("@ID_GARAGE", DBNull.Value);

                                    Cmd.Parameters.AddWithValue("@PRIX_MAINT", decimal.Parse(TxtMontantVdgeMod.Text));
                                    Cmd.Parameters.AddWithValue("@NOTE_MAINT", RtxtNotesVdgeModi.Text);
                                    Cmd.Parameters.AddWithValue("@STATTION_MAINT", TxtStationVdgeMod.Text);
                                    Cmd.Parameters.AddWithValue("@DATE_MAINT", DatePickerCreateVdgeMod.Value.ToString("dd/MM/yyyy"));
                                    Cmd.ExecuteNonQuery();

                                    MessageBox.Show("Les modifications ont a été enregistrées avec succès !", "GestParc: Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Veillez saisir le coût de la vidange ou bien saisissez un coût supérieur à zéro !", "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void CbxGarageVdgeModi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        if (!string.IsNullOrEmpty(CbxGarageVdgeModi.Text))
                        {
                            SqlCmd = new SqlCommand("SELECT ID_GARAGE FROM GARAGE WHERE DESCRIPTION_GARAGE = '" + CbxGarageVdgeModi.SelectedItem + "' ", Conn.cn);
                            MyReader = SqlCmd.ExecuteReader();
                            while (MyReader.Read())
                            {
                                IdGarageVdgeMod = Guid.Parse(MyReader[0].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // List vehicule
        //private void ListeVehiculeRev()
        //{
        //    try
        //    {
        //        string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        //        ConnectDB Conn = new ConnectDB(connectionString);

        //        using (Conn.cn)
        //        {
        //            if (Conn.IsConnection)
        //            {
        //                SqlCmd = new SqlCommand("SELECT*FROM VEHICULE WHERE TYPE_VEHICULE='pool'", Conn.cn);
        //                MyReader = SqlCmd.ExecuteReader();
        //                while (MyReader.Read())
        //                {
        //                    CbxCarRevisionMod.Items.Add(MyReader["IMMATRICULATION_VEHICULE"].ToString());
        //                    CbxCarRevisionMod.DisplayMember = (MyReader["IMMATRICULATION_VEHICULE"].ToString());
        //                    CbxCarRevisionMod.ValueMember = (MyReader["ID_VEHICULE"].ToString());
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void CbxCarRevisionMod_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        //        ConnectDB Conn = new ConnectDB(connectionString);
        //        using (Conn.cn)
        //        {
        //            if (Conn.IsConnection)
        //            {
        //                SqlCmd = new SqlCommand("SELECT ID_VEHICULE FROM VEHICULE WHERE IMMATRICULATION_VEHICULE = '" + txtVehiculeVdge.SelectedItem + "'", Conn.cn);
        //                MyReader = SqlCmd.ExecuteReader();
        //                while (MyReader.Read())
        //                {
        //                    IdVehiculeRevMod = Guid.Parse(MyReader[0].ToString());
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }
}
