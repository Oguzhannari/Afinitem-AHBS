using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sunum.Formlar.Ayarlar
{
    public partial class HastaKabulAyarlari : Form
    {
        public HastaKabulAyarlari()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
       #region tuş silmeleri
        private void tbHastaKabulBilgisayarAdi_Enter(object sender, EventArgs e)
        {
            if (tbHastaKabulBilgisayarAdi.Texts == "Bilgisayar Adı")
            {
                tbHastaKabulBilgisayarAdi.Texts = "";
                tbHastaKabulBilgisayarAdi.ForeColor = Color.Black;
            }
        }

        private void tbHastaKabulBilgisayarAdi_Leave(object sender, EventArgs e)
        {
            if (tbHastaKabulBilgisayarAdi.Texts == "")
            {
                tbHastaKabulBilgisayarAdi.Texts = "Bilgisayar Adı";
                tbHastaKabulBilgisayarAdi.ForeColor = Color.DimGray;
            }
        }




        private void tbTabletİPAdresi_Enter(object sender, EventArgs e)
        {
            if (tbTabletİPAdresi.Texts == "IP Adresi")
            {
                tbTabletİPAdresi.Texts = "";
                tbTabletİPAdresi.ForeColor = Color.Black;
            }
        }


        private void tbSmsAramaTelefonİp_Enter(object sender, EventArgs e)
        {
            if (tbSmsAramaTelefonİp.Texts == "Telefon IP ")
            {
                tbSmsAramaTelefonİp.Texts = "";
                tbSmsAramaTelefonİp.ForeColor = Color.Black;
            }
        }



        private void tbTelefonGüvenlikKodu_Enter(object sender, EventArgs e)
        {
            if (tbTelefonGüvenlikKodu.Texts == "Telefon Güvenlik Kodu")
            {
                tbTelefonGüvenlikKodu.Texts = "";
                tbTelefonGüvenlikKodu.ForeColor = Color.Black;
            }
        }



        private void tbKarekodTelefonİP_Enter(object sender, EventArgs e)
        {
            if (tbKarekodTelefonİP.Texts == "Karekod İçin Telefon IP")
            {
                tbKarekodTelefonİP.Texts = "";
                tbKarekodTelefonİP.ForeColor = Color.Black;
            }
        }



        private void tbTelefonGuvenlikKodu_Enter(object sender, EventArgs e)
        {
            if (tbTelefonGuvenlikKodu.Texts == "Telefon Güvenlik Kodu")
            {
                tbTelefonGuvenlikKodu.Texts = "";
                tbTelefonGuvenlikKodu.ForeColor = Color.Black;
            }
        }



        private void tbKapiUstuGosterimSuresi_Enter(object sender, EventArgs e)
        {
            if (tbKapiUstuGosterimSuresi.Texts == "Gösterim Süresi")
            {
                tbKapiUstuGosterimSuresi.Texts = "";
                tbKapiUstuGosterimSuresi.ForeColor = Color.Black;
            }
        }



        private void tbTabletİPAdresi_Leave(object sender, EventArgs e)
        {
            if (tbTabletİPAdresi.Texts == "")
            {
                tbTabletİPAdresi.Texts = "IP Adresi";
                tbTabletİPAdresi.ForeColor = Color.DimGray;
            }
        }

        private void tbSmsAramaTelefonİp_Leave(object sender, EventArgs e)
        {
            if (tbSmsAramaTelefonİp.Texts == "")
            {
                tbSmsAramaTelefonİp.Texts = "Telefon IP ";
                tbSmsAramaTelefonİp.ForeColor = Color.DimGray;
            }
        }

        private void tbTelefonGüvenlikKodu_Leave(object sender, EventArgs e)
        {
            if (tbTelefonGüvenlikKodu.Texts == "")
            {
                tbTelefonGüvenlikKodu.Texts = "Telefon Güvenlik Kodu";
                tbTelefonGüvenlikKodu.ForeColor = Color.DimGray;
            }
        }

        private void tbKarekodTelefonİP_Leave(object sender, EventArgs e)
        {
            if (tbKarekodTelefonİP.Texts == "")
            {
                tbKarekodTelefonİP.Texts = "Karekod İçin Telefon IP";
                tbKarekodTelefonİP.ForeColor = Color.DimGray;
            }
        }

        private void tbTelefonGuvenlikKodu_Leave(object sender, EventArgs e)
        {
            if (tbTelefonGuvenlikKodu.Texts == "")
            {
                tbTelefonGuvenlikKodu.Texts = "Telefon Güvenlik Kodu";
                tbTelefonGuvenlikKodu.ForeColor = Color.DimGray;
            }
        }

        private void tbKapiUstuGosterimSuresi_Leave(object sender, EventArgs e)
        {
            if (tbTelefonGuvenlikKodu.Texts == "")
            {
                tbTelefonGuvenlikKodu.Texts = "Gösterim Süresi";
                tbTelefonGuvenlikKodu.ForeColor = Color.DimGray;
            }
        }
        #endregion
    }
}
