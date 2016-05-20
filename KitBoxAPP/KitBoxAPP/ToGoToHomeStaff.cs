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
    public partial class ToGoToHomeStaff : Form
	{
		private DBManager mgr;

		public ToGoToHomeStaff(DBManager mgr)
		{
			this.mgr = mgr;

            InitializeComponent();
        }

        private void Passwd_Text_Box_TextChanged(object sender, EventArgs e)
        {
            string password = "654321";

            string passwd = Passwd_Text_Box.Text;

            if (passwd == password)
            {
				Home_staff optionForm = new Home_staff(this.mgr);

                this.Hide();

                optionForm.Show();
            }
        }

        private void button_homeT1_Click(object sender, EventArgs e)
        {
			Home_client optionForm = new Home_client(this.mgr);

            this.Hide();

            optionForm.Show();
        }
    }
}
