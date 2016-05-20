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
    public partial class Home_staff : Form
    {
        private DBManager mgr;

        public Home_staff(DBManager mgr)
		{
			this.mgr = mgr;

			InitializeComponent();
        }

        private void button_stock_Click(object sender, EventArgs e)
        {
			StockManagementStep1 optionForm = new StockManagementStep1(this.mgr);

            this.Hide();

            optionForm.Show();
        }

        private void button_order0_Click(object sender, EventArgs e)
        {
            OrderStep1 optionForm = new OrderStep1(this.mgr);

            this.Hide();

            optionForm.Show();
        }

        private void button_history_Click(object sender, EventArgs e)
        {
            HistoryOrdersStep1 optionForm = new HistoryOrdersStep1();

            this.Hide();

            optionForm.Show();
        }

        private void button_orderToDo_Click(object sender, EventArgs e)
        {
			OrdersToAchieveStep1 optionForm = new OrdersToAchieveStep1(this.mgr);

            this.Hide();

            optionForm.Show();
        }
    }
}
