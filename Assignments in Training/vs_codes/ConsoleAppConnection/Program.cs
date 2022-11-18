using System;
using System.Data.SqlClient;
using System.Data;

namespace ConsoleAppConnection
{
     class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1 : To Get all the data from a Table");
            Console.WriteLine("2 : To Insert the values into the table");
            Console.WriteLine("3 : To Upadate the values in the table");
            Console.WriteLine("Enter a value: ");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    AllData();
                    break;
                case 2:
                    Console.WriteLine("Enter the ProductName");
                   string name= Console.ReadLine();
                    Console.WriteLine("Enter the Price");
                    string price= Console.ReadLine();

                    InsertInto(name,price);
                    break;
            }
            
            Console.ReadKey();
      
        }
        public static void AllData()
        {
            string cnstring = "Data Source=LAPTOP-SF5JKCA0\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cnstring);
            SqlCommand cmd = new SqlCommand("Select * from Products", cn);
            cn.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            int proId;
            string proName;
            double Price;
            while (dr.Read())
            {
                // proId = Convert.ToInt32(dr[0]);
                proId = Convert.ToInt32(dr["ProductID"]);
                proName = dr["ProductName"].ToString();
                Price = Convert.ToDouble(dr[5]);
                Console.WriteLine(proId);
                Console.WriteLine(proName);
                Console.WriteLine(Price);
                Console.WriteLine("------------------------");
            }
            cn.Close();
        }
        public static void InsertInto(string name ,string price)
        {
            string cnstring = "Data Source=LAPTOP-SF5JKCA0\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cnstring);
            SqlCommand cmd = new SqlCommand("insert into products (ProductName,UnitPrice) values (" + "'" + name + "'" + "," + price + ")", cn);
            cn.Open();
            int cnt = cmd.ExecuteNonQuery();
            Console.WriteLine(cnt+ " Row was Effected");
            cn.Close();
        }
    }
}
