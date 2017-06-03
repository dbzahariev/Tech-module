using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11.Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = N1; i <= N2; i++)
            {
                for (int i2 = N1; i2 <= N2; i2++)
                {
                    for (int i3 = N1; i3 <= N2; i3++)
                    {
                        for (int i4 = N1; i4 <= N2; i4++)
                        {
                            for (int i5 = N1; i5 <= N2; i5++)
                            {
                                if (i<i2 && i2 < i3 && i3 < i4 && i4 < i5)
                                {
                                    Console.WriteLine($"{i} {i2} {i3} {i4} {i5}");
                                    count++;
                                }
                            }
                        }
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}