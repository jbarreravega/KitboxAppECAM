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
    public partial class OrderStep9 : Form
	{
		private DBManager mgr;

		public OrderStep9(DBManager mgr)
		{
			this.mgr = mgr;

            InitializeComponent();
            button_home9.BackColor = System.Drawing.Color.DarkRed;
            button_yes9.BackColor = System.Drawing.Color.Green;
            button_no9.BackColor = System.Drawing.Color.Red;
        }

        private void label_step91_Click(object sender, EventArgs e)
        {
			OrderStep1 optionForm = new OrderStep1(this.mgr);
            this.Hide();
            optionForm.Show();
        }

        private void label_step92_Click(object sender, EventArgs e)
        {
			OrderStep2 optionForm = new OrderStep2(this.mgr);
            this.Hide();
            optionForm.Show();
        }

        private void label_step93_Click(object sender, EventArgs e)
        {
			OrderStep3 optionForm = new OrderStep3(this.mgr);
            this.Hide();
            optionForm.Show();
        }

        private void label_step94_Click(object sender, EventArgs e)
        {
			OrderStep4 optionForm = new OrderStep4(this.mgr);
            this.Hide();
            optionForm.Show();
        }

        private void label_step95_Click(object sender, EventArgs e)
        {
			OrderStep5 optionForm = new OrderStep5(this.mgr);
            this.Hide();
            optionForm.Show();
        }

        private void label_step96_Click(object sender, EventArgs e)
        {
			OrderStep6 optionForm = new OrderStep6(this.mgr);
            this.Hide();
            optionForm.Show();
        }

        private void label_step97_Click(object sender, EventArgs e)
        {
			OrderStep7 optionForm = new OrderStep7(this.mgr);
            this.Hide();
            optionForm.Show();
        }

        private void label_step98_Click(object sender, EventArgs e)
        {
			OrderStep8 optionForm = new OrderStep8(this.mgr);
            this.Hide();
            optionForm.Show();
        }

        private void button_home9_Click(object sender, EventArgs e)
        {
			Home_client optionForm = new Home_client(this.mgr);
            this.Hide();
            optionForm.Show();
        }
    }
}
