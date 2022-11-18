using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thrwad_basics
{
    public class Program
    {
        static void Main(string[] args)
        {
            object ob = 123;
            // Thread th = new Thread(new ParameterizedThreadStart(go));
            Thread th1 = new Thread(new ThreadStart(go));
            th1.Start();
            go();

        }
        public static void go()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();  
        }
        /* void go(object ob)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

        }*/
        public static void something()
        {

        }


    }
}
