using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());

            int SN = Math.Min(N1, N2);
            int EN = Math.Max(N1, N2);

            for (int i = SN; i <= EN; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
