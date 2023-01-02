using Microsoft.Web.Services3.Design;
using Microsoft.Web.Services3.Security.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web;
using System.Web.Services.Description;
using System.Security.Policy;
using Microsoft.Web.Services3.Security.Xml;

namespace DenemeEnabiz
{
	public  class WsEnabiz
	{
		private string kullaniciAdi = "31289355994";
		private string sifre = "98765432Uy.";

		private string XmlUyumlusu(string _string) => _string.Trim().Replace("&", "&amp;").Replace("<", "&lt;").Replace(">", "&gt;").Replace("\"", "&quot;").Replace("'", "&apos;");
		private string kurumKodu = "455470";
		private string kurumAdi = "İSTANBUL ARNAVUTKÖY 050 NOLU AİLE HEKİMLİĞİ BİRİMİ";
		private string firmaKodu = "";

		private SYSWS client = new SYSWS();
		private Policy myPolicy = new Policy();

		public WsEnabiz()
		{
			myPolicy.Assertions.Add(new UsernameOverTransportAssertion());
			client.Timeout = (30 < 60 ? 60 : 30) * 1000;

			client.SetClientCredential<UsernameToken>(new UsernameToken(kullaniciAdi, sifre, PasswordOption.SendPlainText));
			client.SetPolicy(myPolicy);
		}


        public string hazirla(string xmlString,List<string> degisecek, List<string> degistirilecek)
        {
			xmlString = xmlString.Replace("girKurumKodu", kurumKodu);
			xmlString = xmlString.Replace("girKurumAdi", kurumAdi);
			xmlString = xmlString.Replace("girFirmaKodu", firmaKodu);
			xmlString = xmlString.Replace("girGuid", Guid.NewGuid().ToString());
			xmlString = xmlString.Replace("girTarih", DateTime.Now.ToString("yyyyMMddHHmm"));

            for (int i = 0; i < degisecek.Count; i++)
                xmlString = xmlString.Replace(degisecek.ElementAt(i), degistirilecek.ElementAt(i));
			


			return xmlString;
		}
        

