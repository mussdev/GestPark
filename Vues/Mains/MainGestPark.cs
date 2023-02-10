using GestPark.Vues.Consult;
using GestPark.Vues.Mains;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace GestPark
{
    public partial class MainGestPark : Form
    {
        private SqlDataAdapter SqlAda;
        //private DataTable dt;
        private SqlCommand SqlCmd;
        private SqlDataReader MyReader;
        //private DataTable Dt;
        String ServiceUser = String.Empty;
        public MainGestPark()
        {
            InitializeComponent();
            lblUserConnecte.Text = $"{FormConnectionUser.pseudoUser.ToLower()} est connecté à Fleet !";
            NbrDemandeCarEnAttente();
        }

        private Form ActiveForm = null;
        private void openChildForm(Form ChildForm)
        {
            if (ActiveForm != null)
                ActiveForm.Close();
            ActiveForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
          //  PanItemMenu.Controls.Add(ChildForm);
         //   PanItemMenu.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private Form FormMenu = null;
        public void DisplayFormOfMenu(Form FormOfMenu)
        {
            if (FormMenu != null)
                FormMenu.Close();
            FormMenu = FormOfMenu;
            FormOfMenu.TopLevel = false;
            FormOfMenu.FormBorderStyle = FormBorderStyle.None;
            FormOfMenu.Dock = DockStyle.Fill;
            PanPrincipalForm.Controls.Add(FormOfMenu);
            PanPrincipalForm.Tag = FormOfMenu;
            FormOfMenu.BringToFront();
            FormOfMenu.Show();
        }

        private void BtnGestion_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenu(new Gestion());
        }

        private void BtnMaint_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenu(new Maintenance());
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenu(new Administration());
        }

        private void PanTablBord_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenu(new TableauDeBord());
        }

        private void BtnParam_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenu(new Parametre());
        }

        //private void displayCarOfVidange()
        //{
        //    try
        //    {
        //        string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        //        ConnectDB Conn = new ConnectDB(connectionString);
        //        using (Conn.cn)
        //        {
        //            if (Conn.IsConnection)
        //            {
        //                // Display data in datagridview
        //                SqlAda = new SqlDataAdapter("select*from vehicule left outer join marque on vehicule.id_marq=marque.id_marq left outer join typeconsommation on typeconsommation.id_typconso=vehicule.id_typconso left outer join fournisseur on fournisseur.id_four=vehicule.id_four where vehicule.KILOMETRAGE_VIDENGE_VEHICULE > '0' ", Conn.cn);
        //                dt = new DataTable();
        //                SqlAda.Fill(dt);
        //                dgvChartCarVidang.AutoGenerateColumns = false;
        //                dgvChartCarVidang.DataSource = dt;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString(), "BestCarFleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
        //    }
        //}

        //private void displayChartVidange()
        //{
        //    try
        //    {
        //        string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        //        ConnectDB Conn = new ConnectDB(connectionString);
        //        using (Conn.cn)
        //        {
        //            if (Conn.IsConnection)
        //            {
        //                using(var Cmd = Conn.cn.CreateCommand())
        //                {
        //                    Cmd.CommandText = "select IMMATRICULATION_VEHICULE,CARTE_GRISE_VEHICULE,TOTALKILOMETRAGE_VEHICULE, KILOMETRAGE_VIDENGE_VEHICULE,KILO_VIDANGE_MARQ from vehicule left outer join marque on vehicule.id_marq=marque.id_marq where vehicule.KILOMETRAGE_VIDENGE_VEHICULE > '0'";
        //                    //SqlCmd = new SqlCommand("select IMMATRICULATION_VEHICULE,CARTE_GRISE_VEHICULE,TOTALKILOMETRAGE_VEHICULE, KILOMETRAGE_VIDENGE_VEHICULE,KILO_VIDANGE_MARQ from vehicule left outer join marque on vehicule.id_marq=marque.id_marq where vehicule.KILOMETRAGE_VIDENGE_VEHICULE > '0'", Conn.cn);
        //                    MyReader = Cmd.ExecuteReader();
        //                    while (MyReader.Read())
        //                    {
        //                        chartCarViewVidange.Series["Vidange"].Points.AddXY(MyReader["IMMATRICULATION_VEHICULE"].ToString(),
        //                            MyReader["KILOMETRAGE_VIDENGE_VEHICULE"].ToString()
        //                            );

        //                        chartCarViewVidange.Series["kilométrage total"].Points.AddXY(MyReader["IMMATRICULATION_VEHICULE"].ToString(),
        //                            MyReader["TOTALKILOMETRAGE_VEHICULE"].ToString()
        //                            );
        //                    }
        //                    MyReader.Close();

        //                    // Requête qui affiche la dépense de carburabt effectuée par véhicule

        //                    Cmd.CommandText = "select vehicule.immatriculation_vehicule ,sum(paiement.totalprix_paie) as totalPriceCarb from paiement inner join provision on  provision.id_prov=paiement.id_prov inner join vehicule on vehicule.id_vehicule=provision.id_vehicule where vehicule.KILOMETRAGE_VIDENGE_VEHICULE > '0' group by vehicule.immatriculation_vehicule";
        //                    MyReader = Cmd.ExecuteReader();
        //                    while (MyReader.Read())
        //                    {
        //                        chartCarViewVidange.Series["Dépense carburant"].Points.AddXY(MyReader["immatriculation_vehicule"].ToString(),
        //                            MyReader["totalPriceCarb"].ToString()
        //                            );
        //                    }
        //                    MyReader.Close();
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void MainGestPark_Load(object sender, EventArgs e)
        {
            NberPoolCaar();
            NberPoolCaarDisponible();
            NberPoolCaarEnActivité();
            int x, y;
            x = (this.Width - panelHomeFleet.Width) / 2;
            y = (this.Height - panelHomeFleet.Height) / 2;
            panelHomeFleet.Location = new Point(x, y);
        }


        private void BtnParam_MouseHover(object sender, EventArgs e)
        {
            BtnParam.BackColor = Color.FromArgb(255, 163, 44);
            BtnParam.ForeColor = Color.Black;
        }

        private void BtnGestion_MouseHover(object sender, EventArgs e)
        {
            BtnGestion.BackColor = Color.FromArgb(255, 163, 44);
            BtnGestion.ForeColor = Color.Black;
        }

        private void BtnMaint_MouseHover(object sender, EventArgs e)
        {
            BtnMaint.BackColor = Color.FromArgb(255, 163, 44);
            BtnMaint.ForeColor = Color.Black;
        }

        private void BtnTablBord_MouseHover(object sender, EventArgs e)
        {
            BtnTablBord.BackColor = Color.FromArgb(255, 163, 44);
            BtnTablBord.ForeColor = Color.Black;
        }

        private void BtnAdmin_MouseHover(object sender, EventArgs e)
        {
            BtnAdmin.BackColor = Color.FromArgb(255, 163, 44);
            BtnAdmin.ForeColor = Color.Black;
        }

        private void btnApropos_MouseHover(object sender, EventArgs e)
        {
            btnApropos.BackColor = Color.FromArgb(255, 163, 44);
            btnApropos.ForeColor = Color.Black;
        }

        private void btnApropos_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenu(new FormApropos());
        }

        private void BtnParam_MouseLeave(object sender, EventArgs e)
        {
            BtnParam.BackColor = Color.FromArgb(102, 222, 132);
            BtnParam.ForeColor = Color.Black;
        }

        private void BtnGestion_MouseLeave(object sender, EventArgs e)
        {
            BtnGestion.BackColor = Color.FromArgb(102, 222, 132);
            BtnGestion.ForeColor = Color.Black;
        }

        private void BtnMaint_MouseLeave(object sender, EventArgs e)
        {
            BtnMaint.BackColor = Color.FromArgb(102, 222, 132);
            BtnMaint.ForeColor = Color.Black;
        }

        private void BtnTablBord_MouseLeave(object sender, EventArgs e)
        {
            BtnTablBord.BackColor = Color.FromArgb(102, 222, 132);
            BtnTablBord.ForeColor = Color.Black;
        }

        private void BtnAdmin_MouseLeave(object sender, EventArgs e)
        {
            BtnAdmin.BackColor = Color.FromArgb(102, 222, 132);
            BtnAdmin.ForeColor = Color.Black;
        }

        private void btnApropos_MouseLeave(object sender, EventArgs e)
        {
            btnApropos.BackColor = Color.FromArgb(102, 222, 132);
            btnApropos.ForeColor = Color.Black;
        }

        private void MenuAlertVidange_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenu(new FormAlerteVidange());
        }

        private void MenuAlertVisitTech_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenu(new FormAlerteVisiteTechnique());
        }

        private void MenuAssurance_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenu(new FormAlerteAssurance());
        }

        private void NberPoolCaar()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        using(var Cmd = Conn.cn.CreateCommand())
                        {
                            Cmd.CommandText = "select count(code_vehicule) as nbrCarPool from vehicule where vehicule.type_vehicule='pool'";
                            MyReader = Cmd.ExecuteReader();
                            while (MyReader.Read())
                            {
                                lblTotalPool.Text = MyReader["nbrCarPool"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Fleet: Gestion des erreurs",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        // Calcule le nombre de voiture disponible
        private void NberPoolCaarDisponible()
        {
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
                            Cmd.CommandText = "select count(code_vehicule) as nbrCarPool from vehicule where vehicule.type_vehicule='pool' and vehicule.etat_vehicule='parking'";
                            MyReader = Cmd.ExecuteReader();
                            while (MyReader.Read())
                            {
                                lblCarPoolDisponible.Text = MyReader["nbrCarPool"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Calcule le nombre de voiture disponible
        private void NberPoolCaarEnActivité()
        {
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
                            Cmd.CommandText = "select count(code_vehicule) as nbrCarPool from vehicule where vehicule.type_vehicule='pool' and vehicule.etat_vehicule='sorti'";
                            MyReader = Cmd.ExecuteReader();
                            while (MyReader.Read())
                            {
                                lblCarPoolEnActivite.Text = MyReader["nbrCarPool"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClocheDemandeVehi_Click(object sender, EventArgs e)
        {
            FormDemandeVehicule formDemandeVehi = new FormDemandeVehicule();
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);

                if (FormConnectionUser.rolesUser.Equals("Chef Service"))
                {
                    SqlCmd = new SqlCommand("SELECT * FROM MOUVEMENTS AS M LEFT OUTER JOIN VEHICULE AS V ON V.ID_VEHICULE=M.ID_VEHICULE LEFT OUTER JOIN VALIDATIONMOUVEMENTCAR AS VALID ON VALID.ID_VALMVT=M.ID_VALMVT LEFT OUTER JOIN PERSONNELS AS P ON P.ID_PERS=M.ID_PERS LEFT OUTER JOIN UTILISATEURS AS U ON P.ID_PERS=U.ID_PERS LEFT OUTER JOIN SERVICESENT AS S ON S.ID_SERV=P.ID_SERV LEFT OUTER JOIN DIRECTION AS D ON D.ID_DIR=S.ID_DIR WHERE VALID.DESCRIPTION_VALMVT = 'En cours de traitement' AND S.DESCRIPTION_SERV = '" + ServiceUser + "'", Conn.cn);
                    SqlAda = new SqlDataAdapter(SqlCmd);
                    DataSet Tb = new DataSet();
                    SqlAda.Fill(Tb);

                    // Fill DataGridView
                    formDemandeVehi.dgvDemandeVehi.AutoGenerateColumns = false;
                    formDemandeVehi.dgvDemandeVehi.DataSource = Tb.Tables[0];

                    formDemandeVehi.ShowDialog();
                }
                else if (FormConnectionUser.rolesUser.Equals("Gestionnaire"))
                {
                    SqlCmd = new SqlCommand("SELECT * FROM MOUVEMENTS AS M LEFT OUTER JOIN VEHICULE AS V ON V.ID_VEHICULE=M.ID_VEHICULE LEFT OUTER JOIN VALIDATIONMOUVEMENTCAR AS VALID ON VALID.ID_VALMVT=M.ID_VALMVT LEFT OUTER JOIN PERSONNELS AS P ON P.ID_PERS=M.ID_PERS LEFT OUTER JOIN UTILISATEURS AS U ON P.ID_PERS=U.ID_PERS LEFT OUTER JOIN SERVICESENT AS S ON S.ID_SERV=P.ID_SERV LEFT OUTER JOIN DIRECTION AS D ON D.ID_DIR=S.ID_DIR WHERE VALID.DESCRIPTION_VALMVT = 'Valide Chef Service'", Conn.cn);
                    SqlAda = new SqlDataAdapter(SqlCmd);
                    DataSet Tb = new DataSet();
                    SqlAda.Fill(Tb);

                    // Fill DataGridView
                    formDemandeVehi.dgvDemandeVehi.AutoGenerateColumns = false;
                    formDemandeVehi.dgvDemandeVehi.DataSource = Tb.Tables[0];

                    formDemandeVehi.ShowDialog();
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Calcule le nombre de voiture disponible
        private void NbrDemandeCarEnAttente()
        {
            String NbrDemande = "0";
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        if (FormConnectionUser.rolesUser.Equals("Chef Service"))
                        {
                            using (var Cmd = Conn.cn.CreateCommand())
                            {
                                // Déterminer le service de l'utilisateur connecté
                                Cmd.CommandText = "SELECT U.DESCRIPTION_USER, S.DESCRIPTION_SERV FROM UTILISATEURS AS U INNER JOIN PERSONNELS AS P ON U.ID_PERS=P.ID_PERS INNER JOIN SERVICESENT AS S ON P.ID_SERV=S.ID_SERV WHERE U.PSEUDO_USERS = '" + FormConnectionUser.pseudoUser.Trim().ToLower() + "'";
                                MyReader = Cmd.ExecuteReader();
                                while (MyReader.Read())
                                {
                                    ServiceUser = MyReader["DESCRIPTION_SERV"].ToString();
                                }
                                MyReader.Close();

                                // Déterminer le service de l'utilisateur connecté
                                Cmd.CommandText = "SELECT COUNT(M.ID_MVTS) AS NbrDemandeVehi FROM MOUVEMENTS AS M LEFT OUTER JOIN VEHICULE AS V ON V.ID_VEHICULE=M.ID_VEHICULE LEFT OUTER JOIN VALIDATIONMOUVEMENTCAR AS VALID ON VALID.ID_VALMVT=M.ID_VALMVT LEFT OUTER JOIN PERSONNELS AS P ON P.ID_PERS=M.ID_PERS LEFT OUTER JOIN SERVICESENT AS S ON S.ID_SERV=P.ID_SERV LEFT OUTER JOIN DIRECTION AS D ON D.ID_DIR=S.ID_DIR WHERE S.DESCRIPTION_SERV='" + ServiceUser + "' ";
                                MyReader = Cmd.ExecuteReader();
                                while (MyReader.Read())
                                {
                                    NbrDemande = MyReader["NbrDemandeVehi"].ToString();
                                    btnClocheDemandeVehi.Text = NbrDemande;
                                }
                                MyReader.Close();
                            }
                        }
                        else if (FormConnectionUser.rolesUser.Equals("Gestionnaire"))
                        {
                            using (var Cmd = Conn.cn.CreateCommand())
                            {
                                // Déterminer le service de l'utilisateur connecté
                                Cmd.CommandText = "SELECT COUNT(M.ID_MVTS) AS NbrDemande FROM MOUVEMENTS AS M LEFT OUTER JOIN VEHICULE AS V ON V.ID_VEHICULE=M.ID_VEHICULE LEFT OUTER JOIN VALIDATIONMOUVEMENTCAR AS VALID ON VALID.ID_VALMVT=M.ID_VALMVT LEFT OUTER JOIN PERSONNELS AS P ON P.ID_PERS=M.ID_PERS LEFT OUTER JOIN UTILISATEURS AS U ON P.ID_PERS=U.ID_PERS LEFT OUTER JOIN SERVICESENT AS S ON S.ID_SERV=P.ID_SERV LEFT OUTER JOIN DIRECTION AS D ON D.ID_DIR=S.ID_DIR WHERE VALID.DESCRIPTION_VALMVT = 'Valide Chef Service'";
                                MyReader = Cmd.ExecuteReader();
                                while (MyReader.Read())
                                {
                                    NbrDemande = MyReader["NbrDemande"].ToString();
                                    btnClocheDemandeVehi.Text = NbrDemande;
                                }
                                MyReader.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fleet: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnMission_Click(object sender, EventArgs e)
        {
            DisplayFormOfMenu(new MainMission());
        }
    }
}
