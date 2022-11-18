using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayer
{
    public class configDAL
    {
        public bool InsertBlogger(configBALobj obj)
        {
            SqlConnection cn = new SqlConnection("Data Source=LAPTOP-SF5JKCA0\\SQLEXPRESS;Integrated Security=true;Initial Catalog=HandsOn");

            // = new SqlCommand("insert into Blogger values("+obj._BloggerID+','+ "'obj._BloggerName'" +','+obj._BloggerSubject+')');
            SqlCommand cmd=new SqlCommand("insert into Blogger values(" + obj.BloggerID + "," + "'" + obj.BloggerName + "'" + "," + "'" + obj.BloggerSubject + "'",cn);
            cn.Open();

            int a=cmd.ExecuteNonQuery();
            Console.WriteLine(a+"Row Inserted");
            cn.Close();
            return true;
            

        }
        public bool InsertBlog(configBALobj obj)
        {
            SqlConnection cn = new SqlConnection("Data Source=LAPTOP-SF5JKCA0\\SQLEXPRESS;Integrated Security=true;Initial Catalog=HandsOn");

            // = new SqlCommand("insert into Blogger values("+obj._BloggerID+','+ "'obj._BloggerName'" +','+obj._BloggerSubject+')');
            SqlCommand cmd = new SqlCommand("insert into Blogs values(" + obj.BlogID + "," + "'" + obj.BlogName + "'" + "," + "'" + obj.BlogContent + "'"+","+"'"+obj.BlogDate+"'"+","+"'"+obj.BloggerID+"'", cn);
            cn.Open();

            int a = cmd.ExecuteNonQuery();
            Console.WriteLine(a + "Row Inserted");
            cn.Close();
            return true;
            

        }
        public bool ShowBlogger()
        {
            SqlConnection cn = new SqlConnection("Data Source=LAPTOP-SF5JKCA0\\SQLEXPRESS;Integrated Security=true;Initial Catalog=HandsOn");

            
            SqlCommand cmd = new SqlCommand("select * from Blogger", cn);
            List<configBALobj>list=new List<configBALobj>();
            cn.Open();
            SqlDataReader sr=cmd.ExecuteReader();
           
            while (sr.Read())
            {
                configBALobj obj = new configBALobj();
                obj.BloggerID= Convert.ToInt32(sr[0]);
                obj.BloggerName= sr[1].ToString();
                obj.BloggerSubject= sr[2].ToString();
                list.Add(obj);
            }
            foreach(var a in list)
            {
                Console.WriteLine(a.BloggerID);
                Console.WriteLine(a.BloggerName);
                Console.WriteLine(a.BloggerSubject);
            }
            cn.Close();
            return true;


        }
        public bool ShowBlog()
        {
            SqlConnection cn = new SqlConnection("Data Source=LAPTOP-SF5JKCA0\\SQLEXPRESS;Integrated Security=true;Initial Catalog=HandsOn");


            SqlCommand cmd = new SqlCommand("select * from Blogs", cn);
            List<configBALobj> list = new List<configBALobj>();
            cn.Open();
            SqlDataReader sr = cmd.ExecuteReader();

            while (sr.Read())
            {
                configBALobj obj = new configBALobj();
                obj.BlogID = Convert.ToInt32(sr[0]);
                obj.BlogName = sr[1].ToString();
                obj.BlogContent = sr[2].ToString();
                obj.BlogDate = Convert.ToDateTime(sr[3].ToString());
                obj.BloggerID = Convert.ToInt32(sr[4]);

                list.Add(obj);
            }
            foreach(var a in list)
            {
                Console.WriteLine(a.BlogID);
                Console.WriteLine(a.BlogName);
                Console.WriteLine(a.BlogContent);
                Console.WriteLine(a.BlogDate);
                Console.WriteLine(a.BloggerID);
            }
            cn.Close();
            return true;

        }
    }
}
