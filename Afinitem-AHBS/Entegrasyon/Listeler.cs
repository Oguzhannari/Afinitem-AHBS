using Apicop;
using SqlDeneme;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sunum.Listeler
{
	public static class cblisteler
	{
		//Field
		#region Listeler
		//public static List<string> lst_zehirlenmeye_neden_olan_etken;
		public static Dictionary<int, string> lst_zehirlenmenin_olus_sekli { get; set; }
		public static Dictionary<int, string> lst_zehirlenme_yolu { get; set; }
		public static Dictionary<int, string> lst_yayma_sonucu { get; set; }
		public static Dictionary<int, string> lst_yataga_bagimlilik { get; set; }
		public static Dictionary<int, string> lst_yaralanmanin_yeri { get; set; }
		public static Dictionary<int, string> lst_yaralanma_gecmisi { get; set; }
		public static Dictionary<int, string> lst_yakinlik_derecesi { get; set; }
		public static Dictionary<int, string> lst_yabanci_hasta_turu { get; set; }
		public static Dictionary<int, string> lst_verilen_egitimler { get; set; }
		public static Dictionary<int, string> lst_verem_tedavi_sonucu { get; set; }
		public static Dictionary<int, string> lst_verem_olgu_tanimi { get; set; }
		public static Dictionary<int, string> lst_verem_hastasi_tedavi_yontemi { get; set; }
		public static Dictionary<int, string> lst_verem_hastasi_klinik_ornegi { get; set; }
		public static Dictionary<int, string> lst_verem_hastaliginin_tutulum_yeri { get; set; }
		public static Dictionary<int, string> lst_vakanin_olusma_sekli { get; set; }
		public static Dictionary<int, string> lst_vaka_turu { get; set; }
		public static Dictionary<int, string> lst_uygulanan_kuduz_profilaksisi { get; set; }
		public static Dictionary<int, string> lst_uyari_tipi { get; set; }
		public static Dictionary<int, string> lst_uterus_involusyon { get; set; }
		//public static List<string> lst_ulke_kodlari;
		public static Dictionary<int, string> lst_uc_gecikme_modeli { get; set; }
		public static Dictionary<int, string> lst_tutun_tedavi_sonucu { get; set; }
		public static Dictionary<int, string> lst_tutun_dumanina_maruz_kalma { get; set; }
		//public static List<string> lst_tumorun_yeri;
		public static Dictionary<int, string> lst_topuk_kani { get; set; }
		public static Dictionary<int, string> lst_toplu_zehirlenme_durumu { get; set; }
		public static Dictionary<int, string> lst_tiroid_muayenesi { get; set; }
		public static Dictionary<int, string> lst_tetkik_istenme_durumu { get; set; }
		public static Dictionary<int, string> lst_telefon_tipi { get; set; }
		public static Dictionary<int, string> lst_tedavi_yontemi { get; set; }
		public static Dictionary<int, string> lst_tedavi_sekli { get; set; }
		public static Dictionary<int, string> lst_tarama_turu { get; set; }
		public static Dictionary<int, string> lst_tarama_sonucu_verem { get; set; }
		public static Dictionary<int, string> lst_tarama_sonucu { get; set; }
		public static Dictionary<int, string> lst_tani_yontemi { get; set; }
		//public static List<string> lst_suttut;
		public static Dictionary<int, string> lst_supheli_temasa_sebep_olan_hayvan { get; set; }
		public static Dictionary<int, string> lst_supheli_temas_tipi { get; set; }
		public static Dictionary<int, string> lst_spirometri { get; set; }
		public static Dictionary<int, string> lst_sosyal_guvence_durumu { get; set; }
		public static Dictionary<int, string> lst_sonuc { get; set; }
		public static Dictionary<int, string> lst_sma_tarama_testi_sonucu { get; set; }
		public static Dictionary<int, string> lst_sma_genetik_tani_sonucu { get; set; }
		public static Dictionary<int, string> lst_sigara_kullanimi { get; set; }
		public static Dictionary<int, string> lst_siddet_turu { get; set; }
		public static Dictionary<int, string> lst_sezaryan_endikasyonlar { get; set; }
		public static Dictionary<int, string> lst_servikal_smear_varligi { get; set; }
		public static Dictionary<int, string> lst_servikal_sitoloji_sonucu { get; set; }
		public static Dictionary<int, string> lst_seer_ozet_evre { get; set; }
		public static Dictionary<int, string> lst_rs30_kontrolun_yapildigi_yer { get; set; }
		public static Dictionary<int, string> lst_rs30_kontrole_uyum { get; set; }
		public static Dictionary<int, string> lst_recete_turu { get; set; }
		public static Dictionary<int, string> lst_raporun_gecerlilik_suresi { get; set; }
		public static Dictionary<int, string> lst_rapor_turu { get; set; }
		public static Dictionary<int, string> lst_psikolojik_tedavi { get; set; }
		public static Dictionary<int, string> lst_psikolojik_durum_degerlendirmesi { get; set; }
		public static Dictionary<int, string> lst_postpartum_depresyon { get; set; }
		public static Dictionary<int, string> lst_parazitin_turu { get; set; }
		public static Dictionary<int, string> lst_pap_smear_testi { get; set; }
		public static Dictionary<int, string> lst_palyatif_bakim { get; set; }
		public static Dictionary<int, string> lst_ozurluluk_durumu { get; set; }
		public static Dictionary<int, string> lst_otopsi_durumu { get; set; }
		public static Dictionary<int, string> lst_organ_nakli_turu { get; set; }
		public static Dictionary<int, string> lst_onceki_dogum_durumu { get; set; }
		public static Dictionary<int, string> lst_olum_yeri { get; set; }
		public static Dictionary<int, string> lst_olum_sekli { get; set; }
		public static Dictionary<int, string> lst_olum_nedeni_turu { get; set; }
		//public static List<string> lst_olasi_vaka_tani_kriteri { get; set; }
		public static Dictionary<int, string> lst_okul_cagi_postur { get; set; }
		public static Dictionary<int, string> lst_ogrenim_durumu { get; set; }
		public static Dictionary<int, string> lst_ogrencinin_sinifi { get; set; }
		public static Dictionary<int, string> lst_ogrenci_muayene_izlem_islemi { get; set; }
		public static Dictionary<int, string> lst_obezite_ilac_tedavisi { get; set; }
		public static Dictionary<int, string> lst_nuks_cesidi { get; set; }
		public static Dictionary<int, string> lst_ntp_takip_bilgisi { get; set; }
		public static Dictionary<int, string> lst_nefropati { get; set; }
		public static Dictionary<int, string> lst_nakil_yapilan_organ { get; set; }
		public static Dictionary<int, string> lst_muayene_turu { get; set; }
		//public static List<string> lst_msvs { get; set; }
		public static Dictionary<int, string> lst_morbid_obez_hasta_lenfatik_odem_varligi { get; set; }
		public static Dictionary<int, string> lst_meslekler { get; set; }
		public static Dictionary<int, string> lst_mesleki_maruziyet_durumu { get; set; }
		public static Dictionary<int, string> lst_meslek_ve_kanser { get; set; }
		public static Dictionary<int, string> lst_medeni_hali { get; set; }
		public static Dictionary<int, string> lst_maruz_kalma_zaman_birimi { get; set; }
		public static Dictionary<int, string> lst_mamografi_sonucu { get; set; }
		public static Dictionary<int, string> lst_mamografi { get; set; }
		//public static List<string> lst_mahalle_kodlari { get; set; }
		public static Dictionary<int, string> lst_madde_kullanimi { get; set; }
		public static Dictionary<int, string> lst_lateralite { get; set; }
		public static Dictionary<int, string> lst_laboratuvar_teyidi { get; set; }
		//public static List<string> lst_kurumlar { get; set; }
		public static Dictionary<int, string> lst_kurum_turu { get; set; }
		public static Dictionary<int, string> lst_kultur_sonucu { get; set; }
		public static Dictionary<int, string> lst_kullanilan_hela_tipi { get; set; }
		public static Dictionary<int, string> lst_kullanilan_aile_planlamasi_yonetmi { get; set; }
		public static Dictionary<int, string> lst_kullandigi_yardimci_araclar { get; set; }
		public static Dictionary<int, string> lst_kuduz_supheli_temas_degerlendirme_durumu { get; set; }
		public static Dictionary<int, string> lst_kuduz_profilaksisi_tamamlanma_durumu { get; set; }
		//public static List<string> lst_koy_kodlari { get; set; }
		public static Dictionary<int, string> lst_konut_tipi { get; set; }
		public static Dictionary<int, string> lst_konjenital_anomalili_dogum_varligi { get; set; }
		public static Dictionary<int, string> lst_kolon_goruntuleme_yontemi { get; set; }
		//public static List<string> lst_klinikler { get; set; }
		public static Dictionary<int, string> lst_klinik_meme_muayenesi { get; set; }
		public static Dictionary<int, string> lst_kisisel_hijyen { get; set; }
		public static Dictionary<int, string> lst_kisisel_bakim { get; set; }
		public static Dictionary<int, string> lst_kir_kent { get; set; }
		//public static List<string> lst_kesin_vaka_tani_kriteri { get; set; }
		public static Dictionary<int, string> lst_kendi_kendine_meme_muayenesi { get; set; }
		public static Dictionary<int, string> lst_kategorizasyon { get; set; }
		public static Dictionary<int, string> lst_kanser_takibi { get; set; }
		public static Dictionary<int, string> lst_kanin_alinis_nedeni { get; set; }
		public static Dictionary<int, string> lst_kanin_alindigi_surveyans_yontemi { get; set; }
		public static Dictionary<int, string> lst_kan_grubu { get; set; }
		public static Dictionary<int, string> lst_kadina_yonelik_siddet_sonucu_yonlendirme_ve_degerlendirme { get; set; }
		public static Dictionary<int, string> lst_kadin_sagligi_risk_tespit { get; set; }
		public static Dictionary<int, string> lst_kadin_sagligi_risk_faktorleri { get; set; }
		public static Dictionary<int, string> lst_kadin_sagligi_islemleri { get; set; }
		public static Dictionary<int, string> lst_kacinci_lohusa_izlem { get; set; }
		public static Dictionary<int, string> lst_kacinci_izlem { get; set; }
		public static Dictionary<int, string> lst_kacinci_gebe_izlem { get; set; }
		public static Dictionary<int, string> lst_kabul_sekli { get; set; }
		public static Dictionary<int, string> lst_isinma_tipi { get; set; }
		public static Dictionary<int, string> lst_isinma { get; set; }
		public static Dictionary<int, string> lst_is_durumu { get; set; }
		public static Dictionary<int, string> lst_intihar_kriz_vaka_turu { get; set; }
		public static Dictionary<int, string> lst_intihar_kriz_vaka_sonucu { get; set; }
		public static Dictionary<int, string> lst_insulin_pompasi { get; set; }
		public static Dictionary<int, string> lst_insulin_enjeksiyon_yerleri_muayene_sonucu { get; set; }
		public static Dictionary<int, string> lst_insektisit_uygulamasi { get; set; }
		public static Dictionary<int, string> lst_immunglobulin_turu { get; set; }
		//public static List<string> lst_ilce_kodlari { get; set; }
		//public static List<string> lst_ilaclar { get; set; }
		public static Dictionary<int, string> lst_ilac_rapor_durumu { get; set; }
		public static Dictionary<int, string> lst_ilac_kullanim_sekli { get; set; }
		public static Dictionary<int, string> lst_ilac_kullanim_periyodu_birimi { get; set; }
		public static Dictionary<int, string> lst_ilac_direnci_verem { get; set; }
		public static Dictionary<int, string> lst_ilac_adi_verem { get; set; }
		//public static List<string> lst_il_kodlari { get; set; }
		public static Dictionary<int, string> lst_idrarda_protein { get; set; }
		public static Dictionary<int, string> lst_icme_suyu_cesidi { get; set; }
		//public static List<string> lst_icd10_msvs_iliskisi { get; set; }
		//public static List<string> lst_icd10 { get; set; }
		public static Dictionary<int, string> lst_hukumluluk_durumu { get; set; }
		public static Dictionary<int, string> lst_hpv_tipi { get; set; }
		public static Dictionary<int, string> lst_histoloji { get; set; }
		public static Dictionary<int, string> lst_hemoglobinopati_test_sonucu_tasiyicilik_turu { get; set; }
		public static Dictionary<int, string> lst_hemoglobinopati_test_sonucu_hastalik_turu { get; set; }
		public static Dictionary<int, string> lst_hemoglobinopati_tarama_testi_sonucu { get; set; }
		public static Dictionary<int, string> lst_hemoglobinopati_tarama_sonucu { get; set; }
		public static Dictionary<int, string> lst_hemoglobinopati_islem_tipi { get; set; }
		public static Dictionary<int, string> lst_hela_tipi { get; set; }
		public static Dictionary<int, string> lst_hayvanin_sahiplik_durumu { get; set; }
		public static Dictionary<int, string> lst_hayvanin_mevcut_durumu { get; set; }
		public static Dictionary<int, string> lst_hayati_tehlike_durumu { get; set; }
		public static Dictionary<int, string> lst_hastanin_tedaviye_uyumu { get; set; }
		public static Dictionary<int, string> lst_hastalik_tipi { get; set; }
		public static Dictionary<int, string> lst_hastalik { get; set; }
		public static Dictionary<int, string> lst_hasta_kayit_turu { get; set; }
		public static Dictionary<int, string> lst_guvenlik { get; set; }
		public static Dictionary<int, string> lst_gorme_tarama_sonucu { get; set; }
		public static Dictionary<int, string> lst_gkd_tarama_sonucu { get; set; }
		public static Dictionary<int, string> lst_gestasyonel_diyabet_taramasi { get; set; }
		public static Dictionary<int, string> lst_genclik_sagligi_islemleri { get; set; }
		public static Dictionary<int, string> lst_genc_kacinci_izlem { get; set; }
		public static Dictionary<int, string> lst_gelisim_tablosu_bilgilerinin_sorgulanmasi { get; set; }
		public static Dictionary<int, string> lst_gelir_durumu { get; set; }
		public static Dictionary<int, string> lst_gecmiste_tedavi_durumu { get; set; }
		public static Dictionary<int, string> lst_gecmiste_ates_nobeti { get; set; }
		public static Dictionary<int, string> lst_gebelikte_risk_faktorleri { get; set; }
		public static Dictionary<int, string> lst_gebelikte_risk_durumu { get; set; }
		public static Dictionary<int, string> lst_gebelik_sonucu { get; set; }
		public static Dictionary<int, string> lst_gebelik_lohusalik_seyrinde_tehlike_isareti { get; set; }
		public static Dictionary<int, string> lst_gebelik_araligi { get; set; }
		public static Dictionary<int, string> lst_gebede_sik_izleme_alinan_risk_altindaki_olgunun_takibi { get; set; }
		public static Dictionary<int, string> lst_gebede_risk_faktorlerine_yapilan_mudahale { get; set; }
		public static Dictionary<int, string> lst_gebe_bilgilendirme_ve_danismanlik { get; set; }
		public static Dictionary<int, string> lst_gametosit_durumu { get; set; }
		public static Dictionary<int, string> lst_gaitada_gizli_kan_testi { get; set; }
		public static Dictionary<int, string> lst_evde_saglik_hizmetleri_hasta_nakli { get; set; }
		public static Dictionary<int, string> lst_evde_saglik_hizmetinin_sonlandirilmasi { get; set; }
		public static Dictionary<int, string> lst_ev_hijyeni { get; set; }
		public static Dictionary<int, string> lst_endikasyon_nedenleri { get; set; }
		public static Dictionary<int, string> lst_egzersiz { get; set; }
		public static Dictionary<int, string> lst_egitim_kurumuna_devam_etme_durumu { get; set; }
		//public static List<string> lst_egitim_kurumlari { get; set; }
		public static Dictionary<int, string> lst_ebeveynin_psikolojik_gelisimini_destekleyici_aktiviteleri { get; set; }
		public static Dictionary<int, string> lst_dusuk_turu { get; set; }
		public static Dictionary<int, string> lst_dogumun_gerceklestigi_yer { get; set; }
		public static Dictionary<int, string> lst_doguma_yardim_eden { get; set; }
		public static Dictionary<int, string> lst_dogum_yonetimi { get; set; }
		public static Dictionary<int, string> lst_dogum_sirasi { get; set; }
		public static Dictionary<int, string> lst_dogum_agirligi { get; set; }
		public static Dictionary<int, string> lst_diyet_tedavisi_tibbi_beslenme_tedavisi { get; set; }
		public static Dictionary<int, string> lst_diyabetli_hasta_basvuru_nedeni { get; set; }
		public static Dictionary<int, string> lst_diyabetli_hasta_aile_oykusu { get; set; }
		public static Dictionary<int, string> lst_diyabetli_cocugun_puberte_gelisimi { get; set; }
		public static Dictionary<int, string> lst_diyabetli_cocugun_dogum_haftasi { get; set; }
		public static Dictionary<int, string> lst_diyabet_komplikasyonlari { get; set; }
		public static Dictionary<int, string> lst_diyabet_ilac_tedavi_sekli { get; set; }
		public static Dictionary<int, string> lst_diyabet_hastasina_egzersiz_onerilme_durumu { get; set; }
		public static Dictionary<int, string> lst_diyabet_egitimi { get; set; }
		public static Dictionary<int, string> lst_dgt_uygulamasini_yapan_kisi { get; set; }
		public static Dictionary<int, string> lst_dgt_uygulama_yeri { get; set; }
		public static Dictionary<int, string> lst_demir_lojistigi_ve_destegi { get; set; }
		public static Dictionary<int, string> lst_d_vitamini_lojistigi_ve_destegi { get; set; }
		public static Dictionary<int, string> lst_cinsiyet_resmi { get; set; }
		public static Dictionary<int, string> lst_cinsiyet { get; set; }
		public static Dictionary<int, string> lst_cinsel_partner_bilgileri { get; set; }
		public static Dictionary<int, string> lst_cikis_sekli { get; set; }
		public static Dictionary<int, string> lst_cezaevi_tipi { get; set; }
		public static Dictionary<int, string> lst_calisma_durumu { get; set; }
		//public static List<string> lst_bucak_kodlari { get; set; }
		public static Dictionary<int, string> lst_bir_sonraki_hizmet_ihtiyaci { get; set; }
		public static Dictionary<int, string> lst_bildirimi_zorunlu_asi_sonrasi_istenmeyen_etki { get; set; }
		public static Dictionary<int, string> lst_beslenme { get; set; }
		public static Dictionary<int, string> lst_bebekte_risk_faktorleri { get; set; }
		public static Dictionary<int, string> lst_bebek_olum_nedenleri { get; set; }
		public static Dictionary<int, string> lst_bebek_cocukta_sik_izleme_alinan_risk_altindaki_olgunun_takibi { get; set; }
		public static Dictionary<int, string> lst_bebek_cocuk_tarama_sonuclari { get; set; }
		public static Dictionary<int, string> lst_bebek_cocuk_sagligi { get; set; }
		public static Dictionary<int, string> lst_bebek_cocuk_gelisim_tablosu { get; set; }
		public static Dictionary<int, string> lst_bebegin_cocugun_risk_faktorlerine_yapilan_mudahale { get; set; }
		public static Dictionary<int, string> lst_bebegin_cocugun_psikolojik_gelisimindeki_risklere_yonelik_egitimler { get; set; }
		public static Dictionary<int, string> lst_bebegin_cocugun_beyin_gelisimini_etkileyebilecek_riskler { get; set; }
		public static Dictionary<int, string> lst_bebegin_beslenme_durumu { get; set; }
		public static Dictionary<int, string> lst_basvuru_turu { get; set; }
		public static Dictionary<int, string> lst_baska_sitma_vakasi { get; set; }
		public static Dictionary<int, string> lst_baska_bir_vaka_ile_epidemiyolojik_baglanti { get; set; }
		public static Dictionary<int, string> lst_basi_degerlendirmesi { get; set; }
		public static Dictionary<int, string> lst_bakim_ve_destek_ihtiyaci { get; set; }
		public static Dictionary<int, string> lst_bagimli_oldugu_urun { get; set; }
		public static Dictionary<int, string> lst_ayni_evde_ates_geciren_kisi_durumu { get; set; }
		public static Dictionary<int, string> lst_aydinlatma { get; set; }
		public static Dictionary<int, string> lst_asinin_uygulama_sekli { get; set; }
		public static Dictionary<int, string> lst_asinin_saglandigi_kaynak { get; set; }
		//public static List<string> lst_asilar { get; set; }
		public static Dictionary<int, string> lst_asi_yapilmama_nedeni { get; set; }
		public static Dictionary<int, string> lst_asi_yapilmama_durumu { get; set; }
		public static Dictionary<int, string> lst_asi_uygulama_yeri { get; set; }
		public static Dictionary<int, string> lst_asi_ozel_durumu_nedeni { get; set; }
		public static Dictionary<int, string> lst_asi_dozu { get; set; }
		public static Dictionary<int, string> lst_anofel_durumu { get; set; }
		public static Dictionary<int, string> lst_anne_olum_zamani { get; set; }
		public static Dictionary<int, string> lst_anne_olum_nedeni { get; set; }
		public static Dictionary<int, string> lst_ameliyat_gecmisi { get; set; }
		public static Dictionary<int, string> lst_ambulans_ile_gelis_durumu { get; set; }
		public static Dictionary<int, string> lst_alkol_kullanimi { get; set; }
		public static Dictionary<int, string> lst_aile_planlamasi_yontemi_lojistigi { get; set; }
		public static Dictionary<int, string> lst_aile_planlamasi_yontemi_kullanmama_nedeni { get; set; }
		public static Dictionary<int, string> lst_agri { get; set; }
		public static Dictionary<int, string> lst_agizdan_sivi_tedavisi { get; set; }
		public static Dictionary<int, string> lst_afet_olay_vatandas_tipi { get; set; }
		public static Dictionary<int, string> lst_afet_olay_tipi { get; set; }
		public static Dictionary<int, string> lst_afet_olay { get; set; }
		public static Dictionary<int, string> lst_adres_tipi { get; set; }
		public static Dictionary<int, string> lst_adres_kodu_seviyesi { get; set; }
		public static Dictionary<int, string> lst_adli_vaka_gelis_sekli { get; set; }
		#endregion


		public static void ListeDoldur()
		{
			#region Listeler

			lst_zehirlenmenin_olus_sekli = ListeGetir("LST_ZEHIRLENMENIN_OLUS_SEKLI");
			lst_zehirlenme_yolu = ListeGetir("LST_ZEHIRLENME_YOLU");
			lst_yayma_sonucu = ListeGetir("LST_YAYMA_SONUCU");
			lst_yataga_bagimlilik = ListeGetir("LST_YATAGA_BAGIMLILIK");
			lst_yaralanmanin_yeri = ListeGetir("LST_YARALANMANIN_YERI");
			lst_yaralanma_gecmisi = ListeGetir("LST_YARALANMA_GECMISI");
			lst_yakinlik_derecesi = ListeGetir("LST_YAKINLIK_DERECESI");
			lst_yabanci_hasta_turu = ListeGetir("LST_YABANCI_HASTA_TURU");
			lst_verilen_egitimler = ListeGetir("LST_VERILEN_EGITIMLER");
			lst_verem_tedavi_sonucu = ListeGetir("LST_VEREM_TEDAVI_SONUCU");
			lst_verem_olgu_tanimi = ListeGetir("LST_VEREM_OLGU_TANIMI");
			lst_verem_hastasi_tedavi_yontemi = ListeGetir("LST_VEREM_HASTASI_TEDAVI_YONTEMI");
			lst_verem_hastasi_klinik_ornegi = ListeGetir("LST_VEREM_HASTASI_KLINIK_ORNEGI");
			lst_verem_hastaliginin_tutulum_yeri = ListeGetir("LST_VEREM_HASTALIGININ_TUTULUM_YERI");
			lst_vakanin_olusma_sekli = ListeGetir("LST_VAKANIN_OLUSMA_SEKLI");
			lst_vaka_turu = ListeGetir("LST_VAKA_TURU");
			lst_uygulanan_kuduz_profilaksisi = ListeGetir("LST_UYGULANAN_KUDUZ_PROFILAKSISI");
			lst_uyari_tipi = ListeGetir("LST_UYARI_TIPI");
			lst_uterus_involusyon = ListeGetir("LST_UTERUS_INVOLUSYON");
			lst_uc_gecikme_modeli = ListeGetir("LST_UC_GECIKME_MODELI");
			lst_tutun_tedavi_sonucu = ListeGetir("LST_TUTUN_TEDAVI_SONUCU");
			lst_tutun_dumanina_maruz_kalma = ListeGetir("LST_TUTUN_DUMANINA_MARUZ_KALMA");
			lst_topuk_kani = ListeGetir("LST_TOPUK_KANI");
			lst_toplu_zehirlenme_durumu = ListeGetir("LST_TOPLU_ZEHIRLENME_DURUMU");
			lst_tiroid_muayenesi = ListeGetir("LST_TIROID_MUAYENESI");
			lst_tetkik_istenme_durumu = ListeGetir("LST_TETKIK_ISTENME_DURUMU");
			lst_telefon_tipi = ListeGetir("LST_TELEFON_TIPI");
			lst_tedavi_yontemi = ListeGetir("LST_TEDAVI_YONTEMI");
			lst_tedavi_sekli = ListeGetir("LST_TEDAVI_SEKLI");
			lst_tarama_turu = ListeGetir("LST_TARAMA_TURU");
			lst_tarama_sonucu_verem = ListeGetir("LST_TARAMA_SONUCU_VEREM");
			lst_tarama_sonucu = ListeGetir("LST_TARAMA_SONUCU");
			lst_tani_yontemi = ListeGetir("LST_TANI_YONTEMI");
			lst_supheli_temasa_sebep_olan_hayvan = ListeGetir("LST_SUPHELI_TEMASA_SEBEP_OLAN_HAYVAN");
			lst_supheli_temas_tipi = ListeGetir("LST_SUPHELI_TEMAS_TIPI");
			lst_spirometri = ListeGetir("LST_SPIROMETRI");
			lst_sosyal_guvence_durumu = ListeGetir("LST_SOSYAL_GUVENCE_DURUMU");
			lst_sonuc = ListeGetir("LST_SONUC");
			lst_sma_tarama_testi_sonucu = ListeGetir("LST_SMA_TARAMA_TESTI_SONUCU");
			lst_sma_genetik_tani_sonucu = ListeGetir("LST_SMA_GENETIK_TANI_SONUCU");
			lst_sigara_kullanimi = ListeGetir("LST_SIGARA_KULLANIMI");
			lst_siddet_turu = ListeGetir("LST_SIDDET_TURU");
			lst_sezaryan_endikasyonlar = ListeGetir("LST_SEZARYAN_ENDIKASYONLAR");
			lst_servikal_smear_varligi = ListeGetir("LST_SERVIKAL_SMEAR_VARLIGI");
			lst_servikal_sitoloji_sonucu = ListeGetir("LST_SERVIKAL_SITOLOJI_SONUCU");
			lst_seer_ozet_evre = ListeGetir("LST_SEER_OZET_EVRE");
			lst_rs30_kontrolun_yapildigi_yer = ListeGetir("LST_RS30_KONTROLUN_YAPILDIGI_YER");
			lst_rs30_kontrole_uyum = ListeGetir("LST_RS30_KONTROLE_UYUM");
			lst_recete_turu = ListeGetir("LST_RECETE_TURU");
			lst_raporun_gecerlilik_suresi = ListeGetir("LST_RAPORUN_GECERLILIK_SURESI");
			lst_rapor_turu = ListeGetir("LST_RAPOR_TURU");
			lst_psikolojik_tedavi = ListeGetir("LST_PSIKOLOJIK_TEDAVI");
			lst_psikolojik_durum_degerlendirmesi = ListeGetir("LST_PSIKOLOJIK_DURUM_DEGERLENDIRMESI");
			lst_postpartum_depresyon = ListeGetir("LST_POSTPARTUM_DEPRESYON");
			lst_parazitin_turu = ListeGetir("LST_PARAZITIN_TURU");
			lst_pap_smear_testi = ListeGetir("LST_PAP_SMEAR_TESTI");
			lst_palyatif_bakim = ListeGetir("LST_PALYATIF_BAKIM");
			lst_ozurluluk_durumu = ListeGetir("LST_OZURLULUK_DURUMU");
			lst_otopsi_durumu = ListeGetir("LST_OTOPSI_DURUMU");
			lst_organ_nakli_turu = ListeGetir("LST_ORGAN_NAKLI_TURU");
			lst_onceki_dogum_durumu = ListeGetir("LST_ONCEKI_DOGUM_DURUMU");
			lst_olum_yeri = ListeGetir("LST_OLUM_YERI");
			lst_olum_sekli = ListeGetir("LST_OLUM_SEKLI");
			lst_olum_nedeni_turu = ListeGetir("LST_OLUM_NEDENI_TURU");
			lst_okul_cagi_postur = ListeGetir("LST_OKUL_CAGI_POSTUR");
			lst_ogrenim_durumu = ListeGetir("LST_OGRENIM_DURUMU");
			lst_ogrencinin_sinifi = ListeGetir("LST_OGRENCININ_SINIFI");
			lst_ogrenci_muayene_izlem_islemi = ListeGetir("LST_OGRENCI_MUAYENE_IZLEM_ISLEMI");
			lst_obezite_ilac_tedavisi = ListeGetir("LST_OBEZITE_ILAC_TEDAVISI");
			lst_nuks_cesidi = ListeGetir("LST_NUKS_CESIDI");
			lst_ntp_takip_bilgisi = ListeGetir("LST_NTP_TAKIP_BILGISI");
			lst_nefropati = ListeGetir("LST_NEFROPATI");
			lst_nakil_yapilan_organ = ListeGetir("LST_NAKIL_YAPILAN_ORGAN");
			lst_muayene_turu = ListeGetir("LST_MUAYENE_TURU");
			lst_morbid_obez_hasta_lenfatik_odem_varligi = ListeGetir("LST_MORBID_OBEZ_HASTA_LENFATIK_ODEM_VARLIGI");
			lst_meslekler = ListeGetir("LST_MESLEKLER");
			lst_mesleki_maruziyet_durumu = ListeGetir("LST_MESLEKI_MARUZIYET_DURUMU");
			lst_meslek_ve_kanser = ListeGetir("LST_MESLEK_VE_KANSER");
			lst_medeni_hali = ListeGetir("LST_MEDENI_HALI");
			lst_maruz_kalma_zaman_birimi = ListeGetir("LST_MARUZ_KALMA_ZAMAN_BIRIMI");
			lst_mamografi_sonucu = ListeGetir("LST_MAMOGRAFI_SONUCU");
			lst_mamografi = ListeGetir("LST_MAMOGRAFI");
			lst_madde_kullanimi = ListeGetir("LST_MADDE_KULLANIMI");
			lst_lateralite = ListeGetir("LST_LATERALITE");
			lst_laboratuvar_teyidi = ListeGetir("LST_LABORATUVAR_TEYIDI");
			lst_kurum_turu = ListeGetir("LST_KURUM_TURU");
			lst_kultur_sonucu = ListeGetir("LST_KULTUR_SONUCU");
			lst_kullanilan_hela_tipi = ListeGetir("LST_KULLANILAN_HELA_TIPI");
			lst_kullanilan_aile_planlamasi_yonetmi = ListeGetir("LST_KULLANILAN_AILE_PLANLAMASI_YONTEMI");
			lst_kullandigi_yardimci_araclar = ListeGetir("LST_KULLANDIGI_YARDIMCI_ARACLAR");
			lst_kuduz_supheli_temas_degerlendirme_durumu = ListeGetir("LST_KUDUZ_SUPHELI_TEMAS_DEGERLENDIRME_DURUMU");
			lst_kuduz_profilaksisi_tamamlanma_durumu = ListeGetir("LST_KUDUZ_PROFILAKSISI_TAMAMLANMA_DURUMU");
			lst_konut_tipi = ListeGetir("LST_KONUT_TIPI");
			lst_konjenital_anomalili_dogum_varligi = ListeGetir("LST_KONJENITAL_ANOMALILI_DOGUM_VARLIGI");
			lst_kolon_goruntuleme_yontemi = ListeGetir("LST_KOLON_GORUNTULEME_YONTEMI");
			lst_klinik_meme_muayenesi = ListeGetir("LST_KLINIK_MEME_MUAYENESI");
			lst_kisisel_hijyen = ListeGetir("LST_KISISEL_HIJYEN");
			lst_kisisel_bakim = ListeGetir("LST_KISISEL_BAKIM");
			lst_kir_kent = ListeGetir("LST_KIR_KENT");
			lst_kendi_kendine_meme_muayenesi = ListeGetir("LST_KENDI_KENDINE_MEME_MUAYENESI");
			lst_kategorizasyon = ListeGetir("LST_KATEGORIZASYON");
			lst_kanser_takibi = ListeGetir("LST_KANSER_TAKIBI");
			lst_kanin_alinis_nedeni = ListeGetir("LST_KANIN_ALINIS_NEDENI");
			lst_kanin_alindigi_surveyans_yontemi = ListeGetir("LST_KANIN_ALINDIGI_SURVEYANS_YONTEMI");
			lst_kan_grubu = ListeGetir("LST_KAN_GRUBU");
			lst_kadina_yonelik_siddet_sonucu_yonlendirme_ve_degerlendirme = ListeGetir("LST_KADINA_YONELIK_SIDDET_SONUCU_YONLENDIRME_VE_DEGERLENDIRME");
			lst_kadin_sagligi_risk_tespit = ListeGetir("LST_KADIN_SAGLIGI_RISK_TESPIT");
			lst_kadin_sagligi_risk_faktorleri = ListeGetir("LST_KADIN_SAGLIGI_RISK_FAKTORLERI");
			lst_kadin_sagligi_islemleri = ListeGetir("LST_KADIN_SAGLIGI_ISLEMLERI");
			lst_kacinci_lohusa_izlem = ListeGetir("LST_KACINCI_LOHUSA_IZLEM");
			lst_kacinci_izlem = ListeGetir("LST_KACINCI_IZLEM");
			lst_kacinci_gebe_izlem = ListeGetir("LST_KACINCI_GEBE_IZLEM");
			lst_kabul_sekli = ListeGetir("LST_KABUL_SEKLI");
			lst_isinma_tipi = ListeGetir("LST_ISINMA_TIPI");
			lst_isinma = ListeGetir("LST_ISINMA");
			lst_is_durumu = ListeGetir("LST_IS_DURUMU");
			lst_intihar_kriz_vaka_turu = ListeGetir("LST_INTIHAR_KRIZ_VAKA_TURU");
			lst_intihar_kriz_vaka_sonucu = ListeGetir("LST_INTIHAR_KRIZ_VAKA_SONUCU");
			lst_insulin_pompasi = ListeGetir("LST_INSULIN_POMPASI");
			lst_insulin_enjeksiyon_yerleri_muayene_sonucu = ListeGetir("LST_INSULIN_ENJEKSIYON_YERLERI_MUAYENE_SONUCU");
			lst_insektisit_uygulamasi = ListeGetir("LST_INSEKTISIT_UYGULAMASI");
			lst_immunglobulin_turu = ListeGetir("LST_IMMUNGLOBULIN_TURU");
			//lst_ilce_kodlari = ListeGetir("LST_ILCE_KODLARI");
			//lst_ilaclar = ListeGetir("LST_ILACLAR");
			lst_ilac_rapor_durumu = ListeGetir("LST_ILAC_RAPOR_DURUMU");
			lst_ilac_kullanim_sekli = ListeGetir("LST_ILAC_KULLANIM_SEKLI");
			lst_ilac_kullanim_periyodu_birimi = ListeGetir("LST_ILAC_KULLANIM_PERIYODU_BIRIMI");
			lst_ilac_direnci_verem = ListeGetir("LST_ILAC_DIRENCI_VEREM");
			lst_ilac_adi_verem = ListeGetir("LST_ILAC_ADI_VEREM");
			//lst_il_kodlari = ListeGetir("LST_IL_KODLARI");
			lst_idrarda_protein = ListeGetir("LST_IDRARDA_PROTEIN");
			lst_icme_suyu_cesidi = ListeGetir("LST_ICME_SUYU_CESIDI");
			//lst_icd10_msvs_iliskisi = ListeGetir("LST_ICD10_MSVS_ILISKISI");
			//lst_icd10 = ListeGetir("LST_ICD10");
			lst_hukumluluk_durumu = ListeGetir("LST_HUKUMLULUK_DURUMU");
			lst_hpv_tipi = ListeGetir("LST_HPV_TIPI");
			lst_histoloji = ListeGetir("LST_HISTOLOJI");
			lst_hemoglobinopati_test_sonucu_tasiyicilik_turu = ListeGetir("LST_HEMOGLOBINOPATI_TEST_SONUCU_TASIYICILIK_TURU");
			lst_hemoglobinopati_test_sonucu_hastalik_turu = ListeGetir("LST_HEMOGLOBINOPATI_TEST_SONUCU_HASTALIK_TURU");
			lst_hemoglobinopati_tarama_testi_sonucu = ListeGetir("LST_HEMOGLOBINOPATI_TARAMA_TESTI_SONUCU");
			lst_hemoglobinopati_tarama_sonucu = ListeGetir("LST_HEMOGLOBINOPATI_TARAMA_SONUCU");
			lst_hemoglobinopati_islem_tipi = ListeGetir("LST_HEMOGLOBINOPATI_ISLEM_TIPI");
			lst_hela_tipi = ListeGetir("LST_HELA_TIPI");
			lst_hayvanin_sahiplik_durumu = ListeGetir("LST_HAYVANIN_SAHIPLIK_DURUMU");
			lst_hayvanin_mevcut_durumu = ListeGetir("LST_HAYVANIN_MEVCUT_DURUMU");
			lst_hayati_tehlike_durumu = ListeGetir("LST_HAYATI_TEHLIKE_DURUMU");
			lst_hastanin_tedaviye_uyumu = ListeGetir("LST_HASTANIN_TEDAVIYE_UYUMU");
			lst_hastalik_tipi = ListeGetir("LST_HASTALIK_TIPI");
			lst_hastalik = ListeGetir("LST_HASTALIK");
			lst_hasta_kayit_turu = ListeGetir("LST_HASTA_KAYIT_TURU");
			lst_guvenlik = ListeGetir("LST_GUVENLIK");
			lst_gorme_tarama_sonucu = ListeGetir("LST_GORME_TARAMA_SONUCU");
			lst_gkd_tarama_sonucu = ListeGetir("LST_GKD_TARAMA_SONUCU");
			lst_gestasyonel_diyabet_taramasi = ListeGetir("LST_GESTASYONEL_DIYABET_TARAMASI");
			lst_genclik_sagligi_islemleri = ListeGetir("LST_GENCLIK_SAGLIGI_ISLEMLERI");
			lst_genc_kacinci_izlem = ListeGetir("LST_GENC_KACINCI_IZLEM");
			lst_gelisim_tablosu_bilgilerinin_sorgulanmasi = ListeGetir("LST_GELISIM_TABLOSU_BILGILERININ_SORGULANMASI");
			lst_gelir_durumu = ListeGetir("LST_GELIR_DURUMU");
			lst_gecmiste_tedavi_durumu = ListeGetir("LST_GECMISTE_TEDAVI_DURUMU");
			lst_gecmiste_ates_nobeti = ListeGetir("LST_GECMISTE_ATES_NOBETI");
			lst_gebelikte_risk_faktorleri = ListeGetir("LST_GEBELIKTE_RISK_FAKTORLERI");
			lst_gebelikte_risk_durumu = ListeGetir("LST_GEBELIKTE_RISK_DURUMU");
			lst_gebelik_sonucu = ListeGetir("LST_GEBELIK_SONUCU");
			lst_gebelik_lohusalik_seyrinde_tehlike_isareti = ListeGetir("LST_GEBELIK_LOHUSALIK_SEYRINDE_TEHLIKE_ISARETI");
			lst_gebelik_araligi = ListeGetir("LST_GEBELIK_ARALIGI");
			lst_gebede_sik_izleme_alinan_risk_altindaki_olgunun_takibi = ListeGetir("LST_GEBEDE_SIK_IZLEME_ALINAN_RISK_ALTINDAKI_OLGUNUN_TAKIBI");
			lst_gebede_risk_faktorlerine_yapilan_mudahale = ListeGetir("LST_GEBEDE_RISK_FAKTORLERINE_YAPILAN_MUDAHALE");
			lst_gebe_bilgilendirme_ve_danismanlik = ListeGetir("LST_GEBE_BILGILENDIRME_VE_DANISMANLIK");
			lst_gametosit_durumu = ListeGetir("LST_GAMETOSIT_DURUMU");
			lst_gaitada_gizli_kan_testi = ListeGetir("LST_GAITADA_GIZLI_KAN_TESTI");
			lst_evde_saglik_hizmetleri_hasta_nakli = ListeGetir("LST_EVDE_SAGLIK_HIZMETLERI_HASTA_NAKLI");
			lst_evde_saglik_hizmetinin_sonlandirilmasi = ListeGetir("LST_EVDE_SAGLIK_HIZMETININ_SONLANDIRILMASI");
			lst_ev_hijyeni = ListeGetir("LST_EV_HIJYENI");
			lst_endikasyon_nedenleri = ListeGetir("LST_ENDIKASYON_NEDENLERI");
			lst_egzersiz = ListeGetir("LST_EGZERSIZ");
			lst_egitim_kurumuna_devam_etme_durumu = ListeGetir("LST_EGITIM_KURUMUNA_DEVAM_ETME_DURUMU");
			//lst_egitim_kurumlari = ListeGetir("LST_EGITIM_KURUMLARI");
			lst_ebeveynin_psikolojik_gelisimini_destekleyici_aktiviteleri = ListeGetir("LST_EBEVEYNIN_PSIKOLOJIK_GELISIMI_DESTEKLEYICI_AKTIVITELERI");
			lst_dusuk_turu = ListeGetir("LST_DUSUK_TURU");
			lst_dogumun_gerceklestigi_yer = ListeGetir("LST_DOGUMUN_GERCEKLESTIGI_YER");
			lst_doguma_yardim_eden = ListeGetir("LST_DOGUMA_YARDIM_EDEN");
			lst_dogum_yonetimi = ListeGetir("LST_DOGUM_YONTEMI");
			lst_dogum_sirasi = ListeGetir("LST_DOGUM_SIRASI");
			lst_dogum_agirligi = ListeGetir("LST_DOGUM_AGIRLIGI");
			lst_diyet_tedavisi_tibbi_beslenme_tedavisi = ListeGetir("LST_DIYET_TEDAVISI_TIBBI_BESLENME_TEDAVISI");
			lst_diyabetli_hasta_basvuru_nedeni = ListeGetir("LST_DIYABETLI_HASTA_BASVURU_NEDENI");
			lst_diyabetli_hasta_aile_oykusu = ListeGetir("LST_DIYABETLI_HASTA_AILE_OYKUSU");
			lst_diyabetli_cocugun_puberte_gelisimi = ListeGetir("LST_DIYABETLI_COCUGUN_PUBERTE_GELISIMI");
			lst_diyabetli_cocugun_dogum_haftasi = ListeGetir("LST_DIYABETLI_COCUGUN_DOGUM_HAFTASI");
			lst_diyabet_komplikasyonlari = ListeGetir("LST_DIYABET_KOMPLIKASYONLARI");
			lst_diyabet_ilac_tedavi_sekli = ListeGetir("LST_DIYABET_ILAC_TEDAVI_SEKLI");
			lst_diyabet_hastasina_egzersiz_onerilme_durumu = ListeGetir("LST_DIYABET_HASTASINA_EGZERSIZ_ONERILME_DURUMU");
			lst_diyabet_egitimi = ListeGetir("LST_DIYABET_EGITIMI");
			lst_dgt_uygulamasini_yapan_kisi = ListeGetir("LST_DGT_UYGULAMASINI_YAPAN_KISI");
			lst_dgt_uygulama_yeri = ListeGetir("LST_DGT_UYGULAMA_YERI");
			lst_demir_lojistigi_ve_destegi = ListeGetir("LST_DEMIR_LOJISTIGI_VE_DESTEGI");
			lst_d_vitamini_lojistigi_ve_destegi = ListeGetir("LST_D_VITAMINI_LOJISTIGI_VE_DESTEGI");
			lst_cinsiyet_resmi = ListeGetir("LST_CINSIYET_RESMI");
			lst_cinsiyet = ListeGetir("LST_CINSIYET");
			lst_cinsel_partner_bilgileri = ListeGetir("LST_CINSEL_PARTNER_BILGILERI");
			lst_cikis_sekli = ListeGetir("LST_CIKIS_SEKLI");
			lst_cezaevi_tipi = ListeGetir("LST_CEZAEVI_TIPI");
			lst_calisma_durumu = ListeGetir("LST_CALISMA_DURUMU");
			//lst_bucak_kodlari = ListeGetir("LST_BUCAK_KODLARI");
			lst_bir_sonraki_hizmet_ihtiyaci = ListeGetir("LST_BIR_SONRAKI_HIZMET_IHTIYACI");
			lst_bildirimi_zorunlu_asi_sonrasi_istenmeyen_etki = ListeGetir("LST_BILDIRIMI_ZORUNLU_ASI_SONRASI_ISTENMEYEN_ETKI");
			lst_beslenme = ListeGetir("LST_BESLENME");
			lst_bebekte_risk_faktorleri = ListeGetir("LST_BEBEKTE_RISK_FAKTORLERI");
			lst_bebek_olum_nedenleri = ListeGetir("LST_BEBEK_OLUM_NEDENLERI");
			lst_bebek_cocukta_sik_izleme_alinan_risk_altindaki_olgunun_takibi = ListeGetir("LST_BEBEK_COCUKTA_SIK_IZLEME_ALINAN_RISK_ALTINDAKI_OLGUNUN_TAKIBI");
			lst_bebek_cocuk_tarama_sonuclari = ListeGetir("LST_BEBEK_COCUK_TARAMA_SONUCLARI");
			lst_bebek_cocuk_sagligi = ListeGetir("LST_BEBEK_COCUK_SAGLIGI");
			lst_bebek_cocuk_gelisim_tablosu = ListeGetir("LST_BEBEK_COCUK_GELISIM_TABLOSU");
			lst_bebegin_cocugun_risk_faktorlerine_yapilan_mudahale = ListeGetir("LST_BEBEGIN_COCUGUN_RISK_FAKTORLERINE_YAPILAN_MUDAHALE");
			lst_bebegin_cocugun_psikolojik_gelisimindeki_risklere_yonelik_egitimler = ListeGetir("LST_BEBEGIN_COCUGUN_PSIKOLOJIK_GELISIMINDEKI_RISKLERE_YONELIK_EGITIMLER");
			lst_bebegin_cocugun_beyin_gelisimini_etkileyebilecek_riskler = ListeGetir("LST_BEBEGIN_COCUGUN_BEYIN_GELISIMINI_ETKILEYEBILECEK_RISKLER");
			lst_bebegin_beslenme_durumu = ListeGetir("LST_BEBEGIN_BESLENME_DURUMU");
			lst_basvuru_turu = ListeGetir("LST_BASVURU_TURU");
			lst_baska_sitma_vakasi = ListeGetir("LST_BASKA_SITMA_VAKASI");
			lst_baska_bir_vaka_ile_epidemiyolojik_baglanti = ListeGetir("LST_BASKA_BIR_VAKA_ILE_EPIDEMIYOLOJIK_BAGLANTI");
			lst_basi_degerlendirmesi = ListeGetir("LST_BASI_DEGERLENDIRMESI");
			lst_bakim_ve_destek_ihtiyaci = ListeGetir("LST_BAKIM_VE_DESTEK_IHTIYACI");
			lst_bagimli_oldugu_urun = ListeGetir("LST_BAGIMLI_OLDUGU_URUN");
			lst_ayni_evde_ates_geciren_kisi_durumu = ListeGetir("LST_AYNI_EVDE_ATES_GECIREN_KISI_DURUMU");
			lst_aydinlatma = ListeGetir("LST_AYDINLATMA");
			lst_asinin_uygulama_sekli = ListeGetir("LST_ASININ_UYGULAMA_SEKLI");
			lst_asinin_saglandigi_kaynak = ListeGetir("LST_ASININ_SAGLANDIGI_KAYNAK");
			//lst_asilar = ListeGetir("LST_ASILAR");
			lst_asi_yapilmama_nedeni = ListeGetir("LST_ASI_YAPILMAMA_NEDENI");
			lst_asi_yapilmama_durumu = ListeGetir("LST_ASI_YAPILMAMA_DURUMU");
			lst_asi_uygulama_yeri = ListeGetir("LST_ASI_UYGULAMA_YERI");
			lst_asi_ozel_durumu_nedeni = ListeGetir("LST_ASI_OZEL_DURUMU_NEDENI");
			lst_asi_dozu = ListeGetir("LST_ASI_DOZU");
			lst_anofel_durumu = ListeGetir("LST_ANOFEL_DURUMU");
			lst_anne_olum_zamani = ListeGetir("LST_ANNE_OLUM_ZAMANI");
			lst_anne_olum_nedeni = ListeGetir("LST_ANNE_OLUM_NEDENI");
			lst_ameliyat_gecmisi = ListeGetir("LST_AMELIYAT_GECMISI");
			lst_ambulans_ile_gelis_durumu = ListeGetir("LST_AMBULANS_ILE_GELIS_DURUMU");
			lst_alkol_kullanimi = ListeGetir("LST_ALKOL_KULLANIMI");
			lst_aile_planlamasi_yontemi_lojistigi = ListeGetir("LST_AILE_PLANLAMASI_YONTEMI_LOJISTIGI");
			lst_aile_planlamasi_yontemi_kullanmama_nedeni = ListeGetir("LST_AILE_PLANLAMASI_YONTEMI_KULLANMAMA_NEDENI");
			lst_agri = ListeGetir("LST_AGRI");
			lst_agizdan_sivi_tedavisi = ListeGetir("LST_AGIZDAN_SIVI_TEDAVISI");
			lst_afet_olay_vatandas_tipi = ListeGetir("LST_AFET_OLAY_VATANDAS_TIPI");
			lst_afet_olay_tipi = ListeGetir("LST_AFET_OLAY_TIPI");
			lst_afet_olay = ListeGetir("LST_AFET_OLAY");
			lst_adres_tipi = ListeGetir("LST_ADRES_TIPI");
			lst_adres_kodu_seviyesi = ListeGetir("LST_ADRES_KODU_SEVIYESI");
			lst_adli_vaka_gelis_sekli = ListeGetir("LST_ADLI_VAKA_GELIS_SEKLI");
			#endregion


		}
		public static Dictionary<int, string> ListeGetir(string tablo)
		{
			Sql a = new Sql();

			Dictionary<int, string> dic = new Dictionary<int, string>();
			dic = a.liste_topla(tablo);
			return dic;
		}

	}
}
