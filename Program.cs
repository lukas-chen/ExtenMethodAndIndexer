using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 15, 32, 45, 66 ,19, 24, 81, 57 };

            data.Show();

            //var result =
            //    from no in data
            //    where no % 2 == 0
            //    orderby no
            //    select no;

            var result = data
                .Where(no=>no % 2 == 0)
                .OrderBy(no=>no);

            result.Show();


            int no1 = 10;
            no1.Show();

            double no2 = no1.ToDouble();
            no2.Show();

            int no3 = no1.Mul(100);
            no3.Show();


            Class3 cls = new Class3();
            cls[10] = new Class3() { AAA = "Hello"};

            //foreach (Class3 obj in cls)
            //{

            //}
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(cls[i]?.AAA ?? i.ToString());
            }
            Console.ReadKey();
        }
    }
}
