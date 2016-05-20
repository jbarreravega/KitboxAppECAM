using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBoxAPP
{
    public class Supplier
    {
		private int code;
        private string name, address;

        //Constructor
        public Supplier(int code, string name, string address)
        {
			this.code = code;
            this.name = name;
            this.address = address;
        }


        //Properties
      	public int Code
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

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
    }
}
