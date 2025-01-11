using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModaAyse.Core.ModaAyseDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModaAyse.Repository.Configurations
{
	public class UrunlerConfiguration : IEntityTypeConfiguration<Urunler>
	{
		public void Configure(EntityTypeBuilder<Urunler> builder)
		{
			builder.HasKey(k => k.Id);
			builder.Property(k =>k.Id).UseIdentityColumn();
			builder.Property(k=>k.UrunAdi).IsRequired().HasMaxLength(100);
			builder.Property(k=>k.Aciklama).IsRequired(false);
			builder.Property(k => k.UrunFiyat).IsRequired(true).HasColumnType("decimal(18,2)");
			//urunler ile kategoriler arasında diyagram bağlantısı
			//builder.Property(k => k.YorumId).IsRequired(true);
			builder.HasOne(k => k.Kategoriler).WithMany(k=>k.Urunler).HasForeignKey(k=>k.KategoriId); //hasone bir üründe bir kategoıri bire sonsuz ürünlerde sonsuz
			


		}
	}
}
