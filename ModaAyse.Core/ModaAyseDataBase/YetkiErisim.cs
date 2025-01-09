using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModaAyse.Core.ModaAyseDataBase
{
	public class YetkiErisim:BaseEntity
	{
		public string Aciklama { get; set; }
		public ICollection<Yetkiler>Yetkiler { get; set; }
		public ICollection<YetkiErisim> Yetkierisim { get; set; }

	}
}
