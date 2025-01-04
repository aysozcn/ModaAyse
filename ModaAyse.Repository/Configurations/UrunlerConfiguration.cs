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
	public class UrunlerConfiguration : IEntityTypeConfiguration<Urunler>
	{
		public void Configure(EntityTypeBuilder<Urunler> builder)
		{
			builder.HasKey(k => k.Id);
			builder.Property(k =>k.Id).UseIdentityColumn();
		}
	}
}
