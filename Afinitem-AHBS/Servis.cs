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
    public partial class Servis : Form
    {
        public Servis()
        {
            InitializeComponent();
        }

        private void tbUSSBeklemeSuresi_Enter(object sender, EventArgs e)
        {
            if (tbUSSBeklemeSuresi.Texts == "Bekleme Süresi ")
            {
                tbUSSBeklemeSuresi.Texts = "";
                tbUSSBeklemeSuresi.ForeColor = Color.Black;
            }
        }

        private void tbUSSBeklemeSuresi_Leave(object sender, EventArgs e)
        {
            if (tbUSSBeklemeSuresi.Texts == "")
            {
                tbUSSBeklemeSuresi.Texts = "Bekleme Süresi ";
                tbUSSBeklemeSuresi.ForeColor = Color.DimGray;
            }
        }

        private void tbMernisBeklemeSuresi_Enter(object sender, EventArgs e)
        {
            if (tbMernisBeklemeSuresi.Texts == "Bekleme Süresi ")
            {
                tbMernisBeklemeSuresi.Texts = "";
                tbMernisBeklemeSuresi.ForeColor = Color.Black;
            }
        }

        private void tbMernisBeklemeSuresi_Leave(object sender, EventArgs e)
        {
            if (tbMernisBeklemeSuresi.Texts == "")
            {
                tbMernisBeklemeSuresi.Texts = "Bekleme Süresi ";
                tbMernisBeklemeSuresi.ForeColor = Color.DimGray;
            }
        }

        private void tbEReceteBeklemeSuresi_Enter(object sender, EventArgs e)
        {
            if (tbEReceteBeklemeSuresi.Texts == "Bekleme Süresi ")
            {
                tbEReceteBeklemeSuresi.Texts = "";
                tbEReceteBeklemeSuresi.ForeColor = Color.Black;
            }
        }

        private void tbEReceteBeklemeSuresi_Leave(object sender, EventArgs e)
        {
            if (tbEReceteBeklemeSuresi.Texts == "")
            {
                tbEReceteBeklemeSuresi.Texts = "Bekleme Süresi ";
                tbEReceteBeklemeSuresi.ForeColor = Color.DimGray;
            }
        }

        private void tbSinaBeklemeSuresi_Enter(object sender, EventArgs e)
        {
            if (tbSinaBeklemeSuresi.Texts == "Bekleme Süresi ")
            {
                tbSinaBeklemeSuresi.Texts = "";
                tbSinaBeklemeSuresi.ForeColor = Color.Black;
            }
        }

        private void tbSinaBeklemeSuresi_Leave(object sender, EventArgs e)
        {
            if (tbSinaBeklemeSuresi.Texts == "")
            {
                tbSinaBeklemeSuresi.Texts = "Bekleme Süresi ";
                tbSinaBeklemeSuresi.ForeColor = Color.DimGray;
            }
        }

        private void tbTumSorgularBeklemeSuresi_Enter(object sender, EventArgs e)
        {
            if (tbTumSorgularBeklemeSuresi.Texts == "Bekleme Süresi ")
            {
                tbTumSorgularBeklemeSuresi.Texts = "";
                tbTumSorgularBeklemeSuresi.ForeColor = Color.Black;
            }
        }

        private void tbTumSorgularBeklemeSuresi_Leave(object sender, EventArgs e)
        {
            if (tbTumSorgularBeklemeSuresi.Texts == "")
            {
                tbTumSorgularBeklemeSuresi.Texts = "Bekleme Süresi ";
                tbTumSorgularBeklemeSuresi.ForeColor = Color.DimGray;
            }
        }
    }
}
