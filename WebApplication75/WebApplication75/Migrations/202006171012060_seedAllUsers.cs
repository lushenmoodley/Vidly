namespace WebApplication75.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedAllUsers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'fb4cb994-0bb9-4e05-92cc-97afdb691887', N'guest@vidly.com', 0, N'ALz81aXefmLaJBslixrMVeWPQ8cjyCybC20WXk/aFjmae0Hd5fijuHWC7KCTufRcQg==', N'6346f7d9-5d93-4b6f-983e-ada1a54e4206', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')");
        }
        
        public override void Down()
        {
        }
    }
}
