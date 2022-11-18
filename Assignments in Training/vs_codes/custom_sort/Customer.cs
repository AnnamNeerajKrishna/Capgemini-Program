using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace custom_sort
{
    public class Customer 
    {
        int cust_id;
        string cust_name;
        string address;
        public Customer(int a,string b,string c)
        {
            Cust_id = a;
            Cust_name = b;
           Address = c;
        }
        public int Cust_id
            {
            get; set;
            }
        public string Cust_name
        {
            get;set;
        }
        public string Address
        {
            get; set;
        }

        
    }
}
