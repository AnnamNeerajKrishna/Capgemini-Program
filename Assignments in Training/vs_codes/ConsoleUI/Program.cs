using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLib;
using BusinessLayerLib;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice =0;
            do
            {
                Console.WriteLine("1 - Add Employee");
                Console.WriteLine("2 - Delete By Id");
                Console.WriteLine("3 - Udate Employee");
                Console.WriteLine("4 - Display All Employee");
                Console.WriteLine("5 - Find by Id");
                Console.WriteLine("6 - Exit ");
                Console.WriteLine("Enter choice :");
                choice=int.Parse(Console.ReadLine());


            
            
            switch (choice)
            {
                    case 1:
                            AddEmployee();
                        break;
                    case 2:
                        DeleteEmployee();
                        break;
                    case 3:
                        // Update Emp
                        break;
                    case 4:
                        DisplayAllEmp();
                        break;

                    case 5:
                        // find by Id
                        break;
                    case 6:
                        Console.WriteLine("Exited.....!");
                        break;

                    default: 
                        Console.WriteLine("Invalid Choice");
                        break;

            }
            } while (choice !=6);
        }

        static void AddEmployee()
        {
            employee emp =new employee();
            Console.WriteLine("Enter Ecode");
            emp.Ecode = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ename");
            emp.EName = Console.ReadLine();
            Console.WriteLine("Enter Salary");
            emp.Salary = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter DeptId");
            emp.DeptId = int.Parse(Console.ReadLine());

            BusinessLAyer bll =new BusinessLAyer();
            bool status = bll.AddEmp(emp);

            if (status)
            {
                Console.WriteLine("Record inserted successfully");

            }
            else
            {
                Console.WriteLine("Could not insert");
            }




        }
        static void DeleteEmployee()
        {
            // Take input for ecode
            Console.WriteLine("Enter the Ecode to delete");
            int ecode=int.Parse(Console.ReadLine());
            BusinessLAyer bll = new BusinessLAyer();

            // delete using business layer
            bool status= bll.DeleteEmpById(ecode);
            if (status)
            {
                Console.WriteLine("Record Deleted successfully");

            }
            else
            {
                Console.WriteLine("Could not Delete");
            }

        }

        static void UpdateEmployee()
        {

        }
        static void DisplayAllEmp()
        {
            BusinessLAyer bll = new BusinessLAyer();
            List<employee> lstEmp = bll.GetAllEmps();

            if(lstEmp.Count == 0)
            {
                Console.WriteLine("No records to display");
            }
            else
            {
                /// display the records
                foreach(var e in lstEmp)
                {
                    Console.WriteLine("{0}\t{1}\t{3}\t", e.Ecode, e.EName, e.Salary, e.DeptId);
                }
            }
        }
        static void FindById()
        {
            // take ecode as input for searching

            Console.WriteLine("Enter ecode for search :");
            int ecode =int.Parse(Console.ReadLine());   
            BusinessLAyer bll=new BusinessLAyer();
            employee emp = bll.GetEmpID(ecode);
            // display the recode

            Console.WriteLine("{0}\t{1}\t{3}\t", emp.Ecode, emp.EName, emp.Salary, emp.DeptId);
        }
    }
}
