using Microsoft.Data.SqlClient;
using OxyPlot.WindowsForms;

namespace KisiselFinansTakipSistemi
{
    public partial class SabitSayfa : Form
    {
        Bakiye bakiye;
        List<string> hareketListesi;
        CariHareketler cariHareketler;
        Grafik grafik;
        Ayarlar ayarlar;

        // Sayfa Referanslarý
        CariIslemler cariSayfa;
        AnaSayfa anaSayfa;
        Grafikler grafiklerSayfasi;
        AyarlarSayfasi ayarlarSayfasi;

        public SabitSayfa()
        {
            InitializeComponent();
            bakiye = new Bakiye();
            hareketListesi = new List<string>();
            cariHareketler = new(hareketListesi, bakiye);
            grafik = new();
            ayarlar = new();

            // Sayfalar için tek seferlik nesneler oluþturuldu
            // Bu nesneler using ile button eventi içerisinde oluþturulacak.
            cariSayfa = new();
            anaSayfa = new();
            grafiklerSayfasi = new();
            ayarlarSayfasi = new();
        }

        #region Kullanýcý Arayüzü
        public void kullaniciArayuzu()
        {
            // Uygulama tam ekran yapýldýðýnda uygun olarak içeriði konumlandýrýyoruz.
            // W: 1938 - H: 1158 ; Normal W: 936 H: 483 ; Ýçerik 733; 408

            if (WindowState == FormWindowState.Maximized)
            {
                int y = 592;

                for (int sayac = 0; sayac <= 3; sayac++)
                {
                    //Controls[1].Controls[sayac].Location = new Point(14, y);
                    this.solSabitMenuPanel.Controls[sayac].Location = new Point(14, y);
                    y -= 59;
                }
            }
            else
            {
                int y = 272;

                for (int sayac = 0; sayac <= 3; sayac++)
                {
                    this.solSabitMenuPanel.Controls[sayac].Location = new Point(14, y);
                    y -= 59;
                }
            }

            // Ana Sayfa
            if (Controls[0].Controls[0].Name == "AnaSayfa")
            {
                anaSayfa.verileriYenile();

                if (WindowState == FormWindowState.Maximized)
                {
                    // Grafik Panel
                    Controls[0].Controls[0].Controls[0].Location = new Point(281, 395);
                    Controls[0].Controls[0].Controls[0].Size = new Size(1048, 430);

                    // Bakiye-Gelir-Gider Panelleri
                    int x = 1103;

                    for (int sayac = 1; sayac <= 4; sayac++)
                    {
                        Controls[0].Controls[0].Controls[sayac].Location = new Point(x, 118);
                        Controls[0].Controls[0].Controls[sayac].Size = new Size(200, 123);
                        x -= 270;
                    }
                }
                else
                {
                    // Grafik Panel
                    Controls[0].Controls[0].Controls[0].Location = new Point(16, 124);
                    Controls[0].Controls[0].Controls[0].Size = new Size(699, 267);

                    // Bakiye-Gelir-Gider Panelleri
                    int x = 561;

                    for (int sayac = 1; sayac <= 4; sayac++)
                    {
                        Controls[0].Controls[0].Controls[sayac].Location = new Point(x, 14);
                        Controls[0].Controls[0].Controls[sayac].Size = new Size(154, 89);
                        x -= 181;
                    }
                }
            }
            else if (Controls[0].Controls[0].Name == "CariIslemler")
            {
                // Cari Ýþlemler 

                if (WindowState == FormWindowState.Maximized)
                {
                    // Kýsaltýlacak

                    // Cari Hareket Listesi
                    Controls[0].Controls[0].Controls[0].Location = new Point(298, 494);
                    Controls[0].Controls[0].Controls[0].Size = new Size(1102, 462);

                    // Cari Hareketler Label
                    Controls[0].Controls[0].Controls[2].Location = new Point(296, 462);

                    // Bakiye Sil Button
                    Controls[0].Controls[0].Controls[3].Location = new Point(489, 333);

                    // Bakiye Ekle Button
                    Controls[0].Controls[0].Controls[4].Location = new Point(389, 333);

                    // Tutar TextBox 
                    Controls[0].Controls[0].Controls[5].Location = new Point(391, 265);

                    // Tutar Label 
                    Controls[0].Controls[0].Controls[6].Location = new Point(389, 242);

                    // Açýklama TextBox 
                    Controls[0].Controls[0].Controls[7].Location = new Point(622, 201);
                    Controls[0].Controls[0].Controls[7].Size = new Size(646, 161);

                    // Açýklama Label 
                    Controls[0].Controls[0].Controls[8].Location = new Point(620, 178);

                    // Ýþlem Baþlýðý TextBox 
                    Controls[0].Controls[0].Controls[9].Location = new Point(388, 201);

                    // Ýþlem Baþlýðý Label 
                    Controls[0].Controls[0].Controls[10].Location = new Point(386, 178);

                    // Sabit Gelir CheckBox 
                    Controls[0].Controls[0].Controls[1].Location = new Point(390, 302);
                }
                else
                {
                    // Cari Hareket Listesi
                    Controls[0].Controls[0].Controls[0].Location = new Point(272, 78);
                    Controls[0].Controls[0].Controls[0].Size = new Size(418, 274);

                    // Cari Hareketler Label
                    Controls[0].Controls[0].Controls[2].Location = new Point(270, 46);

                    // Bakiye Sil Button
                    Controls[0].Controls[0].Controls[3].Location = new Point(144, 323);

                    // Bakiye Ekle Button
                    Controls[0].Controls[0].Controls[4].Location = new Point(44, 323);

                    // Tutar TextBox 
                    Controls[0].Controls[0].Controls[5].Location = new Point(44, 133);

                    // Tutar Label 
                    Controls[0].Controls[0].Controls[6].Location = new Point(42, 110);

                    // Açýklama TextBox 
                    Controls[0].Controls[0].Controls[7].Location = new Point(45, 199);
                    Controls[0].Controls[0].Controls[7].Size = new Size(198, 87);

                    // Açýklama Label 
                    Controls[0].Controls[0].Controls[8].Location = new Point(43, 176);

                    // Ýþlem Baþlýðý TextBox 
                    Controls[0].Controls[0].Controls[9].Location = new Point(41, 69);

                    // Ýþlem Baþlýðý Label 
                    Controls[0].Controls[0].Controls[10].Location = new Point(39, 46);

                    // Sabit Gelir CheckBox 
                    Controls[0].Controls[0].Controls[1].Location = new Point(45, 292);
                }
            }
            else if (Controls[0].Controls[0].Name == "Grafikler")
            {
                // Grafikler
                grafiklerSayfasi.grafikYenile();

                if (WindowState == FormWindowState.Maximized)
                {
                    // Bilgilendirme label
                    Controls[0].Controls[0].Controls[0].Location = new Point(761, 245);

                    // Grafik Panel
                    Controls[0].Controls[0].Controls[1].Location = new Point(345, 376);
                    Controls[0].Controls[0].Controls[1].Size = new Size(961, 485);

                    Controls[0].Controls[0].Controls[2].Location = new Point(578, 240);
                }
                else
                {
                    // Bilgilendirme label
                    Controls[0].Controls[0].Controls[0].Location = new Point(252, 36);

                    // Grafik Panel
                    Controls[0].Controls[0].Controls[1].Location = new Point(31, 80);
                    Controls[0].Controls[0].Controls[1].Size = new Size(662, 337);

                    Controls[0].Controls[0].Controls[2].Location = new Point(69, 31);
                }
            }
            else if (Controls[0].Controls[0].Name == "AyarlarSayfasi")
            {
                if (WindowState == FormWindowState.Maximized)
                {
                    // Grafik Ayarlarý Panel
                    Controls[0].Controls[0].Controls[0].Location = new Point(614, 374);
                    Controls[0].Controls[0].Controls[0].Size = new Size(674, 194);

                    // Grafik Yazý Rengi
                    Controls[0].Controls[0].Controls[0].Controls[0].Location = new Point(391, 35);

                    // Gider Çizgi Rengi
                    Controls[0].Controls[0].Controls[0].Controls[1].Location = new Point(391, 115);

                    // Gelir Çizgi Rengi
                    Controls[0].Controls[0].Controls[0].Controls[2].Location = new Point(150, 115);

                    // Çizgi Türü ComboBox
                    Controls[0].Controls[0].Controls[0].Controls[3].Location = new Point(150, 36);

                    // Çizgi Türü Label
                    Controls[0].Controls[0].Controls[0].Controls[4].Location = new Point(71, 39);

                    // Grafik Ayarlarý Label
                    Controls[0].Controls[0].Controls[1].Location = new Point(887, 341);

                    // Kiþisel Ayarlar Panel
                    Controls[0].Controls[0].Controls[2].Location = new Point(614, 129);

                    // Kiþisel Ayarlar Label
                    Controls[0].Controls[0].Controls[3].Location = new Point(887, 87);
                }
                else
                {
                    // Grafik Ayarlarý Panel
                    Controls[0].Controls[0].Controls[0].Location = new Point(29, 183);
                    Controls[0].Controls[0].Controls[0].Size = new Size(674, 125);

                    // Grafik Yazý Rengi
                    Controls[0].Controls[0].Controls[0].Controls[0].Location = new Point(391, 18);

                    // Gider Çizgi Rengi
                    Controls[0].Controls[0].Controls[0].Controls[1].Location = new Point(391, 72);

                    // Gelir Çizgi Rengi
                    Controls[0].Controls[0].Controls[0].Controls[2].Location = new Point(150, 72);

                    // Çizgi Türü ComboBox
                    Controls[0].Controls[0].Controls[0].Controls[3].Location = new Point(150, 19);

                    // Çizgi Türü Label
                    Controls[0].Controls[0].Controls[0].Controls[4].Location = new Point(71, 22);

                    // Grafik Ayarlarý Label
                    Controls[0].Controls[0].Controls[1].Location = new Point(302, 150);

                    // Kiþisel Ayarlar Panel
                    Controls[0].Controls[0].Controls[2].Location = new Point(29, 61);

                    // Kiþisel Ayarlar Label
                    Controls[0].Controls[0].Controls[3].Location = new Point(302, 19);
                }
            }
        }
        #endregion


