using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessAccessLayer;
using DataAccessLayer;
using BusinessObject;

namespace HandsOnProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ConfigBAL bal=new ConfigBAL(); 
            configBALobj bALobj=new configBALobj(); 
            while (true)
            {
                Console.WriteLine("Menu \n 1.Insert Into Blogger \n 2. Insert into Blog \n 3. Show values of Blogger \n 4.Shoe values of Blog \n 5. Exit");
                Console.WriteLine("Please enter your choice");
                int choice=Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        configBALobj cob=new configBALobj();    
                        Console.WriteLine("Please Enter The Blogger Id");

                        int id=Convert.ToInt32(Console.ReadLine());
                        cob.BloggerID=id;
                        Console.WriteLine("Please Enter the Blogger Name");
                        string name=Console.ReadLine();
                        cob.BloggerName=name;
                        Console.WriteLine("Please enter the subject ");
                        string subj=Console.ReadLine();
                        cob.BloggerSubject=subj;
                        bal.InsertTOBlogger(cob);
                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    default:
                        break;
                }
            }
        }
    }
}
