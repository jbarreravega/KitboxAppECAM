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
			Test ();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home_client());
            //Application.Run(new OrderStep1());
            //Application.Run(new OrderStep2());
            //Application.Run(new OrderStep3());
            //Application.Run(new OrderStep4());
            //Application.Run(new OrderStep5());
            //Application.Run(new OrderStep6());
            //Application.Run(new OrderStep7());
            //Application.Run(new OrderStep8());
            //Application.Run(new OrderStep9());
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
