using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// interface-avbstraction-information security-security
    /// interface keyword-abstract methods nd properties
    /// cannot contain variables
    /// multiple inheritace (no tsupported)-substitued by the interfaces concept
    /// </summary>
    /// 
    interface ITTraining
    {
        //abstracrt property
        string Course { get; set; }
        //abstract method
        void CourseDetails();
        
    }
    interface ITTrainee
    {
        //abstracrt property
        int Strength { get; set; }
        //abstract method
        void Total_trainee();

    }

    public class Csharp_training : ITTraining, ITTrainee
    {
        /// <summary>
        /// PROPERTY COURSE IMPLEMETED
        /// </summary>
        public string Course { get; set; }
        public int Strength { get; set; }
        /// <summary>
        /// course details implementd
        /// </summary>
        public void CourseDetails()
        {
            Console.WriteLine( Course);
        }
        public void Total_trainee()
        {
            Console.WriteLine(Strength);
        }

    }
    /// <summary>
    /// working of destructor method-constructor-memory clanup of the resources
    /// </summary>
    public class Destructor_dispose : IDisposable
    {
        /// <summary>
        /// files(open/close)-database connection(open/c;lose),services
        /// </summary>
        public void Dispose()
        {
            Console.WriteLine("dispose memory");
        }
    }
    internal class Interface
    {
        public static void Main()
        {
            Csharp_training cs=new Csharp_training();
            cs.Course = "c#";
            cs.CourseDetails();
            cs.Strength = 20;
            cs.Total_trainee();
            Destructor_dispose des = new Destructor_dispose();  
            des.Dispose();
        }

    }
}
