namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        CountryId = c.Int(nullable: false, identity: true),
                        CountryName = c.String(nullable: false, maxLength: 25),
                    })
                .PrimaryKey(t => t.CountryId)
                .Index(t => t.CountryName, unique: true);
            
            CreateTable(
                "dbo.Sity",
                c => new
                    {
                        SityId = c.Int(nullable: false, identity: true),
                        SityName = c.String(nullable: false, maxLength: 25),
                        CountryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SityId)
                .ForeignKey("dbo.Countries", t => t.CountryId)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        FirsName = c.String(name: "Firs Name", nullable: false, maxLength: 15),
                        LastName = c.String(name: "Last Name", nullable: false, maxLength: 15),
                        Phone = c.String(nullable: false, maxLength: 30),
                        Email = c.String(nullable: false, maxLength: 30),
                        Title = c.Int(nullable: false),
                        Comment = c.String(maxLength: 500),
                        CountryId = c.Int(nullable: false),
                        CityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Countries", t => t.CountryId)
                .ForeignKey("dbo.Sity", t => t.CityId)
                .Index(t => t.Phone, unique: true)
                .Index(t => t.Email, unique: true)
                .Index(t => t.CountryId)
                .Index(t => t.CityId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "CityId", "dbo.Sity");
            DropForeignKey("dbo.Users", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Sity", "CountryId", "dbo.Countries");
            DropIndex("dbo.Users", new[] { "CityId" });
            DropIndex("dbo.Users", new[] { "CountryId" });
            DropIndex("dbo.Users", new[] { "Email" });
            DropIndex("dbo.Users", new[] { "Phone" });
            DropIndex("dbo.Sity", new[] { "CountryId" });
            DropIndex("dbo.Countries", new[] { "CountryName" });
            DropTable("dbo.Users");
            DropTable("dbo.Sity");
            DropTable("dbo.Countries");
        }
    }
}
