using System;
using System.Collections.Generic;

namespace KitBoxAPP
{
	public class OrderClient : Order
	{
		private string name_client;
		private string address_client;

		public OrderClient () : base ()
		{
			name_client = "";
			address_client = "";
		}

		public double Price ()
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

	}
}

