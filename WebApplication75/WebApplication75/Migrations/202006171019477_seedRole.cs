namespace WebApplication75.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedRole : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'26c0bf99-3b4d-4a08-a774-1c8bb85ba6de', N'CanManageMovies')");
        }
        
        public override void Down()
        {
        }
    }
}
