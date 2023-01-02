using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sunum
{
	public partial class FormKisiIslemleri : Form
	{
		public FormKisiIslemleri()
		{
			InitializeComponent();

            duzenleme();
		}

        #region düzenleme
		private void duzenleme()
		{
            double olcek_height = (1080.0 - Screen.PrimaryScreen.Bounds.Height) / 1080;
            double olcek_width = (1920.0 - Screen.PrimaryScreen.Bounds.Width) / 1920;

            panel1.Width -= Convert.ToInt16(panel1.Width * olcek_width);
            panel1.Height -= Convert.ToInt16(panel1.Height * olcek_height);
            panel2.Width -= Convert.ToInt16(panel2.Width * olcek_width);
            panel2.Height -= Convert.ToInt16(panel2.Height * olcek_height);
            panel3.Width -= Convert.ToInt16(panel3.Width * olcek_width);
            panel3.Height -= Convert.ToInt16(panel3.Height * olcek_height);
            panel5.Width -= Convert.ToInt16(panel5.Width * olcek_width);
            panel5.Height -= Convert.ToInt16(panel5.Height * olcek_height);
            tbArama.Width -= Convert.ToInt16(tbArama.Width * olcek_width);
            tbArama.Height -= Convert.ToInt16(tbArama.Height * olcek_height);
            btnYeniKisiKaydi.Width -= Convert.ToInt16(btnYeniKisiKaydi.Width * olcek_width);
            btnYeniKisiKaydi.Height -= Convert.ToInt16(btnYeniKisiKaydi.Height * olcek_height);
            btnKisiKaydiniDuzenle.Width -= Convert.ToInt16(btnKisiKaydiniDuzenle.Width * olcek_width);
            btnKisiKaydiniDuzenle.Height -= Convert.ToInt16(btnKisiKaydiniDuzenle.Height * olcek_height);
            btnHypListesi.Width -= Convert.ToInt16(btnHypListesi.Width * olcek_width);
            btnHypListesi.Height -= Convert.ToInt16(btnHypListesi.Height * olcek_height);
            btnOzellikliIzlem.Width -= Convert.ToInt16(btnOzellikliIzlem.Width * olcek_width);
            btnOzellikliIzlem.Height -= Convert.ToInt16(btnOzellikliIzlem.Height * olcek_height);
            btnExceleAktar.Width -= Convert.ToInt16(btnExceleAktar.Width * olcek_width);
            btnExceleAktar.Height -= Convert.ToInt16(btnExceleAktar.Height * olcek_height);
            btnDigerIslemler.Width -= Convert.ToInt16(btnDigerIslemler.Width * olcek_width);
            btnDigerIslemler.Height -= Convert.ToInt16(btnDigerIslemler.Height * olcek_height);
            btnKomsular.Width -= Convert.ToInt16(btnKomsular.Width * olcek_width);
            btnKomsular.Height -= Convert.ToInt16(btnKomsular.Height * olcek_height);
            btnTumAile.Width -= Convert.ToInt16(btnTumAile.Width * olcek_width);
            btnTumAile.Height -= Convert.ToInt16(btnTumAile.Height * olcek_height);
            btnYeniMuayene.Width -= Convert.ToInt16(btnYeniMuayene.Width * olcek_width);
            btnYeniMuayene.Height -= Convert.ToInt16(btnYeniMuayene.Height * olcek_height);
            label1.Width -= Convert.ToInt16(label1.Width * olcek_width);
            label1.Height -= Convert.ToInt16(label1.Height * olcek_height);
            cbHastaTipi.Width -= Convert.ToInt16(cbHastaTipi.Width * olcek_width);
            cbHastaTipi.Height -= Convert.ToInt16(cbHastaTipi.Height * olcek_height);
            tabControl1.Width -= Convert.ToInt16(tabControl1.Width * olcek_width);
            tabControl1.Height -= Convert.ToInt16(tabControl1.Height * olcek_height);
            dgvTumListe.Width -= Convert.ToInt16(dgvTumListe.Width * olcek_width);
            dgvTumListe.Height -= Convert.ToInt16(dgvTumListe.Height * olcek_height);
            tabBebek.Width -= Convert.ToInt16(tabBebek.Width * olcek_width);
            tabBebek.Height -= Convert.ToInt16(tabBebek.Height * olcek_height);
            dgvBebekListesi.Width -= Convert.ToInt16(dgvBebekListesi.Width * olcek_width);
            dgvBebekListesi.Height -= Convert.ToInt16(dgvBebekListesi.Height * olcek_height);
            dataGridViewImageColumn1.Width -= Convert.ToInt16(dataGridViewImageColumn1.Width * olcek_width);
            dataGridViewTextBoxColumn1.Width -= Convert.ToInt16(dataGridViewTextBoxColumn1.Width * olcek_width);
            dataGridViewTextBoxColumn2.Width -= Convert.ToInt16(dataGridViewTextBoxColumn2.Width * olcek_width);
            dataGridViewTextBoxColumn3.Width -= Convert.ToInt16(dataGridViewTextBoxColumn3.Width * olcek_width);
            dataGridViewTextBoxColumn4.Width -= Convert.ToInt16(dataGridViewTextBoxColumn4.Width * olcek_width);
            dataGridViewImageColumn2.Width -= Convert.ToInt16(dataGridViewImageColumn2.Width * olcek_width);
            dataGridViewTextBoxColumn5.Width -= Convert.ToInt16(dataGridViewTextBoxColumn5.Width * olcek_width);
            dataGridViewTextBoxColumn6.Width -= Convert.ToInt16(dataGridViewTextBoxColumn6.Width * olcek_width);
            dataGridViewTextBoxColumn7.Width -= Convert.ToInt16(dataGridViewTextBoxColumn7.Width * olcek_width);
            dataGridViewTextBoxColumn8.Width -= Convert.ToInt16(dataGridViewTextBoxColumn8.Width * olcek_width);
            dataGridViewTextBoxColumn9.Width -= Convert.ToInt16(dataGridViewTextBoxColumn9.Width * olcek_width);
            tabCocuk.Width -= Convert.ToInt16(tabCocuk.Width * olcek_width);
            tabCocuk.Height -= Convert.ToInt16(tabCocuk.Height * olcek_height);
            dgvCocukListesi.Width -= Convert.ToInt16(dgvCocukListesi.Width * olcek_width);
            dgvCocukListesi.Height -= Convert.ToInt16(dgvCocukListesi.Height * olcek_height);
            dataGridViewImageColumn3.Width -= Convert.ToInt16(dataGridViewImageColumn3.Width * olcek_width);
            dataGridViewTextBoxColumn10.Width -= Convert.ToInt16(dataGridViewTextBoxColumn10.Width * olcek_width);
            dataGridViewTextBoxColumn11.Width -= Convert.ToInt16(dataGridViewTextBoxColumn11.Width * olcek_width);
            dataGridViewTextBoxColumn12.Width -= Convert.ToInt16(dataGridViewTextBoxColumn12.Width * olcek_width);
            dataGridViewTextBoxColumn13.Width -= Convert.ToInt16(dataGridViewTextBoxColumn13.Width * olcek_width);
            dataGridViewImageColumn4.Width -= Convert.ToInt16(dataGridViewImageColumn4.Width * olcek_width);
            dataGridViewTextBoxColumn14.Width -= Convert.ToInt16(dataGridViewTextBoxColumn14.Width * olcek_width);
            dataGridViewTextBoxColumn15.Width -= Convert.ToInt16(dataGridViewTextBoxColumn15.Width * olcek_width);
            dataGridViewTextBoxColumn16.Width -= Convert.ToInt16(dataGridViewTextBoxColumn16.Width * olcek_width);
            dataGridViewTextBoxColumn17.Width -= Convert.ToInt16(dataGridViewTextBoxColumn17.Width * olcek_width);
            dataGridViewTextBoxColumn18.Width -= Convert.ToInt16(dataGridViewTextBoxColumn18.Width * olcek_width);
            tabKadin.Width -= Convert.ToInt16(tabKadin.Width * olcek_width);
            tabKadin.Height -= Convert.ToInt16(tabKadin.Height * olcek_height);
            dgv1549KadinListesi.Width -= Convert.ToInt16(dgv1549KadinListesi.Width * olcek_width);
            dgv1549KadinListesi.Height -= Convert.ToInt16(dgv1549KadinListesi.Height * olcek_height);
            dataGridViewImageColumn5.Width -= Convert.ToInt16(dataGridViewImageColumn5.Width * olcek_width);
            dataGridViewTextBoxColumn19.Width -= Convert.ToInt16(dataGridViewTextBoxColumn19.Width * olcek_width);
            dataGridViewTextBoxColumn20.Width -= Convert.ToInt16(dataGridViewTextBoxColumn20.Width * olcek_width);
            dataGridViewTextBoxColumn21.Width -= Convert.ToInt16(dataGridViewTextBoxColumn21.Width * olcek_width);
            dataGridViewTextBoxColumn22.Width -= Convert.ToInt16(dataGridViewTextBoxColumn22.Width * olcek_width);
            dataGridViewImageColumn6.Width -= Convert.ToInt16(dataGridViewImageColumn6.Width * olcek_width);
            dataGridViewTextBoxColumn23.Width -= Convert.ToInt16(dataGridViewTextBoxColumn23.Width * olcek_width);
            dataGridViewTextBoxColumn24.Width -= Convert.ToInt16(dataGridViewTextBoxColumn24.Width * olcek_width);
            dataGridViewTextBoxColumn25.Width -= Convert.ToInt16(dataGridViewTextBoxColumn25.Width * olcek_width);
            dataGridViewTextBoxColumn26.Width -= Convert.ToInt16(dataGridViewTextBoxColumn26.Width * olcek_width);
            dataGridViewTextBoxColumn27.Width -= Convert.ToInt16(dataGridViewTextBoxColumn27.Width * olcek_width);
            tabGebe.Width -= Convert.ToInt16(tabGebe.Width * olcek_width);
            tabGebe.Height -= Convert.ToInt16(tabGebe.Height * olcek_height);
            dgvGebeListesi.Width -= Convert.ToInt16(dgvGebeListesi.Width * olcek_width);
            dgvGebeListesi.Height -= Convert.ToInt16(dgvGebeListesi.Height * olcek_height);
            dataGridViewImageColumn7.Width -= Convert.ToInt16(dataGridViewImageColumn7.Width * olcek_width);
            dataGridViewTextBoxColumn28.Width -= Convert.ToInt16(dataGridViewTextBoxColumn28.Width * olcek_width);
            dataGridViewTextBoxColumn29.Width -= Convert.ToInt16(dataGridViewTextBoxColumn29.Width * olcek_width);
            dataGridViewTextBoxColumn30.Width -= Convert.ToInt16(dataGridViewTextBoxColumn30.Width * olcek_width);
            dataGridViewTextBoxColumn31.Width -= Convert.ToInt16(dataGridViewTextBoxColumn31.Width * olcek_width);
            dataGridViewImageColumn8.Width -= Convert.ToInt16(dataGridViewImageColumn8.Width * olcek_width);
            dataGridViewTextBoxColumn32.Width -= Convert.ToInt16(dataGridViewTextBoxColumn32.Width * olcek_width);
            dataGridViewTextBoxColumn33.Width -= Convert.ToInt16(dataGridViewTextBoxColumn33.Width * olcek_width);
            dataGridViewTextBoxColumn34.Width -= Convert.ToInt16(dataGridViewTextBoxColumn34.Width * olcek_width);
            dataGridViewTextBoxColumn35.Width -= Convert.ToInt16(dataGridViewTextBoxColumn35.Width * olcek_width);
            dataGridViewTextBoxColumn36.Width -= Convert.ToInt16(dataGridViewTextBoxColumn36.Width * olcek_width);
            tabLohusa.Width -= Convert.ToInt16(tabLohusa.Width * olcek_width);
            tabLohusa.Height -= Convert.ToInt16(tabLohusa.Height * olcek_height);
            dgvLohusaListesi.Width -= Convert.ToInt16(dgvLohusaListesi.Width * olcek_width);
            dgvLohusaListesi.Height -= Convert.ToInt16(dgvLohusaListesi.Height * olcek_height);
            dataGridViewImageColumn9.Width -= Convert.ToInt16(dataGridViewImageColumn9.Width * olcek_width);
            dataGridViewTextBoxColumn37.Width -= Convert.ToInt16(dataGridViewTextBoxColumn37.Width * olcek_width);
            dataGridViewTextBoxColumn38.Width -= Convert.ToInt16(dataGridViewTextBoxColumn38.Width * olcek_width);
            dataGridViewTextBoxColumn39.Width -= Convert.ToInt16(dataGridViewTextBoxColumn39.Width * olcek_width);
            dataGridViewTextBoxColumn40.Width -= Convert.ToInt16(dataGridViewTextBoxColumn40.Width * olcek_width);
            dataGridViewImageColumn10.Width -= Convert.ToInt16(dataGridViewImageColumn10.Width * olcek_width);
            dataGridViewTextBoxColumn41.Width -= Convert.ToInt16(dataGridViewTextBoxColumn41.Width * olcek_width);
            dataGridViewTextBoxColumn42.Width -= Convert.ToInt16(dataGridViewTextBoxColumn42.Width * olcek_width);
            dataGridViewTextBoxColumn43.Width -= Convert.ToInt16(dataGridViewTextBoxColumn43.Width * olcek_width);
            dataGridViewTextBoxColumn44.Width -= Convert.ToInt16(dataGridViewTextBoxColumn44.Width * olcek_width);
            dataGridViewTextBoxColumn45.Width -= Convert.ToInt16(dataGridViewTextBoxColumn45.Width * olcek_width);
            tabYasli.Width -= Convert.ToInt16(tabYasli.Width * olcek_width);
            tabYasli.Height -= Convert.ToInt16(tabYasli.Height * olcek_height);
            dgv65YasUstu.Width -= Convert.ToInt16(dgv65YasUstu.Width * olcek_width);
            dgv65YasUstu.Height -= Convert.ToInt16(dgv65YasUstu.Height * olcek_height);
            dataGridViewImageColumn11.Width -= Convert.ToInt16(dataGridViewImageColumn11.Width * olcek_width);
            dataGridViewTextBoxColumn46.Width -= Convert.ToInt16(dataGridViewTextBoxColumn46.Width * olcek_width);
            dataGridViewTextBoxColumn47.Width -= Convert.ToInt16(dataGridViewTextBoxColumn47.Width * olcek_width);
            dataGridViewTextBoxColumn48.Width -= Convert.ToInt16(dataGridViewTextBoxColumn48.Width * olcek_width);
            dataGridViewTextBoxColumn49.Width -= Convert.ToInt16(dataGridViewTextBoxColumn49.Width * olcek_width);
            dataGridViewImageColumn12.Width -= Convert.ToInt16(dataGridViewImageColumn12.Width * olcek_width);
            dataGridViewTextBoxColumn50.Width -= Convert.ToInt16(dataGridViewTextBoxColumn50.Width * olcek_width);
            dataGridViewTextBoxColumn51.Width -= Convert.ToInt16(dataGridViewTextBoxColumn51.Width * olcek_width);
            dataGridViewTextBoxColumn52.Width -= Convert.ToInt16(dataGridViewTextBoxColumn52.Width * olcek_width);
            dataGridViewTextBoxColumn53.Width -= Convert.ToInt16(dataGridViewTextBoxColumn53.Width * olcek_width);
            dataGridViewTextBoxColumn54.Width -= Convert.ToInt16(dataGridViewTextBoxColumn54.Width * olcek_width);
            tabMobil.Width -= Convert.ToInt16(tabMobil.Width * olcek_width);
            tabMobil.Height -= Convert.ToInt16(tabMobil.Height * olcek_height);
            dgvMobilListesi.Width -= Convert.ToInt16(dgvMobilListesi.Width * olcek_width);
            dgvMobilListesi.Height -= Convert.ToInt16(dgvMobilListesi.Height * olcek_height);
            dataGridViewImageColumn13.Width -= Convert.ToInt16(dataGridViewImageColumn13.Width * olcek_width);
            dataGridViewTextBoxColumn55.Width -= Convert.ToInt16(dataGridViewTextBoxColumn55.Width * olcek_width);
            dataGridViewTextBoxColumn56.Width -= Convert.ToInt16(dataGridViewTextBoxColumn56.Width * olcek_width);
            dataGridViewTextBoxColumn57.Width -= Convert.ToInt16(dataGridViewTextBoxColumn57.Width * olcek_width);
            dataGridViewTextBoxColumn58.Width -= Convert.ToInt16(dataGridViewTextBoxColumn58.Width * olcek_width);
            dataGridViewImageColumn14.Width -= Convert.ToInt16(dataGridViewImageColumn14.Width * olcek_width);
            dataGridViewTextBoxColumn59.Width -= Convert.ToInt16(dataGridViewTextBoxColumn59.Width * olcek_width);
            dataGridViewTextBoxColumn60.Width -= Convert.ToInt16(dataGridViewTextBoxColumn60.Width * olcek_width);
            dataGridViewTextBoxColumn61.Width -= Convert.ToInt16(dataGridViewTextBoxColumn61.Width * olcek_width);
            dataGridViewTextBoxColumn62.Width -= Convert.ToInt16(dataGridViewTextBoxColumn62.Width * olcek_width);
            dataGridViewTextBoxColumn63.Width -= Convert.ToInt16(dataGridViewTextBoxColumn63.Width * olcek_width);
            tabMobilNon.Width -= Convert.ToInt16(tabMobilNon.Width * olcek_width);
            tabMobilNon.Height -= Convert.ToInt16(tabMobilNon.Height * olcek_height);
            dgvMobilOlmayan.Width -= Convert.ToInt16(dgvMobilOlmayan.Width * olcek_width);
            dgvMobilOlmayan.Height -= Convert.ToInt16(dgvMobilOlmayan.Height * olcek_height);
            dataGridViewImageColumn15.Width -= Convert.ToInt16(dataGridViewImageColumn15.Width * olcek_width);
            dataGridViewTextBoxColumn64.Width -= Convert.ToInt16(dataGridViewTextBoxColumn64.Width * olcek_width);
            dataGridViewTextBoxColumn65.Width -= Convert.ToInt16(dataGridViewTextBoxColumn65.Width * olcek_width);
            dataGridViewTextBoxColumn66.Width -= Convert.ToInt16(dataGridViewTextBoxColumn66.Width * olcek_width);
            dataGridViewTextBoxColumn67.Width -= Convert.ToInt16(dataGridViewTextBoxColumn67.Width * olcek_width);
            dataGridViewImageColumn16.Width -= Convert.ToInt16(dataGridViewImageColumn16.Width * olcek_width);
            dataGridViewTextBoxColumn68.Width -= Convert.ToInt16(dataGridViewTextBoxColumn68.Width * olcek_width);
            dataGridViewTextBoxColumn69.Width -= Convert.ToInt16(dataGridViewTextBoxColumn69.Width * olcek_width);
            dataGridViewTextBoxColumn70.Width -= Convert.ToInt16(dataGridViewTextBoxColumn70.Width * olcek_width);
            dataGridViewTextBoxColumn71.Width -= Convert.ToInt16(dataGridViewTextBoxColumn71.Width * olcek_width);
            dataGridViewTextBoxColumn72.Width -= Convert.ToInt16(dataGridViewTextBoxColumn72.Width * olcek_width);
            tabbYabanci.Width -= Convert.ToInt16(tabbYabanci.Width * olcek_width);
            tabbYabanci.Height -= Convert.ToInt16(tabbYabanci.Height * olcek_height);
            dgvYabancilar.Width -= Convert.ToInt16(dgvYabancilar.Width * olcek_width);
            dgvYabancilar.Height -= Convert.ToInt16(dgvYabancilar.Height * olcek_height);
            dataGridViewImageColumn17.Width -= Convert.ToInt16(dataGridViewImageColumn17.Width * olcek_width);
            dataGridViewTextBoxColumn73.Width -= Convert.ToInt16(dataGridViewTextBoxColumn73.Width * olcek_width);
            dataGridViewTextBoxColumn74.Width -= Convert.ToInt16(dataGridViewTextBoxColumn74.Width * olcek_width);
            dataGridViewTextBoxColumn75.Width -= Convert.ToInt16(dataGridViewTextBoxColumn75.Width * olcek_width);
            dataGridViewTextBoxColumn76.Width -= Convert.ToInt16(dataGridViewTextBoxColumn76.Width * olcek_width);
            dataGridViewImageColumn18.Width -= Convert.ToInt16(dataGridViewImageColumn18.Width * olcek_width);
            dataGridViewTextBoxColumn77.Width -= Convert.ToInt16(dataGridViewTextBoxColumn77.Width * olcek_width);
            dataGridViewTextBoxColumn78.Width -= Convert.ToInt16(dataGridViewTextBoxColumn78.Width * olcek_width);
            dataGridViewTextBoxColumn79.Width -= Convert.ToInt16(dataGridViewTextBoxColumn79.Width * olcek_width);
            dataGridViewTextBoxColumn80.Width -= Convert.ToInt16(dataGridViewTextBoxColumn80.Width * olcek_width);
            dataGridViewTextBoxColumn81.Width -= Convert.ToInt16(dataGridViewTextBoxColumn81.Width * olcek_width);
            tabUyari.Width -= Convert.ToInt16(tabUyari.Width * olcek_width);
            tabUyari.Height -= Convert.ToInt16(tabUyari.Height * olcek_height);
            dgvUyariEklenenKisiler.Width -= Convert.ToInt16(dgvUyariEklenenKisiler.Width * olcek_width);
            dgvUyariEklenenKisiler.Height -= Convert.ToInt16(dgvUyariEklenenKisiler.Height * olcek_height);
            dataGridViewImageColumn19.Width -= Convert.ToInt16(dataGridViewImageColumn19.Width * olcek_width);
            dataGridViewTextBoxColumn82.Width -= Convert.ToInt16(dataGridViewTextBoxColumn82.Width * olcek_width);
            dataGridViewTextBoxColumn83.Width -= Convert.ToInt16(dataGridViewTextBoxColumn83.Width * olcek_width);
            dataGridViewTextBoxColumn84.Width -= Convert.ToInt16(dataGridViewTextBoxColumn84.Width * olcek_width);
            dataGridViewTextBoxColumn85.Width -= Convert.ToInt16(dataGridViewTextBoxColumn85.Width * olcek_width);
            dataGridViewImageColumn20.Width -= Convert.ToInt16(dataGridViewImageColumn20.Width * olcek_width);
            dataGridViewTextBoxColumn86.Width -= Convert.ToInt16(dataGridViewTextBoxColumn86.Width * olcek_width);
            dataGridViewTextBoxColumn87.Width -= Convert.ToInt16(dataGridViewTextBoxColumn87.Width * olcek_width);
            dataGridViewTextBoxColumn88.Width -= Convert.ToInt16(dataGridViewTextBoxColumn88.Width * olcek_width);
            dataGridViewTextBoxColumn89.Width -= Convert.ToInt16(dataGridViewTextBoxColumn89.Width * olcek_width);
            dataGridViewTextBoxColumn90.Width -= Convert.ToInt16(dataGridViewTextBoxColumn90.Width * olcek_width);
            Column8.Width -= Convert.ToInt16(Column8.Width * olcek_width);
            Column1.Width -= Convert.ToInt16(Column1.Width * olcek_width);
            Column3.Width -= Convert.ToInt16(Column3.Width * olcek_width);
            Column4.Width -= Convert.ToInt16(Column4.Width * olcek_width);
            Column5.Width -= Convert.ToInt16(Column5.Width * olcek_width);
            Column6.Width -= Convert.ToInt16(Column6.Width * olcek_width);
            Column7.Width -= Convert.ToInt16(Column7.Width * olcek_width);
            Column2.Width -= Convert.ToInt16(Column2.Width * olcek_width);
            Column9.Width -= Convert.ToInt16(Column9.Width * olcek_width);
            Column10.Width -= Convert.ToInt16(Column10.Width * olcek_width);
            Column11.Width -= Convert.ToInt16(Column11.Width * olcek_width);
            Column12.Width -= Convert.ToInt16(Column12.Width * olcek_width);
            Column13.Width -= Convert.ToInt16(Column13.Width * olcek_width);
            Column14.Width -= Convert.ToInt16(Column14.Width * olcek_width);
            Column15.Width -= Convert.ToInt16(Column15.Width * olcek_width);
            Column16.Width -= Convert.ToInt16(Column16.Width * olcek_width);
            Column17.Width -= Convert.ToInt16(Column17.Width * olcek_width);
            panel4.Width -= Convert.ToInt16(panel4.Width * olcek_width);
            panel4.Height -= Convert.ToInt16(panel4.Height * olcek_height);
            toggleKapatAc.Width -= Convert.ToInt16(toggleKapatAc.Width * olcek_width);
            toggleKapatAc.Height -= Convert.ToInt16(toggleKapatAc.Height * olcek_height);
            label2.Width -= Convert.ToInt16(label2.Width * olcek_width);
            label2.Height -= Convert.ToInt16(label2.Height * olcek_height);
            dgvTamamlananlar.Width -= Convert.ToInt16(dgvTamamlananlar.Width * olcek_width);
            dgvTamamlananlar.Height -= Convert.ToInt16(dgvTamamlananlar.Height * olcek_height);
            dataGridViewTextBoxColumn103.Width -= Convert.ToInt16(dataGridViewTextBoxColumn103.Width * olcek_width);
            dataGridViewTextBoxColumn104.Width -= Convert.ToInt16(dataGridViewTextBoxColumn104.Width * olcek_width);
            dataGridViewTextBoxColumn105.Width -= Convert.ToInt16(dataGridViewTextBoxColumn105.Width * olcek_width);
            dataGridViewTextBoxColumn106.Width -= Convert.ToInt16(dataGridViewTextBoxColumn106.Width * olcek_width);

            dgvBekleyenler.Width -= Convert.ToInt16(dgvBekleyenler.Width * olcek_width);
            dgvBekleyenler.Height -= Convert.ToInt16(dgvBekleyenler.Height * olcek_height);
            dataGridViewTextBoxColumn99.Width -= Convert.ToInt16(dataGridViewTextBoxColumn99.Width * olcek_width);
            dataGridViewTextBoxColumn100.Width -= Convert.ToInt16(dataGridViewTextBoxColumn100.Width * olcek_width);
            dataGridViewTextBoxColumn101.Width -= Convert.ToInt16(dataGridViewTextBoxColumn101.Width * olcek_width);
            dataGridViewTextBoxColumn102.Width -= Convert.ToInt16(dataGridViewTextBoxColumn102.Width * olcek_width);
            panel6.Width -= Convert.ToInt16(panel6.Width * olcek_width);
            panel6.Height -= Convert.ToInt16(panel6.Height * olcek_height);
            afiButton2.Width -= Convert.ToInt16(afiButton2.Width * olcek_width);
            afiButton2.Height -= Convert.ToInt16(afiButton2.Height * olcek_height);
            afiButton4.Width -= Convert.ToInt16(afiButton4.Width * olcek_width);
            afiButton4.Height -= Convert.ToInt16(afiButton4.Height * olcek_height);
            afiButton1.Width -= Convert.ToInt16(afiButton1.Width * olcek_width);
            afiButton1.Height -= Convert.ToInt16(afiButton1.Height * olcek_height);
            afiButton3.Width -= Convert.ToInt16(afiButton3.Width * olcek_width);
            afiButton3.Height -= Convert.ToInt16(afiButton3.Height * olcek_height);
            dpRandevuListesi.Width -= Convert.ToInt16(dpRandevuListesi.Width * olcek_width);
            dpRandevuListesi.Height -= Convert.ToInt16(dpRandevuListesi.Height * olcek_height);
            btnRandevuListesiniGetir.Width -= Convert.ToInt16(btnRandevuListesiniGetir.Width * olcek_width);
            btnRandevuListesiniGetir.Height -= Convert.ToInt16(btnRandevuListesiniGetir.Height * olcek_height);

        }

        #endregion

        private void afiButton2_Click(object sender, EventArgs e)
		{
			
			
			DataTable t2 = new DataTable();

		}

		private void afiButton1_Click(object sender, EventArgs e)
		{

			

		}

		private void btnKisiKaydiniDuzenle_Click(object sender, EventArgs e)
		{

		}

		private void btnExceleAktar_Click(object sender, EventArgs e)
		{

		}

        private void tbArama_Enter(object sender, EventArgs e)
        {
            if (tbArama.Texts == "Hasta Arama")
            {
                tbArama.Texts = "";
                tbArama.ForeColor = Color.Black;
            }
        }

        private void tbArama_Leave(object sender, EventArgs e)
        {
            if (tbArama.Texts == "")
            {
                tbArama.Texts = "Hasta Arama";
                tbArama.ForeColor = Color.DimGray;
            }
        }
    }
}
