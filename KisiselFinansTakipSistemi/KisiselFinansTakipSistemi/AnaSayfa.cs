using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;

namespace KisiselFinansTakipSistemi
{
    public partial class AnaSayfa : UserControl
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        public Bakiye bakiye;
        public Ayarlar ayarlar;
        public Grafik grafik;
        public List<string> cariHareketler;

        public void verileriYenile()
        {
            Point konum = (bakiye.bakiye.ToString().Length, this.Size.Width) switch
            {
                (1, 751) => new Point(49, 38),
                (2, 751) => new Point(38, 38),
                (3, 751) => new Point(30, 38),
                (4, 751) => new Point(27, 38),
                (5, 751) => new Point(23, 38),
                (6, 751) => new Point(18, 38),
                (7, 751) => new Point(14, 38),
                (1, 1753) => new Point(69, 52),
                (2, 1753) => new Point(62, 52),
                (3, 1753) => new Point(55, 52),
                (4, 1753) => new Point(49, 52),
                (5, 1753) => new Point(43, 52),
                (6, 1753) => new Point(37, 52),
                (7, 1753) => new Point(31, 52),
            };

            bakiyeLabel.Location = konum;
            toplamGelirLabel.Location = konum;
            toplamGiderLabel.Location = konum;
            aylikKazancLabel.Location = konum;

            string paraBirimi = ayarlar.paraBirimi switch
            {
                "Türk Lirası" => "TL",
                "ABD Doları" => "$",
                "Euro" => "€"
            };

            bakiyeLabel.Text = $"{bakiye.bakiye} {paraBirimi}";
            toplamGelirLabel.Text = $"{bakiye.gelir} {paraBirimi}";
            toplamGiderLabel.Text = $"{bakiye.gider}  {paraBirimi}";
            aylikKazancLabel.Text = $"{bakiye.kazanc}  {paraBirimi}";

            // Grafik 
            grafikPanel.Controls.Clear();
            grafikPanel.Controls.Add(grafik.grafikOlustur(cariHareketler, 0));
        }
    }
}
