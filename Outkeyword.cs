using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    //out keyword-to returm more than 1 value to the calling method
    internal class Outkeyword
    {
        public static void Main()
        {
            int i;
            int j;
            Add(out i,out j);
            Console.WriteLine(i+" "+ j);
                
        }
        public static void Add(out int x, out int y)
        {
            x = 10;
            y = 20;
            x += x;
            y += y;
        }

    }
}
