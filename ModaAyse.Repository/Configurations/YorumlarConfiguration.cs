using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client;
using ModaAyse.Core.ModaAyseDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModaAyse.Repository.Configurations
{
	public class YorumlarConfiguration : IEntityTypeConfiguration<Yorumlar>
	{
		public void Configure(EntityTypeBuilder<Yorumlar> builder)
		{
			builder.HasKey(y => y.Id);
			builder.Property(y=>y.Id).UseIdentityColumn();
			builder.Property(y => y.Yorum).IsRequired().HasMaxLength(250);
			builder.Property(y => y.EklemeTarihi).IsRequired(true);
			builder.Property(y => y.UstYorumId).IsRequired();
			builder.Property(k => k.UrunId).IsRequired(true).HasColumnType("decimal(18,2");
			//builder.HasOne(y => y.Kullanicilar).WithMany(y => y.Yorumlar).HasForeignKey(y => y.KullaniciId);
			builder.HasOne(y => y.Urunler).WithMany(y=>y.Yorumlar).HasForeignKey(y => y.UrunId);

			
		}
	}
}
