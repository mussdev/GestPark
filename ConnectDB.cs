using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GestPark
{
    class ConnectDB
    {
        public SqlConnection cn;
   
        public ConnectDB(string connectionString)
        {
            try
            {
                cn = new SqlConnection(connectionString);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "GestPark: GESTION ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
               // FormConnexionGestPark ConnGestParkDb = new FormConnexionGestPark();
               //ConnGestParkDb.ShowDialog();
            }
        }

        public bool IsConnection
        {
            get
            {
                if (cn.State == System.Data.ConnectionState.Closed)
                    cn.Open();
                return true;
            }
        }

    }
}
