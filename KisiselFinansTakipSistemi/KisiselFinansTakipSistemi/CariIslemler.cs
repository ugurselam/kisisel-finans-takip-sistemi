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
    public partial class CariIslemler : UserControl
    {
        public CariIslemler()
        {
            InitializeComponent();
        }

        public Bakiye bakiye;
        public Ayarlar ayarlar;
        public CariHareketler cariIslemler;
        public List<string> hareketListesi;

        public void listele()
        {
            cariVerilerList.Items.Clear();
            for (int index = 0; index < hareketListesi.Count; index++)
            {
                if (index % 8 == 0)
                {
                    ListViewItem item = cariVerilerList.Items.Add(hareketListesi[index + 1]);
                    item.SubItems.Add(hareketListesi[index + 2]);
                    item.SubItems.Add(hareketListesi[index + 3]);
                    item.BackColor = bool.Parse(hareketListesi[index + 4]) ? Color.Green : Color.Red;
                }
            }
        }

        private void bakiyeEkleButton_Click(object sender, EventArgs e)
        {
            cariIslemler.Baslik = islemBasligiTextBox.Text;
            cariIslemler.Aciklama = aciklamaTextBox.Text;
            cariIslemler.Tarih = String.Format("{0:dd.MM.yyyy HH:mm}", DateTime.Now);
            cariIslemler.Tutar = int.Parse(tutarTextBox.Text);
            cariIslemler.Tip = true;
            cariIslemler.Sabit = sabitGelirCheckBox.Checked;
            cariIslemler.islemEkle(hareketListesi);
            bakiye.bakiyeEkle(cariIslemler.Tutar);
            listele();
        }

        private void bakiyeSilButton_Click(object sender, EventArgs e)
        {
            cariIslemler.Baslik = islemBasligiTextBox.Text;
            cariIslemler.Aciklama = aciklamaTextBox.Text;
            cariIslemler.Tarih = String.Format("{0:dd.MM.yyyy HH:mm}", DateTime.Now);
            cariIslemler.Tutar = int.Parse(tutarTextBox.Text);
            cariIslemler.Tip = false;
            cariIslemler.islemEkle(hareketListesi);
            bakiye.bakiyeEksilt(cariIslemler.Tutar);
            listele();
        }

        private void CariIslemler_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
