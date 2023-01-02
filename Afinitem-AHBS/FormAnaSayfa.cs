
using Sunum.Formlar.Hasta_Kabul;
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

namespace Sunum
{
    public partial class FormAnaSayfa : Form
    {
        Form form = new Form();
        Form form4 = new Form();
        Form form1 = new Form();
        Form form2 = new Form();

        public FormAnaSayfa()
        {
            InitializeComponent();
            form = SabitFonksiyonlar.AbrirFormulario<grafik>(panelDegisen);
            form4 = SabitFonksiyonlar.AbrirFormulario<FormKisiIslemleri>(panelDegisen);
            form1 = SabitFonksiyonlar.AbrirFormulario<FormHastaKabul>(panelDegisen);
            form2 = SabitFonksiyonlar.AbrirFormulario<FormKisiBilgileri>(panelDegisen);
            form.BringToFront();

        }
        private void LUTENSONANASYFAOLSUN_Load(object sender, EventArgs e)
        {

        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            form.BringToFront();
        }

        private void btnAnaSayfa_MouseHover(object sender, EventArgs e)
        {

        }

        private void HastaKabulbtn_Click(object sender, EventArgs e)
        {
        }

        private void HastaKabulbtn_MouseHover(object sender, EventArgs e)
        {

        }

        private void Kisilerbtn_Click(object sender, EventArgs e)
        {
            form4.BringToFront();
        }

        private void Kisilerbtn_MouseHover(object sender, EventArgs e)
        {

        }

        private void Poliklinikbtn_Click(object sender, EventArgs e)
        {
        }

        private void Poliklinikbtn_MouseHover(object sender, EventArgs e)
        {



        }

        private void Randevubtn_Click(object sender, EventArgs e)
        {
        }

        private void Randevubtn_MouseHover(object sender, EventArgs e)
        {


        }

        private void İsPlanibtn_Click(object sender, EventArgs e)
        {
        }

        private void İsPlanibtn_MouseHover(object sender, EventArgs e)
        {

        }

        private void HYPbtn_Click(object sender, EventArgs e)
        {
        }

        private void AylikClsmabtn_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label6.Text = DateTime.Now.ToLongDateString();
            label7.Text = DateTime.Now.ToLongTimeString();

        }

        private void LUTENSONANASYFAOLSUN_Load_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Kucult_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void AltaAl_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            form.Close();
        }

        private void HastaKabulbtn_Click_1(object sender, EventArgs e)
        {
            form1.BringToFront();
        }

        private void btnKisiİslemleri_Click(object sender, EventArgs e)
        {
            form2.BringToFront();

        }
    }
}
