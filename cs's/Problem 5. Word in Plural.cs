using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            switch (word[word.Length - 1])
            {
                case 'y':
                    word = word.Remove((word.Length - 1), 1);
                    word = word.Insert((word.Length), "ies");
                    break;

                case 'o':
                case 's':
                case 'x':
                case 'z':
                    word = word.Insert((word.Length), "es");
                    break;

                case 'h':
                    if (((word[word.Length - 2]) == 'c') || (word[word.Length - 2]) == 's')
                    {
                        word = word.Insert((word.Length), "es");
                    }
                    break;

                default:
                    word = word.Insert((word.Length), "s");
                    break;
            }
            Console.WriteLine(word);
        }

    }
}