        private void cariIslemlerButton_Click(object sender, EventArgs e)
        {
            this.Text = "Cari Ýþlemler";
            icerikPanel.Controls.Clear();
            cariSayfa.Dock = DockStyle.Fill;
            cariSayfa.bakiye = bakiye;
            cariSayfa.cariIslemler = cariHareketler;
            cariSayfa.ayarlar = ayarlar;
            cariSayfa.hareketListesi = hareketListesi;
            icerikPanel.Controls.Add(cariSayfa);
            kullaniciArayuzu();
        }

        private void anaSayfaButton_Click(object sender, EventArgs e)
        {
            this.Text = "Ana Sayfa";
            icerikPanel.Controls.Clear();
            anaSayfa.Dock = DockStyle.Fill;
            anaSayfa.verileriYenile();
            icerikPanel.Controls.Add(anaSayfa);
            kullaniciArayuzu();
        }

        private void grafiklerButton_Click(object sender, EventArgs e)
        {
            this.Text = "Grafikler";
            icerikPanel.Controls.Clear();
            grafiklerSayfasi.Dock = DockStyle.Fill;
            grafiklerSayfasi.grafik = grafik;
            grafiklerSayfasi.cariHareketler = hareketListesi;
            grafiklerSayfasi.grafikYenile();
            icerikPanel.Controls.Add(grafiklerSayfasi);
            kullaniciArayuzu();
        }

