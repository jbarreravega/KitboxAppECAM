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
    public partial class OrderStep1 : Form
    {
		private DBManager mgr;
        public string name, firstname, delivery, phone, mail;

        public OrderStep1(DBManager mgr)
		{
			this.mgr = mgr;

            InitializeComponent();
            button_home1.BackColor = System.Drawing.Color.DarkRed;
            button_next1.BackColor = System.Drawing.Color.LightBlue;
        }


        private void OrderStep1_Load(object sender, EventArgs e)
        {

        }

        public void text_box_firstname_TextChanged(object sender, EventArgs e)
        {
            firstname = text_box_firstname.Text;
        }

        public void text_box_delivery_TextChanged(object sender, EventArgs e)
        {
            delivery = text_box_delivery.Text;
        }

        public void text_box_phone_TextChanged(object sender, EventArgs e)
        {
            phone = text_box_phone.Text;
        }

        public void text_box_mail_TextChanged(object sender, EventArgs e)
        {
            mail = text_box_mail.Text;
        }

        public void text_box_name_TextChanged(object sender, EventArgs e)
        {
            name = text_box_name.Text;
        }

        public void button_next1_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderStep2 Order2 = new OrderStep2(this.mgr);
            Order2.ShowDialog();
            this.Show();
        }

        public void button_home1_Click(object sender, EventArgs e)
        {
            Home_client optionForm = new Home_client(this.mgr);
            this.Hide();
            optionForm.Show();
        }

        private void checkBox_yes1_CheckedChanged(object sender, EventArgs e)
        {

        }

       
    }
}
