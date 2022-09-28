using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Bonus
    {
        protected int bonus;
        public abstract void GetBonus();
        /// <summary>
        /// non abstract class
        /// </summary>
        /// <param name="salary"></param>
        public void  CalcBonus(int salary)
        {
            bonus = salary*bonus;
            Console.WriteLine(bonus);
        }

    }
    /// <summary>
    /// child class-inheriting the abstract class bonus
    /// </summary>
    public class IT : Bonus
    {
        /// <summary>
        /// implementation of the abstract method -method overriding
        /// </summary>
        public override void GetBonus()
        {
            bonus = 5;
        }
    }
    public class Testing : Bonus
    {
        /// <summary>
        /// implementation of the abstract method -method overriding
        /// </summary>
        public override void GetBonus()
        {
            bonus = 3;
        }
    }
    internal class Abstraction
    {
        public static void Main()
        {
            Bonus bonus = new IT();
            bonus.GetBonus();
            bonus.CalcBonus(2000);
            Bonus bonus1 = new Testing();
            bonus1.GetBonus();
           



        }
    }
}
