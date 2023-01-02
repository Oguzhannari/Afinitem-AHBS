using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using SqlDeneme.Genel_Listeler;
using SqlDeneme;

namespace Apicop
{
	public class Sql
	{
		private string baglanti_string { get; set; }

		public Sql()
		{
			baglanti_string = "Data Source=DESKTOP-GLNRG3J\\SQLEXPRESS;Initial Catalog=TestDB;Integrated Security=True";
		}
		public DataTable Hastalar()
		{
			var dt_obj = new DataTable();
			var con = new SqlConnection(baglanti_string);
			string sorgu = "SELECT * from HRC_TERCIHLER";
			con.Open();

			var data_adapter = new SqlDataAdapter(sorgu, con);
			data_adapter.Fill(dt_obj);
			con.Close();
			return dt_obj;
		}

		public DataTable Hastalar2()
		{

			var dt_obj = new DataTable();
			var con = new SqlConnection(baglanti_string);
			var comm = new SqlCommand();
			string sorgu = "SELECT * from GP_HASTA_KAYIT WHERE Ad=@ad";
			con.Open();
			comm.Connection = con;
			comm.CommandText = sorgu;
			comm.Parameters.AddWithValue("ad", "KARDELEN");
			var da = new SqlDataAdapter(comm);
			da.Fill(dt_obj);
			comm.CommandType = CommandType.Text;
			comm.ExecuteReader();

			SqlDataReader reader = comm.ExecuteReader();
			

			con.Close();
			return dt_obj;
		}

		public bool Hastalar3()
		{

			var dt_obj = new DataTable();
			var con = new SqlConnection(baglanti_string);
			var comm = new SqlCommand();
			string sorgu = "SELECT * from HRC_TERCIHLER";
			con.Open();
			comm.Connection = con;
			comm.CommandText = sorgu;
			comm.Parameters.AddWithValue("ad", "KARDELEN");
			var da = new SqlDataAdapter(comm);
			da.Fill(dt_obj);
			comm.CommandType = CommandType.Text;


			SqlDataReader reader = comm.ExecuteReader();
			if (reader.HasRows)
			{
				while (reader.Read())
				{
					//Tercihler.varsayilan_barkod_yazici = reader.GetString(0);

				}
				return true;
			}
			else
				return false;
			con.Close();
			return true;
		}

		public bool liste_ekle_klasik(string tablo, string kod, string ad, string aktif)
		{
			var con = new SqlConnection(baglanti_string);
			var comm = new SqlCommand();
			string sorgu = "INSERT " + tablo +" (KODU, ADI, AKTIF) VALUES (@kod, @ad, @aktif)";
			con.Open();
			comm.Connection = con;
			comm.CommandText = sorgu;
			comm.Parameters.AddWithValue("kod", kod);
			comm.Parameters.AddWithValue("ad", ad);
			comm.Parameters.AddWithValue("aktif", aktif);
			try
			{
				comm.ExecuteNonQuery();
			}
			catch
			{
			}
			con.Close();
			return true;
		}

