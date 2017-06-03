using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Theatre_Promotions
{
    class Program
    {
        static void Main(string[] args)
        {
            int Price = 0;
            string Day = Console.ReadLine();
            int Age = int.Parse(Console.ReadLine());

            if ((Day == "Weekday") && ((0 <= Age) && (Age <= 18)))
            {
                Price = 12;
            }
            else if ((Day == "Weekday") && ((18 < Age) && (Age <= 64)))
            {
                Price = 18;
            }
            else if ((Day == "Weekday") && ((64 < Age) && (Age <= 122)))
            {
                Price = 12;
            }


            else if ((Day == "Weekend") && ((0 <= Age) && (Age <= 18)))
            {
                Price = 15;
            }
            else if ((Day == "Weekend") && ((18 < Age) && (Age <= 64)))
            {
                Price = 20;
            }
            else if ((Day == "Weekend") && ((64 < Age) && (Age <= 122)))
            {
                Price = 15;
            }


            else if ((Day == "Holiday") && ((0 <= Age) && (Age <= 18)))
            {
                Price = 5;
            }
            else if ((Day == "Holiday") && ((18 < Age) && (Age <= 64)))
            {
                Price = 12;
            }
            else if ((Day == "Holiday") && ((64 < Age) && (Age <= 122)))
            {
                Price = 10;
            }


            if (Price > 0)
            {
                Console.WriteLine($"{Price}$");
            }
            else {
                Console.WriteLine("Error!");
            }
        }
    }
}
