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
    public partial class OrdersToAchieveStep2 : Form
	{
		private DBManager mgr;

		public OrdersToAchieveStep2(DBManager mgr)
		{
			this.mgr = mgr;

            InitializeComponent();
            button_home101.BackColor = System.Drawing.Color.DarkRed;
            button_orderOK.BackColor = System.Drawing.Color.LightBlue;
        }

        private void label_client2_Click(object sender, EventArgs e)
        {

        }

        private void button_home101_Click(object sender, EventArgs e)
        {
			Home_staff optionForm = new Home_staff(this.mgr);

            this.Hide();

            optionForm.Show();
        }

        
    }
}
