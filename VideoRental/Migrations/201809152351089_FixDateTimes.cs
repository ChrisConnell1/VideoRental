namespace VideoRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixDateTimes : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET DateAdded = CAST('2018-09-15' AS DATETIME) WHERE Id = 1 OR 1 = 1");
        }
        
        public override void Down()
        {
        }
    }
}
