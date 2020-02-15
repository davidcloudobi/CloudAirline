namespace AirLineServices.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intial3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Destination", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Destination");
        }
    }
}
