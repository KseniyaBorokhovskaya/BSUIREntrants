namespace BSUIREntrantsWebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SomeFix : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UniversityNodes", "Children", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UniversityNodes", "Children");
        }
    }
}
