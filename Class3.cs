using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Class3
    {
        private Class3[] cls = new Class3[100];

        public Class3 this[int i]
        {
            get { return cls[i]; }
            set { cls[i] = value; }
        }

        public string AAA { get; set; }
    }
}
