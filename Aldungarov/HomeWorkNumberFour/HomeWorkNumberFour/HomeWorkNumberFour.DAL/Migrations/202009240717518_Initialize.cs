namespace HomeWorkNumberFour.ClientLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialize : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CityName = c.String(nullable: false, maxLength: 30),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Country",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CountryName = c.String(nullable: false, maxLength: 30),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        Title = c.Int(nullable: false),
                        Address_CountryName = c.String(),
                        Address_CityName = c.String(),
                        Comments = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Country", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Cities", "User_Id", "dbo.Users");
            DropIndex("dbo.Country", new[] { "User_Id" });
            DropIndex("dbo.Cities", new[] { "User_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Country");
            DropTable("dbo.Cities");
        }
    }
}
