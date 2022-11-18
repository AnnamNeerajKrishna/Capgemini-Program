using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayerUpd;
using BusinessAccessLayerUPd;
using BusinessObjectUpd;
namespace HandsOnProjectUpd
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ConfigBAL bal = new ConfigBAL();
            ConfigBALobj bALobj = new ConfigBALobj();
            while (true)
            {
                Console.WriteLine("Menu \n 1.Insert Into Blogger \n 2. Insert into Blog \n 3. Show values of Blogger \n 4.Shoe values of Blog \n 5. Exit");
                Console.WriteLine("Please enter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ConfigBALobj cob = new ConfigBALobj();
                        Console.WriteLine("Please Enter The Blogger Id");

                        int id = Convert.ToInt32(Console.ReadLine());
                        cob.BloggerID = id;
                        Console.WriteLine("Please Enter the Blogger Name");
                        string name = Console.ReadLine();
                        cob.BloggerName = name;
                        Console.WriteLine("Please enter the subject ");
                        string subj = Console.ReadLine();
                        cob.BloggerSubject = subj;
                        bal.InsertTOBlogger(cob);
                        break;
                    case 2:
                        ConfigBALobj cob1 = new ConfigBALobj();
                        Console.WriteLine("Please Enter The Blogs Id");

                        int Bid = Convert.ToInt32(Console.ReadLine());
                        cob1.BlogID = Bid;
                        Console.WriteLine("Please Enter the Blog Name");
                        string Bname = Console.ReadLine();
                        cob1.BlogName = Bname;
                        Console.WriteLine("Please enter the Content ");
                        string Bsubj = Console.ReadLine();
                        cob1.BlogContent= Bsubj;
                        Console.WriteLine("Please enter the date and time");
                        cob1.BlogDate = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("please enter the bloggerId");
                        int BlId=Convert.ToInt32(Console.ReadLine());
                        cob1.BloggerID = BlId;
                        bal.InsertToBlog(cob1);

                        break;
                    case 3:
                        bool a=bal.ShowBloggerData();
                        break;
                    case 4:
                        bool b = bal.ShowBlogData();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Enter a valid choice");
                        break;
                }
            }
        }
    }
}
