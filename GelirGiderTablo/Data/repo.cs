using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelirGiderTablo.Data
{
    public static class repo
    {
        private static string Constr = ConfigurationManager.ConnectionStrings["GelirGider"].ConnectionString;

        public static bool GelirAdd(GelirModel model)
        {
            var result = false;
            using (var conn = new SQLiteConnection(Constr))
            {
                try
                {
                    conn.Open();
                    var cmd = new SQLiteCommand("INSERT INTO Cahar (CariKod,Aciklama,Borc,Alacak,Tarih,VadeTarihi,ParaCinsi,Tip,BirimFiyat,Adet,OdemeSekli,Crt_tst) values (@CariKod,@Aciklama,@Borc,@Alacak,@Tarih,@VadeTarihi,@ParaCinsi,@Tip,@BirimFiyat,@Adet,@OdemeSekli,@Crt_tst)", conn);
                    cmd.Parameters.AddWithValue("@Firma", model.CariKod);
                    cmd.Parameters.AddWithValue("@Aciklama", model.Aciklama);
                    cmd.Parameters.AddWithValue("@Borc", model.Borc);
                    cmd.Parameters.AddWithValue("@Alacak", model.Alacak);
                    cmd.Parameters.AddWithValue("@Tarih", model.Tarih);
                    cmd.Parameters.AddWithValue("@VadeTarihi", model.VadeTarihi);
                    cmd.Parameters.AddWithValue("@ParaCinsi", model.ParaCinsi);
                    cmd.Parameters.AddWithValue("@Tip", model.Tip);
                    cmd.Parameters.AddWithValue("@BirimFiyat", model.BirimFiyat);
                    cmd.Parameters.AddWithValue("@Adet", model.Adet);
                    cmd.Parameters.AddWithValue("@OdemeSekli", model.OdemeSekli);
                    cmd.Parameters.AddWithValue("@Crt_tst", DateTime.Now);

                    if (cmd.ExecuteNonQuery() > 0)
                        result = true;
                }
                catch (Exception)
                {
                    result = false;
                }
            }
            return result;
        }

        public static bool CariAdd(Cari model)
        {
            var result = false;
            using (var conn = new SQLiteConnection(Constr))
            {
                try
                {
                    conn.Open();
                    var cmd = new SQLiteCommand("INSERT INTO Cariler (CariKod,Ad,Telefon,Adres,Ilce,Il,Email,Crt_tst) values (@CariKod,@Ad,@Telefon,@Adres,@Ilce,@Il,@Email,@Crt_tst)", conn);
                    cmd.Parameters.AddWithValue("@CariKod", model.CariKod);
                    cmd.Parameters.AddWithValue("@Ad", model.Ad);
                    cmd.Parameters.AddWithValue("@Telefon", model.Telefon);
                    cmd.Parameters.AddWithValue("@Adres", model.Adres);
                    cmd.Parameters.AddWithValue("@Ilce", model.Ilce);
                    cmd.Parameters.AddWithValue("@Il", model.Il);
                    cmd.Parameters.AddWithValue("@Email", model.Email);
                    cmd.Parameters.AddWithValue("@Crt_tst", DateTime.Now);

                    if (cmd.ExecuteNonQuery() > 0)
                        result = true;
                }
                catch (Exception ex)
                {
                    result = false;
                }
            }
            return result;
        }

        public static bool CariUpdate(Cari model)
        {
            var result = false;
            using (var conn = new SQLiteConnection(Constr))
            {
                try
                {
                    conn.Open();
                    var cmd = new SQLiteCommand("UPDATE Cariler SET Ad=@Ad,Telefon=@Telefon,Adres=@Adres,Ilce=Ilce,Il=@Il,Email=@Email,Upt_tst=@Upt_tst WHERE CariKod=@CariKod", conn);
                    cmd.Parameters.AddWithValue("@CariKod", model.CariKod);
                    cmd.Parameters.AddWithValue("@Ad", model.Ad);
                    cmd.Parameters.AddWithValue("@Telefon", model.Telefon);
                    cmd.Parameters.AddWithValue("@Adres", model.Adres);
                    cmd.Parameters.AddWithValue("@Ilce", model.Ilce);
                    cmd.Parameters.AddWithValue("@Il", model.Il);
                    cmd.Parameters.AddWithValue("@Email", model.Email);
                    cmd.Parameters.AddWithValue("@Upt_tst", DateTime.Now);

                    if (cmd.ExecuteNonQuery() > 0)
                        result = true;
                }
                catch (Exception ex)
                {
                    result = false;
                }
            }
            return result;
        }

        public static List<Cari> GetCariler(string str)
        {
            var cariler = new List<Cari>();

            using (var conn = new SQLiteConnection(Constr))
            {
                try
                {
                    conn.Open();
                    var cmd = new SQLiteCommand(conn);
                    if (string.IsNullOrEmpty(str))
                    {
                        cmd.CommandText = "SELECT * FROM Cariler";
                    }
                    else
                    {
                        cmd.CommandText = "SELECT * FROM Cariler WHERE Ad LIKE @src or CariKod LIKE @src";
                        cmd.Parameters.AddWithValue("@src", "%" + str + "%");
                    }



                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        var cari = new Cari();
                        cari.CariKod = dr.GetString(0);
                        cari.Ad = dr.GetString(1);
                        cari.Telefon = dr.GetString(2);
                        cari.Adres = dr.GetString(3);
                        cari.Ilce = dr.GetString(4);
                        cari.Il = dr.GetString(5);
                        cari.Email = dr.GetString(6);
                        cariler.Add(cari);
                    }
                    dr.Close();

                }
                catch (Exception ex)
                {

                }

                return cariler;
            }
        }

        public static Cari GetCari_Kod(string str)
        {
            var cari = new Cari();

            using (var conn = new SQLiteConnection(Constr))
            {
                try
                {
                    conn.Open();
                    var cmd = new SQLiteCommand(conn);

                    cmd.CommandText = "SELECT * FROM Cariler WHERE CariKod LIKE @src";
                    cmd.Parameters.AddWithValue("@src", str);



                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cari.CariKod = dr.GetString(0);
                        cari.Ad = dr.GetString(1);
                        cari.Telefon = dr.GetString(2);
                        cari.Adres = dr.GetString(3);
                        cari.Ilce = dr.GetString(4);
                        cari.Il = dr.GetString(5);
                        cari.Email = dr.GetString(6);
                    }
                    dr.Close();

                }
                catch (Exception ex)
                {

                }

                return cari;
            }
        }

        public static List<GelirModel> GetCahar_Carikod(string carikod)
        {
            var carihareketler = new List<GelirModel>();

            using (var conn = new SQLiteConnection(Constr))
            {
                try
                {
                    conn.Open();
                    var cmd = new SQLiteCommand(conn);
                    if (string.IsNullOrEmpty(carikod))
                    {
                        cmd.CommandText = "SELECT * FROM Cahar";
                    }
                    else
                    {
                        cmd.CommandText = "SELECT * FROM Cahar WHERE CariKod LIKE @src";
                        cmd.Parameters.AddWithValue("@src", carikod);
                    }



                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        var cahar = new GelirModel();
                        cahar.Id = dr.GetInt32(0);
                        cahar.CariKod = dr.GetString(1);
                        cahar.Tarih = dr.GetDateTime(2);
                        cahar.VadeTarihi = dr.GetDateTime(3);
                        cahar.Borc = dr.GetDecimal(4);
                        cahar.Alacak = dr.GetDecimal(5);
                        cahar.Aciklama = dr.GetString(6);
                        cahar.ParaCinsi = dr.GetString(7);
                        cahar.Tip = dr.GetString(8);
                        cahar.BirimFiyat = dr.GetDecimal(9);
                        cahar.Adet = dr.GetDecimal(10);
                        cahar.OdemeSekli = dr.GetString(11);
                        carihareketler.Add(cahar);
                    }
                    dr.Close();

                }
                catch (Exception ex)
                {

                }

                return carihareketler;
            }

        }
    }
}