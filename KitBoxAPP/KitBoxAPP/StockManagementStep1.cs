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
    }
}
