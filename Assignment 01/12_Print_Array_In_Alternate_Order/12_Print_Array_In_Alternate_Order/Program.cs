using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12_Print_Array_In_Alternate_Order
{
    class Program
    {
        static void Array_In_Alternate_Order(int[] arr , int N)
        {
            Console.Write("Alternate Order Of Given Array Is :- ");

            for (int i = 0; i < N; i++)
            {
                if (i%2 == 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            int N = 0;

            Console.Write("Enter The Number :- ");
            N = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[N];

            Console.WriteLine("\nEnter Elements in Array :- ");

            for (int i = 0; i < N; i++)
            {
                Console.Write("element {0} :- ",i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array_In_Alternate_Order(arr,N);
        }
    }
}
