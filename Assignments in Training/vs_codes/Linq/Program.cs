using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EmployImplementation employImplementation = new EmployImplementation();
            var ltEmps = employImplementation.EmpLst();
        }
    }
}
