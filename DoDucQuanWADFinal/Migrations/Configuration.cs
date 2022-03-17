namespace DoDucQuanWADFinal.Migrations
{
    using DoDucQuanWADFinal.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DoDucQuanWADFinal.Data.FaicDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DoDucQuanWADFinal.Data.FaicDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            var categories = new List<Category>
            {
                new Category
                    {
                        CategoryID="C001",
                        CategoryName="CD",
                        Description="CD collection",
                        Picture="https://www.pngitem.com/pimgs/m/26-260878_cd-png-cd-icon-cd-icon-png-transparent.png"
                    },
                new Category
                    {
                        CategoryID="C002",
                        CategoryName="Vinyl",
                        Description="Vinyl collection",
                        Picture="https://p.kindpng.com/picc/s/81-810478_record-clipart-svg-vinyl-record-svg-hd-png.png"
                    }
            };
            categories.ForEach(s => context.Categories.AddOrUpdate(s));
            var products = new List<Product>
            {
                new Product
                    {
                        ProductId="P001",
                        ProductName="Liberation CD",
                        SupplierId="S001",
                        CategoryId="C001",
                        QuantityPerUnit=1,
                        UnitPrice=10,
                        UnitsInStock=1,
                        UnitsOnOrder=2,
                        ReorderLevel=1,
                        Discontinued=false
                    },
                new Product
                    {
                        ProductId="P002",
                        ProductName="Bionic CD",
                        SupplierId="S001",
                        CategoryId="C001",
                        QuantityPerUnit=1,
                        UnitPrice=10,
                        UnitsInStock=1,
                        UnitsOnOrder=2,
                        ReorderLevel=1,
                        Discontinued=false
                    },
                new Product
                    {
                        ProductId="P003",
                        ProductName="Red Vinyl",
                        SupplierId="S001",
                        CategoryId="C002",
                        QuantityPerUnit=1,
                        UnitPrice=10,
                        UnitsInStock=1,
                        UnitsOnOrder=2,
                        ReorderLevel=1,
                        Discontinued=false
                    }
            };
            products.ForEach(s => context.Products.AddOrUpdate(s));
            context.SaveChanges();
        }
    }
}
