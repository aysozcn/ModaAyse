﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModaAyse.Core.ModaAyseDataBase
{
	public class Yetkiler:BaseEntity
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		
		public string YerkiAdi{ get; set; }
		public virtual List<Kullanicilar> KullaniciID { get; set; }
		
	}
}
