using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModaAyse.Core.ModaAyseDataBase
{
	public class Iletisim:BaseEntity
	{
		public string IletisimAdres { get; set; }
		public string IletisimNo { get; set; }
		public string IletisimMail { get; set; }
		public Musteriler Musteriler { get; set; }
		public Adresler Adresler { get; set; }
		public Kullanicilar Kullanicilar { get; set; }
		public ErisimAlanlari ErisimAlanlari { get; set; }

	}
}
