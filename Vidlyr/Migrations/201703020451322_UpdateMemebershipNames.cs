namespace Vidlyr.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMemebershipNames : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET MemberShipType='Pay As U Go' WHERE ID=1");
            Sql("UPDATE MembershipTypes SET MemberShipType='Monthly' WHERE ID=2");
            Sql("UPDATE MembershipTypes SET MemberShipType='Quarterly' WHERE ID=3");
            Sql("UPDATE MembershipTypes SET MemberShipType='Yearly' WHERE ID=4");
        }
        
        public override void Down()
        {
        }
    }
}
