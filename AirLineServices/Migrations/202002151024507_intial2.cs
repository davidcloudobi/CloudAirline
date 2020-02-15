namespace AirLineServices.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intial2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TransactionDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PaymentStatus = c.Boolean(nullable: false),
                        Person_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Person_Id)
                .Index(t => t.Person_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TransactionDetails", "Person_Id", "dbo.Users");
            DropIndex("dbo.TransactionDetails", new[] { "Person_Id" });
            DropTable("dbo.TransactionDetails");
        }
    }
}
