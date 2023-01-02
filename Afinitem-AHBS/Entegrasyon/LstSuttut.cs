using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDeneme.Genel_Listeler
{
	public  class LstSuttut
	{
		public int kodu { get; set; }
		public string sut_kodu { get; set; }
		public string adi { get; set; }
		public float fiyat { get; set; }
		public float sut_fiyat { get; set; }
		public string lab_hizmet_kodu { get; set; }
		public string harici_eklenen { get; set; }
		public string grup { get; set; }
		public string eski_suttut_no { get; set; }
	}
}
