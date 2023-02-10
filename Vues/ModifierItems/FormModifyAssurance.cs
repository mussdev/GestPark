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
    public partial class FormModifyAssurance : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataAdapter SqlAda;
        private DataSet Ds;
        private SqlDataReader MyReader;
        private Guid IdVehiculeAssurMod;
        public FormModifyAssurance()
        {
            InitializeComponent();
            fillVehiculeAssurMod();
        }

        private void cbxCarAssurMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_VEHICULE, IMMATRICULATION_VEHICULE  FROM VEHICULE WHERE IMMATRICULATION_VEHICULE = '" + cbxCarAssurMod.Text + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdVehiculeAssurMod = Guid.Parse(MyReader[0].ToString());
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Fill combobox vehicule
        private void fillVehiculeAssurMod()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT*FROM VEHICULE WHERE TYPE_VEHICULE = 'pool' AND SANTE_VEHICULE = 'Bon' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            cbxCarAssurMod.Items.Add(MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            cbxCarAssurMod.DisplayMember = (MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            cbxCarAssurMod.ValueMember = (MyReader["ID_VEHICULE"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iconBtnSavedAssurMod_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                DialogResult result = MessageBox.Show("Voulez vous enregister les modifiactions sur cette assurance ?", "GESTPARC: CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (Conn.IsConnection)
                    {
                        using (var Cmd = Conn.cn.CreateCommand())
                        {
                            if (!string.IsNullOrEmpty(cbxCarAssurMod.Text))
                            {
                                if (!string.IsNullOrEmpty(txtAssureurMod.Text))
                                {
                                    if (!string.IsNullOrEmpty(txtAmountAssurMod.Text))
                                    {
                                        Cmd.CommandText = "UPDATE ASSURANCE SET ID_VEHICULE=@ID_VEHICULE,TYPEASSURANCE_ASSUR=@TYPEASSURANCE_ASSUR,ASSUREUR_ASSUR=@ASSUREUR_ASSUR,NOTE_ASSUR=@NOTE_ASSUR,COUT_ASSUR=@COUT_ASSUR,STATUT_ASSUR=@STATUT_ASSUR,DATEASSUR_ASSUR=@DATEASSUR_ASSUR,DATEMODIFIER_ASSUR=GETDATE() WHERE CODE_ASSUR='"+ txtCodeAssurMod.Text +"'";
                                        Cmd.Parameters.AddWithValue("@ID_VEHICULE", IdVehiculeAssurMod);
                                        Cmd.Parameters.AddWithValue("@TYPEASSURANCE_ASSUR", cbxTypeAssurMod.Text);
                                        Cmd.Parameters.AddWithValue("@ASSUREUR_ASSUR", txtAssureurMod.Text);
                                        Cmd.Parameters.AddWithValue("@NOTE_ASSUR", txtNoteAssurMod.Text);
                                        Cmd.Parameters.AddWithValue("@COUT_ASSUR", decimal.Parse(txtAmountAssurMod.Text));
                                        Cmd.Parameters.AddWithValue("@STATUT_ASSUR", cbxStatutAssurMod.Text);
                                        Cmd.Parameters.AddWithValue("@DATEASSUR_ASSUR", dateRegisterAssurMod.Value.ToString("dd/MM/yyyy"));
                                        Cmd.ExecuteNonQuery();
                                        Cmd.Parameters.Clear();

                                        // Update the date car of assurance
                                        Cmd.CommandText = "UPDATE VEHICULE SET ASSURANCE_VEHICULE=@ASSURANCE_VEHICULE WHERE ID_VEHICULE='" + IdVehiculeAssurMod + "'";
                                        Cmd.Parameters.AddWithValue("@ASSURANCE_VEHICULE", dateRegisterAssurMod.Value.ToString("dd/MM/yyyy"));
                                        Cmd.ExecuteNonQuery();
                                        Cmd.Parameters.Clear();
                                        MessageBox.Show("Votre véhicule est assuré bravo !", "GestParc : Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Veillez saisir le montant de l'assurance svp !", "GestParc : Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Veillez saisir l'assureur svp !", "GestParc : Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Veillez choisir le véhicule svp !", "GestParc : Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc : Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
