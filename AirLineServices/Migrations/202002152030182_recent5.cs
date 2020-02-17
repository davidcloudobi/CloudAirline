namespace AirLineServices.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class recent5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Airlines", "Photo", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Airlines", "Photo");
        }
    }
}
