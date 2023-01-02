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
using Sunum.Formlar.VeriIslemleri;
using Sunum.Static_Sınıflar;

namespace Sunum
{
	public partial class FormUserProfile1 : Form


	{
        Form form = new Form();
        public FormUserProfile1()
		{
			InitializeComponent();
            form = SabitFonksiyonlar.AbrirFormulario<Hesap>(PanelDegisen);

        }



		private void afiButton1_Click(object sender, EventArgs e)
		{
            form.Close();
            form = SabitFonksiyonlar.AbrirFormulario<Hesap>(PanelDegisen);
        }

		private void afiButton14_Click(object sender, EventArgs e)
		{
            form.Close();
            form = SabitFonksiyonlar.AbrirFormulario<Guncellemler>(PanelDegisen);
        }

        private void afiButton11_Click(object sender, EventArgs e)
        {
            form.Close();
            form = SabitFonksiyonlar.AbrirFormulario<Servis>(PanelDegisen);
        }

        private void afiButton12_Click(object sender, EventArgs e)
        {
            form.Close();
            form = SabitFonksiyonlar.AbrirFormulario<Yazici>(PanelDegisen);

        }

        private void afiButton3_Click(object sender, EventArgs e)
        {
            form.Close();
            form = SabitFonksiyonlar.AbrirFormulario<FormVeriIslemleri>(PanelDegisen);


        }

        private void afiButton4_Click(object sender, EventArgs e)
        {
            form.Close();
            form = SabitFonksiyonlar.AbrirFormulario<HastaKabulAyarlari>(PanelDegisen);

        }
    }

}