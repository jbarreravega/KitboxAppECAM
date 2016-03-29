using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBoxAPP
{
    public class OrderWizard
    {
        private List<Furniture> furniture;
        private string name_client, address_client;

        public OrderWizard(List<Furniture> furniture, string name_client,
                           string address_client)
        {
            this.furniture = furniture;
            this.name_client = name_client;
            this.address_client = address_client;
        }

		public OrderWizard()
		{
			this.furniture = new List<Furniture> ();
			this.name_client = "";
			this.address_client = "";
		}

        public Order CreateOrder()
        {
			// not implemented yet
            return null;
        }
    }
}
