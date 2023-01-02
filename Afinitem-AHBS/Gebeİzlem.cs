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
    public partial class Gebeİzlem : Form
    {
        List<Panel> listPanel = new List<Panel>();
        int index;
        public Gebeİzlem()
        {
            InitializeComponent();
            btnSonraki.Visible = true;
            btnUssSorgula.Visible = true;
        }

        private void pnl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void Gebeİzlem_Load(object sender, EventArgs e)
        {
            listPanel.Add(pnlMain);
            listPanel.Add(pnl2);
            listPanel.Add(pnl3);

            listPanel[index].BringToFront();
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
                btnUssSorgula.Visible = true;
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

        private void afiButton5_Click(object sender, EventArgs e)
        {
            index = 2;
            listPanel[index].BringToFront();

            Line2.BackColor = Color.FromArgb(59, 249, 81);
            btn2.ImageIndex = 2;
            btn3.ImageIndex = 2;
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
                Line2.BackColor = Color.FromArgb(167, 167, 167);
                btn3.ImageIndex = 1;
                btnSonraki.Visible = false;
                btnUssSorgula.Visible = false;
                btnKaydet.Visible = true;
                btnOnceki.Visible = true;
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

        private void tbKanamaTakibi_Enter(object sender, EventArgs e)
        {
            if (tbKanamaTakibi.Texts == "Kanama Takipi")
            {
                tbKanamaTakibi.Texts = "";
                tbKanamaTakibi.ForeColor = Color.Black;
            }
        }

        private void tbKanamaTakibi_Leave(object sender, EventArgs e)
        {
            if (tbKanamaTakibi.Texts == "")
            {
                tbKanamaTakibi.Texts = "Kanama Takipi";
                tbKanamaTakibi.ForeColor = Color.DimGray;
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

        private void tbNAbiz_Enter(object sender, EventArgs e)
        {
            if (tbNAbiz.Texts == "Nabız")
            {
                tbNAbiz.Texts = "";
                tbNAbiz.ForeColor = Color.Black;
            }
        }

        private void tbNAbiz_Leave(object sender, EventArgs e)
        {
            if (tbNAbiz.Texts == "")
            {
                tbNAbiz.Texts = "Nabız";
                tbNAbiz.ForeColor = Color.DimGray;
            }
        }

        private void tbSistolikKanBasinci_Enter(object sender, EventArgs e)
        {
            if (tbSistolikKanBasinci.Texts == "Sistolik Kan Basıncı")
            {
                tbSistolikKanBasinci.Texts = "";
                tbSistolikKanBasinci.ForeColor = Color.Black;
            }
        }

        private void tbSistolikKanBasinci_Leave(object sender, EventArgs e)
        {
            if (tbSistolikKanBasinci.Texts == "")
            {
                tbSistolikKanBasinci.Texts = "Sistolik Kan Basıncı";
                tbSistolikKanBasinci.ForeColor = Color.DimGray;
            }

        }

        private void tbDiastolikKanBasinci_Enter(object sender, EventArgs e)
        {
            if (tbDiastolikKanBasinci.Texts == "Diastolik Kan Basıncı")
            {
                tbDiastolikKanBasinci.Texts = "";
                tbDiastolikKanBasinci.ForeColor = Color.Black;
            }
        }

        private void tbDiastolikKanBasinci_Leave(object sender, EventArgs e)
        {
            if (tbDiastolikKanBasinci.Texts == "")
            {
                tbDiastolikKanBasinci.Texts = "Diastolik Kan Basıncı";
                tbDiastolikKanBasinci.ForeColor = Color.DimGray;
            }
        }

        private void tbAtes_Enter(object sender, EventArgs e)
        {
            if (tbAtes.Texts == "Ateş")
            {
                tbAtes.Texts = "";
                tbAtes.ForeColor = Color.Black;
            }
        }

        private void tbAtes_Leave(object sender, EventArgs e)
        {
            if (tbAtes.Texts == "")
            {
                tbAtes.Texts = "Ateş";
                tbAtes.ForeColor = Color.DimGray;
            }
        }

        private void tbDogumSonuBakim_Enter(object sender, EventArgs e)
        {
            if (tbDogumSonuBakim.Texts == "Doğum Sonu Bakım Yönetim Rehberine Uygun İzlem, Sevk ve Danışmanlık")
            {
                tbDogumSonuBakim.Texts = "";
                tbDogumSonuBakim.ForeColor = Color.Black;
            }
        }

        private void tbDogumSonuBakim_Leave(object sender, EventArgs e)
        {
            if (tbDogumSonuBakim.Texts == "")
            {
                tbDogumSonuBakim.Texts = "Doğum Sonu Bakım Yönetim Rehberine Uygun İzlem, Sevk ve Danışmanlık";
                tbDogumSonuBakim.ForeColor = Color.DimGray;
            }
        }

        private void tbLohusaİzlemNotu_Enter(object sender, EventArgs e)
        {
            if (tbLohusaİzlemNotu.Texts == "Lohusa İzlem Not")
            {
                tbLohusaİzlemNotu.Texts = "";
                tbLohusaİzlemNotu.ForeColor = Color.Black;
            }
        }

        private void tbLohusaİzlemNotu_Leave(object sender, EventArgs e)
        {
            if (tbLohusaİzlemNotu.Texts == "")
            {
                tbLohusaİzlemNotu.Texts = "Lohusa İzlem Not";
                tbLohusaİzlemNotu.ForeColor = Color.DimGray;
            }
        }
    }
}
