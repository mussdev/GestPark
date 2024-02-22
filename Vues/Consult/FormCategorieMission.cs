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
    public partial class FormCategorieMission : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataAdapter SqlAda;
        private DataSet Ds;
        public FormCategorieMission()
        {
            InitializeComponent();
            // Display data in datagridview
            rafraichirDgvCateg();
        }

        private void BtnCloseFormCategMission_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**
         * Methode permettant de générer l'identifiant d'une categorie de mission
         */
        // Generate code of personne
        private string generateCodeCategMission()
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
                        SqlCmd = new SqlCommand("SELECT CODE_CATEG_MISS FROM CATEGORIEMISSION WHERE CODE_CATEG_MISS=(SELECT MAX(CODE_CATEG_MISS) FROM CATEGORIEMISSION)", Conn.cn);
                        SqlAda = new SqlDataAdapter(SqlCmd);
                        Ds = new DataSet();
                        SqlAda.Fill(Ds);

                        if (Ds.Tables[0].Rows.Count > 0)
                        {
                            TxtCodCateg.Text = Ds.Tables[0].Rows[0]["CODE_CATEG_MISS"].ToString();
                        }
                        else
                        {
                            TxtCodCateg.Text = "CATEGMISSION0000";
                        }
                        if (!string.IsNullOrEmpty(TxtCodCateg.Text))
                        {
                            TxtCodCateg.SelectionStart = 12;
                            TxtCodCateg.SelectionLength = 4;
                            TxtCodCateg.Text = TxtCodCateg.SelectedText;
                        }
                        if (!string.IsNullOrEmpty(TxtCodCateg.Text))
                        {
                            int codeCarMvt = int.Parse(TxtCodCateg.Text.ToString()) + 1;
                            TxtCodCateg.Text = codeCarMvt.ToString("CATEGMISSION0000");
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
            return TxtCodCateg.Text;
        }

        private void btnValiderCategMission_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(CbxCategProfFonct.Text) && string.IsNullOrEmpty(CbxPaysContinent.Text) && string.IsNullOrEmpty(CbxType.Text) /*&& decimal.Parse(TxtMontant.Text) > 0*/)
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
                            string CodeCategMission = generateCodeCategMission();
                            if (string.IsNullOrEmpty(txtIdCategMiss.Text))
                            {
                                SqlCmd = new SqlCommand("INSERT INTO CATEGORIEMISSION (CODE_CATEG_MISS,DESCRIPTION_CATEG_MISS,TYPE_CATEG_MISS,PAYS_CONTICATEG_MISS,MONTANT_CATEG_MISS,NOTE_CATEG_MISS,DATECREATE_CATEG_MISS) VALUES (@CODE_CATEG_MISS,@DESCRIPTION_CATEG_MISS,@TYPE_CATEG_MISS,@PAYS_CONTICATEG_MISS,@MONTANT_CATEG_MISS,@NOTE_CATEG_MISS,GETDATE()) ", Conn.cn);
                                SqlCmd.Parameters.AddWithValue("@CODE_CATEG_MISS", CodeCategMission);
                                SqlCmd.Parameters.AddWithValue("@DESCRIPTION_CATEG_MISS", CbxCategProfFonct.Text);
                                SqlCmd.Parameters.AddWithValue("@TYPE_CATEG_MISS", CbxType.Text);
                                SqlCmd.Parameters.AddWithValue("@PAYS_CONTICATEG_MISS", CbxPaysContinent.Text);
                                SqlCmd.Parameters.AddWithValue("@MONTANT_CATEG_MISS", decimal.Parse(TxtMontant.Text));
                                SqlCmd.Parameters.AddWithValue("@NOTE_CATEG_MISS", RTxtNoteType.Text);
                                SqlCmd.ExecuteNonQuery();

                                // Clean the fields
                                CleanFiled();

                                // Display data in datagridview
                                rafraichirDgvCateg();

                                MessageBox.Show("Cette direction a été créee avec succcès !", "Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                MessageBox.Show("Cette direction existe déjà !", "Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void rafraichirDgvCateg()
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
                        SqlAda = new SqlDataAdapter("SELECT * FROM CATEGORIEMISSION ORDER BY  DATECREATE_CATEG_MISS DESC", Conn.cn);
                        DataTable dt = new DataTable();
                        SqlAda.Fill(dt);

                        // Fill DataGridView
                        dgvCategMission.AutoGenerateColumns = false;
                        dgvCategMission.DataSource = dt;
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
            CbxCategProfFonct.Text = string.Empty;
            CbxPaysContinent.Text = string.Empty;
            CbxType.Text = string.Empty;
            TxtCodCateg.Clear();
            TxtMontant.Text = "0";
            txtIdCategMiss.Clear();
            RTxtNoteType.Clear();

        }

        private void btnRafraichirDir_Click(object sender, EventArgs e)
        {
            rafraichirDgvCateg();
        }

        private void dgvCategMission_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvCategMiss = dgvCategMission.Rows[e.RowIndex];
                txtIdCategMiss.Text = dgvCategMiss.Cells[0].Value.ToString();
                TxtCodCateg.Text = dgvCategMiss.Cells[1].Value.ToString();
                CbxCategProfFonct.Text = dgvCategMiss.Cells[2].Value.ToString();
                CbxType.Text = dgvCategMiss.Cells[3].Value.ToString();
                CbxPaysContinent.Text = dgvCategMiss.Cells[4].Value.ToString();
                TxtMontant.Text = dgvCategMiss.Cells[5].Value.ToString();
                RTxtNoteType.Text = dgvCategMiss.Cells[6].Value.ToString();
            }
        }

        private int rowIndex = 0;
        private void dgvCategMission_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dgvCategMission.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.dgvCategMission.CurrentCell = this.dgvCategMission.Rows[e.RowIndex].Cells[1];
                this.MenuDeleteCateg.Show(this.dgvCategMission, e.Location);
                MenuDeleteCateg.Show(Cursor.Position);
            }
        }

        private void txtFilterCateg_TextChanged(object sender, EventArgs e)
        {
            (dgvCategMission.DataSource as DataTable).DefaultView.RowFilter = "DESCRIPTION_CATEG_MISS LIKE '%" + txtFilterCateg.Text + "%' ";
        }

        private void btnEditCategMission_Click(object sender, EventArgs e)
        {

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (!string.IsNullOrEmpty(TxtCodCateg.Text) && !string.IsNullOrEmpty(CbxCategProfFonct.Text) && !string.IsNullOrEmpty(CbxPaysContinent.Text) && !string.IsNullOrEmpty(CbxType.Text))
                {
                    DialogResult result = MessageBox.Show("Voulez vous enregister les modifications ?", "Fleet: Questions", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        using (Conn.cn)
                        {
                            if (Conn.IsConnection)
                            {
                                // Request to insert data in table personnels
                                SqlCmd = new SqlCommand("UPDATE CATEGORIEMISSION SET DESCRIPTION_CATEG_MISS=@DESCRIPTION_CATEG_MISS,TYPE_CATEG_MISS=@TYPE_CATEG_MISS, PAYS_CONTICATEG_MISS=@PAYS_CONTICATEG_MISS, MONTANT_CATEG_MISS=@MONTANT_CATEG_MISS, NOTE_CATEG_MISS=@NOTE_CATEG_MISS WHERE CODE_CATEG_MISS='" + TxtCodCateg.Text + "'; ", Conn.cn);
                                SqlCmd.Parameters.AddWithValue("@DESCRIPTION_CATEG_MISS", CbxCategProfFonct.Text);
                                SqlCmd.Parameters.AddWithValue("@TYPE_CATEG_MISS", CbxType.Text);
                                SqlCmd.Parameters.AddWithValue("@PAYS_CONTICATEG_MISS", CbxPaysContinent.Text);
                                SqlCmd.Parameters.AddWithValue("@MONTANT_CATEG_MISS", decimal.Parse(TxtMontant.Text));
                                SqlCmd.Parameters.AddWithValue("@NOTE_CATEG_MISS", RTxtNoteType.Text);
                                SqlCmd.ExecuteNonQuery();
                                MessageBox.Show("Votre modification a été prise compte !", "Fleet: Modification de données", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Display data in datagridview
                                CleanFiled();
                                // Clear the fields provider of car
                                rafraichirDgvCateg();
                            }
                        }
                    }
                }
                else
                    MessageBox.Show("Veillez saisir obligatoirement les champs (*) !" +"\n"+ "Saisir également un montant supérieur à 0 dans le champ montant !", "Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MenuDeleteCateg_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("Attention: Cet objet peut être lié à des enregistrements"+"\n"+ "Si oui veillez vérifier cela avant la suppression svp !"+"\n"+"Voulez vous supprimer cet objet ?"), "Fleet: Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                    ConnectDB Conn = new ConnectDB(connectionString);
                    using (Conn.cn)
                    {
                        if (Conn.IsConnection)
                        {
                            string KeyCategDelete = dgvCategMission.SelectedRows[0].Cells[0].Value.ToString();
                            using (var Cmd = Conn.cn.CreateCommand())
                            {
                                Cmd.CommandText = "DELETE FROM CATEGORIEMISSION WHERE CODE_CATEG_MISS = '" + KeyCategDelete + "' ";
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
    }
}
