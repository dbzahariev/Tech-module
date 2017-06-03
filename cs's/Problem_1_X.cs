using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1_X
{
    class Problem_1_X
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int newn = n;

            for (int A = 0; A < n/2; A++)
            {
                Console.Write(new string(' ', A));
                Console.Write('x');
                Console.Write(new string(' ', newn - 2));
                Console.Write('x');
                newn = newn - 2;
                Console.WriteLine();
            }
            newn = n;
            Console.Write(new string(' ', (n / 2)));
            Console.Write('x');
            Console.WriteLine();
            for (int B = 1; B <= n/2; B ++)
            {
                Console.Write(new string(' ', (newn / 2 - 1)));
                Console.Write('x');
                Console.Write(new string(' ', (B+B)-1));
                Console.Write('x');
                newn = newn - 2;
                Console.WriteLine();
            }
        }
    }
}