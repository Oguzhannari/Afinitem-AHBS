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
    public partial class Hesap : Form
    {
        public Hesap()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void afiToggleButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbAdi_Enter(object sender, EventArgs e)
        {
            if (tbAdi.Texts == "Adı")
            {
                tbAdi.Texts = "";
                tbAdi.ForeColor = Color.Black;
            }
        }

        private void tbAdi_Leave(object sender, EventArgs e)
        {
            if (tbAdi.Texts == "")
            {
                tbAdi.Texts = "Adı";
                tbAdi.ForeColor = Color.DimGray;
            }
        }

        private void tbSoyadi_Enter(object sender, EventArgs e)
        {
            if (tbSoyadi.Texts == "Soyadı")
            {
                tbSoyadi.Texts = "";
                tbSoyadi.ForeColor = Color.Black;
            }
        }

        private void tbSoyadi_Leave(object sender, EventArgs e)
        {
            if (tbSoyadi.Texts == "")
            {
                tbSoyadi.Texts = "Soyadı";
                tbSoyadi.ForeColor = Color.DimGray;
            }
        }

        private void tbTCKimlik_Enter(object sender, EventArgs e)
        {
            if (tbTCKimlik.Texts == "T.C Kimlik No")
            {
                tbTCKimlik.Texts = "";
                tbTCKimlik.ForeColor = Color.Black;
            }
        }

        private void tbTCKimlik_Leave(object sender, EventArgs e)
        {
            if (tbTCKimlik.Texts == "")
            {
                tbTCKimlik.Texts = "T.C Kimlik No";
                tbTCKimlik.ForeColor = Color.DimGray;
            }
        }

        private void tbTelefon_Enter(object sender, EventArgs e)
        {
            if (tbTelefon.Texts == "Telefon ")
            {
                tbTelefon.Texts = "";
                tbTelefon.ForeColor = Color.Black;
            }
        }

        private void tbTelefon_Leave(object sender, EventArgs e)
        {
            if (tbTelefon.Texts == "")
            {
                tbTelefon.Texts = "Telefon ";
                tbTelefon.ForeColor = Color.DimGray;
            }
        }

        private void tbEposta_Enter(object sender, EventArgs e)
        {
            if (tbEposta.Texts == "E-Posta")
            {
                tbEposta.Texts = "";
                tbEposta.ForeColor = Color.Black;
            }
        }

        private void tbEposta_Leave(object sender, EventArgs e)
        {
            if (tbEposta.Texts == "")
            {
                tbEposta.Texts = "E-Posta";
                tbEposta.ForeColor = Color.DimGray;
            }
        }

        private void tbDiplomaTescil_Enter(object sender, EventArgs e)
        {
            if (tbDiplomaTescil.Texts == "Diploma Tescil Numarası")
            {
                tbDiplomaTescil.Texts = "";
                tbDiplomaTescil.ForeColor = Color.Black;
            }
        }

        private void tbDiplomaTescil_Leave(object sender, EventArgs e)
        {
            if (tbDiplomaTescil.Texts == "")
            {
                tbDiplomaTescil.Texts = "Diploma Tescil Numarası";
                tbDiplomaTescil.ForeColor = Color.DimGray;
            }
        }

        private void tbSertifikaNo_Enter(object sender, EventArgs e)
        {
            if (tbSertifikaNo.Texts == "Sertifika Numarası ")
            {
                tbSertifikaNo.Texts = "";
                tbSertifikaNo.ForeColor = Color.Black;
            }
        }

        private void tbSertifikaNo_Leave(object sender, EventArgs e)
        {
            if (tbSertifikaNo.Texts == "")
            {
                tbSertifikaNo.Texts = "Sertifika Numarası ";
                tbSertifikaNo.ForeColor = Color.DimGray;
            }
        }

        private void tbASMBirimKodu_Enter(object sender, EventArgs e)
        {
            if (tbASMBirimKodu.Texts == "ASM Birim Kodu")
            {
                tbASMBirimKodu.Texts = "";
                tbASMBirimKodu.ForeColor = Color.Black;
            }
        }



        private void tbUSSKullaniciSifresi_Enter(object sender, EventArgs e)
        {
            if (tbUSSKullaniciSifresi.Texts == "USS Kullanıcı Şifresi")
            {
                tbUSSKullaniciSifresi.Texts = "";
                tbUSSKullaniciSifresi.ForeColor = Color.Black;
            }
        }

        private void tbUSSKullaniciSifresi_Leave(object sender, EventArgs e)
        {
            if (tbUSSKullaniciSifresi.Texts == "")
            {
                tbUSSKullaniciSifresi.Texts = "USS Kullanıcı Şifresi";
                tbUSSKullaniciSifresi.ForeColor = Color.DimGray;
            }
        }

        private void tbASMBirimKodu_Leave_1(object sender, EventArgs e)
        {
            if (tbASMBirimKodu.Texts == "")
            {
                tbASMBirimKodu.Texts = "ASM Birim Kodu";
                tbASMBirimKodu.ForeColor = Color.DimGray;
            }

        }

        private void tbSGKEreceteSifresi_Enter(object sender, EventArgs e)
        {
            if (tbSGKEreceteSifresi.Texts == "SGK E-Reçete Şifresi")
            {
                tbSGKEreceteSifresi.Texts = "";
                tbSGKEreceteSifresi.ForeColor = Color.Black;
            }
        }

        private void tbSGKEreceteSifresi_Leave(object sender, EventArgs e)
        {
            if (tbSGKEreceteSifresi.Texts == "")
            {
                tbSGKEreceteSifresi.Texts = "SGK E-Reçete Şifresi";
                tbSGKEreceteSifresi.ForeColor = Color.DimGray;
            }
        }

        private void tbKPSv2KullaniciSifresi_Enter(object sender, EventArgs e)
        {
            if (tbKPSv2KullaniciSifresi.Texts == "KPSv2 Kullanıcı Şifresi")
            {
                tbKPSv2KullaniciSifresi.Texts = "";
                tbKPSv2KullaniciSifresi.ForeColor = Color.Black;
            }
        }

        private void tbKPSv2KullaniciSifresi_Leave(object sender, EventArgs e)
        {
            if (tbKPSv2KullaniciSifresi.Texts == "")
            {
                tbKPSv2KullaniciSifresi.Texts = "KPSv2 Kullanıcı Şifresi";
                tbKPSv2KullaniciSifresi.ForeColor = Color.DimGray;
            }
        }

        private void tbMELİSSifresi_Enter(object sender, EventArgs e)
        {
            if (tbMELİSSifresi.Texts == "MELİS Şifresi ")
            {
                tbMELİSSifresi.Texts = "";
                tbMELİSSifresi.ForeColor = Color.Black;
            }
        }

        private void tbMELİSSifresi_Leave(object sender, EventArgs e)
        {
            if (tbMELİSSifresi.Texts == "")
            {
                tbMELİSSifresi.Texts = "MELİS Şifresi ";
                tbMELİSSifresi.ForeColor = Color.DimGray;
            }

        }

        private void tbAHUZEMSifresi_Enter(object sender, EventArgs e)
        {
            if (tbAHUZEMSifresi.Texts == "AHUZEM Şifresi ")
            {
                tbAHUZEMSifresi.Texts = "";
                tbAHUZEMSifresi.ForeColor = Color.Black;
            }
        }

        private void tbAHUZEMSifresi_Leave(object sender, EventArgs e)
        {
            if (tbAHUZEMSifresi.Texts == "")
            {
                tbAHUZEMSifresi.Texts = "AHUZEM Şifresi ";
                tbAHUZEMSifresi.ForeColor = Color.DimGray;
            }

        }

        private void tbATSKullanimSifresi_Enter(object sender, EventArgs e)
        {
            if (tbATSKullanimSifresi.Texts == "ATS Kullanım Şifresi ")
            {
                tbATSKullanimSifresi.Texts = "";
                tbATSKullanimSifresi.ForeColor = Color.Black;
            }
        }

        private void tbATSKullanimSifresi_Leave(object sender, EventArgs e)
        {
            if (tbATSKullanimSifresi.Texts == "")
            {
                tbATSKullanimSifresi.Texts = "ATS Kullanım Şifresi ";
                tbATSKullanimSifresi.ForeColor = Color.DimGray;
            }
        }

        private void tbUygulamaSifresi_Enter(object sender, EventArgs e)
        {
            if (tbUygulamaSifresi.Texts == "Uygulama Şifresi")
            {
                tbUygulamaSifresi.Texts = "";
                tbUygulamaSifresi.ForeColor = Color.Black;
            }
        }

        private void tbUygulamaSifresi_Leave(object sender, EventArgs e)
        {
            if (tbUygulamaSifresi.Texts == "")
            {
                tbUygulamaSifresi.Texts = "Uygulama Şifresi";
                tbUygulamaSifresi.ForeColor = Color.DimGray;
            }
        }
    }
}
