using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Passed_or_Failed
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
            else
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}
