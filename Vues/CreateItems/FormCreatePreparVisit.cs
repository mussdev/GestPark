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
    public partial class FormCreatePreparVisit : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataAdapter SqlAda;
        private SqlDataReader MyReader;
        private DataSet Ds;
        private Guid IdVehiculePrepaVisit, IdGaragePrepaVisit;
        public FormCreatePreparVisit()
        {
            InitializeComponent();
            FillComboboxVehiculePrepaVisit();
            FillGaragePrepaVisit();
        }

        private void ChekPneusPrepaVisit_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipPneus = new ToolTip();
            ToolTipPneus.AutoPopDelay = 5000;
            ToolTipPneus.InitialDelay = 1000;
            ToolTipPneus.ReshowDelay = 500;
            ToolTipPneus.ShowAlways = true;
            ToolTipPneus.SetToolTip(this.ChekPneusPrepaVisit, "Vérification de leur usure et de leur déformation !!!");
        }

        private void CheckGazEchappPrepaVisit_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipGazEchapp = new ToolTip();
            ToolTipGazEchapp.AutoPopDelay = 5000;
            ToolTipGazEchapp.InitialDelay = 1000;
            ToolTipGazEchapp.ReshowDelay = 500;
            ToolTipGazEchapp.ShowAlways = true;
            ToolTipGazEchapp.SetToolTip(this.CheckGazEchappPrepaVisit, "Détecter un potentiel trou dans le pot ou encore\n une usure trop importante ou une mauvaise fixation !!!");
        }

        private void CheckFreinagePrepaVisit_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipFreing = new ToolTip();
            ToolTipFreing.AutoPopDelay = 5000;
            ToolTipFreing.InitialDelay = 1000;
            ToolTipFreing.ReshowDelay = 500;
            ToolTipFreing.ShowAlways = true;
            ToolTipFreing.SetToolTip(this.CheckFreinagePrepaVisit, "Vérification du niveau de liquide de freins\n et de la fiabilité du système de\n freinage et de ses composantes !!!");
        }

        private void CheckReglagePharePrepaVisit_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipPhare = new ToolTip();
            ToolTipPhare.AutoPopDelay = 5000;
            ToolTipPhare.InitialDelay = 1000;
            ToolTipPhare.ReshowDelay = 500;
            ToolTipPhare.ShowAlways = true;
            ToolTipPhare.SetToolTip(this.CheckReglagePharePrepaVisit, "Sur le fonctionnement des feux,\n l'état des ampoules et des phares et\n le réglage de ces derniers !!!");
        }

        private void CheckParallelismePrepaVisit_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipParall = new ToolTip();
            ToolTipParall.AutoPopDelay = 5000;
            ToolTipParall.InitialDelay = 1000;
            ToolTipParall.ReshowDelay = 500;
            ToolTipParall.ShowAlways = true;
            ToolTipParall.SetToolTip(this.CheckParallelismePrepaVisit, "Vérifier et régler l'allignement des 4 roues\n en fonction du réglage des suspensions.\n Réglage de l'alignement des 2 roues directrices\n et de l'angle des roues par rapport à la route !!!");
        }

        // Fill combobox vehicule
        private void FillComboboxVehiculePrepaVisit()
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
                            CbxCarPrepaVisit.Items.Add(MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            CbxCarPrepaVisit.DisplayMember = (MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            CbxCarPrepaVisit.ValueMember = (MyReader["ID_VEHICULE"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbxCarPrepaVisit_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_VEHICULE FROM VEHICULE WHERE IMMATRICULATION_VEHICULE = '" + CbxCarPrepaVisit.SelectedItem + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdVehiculePrepaVisit = Guid.Parse(MyReader[0].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Fill combobox vehicule
        private void FillGaragePrepaVisit()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT * FROM GARAGE ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            CbxGaragePrepaVisit.Items.Add(MyReader["DESCRIPTION_GARAGE"].ToString());
                            CbxGaragePrepaVisit.DisplayMember = (MyReader["DESCRIPTION_GARAGE"].ToString());
                            CbxGaragePrepaVisit.ValueMember = (MyReader["ID_GARAGE"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbxGaragePrepaVisit_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_GARAGE,PROPRIETAIRE_GARAGE FROM GARAGE WHERE DESCRIPTION_GARAGE = '" + CbxGaragePrepaVisit.SelectedItem + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdGaragePrepaVisit = Guid.Parse(MyReader[0].ToString());
                            TxtMecanicienPrepaVisit.Text = MyReader[1].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSavedPrepaVisit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Voulez vous enregister ?", "GESTPARK: CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                    ConnectDB Conn = new ConnectDB(connectionString);
                    string CodPrepaVisit = generateCodePreVisit();
                    using (Conn.cn)
                    {
                        if (Conn.IsConnection)
                        {
                            if (!string.IsNullOrEmpty(CbxCarPrepaVisit.Text))
                            {
                                if (!string.IsNullOrEmpty(CbxGaragePrepaVisit.Text))
                                {
                                    using (var Cmd = Conn.cn.CreateCommand())
                                    {
                                        Cmd.CommandText = "INSERT INTO PREPAREVISITE (ID_VEHICULE,ID_GARAGE,CODE_PREPAVISIT,STATUT_PREPAVISIT,MONTANT_PREPAVISIT,PARALLELISME_PREPAVISIT,PHARE_PREPAVISIT,FREINAGE_PREPAVISIT,GAZECHAPEM_PREPAVISIT,PNEUS_PREPAVISIT,NOTE_PREPAVISIT,DATE_PREPAVISIT,DATECREATE_PREPAVISIT) VALUES (@ID_VEHICULE,@ID_GARAGE,@CODE_PREPAVISIT,@STATUT_PREPAVISIT,@MONTANT_PREPAVISIT,@PARALLELISME_PREPAVISIT,@PHARE_PREPAVISIT,@FREINAGE_PREPAVISIT,@GAZECHAPEM_PREPAVISIT,@PNEUS_PREPAVISIT,@NOTE_PREPAVISIT,@DATE_PREPAVISIT,GETDATE())";
                                        Cmd.Parameters.AddWithValue("@ID_VEHICULE", IdVehiculePrepaVisit);
                                        Cmd.Parameters.AddWithValue("@ID_GARAGE", IdGaragePrepaVisit);
                                        Cmd.Parameters.AddWithValue("@CODE_PREPAVISIT", TxtCodePrepaVisit.Text);
                                       // Cmd.Parameters.AddWithValue("@STATUT_PREPAVISIT", CbxStatutPrepaVisit.SelectedItem);
                                        Cmd.Parameters.AddWithValue("@MONTANT_PREPAVISIT", decimal.Parse(TxtMontantPrepaVisit.Text));
                                        if (CheckParallelismePrepaVisit.Checked == true)
                                        {
                                            Cmd.Parameters.AddWithValue("@PARALLELISME_PREPAVISIT", 1);
                                        }else
                                            Cmd.Parameters.AddWithValue("@PARALLELISME_PREPAVISIT", 0);

                                        if (CheckReglagePharePrepaVisit.Checked == true)
                                        {
                                            Cmd.Parameters.AddWithValue("@PHARE_PREPAVISIT", 1);
                                        }
                                        else
                                            Cmd.Parameters.AddWithValue("@PHARE_PREPAVISIT", 0);

                                        if (CheckFreinagePrepaVisit.Checked == true)
                                        {
                                            Cmd.Parameters.AddWithValue("@FREINAGE_PREPAVISIT", 1);
                                        }
                                        else
                                            Cmd.Parameters.AddWithValue("@FREINAGE_PREPAVISIT", 0);

                                        if (CheckGazEchappPrepaVisit.Checked == true)
                                        {
                                            Cmd.Parameters.AddWithValue("@GAZECHAPEM_PREPAVISIT", 1);
                                        }
                                        else
                                            Cmd.Parameters.AddWithValue("@GAZECHAPEM_PREPAVISIT", 0);


                                        if (ChekPneusPrepaVisit.Checked == true)
                                        {
                                            Cmd.Parameters.AddWithValue("@PNEUS_PREPAVISIT", 1);
                                        }
                                        else
                                            Cmd.Parameters.AddWithValue("@PNEUS_PREPAVISIT", 0);

                                        Cmd.Parameters.AddWithValue("@NOTE_PREPAVISIT", RTxtNotePrepaVisit.Text);
                                        Cmd.Parameters.AddWithValue("@DATE_PREPAVISIT", DatePikerRegisterPrepaVisit.Value.ToString("dd/MM/yyyy"));
                                        Cmd.ExecuteNonQuery();
                                        MessageBox.Show("Enregistré avec succès !", "GestPark : Informations", MessageBoxButtons.OK);
                                        CbxCarPrepaVisit.Text = null; CbxGaragePrepaVisit.Text = null; TxtCodePrepaVisit.Clear(); TxtMecanicienPrepaVisit.Clear(); TxtMontantPrepaVisit.Clear();
                                        ChekPneusPrepaVisit.Checked = false; CheckGazEchappPrepaVisit.Checked = false; CheckFreinagePrepaVisit.Checked = false; CheckReglagePharePrepaVisit.Checked = false; CheckParallelismePrepaVisit.Checked = false;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Veillez sélectionner un garage !!!", "GestPark: Avertissement !", MessageBoxButtons.OK);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Veillez sélectionnez le véhicule !!!", "GestPark : Avertissement !", MessageBoxButtons.OK);
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

        private void BtnSavedPrepaVisit_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnCreatePrepaVisitTech = new ToolTip();
            ToolTipBtnCreatePrepaVisitTech.AutoPopDelay = 5000;
            ToolTipBtnCreatePrepaVisitTech.InitialDelay = 1000;
            ToolTipBtnCreatePrepaVisitTech.ReshowDelay = 500;
            ToolTipBtnCreatePrepaVisitTech.ShowAlways = true;
            ToolTipBtnCreatePrepaVisitTech.SetToolTip(this.BtnSavedPrepaVisit, "Enregistrer");
        }

        private void BtnImportPrepaVisit_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnJoinDocPrepaVisitTech = new ToolTip();
            ToolTipBtnJoinDocPrepaVisitTech.AutoPopDelay = 5000;
            ToolTipBtnJoinDocPrepaVisitTech.InitialDelay = 1000;
            ToolTipBtnJoinDocPrepaVisitTech.ReshowDelay = 500;
            ToolTipBtnJoinDocPrepaVisitTech.ShowAlways = true;
            ToolTipBtnJoinDocPrepaVisitTech.SetToolTip(this.BtnSavedPrepaVisit, "Joidre doc.");
        }


        // Methode te generate code
        private string generateCodePreVisit()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        // Generate code of car
                        SqlCmd = new SqlCommand("SELECT CODE_PREPAVISIT FROM PREPAREVISITE WHERE CODE_PREPAVISIT=(SELECT MAX(CODE_PREPAVISIT) FROM PREPAREVISITE)", Conn.cn);
                        SqlAda = new SqlDataAdapter(SqlCmd);
                        Ds = new DataSet();
                        SqlAda.Fill(Ds);

                        if (Ds.Tables[0].Rows.Count > 0)
                        {
                            TxtCodePrepaVisit.Text = Ds.Tables[0].Rows[0]["CODE_PREPAVISIT"].ToString();
                        }
                        else
                        {
                            TxtCodePrepaVisit.Text = "PREVISIT0000";
                        }
                        if (!string.IsNullOrEmpty(TxtCodePrepaVisit.Text))
                        {
                            TxtCodePrepaVisit.SelectionStart = 8;
                            TxtCodePrepaVisit.SelectionLength = 4;
                            TxtCodePrepaVisit.Text = TxtCodePrepaVisit.SelectedText;
                        }
                        if (!string.IsNullOrEmpty(TxtCodePrepaVisit.Text))
                        {
                            int codPrepaVisit = int.Parse(TxtCodePrepaVisit.Text.ToString()) + 1;
                            TxtCodePrepaVisit.Text = codPrepaVisit.ToString("PREVISIT0000");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return TxtCodePrepaVisit.Text;
        }
    }
}
        

        
   

