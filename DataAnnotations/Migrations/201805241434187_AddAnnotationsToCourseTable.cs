namespace FluentAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAnnotationsToCourseTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Courses", "Author_Id");
            RenameColumn(table: "dbo.Courses", name: "Author_Id1", newName: "Author_Id");
            RenameIndex(table: "dbo.Courses", name: "IX_Author_Id1", newName: "IX_Author_Id");
            AlterColumn("dbo.Courses", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Courses", "Description", c => c.String(nullable: false, maxLength: 2000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Courses", "Description", c => c.String());
            AlterColumn("dbo.Courses", "Name", c => c.String());
            RenameIndex(table: "dbo.Courses", name: "IX_Author_Id", newName: "IX_Author_Id1");
            RenameColumn(table: "dbo.Courses", name: "Author_Id", newName: "Author_Id1");
            AddColumn("dbo.Courses", "Author_Id", c => c.Int());
        }
    }
}
