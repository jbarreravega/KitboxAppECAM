using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitBoxAPP
{
    public partial class StockManagementStep4 : Form
	{
		private DBManager mgr;

		public StockManagementStep4(DBManager mgr)
		{
			this.mgr = mgr;

            InitializeComponent();
            button_home113.BackColor = System.Drawing.Color.DarkRed;
            button_yes40.BackColor = System.Drawing.Color.Green;
            button_no40.BackColor = System.Drawing.Color.Red;
        }
    }
}
