namespace CodeFirstFromDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoryColumnToMigrationsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Category_Id", c => c.Int());
            CreateIndex("dbo.Courses", "Category_Id");
            AddForeignKey("dbo.Courses", "Category_Id", "dbo.Categories", "Id");
            Sql("UPDATE courses SET Category_Id = 1");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Category_Id", "dbo.Categories");
            DropIndex("dbo.Courses", new[] { "Category_Id" });
            DropColumn("dbo.Courses", "Category_Id");
        }
    }
}
