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
    public partial class FormMarque : Form
    {
        private SqlCommand sqlCmd;
        private SqlDataAdapter sqlAda;
        private DataSet Ds;
        public FormMarque()
        {
            InitializeComponent();
            displaybrandCar();
            //TotalModelMarq.Text = $"Total modèle de véhicule = {dataGridViewMarq.RowCount - 1 }";
        }     

        // Display all brand car
        private void displaybrandCar()
        {

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                // Request
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        sqlAda = new SqlDataAdapter("SELECT*FROM MARQUE", Conn.cn);
                        DataTable dtbl = new DataTable();
                        sqlAda.Fill(dtbl);

                        // Fill DataGridView dgvMarq
                        dataGridViewMarq.AutoGenerateColumns = false;
                        dataGridViewMarq.DataSource = dtbl;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnValiderMarq_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                string CodeMarqueVehi = generateCodMarkCar();
                if (string.IsNullOrEmpty(textBoxDescriptMarq.Text))
                {
                    MessageBox.Show("Veiller saisir la description de la marque du véhicule !", "Fleet: Avertissement",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else if (string.IsNullOrEmpty(TxtModelMarq.Text))
                {
                    MessageBox.Show("Veiller saisir le modèle du véhicule svp!", "Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (string.IsNullOrEmpty(txTKiloVidange.Text))
                {
                    MessageBox.Show("Veiller saisir le kilometrage en vidange de ce modèle de véhicule svp!", "Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }else if (string.IsNullOrEmpty(cbxSeuilKiloVdge.Text))
                {
                    MessageBox.Show("Veiller saisir le seuil du kilometrage en vidange de ce modèle de véhicule svp!", "Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    using (Conn.cn)
                    {
                        if (Conn.IsConnection)
                        {
                            if (string.IsNullOrEmpty(txtIdMarque.Text))
                            {
                                sqlCmd = new SqlCommand("INSERT INTO MARQUE (CODE_MARQ,DESCRIPTION_MARQ,MODELE_MARQ,OBSERVATIONS_MARQ,KILO_VIDANGE_MARQ,SEUIL_KILO_VDGE_MARQ,DATECREATE_MARQ) " +
                                "VALUES (@CODE_MARQ,@DESCRIPTION_MARQ,@MODELE_MARQ,@OBSERVATIONS_MARQ,@KILO_VIDANGE_MARQ,@SEUIL_KILO_VDGE_MARQ, GETDATE()) ", Conn.cn);
                                sqlCmd.Parameters.AddWithValue("@CODE_MARQ", CodeMarqueVehi);
                                sqlCmd.Parameters.AddWithValue("@DESCRIPTION_MARQ", textBoxDescriptMarq.Text);
                                sqlCmd.Parameters.AddWithValue("@MODELE_MARQ", TxtModelMarq.Text);
                                sqlCmd.Parameters.AddWithValue("@OBSERVATIONS_MARQ", richTextBoxNoteMarq.Text);
                                sqlCmd.Parameters.AddWithValue("@KILO_VIDANGE_MARQ", decimal.Parse(txTKiloVidange.Text));
                                sqlCmd.Parameters.AddWithValue("@SEUIL_KILO_VDGE_MARQ", decimal.Parse(cbxSeuilKiloVdge.Text));
                                sqlCmd.ExecuteNonQuery();

                                // Clean the fields
                                textBxCodeMarq.Clear(); textBoxDescriptMarq.Clear(); richTextBoxNoteMarq.Clear(); txTKiloVidange.Text = "0";cbxSeuilKiloVdge.Text="0";TxtModelMarq.Clear();
                                // Rafraichir le datagridviewcar
                                refreshDataGridViewMar();
                                MessageBox.Show("Ce modèle de véhicule a été créé avec succès! Veillez créer un nouveau modèle de véhiccule!", "Fleet: Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                                MessageBox.Show("Ce modèle de véhicule existe déja. Veillez créer un nouveau modèle de véhiccule","Fleet: Avertissement",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCloseFormMarq_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewMarq_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow dgvMarq = dataGridViewMarq.Rows[e.RowIndex];
                txtIdMarque.Text = dgvMarq.Cells[0].Value.ToString();
                textBxCodeMarq.Text = dgvMarq.Cells[1].Value.ToString();
                textBoxDescriptMarq.Text = dgvMarq.Cells[2].Value.ToString();
                TxtModelMarq.Text = dgvMarq.Cells[3].Value.ToString();
                txTKiloVidange.Text = dgvMarq.Cells[4].Value.ToString();
                cbxSeuilKiloVdge.Text = dgvMarq.Cells[5].Value.ToString();
                richTextBoxNoteMarq.Text = dgvMarq.Cells[6].Value.ToString();
            }
        }

        // Methode to generate code for watching
        private string generateCodMarkCar()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {
                // Generate code of car
                sqlCmd = new SqlCommand("SELECT CODE_MARQ FROM MARQUE WHERE CODE_MARQ=(SELECT MAX(CODE_MARQ) FROM MARQUE)", Conn.cn);
                sqlAda = new SqlDataAdapter(sqlCmd);
                Ds = new DataSet();
                sqlAda.Fill(Ds);

                if (Ds.Tables[0].Rows.Count > 0)
                {
                    textBxCodeMarq.Text = Ds.Tables[0].Rows[0]["CODE_MARQ"].ToString();
                }
                else
                {
                    textBxCodeMarq.Text = "MARK0000";
                }
                if (!string.IsNullOrEmpty(textBxCodeMarq.Text))
                {
                    textBxCodeMarq.SelectionStart = 4;
                    textBxCodeMarq.SelectionLength = 4;
                    textBxCodeMarq.Text = textBxCodeMarq.SelectedText;
                }
                if (!string.IsNullOrEmpty(textBxCodeMarq.Text))
                {
                    int CodeWatch = int.Parse(textBxCodeMarq.Text.ToString()) + 1;
                    textBxCodeMarq.Text = CodeWatch.ToString("MARK0000");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet : Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return textBxCodeMarq.Text;
        }

        private void iconBtnAnnulerMarq_Click(object sender, EventArgs e)
        {
            textBoxDescriptMarq.Clear();textBxCodeMarq.Clear();txTKiloVidange.Text = "0";TxtModelMarq.Clear();richTextBoxNoteMarq.Clear();cbxSeuilKiloVdge.Text = "0"; txtIdMarque.Clear();
        }

        private void btnEditMarq_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (!string.IsNullOrEmpty(textBoxDescriptMarq.Text) && !string.IsNullOrEmpty(TxtModelMarq.Text) && !string.IsNullOrEmpty(txTKiloVidange.Text))
                {
                    DialogResult result = MessageBox.Show("Voulez vous enregister les modifications ?", "Fleet", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        using (Conn.cn)
                        {
                            if (Conn.IsConnection)
                            {
                                // Request to insert data in table personnels
                                sqlCmd = new SqlCommand("UPDATE MARQUE SET DESCRIPTION_MARQ=@DESCRIPTION_MARQ,MODELE_MARQ=@MODELE_MARQ,KILO_VIDANGE_MARQ=@KILO_VIDANGE_MARQ,OBSERVATIONS_MARQ=@OBSERVATIONS_MARQ WHERE CODE_MARQ='" + textBxCodeMarq.Text + "'; ", Conn.cn);
                                sqlCmd.Parameters.AddWithValue("@DESCRIPTION_MARQ", textBoxDescriptMarq.Text);
                                sqlCmd.Parameters.AddWithValue("@MODELE_MARQ", TxtModelMarq.Text);
                                sqlCmd.Parameters.AddWithValue("@KILO_VIDANGE_MARQ", decimal.Parse(txTKiloVidange.Text));
                                sqlCmd.Parameters.AddWithValue("@OBSERVATIONS_MARQ", richTextBoxNoteMarq.Text);
                                sqlCmd.ExecuteNonQuery();
                                MessageBox.Show("Modification prise compte !", "Modification de données", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Display data in datagridview
                                refreshDataGridViewMar();
                                // Clear the fields provider of car
                                textBoxDescriptMarq.Clear(); textBxCodeMarq.Clear(); txTKiloVidange.Text = "0"; TxtModelMarq.Clear(); richTextBoxNoteMarq.Clear();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private int rowIndex = 0;
        private void dataGridViewMarq_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dataGridViewMarq.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.dataGridViewMarq.CurrentCell = this.dataGridViewMarq.Rows[e.RowIndex].Cells[1];
                this.menuMarq.Show(this.dataGridViewMarq, e.Location);
                menuMarq.Show(Cursor.Position);
            }
        }

        private void deleteMarq_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("Voulez vous supprimer cette marque de véhicule ?"), "Confirmation", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                    ConnectDB Conn = new ConnectDB(connectionString);
                    using (Conn.cn)
                    {
                        if (Conn.IsConnection)
                        {
                            string KeyMarkDelete = dataGridViewMarq.SelectedRows[0].Cells[0].Value.ToString();
                            
                            using (var Cmd = Conn.cn.CreateCommand())
                            {
                                Cmd.CommandText = "delete from marque where code_marq = '" + KeyMarkDelete + "' ";
                                Cmd.ExecuteNonQuery();
                                MessageBox.Show("Cette marque de véhiclue a été supprimée avec succès", "Fleet: Informations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                // Display data in datagridview
                                refreshDataGridViewMar();
                            }
                          
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Fleet : Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Rafraichir le datagridview
        private void refreshDataGridViewMar()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        using (var Cmd = Conn.cn.CreateCommand())
                        {
                            // Display data in datagridview
                            sqlAda = new SqlDataAdapter("select*from marque order by code_marq desc", Conn.cn);
                            DataTable dt = new DataTable();
                            sqlAda.Fill(dt);
                            dataGridViewMarq.AutoGenerateColumns = false;
                            dataGridViewMarq.DataSource = dt;
                            // Number of MarqCar
                            TotalModelMarq.Text = $"Total modèle de véhicule = {dataGridViewMarq.RowCount - 1 }";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet : Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFiltrerMarq_TextChanged(object sender, EventArgs e)
        {
            (dataGridViewMarq.DataSource as DataTable).DefaultView.RowFilter = "DESCRIPTION_MARQ LIKE '%" + txtFiltrerMarq.Text + "%' ";
        }
    }
}
