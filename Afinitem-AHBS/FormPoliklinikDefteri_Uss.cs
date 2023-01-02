using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sunum.Formlar.PoliklinikDefteriV2
{
	public partial class FormPoliklinikDefteri_Uss : DevExpress.XtraEditors.XtraForm
	{
		public FormPoliklinikDefteri_Uss()
		{
			InitializeComponent();
            duzenleme();
		}





		#region düzenleme
		private void duzenleme()
		{
            double olcek_height = (1050.0 - Screen.PrimaryScreen.Bounds.Height) / 1050;
            double olcek_width = (1680.0 - Screen.PrimaryScreen.Bounds.Width) / 1680;
            tableLayoutPanel1.Width -= Convert.ToInt16(tableLayoutPanel1.Width * olcek_width);
            tableLayoutPanel1.Height -= Convert.ToInt16(tableLayoutPanel1.Height * olcek_height);
            panel1.Width -= Convert.ToInt16(panel1.Width * olcek_width);
            panel1.Height -= Convert.ToInt16(panel1.Height * olcek_height);
            panel2.Width -= Convert.ToInt16(panel2.Width * olcek_width);
            panel2.Height -= Convert.ToInt16(panel2.Height * olcek_height);
            panel3.Width -= Convert.ToInt16(panel3.Width * olcek_width);
            panel3.Height -= Convert.ToInt16(panel3.Height * olcek_height);
            dpBaslangicTarihiMax.Width -= Convert.ToInt16(dpBaslangicTarihiMax.Width * olcek_width);
            dpBaslangicTarihiMax.Height -= Convert.ToInt16(dpBaslangicTarihiMax.Height * olcek_height);
            dpBaslangicTarihiMin.Width -= Convert.ToInt16(dpBaslangicTarihiMin.Width * olcek_width);
            dpBaslangicTarihiMin.Height -= Convert.ToInt16(dpBaslangicTarihiMin.Height * olcek_height);
            btnİslemleriGonder.Width -= Convert.ToInt16(btnİslemleriGonder.Width * olcek_width);
            btnİslemleriGonder.Height -= Convert.ToInt16(btnİslemleriGonder.Height * olcek_height);
            btnGonderlmemisİslemlerinTumunuSec.Width -= Convert.ToInt16(btnGonderlmemisİslemlerinTumunuSec.Width * olcek_width);
            btnGonderlmemisİslemlerinTumunuSec.Height -= Convert.ToInt16(btnGonderlmemisİslemlerinTumunuSec.Height * olcek_height);
            btnSorgula.Width -= Convert.ToInt16(btnSorgula.Width * olcek_width);
            btnSorgula.Height -= Convert.ToInt16(btnSorgula.Height * olcek_height);
            btnSecilenleriSil.Width -= Convert.ToInt16(btnSecilenleriSil.Width * olcek_width);
            btnSecilenleriSil.Height -= Convert.ToInt16(btnSecilenleriSil.Height * olcek_height);
            btnSecilenleriGonder.Width -= Convert.ToInt16(btnSecilenleriGonder.Width * olcek_width);
            btnSecilenleriGonder.Height -= Convert.ToInt16(btnSecilenleriGonder.Height * olcek_height);
            btnExceleGonder.Width -= Convert.ToInt16(btnExceleGonder.Width * olcek_width);
            btnExceleGonder.Height -= Convert.ToInt16(btnExceleGonder.Height * olcek_height);
            grid.Width -= Convert.ToInt16(grid.Width * olcek_width);
            grid.Height -= Convert.ToInt16(grid.Height * olcek_height);
            Column2.Width -= Convert.ToInt16(Column2.Width * olcek_width);
            Column1.Width -= Convert.ToInt16(Column1.Width * olcek_width);
            Column3.Width -= Convert.ToInt16(Column3.Width * olcek_width);
            Column4.Width -= Convert.ToInt16(Column4.Width * olcek_width);
            Column5.Width -= Convert.ToInt16(Column5.Width * olcek_width);
            Column6.Width -= Convert.ToInt16(Column6.Width * olcek_width);

            label13.Width -= Convert.ToInt16(label13.Width * olcek_width);
            label13.Height -= Convert.ToInt16(label13.Height * olcek_height);
            panel4.Width -= Convert.ToInt16(panel4.Width * olcek_width);
            panel4.Height -= Convert.ToInt16(panel4.Height * olcek_height);
            label15.Width -= Convert.ToInt16(label15.Width * olcek_width);
            label15.Height -= Convert.ToInt16(label15.Height * olcek_height);
            pictureBox1.Width -= Convert.ToInt16(pictureBox1.Width * olcek_width);
            pictureBox1.Height -= Convert.ToInt16(pictureBox1.Height * olcek_height);
            panel5.Width -= Convert.ToInt16(panel5.Width * olcek_width);
            panel5.Height -= Convert.ToInt16(panel5.Height * olcek_height);
            label23.Width -= Convert.ToInt16(label23.Width * olcek_width);
            label23.Height -= Convert.ToInt16(label23.Height * olcek_height);
            pictureBox2.Width -= Convert.ToInt16(pictureBox2.Width * olcek_width);
            pictureBox2.Height -= Convert.ToInt16(pictureBox2.Height * olcek_height);
            panel9.Width -= Convert.ToInt16(panel9.Width * olcek_width);
            panel9.Height -= Convert.ToInt16(panel9.Height * olcek_height);
            label27.Width -= Convert.ToInt16(label27.Width * olcek_width);
            label27.Height -= Convert.ToInt16(label27.Height * olcek_height);
            pictureBox6.Width -= Convert.ToInt16(pictureBox6.Width * olcek_width);
            pictureBox6.Height -= Convert.ToInt16(pictureBox6.Height * olcek_height);
            panel3.Width -= Convert.ToInt16(panel3.Width * olcek_width);
            panel3.Height -= Convert.ToInt16(panel3.Height * olcek_height);
            label28.Width -= Convert.ToInt16(label28.Width * olcek_width);
            label28.Height -= Convert.ToInt16(label28.Height * olcek_height);
            pictureBox9.Width -= Convert.ToInt16(pictureBox9.Width * olcek_width);
            pictureBox9.Height -= Convert.ToInt16(pictureBox9.Height * olcek_height);
            pictureBox44.Width -= Convert.ToInt16(pictureBox44.Width * olcek_width);
            pictureBox44.Height -= Convert.ToInt16(pictureBox44.Height * olcek_height);
            pictureBox40.Width -= Convert.ToInt16(pictureBox40.Width * olcek_width);
            pictureBox40.Height -= Convert.ToInt16(pictureBox40.Height * olcek_height);
            label21.Width -= Convert.ToInt16(label21.Width * olcek_width);
            label21.Height -= Convert.ToInt16(label21.Height * olcek_height);
            pictureBox38.Width -= Convert.ToInt16(pictureBox38.Width * olcek_width);
            pictureBox38.Height -= Convert.ToInt16(pictureBox38.Height * olcek_height);
            label18.Width -= Convert.ToInt16(label18.Width * olcek_width);
            label18.Height -= Convert.ToInt16(label18.Height * olcek_height);
            pictureBox36.Width -= Convert.ToInt16(pictureBox36.Width * olcek_width);
            pictureBox36.Height -= Convert.ToInt16(pictureBox36.Height * olcek_height);
            label16.Width -= Convert.ToInt16(label16.Width * olcek_width);
            label16.Height -= Convert.ToInt16(label16.Height * olcek_height);
            label20.Width -= Convert.ToInt16(label20.Width * olcek_width);
            label20.Height -= Convert.ToInt16(label20.Height * olcek_height);
            label19.Width -= Convert.ToInt16(label19.Width * olcek_width);
            label19.Height -= Convert.ToInt16(label19.Height * olcek_height);
            pictureBox41.Width -= Convert.ToInt16(pictureBox41.Width * olcek_width);
            pictureBox41.Height -= Convert.ToInt16(pictureBox41.Height * olcek_height);
            pictureBox42.Width -= Convert.ToInt16(pictureBox42.Width * olcek_width);
            pictureBox42.Height -= Convert.ToInt16(pictureBox42.Height * olcek_height);
            pictureBox39.Width -= Convert.ToInt16(pictureBox39.Width * olcek_width);
            pictureBox39.Height -= Convert.ToInt16(pictureBox39.Height * olcek_height);
            label17.Width -= Convert.ToInt16(label17.Width * olcek_width);
            label17.Height -= Convert.ToInt16(label17.Height * olcek_height);
            pictureBox8.Width -= Convert.ToInt16(pictureBox8.Width * olcek_width);
            pictureBox8.Height -= Convert.ToInt16(pictureBox8.Height * olcek_height);
            label14.Width -= Convert.ToInt16(label14.Width * olcek_width);
            label14.Height -= Convert.ToInt16(label14.Height * olcek_height);
            pictureBox7.Width -= Convert.ToInt16(pictureBox7.Width * olcek_width);
            pictureBox7.Height -= Convert.ToInt16(pictureBox7.Height * olcek_height);
            label4.Width -= Convert.ToInt16(label4.Width * olcek_width);
            label4.Height -= Convert.ToInt16(label4.Height * olcek_height);
            label3.Width -= Convert.ToInt16(label3.Width * olcek_width);
            label3.Height -= Convert.ToInt16(label3.Height * olcek_height);
            pictureBox43.Width -= Convert.ToInt16(pictureBox43.Width * olcek_width);
            pictureBox43.Height -= Convert.ToInt16(pictureBox43.Height * olcek_height);
            pictureBox45.Width -= Convert.ToInt16(pictureBox45.Width * olcek_width);
            pictureBox45.Height -= Convert.ToInt16(pictureBox45.Height * olcek_height);
            label1.Width -= Convert.ToInt16(label1.Width * olcek_width);
            label1.Height -= Convert.ToInt16(label1.Height * olcek_height);
            label7.Width -= Convert.ToInt16(label7.Width * olcek_width);
            label7.Height -= Convert.ToInt16(label7.Height * olcek_height);
            label2.Width -= Convert.ToInt16(label2.Width * olcek_width);
            label2.Height -= Convert.ToInt16(label2.Height * olcek_height);
            label6.Width -= Convert.ToInt16(label6.Width * olcek_width);
            label6.Height -= Convert.ToInt16(label6.Height * olcek_height);
            label24.Width -= Convert.ToInt16(label24.Width * olcek_width);
            label24.Height -= Convert.ToInt16(label24.Height * olcek_height);
            pictureBox5.Width -= Convert.ToInt16(pictureBox5.Width * olcek_width);
            pictureBox5.Height -= Convert.ToInt16(pictureBox5.Height * olcek_height);
            label26.Width -= Convert.ToInt16(label26.Width * olcek_width);
            label26.Height -= Convert.ToInt16(label26.Height * olcek_height);
            pictureBox4.Width -= Convert.ToInt16(pictureBox4.Width * olcek_width);
            pictureBox4.Height -= Convert.ToInt16(pictureBox4.Height * olcek_height);
            label25.Width -= Convert.ToInt16(label25.Width * olcek_width);
            label25.Height -= Convert.ToInt16(label25.Height * olcek_height);
            pictureBox3.Width -= Convert.ToInt16(pictureBox3.Width * olcek_width);
            pictureBox3.Height -= Convert.ToInt16(pictureBox3.Height * olcek_height);
            pictureBox18.Width -= Convert.ToInt16(pictureBox18.Width * olcek_width);
            pictureBox18.Height -= Convert.ToInt16(pictureBox18.Height * olcek_height);
            pictureBox27.Width -= Convert.ToInt16(pictureBox27.Width * olcek_width);
            pictureBox27.Height -= Convert.ToInt16(pictureBox27.Height * olcek_height);
            pictureBox28.Width -= Convert.ToInt16(pictureBox28.Width * olcek_width);
            pictureBox28.Height -= Convert.ToInt16(pictureBox28.Height * olcek_height);
            label12.Width -= Convert.ToInt16(label12.Width * olcek_width);
            label12.Height -= Convert.ToInt16(label12.Height * olcek_height);
            pictureBox29.Width -= Convert.ToInt16(pictureBox29.Width * olcek_width);
            pictureBox29.Height -= Convert.ToInt16(pictureBox29.Height * olcek_height);
            label11.Width -= Convert.ToInt16(label11.Width * olcek_width);
            label11.Height -= Convert.ToInt16(label11.Height * olcek_height);
            pictureBox34.Width -= Convert.ToInt16(pictureBox34.Width * olcek_width);
            pictureBox34.Height -= Convert.ToInt16(pictureBox34.Height * olcek_height);
            label10.Width -= Convert.ToInt16(label10.Width * olcek_width);
            label10.Height -= Convert.ToInt16(label10.Height * olcek_height);
            pictureBox30.Width -= Convert.ToInt16(pictureBox30.Width * olcek_width);
            pictureBox30.Height -= Convert.ToInt16(pictureBox30.Height * olcek_height);
            label5.Width -= Convert.ToInt16(label5.Width * olcek_width);
            label5.Height -= Convert.ToInt16(label5.Height * olcek_height);
            pictureBox32.Width -= Convert.ToInt16(pictureBox32.Width * olcek_width);
            pictureBox32.Height -= Convert.ToInt16(pictureBox32.Height * olcek_height);
            label22.Width -= Convert.ToInt16(label22.Width * olcek_width);
            label22.Height -= Convert.ToInt16(label22.Height * olcek_height);
            label9.Width -= Convert.ToInt16(label9.Width * olcek_width);
            label9.Height -= Convert.ToInt16(label9.Height * olcek_height);
            label8.Width -= Convert.ToInt16(label8.Width * olcek_width);
            label8.Height -= Convert.ToInt16(label8.Height * olcek_height);
            pictureBox33.Width -= Convert.ToInt16(pictureBox33.Width * olcek_width);
            pictureBox33.Height -= Convert.ToInt16(pictureBox33.Height * olcek_height);
            pictureBox31.Width -= Convert.ToInt16(pictureBox31.Width * olcek_width);
            pictureBox31.Height -= Convert.ToInt16(pictureBox31.Height * olcek_height);

        }
        #endregion

        private void pictureBox18_Click(object sender, EventArgs e)
		{

		}

		private void panel3_MouseClick(object sender, MouseEventArgs e)
		{

			if (panel3.Height == 88)
				panel3.Height = 361;
			else
                panel3.Height = 88;
		
        }

		private void pictureBox32_Click(object sender, EventArgs e)
		{

		}

		private void label12_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox36_Click(object sender, EventArgs e)
		{

		}

		private void label17_Click(object sender, EventArgs e)
		{

		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void FormPoliklinikDefteri_Uss_Load(object sender, EventArgs e)
		{

		}
	}
}
