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
    public partial class KisiAileTakvim : Form
    {
        public KisiAileTakvim()
        {
            InitializeComponent();
            dpBaslangicTarihi.Format = DateTimePickerFormat.Custom;
            dpBaslangicTarihi.CustomFormat = "yyyy/MM/dd";

            dpSonTarih.Format = DateTimePickerFormat.Custom;
            dpSonTarih.CustomFormat = "yyyy/MM/dd";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
