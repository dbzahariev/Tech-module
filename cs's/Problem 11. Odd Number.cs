using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11.Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = Math.Abs(int.Parse(Console.ReadLine()));

            while (N1 % 2 == 0)
            {
                Console.WriteLine("Please write an odd number.");
                N1 = Math.Abs(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine($"The number is: {N1}");
        }
    }
}
