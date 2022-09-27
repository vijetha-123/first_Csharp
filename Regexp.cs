using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//regualr import
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Regexp
    {
        //regular expression
        public static void Main()
        {
            email();
            mob();
        }
        public static void email()
        {
            Console.WriteLine("email verific");
            string email_id = "sam@gmail.com";
            var validate_email = Regex.IsMatch(email_id, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            Console.WriteLine(validate_email);
        }
        public static void mob()
        {
            string mob = "123 - 4567 - 7878";
            var validate_mob = Regex.IsMatch(mob, @"^[\w-\.]");
            Console.Write(validate_mob);
        }
    }
}
