using GestPark.Vues.ModifierItems;
using Stimulsoft.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestPark.Vues.CreateItems
{
    public partial class FormOrdreDecision : Form
    {
        private SqlDataReader MyReader;
        private decimal AmountTypeStay = 0, AmountPeriodShort = 0, AmountPeriodAverage=0, AmountPeriodLong=0, AmountPrimeMission = 0, TotalPrime=0, PrimeAmount=0;
        public FormOrdreDecision()
        {
            InitializeComponent();
            //TxtDemandeurOrdreDecision.Text = FormCreateDemandeMission.DemandeurMission;
            TxtDemandeurOrdreDecision.Text = FormModifierProjetMission.DescriptionDemandeur;
            //MessageBox.Show("Montant = " + AmountPeriodStay());
            // AmountPeriodStay();
        }

        private void MenuItemFicheOrdreDecision_Click(object sender, EventArgs e)
        {
            var reportFicheDecisionMiss = new StiReport();
            reportFicheDecisionMiss.Load("FicheDecisionMission.mrt");
            //report.Show();
            //reportFicheDecisionMiss.Dictionary.Synchronize();
            //reportFicheDecisionMiss.Compile();
            //reportFicheDecisionMiss.Show(true);
            reportFicheDecisionMiss.Design();
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CbxCategProfFonct.Text) && !string.IsNullOrEmpty(CbxType.Text) && !string.IsNullOrEmpty(CbxPaysContinent.Text))
            {
                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                    ConnectDB conn = new ConnectDB(connectionString);

                    using(conn.cn) {
                        if (conn.IsConnection)
                        {
                            using(var Cmd = conn.cn.CreateCommand())
                            {
                                Cmd.CommandText = "SELECT MONTANT_CATEG_MISS FROM CATEGORIEMISSION WHERE DESCRIPTION_CATEG_MISS =@CategoryProf AND TYPE_CATEG_MISS =@TypStay AND PAYS_CONTICATEG_MISS =@ContinentOrCountry ";
                                Cmd.Parameters.AddWithValue("@CategoryProf", CbxCategProfFonct.Text);
                                Cmd.Parameters.AddWithValue("@TypStay", CbxType.Text);
                                Cmd.Parameters.AddWithValue("@ContinentOrCountry", CbxPaysContinent.Text);
                                MyReader = Cmd.ExecuteReader();

                                while(MyReader.Read())
                                {
                                    AmountTypeStay = decimal.Parse(MyReader["MONTANT_CATEG_MISS"].ToString());
                                }
                            }
                        }
                    }

                    DgvDecision.Rows.Add(CbxCategProfFonct.Text, CbxType.Text, CbxPaysContinent.Text, AmountTypeStay);
                    SumTypeStay();

                    // Netoyage des champs
                    CbxPaysContinent.Text = " ";
                    CbxType.Text = " ";
                    CbxCategProfFonct.Text = " ";
                }
                catch(Exception ex) { 
                    MessageBox.Show(ex.ToString(),"Fleet: Gestion des erreurs",MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
            }
            else
            {
                MessageBox.Show("Aucune catégorie professionnelle n'a été sélectionnée !" + "\n" + "Aucun type de séjour sélectionné ! !" + "\n" + "Aucun continent n'a été sélectionné" + "\n" + "Veillez renseignez ces champs (*)", "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormOrdreDecision_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestParkDataSet.ViewReparation'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.viewReparationTableAdapter.Fill(this.gestParkDataSet.ViewReparation);

        }

        /**
         * 
         */
        private void SumTypeStay()
        {
            // Calculer le montant total debité sur la carte
            decimal Mont = 0;
            for (int i = 0; i < DgvDecision.Rows.Count; ++i)
            {
                Mont += Convert.ToDecimal(DgvDecision.Rows[i].Cells["AmountMission"].Value);
            }

            //TxtTotalTypeStay.Text = $"{Mont.ToString("### ### ### ###")} ";
            TxtTotalTypeStay.Text = Mont.ToString("n0");
            TxtPrimeMission.Text = TxtTotalTypeStay.Text;
        }

        private void ChkShortStay_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkShortStay.Checked)
            {
                ChkAverageStay.Enabled = false;
                ChkLongStay.Enabled = false;
                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                    ConnectDB conn = new ConnectDB(connectionString);

                    using (conn.cn)
                    {
                        if (conn.IsConnection)
                        {
                            using (var Cmd = conn.cn.CreateCommand())
                            {
                                Cmd.CommandText = "SELECT MONTANT_PERIODMISS FROM PERIODEMISSION WHERE PERIODECOURTE_PERIODMISS=@periodStay";
                                Cmd.Parameters.AddWithValue("@periodStay", ChkShortStay.Checked);
                                MyReader = Cmd.ExecuteReader();

                                while (MyReader.Read())
                                {
                                    AmountPeriodShort = decimal.Parse(MyReader["MONTANT_PERIODMISS"].ToString());
                                }
                                //MessageBox.Show("Montant = " + AmountPeriodShort);
                                //CultureInfo culture = new CultureInfo("en-US")}
                                PrimeAmount =  decimal.Parse(TxtPrimeMission.Text);

                               // MessageBox.Show("Montant = " + decimal.Parse(PrimeAmount));
                                TotalPrime = PrimeAmount + AmountPeriodShort;
                                TxtPrimeMission.Text = TotalPrime.ToString("n0");
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Montant à deduire de la prime = " + AmountPeriodShort);
                decimal PrimeAmountOld = decimal.Parse(TxtPrimeMission.Text);
                TotalPrime = PrimeAmountOld - AmountPeriodShort;
                TxtPrimeMission.Text = TotalPrime.ToString("n0");
                ChkAverageStay.Enabled = true;
                ChkLongStay.Enabled = true;
            }
        }

        private void ChkAverageStay_CheckedChanged(object sender, EventArgs e)
        {
            if(ChkAverageStay.Checked)
            {
                ChkLongStay.Enabled = false;
                ChkShortStay.Enabled = false;
                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                    ConnectDB conn = new ConnectDB(connectionString);

                    using (conn.cn)
                    {
                        if (conn.IsConnection)
                        {
                            using (var Cmd = conn.cn.CreateCommand())
                            {
                                Cmd.CommandText = "SELECT MONTANT_PERIODMISS FROM PERIODEMISSION WHERE PERIODEMOYENNE_PERIODMISS=@periodStay";
                                Cmd.Parameters.AddWithValue("@periodStay", ChkAverageStay.Checked);
                                MyReader = Cmd.ExecuteReader();

                                while (MyReader.Read())
                                {
                                    AmountPeriodAverage = decimal.Parse(MyReader["MONTANT_PERIODMISS"].ToString());
                                }
                                MessageBox.Show("Montant = " + AmountPeriodAverage);
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                ChkLongStay.Enabled = true;
                ChkShortStay.Enabled = true;
            }
        }

        private void ChkLongStay_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkLongStay.Checked)
            {
                ChkAverageStay.Enabled = false;
                ChkShortStay.Enabled = false;
                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                    ConnectDB conn = new ConnectDB(connectionString);

                    using (conn.cn)
                    {
                        if (conn.IsConnection)
                        {
                            using (var Cmd = conn.cn.CreateCommand())
                            {
                                Cmd.CommandText = "SELECT MONTANT_PERIODMISS FROM PERIODEMISSION WHERE PERIODELONGUE_PERIODMISS=@periodStay";
                                Cmd.Parameters.AddWithValue("@periodStay", ChkLongStay.Checked);
                                MyReader = Cmd.ExecuteReader();

                                while (MyReader.Read())
                                {
                                    AmountPeriodLong = decimal.Parse(MyReader["MONTANT_PERIODMISS"].ToString());
                                }
                                MessageBox.Show("Montant = " + AmountPeriodLong);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                ChkAverageStay.Enabled = true;
                ChkShortStay.Enabled = true;
            }
        }

    }
}
