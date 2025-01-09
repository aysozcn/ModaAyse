using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModaAyse.Core.ModaAyseDataBase
{
	public class Siparisler:BaseEntity
	{
		public int Kodu { get; set; }
		public string OdemeBilgileri { get; set; }

		public Kullanicilar Kullanicilar { get; set; }
		public IEnumerable <Musteriler> Musteriler { get; set; }
		//public IEnumerable<Musteriler> Musteriler { get; set; }

	}
}
