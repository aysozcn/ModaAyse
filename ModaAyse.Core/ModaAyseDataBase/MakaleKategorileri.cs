using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModaAyse.Core.ModaAyseDataBase
{
	public class MakaleKategorileri
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int KategorilerID { get; set; }
		[StringLength(200),Required]
		public string KategoriAdi { get; set; }
		public string Aciklama { get; set; }
		public virtual List<Makaleler> Makaleler {  get; set; }
	}
}
