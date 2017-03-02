namespace Vidlyr.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangesInNewDatabase : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "MemberShipId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "MemberShipId", c => c.Byte(nullable: false));
        }
    }
}
