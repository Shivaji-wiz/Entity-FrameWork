namespace CodeFirstFromDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedTitleToNameInCoursesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Name", c => c.String(nullable: false));
            Sql("UPDATE Courses SET Name = Title");
            DropColumn("dbo.Courses", "Title");

           // RenameColumn("dbo.Courses", "Title", "Name"); one method other method is to use SQL query.
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Title", c => c.String(nullable: false));
            Sql("UPDATE Courses SET Title = Name");
            DropColumn("dbo.Courses", "Name");
        }
    }
}
