using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7_Training_Hall_Equipment
{
    class Problem_7_Training_Hall_Equipment
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double numberItems = double.Parse(Console.ReadLine());

            double subTotal = 0;


            for (int i = 0; i < numberItems; i++)
            {
                string sItemName = Console.ReadLine();
                double itemPrice = double.Parse(Console.ReadLine());
                double itemCount = double.Parse(Console.ReadLine());

                if (itemCount > 1)
                {
                    sItemName += "s";
                }

                Console.WriteLine($"Adding {itemCount} {sItemName} to cart.");
                subTotal += (itemPrice * itemCount);
            }
            Console.WriteLine($"Subtotal: ${subTotal:F2}");
            if (subTotal < budget)
            {
                Console.WriteLine($"Money left: ${Math.Abs(subTotal - budget):F2}");
            }
            else
            {
                Console.WriteLine($"Not enough. We need ${Math.Abs(subTotal - budget):F2} more.");
            }
        }
    }
}
