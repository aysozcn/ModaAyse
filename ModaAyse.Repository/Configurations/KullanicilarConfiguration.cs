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
	public class KullanicilarConfiguration : IEntityTypeConfiguration<Kullanicilar>
	{
		public void Configure(EntityTypeBuilder<Kullanicilar> builder)
		{
			builder.HasKey(k => k.Id);
			builder.Property(k=>k.Id).UseIdentityColumn();
			builder.Property(k => k.Adi).IsRequired().HasMaxLength(100);
			builder.Property(k => k.Soyadi).IsRequired().HasMaxLength(100);
			builder.Property(k => k.KullaniciResim).IsRequired();
			builder.Property(k => k.KullaniciMail).IsRequired();
			builder.Property(k => k.KullaniciSifre).IsRequired();
			



		}
	}
}
