using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    public class Program
    {
        public int id;
        public string name;

        Program(int i,string k)
        {
            id = i;
            name = k;
        }

        public static void Main(string[] args)
        {
            int a=0;
            int b=10;

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
            Console.WriteLine(Equals(a.GetType(), b.GetType()));  
            Console.WriteLine(Equals(a,b));

            Program p1=new Program(2,"ABC");
            Program p2=new Program(3,"QWE");
            
            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(p2.Equals(p1));
            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(Equals(p1.GetHashCode(),p2.GetHashCode()));
            Program p3 = new Program(2, "ABC");
            Program p4 = p3;
            Console.WriteLine(p3.Equals(p4));
            Console.WriteLine(Equals(p4, p3));


            Console.ReadKey();
        }
    }
}
