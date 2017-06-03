using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = Console.ReadLine();
            int Health = int.Parse(Console.ReadLine());
            int HealthMax = int.Parse(Console.ReadLine());
            int Energy = int.Parse(Console.ReadLine());
            int EnergyMax = int.Parse(Console.ReadLine());

            string SHealth = new string('|', Health);
            string SHealthNew = new string('.', (HealthMax - Health));
            string SEnergy = new string('|', Energy);
            string SEnergyNew = new string('.', (EnergyMax - Energy));

            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine($"Health: |{(SHealth)}{SHealthNew}|");
            Console.WriteLine($"Energy: |{(SEnergy)}{SEnergyNew}|");
        }
    }
}
