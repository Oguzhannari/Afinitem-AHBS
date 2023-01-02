using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunum.Formlar.Kişi_İşlemleri;
using Sunum.Static_Sınıflar;

namespace Sunum
{
	
	public partial class FormKisiBilgileri : Form
	{
        Form form = new Form();
        public FormKisiBilgileri()
		{
			InitializeComponent();
            form = SabitFonksiyonlar.AbrirFormulario<Muayene>(panel1);
            dpDogumTarihi.Format = DateTimePickerFormat.Custom;
            dpDogumTarihi.CustomFormat = "dd/MM/yyyy";
            dpAHKayitTarihi.Format = DateTimePickerFormat.Custom;
            dpAHKayitTarihi.CustomFormat = "dd/MM/yyyy";
            duzenleme();


        }
        #region düzenleme
		private void duzenleme()
		{
            double olcek_height = (1050.0 - Screen.PrimaryScreen.Bounds.Height) / 1050;
            double olcek_width = (1680.0 - Screen.PrimaryScreen.Bounds.Width) / 1680;
            panel3.Width -= Convert.ToInt16(panel3.Width * olcek_width);
            panel3.Height -= Convert.ToInt16(panel3.Height * olcek_height);
            label3.Width -= Convert.ToInt16(label3.Width * olcek_width);
            label3.Height -= Convert.ToInt16(label3.Height * olcek_height);
            panel2.Width -= Convert.ToInt16(panel2.Width * olcek_width);
            panel2.Height -= Convert.ToInt16(panel2.Height * olcek_height);
            btnBebekCocukİzlem.Width -= Convert.ToInt16(btnBebekCocukİzlem.Width * olcek_width);
            btnBebekCocukİzlem.Height -= Convert.ToInt16(btnBebekCocukİzlem.Height * olcek_height);
            btnGebeİzlem.Width -= Convert.ToInt16(btnGebeİzlem.Width * olcek_width);
            btnGebeİzlem.Height -= Convert.ToInt16(btnGebeİzlem.Height * olcek_height);
            btn1549İzlem.Width -= Convert.ToInt16(btn1549İzlem.Width * olcek_width);
            btn1549İzlem.Height -= Convert.ToInt16(btn1549İzlem.Height * olcek_height);
            btnAsi.Width -= Convert.ToInt16(btnAsi.Width * olcek_width);
            btnAsi.Height -= Convert.ToInt16(btnAsi.Height * olcek_height);
            btnKisiAileTakvimi.Width -= Convert.ToInt16(btnKisiAileTakvimi.Width * olcek_width);
            btnKisiAileTakvimi.Height -= Convert.ToInt16(btnKisiAileTakvimi.Height * olcek_height);
            label1.Width -= Convert.ToInt16(label1.Width * olcek_width);
            label1.Height -= Convert.ToInt16(label1.Height * olcek_height);
            label30.Width -= Convert.ToInt16(label30.Width * olcek_width);
            label30.Height -= Convert.ToInt16(label30.Height * olcek_height);
            label31.Width -= Convert.ToInt16(label31.Width * olcek_width);
            label31.Height -= Convert.ToInt16(label31.Height * olcek_height);
            label32.Width -= Convert.ToInt16(label32.Width * olcek_width);
            label32.Height -= Convert.ToInt16(label32.Height * olcek_height);
            label33.Width -= Convert.ToInt16(label33.Width * olcek_width);
            label33.Height -= Convert.ToInt16(label33.Height * olcek_height);
            label34.Width -= Convert.ToInt16(label34.Width * olcek_width);
            label34.Height -= Convert.ToInt16(label34.Height * olcek_height);
            label35.Width -= Convert.ToInt16(label35.Width * olcek_width);
            label35.Height -= Convert.ToInt16(label35.Height * olcek_height);
            label36.Width -= Convert.ToInt16(label36.Width * olcek_width);
            label36.Height -= Convert.ToInt16(label36.Height * olcek_height);
            label37.Width -= Convert.ToInt16(label37.Width * olcek_width);
            label37.Height -= Convert.ToInt16(label37.Height * olcek_height);
            label38.Width -= Convert.ToInt16(label38.Width * olcek_width);
            label38.Height -= Convert.ToInt16(label38.Height * olcek_height);
            label39.Width -= Convert.ToInt16(label39.Width * olcek_width);
            label39.Height -= Convert.ToInt16(label39.Height * olcek_height);
            label40.Width -= Convert.ToInt16(label40.Width * olcek_width);
            label40.Height -= Convert.ToInt16(label40.Height * olcek_height);
            label41.Width -= Convert.ToInt16(label41.Width * olcek_width);
            label41.Height -= Convert.ToInt16(label41.Height * olcek_height);
            label42.Width -= Convert.ToInt16(label42.Width * olcek_width);
            label42.Height -= Convert.ToInt16(label42.Height * olcek_height);
            label43.Width -= Convert.ToInt16(label43.Width * olcek_width);
            label43.Height -= Convert.ToInt16(label43.Height * olcek_height);
            label44.Width -= Convert.ToInt16(label44.Width * olcek_width);
            label44.Height -= Convert.ToInt16(label44.Height * olcek_height);
            label45.Width -= Convert.ToInt16(label45.Width * olcek_width);
            label45.Height -= Convert.ToInt16(label45.Height * olcek_height);
            label46.Width -= Convert.ToInt16(label46.Width * olcek_width);
            label46.Height -= Convert.ToInt16(label46.Height * olcek_height);
            label47.Width -= Convert.ToInt16(label47.Width * olcek_width);
            label47.Height -= Convert.ToInt16(label47.Height * olcek_height);
            label48.Width -= Convert.ToInt16(label48.Width * olcek_width);
            label48.Height -= Convert.ToInt16(label48.Height * olcek_height);
            label49.Width -= Convert.ToInt16(label49.Width * olcek_width);
            label49.Height -= Convert.ToInt16(label49.Height * olcek_height);
            label50.Width -= Convert.ToInt16(label50.Width * olcek_width);
            label50.Height -= Convert.ToInt16(label50.Height * olcek_height);
            label51.Width -= Convert.ToInt16(label51.Width * olcek_width);
            label51.Height -= Convert.ToInt16(label51.Height * olcek_height);
            label52.Width -= Convert.ToInt16(label52.Width * olcek_width);
            label52.Height -= Convert.ToInt16(label52.Height * olcek_height);
            label53.Width -= Convert.ToInt16(label53.Width * olcek_width);
            label53.Height -= Convert.ToInt16(label53.Height * olcek_height);
            cbCinsiyet.Width -= Convert.ToInt16(cbCinsiyet.Width * olcek_width);
            cbCinsiyet.Height -= Convert.ToInt16(cbCinsiyet.Height * olcek_height);
            btntetkikler.Width -= Convert.ToInt16(btntetkikler.Width * olcek_width);
            btntetkikler.Height -= Convert.ToInt16(btntetkikler.Height * olcek_height);
            btnMuayene.Width -= Convert.ToInt16(btnMuayene.Width * olcek_width);
            btnMuayene.Height -= Convert.ToInt16(btnMuayene.Height * olcek_height);
            cbCezaeviTipi.Width -= Convert.ToInt16(cbCezaeviTipi.Width * olcek_width);
            cbCezaeviTipi.Height -= Convert.ToInt16(cbCezaeviTipi.Height * olcek_height);
            cbHukumluluk.Width -= Convert.ToInt16(cbHukumluluk.Width * olcek_width);
            cbHukumluluk.Height -= Convert.ToInt16(cbHukumluluk.Height * olcek_height);
            btnAHDegistimrDilekcesi.Width -= Convert.ToInt16(btnAHDegistimrDilekcesi.Width * olcek_width);
            btnAHDegistimrDilekcesi.Height -= Convert.ToInt16(btnAHDegistimrDilekcesi.Height * olcek_height);
            cbOzurluluk.Width -= Convert.ToInt16(cbOzurluluk.Width * olcek_width);
            cbOzurluluk.Height -= Convert.ToInt16(cbOzurluluk.Height * olcek_height);
            cbAmeliyat.Width -= Convert.ToInt16(cbAmeliyat.Width * olcek_width);
            cbAmeliyat.Height -= Convert.ToInt16(cbAmeliyat.Height * olcek_height);
            cbSigaraKullanim.Width -= Convert.ToInt16(cbSigaraKullanim.Width * olcek_width);
            cbSigaraKullanim.Height -= Convert.ToInt16(cbSigaraKullanim.Height * olcek_height);
            tbBoy.Width -= Convert.ToInt16(tbBoy.Width * olcek_width);
            tbBoy.Height -= Convert.ToInt16(tbBoy.Height * olcek_height);
            tbAgirlik.Width -= Convert.ToInt16(tbAgirlik.Width * olcek_width);
            tbAgirlik.Height -= Convert.ToInt16(tbAgirlik.Height * olcek_height);
            tbBabaTcKimlikNo.Width -= Convert.ToInt16(tbBabaTcKimlikNo.Width * olcek_width);
            tbBabaTcKimlikNo.Height -= Convert.ToInt16(tbBabaTcKimlikNo.Height * olcek_height);
            tbAnneTCKimlikNo.Width -= Convert.ToInt16(tbAnneTCKimlikNo.Width * olcek_width);
            tbAnneTCKimlikNo.Height -= Convert.ToInt16(tbAnneTCKimlikNo.Height * olcek_height);
            cbMedeniHali.Width -= Convert.ToInt16(cbMedeniHali.Width * olcek_width);
            cbMedeniHali.Height -= Convert.ToInt16(cbMedeniHali.Height * olcek_height);
            cbUyruk.Width -= Convert.ToInt16(cbUyruk.Width * olcek_width);
            cbUyruk.Height -= Convert.ToInt16(cbUyruk.Height * olcek_height);
            cbKanGrubu.Width -= Convert.ToInt16(cbKanGrubu.Width * olcek_width);
            cbKanGrubu.Height -= Convert.ToInt16(cbKanGrubu.Height * olcek_height);
            pictureBox10.Width -= Convert.ToInt16(pictureBox10.Width * olcek_width);
            pictureBox10.Height -= Convert.ToInt16(pictureBox10.Height * olcek_height);
            cbKayitTuru.Width -= Convert.ToInt16(cbKayitTuru.Width * olcek_width);
            cbKayitTuru.Height -= Convert.ToInt16(cbKayitTuru.Height * olcek_height);
            dpAHKayitTarihi.Width -= Convert.ToInt16(dpAHKayitTarihi.Width * olcek_width);
            dpAHKayitTarihi.Height -= Convert.ToInt16(dpAHKayitTarihi.Height * olcek_height);
            tbMevcutAHB.Width -= Convert.ToInt16(tbMevcutAHB.Width * olcek_width);
            tbMevcutAHB.Height -= Convert.ToInt16(tbMevcutAHB.Height * olcek_height);
            tbMevcutAH.Width -= Convert.ToInt16(tbMevcutAH.Width * olcek_width);
            tbMevcutAH.Height -= Convert.ToInt16(tbMevcutAH.Height * olcek_height);
            tbBabaAdi.Width -= Convert.ToInt16(tbBabaAdi.Width * olcek_width);
            tbBabaAdi.Height -= Convert.ToInt16(tbBabaAdi.Height * olcek_height);
            tbAnneAdi.Width -= Convert.ToInt16(tbAnneAdi.Width * olcek_width);
            tbAnneAdi.Height -= Convert.ToInt16(tbAnneAdi.Height * olcek_height);
            tbDogumyeri.Width -= Convert.ToInt16(tbDogumyeri.Width * olcek_width);
            tbDogumyeri.Height -= Convert.ToInt16(tbDogumyeri.Height * olcek_height);
            label54.Width -= Convert.ToInt16(label54.Width * olcek_width);
            label54.Height -= Convert.ToInt16(label54.Height * olcek_height);
            dpDogumTarihi.Width -= Convert.ToInt16(dpDogumTarihi.Width * olcek_width);
            dpDogumTarihi.Height -= Convert.ToInt16(dpDogumTarihi.Height * olcek_height);
            tbYupassNo.Width -= Convert.ToInt16(tbYupassNo.Width * olcek_width);
            tbYupassNo.Height -= Convert.ToInt16(tbYupassNo.Height * olcek_height);
            tbPasaportNo.Width -= Convert.ToInt16(tbPasaportNo.Width * olcek_width);
            tbPasaportNo.Height -= Convert.ToInt16(tbPasaportNo.Height * olcek_height);
            tbTCKimlikNo.Width -= Convert.ToInt16(tbTCKimlikNo.Width * olcek_width);
            tbTCKimlikNo.Height -= Convert.ToInt16(tbTCKimlikNo.Height * olcek_height);
            btnGuncelle.Width -= Convert.ToInt16(btnGuncelle.Width * olcek_width);
            btnGuncelle.Height -= Convert.ToInt16(btnGuncelle.Height * olcek_height);
            label55.Width -= Convert.ToInt16(label55.Width * olcek_width);
            label55.Height -= Convert.ToInt16(label55.Height * olcek_height);
            lbTelefon.Width -= Convert.ToInt16(lbTelefon.Width * olcek_width);
            lbTelefon.Height -= Convert.ToInt16(lbTelefon.Height * olcek_height);
            lbAdres.Width -= Convert.ToInt16(lbAdres.Width * olcek_width);
            lbAdres.Height -= Convert.ToInt16(lbAdres.Height * olcek_height);
            tbSoyad.Width -= Convert.ToInt16(tbSoyad.Width * olcek_width);
            tbSoyad.Height -= Convert.ToInt16(tbSoyad.Height * olcek_height);
            tbAd.Width -= Convert.ToInt16(tbAd.Width * olcek_width);
            tbAd.Height -= Convert.ToInt16(tbAd.Height * olcek_height);
            btnKanserTarama.Width -= Convert.ToInt16(btnKanserTarama.Width * olcek_width);
            btnKanserTarama.Height -= Convert.ToInt16(btnKanserTarama.Height * olcek_height);
            btnHYP.Width -= Convert.ToInt16(btnHYP.Width * olcek_width);
            btnHYP.Height -= Convert.ToInt16(btnHYP.Height * olcek_height);
            panel1.Width -= Convert.ToInt16(panel1.Width * olcek_width);
            panel1.Height -= Convert.ToInt16(panel1.Height * olcek_height);
            tableLayoutPanel1.Width -= Convert.ToInt16(tableLayoutPanel1.Width * olcek_width);
            tableLayoutPanel1.Height -= Convert.ToInt16(tableLayoutPanel1.Height * olcek_height);

            pictureBox9.Width -= Convert.ToInt16(pictureBox9.Width * olcek_width);
            pictureBox9.Height -= Convert.ToInt16(pictureBox9.Height * olcek_height);

            pictureBox7.Width -= Convert.ToInt16(pictureBox7.Width * olcek_width);
            pictureBox7.Height -= Convert.ToInt16(pictureBox7.Height * olcek_height);
            pictureBox6.Width -= Convert.ToInt16(pictureBox6.Width * olcek_width);
            pictureBox6.Height -= Convert.ToInt16(pictureBox6.Height * olcek_height);
            pictureBox5.Width -= Convert.ToInt16(pictureBox5.Width * olcek_width);
            pictureBox5.Height -= Convert.ToInt16(pictureBox5.Height * olcek_height);
            pictureBox4.Width -= Convert.ToInt16(pictureBox4.Width * olcek_width);
            pictureBox4.Height -= Convert.ToInt16(pictureBox4.Height * olcek_height);
            pictureBox3.Width -= Convert.ToInt16(pictureBox3.Width * olcek_width);
            pictureBox3.Height -= Convert.ToInt16(pictureBox3.Height * olcek_height);
            pictureBox2.Width -= Convert.ToInt16(pictureBox2.Width * olcek_width);
            pictureBox2.Height -= Convert.ToInt16(pictureBox2.Height * olcek_height);
            pictureBox1.Width -= Convert.ToInt16(pictureBox1.Width * olcek_width);
            pictureBox1.Height -= Convert.ToInt16(pictureBox1.Height * olcek_height);


        }

