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
    public partial class Home_client : Form
    {
        public Home_client()
        {
            InitializeComponent();
            button_client.BackColor = Color.Black;
            button_staff.BackColor = Color.Black;
            button_catalog.BackColor = Color.LightBlue;
            button_order.BackColor = Color.LightBlue;
        }
    }
}
