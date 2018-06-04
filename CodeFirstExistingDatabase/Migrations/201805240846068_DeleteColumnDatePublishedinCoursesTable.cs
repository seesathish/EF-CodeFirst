namespace FluentAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteColumnDatePublishedinCoursesTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Courses", "Datepublished");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Datepublished", c => c.DateTime());
        }
    }
}
