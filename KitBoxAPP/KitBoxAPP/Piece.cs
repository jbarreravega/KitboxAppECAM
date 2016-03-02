using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBoxAPP
{
    class Piece
    {
        private string code, name;
        private int quantity, min_quantity;
        private int stock_quantity, reserved_quantity;
        private double height, width, depth;
        private double price_client;
        private PriceSupplier[] price_suppliers;
        private Color color;

        public Piece(string code, string name, Color color,
                    double width, double depth, double height,
                    int quantity, int min_quantity, int stock_quantity,
                    int reserved_quantity, PriceSupplier[] price_suppliers)
        {
            this.code = code;
            this.name = name;
            this.color = color;
            this.height = height;
            this.width = width;
            this.depth = depth;
            this.quantity = quantity;
            this.min_quantity = min_quantity;
            this.stock_quantity = stock_quantity;
            this.reserved_quantity = reserved_quantity;
            this.price_suppliers = price_suppliers;
        }

        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }

        public int MinQuantity
        {
            get
            {
                return min_quantity;
            }
            set
            {
                min_quantity = value;
            }
        }

        public int StockQuantity
        {
            get
            {
                return stock_quantity;
            }
            set
            {
                stock_quantity = value;
            }
        }

        public int ReservedQuantity
        {
            get
            {
                return reserved_quantity;
            }
            set
            {
                reserved_quantity = value;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }

        public double Depth
        {
            get
            {
                return depth;
            }
            set
            {
                depth = value;
            }
        }

        public double PriceClient
        {
            get
            {
                return price_client;
            }
            set
            {
                price_client = value;
            }
        }

        public PriceSupplier[] PriceSuppliers
        {
            get
            {
                return price_suppliers;
            }
        }

        public Color Color
        {
            get
            {
                return color;
            }
        }
    }
}
