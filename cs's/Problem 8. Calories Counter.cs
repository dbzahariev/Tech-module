using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string ingredients = "";
            int calories = 0;

            for (int i = 0; i < count; i++)
            {
                ingredients = Console.ReadLine();
                if (ingredients.ToLower() == "cheese")
                {
                    calories = calories + 500;
                }
                else if (ingredients.ToLower() == "tomato sauce")
                {
                    calories = calories + 150;
                }
                else if (ingredients.ToLower() == "salami")
                {
                    calories = calories + 600;
                }
                else if (ingredients.ToLower() == "pepper")
                {
                    calories = calories + 50;
                }
            }
            Console.WriteLine($"Total calories: {calories}");
        }
    }
}
