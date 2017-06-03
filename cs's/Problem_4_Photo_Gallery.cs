using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            double size = double.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());


            string orientation = "";
            if (width > height)
            {
                orientation = "landscape";
            }
            else if (width < height)
            {
                orientation = "portrait";
            }
            else
            {
                orientation = "square";
            }

            string sSize = "";
            if (size < 8000)
            {
                sSize = size + "B";
            }
            else if ((size / 1000000) < 1)
            {
                sSize = size / 1000 + "KB";
            }
            else
            {
                sSize = Math.Round((size/1000000),1) + "MB";
            }


            Console.WriteLine($"Name: DSC_{number:D4}.jpg");
            Console.WriteLine($"Date Taken: {day:D2}/{month:D2}/{year:D2} {hours:d2}:{minutes:D2}");
            Console.WriteLine($"Size: {sSize}");
            Console.WriteLine($"Resolution: {width}x{height} ({orientation})");
        }
    }
}
