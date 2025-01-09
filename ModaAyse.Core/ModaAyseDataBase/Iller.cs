using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModaAyse.Core.ModaAyseDataBase
{
	public class Iller:BaseEntity
	{
		public int IlKodu { get; set; }
		public string IlAdi { get; set; }

		public ICollection<Ilceler>Ilceler {get; set;}

	}
}
