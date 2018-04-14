namespace Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeIdToGuid : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrderLine", "Order_Id", "dbo.Order");
            DropForeignKey("dbo.OrderLine", "Product_Id", "dbo.Product");
            DropForeignKey("dbo.OrderLine", "User_Id", "dbo.User");
            DropIndex("dbo.OrderLine", new[] { "Order_Id" });
            DropIndex("dbo.OrderLine", new[] { "Product_Id" });
            DropIndex("dbo.OrderLine", new[] { "User_Id" });
            RenameColumn(table: "dbo.OrderLine", name: "Order_Id", newName: "Order_Guid");
            RenameColumn(table: "dbo.OrderLine", name: "Product_Id", newName: "Product_Guid");
            RenameColumn(table: "dbo.OrderLine", name: "User_Id", newName: "User_Guid");
            DropPrimaryKey("dbo.Extra");
            DropPrimaryKey("dbo.OrderLine");
            DropPrimaryKey("dbo.Order");
            DropPrimaryKey("dbo.Product");
            DropPrimaryKey("dbo.User");
            DropPrimaryKey("dbo.Shop");
            AddColumn("dbo.Extra", "Guid", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.OrderLine", "Guid", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Order", "Guid", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Product", "Guid", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.User", "Guid", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Shop", "Guid", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.OrderLine", "Order_Guid", c => c.String(maxLength: 128));
            AlterColumn("dbo.OrderLine", "Product_Guid", c => c.String(maxLength: 128));
            AlterColumn("dbo.OrderLine", "User_Guid", c => c.String(maxLength: 128));
            AddPrimaryKey("dbo.Extra", "Guid");
            AddPrimaryKey("dbo.OrderLine", "Guid");
            AddPrimaryKey("dbo.Order", "Guid");
            AddPrimaryKey("dbo.Product", "Guid");
            AddPrimaryKey("dbo.User", "Guid");
            AddPrimaryKey("dbo.Shop", "Guid");
            CreateIndex("dbo.OrderLine", "Order_Guid");
            CreateIndex("dbo.OrderLine", "Product_Guid");
            CreateIndex("dbo.OrderLine", "User_Guid");
            AddForeignKey("dbo.OrderLine", "Order_Guid", "dbo.Order", "Guid");
            AddForeignKey("dbo.OrderLine", "Product_Guid", "dbo.Product", "Guid");
            AddForeignKey("dbo.OrderLine", "User_Guid", "dbo.User", "Guid");
            DropColumn("dbo.Extra", "Id");
            DropColumn("dbo.OrderLine", "Id");
            DropColumn("dbo.Order", "Id");
            DropColumn("dbo.Product", "Id");
            DropColumn("dbo.User", "Id");
            DropColumn("dbo.Shop", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Shop", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.User", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Product", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Order", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.OrderLine", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Extra", "Id", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.OrderLine", "User_Guid", "dbo.User");
            DropForeignKey("dbo.OrderLine", "Product_Guid", "dbo.Product");
            DropForeignKey("dbo.OrderLine", "Order_Guid", "dbo.Order");
            DropIndex("dbo.OrderLine", new[] { "User_Guid" });
            DropIndex("dbo.OrderLine", new[] { "Product_Guid" });
            DropIndex("dbo.OrderLine", new[] { "Order_Guid" });
            DropPrimaryKey("dbo.Shop");
            DropPrimaryKey("dbo.User");
            DropPrimaryKey("dbo.Product");
            DropPrimaryKey("dbo.Order");
            DropPrimaryKey("dbo.OrderLine");
            DropPrimaryKey("dbo.Extra");
            AlterColumn("dbo.OrderLine", "User_Guid", c => c.Int());
            AlterColumn("dbo.OrderLine", "Product_Guid", c => c.Int());
            AlterColumn("dbo.OrderLine", "Order_Guid", c => c.Int());
            DropColumn("dbo.Shop", "Guid");
            DropColumn("dbo.User", "Guid");
            DropColumn("dbo.Product", "Guid");
            DropColumn("dbo.Order", "Guid");
            DropColumn("dbo.OrderLine", "Guid");
            DropColumn("dbo.Extra", "Guid");
            AddPrimaryKey("dbo.Shop", "Id");
            AddPrimaryKey("dbo.User", "Id");
            AddPrimaryKey("dbo.Product", "Id");
            AddPrimaryKey("dbo.Order", "Id");
            AddPrimaryKey("dbo.OrderLine", "Id");
            AddPrimaryKey("dbo.Extra", "Id");
            RenameColumn(table: "dbo.OrderLine", name: "User_Guid", newName: "User_Id");
            RenameColumn(table: "dbo.OrderLine", name: "Product_Guid", newName: "Product_Id");
            RenameColumn(table: "dbo.OrderLine", name: "Order_Guid", newName: "Order_Id");
            CreateIndex("dbo.OrderLine", "User_Id");
            CreateIndex("dbo.OrderLine", "Product_Id");
            CreateIndex("dbo.OrderLine", "Order_Id");
            AddForeignKey("dbo.OrderLine", "User_Id", "dbo.User", "Id");
            AddForeignKey("dbo.OrderLine", "Product_Id", "dbo.Product", "Id");
            AddForeignKey("dbo.OrderLine", "Order_Id", "dbo.Order", "Id");
        }
    }
}
