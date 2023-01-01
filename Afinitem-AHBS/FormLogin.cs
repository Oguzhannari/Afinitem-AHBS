using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sunum

{
	public partial class FormLogin : Form
	{
		public FormLogin()
		{
			Thread t = new Thread(new ThreadStart(StartForm));
			t.Start();
			Thread.Sleep(1500);
			InitializeComponent();
            tbSifre.PasswordChar = true;
            t.Abort();
		}

		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);





		private void txtUser_Leave(object sender, EventArgs e)
		{

		}



        private void txtPass_Leave(object sender, EventArgs e)
		{

		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnMinimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void FormLogin_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

        
    private void msgError(string msg)
		{
			lblErrorMessage.Text = "   " + msg;
			lblErrorMessage.Visible = true;
		}
		private void Logout(object sender, FormClosedEventArgs e)
		{
            tbKullaniciAdi.Text = "Password";


            tbKullaniciAdi.Text = "Username";
			lblErrorMessage.Visible = false;
			this.Show();
			//txtUser.Focus();
		}

		private void linkpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var recoverPassword = new FormRecoverPassword();
			recoverPassword.ShowDialog();

		}

       
		public void StartForm()
		{
			Application.Run(new Baslangic());
		}

		private void lblLogin_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
            if (tbKullaniciAdi.Text != "Username")
            {
                if (tbKullaniciAdi.Text != "Password")
                {

                    if (true)
                    {
                        this.Hide();


                    }
                    else
                    {
                        msgError("Kullanıcı adı ve şifre eşleşmiyor \n Lütfen tekrar deneyiniz");
                        tbSifre.Text = "Password";
                        tbKullaniciAdi.Focus();
                    }
                }
				else msgError("Lütfen şifrenizi giriniz");
			}
            else msgError("Lütfen Kullanıcı adınızı giriniz");

        }


        int az = new int();
        int aza = new int();
        private void txtUser_Enter_1(object sender, EventArgs e)
        {
            az += 1;
            if (az == 1)
            {
                tbKullaniciAdi.Texts = "";
            }
        }

		private void txtPass_Enter_1(object sender, EventArgs e)
        {
            aza += 1;
            if (aza == 1)
            {
                tbSifre.Texts = "";
            }
        }


	}
}

