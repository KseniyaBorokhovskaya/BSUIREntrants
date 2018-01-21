namespace BSUIREntrantsWebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewStructure : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UniversityDatas",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Text = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UniversityNodes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        ParentId = c.String(),
                        DataId = c.String(maxLength: 128),
                        TypeAndDepth = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UniversityDatas", t => t.DataId)
                .Index(t => t.DataId);
            
            AddColumn("dbo.Enrollees", "ApplyInfoId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Enrollees", "ApplyInfoId");
            AddForeignKey("dbo.Enrollees", "ApplyInfoId", "dbo.UniversityNodes", "Id");
            DropColumn("dbo.Enrollees", "University");
            DropColumn("dbo.Enrollees", "Faculty");
            DropColumn("dbo.Enrollees", "Speciality");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Enrollees", "Speciality", c => c.String());
            AddColumn("dbo.Enrollees", "Faculty", c => c.String());
            AddColumn("dbo.Enrollees", "University", c => c.String());
            DropForeignKey("dbo.Enrollees", "ApplyInfoId", "dbo.UniversityNodes");
            DropForeignKey("dbo.UniversityNodes", "DataId", "dbo.UniversityDatas");
            DropIndex("dbo.Enrollees", new[] { "ApplyInfoId" });
            DropIndex("dbo.UniversityNodes", new[] { "DataId" });
            DropColumn("dbo.Enrollees", "ApplyInfoId");
            DropTable("dbo.UniversityNodes");
            DropTable("dbo.UniversityDatas");
        }
    }
}
