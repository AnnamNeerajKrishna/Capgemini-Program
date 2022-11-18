using LitwareLib;
using System;

namespace EmployeeManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(106,"Neeraj",40000);
            e1.CalculateSalary();
            Console.ReadLine();
        }
    }
}
