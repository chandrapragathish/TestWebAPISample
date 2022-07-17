using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace TestWebAPI.Models
{
    public class TestContext : DbContext
    {
        public TestContext()
            : base("name=TestEntities")
        {
        }
        public DbSet<Category> Category { get;set;}
        public DbSet<Product> Product { get;set;}
    }
}