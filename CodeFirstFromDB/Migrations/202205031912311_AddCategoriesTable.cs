namespace CodeFirstFromDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoriesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);

            Sql("INSERT INTO categories VALUES (1 ,'Web Devlopment')");
            Sql("INSERT INTO categories VALUES (2 ,'Data Analytics')");
        }
        
        public override void Down()
        {
            DropTable("dbo.Categories");
        }
    }
}
