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
    public partial class İzlem15_49 : Form
    {
        List<Panel> listPanel = new List<Panel>();
        int index;
        public İzlem15_49()
        {
            InitializeComponent();
            btnSonraki.Visible = true;
            btnUssSorgula.Visible = true;
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

        private void İzlem15_49_Load(object sender, EventArgs e)
        {
            listPanel.Add(pnlMain);
            listPanel.Add(pnl2);
            listPanel.Add(pnl3);

            listPanel[index].BringToFront();
        }

        private void afiButton5_Click(object sender, EventArgs e)
        {
            index = 2;
            listPanel[index].BringToFront();

            Line2.BackColor = Color.FromArgb(59, 249, 81);
            btn2.ImageIndex = 2;
            btn3.ImageIndex = 2;
        }

        private void tbHastaAdi_Enter(object sender, EventArgs e)
        {
            if (tbHastaAdi.Texts == "Hasta Adı ")
            {
                tbHastaAdi.Texts = "";
                tbHastaAdi.ForeColor = Color.Black;
            }
        }

        private void tbHastaAdi_Leave(object sender, EventArgs e)
        {
            if (tbHastaAdi.Texts == "")
            {
                tbHastaAdi.Texts = "Hasta Adı ";
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

        private void tbEvlenmeYasi_Enter(object sender, EventArgs e)
        {
            if (tbEvlenmeYasi.Texts == "Yaş")
            {
                tbEvlenmeYasi.Texts = "";
                tbEvlenmeYasi.ForeColor = Color.Black;
            }
        }

        private void tbEvlenmeYasi_Leave(object sender, EventArgs e)
        {
            if (tbEvlenmeYasi.Texts == "")
            {
                tbEvlenmeYasi.Texts = "Yaş";
                tbEvlenmeYasi.ForeColor = Color.DimGray;
            }
        }

        private void tbKenDusuk_Enter(object sender, EventArgs e)
        {
            if (tbKenDusuk.Texts == "Sayısı")
            {
                tbKenDusuk.Texts = "";
                tbKenDusuk.ForeColor = Color.Black;
            }
        }

        private void tbKenDusuk_Leave(object sender, EventArgs e)
        {
            if (tbKenDusuk.Texts == "")
            {
                tbKenDusuk.Texts = "Sayısı";
                tbKenDusuk.ForeColor = Color.DimGray;
            }
        }

        private void tbİlkGebelikYasi_Enter(object sender, EventArgs e)
        {
            if (tbİlkGebelikYasi.Texts == "Yaş")
            {
                tbİlkGebelikYasi.Texts = "";
                tbİlkGebelikYasi.ForeColor = Color.Black;
            }
        }

        private void tbİlkGebelikYasi_Leave(object sender, EventArgs e)
        {
            if (tbİlkGebelikYasi.Texts == "")
            {
                tbİlkGebelikYasi.Texts = "Yaş";
                tbİlkGebelikYasi.ForeColor = Color.DimGray;
            }
        }

        private void tbİlkAdetYasi_Enter(object sender, EventArgs e)
        {
            if (tbİlkAdetYasi.Texts == "Yaş")
            {
                tbİlkAdetYasi.Texts = "";
                tbİlkAdetYasi.ForeColor = Color.Black;
            }
        }

        private void tbİlkAdetYasi_Leave(object sender, EventArgs e)
        {
            if (tbİlkAdetYasi.Texts == "")
            {
                tbİlkAdetYasi.Texts = "Yaş";
                tbİlkAdetYasi.ForeColor = Color.DimGray;
            }
        }

        private void tbGebelikSayisi_Enter(object sender, EventArgs e)
        {
            if (tbGebelikSayisi.Texts == "Sayısı")
            {
                tbGebelikSayisi.Texts = "";
                tbGebelikSayisi.ForeColor = Color.Black;
            }
        }

        private void tbGebelikSayisi_Leave(object sender, EventArgs e)
        {
            if (tbGebelikSayisi.Texts == "")
            {
                tbGebelikSayisi.Texts = "Sayısı";
                tbGebelikSayisi.ForeColor = Color.DimGray;
            }
        }

        private void tbDogumSayisi_Enter(object sender, EventArgs e)
        {
            if (tbDogumSayisi.Texts == "Sayısı")
            {
                tbDogumSayisi.Texts = "";
                tbDogumSayisi.ForeColor = Color.Black;
            }
        }

        private void tbDogumSayisi_Leave(object sender, EventArgs e)
        {
            if (tbDogumSayisi.Texts == "")
            {
                tbDogumSayisi.Texts = "Sayısı";
                tbDogumSayisi.ForeColor = Color.DimGray;
            }
        }

        private void tbDismenore_Enter(object sender, EventArgs e)
        {
            if (tbDismenore.Texts == "Dismenore")
            {
                tbDismenore.Texts = "";
                tbDismenore.ForeColor = Color.Black;
            }
        }

        private void tbDismenore_Leave(object sender, EventArgs e)
        {
            if (tbDismenore.Texts == "")
            {
                tbDismenore.Texts = "Dismenore";
                tbDismenore.ForeColor = Color.DimGray;
            }
        }

        private void tbSahteGebelik_Enter(object sender, EventArgs e)
        {
            if (tbSahteGebelik.Texts == "Sayısı")
            {
                tbSahteGebelik.Texts = "";
                tbSahteGebelik.ForeColor = Color.Black;
            }
        }

        private void tbSahteGebelik_Leave(object sender, EventArgs e)
        {
            if (tbSahteGebelik.Texts == "")
            {
                tbSahteGebelik.Texts = "Sayısı";
                tbSahteGebelik.ForeColor = Color.DimGray;
            }
        }

        private void tbİsteyerekDusuk_Enter(object sender, EventArgs e)
        {
            if (tbİsteyerekDusuk.Texts == "Sayısı")
            {
                tbİsteyerekDusuk.Texts = "";
                tbİsteyerekDusuk.ForeColor = Color.Black;
            }
        }

        private void tbİsteyerekDusuk_Leave(object sender, EventArgs e)
        {
            if (tbİsteyerekDusuk.Texts == "")
            {
                tbİsteyerekDusuk.Texts = "Sayısı";
                tbİsteyerekDusuk.ForeColor = Color.DimGray;
            }
        }

        private void tbTerDusuk_Enter(object sender, EventArgs e)
        {
            if (tbTerDusuk.Texts == "Sayısı")
            {
                tbTerDusuk.Texts = "";
                tbTerDusuk.ForeColor = Color.Black;
            }
        }

        private void tbTerDusuk_Leave(object sender, EventArgs e)
        {
            if (tbTerDusuk.Texts == "")
            {
                tbTerDusuk.Texts = "Sayısı";
                tbTerDusuk.ForeColor = Color.DimGray;
            }
        }

        private void tbCanliDogan_Enter(object sender, EventArgs e)
        {
            if (tbCanliDogan.Texts == "Sayısı")
            {
                tbCanliDogan.Texts = "";
                tbCanliDogan.ForeColor = Color.Black;
            }
        }

        private void tbCanliDogan_Leave(object sender, EventArgs e)
        {
            if (tbCanliDogan.Texts == "")
            {
                tbCanliDogan.Texts = "Sayısı";
                tbCanliDogan.ForeColor = Color.DimGray;
            }
        }

        private void tbAdetKes_Enter(object sender, EventArgs e)
        {
            if (tbAdetKes.Texts == "Değer")
            {
                tbAdetKes.Texts = "";
                tbAdetKes.ForeColor = Color.Black;
            }
        }

        private void tbAdetKes_Leave(object sender, EventArgs e)
        {
            if (tbAdetKes.Texts == "")
            {
                tbAdetKes.Texts = "Değer";
                tbAdetKes.ForeColor = Color.DimGray;
            }
        }

        private void tbTalasemi_Enter(object sender, EventArgs e)
        {
            if (tbTalasemi.Texts == "Değer")
            {
                tbTalasemi.Texts = "";
                tbTalasemi.ForeColor = Color.Black;
            }
        }

        private void tbTalasemi_Leave(object sender, EventArgs e)
        {
            if (tbTalasemi.Texts == "")
            {
                tbTalasemi.Texts = "Değer";
                tbTalasemi.ForeColor = Color.DimGray;
            }
        }

        private void tbYasCok_Enter(object sender, EventArgs e)
        {
            if (tbYasCok.Texts == "Değer")
            {
                tbYasCok.Texts = "";
                tbYasCok.ForeColor = Color.Black;
            }
        }

        private void tbYasCok_Leave(object sender, EventArgs e)
        {
            if (tbYasCok.Texts == "")
            {
                tbYasCok.Texts = "Değer";
                tbYasCok.ForeColor = Color.DimGray;
            }
        }

        private void tbOlenCocuk_Enter(object sender, EventArgs e)
        {
            if (tbOlenCocuk.Texts == "Değer")
            {
                tbOlenCocuk.Texts = "";
                tbOlenCocuk.ForeColor = Color.Black;
            }
        }

        private void tbOlenCocuk_Leave(object sender, EventArgs e)
        {
            if (tbOlenCocuk.Texts == "")
            {
                tbOlenCocuk.Texts = "Değer";
                tbOlenCocuk.ForeColor = Color.DimGray;
            }
        }
    }
}
