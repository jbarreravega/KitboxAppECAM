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
    public partial class OrderStep7 : Form
    {
        public OrderStep7()
        {
            InitializeComponent();
            button_home7.BackColor = System.Drawing.Color.DarkRed;
            button_next7.BackColor = System.Drawing.Color.LightBlue;
            button_previous7.BackColor = System.Drawing.Color.LightBlue;
        }

        private void label_step71_Click(object sender, EventArgs e)
        {
            OrderStep1 optionForm = new OrderStep1();
            this.Hide();
            optionForm.Show();
        }

        private void label_step72_Click(object sender, EventArgs e)
        {
            OrderStep2 optionForm = new OrderStep2();
            this.Hide();
            optionForm.Show();
        }

        private void label_step73_Click(object sender, EventArgs e)
        {
            OrderStep3 optionForm = new OrderStep3();
            this.Hide();
            optionForm.Show();

        }

        private void label_step74_Click(object sender, EventArgs e)
        {
            OrderStep4 optionForm = new OrderStep4();
            this.Hide();
            optionForm.Show();
        }

        private void label_step75_Click(object sender, EventArgs e)
        {
            OrderStep5 optionForm = new OrderStep5();
            this.Hide();
            optionForm.Show();
        }

        private void button_previous7_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button_next7_Click(object sender, EventArgs e)
        {
            OrderStep8 Order8 = new OrderStep8();
            this.Hide();
            Order8.ShowDialog();
            this.Show();
        }

        private void button_home7_Click(object sender, EventArgs e)
        {
            Home_client optionForm = new Home_client();
            this.Hide();
            optionForm.Show();
        }
    }
}
