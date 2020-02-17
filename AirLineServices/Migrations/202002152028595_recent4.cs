namespace AirLineServices.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class recent4 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Airlines", "Photo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Airlines", "Photo", c => c.String());
        }
    }
}
