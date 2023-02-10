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
    public partial class FormAttributeCarModify : Form
    {
        private SqlCommand SqlCmd;
        private Guid IdVehiculeMod, IdProprioMod;
        private SqlDataReader MyReader;
        public FormAttributeCarModify()
        {
            InitializeComponent();
            FillComboboxVehicule();
            FillComboboxProprietor();
        }

        private void CbxVehiculeAttrMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_VEHICULE FROM VEHICULE WHERE IMMATRICULATION_VEHICULE = '" + CbxVehiculeAttrMod.Text + "'", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdVehiculeMod = Guid.Parse(MyReader[0].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbxProprietAttrMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);

                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_PERS FROM PERSONNELS WHERE DESCRIPTION_PERS = '" + CbxProprietAttrMod.SelectedItem + "' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            IdProprioMod = Guid.Parse(MyReader[0].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IbtnRegisterAttributeCarToPersMod_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                DialogResult result = MessageBox.Show("Voulez vous enregister les modificattions ?", "GESTPARC: CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (Conn.cn)
                    {
                        if (Conn.IsConnection)
                        {
                            using (var CmdAttri = Conn.cn.CreateCommand())
                            {
                                CmdAttri.CommandText = "UPDATE APPARTENIR SET ID_PERS=@ID_PERS, ID_VEHICULE=@ID_VEHICULE, DATE_DEBUT_ATTRI=@DATE_DEBUT_ATTRI, DATE_ATTRI=@DATE_ATTRI, NOTE_ATTRI=@NOTE_ATTRI, DATEMODIFY=GETDATE() WHERE CODE_ATTRI = '" + TbxCodeAttrMod.Text + "'";
                                // Request to insert data in table personnels
                                CmdAttri.Parameters.AddWithValue("@ID_PERS", IdProprioMod);
                                CmdAttri.Parameters.AddWithValue("@ID_VEHICULE", IdVehiculeMod);
                                CmdAttri.Parameters.AddWithValue("@DATE_DEBUT_ATTRI", DateAttrVehiMod.Value.ToString("dd/MM/yyyy"));
                                CmdAttri.Parameters.AddWithValue("@DATE_ATTRI", DatePikerCreateAttrMod.Value.ToString("dd/MM/yyyy"));
                                CmdAttri.Parameters.AddWithValue("@NOTE_ATTRI", RbtxNoteAttrMod.Text);
                                CmdAttri.ExecuteNonQuery();
                                //MessageBox.Show("ID car = " + IdVehiculeMod+ " ImmatV = " + CbxVehiculeAttrMod.Text+ " IdProprio = " + IdProprioMod);
                                MessageBox.Show("Les modifications ont été enregistrées avec succès !!!", "GestParc: Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();

                                // Update Table carburant statut

                                CmdAttri.CommandText = " UPDATE VEHICULE SET STATUT_VEHICULE=@STATUT_VEHICULE WHERE ID_VEHICULE='" + IdVehiculeMod + "' ";
                                CmdAttri.Parameters.AddWithValue("@STATUT_VEHICULE", "Attribué");
                                CmdAttri.ExecuteNonQuery();
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

        private void FillComboboxProprietor()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                ConnectDB Conn = new ConnectDB(connectionString);
                using (Conn.cn)
                {
                    if (Conn.IsConnection)
                    {
                        SqlCmd = new SqlCommand("SELECT ID_PERS, DESCRIPTION_PERS FROM PERSONNELS", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            CbxProprietAttrMod.Items.Add(MyReader["DESCRIPTION_PERS"].ToString());
                            CbxProprietAttrMod.DisplayMember = (MyReader["DESCRIPTION_PERS"].ToString());
                            CbxProprietAttrMod.ValueMember = (MyReader["ID_PERS"].ToString());
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IbtnRegisterAttributeCarToPersMod_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnCreateAttr = new ToolTip();
            ToolTipBtnCreateAttr.AutoPopDelay = 5000;
            ToolTipBtnCreateAttr.InitialDelay = 1000;
            ToolTipBtnCreateAttr.ReshowDelay = 500;
            ToolTipBtnCreateAttr.ShowAlways = true;
            ToolTipBtnCreateAttr.SetToolTip(this.IbtnRegisterAttributeCarToPersMod, "Enregistrer");
        }

        private void IbtnJoindreDocAttrMod_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTipBtnJoinDocAttr = new ToolTip();
            ToolTipBtnJoinDocAttr.AutoPopDelay = 5000;
            ToolTipBtnJoinDocAttr.InitialDelay = 1000;
            ToolTipBtnJoinDocAttr.ReshowDelay = 500;
            ToolTipBtnJoinDocAttr.ShowAlways = true;
            ToolTipBtnJoinDocAttr.SetToolTip(this.IbtnJoindreDocAttrMod, "Joindre doc.");
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
                        SqlCmd = new SqlCommand("SELECT * FROM VEHICULE WHERE TYPE_VEHICULE = 'Affecté' ", Conn.cn);
                        MyReader = SqlCmd.ExecuteReader();
                        while (MyReader.Read())
                        {
                            CbxVehiculeAttrMod.Items.Add(MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            CbxVehiculeAttrMod.DisplayMember = (MyReader["IMMATRICULATION_VEHICULE"].ToString());
                            CbxVehiculeAttrMod.ValueMember = (MyReader["ID_VEHICULE"].ToString());

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
