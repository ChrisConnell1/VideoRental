namespace VideoRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixReleaseDateTime : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET ReleaseDate = CAST('1999-09-15' AS DATETIME) WHERE Id = 1");
            Sql("UPDATE Movies SET ReleaseDate = CAST('1995-03-31' AS DATETIME) WHERE Id = 2");
            Sql("UPDATE Movies SET ReleaseDate = CAST('1980-05-23' AS DATETIME) WHERE Id = 3");
            Sql("UPDATE Movies SET ReleaseDate = CAST('1988-07-20' AS DATETIME) WHERE Id = 4");
            Sql("UPDATE Movies SET ReleaseDate = CAST('1971-12-19' AS DATETIME) WHERE Id = 5");
        }

        public override void Down()
        {
        }
    }
}
