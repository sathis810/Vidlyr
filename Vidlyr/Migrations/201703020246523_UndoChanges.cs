namespace Vidlyr.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class UndoChanges : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        id = c.Byte(nullable: false),
                        SignUpFee = c.Short(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.id);

            AddColumn("dbo.Customers", "MembershipType_id", c => c.Byte());
            CreateIndex("dbo.Customers", "MembershipType_id");
            AddForeignKey("dbo.Customers", "MembershipType_id", "dbo.MembershipTypes", "id");
        }

        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MembershipType_id", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "MembershipType_id" });
            DropColumn("dbo.Customers", "MembershipType_id");
            DropTable("dbo.MembershipTypes");
        }
    }
}
