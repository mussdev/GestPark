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

namespace GestPark.Vues.Consult
{
    public partial class FormConducteur : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataReader MyReader;
        private SqlDataAdapter SqlAda;
        private DataSet Ds;
        public FormConducteur()
        {
            InitializeComponent();
            refrechDgv();
        }

        private void btnValiderConduc_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);

                if (string.IsNullOrEmpty(txtDescriptionConduc.Text))
                {
                    MessageBox.Show("Veiller saisir le champ description !", "Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    using (Conn.cn)
                    {
                        if (Conn.IsConnection)
                        {
                            if (string.IsNullOrEmpty(txtIdConduc.Text))
                            {
                                string CodeConduc = generateCodConduc();
                                SqlCmd = new SqlCommand("INSERT INTO CONDUCTEURS (CODE_COND,DESCRIPTION_COND,NUMPERMIS_COND,DISPMISSION_COND,NBRMISSION_COND,EXPERIENCE_COND,DATECREATE_COND) VALUES (@CODE_COND,@DESCRIPTION_COND,@NUMPERMIS_COND,@DISPMISSION_COND,@NBRMISSION_COND,@EXPERIENCE_COND,GETDATE()) ", Conn.cn);
                                SqlCmd.Parameters.AddWithValue("@CODE_COND", CodeConduc);
                                SqlCmd.Parameters.AddWithValue("@DESCRIPTION_COND", txtDescriptionConduc.Text);
                                SqlCmd.Parameters.AddWithValue("@NUMPERMIS_COND", txtPermisConduc.Text);
                                SqlCmd.Parameters.AddWithValue("@DISPMISSION_COND", checkBoxDisponibiliteMission.Checked);
                                SqlCmd.Parameters.AddWithValue("@NBRMISSION_COND", int.Parse(txtNbrMission.Text));
                                SqlCmd.Parameters.AddWithValue("@EXPERIENCE_COND", int.Parse(txtExpConducteur.Text));
                                SqlCmd.ExecuteNonQuery();

                                // Clean the fields
                                ClearFileds();

                                // Display data in datagridview
                                refrechDgv();
                                MessageBox.Show("Vous venez de créer un conducteur !", "Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                MessageBox.Show("Ce conducteur existe déjà !", "Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Methode to generate code for watching
        private string generateCodConduc()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {
                // Generate code of car
                SqlCmd = new SqlCommand("SELECT CODE_COND FROM CONDUCTEURS WHERE CODE_COND=(SELECT MAX(CODE_COND) FROM CONDUCTEURS)", Conn.cn);
                SqlAda = new SqlDataAdapter(SqlCmd);
                Ds = new DataSet();
                SqlAda.Fill(Ds);

                if (Ds.Tables[0].Rows.Count > 0)
                {
                    TxtCodConduc.Text = Ds.Tables[0].Rows[0]["CODE_COND"].ToString();
                }
                else
                {
                    TxtCodConduc.Text = "COND0000";
                }
                if (!string.IsNullOrEmpty(TxtCodConduc.Text))
                {
                    TxtCodConduc.SelectionStart = 4;
                    TxtCodConduc.SelectionLength = 4;
                    TxtCodConduc.Text = TxtCodConduc.SelectedText;
                }
                if (!string.IsNullOrEmpty(TxtCodConduc.Text))
                {
                    int CodeWatch = int.Parse(TxtCodConduc.Text.ToString()) + 1;
                    TxtCodConduc.Text = CodeWatch.ToString("COND0000");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return TxtCodConduc.Text;
        }

        // Methode qui rafraîchir le datagridview des données
        private void refrechDgv()
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
                            SqlAda = new SqlDataAdapter("SELECT * FROM CONDUCTEURS ORDER BY DATECREATE_COND DESC", Conn.cn);
                            DataTable dt = new DataTable();
                            SqlAda.Fill(dt);

                            // Fill DataGridView
                            dgvConduc.AutoGenerateColumns = false;
                            dgvConduc.DataSource = dt;

                            // Nombre de service 
                            txtNbrConduc.Text = $"Total Conducteur = {dgvConduc.RowCount - 1}";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRafraichirConduc_Click(object sender, EventArgs e)
        {
            refrechDgv();
        }

        private void BtnAnnulerConduc_Click(object sender, EventArgs e)
        {
            ClearFileds();
        }

        private void ClearFileds()
        {
            txtDescriptionConduc.Clear(); txtIdConduc.Clear(); txtPermisConduc.Clear(); TxtCodConduc.Clear(); txtExpConducteur.Text="0"; txtNbrMission.Text="0"; checkBoxDisponibiliteMission.Checked=false;
        }

        private void btnEditConduc_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (!string.IsNullOrEmpty(TxtCodConduc.Text) && !string.IsNullOrEmpty(txtDescriptionConduc.Text) && !string.IsNullOrEmpty(txtIdConduc.Text))
                {
                    DialogResult result = MessageBox.Show("Voulez vous enregister les modifications ?", "Fleet: Questions", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        using (Conn.cn)
                        {
                            if (Conn.IsConnection)
                            {
                                // Request to insert data in table personnels
                                SqlCmd = new SqlCommand("UPDATE CONDUCTEURS SET DESCRIPTION_COND=@DESCRIPTION_COND,NUMPERMIS_COND=@NUMPERMIS_COND,DISPMISSION_COND=@DISPMISSION_COND,NBRMISSION_COND=@NBRMISSION_COND,EXPERIENCE_COND=@EXPERIENCE_COND,DATEMODIFY_COND=GETDATE() WHERE ID_COND='" + Guid.Parse(txtIdConduc.Text) + "'; ", Conn.cn);
                                SqlCmd.Parameters.AddWithValue("@DESCRIPTION_COND", txtDescriptionConduc.Text);
                                SqlCmd.Parameters.AddWithValue("@NUMPERMIS_COND", txtPermisConduc.Text);
                                SqlCmd.Parameters.AddWithValue("@DISPMISSION_COND", checkBoxDisponibiliteMission.Checked);
                                SqlCmd.Parameters.AddWithValue("@NBRMISSION_COND", int.Parse(txtNbrMission.Text));
                                SqlCmd.Parameters.AddWithValue("@EXPERIENCE_COND", int.Parse(txtExpConducteur.Text));
                                SqlCmd.ExecuteNonQuery();
                                MessageBox.Show("Modification prise compte !", "Modification de données", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Display data in datagridview
                                refrechDgv();
                                // Clear the fields provider of car
                                ClearFileds();
                            }
                        }
                    }
                }
                else
                    MessageBox.Show("Veillez sélectionner un conducteur dans la table !", "Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvConduc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvConducteur = dgvConduc.Rows[e.RowIndex];
                txtIdConduc.Text = dgvConducteur.Cells["ID_COND"].Value.ToString();
                TxtCodConduc.Text = dgvConducteur.Cells["CODE_COND"].Value.ToString();
                txtDescriptionConduc.Text = dgvConducteur.Cells["DESCRIPTION_COND"].Value.ToString();
                txtPermisConduc.Text = dgvConducteur.Cells["NUMPERMIS_COND"].Value.ToString();
                txtNbrMission.Text = dgvConducteur.Cells["NBRMISSION_COND"].Value.ToString();
                txtExpConducteur.Text = dgvConducteur.Cells["EXPERIENCE_COND"].Value.ToString();
                checkBoxDisponibiliteMission.Checked = Convert.ToBoolean(dgvConducteur.Cells["DISPMISSION_COND"].Value);
            }
        }

        private void BtnCloseFormConducteur_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int rowIndex = 0;
        private void dgvConduc_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dgvConduc.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.dgvConduc.CurrentCell = this.dgvConduc.Rows[e.RowIndex].Cells[1];
                this.MenuConducteur.Show(this.dgvConduc, e.Location);
                MenuConducteur.Show(Cursor.Position);
            }
        }

        private void itemMenuDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("Voulez vous supprimer ce conducteur ?"), "Fleet: Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                    ConnectDB Conn = new ConnectDB(connectionString);
                    using (Conn.cn)
                    {
                        if (Conn.IsConnection)
                        {
                            Guid KeyGarageDelete = Guid.Parse(dgvConduc.SelectedRows[0].Cells[0].Value.ToString().ToLower());
                            //MessageBox.Show(" id du conducteur : " + KeyGarageDelete);
                            using (var Cmd = Conn.cn.CreateCommand())
                            {
                                Cmd.CommandText = "DELETE FROM CONDUCTEURS WHERE ID_COND = '" + KeyGarageDelete + "' ";
                                Cmd.ExecuteNonQuery();
                                ClearFileds();
                                refrechDgv();
                                MessageBox.Show("Vous venez de supprimer un conducteur !", "Fleet: Informations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void txtFilterConduc_TextChanged(object sender, EventArgs e)
        {
            (dgvConduc.DataSource as DataTable).DefaultView.RowFilter = "DESCRIPTION_COND LIKE '%" + txtDescriptionConduc.Text + "%' ";
        }
    }
}
