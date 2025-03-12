using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using OxyPlot;

namespace KisiselFinansTakipSistemi
{
    public class Ayarlar
    {
        public string paraBirimi { get; set; }
        public string dil { get; set; }
        public string cizgiTuru { get; set; }
        public OxyColor grafikYaziRengi { get; set; }
        public OxyColor grafikGelirCizgiRengi { get; set; }
        public OxyColor grafikGiderCizgiRengi { get; set; }

        public Ayarlar()
        {
            // Program ilk açıldığında veri tabanında kayıt edilmiş ayarları çekiyoruz.

            using (dbConnection db = new())
            {
                SqlCommand command = new("SELECT * FROM Ayarlar", db.dbConnect());
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();

                this.paraBirimi = reader[0].ToString();
                this.dil = reader[1].ToString();
                this.cizgiTuru = reader[2].ToString();
                this.grafikYaziRengi = OxyColor.Parse(reader[3].ToString());
                this.grafikGelirCizgiRengi = OxyColor.Parse(reader[4].ToString());
                this.grafikGiderCizgiRengi = OxyColor.Parse(reader[5].ToString());
            }
        }

        public void paraBirimiGuncelle(string paraBirimi)
        {
            this.paraBirimi = paraBirimi;
        }

        public void dilGuncelle(string dil)
        {
            this.dil = dil;
        }
    }
}
