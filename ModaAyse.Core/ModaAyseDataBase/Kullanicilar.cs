using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModaAyse.Core.ModaAyseDataBase
{
	public class Kullanicilar:BaseEntity
	{
		public string Adi { get; set; }
		public string Soyadi { get; set; }
		public int KullaniciSifre { get; set; }
		public string KullaniciMail { get; set; }
		public string KullaniciTelefon { get; set; }
		public string KullaniciAdres { get; set; }
		public bool KullaniciResim { get; set; }


		public int YetkiId { get; set; }
		public Yetkiler Yetkiler { get; set; }
		public ICollection<Yorumlar> Yorumlar { get; set; }
		public ICollection<Siparisler>Siparisler { get; set; }
		public ICollection<Iletisim>Iletisim { get; set; }
		public ICollection<ErisimAlanlari>ErisimAlanlari { get; set; }


		public int UrunlerId { get; set; }
		public Urunler Urunler { get; set; }
		//public IEnumerable <Musteriler> Musteriler { get; set; }





	}
}
