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
	public class IletisimConfiguration : IEntityTypeConfiguration<Iletisim>
	{
		public void Configure(EntityTypeBuilder<Iletisim> builder)
		{
			builder.HasKey(i => i.Id);
			builder.Property(i => i.Id).UseIdentityColumn();
			builder.Property(i => i.IletisimMail).IsRequired();
			builder.Property(i => i.IletisimAdres).IsRequired();
			builder.Property(i => i.IletisimNo).IsRequired();

			builder.HasOne(i => i.Kullanicilar).WithMany(i => i.Iletisim).HasForeignKey(i => i.KullaniciId);
		}
	}
}
