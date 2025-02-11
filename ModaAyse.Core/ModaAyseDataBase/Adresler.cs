﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModaAyse.Core.ModaAyseDataBase
{
	public class Adresler:BaseEntity
	{
		public string AdresBasligi {  get; set; }
		public string Adres {  get; set; }
		public string PostaKodu { get; set; }
		public int MusteriId { get; set; }
		public int IlKodu { get; set; }
		public int IlceKodu { get; set; }
		public Iller Iller { get; set; }
		public Ilceler Ilceler { get; set; }
		public Musteriler Musteriler { get; set; }
	}
}
