using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_AS
{
    public  class Program
    {
       public static void Main(string[] args)
        {
            object b = "fkhksah";
            Console.WriteLine(b.GetType());
            int a = (int)b; 
            Console.WriteLine(a.GetType());
            Console.ReadLine();
        }
    }
}
