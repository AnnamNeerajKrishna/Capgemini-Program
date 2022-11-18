using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDelegate
{
    delegate void maindel(string info);
    public class Program
    {
        public static void Good_morning(string s)
        {
            Console.WriteLine($" Good morning, {s}. ");
        }

        public static void GoodBye(string s)
        {
            Console.WriteLine($" Good Bye, {s}. ");
        }

        static void Main(string[] args)
        {

            maindel hiDel, byeDel, multiDel;

            hiDel = Good_morning;
            byeDel = GoodBye;
            multiDel = hiDel + byeDel;

            Console.WriteLine("Invoking the hiDel - ");
            hiDel("Neeraj");
            Console.WriteLine("Invoking the byeDel - ");
            byeDel("Neeraj");
            Console.WriteLine("Invoking the MultiDel - ");
            multiDel("ABC");

            Console.ReadLine();

        }
    }
}