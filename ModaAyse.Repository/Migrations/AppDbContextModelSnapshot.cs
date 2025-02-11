﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ModaAyse.Repository;

#nullable disable

namespace ModaAyse.Repository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ModaAyse.Core.ModaAyseDataBase.Adresler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("AdresBasligi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("AktifMi")
                        .HasColumnType("bit");

                    b.Property<DateTime>("EklemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("IlKodu")
                        .HasColumnType("int");

                    b.Property<int>("IlceKodu")
                        .HasColumnType("int");

                    b.Property<int?>("IlcelerIlceKodu")
                        .HasColumnType("int");

                    b.Property<int?>("IllerIlKodu")
                        .HasColumnType("int");

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.Property<int>("MusteriId")
                        .HasColumnType("int");

                    b.Property<string>("PostaKodu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IlcelerIlceKodu");

                    b.HasIndex("IllerIlKodu");

                    b.HasIndex("MusteriId");

                    b.ToTable("Adresler");
                });

            modelBuilder.Entity("ModaAyse.Core.ModaAyseDataBase.ErisimAlanlari", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("AktifMi")
                        .HasColumnType("bit");

                    b.Property<string>("AlanAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ControllerAdi")
                        .HasColumnType("bit");

                    b.Property<string>("ControllerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EklemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.Property<int?>("MusterilerId")
                        .HasColumnType("int");

                    b.Property<int?>("YetkiErisimId")
                        .HasColumnType("int");

                    b.Property<int?>("YetkilerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KullaniciId");

                    b.HasIndex("MusterilerId");

                    b.HasIndex("YetkiErisimId");

                    b.HasIndex("YetkilerId");

                    b.ToTable("ErisimAlanlari");
                });

            modelBuilder.Entity("ModaAyse.Core.ModaAyseDataBase.Ilceler", b =>
                {
                    b.Property<int>("IlceKodu")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(128)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IlceKodu"));

                    b.Property<bool>("AktifMi")
                        .HasColumnType("bit");

                    b.Property<DateTime>("EklemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("IlKodu")
                        .HasColumnType("int");

                    b.Property<string>("IlceAdi")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.HasKey("IlceKodu");

                    b.HasIndex("IlKodu");

                    b.ToTable("Ilceler");
                });

            modelBuilder.Entity("ModaAyse.Core.ModaAyseDataBase.Iletisim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AdreslerId")
                        .HasColumnType("int");

                    b.Property<bool>("AktifMi")
                        .HasColumnType("bit");

                    b.Property<DateTime>("EklemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ErisimAlanlariId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("IletisimAdres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IletisimMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IletisimNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.Property<int?>("MusterilerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdreslerId");

                    b.HasIndex("ErisimAlanlariId");

                    b.HasIndex("KullaniciId");

                    b.HasIndex("MusterilerId");

                    b.ToTable("Iletisim");
                });

            modelBuilder.Entity("ModaAyse.Core.ModaAyseDataBase.Iller", b =>
                {
                    b.Property<int>("IlKodu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IlKodu"));

                    b.Property<bool>("AktifMi")
                        .HasColumnType("bit");

                    b.Property<DateTime>("EklemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("IlAdi")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.HasKey("IlKodu");

                    b.ToTable("Iller");
                });

            modelBuilder.Entity("ModaAyse.Core.ModaAyseDataBase.Kategoriler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("AktifMi")
                        .HasColumnType("bit");

                    b.Property<DateTime>("EklemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("KategoriAdi")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Kategoriler");
                });

            modelBuilder.Entity("ModaAyse.Core.ModaAyseDataBase.Kullanicilar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("AktifMi")
                        .HasColumnType("bit");

                    b.Property<DateTime>("EklemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("KullaniciAdres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.Property<string>("KullaniciMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("KullaniciResim")
                        .HasColumnType("bit");

                    b.Property<int>("KullaniciSifre")
                        .HasColumnType("int");

                    b.Property<string>("KullaniciTelefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyadi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UrunlerId")
                        .HasColumnType("int");

                    b.Property<int>("YetkiId")
                        .HasColumnType("int");

                    b.Property<int?>("YetkilerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UrunlerId");

                    b.HasIndex("YetkilerId");

                    b.ToTable("Kullanicilar");
                });

            modelBuilder.Entity("ModaAyse.Core.ModaAyseDataBase.Menuler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("AktifMi")
                        .HasColumnType("bit");

                    b.Property<DateTime>("EklemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int?>("KategorilerId")
                        .HasColumnType("int");

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.Property<string>("MenuAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MenuKatekori")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UrunlerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KategorilerId");

                    b.HasIndex("UrunlerId");

                    b.ToTable("Menuler");
                });

            modelBuilder.Entity("ModaAyse.Core.ModaAyseDataBase.Musteriler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("AktifMi")
                        .HasColumnType("bit");

                    b.Property<DateTime>("EklemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.Property<int?>("KullanicilarId")
                        .HasColumnType("int");

                    b.Property<string>("MusteriAdi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("MusteriCinsiyet")
                        .HasMaxLength(10)
                        .HasColumnType("bit");

                    b.Property<DateTime>("MusteriDogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("MusteriSoyadi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("MusteriTelefon")
                        .HasMaxLength(20)
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("KullanicilarId");

                    b.ToTable("Musteriler");
                });

            modelBuilder.Entity("ModaAyse.Core.ModaAyseDataBase.Resimler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("AktifMi")
                        .HasColumnType("bit");

                    b.Property<DateTime>("EklemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.Property<string>("ResimAciklamasi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResimSirasi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ResimTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("ResimYolu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UrunId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UrunId");

                    b.ToTable("Resimler");
                });

            modelBuilder.Entity("ModaAyse.Core.ModaAyseDataBase.Siparisler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("AktifMi")
                        .HasColumnType("bit");

                    b.Property<DateTime>("EklemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("Kodu")
                        .HasColumnType("int");

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.Property<int?>("KullanicilarId")
                        .HasColumnType("int");

                    b.Property<string>("OdemeBilgileri")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KullanicilarId");

                    b.ToTable("Siparisler");
                });

            modelBuilder.Entity("ModaAyse.Core.ModaAyseDataBase.Urunler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("AktifMi")
                        .HasColumnType("bit");

                    b.Property<DateTime>("EklemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.Property<string>("UrunAdi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("UrunFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UrunStok")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.ToTable("Urunler");
                });

            modelBuilder.Entity("ModaAyse.Core.ModaAyseDataBase.YetkiErisim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("AktifMi")
                        .HasColumnType("bit");

                    b.Property<DateTime>("EklemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.Property<int?>("YetkiErisimId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("YetkiErisimId");

                    b.ToTable("YetkiErisim");
                });

            modelBuilder.Entity("ModaAyse.Core.ModaAyseDataBase.Yetkiler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("AktifMi")
                        .HasColumnType("bit");

                    b.Property<DateTime>("EklemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.Property<string>("YerkiAdi")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("YetkiErisimId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("YetkiErisimId");

                    b.ToTable("Yetkiler");
                });

            modelBuilder.Entity("ModaAyse.Core.ModaAyseDataBase.Yorumlar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("AktifMi")
                        .HasColumnType("bit");

                    b.Property<DateTime>("EklemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.Property<int?>("KullanicilarId")
                        .HasColumnType("int");

                    b.Property<int?>("UrunlerId")
                        .HasColumnType("int");

                    b.Property<int>("UstYorumId")
                        .HasColumnType("int");

                    b.Property<string>("Yorum")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.HasIndex("KullanicilarId");

                    b.HasIndex("UrunlerId");

                    b.ToTable("Yorumlar");
                });

            modelBuilder.Entity("MusterilerSiparisler", b =>
                {
                    b.Property<int>("MusterilerId")
                        .HasColumnType("int");

                    b.Property<int>("SiparislerId")
                        .HasColumnType("int");

                    b.HasKey("MusterilerId", "SiparislerId");

                    b.HasIndex("SiparislerId");

                    b.ToTable("MusterilerSiparisler");
                });

            modelBuilder.Entity("ModaAyse.Core.ModaAyseDataBase.Adresler", b =>
                {
                    b.HasOne("ModaAyse.Core.ModaAyseDataBase.Ilceler", "Ilceler")
                        .WithMany()
                        .HasForeignKey("IlcelerIlceKodu");

                    b.HasOne("ModaAyse.Core.ModaAyseDataBase.Iller", "Iller")
                        .WithMany()
                        .HasForeignKey("IllerIlKodu");

                    b.HasOne("ModaAyse.Core.ModaAyseDataBase.Musteriler", "Musteriler")
                        .WithMany("Adresler")
                        .HasForeignKey("MusteriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ilceler");

                    b.Navigation("Iller");

                    b.Navigation("Musteriler");
                });

            modelBuilder.Entity("ModaAyse.Core.ModaAyseDataBase.ErisimAlanlari", b =>
                {
                    b.HasOne("ModaAyse.Core.ModaAyseDataBase.Kullanicilar", "Kullanicilar")
                        .WithMany("ErisimAlanlari")
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ModaAyse.Core.ModaAyseDataBase.Musteriler", "Musteriler")
                        .WithMany()
                        .HasForeignKey("MusterilerId");

                    b.HasOne("ModaAyse.Core.ModaAyseDataBase.YetkiErisim", "YetkiErisim")
                        .WithMany()
                        .HasForeignKey("YetkiErisimId");

                    b.HasOne("ModaAyse.Core.ModaAyseDataBase.Yetkiler", "Yetkiler")
                        .WithMany()
                        .HasForeignKey("YetkilerId");

                    b.Navigation("Kullanicilar");

                    b.Navigation("Musteriler");

                    b.Navigation("YetkiErisim");

                    b.Navigation("Yetkiler");
                });

            modelBuilder.Entity("ModaAyse.Core.ModaAyseDataBase.Ilceler", b =>
                {
                    b.HasOne("ModaAyse.Core.ModaAyseDataBase.Iller", "Iller")
                        .WithMany("Ilceler")
                        .HasForeignKey("IlKodu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Iller");
                });

            modelBuilder.Entity("ModaAyse.Core.ModaAyseDataBase.Iletisim", b =>
                {
                    b.HasOne("ModaAyse.Core.ModaAyseDataBase.Adresler", "Adresler")
                        .WithMany()
                        .HasForeignKey("AdreslerId");

                    b.HasOne("ModaAyse.Core.ModaAyseDataBase.ErisimAlanlari", "ErisimAlanlari")
                        .WithMany()
                        .HasForeignKey("ErisimAlanlariId");

                    b.HasOne("ModaAyse.Core.ModaAyseDataBase.Kullanicilar", "Kullanicilar")
                        .WithMany("Iletisim")
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ModaAyse.Core.ModaAyseDataBase.Musteriler", "Musteriler")
                        .WithMany()
                        .HasForeignKey("MusterilerId");

                    b.Navigation("Adresler");

                    b.Navigation("ErisimAlanlari");

                    b.Navigation("Kullanicilar");

                    b.Navigation("Musteriler");
                });

            modelBuilder.Entity("ModaAyse.Core.ModaAyseDataBase.Kullanicilar", b =>
                {
                    b.HasOne("ModaAyse.Core.ModaAyseDataBase.Urunler", "Urunler")
                        .WithMany()
                        .HasForeignKey("UrunlerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ModaAyse.Core.ModaAyseDataBase.Yetkiler", "Yetkiler")
                        .WithMany("KullaniciID")
                        .HasForeignKey("YetkilerId");

                    b.Navigation("Urunler");

                    b.Navigation("Yetkiler");
                });

            modelBuilder.Entity("ModaAyse.Core.ModaAyseDataBase.Menuler", b =>
                {
                    b.HasOne("ModaAyse.Core.ModaAyseDataBase.Kategoriler", null)
                        .WithMany("Menuler")
                        .HasForeignKey("KategorilerId");

                    b.HasOne("ModaAyse.Core.ModaAyseDataBase.Urunler", "Urunler")
                        .WithMany()
                        .HasForeignKey("UrunlerId");

                    b.Navigation("Urunler");
                });

            modelBuilder.Entity("ModaAyse.Core.ModaAyseDataBase.Musteriler", b =>
                {
                    b.HasOne("ModaAyse.Core.ModaAyseDataBase.Kullanicilar", "Kullanicilar")
                        .WithMany()
                        .HasForeignKey("KullanicilarId");

                    b.Navigation("Kullanicilar");
                });

            modelBuilder.Entity("ModaAyse.Core.ModaAyseDataBase.Resimler", b =>
                {
                    b.HasOne("ModaAyse.Core.ModaAyseDataBase.Urunler", "Urunler")
                        .WithMany("Resimler")
                        .HasForeignKey("UrunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Urunler");
                });

            modelBuilder.Entity("ModaAyse.Core.ModaAyseDataBase.Siparisler", b =>
                {
                    b.HasOne("ModaAyse.Core.ModaAyseDataBase.Kullanicilar", "Kullanicilar")
                        .WithMany("Siparisler")
                        .HasForeignKey("KullanicilarId");

                    b.Navigation("Kullanicilar");
                });

            modelBuilder.Entity("ModaAyse.Core.ModaAyseDataBase.Urunler", b =>
                {
                    b.HasOne("ModaAyse.Core.ModaAyseDataBase.Kategoriler", "Kategoriler")
                        .WithMany("Urunler")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategoriler");
                });

            modelBuilder.Entity("ModaAyse.Core.ModaAyseDataBase.YetkiErisim", b =>
                {
                    b.HasOne("ModaAyse.Core.ModaAyseDataBase.YetkiErisim", null)
                        .WithMany("Yetkierisim")
                        .HasForeignKey("YetkiErisimId");
                });

            modelBuilder.Entity("ModaAyse.Core.ModaAyseDataBase.Yetkiler", b =>
                {
                    b.HasOne("ModaAyse.Core.ModaAyseDataBase.YetkiErisim", null)
                        .WithMany("Yetkiler")
                        .HasForeignKey("YetkiErisimId");
                });

            modelBuilder.Entity("ModaAyse.Core.ModaAyseDataBase.Yorumlar", b =>
                {
                    b.HasOne("ModaAyse.Core.ModaAyseDataBase.Kullanicilar", "Kullanicilar")
                        .WithMany("Yorumlar")
                        .HasForeignKey("KullanicilarId");

                    b.HasOne("ModaAyse.Core.ModaAyseDataBase.Urunler", "Urunler")
                        .WithMany("Yorumlar")
                        .HasForeignKey("UrunlerId");

                    b.Navigation("Kullanicilar");

                    b.Navigation("Urunler");
                });

            modelBuilder.Entity("MusterilerSiparisler", b =>
                {
                    b.HasOne("ModaAyse.Core.ModaAyseDataBase.Musteriler", null)
                        .WithMany()
                        .HasForeignKey("MusterilerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ModaAyse.Core.ModaAyseDataBase.Siparisler", null)
                        .WithMany()
                        .HasForeignKey("SiparislerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ModaAyse.Core.ModaAyseDataBase.Iller", b =>
                {
                    b.Navigation("Ilceler");
                });

            modelBuilder.Entity("ModaAyse.Core.ModaAyseDataBase.Kategoriler", b =>
                {
                    b.Navigation("Menuler");

                    b.Navigation("Urunler");
                });

            modelBuilder.Entity("ModaAyse.Core.ModaAyseDataBase.Kullanicilar", b =>
                {
                    b.Navigation("ErisimAlanlari");

                    b.Navigation("Iletisim");

                    b.Navigation("Siparisler");

                    b.Navigation("Yorumlar");
                });

            modelBuilder.Entity("ModaAyse.Core.ModaAyseDataBase.Musteriler", b =>
                {
                    b.Navigation("Adresler");
                });

            modelBuilder.Entity("ModaAyse.Core.ModaAyseDataBase.Urunler", b =>
                {
                    b.Navigation("Resimler");

                    b.Navigation("Yorumlar");
                });

            modelBuilder.Entity("ModaAyse.Core.ModaAyseDataBase.YetkiErisim", b =>
                {
                    b.Navigation("Yetkierisim");

                    b.Navigation("Yetkiler");
                });

            modelBuilder.Entity("ModaAyse.Core.ModaAyseDataBase.Yetkiler", b =>
                {
                    b.Navigation("KullaniciID");
                });
#pragma warning restore 612, 618
        }
    }
}
