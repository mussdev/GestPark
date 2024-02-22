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
using System.Globalization;

namespace GestPark
{
    public partial class FormCreateConsoCarburant : Form
    {
        private SqlCommand SqlCmd, SqlCmdMaj;
        private SqlDataAdapter SqlAda;
        private DataSet Ds;
        private SqlDataReader MyReader;
        private Guid IdVehiCarb, IdCardAppro, IdAppro;
        private string NumCard, CodeCar;
        private DataTable dtCar = new DataTable();
        private DataTable dt = new DataTable();
        DataRow dr,drCar;
        private decimal HoldKilometerVidenge=0, SoldeCard = 0,AmountPaieCard=0,AmountLiterEnergy=0;
        public FormCreateConsoCarburant()
        {
            InitializeComponent();
            FillComboboxVehiculeCarb();
            FillCbxCardPaie();

            // Column of table paie
            dt.Columns.Add("IdCard");
            dt.Columns.Add("CardNum");
            dt.Columns.Add("AmountCard");
           // dt.Columns.Add("holdAmountCard");

            // Column of table car
            dtCar.Columns.Add("IdCarRavi");
            dtCar.Columns.Add("ImmatCar");
            dtCar.Columns.Add("KilometrageTotalCar");
            dtCar.Columns.Add("KilometreHebdoParc");
            dtCar.Columns.Add("prixUnitaireCarburant");
            dtCar.Columns.Add("CoutConsomme");
            dtCar.Columns.Add("CompterVdge");
        }

