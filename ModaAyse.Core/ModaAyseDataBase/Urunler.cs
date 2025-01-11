using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModaAyse.Core.ModaAyseDataBase
{
	public class Urunler:BaseEntity
	{
		
		public string UrunAdi { get; set; }
		public string Aciklama { get; set; }
		public string UrunStok { get; set; }
		public decimal UrunFiyat { get; set; }
		public int YorumId { get; set; }
		public int KategoriId { get; set; }
		public Kategoriler Kategoriler { get; set; }
		public IEnumerable<Yorumlar>Yorumlar { get; set; }
		public IEnumerable<Resimler> Resimler { get; set; }	
	}
}
