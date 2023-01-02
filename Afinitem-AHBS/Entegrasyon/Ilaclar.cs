using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDeneme
{
	public class Ilaclar
	{
		public string ilac_kodu { get; set; }
		public string ad { get; set; }
		public string barkod { get; set; }
		public int recete_turu { get; set; }
		public List<string> etken_madde = new List<string>();
		public double fiyat { get; set; }
		public bool manuel_eklenmis_mi { get; set; }
		public bool sgk_aktif_mi { get; set; }
		public string atc_kodu { get; set; }
		public string atc_adi { get; set; }
		public string eski_skrs_ilac_no { get; set; }
		public string esdeger { get; set; }
		public float? ambalaj_birimi { get; set; }
		public float? ambalaj_miktari { get; set; }

		 
	}
}
