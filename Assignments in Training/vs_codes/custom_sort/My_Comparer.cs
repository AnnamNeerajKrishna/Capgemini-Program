using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace custom_sort
{
    public class My_Comparer : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.Cust_id.CompareTo(y.Cust_id);
        }
    }
    public class My_Customer:IComparer<Customer>
    {
        public int Compare(Customer p,Customer q)
        {
            return p.Cust_name.CompareTo(q.Cust_name);  
        }
    }
}
