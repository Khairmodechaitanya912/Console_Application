using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_Arithmetic_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            int A1, A2, N;

            UP:
            Console.Write("Enter First No :- ");
            A1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second No :- ");
            A2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The Nth No :- ");
            N = Convert.ToInt32(Console.ReadLine());

            if (A1 == 0 && A2 == 0)
            {
                Console.Write("Plz Enter Valid No...!! \n\n");
                goto UP;
            }

            int D = A2 - A1;

            N = A1 + ((N - 1) * D);

            Console.Write(N);
            Console.ReadKey();
        }
    }
}
