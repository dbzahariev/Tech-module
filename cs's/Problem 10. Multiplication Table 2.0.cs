using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10.Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());

            if (N2 > 10)
            {
                var temp = N1 * N2;
                Console.WriteLine($"{N1} X {N2} = {temp}");
            }
            else
            {
                for (int i = N2; i <= 10; i++)
                {
                    var temp = N1 * i;
                    Console.WriteLine($"{N1} X {i} = {temp}");
                }
            }
        }
    }
}
