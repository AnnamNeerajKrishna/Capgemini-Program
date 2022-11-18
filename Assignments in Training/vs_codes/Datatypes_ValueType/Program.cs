using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes_ValueType
{
    public class Program
    {
       /* enum day
        {
            A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z
        }
        struct person
        {
            string name;
            int age;

            public static void getAge(int age)
            {
               age = age;
                Console.WriteLine(age);
            }
        }*/
       
        static void Main(string[] args)
        {

            /*Store s=new Store();
            s.display();
            Store s2 = new Store("ASD", "14/56-f", "Qwerty", 123456789);
            s2.display();
            Console.ReadKey();*/
            Kirana k=new Kirana();
            k.display();
            k.display1();
            Console.ReadKey();

           /* Console.WriteLine("Entering Enums");
            day  d1 = day.A;
            Console.WriteLine(d1.ToString());
            int a = 100; 
            Console.WriteLine(a);
            uint a1=(uint)a;
            Console.WriteLine(a1);
            float b = 100.23f;
            Console.WriteLine(b);
            double d = (float)b;
            Console.WriteLine(d);
            string s1 = "200"; 
            a.ToString();
            Console.WriteLine(a+"ABC");
             if (a.CompareTo(s1) == 0)
             {
                 Console.WriteLine("Both" + a, b + "are string");
             }
             else
             {
                 Console.WriteLine("Not strings");
             }
            int w = s1.Length;
            Console.WriteLine(w);
            int [] r = new int[10];
            Console.WriteLine("Array values are printing");
            for(int i=0; i<10; i++)
            {
                r[i]=i+100;
                Console.WriteLine(r[i]);
            }
            uint f = 1;
            while (f <=1)
            {
                Console.WriteLine(f);
                f--;
            }
            string s = "";
            Console.WriteLine("Adding values into string");   
            for (int i = 0; i < w; i++)
            {

                s=s+Console.ReadLine()+" ";
            }
            Console.WriteLine(s);
            Console.ReadKey();*/
        }
    }
}
