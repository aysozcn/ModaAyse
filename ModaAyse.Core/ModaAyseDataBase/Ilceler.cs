using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModaAyse.Core.ModaAyseDataBase
{
	public class Ilceler:BaseEntity
	{
		public int IlceKodu { get; set; }
		public int IlKodu { get; set; }
		public string IlceAdi { get; set; }
		public Iller Iller  { get; set; }
		

	}
}
