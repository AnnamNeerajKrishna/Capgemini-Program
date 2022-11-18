using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_Assignment
{
    public class Program
    {
       public static void Main(string[] args)
       {
            int[] arr1 = { 1, 2, 3, 4, 5,32, 6, };
            String[] arr2 = { "Raju", "Ramu", "Siva", "Teja" };
            int[] Arr1=new int [arr1.Length] ;
            String[] Arr2=new string[arr2.Length];
            Console.WriteLine("Operating Arrays");

            Array.Copy(arr1,Arr1, arr1.Length);

            Array.Copy (arr2,Arr2, arr2.Length);
            foreach(int i in Arr1)
            {
                Console.WriteLine(i);
            }
            foreach(string i in Arr2) { Console.WriteLine(i); }
            Console.WriteLine("/*--------------------------------------------------------------------*/");
            Array.Sort(Arr1);
            Array.Sort(Arr2);
            foreach (int i in Arr1)
            {
                Console.WriteLine(i);
            }
            foreach (string i in Arr2) { Console.WriteLine(i); }


            Console.WriteLine("/*--------------------------------------------------------------------*/");

            Array.Reverse(Arr1);
            Array.Reverse(Arr2);
            foreach (int i in Arr1)
            {
                Console.WriteLine(i);
            }
            foreach (string i in Arr2) { Console.WriteLine(i); }
            Console.WriteLine("/*--------------------------------------------------------------------*/");

            Array.Clear(Arr1,1, 3);
            Array.Clear(Arr2,1,3);

            foreach (int i in Arr1)
            {
                Console.WriteLine(i);
            }
            foreach (string i in Arr2) { Console.WriteLine(i); }
            Console.WriteLine("/*--------------------------------------------------------------------*/");



            Console.ReadLine();
       }
    }
}
