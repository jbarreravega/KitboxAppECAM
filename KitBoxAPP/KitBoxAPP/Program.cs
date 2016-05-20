using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitBoxAPP
{
    static class Program
   {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
			DBManager mgr = new DBManager ();

			Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home_client(mgr));
        }
    

        /// <summary>
        /// Function to test some code.
        /// </summary>
        static void Test ()
		{
			DBManager mgr = new DBManager ();
			mgr.Stock.List ();
		}
	}
}
