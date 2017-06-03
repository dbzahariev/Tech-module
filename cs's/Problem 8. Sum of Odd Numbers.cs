using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int sum = 0;
            int br = 0;
            while (br <= N+N)
            {
                if (br % 2 == 1)
                {
                    Console.WriteLine(br);
                    sum += br;
                }
                br++;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
