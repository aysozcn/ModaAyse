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
	public class YetkilerConfiguration : IEntityTypeConfiguration<Yetkiler>
	{
		public void Configure(EntityTypeBuilder<Yetkiler> builder)
		{
			builder.HasKey(y=>y.Id);
			builder.Property(y =>y.Id).UseIdentityColumn();
			builder.Property(y => y.AktifMi).IsRequired();
			builder.Property(y =>y.YerkiAdi).IsRequired().HasMaxLength(100);
			
			
		}
	}
}