        // Methode te generate code
        private string generateCodeProvCarb()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {
                // Generate code of car
                SqlCmd = new SqlCommand("SELECT CODE_PROV FROM PROVISION WHERE CODE_PROV=(SELECT MAX(CODE_PROV) FROM PROVISION)", Conn.cn);
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
                MessageBox.Show(ex.ToString(), "Fleet : Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        SqlCmd = new SqlCommand("SELECT * FROM VEHICULE WHERE TYPE_VEHICULE <> 'Affecté'", Conn.cn);
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
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IcBtnSavedConsoCarb_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Voulez vous enregister ce ravitaillement en carburant des véhicules ?", "Fleet: Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                    ConnectDB Conn = new ConnectDB(connectionString);
                    string CodVehCarb = generateCodeProvCarb();

                    using (Conn.cn)
                    {
                        if (Conn.IsConnection)
                        {
                            using (var Cmd = Conn.cn.CreateCommand())
                            {
                                Cmd.CommandText = "INSERT INTO PROVISION (CODE_PROV,DATE_PROV,MONTANT_PROV,DATECREATE_PROV) VALUES (@CODE_PROV,@DATE_PROV,@MONTANT_PROV,GETDATE())";
                                Cmd.Parameters.AddWithValue("@CODE_PROV", CodVehCarb);
                                Cmd.Parameters.AddWithValue("@DATE_PROV", DateRegisterConsoCarb.Value.ToString("dd/MM/yyyy"));
                                Cmd.Parameters.AddWithValue("@MONTANT_PROV", decimal.Parse(TxtTotalConsoCar.Text));
                                Cmd.ExecuteNonQuery();
                                Cmd.Parameters.Clear();

                                // Déterminer le id de la provision
                                Cmd.CommandText = "SELECT ID_PROV FROM PROVISION WHERE CODE_PROV = '" + CodVehCarb + "'";
                                MyReader = Cmd.ExecuteReader();
                                while (MyReader.Read())
                                {
                                    IdAppro = Guid.Parse(MyReader[0].ToString());
                                }
                                MyReader.Close();

                                for (int i = 0; i < DvgCarAppro.Rows.Count - 1; i++)
                                {
                                    //MessageBox.Show("i = " + i + " carId = " + DvgCarAppro.Rows[i].Cells["IdCarRavi"].Value + " kilo avant ravi = " + DvgCarAppro.Rows[i].Cells["KilometreHebdoParc"].Value);
                                    Cmd.CommandText = "INSERT INTO PROVISIONLINE (ID_PROV,ID_VEHICULE,KILO_AVANT_VIDENGE,MONTANT_PROV,LITRE_PROV,KILO_TOTAL_OLD_PROV,ANCIEN_COUNT_VIDANGE_PROV,PRIX_LITRE_PROV,DATECREATE_PROV) VALUES (@ID_PROV,@ID_VEHICULE,@KILO_AVANT_VIDENGE,@MONTANT_PROV,@LITRE_PROV,@KILO_TOTAL_OLD_PROV,@ANCIEN_COUNT_VIDANGE_PROV,@PRIX_LITRE_PROV,GETDATE())";
                                    Cmd.Parameters.AddWithValue("@ID_PROV", IdAppro);
                                    Cmd.Parameters.AddWithValue("@ID_VEHICULE", DvgCarAppro.Rows[i].Cells["IdCarRavi"].Value ?? DBNull.Value);
                                    Cmd.Parameters.AddWithValue("@MONTANT_PROV", Convert.ToDecimal(DvgCarAppro.Rows[i].Cells["CoutConsomme"].Value));
                                    Cmd.Parameters.AddWithValue("@LITRE_PROV", (Convert.ToDecimal(DvgCarAppro.Rows[i].Cells["CoutConsomme"].Value) / Convert.ToDecimal(DvgCarAppro.Rows[i].Cells["prixUnitaireCarburant"].Value)));
                                    Cmd.Parameters.AddWithValue("@KILO_AVANT_VIDENGE", decimal.Parse((string)DvgCarAppro.Rows[i].Cells["KilometreHebdoParc"].Value));
                                    Cmd.Parameters.AddWithValue("@KILO_TOTAL_OLD_PROV", decimal.Parse((string)DvgCarAppro.Rows[i].Cells["KilometrageTotalCar"].Value));
                                    Cmd.Parameters.AddWithValue("@ANCIEN_COUNT_VIDANGE_PROV", decimal.Parse((string)DvgCarAppro.Rows[i].Cells["CompterVdge"].Value));
                                    Cmd.Parameters.AddWithValue("@PRIX_LITRE_PROV", Convert.ToDecimal(DvgCarAppro.Rows[i].Cells["prixUnitaireCarburant"].Value));
                                    Cmd.ExecuteNonQuery();
                                    Cmd.Parameters.Clear();

                                    // Update car meleage
                                    Decimal OnlyCarKilomHebdo = Convert.ToDecimal(DvgCarAppro.Rows[i].Cells["KilometreHebdoParc"].Value);
                                    Decimal HoldKilometer = Convert.ToDecimal(DvgCarAppro.Rows[i].Cells["KilometrageTotalCar"].Value);
                                    decimal KilometreEffect = (OnlyCarKilomHebdo - HoldKilometer);
                                   
                                    // Mise a jour des compteurs vidange et kilometrage du véhicule
                                    Cmd.CommandText = "UPDATE VEHICULE SET KILOMETRAGE_VIDENGE_VEHICULE=@KILOMETRAGE_VIDENGE_VEHICULE,TOTALKILOMETRAGE_VEHICULE=@TOTALKILOMETRAGE_VEHICULE WHERE ID_VEHICULE='" + DvgCarAppro.Rows[i].Cells["IdCarRavi"].Value + "' ";
                                    Cmd.Parameters.AddWithValue("@KILOMETRAGE_VIDENGE_VEHICULE", (Convert.ToDecimal(DvgCarAppro.Rows[i].Cells["CompterVdge"].Value) + KilometreEffect));
                                    Cmd.Parameters.AddWithValue("@TOTALKILOMETRAGE_VEHICULE", (HoldKilometer + KilometreEffect));
                                    Cmd.ExecuteNonQuery();

                                }

                                for (int j = 0; j < DgvPaie.Rows.Count - 1; j++)
                                {
                                    // Recuperer le montant de la carte qui a servi le paiement
                                    Cmd.CommandText = "SELECT SOLDE_CARD FROM CARDPAIEMENT WHERE ID_CARD='" + DgvPaie.Rows[j].Cells["IdCard"].Value + "'";
                                    MyReader = Cmd.ExecuteReader();
                                    while (MyReader.Read())
                                    {
                                        AmountPaieCard = decimal.Parse(MyReader[0].ToString());
                                    }
                                    MyReader.Close();

                                    Cmd.CommandText = "INSERT INTO PAIEMENT (ID_PROV,ID_CARD,TOTALPRIX_PAIE,ANCIEN_SOLDE_CARTE_PAIE,DATE_PAIE,DATECREATE_PAIE) VALUES (@ID_PROV,@ID_CARD,@TOTALPRIX_PAIE,@ANCIEN_SOLDE_CARTE_PAIE,@DATE_PAIE,GETDATE())";
                                    Cmd.Parameters.AddWithValue("@ID_PROV", IdAppro);
                                    Cmd.Parameters.AddWithValue("@ID_CARD", DgvPaie.Rows[j].Cells["IdCard"].Value ?? DBNull.Value);
                                    Cmd.Parameters.AddWithValue("@TOTALPRIX_PAIE", DgvPaie.Rows[j].Cells["AmountCard"].Value ?? DBNull.Value);
                                    Cmd.Parameters.AddWithValue("@ANCIEN_SOLDE_CARTE_PAIE", AmountPaieCard);
                                    Cmd.Parameters.AddWithValue("@DATE_PAIE", datePaie.Value.ToString("dd/MM/yyyy"));
                                    //MessageBox.Show("Id Appro = " + IdAppro + " Id Card = " + IdCardAppro + " Date = " + DateRegisterConsoCarb.Value.ToString("dd/MM/yyyy"));
                                    Cmd.ExecuteNonQuery();
                                    Cmd.Parameters.Clear();

                                    // Mise à jour du solde de la carte des paiements de carburant
                                    decimal totalAmountCard = AmountPaieCard - decimal.Parse(DgvPaie.Rows[j].Cells["AmountCard"].Value.ToString());
                                    Cmd.CommandText = "UPDATE CARDPAIEMENT SET SOLDE_CARD=@SOLDE_CARD WHERE ID_CARD='" + DgvPaie.Rows[j].Cells["IdCard"].Value + "'";
                                    Cmd.Parameters.AddWithValue("@SOLDE_CARD", totalAmountCard);
                                    Cmd.ExecuteNonQuery();

                                    //MessageBox.Show("Solde carte avant paie = " + AmountPaieCard + " Solde après paie = " + totalAmountCard);
                                }

                                TxtCodeConsoCarb.Clear(); CbxVehiConsoCab.Text = null;
                                MessageBox.Show("Les ravitaillements de véhicules ont été enregistrés avec succès !", "Fleet: Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ItemMenuDeleteRavi_Click(object sender, EventArgs e)
        {
            int rowIndex = DvgCarAppro.CurrentCell.RowIndex;
            DvgCarAppro.Rows.RemoveAt(rowIndex);
        }

        private void ItemMenuDeletePaieRavi_Click(object sender, EventArgs e)
        {
            int rowIndex = DgvPaie.CurrentCell.RowIndex;
            DgvPaie.Rows.RemoveAt(rowIndex);
        }

        private void TxtkilometrageHebdoCarb_TextChanged(object sender, EventArgs e)
        {
            if (TxtkilometrageHebdoCarb.Text == "" || TxtkilometrageHebdoCarb.Text == "0") return;
            decimal price;
            price = decimal.Parse(TxtkilometrageHebdoCarb.Text, System.Globalization.NumberStyles.Currency);
            TxtkilometrageHebdoCarb.Text = price.ToString("#,#");
            TxtkilometrageHebdoCarb.SelectionStart = TxtkilometrageHebdoCarb.Text.Length;
        }

        private void TxtAmountConsoOnlyCarAppro_TextChanged(object sender, EventArgs e)
        {
            if (TxtAmountConsoOnlyCarAppro.Text == "" || TxtAmountConsoOnlyCarAppro.Text == "0") return;
            decimal price;
            price = decimal.Parse(TxtAmountConsoOnlyCarAppro.Text, System.Globalization.NumberStyles.Currency);
            TxtAmountConsoOnlyCarAppro.Text = price.ToString("#,#");
            TxtAmountConsoOnlyCarAppro.SelectionStart = TxtAmountConsoOnlyCarAppro.Text.Length;
        }

        private void TxtAmountAppro_TextChanged(object sender, EventArgs e)
        {
            if (TxtAmountAppro.Text == "" || TxtAmountAppro.Text == "0") return;
            decimal price;
            price = decimal.Parse(TxtAmountAppro.Text, System.Globalization.NumberStyles.Currency);
            TxtAmountAppro.Text = price.ToString("#,#");
            TxtAmountAppro.SelectionStart = TxtAmountAppro.Text.Length;
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
                        SqlCmd = new SqlCommand("SELECT ID_VEHICULE,TOTALKILOMETRAGE_VEHICULE,KILOMETRAGE_VIDENGE_VEHICULE,CODE_VEHICULE,PRIXLITRE_TYPCONSO FROM VEHICULE LEFT OUTER JOIN TYPECONSOMMATION ON VEHICULE.ID_TYPCONSO=TYPECONSOMMATION.ID_TYPCONSO WHERE IMMATRICULATION_VEHICULE = '" + CbxVehiConsoCab.SelectedItem + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdVehiCarb = Guid.Parse(MyReader["ID_VEHICULE"].ToString());
                            TxtKilometreTotal.Text = string.Format(CultureInfo.GetCultureInfo("fr"), "{0:n}", MyReader["TOTALKILOMETRAGE_VEHICULE"]);
                            HoldKilometerVidenge = decimal.Parse(MyReader["KILOMETRAGE_VIDENGE_VEHICULE"].ToString());
                            CodeCar = MyReader["CODE_VEHICULE"].ToString();
                            //TxtKilometreTotal.Text = HoldKilometerCar.ToString();
                            AmountLiterEnergy = decimal.Parse(MyReader["PRIXLITRE_TYPCONSO"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void JointDocConsoCarb_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnJoinDocRaviCarbu = new ToolTip();
            ToolTipBtnJoinDocRaviCarbu.AutoPopDelay = 5000;
            ToolTipBtnJoinDocRaviCarbu.InitialDelay = 1000;
            ToolTipBtnJoinDocRaviCarbu.ReshowDelay = 500;
            ToolTipBtnJoinDocRaviCarbu.ShowAlways = true;
            ToolTipBtnJoinDocRaviCarbu.SetToolTip(this.JointDocConsoCarb, "Joindre doc.");
        }

        private void BtnAddCar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CbxVehiConsoCab.Text))
            {
                if(decimal.Parse(TxtAmountConsoOnlyCarAppro.Text) > 0)
                {
                    if(decimal.Parse(TxtkilometrageHebdoCarb.Text) > 0 && decimal.Parse(TxtkilometrageHebdoCarb.Text) > decimal.Parse(TxtKilometreTotal.Text) )
                    {
                        drCar = dtCar.NewRow();
                        drCar["IdCarRavi"] = IdVehiCarb;
                        drCar["ImmatCar"] = CbxVehiConsoCab.Text;
                        drCar["KilometrageTotalCar"] = decimal.Parse(TxtKilometreTotal.Text);
                        drCar["KilometreHebdoParc"] = decimal.Parse(TxtkilometrageHebdoCarb.Text);
                        drCar["prixUnitaireCarburant"] = AmountLiterEnergy;
                        drCar["CoutConsomme"] = decimal.Parse(TxtAmountConsoOnlyCarAppro.Text);
                        drCar["CompterVdge"] = HoldKilometerVidenge;
                        dtCar.Rows.Add(drCar);
                        DvgCarAppro.DataSource = dtCar;
                        CbxVehiConsoCab.ResetText(); 
                        TxtAmountConsoOnlyCarAppro.Text = "0";
                        TxtkilometrageHebdoCarb.Text = "0";
                        TxtKilometreTotal.Clear();

                        // Calculer le montant total debité sur la carte
                        decimal Mont = 0;
                        for (int i = 0; i < DvgCarAppro.Rows.Count; ++i)
                        {
                            Mont += Convert.ToDecimal(DvgCarAppro.Rows[i].Cells["CoutConsomme"].Value);
                        }

                        TxtTotalConsoCar.Text = string.Format(CultureInfo.GetCultureInfo("fr"), "{0:n}", Mont);
                    }
                    else
                    {
                        MessageBox.Show("Veillez saisir une valeur positive ou la valeur doit être supérieure au kilomètre total !!!", "Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Veillez saisi un montant positif !!!", "Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Fleet: Avertissemen", "Veillez sélectionner le véhicule svp !!!", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void BtnPrintCarbu_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnPrintRaviCarbu = new ToolTip();
            ToolTipBtnPrintRaviCarbu.AutoPopDelay = 5000;
            ToolTipBtnPrintRaviCarbu.InitialDelay = 1000;
            ToolTipBtnPrintRaviCarbu.ReshowDelay = 500;
            ToolTipBtnPrintRaviCarbu.ShowAlways = true;
            ToolTipBtnPrintRaviCarbu.SetToolTip(this.JointDocConsoCarb, "Imprimer");
        }

        private void BtnAddCardAppro_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CbxCartPaieAppro.Text))
            {
                if(decimal.Parse(TxtAmountAppro.Text) > 0 && decimal.Parse(TxtAmountAppro.Text) <= SoldeCard)
                {
                    dr = dt.NewRow();
                    dr["IdCard"] = IdCardAppro;
                    dr["CardNum"] = CbxCartPaieAppro.Text;
                    dr["AmountCard"] = decimal.Parse(TxtAmountAppro.Text);
                    dt.Rows.Add(dr);
                    DgvPaie.DataSource = dt;
                    CbxCartPaieAppro.Text = null; TxtAmountAppro.Clear();

                    // Calculer le montant total debité sur la carte
                    decimal Mont = 0;
                    for (int i = 0; i < DgvPaie.Rows.Count; ++i)
                    {
                        Mont += Convert.ToDecimal(DgvPaie.Rows[i].Cells[2].Value);
                    }

                    TxtTotalAmountCard.Text = $"{Mont.ToString("### ### ### ###")} ";
                }
                else
                {
                    MessageBox.Show("Le solde de la carte debiteur est insuffisant", "Fleet: Avertissement", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Sélectionnez la carte à debiter !!!", "Fleet: Avertissement", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void IcBtnSavedConsoCarb_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnCreateRaviCarburant = new ToolTip();
            ToolTipBtnCreateRaviCarburant.AutoPopDelay = 5000;
            ToolTipBtnCreateRaviCarburant.InitialDelay = 1000;
            ToolTipBtnCreateRaviCarburant.ReshowDelay = 500;
            ToolTipBtnCreateRaviCarburant.ShowAlways = true;
            ToolTipBtnCreateRaviCarburant.SetToolTip(this.IcBtnSavedConsoCarb, "Enregistrer");
        }

        private void CbxCartPaieAppro_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_CARD,NUM_CARD,SOLDE_CARD FROM CARDPAIEMENT WHERE TPYE_CARD = '" + CbxCartPaieAppro.SelectedItem + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdCardAppro = Guid.Parse(MyReader[0].ToString());
                            NumCard = MyReader[1].ToString();
                            SoldeCard = decimal.Parse(MyReader[2].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Fill combobox vehicule
        private void FillCbxCardPaie()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT * FROM CARDPAIEMENT", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            CbxCartPaieAppro.Items.Add(MyReader["TPYE_CARD"].ToString());
                            CbxCartPaieAppro.DisplayMember = (MyReader["TPYE_CARD"].ToString());
                            CbxCartPaieAppro.ValueMember = (MyReader["ID_CARD"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
