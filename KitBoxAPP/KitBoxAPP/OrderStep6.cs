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
        public OrderStep6()
        {
            InitializeComponent();
            button_home6.BackColor = System.Drawing.Color.DarkRed;
            button_next6.BackColor = System.Drawing.Color.LightBlue;
            button_previous6.BackColor = System.Drawing.Color.LightBlue;
        }

        private void label_step61_Click(object sender, EventArgs e)
        {
            OrderStep1 optionForm = new OrderStep1();
            this.Hide();
            optionForm.Show();
        }

        private void label_step62_Click(object sender, EventArgs e)
        {
            OrderStep2 optionForm = new OrderStep2();
            this.Hide();
            optionForm.Show();
        }

        private void label_step63_Click(object sender, EventArgs e)
        {
            OrderStep3 optionForm = new OrderStep3();
            this.Hide();
            optionForm.Show();
        }

        private void label_step64_Click(object sender, EventArgs e)
        {
            OrderStep4 optionForm = new OrderStep4();
            this.Hide();
            optionForm.Show();
        }

        private void button_previous6_Click(object sender, EventArgs e)
        {
            OrderStep5 optionForm = new OrderStep5();
            this.Hide();
            optionForm.Show();
        }

        private void button_next6_Click(object sender, EventArgs e)
        {
            OrderStep7 optionForm = new OrderStep7();
            this.Hide();
            optionForm.Show();
        }

        private void button_home6_Click(object sender, EventArgs e)
        {
            Home_client optionForm = new Home_client();
            this.Hide();
            optionForm.Show();
        }
    }
}
