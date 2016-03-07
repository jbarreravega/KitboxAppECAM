using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace KitBoxAPP
{
    class OrderSupplierManager
    {
        private SQLiteConnection db;

        public OrderSupplierManager(SQLiteConnection db)
        {
            this.db = db;
        }

        public List<OrderSupplier> List()
        {
            return null;
        }

        public OrderSupplier[] FindOrderSupplier()
        {
            return null;
        }

        public bool ChangeStatus(OrderSupplier order_supplier)
        {
            return false;
        }
    }
}
