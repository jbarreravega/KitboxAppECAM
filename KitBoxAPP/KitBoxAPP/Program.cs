    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitBoxAPP
{
    static class Program
   {
		private DBManager mgr;

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
			this.mgr = new DBManager ();

			Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home_client(this.mgr));
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
