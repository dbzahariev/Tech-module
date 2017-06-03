using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            int tototalCombi = 0;
            int mySum = 0;

            for (int i = N1; i >= 1; i--)
            {
                for (int j = 1; j <= N2; j++)
                {
                    tototalCombi++;
                    mySum += (i * j) * 3;

                    if (mySum >= sum)
                    {
                        Console.WriteLine($"{tototalCombi} combinations");
                        Console.WriteLine($"Sum: {mySum} >= {sum}");
                        return;
                    }
                }
            }

            Console.WriteLine($"{tototalCombi} combinations");
            Console.WriteLine($"Sum: {mySum}");
            return;
        }
    }
}
