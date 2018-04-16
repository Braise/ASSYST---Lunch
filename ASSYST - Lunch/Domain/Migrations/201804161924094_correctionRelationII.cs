namespace Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class correctionRelationII : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrderLine", "Product_Guid", "dbo.Product");
            DropIndex("dbo.Product", new[] { "Shop_Guid" });
            DropColumn("dbo.Product", "Guid");
            RenameColumn(table: "dbo.Product", name: "Shop_Guid", newName: "Guid");
            DropPrimaryKey("dbo.Product");
            AlterColumn("dbo.Product", "Guid", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Product", "Guid");
            CreateIndex("dbo.Product", "Guid");
            AddForeignKey("dbo.OrderLine", "Product_Guid", "dbo.Product", "Guid");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderLine", "Product_Guid", "dbo.Product");
            DropIndex("dbo.Product", new[] { "Guid" });
            DropPrimaryKey("dbo.Product");
            AlterColumn("dbo.Product", "Guid", c => c.String(maxLength: 128));
            AddPrimaryKey("dbo.Product", "Guid");
            RenameColumn(table: "dbo.Product", name: "Guid", newName: "Shop_Guid");
            AddColumn("dbo.Product", "Guid", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Product", "Shop_Guid");
            AddForeignKey("dbo.OrderLine", "Product_Guid", "dbo.Product", "Guid");
        }
    }
}
