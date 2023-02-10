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
    public partial class FormTypeConsommation : Form
    {
        private SqlDataAdapter SqlAda;
        private SqlCommand SqlCmd;
        private DataSet Ds;
        public FormTypeConsommation()
        {
            InitializeComponent();
            displayListTypConsommation();
            TotalEnergie.Text = $"Total direction = {DgvTypConso.RowCount - 1 }";
        }

        private void iconBtnCloseFormTypConso_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconBtnValiderTypConso_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                string CodeEnergie = generateCodeEnergy();
                if (string.IsNullOrEmpty(textBoxDescripTypConso.Text))
                {
                    MessageBox.Show("Veiller saisir le nom d'une energy de consommation de véhicule !","Fleet: Avertissement",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    using (Conn.cn)
                    {
                        if (Conn.IsConnection)
                        {
                            if (string.IsNullOrEmpty(txtIdEnergie.Text))
                            {
                                SqlCmd = new SqlCommand("INSERT INTO TYPECONSOMMATION (CODE_TYPCONSO,DESCRIPTION_TYPCONSO,PRIXLITRE_TYPCONSO,OBSERVATION_TYPCONSO,DATECREATE_TYPCONSO) " +
                                "VALUES (@CODE_TYPCONSO,@DESCRIPTION_TYPCONSO,@PRIXLITRE_TYPCONSO,@OBSERVATION_TYPCONSO,GETDATE())", Conn.cn);
                                SqlCmd.Parameters.AddWithValue("@CODE_TYPCONSO", CodeEnergie);
                                SqlCmd.Parameters.AddWithValue("@DESCRIPTION_TYPCONSO", textBoxDescripTypConso.Text);
                                SqlCmd.Parameters.AddWithValue("@PRIXLITRE_TYPCONSO", decimal.Parse(TxtPrixLitre.Text));
                                SqlCmd.Parameters.AddWithValue("@OBSERVATION_TYPCONSO", richTextBoxNoteTypConso.Text);
                                SqlCmd.ExecuteNonQuery();
                                // Clear the fields
                                textBoxCodTypConso.Clear(); textBoxDescripTypConso.Clear(); richTextBoxNoteTypConso.Clear();

                                // Request
                                SqlAda = new SqlDataAdapter("SELECT*FROM TYPECONSOMMATION ORDER BY CODE_TYPCONSO DESC", Conn.cn);
                                DataTable dtbl = new DataTable();
                                SqlAda.Fill(dtbl);

                                // Fill DataGridView
                                DgvTypConso.AutoGenerateColumns = false;
                                DgvTypConso.DataSource = dtbl;
                                MessageBox.Show("Vous venez de créer une energie de consommation !", "Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                                MessageBox.Show("Cette énergie existe déja !","Fleet: Avertissement",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to display all type of car consommation
        private void displayListTypConsommation()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        // Request
                        SqlAda = new SqlDataAdapter("SELECT * FROM TYPECONSOMMATION", Conn.cn);
                        DataTable dtbl = new DataTable();
                        SqlAda.Fill(dtbl);

                        // Fill dataGridView to display the list of parking
                        DgvTypConso.AutoGenerateColumns = false;
                        DgvTypConso.DataSource = dtbl;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iconBtnAnnulerTypConso_Click(object sender, EventArgs e)
        {
            richTextBoxNoteTypConso.Clear(); textBoxCodTypConso.Clear(); textBoxDescripTypConso.Clear();txtIdEnergie.Clear();
        }

        // Methode to generate code for watching
        private string generateCodeEnergy()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {
                // Generate code of car
                SqlCmd = new SqlCommand("SELECT CODE_TYPCONSO FROM TYPECONSOMMATION WHERE ID_TYPCONSO=(SELECT MAX(ID_TYPCONSO) FROM TYPECONSOMMATION)", Conn.cn);
                SqlAda = new SqlDataAdapter(SqlCmd);
                Ds = new DataSet();
                SqlAda.Fill(Ds);

                if (Ds.Tables[0].Rows.Count > 0)
                {
                    textBoxCodTypConso.Text = Ds.Tables[0].Rows[0]["CODE_TYPCONSO"].ToString();
                }
                else
                {
                    textBoxCodTypConso.Text = "ENER0000";
                }
                if (!string.IsNullOrEmpty(textBoxCodTypConso.Text))
                {
                    textBoxCodTypConso.SelectionStart = 4;
                    textBoxCodTypConso.SelectionLength = 4;
                    textBoxCodTypConso.Text = textBoxCodTypConso.SelectedText;
                }
                if (!string.IsNullOrEmpty(textBoxCodTypConso.Text))
                {
                    int CodeWatch = int.Parse(textBoxCodTypConso.Text.ToString()) + 1;
                    textBoxCodTypConso.Text = CodeWatch.ToString("ENER0000");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return textBoxCodTypConso.Text;
        }

        private void DgvTypConso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow dgvEnergy = DgvTypConso.Rows[e.RowIndex];
                txtIdEnergie.Text = dgvEnergy.Cells[0].Value.ToString();
                textBoxCodTypConso.Text = dgvEnergy.Cells[1].Value.ToString();
                textBoxDescripTypConso.Text = dgvEnergy.Cells[2].Value.ToString();
                TxtPrixLitre.Text = dgvEnergy.Cells[3].Value.ToString();
                richTextBoxNoteTypConso.Text = dgvEnergy.Cells[4].Value.ToString();
            }
        }

        private void btnEditEnergy_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (!string.IsNullOrEmpty(textBoxCodTypConso.Text) && !string.IsNullOrEmpty(textBoxDescripTypConso.Text) && !string.IsNullOrEmpty(TxtPrixLitre.Text))
                {
                    DialogResult result = MessageBox.Show("Voulez vous enregister les modifications ?", "Fleet", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        using (Conn.cn)
                        {
                            if (Conn.IsConnection)
                            {
                                // Request to insert data in table personnels
                                SqlCmd = new SqlCommand("UPDATE TYPECONSOMMATION SET DESCRIPTION_TYPCONSO=@DESCRIPTION_TYPCONSO,PRIXLITRE_TYPCONSO=@PRIXLITRE_TYPCONSO,OBSERVATION_TYPCONSO=@OBSERVATION_TYPCONSO WHERE CODE_TYPCONSO='" + textBoxCodTypConso.Text + "'; ", Conn.cn);
                                SqlCmd.Parameters.AddWithValue("@DESCRIPTION_TYPCONSO", textBoxDescripTypConso.Text);
                                SqlCmd.Parameters.AddWithValue("@PRIXLITRE_TYPCONSO", decimal.Parse(TxtPrixLitre.Text));
                                SqlCmd.Parameters.AddWithValue("@OBSERVATION_TYPCONSO", richTextBoxNoteTypConso.Text);
                                SqlCmd.ExecuteNonQuery();
                                MessageBox.Show("Modification prise compte !", "Modification de données", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Display data in datagridview
                                SqlAda = new SqlDataAdapter("select*from TYPECONSOMMATION order by CODE_TYPCONSO desc", Conn.cn);
                                DataTable dt = new DataTable();
                                SqlAda.Fill(dt);
                                DgvTypConso.AutoGenerateColumns = false;
                                DgvTypConso.DataSource = dt;
                                // Clear the fields provider of car
                                textBoxCodTypConso.Clear(); textBoxDescripTypConso.Clear(); richTextBoxNoteTypConso.Clear();
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
        private void DgvTypConso_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.DgvTypConso.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.DgvTypConso.CurrentCell = this.DgvTypConso.Rows[e.RowIndex].Cells[1];
                this.menuEnergy.Show(this.DgvTypConso, e.Location);
                menuEnergy.Show(Cursor.Position);
            }
        }

        private void deleteEnergy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("Voulez vous supprimer cette énergie ?"), "Fleet: Confirmation", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                    ConnectDB Conn = new ConnectDB(connectionString);
                    using (Conn.cn)
                    {
                        if (Conn.IsConnection)
                        {
                            string KeydeleteEnergy = DgvTypConso.SelectedRows[0].Cells[0].Value.ToString();

                            using (var Cmd = Conn.cn.CreateCommand())
                            {
                                Cmd.CommandText = "delete from typeconsommation where code_typconso = '" + KeydeleteEnergy + "' ";
                                Cmd.ExecuteNonQuery();
                                MessageBox.Show("Energie supprimée avec succès", "Fleet: Informations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
  
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

        private void txtFilterEnergie_TextChanged(object sender, EventArgs e)
        {
            (DgvTypConso.DataSource as DataTable).DefaultView.RowFilter = "DESCRIPTION_TYPCONSO LIKE '%" + txtFilterEnergie.Text + "%' ";
        }
    }
}
