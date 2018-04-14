namespace Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeIdToGuid1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Product", "Shop_Guid", c => c.String(maxLength: 128));
            AlterColumn("dbo.Product", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Product", "Description", c => c.String(nullable: false));
            CreateIndex("dbo.Product", "Shop_Guid");
            AddForeignKey("dbo.Product", "Shop_Guid", "dbo.Shop", "Guid");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "Shop_Guid", "dbo.Shop");
            DropIndex("dbo.Product", new[] { "Shop_Guid" });
            AlterColumn("dbo.Product", "Description", c => c.String());
            AlterColumn("dbo.Product", "Name", c => c.String());
            DropColumn("dbo.Product", "Shop_Guid");
        }
    }
}
