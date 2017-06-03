using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double studioDis = 0;
            double doublePrice = 0;
            double doubleDis = 0;
            double suitePrice = 0;
            double suiteDis = 0;

            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50;
                    doublePrice = 65;
                    suitePrice = 75;
                    if (nightsCount > 7)
                    {
                        studioDis = 5;
                    }
                    break;

                case "June":
                case "September":
                    studioPrice = 60;
                    doublePrice = 72;
                    suitePrice = 82;
                    if (nightsCount > 14)
                    {
                        doubleDis = 10;
                    }
                    break;

                case "July":
                case "August":
                case "December":
                    studioPrice = 68;
                    doublePrice = 77;
                    suitePrice = 89;
                    if (nightsCount > 14)
                    {
                        suiteDis = 15;
                    }
                    break;
            }

            int nightCountStudio = nightsCount;

            if ((nightCountStudio > 7) && (month == "September" || month == "October"))
            {
                nightCountStudio--;
            }

            studioPrice = studioPrice - (studioPrice * studioDis / 100);
            doublePrice = doublePrice - (doublePrice * doubleDis / 100);
            suitePrice = suitePrice - (suitePrice * suiteDis / 100);

            studioPrice = studioPrice * nightCountStudio;
            doublePrice = doublePrice * nightsCount;
            suitePrice = suitePrice * nightsCount;

            Console.WriteLine($"Studio: {studioPrice:F2} lv.");
            Console.WriteLine($"Double: {doublePrice:F2} lv.");
            Console.WriteLine($"Suite: {suitePrice:F2} lv.");
        }
    }
}
