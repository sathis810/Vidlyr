namespace Vidlyr.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtablegenremoviedbset : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        GenreId = c.Int(nullable: false, identity: true),
                        Name = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GenreId);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Genre_GenreId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genres", t => t.Genre_GenreId)
                .Index(t => t.Genre_GenreId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "Genre_GenreId", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "Genre_GenreId" });
            DropTable("dbo.Movies");
            DropTable("dbo.Genres");
        }
    }
}
