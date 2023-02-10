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

namespace GestPark.Workflows.NiveauTransition
{
    public partial class FormNiveauTransitionDemandeCar : Form
    {
        private SqlDataAdapter SqlAda;
        public FormNiveauTransitionDemandeCar()
        {
            InitializeComponent();
            RafraichirValMvt();
        }

        private void btnNiveauTransMvt_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);

                if (Conn.IsConnection)
                {
                    if (string.IsNullOrEmpty(txtIDNiveauTransMvt.Text))
                    {
                        using (var Cmd = Conn.cn.CreateCommand())
                        {
                            Cmd.CommandText = "INSERT INTO NIVEAUVALIDATION (DESCRIPTION_NIVVAL,OBSERVATION_NIVVAL,DATECREATE_NIVVAL) VALUES (@DESCRIPTION_NIVVAL,@OBSERVATION_NIVVAL,GETDATE()) ";
                            Cmd.Parameters.AddWithValue("@DESCRIPTION_NIVVAL", txtDescriptionNiveauTransMvt.Text);
                            Cmd.Parameters.AddWithValue("@OBSERVATION_NIVVAL", richTextBoxObserNiveau.Text);
                            Cmd.ExecuteNonQuery();

                            // Clean the fields
                            txtDescriptionNiveauTransMvt.Clear(); richTextBoxObserNiveau.Clear();
                            MessageBox.Show("Le niveau de validation a été créé avec succès !!!", "Fleet: Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RafraichirValMvt();
                        }
                    }
                    else
                        MessageBox.Show("Ce niveau existe déja ! Veillez saisir un nouveau niveau de validation !", "Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }else
                    MessageBox.Show("Veillez réviser les paramètres de connexion à la base de donnée !", "Fleet: Connexion à la base de donnée", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Rafraîchir le datagrid
        private void RafraichirValMvt()
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
                        SqlAda = new SqlDataAdapter("select * from NIVEAUVALIDATION order by DATECREATE_NIVVAL desc", Conn.cn);
                        DataTable dt = new DataTable();
                        SqlAda.Fill(dt);

                        //Fill DataGridView
                        dgvNiveauTransitionVehi.AutoGenerateColumns = false;
                        dgvNiveauTransitionVehi.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRafraichirTransMvt_Click(object sender, EventArgs e)
        {
            RafraichirValMvt();
        }

        private void BtnAnnulerNiveauTransMvt_Click(object sender, EventArgs e)
        {
            txtDescriptionNiveauTransMvt.Clear();richTextBoxObserNiveau.Clear();txtIDNiveauTransMvt.Clear();
        }

        private int rowIndex = 0;
        private void dataGridViewValidationMvt_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dgvNiveauTransitionVehi.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.dgvNiveauTransitionVehi.CurrentCell = this.dgvNiveauTransitionVehi.Rows[e.RowIndex].Cells[1];
                this.MenuNiveau.Show(this.dgvNiveauTransitionVehi, e.Location);
                MenuNiveau.Show(Cursor.Position);
            }
        }

        private void MenuItemDeleteNiveau_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("Voulez vous supprimer ce niveau de validation ?"), "Fleet: Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                    ConnectDB Conn = new ConnectDB(connectionString);
                    using (Conn.cn)
                    {
                        if (Conn.IsConnection)
                        {
                            string KeyGarageDelete = dgvNiveauTransitionVehi.SelectedRows[0].Cells[0].Value.ToString();
                            using (var Cmd = Conn.cn.CreateCommand())
                            {
                                Cmd.CommandText = "delete from NIVEAUVALIDATION where ID_NIVVAL = '" + KeyGarageDelete + "' ";
                                Cmd.ExecuteNonQuery();
                                MessageBox.Show("La validation a été supprimée avec succès !", "Fleet: Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                RafraichirValMvt();
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

        private void dgvTransitionDemandeVehi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvValMvt = dgvNiveauTransitionVehi.Rows[e.RowIndex];
                txtIDNiveauTransMvt.Text = dgvValMvt.Cells["ID_NIVVAL"].Value.ToString();
                txtDescriptionNiveauTransMvt.Text = dgvValMvt.Cells["DESCRIPTION_NIVVAL"].Value.ToString();
                richTextBoxObserNiveau.Text = dgvValMvt.Cells["OBSERVATION_NIVVAL"].Value.ToString();
            }
        }

        private void btnEditNiveauTransMvt_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (!string.IsNullOrEmpty(txtDescriptionNiveauTransMvt.Text))
                {
                    DialogResult result = MessageBox.Show("Voulez vous enregister les modifications ?", "Fleet Automobi: Questions", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        using (Conn.cn)
                        {
                            if (Conn.IsConnection)
                            {
                                using (var Cmd = Conn.cn.CreateCommand())
                                {
                                    Cmd.CommandText = "UPDATE NIVEAUVALIDATION SET DESCRIPTION_NIVVAL=@DESCRIPTION_NIVVAL,OBSERVATION_NIVVAL=@OBSERVATION_NIVVAL,DATEMODIFY_NIVVAL=GETDATE() WHERE ID_NIVVAL='" + Guid.Parse(txtIDNiveauTransMvt.Text) + "'";
                                    Cmd.Parameters.AddWithValue("@DESCRIPTION_NIVVAL", txtDescriptionNiveauTransMvt.Text);
                                    Cmd.Parameters.AddWithValue("@OBSERVATION_NIVVAL", richTextBoxObserNiveau.Text);
                                    Cmd.ExecuteNonQuery();
                                }
                                MessageBox.Show("Modification prise compte !", "Fleet: Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // Display data in datagridview
                                RafraichirValMvt();
                                // Clear the fields provider of car
                                txtDescriptionNiveauTransMvt.Clear(); txtIDNiveauTransMvt.Clear(); richTextBoxObserNiveau.Clear();
                            }
                        }
                    }
                }
                else
                    MessageBox.Show("Veillez sélectionner une validation dans la table !", "Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCloseNiveau_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