		public bool liste_guncelle_klasik(string tablo, string kod, string ad, string aktif)
		{
			var con = new SqlConnection(baglanti_string);
			var comm = new SqlCommand();
			string sorgu = "UPDATE " + tablo + " SET ADI=@ad, AKTIF=@aktif WHERE KODU=@kod";
			con.Open();
			comm.Connection = con;
			comm.CommandText = sorgu;
			comm.Parameters.AddWithValue("kod", kod);
			comm.Parameters.AddWithValue("ad", ad);
			comm.Parameters.AddWithValue("aktif", aktif);
			comm.ExecuteNonQuery();
			con.Close();
			return true;
		}

		
        #region Skrs Topla
        public bool ilaclari_topla()
        {

            var dt_obj = new DataTable();
            var con = new SqlConnection(baglanti_string);
            var comm = new SqlCommand();
            string sorgu = "SELECT * from LST_ILACLAR";
            con.Open();
            comm.Connection = con;
            comm.CommandText = sorgu;
            comm.CommandType = CommandType.Text;

            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (reader.GetBoolean(4))
                    {
                        Ilaclar ilac = new Ilaclar();

                        ilac.ilac_kodu = !reader.IsDBNull(0) ? reader.GetInt16(0).ToString() : "";
                        ilac.ad = !reader.IsDBNull(1) ? reader.GetString(1) : "";
                        ilac.barkod = !reader.IsDBNull(2) ? reader.GetInt64(2).ToString() : "";
                        ilac.recete_turu = !reader.IsDBNull(3) ? reader.GetByte(3) : -1;

                        if (!reader.IsDBNull(6))
                        {
                            string[] gecici = reader.GetString(6).Split(',');
                            if (gecici != null)
                            {
                                foreach (string kelime in gecici)
                                {

                                    ilac.etken_madde.Add(kelime);
                                }

                            }
                        }
                        ilac.fiyat = !reader.IsDBNull(7) ? Convert.ToDouble(reader[7]) : -1;
                        if (!reader.IsDBNull(8))
                            ilac.manuel_eklenmis_mi = reader.GetBoolean(8);
                        if (!reader.IsDBNull(9))
                            ilac.sgk_aktif_mi = reader.GetBoolean(9);
                        ilac.atc_kodu = !reader.IsDBNull(10) ? reader.GetString(10) : "";
                        ilac.atc_adi = !reader.IsDBNull(11) ? reader.GetString(11) : "";
                        ilac.eski_skrs_ilac_no = !reader.IsDBNull(12) ? reader.GetString(12) : "";
                        ilac.esdeger = !reader.IsDBNull(13) ? reader.GetString(13) : "";
                        ilac.ambalaj_birimi = !reader.IsDBNull(14) ? Convert.ToSingle(reader["AMBALAJ_BIRIMI"]) : -1;
                        ilac.ambalaj_miktari = !reader.IsDBNull(15) ? Convert.ToSingle(reader["AMBALAJ_MIKTAR"]) : -1;
                        Staticler.Ilac_lst.Add(ilac);
                    }

                }
                return true;
            }
            else
                return false;
            return true;
        }

        public bool icd10_topla()
        {

            var dt_obj = new DataTable();
            var con = new SqlConnection(baglanti_string);
            var comm = new SqlCommand();
            string sorgu = "SELECT * from LST_ICD10";
            con.Open();
            comm.Connection = con;
            comm.CommandText = sorgu;
            comm.CommandType = CommandType.Text;
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (reader.GetBoolean(5))
                    {
                        ICD_10 icd10 = new ICD_10();

                        icd10.kod = !reader.IsDBNull(0) ? reader.GetInt16(0) : -1;
                        icd10.icd10_kodu = !reader.IsDBNull(1) ? reader.GetString(1) : "";
                        icd10.icd10_adi = !reader.IsDBNull(2) ? reader.GetString(2) : "";
                        icd10.ust_icd10_kodu = !reader.IsDBNull(3) ? reader.GetString(3) : "";
                        //icd10.seviye = !reader.IsDBNull(4) ? reader.GetInt16(4) : -1;
                        Staticler.Icd10_lst.Add(icd10);
                    }

                }
                return true;
            }
            else
                return false;
            return true;
        }

        public Dictionary<int, string> liste_topla(string tablo)
        {

            var dt_obj = new DataTable();
            var con = new SqlConnection(baglanti_string);
            var comm = new SqlCommand();
            string sorgu = "SELECT * from " + tablo;
            con.Open();
            comm.Connection = con;
            comm.CommandText = sorgu;
            comm.CommandType = CommandType.Text;
            SqlDataReader reader = comm.ExecuteReader();
            Dictionary<int, string> dic = new Dictionary<int, string>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (reader.GetBoolean(2))
                    {

                        dic.Add(Convert.ToInt16(reader[0]), (string)reader[1]);

                    }

                }
                con.Close();
                return (dic);
            }
            else
                return null;
            return null;
        }

        public Dictionary<int, string> liste_topla_zehirlenmeye_neden_olan_etken()
        {

            var dt_obj = new DataTable();
            var con = new SqlConnection(baglanti_string);
            var comm = new SqlCommand();
            string sorgu = "SELECT * from LST_ZEHIRLENMEYE_NEDEN_OLAN_ETKEN";
            con.Open();
            comm.Connection = con;
            comm.CommandText = sorgu;
            comm.CommandType = CommandType.Text;
            SqlDataReader reader = comm.ExecuteReader();
            Dictionary<int, string> dic = new Dictionary<int, string>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (reader.GetBoolean(3))
                    {
                        Lst_zehirlenmeye_neden_olan_etken list = new Lst_zehirlenmeye_neden_olan_etken();
                        list.kodu = Convert.ToInt32(reader[0]);
                        list.adı = reader.GetString(1);
                        list.ust_bolum_kodu = Convert.ToInt32(reader[2]);

                        Staticler.Zehirlenmeye_neden_olan_etken_lst.Add(list);
                    }

                }
                con.Close();
                return (dic);
            }
            else
                return null;
            return null;
        }

        public bool liste_topla_ulke_kodlari()
        {

            var dt_obj = new DataTable();
            var con = new SqlConnection(baglanti_string);
            var comm = new SqlCommand();
            string sorgu = "SELECT * from LST_ULKE_KODLARI";
            con.Open();
            comm.Connection = con;
            comm.CommandText = sorgu;
            comm.CommandType = CommandType.Text;
            SqlDataReader reader = comm.ExecuteReader();
            Dictionary<int, string> dic = new Dictionary<int, string>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (reader.GetBoolean(2))
                    {
                        LstUlkeKodlari list = new LstUlkeKodlari();
                        list.kodu = reader.GetString(0);
                        list.adi = reader.GetString(1);
                        list.mernis_kodu = !reader.IsDBNull(3) ? reader.GetString(3) : "";

                        Staticler.Ulke_kodlari_lst.Add(list);
                    }

                }
                con.Close();
                return true;
            }
            else
                return false;
            return false;
        }

        public bool liste_topla_tumorun_yeri()
        {

            var dt_obj = new DataTable();
            var con = new SqlConnection(baglanti_string);
            var comm = new SqlCommand();
            string sorgu = "SELECT * from LST_TUMORUN_YERI";
            con.Open();
            comm.Connection = con;
            comm.CommandText = sorgu;
            comm.CommandType = CommandType.Text;
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (reader.GetBoolean(4))
                    {
                        LstTumorunYeri list = new LstTumorunYeri();
                        list.kodu = Convert.ToInt32(reader[0]);
                        list.adi = !reader.IsDBNull(1) ? reader.GetString(1) : "";
                        list.karsilik_kodu = !reader.IsDBNull(2) ? reader.GetString(2) : "";
                        list.ust_bolum_kodu = !reader.IsDBNull(3) ? reader.GetInt16(3) : -1;

                        Staticler.Tumorun_yeri_lst.Add(list);
                    }

                }
                con.Close();
                return true;
            }
            else
                return false;
            return false;
        }
        public bool liste_topla_suttut()
        {

            var dt_obj = new DataTable();
            var con = new SqlConnection(baglanti_string);
            var comm = new SqlCommand();
            string sorgu = "SELECT * from LST_SUTTUT";
            con.Open();
            comm.Connection = con;
            comm.CommandText = sorgu;
            comm.CommandType = CommandType.Text;
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (reader.GetBoolean(5))
                    {
                        LstSuttut list = new LstSuttut();
                        list.kodu = Convert.ToInt16(reader[0]);
                        list.sut_kodu = !reader.IsDBNull(1) ? reader.GetString(1) : "";
                        list.adi = !reader.IsDBNull(2) ? reader.GetString(2) : "";
                        list.fiyat = !reader.IsDBNull(3) ? Convert.ToSingle(reader[3]) : -1;
                        list.sut_fiyat = !reader.IsDBNull(4) ? Convert.ToSingle(reader[4]) : -1;

                        if (!reader.IsDBNull(6))
                            list.lab_hizmet_kodu = reader.GetString(6);
                        if (!reader.IsDBNull(7))
                            list.harici_eklenen = reader[7].ToString();
                        if (!reader.IsDBNull(8))
                            list.grup = reader.GetString(8);
                        if (!reader.IsDBNull(9))
                            list.eski_suttut_no = reader.GetString(9);

                        Staticler.Suttut_lst.Add(list);
                    }

                }
                con.Close();
                return true;
            }
            else
                return false;
            return false;
        }

        public bool liste_topla_olasi_vaka_tani_kriteri()
        {

            var dt_obj = new DataTable();
            var con = new SqlConnection(baglanti_string);
            var comm = new SqlCommand();
            string sorgu = "SELECT * from LST_OLASI_VAKA_TANI_KRITERI";
            con.Open();
            comm.Connection = con;
            comm.CommandText = sorgu;
            comm.CommandType = CommandType.Text;
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    LstOlasiVakaTaniKriteri list = new LstOlasiVakaTaniKriteri();

                    list.bolum_kodu = Convert.ToInt32(reader[0]);
                    list.ust_bolum_kodu = Convert.ToInt32(reader[1]);
                    list.adi = !reader.IsDBNull(2) ? reader.GetString(2) : "";
                    list.kodu = !reader.IsDBNull(3) ? reader.GetString(3) : "";

                    Staticler.Olası_vaka_tani_kriter_lst.Add(list);

                }
                con.Close();
                return true;
            }
            else
                return false;
            return false;
        }

        public bool liste_topla_ilce_kodlari()
        {

            var dt_obj = new DataTable();
            var con = new SqlConnection(baglanti_string);
            var comm = new SqlCommand();
            string sorgu = "SELECT * from LST_ILCE_KODLARI";
            con.Open();
            comm.Connection = con;
            comm.CommandText = sorgu;
            comm.CommandType = CommandType.Text;
            SqlDataReader reader = comm.ExecuteReader();
            Dictionary<int, string> dic = new Dictionary<int, string>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (reader.GetBoolean(2))
                    {
                        LstIlceKodlari list = new LstIlceKodlari();
                        list.kodu = reader.GetInt32(0);
                        list.adi = reader.GetString(1);
                        list.il_kodu = reader.GetInt32(3);

                        Staticler.Ilce_kodlari_lst.Add(list);
                    }

                }
                con.Close();
                return true;
            }
            else
                return false;
            return false;
        }
        #endregion



        #region Skrs Guncelle
        public bool liste_ekle_ilac(JToken token)
        {
            var con = new SqlConnection(baglanti_string);
            var comm = new SqlCommand();
            string sorgu = "INSERT LST_ILACLAR (ILAC_ADI, BARKODU, RECETE_TURU, AKTIF, PROSPEKTUS, ETKEN_MADDE, FIYAT, MANUEL_EKLENMIS_ILAC, SGK_AKTIF, ATC_KODU, ATC_ADI, ESKI_SKRS_ILAC_NO, ESDEGER, AMBALAJ_BIRIMI, AMBALAJ_MIKTAR) VALUES (@ilacAd, @barkod, @receteTuru, @aktif, @prospektus, @etkenMadde, @fiyat, @manuelEklenmis, @sgkAktif, @atcKodu, @atcAdi, @eskiSkrs, @esdeger, @ambalajBirimi, @ambalajMiktari)";
            con.Open();
            comm.Connection = con;
            comm.CommandText = sorgu;
            comm.Parameters.AddWithValue("ilacAd", token["ADI"].ToString());
            comm.Parameters.AddWithValue("barkod", token["BARKODU"].ToString());
            comm.Parameters.AddWithValue("receteTuru", token["RECETETURU"].ToString());
            comm.Parameters.AddWithValue("aktif", token["AKTIF"].ToString());
            comm.Parameters.AddWithValue("prospektus", null);
            comm.Parameters.AddWithValue("etkenMadde", null);
            comm.Parameters.AddWithValue("fiyat", -1);
            comm.Parameters.AddWithValue("manuelEklenmis", "False");
            comm.Parameters.AddWithValue("sgkAktif", null);
            comm.Parameters.AddWithValue("atcKodu", token["ATCKODU"].ToString());
            comm.Parameters.AddWithValue("atcAdi", token["ATCADI"].ToString());
            comm.Parameters.AddWithValue("eskiSkrs", null);
            comm.Parameters.AddWithValue("esdeger", null);
            comm.Parameters.AddWithValue("ambalajBirimi", null);
            comm.Parameters.AddWithValue("ambalajMiktari", null);

            comm.ExecuteNonQuery();

            con.Close();
            return true;
        }

        public bool liste_guncelle_ilac(JToken token)
        {
            var con = new SqlConnection(baglanti_string);
            var comm = new SqlCommand();
            string sorgu = "UPDATE LST_ILACLAR SET RECETE_TURU=@tur, AKTIF=@aktif WHERE BARKODU=@barkod";
            con.Open();
            comm.Connection = con;
            comm.CommandText = sorgu;
            comm.Parameters.AddWithValue("aktif", token["AKTIF"].ToString());
            comm.Parameters.AddWithValue("tur", token["RECETETURU"].ToString());
            comm.Parameters.AddWithValue("barkod", token["BARKODU"].ToString());
            comm.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public bool liste_ekle_icd10(JToken token)
        {
            var con = new SqlConnection(baglanti_string);
            var comm = new SqlCommand();
            string sorgu = "INSERT LST_ICD10 (KODU, ICD10_KODU, ICD10_ADI, UST_ICD10_KODU, SEVIYE, AKTIF) VALUES (@primaryKodu, @kodu, @adi, @ustKodu, @seviye, @aktif)";
            con.Open();
            comm.Connection = con;
            comm.CommandText = sorgu;

            comm.Parameters.AddWithValue("primaryKodu", "13"); //HATALI SAYILMASINA DİKAKT ET
            comm.Parameters.AddWithValue("adi", token["ADI"].ToString());
            comm.Parameters.AddWithValue("ustKodu", token["USTKODU"].ToString());
            comm.Parameters.AddWithValue("seviye", token["SEVIYE"].ToString());
            comm.Parameters.AddWithValue("aktif", token["AKTIF"].ToString());
            comm.Parameters.AddWithValue("kodu", token["KODU"].ToString());

            comm.ExecuteNonQuery();

            con.Close();
            return true;
        }

        public bool liste_guncelle_icd10(JToken token)
        {
            var con = new SqlConnection(baglanti_string);
            var comm = new SqlCommand();
            string sorgu = "UPDATE LST_ICD10 SET ICD10_ADI=@adi, UST_ICD10_KODU=@ustKodu, SEVIYE=@seviye, AKTIF=@aktif WHERE ICD10_KODU=@kodu";
            con.Open();
            comm.Connection = con;
            comm.CommandText = sorgu;
            comm.Parameters.AddWithValue("adi", token["ADI"].ToString());
            comm.Parameters.AddWithValue("ustKodu", token["USTKODU"].ToString());
            comm.Parameters.AddWithValue("seviye", token["SEVIYE"].ToString());
            comm.Parameters.AddWithValue("aktif", token["AKTIF"].ToString());
            comm.Parameters.AddWithValue("kodu", token["KODU"].ToString());
            comm.ExecuteNonQuery();
            con.Close();
            return true;
        }


        public bool liste_ekle_ulkeKodlari(JToken token)
        {
            var con = new SqlConnection(baglanti_string);
            var comm = new SqlCommand();
            string sorgu = "INSERT LST_ULKE_KODLARI (KODU, ADI, AKTIF, MERNIS_KODU) VALUES (@kodu, @adi, @aktif, @mernis_kodu)";
            con.Open();
            comm.Connection = con;
            comm.CommandText = sorgu;


            comm.Parameters.AddWithValue("kodu", token["KODU"].ToString());
            comm.Parameters.AddWithValue("adi", token["ADI"].ToString());
            comm.Parameters.AddWithValue("aktif", token["AKTIF"].ToString());
            comm.Parameters.AddWithValue("mernis_kodu", token["MERNISKODU"].ToString());

            comm.ExecuteNonQuery();

            con.Close();
            return true;
        }

        public bool liste_guncelle_ulkeKodlari(JToken token)
        {
            var con = new SqlConnection(baglanti_string);
            var comm = new SqlCommand();
            string sorgu = "UPDATE LST_ULKE_KODLARI SET KODU=@kodu, ADI=@adi, AKTIF=@aktif, MERNIS_KODU=@mernis_kodu WHERE KODU=@kodu";
            con.Open();
            comm.Connection = con;
            comm.CommandText = sorgu;
            comm.Parameters.AddWithValue("kodu", token["KODU"].ToString());
            comm.Parameters.AddWithValue("adi", token["ADI"].ToString());
            comm.Parameters.AddWithValue("aktif", token["AKTIF"].ToString());
            comm.Parameters.AddWithValue("mernis_kodu", token["MERNISKODU"].ToString());
            comm.ExecuteNonQuery();
            con.Close();
            return true;
        }
        public bool liste_ekle_asilar(JToken token)
        {
            var con = new SqlConnection(baglanti_string);
            var comm = new SqlCommand();
            string sorgu = "INSERT LST_ASILAR (KODU, ADI, AKTIF) VALUES (@kodu, @adi, @aktif)";
            con.Open();
            comm.Connection = con;
            comm.CommandText = sorgu;


            comm.Parameters.AddWithValue("kodu", token["KODU"].ToString());
            comm.Parameters.AddWithValue("adi", token["ADI"].ToString());
            comm.Parameters.AddWithValue("aktif", token["AKTIF"].ToString());

            comm.ExecuteNonQuery();

            con.Close();
            return true;
        }

        public bool liste_guncelle_asilar(JToken token)
        {
            var con = new SqlConnection(baglanti_string);
            var comm = new SqlCommand();
            string sorgu = "UPDATE LST_ASILAR SET KODU=@kodu, ADI=@adi, AKTIF=@aktif WHERE KODU=@kodu";
            con.Open();
            comm.Connection = con;
            comm.CommandText = sorgu;
            comm.Parameters.AddWithValue("kodu", token["KODU"].ToString());
            comm.Parameters.AddWithValue("adi", token["ADI"].ToString());
            comm.Parameters.AddWithValue("aktif", token["AKTIF"].ToString());
            comm.ExecuteNonQuery();
            con.Close();
            return true;
        }
        public bool liste_ekle_bucak_kodlari(JToken token)
        {
            var con = new SqlConnection(baglanti_string);
            var comm = new SqlCommand();
            string sorgu = "INSERT LST_BUCAK_KODLARI (KODU, ADI, AKTIF,ILCE_KODU) VALUES (@kodu, @adi, @aktif, @ilce_kodu)";
            con.Open();
            comm.Connection = con;
            comm.CommandText = sorgu;


            comm.Parameters.AddWithValue("kodu", token["KODU"].ToString());
            comm.Parameters.AddWithValue("adi", token["ADI"].ToString());
            comm.Parameters.AddWithValue("aktif", token["AKTIF"].ToString());
            comm.Parameters.AddWithValue("ilce_kodu", token["ILCEKODU"].ToString());

            comm.ExecuteNonQuery();

            con.Close();
            return true;
        }
        public bool liste_guncelle_bucak_kodlari(JToken token)
        {
            var con = new SqlConnection(baglanti_string);
            var comm = new SqlCommand();
            string sorgu = "UPDATE LST_BUCAK_KODLARI SET KODU=@kodu, ADI=@adi, AKTIF=@aktif, ILCE_KODU=@ilce_kodu WHERE KODU=@kodu";
            con.Open();
            comm.Connection = con;
            comm.CommandText = sorgu;
            comm.Parameters.AddWithValue("kodu", token["KODU"].ToString());
            comm.Parameters.AddWithValue("adi", token["ADI"].ToString());
            comm.Parameters.AddWithValue("aktif", token["AKTIF"].ToString());
            comm.Parameters.AddWithValue("ilce_kodu", token["ILCEKODU"].ToString());
            comm.ExecuteNonQuery();
            con.Close();
            return true;
        }
        public bool liste_ekle_egitim_kurumlari(JToken token)
        {
            var con = new SqlConnection(baglanti_string);
            var comm = new SqlCommand();
            string sorgu = "INSERT LST_EGITIM_KURUMLARI (KODU, ADI, ILKODU ,ILCEKODU, AKTIF) VALUES (@kodu, @adi, @il_kodu, @ilce_kodu, @aktif)";
            con.Open();
            comm.Connection = con;
            comm.CommandText = sorgu;

            comm.Parameters.AddWithValue("kodu", token["KODU"].ToString());
            comm.Parameters.AddWithValue("adi", token["ADI"].ToString());
            comm.Parameters.AddWithValue("il_kodu", token["ILKODU"].ToString());
            comm.Parameters.AddWithValue("ilce_kodu", token["ILCEKODU"].ToString());
            comm.Parameters.AddWithValue("aktif", token["AKTIF"].ToString());
            comm.ExecuteNonQuery();

            con.Close();
            return true;
        }
        public bool liste_guncelle_egitim_kurumlari(JToken token)
        {
            var con = new SqlConnection(baglanti_string);
            var comm = new SqlCommand();
            string sorgu = "UPDATE LST_EGITIM_KURUMLARI SET KODU=@kodu, ADI=@adi, ILKODU=@il_kodu, ILCEKODU=@ilce_kodu ,AKTIF=@aktif WHERE KODU=@kodu";
            con.Open();
            comm.Connection = con;
            comm.CommandText = sorgu;
            comm.Parameters.AddWithValue("kodu", token["KODU"].ToString() + "49");
            comm.Parameters.AddWithValue("adi", token["ADI"].ToString() + "78987988");
            comm.Parameters.AddWithValue("il_kodu", token["ILKODU"].ToString());
            comm.Parameters.AddWithValue("ilce_kodu", token["ILCEKODU"].ToString());
            comm.Parameters.AddWithValue("aktif", token["AKTIF"].ToString());

            comm.ExecuteNonQuery();
            con.Close();
            return true;
        }
        public bool liste_ekle_ilce_kodlari(JToken token)
        {
            var con = new SqlConnection(baglanti_string);
            var comm = new SqlCommand();
            string sorgu = "INSERT LST_ILCE_KODLARI (KODU, ADI, AKTIF, IL_KODU) VALUES (@kodu, @adi, @aktif, @il_kodu)";
            con.Open();
            comm.Connection = con;
            comm.CommandText = sorgu;

            comm.Parameters.AddWithValue("kodu", token["KODU"].ToString());
            comm.Parameters.AddWithValue("adi", token["ADI"].ToString());
            comm.Parameters.AddWithValue("aktif", token["AKTIF"].ToString());
            comm.Parameters.AddWithValue("il_kodu", token["ILKODU"].ToString());
            comm.ExecuteNonQuery();

            con.Close();
            return true;
        }
        public bool liste_guncelle_ilce_kodlari(JToken token)
        {
            var con = new SqlConnection(baglanti_string);
            var comm = new SqlCommand();
            string sorgu = "UPDATE LST_ILCE_KODLARI SET KODU=@kodu, ADI=@adi, AKTIF=@aktif, IL_KODU=@il_kodu WHERE KODU=@kodu";
            con.Open();
            comm.Connection = con;
            comm.CommandText = sorgu;
            comm.Parameters.AddWithValue("kodu", token["KODU"].ToString());
            comm.Parameters.AddWithValue("adi", token["ADI"].ToString());
            comm.Parameters.AddWithValue("aktif", token["AKTIF"].ToString());
            comm.Parameters.AddWithValue("il_kodu", token["ILKODU"].ToString());

            comm.ExecuteNonQuery();
            con.Close();
            return true;
        }






        public bool liste_ekle_yonlendirci(JToken token, string code)
        {
            if (code == "c3eaabad-8c4c-56ee-e043-14031b0a5530")
                liste_ekle_icd10(token);
            else if (code == "c3eab581-ae56-5807-e043-14031b0acb40")
                liste_ekle_ilac(token);
            else if (code == "d650777a-3d4d-a259-e040-7c0a01167a83")
                liste_ekle_ulkeKodlari(token);
            else if (code == "c3dbbb53-3b59-06e1-e043-14031b0a9fe6")
                liste_ekle_asilar(token);
            else if (code == "822af824-4163-46f8-b028-3741259b8471")
                liste_ekle_bucak_kodlari(token);
            else if (code == "cfb749a9-c769-7414-e040-7c0a04165362")
                liste_ekle_egitim_kurumlari(token);
            else if (code == "96184a9e-537c-4a70-8b3a-27a7a170355b")
                liste_ekle_ilce_kodlari(token);

            return true;
        }
        public bool liste_guncelle_yonlendirci(JToken token, string code)
        {
            if (code == "c3eaabad-8c4c-56ee-e043-14031b0a5530")
                liste_guncelle_icd10(token);
            else if (code == "c3eab581-ae56-5807-e043-14031b0acb40")
                liste_guncelle_ilac(token);
            else if (code == "d650777a-3d4d-a259-e040-7c0a01167a83")
                liste_guncelle_ulkeKodlari(token);
            else if (code == "c3dbbb53-3b59-06e1-e043-14031b0a9fe6")
                liste_guncelle_asilar(token);
            else if (code == "822af824-4163-46f8-b028-3741259b8471")
                liste_guncelle_bucak_kodlari(token);
            else if (code == "cfb749a9-c769-7414-e040-7c0a04165362")
                liste_guncelle_egitim_kurumlari(token);
            else if (code == "96184a9e-537c-4a70-8b3a-27a7a170355b")
                liste_guncelle_ilce_kodlari(token);

            return true;
        }
        #endregion

    }
}
