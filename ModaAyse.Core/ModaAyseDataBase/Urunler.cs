using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModaAyse.Core.ModaAyseDataBase
{
	public class Urunler:BaseEntity
	{
		public Urunler() //bağlantıları burada yaptım
		{
			



		}
		public virtual Kategoriler Kategoriler { get; set; }

	}
}
