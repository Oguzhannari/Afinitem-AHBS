
using Sunum.Static_Sınıflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunum.Static_Sınıflar;
namespace Sunum
{
    public partial class grafik : Form
    {
        Form form = new Form();
        public grafik()
        {
            InitializeComponent();
            chartBuyuk.Series["Veriler"].IsValueShownAsLabel = true;

            chartBuyuk.Series["Veriler"].Points.AddXY("Bebek", 27);
            chartBuyuk.Series["Veriler"].Points.AddXY("Çocuk", 94);
            chartBuyuk.Series["Veriler"].Points.AddXY("Gebe", 9);
            chartBuyuk.Series["Veriler"].Points.AddXY("65 Yaş Üstü", 492);
            chartBuyuk.Series["Veriler"].Points.AddXY("Mobil", 919);
            chartBuyuk.Series["Veriler"].Points.AddXY("Toplam", 2743);
            chartBuyuk.ChartAreas["ChartArea1"].BackColor = Color.Transparent;


            /*
            chart3.Series["Tarama/İzlem"].IsValueShownAsLabel = true;
            chart3.Series["Tarama/İzlem"].Points.AddXY("DİYABET", 31);
            chart3.Series["Tarama/İzlem"].Points.AddXY("HİPERTANSİYON", 116);
            chart3.Series["Tarama/İzlem"].Points.AddXY("OBEZİTE", 188);
            chart3.Series["Tarama/İzlem"].Points.AddXY("TKTT", 68);
            chart3.Series["Tarama/İzlem"].Points.AddXY("KVR", 24);
            chart3.ChartAreas["ChartArea1"].BackColor = Color.Transparent;
            */
            //chart3.Series["Tarama/İzlem"].IsValueShownAsLabel = true;
            chartAsi.Series["s1"].Points.AddXY("Sina", 25);
            chartAsi.Series["s1"].Points.AddXY("Yerel", 22);
            chartAsi.Series["s1"].Points.AddXY("Tamamlandı", 80);
            chartAsi.ChartAreas["ChartArea1"].BackColor = Color.Transparent;


            chartGebeİzlem.Series["s4"].Points.AddXY("Sina", 25);
            chartGebeİzlem.Series["s4"].Points.AddXY("Yerel", 22);
            chartGebeİzlem.Series["s4"].Points.AddXY("Tamamlandı", 80);
            chartGebeİzlem.ChartAreas["ChartArea1"].BackColor = Color.Transparent;

            chartCocukİzlem.Series["s5"].Points.AddXY("Sina", 25);
            chartCocukİzlem.Series["s5"].Points.AddXY("Yerel", 22);
            chartCocukİzlem.Series["s5"].Points.AddXY("Tamamlandı", 80);
            chartCocukİzlem.ChartAreas["ChartArea1"].BackColor = Color.Transparent;

            chartBebekİzlem.Series["s6"].Points.AddXY("Sina", 25);
            chartBebekİzlem.Series["s6"].Points.AddXY("Yerel", 22);
            chartBebekİzlem.Series["s6"].Points.AddXY("Tamamlandı", 80);
            chartBebekİzlem.ChartAreas["ChartArea1"].BackColor = Color.Transparent;

        }

        private void grafik_Load(object sender, EventArgs e)
        {
            panelBildirim.BackColor = Color.FromArgb(100, 215, 220, 213);
            //panel16.BackColor = Color.FromArgb(100, 243, 242, 237);
            //panel15.BackColor = Color.FromArgb(100, 243, 242, 237);
            //panel17.BackColor = Color.FromArgb(100, 243, 242, 237);
            //panel6.BackColor = Color.FromArgb(100, 243, 242, 237);
        }

        private void afiButton2_Click(object sender, EventArgs e)
        {
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
