using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes_ValueType
{
    public class Store
    {
       public Store()
        {
            store_Name = "ABC";
            store_Id = "12/13-B";
            store_address = "Kankipadu";
            store_ph_number = 123456789;

        }
       public Store(string Name,string Id,string address,int num)
        {
            store_Name=Name;
            store_Id=Id;
            store_address=address;
            store_ph_number=num;
        }
        public string store_Name;
        public string store_Id;
        public string store_address;
        public int store_ph_number;
        
        public void display()
        {
            Console.WriteLine(store_Id);
            Console.WriteLine(store_address);
            Console.WriteLine(store_ph_number);
            Console.WriteLine(store_Name);
        }
    }
        public class Kirana : Store
    {
        public int num_items;
        public string store_type;
        public Kirana()
        {
            num_items = 10;
            store_type = "XYZ";
        }
        private void display1()
        {
           
            Console.WriteLine(store_type);
            Console.WriteLine(num_items);
        }
    }
  
}
