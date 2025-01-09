using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModaAyse.Core.ModaAyseDataBase
{
	public class Kategoriler:BaseEntity
	{
		public string KategoriAdi { get; set; }
		public string Aciklama { get; set; }
		public ICollection<Urunler> Urunler  { get; set; }
		public ICollection<Menuler> Menuler { get; set; }
	}
}
