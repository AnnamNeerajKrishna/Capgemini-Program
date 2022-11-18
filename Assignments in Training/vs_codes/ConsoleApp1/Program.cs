using System;
using System.Diagnostics;
using System.Text;

namespace String_builder
{
    public class Program
    {
        int age;
        string name;
        int ph_num;
        string address="fixed";

        public Program(int a,string n,int p)
        {
            age = a;
            name = n; 
            ph_num = p;
           // address = add;
        }
        public Program(int a,string n="Neeraj",int p=22,string add="Kankipadu")
        {
            age=a;
            name=n;
            ph_num=p;
            address = add;
        }

        public  void Display()
        {
            Console.WriteLine(age +" "+ name + " "+ph_num + " "+ address);
        }
        public static void Main(string[] args)
        {
            //Program p1 = new Program(add:"jfkd",a:23,n:"dfka",p:123456789);


            Program p2 = new Program(5);
            
            p2.Display();







            Stopwatch st = new Stopwatch();
            st.Start();
           
            StringBuilder stringBuilder = new StringBuilder();
            for(int i = 0; i < 10; i++)
            {
                stringBuilder.Append(Console.ReadLine());
            }
            Console.WriteLine(st.ElapsedMilliseconds);
            st.Stop();
           // Console.WriteLine(st.ElapsedMilliseconds);
            st.Reset();


            string str = "";
            st.Start();
            for (int i = 0; i < 10; i++)
            {
               str+=Console.ReadLine();
            }
            Console.WriteLine(st.ElapsedMilliseconds);
            st.Stop();
            String str2 = "ABC";

            str2.Replace("A", "b");
            Console.WriteLine(str2);

            
            Console.ReadKey();

        }
    }
}
