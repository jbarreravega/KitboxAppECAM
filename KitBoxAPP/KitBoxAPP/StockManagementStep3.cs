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
    public partial class StockManagementStep3 : Form
	{
		private DBManager mgr;

		public StockManagementStep3(DBManager mgr)
		{
			this.mgr = mgr;

            InitializeComponent();
            button_home112.BackColor = System.Drawing.Color.DarkRed;
            button_no30.BackColor = System.Drawing.Color.Green;
            button_yes30.BackColor = System.Drawing.Color.Red;
        }

        private void label_amount21_Click(object sender, EventArgs e)
        {

        }
    }
}
