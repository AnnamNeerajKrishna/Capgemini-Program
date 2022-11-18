    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getters_Setters
{
    public class Student
    {
        int id;
        string name;
        int age;
        Student(int id,string name,int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
         
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age;}
            set { age = value; }
        }
       public static void Main(string[] args)
        {
            Student s1 = new Student(123,"Neeraj",21);
            Console.WriteLine(s1.name+s1.id+s1.age);
            s1.Age = 22;
            Console.WriteLine(s1.age);
            s1.Name = "Krishna";
            Console.WriteLine(s1.name);
            s1.Id = 321;
            Console.WriteLine(s1.id);   
            Console.ReadKey();
       }
    }
}
