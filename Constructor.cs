using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee
    {
        public int? id;
        public string? name;
        public Employee()
        {
            id = 1;
            name = "john";
            Console.WriteLine($"{id}:{name}");
        }
            public Employee(int age)
            {
                Console.WriteLine($"{id}:{name}: {age}");
            }
       
    }
   
    internal class Constructor
    {
        public static void Main()
        {
            Employee emp = new Employee();
            Employee emp1 = new Employee(20);

        }
    }
}
