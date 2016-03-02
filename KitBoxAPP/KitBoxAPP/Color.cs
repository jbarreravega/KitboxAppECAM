using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBoxAPP
{
    class Color
    {
        private int code;
        private string name;

        public Color(int code, string name)
        {
            this.code = code;
            this.name = name;
        }

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
    }
}
