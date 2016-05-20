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
    public partial class OrdersToAchieveStep1 : Form
	{
		private DBManager mgr;

		public OrdersToAchieveStep1(DBManager mgr)
		{
			this.mgr = mgr;

            InitializeComponent();
            button_home100.BackColor = System.Drawing.Color.DarkRed;
            button_detailsOfOrder.BackColor = System.Drawing.Color.LightBlue;
        }

        private void button_home100_Click(object sender, EventArgs e)
        {
			Home_staff optionForm = new Home_staff(this.mgr);

            this.Hide();

            optionForm.Show();
        }

        private void button_detailsOfOrder_Click(object sender, EventArgs e)
        {
			OrdersToAchieveStep2 optionForm = new OrdersToAchieveStep2(this.mgr);

            this.Hide();

            optionForm.Show();
        }
    }
}
