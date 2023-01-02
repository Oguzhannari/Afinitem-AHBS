using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Apicop
{
	public  class VeriGuncelle
	{
		public static Dictionary<string, string> skrs_kodlari1 { get; set; }
		public static HttpClient client = new HttpClient();
		public VeriGuncelle()
		{
			skrs_kodlari1 = new Dictionary<string, string>();
			client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

			client.DefaultRequestHeaders.Add("KullaniciAdi", "");
			client.DefaultRequestHeaders.Add("Sifre", "");
			client.DefaultRequestHeaders.Add("UygulamaKodu", "");
			
			#region X

			//Zehirlenmeler yok
			skrs_kodlari1.Add("82f99fcc-5282-4132-b5ff-70af5ec38a17", "LST_YAYMA_SONUCU");
			skrs_kodlari1.Add("7c011fa6-7896-409b-8fc7-9b4f501cc9db", "LST_YATAGA_BAGIMLILIK");
			skrs_kodlari1.Add("aab59c51-81bf-46ca-9743-d08288c845cb", "LST_YARALANMANIN_YERI");
			//LST_YARALANMA_GECMISI
			//LST_YAKINLIK_DERECESI
			skrs_kodlari1.Add("d8e52cb9-4aa9-512c-e043-14031b0a419d", "LST_YABANCI_HASTA_TURU");
			skrs_kodlari1.Add("79aaa967-1886-4d9d-a5d8-cdde552d94ad", "LST_VERILEN_EGITIMLER");
			skrs_kodlari1.Add("761d469a-9755-48e8-926b-49dd023ec914", "LST_VEREM_TEDAVI_SONUCU");
			skrs_kodlari1.Add("aaf78ab1-0d00-4dd5-8b70-bd9a6c3a2a0a", "LST_VEREM_OLGU_TANIMI");
			skrs_kodlari1.Add("eeb4ec17-28e7-4476-9ce9-21c5bd660b86", "LST_VEREM_HASTASI_TEDAVI_YONTEMI");
			skrs_kodlari1.Add("64bd7f03-db1d-4234-b77f-0496e22c6c45", "LST_VEREM_HASTASI_KLINIK_ORNEGI");
			skrs_kodlari1.Add("dc0248b9-4444-4ab7-bd8b-02355130611e", "LST_VEREM_HASTALIGININ_TUTULUM_YERI");
			//LST_VAKANIN_OLUSMA_SEKLI
			skrs_kodlari1.Add("46380e82-d8b1-407d-9554-255d95a9f959", "LST_VAKA_TURU");
			skrs_kodlari1.Add("db1af0ba-193c-424f-a2fe-710001d552c9", "LST_UYGULANAN_KUDUZ_PROFILAKSISI");
			//LST_UYARI_TIPI
			skrs_kodlari1.Add("d7df9348-aefb-1248-e040-7c0a02161f00", "LST_UTERUS_INVOLUSYON");
			//LST_ULKE_KODLARI *
			skrs_kodlari1.Add("645ec158-0090-4093-aeb0-dabcc7456a4c", "LST_UC_GECIKME_MODELI");
			skrs_kodlari1.Add("bdc7aa0a-2775-4149-9303-bf1bdc08c31a", "LST_TUTUN_TEDAVI_SONUCU");
			skrs_kodlari1.Add("c366b0b6-b15b-4819-920d-a9f465eed764", "LST_TUTUN_DUMANINA_MARUZ_KALMA");
			//LST_TUMORUN_YERI *-
			//LST_TOPUK_KANI
			//LST_TOPLU_ZEHIRLENME_DURUMU
			skrs_kodlari1.Add("1683b32e-0668-4c28-97b7-8d3245ae2f4d", "LST_TIROID_MUAYENESI");
			//LST_TETKIK_ISTENME_DURUMU
			skrs_kodlari1.Add("e387c902-9062-4406-85ef-63e085754f9e", "LST_TELEFON_TIPI");
			//LST_TEDAVI_YONTEMI
			skrs_kodlari1.Add("4cf6d20f-f01b-478f-ae96-1d5853030cae", "LST_TEDAVI_SEKLI");
			skrs_kodlari1.Add("52bcc87e-b051-4603-b6d6-43298fb0d443", "LST_TARAMA_TURU");
			skrs_kodlari1.Add("27e74b69-04ab-48b1-8c83-456f44bf32f7", "LST_TARAMA_SONUCU_VEREM");
			//LST_TARAMA_SONUCU birçoğunun birleşimi gibi kodlar karışıyor anlamadım
			//LST_TANI_YONTEMI
			//LST_SUTTUT *
			skrs_kodlari1.Add("81eac734-5328-4f90-bae0-7191311ebbaf", "LST_SUPHELI_TEMASA_SEBEP_OLAN_HAYVAN");
			skrs_kodlari1.Add("76578724-3b1a-433e-aba6-40ffd47d6dd7", "LST_SUPHELI_TEMAS_TIPI");
			skrs_kodlari1.Add("183e952f-4a72-43ff-85ab-793e0e6f892a", "LST_SPIROMETRI");
			skrs_kodlari1.Add("530da738-2be0-4adc-a7c1-aca18c66a3f8", "LST_SOSYAL_GUVENCE_DURUMU");
			//LST_SONUC
			skrs_kodlari1.Add("dd4d3adc-4261-4189-aab6-125ad8122144", "LST_SMA_TARAMA_TESTI_SONUCU");
			skrs_kodlari1.Add("d2fe70a0-cb28-4178-abc4-99551454203a", "LST_SMA_GENETIK_TANI_SONUCU");
			skrs_kodlari1.Add("567e3679-be54-4307-abbf-c499a25fe69e", "LST_SIGARA_KULLANIMI");
			skrs_kodlari1.Add("a1abeb83-cc2a-4556-98be-0d5fa6b0980a", "LST_SIDDET_TURU");
			skrs_kodlari1.Add("d7d14450-eaf1-7321-e040-7c0a04164cc0", "LST_SEZARYAN_ENDIKASYONLAR");
			//LST_SERVIKAL_SMEAR_VARLIGI
			skrs_kodlari1.Add("197c1232-2886-47de-9a38-0d5401fe6510", "LST_SERVIKAL_SITOLOJI_SONUCU");
			//LST_SEER_OZET_EVRE
			//LST_RS30_KONTROLUN_YAPILDIGI_YER
			//LST_RS30_KONTROLE_UYUM
			skrs_kodlari1.Add("c2fbe9bb-f6b3-4cb5-8670-47890ed7ed4b", "LST_RECETE_TURU");
			//LST_RAPORUN_GECERLILIK_SURESI
			skrs_kodlari1.Add("3fb672ac-0675-44ef-9f91-86856dc79370", "LST_RAPOR_TURU");
			skrs_kodlari1.Add("e6e4e0ab-4f88-4e28-99cd-dd0dadcfbf3f", "LST_PSIKOLOJIK_TEDAVI");
			skrs_kodlari1.Add("8ed2e8ce-b1fe-49f6-91ac-8f3340deac9d", "LST_PSIKOLOJIK_DURUM_DEGERLENDIRMESI");
			skrs_kodlari1.Add("8e9f8b79-e70a-427f-ad8c-add091dd4a7c", "LST_POSTPARTUM_DEPRESYON");
			//LST_PARAZITIN_TURU
			skrs_kodlari1.Add("99db2341-c9e7-42a1-bed9-bb04e0388395", "LST_PAP_SMEAR_TESTI");
			//LST_PALYATIF_BAKIM
			skrs_kodlari1.Add("199cf767-f649-4c99-8b14-8c988515093f", "LST_OZURLULUK_DURUMU");
			skrs_kodlari1.Add("3854f1ab-d485-4882-9811-e1ec26ae35eb", "LST_OTOPSI_DURUMU");
			//LST_ORGAN_NAKLI_TURU
			skrs_kodlari1.Add("d7e6d65a-b82a-6717-e040-7c0a021654a2", "LST_ONCEKI_DOGUM_DURUMU");
			skrs_kodlari1.Add("a4a991c6-70fa-4e40-9ffe-aaea2150faf2", "LST_OLUM_YERI");
			skrs_kodlari1.Add("2ae7bfff-3f84-4d21-a9d9-8cdbfe693f08", "LST_OLUM_SEKLI");
			skrs_kodlari1.Add("95c5182e-9715-4c27-b91c-f178dc383b21", "LST_OLUM_NEDENI_TURU");
			//LST_OLASI_VAKA_TANI_KRITERI *-
			skrs_kodlari1.Add("1db040f2-9b97-4e25-97ad-cc295b2428ee", "LST_OKUL_CAGI_POSTUR");
			skrs_kodlari1.Add("3cdc2ba0-03de-46f4-8ace-684c94712349", "LST_OGRENIM_DURUMU");
			skrs_kodlari1.Add("43337672-caef-4731-862c-b1adb7dc16b4", "LST_OGRENCININ_SINIFI");
			skrs_kodlari1.Add("1f1cef7e-cf63-4a9f-a351-5118b4cd3b6f", "LST_OGRENCI_MUAYENE_IZLEM_ISLEMI");
			skrs_kodlari1.Add("e263f61b-bacb-482e-b048-f6eb89a6b3ba", "LST_OBEZITE_ILAC_TEDAVISI");
			//LST_NUKS_CESIDI
			skrs_kodlari1.Add("b409d9c0-fe50-43e0-afab-889cf87a2855", "LST_NTP_TAKIP_BILGISI");
			skrs_kodlari1.Add("6338d7a6-20e3-4124-8538-9bf4a08a28c6", "LST_NEFROPATI");
			//LST_NAKIL_YAPILAN_ORGAN
			//LST_MUAYENE_TURU
			//skrs_kodlari1.Add("2a610de0-7866-4b72-9372-29218cdaacfc", "LST_MSVS"); aktif kolonu yok
			skrs_kodlari1.Add("7516d5d8-7ed7-4bbc-88f6-cd26d7925c16", "LST_MORBID_OBEZ_HASTA_LENFATIK_ODEM_VARLIGI");
			//skrs_kodlari1.Add("c3eaf407-b302-5fdd-e043-14031b0a2484", "LST_MESLEKLER"); 1k dan fazla tablo var
			skrs_kodlari1.Add("3a39e318-9673-4dfe-842d-939cf487dc17", "LST_MESLEKI_MARUZIYET_DURUMU");
			//LST_MESLEK_VE_KANSER
			skrs_kodlari1.Add("600a900d-974b-48a3-bf2a-a8fc4752f57c", "LST_MEDENI_HALI");
			//LST_MARUZ_KALMA_ZAMAN_BIRIMI
			skrs_kodlari1.Add("397e2da4-e9be-4822-bd26-dbc82530c783", "LST_MAMOGRAFI_SONUCU");
			skrs_kodlari1.Add("6d1c6d74-d446-4d53-a056-5e75b19cad0f", "LST_MAMOGRAFI");
			//LST_MAHALLE_KODLARI *
			skrs_kodlari1.Add("21fcc6c7-1bd2-4f3f-86c2-7a0ef0002d87", "LST_MADDE_KULLANIMI");
			//LST_LATERALITE
			//LST_LABORATUVAR_TEYIDI
			//LST_KURUMLAR * güncelleme tarihi notlarından key görüntülenebiliyor sitede search edilmiyor
			//LST_KURUM_TURU her şey var lakin bilgiler uyuşmuyor
			skrs_kodlari1.Add("416e90f1-2de1-4739-a99e-00975bdeca26", "LST_KULTUR_SONUCU");
			skrs_kodlari1.Add("52d09f03-7eff-47aa-898f-f197e7597904", "LST_KULLANILAN_HELA_TIPI");
			skrs_kodlari1.Add("24d08065-6a3f-4ee3-b07b-1fe5d83241c1", "LST_KULLANILAN_AILE_PLANLAMASI_YONTEMI");
			skrs_kodlari1.Add("1435482c-1a3f-4f2d-b692-77c06f3827cd", "LST_KULLANDIGI_YARDIMCI_ARACLAR");
			//LST_KUDUZ_SUPHELI_TEMAS_DEGERLENDIRME_DURUMU
			skrs_kodlari1.Add("033f9c18-2d1b-41a1-a605-082595f93632", "LST_KUDUZ_PROFILAKSISI_TAMAMLANMA_DURUMU");
			//LST_KOY_KODLARI *
			skrs_kodlari1.Add("9462baa3-789f-4d54-9475-8d7cd186b408", "LST_KONUT_TIPI");
			skrs_kodlari1.Add("484b2fc2-d1a2-4675-872e-c2c56e72d921", "LST_KONJENITAL_ANOMALILI_DOGUM_VARLIGI");
			skrs_kodlari1.Add("72ee89f5-de3d-4b1a-b806-d73ea34acbd0", "LST_KOLON_GORUNTULEME_YONTEMI");
			skrs_kodlari1.Add("c04bee57-c5d4-443d-e040-7b0a6f146a3d", "LST_KLINIKLER");
			skrs_kodlari1.Add("46ff4cc1-3a97-4cb5-a188-b60ad5ef948c", "LST_KLINIK_MEME_MUAYENESI");
			skrs_kodlari1.Add("f71eb1ea-1854-4836-9319-3c549b8d49a5", "LST_KISIYE_PLANLANAN_KUDUZ_PROFILAKSISI");
			skrs_kodlari1.Add("b5366d27-e84c-49c7-ad1f-66ef7636969a", "LST_KISISEL_HIJYEN");
			skrs_kodlari1.Add("922fd54a-443f-4b47-9e82-53f9d7f96a0d", "LST_KISISEL_BAKIM");
			//LST_KIR_KENT Her şey var ama yedek dosyada belirtilmemiş durumu web serviste yok
			//LST_KESIN_VAKA_TANI_KRITERI *
			skrs_kodlari1.Add("ca7e0d3b-777c-4637-8094-1e17d4eca5f0", "LST_KENDI_KENDINE_MEME_MUAYENESI");
			//LST_KATEGORIZASYON
			//LST_KANSER_TAKIBI
			//LST_KANIN_ALINIS_NEDENI
			//LST_KANIN_ALINDIGI_SURVEYANS_YONTEMI
			skrs_kodlari1.Add("a3d6e943-5d85-4c75-ac72-709115974fb7", "LST_KAN_GRUBU");
			skrs_kodlari1.Add("baa4ecee-31c8-4fec-bbd6-8982289236c0", "LST_KADINA_YONELIK_SIDDET_SONUCU_YONLENDIRME_VE_DEGERLENDIRME");
			//LST_KADIN_SAGLIGI_RISK_TESPIT
			skrs_kodlari1.Add("4ccb2194-0ce3-4895-99ec-6712db7d0ad7", "LST_KADIN_SAGLIGI_RISK_FAKTORLERI");
			skrs_kodlari1.Add("9f10cc39-f47a-4611-b328-78e044a8a2bc", "LST_KADIN_SAGLIGI_ISLEMLERI");
			skrs_kodlari1.Add("05d2b394-9c2b-4b2a-8a3a-8b5023187502", "LST_KACINCI_LOHUSA_IZLEM");
			skrs_kodlari1.Add("402e5a45-f723-4309-9cb8-686358dee75a", "LST_KACINCI_IZLEM");
			skrs_kodlari1.Add("a280b762-8804-4049-b587-7c471ff2cbee", "LST_KACINCI_GEBE_IZLEM");
			//LST_KABUL_SEKLI
			//LST_ISINMA_TIPI
			skrs_kodlari1.Add("28a8a3fc-bea3-4da0-bcd6-d9537d379093", "LST_ISINMA");
			skrs_kodlari1.Add("c5a44219-28d5-4963-984c-93f56e51cfbd", "LST_IS_DURUMU");
			skrs_kodlari1.Add("bad13b15-cc1b-453b-802c-e7a257d2a7a0", "LST_INTIHAR_KRIZ_VAKA_TURU");
			skrs_kodlari1.Add("7c9c42e2-ecd0-425b-a1bb-73fe23947338", "LST_INTIHAR_KRIZ_VAKA_SONUCU");
			skrs_kodlari1.Add("e400057e-d8df-482d-9fa5-4d59571ff35b", "LST_INTIHAR_GIRISIMI_YA_DA_KRIZ_NEDENLERI");
			skrs_kodlari1.Add("bdced233-68b4-4264-86e7-a0a7985738e3", "LST_INSULIN_POMPASI");
			//LST_INSULIN_ENJEKSIYON_YERLERI_MUAYENE_SONUCU
			//LST_INSEKTISIT_UYGULAMASI
			skrs_kodlari1.Add("ecdaec49-6f7c-4fa9-9cbd-2dd40cfe39d1", "LST_IMMUNGLOBULIN_TURU");
			//LST_ILCE_KODLARI *
			//skrs_kodlari1.Add("c3eab581-ae56-5807-e043-14031b0acb40", "LST_ILACLAR");
			//LST_ILAC_RAPOR_DURUMU
			skrs_kodlari1.Add("32d57611-4928-46da-afac-624aaaa388d8", "LST_ILAC_KULLANIM_SEKLI");
			skrs_kodlari1.Add("64408499-b82a-4e64-805e-e821aa0c64c9", "LST_ILAC_KULLANIM_PERIYODU_BIRIMI");
			skrs_kodlari1.Add("06f4cabf-04d0-4a64-882c-ec73798a225c", "LST_ILAC_DIRENCI_VEREM");
			skrs_kodlari1.Add("932c2f19-dfd3-45c8-94c3-98ce9914425a", "LST_ILAC_ADI_VEREM");
			skrs_kodlari1.Add("5bc508fa-782a-4d75-831f-34948e350e72", "LST_IL_KODLARI");
			skrs_kodlari1.Add("f3d218b5-1a31-4e67-a5f2-72f2d412a802", "LST_IDRARDA_PROTEIN");
			//LST_ICME_SUYU_CESIDI
			//LST_ICD10_MSVS_ILISKISI *
			//LST_ICD10
			//LST_HUKUMLULUK_DURUMU
			skrs_kodlari1.Add("fe6835a3-5ee1-4d18-bb50-1f0cc336136a", "LST_HPV_TIPI");
			skrs_kodlari1.Add("a1edee3c-cdb4-4b36-810e-ae461b6faeeb", "LST_HPV_TARAMA_TESTI");
			//LST_HISTOLOJI hem yok hem de 700 tane veri var. Sonradan artabilir dikkat
			skrs_kodlari1.Add("c34de26e-5fb2-41d9-9b1c-20c41ba58879", "LST_HEMOGLOBINOPATI_TEST_SONUCU_TASIYICILIK_TURU");
			skrs_kodlari1.Add("6c4b59ec-cc85-4bfa-9405-739413633cdd", "LST_HEMOGLOBINOPATI_TEST_SONUCU_HASTALIK_TURU");
			skrs_kodlari1.Add("3f621539-c978-4208-b7ff-8c972064a08b", "LST_HEMOGLOBINOPATI_TARAMA_TESTI_SONUCU");
			skrs_kodlari1.Add("779c4080-5c1c-47b4-a885-4b52b4f7f8ce", "LST_HEMOGLOBINOPATI_ISLEM_TIPI");
			//LST_HELA_TIPI hem kullanılan hela tipi diye tabloda aynı bilgiler var hem de bunları kodları farklı
			//LST_HAYVANIN_SAHIPLIK_DURUMU
			//LST_HAYVANIN_SAHIPLIK_DURUMU
			skrs_kodlari1.Add("8999f472-8252-4dff-901e-66e3f9f57c68", "LST_HAYATI_TEHLIKE_DURUMU");
			skrs_kodlari1.Add("f3db1582-000e-47e8-a08c-8fe76ec37891", "LST_HASTANIN_TEDAVIYE_UYUMU");
			skrs_kodlari1.Add("5451a206-b7dc-4086-be04-fb929846f348", "LST_HASTALIK_TIPI");
			//LST_HASTALIK
			skrs_kodlari1.Add("c1cd773f-43aa-4481-e043-14031b0a83c7", "LST_HASTA_TIPI");
			//LST_HASTA_KAYIT_TURU
			skrs_kodlari1.Add("a043c0be-cd98-422c-8ca6-6c3b4872d1c9", "LST_GUVENLIK");
			skrs_kodlari1.Add("bb174db7-75ea-4bd4-a3e9-cf2a908511cb", "LST_GORME_TARAMA_SONUCU");
			skrs_kodlari1.Add("03dee8e4-6d54-4009-9b53-84c11d302e14", "LST_GKD_TARAMA_SONUCU");
			skrs_kodlari1.Add("eac44682-3583-47f3-8066-7310aac49a21", "LST_GESTASYONEL_DIYABET_TARAMASI");
			skrs_kodlari1.Add("a02655fd-acdf-4af9-84ba-ecb0d7d69247", "LST_GENCLIK_SAGLIGI_ISLEMLERI");
			//LST_GENC_KACINCI_IZLEM
			skrs_kodlari1.Add("b0f8712e-a51b-427a-a554-a21574abb07b", "LST_GELISIM_TABLOSU_BILGILERININ_SORGULANMASI");
			//LST_GELIR_DURUMU
			//LST_GECMISTE_TEDAVI_DURUMU
			//LST_GECMISTE_ATES_NOBETI
			skrs_kodlari1.Add("ad9ae051-f75d-4180-b57f-38f45132a1b0", "LST_GEBELIKTE_RISK_FAKTORLERI");
			//LST_GEBELIKTE_RISK_DURUMU
			//skrs_kodlari1.Add("b5070ebb-a700-46dd-8f50-bee87e4b4596", "LST_GEBELIK_SONUCU"); fazladan bilgi var yedek dosyada
			skrs_kodlari1.Add("86d2237f-1896-41cc-bfd5-7745cd576e2d", "LST_GEBELIK_LOHUSALIK_SEYRINDE_TEHLIKE_ISARETI");
			skrs_kodlari1.Add("fc683bce-5fc5-4aae-9924-33a84a4873fd", "LST_GEBELIK_ARALIGI");
			skrs_kodlari1.Add("02f4541a-3dcf-4519-9c43-c2251db70590", "LST_GEBEDE_SIK_IZLEME_ALINAN_RISK_ALTINDAKI_OLGUNUN_TAKIBI");
			skrs_kodlari1.Add("d6572124-7f21-4cf2-aad8-e6240ea06e2a", "LST_GEBEDE_RISK_FAKTORLERINE_YAPILAN_MUDAHALE");
			//LST_GEBE_BILGILENDIRME_VE_DANISMANLIK
			//LST_GAMETOSIT_DURUMU
			skrs_kodlari1.Add("a6a592bd-2653-4410-b03e-7b8cd712d3bb", "LST_GAITADA_GIZLI_KAN_TESTI");
			skrs_kodlari1.Add("a301b5d0-f467-458b-81e1-27a48a049c99", "LST_EVDE_SAGLIK_HIZMETLERI_HASTA_NAKLI");
			skrs_kodlari1.Add("bb0d92ea-397f-4c8d-989c-f00aa9d5d7ff", "LST_EVDE_SAGLIK_HIZMETININ_SONLANDIRILMASI");
			skrs_kodlari1.Add("d26c2f94-5506-4d1e-a138-27e920f61008", "LST_EV_HIJYENI");
			skrs_kodlari1.Add("d7d15411-dbc7-f5bd-e040-7c0a041665a6", "LST_ENDIKASYON_NEDENLERI");
			skrs_kodlari1.Add("f61204f8-08d4-4aae-9032-893f58319183", "LST_EGZERSIZ");
			//LST_EGITIM_KURUMUNA_DEVAM_ETME_DURUMU
			//LST_EGITIM_KURUMLARI *
			skrs_kodlari1.Add("3e30ff47-ed6f-425c-b099-5a4a8121fa10", "LST_EBEVEYNIN_PSIKOLOJIK_GELISIMI_DESTEKLEYICI_AKTIVITELERI");
			//LST_DUSUK_TURU
			skrs_kodlari1.Add("bc2104af-0c2b-4a9d-a450-c0827effe607", "LST_DOGUMUN_GERCEKLESTIGI_YER");
			skrs_kodlari1.Add("a85c1ba7-3ae9-44c5-b0d0-613f92c5281b", "LST_DOGUMA_YARDIM_EDEN");
			skrs_kodlari1.Add("c03d71af-54c5-4245-aea4-ad58e876e8bd", "LST_DOGUM_YONTEMI");
			skrs_kodlari1.Add("2a66899f-b4f1-43c2-a672-bb2d3d67e0cc", "LST_DOGUM_SIRASI");
			skrs_kodlari1.Add("7eff024d-9edb-4e99-a5ca-c35d72152bcf", "LST_DOGUM_AGIRLIGI");
			skrs_kodlari1.Add("8c0e3f06-e381-4415-9446-a6251d655f91", "LST_DIYET_TEDAVISI_TIBBI_BESLENME_TEDAVISI");
			//LST_DIYABETLI_HASTA_BASVURU_NEDENI
			skrs_kodlari1.Add("8cf96225-09f2-4e66-b1d3-5de56219a981", "LST_DIYABETLI_HASTA_AILE_OYKUSU");
			skrs_kodlari1.Add("00b6f165-eb7a-452f-b5d8-26d6c958a325", "LST_DIYABETLI_COCUGUN_PUBERTE_GELISIMI");
			skrs_kodlari1.Add("f4fae3f4-7fbf-4319-8b79-2035ef3647fe", "LST_DIYABETLI_COCUGUN_DOGUM_HAFTASI");
			skrs_kodlari1.Add("0d4c699c-06ca-4983-b3b5-617dd5def8e6", "LST_DIYABET_KOMPLIKASYONLARI");
			//skrs_kodlari1.Add("72f8fe9d-cdfe-4d8d-b154-66e0e706f06a", "LST_DIYABET_ILAC_TEDAVI_SEKLI"); yedek dosyada eksik veri var
			//LST_DIYABET_HASTASINA_EGZERSIZ_ONERILME_DURUMU
			skrs_kodlari1.Add("f007d4ed-302d-4b7a-897d-48240924bb2d", "LST_DIYABET_EGITIMI");
			skrs_kodlari1.Add("be92738b-e77e-47d4-9afb-266eca7c9ab9", "LST_DGT_UYGULAMASINI_YAPAN_KISI");
			skrs_kodlari1.Add("92ac5591-0042-4461-8d9b-4e0dfc7f086f", "LST_DGT_UYGULAMA_YERI");
			skrs_kodlari1.Add("83c966d5-1054-451c-87c6-19a0e11b287b", "LST_DEMIR_LOJISTIGI_VE_DESTEGI");
			skrs_kodlari1.Add("672986f8-5e0d-43a6-b417-37bdc59cd09b", "LST_D_VITAMINI_LOJISTIGI_VE_DESTEGI");
			//LST_CINSIYET_RESMI
			skrs_kodlari1.Add("784d0f4f-0603-4425-937f-1a3941fc3a1f", "LST_CINSIYET");
			//LST_CINSEL_PARTNER_BILGILERI
			skrs_kodlari1.Add("e8fba324-ae10-49a9-9178-e2c5ad0b57e9", "LST_CIKIS_SEKLI");
			//LST_CEZAEVI_TIPI
			//LST_CALISMA_DURUMU
			//LST_BUCAK_KODLARI *
			skrs_kodlari1.Add("1ac7dc71-e09d-4ddd-bea5-179735d35246", "LST_BIR_SONRAKI_HIZMET_IHTIYACI");
			skrs_kodlari1.Add("c6652612-6fcb-6fa8-e040-7c0a011670bd", "LST_BILDIRIMI_ZORUNLU_ASI_SONRASI_ISTENMEYEN_ETKI");
			skrs_kodlari1.Add("6a220e1d-3865-4cab-b98f-b7933d9aa1ba", "LST_BESLENME");
			//LST_BEBEKTE_RISK_FAKTORLERI
			skrs_kodlari1.Add("ae5efc06-8f12-4f4e-9c50-3cc5e5dfa5de", "LST_BEBEK_OLUM_NEDENLERI");
			skrs_kodlari1.Add("9d81738b-2e2d-4251-b397-34dfb014dc9b", "LST_BEBEK_COCUKTA_SIK_IZLEME_ALINAN_RISK_ALTINDAKI_OLGUNUN_TAKIBI");
			//LST_BEBEK_COCUK_TARAMA_SONUCLARI
			//LST_BEBEK_COCUK_SAGLIGI
			//LST_BEBEK_COCUK_GELISIM_TABLOSU
			skrs_kodlari1.Add("27f5f375-1755-4d5b-ba13-0b0f6817bfa5", "LST_BEBEGIN_COCUGUN_RISK_FAKTORLERINE_YAPILAN_MUDAHALE");
			skrs_kodlari1.Add("58078833-09f4-4046-883e-81777a548af0", "LST_BEBEGIN_COCUGUN_PSIKOLOJIK_GELISIMINDEKI_RISKLERE_YONELIK_EGITIMLER");
			skrs_kodlari1.Add("c81e3e71-8c22-4363-af86-3b687c91b063", "LST_BEBEGIN_COCUGUN_BEYIN_GELISIMINI_ETKILEYEBILECEK_RISKLER");
			skrs_kodlari1.Add("7f29ff54-3810-4875-9dda-01ac0d70fa21", "LST_BEBEGIN_BESLENME_DURUMU");
			skrs_kodlari1.Add("8f04bf30-3501-4080-91df-458e20917be2", "LST_BASVURU_TURU");
			//LST_BASKA_SITMA_VAKASI
			//LST_BASKA_BIR_VAKA_ILE_EPIDEMIYOLOJIK_BAGLANTI
			skrs_kodlari1.Add("26f3177d-b761-4e29-bbbc-b4fac7df3322", "LST_BASI_DEGERLENDIRMESI");
			skrs_kodlari1.Add("5342dd3f-5606-47a1-b6be-4a4427a02f4a", "LST_BAGIMLI_OLDUGU_URUN");
			//LST_AYNI_EVDE_ATES_GECIREN_KISI_DURUMU
			skrs_kodlari1.Add("cd2deead-3154-424b-88de-85b38ff63958", "LST_AYDINLATMA");
			skrs_kodlari1.Add("f20210e0-d780-4961-87eb-3323000b7dbb", "LST_ASININ_UYGULAMA_SEKLI");
			skrs_kodlari1.Add("15068142-6853-4dab-86e1-e45e6e93b150", "LST_ASININ_SAGLANDIGI_KAYNAK");
			//LST_ASILAR *-
			skrs_kodlari1.Add("c6651718-aa25-a422-e0407-c0a011657e6", "LST_ASI_YAPILMAMA_NEDENI");
			skrs_kodlari1.Add("0d70eb6c-1b87-4a23-a744-d4dd68210270", "LST_ASI_YAPILMAMA_DURUMU");
			skrs_kodlari1.Add("eb66330f-2b96-40a7-931e-fc9aed2b9409", "LST_ASI_UYGULAMA_YERI");
			skrs_kodlari1.Add("0a8f681f-4ed0-4830-9dc9-a0295686398b", "LST_ASI_OZEL_DURUMU_NEDENI");
			skrs_kodlari1.Add("da92a50e-b1a8-4e6a-be8c-2b6ca2c0a58b", "LST_ASI_DOZU");
			//LST_ANOFEL_DURUMU
			skrs_kodlari1.Add("16073eac-a3f9-4efb-91ac-a08442c240a4", "LST_ANNE_OLUM_ZAMANI");
			skrs_kodlari1.Add("b9740b2a-67b5-47e4-beb4-95388d050929", "LST_ANNE_OLUM_NEDENI");
			//LST_AMELIYAT_GECMISI
			//LST_AMBULANS_ILE_GELIS_DURUMU
			skrs_kodlari1.Add("7e3e39e1-d1d8-481f-b898-174c5efa06e7", "LST_ALKOL_KULLANIMI");
			skrs_kodlari1.Add("8335af99-322d-4aa5-bdaa-f888b351a30a", "LST_AILE_PLANLAMASI_YONTEMI_LOJISTIGI");
			skrs_kodlari1.Add("084620ca-5f25-469b-af47-158f760f16b5", "LST_AILE_PLANLAMASI_YONTEMI_KULLANMAMA_NEDENI");
			skrs_kodlari1.Add("a87d1c7a-36f1-4950-87a3-0cc1b61c1265", "LST_AGRI");
			//LST_AGIZDAN_SIVI_TEDAVISI
			skrs_kodlari1.Add("ddb59d45-97c3-4b87-ba90-03fc7689b7eb", "LST_AFET_OLAY_VATANDAS_TIPI");
			skrs_kodlari1.Add("4f293bf2-111c-47e1-adbd-9e9f33488e77", "LST_AFET_OLAY_TIPI");
			//LST_AFET_OLAY boş
			skrs_kodlari1.Add("35f4968a-3e72-41ce-9ae4-f4d22f90ea2e", "LST_ADRES_TIPI");
			skrs_kodlari1.Add("aa0e83ba-e9db-4817-80da-577fd6a17373", "LST_ADRES_KODU_SEVIYESI");
			//LST_ADLI_VAKA_GELIS_SEKLI
			//HRC_LST_RAPOR_TURU tabloda eksikler var
			#endregion

		}

		public int SkrsGuncellemeKontrolu(DateTime date)
		{
			HttpResponseMessage message = new HttpResponseMessage();
			string cevabim;
			JObject cevap_json;
			message = client.GetAsync("http://skrs.saglik.gov.tr/api/SkrsService/GetSkrsList?baslangicTarihi=" + date).Result;
			cevabim = message.Content.ReadAsStringAsync().Result;
			cevap_json = JObject.Parse(cevabim);

			Console.ReadLine();
			foreach (var x in cevap_json["sonuc"])
			{
				/*
				if (skrs_kodlari1.ContainsKey((string)x["kodu"]))
				{
					Console.WriteLine(x);
					ilacim((string)x["kodu"]);
					
				}
				*/
				if (x["kodu"].ToString() == "c3eaabad-8c4c-56ee-e043-14031b0a5530")
				{
					Console.WriteLine(x);
					Console.ReadLine();
					SayfaSorgula((string)x["kodu"]);
				}
			}
			return 1;
		}




		public bool SayfaSorgula(string code, string page = "1")
		{
			HttpResponseMessage message = new HttpResponseMessage();
			string cevabim;
			JObject cevap_json;
			if (code == "c3eab581-ae56-5807-e043-14031b0acb40")
				message = client.GetAsync("http://skrs.saglik.gov.tr/api/SkrsService/GetSkrsIlac?skrsCodeSystemGuid=" + code + "&page=" + page).Result;
			else
				message = client.GetAsync("http://skrs.saglik.gov.tr/api/SkrsService/GetSkrsObject?skrsCodeSystemGuid=" + code + "&page=" + page).Result;
			cevabim = message.Content.ReadAsStringAsync().Result;
			cevap_json = JObject.Parse(cevabim);

			UpdateSkrs(cevap_json, code);

			return true;
		}

		public bool TekilSorgu(string code, string page = "1")
		{
			HttpResponseMessage message = new HttpResponseMessage();
			string cevabim;
			JObject cevap_json;
			if (code == "c3eab581-ae56-5807-e043-14031b0acb40")
				message = client.GetAsync("http://skrs.saglik.gov.tr/api/SkrsService/GetSkrsIlac?skrsCodeSystemGuid=" + code + "&page=" + page).Result;
			else
				message = client.GetAsync("http://skrs.saglik.gov.tr/api/SkrsService/GetSkrsObject?skrsCodeSystemGuid=" + code + "&page=" + page).Result;
			cevabim = message.Content.ReadAsStringAsync().Result;
			cevap_json = JObject.Parse(cevabim);

			UpdateSkrs(cevap_json, code);

			return true;
		}


		public bool UpdateSkrs(JObject json_obje, string code)
		{
			DateTime tarih = new DateTime(2022, 07, 04);
			DateTime olusturulma_tarihi = new DateTime();
			DateTime guncelleme_tarihi = new DateTime();
			Sql a = new Sql();

			string ad = "ADI";
			string kod = "KODU";
			string aktif = "AKTIF";
			string Strolusturulma_tarihi = "OLUSTURULMATARIHI";
			string Strguncelleme_tarihi = "GUNCELLEMETARIHI";
			if (code == "d2fe70a0-cb28-4178-abc4-99551454203a" || code == "dd4d3adc-4261-4189-aab6-125ad8122144" || code == "85ddd365-fe96-497d-8a63-4a0245484e6f")
			{
				ad = "adi";
				kod = "kodu";
				aktif = "aktif";
				Strolusturulma_tarihi = "olusturulmatarihi";
				Strguncelleme_tarihi = "guncellenmetarihi";
			}
			//Console.WriteLine(json_obje);
			//Console.ReadLine();
			foreach (var y in json_obje["sonuc"]["kayit"])
			{

				Console.WriteLine(y["ADI"]);
				Console.WriteLine(y["KODU"]);
				Console.WriteLine(y["MERNISKODU"]);
				Console.WriteLine(y["AKTIF"]);

				try
				{
					olusturulma_tarihi = DateTime.Parse(y[Strolusturulma_tarihi].ToString());
				}
				catch
				{
					olusturulma_tarihi = new DateTime();
				}
				try
				{
					guncelleme_tarihi = DateTime.Parse(y[Strguncelleme_tarihi].ToString());
				}
				catch
				{
					guncelleme_tarihi = new DateTime();
				}


				if (tarih < olusturulma_tarihi)
				{
					if (skrs_kodlari1.ContainsKey(y[kod].ToString()))
						a.liste_ekle_klasik(skrs_kodlari1[code], y[kod].ToString(), y[ad].ToString(), y[aktif].ToString());
					else
						a.liste_ekle_yonlendirci(y, code);

				}
				else
					Console.WriteLine("----------------------");


				if (tarih < guncelleme_tarihi)
				{
					if (skrs_kodlari1.ContainsKey(y[kod].ToString()))
						a.liste_guncelle_klasik(skrs_kodlari1[code], y[kod].ToString(), y[ad].ToString(), y[aktif].ToString());
					else
						a.liste_guncelle_yonlendirci(y, code);
					Console.WriteLine("EKLEDİM Bİ BAK BAKALIM");
					Console.ReadLine();
				}
				else
					Console.WriteLine("----------------------");

				Console.WriteLine("*----**");
			}

			Console.WriteLine(json_obje["sonuc"]["sonrakiSayfa"]);
			Console.ReadLine();
			if (json_obje["sonuc"]["sonrakiSayfa"].ToString() != "1")
				SayfaSorgula(code, json_obje["sonuc"]["sonrakiSayfa"].ToString());

			return true;

		}
	}
}
