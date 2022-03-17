using DoDucQuanWADFinal.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DoDucQuanWADFinal.Data
{
    public class FaicDbContext: DbContext
    {
        public FaicDbContext() : base("ConnectionString")
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}