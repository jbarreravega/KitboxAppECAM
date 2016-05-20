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
    public partial class Home_client : Form
    {
		private DBManager mgr;

        public Home_client(DBManager mgr)
        {
            this.mgr = mgr;

			InitializeComponent();
            button_client.BackColor = System.Drawing.Color.Black;
            button_staff.BackColor = System.Drawing.Color.Black;
            button_catalog.BackColor = System.Drawing.Color.LightBlue;
            button_order.BackColor = System.Drawing.Color.LightBlue;
        }

        private void button_order_Click(object sender, EventArgs e)
        {
            OrderStep1 Order1 = new OrderStep1(this.mgr);
            this.Hide();
            Order1.ShowDialog();
            this.Show();
        }

		private void button_staff_Click (object sender, EventArgs e)
		{
			/* 
               ToGoToHomeStaff optionForm = new ToGoToHomeStaff();

                this.Hide();

                optionForm.Show();
			 */
            
		}
    }
}
