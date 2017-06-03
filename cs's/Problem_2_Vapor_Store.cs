using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2_Vapor_Store
{
    class Problem_2_Vapor_Store
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            string game = Console.ReadLine();

            double BoughtBalance = 0;
            double game1Price = 39.99;
            double game2Price = 15.99;
            double game3Price = 19.99;
            double game4Price = 59.99;
            double game5Price = 29.99;
            double game6Price = 39.99;
            string output = "";


            while (game != "Game Time")
            {
                switch (game)
                {
                    case "OutFall 4":
                        if (game1Price <= balance)
                        {
                            BoughtBalance += game1Price;
                            balance -= game1Price;
                            output += "Bought OutFall 4\n";
                        }
                        else
                        {
                            output += "Too Expensive\n";
                        }
                        break;

                    case "CS: OG":
                        if (game2Price <= balance)
                        {
                            BoughtBalance += game2Price;
                            balance -= game2Price;
                            output += $"Bought CS: OG\n";
                        }
                        else
                        {
                            output += "Too Expensive\n";
                        }
                        break;

                    case "Zplinter Zell":
                        if (game3Price <= balance)
                        {
                            BoughtBalance += game3Price;
                            balance -= game3Price;
                            output += $"Bought Zplinter Zell\n";
                        }
                        else
                        {
                            output += "Too Expensive\n";
                        }
                        break;

                    case "Honored 2":
                        if (game4Price <= balance)
                        {
                            BoughtBalance += game4Price;
                            balance -= game4Price;
                            output += $"Bought Honored 2\n";
                        }
                        else
                        {
                            output += "Too Expensive\n";
                        }
                        break;

                    case "RoverWatch":
                        if (game5Price <= balance)
                        {
                            BoughtBalance += game5Price;
                            balance -= game5Price;
                            output += $"Bought RoverWatch\n";
                        }
                        else
                        {
                            output += "Too Expensive\n";
                        }
                        break;

                    case "RoverWatch Origins Edition":
                        if (game6Price <= balance)
                        {
                            BoughtBalance += game6Price;
                            balance -= game6Price;
                            output += $"Bought RoverWatch Origins Edition\n";
                        }
                        else
                        {
                            output += "Too Expensive\n";
                        }
                        break;

                    default:
                        output += "Not Found\n";
                        break;

                }
                game = Console.ReadLine();
            }


            output = output.Remove(output.Length - 1);
            Console.WriteLine(output);
            if (balance == 0)
            {
                Console.WriteLine("Out of money!");
            }
            else
            {
                Console.WriteLine($"Total spent: ${BoughtBalance:f2}. Remaining: ${balance:f2}");
            }
        }
    }
}
