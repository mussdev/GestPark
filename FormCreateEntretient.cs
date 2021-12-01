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
        private int IdVehicule = 0, IdGarage = 0;
        public FormCreateEntretien()
        {
            InitializeComponent();
            FillComboboxVehicule();
            fillComboboxGarage();
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
                            TxtCodeMaint.Text = Ds.Tables[0].Rows[0]["CODE_MAINT"].ToString();
                        }
                        else
                        {
                            TxtCodeMaint.Text = "MAIN0000";
                        }
                        if (!string.IsNullOrEmpty(TxtCodeMaint.Text))
                        {
                            TxtCodeMaint.SelectionStart = 4;
                            TxtCodeMaint.SelectionLength = 4;
                            TxtCodeMaint.Text = TxtCodeMaint.SelectedText;
                        }
                        if (!string.IsNullOrEmpty(TxtCodeMaint.Text))
                        {
                            int codePers = int.Parse(TxtCodeMaint.Text.ToString()) + 1;
                            TxtCodeMaint.Text = codePers.ToString("MAIN0000");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return TxtCodeMaint.Text;
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
                        SqlCmd = new SqlCommand("SELECT ID_VEHICULE, IMMATRICULATION_VEHICULE FROM VEHICULE", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            CbxCarMaint.Items.Add(MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            CbxCarMaint.DisplayMember = (MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            CbxCarMaint.ValueMember = (MyReader["ID_VEHICULE"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                MessageBox.Show(e.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbxCarMaint_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_VEHICULE FROM VEHICULE WHERE IMMATRICULATION_VEHICULE = '" + CbxCarMaint.SelectedItem + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdVehicule = int.Parse(MyReader[0].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iconBtnSavedMaint_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(CbxCarMaint.Text) && string.IsNullOrEmpty(CbxGarageMaint.Text) && string.IsNullOrEmpty(CbxTypeEntretienMaint.Text))
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
                                // Request to insert data in table personnels
                                SqlCmd = new SqlCommand("INSERT INTO GARAGE (ID_GARAGE,ID_VEHICULE,CODE_MAINT,STATUT_MAINT,DATE_MAINT,NOTE_MAINT,PRIX_MAINT,TYPE_MAINT,STATTION_MAINT,DATECREATE_MAINT) VALUES (@ID_GARAGE,@ID_VEHICULE,@CODE_MAINT,@STATUT_MAINT,@DATE_MAINT,@NOTE_MAINT,@PRIX_MAINT,@TYPE_MAINT,GETDATE()); ", Conn.cn);
                                SqlCmd.Parameters.AddWithValue("@ID_GARAGE", IdGarage);
                                SqlCmd.Parameters.AddWithValue("@ID_VEHICULE", IdVehicule);
                                SqlCmd.Parameters.AddWithValue("@CODE_MAINT", TxtCodeMaint.Text);
                                SqlCmd.Parameters.AddWithValue("@STATUT_MAINT", CbxStatutMaint.Text);
                                SqlCmd.Parameters.AddWithValue("@DATE_MAINT", DatePickerCreateMaint.Value.ToString("dd/MM/yyyy"));
                                SqlCmd.Parameters.AddWithValue("@NOTE_MAINT", RtxtNotesMaint.Text);
                                SqlCmd.Parameters.AddWithValue("@PRIX_MAINT", decimal.Parse(TxtPrixMaint.Text));
                                SqlCmd.Parameters.AddWithValue("@TYPE_MAINT", CbxTypeEntretienMaint.Text);
                                SqlCmd.Parameters.AddWithValue("@STATTION_MAINT", TxtStationMaint.Text);
                                SqlCmd.ExecuteNonQuery();
                                MessageBox.Show("Enregistré avec succès !!!", "GestPark: Informations", MessageBoxButtons.OK);
                                this.Close();
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
                        SqlCmd = new SqlCommand("SELECT ID_GARAGE FROM GARAGE WHERE DESCRIPTION_GARAGE = '" + CbxGarageMaint.SelectedItem + "' ", Conn.cn);
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
                MessageBox.Show(ex.ToString(), "GestPark: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
