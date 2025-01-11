using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModaAyse.Repository.Migrations
{
    /// <inheritdoc />
    public partial class initial_duzenleme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KulaniciId",
                table: "Urunler",
                newName: "KullaniciId");

            migrationBuilder.RenameColumn(
                name: "KulaniciId",
                table: "Kategoriler",
                newName: "KullaniciId");

            migrationBuilder.AddColumn<bool>(
                name: "AktifMi",
                table: "Iller",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "EklemeTarihi",
                table: "Iller",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "GuncellemeTarihi",
                table: "Iller",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Iller",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KullaniciId",
                table: "Iller",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "AktifMi",
                table: "Ilceler",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "EklemeTarihi",
                table: "Ilceler",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "GuncellemeTarihi",
                table: "Ilceler",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Ilceler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KullaniciId",
                table: "Ilceler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Menuler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MenuKatekori = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrunlerId = table.Column<int>(type: "int", nullable: true),
                    KategorilerId = table.Column<int>(type: "int", nullable: true),
                    AktifMi = table.Column<bool>(type: "bit", nullable: false),
                    EklemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menuler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menuler_Kategoriler_KategorilerId",
                        column: x => x.KategorilerId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Menuler_Urunler_UrunlerId",
                        column: x => x.UrunlerId,
                        principalTable: "Urunler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Resimler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResimYolu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResimSirasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResimAciklamasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResimTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UrunId = table.Column<int>(type: "int", nullable: false),
                    AktifMi = table.Column<bool>(type: "bit", nullable: false),
                    EklemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resimler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resimler_Urunler_UrunId",
                        column: x => x.UrunId,
                        principalTable: "Urunler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "YetkiErisim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YetkiErisimId = table.Column<int>(type: "int", nullable: true),
                    AktifMi = table.Column<bool>(type: "bit", nullable: false),
                    EklemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YetkiErisim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_YetkiErisim_YetkiErisim_YetkiErisimId",
                        column: x => x.YetkiErisimId,
                        principalTable: "YetkiErisim",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Yetkiler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YerkiAdi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    YetkiErisimId = table.Column<int>(type: "int", nullable: true),
                    AktifMi = table.Column<bool>(type: "bit", nullable: false),
                    EklemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yetkiler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Yetkiler_YetkiErisim_YetkiErisimId",
                        column: x => x.YetkiErisimId,
                        principalTable: "YetkiErisim",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Soyadi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    KullaniciSifre = table.Column<int>(type: "int", nullable: false),
                    KullaniciMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KullaniciTelefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KullaniciAdres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KullaniciResim = table.Column<bool>(type: "bit", nullable: false),
                    YetkiId = table.Column<int>(type: "int", nullable: false),
                    YetkilerId = table.Column<int>(type: "int", nullable: true),
                    UrunlerId = table.Column<int>(type: "int", nullable: false),
                    AktifMi = table.Column<bool>(type: "bit", nullable: false),
                    EklemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kullanicilar_Urunler_UrunlerId",
                        column: x => x.UrunlerId,
                        principalTable: "Urunler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kullanicilar_Yetkiler_YetkilerId",
                        column: x => x.YetkilerId,
                        principalTable: "Yetkiler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Musteriler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriAdi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MusteriSoyadi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MusteriCinsiyet = table.Column<bool>(type: "bit", maxLength: 10, nullable: false),
                    MusteriTelefon = table.Column<double>(type: "float", maxLength: 20, nullable: false),
                    MusteriDogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KullanicilarId = table.Column<int>(type: "int", nullable: true),
                    AktifMi = table.Column<bool>(type: "bit", nullable: false),
                    EklemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteriler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Musteriler_Kullanicilar_KullanicilarId",
                        column: x => x.KullanicilarId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Siparisler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kodu = table.Column<int>(type: "int", nullable: false),
                    OdemeBilgileri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KullanicilarId = table.Column<int>(type: "int", nullable: true),
                    AktifMi = table.Column<bool>(type: "bit", nullable: false),
                    EklemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Siparisler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Siparisler_Kullanicilar_KullanicilarId",
                        column: x => x.KullanicilarId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Yorumlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Yorum = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    UstYorumId = table.Column<int>(type: "int", nullable: false),
                    AktifMi = table.Column<bool>(type: "bit", nullable: false),
                    EklemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yorumlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Yorumlar_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Yorumlar_Urunler_Id",
                        column: x => x.Id,
                        principalTable: "Urunler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Adresler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdresBasligi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PostaKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MusteriId = table.Column<int>(type: "int", nullable: false),
                    IlKodu = table.Column<int>(type: "int", nullable: false),
                    IlceKodu = table.Column<int>(type: "int", nullable: false),
                    IllerIlKodu = table.Column<int>(type: "int", nullable: true),
                    IlcelerIlceKodu = table.Column<int>(type: "int", nullable: true),
                    AktifMi = table.Column<bool>(type: "bit", nullable: false),
                    EklemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adresler_Ilceler_IlcelerIlceKodu",
                        column: x => x.IlcelerIlceKodu,
                        principalTable: "Ilceler",
                        principalColumn: "IlceKodu");
                    table.ForeignKey(
                        name: "FK_Adresler_Iller_IllerIlKodu",
                        column: x => x.IllerIlKodu,
                        principalTable: "Iller",
                        principalColumn: "IlKodu");
                    table.ForeignKey(
                        name: "FK_Adresler_Musteriler_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "Musteriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ErisimAlanlari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlanAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ControllerAdi = table.Column<bool>(type: "bit", nullable: false),
                    ControllerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YetkiErisimId = table.Column<int>(type: "int", nullable: true),
                    YetkilerId = table.Column<int>(type: "int", nullable: true),
                    MusterilerId = table.Column<int>(type: "int", nullable: true),
                    AktifMi = table.Column<bool>(type: "bit", nullable: false),
                    EklemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErisimAlanlari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ErisimAlanlari_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ErisimAlanlari_Musteriler_MusterilerId",
                        column: x => x.MusterilerId,
                        principalTable: "Musteriler",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ErisimAlanlari_YetkiErisim_YetkiErisimId",
                        column: x => x.YetkiErisimId,
                        principalTable: "YetkiErisim",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ErisimAlanlari_Yetkiler_YetkilerId",
                        column: x => x.YetkilerId,
                        principalTable: "Yetkiler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MusterilerSiparisler",
                columns: table => new
                {
                    MusterilerId = table.Column<int>(type: "int", nullable: false),
                    SiparislerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusterilerSiparisler", x => new { x.MusterilerId, x.SiparislerId });
                    table.ForeignKey(
                        name: "FK_MusterilerSiparisler_Musteriler_MusterilerId",
                        column: x => x.MusterilerId,
                        principalTable: "Musteriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MusterilerSiparisler_Siparisler_SiparislerId",
                        column: x => x.SiparislerId,
                        principalTable: "Siparisler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Iletisim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IletisimAdres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IletisimNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IletisimMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MusterilerId = table.Column<int>(type: "int", nullable: true),
                    AdreslerId = table.Column<int>(type: "int", nullable: true),
                    ErisimAlanlariId = table.Column<int>(type: "int", nullable: true),
                    AktifMi = table.Column<bool>(type: "bit", nullable: false),
                    EklemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iletisim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Iletisim_Adresler_AdreslerId",
                        column: x => x.AdreslerId,
                        principalTable: "Adresler",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Iletisim_ErisimAlanlari_ErisimAlanlariId",
                        column: x => x.ErisimAlanlariId,
                        principalTable: "ErisimAlanlari",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Iletisim_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Iletisim_Musteriler_MusterilerId",
                        column: x => x.MusterilerId,
                        principalTable: "Musteriler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adresler_IlcelerIlceKodu",
                table: "Adresler",
                column: "IlcelerIlceKodu");

            migrationBuilder.CreateIndex(
                name: "IX_Adresler_IllerIlKodu",
                table: "Adresler",
                column: "IllerIlKodu");

            migrationBuilder.CreateIndex(
                name: "IX_Adresler_MusteriId",
                table: "Adresler",
                column: "MusteriId");

            migrationBuilder.CreateIndex(
                name: "IX_ErisimAlanlari_KullaniciId",
                table: "ErisimAlanlari",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_ErisimAlanlari_MusterilerId",
                table: "ErisimAlanlari",
                column: "MusterilerId");

            migrationBuilder.CreateIndex(
                name: "IX_ErisimAlanlari_YetkiErisimId",
                table: "ErisimAlanlari",
                column: "YetkiErisimId");

            migrationBuilder.CreateIndex(
                name: "IX_ErisimAlanlari_YetkilerId",
                table: "ErisimAlanlari",
                column: "YetkilerId");

            migrationBuilder.CreateIndex(
                name: "IX_Iletisim_AdreslerId",
                table: "Iletisim",
                column: "AdreslerId");

            migrationBuilder.CreateIndex(
                name: "IX_Iletisim_ErisimAlanlariId",
                table: "Iletisim",
                column: "ErisimAlanlariId");

            migrationBuilder.CreateIndex(
                name: "IX_Iletisim_KullaniciId",
                table: "Iletisim",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_Iletisim_MusterilerId",
                table: "Iletisim",
                column: "MusterilerId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicilar_UrunlerId",
                table: "Kullanicilar",
                column: "UrunlerId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicilar_YetkilerId",
                table: "Kullanicilar",
                column: "YetkilerId");

            migrationBuilder.CreateIndex(
                name: "IX_Menuler_KategorilerId",
                table: "Menuler",
                column: "KategorilerId");

            migrationBuilder.CreateIndex(
                name: "IX_Menuler_UrunlerId",
                table: "Menuler",
                column: "UrunlerId");

            migrationBuilder.CreateIndex(
                name: "IX_Musteriler_KullanicilarId",
                table: "Musteriler",
                column: "KullanicilarId");

            migrationBuilder.CreateIndex(
                name: "IX_MusterilerSiparisler_SiparislerId",
                table: "MusterilerSiparisler",
                column: "SiparislerId");

            migrationBuilder.CreateIndex(
                name: "IX_Resimler_UrunId",
                table: "Resimler",
                column: "UrunId");

            migrationBuilder.CreateIndex(
                name: "IX_Siparisler_KullanicilarId",
                table: "Siparisler",
                column: "KullanicilarId");

            migrationBuilder.CreateIndex(
                name: "IX_YetkiErisim_YetkiErisimId",
                table: "YetkiErisim",
                column: "YetkiErisimId");

            migrationBuilder.CreateIndex(
                name: "IX_Yetkiler_YetkiErisimId",
                table: "Yetkiler",
                column: "YetkiErisimId");

            migrationBuilder.CreateIndex(
                name: "IX_Yorumlar_KullaniciId",
                table: "Yorumlar",
                column: "KullaniciId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Iletisim");

            migrationBuilder.DropTable(
                name: "Menuler");

            migrationBuilder.DropTable(
                name: "MusterilerSiparisler");

            migrationBuilder.DropTable(
                name: "Resimler");

            migrationBuilder.DropTable(
                name: "Yorumlar");

            migrationBuilder.DropTable(
                name: "Adresler");

            migrationBuilder.DropTable(
                name: "ErisimAlanlari");

            migrationBuilder.DropTable(
                name: "Siparisler");

            migrationBuilder.DropTable(
                name: "Musteriler");

            migrationBuilder.DropTable(
                name: "Kullanicilar");

            migrationBuilder.DropTable(
                name: "Yetkiler");

            migrationBuilder.DropTable(
                name: "YetkiErisim");

            migrationBuilder.DropColumn(
                name: "AktifMi",
                table: "Iller");

            migrationBuilder.DropColumn(
                name: "EklemeTarihi",
                table: "Iller");

            migrationBuilder.DropColumn(
                name: "GuncellemeTarihi",
                table: "Iller");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Iller");

            migrationBuilder.DropColumn(
                name: "KullaniciId",
                table: "Iller");

            migrationBuilder.DropColumn(
                name: "AktifMi",
                table: "Ilceler");

            migrationBuilder.DropColumn(
                name: "EklemeTarihi",
                table: "Ilceler");

            migrationBuilder.DropColumn(
                name: "GuncellemeTarihi",
                table: "Ilceler");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Ilceler");

            migrationBuilder.DropColumn(
                name: "KullaniciId",
                table: "Ilceler");

            migrationBuilder.RenameColumn(
                name: "KullaniciId",
                table: "Urunler",
                newName: "KulaniciId");

            migrationBuilder.RenameColumn(
                name: "KullaniciId",
                table: "Kategoriler",
                newName: "KulaniciId");
        }
    }
}
