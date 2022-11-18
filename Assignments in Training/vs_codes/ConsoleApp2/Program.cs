
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        string St_name;
        string St_ph_number;
        public static void Main(string[] args)
        {
            Method1();
           // Method2();
           // Method3();
        }
        private static  void Method1()
        {
            Program p1=new Program();
            Type t = p1.GetType();
            Console.WriteLine(t.FullName);
            Console.WriteLine(t.Name);
            Console.WriteLine(t.Namespace);
            Console.WriteLine(t.Assembly);
            Console.WriteLine(t.BaseType);
            Console.WriteLine(t.BaseType.FullName);
            Console.WriteLine(t.AssemblyQualifiedName);
            Console.ReadKey();
        }
        private static void Method2()
        {
            Program p2=new Program();
            Console.WriteLine(p2.GetType().FullName);   
        }
        private static void Method3()
        {
            Type t1=Type.GetType("ConsoleApp2.Program",false,true);
            Console.WriteLine(t1.FullName);
        }
    }
}
