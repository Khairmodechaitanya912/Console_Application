using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_Pattern_From_Given_No
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;

            //Accept the Number From User To Print The Given Pattern

            Console.Write("Enter a Number For Print The Pattern : ");
            N = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n_______________Given Pattern Is_______________________\n\n");

            for (int i = 0; i < N; i++)
            {
                for (int j = N; j > 0; j--)
                {
                    for (int k = N; k > i; k--)
                    {
                        Console.Write(j);

                    }
                }
                Console.WriteLine();
            }

            Console.Write("_______________________________________________________");

            Console.ReadKey();
        }
    }
}
