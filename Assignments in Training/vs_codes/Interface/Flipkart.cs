using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface Flipkart
    {
         void sellers();
        void total_stock();
        void orders();


    }
    public class A : Flipkart
    {
       public void sellers()
        {
            Console.WriteLine("Total Number of Sellers");
        }
        public void total_stock() 
        {
            Console.WriteLine("Total number of stocks");
        }

       public void orders()
        {
            Console.WriteLine("Total number of Orders");
        }
    }
    public class B : Flipkart
    {
        
        
          public void sellers()
            {
                Console.WriteLine("Total Number of Sellers");
            }
           public void total_stock()
            {
                Console.WriteLine("Total number of stocks");
            }
           public void orders()
            {
            Console.WriteLine("Total number of orders");

            }
        
    }
}
