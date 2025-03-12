using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KisiselFinansTakipSistemi
{
    public partial class Grafikler : UserControl
    {
        public Grafikler()
        {
            InitializeComponent();
        }

        public Grafik grafik;
        public List<string> cariHareketler;

        public void grafikYenile()
        {
            grafikPaneli.Controls.Clear();
            grafikPaneli.Controls.Add(grafik.grafikOlustur(cariHareketler, 0));
        }

        private void grafikFiltreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            grafikPaneli.Controls.Clear();
            grafikPaneli.Controls.Add(grafik.grafikOlustur(cariHareketler, grafikFiltreComboBox.SelectedIndex));
        }
    }
}
 