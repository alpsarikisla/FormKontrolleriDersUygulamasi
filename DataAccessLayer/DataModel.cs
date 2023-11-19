using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataModel
    {
        SqlConnection con; SqlCommand cmd;
        public DataModel()
        {
            con = new SqlConnection(ConnectionStrings.ConStr);
            cmd = con.CreateCommand();
        }

        public List<Sehir> SehirListele()
        {
            List<Sehir> sehirler = new List<Sehir>();
            try
            {
                cmd.CommandText = "SELECT * FROM Sehirler";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Sehir s = new Sehir();
                    s.ID = reader.GetInt32(0);
                    s.Isim = reader.GetString(1);
                    sehirler.Add(s);
                }
                return sehirler;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public List<Ilce> SehireGoreIlceListele(int sehirID)
        {
            List<Ilce> ilceler = new List<Ilce>();
            try
            {
                cmd.CommandText = "SELECT * FROM Ilceler WHERE SehirID=@sid";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@sid", sehirID);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Ilce i = new Ilce();
                    i.ID = reader.GetInt32(0);
                    i.SehirID = reader.GetInt32(1);
                    i.Isim = reader.GetString(2);
                    ilceler.Add(i);
                }
                return ilceler;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public List<Departman> DepartmanListele()
        {
            List<Departman> departmanlar = new List<Departman>();

            try
            {
                cmd.CommandText = "SELECT * FROM Departmanlar";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Departman d = new Departman();
                    d.ID = reader.GetInt32(0);
                    d.Isim = reader.GetString(1);
                    departmanlar.Add(d);
                }
                return departmanlar;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public bool PersonelEkle(Personel p)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Personeller(Sehir_ID, Ilce_ID, Departman_ID ,Isim, Soyisim, KimlikNo, Telefon, DogumTarihi, CocukSayi, Cinsiyet, MedeniHal, Adres, Gorev, Maas, Diller, PersonelNot) VALUES(@sehir_ID, @ilce_ID, @departman_ID, @isim, @soyisim, @kimlikNo, @telefon, @dogumTarihi, @cocukSayi, @cinsiyet, @medeniHal, @adres, @gorev, @maas, @diller, @personelNot)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@sehir_ID", p.Sehir_ID);
                cmd.Parameters.AddWithValue("@ilce_ID", p.Ilce_ID);
                cmd.Parameters.AddWithValue("@departman_ID", p.Departman_ID);
                cmd.Parameters.AddWithValue("@isim", p.Isim);
                cmd.Parameters.AddWithValue("@soyisim", p.Soyisim);
                cmd.Parameters.AddWithValue("@kimlikNo", p.KimlikNo);
                cmd.Parameters.AddWithValue("@telefon", p.Telefon);
                cmd.Parameters.AddWithValue("@dogumTarihi", p.DogumTarihi);
                cmd.Parameters.AddWithValue("@cocukSayi", p.CocukSayisi);
                cmd.Parameters.AddWithValue("@cinsiyet", p.Cinsiyet);
                cmd.Parameters.AddWithValue("@medeniHal", p.MedeniHal);
                cmd.Parameters.AddWithValue("@adres", p.Adres);
                cmd.Parameters.AddWithValue("@gorev", p.Gorev);
                cmd.Parameters.AddWithValue("@maas", p.Maas);
                cmd.Parameters.AddWithValue("@diller", p.Diller);
                cmd.Parameters.AddWithValue("@personelNot", p.PersonelNot);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
