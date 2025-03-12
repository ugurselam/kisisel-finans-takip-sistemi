using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace KisiselFinansTakipSistemi
{
    public class CariHareketler
    {
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public int Tutar { get; set; }
        public bool Tip { get; set; }
        public bool Sabit { get; set; }
        public string Tarih { get; set; }

        public int baslangicElemanSayisi = 0;

        public CariHareketler(List<string> hareketListesi, Bakiye bakiye)
        {
            using (dbConnection db = new())
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM CariHareketler", db.dbConnect());
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    hareketListesi.Add(reader.GetInt32(0).ToString());
                    hareketListesi.Add(reader.GetString(1));
                    hareketListesi.Add(reader.GetString(2));
                    hareketListesi.Add(reader.GetString(3));
                    hareketListesi.Add(reader.GetBoolean(4).ToString()); // Tip

                    if (reader.GetBoolean(5))
                    {
                        // Sabit Gelirin Tarihi Geldiyse Ekleme İşlemi 
                        // ParseExact metodu sayesinde string türündeki tarih verisini DateTime türüne dönüştürdük.
                        hareketListesi.Add("True");
                        DateTime gelenTarih = DateTime.ParseExact(reader.GetString(6), "dd.MM.yyyy HH:mm", null);

                        string bakiyeEklendimi = reader.GetBoolean(7).ToString(); // Sabit gelir var mı?

                        using (dbConnection dbConnect = new())
                        {
                            if (gelenTarih.Day >= DateTime.Now.Day && bakiyeEklendimi == "0")
                            {
                                bakiye.bakiyeEkle(Convert.ToInt32(reader.GetString(3)));

                                SqlCommand cariGuncelle = new("UPDATE CariHareketler SET SabitAlindimi = @p1 WHERE ID = @p2", dbConnect.dbConnect());
                                cariGuncelle.Parameters.AddWithValue("@p1", 1);
                                cariGuncelle.Parameters.AddWithValue("@p2", reader.GetInt32(0));
                                cariGuncelle.ExecuteNonQuery();
                            }
                            else if (bakiyeEklendimi != "0")
                            {
                                SqlCommand cariGuncelle = new("UPDATE CariHareketler SET SabitAlindimi = @p1 WHERE ID = @p2", dbConnect.dbConnect());
                                cariGuncelle.Parameters.AddWithValue("@p1", 0);
                                cariGuncelle.Parameters.AddWithValue("@p2", reader.GetInt32(0));
                                cariGuncelle.ExecuteNonQuery();
                            }
                        }
                    }
                    else
                    {
                        hareketListesi.Add("False");
                    }

                    hareketListesi.Add(reader.GetString(6));
                    hareketListesi.Add(reader.GetBoolean(7).ToString());

                    if (reader.GetBoolean(4))
                        bakiye.gelir += Convert.ToInt32(reader.GetString(3));
                    else
                        bakiye.gider += Convert.ToInt32(reader.GetString(3));
                }

                baslangicElemanSayisi = hareketListesi.Count;
                bakiye.kazanc = bakiye.gelir - bakiye.gider;
            }
        }

        public void islemEkle(List<string> hareketListesi)
        {
            int index = int.Parse(hareketListesi[hareketListesi.Count - 8]);

            hareketListesi.Add((index + 1).ToString());
            hareketListesi.Add(this.Baslik);
            hareketListesi.Add(this.Aciklama);
            hareketListesi.Add(this.Tutar.ToString());
            hareketListesi.Add(this.Tip.ToString()); // 0 Bakiye Ekle : 1 Bakkiye Eksilt
            hareketListesi.Add(this.Sabit.ToString()); // 0 Bakiye Ekle : 1 Bakkiye Eksilt
            hareketListesi.Add(this.Tarih);
            hareketListesi.Add("0"); // Sabit Alindimi
        }

    }
}
