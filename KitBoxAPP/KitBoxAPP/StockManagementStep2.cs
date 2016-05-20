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
    public partial class StockManagementStep2 : Form
	{
		private DBManager mgr;

		public StockManagementStep2(DBManager mgr)
		{
			this.mgr = mgr;

            InitializeComponent();
            button_home111.BackColor = System.Drawing.Color.DarkRed;
            button_yes29.BackColor = System.Drawing.Color.Green;
            button_no29.BackColor = System.Drawing.Color.Red;
        }

        private void button_yes29_Click(object sender, EventArgs e)
        {
            Console.WriteLine("La pièce a été ajoutée au stock");
        }

        private void button_no29_Click(object sender, EventArgs e)
        {
			Home_staff optionForm = new Home_staff(this.mgr);

            this.Hide();

            optionForm.Show();
        }

        private void button_home111_Click(object sender, EventArgs e)
        {
			Home_staff optionForm = new Home_staff(this.mgr);

            this.Hide();

            optionForm.Show();
        }
    }
}
