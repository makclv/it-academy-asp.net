namespace OrderTrackingSystem.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSecondMigration : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Users", "Phone", unique: true);
            CreateIndex("dbo.Users", "Email", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", new[] { "Email" });
            DropIndex("dbo.Users", new[] { "Phone" });
        }
    }
}
