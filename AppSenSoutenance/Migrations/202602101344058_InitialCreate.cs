namespace AppSenSoutenance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Utilisateurs",
                c => new
                    {
                        IdUtilisateur = c.Int(nullable: false, identity: true),
                        NomUtilisateur = c.String(nullable: false, maxLength: 80, storeType: "nvarchar"),
                        PrenomUtilisateur = c.String(nullable: false, maxLength: 80, storeType: "nvarchar"),
                        TelUtilisateur = c.String(nullable: false, maxLength: 15, storeType: "nvarchar"),
                        EmailUtilisateur = c.String(nullable: false, maxLength: 80, storeType: "nvarchar"),
                        MotDePasse = c.String(nullable: false, maxLength: 300, storeType: "nvarchar"),
                        MatriculeCandidat = c.String(maxLength: 20, storeType: "nvarchar"),
                        IdDepartement = c.Int(),
                        SpecialiteProfesseur = c.String(maxLength: 80, storeType: "nvarchar"),
                        Id = c.String(unicode: false),
                        Discriminator = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.IdUtilisateur)
                .ForeignKey("dbo.Departements", t => t.IdDepartement)
                .Index(t => t.IdDepartement);
            
            CreateTable(
                "dbo.AnneeAcademiques",
                c => new
                    {
                        IdAnneeAcademique = c.Int(nullable: false, identity: true),
                        LibelleAnneeAcademique = c.String(nullable: false, maxLength: 10, storeType: "nvarchar"),
                        AnneeAcademiqueVal = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdAnneeAcademique);
            
            CreateTable(
                "dbo.Departements",
                c => new
                    {
                        IdDepartement = c.Int(nullable: false, identity: true),
                        LibelleDepartement = c.String(nullable: false, maxLength: 80, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.IdDepartement);
            
            CreateTable(
                "dbo.Memoires",
                c => new
                    {
                        IdMemoire = c.Int(nullable: false, identity: true),
                        SujetMemoire = c.String(nullable: false, maxLength: 500, storeType: "nvarchar"),
                        IdAnneeAcademique = c.Int(),
                        DocumentMemoire = c.Binary(),
                        IdSession = c.Int(),
                    })
                .PrimaryKey(t => t.IdMemoire)
                .ForeignKey("dbo.AnneeAcademiques", t => t.IdAnneeAcademique)
                .ForeignKey("dbo.Sessions", t => t.IdSession)
                .Index(t => t.IdAnneeAcademique)
                .Index(t => t.IdSession);
            
            CreateTable(
                "dbo.Sessions",
                c => new
                    {
                        IdSession = c.Int(nullable: false, identity: true),
                        LibelleSession = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        IdAnneeAcademique = c.Int(),
                    })
                .PrimaryKey(t => t.IdSession)
                .ForeignKey("dbo.AnneeAcademiques", t => t.IdAnneeAcademique)
                .Index(t => t.IdAnneeAcademique);
            
            CreateTable(
                "dbo.Soutenances",
                c => new
                    {
                        IdSoutenance = c.Int(nullable: false, identity: true),
                        DateSoutenance = c.DateTime(nullable: false, precision: 0),
                        LieuSoutenance = c.String(maxLength: 2000, storeType: "nvarchar"),
                        ResultatSoutenance = c.String(maxLength: 50, storeType: "nvarchar"),
                        MentionSoutenance = c.String(maxLength: 100, storeType: "nvarchar"),
                        ObservationsSoutenance = c.String(maxLength: 5000, storeType: "nvarchar"),
                        IdMemoire = c.Int(),
                    })
                .PrimaryKey(t => t.IdSoutenance)
                .ForeignKey("dbo.Memoires", t => t.IdMemoire)
                .Index(t => t.IdMemoire);
            
            CreateTable(
                "dbo.Td_Erreur",
                c => new
                    {
                        IdTd_Erreur = c.Int(nullable: false, identity: true),
                        TitreErreur = c.String(maxLength: 200, storeType: "nvarchar"),
                        DescriptionErreur = c.String(maxLength: 2000, storeType: "nvarchar"),
                        DateErreur = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.IdTd_Erreur);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Soutenances", "IdMemoire", "dbo.Memoires");
            DropForeignKey("dbo.Memoires", "IdSession", "dbo.Sessions");
            DropForeignKey("dbo.Sessions", "IdAnneeAcademique", "dbo.AnneeAcademiques");
            DropForeignKey("dbo.Memoires", "IdAnneeAcademique", "dbo.AnneeAcademiques");
            DropForeignKey("dbo.Utilisateurs", "IdDepartement", "dbo.Departements");
            DropIndex("dbo.Soutenances", new[] { "IdMemoire" });
            DropIndex("dbo.Sessions", new[] { "IdAnneeAcademique" });
            DropIndex("dbo.Memoires", new[] { "IdSession" });
            DropIndex("dbo.Memoires", new[] { "IdAnneeAcademique" });
            DropIndex("dbo.Utilisateurs", new[] { "IdDepartement" });
            DropTable("dbo.Td_Erreur");
            DropTable("dbo.Soutenances");
            DropTable("dbo.Sessions");
            DropTable("dbo.Memoires");
            DropTable("dbo.Departements");
            DropTable("dbo.AnneeAcademiques");
            DropTable("dbo.Utilisateurs");
        }
    }
}
