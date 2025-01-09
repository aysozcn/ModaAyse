using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModaAyse.Core.ModaAyseDataBase
{
	public class Musteriler:BaseEntity
	{
		public string MusteriAdi {  get; set; }
		public string MusteriSoyadi { get; set; }
		public bool MusteriCinsiyet { get; set; }
		public double MusteriTelefon {  get; set; }
		public DateTime MusteriDogumTarihi { get; set; }
		//public int KullaniciId { get; set; }

		public Kullanicilar Kullanicilar { get; set; }
		public IEnumerable<Adresler> Adresler { get; set; }	
		public IEnumerable<Siparisler> Siparisler { get; set; }




	}
}
