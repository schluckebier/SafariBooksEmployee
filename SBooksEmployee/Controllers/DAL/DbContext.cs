using SBooksEmployee.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SBooksEmployee.Controllers.DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        // public DbSet<Song> Songs { get; set; } 
        public AppDbContext()
            : base("MyDBConnection")
        { }
    }
}