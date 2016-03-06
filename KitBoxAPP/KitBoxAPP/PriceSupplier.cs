using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBoxAPP
{
    public class PriceSupplier
    {
        private Supplier supplier;
        private double price;
        private int delivery_time; // in days

        public PriceSupplier(Supplier supplier, double price, int delivery_time)
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

        public int DeliveryTime
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
