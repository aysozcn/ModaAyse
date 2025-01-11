using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModaAyse.Core.ModaAyseDataBase
{
	public class ErisimAlanlari:BaseEntity
	{
		public string AlanAdi {  get; set; }
		public bool ControllerAdi { get; set; }
		public string ControllerName { get; set; }
		public string Aciklama { get; set; }
		public Kullanicilar Kullanicilar { get; set; }
		public YetkiErisim YetkiErisim { get; set; }
		public Yetkiler Yetkiler { get; set; }
		public Musteriler Musteriler { get; set; }
		public Menuler Menuler { get; set; }	

	}
}
