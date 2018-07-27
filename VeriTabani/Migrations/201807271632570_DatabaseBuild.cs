namespace Bilgi.VeriTabani.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatabaseBuild : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bilgis",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Metin = c.String(),
                        Kaynak = c.String(),
                        Tarih = c.DateTime(nullable: false),
                        HakkindaOlanKisi_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Kisis", t => t.HakkindaOlanKisi_ID)
                .Index(t => t.HakkindaOlanKisi_ID);
            
            CreateTable(
                "dbo.Kisis",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Isim = c.String(),
                        Soyisim = c.String(),
                        DogumTarihi = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Cinsiyet = c.Boolean(nullable: false),
                        Sehir_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Sehirs", t => t.Sehir_ID)
                .Index(t => t.Sehir_ID);
            
            CreateTable(
                "dbo.Sehirs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Isim = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SosyalMedyaHesabis",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Kullanici_ID = c.Int(),
                        SosyalMedyaTur_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Kisis", t => t.Kullanici_ID)
                .ForeignKey("dbo.SosyalMedyas", t => t.SosyalMedyaTur_ID)
                .Index(t => t.Kullanici_ID)
                .Index(t => t.SosyalMedyaTur_ID);
            
            CreateTable(
                "dbo.SosyalMedyas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Isim = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TelefonNumarasis",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Numara = c.String(),
                        Kullanici_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Kisis", t => t.Kullanici_ID)
                .Index(t => t.Kullanici_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TelefonNumarasis", "Kullanici_ID", "dbo.Kisis");
            DropForeignKey("dbo.SosyalMedyaHesabis", "SosyalMedyaTur_ID", "dbo.SosyalMedyas");
            DropForeignKey("dbo.SosyalMedyaHesabis", "Kullanici_ID", "dbo.Kisis");
            DropForeignKey("dbo.Kisis", "Sehir_ID", "dbo.Sehirs");
            DropForeignKey("dbo.Bilgis", "HakkindaOlanKisi_ID", "dbo.Kisis");
            DropIndex("dbo.TelefonNumarasis", new[] { "Kullanici_ID" });
            DropIndex("dbo.SosyalMedyaHesabis", new[] { "SosyalMedyaTur_ID" });
            DropIndex("dbo.SosyalMedyaHesabis", new[] { "Kullanici_ID" });
            DropIndex("dbo.Kisis", new[] { "Sehir_ID" });
            DropIndex("dbo.Bilgis", new[] { "HakkindaOlanKisi_ID" });
            DropTable("dbo.TelefonNumarasis");
            DropTable("dbo.SosyalMedyas");
            DropTable("dbo.SosyalMedyaHesabis");
            DropTable("dbo.Sehirs");
            DropTable("dbo.Kisis");
            DropTable("dbo.Bilgis");
        }
    }
}
