using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            double groupSize = double.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            string place = "";

            double priceHall = 0;
            double packagePrice = 0;
            double discount = 0;
            double totalPrice = 0;
            double pricePerPerson;
            if (groupSize <= 50)
            {
                place = "Small Hall";
                priceHall = 2500;
            }
            else if (groupSize <= 100)
            {
                place = "Terrace";
                priceHall = 5000;
            }
            else if (groupSize <= 120)
            {
                place = "Great Hall";
                priceHall = 7500;
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            if (package == "Normal")
            {
                packagePrice = 500;
                discount = 5;
            }
            else if (package == "Gold")
            {
                packagePrice = 750;
                discount = 10;
            }
            else if (package == "Platinum")
            {
                packagePrice = 1000;
                discount = 15;
            }

            totalPrice = packagePrice + priceHall;
            totalPrice = totalPrice - (totalPrice * discount / 100);
            pricePerPerson = totalPrice / groupSize;

            Console.WriteLine($"We can offer you the {place}");
            Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
        }
    }
}
