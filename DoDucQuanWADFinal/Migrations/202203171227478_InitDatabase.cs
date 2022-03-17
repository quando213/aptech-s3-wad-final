namespace DoDucQuanWADFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.String(nullable: false, maxLength: 128),
                        CategoryName = c.String(),
                        Description = c.String(),
                        Picture = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.String(nullable: false, maxLength: 128),
                        ProductName = c.String(),
                        SupplierId = c.String(),
                        CategoryId = c.String(maxLength: 128),
                        QuantityPerUnit = c.Int(nullable: false),
                        UnitPrice = c.Single(nullable: false),
                        UnitsInStock = c.Int(nullable: false),
                        UnitsOnOrder = c.Int(nullable: false),
                        ReorderLevel = c.Int(nullable: false),
                        Discontinued = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Categories", t => t.CategoryId)
                .Index(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
