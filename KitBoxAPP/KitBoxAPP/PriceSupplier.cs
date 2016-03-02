using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBoxAPP
{
    class PriceSupplier
    {
        private Supplier supplier;
        private double price;
        private DateTime delivery_time;

        public PriceSupplier(Supplier supplier, double price, DateTime delivery_time)
        {
            this.supplier = supplier;
            this.price = price;
            this.delivery_time = delivery_time;
        }

        public Supplier Supplier
        {
            get
            {
                return supplier;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public DateTime DeliveryTime
        {
            get
            {
                return delivery_time;
            }
            set
            {
                delivery_time = value;
            }
        }
    }
}
