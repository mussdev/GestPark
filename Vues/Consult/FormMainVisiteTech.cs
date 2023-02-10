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
    public partial class FormMainVisiteTech : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataReader MyReader;
        private Guid IdVehiVisitTech;
        private SqlDataAdapter SqlAda;
        private DataSet Ds;
        public FormMainVisiteTech()
        {
            InitializeComponent();
            listVisitTechCar();
        }

        private void iconBtnCloseFormVisit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconBtnCreateVisit_Click(object sender, EventArgs e)
        {
            Form CreateVisit = new FormCreateVisitTechCar();
            CreateVisit.ShowDialog();
        }

        private void iconBtnExportReportCarVist_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // worksheet = workbook.Sheets["Sheets1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "CarDetail";
            // Recuperer les colonnes du DataGridView pour afficher dans la feuille Excel
            for (int i = 1; i < dgvVisitTech.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgvVisitTech.Columns[i - 1].HeaderText;
            }

            // Recuperer les lignes du DataGridView pour les afficher dans la feuille
            for (int i = 0; i < dgvVisitTech.Rows.Count; i++)
            {
                for (int j = 0; j < dgvVisitTech.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvVisitTech.Rows[i].Cells[j].Value?.ToString();
                }
            }
            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "ListeVehiculeVisiteTechnique";
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }

        private void cbxCarVisitTech_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_VEHICULE FROM VEHICULE WHERE IMMATRICULATION_VEHICULE = '" + cbxCarVisitTech.SelectedItem + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdVehiVisitTech = Guid.Parse(MyReader[0].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // List car
        private void listVisitTechCar()
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
                            cbxCarVisitTech.Items.Add(MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            cbxCarVisitTech.DisplayMember = (MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            cbxCarVisitTech.ValueMember = (MyReader["ID_VEHICULE"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxPeriodSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPeriodSearch.SelectedItem.Equals("Personnalisé"))
            {
                dateVisiteTechFrom.Enabled = true;
                dateVisitTechTo.Enabled = true;
            }
        }

        private void dgvVisitTech_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormModifyVisitTech VisitTech = new FormModifyVisitTech();
            VisitTech.txtCodVisitTechMod.Text = dgvVisitTech.CurrentRow.Cells[0].Value.ToString();
            VisitTech.cbxCarVisitTechMod.Text = dgvVisitTech.CurrentRow.Cells[1].Value.ToString();
            VisitTech.txtFraisDossierVisitMod.Text = dgvVisitTech.CurrentRow.Cells[2].Value.ToString();
            VisitTech.txtFraisVignetteMod.Text = dgvVisitTech.CurrentRow.Cells[3].Value.ToString();
            VisitTech.txtFraisGaragiste.Text = dgvVisitTech.CurrentRow.Cells[4].Value.ToString();
            VisitTech.txtEntrepriseMod.Text = dgvVisitTech.CurrentRow.Cells[5].Value.ToString();
            VisitTech.rtxtNote.Text = dgvVisitTech.CurrentRow.Cells[6].Value.ToString();
            VisitTech.dateRegisterVisitTech.Text = dgvVisitTech.CurrentRow.Cells[7].Value.ToString();
            VisitTech.ShowDialog();
        }

        private void iconBtnSearchFormVisit_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT*FROM VISITETECHNIQUE LEFT OUTER JOIN VEHICULE ON VEHICULE.ID_VEHICULE=VISITETECHNIQUE.ID_VEHICULE LEFT OUTER JOIN GARAGE ON GARAGE.ID_GARAGE=VISITETECHNIQUE.ID_GARAGE", Conn.cn);
                        SqlAda = new SqlDataAdapter(SqlCmd);
                        Ds = new DataSet();
                        SqlAda.Fill(Ds);

                        // Fill DataGridView
                        dgvVisitTech.AutoGenerateColumns = false;
                        dgvVisitTech.DataSource = Ds.Tables[0];

                        // Calculer la somme de prise d'assurance
                        SumPriceAssurCar();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SumPriceAssurCar()
        {
            int MontFraisDossier = 0,MontFraisVignette=0,MontGaragiste=0;
            for (int i = 0; i < dgvVisitTech.Rows.Count; ++i)
            {
                MontFraisDossier += Convert.ToInt32(dgvVisitTech.Rows[i].Cells[2].Value);
                MontFraisVignette += Convert.ToInt32(dgvVisitTech.Rows[i].Cells[3].Value);
                MontGaragiste += Convert.ToInt32(dgvVisitTech.Rows[i].Cells[4].Value);
            }

            LblTotalFraisDossier.Text = $"Total frais dossier = {MontFraisDossier.ToString("### ### ### ###")} ";
            LblTotalVignette.Text = $"Total frais vignette = {MontFraisVignette.ToString("### ### ### ###")} ";
            LblTotalGaragiste.Text = $"Total frais garagiste = {MontGaragiste.ToString("### ### ### ###")} ";
            // Calculer le nombre total de véhicule
            LblTotalVisit.Text = $"Nbr. de visite = {dgvVisitTech.RowCount - 1}";
        }
    }
}
