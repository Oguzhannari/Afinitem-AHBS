using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Sunum.Formlar.Ayarlar;
using Sunum.Static_Sınıflar;
namespace Sunum.Formlar.VeriIslemleri
{
	public partial class FormVeriIslemleri : Form
	{
		Form form = new Form();
		public FormVeriIslemleri()
		{
			InitializeComponent();
			form = SabitFonksiyonlar.AbrirFormulario<Genel>(panelDegisen);
		}

		#region Buton Clikler


		private void btnBakanlikKisiListesi_Click(object sender, EventArgs e)
		{
			form.Close();
			form = SabitFonksiyonlar.AbrirFormulario<FormVeriIslemleri_BakanlikKisiIslemleri>(panelDegisen);
		}



		private void btnTopluHpvSonucSorgulama_Click(object sender, EventArgs e)
		{
			form.Close();
			form = SabitFonksiyonlar.AbrirFormulario<FormVeriIslemleri_TopluHPVSonuc>(panelDegisen);
		}



		private void btnMernisTopluSorgulama_Click(object sender, EventArgs e)
		{
			form.Close();
			form = SabitFonksiyonlar.AbrirFormulario<FormVeriIslemleri_MernisTopluSorgulama>(panelDegisen);
		}







		private void btnEslestirmeGecmisi_Click(object sender, EventArgs e)
		{
			form.Close();
			form = SabitFonksiyonlar.AbrirFormulario<FormVeriIslemleri_EslestirmeGecmisi>(panelDegisen);
		}

		private void btnMernisEslestirmeGecmisi_Click(object sender, EventArgs e)
		{
			form.Close();
			form = SabitFonksiyonlar.AbrirFormulario<FormVeriIslemleriMernisEslestirmeGecmisi>(panelDegisen);
		}

		private void btnEvdeSaglikHizmetBaşvuruVeEmirleri_Click(object sender, EventArgs e)
		{
			form.Close();
			form = SabitFonksiyonlar.AbrirFormulario<FormVeriIslemleri_EvdeSaglikHizmet>(panelDegisen);
		}



		#endregion

		private void afiButton1_Click(object sender, EventArgs e)
		{
            form.Close();
            form = SabitFonksiyonlar.AbrirFormulario<FormAileİslemleri>(panelDegisen);


        }

		private void afiButton2_Click(object sender, EventArgs e)
		{
            form.Close();
            form = SabitFonksiyonlar.AbrirFormulario<Genel>(panelDegisen);
        }

		private void afiButton3_Click(object sender, EventArgs e)
		{
            form.Close();
            form = SabitFonksiyonlar.AbrirFormulario<TKTT>(panelDegisen);
        }

		private void afiButton4_Click(object sender, EventArgs e)
		{
            form.Close();
            form = SabitFonksiyonlar.AbrirFormulario<NTP>(panelDegisen);
        }
	}


}
