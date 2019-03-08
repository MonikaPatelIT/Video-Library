namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDOBToCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET DOB= '1992-02-19' WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
