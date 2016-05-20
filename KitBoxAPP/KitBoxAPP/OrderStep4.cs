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
    public partial class OrderStep4 : Form
	{
		private DBManager mgr;

		public OrderStep4(DBManager mgr)
		{
			this.mgr = mgr;

            InitializeComponent();
			button_home4.BackColor = System.Drawing.Color.DarkRed;
			button_next4.BackColor = System.Drawing.Color.LightBlue;
			button_previous4.BackColor = System.Drawing.Color.LightBlue;
        }

        private void label_step41_Click(object sender, EventArgs e)
        {
			OrderStep1 optionForm = new OrderStep1(this.mgr);
            this.Hide();
            optionForm.Show();
        }

        private void label_step42_Click(object sender, EventArgs e)
        {
			OrderStep2 optionForm = new OrderStep2(this.mgr);
            this.Hide();
            optionForm.Show();
        }

        private void button_previous4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button_next4_Click(object sender, EventArgs e)
        {
			OrderStep5 Order5 = new OrderStep5(this.mgr);
            this.Hide();
            Order5.ShowDialog();
            this.Show();
        }

        private void button_home4_Click(object sender, EventArgs e)
        {
			Home_client optionForm = new Home_client(this.mgr);
            this.Hide();
            optionForm.Show();
        }
    }
}
