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
using Stimulsoft.Report;

namespace GestPark
{
    public partial class FormCreateConsoCarburant : Form
    {
        private SqlCommand SqlCmd, SqlCmdMaj;
        private SqlDataAdapter SqlAda;
        private DataSet Ds;
        private SqlDataReader MyReader;
        private int IdVehiCarb;
        private string CodeCar;
        public FormCreateConsoCarburant()
        {
            InitializeComponent();
            FillComboboxVehiculeCarb();
        }

        // Methode te generate code
        private string generateCodeProvCarb()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {
                // Generate code of car
                SqlCmd = new SqlCommand("SELECT CODE_PROV FROM PROVISION WHERE ID_PROV=(SELECT MAX(ID_PROV) FROM PROVISION)", Conn.cn);
                SqlAda = new SqlDataAdapter(SqlCmd);
                Ds = new DataSet();
                SqlAda.Fill(Ds);

                if (Ds.Tables[0].Rows.Count > 0)
                {
                    TxtCodeConsoCarb.Text = Ds.Tables[0].Rows[0]["CODE_PROV"].ToString();
                }
                else
                {
                    TxtCodeConsoCarb.Text = "PROV0000";
                }
                if (!string.IsNullOrEmpty(TxtCodeConsoCarb.Text))
                {
                    TxtCodeConsoCarb.SelectionStart = 4;
                    TxtCodeConsoCarb.SelectionLength = 4;
                    TxtCodeConsoCarb.Text = TxtCodeConsoCarb.SelectedText;
                }
                if (!string.IsNullOrEmpty(TxtCodeConsoCarb.Text))
                {
                    int CodeFour = int.Parse(TxtCodeConsoCarb.Text.ToString()) + 1;
                    TxtCodeConsoCarb.Text = CodeFour.ToString("PROV0000");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark : GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return TxtCodeConsoCarb.Text;
        }

        // Fill combobox vehicule
        private void FillComboboxVehiculeCarb()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT*FROM VEHICULE", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            CbxVehiConsoCab.Items.Add(MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            CbxVehiConsoCab.DisplayMember = (MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            CbxVehiConsoCab.ValueMember = (MyReader["ID_VEHICULE"].ToString());

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbxVehiConsoCab_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_VEHICULE, TYPECONSOMMATION.DESCRIPTION_TYPCONSO, TOTALKILOMETRAGE_VEHICULE,KILOMETRAGE_VIDENGE_VEHICULE,CODE_VEHICULE FROM VEHICULE LEFT OUTER JOIN TYPECONSOMMATION ON VEHICULE.ID_TYPCONSO=TYPECONSOMMATION.ID_TYPCONSO WHERE IMMATRICULATION_VEHICULE = '" + CbxVehiConsoCab.SelectedItem + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdVehiCarb = int.Parse(MyReader[0].ToString());
                            TxtTypConsoCarb.Text = MyReader[1].ToString();
                            TxtKiloTotalCar.Text = MyReader[2].ToString();
                            if (string.IsNullOrEmpty(TxtKiloVidengeCarb.Text = MyReader[3].ToString())){
                                TxtKiloVidengeCarb.Text = "0";
                            }
                            else
                            {
                                TxtKiloVidengeCarb.Text = MyReader[3].ToString();
                            }
                            CodeCar = MyReader[4].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IcBtnSavedConsoCarb_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CbxVehiConsoCab.Text))
            {
                MessageBox.Show("Veillez choisir un vehicule !","GestPark", MessageBoxButtons.OK);
            }else if (string.IsNullOrEmpty(TxtkilometrageAvantCarb.Text))
            {
                MessageBox.Show("Veillez saisir le kilometrage du vehicule !!!", "GestPark", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    DialogResult result = MessageBox.Show("Voulez vous enregister ?", "GESTPARK: CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                        ConnectDB Conn = new ConnectDB(connectionString);
                        string CodVehCarb = generateCodeProvCarb();

                        using (Conn.cn)
                        {
                            if (Conn.IsConnection)
                            {
                                if (decimal.Parse(TxtkilometrageAvantCarb.Text) > decimal.Parse(TxtKiloTotalCar.Text))
                                {
                                    using (var Cmd = Conn.cn.CreateCommand())
                                    {
                                        Cmd.CommandText = "INSERT INTO PROVISION (ID_VEHICULE,CODE_PROV,DESCRIPTION_PROV,KILO_AVANT,NOTE_PROV,STATUT_PROV,KILOMETRAGE_EFFECT_HEBDO_VEHICULE,DATE_PROV,DATECREATE_PROV) VALUES (@ID_VEHICULE,@CODE_PROV,@DESCRIPTION_PROV,@KILO_AVANT,@NOTE_PROV,@STATUT_PROV,@KILOMETRAGE_EFFECT_HEBDO_VEHICULE,@DATE_PROV,GETDATE())";
                                        Cmd.Parameters.AddWithValue("@ID_VEHICULE", IdVehiCarb);
                                        Cmd.Parameters.AddWithValue("@CODE_PROV", CodVehCarb);
                                        Cmd.Parameters.AddWithValue("@DESCRIPTION_PROV", TxtDescriptionConsoCarb.Text);
                                        Cmd.Parameters.AddWithValue("@KILO_AVANT", decimal.Parse(TxtkilometrageAvantCarb.Text));
                                        //Cmd.Parameters.AddWithValue("@QTELITRE_PROV", decimal.Parse(TxtLitreConsoCarb.Text));
                                        Cmd.Parameters.AddWithValue("@STATUT_PROV", CbxStatutProvisionCarb.Text);
                                        Cmd.Parameters.AddWithValue("@KILOMETRAGE_EFFECT_HEBDO_VEHICULE", decimal.Parse(TxtKilometreEffect.Text));
                                        Cmd.Parameters.AddWithValue("@NOTE_PROV", RtxtNoteConsoCarb.Text);
                                        Cmd.Parameters.AddWithValue("@DATE_PROV", DateRegisterConsoCarb.Value.ToString("dd/MM/yyyy"));
                                        Cmd.ExecuteNonQuery();

                                        // Update car meleage
                                        Cmd.CommandText = "UPDATE VEHICULE SET KILOMETRAGE_VIDENGE_VEHICULE=@KILOMETRAGE_VIDENGE_VEHICULE,TOTALKILOMETRAGE_VEHICULE=@TOTALKILOMETRAGE_VEHICULE WHERE CODE_VEHICULE='" + CodeCar + "' ";
                                        Cmd.Parameters.AddWithValue("@KILOMETRAGE_VIDENGE_VEHICULE", (decimal.Parse(TxtKiloVidengeCarb.Text) + decimal.Parse(TxtKilometreEffect.Text)));
                                        Cmd.Parameters.AddWithValue("@TOTALKILOMETRAGE_VEHICULE", (decimal.Parse(TxtKiloTotalCar.Text) + decimal.Parse(TxtKilometreEffect.Text)));
                                        Cmd.ExecuteNonQuery();
                                        MessageBox.Show("Enregistré avec succès !", "GestPark : Informations", MessageBoxButtons.OK);
                                        TxtCodeConsoCarb.Clear(); TxtDescriptionConsoCarb.Clear(); RtxtNoteConsoCarb.Clear(); CbxVehiConsoCab.Text = null;

                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Veillez verifier le kilometrage effectué avant la consommation car il doit être supérieur au kilometrage total.", "GestPark : Avertissement !", MessageBoxButtons.OK);
                                }
                                  
                            }
                        }
                    }    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void BtnPrintCarbu_Click(object sender, EventArgs e)
        {
            var reportCarCarburant = new StiReport();
            // Call report
            reportCarCarburant.Design();
        }

        private void BtnPaiementCarb_Click(object sender, EventArgs e)
        {
            FormAddPaiement AddPaie = new FormAddPaiement();
            AddPaie.ShowDialog();
        }

        private void TxtkilometrageAvantCarb_TextChanged(object sender, EventArgs e)
        {
            TxtKilometreEffect.Text = (decimal.Parse(TxtkilometrageAvantCarb.Text) - decimal.Parse(TxtKiloTotalCar.Text)).ToString();
        }
    }
}