        #endregion




        private void afiButton2_Click(object sender, EventArgs e)
		{


        }



		private void panel3_Paint(object sender, PaintEventArgs e)
		{

		}

		private void afiComboBox8_OnSelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void afiComboBox9_OnSelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void afiComboBox7_OnSelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void afiComboBox6_OnSelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void afiTextBox9_Load(object sender, EventArgs e)
		{

		}

		private void afiTextBox10_Load(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void afiButton17_Click(object sender, EventArgs e)
		{
            form.Close();
            form = SabitFonksiyonlar.AbrirFormulario<Muayene>(panel1);

        }

		private void afiButton16_Click(object sender, EventArgs e)
		{
            form.Close();
            form = SabitFonksiyonlar.AbrirFormulario<Tetkik>(panel1);
        }

		private void afiButton15_Click(object sender, EventArgs e)
		{
            form.Close();
            form = SabitFonksiyonlar.AbrirFormulario<KisiAileTakvim>(panel1);
        }

		private void afiButton14_Click(object sender, EventArgs e)
		{
            form.Close();
            form = SabitFonksiyonlar.AbrirFormulario<Asi>(panel1);
        }

		private void afiButton2_Click_1(object sender, EventArgs e)
		{
            form.Close();
            form = SabitFonksiyonlar.AbrirFormulario<Asi>(panel1);
        }

		private void afiButton1_Click(object sender, EventArgs e)
		{
            form.Close();
        }

		private void afiButton12_Click(object sender, EventArgs e)
		{
            form.Close();
        }

        private void afiButton8_Click(object sender, EventArgs e)
        {
            form.Close();
        }

        private void afiButton13_Click(object sender, EventArgs e)
        {
            form.Close();
        }

        private void tbAd_Enter(object sender, EventArgs e)
        {
            if (tbAd.Texts == "Ad")
            {
                tbAd.Texts = "";
                tbAd.ForeColor = Color.Black;
            }
        }

        private void tbAd_Leave(object sender, EventArgs e)
        {
            if (tbAd.Texts == "")
            {
                tbAd.Texts = "Ad";
                tbAd.ForeColor = Color.DimGray;
            }
        }

        private void tbSoyad_Enter(object sender, EventArgs e)
        {
            if (tbSoyad.Texts == "Soyad")
            {
                tbSoyad.Texts = "";
                tbSoyad.ForeColor = Color.Black;
            }
        }

        private void tbSoyad_Leave(object sender, EventArgs e)
        {
            if (tbSoyad.Texts == "")
            {
                tbSoyad.Texts = "Soyad";
                tbSoyad.ForeColor = Color.DimGray;
            }
        }

        private void tbTCKimlikNo_Enter(object sender, EventArgs e)
        {
            if (tbTCKimlikNo.Texts == "T.C. Kimlik No")
            {
                tbTCKimlikNo.Texts = "";
                tbTCKimlikNo.ForeColor = Color.Black;
            }
        }

        private void tbTCKimlikNo_Leave(object sender, EventArgs e)
        {
            if (tbTCKimlikNo.Texts == "")
            {
                tbTCKimlikNo.Texts = "T.C. Kimlik No";
                tbTCKimlikNo.ForeColor = Color.DimGray;
            }
        }

        private void tbPasaportNo_Enter(object sender, EventArgs e)
        {
            if (tbPasaportNo.Texts == "Pasaport No")
            {
                tbPasaportNo.Texts = "";
                tbPasaportNo.ForeColor = Color.Black;
            }
        }

        private void tbPasaportNo_Leave(object sender, EventArgs e)
        {
            if (tbPasaportNo.Texts == "")
            {
                tbPasaportNo.Texts = "Pasaport No";
                tbPasaportNo.ForeColor = Color.DimGray;
            }
        }

        private void tbYupassNo_Enter(object sender, EventArgs e)
        {
            if (tbYupassNo.Texts == "YuPass No")
            {
                tbYupassNo.Texts = "";
                tbYupassNo.ForeColor = Color.Black;
            }
        }

        private void tbYupassNo_Leave(object sender, EventArgs e)
        {
            if (tbYupassNo.Texts == "")
            {
                tbYupassNo.Texts = "YuPass No";
                tbYupassNo.ForeColor = Color.DimGray;
            }
        }

        private void tbDogumyeri_Enter(object sender, EventArgs e)
        {
            if (tbDogumyeri.Texts == "Doğum Yeri")
            {
                tbDogumyeri.Texts = "";
                tbDogumyeri.ForeColor = Color.Black;
            }
        }

        private void tbDogumyeri_Leave(object sender, EventArgs e)
        {
            if (tbDogumyeri.Texts == "")
            {
                tbDogumyeri.Texts = "Doğum Yeri";
                tbDogumyeri.ForeColor = Color.DimGray;
            }
        }

        private void tbAgirlik_Enter(object sender, EventArgs e)
        {
            if (tbAgirlik.Texts == "Ağırlık")
            {
                tbAgirlik.Texts = "";
                tbAgirlik.ForeColor = Color.Black;
            }
        }

        private void tbAgirlik_Leave(object sender, EventArgs e)
        {
            if (tbAgirlik.Texts == "")
            {
                tbAgirlik.Texts = "Ağırlık";
                tbAgirlik.ForeColor = Color.DimGray;
            }
        }

        private void tbBoy_Enter(object sender, EventArgs e)
        {
            if (tbBoy.Texts == "Boy")
            {
                tbBoy.Texts = "";
                tbBoy.ForeColor = Color.Black;
            }
        }

        private void tbBoy_Leave(object sender, EventArgs e)
        {
            if (tbBoy.Texts == "")
            {
                tbBoy.Texts = "Boy";
                tbBoy.ForeColor = Color.DimGray;
            }
        }

        private void tbMevcutAH_Enter(object sender, EventArgs e)
        {
            if (tbMevcutAH.Texts == "Mevcut AH")
            {
                tbMevcutAH.Texts = "";
                tbMevcutAH.ForeColor = Color.Black;
            }
        }

        private void tbMevcutAH_Leave(object sender, EventArgs e)
        {
            if (tbMevcutAH.Texts == "")
            {
                tbMevcutAH.Texts = "Mevcut AH";
                tbMevcutAH.ForeColor = Color.DimGray;
            }
        }

        private void tbMevcutAHB_Enter(object sender, EventArgs e)
        {
            if (tbMevcutAHB.Texts == "Mevcut AHB")
            {
                tbMevcutAHB.Texts = "";
                tbMevcutAHB.ForeColor = Color.Black;
            }

        }

        private void tbMevcutAHB_Leave(object sender, EventArgs e)
        {
            if (tbMevcutAHB.Texts == "")
            {
                tbMevcutAHB.Texts = "Mevcut AHB";
                tbMevcutAHB.ForeColor = Color.DimGray;
            }
        }

        private void tbAnneAdi_Enter(object sender, EventArgs e)
        {
            if (tbAnneAdi.Texts == "Anne Adı")
            {
                tbAnneAdi.Texts = "";
                tbAnneAdi.ForeColor = Color.Black;
            }
        }

        private void tbAnneAdi_Leave(object sender, EventArgs e)
        {
            if (tbAnneAdi.Texts == "")
            {
                tbAnneAdi.Texts = "Anne Adı";
                tbAnneAdi.ForeColor = Color.DimGray;
            }
        }

        private void tbAnneTCKimlikNo_Enter(object sender, EventArgs e)
        {
            if (tbAnneTCKimlikNo.Texts == "Anne T.C Kimlik No")
            {
                tbAnneTCKimlikNo.Texts = "";
                tbAnneTCKimlikNo.ForeColor = Color.Black;
            }
        }

        private void tbAnneTCKimlikNo_Leave(object sender, EventArgs e)
        {
            if (tbAnneTCKimlikNo.Texts == "")
            {
                tbAnneTCKimlikNo.Texts = "Anne T.C Kimlik No";
                tbAnneTCKimlikNo.ForeColor = Color.DimGray;
            }
        }

        private void tbBabaAdi_Enter(object sender, EventArgs e)
        {
            if (tbBabaAdi.Texts == "Baba Adı")
            {
                tbBabaAdi.Texts = "";
                tbBabaAdi.ForeColor = Color.Black;
            }

        }

        private void tbBabaAdi_Leave(object sender, EventArgs e)
        {
            if (tbBabaAdi.Texts == "")
            {
                tbBabaAdi.Texts = "Baba Adı";
                tbBabaAdi.ForeColor = Color.DimGray;
            }
        }

        private void tbBabaTcKimlikNo_Enter(object sender, EventArgs e)
        {
            if (tbBabaTcKimlikNo.Texts == "Baba T.C Kimlik No")
            {
                tbBabaTcKimlikNo.Texts = "";
                tbBabaTcKimlikNo.ForeColor = Color.Black;
            }
        }

        private void tbBabaTcKimlikNo_Leave(object sender, EventArgs e)
        {
            if (tbBabaTcKimlikNo.Texts == "")
            {
                tbBabaTcKimlikNo.Texts = "Baba T.C Kimlik No";
                tbBabaTcKimlikNo.ForeColor = Color.DimGray;
            }
        }


    }
	
			
}
