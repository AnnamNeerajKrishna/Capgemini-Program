using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace custom_sort
{
  


    public  class Program 
    {
        public static void Main(string[] args)
        {
            List<Student> list = new List<Student>();

            Student s1 = new Student(123, "Neeraj");
            Student s2 = new Student(354, "Krishna");
            list.Add(s1); list.Add(s2);

            list.Sort();

            foreach (Student s in list)
            {
                Console.WriteLine(s.Name);
            }
            Console.ReadKey();

            List<Customer> list1 = new List<Customer>();

            Customer c1 = new Customer(12, "Neeraj", "8/104-1B");
            Customer c2 = new Customer(13, "Krishna", "8/504-1p");
            Customer c3 = new Customer(14, "Annam", "81/54-23K");

            list1.Add(c1); list1.Add(c2); list1.Add(c3);

            
            My_Comparer m = new My_Comparer();    
            list1.Sort(m);

            foreach (Customer c in list1)
            {
                Console.WriteLine(c.Address);
            }
            Console.ReadLine();
        }
    }
}

