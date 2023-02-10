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
    public partial class FormCreateAssurance : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataReader MyReader;
        private DataSet Ds;
        private SqlDataAdapter SqlAda;
        private Guid IdVehiculeAssur;
        public FormCreateAssurance()
        {
            InitializeComponent();
            fillVehiculeAssur();
        }

        private void iconBtnCloseFormCreateAssur_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconBtnAssCreateVisitTech_Click(object sender, EventArgs e)
        {
            
        }

        private void iconBtnSavedAssurance_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnCreateCar = new ToolTip();
            ToolTipBtnCreateCar.AutoPopDelay = 5000;
            ToolTipBtnCreateCar.InitialDelay = 1000;
            ToolTipBtnCreateCar.ReshowDelay = 500;
            ToolTipBtnCreateCar.ShowAlways = true;
            ToolTipBtnCreateCar.SetToolTip(this.iconBtnSavedAssurance, "Enregistrer");
        }

        private void iconBtUploadDocAssu_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnCreateCar = new ToolTip();
            ToolTipBtnCreateCar.AutoPopDelay = 5000;
            ToolTipBtnCreateCar.InitialDelay = 1000;
            ToolTipBtnCreateCar.ReshowDelay = 500;
            ToolTipBtnCreateCar.ShowAlways = true;
            ToolTipBtnCreateCar.SetToolTip(this.iconBtUploadDocAssu, "Joindre doc.");
        }

        // Fill combobox vehicule
        private void fillVehiculeAssur()
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
                            cbxCarAssur.Items.Add(MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            cbxCarAssur.DisplayMember = (MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            cbxCarAssur.ValueMember = (MyReader["ID_VEHICULE"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Methode te generate code
        private string generateCodeAssur()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {
                // Generate code of car
                SqlCmd = new SqlCommand("SELECT CODE_ASSUR FROM ASSURANCE WHERE CODE_ASSUR=(SELECT MAX(CODE_ASSUR) FROM ASSURANCE)", Conn.cn);
                SqlAda = new SqlDataAdapter(SqlCmd);
                Ds = new DataSet();
                SqlAda.Fill(Ds);

                if (Ds.Tables[0].Rows.Count > 0)
                {
                    txtCodeAssur.Text = Ds.Tables[0].Rows[0]["CODE_ASSUR"].ToString();
                }
                else
                {
                    txtCodeAssur.Text = "ASSUR0000";
                }
                if (!string.IsNullOrEmpty(txtCodeAssur.Text))
                {
                    txtCodeAssur.SelectionStart = 5;
                    txtCodeAssur.SelectionLength = 4;
                    txtCodeAssur.Text = txtCodeAssur.SelectedText;
                }
                if (!string.IsNullOrEmpty(txtCodeAssur.Text))
                {
                    int CodeFour = int.Parse(txtCodeAssur.Text.ToString()) + 1;
                    txtCodeAssur.Text = CodeFour.ToString("ASSUR0000");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc : Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return txtCodeAssur.Text;
        }

        private void iconBtnSavedAssurance_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                DialogResult result = MessageBox.Show("Voulez vous enregister cette assurance pour ce véhicule ?", "GESTPARC: CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (Conn.IsConnection)
                    {
                        using(var Cmd = Conn.cn.CreateCommand())
                        {
                            if (!string.IsNullOrEmpty(cbxCarAssur.Text))
                            {
                                if (!string.IsNullOrEmpty(txtAssureur.Text))
                                {
                                    if (!string.IsNullOrEmpty(txtAmountAssur.Text))
                                    {
                                        Cmd.CommandText = "INSERT INTO ASSURANCE (ID_VEHICULE,CODE_ASSUR,TYPEASSURANCE_ASSUR,ASSUREUR_ASSUR,NOTE_ASSUR,COUT_ASSUR,STATUT_ASSUR,DATEASSUR_ASSUR,DATECREATE_ASSUR) VALUES (@ID_VEHICULE,@CODE_ASSUR,@TYPEASSURANCE_ASSUR,@ASSUREUR_ASSUR,@NOTE_ASSUR,@COUT_ASSUR,@STATUT_ASSUR,@DATEASSUR_ASSUR,GETDATE())";
                                        Cmd.Parameters.AddWithValue("@ID_VEHICULE", IdVehiculeAssur);
                                        Cmd.Parameters.AddWithValue("@CODE_ASSUR", generateCodeAssur());
                                        Cmd.Parameters.AddWithValue("@TYPEASSURANCE_ASSUR", cbxTypeAssur.Text);
                                        Cmd.Parameters.AddWithValue("@ASSUREUR_ASSUR", txtAssureur.Text);
                                        Cmd.Parameters.AddWithValue("@NOTE_ASSUR", txtNoteAssur.Text);
                                        Cmd.Parameters.AddWithValue("@COUT_ASSUR", decimal.Parse(txtAmountAssur.Text));
                                        Cmd.Parameters.AddWithValue("@STATUT_ASSUR", "Assuré");
                                        Cmd.Parameters.AddWithValue("@DATEASSUR_ASSUR", dateRegisterAssur.Value.ToString("dd/MM/yyyy"));
                                        Cmd.ExecuteNonQuery();
                                        //MessageBox.Show("Assur : " + cbxTypeAssur);
                                        Cmd.Parameters.Clear();

                                        // Update the date car of assurance
                                        Cmd.CommandText = "UPDATE VEHICULE SET ASSURANCE_VEHICULE=@ASSURANCE_VEHICULE WHERE ID_VEHICULE='" + IdVehiculeAssur + "'";
                                        Cmd.Parameters.AddWithValue("@ASSURANCE_VEHICULE", dateRegisterAssur.Value.ToString("dd/MM/yyyy"));
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
                                MessageBox.Show("Veillez choisir le véhicule svp !","GestParc : Avertissement",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"GestParc : Gestion des erreurs",MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void cbxCarAssur_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_VEHICULE, IMMATRICULATION_VEHICULE  FROM VEHICULE WHERE IMMATRICULATION_VEHICULE = '" + cbxCarAssur.Text + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdVehiculeAssur = Guid.Parse(MyReader[0].ToString());
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: Gestion error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
