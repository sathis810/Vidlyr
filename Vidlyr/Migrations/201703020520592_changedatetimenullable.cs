namespace Vidlyr.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedatetimenullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "BirthdayDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "BirthdayDate", c => c.DateTime(nullable: false));
        }
    }
}
