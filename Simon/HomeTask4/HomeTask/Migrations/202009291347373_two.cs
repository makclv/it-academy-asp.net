namespace HomeTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class two : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cities", "CCountryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Cities", "CCountryId");
            AddForeignKey("dbo.Cities", "CCountryId", "dbo.Countries", "CountryId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cities", "CCountryId", "dbo.Countries");
            DropIndex("dbo.Cities", new[] { "CCountryId" });
            DropColumn("dbo.Cities", "CCountryId");
        }
    }
}
