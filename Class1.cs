using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public static class Class1
    {
        public static void Show(this IEnumerable<int> data)
        {
            foreach (int no in data)
                Console.Write("{0}, ", no);
            Console.WriteLine();
        }
    }
}
