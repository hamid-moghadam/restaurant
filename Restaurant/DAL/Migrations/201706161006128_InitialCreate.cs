namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Factor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        TotalPrice = c.Double(nullable: false),
                        TotalPriceWithTax = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FactorDetail",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Count = c.Int(nullable: false),
                        TotalPrice = c.Double(nullable: false),
                        Description = c.String(),
                        FactorId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Factor", t => t.FactorId, cascadeDelete: true)
                .ForeignKey("dbo.Product", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.FactorId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Price = c.Double(nullable: false),
                        Available = c.Boolean(nullable: false),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FactorDetail", "ProductId", "dbo.Product");
            DropForeignKey("dbo.FactorDetail", "FactorId", "dbo.Factor");
            DropIndex("dbo.FactorDetail", new[] { "ProductId" });
            DropIndex("dbo.FactorDetail", new[] { "FactorId" });
            DropTable("dbo.Product");
            DropTable("dbo.FactorDetail");
            DropTable("dbo.Factor");
        }
    }
}
