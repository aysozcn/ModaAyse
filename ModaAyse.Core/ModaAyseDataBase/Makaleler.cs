using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ModaAyse.Core.ModaAyseDataBase
{
	public class Makaleler
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int MakalelerID {  get; set; }
		[StringLength(100),Required]
		public string MakaleAdi { get; set; }
		public virtual List<Kategoriler> Kategoriler { get; set; }
	    public virtual List<Kullanicilar> KullanicilarID{ get; set; }

	}
}
