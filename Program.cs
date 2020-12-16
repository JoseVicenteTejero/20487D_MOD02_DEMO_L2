using System;
using MyFirstEF.Database;

namespace MyFirst
{
    class Program
    {
       static void Main(string[] args)
    {
        using(var context = new MyDbContext())
        {
            DbInitializer.Initialize(context);
        }
        Console.WriteLine("Database created");
    }
    }
}
