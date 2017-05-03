namespace AquaEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelChange : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AquariumAquaticLifeOcean", "Aquariums_Id", "dbo.Aquariums");
            DropForeignKey("dbo.AquariumAquaticLifeOcean", "AquaticLifes_Id", "dbo.AquaticLifes");
            DropForeignKey("dbo.AquariumAquaticLifeOcean", "Oceans_Id", "dbo.Oceans");
            DropIndex("dbo.AquariumAquaticLifeOcean", new[] { "Aquariums_Id" });
            DropIndex("dbo.AquariumAquaticLifeOcean", new[] { "AquaticLifes_Id" });
            DropIndex("dbo.AquariumAquaticLifeOcean", new[] { "Oceans_Id" });
            RenameColumn(table: "dbo.AquariumAquaticLifeOcean", name: "Aquariums_Id", newName: "AquariumsId");
            RenameColumn(table: "dbo.AquariumAquaticLifeOcean", name: "AquaticLifes_Id", newName: "AquaticLifesId");
            RenameColumn(table: "dbo.AquariumAquaticLifeOcean", name: "Oceans_Id", newName: "OceansId");
            AlterColumn("dbo.AquariumAquaticLifeOcean", "AquariumsId", c => c.Int(nullable: false));
            AlterColumn("dbo.AquariumAquaticLifeOcean", "AquaticLifesId", c => c.Int(nullable: false));
            AlterColumn("dbo.AquariumAquaticLifeOcean", "OceansId", c => c.Int(nullable: false));
            CreateIndex("dbo.AquariumAquaticLifeOcean", "AquariumsId");
            CreateIndex("dbo.AquariumAquaticLifeOcean", "AquaticLifesId");
            CreateIndex("dbo.AquariumAquaticLifeOcean", "OceansId");
            AddForeignKey("dbo.AquariumAquaticLifeOcean", "AquariumsId", "dbo.Aquariums", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AquariumAquaticLifeOcean", "AquaticLifesId", "dbo.AquaticLifes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AquariumAquaticLifeOcean", "OceansId", "dbo.Oceans", "Id", cascadeDelete: true);
            DropColumn("dbo.AquariumAquaticLifeOcean", "AquariumId");
            DropColumn("dbo.AquariumAquaticLifeOcean", "AquaticLifeId");
            DropColumn("dbo.AquariumAquaticLifeOcean", "OceanId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AquariumAquaticLifeOcean", "OceanId", c => c.Int(nullable: false));
            AddColumn("dbo.AquariumAquaticLifeOcean", "AquaticLifeId", c => c.Int(nullable: false));
            AddColumn("dbo.AquariumAquaticLifeOcean", "AquariumId", c => c.Int(nullable: false));
            DropForeignKey("dbo.AquariumAquaticLifeOcean", "OceansId", "dbo.Oceans");
            DropForeignKey("dbo.AquariumAquaticLifeOcean", "AquaticLifesId", "dbo.AquaticLifes");
            DropForeignKey("dbo.AquariumAquaticLifeOcean", "AquariumsId", "dbo.Aquariums");
            DropIndex("dbo.AquariumAquaticLifeOcean", new[] { "OceansId" });
            DropIndex("dbo.AquariumAquaticLifeOcean", new[] { "AquaticLifesId" });
            DropIndex("dbo.AquariumAquaticLifeOcean", new[] { "AquariumsId" });
            AlterColumn("dbo.AquariumAquaticLifeOcean", "OceansId", c => c.Int());
            AlterColumn("dbo.AquariumAquaticLifeOcean", "AquaticLifesId", c => c.Int());
            AlterColumn("dbo.AquariumAquaticLifeOcean", "AquariumsId", c => c.Int());
            RenameColumn(table: "dbo.AquariumAquaticLifeOcean", name: "OceansId", newName: "Oceans_Id");
            RenameColumn(table: "dbo.AquariumAquaticLifeOcean", name: "AquaticLifesId", newName: "AquaticLifes_Id");
            RenameColumn(table: "dbo.AquariumAquaticLifeOcean", name: "AquariumsId", newName: "Aquariums_Id");
            CreateIndex("dbo.AquariumAquaticLifeOcean", "Oceans_Id");
            CreateIndex("dbo.AquariumAquaticLifeOcean", "AquaticLifes_Id");
            CreateIndex("dbo.AquariumAquaticLifeOcean", "Aquariums_Id");
            AddForeignKey("dbo.AquariumAquaticLifeOcean", "Oceans_Id", "dbo.Oceans", "Id");
            AddForeignKey("dbo.AquariumAquaticLifeOcean", "AquaticLifes_Id", "dbo.AquaticLifes", "Id");
            AddForeignKey("dbo.AquariumAquaticLifeOcean", "Aquariums_Id", "dbo.Aquariums", "Id");
        }
    }
}
