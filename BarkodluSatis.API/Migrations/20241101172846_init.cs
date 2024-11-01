using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BarkodluSatis.API.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Barkod",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BarkodNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Barkod", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HizliUrun",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Barkod = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UrunAd = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Fiyat = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HizliUrun", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Islem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IslemNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Islem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IslemOzet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IslemNo = table.Column<int>(type: "int", nullable: false),
                    Iade = table.Column<bool>(type: "bit", nullable: false),
                    OdemeSekli = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nakit = table.Column<double>(type: "float", nullable: false),
                    Kart = table.Column<double>(type: "float", nullable: false),
                    Gelir = table.Column<bool>(type: "bit", nullable: false),
                    Gider = table.Column<bool>(type: "bit", nullable: false),
                    AlisFiyatToplam = table.Column<double>(type: "float", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kullanici = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IslemOzet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kullanici",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Eposta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KullaniciAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Satis = table.Column<bool>(type: "bit", nullable: false),
                    Rapor = table.Column<bool>(type: "bit", nullable: false),
                    Stok = table.Column<bool>(type: "bit", nullable: false),
                    UrunGiris = table.Column<bool>(type: "bit", nullable: false),
                    Ayarlar = table.Column<bool>(type: "bit", nullable: false),
                    FiyatGuncelle = table.Column<bool>(type: "bit", nullable: false),
                    Yedekleme = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanici", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sabit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KartKomisyon = table.Column<int>(type: "int", nullable: false),
                    Yazici = table.Column<bool>(type: "bit", nullable: false),
                    AdSoyad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Unvan = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Eposta = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sabit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Satis",
                columns: table => new
                {
                    SatisId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IslemNo = table.Column<int>(type: "int", nullable: false),
                    UrunAd = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Barkod = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UrunGrup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlisFiyat = table.Column<double>(type: "float", nullable: false),
                    SatisFiyat = table.Column<double>(type: "float", nullable: false),
                    Miktar = table.Column<double>(type: "float", nullable: false),
                    Toplam = table.Column<double>(type: "float", nullable: false),
                    KdvTutari = table.Column<double>(type: "float", nullable: false),
                    OdemeSekli = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Iade = table.Column<bool>(type: "bit", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kullanici = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Satis", x => x.SatisId);
                });

            migrationBuilder.CreateTable(
                name: "StokHareket",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Barkod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrunAd = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Birim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Miktar = table.Column<double>(type: "float", nullable: false),
                    UrunGrup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kullanici = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StokHareket", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Terazi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeraziOnEk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terazi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Urun",
                columns: table => new
                {
                    UrunId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Barkod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrunAd = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrunGrup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlisFiyati = table.Column<double>(type: "float", nullable: false),
                    SatisFiyati = table.Column<double>(type: "float", nullable: false),
                    KdvOrani = table.Column<int>(type: "int", nullable: false),
                    KdvTutari = table.Column<double>(type: "float", nullable: false),
                    Birim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Miktar = table.Column<double>(type: "float", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kullanici = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urun", x => x.UrunId);
                });

            migrationBuilder.CreateTable(
                name: "UrunGrup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunGrupAd = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrunGrup", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Barkod");

            migrationBuilder.DropTable(
                name: "HizliUrun");

            migrationBuilder.DropTable(
                name: "Islem");

            migrationBuilder.DropTable(
                name: "IslemOzet");

            migrationBuilder.DropTable(
                name: "Kullanici");

            migrationBuilder.DropTable(
                name: "Sabit");

            migrationBuilder.DropTable(
                name: "Satis");

            migrationBuilder.DropTable(
                name: "StokHareket");

            migrationBuilder.DropTable(
                name: "Terazi");

            migrationBuilder.DropTable(
                name: "Urun");

            migrationBuilder.DropTable(
                name: "UrunGrup");
        }
    }
}
