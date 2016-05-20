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
    public partial class OrderStep6 : Form
	{
		private DBManager mgr;

		public OrderStep6(DBManager mgr)
		{
			this.mgr = mgr;

            InitializeComponent();
            button_home6.BackColor = System.Drawing.Color.DarkRed;
            button_next6.BackColor = System.Drawing.Color.LightBlue;
            button_previous6.BackColor = System.Drawing.Color.LightBlue;
        }

        private void label_step61_Click(object sender, EventArgs e)
        {
			OrderStep1 optionForm = new OrderStep1(this.mgr);
            this.Hide();
            optionForm.Show();
        }

        private void label_step62_Click(object sender, EventArgs e)
        {
			OrderStep2 optionForm = new OrderStep2(this.mgr);
            this.Hide();
            optionForm.Show();
        }

        private void label_step63_Click(object sender, EventArgs e)
        {
			OrderStep3 optionForm = new OrderStep3(this.mgr);
            this.Hide();
            optionForm.Show();
        }

        private void label_step64_Click(object sender, EventArgs e)
        {
			OrderStep4 optionForm = new OrderStep4(this.mgr);
            this.Hide();
            optionForm.Show();
        }

        private void button_previous6_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button_next6_Click(object sender, EventArgs e)
        {
			OrderStep7 Order7 = new OrderStep7(this.mgr);
            this.Hide();
            Order7.ShowDialog();
            this.Show();
        }

        private void button_home6_Click(object sender, EventArgs e)
        {
			Home_client optionForm = new Home_client(this.mgr);
            this.Hide();
            optionForm.Show();
        }
    }
}
