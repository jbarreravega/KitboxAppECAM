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
    public partial class StockManagementStep1 : Form
    {
        public StockManagementStep1()
        {
            InitializeComponent();
            button_home110.BackColor = System.Drawing.Color.DarkRed;
            button_changePiece1.BackColor = System.Drawing.Color.LightBlue;
            button_deletePiece1.BackColor = System.Drawing.Color.LightBlue;
            button_addPiece1.BackColor = System.Drawing.Color.LightBlue;
        }

        private void button_addPiece1_Click(object sender, EventArgs e)
        {
            StockManagementStep2 optionForm = new StockManagementStep2();

            this.Hide();

            optionForm.Show();
        }

        private void button_deletePiece1_Click(object sender, EventArgs e)
        {
            StockManagementStep3 optionForm = new StockManagementStep3();

            this.Hide();

            optionForm.Show();
        }

        private void button_changePiece1_Click(object sender, EventArgs e)
        {
            StockManagementStep4 optionForm = new StockManagementStep4();

            this.Hide();

            optionForm.Show();
        }

        private void button_home110_Click(object sender, EventArgs e)
        {
            Home_staff optionForm = new Home_staff();

            this.Hide();

            optionForm.Show();
        }
    }
}
