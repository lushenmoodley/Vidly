namespace WebApplication75.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateCustomerTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "CustomerDateOfBirth", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "CustomerDateOfBirth");
        }
    }
}
