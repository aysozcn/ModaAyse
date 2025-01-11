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
	public class BaseConfiguraton : IEntityTypeConfiguration<BaseEntity>
	{
		public void Configure(EntityTypeBuilder<BaseEntity> builder)
		{
			builder.HasKey(b => b.Id);
			builder.Property(b => b.Id).IsRequired();
		}
	}
}
