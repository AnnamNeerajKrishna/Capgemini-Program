using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var_dynamic
{
    public class Program
    {
         public static void Main(string[] args)
        {
            int a = 789;
            a.ToString();
            Console.WriteLine(a + "fhsfk");
            Console.WriteLine(a.GetType());
            var i = 123;
           Console.WriteLine(i.GetType());
          //  i.ToString();
            Console.WriteLine(i.ToString().GetType());
            dynamic d = "asdasf";
            Console.WriteLine(d.GetType());
            dynamic f = 123;
            Console.WriteLine(f.ToString().GetType());
            Console.ReadLine();
        }
    }
}
