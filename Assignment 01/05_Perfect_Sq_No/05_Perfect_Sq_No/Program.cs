using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05_Perfect_Sq_No
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;

            Console.Write("Enter The Number : ");
            N = Convert.ToInt32(Console.ReadLine());

            Console.Write("_______________________________________________Output___________________________________________________\n\n");

            Console.Write(" Are The Only Perfect Square Number Less Than "+ N + " And The Total Count Of Sq. Number Is : " + Perfect_Sq(N));

            Console.Write("\n_________________________________________________________________________________________________________\n\n");
            Console.ReadKey();
        }

        static int Perfect_Sq(int num)
        {
            int Cnt = 0;

            for (int i = 1; i <= num; i++)
            {
                if (i*i < num)
                {
                    Console.Write(" " + i * i);
                    Cnt++;
                }
            }

            return Cnt;
        }
    }
}
