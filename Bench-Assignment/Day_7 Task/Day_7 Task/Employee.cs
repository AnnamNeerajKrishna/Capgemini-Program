using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7_Task
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }    

        public static void Main(string[] args)
        {
            /*------------------ Inisilize List Of Employees---------------------- */
            List<Employee> list = new List<Employee>();

            /*-------------------Employee Data-----------------------*/
            Employee emp1 = new Employee()
            {
                EmpId = 1001,
                FirstName = "Malcolm",
                LastName = "Daruwalla",
                Title = "Manager",
                DOB = new DateTime(1984, 11, 16),
                DOJ = new DateTime(2011, 06, 06),
                City = "Mumbai"
            };
            list.Add(emp1);

            Employee emp2 = new Employee()
            {
                EmpId = 1002,
                FirstName = "Asdin",
                LastName = "Dhalla",
                Title = "AssManager",
                DOB = new DateTime(1984,08,20),
                DOJ = new DateTime(2017, 02, 02),
                City = "Mumbai"
            };
            list.Add(emp2);

            Employee emp3 = new Employee()
            {
                EmpId = 1003,
                FirstName = "Madhavi",
                LastName = "Oza",
                Title = "Consultant",
                DOB = new DateTime(1987, 11, 14),
                DOJ = new DateTime(2015, 04, 12),
                City = "Pune"
            };
            list.Add(emp3);

            Employee emp4 = new Employee()
            {
                EmpId = 1004,
                FirstName = "Saba",
                LastName = "Shaikh",
                Title = "SE",
                DOB = new DateTime(1990, 06, 03),
                DOJ = new DateTime(2016,02,02),
                City = "Pune"
            };
            list.Add(emp4);

            Employee emp5 = new Employee()
            {
                EmpId = 1005,
                FirstName = "Nazai",
                LastName = "Shaikh",
                Title = "SE",
                DOB = new DateTime(1991,03,08),
                DOJ = new DateTime(2016,02,02),
                City = "Mumbai"
            };
            list.Add(emp5);

            Employee emp6 = new Employee()
            {
                EmpId = 1006,
                FirstName = "Amit",
                LastName = "Pathak",
                Title = "Consultant",
                DOB = new DateTime(1989, 11, 07),
                DOJ = new DateTime(2014, 08, 08),
                City = "Chennai"
            };
            list.Add(emp6);

            Employee emp7 = new Employee()
            {
                EmpId = 1007,
                FirstName = "Vijay",
                LastName = "Natarajan",
                Title = "Consultant",
                DOB = new DateTime(1984, 12, 02),
                DOJ = new DateTime(2011, 06, 01),
                City = "Mumbai"
            };
            list.Add(emp7);

            Employee emp8 = new Employee()
            {
                EmpId = 1008,
                FirstName = "Rahul",
                LastName = "Dubey",
                Title = "Associate",
                DOB = new DateTime(1993, 11, 11),
                DOJ = new DateTime(2014, 11, 06),
                City = "Chennai"
            };
            list.Add(emp8);

            Employee emp9 = new Employee()
            {
                EmpId = 1009,
                FirstName = "Suresh",
                LastName = "Mistry",
                Title = "Associate",
                DOB = new DateTime(1992, 08, 12),
                DOJ = new DateTime(2014, 12, 03),
                City = "Chennai"
            };
            list.Add(emp9);

            Employee emp10 = new Employee()
            {
                EmpId = 1010,
                FirstName = "Sumit",
                LastName = "Shah",
                Title = "Manager",
                DOB = new DateTime(1991, 04, 12),
                DOJ = new DateTime(2016, 1, 02),
                City = "Pune"
            };
            list.Add(emp10);

            Console.WriteLine("--------------------------------***Employee Details****-----------------------------------");
           foreach(var item in list)
            {
                Console.WriteLine(item.EmpId+" , "+ item.FirstName+ " , " +item.LastName+ " , " +
                    item.Title+ " , " +item.DOB+ " , " + item.DOJ+ " , " +item.City);
            }

            Console.WriteLine("-------------------------------***Employee Not in Mumbai***-----------------------------------");
            var lst1 = list.Where(x => x.City != "Mumbai");

            foreach(var item in lst1)
            {
                Console.WriteLine(item.EmpId + " , " + item.FirstName + " , " + item.LastName + " , " +
                    item.Title + " , " + item.DOB + " , " + item.DOJ + " , " + item.City);
            }
            Console.WriteLine("------------------------------**Employee With Title AssManager**------------------------------");
            var lst2 = list.Where(x => x.Title == "AssManager");

            foreach(var item in lst2)
            {
                Console.WriteLine(item.EmpId + " , " + item.FirstName + " , " + item.LastName + " , " +
                    item.Title + " , " + item.DOB + " , " + item.DOJ + " , " + item.City);
            }

            Console.WriteLine("-------------------------------**Employee Last Name Starting with 'S'***----------------------");

            var lts3 = list.Where(x => x.LastName.FirstOrDefault() == 'S');

            foreach(var item in lts3)
            {
                Console.WriteLine(item.EmpId + " , " + item.FirstName + " , " + item.LastName + " , " +
                    item.Title + " , " + item.DOB + " , " + item.DOJ + " , " + item.City);
            }

            Console.WriteLine("-----------------------------**Employee Joined before 1/1/2015*---------------------------------");

            var lts4 = from s in list
                       where s.DOJ < new DateTime(2015,01,01)
                       select s;

            foreach(var item in lts4)
            {
                Console.WriteLine(item.EmpId + " , " + item.FirstName + " , " + item.LastName + " , " +
                   item.Title + " , " + item.DOB + " , " + item.DOJ + " , " + item.City);
            }

            Console.WriteLine("-----------------------------**Total Number Of Employees**-----------------------------------");
            Console.WriteLine("Total Number of Employeees:- "+list.Count);

            Console.WriteLine("-----------------------------***Employee With Hightest EmpID**------------------------------------------");
            Console.WriteLine("Employee with Hightest Id :- " +list[list.Count-1].EmpId+" : "+ list[list.Count - 1].FirstName +"  "+ list[list.Count-1].LastName);
            Console.WriteLine("-----------------------------***Youngest Employee in the List****---------------------------------------");



            Console.ReadLine();
        }
    }
}
