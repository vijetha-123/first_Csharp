using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //arrays concept
    internal class Class1
    {
        public static void Main()
        {
            Array_1d();
            Array_2d();
            Jagged_array();
        }
        public static void Array_1d()
        {
            int[] array = new int[] { 4,5,6,9,1, 2, 3 };
            Console.WriteLine("1 D ARRAY");
            foreach (int j in array)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("functions");
            Console.WriteLine(array.Max());
            Console.WriteLine(array.Min());
            Console.WriteLine(array.Count());
            Console.WriteLine(array.Sum());
            Console.WriteLine(array.Average());
            Array.Sort(array);
            Console.WriteLine("sorted array");
            foreach(int k in array)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("reverse");
            Array.Reverse(array);
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }

        public static void Array_2d()
        {
            int[,] array = new int[,]
            {
                { 1,2,3,4},
                { 5,6,7,8}
            };
            Console.WriteLine("2d array");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine(array[i,j]);
                }
            }
        }
        //jaged array=array of arrays
        public static void Jagged_array()
        {
            int[][] array = new int[][]
            {
                new int[4]{1,2,3,4},
                new int[5]{1,2,3,4,5},
                new int[6]{1,2,3,5,7,8},
            };
            Console.WriteLine("jagged array");
                for(int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < array[i].Length; j++)
                {
                    Console.WriteLine(array[(int)i][j]);
                }
            }

        }
        
    }

}
