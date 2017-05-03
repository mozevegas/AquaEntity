namespace AquaEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LoadTheTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AquariumAquaticLifeOcean",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AquariumId = c.Int(nullable: false),
                        AquaticLifeId = c.Int(nullable: false),
                        OceanId = c.Int(nullable: false),
                        Aquariums_Id = c.Int(),
                        AquaticLifes_Id = c.Int(),
                        Oceans_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Aquariums", t => t.Aquariums_Id)
                .ForeignKey("dbo.AquaticLifes", t => t.AquaticLifes_Id)
                .ForeignKey("dbo.Oceans", t => t.Oceans_Id)
                .Index(t => t.Aquariums_Id)
                .Index(t => t.AquaticLifes_Id)
                .Index(t => t.Oceans_Id);
            
            CreateTable(
                "dbo.Aquariums",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AquaticLifes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Color = c.String(),
                        Name = c.String(),
                        DateAdded = c.DateTime(nullable: false),
                        Quarantine = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Oceans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        AvgTemp = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AquariumAquaticLifeOcean", "Oceans_Id", "dbo.Oceans");
            DropForeignKey("dbo.AquariumAquaticLifeOcean", "AquaticLifes_Id", "dbo.AquaticLifes");
            DropForeignKey("dbo.AquariumAquaticLifeOcean", "Aquariums_Id", "dbo.Aquariums");
            DropIndex("dbo.AquariumAquaticLifeOcean", new[] { "Oceans_Id" });
            DropIndex("dbo.AquariumAquaticLifeOcean", new[] { "AquaticLifes_Id" });
            DropIndex("dbo.AquariumAquaticLifeOcean", new[] { "Aquariums_Id" });
            DropTable("dbo.Oceans");
            DropTable("dbo.AquaticLifes");
            DropTable("dbo.Aquariums");
            DropTable("dbo.AquariumAquaticLifeOcean");
        }
    }
}
