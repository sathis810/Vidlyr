namespace Vidlyr.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updatemembershiptable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "MemberShipType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "MemberShipType");
        }
    }
}
