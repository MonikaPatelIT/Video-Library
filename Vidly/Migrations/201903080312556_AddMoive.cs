namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMoive : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        GenreType = c.String(),
                        ReleasedDate = c.String(),
                        Quantity = c.Short(nullable: false),
                        Genre_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genres", t => t.Genre_Id)
                .Index(t => t.Genre_Id);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenreTypeId", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "GenreTypeId" });
            DropTable("dbo.Genres");
            DropTable("dbo.Movies");
        }
    }
}
