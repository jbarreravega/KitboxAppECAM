using System;
using System.Collections.Generic;

namespace KitBoxAPP
{
	public class OrderClient : Order
	{
		private string name_client;
		private string address_client;
        private DateTime order_time, delivery_time;

        /// <summary>
        /// Default constructor
        /// </summary>
		public OrderClient () : base ()
		{
			name_client = "";
			address_client = "";
		}

        /// <summary>
        /// Constuctor using parameters
        /// </summary>
        /// <param name="name_client"></param>
        /// <param name="address_client"></param>
        /// <param name="pieces"></param>
        /// <param name="order_time"></param>
		public OrderClient (string name_client, string address_client,
		                    List<Piece> pieces, DateTime order_time) 
                            : base (pieces)
		{
			this.name_client = name_client;
			this.address_client = address_client;
            this.order_time = order_time;
		}

        /// <summary>
        /// Returns the price of the ordrer
        /// </summary>
        /// <returns>double price</returns>
		public override double Price ()
		{
			// To be implemented
			return 0.0;
		}

		// Properties

		public string NameClient
		{
			get { return name_client; }
			set { name_client = value; }
		}

		public string AddressClient
		{
			get { return address_client; }
			set { address_client = value; }
		}

        public DateTime OrderTime
        {
            get { return order_time; }
        }

        public DateTime DeliveryTime
        {
            get { return delivery_time; }
        }
	}
}

