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
namespace Sunum.Formlar.Kişi_İşlemleri
{
    public partial class HYP : Form
    {
        Form form = new Form();
        public HYP()
        {
            InitializeComponent();
            //form = SabitFonksiyonlar.AbrirFormulario<Hesap>(panel2);
        }
    }
}
