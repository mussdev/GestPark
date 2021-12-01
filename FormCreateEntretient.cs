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
        private int IdVehicule = 0;
        private int? IdGarage = null;
        private decimal kilometrageVidenge = 0;
        public FormCreateEntretien()
        {
            InitializeComponent();
            // FillComboboxVehicule();
            fillComboboxGarage();
            TxtKiloVidengeModi.Text = CalKilometrageVidenge().ToString();
        }

        // Generate code of personne
        private string generateCodeEntretien()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        // Generate code attribution car to person
                        SqlCmd = new SqlCommand("SELECT CODE_MAINT FROM MAINTENANCE WHERE CODE_MAINT=(SELECT MAX(CODE_MAINT) FROM MAINTENANCE)", Conn.cn);
                        SqlAda = new SqlDataAdapter(SqlCmd);
                        Ds = new DataSet();
                        SqlAda.Fill(Ds);

                        if (Ds.Tables[0].Rows.Count > 0)
                        {
                            TxtCodeMaintModi.Text = Ds.Tables[0].Rows[0]["CODE_MAINT"].ToString();
                        }
                        else
                        {
                            TxtCodeMaintModi.Text = "MAIN0000";
                        }
                        if (!string.IsNullOrEmpty(TxtCodeMaintModi.Text))
                        {
                            TxtCodeMaintModi.SelectionStart = 4;
                            TxtCodeMaintModi.SelectionLength = 4;
                            TxtCodeMaintModi.Text = TxtCodeMaintModi.SelectedText;
                        }
                        if (!string.IsNullOrEmpty(TxtCodeMaintModi.Text))
                        {
                            int codeCarEntre = int.Parse(TxtCodeMaintModi.Text.ToString()) + 1;
                            TxtCodeMaintModi.Text = codeCarEntre.ToString("MAIN0000");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return TxtCodeMaintModi.Text;
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
                            CbxGarageMaintModi.Items.Add(MyReader["DESCRIPTION_GARAGE"].ToString());
                            CbxGarageMaintModi.DisplayMember = (MyReader["DESCRIPTION_GARAGE"].ToString());
                            CbxGarageMaintModi.ValueMember = (MyReader["ID_GARAGE"].ToString());
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void iconBtnSavedMaint_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(CbxCarMaintModi.Text) && string.IsNullOrEmpty(CbxGarageMaintModi.Text) && string.IsNullOrEmpty(CbxTypeEntretienMaint.Text))
            {
                MessageBox.Show("Veillez saisir tous les champs obligatoires svp !!!", "GestPark: Avertissement !", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult result = MessageBox.Show("Voulez vous enregister ?", "Oui", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                        ConnectDB Conn = new ConnectDB(connectionString);
                        string CodMaint = generateCodeEntretien();
                        using (Conn.cn)
                        {
                            if (Conn.IsConnection)
                            {
                                using(var Cmd = Conn.cn.CreateCommand())
                                {
                                    Cmd.CommandText = "INSERT INTO MAINTENANCE (ID_GARAGE,ID_VEHICULE,CODE_MAINT,STATUT_MAINT,DATE_MAINT,NOTE_MAINT,PRIX_MAINT,TYPE_MAINT,STATTION_MAINT,DATECREATE_MAINT) VALUES (@ID_GARAGE,@ID_VEHICULE,@CODE_MAINT,@STATUT_MAINT,@DATE_MAINT,@NOTE_MAINT,@PRIX_MAINT,@TYPE_MAINT,@STATTION_MAINT,GETDATE())";
                                    if (IdGarage.HasValue)
                                        Cmd.Parameters.AddWithValue("@ID_GARAGE", IdGarage.Value);
                                    else
                                        Cmd.Parameters.AddWithValue("@ID_GARAGE", DBNull.Value);

                                    Cmd.Parameters.AddWithValue("@ID_VEHICULE", CalIdCar());
                                    Cmd.Parameters.AddWithValue("@CODE_MAINT", CodMaint);
                                    Cmd.Parameters.AddWithValue("@STATUT_MAINT", CbxStatutMaintModi.Text);
                                    Cmd.Parameters.AddWithValue("@DATE_MAINT", DatePickerCreateMaintModi.Value.ToString("dd/MM/yyyy"));
                                    Cmd.Parameters.AddWithValue("@NOTE_MAINT", RtxtNotesMaintModi.Text);
                                    Cmd.Parameters.AddWithValue("@PRIX_MAINT", decimal.Parse(TxtPrixMaintModi.Text));
                                    Cmd.Parameters.AddWithValue("@TYPE_MAINT", CbxTypeEntretienMaint.Text);
                                    Cmd.Parameters.AddWithValue("@STATTION_MAINT", TxtStationMaintModi.Text);
                                    Cmd.ExecuteNonQuery();

                                    Cmd.CommandText = "UPDATE VEHICULE SET KILOMETRAGE_VIDENGE_VEHICULE=@KILOMETRAGE_VIDENGE_VEHICULE WHERE IMMATRICULATION_VEHICULE='" + CbxCarMaintModi.Text + "'";
                                    Cmd.Parameters.AddWithValue("@KILOMETRAGE_VIDENGE_VEHICULE", (CalKilometrageVidenge() - 10000));
                                    Cmd.ExecuteNonQuery();
                                    // MessageBox.Show("Kilometrage de videnge reste : " + (CalKilometrageVidenge()));
                                    MessageBox.Show("Enregistré avec succès !!!", "GestPark: Informations", MessageBoxButtons.OK);
                                    this.Close();
                                }
                                
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "GestPark: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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
                        if (!string.IsNullOrEmpty(CbxGarageMaintModi.Text))
                        {
                            SqlCmd = new SqlCommand("SELECT ID_GARAGE FROM GARAGE WHERE DESCRIPTION_GARAGE = '" + CbxGarageMaintModi.SelectedItem + "' ", Conn.cn);
                            MyReader = SqlCmd.ExecuteReader();
                            while (MyReader.Read())
                            {
                                IdGarage = int.Parse(MyReader[0].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int CalIdCar()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_VEHICULE FROM VEHICULE WHERE IMMATRICULATION_VEHICULE='"+ CbxCarMaintModi.Text +"'", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdVehicule = int.Parse(MyReader[0].ToString());
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return IdVehicule;
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
                        SqlCmd = new SqlCommand("SELECT KILOMETRAGE_VIDENGE_VEHICULE FROM VEHICULE WHERE IMMATRICULATION_VEHICULE='" + CbxCarMaintModi.Text + "'", Conn.cn);
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
                MessageBox.Show(ex.ToString(), "GestPark: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return kilometrageVidenge;
        }
    }
}
