using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_Library1;
namespace Demo__1
{
    internal class Program
    {
       public static void Main(string[] args)
        { 
              int i = 0;

            while (i++ < 10)
            {
                int n = Console.Read();
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }
    }
}
