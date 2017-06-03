using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            float N1 = float.Parse(Console.ReadLine());
            float N2 = float.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2}", (N1 * N2));
        }
    }
}
