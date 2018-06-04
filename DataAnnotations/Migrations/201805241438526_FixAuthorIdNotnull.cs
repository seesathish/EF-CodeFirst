namespace FluentAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixAuthorIdNotnull : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "Author_Id", "dbo.Authors");
            DropIndex("dbo.Courses", new[] { "Author_Id" });
            AlterColumn("dbo.Courses", "Author_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Courses", "Author_Id");
            AddForeignKey("dbo.Courses", "Author_Id", "dbo.Authors", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Author_Id", "dbo.Authors");
            DropIndex("dbo.Courses", new[] { "Author_Id" });
            AlterColumn("dbo.Courses", "Author_Id", c => c.Int());
            CreateIndex("dbo.Courses", "Author_Id");
            AddForeignKey("dbo.Courses", "Author_Id", "dbo.Authors", "Id");
        }
    }
}
