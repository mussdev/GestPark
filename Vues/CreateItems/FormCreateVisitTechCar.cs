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
    public partial class FormCreateVisitTechCar : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataReader MyReader;
        private SqlDataAdapter SqlAda;
        private DataSet Ds;
        private Guid? IdCarVisitTech, IdGarageVisitTech=null;
        public FormCreateVisitTechCar()
        {
            InitializeComponent();
            ListCarVisitTech();
            ListeGaragiste();
        }

        private void iconBtnSavedVisit_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnCreateVisit = new ToolTip();
            ToolTipBtnCreateVisit.AutoPopDelay = 5000;
            ToolTipBtnCreateVisit.InitialDelay = 1000;
            ToolTipBtnCreateVisit.ReshowDelay = 500;
            ToolTipBtnCreateVisit.ShowAlways = true;
            ToolTipBtnCreateVisit.SetToolTip(this.iconBtnSavedVisit, "Enregistrer");
        }

        private void iconBtUploadDocVisit_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnJoinDocVisit = new ToolTip();
            ToolTipBtnJoinDocVisit.AutoPopDelay = 5000;
            ToolTipBtnJoinDocVisit.InitialDelay = 1000;
            ToolTipBtnJoinDocVisit.ReshowDelay = 500;
            ToolTipBtnJoinDocVisit.ShowAlways = true;
            ToolTipBtnJoinDocVisit.SetToolTip(this.iconBtUploadDocVisit, "Joindre doc.");
        }

        // list vehicule of visit tech
        private void ListCarVisitTech()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT*FROM VEHICULE", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            cbxCarVisitTech.Items.Add(MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            cbxCarVisitTech.DisplayMember = (MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            cbxCarVisitTech.ValueMember = (MyReader["ID_VEHICULE"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxCarVisitTech_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_VEHICULE FROM VEHICULE WHERE IMMATRICULATION_VEHICULE = '" + cbxCarVisitTech.SelectedItem + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdCarVisitTech = Guid.Parse(MyReader[0].ToString());
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
        private void ListeGaragiste()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT*FROM GARAGE", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            cbxGaragistre.Items.Add(MyReader["PROPRIETAIRE_GARAGE"].ToString());
                            cbxGaragistre.DisplayMember = (MyReader["PROPRIETAIRE_GARAGE"].ToString());
                            cbxGaragistre.ValueMember = (MyReader["ID_GARAGE"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iconBtnSavedVisit_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                DialogResult result = MessageBox.Show("Voulez vous enregister cette visite technique pour ce véhicule ?", "GESTPARC: CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (Conn.IsConnection)
                    {
                        using (var Cmd = Conn.cn.CreateCommand())
                        {
                            if (!string.IsNullOrEmpty(cbxCarVisitTech.Text))
                            {
                                if (!string.IsNullOrEmpty(txtEntreprise.Text))
                                {
                                    if (!string.IsNullOrEmpty(txtFraisDossierVisit.Text) && decimal.Parse(txtFraisDossierVisit.Text) > 0)
                                    {
                                        if (!string.IsNullOrEmpty(txtFraisVignette.Text) && decimal.Parse(txtFraisVignette.Text) > 0)
                                        {
                                            if(!string.IsNullOrEmpty(txtFraisGaragiste.Text) && decimal.Parse(txtFraisGaragiste.Text) > 0)
                                            {
                                                Cmd.CommandText = "INSERT INTO VISITETECHNIQUE (ID_VEHICULE,ID_GARAGE,STATUT_VISIT,CODE_VISIT,FRAIS_DOSSIER_VISIT,PRIX_VIGNET_VISIT,FRAIS_GARAGISTE,ENTREPRISE_VISIT,NOTE_VISIT,DATE_VISIT,DATECREATE_VISIT) VALUES (@ID_VEHICULE,@ID_GARAGE,@STATUT_VISIT,@CODE_VISIT,@FRAIS_DOSSIER_VISIT,@PRIX_VIGNET_VISIT,@FRAIS_GARAGISTE,@ENTREPRISE_VISIT,@NOTE_VISIT,@DATE_VISIT,GETDATE())";
                                                Cmd.Parameters.AddWithValue("@ID_VEHICULE", IdCarVisitTech);

                                                if (IdGarageVisitTech.HasValue)
                                                    Cmd.Parameters.AddWithValue("@ID_GARAGE", IdGarageVisitTech.Value);
                                                else
                                                    Cmd.Parameters.AddWithValue("@ID_GARAGE", DBNull.Value);

                                                Cmd.Parameters.AddWithValue("@STATUT_VISIT", cbxCarVisitTech.Text);
                                                Cmd.Parameters.AddWithValue("@CODE_VISIT", generateCodeVisitTech());
                                                Cmd.Parameters.AddWithValue("@FRAIS_DOSSIER_VISIT", decimal.Parse(txtFraisDossierVisit.Text));
                                                Cmd.Parameters.AddWithValue("@PRIX_VIGNET_VISIT", decimal.Parse(txtFraisVignette.Text));
                                                Cmd.Parameters.AddWithValue("@FRAIS_GARAGISTE", decimal.Parse(txtFraisGaragiste.Text));
                                                Cmd.Parameters.AddWithValue("@ENTREPRISE_VISIT", txtEntreprise.Text);
                                                Cmd.Parameters.AddWithValue("@NOTE_VISIT", rtxtNote.Text);
                                                Cmd.Parameters.AddWithValue("@DATE_VISIT", dateRegisterVisitTech.Value.ToString("dd/MM/yyyy"));
                                                Cmd.ExecuteNonQuery();
                                                //MessageBox.Show("Assur : " + cbxTypeAssur);
                                                Cmd.Parameters.Clear();

                                                //Update the date car of assurance
                                                Cmd.CommandText = "UPDATE VEHICULE SET DATE_VISITE_VEHICULE=@DATE_VISITE_VEHICULE WHERE ID_VEHICULE='" + IdCarVisitTech + "'";
                                                Cmd.Parameters.AddWithValue("@DATE_VISITE_VEHICULE", dateRegisterVisitTech.Value);
                                                Cmd.ExecuteNonQuery();
                                                Cmd.Parameters.Clear();
                                                MessageBox.Show("Vos informations pour la visite technique a été enregistrées avec succès !", "GestParc: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                this.Close();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Veillez saisir les frais du garagiste ou un montant superieur à zéro svp !", "GestParc: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Veillez saisir les frais de vignette ou un montant superieur à zéro svp !", "GestParc: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Veillez saisir les frais de dossier ou un montant superieur à zéro svp !", "GestParc: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Veillez saisir l'entreprise qui fait la visite svp !", "GestParc: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Veillez choisir le véhicule svp !", "GestParc: Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxGaragistre_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_GARAGE,DESCRIPTION_GARAGE FROM GARAGE WHERE DESCRIPTION_GARAGE = '" + cbxGaragistre.SelectedItem + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdGarageVisitTech = Guid.Parse(MyReader["ID_GARAGE"].ToString());
                            txtGarageVisit.Text = MyReader[1].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Methode te generate code
        private string generateCodeVisitTech()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {
                // Generate code of car
                SqlCmd = new SqlCommand("SELECT CODE_VISIT FROM VISITETECHNIQUE WHERE CODE_VISIT=(SELECT MAX(CODE_VISIT) FROM VISITETECHNIQUE)", Conn.cn);
                SqlAda = new SqlDataAdapter(SqlCmd);
                Ds = new DataSet();
                SqlAda.Fill(Ds);

                if (Ds.Tables[0].Rows.Count > 0)
                {
                    txtCodVisitTech.Text = Ds.Tables[0].Rows[0]["CODE_VISIT"].ToString();
                }
                else
                {
                    txtCodVisitTech.Text = "VISITTECH0000";
                }
                if (!string.IsNullOrEmpty(txtCodVisitTech.Text))
                {
                    txtCodVisitTech.SelectionStart = 9;
                    txtCodVisitTech.SelectionLength = 4;
                    txtCodVisitTech.Text = txtCodVisitTech.SelectedText;
                }
                if (!string.IsNullOrEmpty(txtCodVisitTech.Text))
                {
                    int CodeFour = int.Parse(txtCodVisitTech.Text.ToString()) + 1;
                    txtCodVisitTech.Text = CodeFour.ToString("VISITTECH0000");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return txtCodVisitTech.Text;
        }
    }
}
