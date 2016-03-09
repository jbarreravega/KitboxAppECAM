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
    public partial class OrderStep3 : Form
    {
        public OrderStep3()
        {
            InitializeComponent();
			button_home3.BackColor = System.Drawing.Color.DarkRed;
			button_next3.BackColor = System.Drawing.Color.LightBlue;
			button_previous3.BackColor = System.Drawing.Color.LightBlue;
        }

        private void label_step31_Click(object sender, EventArgs e)
        {
            OrderStep1 optionForm = new OrderStep1();
            this.Hide();
            optionForm.Show();
        }

        private void button_previous3_Click(object sender, EventArgs e)
        {
            OrderStep2 optionForm = new OrderStep2();
            this.Hide();
            optionForm.Show();
        }

        private void button_next3_Click(object sender, EventArgs e)
        {
            OrderStep4 optionForm = new OrderStep4();
            this.Hide();
            optionForm.Show();
        }

        private void button_home3_Click(object sender, EventArgs e)
        {
            Home_client optionForm = new Home_client();
            this.Hide();
            optionForm.Show();
        }
    }
}
