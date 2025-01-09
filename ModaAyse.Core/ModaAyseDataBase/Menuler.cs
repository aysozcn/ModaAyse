using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModaAyse.Core.ModaAyseDataBase
{
	public class Menuler:BaseEntity
	{
		public string MenuAdi {  get; set; }
		public string MenuKatekori { get; set; }
		public Urunler Urunler { get; set; }
	}
}
