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

namespace GestPark.Validations
{
    public partial class FormTransitionDemandeVehicule : Form
    {
        private SqlDataAdapter SqlAda;
        private SqlCommand SqlCmd;
        private SqlDataReader MyReader;
        private Guid? IdStartStatut, IdEndStatut, IdNiveau, IdTrans;
        private static string descriptionTransition;
        public FormTransitionDemandeVehicule()
        {
            InitializeComponent();
            displayRolesInCheckListBox();
            fillComboboxNiveauDeValidationMvt();
            fillComboboxStartTransition();
            RafraichirDataGridViewTransMvt();
        }

        // Afficher l'element crée dans le datagridview des rôles
        private void displayRolesInCheckListBox()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);

                if (Conn.IsConnection)
                {
                    using (var Cmd = Conn.cn.CreateCommand())
                    {
                        Cmd.CommandText = "select ID_ROLE, DESCRIPTION_ROLE from roles";
                        SqlAda = new SqlDataAdapter(Cmd);
                        DataTable tb = new DataTable();
                        SqlAda.Fill(tb);

                        ((ListBox)checkedListBoxRoleTrans).DataSource = tb;
                        ((ListBox)checkedListBoxRoleTrans).DisplayMember = "DESCRIPTION_ROLE";
                        ((ListBox)checkedListBoxRoleTrans).ValueMember = "ID_ROLE";

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Code pour remplir les differents niveaux de validations dans le combobox
        private void fillComboboxNiveauDeValidationMvt()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {
                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("SELECT * FROM NIVEAUVALIDATION", Conn.cn);
                    MyReader = SqlCmd.ExecuteReader();
                    while (MyReader.Read())
                    {
                        cbxNiveauTransMvt.Items.Add(new KeyValuePair<Guid, string>((Guid)MyReader["ID_NIVVAL"], MyReader["DESCRIPTION_NIVVAL"].ToString()));
                        cbxNiveauTransMvt.DisplayMember = "Value";
                        cbxNiveauTransMvt.ValueMember = "Key";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCloseTransition_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Code pour remplir les statuts de validation dans le combobox................
        private void fillComboboxStartTransition()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {
                if (Conn.IsConnection)
                {
                    SqlCmd = new SqlCommand("SELECT * FROM VALIDATIONMOUVEMENTCAR", Conn.cn);
                    MyReader = SqlCmd.ExecuteReader();
                    while (MyReader.Read())
                    {
                        // Combobox Début
                        cbxDebutTransMvt.Items.Add(new KeyValuePair<Guid, string>((Guid)MyReader["ID_VALMVT"], MyReader["DESCRIPTION_VALMVT"].ToString()));
                        cbxDebutTransMvt.DisplayMember = "Value";
                        cbxDebutTransMvt.ValueMember = "Key";

                        // Combobox Fin
                        cbxFinTransMvt.Items.Add(new KeyValuePair<Guid, string>((Guid)MyReader["ID_VALMVT"], MyReader["DESCRIPTION_VALMVT"].ToString()));
                        cbxFinTransMvt.DisplayMember = "Value";
                        cbxFinTransMvt.ValueMember = "Key";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnValiderTransMvt_Click(object sender, EventArgs e)
        {
            InsertDemandeCarTrans();
        }

        private void cbxDebutTransMvt_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);

            try
            {
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_VALMVT FROM VALIDATIONMOUVEMENTCAR WHERE DESCRIPTION_VALMVT = '" + cbxDebutTransMvt.Text + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdStartStatut = Guid.Parse(MyReader[0].ToString());
                            //MessageBox.Show("IdStartStatut :" + IdStartStatut);
                        }
                    }
                    else
                        MessageBox.Show("Veillez réviser les paramètres de connexion à la base de données", "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxFinTransMvt_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_VALMVT FROM VALIDATIONMOUVEMENTCAR WHERE DESCRIPTION_VALMVT = '" + cbxFinTransMvt.Text + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdEndStatut = Guid.Parse(MyReader[0].ToString());
                        }
                    }
                    else
                        MessageBox.Show("Veillez réviser les paramètres de connexion à la base de données", "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAnnulerTransMvt_Click(object sender, EventArgs e)
        {
            CleanFieldsTrans();
        }

        private void dgvTransitionDemandeVehi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvTransMvt = dgvTransitionDemandeVehi.Rows[e.RowIndex];
                txtIDTransMvt.Text = dgvTransMvt.Cells["ID_TRANSASKCAR"].Value.ToString();
                txtDescriptionTransMvt.Text = dgvTransMvt.Cells["DESCRIPTION_TRANSASKCAR"].Value.ToString();
                cbxDebutTransMvt.Text = dgvTransMvt.Cells["STATUT_1"].Value.ToString();
                cbxFinTransMvt.Text = dgvTransMvt.Cells["STATUT_2"].Value.ToString();
                cbxNiveauTransMvt.Text = dgvTransMvt.Cells["DESCRIPTION_NIVVAL"].Value.ToString();

                // Afficher les rôles associés à chaque transition
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
                                Cmd.CommandText = "SELECT * FROM ROLESTRANSITIONDEMANDEVEHICULE WHERE ID_TRANSASKCAR = '" + Guid.Parse(txtIDTransMvt.Text) + "' ";
                                MyReader = Cmd.ExecuteReader();
                                for (int i = 0; i < checkedListBoxRoleTrans.Items.Count; i++)
                                {
                                    checkedListBoxRoleTrans.SetItemChecked(i, false);
                                }

                                if (MyReader != null)
                                {
                                    while (MyReader.Read())
                                    {
                                        string idRole = MyReader["ID_ROLE"].ToString();
                                       
                                        for (int i = 0; i < checkedListBoxRoleTrans.Items.Count; i++)
                                        {
                                            if (((System.Data.DataRowView)checkedListBoxRoleTrans.Items[i]).Row.ItemArray[0].ToString().ToLower() == idRole.ToString().ToLower())
                                            {
                                                //MessageBox.Show("Test");
                                                checkedListBoxRoleTrans.SetItemChecked(i, true);
                                            }
                                        }
                                    }
                                }


                                checkedListBoxRoleTrans.Refresh();
                            }
                        }
                        else
                            MessageBox.Show("Veillez réviser votre paramètres de connexion à la base de données.", "Fleet: Gestion des erreus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtFilterTransition_TextChanged(object sender, EventArgs e)
        {
            (dgvTransitionDemandeVehi.DataSource as DataTable).DefaultView.RowFilter = "DESCRIPTION_TRANSASKCAR LIKE '%" + txtFilterTransition.Text + "%' ";
        }

        private void btnEditTransMvt_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);

                if (Conn.IsConnection)
                {
                    if (!string.IsNullOrEmpty(txtDescriptionTransMvt.Text) && !string.IsNullOrEmpty(cbxNiveauTransMvt.Text) && !string.IsNullOrEmpty(cbxDebutTransMvt.Text) && !string.IsNullOrEmpty(cbxFinTransMvt.Text))
                    {
                        if (!string.IsNullOrEmpty(txtIDTransMvt.Text))
                        {
                            using (var Cmd = Conn.cn.CreateCommand())
                            {
                                // Inserer les données dans la table transition
                                Cmd.CommandText = "UPDATE TRANSITIONDEMANDEVEHICULE SET ID_NIVVAL=@ID_NIVVAL,ID_DEBUT_TRANSASKCAR=@ID_DEBUT_TRANSASKCAR,ID_FIN_TRANSASKCAR=@ID_FIN_TRANSASKCAR,DESCRIPTION_TRANSASKCAR=@DESCRIPTION_TRANSASKCAR,USERMODIFY=GETDATE() WHERE ID_TRANSASKCAR='"+Guid.Parse(txtIDTransMvt.Text.ToLower())+"'";
                                Cmd.Parameters.AddWithValue("@ID_NIVVAL", IdNiveau);
                                Cmd.Parameters.AddWithValue("@ID_DEBUT_TRANSASKCAR", IdStartStatut);
                                Cmd.Parameters.AddWithValue("@ID_FIN_TRANSASKCAR", IdEndStatut);
                                Cmd.Parameters.AddWithValue("@DESCRIPTION_TRANSASKCAR", txtDescriptionTransMvt.Text);
                                Cmd.ExecuteNonQuery();
                                Cmd.Parameters.Clear();
                            }

                            /*
                             * Supprimer tous les rôles associés à la transion
                             */

                            using (var Cmd = Conn.cn.CreateCommand())
                            {
                                // Inserer les données dans la table transition
                                Cmd.CommandText = "DELETE FROM ROLESTRANSITIONDEMANDEVEHICULE WHERE ID_TRANSASKCAR=@paramIdTransDelete";
                                Cmd.Parameters.AddWithValue("@paramIdTransDelete", Guid.Parse(txtIDTransMvt.Text));
                                Cmd.ExecuteNonQuery();
                            }

                            /*
                             * Inserer de nouveaux rôles associés à cette transition
                             */

                            if (checkedListBoxRoleTrans.CheckedItems != null)
                            {
                                foreach (var obj in checkedListBoxRoleTrans.CheckedItems)
                                {
                                    Guid IdchekclistRole = Guid.Parse(((System.Data.DataRowView)(obj)).Row.ItemArray[0].ToString());
                                    //MessageBox.Show("Insertion des rôles asssociés à la transition : " + valIdchekclistRole + "la transition : " + IdTrans);
                                    // Inserer les données dans la table roletransition
                                    using (var Cmd = Conn.cn.CreateCommand())
                                    {
                                        Cmd.CommandText = "INSERT INTO ROLESTRANSITIONDEMANDEVEHICULE (ID_TRANSASKCAR,ID_ROLE) VALUES (@ID_TRANSASKCAR,@ID_ROLE)";
                                        Cmd.Parameters.AddWithValue("@ID_TRANSASKCAR", Guid.Parse(txtIDTransMvt.Text));
                                        Cmd.Parameters.AddWithValue("@ID_ROLE", IdchekclistRole);
                                        Cmd.ExecuteNonQuery();
                                        Cmd.Parameters.Clear();
                                    }
                                }
                            }

                            RafraichirDataGridViewTransMvt();

                            // Clean the fields
                            txtDescriptionTransMvt.Clear(); cbxDebutTransMvt.Text = null; cbxFinTransMvt.Text = null; cbxNiveauTransMvt.Text = null; checkedListBoxRoleTrans.Refresh();
                            MessageBox.Show("Modification effectuée avec succès !!!", "Fleet: Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RafraichirDataGridViewTransMvt();
                            //MessageBox.Show("id de la trabsition créée = " + IdTrans);                         
                        }
                        else
                            MessageBox.Show("Aucune ligne sélectionnée dans le tableau pour la modification !", "Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                        MessageBox.Show("Veillez saisir tout les champs obligatoires (*).", "Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Veillez réviser les paramètres de connexion à la base de donnée !", "Fleet: Connexion à la base de donnée", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRafraichirTransMvt_Click(object sender, EventArgs e)
        {
            RafraichirDataGridViewTransMvt();
        }

        private void cbxNiveauTransMvt_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_NIVVAL FROM NIVEAUVALIDATION WHERE DESCRIPTION_NIVVAL = '" + cbxNiveauTransMvt.Text + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdNiveau = Guid.Parse(MyReader[0].ToString());
                        }
                    }
                    else
                        MessageBox.Show("Veillez réviser les paramètres de connexion à la base de données", "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Rafraîchir le datagrid
        private void RafraichirDataGridViewTransMvt()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);

                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        //Display data in datagridview
                        SqlAda = new SqlDataAdapter("SELECT T.ID_TRANSASKCAR, T.DESCRIPTION_TRANSASKCAR, STATUT_DEBUT.DESCRIPTION_VALMVT AS STATUT_1, STATUT_FIN.DESCRIPTION_VALMVT AS STATUT_2, T.DATECREATE_TRANSASKCAR, T.DATEMODIFY_TRANSASKCAR, T.USERCREATE_TRANSASKCAR, NIVEAU.ID_NIVVAL, NIVEAU.DESCRIPTION_NIVVAL FROM TRANSITIONDEMANDEVEHICULE AS T INNER JOIN NIVEAUVALIDATION AS NIVEAU ON NIVEAU.ID_NIVVAL=T.ID_NIVVAL INNER JOIN VALIDATIONMOUVEMENTCAR  AS STATUT_DEBUT ON STATUT_DEBUT.ID_VALMVT=T.ID_DEBUT_TRANSASKCAR INNER JOIN VALIDATIONMOUVEMENTCAR  AS STATUT_FIN ON STATUT_FIN.ID_VALMVT=T.ID_FIN_TRANSASKCAR ORDER BY T.DATECREATE_TRANSASKCAR DESC", Conn.cn);
                        DataTable dt = new DataTable();
                        SqlAda.Fill(dt);

                        //Fill DataGridView
                        dgvTransitionDemandeVehi.AutoGenerateColumns = false;
                        dgvTransitionDemandeVehi.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Inserer les demandes de véhicule dans la base
        public void InsertDemandeCarTrans()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);

                if (Conn.IsConnection)
                {
                    if (!string.IsNullOrEmpty(txtDescriptionTransMvt.Text) && !string.IsNullOrEmpty(cbxNiveauTransMvt.Text) && !string.IsNullOrEmpty(cbxDebutTransMvt.Text) && !string.IsNullOrEmpty(cbxFinTransMvt.Text))
                    {
                        if (string.IsNullOrEmpty(txtIDTransMvt.Text))
                        {
                            using (var Cmd = Conn.cn.CreateCommand())
                            {
                                // Inserer les données dans la table transition
                                Cmd.CommandText = "INSERT INTO TRANSITIONDEMANDEVEHICULE (ID_NIVVAL,ID_DEBUT_TRANSASKCAR,ID_FIN_TRANSASKCAR,DESCRIPTION_TRANSASKCAR,DATECREATE_TRANSASKCAR) VALUES (@ID_NIVVAL,@ID_DEBUT_TRANSASKCAR,@ID_FIN_TRANSASKCAR,@DESCRIPTION_TRANSASKCAR,GETDATE())";
                                Cmd.Parameters.AddWithValue("@ID_NIVVAL", IdNiveau);
                                Cmd.Parameters.AddWithValue("@ID_DEBUT_TRANSASKCAR", IdStartStatut);
                                Cmd.Parameters.AddWithValue("@ID_FIN_TRANSASKCAR", IdEndStatut);
                                Cmd.Parameters.AddWithValue("@DESCRIPTION_TRANSASKCAR", txtDescriptionTransMvt.Text);
                                Cmd.ExecuteNonQuery();
                                Cmd.Parameters.Clear();
                            }

                            // Recuperer l'id de la transaction créée
                            using (var Cmd = Conn.cn.CreateCommand())
                            {
                                // Inserer les données dans la table transition
                                descriptionTransition = txtDescriptionTransMvt.Text;
                                //MessageBox.Show("Le nom de la trabsition créée = " + descriptionTransition);
                                Cmd.CommandText = "SELECT ID_TRANSASKCAR FROM TRANSITIONDEMANDEVEHICULE WHERE DESCRIPTION_TRANSASKCAR=@DESCRIPTION_TRANSASKCAR";
                                Cmd.Parameters.AddWithValue("@DESCRIPTION_TRANSASKCAR", descriptionTransition);
                                MyReader = Cmd.ExecuteReader();

                                while (MyReader.Read())
                                {
                                    IdTrans = Guid.Parse(MyReader["ID_TRANSASKCAR"].ToString());
                                }

                                //MessageBox.Show("id de la trabsition créée = " + IdTrans);

                                Cmd.Parameters.Clear();
                                MyReader.Close();
                            }

                            if (checkedListBoxRoleTrans.CheckedItems != null)
                            {
                                foreach (var obj in checkedListBoxRoleTrans.CheckedItems)
                                {
                                    var valIdchekclistRole = ((System.Data.DataRowView)(obj)).Row.ItemArray[0];
                                    //MessageBox.Show("Insertion des rôles asssociés à la transition : " + valIdchekclistRole + "la transition : " + IdTrans);
                                    // Inserer les données dans la table roletransition
                                    using (var Cmd = Conn.cn.CreateCommand())
                                    {
                                        Cmd.CommandText = "INSERT INTO ROLESTRANSITIONDEMANDEVEHICULE (ID_TRANSASKCAR,ID_ROLE) VALUES (@ID_TRANSASKCAR,@ID_ROLE)";
                                        Cmd.Parameters.AddWithValue("@ID_TRANSASKCAR", IdTrans);
                                        Cmd.Parameters.AddWithValue("@ID_ROLE", valIdchekclistRole);
                                        Cmd.ExecuteNonQuery();
                                        Cmd.Parameters.Clear();
                                    }
                                }
                            }

                            RafraichirDataGridViewTransMvt();
                            // Clean the fields
                            CleanFieldsTrans();
                            MessageBox.Show("Bravo vous venez de créer une transaction avec succès !!!", "Fleet: Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //MessageBox.Show("id de la trabsition créée = " + IdTrans);
                        }
                        else
                            MessageBox.Show("Cette transition existe déjà !", "Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                        MessageBox.Show("Veillez saisir tout les champs obligatoires (*).", "Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Veillez réviser les paramètres de connexion à la base de donnée !", "Fleet: Connexion à la base de donnée", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Clean the fields
        private void CleanFieldsTrans()
        {
            txtDescriptionTransMvt.Clear(); cbxDebutTransMvt.Text = null; cbxFinTransMvt.Text = null; cbxNiveauTransMvt.Text = null; txtIDTransMvt.Clear();
            for (int i = 0; i < checkedListBoxRoleTrans.Items.Count; i++)
            {
                checkedListBoxRoleTrans.SetItemChecked(i, false);
            }
        }
    }
}
