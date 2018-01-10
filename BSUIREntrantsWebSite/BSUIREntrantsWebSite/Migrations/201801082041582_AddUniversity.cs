namespace BSUIREntrantsWebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUniversity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Enrollees", "University", c => c.String());
            AddColumn("dbo.Enrollees", "Faculty", c => c.String());
            AddColumn("dbo.Enrollees", "Speciality", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Enrollees", "Speciality");
            DropColumn("dbo.Enrollees", "Faculty");
            DropColumn("dbo.Enrollees", "University");
        }
    }
}
