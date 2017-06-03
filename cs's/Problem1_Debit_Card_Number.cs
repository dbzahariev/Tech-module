using System;

namespace Problem1_Debit_Card_Number
{
    class Program
    {
        static void Main()
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            int N3 = int.Parse(Console.ReadLine());
            int N4 = int.Parse(Console.ReadLine());

            Console.WriteLine("{0:D4} {1:D4} {2:D4} {3:D4}", N1, N2, N3, N4);
        }
    }
}
