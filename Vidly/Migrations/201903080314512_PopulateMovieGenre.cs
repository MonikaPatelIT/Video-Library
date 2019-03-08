namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovieGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres VALUES('Comedy')");
            Sql("INSERT INTO Genres VALUES('Action')");
            Sql("INSERT INTO Genres VALUES('Romance')");
        }
        
        public override void Down()
        {
        }
    }
}
