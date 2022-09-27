using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Paramarray
    {
        public static void Main()
        {
            int total = sum( 7, 2, 6, 5, 8, 5, 4);
            Console.WriteLine(total);
        }
        public static int sum(params int[] numbers)
        {
            int sum = 0;
            foreach (int i in numbers)
            {
                sum = +i;
            }
            return sum;
        }
    }
}
