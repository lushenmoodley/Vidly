namespace WebApplication75.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateMembershipTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MEMBERSHIPTYPES (SignUpFee,DurationInMonths,DiscountRate) Values (0,0,0)");
            Sql("INSERT INTO MEMBERSHIPTYPES (SignUpFee,DurationInMonths,DiscountRate) Values (30,1,10)");
            Sql("INSERT INTO MEMBERSHIPTYPES (SignUpFee,DurationInMonths,DiscountRate) Values (90,3,15)");
            Sql("INSERT INTO MEMBERSHIPTYPES (SignUpFee,DurationInMonths,DiscountRate) Values (300,12,20)");
        }
        
        public override void Down()
        {
        }
    }
}
