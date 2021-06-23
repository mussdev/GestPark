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
    public partial class FormAttributeCarToPerson : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataAdapter SqlAda;
        public FormAttributeCarToPerson()
        {
            InitializeComponent();
        }

        private void IbtnCloseFormMainAttribute_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IbtnCreateAttribute_Click(object sender, EventArgs e)
        {
            FormCreateAttributeCar AttributeCar = new FormCreateAttributeCar();
            AttributeCar.ShowDialog();
        }

        private void IbtnSearchCarAttribute_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TbxSearchAttribute.Text))
            {
                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                    ConnectDB Conn = new ConnectDB(connectionString);
                    using (Conn.cn)
                    {
                        if (Conn.IsConnection)
                        {
                            SqlCmd = new SqlCommand("SELECT * FROM APPARTENIR LEFT OUTER JOIN PERSONNELS ON APPARTENIR.ID_PERS = PERSONNELS.ID_PERS LEFT OUTER JOIN VEHICULE ON APPARTENIR.ID_VEHICULE = VEHICULE.ID_VEHICULE WHERE PERSONNELS.DESCRIPTION_PERS LIKE @DESCRIPTION_PERS", Conn.cn);
                            //  SqlCmd.Parameters.AddWithValue("@IMMATRICULATION_VEHICULE", string.Format("%{0}%", TbxSearchAttribute.Text));
                            SqlCmd.Parameters.AddWithValue("@DESCRIPTION_PERS", string.Format("%{0}%", TbxSearchAttribute.Text));
                            SqlAda = new SqlDataAdapter(SqlCmd);
                            DataSet Tb = new DataSet();
                            SqlAda.Fill(Tb);

                            // Fill DataGridView
                            dataGridViewAttributeCar.AutoGenerateColumns = false;
                            dataGridViewAttributeCar.DataSource = Tb.Tables[0];
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "GestPark : GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridViewAttributeCar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormAttributeCarModify AttributeCarModify = new FormAttributeCarModify();
            AttributeCarModify.TbxCodeAttr.Text = this.dataGridViewAttributeCar.CurrentRow.Cells[1].Value?.ToString();
            AttributeCarModify.CbxVehiculeAttrMod.Text = this.dataGridViewAttributeCar.CurrentRow.Cells[2].Value?.ToString();
            AttributeCarModify.CbxProprietAttrMod.Text = this.dataGridViewAttributeCar.CurrentRow.Cells[3].Value?.ToString();
            AttributeCarModify.RbtxNoteAttr.Text = this.dataGridViewAttributeCar.CurrentRow.Cells[4].Value?.ToString();
            AttributeCarModify.DatePikerCreateAttr.Text = this.dataGridViewAttributeCar.CurrentRow.Cells[5].Value?.ToString();
            AttributeCarModify.DateAttrVehi.Text = this.dataGridViewAttributeCar.CurrentRow.Cells[6].Value?.ToString();
            AttributeCarModify.ShowDialog();
        }
    }
}
