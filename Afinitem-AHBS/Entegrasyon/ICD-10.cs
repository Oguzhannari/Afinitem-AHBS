using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDeneme
{
	public  class ICD_10
	{
		public int kod { get; set; }
		public string icd10_kodu { get; set; }
		public string icd10_adi { get; set; }
		public string ust_icd10_kodu { get; set; } 
		public int seviye { get; set; }
	}
}
