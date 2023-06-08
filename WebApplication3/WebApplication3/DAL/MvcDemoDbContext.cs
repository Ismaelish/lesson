//dbcontext is a class used to communicate with the database

using Microsoft.EntityFrameworkCore; //library for DbContext, use or declare this if you are using dbcontext
using WebApplication3.Models.Domain;

namespace WebApplication3.DAL
{
    public class MvcDemoDbContext : DbContext
    {
        public MvcDemoDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; } // create a model to use this (inside DbSet)
                                                       // Employees is the table name
    }
}



//After creating DbCOntext, inject it to Program.cs file