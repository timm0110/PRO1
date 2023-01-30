namespace MCV_APLIKACIJA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class b : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Izpits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Datum = c.DateTime(nullable: false),
                        Ocena = c.Int(nullable: false),
                        PredmetID = c.Int(nullable: false),
                        StudentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Predmets", t => t.PredmetID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.PredmetID)
                .Index(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Izpits", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Izpits", "PredmetID", "dbo.Predmets");
            DropIndex("dbo.Izpits", new[] { "StudentId" });
            DropIndex("dbo.Izpits", new[] { "PredmetID" });
            DropTable("dbo.Izpits");
        }
    }
}
