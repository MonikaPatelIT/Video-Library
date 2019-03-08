namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMovieGenreType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "GenreTypeId", c => c.Short(nullable: false));
            DropColumn("dbo.Movies", "GenreType");
        }
        
        public override void Down()
        {
          //  AddColumn("dbo.Movies", "GenreType", c => c.String());
            DropColumn("dbo.Movies", "GenreTypeId");
        }
    }
}
