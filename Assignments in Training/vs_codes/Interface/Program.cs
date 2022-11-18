using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public  class Program
    {
      public static void Main(string[] args)
        {
            Flipkart f;
            f=new A();
            f.sellers();
            f.total_stock();
            f.orders();
            Console.ReadLine();
        }       
    }
}
