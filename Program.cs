using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestPark
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // new FormConnectionUser()

            CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("fr-CI");
            CultureInfo.CurrentCulture.NumberFormat.CurrencyGroupSeparator = " ";
            CultureInfo.CurrentCulture.NumberFormat.NumberGroupSeparator = " ";

            Application.Run(new FormConnectionUser());
            //Application.Run(new MainGestPark());
        }
    }
}
