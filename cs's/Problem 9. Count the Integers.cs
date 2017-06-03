using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string N1 = Console.ReadLine();

            int count = 0;

            int number = int.MinValue;
            while (int.TryParse(N1, out number))
            {
                count++;
                N1 = Console.ReadLine();
            }

            Console.WriteLine(count);
        }
    }
}
