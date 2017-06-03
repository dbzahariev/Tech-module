using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8_SMS_Typing
{
    class Problem_8_SMS_Typing
    {
        static void Main()
        {

            int countOfNumbers = int.Parse(Console.ReadLine( ));
            int offset = 0;
            int index = 0;

            char[] letters = new char[26];
            for (int i = 0; i <= 25; i++)
            {
                letters[i] = Convert.ToChar(i + 97);
            }

            string result = string.Empty;
            for (int i = 0; i < countOfNumbers; i++)
            {
                int code = int.Parse(Console.ReadLine( ));
                offset = (code % 10 - 2) * 3;
                if (code % 10 == 9 || code % 10 == 8)
                {
                    offset += 1;
                }
                index = offset + code.ToString( ).Length - 1;
                if (code % 10 < 2)
                {
                    result += " ";
                    continue;
                }

                result += letters[index];
            }

            Console.WriteLine(result);
        }
    }
}