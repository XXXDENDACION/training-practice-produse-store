namespace ShopOfProd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLogPass : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "FullName", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "LogName", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Password", c => c.String());
            AlterColumn("dbo.Users", "LogName", c => c.String());
            AlterColumn("dbo.Users", "FullName", c => c.String());
        }
    }
}
