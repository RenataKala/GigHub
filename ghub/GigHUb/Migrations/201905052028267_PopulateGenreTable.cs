namespace GigHUb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Genres (Id,Name) Values (1, 'JAZZ')");
            Sql("Insert into Genres (Id,Name) Values (2, 'BLUES')");
            Sql("Insert into Genres (Id,Name) Values (3, 'ROCK')");
            Sql("Insert into Genres (Id,Name) Values (4, 'COUNTRY')");
        }
        
        public override void Down()
        {
            Sql("Delete from  Genres where Id in (1,2,3,4)");
        }
    }
}
