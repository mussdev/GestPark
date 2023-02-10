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
using Microsoft.Reporting.WinForms;

namespace GestPark
{
    public partial class FormReportCar : Form
    {
        //private SqlCommand sqlCmd;
        //private SqlDataAdapter sqlAda;
        private SqlDataReader MyReader;
        private string codCarReport, IdCarReport;
        public FormReportCar()
        {
            InitializeComponent();
            codCarReport = FormModifyVehicule.codeCar;
            IdCarReport = FormModifyVehicule.idCarMod;
        }

        private void FormReportCar_Load(object sender, EventArgs e)
        {
            displayDataCar();
            this.reportViewerCar.RefreshReport();
            
        }

        public void displayDataCar()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (Conn.IsConnection)
                {
                    using (var Cmd = Conn.cn.CreateCommand())
                    {
                        Cmd.CommandText = "SELECT*FROM VEHICULE LEFT OUTER JOIN TYPECONSOMMATION ON TYPECONSOMMATION.ID_TYPCONSO = VEHICULE.ID_TYPCONSO LEFT OUTER JOIN FOURNISSEUR ON FOURNISSEUR.ID_FOUR = VEHICULE.ID_FOUR LEFT OUTER JOIN MARQUE ON MARQUE.ID_MARQ = VEHICULE.ID_MARQ LEFT OUTER JOIN APPARTENIR ON APPARTENIR.ID_VEHICULE = VEHICULE.ID_VEHICULE LEFT OUTER JOIN PERSONNELS ON PERSONNELS.ID_PERS = APPARTENIR.ID_PERS WHERE CODE_VEHICULE='" + codCarReport + "'";
                        MyReader = Cmd.ExecuteReader();
                        //MessageBox.Show("Contenu de la variable MyReader : " + MyReader["IMMATRICULATION_VEHICULE"].ToString());
                        while (MyReader.Read())
                        {
                            ReportParameter[] param = new ReportParameter[12];
                            param[0] = new ReportParameter("pMatriculeCar", MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            param[1] = new ReportParameter("pCarteGrise", MyReader["CARTE_GRISE_VEHICULE"].ToString());
                            param[2] = new ReportParameter("pMarq", MyReader["DESCRIPTION_MARQ"].ToString());
                            param[3] = new ReportParameter("pModel", MyReader["MODELE_MARQ"].ToString());
                            param[4] = new ReportParameter("pEnergie", MyReader["DESCRIPTION_TYPCONSO"].ToString());
                            param[5] = new ReportParameter("pFour", MyReader["DESCRIPTION_FOUR"].ToString());
                            param[6] = new ReportParameter("pPrixCar", MyReader["PRIX_VEHICULE"].ToString());
                            param[7] = new ReportParameter("pEtat", MyReader["SANTE_VEHICULE"].ToString());
                            param[8] = new ReportParameter("pKilometrageTotal", MyReader["TOTALKILOMETRAGE_VEHICULE"].ToString());
                            param[9] = new ReportParameter("pDateAchatCar", MyReader["DATE_ACHA_VEHICULE"].ToString());
                            param[10] = new ReportParameter("pDateLastAssurCar", MyReader["ASSURANCE_VEHICULE"].ToString());
                            param[11] = new ReportParameter("pDateVisiteCar", MyReader["DATE_VISITE_VEHICULE"].ToString());
                            this.reportViewerCar.LocalReport.SetParameters(param);
                        }
                        //MyReader.Close();
                    }

                    // Information sur les approvionnements
                    using (var Cmd = Conn.cn.CreateCommand())
                    {
                        Cmd.CommandText = "select COUNT(CODE_PROV) as NbrRavitaillement,IMMATRICULATION_VEHICULE, SUM(LITRE_PROV) as Totallitre,SUM(MONTANT_PROV) AS TotalMontant from View_Provision where IMMATRICULATION_VEHICULE = '" + IdCarReport + "' group by IMMATRICULATION_VEHICULE";
                        MyReader = Cmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            ReportParameter[] param = new ReportParameter[3];
                            param[0] = new ReportParameter("pNbreRavi", MyReader["NbrRavitaillement"].ToString());
                            param[1] = new ReportParameter("pTotalLitreRavi", MyReader["Totallitre"].ToString());
                            param[2] = new ReportParameter("pTotalMontantRavi", MyReader["TotalMontant"].ToString());
                            this.reportViewerCar.LocalReport.SetParameters(param);
                        }
                    }

                    // Information vidange
                    using (var Cmd = Conn.cn.CreateCommand())
                    {
                        Cmd.CommandText = "select COUNT(CODE_PROV) as NbrRavitaillement,IMMATRICULATION_VEHICULE, SUM(LITRE_PROV) as Totallitre,SUM(MONTANT_PROV) AS TotalMontant from View_Provision where IMMATRICULATION_VEHICULE = '" + IdCarReport + "' group by IMMATRICULATION_VEHICULE";
                        MyReader = Cmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            ReportParameter[] param = new ReportParameter[3];
                            param[0] = new ReportParameter("pNbrVdge", MyReader["NbrRavitaillement"].ToString());
                            param[1] = new ReportParameter("pTotalLitreRavi", MyReader["Totallitre"].ToString());
                            param[2] = new ReportParameter("pAmountVdge", MyReader["TotalMontant"].ToString());
                            this.reportViewerCar.LocalReport.SetParameters(param);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
