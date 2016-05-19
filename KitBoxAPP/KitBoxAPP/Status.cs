using System;
using System.Collections.Generic;

namespace KitBoxAPP
{
	public class Status
	{
		private int code;
		private string name;

		public Status ()
		{
			code = -1;
			name = "";
		}

        //Return status
		public Status (int code, string name)
		{
			this.code = code;
			this.name = name;
		}

        //Return code
		public int Code
		{
			get { return code; }
			set { code = value; }
		}

        //Return name
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
	}
}

