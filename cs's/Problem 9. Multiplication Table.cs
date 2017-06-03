using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                var temp = N * i;
                Console.WriteLine($"{N} X {i} = {temp}");
            }
        }
    }
}
