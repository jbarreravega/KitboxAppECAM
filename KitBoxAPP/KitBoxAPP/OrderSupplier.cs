using System;
using System.Collections.Generic;

namespace KitBoxAPP
{
	public class OrderSupplier : Order
	{
		private Supplier supplier;

		public OrderSupplier (Supplier supplier) : base ()
		{
			this.supplier = supplier;
		}

		public override double Price ()
		{
			return 0.0;
		}

		// Properties

		public Supplier Supplier
		{
			get { return supplier; }
			set { supplier = value; }
		}
	}
}