        private void ayarlarButton_Click(object sender, EventArgs e)
        {
            this.Text = "Ayarlar";
            icerikPanel.Controls.Clear();
            ayarlarSayfasi.Dock = DockStyle.Fill;
            ayarlarSayfasi.ayarlariGetir();
            icerikPanel.Controls.Add(ayarlarSayfasi);
            kullaniciArayuzu();
        }

        private void SabitSayfa_Load(object sender, EventArgs e)
        {
            anaSayfa.Dock = DockStyle.Fill;
            anaSayfa.bakiye = bakiye;
            anaSayfa.cariHareketler = hareketListesi;
            anaSayfa.grafik = grafik;
            icerikPanel.Controls.Add(anaSayfa);

            // Sayfa çevirileri için referanslarý ayarlar'a gönderiyoruz.
            ayarlarSayfasi.ayarlar = ayarlar;
            ayarlarSayfasi.cariIslemlerSayfasi = cariSayfa;
            ayarlarSayfasi.anaSayfa = anaSayfa;
            ayarlarSayfasi.sabitSayfaPanel = Controls[1];
            ayarlarSayfasi.grafikSayfasi = grafiklerSayfasi;
            ayarlarSayfasi.grafik = grafik;
            grafik.ayarlar = ayarlar;
            anaSayfa.ayarlar = ayarlar;

            anaSayfa.verileriYenile();
        }

