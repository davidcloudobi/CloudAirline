namespace AirLineServices.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Airlines", "Photo", c => c.Binary());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Airlines", "Photo", c => c.String());
        }
    }
}
