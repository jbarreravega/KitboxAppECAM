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
    public partial class OrderStep5 : Form
	{
		private DBManager mgr;

		public OrderStep5(DBManager mgr)
		{
			this.mgr = mgr;

            InitializeComponent();
			button_home5.BackColor = System.Drawing.Color.DarkRed;
			button_next5.BackColor = System.Drawing.Color.LightBlue;
			button_previous5.BackColor = System.Drawing.Color.LightBlue;
        }

        private void label_step51_Click(object sender, EventArgs e)
        {
			OrderStep1 optionForm = new OrderStep1(this.mgr);
            this.Hide();
            optionForm.Show();
        }

        private void label_step52_Click(object sender, EventArgs e)
        {
			OrderStep2 optionForm = new OrderStep2(this.mgr);
            this.Hide();
            optionForm.Show();
        }

        private void label_step53_Click(object sender, EventArgs e)
        {
			OrderStep3 optionForm = new OrderStep3(this.mgr);
            this.Hide();
            optionForm.Show();
        }

        private void button_previous5_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button_next5_Click(object sender, EventArgs e)
        {
			OrderStep6 Order6 = new OrderStep6(this.mgr);
            this.Hide();
            Order6.ShowDialog();
            this.Show();
        }

        private void button_home5_Click(object sender, EventArgs e)
        {
			Home_client optionForm = new Home_client(this.mgr);
            this.Hide();
            optionForm.Show();
        }
    }
}
