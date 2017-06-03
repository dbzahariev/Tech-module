using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_15.Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int PeshoDemage = int.Parse(Console.ReadLine());
            int GoshoDemage = int.Parse(Console.ReadLine());

            int PeshoHelth = 100;
            int GoshoHelth = 100;
            bool Death = false;
            int Round = 0;


            while (Death == false)
            {
                Round++;
                if ((Round) % 2 == 1)
                {
                    GoshoHelth -= PeshoDemage;
                    if (GoshoHelth <= 0)
                    {
                        Console.WriteLine($"Pesho won in {Round}th round.");
                        Death = true;
                    }
                    else
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {GoshoHelth} health.");
                    }
                }
                else
                {
                    PeshoHelth -= GoshoDemage;
                    if (PeshoHelth <= 0)
                    {
                        Console.WriteLine($"Gosho won in {Round}th round.");
                        Death = true;
                    }
                    else
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {PeshoHelth} health.");
                    }
                }
                if ((Round) != 0 && (Round) % 3 == 0 && Death == false)
                {
                    GoshoHelth += 10;
                    PeshoHelth += 10;
                }
            }
        }
    }
}
