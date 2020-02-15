namespace AirLineServices.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Airlines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 225),
                        BookingAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TravelType = c.Int(nullable: false),
                        Time = c.Int(nullable: false),
                        Destination = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 225),
                        Address = c.String(nullable: false, maxLength: 225),
                        Age = c.Int(nullable: false),
                        PassportId = c.Int(nullable: false),
                        BookingAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TravelType = c.Int(nullable: false),
                        Time = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Airlines");
        }
    }
}
