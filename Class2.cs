using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public static class Class2
    {
        public static void Show(this int no)
        {
            Console.WriteLine(no);
        }
        public static void Show(this double no)
        {
            Console.WriteLine(no);
        }

        public static double ToDouble(this int no)
        {
            return Convert.ToDouble(no);
        }

        public static int Mul(this int no, int times)
        {
            return no * times;
        }
    }
}
