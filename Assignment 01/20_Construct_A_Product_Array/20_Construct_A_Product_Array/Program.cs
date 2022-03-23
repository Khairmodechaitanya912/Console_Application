using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20_Construct_A_Product_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;

            Console.Write("Enter The Number To Create Array :- ");
            N = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write("Enter The Element :- ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Construct_A_Product_Array(arr);

            Console.ReadKey();
        }

        static void Construct_A_Product_Array(int []arr)
        {
            int[] PArry = new int[arr.Length];

            int Ret = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    else
                    {
                        Ret = Ret * arr[j];
                        PArry[i] = Ret;
                    }
                }

                Ret = 1;
            }

            Console.Write("\nProduct Array Given Array is :- \n");

            for (int i = 0; i < PArry.Length; i++)
            {
                Console.WriteLine("\t\t\t P["+i+"] = "+PArry[i]);
            }
        }
    }
}
