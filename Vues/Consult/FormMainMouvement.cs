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
using GestPark.Vues.Imports;

namespace GestPark
{
    public partial class FormMainMouvement : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataAdapter SqlAda;
        private SqlDataReader MyReader;
        FormImportMouvement formImportMvt = new FormImportMouvement();
        public FormMainMouvement()
        {
            InitializeComponent();

            fillCbxService();
            fillCbxDirection();
            fillCbxVehicule();
        }

        private void IbtnCloseFormMvt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IbtnRegisterMvt_Click(object sender, EventArgs e)
        {
            FormCreateMouvement CreateMouvement = new FormCreateMouvement();
            if (FormConnectionUser.rolesUser.Equals("Gestionnaire") || FormConnectionUser.rolesUser.Equals("Administrateur"))
            {
                CreateMouvement.cbxConducteur.Enabled = true;
                CreateMouvement.CbxVehiculeMvt.Enabled = true;
                CreateMouvement.ShowDialog();
            }
            else
            {
                CreateMouvement.cbxConducteur.Enabled = false;
                CreateMouvement.CbxVehiculeMvt.Enabled = false;
                CreateMouvement.ShowDialog();
            }
        }

        private void IbtnSearchMvt_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                    using (Conn.cn)
                    {
                        if (Conn.IsConnection)
                        {
                            if(string.IsNullOrEmpty(cbxService.Text) && string.IsNullOrEmpty(CbxDirecteur.Text) && string.IsNullOrEmpty(cbxCarMvts.Text) && string.IsNullOrEmpty(TbxSearchMvt.Text) && string.IsNullOrEmpty(cbxPeriodMvt.Text) && string.IsNullOrEmpty(cbxCarMvts.Text) && dateMvtFrom.Enabled==false && dateMvtTo.Enabled==false)
                            {
                                SqlCmd = new SqlCommand("SELECT * FROM MOUVEMENTS AS M LEFT OUTER JOIN VEHICULE AS V ON V.ID_VEHICULE=M.ID_VEHICULE LEFT OUTER JOIN VALIDATIONMOUVEMENTCAR AS VALID ON VALID.ID_VALMVT=M.ID_VALMVT LEFT OUTER JOIN PERSONNELS AS P ON P.ID_PERS=M.ID_PERS LEFT OUTER JOIN SERVICESENT AS S ON S.ID_SERV=P.ID_SERV LEFT OUTER JOIN DIRECTION AS D ON D.ID_DIR=S.ID_DIR", Conn.cn);
                                SqlAda = new SqlDataAdapter(SqlCmd);
                                DataSet Tb = new DataSet();
                                SqlAda.Fill(Tb);

                                // Fill DataGridView
                                DataGridViewMvt.AutoGenerateColumns = false;
                                DataGridViewMvt.DataSource = Tb.Tables[0];
                                TotalMvts.Text = $"Total mouvement = {DataGridViewMvt.RowCount - 1 }";
                            }else if (string.IsNullOrEmpty(cbxService.Text) && string.IsNullOrEmpty(CbxDirecteur.Text) && string.IsNullOrEmpty(cbxCarMvts.Text) && !string.IsNullOrEmpty(TbxSearchMvt.Text) && string.IsNullOrEmpty(cbxPeriodMvt.Text) && string.IsNullOrEmpty(cbxCarMvts.Text) && dateMvtFrom.Enabled == false && dateMvtTo.Enabled == false)
                            {
                                string reqCar = "SELECT * FROM MOUVEMENTS AS M LEFT OUTER JOIN VEHICULE AS V ON V.ID_VEHICULE=M.ID_VEHICULE LEFT OUTER JOIN VALIDATIONMOUVEMENTCAR AS VALID ON VALID.ID_VALMVT=M.ID_VALMVT LEFT OUTER JOIN PERSONNELS AS P ON P.ID_PERS=M.ID_PERS LEFT OUTER JOIN SERVICESENT AS S ON S.ID_SERV=P.ID_SERV LEFT OUTER JOIN DIRECTION AS D ON D.ID_DIR=S.ID_DIR";
                                reqCar += " WHERE V.IMMATRICULATION_VEHICULE LIKE '%' +@param1+ '%' ";
                                reqCar += " OR M.LIEU_MVTS LIKE '%' +@param1+ '%' ";
                                reqCar += " OR M.CONDUCTEUR_MVTS LIKE '%' +@param1+ '%' ";


                                // SqlCmd.Parameters.AddWithValue("param2", textBxSearchVehi.Text);
                                SqlCmd = new SqlCommand(reqCar, Conn.cn);
                                    SqlCmd.Parameters.AddWithValue("param1", TbxSearchMvt.Text);
                                    SqlAda = new SqlDataAdapter(SqlCmd);
                                    DataSet tb = new DataSet();
                                    SqlAda.Fill(tb);

                                // Fill DataGridView
                                    DataGridViewMvt.AutoGenerateColumns = false;
                                    DataGridViewMvt.DataSource = tb.Tables[0];

                             TotalMvts.Text = $"Total mouvement = {DataGridViewMvt.RowCount - 1 }";
                            }else if (string.IsNullOrEmpty(cbxService.Text) && !string.IsNullOrEmpty(CbxDirecteur.Text) && string.IsNullOrEmpty(cbxCarMvts.Text) && string.IsNullOrEmpty(TbxSearchMvt.Text) && string.IsNullOrEmpty(cbxPeriodMvt.Text) && string.IsNullOrEmpty(cbxCarMvts.Text) && dateMvtFrom.Enabled == false && dateMvtTo.Enabled == false)
                            {
                                string reqCar = "SELECT * FROM MOUVEMENTS AS M LEFT OUTER JOIN VEHICULE AS V ON V.ID_VEHICULE=M.ID_VEHICULE LEFT OUTER JOIN VALIDATIONMOUVEMENTCAR AS VALID ON VALID.ID_VALMVT=M.ID_VALMVT LEFT OUTER JOIN PERSONNELS AS P ON P.ID_PERS=M.ID_PERS LEFT OUTER JOIN SERVICESENT AS S ON S.ID_SERV=P.ID_SERV LEFT OUTER JOIN DIRECTION AS D ON D.ID_DIR=S.ID_DIR";
                                //reqCar += " where IMMATRICULATION_VEHICULE LIKE '%' +@param1+ '%' ";
                                reqCar += " WHERE DESCRIPTION_DIR=@param1";
                                //reqCar += " or CONDUCTEUR_MVTS LIKE '%' +@param1+ '%' ";


                                // SqlCmd.Parameters.AddWithValue("param2", textBxSearchVehi.Text);
                                SqlCmd = new SqlCommand(reqCar, Conn.cn);
                                    SqlCmd.Parameters.AddWithValue("param1", CbxDirecteur.Text);
                                    SqlAda = new SqlDataAdapter(SqlCmd);
                                    DataSet tb = new DataSet();
                                    SqlAda.Fill(tb);

                                // Fill DataGridView
                                    DataGridViewMvt.AutoGenerateColumns = false;
                                    DataGridViewMvt.DataSource = tb.Tables[0];

                             TotalMvts.Text = $"Total mouvement = {DataGridViewMvt.RowCount - 1 }";
                            }else if (!string.IsNullOrEmpty(cbxService.Text) && string.IsNullOrEmpty(CbxDirecteur.Text) && string.IsNullOrEmpty(cbxCarMvts.Text) && string.IsNullOrEmpty(TbxSearchMvt.Text) && string.IsNullOrEmpty(cbxPeriodMvt.Text) && string.IsNullOrEmpty(cbxCarMvts.Text) && dateMvtFrom.Enabled == false && dateMvtTo.Enabled == false)
                            {
                                string reqCar = "SELECT * FROM MOUVEMENTS AS M LEFT OUTER JOIN VEHICULE AS V ON V.ID_VEHICULE=M.ID_VEHICULE LEFT OUTER JOIN VALIDATIONMOUVEMENTCAR AS VALID ON VALID.ID_VALMVT=M.ID_VALMVT LEFT OUTER JOIN PERSONNELS AS P ON P.ID_PERS=M.ID_PERS LEFT OUTER JOIN SERVICESENT AS S ON S.ID_SERV=P.ID_SERV LEFT OUTER JOIN DIRECTION AS D ON D.ID_DIR=S.ID_DIR";
                                //reqCar += " where IMMATRICULATION_VEHICULE LIKE '%' +@param1+ '%' ";
                                reqCar += " WHERE S.DESCRIPTION_SERV=@param1 ";
                                //reqCar += " or CONDUCTEUR_MVTS LIKE '%' +@param1+ '%' ";


                                // SqlCmd.Parameters.AddWithValue("param2", textBxSearchVehi.Text);
                                SqlCmd = new SqlCommand(reqCar, Conn.cn);
                                    SqlCmd.Parameters.AddWithValue("param1", cbxService.Text);
                                    SqlAda = new SqlDataAdapter(SqlCmd);
                                    DataSet tb = new DataSet();
                                    SqlAda.Fill(tb);

                                // Fill DataGridView
                                    DataGridViewMvt.AutoGenerateColumns = false;
                                    DataGridViewMvt.DataSource = tb.Tables[0];

                             TotalMvts.Text = $"Total mouvement = {DataGridViewMvt.RowCount - 1 }";
                            }else if (!string.IsNullOrEmpty(cbxService.Text) && string.IsNullOrEmpty(CbxDirecteur.Text) && string.IsNullOrEmpty(cbxCarMvts.Text) && string.IsNullOrEmpty(TbxSearchMvt.Text) && string.IsNullOrEmpty(cbxPeriodMvt.Text) && string.IsNullOrEmpty(cbxCarMvts.Text) && dateMvtFrom.Enabled == false && dateMvtTo.Enabled == false)
                            {
                                string reqCar = "SELECT * FROM MOUVEMENTS AS M LEFT OUTER JOIN VEHICULE AS V ON V.ID_VEHICULE=M.ID_VEHICULE LEFT OUTER JOIN VALIDATIONMOUVEMENTCAR AS VALID ON VALID.ID_VALMVT=M.ID_VALMVT LEFT OUTER JOIN PERSONNELS AS P ON P.ID_PERS=M.ID_PERS LEFT OUTER JOIN SERVICESENT AS S ON S.ID_SERV=P.ID_SERV LEFT OUTER JOIN DIRECTION AS D ON D.ID_DIR=S.ID_DIR";
                                //reqCar += " where IMMATRICULATION_VEHICULE LIKE '%' +@param1+ '%' ";
                                reqCar += " WHERE S.DESCRIPTION_SERV=@param1 ";
                                //reqCar += " or CONDUCTEUR_MVTS LIKE '%' +@param1+ '%' ";


                                // SqlCmd.Parameters.AddWithValue("param2", textBxSearchVehi.Text);
                                SqlCmd = new SqlCommand(reqCar, Conn.cn);
                                    SqlCmd.Parameters.AddWithValue("param1", cbxService.Text);
                                    SqlAda = new SqlDataAdapter(SqlCmd);
                                    DataSet tb = new DataSet();
                                    SqlAda.Fill(tb);

                                // Fill DataGridView
                                    DataGridViewMvt.AutoGenerateColumns = false;
                                    DataGridViewMvt.DataSource = tb.Tables[0];

                             TotalMvts.Text = $"Total mouvement = {DataGridViewMvt.RowCount - 1 }";
                            }
                            else if (!string.IsNullOrEmpty(cbxCarMvts.Text) && string.IsNullOrEmpty(cbxService.Text) && string.IsNullOrEmpty(CbxDirecteur.Text) && string.IsNullOrEmpty(TbxSearchMvt.Text) && string.IsNullOrEmpty(cbxPeriodMvt.Text) && string.IsNullOrEmpty(cbxCarMvts.Text) && dateMvtFrom.Enabled == false && dateMvtTo.Enabled == false)
                            {
                                string reqCar = "SELECT * FROM MOUVEMENTS AS M LEFT OUTER JOIN VEHICULE AS V ON V.ID_VEHICULE=M.ID_VEHICULE LEFT OUTER JOIN VALIDATIONMOUVEMENTCAR AS VALID ON VALID.ID_VALMVT=M.ID_VALMVT LEFT OUTER JOIN PERSONNELS AS P ON P.ID_PERS=M.ID_PERS LEFT OUTER JOIN SERVICESENT AS S ON S.ID_SERV=P.ID_SERV LEFT OUTER JOIN DIRECTION AS D ON D.ID_DIR=S.ID_DIR";
                                //reqCar += " where IMMATRICULATION_VEHICULE LIKE '%' +@param1+ '%' ";
                                reqCar += " WHERE V.IMMATRICULATION_VEHICULE=@param1 ";
                                //reqCar += " or CONDUCTEUR_MVTS LIKE '%' +@param1+ '%' ";


                                // SqlCmd.Parameters.AddWithValue("param2", textBxSearchVehi.Text);
                                SqlCmd = new SqlCommand(reqCar, Conn.cn);
                                SqlCmd.Parameters.AddWithValue("param1", cbxCarMvts.Text);
                                SqlAda = new SqlDataAdapter(SqlCmd);
                                DataSet tb = new DataSet();
                                SqlAda.Fill(tb);

                                // Fill DataGridView
                                DataGridViewMvt.AutoGenerateColumns = false;
                                DataGridViewMvt.DataSource = tb.Tables[0];

                                TotalMvts.Text = $"Total mouvement = {DataGridViewMvt.RowCount - 1}";
                            }
                            else if (string.IsNullOrEmpty(cbxService.Text) && string.IsNullOrEmpty(CbxDirecteur.Text) && string.IsNullOrEmpty(TbxSearchMvt.Text) && string.IsNullOrEmpty(cbxCarMvts.Text) && dateMvtFrom.Enabled == false && dateMvtTo.Enabled == false && cbxPeriodMvt.Text.Equals("Aujourd'hui"))
                            {
                                string reqCar = "SELECT * FROM MOUVEMENTS AS M LEFT OUTER JOIN VEHICULE AS V ON V.ID_VEHICULE=M.ID_VEHICULE LEFT OUTER JOIN VALIDATIONMOUVEMENTCAR AS VALID ON VALID.ID_VALMVT=M.ID_VALMVT LEFT OUTER JOIN PERSONNELS AS P ON P.ID_PERS=M.ID_PERS LEFT OUTER JOIN SERVICESENT AS S ON S.ID_SERV=P.ID_SERV LEFT OUTER JOIN DIRECTION AS D ON D.ID_DIR=S.ID_DIR";
                                //reqCar += " where IMMATRICULATION_VEHICULE LIKE '%' +@param1+ '%' ";
                                reqCar += " WHERE M.DATEEXECUTION=@param1 ";
                                //reqCar += " or CONDUCTEUR_MVTS LIKE '%' +@param1+ '%' ";


                                // SqlCmd.Parameters.AddWithValue("param2", textBxSearchVehi.Text);
                                SqlCmd = new SqlCommand(reqCar, Conn.cn);
                                SqlCmd.Parameters.AddWithValue("param1", DateTime.Now.ToString("dd/MM/yyyy"));
                                SqlAda = new SqlDataAdapter(SqlCmd);
                                DataSet tb = new DataSet();
                                SqlAda.Fill(tb);

                                // Fill DataGridView
                                    DataGridViewMvt.AutoGenerateColumns = false;
                                    DataGridViewMvt.DataSource = tb.Tables[0];

                             TotalMvts.Text = $"Total mouvement = {DataGridViewMvt.RowCount - 1 }";
                            }else if (string.IsNullOrEmpty(cbxService.Text) && string.IsNullOrEmpty(CbxDirecteur.Text) && string.IsNullOrEmpty(cbxCarMvts.Text) && string.IsNullOrEmpty(TbxSearchMvt.Text) && string.IsNullOrEmpty(cbxCarMvts.Text) && dateMvtFrom.Enabled == false && dateMvtTo.Enabled == false && cbxPeriodMvt.Text.Equals("Mois en cours"))
                            {
                                var now = DateTime.Now;
                                var startOfMonth = new DateTime(now.Year, now.Month, 1);
                                var DaysInMonth = DateTime.DaysInMonth(now.Year, now.Month);
                                var lastDay = new DateTime(now.Year, now.Month, DaysInMonth);

                                SqlCmd = new SqlCommand("SELECT * FROM MOUVEMENTS AS M LEFT OUTER JOIN VEHICULE AS V ON V.ID_VEHICULE=M.ID_VEHICULE LEFT OUTER JOIN VALIDATIONMOUVEMENTCAR AS VALID ON VALID.ID_VALMVT=M.ID_VALMVT LEFT OUTER JOIN PERSONNELS AS P ON P.ID_PERS=M.ID_PERS LEFT OUTER JOIN SERVICESENT AS S ON S.ID_SERV=P.ID_SERV LEFT OUTER JOIN DIRECTION AS D ON D.ID_DIR=S.ID_DIR WHERE M.DATEEXECUTION BETWEEN '" + startOfMonth.ToString("dd/MM/yyyy")+ "' and '"+ lastDay.ToString("dd/MM/yyyy")+"' ", Conn.cn);
                                SqlAda = new SqlDataAdapter(SqlCmd);
                                DataSet Tb = new DataSet();
                                SqlAda.Fill(Tb);

                                // Fill DataGridView
                                DataGridViewMvt.AutoGenerateColumns = false;
                                DataGridViewMvt.DataSource = Tb.Tables[0];
                                TotalMvts.Text = $"Total mouvement = {DataGridViewMvt.RowCount - 1 }";
                            }
                            else if (string.IsNullOrEmpty(cbxService.Text) && string.IsNullOrEmpty(CbxDirecteur.Text) && string.IsNullOrEmpty(cbxCarMvts.Text) && string.IsNullOrEmpty(TbxSearchMvt.Text) && string.IsNullOrEmpty(cbxCarMvts.Text) && dateMvtFrom.Enabled == false && dateMvtTo.Enabled == false && cbxPeriodMvt.Text.Equals("Mois précédent"))
                            {
                                var now = DateTime.Now;
                                var startOfMonth = new DateTime(now.Year, now.Month, 1);
                                var DaysInMonth = DateTime.DaysInMonth(now.Year, now.Month);
                                var lastDay = new DateTime(now.Year, now.Month, DaysInMonth);
                                var startOfMonthPrevious = startOfMonth.AddMonths(-1);
                                var DaysInMonthPrevious = DateTime.DaysInMonth(now.Year, startOfMonthPrevious.Month);
                                var lastOfMonthPrevious = new DateTime(now.Year, startOfMonthPrevious.Month, DaysInMonthPrevious);

                                SqlCmd = new SqlCommand("SELECT * FROM MOUVEMENTS AS M LEFT OUTER JOIN VEHICULE AS V ON V.ID_VEHICULE=M.ID_VEHICULE LEFT OUTER JOIN VALIDATIONMOUVEMENTCAR AS VALID ON VALID.ID_VALMVT=M.ID_VALMVT LEFT OUTER JOIN PERSONNELS AS P ON P.ID_PERS=M.ID_PERS LEFT OUTER JOIN SERVICESENT AS S ON S.ID_SERV=P.ID_SERV LEFT OUTER JOIN DIRECTION AS D ON D.ID_DIR=S.ID_DIR WHERE M.DATEEXECUTION BETWEEN '" + startOfMonthPrevious.ToString("dd/MM/yyyy") + "' AND '" + lastOfMonthPrevious.ToString("dd/MM/yyyy") + "' ", Conn.cn);
                                SqlAda = new SqlDataAdapter(SqlCmd);
                                DataSet Tb = new DataSet();
                                SqlAda.Fill(Tb);

                                // Fill DataGridView
                                DataGridViewMvt.AutoGenerateColumns = false;
                                DataGridViewMvt.DataSource = Tb.Tables[0];
                                TotalMvts.Text = $"Total mouvement = {DataGridViewMvt.RowCount - 1}";
                            }
                            else if (string.IsNullOrEmpty(cbxService.Text) && string.IsNullOrEmpty(CbxDirecteur.Text) && string.IsNullOrEmpty(cbxCarMvts.Text) && string.IsNullOrEmpty(TbxSearchMvt.Text) && string.IsNullOrEmpty(cbxCarMvts.Text) && dateMvtFrom.Enabled == false && dateMvtTo.Enabled == false && cbxPeriodMvt.Text.Equals("Année en cours"))
                            {
                                var now = DateTime.Now;
                                int year = DateTime.Now.Year;
                                DateTime firstDay = new DateTime(year, 1, 1);
                                DateTime lastDay = new DateTime(year, 12, 31);

                                SqlCmd = new SqlCommand("SELECT * FROM MOUVEMENTS AS M LEFT OUTER JOIN VEHICULE AS V ON V.ID_VEHICULE=M.ID_VEHICULE LEFT OUTER JOIN VALIDATIONMOUVEMENTCAR AS VALID ON VALID.ID_VALMVT=M.ID_VALMVT LEFT OUTER JOIN PERSONNELS AS P ON P.ID_PERS=M.ID_PERS LEFT OUTER JOIN SERVICESENT AS S ON S.ID_SERV=P.ID_SERV LEFT OUTER JOIN DIRECTION AS D ON D.ID_DIR=S.ID_DIR WHERE M.DATEEXECUTION BETWEEN '" + firstDay.ToString("dd/MM/yyyy") + "' AND '" + lastDay.ToString("dd/MM/yyyy") + "' ", Conn.cn);
                                SqlAda = new SqlDataAdapter(SqlCmd);
                                DataSet Tb = new DataSet();
                                SqlAda.Fill(Tb);

                                // Fill DataGridView
                                DataGridViewMvt.AutoGenerateColumns = false;
                                DataGridViewMvt.DataSource = Tb.Tables[0];
                                TotalMvts.Text = $"Total mouvement = {DataGridViewMvt.RowCount - 1}";
                            }
                            else if (string.IsNullOrEmpty(cbxService.Text) && string.IsNullOrEmpty(CbxDirecteur.Text) && string.IsNullOrEmpty(cbxCarMvts.Text) && string.IsNullOrEmpty(TbxSearchMvt.Text) && string.IsNullOrEmpty(cbxCarMvts.Text) && dateMvtFrom.Enabled == false && dateMvtTo.Enabled == false && cbxPeriodMvt.Text.Equals("Année précédente"))
                            {
                                DateTime lastYearToDate = DateTime.Now.AddYears(-1);
                                int year = lastYearToDate.Year;
                                DateTime firstDay = new DateTime(year, 1, 1);
                                DateTime lastDay = new DateTime(year, 12, 31);

                                SqlCmd = new SqlCommand("SELECT * FROM MOUVEMENTS AS M LEFT OUTER JOIN VEHICULE AS V ON V.ID_VEHICULE=M.ID_VEHICULE LEFT OUTER JOIN VALIDATIONMOUVEMENTCAR AS VALID ON VALID.ID_VALMVT=M.ID_VALMVT LEFT OUTER JOIN PERSONNELS AS P ON P.ID_PERS=M.ID_PERS LEFT OUTER JOIN SERVICESENT AS S ON S.ID_SERV=P.ID_SERV LEFT OUTER JOIN DIRECTION AS D ON D.ID_DIR=S.ID_DIR WHERE M.DATEEXECUTION BETWEEN '" + firstDay.ToString("dd/MM/yyyy") + "' AND '" + lastDay.ToString("dd/MM/yyyy") + "' ", Conn.cn);
                                SqlAda = new SqlDataAdapter(SqlCmd);
                                DataSet Tb = new DataSet();
                                SqlAda.Fill(Tb);

                                // Fill DataGridView
                                DataGridViewMvt.AutoGenerateColumns = false;
                                DataGridViewMvt.DataSource = Tb.Tables[0];
                                TotalMvts.Text = $"Total mouvement = {DataGridViewMvt.RowCount - 1}";
                            }
                            else if (string.IsNullOrEmpty(cbxService.Text) && string.IsNullOrEmpty(CbxDirecteur.Text) && string.IsNullOrEmpty(TbxSearchMvt.Text) && string.IsNullOrEmpty(cbxCarMvts.Text) && dateMvtFrom.Enabled == true && dateMvtTo.Enabled == true && cbxPeriodMvt.Text.Equals("Personnalisée"))
                            {
                                SqlCmd = new SqlCommand("SELECT * FROM MOUVEMENTS AS M LEFT OUTER JOIN VEHICULE AS V ON V.ID_VEHICULE=M.ID_VEHICULE LEFT OUTER JOIN VALIDATIONMOUVEMENTCAR AS VALID ON VALID.ID_VALMVT=M.ID_VALMVT LEFT OUTER JOIN PERSONNELS AS P ON P.ID_PERS=M.ID_PERS LEFT OUTER JOIN SERVICESENT AS S ON S.ID_SERV=P.ID_SERV LEFT OUTER JOIN DIRECTION AS D ON D.ID_DIR=S.ID_DIR WHERE DATEEXECUTION BETWEEN '" + dateMvtFrom.Value.ToString("dd/MM/yyyy") + "' AND '" + dateMvtTo.Value.ToString("dd/MM/yyyy") + "' ", Conn.cn);
                                SqlAda = new SqlDataAdapter(SqlCmd);
                                DataSet Tb = new DataSet();
                                SqlAda.Fill(Tb);

                                // Fill DataGridView
                                DataGridViewMvt.AutoGenerateColumns = false;
                                DataGridViewMvt.DataSource = Tb.Tables[0];
                                TotalMvts.Text = $"Total mouvement = {DataGridViewMvt.RowCount - 1}";
                            }

                        }
                    }
               // }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayMvt()
        {
            FormModifyMouvement FormModif = new FormModifyMouvement();
            DataGridViewCheckBoxCell checkingVerrous = this.DataGridViewMvt.CurrentRow.Cells[18] as DataGridViewCheckBoxCell;
            
            if ((FormConnectionUser.rolesUser.Equals("Gestionnaire") || FormConnectionUser.rolesUser.Equals("Administrateur")) && Convert.ToBoolean(checkingVerrous.Value) == true)
            {
                //MessageBox.Show("Test niveau 1");
                FormModif.txtValMvtMod.Text = this.DataGridViewMvt.CurrentRow.Cells[0].Value?.ToString();
                FormModif.DateExecutionMod.Text = this.DataGridViewMvt.CurrentRow.Cells[1].Value?.ToString();
                FormModif.DateDepartSouhMvtMod.Text = this.DataGridViewMvt.CurrentRow.Cells[2].Value?.ToString();
                FormModif.DateRetouProbMvtMod.Text = this.DataGridViewMvt.CurrentRow.Cells[3].Value?.ToString();
                FormModif.DateRetouReelMod.Text = this.DataGridViewMvt.CurrentRow.Cells[4].Value?.ToString();
                FormModif.TimeStartMvtModi.Text = this.DataGridViewMvt.CurrentRow.Cells[5].Value?.ToString();
                FormModif.TimeEndMvtModi.Text = this.DataGridViewMvt.CurrentRow.Cells[6].Value?.ToString();
                FormModif.CbxVehiculeMod.Text = this.DataGridViewMvt.CurrentRow.Cells[7].Value?.ToString();
                FormModif.CbxLieuMvtsMod.Text = this.DataGridViewMvt.CurrentRow.Cells[8].Value?.ToString();
                FormModif.CbxDemandeurMvtMod.Text = this.DataGridViewMvt.CurrentRow.Cells[9].Value?.ToString();
                FormModif.TxtServiceMvtMod.Text = this.DataGridViewMvt.CurrentRow.Cells[10].Value?.ToString();
                FormModif.TxtDirMvtMod.Text = this.DataGridViewMvt.CurrentRow.Cells[11].Value?.ToString();
                FormModif.cbxConducteurMod.Text = this.DataGridViewMvt.CurrentRow.Cells[12].Value?.ToString();
                FormModif.RtbxNoteMvtMod.Text = this.DataGridViewMvt.CurrentRow.Cells[13].Value?.ToString();
                FormModif.TbxCodMvtMod.Text = this.DataGridViewMvt.CurrentRow.Cells[14].Value?.ToString();
                FormModif.CbxStatutMvtMod.Text = this.DataGridViewMvt.CurrentRow.Cells[15].Value?.ToString();
                FormModif.cbxConducteurMod.Enabled = true;
                FormModif.CbxVehiculeMod.Enabled = true;
                FormModif.ShowDialog();
                //if (verrousFormMvt == 1)
                //{
                //    FormModif.Enabled = true;
                   
                //}
                
            }else if ((!FormConnectionUser.rolesUser.Equals("Gestionnaire") || !FormConnectionUser.rolesUser.Equals("Administrateur")) && Convert.ToBoolean(checkingVerrous.Value) == true)
            {
                // Recupérer les données dans le formulaire
                FormModif.txtValMvtMod.Text = this.DataGridViewMvt.CurrentRow.Cells[0].Value?.ToString();
                FormModif.DateExecutionMod.Text = this.DataGridViewMvt.CurrentRow.Cells[1].Value?.ToString();
                FormModif.DateDepartSouhMvtMod.Text = this.DataGridViewMvt.CurrentRow.Cells[2].Value?.ToString();
                FormModif.DateRetouProbMvtMod.Text = this.DataGridViewMvt.CurrentRow.Cells[3].Value?.ToString();
                FormModif.DateRetouReelMod.Text = this.DataGridViewMvt.CurrentRow.Cells[4].Value?.ToString();
                FormModif.TimeStartMvtModi.Text = this.DataGridViewMvt.CurrentRow.Cells[5].Value?.ToString();
                FormModif.TimeEndMvtModi.Text = this.DataGridViewMvt.CurrentRow.Cells[6].Value?.ToString();
                FormModif.CbxVehiculeMod.Text = this.DataGridViewMvt.CurrentRow.Cells[7].Value?.ToString();
                FormModif.CbxLieuMvtsMod.Text = this.DataGridViewMvt.CurrentRow.Cells[8].Value?.ToString();
                FormModif.CbxDemandeurMvtMod.Text = this.DataGridViewMvt.CurrentRow.Cells[9].Value?.ToString();
                FormModif.TxtServiceMvtMod.Text = this.DataGridViewMvt.CurrentRow.Cells[10].Value?.ToString();
                FormModif.TxtDirMvtMod.Text = this.DataGridViewMvt.CurrentRow.Cells[11].Value?.ToString();
                FormModif.cbxConducteurMod.Text = this.DataGridViewMvt.CurrentRow.Cells[12].Value?.ToString();
                FormModif.RtbxNoteMvtMod.Text = this.DataGridViewMvt.CurrentRow.Cells[13].Value?.ToString();
                FormModif.TbxCodMvtMod.Text = this.DataGridViewMvt.CurrentRow.Cells[14].Value?.ToString();
                FormModif.CbxStatutMvtMod.Text = this.DataGridViewMvt.CurrentRow.Cells[15].Value?.ToString();
                
                // Mettre le formulaire en mode lecture
                FormModif.cbxConducteurMod.Enabled = false;
                FormModif.CbxVehiculeMod.Enabled = false;
                FormModif.txtValMvtMod.Enabled = false;
                FormModif.TxtDirMvtMod.Enabled = false;
                FormModif.TxtServiceMvtMod.Enabled = false;
                FormModif.CbxDemandeurMvtMod.Enabled=false;
                FormModif.CbxLieuMvtsMod.Enabled = false;
                FormModif.CbxStatutMvtMod.Enabled= false;
                FormModif.TimeEndMvtModi.Enabled = false;
                FormModif.TimeStartMvtModi.Enabled=false;
                FormModif.DateDepartSouhMvtMod.Enabled = false;
                FormModif.DateRetouProbMvtMod.Enabled = false;
                FormModif.DateRetouReelMod.Enabled = false;
                FormModif.DateExecutionMod.Enabled = false;
                FormModif.btnChoiceStatutCarMod.Enabled = false;
                FormModif.RtbxNoteMvtMod.Enabled = false;
                
                FormModif.ShowDialog();
                
            }
            else
            {
                FormModif.txtValMvtMod.Text = this.DataGridViewMvt.CurrentRow.Cells[0].Value?.ToString();
                FormModif.DateExecutionMod.Text = this.DataGridViewMvt.CurrentRow.Cells[1].Value?.ToString();
                FormModif.DateDepartSouhMvtMod.Text = this.DataGridViewMvt.CurrentRow.Cells[2].Value?.ToString();
                FormModif.DateRetouProbMvtMod.Text = this.DataGridViewMvt.CurrentRow.Cells[3].Value?.ToString();
                FormModif.DateRetouReelMod.Text = this.DataGridViewMvt.CurrentRow.Cells[4].Value?.ToString();
                FormModif.TimeStartMvtModi.Text = this.DataGridViewMvt.CurrentRow.Cells[5].Value?.ToString();
                FormModif.TimeEndMvtModi.Text = this.DataGridViewMvt.CurrentRow.Cells[6].Value?.ToString();
                FormModif.CbxVehiculeMod.Text = this.DataGridViewMvt.CurrentRow.Cells[7].Value?.ToString();
                FormModif.CbxLieuMvtsMod.Text = this.DataGridViewMvt.CurrentRow.Cells[8].Value?.ToString();
                FormModif.CbxDemandeurMvtMod.Text = this.DataGridViewMvt.CurrentRow.Cells[9].Value?.ToString();
                FormModif.TxtServiceMvtMod.Text = this.DataGridViewMvt.CurrentRow.Cells[10].Value?.ToString();
                FormModif.TxtDirMvtMod.Text = this.DataGridViewMvt.CurrentRow.Cells[11].Value?.ToString();
                FormModif.cbxConducteurMod.Text = this.DataGridViewMvt.CurrentRow.Cells[12].Value?.ToString();
                FormModif.RtbxNoteMvtMod.Text = this.DataGridViewMvt.CurrentRow.Cells[13].Value?.ToString();
                FormModif.TbxCodMvtMod.Text = this.DataGridViewMvt.CurrentRow.Cells[14].Value?.ToString();
                FormModif.CbxStatutMvtMod.Text = this.DataGridViewMvt.CurrentRow.Cells[15].Value?.ToString();
                FormModif.cbxConducteurMod.Enabled = false;
                FormModif.CbxVehiculeMod.Enabled = false;
                FormModif.ShowDialog();
                
            }
        }

