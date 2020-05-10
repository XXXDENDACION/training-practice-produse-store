namespace ShopOfProd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForeignKey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Products", "Category_Id", "dbo.CategoryProducts");
            DropIndex("dbo.Orders", new[] { "User_Id" });
            DropIndex("dbo.Products", new[] { "Category_Id" });
            RenameColumn(table: "dbo.Orders", name: "User_Id", newName: "userId");
            RenameColumn(table: "dbo.Products", name: "Category_Id", newName: "categoryId");
            AlterColumn("dbo.Orders", "userId", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "categoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Orders", "userId");
            CreateIndex("dbo.Products", "categoryId");
            AddForeignKey("dbo.Orders", "userId", "dbo.Users", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Products", "categoryId", "dbo.CategoryProducts", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "categoryId", "dbo.CategoryProducts");
            DropForeignKey("dbo.Orders", "userId", "dbo.Users");
            DropIndex("dbo.Products", new[] { "categoryId" });
            DropIndex("dbo.Orders", new[] { "userId" });
            AlterColumn("dbo.Products", "categoryId", c => c.Int());
            AlterColumn("dbo.Orders", "userId", c => c.Int());
            RenameColumn(table: "dbo.Products", name: "categoryId", newName: "Category_Id");
            RenameColumn(table: "dbo.Orders", name: "userId", newName: "User_Id");
            CreateIndex("dbo.Products", "Category_Id");
            CreateIndex("dbo.Orders", "User_Id");
            AddForeignKey("dbo.Products", "Category_Id", "dbo.CategoryProducts", "Id");
            AddForeignKey("dbo.Orders", "User_Id", "dbo.Users", "Id");
        }
    }
}
