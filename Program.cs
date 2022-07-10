using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixMultiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[2,2];
            int[,] arr2 = new int[2,2];
            int[,] mul = new int[2,2];
            int m = 1;
            Console.WriteLine(" Enter elements for MARTIX 1 : \n");
            for (int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    Console.Write("Enter element " + (m++) + " : ");
                    arr1[i,j]=Convert.ToInt32(Console.ReadLine());
                    Console.Write("\n");
                }
            }
            Console.WriteLine(" Enter elements for MARTIX 2 : \n");
            m = 1;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("Enter element " + (m++) + " : ");
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\n");
                }
            }
            Console.WriteLine("MARTIX 1 : ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(arr1[i,j]+"\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("MARTIX 2 : ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(arr2[i,j]+"\t");
                }
                Console.WriteLine("\n");
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    mul[i,j] = 0;
                    for(int k = 0; k < 2; k++)
                    {
                        mul[i, j] += arr1[i, k] * arr2[k,j];
                    }
                }
            }
            Console.WriteLine("The product of the two matrices is :");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(mul[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
