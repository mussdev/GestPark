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
    public partial class FormMainGarage : Form
    {
        private SqlCommand sqlCmd;
        private SqlDataAdapter sqlAda;
        private DataSet ds;
        public FormMainGarage()
        {
            InitializeComponent();
            DisplayGarage();
        }

        private void IcBtnCloseFormGarage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IbtnRegisterGarage_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (string.IsNullOrEmpty(TbxDescriptionGar.Text))
                {
                    MessageBox.Show("Veiller saisir le garage !");
                }
                else if (string.IsNullOrEmpty(TbxProprioGar.Text))
                {
                    MessageBox.Show("Veiller saisir le champ propriétaire !");
                }
                else if (string.IsNullOrEmpty(TbxTelGar.Text))
                {
                    MessageBox.Show("Veiller saisir le contact !");
                }
                else
                {
                    if (string.IsNullOrEmpty(txtIdGarage.Text))
                    {
                        // Generate code to person
                        string codeGarage = generateCodeGarage();

                        DialogResult result = MessageBox.Show("Voulez vous enregister ?", "Fleet: Questions", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            using (Conn.cn)
                            {
                                if (Conn.IsConnection)
                                {
                                    // Request to insert data in table personnels
                                    sqlCmd = new SqlCommand("INSERT INTO GARAGE (CODE_GARAGE,DESCRIPTION_GARAGE,PROPRIETAIRE_GARAGE,TEL_GARAGE,OBSERVATIONS_GARAGE,DATECREATE_GARAGE) VALUES (@CODE_GARAGE,@DESCRIPTION_GARAGE,@PROPRIETAIRE_GARAGE,@TEL_GARAGE,@OBSERVATIONS_GARAGE, GETDATE()); ", Conn.cn);
                                    sqlCmd.Parameters.AddWithValue("@CODE_GARAGE", codeGarage);
                                    sqlCmd.Parameters.AddWithValue("@DESCRIPTION_GARAGE", TbxDescriptionGar.Text);
                                    sqlCmd.Parameters.AddWithValue("@PROPRIETAIRE_GARAGE", TbxProprioGar.Text);
                                    sqlCmd.Parameters.AddWithValue("@TEL_GARAGE", TbxTelGar.Text);
                                    sqlCmd.Parameters.AddWithValue("@OBSERVATIONS_GARAGE", RichTextBoxNoteGar.Text);
                                    sqlCmd.ExecuteNonQuery();
                                   
                                    // Display data in datagridview
                                    sqlAda = new SqlDataAdapter("select*from garage order by CODE_GARAGE desc", Conn.cn);
                                    DataTable dt = new DataTable();
                                    sqlAda.Fill(dt);
                                    dataGridViewGarage.AutoGenerateColumns = false;
                                    dataGridViewGarage.DataSource = dt;

                                    // Nombre de service 
                                    lblTotalGarage.Text = $"Total Garage = {dataGridViewGarage.RowCount - 1}";

                                    // Clear the fields provider of car
                                    TbxGarCode.Clear(); TbxDescriptionGar.Clear(); TbxProprioGar.Clear(); TbxTelGar.Clear(); RichTextBoxNoteGar.Clear();
                                    MessageBox.Show("Garage enregistré avec succès", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    else
                        MessageBox.Show("Ce garage existe déja ! Veillez vider les champs et saisir un nouveau garage !","Avertissement",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Generate code of personne
        private string generateCodeGarage()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        // Generate code garage
                        sqlCmd = new SqlCommand("SELECT CODE_GARAGE FROM GARAGE WHERE CODE_GARAGE=(SELECT MAX(CODE_GARAGE) FROM GARAGE)", Conn.cn);
                        sqlAda = new SqlDataAdapter(sqlCmd);
                        ds = new DataSet();
                        sqlAda.Fill(ds);

                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            TbxGarCode.Text = ds.Tables[0].Rows[0]["CODE_GARAGE"].ToString();
                        }
                        else
                        {
                            TbxGarCode.Text = "GAR0000";
                        }
                        if (!string.IsNullOrEmpty(TbxGarCode.Text))
                        {
                            TbxGarCode.SelectionStart = 3;
                            TbxGarCode.SelectionLength = 4;
                            TbxGarCode.Text = TbxGarCode.SelectedText;
                        }
                        if (!string.IsNullOrEmpty(TbxGarCode.Text))
                        {
                            int codePers = int.Parse(TbxGarCode.Text.ToString()) + 1;
                            TbxGarCode.Text = codePers.ToString("GAR0000");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return TbxGarCode.Text;
        }

        // Display garage
        private void DisplayGarage()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        sqlAda = new SqlDataAdapter("SELECT * FROM GARAGE", Conn.cn);
                        DataTable dt = new DataTable();
                        sqlAda.Fill(dt);
                        dataGridViewGarage.AutoGenerateColumns = false;
                        dataGridViewGarage.DataSource = dt;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IbtnAnnulerGarage_Click(object sender, EventArgs e)
        {
            TbxGarCode.Clear(); TbxDescriptionGar.Clear(); TbxProprioGar.Clear(); TbxTelGar.Clear(); RichTextBoxNoteGar.Clear(); txtIdGarage.Clear();
        }

        private void dataGridViewGarage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow dgvGarage = dataGridViewGarage.Rows[e.RowIndex];
                txtIdGarage.Text = dgvGarage.Cells[0].Value.ToString();
                TbxGarCode.Text = dgvGarage.Cells[1].Value.ToString();
                TbxDescriptionGar.Text = dgvGarage.Cells[2].Value.ToString();
                TbxProprioGar.Text = dgvGarage.Cells[3].Value.ToString();
                TbxTelGar.Text = dgvGarage.Cells[4].Value.ToString();
                RichTextBoxNoteGar.Text = dgvGarage.Cells[5].Value.ToString();
            }
        }

        private void btnEditGar_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if(!string.IsNullOrEmpty(TbxGarCode.Text) && !string.IsNullOrEmpty(TbxDescriptionGar.Text) && !string.IsNullOrEmpty(TbxProprioGar.Text))
                {
                    DialogResult result = MessageBox.Show("Voulez vous enregister les modifications ?", "Fleet", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        using (Conn.cn)
                        {
                            if (Conn.IsConnection)
                            {
                                // Request to insert data in table personnels
                                sqlCmd = new SqlCommand("UPDATE GARAGE SET DESCRIPTION_GARAGE=@DESCRIPTION_GARAGE,PROPRIETAIRE_GARAGE=@PROPRIETAIRE_GARAGE,TEL_GARAGE=@TEL_GARAGE,OBSERVATIONS_GARAGE=@OBSERVATIONS_GARAGE WHERE CODE_GARAGE='" + TbxGarCode.Text + "'; ", Conn.cn);
                                sqlCmd.Parameters.AddWithValue("@DESCRIPTION_GARAGE", TbxDescriptionGar.Text);
                                sqlCmd.Parameters.AddWithValue("@PROPRIETAIRE_GARAGE", TbxProprioGar.Text);
                                sqlCmd.Parameters.AddWithValue("@TEL_GARAGE", TbxTelGar.Text);
                                sqlCmd.Parameters.AddWithValue("@OBSERVATIONS_GARAGE", RichTextBoxNoteGar.Text);
                                sqlCmd.ExecuteNonQuery();
                                MessageBox.Show("Modification prise compte !", "Modification de données", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Display data in datagridview
                                sqlAda = new SqlDataAdapter("select*from garage order by CODE_GARAGE desc", Conn.cn);
                                DataTable dt = new DataTable();
                                sqlAda.Fill(dt);
                                dataGridViewGarage.AutoGenerateColumns = false;
                                dataGridViewGarage.DataSource = dt;
                                // Clear the fields provider of car
                                TbxGarCode.Clear(); TbxDescriptionGar.Clear(); TbxProprioGar.Clear(); TbxTelGar.Clear(); RichTextBoxNoteGar.Clear();
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK,MessageBoxIcon.Error); ;
            }
        }



        private void deleteGarage_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("Voulez vous supprimer ce garage ?"), "Fleet: Confirmation", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                    ConnectDB Conn = new ConnectDB(connectionString);
                    using (Conn.cn)
                    {
                        if (Conn.IsConnection)
                        {
                            string KeyGarageDelete = dataGridViewGarage.SelectedRows[0].Cells[0].Value.ToString();
                            using (var Cmd = Conn.cn.CreateCommand())
                            {
                                Cmd.CommandText = "delete from garage where code_garage = '" + KeyGarageDelete + "' ";
                                Cmd.ExecuteNonQuery();
                                MessageBox.Show("Le garage a été supprimé avec succès !", "Fleet: Informations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private int rowIndex = 0;
        private void dataGridViewGarage_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dataGridViewGarage.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.dataGridViewGarage.CurrentCell = this.dataGridViewGarage.Rows[e.RowIndex].Cells[1];
                this.menuGarage.Show(this.dataGridViewGarage, e.Location);
                menuGarage.Show(Cursor.Position);
            }
        }

        private void BtnImportGarag_Click(object sender, EventArgs e)
        {
            Form ImportGarag = new FormImportGarage();
            ImportGarag.ShowDialog();
        }

        private void BtnExportGarag_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // worksheet = workbook.Sheets["Sheets1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "DATA";
            // Recuperer les colonnes du DataGridView pour afficher dans la feuille Excel
            for (int i = 1; i < dataGridViewGarage.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridViewGarage.Columns[i - 1].HeaderText;
            }

            // Recuperer les lignes du DataGridView pour les afficher dans la feuille
            for (int i = 0; i < dataGridViewGarage.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewGarage.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridViewGarage.Rows[i].Cells[j].Value?.ToString();
                }
            }
            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "Nom du fichier";
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }

        private void btnRafraichirGarag_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        using (var Cmd = Conn.cn.CreateCommand())
                        {
                            // Display data in datagridview
                            sqlAda = new SqlDataAdapter("SELECT * FROM GARAGE", Conn.cn);
                            DataTable dt = new DataTable();
                            sqlAda.Fill(dt);

                            // Fill DataGridView
                            dataGridViewGarage.AutoGenerateColumns = false;
                            dataGridViewGarage.DataSource = dt;

                            // Nombre de service 
                            lblTotalGarage.Text = $"Total Garage = {dataGridViewGarage.RowCount - 1}";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFilterGarage_TextChanged(object sender, EventArgs e)
        {
            (dataGridViewGarage.DataSource as DataTable).DefaultView.RowFilter = "DESCRIPTION_GARAGE LIKE '%" + txtFilterGarage.Text + "%' ";
        }
    }
}
