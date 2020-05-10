namespace ShopOfProd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Icollecting : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "userId", "dbo.Users");
            DropIndex("dbo.Orders", new[] { "userId" });
            RenameColumn(table: "dbo.Orders", name: "userId", newName: "User_Id");
            AlterColumn("dbo.Orders", "User_Id", c => c.Int());
            CreateIndex("dbo.Orders", "User_Id");
            AddForeignKey("dbo.Orders", "User_Id", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "User_Id", "dbo.Users");
            DropIndex("dbo.Orders", new[] { "User_Id" });
            AlterColumn("dbo.Orders", "User_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Orders", name: "User_Id", newName: "userId");
            CreateIndex("dbo.Orders", "userId");
            AddForeignKey("dbo.Orders", "userId", "dbo.Users", "Id", cascadeDelete: true);
        }
    }
}
