using ConsoleAppEF.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace ConsoleAppEF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            NorthwindContext context = new NorthwindContext();  
            Categories c = new Categories();
            c.CategoryName = "New";
            //c.CategoryId = 1;
            c.Description = "new one";
            context.Categories.Add(c); 
            context.SaveChanges();
            Console.WriteLine("Saved Successfully");


            Console.ReadKey();

        }
        private static void show()
        {
            NorthwindContext context = new NorthwindContext();
            DbSet<Categories> catlist = context.Categories;
            foreach (var cat in catlist)
            {
                Console.WriteLine(cat.CategoryId);
                Console.WriteLine(cat.CategoryName);
                Console.WriteLine(cat.Description);

            }
        }
    }
}
