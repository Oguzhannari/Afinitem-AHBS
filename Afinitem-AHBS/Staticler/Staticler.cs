using Afinitem_AHBS.Entegrasyon;
using SqlDeneme.Genel_Listeler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDeneme
{
	public static class Staticler
	{
		public static List<Ilaclar> Ilac_lst { get; set; }
		public static List<ICD_10> Icd10_lst { get; set; }
        public static List<LstEgitimKurumlari> LstEgitimKurumlari { get; set; }

        public static List<Lst_zehirlenmeye_neden_olan_etken> Zehirlenmeye_neden_olan_etken_lst { get; set; }
		public static List<LstUlkeKodlari> Ulke_kodlari_lst { get; set; }
		public static List<LstTumorunYeri> Tumorun_yeri_lst { get; set; }
		public static List<LstSuttut> Suttut_lst { get; set; }
		public static List<LstOlasiVakaTaniKriteri> Olası_vaka_tani_kriter_lst { get; set; }
		public static List<LstIlceKodlari> Ilce_kodlari_lst { get; set; }





		#region Basit Listeler

		#endregion
		static Staticler()
		{
			Ilac_lst= new List<Ilaclar>();
			Icd10_lst= new List<ICD_10>();
			Zehirlenmeye_neden_olan_etken_lst = new List<Lst_zehirlenmeye_neden_olan_etken>();
			Ulke_kodlari_lst = new List<LstUlkeKodlari>();
			Tumorun_yeri_lst = new List<LstTumorunYeri>();
			Suttut_lst = new List<LstSuttut>();
			Olası_vaka_tani_kriter_lst = new List<LstOlasiVakaTaniKriteri>();
            LstEgitimKurumlari = new List<LstEgitimKurumlari>();

        }
	}
}
