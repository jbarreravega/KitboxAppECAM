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
    public partial class OrdersToAchieveStep2 : Form
    {
        public OrdersToAchieveStep2()
        {
            InitializeComponent();
            button_home101.BackColor = System.Drawing.Color.DarkRed;
            button_orderOK.BackColor = System.Drawing.Color.LightBlue;
        }

        private void label_client2_Click(object sender, EventArgs e)
        {

        }

        private void button_home101_Click(object sender, EventArgs e)
        {
            Home_staff optionForm = new Home_staff();

            this.Hide();

            optionForm.Show();
        }

        
    }
}
