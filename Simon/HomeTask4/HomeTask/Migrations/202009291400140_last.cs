namespace HomeTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class last : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Cities", name: "CCountryId", newName: "Country_CountryId");
            RenameIndex(table: "dbo.Cities", name: "IX_CCountryId", newName: "IX_Country_CountryId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Cities", name: "IX_Country_CountryId", newName: "IX_CCountryId");
            RenameColumn(table: "dbo.Cities", name: "Country_CountryId", newName: "CCountryId");
        }
    }
}
