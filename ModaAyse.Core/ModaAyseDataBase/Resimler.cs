using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModaAyse.Core.ModaAyseDataBase
{
	public class Resimler:BaseEntity
	{
		public string ResimYolu{ get; set; }
		public byte ResimSirasi { get; set; }
		public string ResimAciklamasi { get; set; }
		public DateTime ResimTarihi { get; set; }
		public int UrunId { get; set; }
		public Urunler Urunler { get; set; }



	}
}
