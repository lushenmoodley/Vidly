namespace WebApplication75.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedUserAgain : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES ('d687888d-7a59-4563-a302-8af080ae9d93', '26c0bf99-3b4d-4a08-a774-1c8bb85ba6de')");
        }
        
        public override void Down()
        {
        }
    }
}
