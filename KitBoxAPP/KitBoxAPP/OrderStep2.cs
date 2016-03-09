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
    public partial class OrderStep2 : Form
    {
        public OrderStep2()
        {
            InitializeComponent();
            button_home2.BackColor = System.Drawing.Color.DarkRed;
            button_next2.BackColor = System.Drawing.Color.LightBlue;
            button_previous2.BackColor = System.Drawing.Color.LightBlue;
        }

        private void button_previous2_Click(object sender, EventArgs e)
        {
            OrderStep1 optionForm = new OrderStep1();
            this.Hide();
            optionForm.Show();
        }

        private void button_next2_Click(object sender, EventArgs e)
        {
            OrderStep3 optionForm = new OrderStep3();
            this.Hide();
            optionForm.Show();
        }

        private void button_home2_Click(object sender, EventArgs e)
        {
            Home_client optionForm = new Home_client();
            this.Hide();
            optionForm.Show();
        }

    }
}
