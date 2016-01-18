namespace Repozytorium.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dodanieatr : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OgloszenieAtrybutWartosc",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdOgloszenia = c.Int(nullable: false),
                        IdAtrybutu = c.Int(nullable: false),
                        IdAtybutWartosc = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OgloszenieAtrybutWartosc");
        }
    }
}
