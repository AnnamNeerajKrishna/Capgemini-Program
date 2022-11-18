using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace custom_sort
{
    public class Student:IComparable
    {
        int id; string name;    
        public Student(int a,string b)
        {
            Id = a;
            Name = b;

        }
        public int Id { get; set; } 
        public string Name { get; set; }

        public int CompareTo(object stu)
        {
            return this.Name.CompareTo(((Student)stu).Name);
        }
    }
}
