using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace KisiselFinansTakipSistemi
{
    public class Bakiye
    {
        public int bakiye { get; set; }
        public int gelir { get; set; }
        public int gider { get; set; }
        public int kazanc { get; set; }

        public Bakiye()
        {
            this.bakiye = bakiyeGetir();
        }

        public int bakiyeGetir()
        {
            using(dbConnection dbConnection = new())
            {
                SqlCommand command = new("SELECT * FROM Bakiye", dbConnection.dbConnect());
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();

                return Convert.ToInt32(reader[1]);
            }
        }

        public void bakiyeEkle(int miktar)
        {
            this.bakiye += miktar;
            this.gelir += miktar;
            this.kazanc = this.gelir - this.gider;
        }

        public void bakiyeEksilt(int miktar)
        {
            this.bakiye -= miktar;
            this.gider += miktar;
            this.kazanc = this.gelir - this.gider;
        }
    }
}
