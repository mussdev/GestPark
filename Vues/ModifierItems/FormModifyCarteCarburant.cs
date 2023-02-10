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

namespace GestPark
{
    public partial class FormModifyCarteCarburant : Form
    {
        public FormModifyCarteCarburant()
        {
            InitializeComponent();
        }

        private void IbtnCloseFormCardModi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSavedCreateCardMod_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNumCardMod.Text))
            {
                MessageBox.Show("Veillez saisir le numéro de la carte !!!", "GestParc: Avertissement !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if (string.IsNullOrEmpty(TxtSoldeCardMod.Text))
            {
                MessageBox.Show("Veillez saisir le solde de la carte !!!", "GestParc: Avertissement !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if (string.IsNullOrEmpty(CbxTypeCardMod.Text))
            {
                MessageBox.Show("Veillez sélectionner le type de carte !!!", "GestParc: Avertissement !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrEmpty(TxtStationCardMod.Text))
            {
                MessageBox.Show("Veillez saisir la station qui vous a délivré la carte !!!", "GestParc: Avertissement !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try{
                    string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                    ConnectDB Conn = new ConnectDB(connectionString);
                    DialogResult result = MessageBox.Show("Voulez vous enregister les modifications ?", "GESTPARC: CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        using (Conn.cn)
                        {
                            if (Conn.IsConnection)
                            {
                                using (var Cmd = Conn.cn.CreateCommand())
                                {
                                    Cmd.CommandText = "UPDATE CARDPAIEMENT SET NUM_CARD=@NUM_CARD,SOLDE_CARD=@SOLDE_CARD,TPYE_CARD=@TPYE_CARD,STATION_CARD=@STATION_CARD,DATEMODIFY_CARD=GETDATE() WHERE CODE_CARD='" + TxtCodeCardMod.Text + "'";
                                    Cmd.Parameters.AddWithValue("@NUM_CARD", TxtNumCardMod.Text);
                                    Cmd.Parameters.AddWithValue("@SOLDE_CARD", decimal.Parse(TxtSoldeCardMod.Text));
                                    Cmd.Parameters.AddWithValue("@TPYE_CARD", CbxTypeCardMod.Text);
                                    Cmd.Parameters.AddWithValue("@STATION_CARD", TxtStationCardMod.Text);
                                    Cmd.ExecuteNonQuery();
                                    MessageBox.Show("Carte modifiée avec succès !", "GestParc : Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                    Conn.cn.Close();
                                }
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "GestParc: Gestion des erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnRechargeCardMod_Click(object sender, EventArgs e)
        {
            FormRechargeCarte rechargeCarte = new FormRechargeCarte();
            rechargeCarte.ShowDialog();
        }

    }
}
