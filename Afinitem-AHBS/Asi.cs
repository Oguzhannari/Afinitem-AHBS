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

    public partial class Asi : Form
    {
        List<Panel> listPanel = new List<Panel>();
        int index;
        public Asi()
        {
            InitializeComponent();
            ussSorgula.Visible = false;

        }


        private void Asi_Load(object sender, EventArgs e)
        {
            listPanel.Add(pnlMain);
            listPanel.Add(pnl2);
            listPanel.Add(pnl3);

            listPanel[index].BringToFront();
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Sonraki_Click_1(object sender, EventArgs e)
        {
            if (index < listPanel.Count - 1)
                listPanel[++index].BringToFront();
            if (index == 0)
            {
                btn1.ImageIndex = 1;
                btn2.ImageIndex = btn3.ImageIndex = 0;
                Line1.BackColor = Line2.BackColor =  Color.FromArgb(167, 167, 167);
                Sonraki.Visible = true;
                ussSorgula.Visible = true;
                afiButton5.Visible = false;
                onceki1.Visible = false;
            }
            else if (index == 1)
            {
                btn1.ImageIndex = 2;
                btn2.ImageIndex = 1;
                btn3.ImageIndex =  0;
                Line1.BackColor = Color.FromArgb(59, 249, 81);
                Line2.BackColor =  Color.FromArgb(167, 167, 167);
                Sonraki.Visible = false;
                ussSorgula.Visible = false;
                afiButton5.Visible = true;
                onceki1.Visible = true;
            }
        }
        private void pnl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void afiButton5_Click(object sender, EventArgs e)
        {
            index = 2;
            listPanel[index].BringToFront();

            Line2.BackColor = Color.FromArgb(59, 249, 81);
            btn3.ImageIndex = 2;
            btn2.ImageIndex = 2;
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
                Sonraki.Visible = true;
                ussSorgula.Visible = false;
                afiButton5.Visible = false;
                onceki1.Visible = false;
            }
            else if (index == 1)
            {
                btn1.ImageIndex = 2;
                btn2.ImageIndex = 1;
                Line1.BackColor = Color.FromArgb(59, 249, 81);
                Sonraki.Visible = false;
                ussSorgula.Visible = false;
                afiButton5.Visible = true;
                onceki1.Visible = true;
            }
        }

        private void tbKarekodNo_Enter(object sender, EventArgs e)
        {
            if (tbKarekodNo.Texts == "Karekod No")
            {
                tbKarekodNo.Texts = "";
                tbKarekodNo.ForeColor = Color.Black;
            }
        }

        private void tbKarekodNo_Leave(object sender, EventArgs e)
        {
            if (tbKarekodNo.Texts == "")
            {
                tbKarekodNo.Texts = "Karekod No";
                tbKarekodNo.ForeColor = Color.DimGray;
            }
        }

        private void tbSeriNo_Enter(object sender, EventArgs e)
        {
            if (tbSeriNo.Texts == "Seri No")
            {
                tbSeriNo.Texts = "";
                tbSeriNo.ForeColor = Color.Black;
            }
        }

        private void tbSeriNo_Leave(object sender, EventArgs e)
        {
            if (tbSeriNo.Texts == "")
            {
                tbSeriNo.Texts = "Seri No";
                tbSeriNo.ForeColor = Color.DimGray;
            }
        }

        private void tbHL7Kodu_Enter(object sender, EventArgs e)
        {
            if (tbHL7Kodu.Texts == "HL7 Kodu")
            {
                tbHL7Kodu.Texts = "";
                tbHL7Kodu.ForeColor = Color.Black;
            }
        }

        private void tbHL7Kodu_Leave(object sender, EventArgs e)
        {
            if (tbHL7Kodu.Texts == "")
            {
                tbHL7Kodu.Texts = "HL7 Kodu";
                tbHL7Kodu.ForeColor = Color.DimGray;
            }
        }

        private void tbEAN13_Enter(object sender, EventArgs e)
        {
            if (tbEAN13.Texts == "EAN-13")
            {
                tbEAN13.Texts = "";
                tbEAN13.ForeColor = Color.Black;
            }
        }

        private void tbEAN13_Leave(object sender, EventArgs e)
        {
            if (tbEAN13.Texts == "")
            {
                tbEAN13.Texts = "EAN-13";
                tbEAN13.ForeColor = Color.DimGray;
            }
        }

        private void tbLotNo_Enter(object sender, EventArgs e)
        {
            if (tbLotNo.Texts == "Lot No")
            {
                tbLotNo.Texts = "";
                tbLotNo.ForeColor = Color.Black;
            }
        }

        private void tbLotNo_Leave(object sender, EventArgs e)
        {
            if (tbLotNo.Texts == "")
            {
                tbLotNo.Texts = "Lot No";
                tbLotNo.ForeColor = Color.DimGray;
            }
        }

        private void tbSKT_Enter(object sender, EventArgs e)
        {
            if (tbSKT.Texts == "SKT")
            {
                tbSKT.Texts = "";
                tbSKT.ForeColor = Color.Black;
            }
        }

        private void tbSKT_Leave(object sender, EventArgs e)
        {
            if (tbSKT.Texts == "")
            {
                tbSKT.Texts = "SKT";
                tbSKT.ForeColor = Color.DimGray;
            }
        }

        private void tbKarekodBilgisi_Enter(object sender, EventArgs e)
        {
            if (tbKarekodBilgisi.Texts == "Karekod Bilgisi")
            {
                tbKarekodBilgisi.Texts = "";
                tbKarekodBilgisi.ForeColor = Color.Black;
            }
        }

        private void tbKarekodBilgisi_Leave(object sender, EventArgs e)
        {
            if (tbKarekodBilgisi.Texts == "")
            {
                tbKarekodBilgisi.Texts = "Karekod Bilgisi";
                tbKarekodBilgisi.ForeColor = Color.DimGray;
            }
        }

        private void tbSulandiriciKArekod_Enter(object sender, EventArgs e)
        {
            if (tbSulandiriciKArekod.Texts == "Sulandırıcı Karekodu ")
            {
                tbSulandiriciKArekod.Texts = "";
                tbSulandiriciKArekod.ForeColor = Color.Black;
            }
        }

        private void tbSulandiriciKArekod_Leave(object sender, EventArgs e)
        {
            if (tbSulandiriciKArekod.Texts == "")
            {
                tbSulandiriciKArekod.Texts = "Sulandırıcı Karekodu ";
                tbSulandiriciKArekod.ForeColor = Color.DimGray;
            }
        }

        private void tbAntiSerumKarekodu_Enter(object sender, EventArgs e)
        {
            if (tbAntiSerumKarekodu.Texts == "Anti Serum Karekodu")
            {
                tbAntiSerumKarekodu.Texts = "";
                tbAntiSerumKarekodu.ForeColor = Color.Black;
            }
        }

        private void tbAntiSerumKarekodu_Leave(object sender, EventArgs e)
        {
            if (tbAntiSerumKarekodu.Texts == "")
            {
                tbAntiSerumKarekodu.Texts = "Anti Serum Karekodu";
                tbAntiSerumKarekodu.ForeColor = Color.DimGray;
            }
        }

        private void tbAsiSorguNo_Enter(object sender, EventArgs e)
        {
            if (tbAsiSorguNo.Texts == "Aşı Sorgu No")
            {
                tbAsiSorguNo.Texts = "";
                tbAsiSorguNo.ForeColor = Color.Black;
            }

        }

        private void tbAsiSorguNo_Leave(object sender, EventArgs e)
        {
            if (tbAsiSorguNo.Texts == "")
            {
                tbAsiSorguNo.Texts = "Aşı Sorgu No";
                tbAsiSorguNo.ForeColor = Color.DimGray;
            }
        }

        private void tbAsiATSSorguNo_Enter(object sender, EventArgs e)
        {
            if (tbAsiATSSorguNo.Texts == "Aşı ATS Sorgu No")
            {
                tbAsiATSSorguNo.Texts = "";
                tbAsiATSSorguNo.ForeColor = Color.Black;
            }
        }

        private void tbAsiATSSorguNo_Leave(object sender, EventArgs e)
        {
            if (tbAsiATSSorguNo.Texts == "")
            {
                tbAsiATSSorguNo.Texts = "Aşı ATS Sorgu No";
                tbAsiATSSorguNo.ForeColor = Color.DimGray;
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
    }
}
