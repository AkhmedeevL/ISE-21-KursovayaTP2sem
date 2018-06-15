namespace Service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MMFfirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AdminFIO = c.String(nullable: false),
                        AdminLogin = c.String(nullable: false),
                        AdminPassword = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Entries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        FurnitureId = c.Int(nullable: false),
                        ConsultantId = c.Int(),
                        AdminId = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                        Sum = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Status = c.Int(nullable: false),
                        DateCreate = c.DateTime(nullable: false),
                        DateImplement = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Consultants", t => t.ConsultantId)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Furnitures", t => t.FurnitureId, cascadeDelete: true)
                .ForeignKey("dbo.Admins", t => t.AdminId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.FurnitureId)
                .Index(t => t.ConsultantId)
                .Index(t => t.AdminId);
            
            CreateTable(
                "dbo.Consultants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ConsultantFIO = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerFIO = c.String(nullable: false),
                        CustomerLogin = c.String(nullable: false),
                        CustomerPassword = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Furnitures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FurnitureName = c.String(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FurnitureParts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FurnitureId = c.Int(nullable: false),
                        PartId = c.Int(nullable: false),
                        Count = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Furnitures", t => t.FurnitureId, cascadeDelete: true)
                .ForeignKey("dbo.Parts", t => t.PartId, cascadeDelete: true)
                .Index(t => t.FurnitureId)
                .Index(t => t.PartId);
            
            CreateTable(
                "dbo.Parts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PartName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Entries", "AdminId", "dbo.Admins");
            DropForeignKey("dbo.FurnitureParts", "PartId", "dbo.Parts");
            DropForeignKey("dbo.FurnitureParts", "FurnitureId", "dbo.Furnitures");
            DropForeignKey("dbo.Entries", "FurnitureId", "dbo.Furnitures");
            DropForeignKey("dbo.Entries", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Entries", "ConsultantId", "dbo.Consultants");
            DropIndex("dbo.FurnitureParts", new[] { "PartId" });
            DropIndex("dbo.FurnitureParts", new[] { "FurnitureId" });
            DropIndex("dbo.Entries", new[] { "AdminId" });
            DropIndex("dbo.Entries", new[] { "ConsultantId" });
            DropIndex("dbo.Entries", new[] { "FurnitureId" });
            DropIndex("dbo.Entries", new[] { "CustomerId" });
            DropTable("dbo.Parts");
            DropTable("dbo.FurnitureParts");
            DropTable("dbo.Furnitures");
            DropTable("dbo.Customers");
            DropTable("dbo.Consultants");
            DropTable("dbo.Entries");
            DropTable("dbo.Admins");
        }
    }
}
