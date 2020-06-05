namespace WebApplication75.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GENRES(GenreName) Values('Comedy')");
        }
        
        public override void Down()
        {
        }
    }
}
