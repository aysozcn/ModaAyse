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
	public class ResimlerConfiguration : IEntityTypeConfiguration<Resimler>
	{
		public void Configure(EntityTypeBuilder<Resimler> builder)
		{
			builder.HasKey(r => r.Id);
			builder.Property(r => r.Id).UseIdentityColumn();
			builder.Property(r => r.AktifMi).IsRequired(true);
			builder.Property(r => r.EklemeTarihi).IsRequired(true);
			builder.Property(r => r.GuncellemeTarihi).IsRequired();
			builder.Property(r => r.ResimYolu).IsRequired(true);
			builder.Property(r => r.ResimAciklamasi).IsRequired(true);
			builder.Property(r => r.ResimSirasi).IsRequired();
			builder.HasOne(r => r.Urunler).WithMany(r => r.Resimler).HasForeignKey(r => r.UrunId);
		}
	}
}
