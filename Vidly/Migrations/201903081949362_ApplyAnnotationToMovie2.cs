namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotationToMovie2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "ReleasedDate", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "ReleasedDate", c => c.String());
        }
    }
}
