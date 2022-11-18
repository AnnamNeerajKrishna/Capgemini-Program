using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<int , string> map = new Dictionary<int , string>()
            {
                { 1,"Neeraj"},
                { 2 ,"Krishna"},
                { 3 ,"Annam"}
            };
            Dictionary<char, int > map2 = new Dictionary<char, int >()
            {
                {'A',1 },
                {'B',2 },
                {'C',3 }
            };
            for (int i = 0; i < map.Count; i++)
            {
                var V=map.ElementAt(i);
                var j=V.Key;
                var v=V.Value;
                Console.WriteLine(j + " " + v);
            }
            foreach(char c in map2.Keys)
            {
                Console.Write(c+" ");
            }
            Console.WriteLine();
            foreach (KeyValuePair<char,int> mp in map2)
            {
                Console.WriteLine(mp.Key+","+mp.Value);
            }

            LinkedList<value> list = new LinkedList<value>();

            value v1 = new value(1, 10);
            value v2 = new value(2, 20);

            list.AddFirst(v1);
            list.AddLast(v2);
            Console.WriteLine("List Values :");
            foreach (value v in list)
            {
                Console.Write(v.a+" "+v.b);
                ///Console.Write(v.b);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
    public class value
    {
        public int a;
        public int b;

        public value(int av, int bv)
        {
            a = av; b = bv; 
        }
            
            }
}
