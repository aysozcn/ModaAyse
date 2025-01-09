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
			builder.HasKey(k => k.Id);
			builder.Property(k=>k.Id).UseIdentityColumn();
			builder.Property(k => k.Yorum).IsRequired().HasMaxLength(250);
			builder.Property(k => k.EklemeTarihi).IsRequired(true);
			builder.Property(k => k.UstYorumId).IsRequired();
			//builder.HasOne(k => k.Kullanicilar).WithMany(k => k.Yorumlar).HasForeignKey(k => k.Kullanicilar);
			//builder.HasOne(k => k.Urunler).WithMany(k=>k.Yorumlar).HasForeignKey(k => k.Urunler);

			
		}
	}
}
