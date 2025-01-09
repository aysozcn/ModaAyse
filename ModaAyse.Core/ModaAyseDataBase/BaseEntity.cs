using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModaAyse.Core.ModaAyseDataBase
{
	public abstract class BaseEntity
	{
		public int Id { get; set; }
		public bool AktifMi { get; set; }
		public DateTime EklemeTarihi { get; set; }
		public DateTime? GuncellemeTarihi { get; set; }
		
		public int KullaniciId { get; set; }
	}
}
