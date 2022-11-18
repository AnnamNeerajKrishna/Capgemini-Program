using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraylist_Collection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            Employee e1 = new Employee(1, 22, "Teja", 951365478);
            Employee e2 = new Employee(2, 20, "Ramu", 4567891234);
            employees.Add(e1);
            employees.Add(e2);

            Console.WriteLine("Total number of employees:- "+employees.Count());
            foreach(Employee e in employees)
            {
                Console.WriteLine(e.EmpName+","+e.EmpId+","+e.EmpPhoneNumber);
            } 
            Console.ReadLine();

            foreach(Employee ew in employees)
            {
                if(e1.EmpId== ew.EmpId)
                {
                    Console.WriteLine("Employee Data Found");
                }
            }


        }
       

        
    }
}
