using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class P_1
    {
        public delegate void E_vent();


        public event E_vent E;

        public void Start_Event()
        {
            Console.WriteLine("Event Process Started");

            Process_Continue();
        }
        public void Process_Continue()
        {
            E?.Invoke();
        }
    }
    public class Program 
    
    {
        static void Main(string[] args)
        {
            P_1 p1 = new P_1();

            p1.E += p1_E;
            p1.Start_Event();
            Console.ReadKey();
        }
        public static void p1_E()
        {
            Console.WriteLine("Process_Completed");


        }
    
    }
}
