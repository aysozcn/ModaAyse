using Microsoft.EntityFrameworkCore;
using ModaAyse.Core.ModaAyseDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModaAyse.Repository
{
	internal class AppDbContext: DbContext
	{

		public AppDbContext(DbContextOptions<AppDbContext> options):base(options)//db context option olarak benim db me bu özellikleri ver "kalıtımdb"
		{
				
		}
		public DbSet<Urunler> Urunler {  get; set; }
		public DbSet<Kategoriler> Kategoriler { get; set; }
		public DbSet<Adresler> Adresler { get; set; }
		public DbSet<Iller> Iller{ get; set; }
		public DbSet<Ilceler> Ilceler { get; set; }
		public DbSet<Kullanicilar> Kullanicilar { get; set; }
		public DbSet<Musteriler> Musteriler { get; set; }
		public DbSet<Menuler> Menuler{ get; set; }
		public DbSet<Makaleler> Makaleler { get; set; }
		public DbSet<MakaleKategorileri> MakaleKategorileri { get; set; }
		public DbSet<Personeller> Personeller{ get; set; }
		public DbSet<Resimler> Resimler { get; set; }
		public DbSet<SiparisDetay> SiparisDetay { get; set; }
		public DbSet<Siparisler> Siparisler { get; set; }
		public DbSet<Tedarikciler> Tedaikciler{ get; set; }
		public DbSet<Yazarlar> Yazarlar { get; set; }
		public DbSet<YetkiErisim> YetkiErisim { get; set; }
		public DbSet<Yetkiler> Yetkiler { get; set; }
		public DbSet<Yorumlar> Yorumlar { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}

		//model builder: orn:urunler tablosundan key diye tanımladığım yeri configuration bölümünde yaptım.
		//modelBuilder.Entity<Urunler>().HasKey(k => k.UrunlerId); deki yer!!

	}
}
