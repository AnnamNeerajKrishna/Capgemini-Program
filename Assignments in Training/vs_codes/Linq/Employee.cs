using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public  class Employee

    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int DeptId { get; set; }


        public Employee(int v1, string v2, int v3, int v4)
        {
            this.Id = v1;
            this.Name = v2;
            this.Salary = v3;
            this.DeptId = v4;
        }

        
        
    }
}
