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
	public class AdreslerConfiguration : IEntityTypeConfiguration<Adresler>
	{
		public void Configure(EntityTypeBuilder<Adresler> builder)
		{
			builder.HasKey(a => a.Id);
			builder.Property(a => a.Id).UseIdentityColumn();
			builder.Property(a => a.AdresBasligi).IsRequired();
			builder.Property(a => a.Adres).IsRequired().HasMaxLength(100);
			builder.Property(a => a.PostaKodu).IsRequired();
			builder.HasOne(a => a.Musteriler).WithMany(m => m.Adresler).HasForeignKey(a => a.MusteriId);



		}
	}
}
