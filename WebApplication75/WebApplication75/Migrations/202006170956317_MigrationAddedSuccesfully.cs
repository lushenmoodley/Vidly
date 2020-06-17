namespace WebApplication75.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationAddedSuccesfully : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd687888d-7a59-4563-a302-8af080ae9d93', N'admin@vidly.com', 0, N'AJ/LiSbkqQQW8aOTfg6VJUkSoujxmFiui6o8xcWuTvD5DqKUtHBC/pn67KWzNhPmeA==', N'8d4ac497-1233-42ed-b640-1d52c2deb407', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')");
           
            
        }
        
        public override void Down()
        {
        
        }
    }
}
