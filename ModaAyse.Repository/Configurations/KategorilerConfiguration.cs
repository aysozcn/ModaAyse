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
	public class KategorilerConfiguration : IEntityTypeConfiguration<Kategoriler>
	{
		public void Configure(EntityTypeBuilder<Kategoriler> builder)
		{
			builder.HasKey(k => k.Id);
			//builder.Property(k => k.Id).HasColumnName("KategoriId"); //baseEntity den alınan Id adını KategorilerId olarak db de tutar
			//builder.ToTable("Tbl_Kategoriler"); //Tablo adını db ye Tbl_Kategoriler isminde kayıt eder
			builder.Property(k=>k.Id).UseIdentityColumn();
			builder.Property(k=>k.Aciklama).IsRequired(false);
			builder.Property(k => k.KategoriAdi).IsRequired().HasMaxLength(100);





		}
	}
}
