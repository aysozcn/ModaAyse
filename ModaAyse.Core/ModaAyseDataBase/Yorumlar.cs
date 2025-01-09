using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModaAyse.Core.ModaAyseDataBase
{
	public class Yorumlar:BaseEntity
	{
		public string Yorum { get; set; }
		public int UstYorumId { get; set; }
		public Urunler Urunler { get; set; }
		public  Kullanicilar Kullanicilar { get; set; }


		

	}
}
