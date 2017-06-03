using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.DNA_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (var i = 1; i <= 4; i++)
            {
                for (var k = 1; k <= 4; k++)
                {
                    for (var l = 1; l <= 4; l++)
                    {
                        char prediSled = ' ';
                        if (n > (i + k + l))
                        {
                            prediSled = 'X';
                        }
                        else
                        {
                            prediSled = 'O';
                        }

                        string word = $"{prediSled}{i}{k}{l}{prediSled} ";
                        word = word.Replace('1', 'A').Replace('2', 'C').Replace('3', 'G').Replace('4', 'T');
                        Console.Write(word);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}