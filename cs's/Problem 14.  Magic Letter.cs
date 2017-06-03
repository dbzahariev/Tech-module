using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_14.Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char C1 = char.Parse(Console.ReadLine());
            char C2 = char.Parse(Console.ReadLine());
            char C3 = char.Parse(Console.ReadLine());

            for (char i = C1; i <= C2; i++)
            {
                for (char i2 = C1; i2 <= C2; i2++)
                {
                    for (char i3 = C1; i3 <= C2; i3++)
                    {
                        if (i != C3 && i2 != C3 && i3 != C3)
                        {
                            Console.Write($"{i}{i2}{i3} ");
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
