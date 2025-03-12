using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;

namespace KisiselFinansTakipSistemi
{
    public class Grafik
    {
        public Ayarlar ayarlar;

        public LineSeries giderVerileri(List<string> cariHareketler)
        {
            List<DataPoint> giderVerisi = new List<DataPoint>();

            for (int ay = 1; ay <= 12; ay++)
            {
                int aylikGider = 0;

                for (int cariSira = 0; cariSira < cariHareketler.Count; cariSira++)
                {
                    if (cariSira % 8 == 0 && !bool.Parse(cariHareketler[cariSira + 4]))
                    {
                        int cariIslemAy = DateTime.ParseExact(cariHareketler[cariSira + 6], "dd.MM.yyyy HH:mm", null).Month;
                        aylikGider += cariIslemAy == ay ? int.Parse(cariHareketler[cariSira + 3]) : 0;
                    }
                }

                if (aylikGider != 0)
                    giderVerisi.Add(new DataPoint((ay - 1), aylikGider));
                else
                    break;
            }

            var giderSerisi = new LineSeries
            {
                ItemsSource = giderVerisi,
                Color = ayarlar.grafikGiderCizgiRengi,
                YAxisKey = ayarlar.dil == "Türkçe" ? "Gelir/Gider" : ayarlar.dil == "English" ? "Expense/Income" : "Geht/Einkommen",
                InterpolationAlgorithm = ayarlar.cizgiTuru == "Yumuşak" ? InterpolationAlgorithms.CanonicalSpline : null,
            };

            return giderSerisi;
        }

        public LineSeries gelirVerileri(List<string> cariHareketler)
        {
            List<DataPoint> gelirVerisi = new List<DataPoint>();

            for (int ay = 1; ay <= 12; ay++)
            {
                int aylikGelir = 0;

                for (int cariSira = 0; cariSira < cariHareketler.Count; cariSira++)
                {
                    if (cariSira % 8 == 0 && bool.Parse(cariHareketler[cariSira + 4]))
                    {
                        int cariIslemAy = DateTime.ParseExact(cariHareketler[cariSira + 6], "dd.MM.yyyy HH:mm", null).Month;
                        aylikGelir += cariIslemAy == ay ? int.Parse(cariHareketler[cariSira + 3]) : 0;
                    }
                }

                if (aylikGelir != 0)
                    gelirVerisi.Add(new DataPoint((ay - 1), aylikGelir));
                else
                    break;
            }

            var gelirSerisi = new LineSeries
            {
                ItemsSource = gelirVerisi,
                Color = ayarlar.grafikGelirCizgiRengi,
                YAxisKey = ayarlar.dil == "Türkçe" ? "Gelir/Gider" : ayarlar.dil == "English" ? "Expense/Income" : "Geht/Einkommen",
                InterpolationAlgorithm = ayarlar.cizgiTuru == "Yumuşak" ? InterpolationAlgorithms.CanonicalSpline : null,
            };

            return gelirSerisi;
        }

        public List<List<string>> aylar;
        public PlotView plotView = new PlotView();

        public Control grafikOlustur(List<string> cariHareketler, int grafikTuru)
        {
            PlotModel plotModel = new PlotModel();
            List<string> seciliAy = null;

            aylar = new List<List<string>>
            {
              new List<string>
              {
                    "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık"
              },
              new List<string>
              {
                   "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"
              },
              new List<string>
              {
                    "Januar", "Februar", "März", "April", "Mai", "Juni", "Juli", "August", "September", "Oktober", "November", "Dezember"
              }
            };

            seciliAy = ayarlar.dil == "Türkçe" ? aylar[0] : ayarlar.dil == "English" ? aylar[1] : aylar[2];


            plotModel.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Bottom,
                Key = ayarlar.dil == "Türkçe" ? "Aylar" : ayarlar.dil == "English" ? "Months" : "Monate",
                ItemsSource = seciliAy
            });

            plotModel.Axes.Add(new LinearAxis
            {
                Key = ayarlar.dil == "Türkçe" ? "Gelir/Gider" : ayarlar.dil == "English" ? "Expense/Income" : "Geht/Einkommen",
                Position = AxisPosition.Left,
                Title = ayarlar.dil == "Türkçe" ? "Gelir/Gider" : ayarlar.dil == "English" ? "Expense/Income" : "Geht/Einkommen",
            });

            if(grafikTuru == 0)
            {
                plotModel.Series.Add(gelirVerileri(cariHareketler));
                plotModel.Series.Add(giderVerileri(cariHareketler));
            } else if(grafikTuru == 1)
            {
                plotModel.Series.Add(gelirVerileri(cariHareketler));
            } else
            {
                plotModel.Series.Add(giderVerileri(cariHareketler));
            }

            plotModel.TextColor = ayarlar.grafikYaziRengi;

            plotView.Model = plotModel;
            plotView.Dock = DockStyle.Fill;

            return plotView;
        }

    }
}
