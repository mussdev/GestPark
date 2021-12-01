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
    public partial class FormCreateMouvement : Form
    {
        private SqlCommand SqlCmd = null;
        private string IdConducteur, IdVehicule, IdMvts;
        private SqlDataReader MyReader;
        private SqlDataAdapter SqlAda;
        private DataSet Ds;

        public FormCreateMouvement()
        {
            InitializeComponent();
            FillComboboxConducteur();
            FillComboboxVehicule();
        }

        private void CbxConducMvt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_PERS FROM PERSONNELS WHERE TYPE_PERS = 'Conducteur' AND DESCRIPTION_PERS = '" + CbxConducMvt.SelectedItem + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdConducteur = MyReader[0].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Fill combobox conducteur
        private void FillComboboxConducteur()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT * FROM PERSONNELS WHERE TYPE_PERS = 'Conducteur' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            CbxConducMvt.Items.Add(MyReader["DESCRIPTION_PERS"].ToString());
                            CbxConducMvt.DisplayMember = (MyReader["DESCRIPTION_PERS"].ToString());
                            CbxConducMvt.ValueMember = (MyReader["ID_PERS"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IbtnRegisterMvt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TbxDescriptionMvt.Text))
            {
                MessageBox.Show("Veillez l'objet du mouvement");
            }
            else if (string.IsNullOrEmpty(CbxLieuMvts.Text))
            {
                MessageBox.Show("Veillez définir le lieu");
            }
            else if (string.IsNullOrEmpty(CbxConducMvt.Text))
            {
                MessageBox.Show("Veillez choisir le conducteur");
            }
            else if (string.IsNullOrEmpty(CbxVehicule.Text))
            {
                MessageBox.Show("Veillez choisir le vehicule");
            }
            else
            {
                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                    ConnectDB Conn = new ConnectDB(connectionString);
                    DialogResult result = MessageBox.Show("Voulez vous enregister ?", "GESTPARK: CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        using (Conn.cn)
                        {
                            if (Conn.IsConnection)
                            {
                                string CodMouvement = generateCodeMvt();
                                SqlCmd = new SqlCommand("INSERT INTO MOUVEMENTS (ID_PERS,ID_VEHICULE,CODE_MVTS,STATUT_MVTS,DESCRIPTION_MVTS,LIEU_MVTS,NOTE_MVTS,DATEDEPART_MVTS,TIMESTART_MVTS,DATECREATE_MVTS) VALUES (@ID_PERS,@ID_VEHICULE,@CODE_MVTS,@STATUT_MVTS,@DESCRIPTION_MVTS,@LIEU_MVTS,@NOTE_MVTS,@TIMESTART_MVTS,@DATEDEPART_MVTS,GETDATE()) ", Conn.cn);
                                SqlCmd.Parameters.AddWithValue("@ID_PERS", IdConducteur);
                                SqlCmd.Parameters.AddWithValue("@ID_VEHICULE", IdVehicule);
                                SqlCmd.Parameters.AddWithValue("@CODE_MVTS", CodMouvement);
                                SqlCmd.Parameters.AddWithValue("@STATUT_MVTS", CbxStatutMvt.Text);
                                SqlCmd.Parameters.AddWithValue("@TIMESTART_MVTS", TimeStartMvt.Value.ToString("hh:mm:ss"));
                                //SqlCmd.Parameters.AddWithValue("@KILO_APRES_MVTS", decimal.Parse(TbxKiloParcouApresMvt.Text));
                                SqlCmd.Parameters.AddWithValue("@DESCRIPTION_MVTS", TbxDescriptionMvt.Text);
                                SqlCmd.Parameters.AddWithValue("@LIEU_MVTS", CbxLieuMvts.Text);
                                SqlCmd.Parameters.AddWithValue("@NOTE_MVTS", RtbxNoteMvt.Text);
                                SqlCmd.Parameters.AddWithValue("@DATEDEPART_MVTS", DateDepartMvt.Value.ToString("dd/MM/yyyy"));
                                SqlCmd.ExecuteNonQuery();
                                MessageBox.Show("Enregistré avec succès !");
                                // Clear the fields
                                TbxCodMvt.Clear();TbxDescriptionMvt.Clear();RtbxNoteMvt.Clear();CbxConducMvt.SelectedItem=null;CbxVehicule.SelectedItem = null;CbxLieuMvts.SelectedItem = null;
                                
                            }

                            // Update state car
                            SqlCmd = new SqlCommand("UPDATE VEHICULE SET ETAT_VEHICULE=@ETAT_VEHICULE WHERE ID_VEHICULE='" + IdVehicule + "'", Conn.cn);
                            SqlCmd.Parameters.AddWithValue("@ETAT_VEHICULE", CbxStatutMvt.Text);
                            SqlCmd.ExecuteNonQuery();
                            
                            Conn.cn.Close();
                            
                        }
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void CbxVehicule_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_VEHICULE FROM VEHICULE WHERE IMMATRICULATION_VEHICULE = '" + CbxVehicule.SelectedItem + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdVehicule = MyReader[0].ToString();
                        }
                        MyReader.Close();
                        // Calculate total kilometers of car
                        //SqlCmd = new SqlCommand("SELECT SUM((KILO_APRES_MVTS + KILOMETRE_AVA_MVTS)) AS KILOTOTAL FROM MOUVEMENTS LEFT OUTER JOIN VEHICULE ON MOUVEMENTS.ID_VEHICULE=VEHICULE.ID_VEHICULE WHERE VEHICULE.ID_VEHICULE = '" + IdVehicule + "'", Conn.cn);
                        //MyReader = SqlCmd.ExecuteReader();
                        //while (MyReader.Read())
                        //{
                        //    TbxKilometreAvantMvt.Text = MyReader[0].ToString();
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Fill combobox vehicule
        private void FillComboboxVehicule()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_VEHICULE,IMMATRICULATION_VEHICULE FROM VEHICULE WHERE TYPE_VEHICULE = 'Pool' AND ETAT_VEHICULE='Parking' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            CbxVehicule.Items.Add(MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            CbxVehicule.DisplayMember = (MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            CbxVehicule.ValueMember = (MyReader["ID_VEHICULE"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Methode te generate code
        private string generateCodeMvt()
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
                        SqlCmd = new SqlCommand("SELECT CODE_MVTS FROM MOUVEMENTS WHERE ID_MVTS=(SELECT MAX(ID_MVTS) FROM MOUVEMENTS)", Conn.cn);
                        SqlAda = new SqlDataAdapter(SqlCmd);
                        Ds = new DataSet();
                        SqlAda.Fill(Ds);

                        if (Ds.Tables[0].Rows.Count > 0)
                        {
                            TbxCodMvt.Text = Ds.Tables[0].Rows[0]["CODE_MVTS"].ToString();
                        }
                        else
                        {
                            TbxCodMvt.Text = "MVT0000";
                        }
                        if (!string.IsNullOrEmpty(TbxCodMvt.Text))
                        {
                            TbxCodMvt.SelectionStart = 3;
                            TbxCodMvt.SelectionLength = 4;
                            TbxCodMvt.Text = TbxCodMvt.SelectedText;
                        }
                        if (!string.IsNullOrEmpty(TbxCodMvt.Text))
                        {
                            int codeMvt = int.Parse(TbxCodMvt.Text.ToString()) + 1;
                            TbxCodMvt.Text = codeMvt.ToString("MVT0000");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             return TbxCodMvt.Text;
        }
    }
}
