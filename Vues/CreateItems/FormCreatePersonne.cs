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
    public partial class FormCreatePersonne : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataAdapter SqlAda;
        private DataSet Ds;
        private SqlDataReader MyReader;
        private Guid IdServ;

        public FormCreatePersonne()
        {
            InitializeComponent();
            FillCbxServices();
        }

        private void iconBtnSavedPerson_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                if (string.IsNullOrEmpty(textBxNomPers.Text))
                {
                    MessageBox.Show("Veiller saisir le nom !","GestPark : Avertissement",MessageBoxButtons.OK);
                }
                else if (string.IsNullOrEmpty(textBxPrenPers.Text))
                {
                    MessageBox.Show("Veiller saisir le champ prénom !","GestPark : Avertissement", MessageBoxButtons.OK);
                }
                else if (string.IsNullOrEmpty(comboBoxTypPiecPers.SelectedItem.ToString()))
                {
                    MessageBox.Show("Veiller sélectionner la pièce !","GestPark : Avertissement", MessageBoxButtons.OK);
                }
                else if (string.IsNullOrEmpty(textBoxNumPieceIdentPers.Text))
                {
                    MessageBox.Show("Veiller saisir le champ n° pièce !","GestPark : Avertissement", MessageBoxButtons.OK);
                }
                else if (string.IsNullOrEmpty(CbxServicePers.Text))
                {
                    MessageBox.Show("Veillez sélectionner votre service !","GestPark : Avertissement",MessageBoxButtons.OK);
                }
                else
                {
                    // Generate code to person
                    string codePerson = generateCodePersonel();
                    DialogResult result = MessageBox.Show("Voulez vous enregister ?", "Oui", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        using (Conn.cn)
                        {
                            if (Conn.IsConnection)
                            {
                                // INSERT PROVIDER IN DATABASE
                                string DescPerson = textBxNomPers.Text + " " + textBxPrenPers.Text;
                                // Request to insert data in table personnels
                                SqlCmd = new SqlCommand("INSERT INTO PERSONNELS (ID_SERV,CODE_PERS,NOM_PERS,PRENOM_PERS,DESCRIPTION_PERS,TEL_PERS,DATENAISS_PERS,LIEUNAISS_PERS,NUMPERMIS_PERS,TYPEPIECE_PERS,NUMPIECEIDENT_PERS,FONCTION_PERS,NOTE_PERS,PAYS_PERS,ADRESSE_PERS,VILLE_PERS,CODEPOSTAL_PERS,DATE_PERS,DATECREATE_PERS,CATEGORIE_PERS) VALUES (@ID_SERV,@CODE_PERS, @NOM_PERS, @PRENOM_PERS,@DESCRIPTION_PERS, @TEL_PERS, @DATENAISS_PERS, @LIEUNAISS_PERS, @NUMPERMIS_PERS, @TYPEPIECE_PERS, @NUMPIECEIDENT_PERS, @FONCTION_PERS, @NOTE_PERS, @PAYS_PERS, @ADRESSE_PERS, @VILLE_PERS, @CODEPOSTAL_PERS, @DATE_PERS, GETDATE(),@CATEGORIE_PERS); ", Conn.cn);
                                SqlCmd.Parameters.AddWithValue("@ID_SERV", IdServ);
                                SqlCmd.Parameters.AddWithValue("@CODE_PERS", codePerson);
                                SqlCmd.Parameters.AddWithValue("@NOM_PERS", textBxNomPers.Text);
                                SqlCmd.Parameters.AddWithValue("@PRENOM_PERS", textBxPrenPers.Text);
                                SqlCmd.Parameters.AddWithValue("@DESCRIPTION_PERS", DescPerson);
                                SqlCmd.Parameters.AddWithValue("@TEL_PERS", textBxTelPers.Text);
                                SqlCmd.Parameters.AddWithValue("@DATENAISS_PERS", dateTimePickerDateNaissPers.Value.ToString("dd/MM/yyyy"));
                                SqlCmd.Parameters.AddWithValue("@LIEUNAISS_PERS", comboBoxTownPers.Text);
                                SqlCmd.Parameters.AddWithValue("@NUMPERMIS_PERS", textBoxNumPermisPers.Text);
                                SqlCmd.Parameters.AddWithValue("@TYPEPIECE_PERS", comboBoxTypPiecPers.Text);
                                SqlCmd.Parameters.AddWithValue("@NUMPIECEIDENT_PERS", textBoxNumPieceIdentPers.Text);
                                SqlCmd.Parameters.AddWithValue("@FONCTION_PERS", txtFonctionPers.Text);
                                SqlCmd.Parameters.AddWithValue("@NOTE_PERS", richTextBoxNotePers.Text);
                                SqlCmd.Parameters.AddWithValue("@PAYS_PERS", comboBoxCountryPers.Text);
                                SqlCmd.Parameters.AddWithValue("@ADRESSE_PERS", textBoxAdressPers.Text);
                                SqlCmd.Parameters.AddWithValue("@VILLE_PERS", comboBoxTownPers.Text);
                                SqlCmd.Parameters.AddWithValue("@CODEPOSTAL_PERS", textBoxCodePostalPers.Text);
                                SqlCmd.Parameters.AddWithValue("@DATE_PERS", dateTimePickerDateCreate.Value.ToString("dd/MM/yyyy"));
                                SqlCmd.Parameters.AddWithValue("@CATEGORIE_PERS",TxtCategPers.Text);
                                SqlCmd.ExecuteNonQuery();
                                MessageBox.Show("Enregistré avec succès","GestPark : Information", MessageBoxButtons.OK);
                                // Clear the fields provider of car
                                textBxCodePers.Clear(); textBxNomPers.Clear(); textBxPrenPers.Clear(); textBoxAdressPers.Clear(); textBoxCodePostalPers.Clear(); textBoxNumPermisPers.Clear(); textBoxNumPieceIdentPers.Clear();
                                textBxTelPers.Clear(); richTextBoxNotePers.Clear();CbxServicePers.Text = null; TxtDirPers.Clear();
                            }
                        }
                    }
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Generate code of personne
        private string generateCodePersonel()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        // Generate code person
                        SqlCmd = new SqlCommand("SELECT CODE_PERS FROM PERSONNELS WHERE CODE_PERS=(SELECT MAX(CODE_PERS) FROM PERSONNELS)", Conn.cn);
                        SqlAda = new SqlDataAdapter(SqlCmd);
                        Ds = new DataSet();
                        SqlAda.Fill(Ds);

                        if (Ds.Tables[0].Rows.Count > 0)
                        {
                            textBxCodePers.Text = Ds.Tables[0].Rows[0]["CODE_PERS"].ToString();
                        }
                        else
                        {
                            textBxCodePers.Text = "PERS0000";
                        }
                        if (!string.IsNullOrEmpty(textBxCodePers.Text))
                        {
                            textBxCodePers.SelectionStart = 4;
                            textBxCodePers.SelectionLength = 4;
                            textBxCodePers.Text = textBxCodePers.SelectedText;
                        }
                        if (!string.IsNullOrEmpty(textBxCodePers.Text))
                        {
                            int codePers = int.Parse(textBxCodePers.Text.ToString()) + 1;
                            textBxCodePers.Text = codePers.ToString("PERS0000");
                        }
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION DES ERREURS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return textBxCodePers.Text;
        }

        private void iconBtnSavedPerson_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnSavedPers = new ToolTip();
            ToolTipBtnSavedPers.AutoPopDelay = 5000;
            ToolTipBtnSavedPers.InitialDelay = 1000;
            ToolTipBtnSavedPers.ReshowDelay = 500;
            ToolTipBtnSavedPers.ShowAlways = true;
            ToolTipBtnSavedPers.SetToolTip(this.iconBtnSavedPerson, "Enregistrer");
        }

        private void BtnJoindreDoc_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnSavedPers = new ToolTip();
            ToolTipBtnSavedPers.AutoPopDelay = 5000;
            ToolTipBtnSavedPers.InitialDelay = 1000;
            ToolTipBtnSavedPers.ReshowDelay = 500;
            ToolTipBtnSavedPers.ShowAlways = true;
            ToolTipBtnSavedPers.SetToolTip(this.BtnJoindreDoc, "Joindre doc.");
        }


        private void FillCbxServices()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_SERV, DESCRIPTION_SERV FROM SERVICESENT", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            CbxServicePers.Items.Add(MyReader["DESCRIPTION_SERV"].ToString());
                            CbxServicePers.DisplayMember = (MyReader["DESCRIPTION_SERV"].ToString());
                            CbxServicePers.ValueMember = (MyReader["ID_SERV"].ToString());
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "GestPark: Gestion error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbxServicePers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        if (!string.IsNullOrEmpty(CbxServicePers.Text))
                        {
                            SqlCmd = new SqlCommand("SELECT ID_SERV,DESCRIPTION_DIR FROM SERVICESENT INNER JOIN DIRECTION ON SERVICESENT.ID_DIR=DIRECTION.ID_DIR WHERE DESCRIPTION_SERV = '" + CbxServicePers.SelectedItem + "' ", Conn.cn);
                            MyReader = SqlCmd.ExecuteReader();
                            while (MyReader.Read())
                            {
                                IdServ = Guid.Parse(MyReader[0].ToString());
                                TxtDirPers.Text = MyReader[1].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
