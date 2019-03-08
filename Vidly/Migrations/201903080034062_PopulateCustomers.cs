namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers( Name, MembershipTypeId) VALUES('Monika Patel', 1)");
            Sql("INSERT INTO Customers( Name, MembershipTypeId) VALUES('Hiren Patel', 4)");
        }
        
        public override void Down()
        {
        }
    }
}