        private void SabitSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Uygulama kapatýlýrken veri tabanýna kayýt iþlemlerini gerçekleþtiriyoruz.
            using (dbConnection db = new())
            {
                SqlCommand bakiyeSet = new("UPDATE Bakiye SET Bakiye = @p1", db.dbConnect());
                bakiyeSet.Parameters.AddWithValue("@p1", bakiye.bakiye);
                bakiyeSet.ExecuteNonQuery();
            }

            using (dbConnection db = new())
            {
                int baslangicElemanSayisi = cariHareketler.baslangicElemanSayisi;

                for (int elemanSayisi = baslangicElemanSayisi; elemanSayisi != hareketListesi.Count; elemanSayisi += 8)
                {
                    SqlCommand cariHareketEkle = new("INSERT INTO CariHareketler (Baslik, Aciklama, Tutar, Tip, Sabit, Tarih, SabitAlindimi) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7)", db.dbConnect());
                    cariHareketEkle.Parameters.AddWithValue("@p1", hareketListesi[elemanSayisi + 1]);
                    cariHareketEkle.Parameters.AddWithValue("@p2", hareketListesi[elemanSayisi + 2]);
                    cariHareketEkle.Parameters.AddWithValue("@p3", hareketListesi[elemanSayisi + 3]);
                    cariHareketEkle.Parameters.AddWithValue("@p4", Convert.ToBoolean(hareketListesi[elemanSayisi + 4]));
                    cariHareketEkle.Parameters.AddWithValue("@p5", Convert.ToBoolean(hareketListesi[elemanSayisi + 5]));
                    cariHareketEkle.Parameters.AddWithValue("@p6", hareketListesi[elemanSayisi + 6]);
                    cariHareketEkle.Parameters.AddWithValue("@p7", hareketListesi[elemanSayisi + 7]);
                    cariHareketEkle.ExecuteNonQuery();
                }
            }

            using (dbConnection db = new())
            {
                SqlCommand ayarlarGuncelle = new("UPDATE Ayarlar SET ParaBirimi = @p1, Dil = @p2, CizgiTuru = @p3, GrafikYaziRengi = @p4, GrafikGelirCizgiRengi = @p5, GrafikGiderCizgiRengi = @p6", db.dbConnect());
                ayarlarGuncelle.Parameters.AddWithValue("@p1", ayarlar.paraBirimi);
                ayarlarGuncelle.Parameters.AddWithValue("@p2", ayarlar.dil);
                ayarlarGuncelle.Parameters.AddWithValue("@p3", ayarlar.cizgiTuru);
                ayarlarGuncelle.Parameters.AddWithValue("@p4", ayarlar.grafikYaziRengi.ToString());
                ayarlarGuncelle.Parameters.AddWithValue("@p5", ayarlar.grafikGelirCizgiRengi.ToString());
                ayarlarGuncelle.Parameters.AddWithValue("@p6", ayarlar.grafikGiderCizgiRengi.ToString());
                ayarlarGuncelle.ExecuteNonQuery();
            }
        }

        private void SabitSayfa_Resize(object sender, EventArgs e)
        {
            kullaniciArayuzu();
        }
    }
}
