namespace Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Extra",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrderLine",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Note = c.String(),
                        IsPaid = c.Boolean(nullable: false),
                        Order_Id = c.Int(),
                        Product_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Order", t => t.Order_Id)
                .ForeignKey("dbo.Product", t => t.Product_Id)
                .ForeignKey("dbo.User", t => t.User_Id)
                .Index(t => t.Order_Id)
                .Index(t => t.Product_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Price = c.Double(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Firstname = c.String(),
                        Lastname = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Shop",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        City = c.String(nullable: false),
                        ZipCode = c.String(nullable: false),
                        Street = c.String(nullable: false),
                        Number = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        Mail = c.String(nullable: false),
                        OrderBefore = c.String(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderLine", "User_Id", "dbo.User");
            DropForeignKey("dbo.OrderLine", "Product_Id", "dbo.Product");
            DropForeignKey("dbo.OrderLine", "Order_Id", "dbo.Order");
            DropIndex("dbo.OrderLine", new[] { "User_Id" });
            DropIndex("dbo.OrderLine", new[] { "Product_Id" });
            DropIndex("dbo.OrderLine", new[] { "Order_Id" });
            DropTable("dbo.Shop");
            DropTable("dbo.User");
            DropTable("dbo.Product");
            DropTable("dbo.Order");
            DropTable("dbo.OrderLine");
            DropTable("dbo.Extra");
        }
    }
}
