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
    public partial class FormCreateWatchCar : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataAdapter SqlAda;
        private SqlDataReader MyReader;
        private DataSet Ds;
        private Guid IdVehiWatch, IdCardWatch, IdLavage;
        private String MatriculeCar = null, CarteGriseCar = null, ModelCar = null, CartePaie = null;
        private decimal SoldeCarte = 0;
        public FormCreateWatchCar()
        {
            InitializeComponent();
            FillComboboxVehiculeToWatch();
            FillCbxCardPaieClean();
        }

        // Methode to generate code for watching
        private string generateCodeCar()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            ConnectDB Conn = new ConnectDB(connectionString);
            try
            {
                // Generate code of car
                SqlCmd = new SqlCommand("SELECT CODE_WATCH FROM LAVAGE WHERE CODE_WATCH=(SELECT MAX(CODE_WATCH) FROM LAVAGE)", Conn.cn);
                SqlAda = new SqlDataAdapter(SqlCmd);
                Ds = new DataSet();
                SqlAda.Fill(Ds);

                if (Ds.Tables[0].Rows.Count > 0)
                {
                    TbxCodeWatchCar.Text = Ds.Tables[0].Rows[0]["CODE_WATCH"].ToString();
                }
                else
                {
                    TbxCodeWatchCar.Text = "LAV0000";
                }
                if (!string.IsNullOrEmpty(TbxCodeWatchCar.Text))
                {
                    TbxCodeWatchCar.SelectionStart = 3;
                    TbxCodeWatchCar.SelectionLength = 4;
                    TbxCodeWatchCar.Text = TbxCodeWatchCar.SelectedText;
                }
                if (!string.IsNullOrEmpty(TbxCodeWatchCar.Text))
                {
                    int CodeWatch = int.Parse(TbxCodeWatchCar.Text.ToString()) + 1;
                    TbxCodeWatchCar.Text = CodeWatch.ToString("LAV0000");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return TbxCodeWatchCar.Text;
        }

        // Fill combobox vehicule
        private void FillComboboxVehiculeToWatch()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT * FROM VEHICULE ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            CbxVehiculeWatchCar.Items.Add(new KeyValuePair<Guid, string>((Guid)MyReader["ID_VEHICULE"], MyReader["IMMATRICULATION_VEHICULE"].ToString()));
                            CbxVehiculeWatchCar.DisplayMember = "Value";
                            CbxVehiculeWatchCar.ValueMember = "Key";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbxVehiculeWatchCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT * FROM VEHICULE AS V INNER JOIN MARQUE AS M ON V.ID_MARQ=M.ID_MARQ WHERE V.IMMATRICULATION_VEHICULE = '" + CbxVehiculeWatchCar.Text + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdVehiWatch = Guid.Parse(MyReader["ID_VEHICULE"].ToString());
                            MatriculeCar = MyReader["IMMATRICULATION_VEHICULE"].ToString();
                            CarteGriseCar = MyReader["CARTE_GRISE_VEHICULE"].ToString();
                            ModelCar = MyReader["MODELE_MARQ"].ToString();
                            //MessageBox.Show("Id car : " + IdVehiWatch + "Matricule : " + MatriculeCar + "Carte grise : " + CarteGriseCar + " Modèle véhicule : " + ModelCar);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IBtnRegisterWatchCar_Click(object sender, EventArgs e)
        {
            if(dgvCarLineWatch.Rows != null)
            {
                try
                {
                    DialogResult result = MessageBox.Show("Voulez vous enregister ce ravitaillement en carburant des véhicules ?", "Fleet: Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                        ConnectDB Conn = new ConnectDB(connectionString);
                        string CodVehWatch = generateCodeCar();

                        if (Conn.IsConnection)
                        {
                            using (var Cmd = Conn.cn.CreateCommand())
                            {
                                Cmd.CommandText = "INSERT INTO LAVAGE (CODE_WATCH,MONTANT_WATCH,LIEU_WATCH,DATE_WATCH,DATECREATE_WATCH) VALUES (@CODE_WATCH,@MONTANT_WATCH,@LIEU_WATCH,@DATE_WATCH,GETDATE())";
                                Cmd.Parameters.AddWithValue("@CODE_WATCH", CodVehWatch);
                                Cmd.Parameters.AddWithValue("@MONTANT_WATCH",decimal.Parse(txtNetAPayerCarWatch.Text.Trim()));
                                Cmd.Parameters.AddWithValue("@LIEU_WATCH", TxtBLieuWatchCar.Text);
                                Cmd.Parameters.AddWithValue("@DATE_WATCH", DatePikerWatchCar.Value.ToString("dd/MM/yyyy"));
                                Cmd.ExecuteNonQuery();

                            }

                            // Récuperer l'id dans la table lavage
                            using (var Cmd = Conn.cn.CreateCommand())
                            {
                                Cmd.CommandText = "SELECT ID_WATCH FROM LAVAGE WHERE CODE_WATCH='" + TbxCodeWatchCar .Text+ "' ";
                                MyReader = Cmd.ExecuteReader();
                                while (MyReader.Read())
                                {
                                    IdLavage = Guid.Parse(MyReader["ID_WATCH"].ToString());
                                }
                                MyReader.Close();
                            }

                            // Inserer les véhicules dans table lavageline
                            using (var Cmd = Conn.cn.CreateCommand())
                            {
                                for(int i = 0; i < dgvCarLineWatch.Rows.Count - 1; i++)
                                {
                                    Cmd.CommandText = "INSERT INTO LAVAGELINE (ID_WATCH,ID_VEHICULE) VALUES (@KeyWatch,@ID_VEHICULE)";
                                    Cmd.Parameters.AddWithValue("@KeyWatch", IdLavage);
                                    Cmd.Parameters.AddWithValue("@ID_VEHICULE", Guid.Parse(dgvCarLineWatch.Rows[i].Cells["ID_VEHICULE"].Value.ToString()));
                                    Cmd.ExecuteNonQuery();
                                    Cmd.Parameters.Clear();
                                }
                            }

                            // Inserer les cartes utilisées pour le paiement
                            using (var Cmd = Conn.cn.CreateCommand())
                            {
                                for (int j = 0; j < dgvPaieWatchCar.Rows.Count - j; j++)
                                {
                                    Cmd.CommandText = "INSERT INTO PAIEMENT (ID_WATCH,ID_CARD,TOTALPRIX_PAIE,DATE_PAIE,DATECREATE_PAIE,ANCIEN_SOLDE_CARTE_PAIE) VALUES (@ID_WATCH,@ID_CARD,@TOTALPRIX_PAIE,@DATE_PAIE,GETDATE(),@ANCIEN_SOLDE_CARTE_PAIE)";
                                    Cmd.Parameters.AddWithValue("@ID_WATCH", IdLavage);
                                    Cmd.Parameters.AddWithValue("@ID_CARD", Guid.Parse(dgvPaieWatchCar.Rows[j].Cells["ID_CARD"].Value.ToString()));
                                    Cmd.Parameters.AddWithValue("@TOTALPRIX_PAIE", decimal.Parse(dgvPaieWatchCar.Rows[j].Cells["AmountDebite"].Value.ToString()));
                                    Cmd.Parameters.AddWithValue("@DATE_PAIE", datePaieWatch.Value.ToString("dd/MM/yyyy"));
                                    Cmd.Parameters.AddWithValue("@ANCIEN_SOLDE_CARTE_PAIE", decimal.Parse(dgvPaieWatchCar.Rows[j].Cells["SOLDE_CARD"].Value.ToString()));
                                    Cmd.ExecuteNonQuery();
                                    Cmd.Parameters.Clear();

                                    // Mise à jour de la carte
                                    // Recuperer le montant de la carte qui a servi le paiement
                                    decimal totalAmountCard = Convert.ToDecimal(dgvPaieWatchCar.Rows[j].Cells["SOLDE_CARD"].Value.ToString()) - Convert.ToDecimal(dgvPaieWatchCar.Rows[j].Cells["AmountDebite"].Value.ToString());

                                    // Mise à jour du solde de la carte des paiements de carburant
                                    Cmd.CommandText = "UPDATE CARDPAIEMENT SET SOLDE_CARD=@SOLDE_CARD WHERE ID_CARD='" + dgvPaieWatchCar.Rows[j].Cells["ID_CARD"].Value + "'";
                                    Cmd.Parameters.AddWithValue("@SOLDE_CARD", totalAmountCard);
                                    Cmd.ExecuteNonQuery();
                                }
                            }

                            // Vider les champs pour une autre saisie
                            txtNetAPayerCarWatch.Clear();TxtBLieuWatchCar.Clear(); TxtBMontant.Clear(); TbxCodeWatchCar.Clear();
                            this.Close();
                        }
                    }
                    }catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vous n'avez aucun véhicule dans la table"+ "\n" + "Veillez ajouter les véhicules lavés dans la table !","Fleet: Gestion des erreurs !",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
                
        }

        private void cbxWatchCardPaie_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT * FROM CARDPAIEMENT WHERE TPYE_CARD = '" + cbxWatchCardPaie.Text + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdCardWatch = Guid.Parse(MyReader["ID_CARD"].ToString());
                            CartePaie = MyReader["NUM_CARD"].ToString();
                            SoldeCarte = decimal.Parse(MyReader["SOLDE_CARD"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNetAPayerCarWatch_TextChanged(object sender, EventArgs e)
        {
            if (txtNetAPayerCarWatch.Text == "" || txtNetAPayerCarWatch.Text == "0") return;
            decimal price;
            price = decimal.Parse(txtNetAPayerCarWatch.Text, System.Globalization.NumberStyles.Currency);
            txtNetAPayerCarWatch.Text = price.ToString("#,#");
            txtNetAPayerCarWatch.SelectionStart = txtNetAPayerCarWatch.Text.Length;
        }

        private void txtAmountDebite_TextChanged(object sender, EventArgs e)
        {
            if (txtAmountDebite.Text == "" || txtAmountDebite.Text == "0") return;
            decimal price;
            price = decimal.Parse(txtAmountDebite.Text, System.Globalization.NumberStyles.Currency);
            txtAmountDebite.Text = price.ToString("#,#");
            txtAmountDebite.SelectionStart = txtAmountDebite.Text.Length;
        }

        private void btnAddCarWatch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CbxVehiculeWatchCar.Text))
            {
                dgvCarLineWatch.Rows.Add(IdVehiWatch,MatriculeCar,CarteGriseCar,ModelCar);
                CbxVehiculeWatchCar.Text = " ";
            }
            else
            {
                MessageBox.Show("Aucun véhicule n'a été sélectionné !" + "\n" + "Veillez sélectionner un ou plusieurs véhicule(s) !","Fleet: Gestion des erreurs",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddCardPaie_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbxWatchCardPaie.Text))
            {
                dgvPaieWatchCar.Rows.Add(IdCardWatch, CartePaie, SoldeCarte, txtAmountDebite.Text);
                cbxWatchCardPaie.Text = " ";
                txtAmountDebite.Clear();

                // Calculer le montant total debité sur la carte
                decimal Mont = 0;
                for (int i = 0; i < dgvPaieWatchCar.Rows.Count; ++i)
                {
                    Mont += Convert.ToDecimal(dgvPaieWatchCar.Rows[i].Cells["AmountDebite"].Value);
                }

                TxtBMontant.Text = $"{Mont.ToString("### ### ### ###")} ";
            }
            else
            {
                MessageBox.Show("Aucune carte pour le paiement n'a été sélectionnée !" + "\n" + "Veillez sélectionner une ou plusieurs carte(s) !", "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IBtnRegisterWatchCar_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnCreateCar = new ToolTip();
            ToolTipBtnCreateCar.AutoPopDelay = 5000;
            ToolTipBtnCreateCar.InitialDelay = 1000;
            ToolTipBtnCreateCar.ReshowDelay = 500;
            ToolTipBtnCreateCar.ShowAlways = true;
            ToolTipBtnCreateCar.SetToolTip(this.IBtnRegisterWatchCar, "Enregistrer");
        }

        private void BtnJoindreWatchCar_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnCreateCar = new ToolTip();
            ToolTipBtnCreateCar.AutoPopDelay = 5000;
            ToolTipBtnCreateCar.InitialDelay = 1000;
            ToolTipBtnCreateCar.ReshowDelay = 500;
            ToolTipBtnCreateCar.ShowAlways = true;
            ToolTipBtnCreateCar.SetToolTip(this.BtnJoindreWatchCar, "Joindre doc.");
        }

        // Fill combobox vehicule
        private void FillCbxCardPaieClean()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT * FROM CARDPAIEMENT", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            cbxWatchCardPaie.Items.Add(MyReader["TPYE_CARD"].ToString());
                            cbxWatchCardPaie.DisplayMember = (MyReader["TPYE_CARD"].ToString());
                            cbxWatchCardPaie.ValueMember = (MyReader["ID_CARD"].ToString());
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
