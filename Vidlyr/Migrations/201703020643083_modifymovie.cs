namespace Vidlyr.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifymovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "RelaseDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "AddeDateTime", c => c.DateTime(nullable: false));

            Sql("UPDATE Movies set RelaseDateTime='2014-05-14',AddeDateTime=GETDATE() WHERE id='1'");
            Sql("UPDATE Movies set RelaseDateTime='2015-05-14',AddeDateTime=GETDATE() WHERE id='2'");
            Sql("UPDATE Movies set RelaseDateTime='2013-05-14',AddeDateTime=GETDATE() WHERE id='3'");
            Sql("UPDATE Movies set RelaseDateTime='2012-05-14',AddeDateTime=GETDATE() WHERE id='4'");
            Sql("UPDATE Movies set RelaseDateTime='2011-04-14',AddeDateTime=GETDATE() WHERE id='5'");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "AddeDateTime");
            DropColumn("dbo.Movies", "RelaseDateTime");
        }
    }
}
