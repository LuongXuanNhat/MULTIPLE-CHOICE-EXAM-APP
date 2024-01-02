namespace PhanMemThiTracNghiem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initdatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BANGDIEM",
                c => new
                    {
                        MASV = c.String(nullable: false, maxLength: 15, unicode: false),
                        MAKITHI = c.String(nullable: false, maxLength: 11, unicode: false),
                        MAMT = c.String(nullable: false, maxLength: 40, unicode: false),
                        ID = c.Int(),
                        DIEM = c.Double(),
                        CHITIETKYTHI_MAKITHI = c.String(maxLength: 11, unicode: false),
                        CHITIETKYTHI_MAMT = c.String(maxLength: 40, unicode: false),
                        CHITIETKYTHI_MASV = c.String(maxLength: 15, unicode: false),
                    })
                .PrimaryKey(t => new { t.MASV, t.MAKITHI, t.MAMT })
                .ForeignKey("dbo.CHITIETKYTHI", t => new { t.CHITIETKYTHI_MAKITHI, t.CHITIETKYTHI_MAMT, t.CHITIETKYTHI_MASV })
                .Index(t => new { t.CHITIETKYTHI_MAKITHI, t.CHITIETKYTHI_MAMT, t.CHITIETKYTHI_MASV });
            
            CreateTable(
                "dbo.CHITIETKYTHI",
                c => new
                    {
                        MAKITHI = c.String(nullable: false, maxLength: 11, unicode: false),
                        MAMT = c.String(nullable: false, maxLength: 40, unicode: false),
                        MASV = c.String(nullable: false, maxLength: 15, unicode: false),
                        DIEM = c.Double(),
                        THOIGIANTHI = c.Int(),
                        THOIGIANBD = c.DateTime(),
                        THOIGIANKT = c.DateTime(),
                    })
                .PrimaryKey(t => new { t.MAKITHI, t.MAMT, t.MASV })
                .ForeignKey("dbo.MONTHI", t => t.MAMT, cascadeDelete: true)
                .ForeignKey("dbo.SINHVIEN", t => t.MASV, cascadeDelete: true)
                .Index(t => t.MAMT)
                .Index(t => t.MASV);
            
            CreateTable(
                "dbo.CAUHOI",
                c => new
                    {
                        MACAUHOI = c.Int(nullable: false),
                        STT = c.Int(nullable: false),
                        NDCAUHOI = c.String(maxLength: 500),
                        DAPAN1 = c.String(nullable: false, maxLength: 200),
                        DAPAN2 = c.String(nullable: false, maxLength: 200),
                        DAPAN3 = c.String(nullable: false, maxLength: 200),
                        DAPAN4 = c.String(nullable: false, maxLength: 200),
                        DAPANDUNG = c.String(nullable: false, maxLength: 200),
                        MAGV = c.String(nullable: false, maxLength: 15, unicode: false),
                        MAMT = c.String(maxLength: 40, unicode: false),
                    })
                .PrimaryKey(t => t.MACAUHOI)
                .ForeignKey("dbo.MONTHI", t => t.MAMT)
                .ForeignKey("dbo.GIANGVIEN", t => t.MAGV, cascadeDelete: true)
                .Index(t => t.MAGV)
                .Index(t => t.MAMT);
            
            CreateTable(
                "dbo.CHITIETDETHI",
                c => new
                    {
                        MADETHI = c.String(nullable: false, maxLength: 10, unicode: false),
                        MACAUHOI = c.Int(nullable: false),
                        MUCDO = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => new { t.MADETHI, t.MACAUHOI })
                .ForeignKey("dbo.DETHI", t => t.MADETHI, cascadeDelete: true)
                .Index(t => t.MADETHI);
            
            CreateTable(
                "dbo.DETHI",
                c => new
                    {
                        MADETHI = c.String(nullable: false, maxLength: 10, unicode: false),
                        ID = c.Int(),
                        MAKITHI = c.String(maxLength: 11, unicode: false),
                        MAMT = c.String(maxLength: 40, unicode: false),
                    })
                .PrimaryKey(t => t.MADETHI)
                .ForeignKey("dbo.MONTHI", t => t.MAMT)
                .Index(t => t.MAMT);
            
            CreateTable(
                "dbo.MONTHI",
                c => new
                    {
                        MAMT = c.String(nullable: false, maxLength: 40, unicode: false),
                        STT = c.Int(),
                        TENMT = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.MAMT);
            
            CreateTable(
                "dbo.GIANGVIEN",
                c => new
                    {
                        MAGV = c.String(nullable: false, maxLength: 15, unicode: false),
                        STT = c.Int(),
                        TENGV = c.String(nullable: false, maxLength: 50),
                        NGAYSINH = c.DateTime(nullable: false, storeType: "date"),
                        MATKHAU = c.String(nullable: false, maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.MAGV);
            
            CreateTable(
                "dbo.KITHI",
                c => new
                    {
                        MAKITHI = c.String(nullable: false, maxLength: 11, unicode: false),
                        ID = c.Int(),
                        TENKITHI = c.String(nullable: false, maxLength: 50),
                        ADMIN = c.String(maxLength: 20, unicode: false),
                        THOIGIANBDKITHI = c.DateTime(),
                        THOIGIANKTKITHI = c.DateTime(),
                    })
                .PrimaryKey(t => t.MAKITHI)
                .ForeignKey("dbo.QUANTRI", t => t.ADMIN)
                .Index(t => t.ADMIN);
            
            CreateTable(
                "dbo.QUANTRI",
                c => new
                    {
                        ADMIN = c.String(nullable: false, maxLength: 20, unicode: false),
                        STT = c.Int(),
                        MATKHAU = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ADMIN);
            
            CreateTable(
                "dbo.SINHVIEN",
                c => new
                    {
                        MASV = c.String(nullable: false, maxLength: 15, unicode: false),
                        STT = c.Int(nullable: false),
                        LOP = c.String(nullable: false, maxLength: 10, unicode: false),
                        TENSV = c.String(nullable: false, maxLength: 50),
                        NGAYSINH = c.DateTime(nullable: false, storeType: "date"),
                        MATKHAU = c.String(nullable: false, maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.MASV);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CHITIETKYTHI", "MASV", "dbo.SINHVIEN");
            DropForeignKey("dbo.KITHI", "ADMIN", "dbo.QUANTRI");
            DropForeignKey("dbo.CAUHOI", "MAGV", "dbo.GIANGVIEN");
            DropForeignKey("dbo.DETHI", "MAMT", "dbo.MONTHI");
            DropForeignKey("dbo.CHITIETKYTHI", "MAMT", "dbo.MONTHI");
            DropForeignKey("dbo.CAUHOI", "MAMT", "dbo.MONTHI");
            DropForeignKey("dbo.CHITIETDETHI", "MADETHI", "dbo.DETHI");
            DropForeignKey("dbo.BANGDIEM", new[] { "CHITIETKYTHI_MAKITHI", "CHITIETKYTHI_MAMT", "CHITIETKYTHI_MASV" }, "dbo.CHITIETKYTHI");
            DropIndex("dbo.KITHI", new[] { "ADMIN" });
            DropIndex("dbo.DETHI", new[] { "MAMT" });
            DropIndex("dbo.CHITIETDETHI", new[] { "MADETHI" });
            DropIndex("dbo.CAUHOI", new[] { "MAMT" });
            DropIndex("dbo.CAUHOI", new[] { "MAGV" });
            DropIndex("dbo.CHITIETKYTHI", new[] { "MASV" });
            DropIndex("dbo.CHITIETKYTHI", new[] { "MAMT" });
            DropIndex("dbo.BANGDIEM", new[] { "CHITIETKYTHI_MAKITHI", "CHITIETKYTHI_MAMT", "CHITIETKYTHI_MASV" });
            DropTable("dbo.SINHVIEN");
            DropTable("dbo.QUANTRI");
            DropTable("dbo.KITHI");
            DropTable("dbo.GIANGVIEN");
            DropTable("dbo.MONTHI");
            DropTable("dbo.DETHI");
            DropTable("dbo.CHITIETDETHI");
            DropTable("dbo.CAUHOI");
            DropTable("dbo.CHITIETKYTHI");
            DropTable("dbo.BANGDIEM");
        }
    }
}
