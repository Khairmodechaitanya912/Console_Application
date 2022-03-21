using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07_Trailing_Zeroes_In_N_
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0 , fact = 1;

            Up:
            Console.Write(" Enter A Number :- ");
            N = Convert.ToInt32(Console.ReadLine());
            
            if (N <= 0)
            {
                Console.Write(" Invalid No Plz Enter Again No");
                goto Up;
            }

            for (; N > 0 ; N-- )
            {
                fact *= N; 
            }

            if (fact < 0)
            {
                fact = -(fact);
            }

            Console.Write("\n Factorial Of Given Number is :- "+fact + "\n\n");

            Console.Write(" Trailing Zero of Given Factorial is :- " + CntOfZero(fact));
            Console.ReadKey();
        }

        static int CntOfZero(int Num)
        {
            int Cnt = 0;

            for (; Num > 0;Num /=10 )
            {
                if (Num%10 == 0)
                {
                    Cnt++;
                }
            }
            return Cnt;
        }
    }
}
