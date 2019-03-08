namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMoives : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO [Vidly].[dbo].[Movies]  VALUES('Love ni Bhavai','Romance' ,'2018-12-23',1, 3)");
                Sql("INSERT INTO [Vidly].[dbo].[Movies]  VALUES('Badla','Action' ,'2019-03-07',0, 2)");
        }
        
        public override void Down()
        {
        }
    }
}
