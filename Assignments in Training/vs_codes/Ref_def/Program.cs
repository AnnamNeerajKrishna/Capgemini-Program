using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_def
{
    public class Program
    {
        public static void Main(string[] args)
        {
            A();
            B();
            Console.ReadLine();
        }
        public static void A()
        {
            int num=6;
            Console.WriteLine(num);
            pa_ref(ref num);
            Console.WriteLine(num);
        }
       

        public static void pa_ref(ref int num)
        {
            num=400;
        }

        public static void B()
        {
            int hum = 1;
            Console.WriteLine(hum);
            out_ref(out hum);
            Console.WriteLine(hum);
        }
        public static void out_ref(out int a)
        {
            a = 100;

        }
    }
}
