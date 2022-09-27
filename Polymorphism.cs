using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    /// <summary>
    /// poly-compile time (overloadiing) and runtime(overriding)
    /// overloading -same method with no of paramenter or type of parameter, or sequence of parameter
    /// </summary>
    internal class Polymorphism
    {
        public static int num;
        public static void add()
        {
            num += 10;
            Console.WriteLine(num);
        }
        public static void add(int a)
        {
            a += a;
            Console.WriteLine(a);
        }
        public static void getdetails(int id,string name)
        {
            Console.WriteLine($"{ id}:{ name}");
        }
        public static void getdetails(string name,int id)
        {
            Console.WriteLine($"{ id}:{ name}");
        }
        public static void Main()
        {
            add();
            add(10);
            getdetails(10, "john");
            getdetails("john", 100);
        }
    }
}
