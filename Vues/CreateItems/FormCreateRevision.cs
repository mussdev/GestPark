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
    public partial class FormCreateEntretien : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataAdapter SqlAda;
        private DataSet Ds;
        private SqlDataReader MyReader;
        private Guid? IdGarage = null, IdVehiculeRev;
        private decimal kilometrageVidenge = 0, kiloCarMarq=0;
        public FormCreateEntretien()
        {
            InitializeComponent();
            fillComboboxGarage();
        }

        // Generate code of personne
        private string generateCodeEntretien()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {
                // Generate code of car
                SqlCmd = new SqlCommand("SELECT CODE_MAINT FROM VIDANGE WHERE CODE_MAINT=(SELECT MAX(CODE_MAINT) FROM VIDANGE)", Conn.cn);
                SqlAda = new SqlDataAdapter(SqlCmd);
                Ds = new DataSet();
                SqlAda.Fill(Ds);

                if (Ds.Tables[0].Rows.Count > 0)
                {
                    TxtCodeVdge.Text = Ds.Tables[0].Rows[0]["CODE_MAINT"].ToString();
                }
                else
                {
                    TxtCodeVdge.Text = "MAIN0000";
                }
                if (!string.IsNullOrEmpty(TxtCodeVdge.Text))
                {
                    TxtCodeVdge.SelectionStart = 4;
                    TxtCodeVdge.SelectionLength = 4;
                    TxtCodeVdge.Text = TxtCodeVdge.SelectedText;
                }
                if (!string.IsNullOrEmpty(TxtCodeVdge.Text))
                {
                    int CodeFour = int.Parse(TxtCodeVdge.Text.ToString()) + 1;
                    TxtCodeVdge.Text = CodeFour.ToString("MAIN0000");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return TxtCodeVdge.Text;
        }

        private void fillComboboxGarage()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_GARAGE, DESCRIPTION_GARAGE FROM GARAGE", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            CbxGarageMaint.Items.Add(MyReader["DESCRIPTION_GARAGE"].ToString());
                            CbxGarageMaint.DisplayMember = (MyReader["DESCRIPTION_GARAGE"].ToString());
                            CbxGarageMaint.ValueMember = (MyReader["ID_GARAGE"].ToString());
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbxGarageMaint_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        if (!string.IsNullOrEmpty(CbxGarageMaint.Text))
                        {
                            SqlCmd = new SqlCommand("SELECT ID_GARAGE FROM GARAGE WHERE DESCRIPTION_GARAGE = '" + CbxGarageMaint.SelectedItem + "' ", Conn.cn);
                            MyReader = SqlCmd.ExecuteReader();
                            while (MyReader.Read())
                            {
                                IdGarage = Guid.Parse(MyReader[0].ToString());
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

        private decimal CalKilometrageVidenge()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT KILOMETRAGE_VIDENGE_VEHICULE FROM VEHICULE WHERE IMMATRICULATION_VEHICULE='" + txtCarVdge.Text + "'", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            kilometrageVidenge = decimal.Parse(MyReader[0].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return kilometrageVidenge;
        }

        private void BtnSaveEntretien_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnCreateEntre = new ToolTip();
            ToolTipBtnCreateEntre.AutoPopDelay = 5000;
            ToolTipBtnCreateEntre.InitialDelay = 1000;
            ToolTipBtnCreateEntre.ReshowDelay = 500;
            ToolTipBtnCreateEntre.ShowAlways = true;
            ToolTipBtnCreateEntre.SetToolTip(this.BtnSaveVdge, "Enregistrer");
        }

        private void BtnJoindreDoc_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnJoindDocEntre = new ToolTip();
            ToolTipBtnJoindDocEntre.AutoPopDelay = 5000;
            ToolTipBtnJoindDocEntre.InitialDelay = 1000;
            ToolTipBtnJoindDocEntre.ReshowDelay = 500;
            ToolTipBtnJoindDocEntre.ShowAlways = true;
            ToolTipBtnJoindDocEntre.SetToolTip(this.BtnJoindreDocVdge, "Joindre doc.");
        }

        private void BtnSaveEntretien_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (!string.IsNullOrEmpty(TxtPrixVdge.Text) && decimal.Parse(TxtPrixVdge.Text) > 0)
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
                                    Cmd.CommandText = "INSERT INTO VIDANGE (ID_VEHICULE,ID_GARAGE,CODE_MAINT,PRIX_MAINT,NOTE_MAINT,STATTION_MAINT,DATE_MAINT,DATECREATE_MAINT,HOLD_COMPTEUR_VIDANGE) VALUES (@ID_VEHICULE,@ID_GARAGE,@CODE_MAINT,@PRIX_MAINT,@NOTE_MAINT,@STATTION_MAINT,@DATE_MAINT,GETDATE(),@HOLD_COMPTEUR_VIDANGE)";

                                    if (IdGarage.HasValue)
                                    {
                                        Cmd.Parameters.AddWithValue("@ID_GARAGE", IdGarage);
                                    }else
                                        Cmd.Parameters.AddWithValue("@ID_GARAGE", DBNull.Value);

                                    Cmd.Parameters.AddWithValue("@ID_VEHICULE", IdCarVidange());
                                    Cmd.Parameters.AddWithValue("@CODE_MAINT", generateCodeEntretien());
                                    Cmd.Parameters.AddWithValue("@PRIX_MAINT", decimal.Parse(TxtPrixVdge.Text));
                                    Cmd.Parameters.AddWithValue("@NOTE_MAINT", RtxtNotesVdge.Text);
                                    Cmd.Parameters.AddWithValue("@STATTION_MAINT", TxtStationVdge.Text);
                                    Cmd.Parameters.AddWithValue("@HOLD_COMPTEUR_VIDANGE", CalKilometrageVidenge());
                                    Cmd.Parameters.AddWithValue("@DATE_MAINT", DatePickerCreateVdge.Value.ToString("dd/MM/yyyy"));
                                    Cmd.ExecuteNonQuery();

                                    // Mise à jour du kilométrage de vidange
                                    Cmd.CommandText = "SELECT KILO_VIDANGE_MARQ FROM VEHICULE LEFT OUTER JOIN MARQUE ON MARQUE.ID_MARQ=VEHICULE.ID_MARQ WHERE ID_VEHICULE='" + IdVehiculeRev + "'";
                                    MyReader = Cmd.ExecuteReader();
                                    while (MyReader.Read())
                                    {
                                        kiloCarMarq = decimal.Parse(MyReader[0].ToString());
                                    }
                                    MyReader.Close();

                                    Cmd.CommandText = "UPDATE VEHICULE SET KILOMETRAGE_VIDENGE_VEHICULE=@KILOMETRAGE_VIDENGE_VEHICULE WHERE ID_VEHICULE = '" + IdVehiculeRev + "' ";
                                    Cmd.Parameters.AddWithValue("@KILOMETRAGE_VIDENGE_VEHICULE", (CalKilometrageVidenge() - kiloCarMarq));
                                    Cmd.ExecuteNonQuery();

                                    MessageBox.Show("La vidange du véhicule a été effectuée avec succès !", "GestParc: Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private Guid IdCarVidange()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_VEHICULE FROM VEHICULE WHERE IMMATRICULATION_VEHICULE = '" + txtCarVdge.Text + "'", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdVehiculeRev = Guid.Parse(MyReader[0].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return (Guid) IdVehiculeRev;
        }

    }
}
