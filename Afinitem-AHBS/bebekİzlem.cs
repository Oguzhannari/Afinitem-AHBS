using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sunum.Formlar.Kişi_İşlemleri
{
    public partial class bebekİzlem : Form
    {
        List<Panel> listPanel = new List<Panel>();
        int index;
        public bebekİzlem()
        {
            InitializeComponent();
        }

        private void Sonraki_Click(object sender, EventArgs e)
        {
            if (index < listPanel.Count - 1)
                listPanel[++index].BringToFront();
            if (index == 0)
            {
                btn1.ImageIndex = 1;
                btn2.ImageIndex = btn3.ImageIndex = 0;
                Line1.BackColor = Line2.BackColor = Color.FromArgb(167, 167, 167);
                btnSonraki.Visible = true;
                btnUssSorgula.Visible = false;
                btnKaydet.Visible = false;
                btnOnceki.Visible = false;
            }
            else if (index == 1)
            {
                btn1.ImageIndex = 2;
                btn2.ImageIndex = 1;
                btn3.ImageIndex = 0;
                Line1.BackColor = Color.FromArgb(59, 249, 81);
                Line2.BackColor = Color.FromArgb(167, 167, 167);
                btnSonraki.Visible = false;
                btnUssSorgula.Visible = false;
                btnKaydet.Visible = true;
                btnOnceki.Visible = true;
            }
        }

        private void bebekİzlem_Load(object sender, EventArgs e)
        {
            listPanel.Add(pnlMain);
            listPanel.Add(pnl2);
            listPanel.Add(pnl3);

            listPanel[index].BringToFront();
        }

        private void onceki1_Click(object sender, EventArgs e)
        {
            if (index > 0)
                listPanel[--index].BringToFront();
            if (index == 0)
            {
                btn1.ImageIndex = 1;
                btn2.ImageIndex = btn3.ImageIndex = 0;
                Line1.BackColor = Line2.BackColor = Color.FromArgb(167, 167, 167);
                btnSonraki.Visible = true;
                btnUssSorgula.Visible = false;
                btnKaydet.Visible = false;
                btnOnceki.Visible = false;
            }
            else if (index == 1)
            {
                btn1.ImageIndex = 2;
                btn2.ImageIndex = 1;
                Line1.BackColor = Color.FromArgb(59, 249, 81);
                btnSonraki.Visible = false;
                btnUssSorgula.Visible = false;
                btnKaydet.Visible = true;
                btnOnceki.Visible = true;
            }
        }

        private void afiButton5_Click(object sender, EventArgs e)
        {
            {
                index = 2;
                listPanel[index].BringToFront();

                Line2.BackColor = Color.FromArgb(59, 249, 81);
                btn3.ImageIndex = 2;
                btn2.ImageIndex = 2;
            }
        }

        private void tbHastaAdi_Enter(object sender, EventArgs e)
        {
            if (tbHastaAdi.Texts == "Hasta Adı")
            {
                tbHastaAdi.Texts = "";
                tbHastaAdi.ForeColor = Color.Black;
            }
        }

        private void tbHastaAdi_Leave(object sender, EventArgs e)
        {
            if (tbHastaAdi.Texts == "")
            {
                tbHastaAdi.Texts = "Hasta Adı";
                tbHastaAdi.ForeColor = Color.DimGray;
            }
        }

        private void tbHastaTCKimlikNo_Enter(object sender, EventArgs e)
        {
            if (tbHastaTCKimlikNo.Texts == "Hasta T.C Kimlik No")
            {
                tbHastaTCKimlikNo.Texts = "";
                tbHastaTCKimlikNo.ForeColor = Color.Black;
            }
        }

        private void tbHastaTCKimlikNo_Leave(object sender, EventArgs e)
        {
            if (tbHastaTCKimlikNo.Texts == "")
            {
                tbHastaTCKimlikNo.Texts = "Hasta T.C Kimlik No";
                tbHastaTCKimlikNo.ForeColor = Color.DimGray;
            }
        }

        private void tbBebekAgirligi_Enter(object sender, EventArgs e)
        {
            if (tbBebekAgirligi.Texts == "Ağırlık")
            {
                tbBebekAgirligi.Texts = "";
                tbBebekAgirligi.ForeColor = Color.Black;
            }
        }

        private void tbBebekAgirligi_Leave(object sender, EventArgs e)
        {
            if (tbBebekAgirligi.Texts == "")
            {
                tbBebekAgirligi.Texts = "Ağırlık";
                tbBebekAgirligi.ForeColor = Color.DimGray;
            }
        }

        private void tbBebekBoyu_Enter(object sender, EventArgs e)
        {
            if (tbBebekBoyu.Texts == "Bebek Boyu")
            {
                tbBebekBoyu.Texts = "";
                tbBebekBoyu.ForeColor = Color.Black;
            }
        }

        private void tbBebekBoyu_Leave(object sender, EventArgs e)
        {
            if (tbBebekBoyu.Texts == "")
            {
                tbBebekBoyu.Texts = "Bebek Boyu";
                tbBebekBoyu.ForeColor = Color.DimGray;
            }
        }

        private void tbBebekBasCevresi_Enter(object sender, EventArgs e)
        {
            if (tbBebekBasCevresi.Texts == "Bebek Baş Çevresi ")
            {
                tbBebekBasCevresi.Texts = "";
                tbBebekBasCevresi.ForeColor = Color.Black;
            }
        }

        private void tbBebekBasCevresi_Leave(object sender, EventArgs e)
        {
            if (tbBebekBasCevresi.Texts == "")
            {
                tbBebekBasCevresi.Texts = "Bebek Baş Çevresi ";
                tbBebekBasCevresi.ForeColor = Color.DimGray;
            }
        }

        private void tbGogusCevresi_Enter(object sender, EventArgs e)
        {
            if (tbGogusCevresi.Texts == "Goğus")
            {
                tbGogusCevresi.Texts = "";
                tbGogusCevresi.ForeColor = Color.Black;
            }
        }

        private void tbGogusCevresi_Leave(object sender, EventArgs e)
        {
            if (tbGogusCevresi.Texts == "")
            {
                tbGogusCevresi.Texts = "Goğus";
                tbGogusCevresi.ForeColor = Color.DimGray;
            }
        }

        private void tbFontonel_Enter(object sender, EventArgs e)
        {
            if (tbFontonel.Texts == "Fontonel")
            {
                tbFontonel.Texts = "";
                tbFontonel.ForeColor = Color.Black;
            }
        }

        private void tbFontonel_Leave(object sender, EventArgs e)
        {
            if (tbFontonel.Texts == "")
            {
                tbFontonel.Texts = "Fontonel";
                tbFontonel.ForeColor = Color.DimGray;
            }

        }

        private void tbSist_Enter(object sender, EventArgs e)
        {
            if (tbSist.Texts == "Sist")
            {
                tbSist.Texts = "";
                tbSist.ForeColor = Color.Black;
            }

        }

        private void tbSist_Leave(object sender, EventArgs e)
        {
            if (tbSist.Texts == "")
            {
                tbSist.Texts = "Sist";
                tbSist.ForeColor = Color.DimGray;
            }
        }

        private void tbDias_Enter(object sender, EventArgs e)
        {
            if (tbDias.Texts == "Dias")
            {
                tbDias.Texts = "";
                tbDias.ForeColor = Color.Black;
            }
        }

        private void tbDias_Leave(object sender, EventArgs e)
        {
            if (tbDias.Texts == "")
            {
                tbDias.Texts = "Dias";
                tbDias.ForeColor = Color.DimGray;
            }
        }

        private void tbHemoglobin_Enter(object sender, EventArgs e)
        {
            if (tbHemoglobin.Texts == "Hemoglobin")
            {
                tbHemoglobin.Texts = "";
                tbHemoglobin.ForeColor = Color.Black;
            }
        }

        private void tbHemoglobin_Leave(object sender, EventArgs e)
        {
            if (tbHemoglobin.Texts == "")
            {
                tbHemoglobin.Texts = "Hemoglobin";
                tbHemoglobin.ForeColor = Color.DimGray;
            }
        }

        private void tbHematokrit_Enter(object sender, EventArgs e)
        {
            if (tbHematokrit.Texts == "Hematokrit")
            {
                tbHematokrit.Texts = "";
                tbHematokrit.ForeColor = Color.Black;
            }
        }

        private void tbHematokrit_Leave(object sender, EventArgs e)
        {
            if (tbHematokrit.Texts == "")
            {
                tbHematokrit.Texts = "Hematokrit";
                tbHematokrit.ForeColor = Color.DimGray;
            }
        }

        private void tbAnneSutuSuresi_Enter(object sender, EventArgs e)
        {
            if (tbAnneSutuSuresi.Texts == " Süre")
            {
                tbAnneSutuSuresi.Texts = "";
                tbAnneSutuSuresi.ForeColor = Color.Black;
            }
        }

        private void tbAnneSutuSuresi_Leave(object sender, EventArgs e)
        {
            if (tbAnneSutuSuresi.Texts == "")
            {
                tbAnneSutuSuresi.Texts = " Süre";
                tbAnneSutuSuresi.ForeColor = Color.DimGray;
            }
        }

        private void tbEkGidaBasladigiAy_Enter(object sender, EventArgs e)
        {
            if (tbEkGidaBasladigiAy.Texts == "Ay")
            {
                tbEkGidaBasladigiAy.Texts = "";
                tbEkGidaBasladigiAy.ForeColor = Color.Black;
            }
        }

        private void tbEkGidaBasladigiAy_Leave(object sender, EventArgs e)
        {
            if (tbEkGidaBasladigiAy.Texts == "")
            {
                tbEkGidaBasladigiAy.Texts = "Ay";
                tbEkGidaBasladigiAy.ForeColor = Color.DimGray;
            }
        }

        private void tbAnneSutundenKesildigiAy_DragEnter(object sender, DragEventArgs e)
        {
            if (tbAnneSutundenKesildigiAy.Texts == "Ay")
            {
                tbAnneSutundenKesildigiAy.Texts = "";
                tbAnneSutundenKesildigiAy.ForeColor = Color.Black;
            }
        }

        private void tbAnneSutundenKesildigiAy_Leave(object sender, EventArgs e)
        {
            if (tbAnneSutundenKesildigiAy.Texts == "")
            {
                tbAnneSutundenKesildigiAy.Texts = "Ay";
                tbAnneSutundenKesildigiAy.ForeColor = Color.DimGray;
            }
        }

        private void tbBebekCocukİzlemNotu_Enter(object sender, EventArgs e)
        {
            if (tbAnneSutundenKesildigiAy.Texts == "Bebek Çocuk İzlem Notu")
            {
                tbAnneSutundenKesildigiAy.Texts = "";
                tbAnneSutundenKesildigiAy.ForeColor = Color.Black;
            }
        }

        private void tbBebekCocukİzlemNotu_Leave(object sender, EventArgs e)
        {
            if (tbAnneSutundenKesildigiAy.Texts == "")
            {
                tbAnneSutundenKesildigiAy.Texts = "Bebek Çocuk İzlem Notu";
                tbAnneSutundenKesildigiAy.ForeColor = Color.DimGray;
            }
        }
    }
}
