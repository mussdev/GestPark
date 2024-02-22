using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestPark.Vues.Consult
{
    public partial class FormPeriodeMission : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataReader MyReader;
        private DataSet Ds;
        private SqlDataAdapter SqlAda;
        public FormPeriodeMission()
        {
            InitializeComponent();
            rafraichirDgvPeriodMiss();
        }

        /**
         * Methode permettant de générer l'identifiant d'une categorie de mission
         */
        private string generateCodePeriodeMission()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        // Generate code attribution car to person
                        SqlCmd = new SqlCommand("SELECT CODE_PERIODMISS FROM PERIODEMISSION WHERE CODE_PERIODMISS=(SELECT MAX(CODE_PERIODMISS) FROM PERIODEMISSION)", Conn.cn);
                        SqlAda = new SqlDataAdapter(SqlCmd);
                        Ds = new DataSet();
                        SqlAda.Fill(Ds);

                        if (Ds.Tables[0].Rows.Count > 0)
                        {
                            TxtCodPeriodMiss.Text = Ds.Tables[0].Rows[0]["CODE_PERIODMISS"].ToString();
                        }
                        else
                        {
                            TxtCodPeriodMiss.Text = "PERIODMISS0000";
                        }
                        if (!string.IsNullOrEmpty(TxtCodPeriodMiss.Text))
                        {
                            TxtCodPeriodMiss.SelectionStart = 10;
                            TxtCodPeriodMiss.SelectionLength = 4;
                            TxtCodPeriodMiss.Text = TxtCodPeriodMiss.SelectedText;
                        }
                        if (!string.IsNullOrEmpty(TxtCodPeriodMiss.Text))
                        {
                            int codeCarMvt = int.Parse(TxtCodPeriodMiss.Text.ToString()) + 1;
                            TxtCodPeriodMiss.Text = codeCarMvt.ToString("PERIODMISS0000");
                        }
                    }
                    else
                        MessageBox.Show("Veillez réviser les paramètres de connexion à la base de données !", "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return TxtCodPeriodMiss.Text;
        }

        private void btnValiderPeriodMission_Click(object sender, EventArgs e)
        {
            if (decimal.Parse(TxtMontantPeriodMiss.Text) < 0 && (ChkPeriodeCourteMiss.Checked || ChkPeriodeMoyenneMiss.Checked || ChkPeriodeLongueMiss.Checked))
            {
                MessageBox.Show("Veillez renseigner tous les champs (*)." + "\n" + "Ou Saisir un montant supérieur à 0 dans le champ montant", "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                    ConnectDB Conn = new ConnectDB(connectionString);

                    using (Conn.cn)
                    {
                        if (Conn.IsConnection)
                        {
                            string CodePeriodMission = generateCodePeriodeMission();
                            if (string.IsNullOrEmpty(txtIdPeriodMiss.Text))
                            {
                                SqlCmd = new SqlCommand("INSERT INTO PERIODEMISSION (CODE_PERIODMISS,PERIODECOURTE_PERIODMISS,PERIODEMOYENNE_PERIODMISS,PERIODELONGUE_PERIODMISS,MONTANT_PERIODMISS,NOTE_PERIODMISS,DATECREATE_PERIODMISS) VALUES (@CODE_PERIODMISS,@PERIODECOURTE_PERIODMISS,@PERIODEMOYENNE_PERIODMISS,@PERIODELONGUE_PERIODMISS,@MONTANT_PERIODMISS,@NOTE_PERIODMISS,GETDATE()) ", Conn.cn);
                                SqlCmd.Parameters.AddWithValue("@CODE_PERIODMISS", CodePeriodMission);
                                SqlCmd.Parameters.AddWithValue("@PERIODECOURTE_PERIODMISS", ChkPeriodeCourteMiss.Checked);
                                SqlCmd.Parameters.AddWithValue("@PERIODEMOYENNE_PERIODMISS", ChkPeriodeMoyenneMiss.Checked);
                                SqlCmd.Parameters.AddWithValue("@PERIODELONGUE_PERIODMISS", ChkPeriodeLongueMiss.Checked);
                                SqlCmd.Parameters.AddWithValue("@MONTANT_PERIODMISS", decimal.Parse(TxtMontantPeriodMiss.Text));
                                SqlCmd.Parameters.AddWithValue("@NOTE_PERIODMISS", RTxtNotePeriodMiss.Text);
                                SqlCmd.ExecuteNonQuery();

                                // Clean the fields
                                CleanFiled();

                                // Display data in datagridview
                                rafraichirDgvPeriodMiss();

                                MessageBox.Show("Vous de définir une période de mission avec succcès !", "Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                MessageBox.Show("Cette période de mission existe déjà !", "Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /**
         * 
         * Methode qui renvoie la liste des catégories mission
         */

        private void rafraichirDgvPeriodMiss()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);

                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        // Display data in datagridview
                        SqlAda = new SqlDataAdapter("SELECT * FROM PERIODEMISSION ORDER BY  DATECREATE_PERIODMISS DESC", Conn.cn);
                        DataTable dt = new DataTable();
                        SqlAda.Fill(dt);

                        // Fill DataGridView
                        dgvPeriodMission.AutoGenerateColumns = false;
                        dgvPeriodMission.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /**
         * 
         * Method to clean the fields
         */
        private void CleanFiled()
        {
            RTxtNotePeriodMiss.Text = string.Empty;
            TxtCodPeriodMiss.Text = string.Empty;
            TxtMontantPeriodMiss.Text = "0";
            ChkPeriodeLongueMiss.Checked = false;
            ChkPeriodeCourteMiss.Checked = false;
            ChkPeriodeMoyenneMiss.Checked = false;
            txtIdPeriodMiss.Clear();
        }

        private void btnRafraichirPeriodMission_Click(object sender, EventArgs e)
        {
            rafraichirDgvPeriodMiss();
        }

        private void ChkPeriodeCourteMiss_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkPeriodeCourteMiss.Checked)
            {
                ChkPeriodeMoyenneMiss.Enabled = false;
                ChkPeriodeLongueMiss.Enabled = false;
            }
            else
            {
                ChkPeriodeMoyenneMiss.Enabled = true;
                ChkPeriodeLongueMiss.Enabled = true;
            }
                
        }

        private void ChkPeriodeMoyenneMiss_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkPeriodeMoyenneMiss.Checked)
            {
                ChkPeriodeCourteMiss.Enabled = false;
                ChkPeriodeLongueMiss.Enabled = false;
            }
            else
            {
                ChkPeriodeCourteMiss.Enabled = true;
                ChkPeriodeLongueMiss.Enabled = true;
            }
                
        }

        private void ChkPeriodeLongueMiss_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkPeriodeLongueMiss.Checked)
            {
                ChkPeriodeCourteMiss.Enabled = false;
                ChkPeriodeMoyenneMiss.Enabled = false;
            }
            else
            {
                ChkPeriodeCourteMiss.Enabled = true;
                ChkPeriodeMoyenneMiss.Enabled = true;
            }
                
        }

        private void btnEditPeriodMission_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (!string.IsNullOrEmpty(TxtCodPeriodMiss.Text) && decimal.Parse(TxtMontantPeriodMiss.Text) > 0)
                {
                    DialogResult result = MessageBox.Show("Voulez vous enregister les modifications ?", "Fleet: Questions", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        using (Conn.cn)
                        {
                            if (Conn.IsConnection)
                            {
                                // Request to insert data in table personnels
                                SqlCmd = new SqlCommand("UPDATE PERIODEMISSION SET PERIODECOURTE_PERIODMISS=@PERIODECOURTE_PERIODMISS,PERIODEMOYENNE_PERIODMISS=@PERIODEMOYENNE_PERIODMISS,PERIODELONGUE_PERIODMISS=@PERIODELONGUE_PERIODMISS,MONTANT_PERIODMISS=@MONTANT_PERIODMISS,NOTE_PERIODMISS=@NOTE_PERIODMISS,DATEMODIFIER_PERIODMISS=GETDATE() WHERE ID_PERIODMISS='" + Guid.Parse(txtIdPeriodMiss.Text) + "' ", Conn.cn);
                                SqlCmd.Parameters.AddWithValue("@PERIODECOURTE_PERIODMISS", ChkPeriodeCourteMiss.Checked);
                                SqlCmd.Parameters.AddWithValue("@PERIODEMOYENNE_PERIODMISS", ChkPeriodeMoyenneMiss.Checked);
                                SqlCmd.Parameters.AddWithValue("@PERIODELONGUE_PERIODMISS", ChkPeriodeLongueMiss.Checked);
                                SqlCmd.Parameters.AddWithValue("@MONTANT_PERIODMISS", decimal.Parse(TxtMontantPeriodMiss.Text));
                                SqlCmd.Parameters.AddWithValue("@NOTE_PERIODMISS", RTxtNotePeriodMiss.Text);
                                SqlCmd.ExecuteNonQuery();
                                MessageBox.Show("Votre modification a été prise compte !", "Fleet: Modification de données", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Display data in datagridview
                                CleanFiled();
                                // Clear the fields provider of car
                                rafraichirDgvPeriodMiss();
                            }
                        }
                    }
                }
                else
                    MessageBox.Show("Veillez saisir obligatoirement les champs (*) !" + "\n" + "Saisir également un montant supérieur à 0 dans le champ montant !", "Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int rowIndex = 0;
        private void dgvPeriodMission_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dgvPeriodMission.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.dgvPeriodMission.CurrentCell = this.dgvPeriodMission.Rows[e.RowIndex].Cells[1];
                this.MenuDeletePeriodeMiss.Show(this.dgvPeriodMission, e.Location);
                MenuDeletePeriodeMiss.Show(Cursor.Position);
            }
        }

        private void dgvPeriodMission_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvPeriodMiss = dgvPeriodMission.Rows[e.RowIndex];
                txtIdPeriodMiss.Text = dgvPeriodMiss.Cells["ID_PERIODMISS"].Value.ToString();
                TxtCodPeriodMiss.Text = dgvPeriodMiss.Cells["CODE_PERIODMISS"].Value.ToString();
                TxtMontantPeriodMiss.Text = dgvPeriodMiss.Cells["MONTANT_PERIODMISS"].Value.ToString();
                ChkPeriodeCourteMiss.Checked = Convert.ToBoolean(dgvPeriodMiss.Cells["PERIODECOURTE_PERIODMISS"].Value);
                ChkPeriodeMoyenneMiss.Checked = Convert.ToBoolean(dgvPeriodMiss.Cells["PERIODEMOYENNE_PERIODMISS"].Value);
                ChkPeriodeLongueMiss.Checked = Convert.ToBoolean(dgvPeriodMiss.Cells["PERIODELONGUE_PERIODMISS"].Value);
                RTxtNotePeriodMiss.Text = dgvPeriodMiss.Cells["NOTE_PERIODMISS"].Value.ToString();
            }
        }

        private void txtFilterPeriodMiss_TextChanged(object sender, EventArgs e)
        {
            (dgvPeriodMission.DataSource as DataTable).DefaultView.RowFilter = "MONTANT_PERIODMISS = '" + txtFilterPeriodMiss.Text + "' ";
        }

        private void MenuItemDeletePeriodMiss_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("Attention: Cet objet peut être lié à des enregistrements" + "\n" + "Si oui veillez vérifier cela avant la suppression svp !" + "\n" + "Voulez vous supprimer cet objet ?"), "Fleet: Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                    ConnectDB Conn = new ConnectDB(connectionString);
                    using (Conn.cn)
                    {
                        if (Conn.IsConnection)
                        {
                            string KeyPeriodDelete = dgvPeriodMission.SelectedRows[0].Cells["ID_PERIODMISS"].Value.ToString();
                            using (var Cmd = Conn.cn.CreateCommand())
                            {
                                Cmd.CommandText = "DELETE FROM PERIODEMISSION WHERE CODE_PERIODMISS = '" + KeyPeriodDelete + "' ";
                                Cmd.ExecuteNonQuery();
                                MessageBox.Show("L'objet a été supprimé avec succès !", "Fleet: Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void BtnAnnulerPeriodMission_Click(object sender, EventArgs e)
        {
            CleanFiled();
        }
    }
}
