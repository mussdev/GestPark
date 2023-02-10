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
using GestPark.Validations;

namespace GestPark
{
    public partial class FormValidationMouvementCar : Form
    {
        private SqlDataAdapter SqlAda;
        public FormValidationMouvementCar()
        {
            InitializeComponent();
            RafraichirValMvt();
        }

        private void btnValiderValMvt_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);

                if (string.IsNullOrEmpty(txtDescriptionValidationMvt.Text))
                {
                    MessageBox.Show("Veillez saisir tous les champs obligatoires !", "Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    using (Conn.cn)
                    {
                        if (Conn.IsConnection)
                        {

                            if (string.IsNullOrEmpty(txtIdValMvt.Text))
                            {
                                using(var Cmd = Conn.cn.CreateCommand())
                                {
                                    Cmd.CommandText = "INSERT INTO VALIDATIONMOUVEMENTCAR (DESCRIPTION_VALMVT,CHECKVEROUS_VALMVT,NOTE_VALMVT,DATECREATE_VALMVT) VALUES (@DESCRIPTION_VALMVT,@CHECKVEROUS_VALMVT,@NOTE_VALMVT,GETDATE())";
                                    Cmd.Parameters.AddWithValue("@DESCRIPTION_VALMVT",txtDescriptionValidationMvt.Text);
                                    Cmd.Parameters.AddWithValue("@CHECKVEROUS_VALMVT", checkBoxVerousValMvt.Checked);
                                    Cmd.Parameters.AddWithValue("@NOTE_VALMVT",RtxtNoteValidationMvt.Text);
                                    Cmd.ExecuteNonQuery();

                                    // Clean the fields
                                    txtDescriptionValidationMvt.Clear(); RtxtNoteValidationMvt.Clear(); checkBoxVerousValMvt.Refresh();
                                    MessageBox.Show("La validation a été créée avec succès !!!", "Fleet: Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    RafraichirValMvt();
                                }
                            }
                            else
                                MessageBox.Show("Cette validation existe déja ! Veillez saisir une nouvelle validation !", "Fleet: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
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
                        SqlAda = new SqlDataAdapter("select * from VALIDATIONMOUVEMENTCAR order by DATECREATE_VALMVT desc", Conn.cn);
                        DataTable dt = new DataTable();
                        SqlAda.Fill(dt);

                        //Fill DataGridView
                         dataGridViewValidationMvt.AutoGenerateColumns = false;
                         dataGridViewValidationMvt.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRafraichirValMvt_Click(object sender, EventArgs e)
        {
            RafraichirValMvt();
        }

        private void BtnAnnulerValMvt_Click(object sender, EventArgs e)
        {
            // Clean the fields
            txtDescriptionValidationMvt.Clear(); RtxtNoteValidationMvt.Clear(); checkBoxVerousValMvt.Refresh();
        }

        private void BtnCloseFormValMvt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewValidationMvt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvValMvt = dataGridViewValidationMvt.Rows[e.RowIndex];
                txtIdValMvt.Text = dgvValMvt.Cells["ID_VALMVT"].Value.ToString();
                txtDescriptionValidationMvt.Text = dgvValMvt.Cells["DESCRIPTION_VALMVT"].Value.ToString();
                checkBoxVerousValMvt.Checked = Convert.ToBoolean(dgvValMvt.Cells["CHECKVEROUS_VALMVT"].Value);
                RtxtNoteValidationMvt.Text = dgvValMvt.Cells["NOTE_VALMVT"].Value.ToString();
            }
        }

        private int rowIndex = 0;
        private void dataGridViewValidationMvt_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dataGridViewValidationMvt.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.dataGridViewValidationMvt.CurrentCell = this.dataGridViewValidationMvt.Rows[e.RowIndex].Cells[1];
                this.MenuValMvt.Show(this.dataGridViewValidationMvt, e.Location);
                MenuValMvt.Show(Cursor.Position);
            }
        }

        private void itemMenuDeleteValMvt_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("Voulez vous supprimer cette validation ?"), "Fleet: Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                    ConnectDB Conn = new ConnectDB(connectionString);
                    using (Conn.cn)
                    {
                        if (Conn.IsConnection)
                        {
                            string KeyGarageDelete = dataGridViewValidationMvt.SelectedRows[0].Cells[0].Value.ToString();
                            using (var Cmd = Conn.cn.CreateCommand())
                            {
                                Cmd.CommandText = "delete from VALIDATIONMOUVEMENTCAR where ID_VALMVT = '" + KeyGarageDelete + "' ";
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

        private void btnEditValMvt_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (!string.IsNullOrEmpty(txtDescriptionValidationMvt.Text))
                {
                    DialogResult result = MessageBox.Show("Voulez vous enregister les modifications ?", "Fleet: Questions", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        using (Conn.cn)
                        {
                            if (Conn.IsConnection)
                            {
                                using(var Cmd = Conn.cn.CreateCommand())
                                {
                                    Cmd.CommandText = "UPDATE VALIDATIONMOUVEMENTCAR SET DESCRIPTION_VALMVT=@DESCRIPTION_VALMVT,CHECKVEROUS_VALMVT=@CHECKVEROUS_VALMVT,NOTE_VALMVT=@NOTE_VALMVT,DATEMODIFY_VALMVT=GETDATE() WHERE ID_VALMVT='"+Guid.Parse(txtIdValMvt.Text)+"'";
                                    Cmd.Parameters.AddWithValue("@DESCRIPTION_VALMVT", txtDescriptionValidationMvt.Text);
                                    Cmd.Parameters.AddWithValue("@CHECKVEROUS_VALMVT", checkBoxVerousValMvt.Checked);
                                    Cmd.Parameters.AddWithValue("@NOTE_VALMVT", RtxtNoteValidationMvt.Text);
                                    Cmd.ExecuteNonQuery();
                                }
                                MessageBox.Show("Modification prise compte !", "Fleet: Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // Clear the fields provider of car
                                txtDescriptionValidationMvt.Clear(); txtIdValMvt.Clear(); RtxtNoteValidationMvt.Clear();checkBoxVerousValMvt.Refresh();
                                // Display data in datagridview
                                RafraichirValMvt();
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

        private void menuItemAddRole_Click(object sender, EventArgs e)
        {
            FormTransitionDemandeVehicule AddRoleToValAskCar = new FormTransitionDemandeVehicule();
            AddRoleToValAskCar.ShowDialog();
        }
    }
}
