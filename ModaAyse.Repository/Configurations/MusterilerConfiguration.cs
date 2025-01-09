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
	public class MusterilerConfiguration : IEntityTypeConfiguration<Musteriler>
	{
		public void Configure(EntityTypeBuilder<Musteriler> builder)
		{
			builder.HasKey(m => m.Id);
			builder.Property(m=>m.Id).UseIdentityColumn();
			builder.Property(m=>m.MusteriAdi).IsRequired().HasMaxLength(100);
			builder.Property(m=>m.MusteriSoyadi).IsRequired().HasMaxLength(100);
			builder.Property(m=>m.MusteriCinsiyet).IsRequired().HasMaxLength(10);
			builder.Property(m=>m.MusteriTelefon).IsRequired().HasMaxLength(20);
			builder.Property(m => m.MusteriDogumTarihi).IsRequired();
			//builder.HasOne(m=>m.Kullanicilar).WithOne(m => m.Musteriler).HasForeignKey<Kullanicilar>(k => k.KullaniciId);
			//builder.HasMany(m => m.Siparisler).WithMany(m => m.Musteriler).HasForeignKey<Siparisler>(m => m.Id);

		}
	}
}
