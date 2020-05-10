namespace ShopOfProd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adduserID : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "User_Id", "dbo.Users");
            DropIndex("dbo.Orders", new[] { "User_Id" });
            RenameColumn(table: "dbo.Orders", name: "User_Id", newName: "userId");
            AlterColumn("dbo.Orders", "userId", c => c.Int(nullable: false));
            CreateIndex("dbo.Orders", "userId");
            AddForeignKey("dbo.Orders", "userId", "dbo.Users", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "userId", "dbo.Users");
            DropIndex("dbo.Orders", new[] { "userId" });
            AlterColumn("dbo.Orders", "userId", c => c.Int());
            RenameColumn(table: "dbo.Orders", name: "userId", newName: "User_Id");
            CreateIndex("dbo.Orders", "User_Id");
            AddForeignKey("dbo.Orders", "User_Id", "dbo.Users", "Id");
        }
    }
}
