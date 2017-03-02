namespace Vidlyr.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddMembershipTypes1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "MemberShipId", c => c.Byte(nullable: false));
        }

        public override void Down()
        {
            DropColumn("dbo.Customers", "MemberShipId");
        }
    }
}
