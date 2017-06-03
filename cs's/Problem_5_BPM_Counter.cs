using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int bPM = int.Parse(Console.ReadLine());
            double beats = double.Parse(Console.ReadLine());

            double time = (beats / bPM) * 60;
            int mins = (int)time / 60;
            double secs = (int)time % 60;

            Console.WriteLine($"{Math.Round(beats / 4, 1)} bars - {mins}m {secs}s");
        }
    }
}
