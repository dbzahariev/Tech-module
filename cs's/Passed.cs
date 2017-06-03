using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Passed
{
    class Program
    {
        static void Main(string[] args)
        {
            double Grade = double.Parse(Console.ReadLine());

            if (Grade >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
