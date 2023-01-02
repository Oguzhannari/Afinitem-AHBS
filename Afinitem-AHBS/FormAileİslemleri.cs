using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sunum.Formlar.Ayarlar
{
    public partial class FormAileİslemleri : Form
    {
        public FormAileİslemleri()
        {
            InitializeComponent();
        }

        private void tbArama_Enter(object sender, EventArgs e)
        {
            if (tbArama.Texts == "Aile Arama")
            {
                tbArama.Texts = "";
                tbArama.ForeColor = Color.Black;
            }
        }

        private void tbArama_Leave(object sender, EventArgs e)
        {
            if (tbArama.Texts == "")
            {
                tbArama.Texts = "Aile Arama";
                tbArama.ForeColor = Color.DimGray;
            }
        }
    }
}
