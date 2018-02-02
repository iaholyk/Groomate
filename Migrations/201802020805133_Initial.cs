namespace socialbutterfly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pets",
                c => new
                    {
                        PetId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Nickname = c.String(),
                        OwnerName = c.String(nullable: false),
                        Weight = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Age = c.Int(nullable: false),
                        Allergies = c.String(),
                        Breed = c.String(nullable: false),
                        Muzzle = c.Boolean(nullable: false),
                        SpecialNeeds = c.String(),
                        Sex = c.String(nullable: false),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.PetId)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pets", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Pets", new[] { "ApplicationUser_Id" });
            DropTable("dbo.Pets");
        }
    }
}
