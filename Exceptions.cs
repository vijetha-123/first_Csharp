using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp1
{
    /// <summary>
    /// errors-synatx error,compile time,logical error,runtime error
    /// exception handling-runtime errors-try,catch,finally,throw
    /// exceptions-predefined and user defined
    /// exception -base class
    /// predefined classes-Exception(base)-systemexception-arithmeyicexception-divideby zer
    /// userdefined-applicationexptn/excptn
    /// 
    /// </summary>
    public class AttendenceException : ApplicationException
    {
        public AttendenceException(string message):base(message)    
        {

        }
    }
    internal class Exceptions
    {
        
        public static void Main()
        {
            int total_trainee;
            try
            {
                Console.WriteLine("enter the total:");
                total_trainee = Convert.ToInt32(Console.ReadLine());
                if (total_trainee < 38)
                {
                    throw (new AttendenceException("few are abset"));
                }
                else
                {
                    Console.WriteLine("all are present");
                }
            }
            catch(AttendenceException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}
