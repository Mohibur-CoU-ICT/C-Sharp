using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    interface Employee
    {
        //By default, members of an interface are abstract and public.
        double SalaryIncrement();
        double Salary();
    }

    class FrontEndDeveloper : Employee
    {
        public double SalaryIncrement()
        {
            return 7.0;
        }
        public double Salary()
        {
            return 30000;
        }
    }

    class BackEndDeveloper : Employee
    {
        public double SalaryIncrement()
        {
            return 10.0;
        }
        public double Salary()
        {
            return 40000;
        }
    }

    class Interface
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interface Example");
            Employee employee = new FrontEndDeveloper();
            Console.WriteLine(employee.Salary());
            Console.WriteLine(employee.SalaryIncrement());

            BackEndDeveloper backEndDeveloper = new BackEndDeveloper();
            Console.WriteLine(backEndDeveloper.Salary());
            Console.WriteLine(backEndDeveloper.SalaryIncrement());

            Console.ReadLine();
        }
    }
}
