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
	public class MenuConfiguration : IEntityTypeConfiguration<Menuler>
	{
		public void Configure(EntityTypeBuilder<Menuler> builder)
		{
			builder.HasKey(m => m.Id);
			builder.Property(m => m.Id).UseIdentityColumn();
			builder.Property(m => m.MenuAdi).IsRequired();
			//builder.HasOne(m => m.Kategoriler).WithMany(m => m.Menuler).HasForeignKey(m => m.Kategoriler);
		}
	}
}
