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
		public int UstMenuId { get; set; }
		public int MenuSirasi { get; set; }
		public int ErisimAlanlariId { get; set; }

		public Urunler Urunler { get; set; }
		public ICollection<Menuler>AltMenu { get; set; }
		public Menuler UstMenu { get; set; }
		public ErisimAlanlari ErisimAlanlari { get; set; }

	}
}