        private void DataGridViewMvt_DoubleClick(object sender, EventArgs e)
        {
            DisplayMvt();
        }

        private void SaisirMvts_Click(object sender, EventArgs e)
        {
            Form CreateMvts = new FormCreateMouvement();
            CreateMvts.ShowDialog();
        }

        private void OpenMvts_Click(object sender, EventArgs e)
        {
            DisplayMvt();
        }

        private void ModifierMvts_Click(object sender, EventArgs e)
        {
            DisplayMvt();
        }

        private int rowIndex = 0;
        private void DataGridViewMvt_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.DataGridViewMvt.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.DataGridViewMvt.CurrentCell = this.DataGridViewMvt.Rows[e.RowIndex].Cells[1];
                this.MenuContextMouvement.Show(this.DataGridViewMvt, e.Location);
                MenuContextMouvement.Show(Cursor.Position);
            }
        }

        // Direction
        private void fillCbxDirection()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_DIR,DESCRIPTION_DIR FROM DIRECTION", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            CbxDirecteur.Items.Add(MyReader["DESCRIPTION_DIR"].ToString());
                            CbxDirecteur.DisplayMember = (MyReader["DESCRIPTION_DIR"].ToString());
                            CbxDirecteur.ValueMember = (MyReader["ID_DIR"].ToString());
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Service
        private void fillCbxService()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_SERV,DESCRIPTION_SERV FROM SERVICESENT", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            cbxService.Items.Add(MyReader["DESCRIPTION_SERV"].ToString());
                            cbxService.DisplayMember = (MyReader["DESCRIPTION_SERV"].ToString());
                            cbxService.ValueMember = (MyReader["ID_SERV"].ToString());
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IbtnExportMvt_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // worksheet = workbook.Sheets["Sheets1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "CarDetail";
            // Recuperer les colonnes du DataGridView pour afficher dans la feuille Excel
            for (int i = 1; i < DataGridViewMvt.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = DataGridViewMvt.Columns[i - 1].HeaderText;
            }

            // Recuperer les lignes du DataGridView pour les afficher dans la feuille
            for (int i = 0; i < DataGridViewMvt.Rows.Count; i++)
            {
                for (int j = 0; j < DataGridViewMvt.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = DataGridViewMvt.Rows[i].Cells[j].Value?.ToString();
                }
            }
            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "ListeMouvementVehicule";
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }

        private void cbxPeriodMvt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPeriodMvt.Text.Equals("Personnalisée"))
            {
                dateMvtFrom.Enabled = true;
                dateMvtTo.Enabled = true;
            }
            else
            {
                dateMvtFrom.Enabled = false;
                dateMvtTo.Enabled = false;
            }
        }

        // Direction
        private void fillCbxVehicule()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    cbxCarMvts.DisplayMember = "Value";
                    cbxCarMvts.ValueMember = "Key";

                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_VEHICULE,IMMATRICULATION_VEHICULE FROM VEHICULE WHERE TYPE_VEHICULE='Pool'", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            cbxCarMvts.Items.Add(new KeyValuePair<Guid, string>((Guid)MyReader["ID_VEHICULE"], MyReader["IMMATRICULATION_VEHICULE"].ToString()));
                            //cbxCarMvts.Text = MyReader["DESCRIPTION_VALMVT"].ToString();
                            //MessageBox.Show("Valeur : " + createMouvement.cbxValidationMvt.Text);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /**
         * Methode qui veroulle la fenête lorsque le gestionnnaire du parc automobile à valider
         */

        //private void DesableFormMouvement(FormModifyMouvement formModifyCar)
        //{
        //    formModifyCar.Enabled = false;
        //}

        private void txtFilterMvt_TextChanged(object sender, EventArgs e)
        {
            (DataGridViewMvt.DataSource as DataTable).DefaultView.RowFilter = "IMMATRICULATION_VEHICULE LIKE '%" + txtFilterMvt.Text + "%' ";
        }

        private void btnImportMvt_Click(object sender, EventArgs e)
        {
            formImportMvt.ShowDialog();
        }
    }
}
