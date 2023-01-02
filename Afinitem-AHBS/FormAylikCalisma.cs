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

namespace Sunum.Formlar.Aylık_Çalışma
{
	public partial class FormAylikCalisma : Form
	{
		Form form = new Form();
		public FormAylikCalisma()
		{
			InitializeComponent();
			form = SabitFonksiyonlar.AbrirFormulario<FormAylikCalisma_AileHekimligi>(panelForm);

		}

		private void btnAileHekimligi_Click(object sender, EventArgs e)
		{
			form.Close();
			form = SabitFonksiyonlar.AbrirFormulario<FormAylikCalisma_AileHekimligi>(panelForm);
		}

		private void btnAnneCocuk_Click(object sender, EventArgs e)
		{
			form.Close();

		}

		private void afiButton2_Click(object sender, EventArgs e)
		{
            form.Close();
            form = SabitFonksiyonlar.AbrirFormulario<FormAylikCalisma_AileHekimligi>(panelForm);

        }

		private void afiButton8_Click(object sender, EventArgs e)
		{

		}

		private void tbAra_Enter(object sender, EventArgs e)
		{
            if (tbAra.Texts == "Ara..")
            {
                tbAra.Texts = "";
                tbAra.ForeColor = Color.Black;
            }
        }

		private void tbAra_Leave(object sender, EventArgs e)
		{
            if (tbAra.Texts == "Ara..")
            {
                tbAra.Texts = "";
                tbAra.ForeColor = Color.DimGray;
            }
        }
	}
}
