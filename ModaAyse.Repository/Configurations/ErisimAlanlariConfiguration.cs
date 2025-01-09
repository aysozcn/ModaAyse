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
	public class ErisimAlanlariConfiguration : IEntityTypeConfiguration<ErisimAlanlari>
	{
		public void Configure(EntityTypeBuilder<ErisimAlanlari> builder)
		{
			builder.HasKey(e => e.Id);
			builder.Property(e => e.Id).UseIdentityColumn();
			builder.Property(e => e.AktifMi).IsRequired();
			builder.Property(e => e.Aciklama).IsRequired(false);
			builder.HasOne(e => e.Kullanicilar).WithMany(e => e.ErisimAlanlari).HasForeignKey(e=> e.KullaniciId);

			
		}

	}
}
