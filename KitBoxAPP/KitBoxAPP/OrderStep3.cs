﻿using System;
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
		private DBManager mgr;

		public OrderStep3(DBManager mgr)
		{
			this.mgr = mgr;

            InitializeComponent();
			button_home3.BackColor = System.Drawing.Color.DarkRed;
			button_next3.BackColor = System.Drawing.Color.LightBlue;
			button_previous3.BackColor = System.Drawing.Color.LightBlue;
        }

        private void label_step31_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button_previous3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button_next3_Click(object sender, EventArgs e)
        {
			OrderStep4 Order4 = new OrderStep4(this.mgr);
            this.Hide();
            Order4.ShowDialog();
            this.Show();
        }

        private void button_home3_Click(object sender, EventArgs e)
        {
			Home_client optionForm = new Home_client(this.mgr);
            this.Close();
            optionForm.Show();
        }
    }
}
