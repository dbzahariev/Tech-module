using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = Console.ReadLine();
            int Volume = int.Parse(Console.ReadLine());
            int Energy = int.Parse(Console.ReadLine());
            int Sugar = int.Parse(Console.ReadLine());

            double sumEn = (Energy * Volume);
            double sumSu = (Sugar * Volume);

            Console.WriteLine($"{Volume}ml {Name}:");
            Console.WriteLine($"{(sumEn / 100)}kcal, {(sumSu / 100)}g sugars");
        }
    }
}
