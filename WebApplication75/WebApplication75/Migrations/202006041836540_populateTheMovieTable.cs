namespace WebApplication75.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateTheMovieTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Movies(MovieName,ReleaseDate,Genre,Price) Values('Fast & The Furious','2020/02/05 00:00:00','Action',32)");
        }
        
        public override void Down()
        {
        }
    }
}
