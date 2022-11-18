using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraylist_Collection
{
    public class Employee
    {
        public int EmpId;
        public string EmpName;
        public int EmpAge;
        public long EmpPhoneNumber;

        public Employee(int empId,int age,string name,long number) 
        {
           EmpId=empId; 
            EmpName=name;  
            EmpAge=age;
            EmpPhoneNumber=number;
            
        }
    }
}
