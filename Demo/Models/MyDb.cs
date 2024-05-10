using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Demo.Models
{
    public class MyDb : DbContext
    {
        public MyDb() : base("Data Source=CHINMAYA-PATRA\\SQLEXPRESS;Initial Catalog=tempdb;Integrated Security=True;TrustServerCertificate=True") 
        {

        
        }
        public DbSet<Sale> Sales1 { get; set; }
    }
}