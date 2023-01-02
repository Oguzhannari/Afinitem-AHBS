using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sunum.Static_Sınıflar
{
	public class SabitFonksiyonlar
	{
		public static Form AbrirFormulario<MiForm>(Panel panelForm) where MiForm : Form, new()
		{
			Form formulario;
			formulario = panelForm.Controls.OfType<MiForm>().FirstOrDefault();
			if (formulario == null)
			{
				formulario = new MiForm();
				formulario.TopLevel = false;
				formulario.FormBorderStyle = FormBorderStyle.None;
				formulario.Dock = DockStyle.Fill;
				panelForm.Controls.Add(formulario);
				panelForm.Tag = formulario;
				formulario.Show();
				formulario.BringToFront();
				//formulario.FormClosed += new FormClosedEventHandler(CloseForm);
			}
			else
			{
				formulario.BringToFront();
			}
			return formulario;
		}

        public static void Olceklendir(ArrayList liste)
		{



		}






    }
}
