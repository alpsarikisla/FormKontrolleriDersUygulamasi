using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Personel
    {
        public int ID { get; set; }
        public int Sehir_ID { get; set; }
        public int Ilce_ID { get; set; }
        public int Departman_ID { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string KimlikNo { get; set; }
        public string Telefon { get; set; }
        public DateTime DogumTarihi { get; set; }
        public byte CocukSayisi { get; set; }
        public string Cinsiyet { get; set; }
        public string MedeniHal { get; set; }
        public string Adres { get; set; }
        public string Gorev { get; set; }
        public double Maas { get; set; }
        public string Diller { get; set; }
        public string PersonelNot { get; set; }
    }
}
