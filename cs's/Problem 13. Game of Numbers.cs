using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            int NMagic = int.Parse(Console.ReadLine());

            int countCombi = 0;
            bool foundMagic = false;
            int lastI = 0;
            int lastJ = 0;
            for (int i = N1; i <= N2; i++)
            {
                for (int j = N1; j <= N2; j++)
                {
                    if ((i + j) == NMagic)
                    {
                        lastI = i;
                        lastJ = j;
                        foundMagic = true;
                    }
                    countCombi++;
                }
            }
            if (foundMagic == true)
            {
                Console.WriteLine($"Number found! {lastI} + {lastJ} = {NMagic}");
            }
            else
            {
                Console.WriteLine($"{countCombi} combinations - neither equals {NMagic}");
            }
        }
    }
}
