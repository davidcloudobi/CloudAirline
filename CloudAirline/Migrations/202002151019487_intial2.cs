namespace CloudAirline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intial2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TransactionDetails", "Person_Id", "dbo.Users");
            DropForeignKey("dbo.TransactionDetails", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.TransactionDetails", new[] { "Person_Id" });
            DropIndex("dbo.TransactionDetails", new[] { "ApplicationUser_Id" });
            DropTable("dbo.TransactionDetails");
            DropTable("dbo.Users");
        }
        
        public override void Down()
        {
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
            
            CreateTable(
                "dbo.TransactionDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PaymentStatus = c.Boolean(nullable: false),
                        Person_Id = c.Int(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.TransactionDetails", "ApplicationUser_Id");
            CreateIndex("dbo.TransactionDetails", "Person_Id");
            AddForeignKey("dbo.TransactionDetails", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.TransactionDetails", "Person_Id", "dbo.Users", "Id");
        }
    }
}