		public string SysTakipNoSorgula(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\SysTakipNoSorgula.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();
            List<string> degisecek = new List<string>
            {
                "girSysTakipNo"
            };

			xmlString = hazirla(xmlString, degisecek, degistirilecek);

			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string AsiSonrasiIstenmeyenEtkiVeriSeti(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\AsiSonrasiIstenmeyenEtkiVeriSeti.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();
			List<string> degisecek = new List<string>
			{
				"girAsi",
				"girAsieOrtayaCikisNedeni",
				"girAsininDozu",
				"girAsiUygulamaYeri",
				"girBildirimiZorunluAsiSonrasiIstenmeyenEtkiNedeni",
				"girAcikAdres",
				"girAdresKodu",
				"girAdresKoduSeviyesi",
				"girAdresTipi",
				"girSysTakipNo",

			};

			xmlString = hazirla(xmlString, degisecek, degistirilecek);

			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}

		public string MuayeneBilgisiKayit(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\MuayeneBilgisiKayit.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();
			List<string> degisecek = new List<string>
			{
				"girTarih", "girKurumKodu", "girKurumAdi", "girFirmaKodu", "girSysTakipNo",
				"girReceteTarihi", "girReceteNumarasi", "girReceteTuru", "girHekimKimlikNumarasi", "girIlacBarkodu",
				"girIlacAdi", "girKutuAdeti", "girIlacKullanimSekli", "girIlacKullanimSayisi", "girIlacKullanimDozu",
				"girIlacKullanimPeriyodu", "girIlacKullanimPeriyoduBirimi", "girIlacAciklama", "girRaporTarihi", "girRaporNumarasi",
				"girRaporTuru", "girRaporBaslangicTarihi", "girRaporBitisTarihi", "girRaporTakipNumarasi", "girRaporPdfBilgisi", 
				"girCheckUpBilgisi", "girSigaraKullanimDurumu", "girPaketeAitIslemZamani", "girMuayeneBaslangicTarihi", "girMuayeneBitisTarihi",
				"girEpikrizBilgisiBaslik", "girEpikrizBilgisiAciklama", "girTaniTuru", "girIcd10", "girBoy",
				"girKilo", "girTibbiGenetikUzmanGorusu", "girNadirHastalikTani"
			};

			xmlString = hazirla(xmlString, degisecek, degistirilecek);

			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}

		public string LaboratuvarSonucKayit(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\LaboratuvarSonucKayit.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();
			List<string> degisecek = new List<string>
			{
				"girSysTakipNo",
				"girPaketeAitIslemZamani",
				"girIslemReferansNumarasi",
				"girTetkikOrnekNumarasi",
				"girTetkikOrnegininAlindigiZaman",
				"girTetkikOrnegininKabulZamani",
				"girTetkikSonucTarihi",
				"girTetkikSonucOnayTarihi",
				"girSonucDisErisimBilgisi",
				"girLoincKodu",
				"girTetkikSonucParametreAdi",
				"girTetkikSonucu",
				"girTetkikSonucuBirimi",
				"girTetkikSonucuReferansDegeri",
				"girTetkikSonucuReferansDegerAraligindaMi",

			};

			xmlString = hazirla(xmlString, degisecek, degistirilecek);

			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}


		public string HastaKayit(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\HastaKayit.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();
			List<string> degisecek = new List<string>
			{
				"girGuid","girTarih","girKurumKodu","girKurumAdi","girSysTakipNo",
				"girBabaKimlikNumarasi","girGeldigiUlke","girTelefonNumarasi","girRandevuZamani","girDonorAliciKimlikNumarasi",
				"girHastaKimlikNumarasi","girAd","girSoyad","girDogumTarihi","girCinsiyet",
				"girUyruk","girAnneKimlikNumarasi","girDogumSirasi","girYabanciHastaKimlikNumarasi","girPasaportNo",
				"girkimliksizHastaBilgisi","girBeyanDogumTarihi","girHastaTipi","girEpostaAdresi","girYabanciHastaTuru",
				"girYupassNo","girAdresKoduSeviyesi","girAdresKodu","girAcikAdres","girAcikAdresİlce",
				"girSpkKodu","girAmbulansTakipNumarasi","girPaketeAitİslemZamani","girHizmetSunucu","girKayitYeri",
				"girProtokolNumarasi","girHastaneReferansNumarasi","girSgkTakipNumarasi","girKabulZamani","girKlinikKodu",
				"girSosyalGuvenceDurumu","girHekimKimlikNumarasi","girVakaTuru","girMhrsRandevuNumarasi","girTriaj",
				"girYatisKabulZamani","girYatakNo","girYatisGunubirlikMi","girYatisinAciliyeti"
			};

			xmlString = hazirla(xmlString, degisecek, degistirilecek);

			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string AySonuVeriSeti(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\AySonuVeriSeti.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
		{
		"girKayitYeri",
		"girKaliteYil",
		"girKaliteAy",
		"girKlinikKodu",
		"girKlinikKaliteTanim",
		"girKlinikKaliteSayi",
		};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string DoktorMesajiPaketi(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\DoktorMesajiPaketi.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
		{
		"girSysTakipNo",
		"girHastaMesajlariTuru",
		"girMesajDetayi",
		"girMesajTarihi",
		};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string DonemSonlandirma(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\DonemSonlandirma.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
		{
		"girKayitYeri",
		"girManuelPuan",
		"girHekimKimlikNumarasi",
		"girDonem",
		"girOnayZamani",
		};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string EkOdemeKayit(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\EkOdemeKayit.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
		{
		"girDonembaslangictarihi",
		"girDonembitistarihi",
		"girToplamhizmetpuani",
		"girHastanetoplampuani",
		"girDagitilmasiplanlanantutar",
		"girDagitilantutar",
		"girKatsayi",
		"girKatkiyapanpersonelsayisi",
		"girPersonelKimlikNumarasi",
		"girNetperformanspuani",
		"girTavanekodemetutari",
		"girBrutekodeme",
		"girNetekodeme",
		};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string EvdeSaglikHizmetEmri(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\EvdeSaglikHizmetEmri.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
		{
		"girAtayanKurumKodu",
		"girAciklama",
		"girHizmetEmriTarihi",
		};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string GunlukVeriSorgulama(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\GunlukVeriSorgulama.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
		{
		"girSorguTarihi",
		};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}

		public string HastaKayitSilme(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\HastaKayitSilme.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
		{
		"girSysTakipNo"
		};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string HastalikTakibiVeriSeti(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\HastalikTakibiVeriSeti.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
		{
		"girTakipTipi",
		"girTakipTamamlanmaDurumu",
		"girKronikHastalikBilgisi",
		"girTakipTarihi",
		"girPlanlananTakipTarihi",
		"girSigaraKullanimi",
		"girAlkolKullanimi",
		"girTaniTuru",
		"girIcd10",
		"girVitalBulgu",
		"girVitalBulguDegeri",
		"girVitalBulguBirimi",
		"girHedefSaglikUzmaniAciklamasi",
		"girHedefBaslangicTarihi",
		"girHedefHastaAciklamasi",
		"girHedefBitisTarihi",
		"girHedeflenenParametre",
		"girHedeflenenParametreAltLimiti",
		"girHedeflenenParametreUstLimiti",
		"girHastayaGosterilmeDurumu",
		"girHedeflenenParametreBirimi",
		"girBirOncekiHedefeUlasmaDurumu",
		"girHedeflenenParametreSonOlcumDegeri",
		"girHedeflenenParametreSonOlcumZamani",
		"girSevkIstegi",
		"girLaboratuvarIstegi",
		"girDavranisOnerisi",
		"girEgitimMateryali",
		"girAktiviteSaglikUzmaniAciklama",
		"girAktiviteHastaAciklamasi",
		"girAktiviteBaslangicTarihi",
		"girAktiviteBitisTarihi",
		"girAktiviteUygulamaFrekansi",
		"girAktiviteUygulamaPeriyodu",
		"girAktiviteUygulamaMiktari",
		"girAktiviteUygulamaMiktariBirimi",
		"girAktiviteUygulamaPeriyoduBirimi",
		"girShmSevkIstegi",
		"girIlacIstegiAdi",
		"girIlacIstegiAtcKodu",
		"girAsiIstegi",
		"girSysTakipNo"
		};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string HastaNakilIptal(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\HastaNakilIptal.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
		{
		"girNakilReferansNumarasi",
		"girNakilIptalNedeni",
		"girSysTakipNo"
		};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string HastaneReferansNumarasiSorgulama(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\HastaneReferansNumarasiSorgulama.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
		{
		"girHastaneReferansNumarasi",
		};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string HastaOzlukBilgileri(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\HastaOzlukBilgileri.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
		{
		"girKanGrubu",
		"girMeslek",
		"girIsDurumu",
		"girOgrenimDurumu",
		"girEngellilikDurumu",
		"girEvlenmeYasi",
		"girBoy",
		"girKilo",
		"girAlerjiler",
		"girAlkolKullanimi",
		"girMaddeKullanimi",
		"girSigaraKullanimi",
		"girSigaraAdedi",
		"girTelefonNumarasi",
		"girEpostaAdresi",
		"girAcikAdres",
		"girAdresKodu",
		"girAdresKoduSeviyesi",
		"girAdresTipi",
		"girTelefonTipi",
		"girSysTakipNo"
		};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string HemoglobinopatiTaramaVeriSeti(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\HemoglobinopatiTaramaVeriSeti.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
		{
		"girHemoglobinopatiTaramaSonucu",
		"girEsAdayiKimlikNumarasi",
		"girEsAdayiTelefonNumarasi",
		"girHemoglobinopatiTaramaTestiSonucu",
		"girHemoglobinopatiIslemTipi",
		"girHemoglobinapatiTestSonucuHastalikTuru",
		"girHemoglobinopatiTestSonucuTasiyicilikTuru",
		"girSysTakipNo"
		};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string HizmetSilme(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\HizmetSilme.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
		{
		"girSysTakipNo",
		"girIslemReferansNumarasi",
		};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string HPVTaramaSonucu(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\HPVTaramaSonucu.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
		{
		"girHpvTaramaTesti",
		"girHpvTipi",
		"girServikalSitolojiSonucu",
		"girHpvBarkodNumarasi",
		"girHpvTaramaSonucZamani",
		"girHpvTaramaSonuclandiranKurumKodu",
		"girSysTakipNo"
		};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string HYPFizikselBulgular(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\HYPFizikselBulgular.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
		{
		"girHypAgirlikBilgisi",
		"girHypBoyBilgisi",
		"girHypSistolikKanBasinci",
		"girHypDiastolikKanBasinci",
		"girHypNabiz",
		"girHypAtes",
		"girHypBelCevresi",
		"girHypKalcaCevresi",
		"girHypVucutYagKitlesiAgirligi",
		"girHypAlkolKullanimi",
		"girHypEgzersizYapmaDurumu",
		"girHypSigaraKullanimi",
		"girSysTakipNo"
		};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string IsitmeTaramaVeriPaketi(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\IsitmeTaramaVeriPaketi.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
		{
		"girTaramaTuru",
		"girIslemTarihi",
		"girAileOnayi",
		"girAiledeIsitmeKaybi",
		"girTakipTarihi",
		"girBebekCocuktaOlanDurumlarYogunBakim",
		"girBebekCocuktaSendromikHastaliklar",
		"girBebekCocuktaKraniyofasiyalAnomaliler",
		"girAnneGebelikSirasindaOlanDurumlar",
		"girBebekCocuktaOlanDurumlar",
		"girTesteEngelDurum",
		"girTestTuru",
		"girTestSonucu",
		"girSagKulakSonuc",
		"girSolKulakSonuc",
		"girOkulIli",
		"girOkulIlcesi",
		"girOkulKodu",
		"girOkulAdi",
		"girOkulTaramaIslem",
		"girSevkIli",
		"girSevkMerkeziKurumKodu",
		"girSevkMerkezi",
		"girMerkezDurumu",
		"girSysTakipNo"
		};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string KanTransfuzyonuVeriSeti(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\KanTransfuzyonuVeriSeti.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
		{
		"girKanGrubu",
		"girRhAntijenProfili",
		"girKanTransfuzyonuNotlar",
		"girDigerKanTransfuzyonEndikasyonuAciklama",
		"girDigerAntijenProfili",
		"girKanTransfuzyonuTamamlanmamaNedeni",
		"girTransfuzeEdilenToplamMiktar",
		"girKanTransfuzyonBaslangicZamani",
		"girKanTransfuzyonBitisZamani",
		"girKanTransfuzyonEndikasyonu",
		"girKanTransfuzyonTamamlanmaDurumu",
		"girIslemReferansNumarasi",
		"girIsbtUniteNo",
		"girIsbtBilesenKodu",
		"girSysTakipNo"
		};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string MalzemeKesinlestirmeVeriSeti(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\MalzemeKesinlestirmeVeriSeti.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
		{
		"girSeriNo",
		"girLotNo",
		"girKullanimBildirimId",
		"girIslemReferansNumarasi",
		"girSysTakipNo"
		};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string MamografiBildirim(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\MamografiBildirim.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
		{
		"girHastaKimlikNumarasi",
		"girHekimKimlikNumarasi",
		"girAd",
		"girSoyad",
		"girDogumTarihi",
		"girTelefonNumarasi",
		"girMobilKetemKodu",
		"girSysTakipNo"
		};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string MamografiIptal(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\MamografiIptal.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
		{
		"girSysTakipNo",
		"girHastaKimlikNumarasi",
		"girHekimKimlikNumarasi",
		"girMamografiErisimNo",
		};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string MamografiSonuc(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\MamografiSonuc.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
		{
		"girHastaKimlikNumarasi",
		"girHekimKimlikNumarasi",
		"girMamografiErisimNo",
		"girSysTakipNo"
		};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string MelisIstemIptal(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\MelisIstemIptal.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
		{
		"girIstekKabulId",
		"girLbysBarkodNumarasi",
		"girSysTakipNo"
		};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string MelisIstemVeriPaketi(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\MelisIstemVeriPaketi.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
		{
		"girBabaAdi",
		"girGonderilenLabId",
		"girNumuneAlinmaTarihi",
		"girIstemYapanDrTcKimlik",
		"girIstemYapanDrAdiSoyadi",
		"girIstemYapanDrTel",
		"girIstemYapanDrMail",
		"girHastaTelefonNumarasi",
		"girBarkodNumarasi",
		"girEsAdayTcKimlikNo",
		"girIslemTipi",
		"girMelisHastaAdresBilgisi",
		"girSysTakipNo"
		};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string MeslekiMaruziyet(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\MeslekiMaruziyet.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
		{
		"girMeslek",
		"girMeslekiMaruziyetDurumu",
		"girIcd10",
		"girSysTakipNo"
		};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string MisafirAnneTalepleri(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\MisafirAnneTalepleri.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
		{
		"girHastaKimlikNumarasi",
		"girSonAdetTarihi",
		"girTalepTarihi",
		"girTalepNedeni",
		"girHastaOnayDurumu",
		"girRedNedeni",
		"girAileHekimligiBirimKodu",
		};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string SaglikTesisiBilgileri(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\SaglikTesisiBilgileri.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
		{
		"girMedulaTesisKodu",
		"girHizmetSunucu",
		"girMedulaTesisAdi",
		"girKayitYeri",
		};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string SGKISLEMBILDIR(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\SGKISLEMBILDIR.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
		{
		"girIslemReferansNumarasi",
		"girSgkTakipNumarasi",
		"girSgkHizmetReferansNumarasi",
		"girSgkBildirim",
		"girSysTakipNo"
		};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string SMATarama(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\SMATarama.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
		{
		"girSmaIslemTipi",
		"girEsAdayiKimlikNumarasi",
		"girEsAdayiTelefonNumarasi",
		"girSmaTaramaTestiSonucu",
		"girSmaGenetikTaniSonucu",
		"girSmaTaramaSonucu",
		"girSysTakipNo"
		};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string TAVIGirisimveIslemSonuVeriSeti(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\TAVIGirisimveIslemSonuVeriSeti.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
		{
		"girTaviUzmanNotu",
		"girAortKapagiOrtalamaGradiyent",
		"girSolVentrikulEjeksiyonFraksiyonu",
		"girAortikBalonValvuloplastiYapilmisMi",
		"girKullanilanBalonCapi",
		"girGirisimYeri",
		"girSheathSizePerkutanIse",
		"girKullanilanKapaginSutKodu",
		"girKullanilanKapaginKureselUrunBarkodu",
		"girKullanilanKapakSize",
		"girVaskulerKapatmaTeknigi",
		"girBasariliKapakYerlestirme",
		"girAortYetersizligiAnjiyografiDereceBilgisi",
		"girDamarYaralanmasiBilgisi",
		"girSerebrovaskulerOlayBilgisi",
		"girAortYetersizligiEkokardiyografiIle",
		"girAortYetersizligiAnjiyografiIle",
		"girTaviOlum",
		"girMiyokardInfarktusu",
		"girTamponad",
		"girTamponadIslemBilgisi",
		"girDamarYaralanmasiGelismisMi",
		"girMajorApikalKanulasyonKomplikasyonlariGelismisMi",
		"girAnaKoronereMudahaleGerektirenKurtarmaGelismisMi",
		"girKalpPiliGerektirenYeniIletimAnormalligiGelismisMi",
		"girAcilKapakCerrahisineDonusum",
		"girAcilValveInValveUygulamasiGerekenDurumGelismisMi",
		"girKardiyojenikSokGelismisMi",
		"girCihazEmbolizasyonuGelismisMi",
		"girAnnulerRupturGelismisMi",
		"girSerebrovaskulerOlayGelismisMi",
		"girMiyokardInfarktusuGelismisMi",
		"girValveInValveImplatasyonuGerektirecekOlayGelismisMi",
		"girCerrahiAortKapakReplasmaniGerektirecekOlayGelismisMi",
		"girKaliciKalpPiliGerektirecekOlayGelismisMi",
		"girCihazinYerDegistirmesi",
		"girKanamaKomplikasyonlari",
		"girKanamaKomplikasyonlariBilgisi",
		"girTaviKanTransfuzyonu",
		"girAkutBobrekHasari",
		"girGirisimSonrasiYeniHemofiltrasyonVeyaDiyaliz",
		"girCerrahiGerektirenVaskulerKomplikasyonlar",
		"girSysTakipNo"
		};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string TAVIKayitVeriSeti(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\TAVIKayitVeriSeti.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
		{
		"girFormuDolduranHekimKimlikNumarasi",
		"girIslemReferansNumarasi",
		"girStsSkoru",
		"girSigaraIciyorMu",
		"girFizikselAktiviteDuzeyiAzalmisMi",
		"girNorolojikHastalikOykusu",
		"girMalignensiOykusu",
		"girGecirilmisKalpAmeliyati",
		"girOncekiPerkutanAortikKapakGirisimi",
		"girGirisimOncesiEslikEdenCiddiDurumVarMi",
		"girOncekiPerkutanKoronerIslem",
		"girTaviVucutKitleIndexi",
		"girRitimBozukluguIslemOykusu",
		"girNewYorkHeartAssociationDispneDurumu",
		"girTaviFizikselAktivite",
		"girIslemOncesiKalpRitmi",
		"girGirisimOncesiEslikEdenCiddiDurum",
		"girKoronerArterHastalikBilgisi",
		"girSolAnaKoronerDamarHastaligiBilgisi",
		"girKoronerArterHastaligiVarMi",
		"girAortKapagiPeakGradiyent",
		"girAortKapagiOrtalamaGradiyent",
		"girAortKapakAlani",
		"girSistolikPulmonerArterBasinci",
		"girSolVentrikulEjeksiyonFraksiyonu",
		"girAortDarligininTipi",
		"girAortKapagininYapisi",
		"girSolAnaKoronerDamarHastaligiVarMi",
		"girTrikuspitKapakPatolojisi",
		"girAortikAnnulerOlcumYontemiBilgisi",
		"girAortikAnulerOlcumYontemiDegeri",
		"girAortKapakPatolojisiBilgisi",
		"girAortKapakPatolojisininEtiyolojisiBilgisi",
		"girMitralKapakPatolojisi",
		"girMitralKapakPatolojiDerecesi",
		"girSysTakipNo"
		};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string UzaktanSaglikBilgiSistemiVeriSeti(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\UzaktanSaglikBilgiSistemiVeriSeti.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
		{
		"girHekimKimlikNumarasi",
		"girKlinikKodu",
		"girUsbsFirmaKodu",
		"girUsbsMuayeneBaslangicZamani",
		"girUsbsMuayeneBitisZamani",
		"girUsbsMuayeneGoruntuKaydi",
		"girUsbsMuayeneSesKaydi",
		"girUsbsMuayeneDosyaGonderim",
		"girSysTakipNo"
		};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string VatandasKayit(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\VatandasKayit.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
		{
		"girHastaKimlikNumarasi",
		"girAnneKimlikNumarasi",
		"girSysTakipNo"
		};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string YatakBilgisiKayit(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\YatakBilgisiKayit.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
		{
		"girPaketeAitIslemZamani",
		"girTarih",
		"girKayitYeri",
		"girKlinikKodu",
		"girKlinikDurumu",
		"girKlinikKapaliOlmaNedeni",
		"girYatakTuru",
		"girToplamYatak",
		"girBosYatak",
		"girRezerveYatak",
		"girToplamVentilator",
		"girBosVentilator",
		"girArizaliVentilator",
		"girYogunBakimYatakSeviyeBilgisi",
		};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string YenidoganKayit(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\YenidoganKayit.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
		{
		"girAnneKimlikNumarasi",
		"girBabaKimlikNumarasi",
		"girDogumTarihi",
		"girDogumSirasi",
		"girCinsiyet",
		"girSysTakipNo"
		};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string YogunBakimDegerlendirmeCihazOlcumBilgileri(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\YogunBakimDegerlendirmeCihazOlcumBilgileri.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
		{
		"girSantralVenozBasinc",
		"girIbpSistolik",
		"girIbpDiastolik",
		"girSpoIiDegeri",
		"girNabiz",
		"girDiastolikKanBasinci",
		"girSistolikKanBasinci",
		"girVucutIsisi",
		"girOlcumZamani",
		"girTidalVolumDegeri",
		"girFrekansDegeri",
		"girTepeBasincDegeri",
		"girFioIiDegeri",
		"girPeepDegeri",
		"girVentilatorModu",
		"girSonucZamani",
		"girKanGaziPh",
		"girKanGaziPaoIi",
		"girKanGaziPacoIi",
		"girKanGaziHcoIii",
		"girKanGaziLaktat",
		"girKanGaziGlukoz",
		"girSysTakipNo"
		};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string YogunBakimDegerlendirmeGenelBilgiler(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\YogunBakimDegerlendirmeGenelBilgiler.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
		{
		"girHavaliHastaYatakDurumu",
		"girKanGrubu",
		"girYogunBakimGirisZamani",
		"girYogunBakimCikisZamani",
		"girYogunBakimTipi",
		"girYogunBakimUniteAdi",
		"girYogunBakimUnitesiSeviyesi",
		"girHastaBilgilendirmeOnamAlinmaDurumu",
		"girTaniTuru",
		"girIcd10",
		"girSysTakipNo"
		};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string YogunBakimDegerlendirmeIzlemveSkorlamaVeriPaketi(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\YogunBakimDegerlendirmeIzlemveSkorlamaVeriPaketi.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
		{
		"girYogunBakimTipi",
		"girActBalansDegeri",
		"girDekubitUlseriSkorSonucu",
		"girDekubitUlseriSkorlamaTuru",
		"girDiyalizCihazinaBaglilikDurumu",
		"girDrenVarligi",
		"girDrenBilgisi",
		"girEcmoIhtiyaci",
		"girEnfekteOlmaDurumBilgisi",
		"girHemodiyalizIhtiyaci",
		"girKataterBilgisi",
		"girSepsisDurumu",
		"girSeptikSok",
		"girVentilasyonDurumu",
		"girVentilatorIliskiliPnomoniVarligi",
		"girYatakBasiYarasiVarligi",
		"girYogunBakimSeviyeBilgisi",
		"girAkiDurumu",
		"girAlkolozDurumu",
		"girArdsGelismeDurumu",
		"girGunlukIzlemNotu",
		"girHastaGenelDurum",
		"girYogunBakimYatakMedulaKodu",
		"girAsidozDurumu",
		"girBeslenmeBilgisi",
		"girDusmeRiski",
		"girIslemReferansNumarasi",
		"girToplamApacheSkoru",
		"girBeklenenOlumOrani",
		"girBeklenenOlumOraniDuzeltilmis",
		"girOlcumZamani",
		"girSnapIiSkoru",
		"girSnapPeIiSkoru",
		"girToplamPrismSkoru",
		"girGozler",
		"girSozel",
		"girMotor",
		"girVentilasyonYontemi",
		"girVentilasyonBaslangicZamani",
		"girVentilasyonBitisZamani",
		"girSysTakipNo"
		};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string HizmetIlacMalzemeBilgisiKayit(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\HizmetIlacMalzemeBilgisiKayit.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();
			List<string> degisecek = new List<string>
			{
				"girSysTakipNo",
				"girTarafBilgisi",
				"girHekiminAmeliyataKararVerdigiTarih",
				"girAmeliyatRandevuTarihi",
				"girAsistanHekimKimlikNumarasi",
				"girSağlikTurizmiFiyatTarifesi",
				"girKlinikKodu",
				"girGerceklesmeZamani",
				"girIslemTuru",
				"girIslemKodu",
				"girIslemAdi",
				"girGirisimselIslemKodu",
				"girIslemZamani",
				"girAdet",
				"girHastaTutari",
				"girKurumTutari",
				"girRandevuZamani",
				"girKullaniciKimlikNumarasi",
				"girCİhazNumarasi",
				"girIslemReferansNumarasi",
				"girHekimKimlikNumarasi",
				"girIslemPuani",
				"girPuanHakedisZamani",
				"girGenKodu",
			};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}

		public string CikisBilgisiKayit(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\CikisBilgisiKayit.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();
			List<string> degisecek = new List<string>
			{
				"girSysTakipNo",
				"girYogunBakimIhtiyaci","girHastanedeOzellikliBiriminOlmamasi","girHastanedeOzellikliBiriminDolulugu","girHekimIhtiyaci","girGoruntulemeCihazBulunmamasi",
				"girCikisZamani","girCikisSekli","girSevkNedeni","girSevkTanisi","girSevkEdilenPoliklinik",
				"girPaketeAitIslemZamani"
			};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string TeleTipSonucKayit(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\TeleTipSonucKayit.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
			{
				"girSysTakipNo","girIslemReferansNumarasi","girCekimZamani","girSgkTakipNumarasi","girAccessionNumber"

			};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string YatanHastaEpikrizKayit(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\YatanHastaEpikrizKayit.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();
			List<string> degisecek = new List<string>
			{
				"girSysTakipNo","girBase64PdfBilgisi","girPdfReferansNumarasi"
			};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string VeriPaketiSilme(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\VeriPaketiSilme.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();
			List<string> degisecek = new List<string>
			{
				"girSysTakipNo","girSilinecekVeriPaketi"
			};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string PatolojiKayit(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\PatolojiKayit.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();
			List<string> degisecek = new List<string>
			{
				"girSysTakipNo","girTetkikSonucu","girIslemReferansNumarasi","girIstemZamani","girIstemYapilanKlinik",

				"girIstemYapanHekimKimlikNumarasi","girRaporlamaZamani","girRaporlayanHekimKimlikNumarasi","girNumuneninAlindigiDokununTemelOzelligi","girNumuneAlinmaSekli",
				"girPreparatDurumu","girYerlesimYeri","girMorfolojiKodu"
			};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string YasKadinIzlemVeriSeti(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\15-49YasKadinIzlemVeriSeti.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();
			List<string> degisecek = new List<string>
			{
				"girSysTakipNo","girKonjenitalAnomaliVarligi","girCanliDoganBebekSayisi","girHemoglobin","girOluDoganBebekSayisi",
				"girBirOncekiDogumDurumu","girIzleminYapildigiYer","girKullanilanAilePlanlamasiYontemi","girAilePlanlamasiYontemiLojistigi","girPaketeAitIslemZamani",
				"girIslemYapan","girBilgiAlinanKisiAdiSoyadi","girBilgiAlinanKisiTel","girKadinSagligiIslemleri","girAilePlanlamasiYontemiKullanmamaNedeni",
				"girBirOncekiKullanilanAilePlanlamasiYontemi",
			};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string AgzVeDisSagligiVeriSeti(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\AgzVeDisSagligiVeriSeti.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();
			List<string> degisecek = new List<string>
			{
				"girSysTakipNo","girMudahale","girMudahaleBaslangicZamani","girMudahaleBitisZamani","girTedaviEdilenDisinKodu",
				"girIslemReferansNumarasi","girMevcutDisDurumu","girMevcutDisKodu"
			};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string AnneOlumVeriSeti(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\AnneOlumVeriSeti.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
			{
				"girSysTakipNo","girAnneOlumZamani","girDogumGebelikSonlanmaHaftasi","girDogumYontemi","girGebelikAraligi",
				"girGebelikSonlanmaTarihi","girGebelikSonucu","girKacinciGebelik","girAnneOlumNedeni","girGebelikteRiskFaktorleri",
			};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string AsiErtelemeIptalVeriSeti(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\AsiErtelemeIptalVeriSeti.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
			{
				"girSysTakipNo","girPaketeAitIslemZamani","girAsi","girAsininDozu","girAsiErtelemeSuresi",
				"girAsiYapilmamaDurumu","girAsiYapilmamaNedeni","girAsiYapilmaZamani","girAlttaYatanHastalik"
			};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string AsiVeriSeti(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\AsiVeriSeti.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
			{
				"girSysTakipNo","girIzleminYapildigiYer","girAsiOzelDurumNedeni","girAsi","girAsiDozu",
				"girAsininUygulamaSekli","girAsininUygulamaYeri","girAsiSorguNumarasi","girIslemYapan","girAsiIslemTuru",
				"girBilgiAlinanKisiAdiSoyadi","girBilgiAlinanKisiTel","girAsiYapilmaZamani"
			};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string AskerlikOlurRaporuVeriSeti(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\AskerlikOlurRaporuVeriSeti.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();
			List<string> degisecek = new List<string>
			{
				"girSysTakipNo","girAciklama","girAlkolMaddeBagimliligi","girBedenselRuhsalIleriTetkikBulgusu","girGecmisHastaligaDairKayit",
				"girGormeIsitmeKaybÄ±","girKanGrubu","girPsikiyatrikRahatsizlik","girUzuvKaybiOrtopedikRahatsizlik","girAsalHastalik",
				"girAsalHastalikTipi","girBoy","girKilo"
			};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string BebekCocukIzlemVeriSeti(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\BebekCocukIzlemVeriSeti.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
			{
				"girSysTakipNo","girKritikDkhTaramaSonucu","girBasCevresi","girDemirLojistigiVeDestegi","girDogumAraligi",
				"girDVitaminiLojistigiVeDestegi","girHematokrit","girHemoglobin","girKacinciIzlem","girGkdTaramaSonucu",
				"girGormeTaramaSonucu","girBebeginBeslenmeDurumu","girNtpTakipBilgisi","girIzlemIslemTuru","girBoy",
				"girKilo","girKritikDkhTaramaSonrasiIslem"
			};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string BebekOlumVeriSeti(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\BebekOlumVeriSeti.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
			{
				"girSysTakipNo","girAgirlik","girBebekOlumNedenleri","girDogumunGerceklestigiYer","girDogumAgirligi",
				"girDogumGebelikSonlanmaHaftasi","girDogumYontemi","girDogumZamani","girGebelikAraligi","girKacinciGebelik",
				"girOlumTarihi"
			};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string BebekCocukPsikososyalIzlemVeriSeti(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\BebekCocukPsikososyalIzlemVeriSeti.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
			{
				"girSysTakipNo","girGelisimTablosuBilgilerininSorgulanmasi","girBebeginCocugunBeyinGelisiminiEtkileyebilecekRiskler","girEbeveyninPsikolojikGelisiminiDestekleyiciAktiviteleri","girBebeginCocugunPsikolojikGelisimindekiRisklereYonelikEgitimler",
				"girBebeginCocugunRiskFaktÃ¶rlerineYapilanMudahale","girBebekCocuktaSikIzlemeAlinanRiskAltindakiOlgununTakibi"
			};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}

		public string BulasiciHastalikBildirimVeriSeti(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\BulasiciHastalikBildirimVeriSeti.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
			{
			"girPaketeAitIslemZamani",
			"girVakaTipi",
			"girKlinikBelirtilerinBasladigiTarih",
			"girTelefonNumarasi",
			"girTelefonTipi",
			"girHastaKimlikNumarasi",
			"girAd",
			"girSoyad",
			"girDogumTarihi",
			"girCinsiyet",
			"girUyruk",
			"girAnneKimlikNumarasi",
			"girDogumSirasi",
			"girYabanciHastaKimlikNumarasi",
			"girPasaportNo",
			"girKimliksizHastaBilgisi",
			"girTaniTuru",
			"girIcd10",
			"girIlKodu",
			"girIlceKodu",
			"girBucakKodu",
			"girKoyKodu",
			"girMahalleKodu",
			"girCsbmKodu",
			"girDisKapi",
			"girIcKapi",
			"girSysTakipNo",
			};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string DiyabetVeriSeti(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\DiyabetVeriSeti.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
			{
				"girDiyabetEgitimi",
				"girIlkTaniTarihi",
				"girDiyabetKomplikasyonlari",
				"girBoy",
				"girKilo",
				"girSysTakipNo",
			};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string GebelikBildirimVeriSeti(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\GebelikBildirimVeriSeti.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
				{
					"girBirOncekiDogumDurumu",
					"girSonAdetTarihi",
					"girSysTakipNo",
				};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string GebelikSonucuVeriSeti(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\GebelikSonucuVeriSeti.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
			{
			"girDogumaYardimEden",
			"girCanliDoganBebekSayisi",
			"girDogumunGerceklestigiYer",
			"girDogumYontemi",
			"girGebelikSonlanmaTarihi",
			"girGebelikSonucu",
			"girOluDoganBebekSayisi",
			"girSezaryanEndikasyon",
			"girEndikasyonNedenleri",
			"girSysTakipNo",
			};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string GebePsikososyalIzlemVeriSeti(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\GebePsikososyalIzlemVeriSeti.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();
			List<string> degisecek = new List<string>
			{
			"girBebeginCocugunBeyinGelisiminiEtkileyebilecekRiskler",
			"girBebeginCocugunPsikolojikGelisimindekiRisklereYonelikEgitimler",
			"girGebedeRiskFaktorlerineYapilanMudahale",
			"girGebedeSikIzlemeAlinanRiskAltindakiOlgununTakibi",
			"girSysTakipNo",
			};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string GebeIzlemVeriSeti(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\GebeIzlemVeriSeti.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();
			List<string> degisecek = new List<string>
			{
			"girSysTakipNo",
			"girGestasyonelDiyabetTaramasi",
			"girIdrardaProtein",
			"girHemoglobin",
			"girIzlemIslemTuru",
			"girKacinciGebeIzlem",
			"girDemirLojistigiVeDestegi",
			"girDVitaminiLojistigiVeDestegi",
			"girKonjenitalAnomaliVarligi",
			"girFetusKalpSesi",
			"girDiastolikKanBasinciDegeri",
			"girSistolikKanBasinciDegeri",
			"girGebelikteRiskFaktorleri",
			"girBoy",
			"girKilo",
			};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);
			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string KuduzProfilaksiIzlemVeriSeti(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\KuduzProfilaksiIzlemVeriSeti.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
			{
			"girKuduzProfilaksisiSonlandirmaDurumu",
			"girKilo",
			"girImmunglobulinMiktari",
			"girImmunglobulinTuru",
			"girUygulananKuduzProfilaksisi",
			"girSysTakipNo",
			};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string KuduzRiskliTemasBildirimVeriSeti(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\KuduzRiskliTemasBildirimVeriSeti.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
			{
			"girRiskliTemasTarihi",
			"girOlayinGerceklestigiAdres",
			"girKuduzAntiserumuYapilmaDurumu",
			"girTetanozProfilaksisiYapilmaDurumu",
			"girYaraBakimiYapilmaDurumu",
			"girRiskliTemasTipi",
			"girKisiyePlanlananKuduzProfilaksisi",
			"girTelefonNumarasi",
			"girTelefonTipi",
			"girCsbmKodu",
			"girBucakKodu",
			"girDisKapi",
			"girIcKapi",
			"girIlceKodu",
			"girIlKodu",
			"girKoyKodu",
			"girMahalleKodu",
			"girRiskliTemasaSebepOlanHayvan",
			"girSysTakipNo",
			};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string LohusaIzlemVeriSeti(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\LohusaIzlemVeriSeti.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
			{
			"girIzleminYapildigiYer",
			"girKacinciLohusaIzlem",
			"girDemirLojistigiVeDestegi",
			"girDVitaminiLojistigiVeDestegi",
			"girGebelikSonlanmaTarihi",
			"girPostpartumDepresyon",
			"girUterusInvolusyon",
			"girPaketeAitIslemZamani",
			"girIslemYapan",
			"girBilgiAlinanKisiAdiSoyadi",
			"girBilgiAlinanKisiTel",
			"girKonjenitalAnomaliVarligi",
			"girHemoglobin",
			"girKomplikasyonTanisi",
			"girGebelikLohusalikSeyrindeTehlikeIsareti",
			"girAilePlanlamasiYontemiLojistigi",
			"girKullanilanAilePlanlamasiYontemi",
			"girKadinSagligiIslemleri",
			"girSysTakipNo",
			};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string ObeziteIzlemVeriSeti(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\ObeziteIzlemVeriSeti.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
			{
			"girBelCevresi",
			"girDiyetTedavisiTibbiBeslenmeTedavisi",
			"girIlkTaniTarihi",
			"girKalcaCevresi",
			"girMorbidObezHastaLenfatikOdemVarligi",
			"girObeziteIlacTedavisi",
			"girPsikolojikTedavi",
			"girBirlikteGorulenEkHastaliklar",
			"girEgzersiz",
			"girBoy",
			"girKilo",
			"girSysTakipNo",
			};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string OkulCagCocukGenclikSaglgIzlemVeriSeti(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\OkulCagCocukGenclikSaglgIzlemVeriSeti.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
			{
			"girKacinciIzlem",
			"girGormeTaramaSonucu",
			"girHemoglobin",
			"girHematokrit",
			"girOkulCagiPosturMuayeneBilgisi",
			"girOkulCagiCocukGenclikSagligiDanismanlik",
			"girBoy",
			"girKilo",
			"girDiastolikKanBasinciDegeri",
			"girSistolikKanBasinciDegeri",
			"girOgrenciMuayeneIzlemIslemi",
			"girSysTakipNo",
			};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string CocukDiyabetIzlem(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\CocukDiyabetIzlem.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
			{
			"girTannerEvre",
			"girDiyabetKomplikasyonlari",
			"girTiroidMuayenesi",
			"girDiyabetTipi",
			"girEslikEdenBaskaHastalik",
			"girDiyabetIlacTedaviSekli",
			"girDiyetTedavisiTibbiBeslenmeTedavisi",
			"girBoy",
			"girKilo",
			"girSysTakipNo",
			};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string AcilSaglkBilgileriASOS(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\AcilSaglkBilgileriASOS.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
				{
				"girAmbulansTakipNumarasi",
				"girAracTuru",
				"girAmbulansCikisIl",
				"girPlaka",
				"girAracKullanimAmaci",
				"girIstasyonNo",
				"girVakaMalzemeKullanimi",
				"girVakaIslemBilgisi",
				"girUlasimZamani",
				"girMudahaleZamani",
				"girAlinanKurum",
				"girTeslimZamani",
				"girTeslimEdilenKurum",
				"girSevkNedeni",
				"girOlayYeri",
				"girIhbarZamani",
				"girIhbarNedeni",
				"girBilinc",
				"girPupilla",
				"girDeriDurumu",
				"girNabiz",
				"girSolunum",
								"girSysTakipNo",
				};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string COVIDVakaTakipKayt(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\COVIDVakaTakipKayt.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
			{
			"girSemptomVarMi",
			"girSemptomBaslamaTarihi",
			"girPaketeAitIslemZamani",
			"girEkHastaliklar",
			"girTemasliMi",
			"girSaglikPersoneliMi",
			"girIlKodu",
			"girIlceKodu",
			"girBucakKodu",
			"girKoyKodu",
			"girMahalleKodu",
			"girCsbmKodu",
			"girDisKapi",
			"girIcKapi",
			"girTelefonNumarasi",
			"girTelefonTipi",
			"girSysTakipNo",
			};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string CocukDiyabetBildirim(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\CocukDiyabetBildirim.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
			{
			"girIlkTaniTarihi",
			"girDiyabetTipi",
			"girKizCocuklardaMenarsYasi",
			"girBeyinOdemi",
			"girDiyabetIlacTedaviSekli",
			"girKetoasidozSon3Ay",
			"girDiyabetEgitimi",
			"girTiroidMuayenesi",
			"girDiyetTedavisiTibbiBeslenmeTedavisi",
			"girDiyabetliHastaAileOykusu",
			"girSikayet",
			"girSikayetinSuresi",
			"girBoy",
			"girKilo",
			"girAxillerKillanma",
			"girPubikKillanma",
			"girTannerEvre",
			"girMemeEvre",
			"girTestisVolumSag",
			"girTestisVolumSol",
			"girEslikEdenBaskaHastalik",
			"girEslikEdenBaskaHastalikTaniTarihi",
			"girSysTakipNo",
			};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string RaporKayt(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\RaporKayt.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
			{
			"girIslemReferansNumarasi",
			"girRaporTarihi",
			"girRaporNumarasi",
			"girRaporTuru",
			"girRaporBaslangicTarihi",
			"girRaporBitisTarihi",
			"girHekimKimlikNumarasi",
			"girDogumTarihi",
			"girBabaAdi",
			"girAnneAdi",
			"girKanGrubu",
			"girRaporMuayeneSonucu",
			"girKisitKodu",
			"girSysTakipNo",
			};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);
			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string ToplumTabanliKanserTaramaVeriSeti(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\ToplumTabanliKanserTaramaVeriSeti.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
			{
			"girGaitadaGizliKanTesti",
			"girHpvTaramaTesti",
			"girKendiKendineMemeMuayenesi",
			"girKlinikMemeMuayenesi",
			"girKolonoskopi",
			"girKolonoskopininSuresi",
			"girKolonGoruntulemeYontemi",
			"girKolposkopi",
			"girMamografi",
			"girMamografiSonucu",
			"girPapSmearTesti",
			"girSigmoidoskopi",
			"girHpvTipi",
			"girKolonoskopiKaliteKriterleri",
			"girKolorektalBiyopsiSonucu",
			"girMemedenBiyopsiAlimi",
			"girMemeBiyopsiSonucu",
			"girServikalBiyopsiSonucu",
			"girServikalSitolojiSonucu",
			"girTaramaTipi",
			"girTaramaTarihi",
			"girTaramaSonuclanmaTarihi",
			"girSysTakipNo",
			};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;

		}
		public string TutunKullanimiVeriSeti(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\TutunKullanimiVeriSeti.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
			{
			"girSigaraAdedi",
			"girSigaraKullanimi",
			"girTutunDumaninaMaruzKalma",
			"girBagimliOlduguUrun",
			"girTedaviSekli",
			"girTutunTedaviSonucu",
			"girSysTakipNo",
			};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string VeremTaramaVeriSeti(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\VeremTaramaVeriSeti.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
				{
				"girVeremTaramaSonucu",
				"girHastaKimlikNumarasi",
				"girTaramaTuru",
				"girSysTakipNo",
				};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string VeremVeriSeti(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\VeremVeriSeti.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
			{
			"girBcgSkarSayisi",
			"girDgtUygulamasiniYapanKisi",
			"girDgtUygulamaYeri",
			"girHastaninTedaviyeUyumu",
			"girKulturSonucu",
			"girTuberkulinDeriTestiSonucu",
			"girVeremHastasiTedaviYontemi",
			"girVeremOlguTanimi",
			"girYaymaSonucu",
			"girVeremHastaligininTutulumYeri",
			"girVeremHastasiKlinikOrnegi",
			"girIlacAdiVerem",
			"girIlacDirenciVerem",
			"girVeremTedaviSonucu",
			"girSysTakipNo",
			};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string KonsultasyonKayit(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\KonsultasyonKayit.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
		{
		"girIslemReferansNumarasi",
		"girKonsultasyonBaslamaZamani",
		"girKonsultasyonBitisZamani",
		"girKonsultasyonTalebiniYapanHekimKimlikNumarasi",
		"girKonsultasyonTalebineCevapVerenHekimKimlikNumarasi",
		"girTaniTuru",
		"girIcd10",
		"girKonsultasyonNotuBaslik",
		"girKonsultasyonNotuAciklama",
		"girSysTakipNo"
		};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string KronikHastalikTaramaTEST(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\KronikHastalikTaramaTEST.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
		{
		"girSigaraKullanimi",
		"girSistolikKanBasinciDegeri",
		"girKanBasinciKontrolundeIlacKullanimi",
		"girTaramaTarihi",
		"girTaramaTipi",
		"girOnerilenYasamTarziDegisikligi",
		"girOnerilenTibbiTedavi",
		"girBoy",
		"girKilo",
		"girBelCevresi",
		"girHba1c",
		"girTotalKolestrolDegeri",
		"girKolestrolKontrolundeIlacKullanimi",
		"girSysTakipNo"
		};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string NtpTarama(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\NtpTarama.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
		{
		"girTopukKaniAlmaZamani",
		"girEbeveynTelefonNumarasi",
		"girNumuneninAlindigiKurum",
		"girNtpTaramaYontemi",
		"girNtpAnalizSonucuBirimi",
		"girNtpTaramayaAitUyari",
		"girNtpAnalizSonucuDegeri",
		"girNtpBarkod",
		"girNtpNumuneTuru",
		"girNtpTaramaTuru",
		"girSysTakipNo"
		};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string OlayAfetBilgisi(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\OlayAfetBilgisi.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
		{
		"girAfetOlayVatandasTipi",
		"girOlayId",
		"girHayatiTehlikeDurumu",
		"girGlasgowKomaSkalasi",
		"girSysTakipNo"
		};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string OZELLIKLIIZLEMVERISETI(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\OZELLIKLIIZLEMVERISETI.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
		{
		"girIzlemTarihi",
		"girIzlemYapilmamaNedeni",
		"girIzlemNotu",
		"girSemptomGelismeDurumu",
		"girIzlemIslemTuru",
		"girTelefonNumarasi",
		"girKacinciOzellikliIzlem",
		"girAtes386Ustu",
		"girOksurukVarMi",
		"girNefesDarligiVarMi",
		"girNumuneAlindiMi",
		"girIzlemYapilmamaNedeniAciklama",
		"girSurecBitir",
		"girKasAgrisi",
		"girTatKokuKaybi",
		"girIshal",
		"girHastaKimlikNumarasi",
		"girIzlemYapilmaDurumu",
		"girListeyeDahilMi",
		"girVucutIsisi",
		"girNumuneAlinmamaNedeni",
		"girBasAgrisi",
		};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string PandemiAsiSonrasiIstenmeyenEtki(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\PandemiAsiSonrasiIstenmeyenEtki.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
		{
		"girTedavininYapildigiYer",
		"girYatisinGerceklestigiHastane",
		"girOlumZamani",
		"girCiddiAsieDurumBilgisi",
		"girHastalikBilgisi",
		"girFormuDolduranKisiAdi",
		"girFormuDolduranKisininSoyadi",
		"girAsieKayitNo",
		"girAsilamaSirasindaBilinenHastaligiVarMi",
		"girOncesindeBenzerBirAsieTablosuVarligiVarMi",
		"girAlerjiOykusuVarMi",
		"girAsieOrtayaCikisZamani",
		"girAsieMevcutDurumu",
		"girVakayaTedaviGerektiMi",
		"girVakaHastaneyeYattiMi",
		"girVakaOlduMu",
		"girCiddiAsieDurumVarligi",
		"girAsilamaSirasindaKullandigiIlacVarMi",
		"girAsi",
		"girKullanilanIlacGrupAdi",
		"girIlacAdi",
		"girDozBilgisi",
		"girKullanilanSure",
		"girPandemiAsieAlerjiBilgisi",
		"girTutulanSistemler",
		"girOzellik",
		"girYerlesim",
		"girBoyut",
		"girDigerAsiSonrasiIstenmeyenEtki",
		"girDigerTutulanSistemler",
		"girReaksiyonSuresi",
		"girSolunumSistemindeOlusanEtkiler",
		"girDolasimSistemindeOlusanEtkiler",
		"girGastrointestinalSistemindeOlusanEtkiler",
		"girCiltOlusanEtkiler",
		"girDeriMukozaOlusanEtkiler",
		"girAsiUygulamasindanSonrakiOrtayaCikisZamani",
		"girDigerOlusanEtkiler",
		"girPandemiAsiSonrasiIstenmeyenEtki",
		"girSysTakipNo"
		};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string PandemiAsiVeriSeti(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\PandemiAsiVeriSeti.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
		{
		"girSulandiriciLotNo",
		"girAltRiskGrubu",
		"girAsiUygulananSaglikCalisani",
		"girAsiUygulananRiskGrubu",
		"girPandemiAsisininUygulamaTipi",
		"girAsi",
		"girKarekod",
		"girAsiLotNo",
		"girUreticiFirma",
		"girAsiSorguNumarasi",
		"girAsininUygulamaYeri",
		"girAsiYapilmaZamani",
		"girAsininSaglandigiKaynak",
		"girAsininUygulamaSekli",
		"girAsiDozu",
		"girAsiIslemTuru",
		"girIslemYapan",
		"girAsininUygulandigiKurum",
		"girBarkod",
		"girPartiNo",
		"girSonKullanmaTarihi",
		"girSeriNo",
		"girUrunAdi",
		"girSysTakipNo"
		};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string HastaNakilBilgileri(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\HastaNakilBilgileri.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
		{
		"girHastaHukumluMu",
		"girHastaAdliVakaMi",
		"girKanGrubu",
		"girNakilReferansNumarasi",
		"girPaketeAitIslemZamani",
		"girNaklinTalepEdildigiZaman",
		"girNakilTalepEdenKurum",
		"girNakilTalepEdenKurumTelefon",
		"girNakilTalepEdenKlinik",
		"girHastaninBulunduguKlinik",
		"girNakilEdilmekIstendigiKlinik",
		"girHastaNakilTipi",
		"girGerceklestirilmesiIstenenKomutaMerkezi",
		"girAd",
		"girSoyad",
		"girTelefonNumarasi",
		"girAcikAdres",
		"girPatolojikMuayeneBilgileri",
		"girTetkikBilgileri",
		"girYapilanMedikalIslemler",
		"girIstenenMedikalIslemler",
		"girSevkEdilenKurumdanYapilmasiIstenenMedikalIslemler",
		"girTriaj",
		"girNabizSayisi",
		"girSistolikKanBasinciDegeri",
		"girDiastolikKanBasinciDegeri",
		"girBilinc",
		"girAtes",
		"girSolunum",
		"girSolunumSayisi",
		"girKanSekeri",
		"girSolunumIslemi",
		"girGozler",
		"girSozel",
		"girMotor",
		"girIcd10",
		"girPo2",
		"girSpo2",
		"girEtco2",
		"girCrp",
		"girPh",
		"girFio2",
		"girCo2",
		"girHco3",
		"girK",
		"girCa",
		"girNa",
		"girEpikrizBilgisiBaslik",
		"girEpikrizBilgisiAciklama",
		"girGestasyonHaftasi",
		"girDogumAgirligi",
		"girMevcutAgirligi",
		"girDogumYontemi",
		"girApgar1",
		"girApgar5",
		"girDoktorIhtiyaci",
		"girBransIhtiyaci",
		"girTeyitliVakaMi",
		"girNakilYolu",
		"girMalzeme",
		"girMalzemeSayisi",
		"girHekimKimlikNumarasi",
		"girAciklama",
		"girHekimIhtiyaci",
		"girHastanedeOzellikliBiriminOlmamasi",
		"girYogunBakimDolulugu",
		"girHastanedeOzellikliBiriminDolulugu",
		"girYogunBakimOlmamasi",
		"girGoruntulemeCihazBulunmamasi",
		"girSevkNedeni",
		"girBoy",
		"girKilo",
		"girIl",
		"girKabulEdenKurum",
		"girKabulEdenKlinik",
		"girKabulEdenPersonelAdi",
		"girKabulEdenPersonelSoyadi",
		"girKabulEdenPersonelTelefon",
		"girSysTakipNo"
		};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}


		

		
		
		
		
		
		
		
		
		
		
		
		
		
		public string EvdeSaglikHizmetiIlkIzlemVeriSeti(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\EvdeSaglikHizmetiIlkIzlemVeriSeti.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
			{
			"girAgri",
			"girAydinlatma",
			"girBakimVeDestekIhtiyaci",
			"girBasiDegerlendirmesi",
			"girBasvuruTuru",
			"girBeslenme",
			"girBirSonrakiHizmetIhtiyaci",
			"girEvdeSaglikHizmetineEsasHastalikGrubu",
			"girEvHijyeni",
			"girGuvenlik",
			"girIsinma",
			"girKisiselBakim",
			"girKisiselHijyen",
			"girKonutTipi",
			"girKullanilanHelaTipi",
			"girYatagaBagimlilik",
			"girKullandigiYardimciAraclar",
			"girPsikolojikDurumDegerlendirmesi",
			"girVerilenEgitimler",
			"girSysTakipNo",
			};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string EvdeSaglikHizmetiIzlemVeriSeti(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\EvdeSaglikHizmetiIzlemVeriSeti.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
			{
			"girAgri",
			"girBasiDegerlendirmesi",
			"girBeslenme",
			"girEvdeSaglikHizmetininSonlandirilmasi",
			"girEvdeSaglikHizmetleriHastaNakli",
			"girHizmetAlinacakIl",
			"girBirSonrakiHizmetIhtiyaci",
			"girPsikolojikDurumDegerlendirmesi",
			"girVerilenEgitimler",
			"girSysTakipNo",
			};

			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string DiyalizHastasiBildirimVeriSeti(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\DiyalizHastasiBildirimVeriSeti.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();


			List<string> degisecek = new List<string>
			{
			"girDiyalizTedavisineBaslamaTarihi",
			"girPrimerTani",
			"girBirlikteGorulenEkHastaliklar",
			"girDiyalizTedavisiYontemi",
			"girHemodiyalizeGecmeNedenleri",
			"girOncekiRrtYontemi",
			"girSysTakipNo",
			};

			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string DiyalizHastasiIzlemVeriSeti(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\DiyalizHastasiIzlemVeriSeti.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();


			List<string> degisecek = new List<string>
			{
			"girAntihipertansifIlacKullanimDurumu",
			"girDamarErisimYolu",
			"girDiyalizeGirmeSikligi",
			"girDiyalizorAlani",
			"girDiyalizorTipi",
			"girKanAkimHizi",
			"girKullanilanDiyalizTedavisi",
			"girPeritonealGecirgenlik",
			"girPeritonDiyaliziKacinciKateter",
			"girPeritonDiyaliziKateterTipi",
			"girPeritonDiyalizKateterYerlestirmeYontemi",
			"girPeritonDiyalizTunelYonu",
			"girSeansSuresi",
			"girSinekalset",
			"girTedavininSeyri",
			"girAgirlik",
			"girAgirlikOlcumZamani",
			"girAktifVitaminDKullanimi",
			"girAnemiTedavisiYontemi",
			"girFosforBaglayiciAjan",
			"girPeritonDiyaliziKomplikasyon",
			"girSysTakipNo",
			};

			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string IntiharGirisimiveKrizIzlemVeriSeti(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\IntiharGirisimiveKrizIzlemVeriSeti.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
			{
			"girIntiharKrizVakaTuru",
			"girIntiharGirisimiYaDaKrizNedenleri",
			"girIntiharGirisimiYontemi",
			"girIntiharKrizVakaSonucu",
			"girSysTakipNo",
			};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string KadinaYonelikSiddetVeriSeti(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\KadinaYonelikSiddetVeriSeti.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
			{
			"girKadinaYonelikSiddetSonucuYonlendirmeVeDegerlendirme",
			"girSiddetTuru",
			"girSysTakipNo",
			};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string EnfeksiyonEtkeniBildirimVeriSeti(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\EnfeksiyonEtkeniBildirimVeriSeti.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
			{
			"girBildirimTarihi",
			"girTaniTarihi",
			"girHekimKimlikNumarasi",
			"girTelefonNumarasi",
			"girTelefonTipi",
			"girAdresTipi",
			"girBucakKodu",
			"girCsbmKodu",
			"girDisKapi",
			"girIcKapi",
			"girIlceKodu",
			"girIlKodu",
			"girKoyKodu",
			"girMahalleKodu",
			"girEnfeksiyonEtkeni",
			"girSysTakipNo",
			};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}
		public string GozlukReceteBilgileri(List<string> degistirilecek)
		{
			string xmlString;
			string path = "./Xml\\GozlukReceteBilgileri.xml";
			StreamReader sr = new StreamReader(path);
			xmlString = sr.ReadToEnd();

			List<string> degisecek = new List<string>
			{
			"girGozlukReceteTipi",
			"girReceteNumarasi",
			"girReceteTarihi",
			"girHekimKimlikNumarasi",
			"girGozlukTuru",
			"girCamTipi",
			"girCamRengi",
			"girCamSferik",
			"girCamSilindirik",
			"girCamAks",
			"girCamCap",
			"girCamEgim",
			"girGeciciMadde",
			"girTeleskopikGozlukTipi",
			"girTeleskopikGozlukTuru",
			"girSagCam",
			"girSolCam",
			"girSysTakipNo",
			};
			xmlString = hazirla(xmlString, degisecek, degistirilecek);



			string calisircevap = client.SYSSendMessage(xmlString);
			return calisircevap;
		}






































	}
}
