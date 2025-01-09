using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModaAyse.Core.ModaAyseDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModaAyse.Repository.Configurations
{
	public class YetkiErisimConfiguration : IEntityTypeConfiguration<YetkiErisim>
	{
		public void Configure(EntityTypeBuilder<YetkiErisim> builder)
		{
			builder.HasKey(y => y.Id);
			builder.Property(y => y.Id).UseIdentityColumn();
			builder.Property(y => y.AktifMi).IsRequired();
			builder.Property(y => y.Aciklama).IsRequired(false);







		}

	}
}
