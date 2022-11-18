using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Delegates.Program;

namespace Delegates
{
    public class Program
    {
        public delegate void rect(int x, int y);
        //public delegate void cube(int x, int y,int z);

        //public static rect ra = new rect(delegate a ,);
        public  void Area(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public  void volume(int a, int b, int c)
        {
            Console.WriteLine(a * b * c);
        }

    }
        public class adb
        {
            public static void Main(string[] args)
            {
                Program p1 = new Program();
                rect del = new rect(p1.Area);
                del(10, 20);

            }
        }
    
}
