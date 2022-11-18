using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayerLirbary;
using DataAccessLayerLibrary;
namespace ConsoleAppWith3tierConnectedDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CategoryBAL category = new CategoryBAL();
            Console.WriteLine("Menu \n 1.Show All \n 2. Insert \n 3. Update \n 4. Delete  \n 5. Find \n 6. Exit");
            int userchoice = Convert.ToInt32(Console.ReadLine());
            switch (userchoice)
            {
                case 1:
                    CategoryDataAccess access = new CategoryDataAccess();
                    List<CategoryBAL> categoryList=access.ShowCategories();
                    foreach (var item in categoryList)
                    {
                        Console.WriteLine("Category Id=" + item.CategoryID);
                        Console.WriteLine("Category Name=" + item.CategoryName);
                        Console.WriteLine("Description=" +item.CatDesc);
                        Console.WriteLine("-----------------");
                    }
                    break;
                case 2:
                  //  Console.WriteLine("Enter category id");
                  //category.CategoryID = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter category name");
                 category.CategoryName = Console.ReadLine();
                    Console.WriteLine("enter  Category Description");
                 category.CatDesc= Console.ReadLine();
                    CategoryDataAccess dataAccess = new CategoryDataAccess();
                    try
                    {
                        bool ans=dataAccess.InsertCategory(category);
                        if (ans)
                        {
                            Console.WriteLine("Record inserted successfuly....");
                        }
                        else
                        {
                            Console.WriteLine("No record was added to the database");
                        }
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                    

                    break;

                case 3:

                    Console.WriteLine("Enter category id");
                    category.CategoryID = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter category name");
                    category.CategoryName = Console.ReadLine();
                    Console.WriteLine("enter  Category Description");
                    category.CatDesc = Console.ReadLine();
                    break;
                case 4:
                    
                    Console.WriteLine("Enter categoryid");
                    category.CategoryID = Convert.ToInt32(Console.ReadLine());
             
                    break;
                case 5:
                    
                    Console.WriteLine("Enter category id to find");
                   category.CategoryID = Convert.ToInt32(Console.ReadLine());
                    CategoryDataAccess access1 = new CategoryDataAccess();
                   // int catid = category.CategoryID;
                    category =access1.FindCategory(category.CategoryID);
                    Console.WriteLine(category.CategoryName);
                    Console.WriteLine(category.CatDesc);
                    break;
                case 6:
                    Environment.Exit(1);
                    break;
            }
            Console.Read();
        }
    }
}
