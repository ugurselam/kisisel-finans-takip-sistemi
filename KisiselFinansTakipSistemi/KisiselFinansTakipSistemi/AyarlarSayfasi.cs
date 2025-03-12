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
    public partial class AyarlarSayfasi : UserControl
    {
        public AyarlarSayfasi()
        {
            InitializeComponent();
        }

        public Control sabitSayfaPanel;
        public Ayarlar ayarlar;
        public CariIslemler cariIslemlerSayfasi;
        public AnaSayfa anaSayfa;
        public Grafikler grafikSayfasi;
        public Grafik grafik;

        public void ayarlariGetir()
        {
            paraBirimiComboBox.Text = ayarlar.paraBirimi;
            dilComboBox.Text = ayarlar.dil;
            cizgiTuruComboBox.Text = ayarlar.cizgiTuru;
            yaziRengi.Color = ayarlar.grafikYaziRengi.ToColor();
            gelirCizgiRengi.Color = ayarlar.grafikGelirCizgiRengi.ToColor();
            giderCizgiRengi.Color = ayarlar.grafikGiderCizgiRengi.ToColor();
        }

        private void paraBirimiComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ayarlar.paraBirimi = paraBirimiComboBox.Text;
        }

        public void sabitSayfaDilYenile()
        {
            for (int sayac = 0; sayac <= 3; sayac++)
            {
                sabitSayfaPanel.Controls[sayac].Text = (ayarlar.dil, sayac) switch
                {
                    ("Türkçe", 0) => "Ayarlar",
                    ("Türkçe", 1) => "Grafikler",
                    ("Türkçe", 2) => "Cari İşlemler",
                    ("Türkçe", 3) => "Ana Sayfa",
                    ("English", 0) => "Settings",
                    ("English", 1) => "Graphics",
                    ("English", 2) => "Current Transactions",
                    ("English", 3) => "Home",
                    ("Deutsch", 0) => "Einstellungen",
                    ("Deutsch", 1) => "Grafiken",
                    ("Deutsch", 2) => "Aktuelle Transaktionen",
                    ("Deutsch", 3) => "Startseite",
                };
            }
        }

        public void cariIslemlerDilYenile()
        {
            for (int sayac = 1; sayac <= 10; sayac++)
            {
                if (sayac <= 4)
                {
                    cariIslemlerSayfasi.Controls[sayac].Text = (ayarlar.dil, sayac) switch
                    {
                        ("Türkçe", 1) => "Sabit Gelir",
                        ("Türkçe", 2) => "Cari Hareketler",
                        ("Türkçe", 3) => "Bakiye Sil",
                        ("Türkçe", 4) => "Bakiye Ekle",
                        ("English", 1) => "Fixed Income",
                        ("English", 2) => "Current Movements",
                        ("English", 3) => "Delete Balance",
                        ("English", 4) => "Add Balance",
                        ("Deutsch", 1) => "Festes Einkommen",
                        ("Deutsch", 2) => "Aktuelle Bewegungen",
                        ("Deutsch", 3) => "Balance Löschen",
                        ("Deutsch", 4) => "Guthaben Hinzufügen",
                    };
                }
                else if (sayac % 2 == 0)
                {
                    cariIslemlerSayfasi.Controls[sayac].Text = (ayarlar.dil, sayac) switch
                    {
                        ("Türkçe", 6) => "Tutar",
                        ("Türkçe", 8) => "Açıklama",
                        ("Türkçe", 10) => "İşlem Başlığı",
                        ("English", 6) => "Amount",
                        ("English", 8) => "Explanation",
                        ("English", 10) => "Transaction Title",
                        ("Deutsch", 6) => "Preis",
                        ("Deutsch", 8) => "Beschreibung",
                        ("Deutsch", 10) => "Transaktionskopf",
                    };
                }
            }
        }

        public void anaSayfaDilYenile()
        {
            // Dil ayarlarının tamamını ayarlarsayfası içerisindeki metot'ta yapacağız.

            for (int sayac = 1; sayac <= 4; sayac++)
            {
                anaSayfa.Controls[sayac].Controls[1].Text = (ayarlar.dil, sayac) switch
                {
                    ("Türkçe", 1) => "Toplam Kazanç",
                    ("Türkçe", 2) => "Toplam Gider",
                    ("Türkçe", 3) => "Toplam Gelir",
                    ("Türkçe", 4) => "Bakiye",
                    ("English", 1) => "Total Earnings",
                    ("English", 2) => "Total Expense",
                    ("English", 3) => "Total Revenue",
                    ("English", 4) => "Remnant",
                    ("Deutsch", 1) => "Gesamtgewinn",
                    ("Deutsch", 2) => "Gesamtausgaben",
                    ("Deutsch", 3) => "Einkommen",
                    ("Deutsch", 4) => "Balance",
                };
            }
        }

        public void ayarlarDilYenile()
        {
            kisiselAyarlarLabel.Text = ayarlar.dil == "Türkçe" ? "Kişisel Ayarlar" : ayarlar.dil == "English" ? "Personal Settings" : "Persönliche Einstellungen";
            grafikAyarlariLabel.Text = ayarlar.dil == "Türkçe" ? "Grafik Ayarları" : ayarlar.dil == "English" ? "Graphic Settings" : "Grafikeinstellungen";
            grafikYaziRengiButton.Text = ayarlar.dil == "Türkçe" ? "Yazı Rengi" : ayarlar.dil == "English" ? "Writing Color" : "Schriftfarbe";
            gelirCizgiRengiButton.Text = ayarlar.dil == "Türkçe" ? "Gelir Çizgi Rengi" : ayarlar.dil == "English" ? "Revenue Line Color" : "Kommt Linie Farbe";
            giderCizgiRengiButton.Text = ayarlar.dil == "Türkçe" ? "Gider Çizgi Rengi" : ayarlar.dil == "English" ? "Expense Line Color" : "Ausgabefarbe";

            cizgiTuruLabel.Text = ayarlar.dil == "Türkçe" ? "Çizgi Türü:" : ayarlar.dil == "English" ? "Type Of Line:" : "Linientyp:";
            cizgiTuruLabel.Location = ayarlar.dil == "Türkçe" ? new Point(61, 22) : ayarlar.dil == "English" ? new Point(55, 22) : new Point(78, 22);

            paraBirimiLabel.Text = ayarlar.dil == "Türkçe" ? "Para Birimi:" : ayarlar.dil == "English" ? "Currency:" : "Währung:";
            paraBirimiLabel.Location = ayarlar.dil == "Türkçe" ? new Point(61, 18) : new Point(78, 18);

            dilLabel.Text = ayarlar.dil == "Türkçe" ? "Dil:" : ayarlar.dil == "English" ? "Language:" : "Sprache:";
            dilLabel.Location = ayarlar.dil == "Türkçe" ? new Point(354, 20) : ayarlar.dil == "English" ? new Point(315, 20) : new Point(325, 20);
        }

        public void grafiklerSayfasiDilYenile()
        {
            grafikSayfasi.Controls[0].Text = ayarlar.dil == "Türkçe" ? "Menüden seçim yaparak grafiği filtreleyebilirsiniz." : ayarlar.dil == "English" ? "You can filter the chart by selecting from the menu." : "\r\nSie können das Diagramm filtern, indem Sie aus dem Menü auswählen.";
        }

        private void dilComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ayarlar.dilGuncelle(dilComboBox.Text);

            // Sayfalardaki dilleri güncelle
            cariIslemlerDilYenile();
            sabitSayfaDilYenile();
            anaSayfaDilYenile();
            ayarlarDilYenile();
            grafiklerSayfasiDilYenile();
        }
        private void cizgiTuruComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ayarlar.cizgiTuru = cizgiTuruComboBox.Text;
        }

        private void gelirCizgiRengiButton_Click(object sender, EventArgs e)
        {
            gelirCizgiRengi.ShowDialog();
            ayarlar.grafikGelirCizgiRengi = gelirCizgiRengi.Color.ToOxyColor();
        }

        private void grafikYaziRengiButton_Click(object sender, EventArgs e)
        {
            yaziRengi.ShowDialog();
            ayarlar.grafikYaziRengi = yaziRengi.Color.ToOxyColor();
        }

        private void giderCizgiRengiButton_Click(object sender, EventArgs e)
        {
            giderCizgiRengi.ShowDialog();
            ayarlar.grafikGiderCizgiRengi = giderCizgiRengi.Color.ToOxyColor();
        }
    }
}
