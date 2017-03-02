namespace Vidlyr.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeRecent : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Genres", "Name", c => c.String());
            Sql("INSERT INTO Genres(Name) values ('Action')");
            Sql("INSERT INTO Genres(Name) values ('Animation')");
            Sql("INSERT INTO Genres(Name) values ('Comedy')");
            Sql("INSERT INTO Genres(Name) values ('Thriller')");
            Sql("INSERT INTO Genres(Name) values ('Romance')");
            Sql("INSERT INTO Genres(Name) values ('Drama')");
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Genres", "Name", c => c.Int(nullable: false));
        }
    }
}
