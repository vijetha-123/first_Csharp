// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics.CodeAnalysis;

namespace  basics;

class methods_functn
{
    enum Num_const
    {
        a=10,
        b=20,

    }
    public static void Main()
    {
        int a = (int)Num_const.a;
        int b = (int)Num_const.b;
        Sum(a,b);
       methods_functn m=new methods_functn();
        m.Control_stat();
        Console.WriteLine("Enter employee id:");
        int emp_id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter employee name:");
        string emp_name = Console.ReadLine();
        Console.WriteLine("Enter employee role:");
        string emp_role = Console.ReadLine();
        m.Employee_disp(emp_id, emp_name, emp_role);

    }
    public static void Sum(int a, int b)
    {
        Console.WriteLine("sum of 2 nos is {0}", a+b);   
    }
    public void Control_stat()
    {
        int sum=0;
        for(int i = 1; i < 3; i++)
        {
            Console.WriteLine("Enter subject {0} marks:",i);
            int sub1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter subject"+i+" marks:"+sub1);
            sum += sub1;

        }
        Console.WriteLine("total:"+sum);
        if(sum > 80)
        {
            Console.WriteLine("GRADE A");
        }
        else
        {
            Console.WriteLine("GRADE B");
        }

    }
   
    public void Employee_disp(int a, string b, string c)
    {
       
        Console.WriteLine("Employee id:" + a);
        Console.WriteLine("Employee name:" + b);
        Console.WriteLine("Empolyee role:" + c);
    }
}

/* public static void Employee_det(int emp_id,string emp_name,string emp_role)
    {
        Console.WriteLine("Enter employee id:");
        emp_id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter employee name:");
        emp_name = Console.ReadLine();
        Console.WriteLine("Enter employee role:");
        emp_role = Console.ReadLine();
    }*/
//  Employee_det(emp_id, emp_name, emp_role);
