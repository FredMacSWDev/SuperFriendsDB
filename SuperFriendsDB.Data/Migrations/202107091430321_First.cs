namespace SuperHeroDB.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.Appearance",
            //    c => new
            //        {
            //            AppearanceId = c.Int(nullable: false, identity: true),
            //            CharacterId = c.Int(nullable: false),
            //            Gender = c.String(nullable: false),
            //            Race = c.String(nullable: false),
            //            Height = c.String(nullable: false),
            //            Weight = c.String(nullable: false),
            //            EyeColor = c.String(nullable: false),
            //            HairColor = c.String(nullable: false),
            //        })
            //    .PrimaryKey(t => t.AppearanceId)
            //    .ForeignKey("dbo.Character", t => t.CharacterId, cascadeDelete: true)
            //    .Index(t => t.CharacterId);
            
            //CreateTable(
            //    "dbo.Character",
            //    c => new
            //        {
            //            CharacterId = c.Int(nullable: false, identity: true),
            //            HeroName = c.String(nullable: false),
            //        })
            //    .PrimaryKey(t => t.CharacterId);
            
            //CreateTable(
            //    "dbo.Biography",
            //    c => new
            //        {
            //            BioId = c.Int(nullable: false, identity: true),
            //            CharacterId = c.Int(nullable: false),
            //            FullName = c.String(nullable: false),
            //            AlterEgos = c.String(nullable: false),
            //            PlaceOfBirth = c.String(nullable: false),
            //            FirstAppearance = c.String(nullable: false),
            //            Publisher = c.String(nullable: false),
            //            Alignment = c.String(nullable: false),
            //        })
            //    .PrimaryKey(t => t.BioId)
            //    .ForeignKey("dbo.Character", t => t.CharacterId, cascadeDelete: true)
            //    .Index(t => t.CharacterId);
            
            //CreateTable(
            //    "dbo.Powerstat",
            //    c => new
            //        {
            //            StatsId = c.Int(nullable: false, identity: true),
            //            CharacterId = c.Int(nullable: false),
            //            Intelligence = c.String(nullable: false),
            //            Strength = c.String(nullable: false),
            //            Speed = c.String(nullable: false),
            //            Durability = c.String(nullable: false),
            //            Power = c.String(nullable: false),
            //            Combat = c.String(nullable: false),
            //        })
            //    .PrimaryKey(t => t.StatsId)
            //    .ForeignKey("dbo.Character", t => t.CharacterId, cascadeDelete: true)
            //    .Index(t => t.CharacterId);
            
            //CreateTable(
            //    "dbo.IdentityRole",
            //    c => new
            //        {
            //            Id = c.String(nullable: false, maxLength: 128),
            //            Name = c.String(),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "dbo.IdentityUserRole",
            //    c => new
            //        {
            //            UserId = c.String(nullable: false, maxLength: 128),
            //            RoleId = c.String(),
            //            IdentityRole_Id = c.String(maxLength: 128),
            //            ApplicationUser_Id = c.String(maxLength: 128),
            //        })
            //    .PrimaryKey(t => t.UserId)
            //    .ForeignKey("dbo.IdentityRole", t => t.IdentityRole_Id)
            //    .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
            //    .Index(t => t.IdentityRole_Id)
            //    .Index(t => t.ApplicationUser_Id);
            
            //CreateTable(
            //    "dbo.ApplicationUser",
            //    c => new
            //        {
            //            Id = c.String(nullable: false, maxLength: 128),
            //            Email = c.String(),
            //            EmailConfirmed = c.Boolean(nullable: false),
            //            PasswordHash = c.String(),
            //            SecurityStamp = c.String(),
            //            PhoneNumber = c.String(),
            //            PhoneNumberConfirmed = c.Boolean(nullable: false),
            //            TwoFactorEnabled = c.Boolean(nullable: false),
            //            LockoutEndDateUtc = c.DateTime(),
            //            LockoutEnabled = c.Boolean(nullable: false),
            //            AccessFailedCount = c.Int(nullable: false),
            //            UserName = c.String(),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "dbo.IdentityUserClaim",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            UserId = c.String(),
            //            ClaimType = c.String(),
            //            ClaimValue = c.String(),
            //            ApplicationUser_Id = c.String(maxLength: 128),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
            //    .Index(t => t.ApplicationUser_Id);
            
            //CreateTable(
            //    "dbo.IdentityUserLogin",
            //    c => new
            //        {
            //            UserId = c.String(nullable: false, maxLength: 128),
            //            LoginProvider = c.String(),
            //            ProviderKey = c.String(),
            //            ApplicationUser_Id = c.String(maxLength: 128),
            //        })
            //    .PrimaryKey(t => t.UserId)
            //    .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
            //    .Index(t => t.ApplicationUser_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IdentityUserRole", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.IdentityUserLogin", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.IdentityUserClaim", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.IdentityUserRole", "IdentityRole_Id", "dbo.IdentityRole");
            DropForeignKey("dbo.Powerstat", "CharacterId", "dbo.Character");
            DropForeignKey("dbo.Biography", "CharacterId", "dbo.Character");
            DropForeignKey("dbo.Appearance", "CharacterId", "dbo.Character");
            DropIndex("dbo.IdentityUserLogin", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserClaim", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserRole", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserRole", new[] { "IdentityRole_Id" });
            DropIndex("dbo.Powerstat", new[] { "CharacterId" });
            DropIndex("dbo.Biography", new[] { "CharacterId" });
            DropIndex("dbo.Appearance", new[] { "CharacterId" });
            DropTable("dbo.IdentityUserLogin");
            DropTable("dbo.IdentityUserClaim");
            DropTable("dbo.ApplicationUser");
            DropTable("dbo.IdentityUserRole");
            DropTable("dbo.IdentityRole");
            DropTable("dbo.Powerstat");
            DropTable("dbo.Biography");
            DropTable("dbo.Character");
            DropTable("dbo.Appearance");
        }
    }
}
