using GelirGiderTablo.Dtos;
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

        public static bool AddCahar(Cahar model)
        {
            var result = false;
            try
            {
                using (var conn = new SQLiteConnection(Constr))
                {


                    var cmd = new SQLiteCommand("INSERT INTO Cahar (CariKod,Aciklama,Borc,Alacak,Tarih,VadeTarihi,ParaCinsi,Tip,BirimFiyat,Adet,OdemeSekli,Crt_tst) values (@CariKod,@Aciklama,@Borc,@Alacak,@Tarih,@VadeTarihi,@ParaCinsi,@Tip,@BirimFiyat,@Adet,@OdemeSekli,@Crt_tst)", conn);
                    cmd.Parameters.AddWithValue("@CariKod", model.CariKod);
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

                    conn.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                        result = true;

                }
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public static bool AddCari(Cari model)
        {
            var result = false;
            try
            {
                using (var conn = new SQLiteConnection(Constr))
                {


                    var cmd = new SQLiteCommand("INSERT INTO Cariler (CariKod,Ad,Telefon,Adres,Ilce,Il,Email,Crt_tst) values (@CariKod,@Ad,@Telefon,@Adres,@Ilce,@Il,@Email,@Crt_tst)", conn);
                    cmd.Parameters.AddWithValue("@CariKod", model.CariKod);
                    cmd.Parameters.AddWithValue("@Ad", model.Ad);
                    cmd.Parameters.AddWithValue("@Telefon", model.Telefon);
                    cmd.Parameters.AddWithValue("@Adres", model.Adres);
                    cmd.Parameters.AddWithValue("@Ilce", model.Ilce);
                    cmd.Parameters.AddWithValue("@Il", model.Il);
                    cmd.Parameters.AddWithValue("@Email", model.Email);
                    cmd.Parameters.AddWithValue("@Crt_tst", DateTime.Now);

                    conn.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                        result = true;

                }
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }

        public static bool UpdateCari(Cari model)
        {
            var result = false;
            try
            {
                using (var conn = new SQLiteConnection(Constr))
                {


                    var cmd = new SQLiteCommand("UPDATE Cariler SET Ad=@Ad,Telefon=@Telefon,Adres=@Adres,Ilce=Ilce,Il=@Il,Email=@Email,Upt_tst=@Upt_tst WHERE CariKod=@CariKod", conn);
                    cmd.Parameters.AddWithValue("@CariKod", model.CariKod);
                    cmd.Parameters.AddWithValue("@Ad", model.Ad);
                    cmd.Parameters.AddWithValue("@Telefon", model.Telefon);
                    cmd.Parameters.AddWithValue("@Adres", model.Adres);
                    cmd.Parameters.AddWithValue("@Ilce", model.Ilce);
                    cmd.Parameters.AddWithValue("@Il", model.Il);
                    cmd.Parameters.AddWithValue("@Email", model.Email);
                    cmd.Parameters.AddWithValue("@Upt_tst", DateTime.Now);

                    conn.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                        result = true;

                }
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }

        public static List<Cari> GetCariler(string str)
        {
            var cariler = new List<Cari>();
            try
            {

                using (var conn = new SQLiteConnection(Constr))
                {

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


                    conn.Open();
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        var cari = new Cari();
                        cari.CariKod = dr.GetString(dr.GetOrdinal("CariKod"));
                        cari.Ad = dr.GetString(dr.GetOrdinal("Ad"));
                        cari.Telefon = dr.GetString(dr.GetOrdinal("Telefon"));
                        cari.Adres = dr.GetString(dr.GetOrdinal("Adres"));
                        cari.Ilce = dr.GetString(dr.GetOrdinal("Ilce"));
                        cari.Il = dr.GetString(dr.GetOrdinal("Il"));
                        cari.Email = dr.GetString(dr.GetOrdinal("Email"));
                        cariler.Add(cari);
                    }
                    dr.Close();



                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return cariler;
        }

        public static Cari GetCari_Kod(string str)
        {
            var cari = new Cari();
            try
            {
                using (var conn = new SQLiteConnection(Constr))
                {


                    var cmd = new SQLiteCommand(conn);

                    cmd.CommandText = "SELECT * FROM Cariler WHERE CariKod LIKE @src";
                    cmd.Parameters.AddWithValue("@src", str);


                    conn.Open();
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cari.CariKod = dr.GetString(dr.GetOrdinal("CariKod"));
                        cari.Ad = dr.GetString(dr.GetOrdinal("Ad"));
                        cari.Telefon = dr.GetString(dr.GetOrdinal("Telefon"));
                        cari.Adres = dr.GetString(dr.GetOrdinal("Adres"));
                        cari.Ilce = dr.GetString(dr.GetOrdinal("Ilce"));
                        cari.Il = dr.GetString(dr.GetOrdinal("Il"));
                        cari.Email = dr.GetString(dr.GetOrdinal("Email"));
                    }
                    dr.Close();



                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return cari;
        }

        public static List<Cahar> GetCahar_Carikod(string carikod)
        {
            var carihareketler = new List<Cahar>();
            try
            {
                using (var conn = new SQLiteConnection(Constr))
                {


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

                    conn.Open();
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        var cahar = new Cahar();
                        cahar.CariKod = dr.GetString(dr.GetOrdinal("CariKod"));
                        cahar.Tarih = dr.GetDateTime(dr.GetOrdinal("Tarih"));
                        cahar.VadeTarihi = dr.GetDateTime(dr.GetOrdinal("VadeTarihi"));
                        cahar.Borc = dr.GetDecimal(dr.GetOrdinal("Borc"));
                        cahar.Alacak = dr.GetDecimal(dr.GetOrdinal("Alacak"));
                        cahar.Aciklama = dr.GetString(dr.GetOrdinal("Aciklama"));
                        cahar.ParaCinsi = dr.GetString(dr.GetOrdinal("ParaCinsi"));
                        cahar.Tip = dr.GetString(dr.GetOrdinal("Tip"));
                        cahar.BirimFiyat = dr.GetDecimal(dr.GetOrdinal("BirimFiyat"));
                        cahar.Adet = dr.GetDecimal(dr.GetOrdinal("Adet"));
                        cahar.OdemeSekli = dr.GetString(dr.GetOrdinal("OdemeSekli"));
                        carihareketler.Add(cahar);
                    }
                    dr.Close();


                }
            }
            catch (Exception ex)
            {
                return null;

            }
            return carihareketler;
        }

        public static List<Cahar> GetCahar()
        {
            var carihareketler = new List<Cahar>();
            try
            {
                using (var conn = new SQLiteConnection(Constr))
                {
                    var cmd = new SQLiteCommand(conn);

                    cmd.CommandText = "SELECT * FROM Cahar";

                    conn.Open();
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        var cahar = new Cahar();
                        cahar.Id = dr.GetInt32(dr.GetOrdinal("Id"));
                        cahar.CariKod = dr.GetString(dr.GetOrdinal("CariKod"));
                        cahar.Tarih = dr.GetDateTime(dr.GetOrdinal("Tarih"));
                        cahar.VadeTarihi = dr.GetDateTime(dr.GetOrdinal("VadeTarihi"));
                        cahar.Borc = dr.GetDecimal(dr.GetOrdinal("Borc"));
                        cahar.Alacak = dr.GetDecimal(dr.GetOrdinal("Alacak"));
                        cahar.Aciklama = dr.GetString(dr.GetOrdinal("Aciklama"));
                        cahar.ParaCinsi = dr.GetString(dr.GetOrdinal("ParaCinsi"));
                        cahar.Tip = dr.GetString(dr.GetOrdinal("Tip"));
                        cahar.BirimFiyat = dr.GetDecimal(dr.GetOrdinal("BirimFiyat"));
                        cahar.Adet = dr.GetDecimal(dr.GetOrdinal("Adet"));
                        cahar.OdemeSekli = dr.GetString(dr.GetOrdinal("OdemeSekli"));
                        carihareketler.Add(cahar);
                    }
                    dr.Close();



                }
            }
            catch (Exception ex)
            {
                return null;

            }
            return carihareketler;
        }

        public static List<Cahar> GetCaharbyTip(string tip)
        {
            var carihareketler = new List<Cahar>();
            try
            {
                using (var conn = new SQLiteConnection(Constr))
                {
                    var cmd = new SQLiteCommand(conn);
                    if(tip=="SATIS")
                        cmd.CommandText = "SELECT * FROM Cahar WHERE Tip='SATIS'";
                    else
                        cmd.CommandText = "SELECT * FROM Cahar WHERE Tip!='SATIS'";

                    conn.Open();
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        var cahar = new Cahar();
                        cahar.Id = dr.GetInt32(dr.GetOrdinal("Id"));
                        cahar.CariKod = dr.GetString(dr.GetOrdinal("CariKod"));
                        cahar.Tarih = dr.GetDateTime(dr.GetOrdinal("Tarih"));
                        cahar.VadeTarihi = dr.GetDateTime(dr.GetOrdinal("VadeTarihi"));
                        cahar.Borc = dr.GetDecimal(dr.GetOrdinal("Borc"));
                        cahar.Alacak = dr.GetDecimal(dr.GetOrdinal("Alacak"));
                        cahar.Aciklama = dr.GetString(dr.GetOrdinal("Aciklama"));
                        cahar.ParaCinsi = dr.GetString(dr.GetOrdinal("ParaCinsi"));
                        cahar.Tip = dr.GetString(dr.GetOrdinal("Tip"));
                        cahar.BirimFiyat = dr.GetDecimal(dr.GetOrdinal("BirimFiyat"));
                        cahar.Adet = dr.GetDecimal(dr.GetOrdinal("Adet"));
                        cahar.OdemeSekli = dr.GetString(dr.GetOrdinal("OdemeSekli"));
                        carihareketler.Add(cahar);
                    }
                    dr.Close();



                }
            }
            catch (Exception ex)
            {
                return null;

            }
            return carihareketler;
        }

        public static List<CariBorcAlacak> GetCaharVadesiGecmisBorcAlacak()
        {
            var cariborclist = new List<CariBorcAlacak>();
            try
            {
                using (var conn = new SQLiteConnection(Constr))
                {
                    var cmd = new SQLiteCommand(conn);

                    cmd.CommandText = "SELECT CariKod,SUM(Borc) as Borc,SUM(Alacak) as Alacak,ParaCinsi FROM Cahar WHERE VadeTarihi<=@vadetarihi GROUP BY CariKod,ParaCinsi";
                    cmd.Parameters.AddWithValue("@vadetarihi", DateTime.Now);

                    conn.Open();
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        var cahar = new CariBorcAlacak();
                        cahar.CariKod = dr.GetString(dr.GetOrdinal("CariKod"));
                        cahar.Borc = dr.GetDecimal(dr.GetOrdinal("Borc"));
                        cahar.Alacak = dr.GetDecimal(dr.GetOrdinal("Alacak"));
                        cahar.ParaCinsi = dr.GetString(dr.GetOrdinal("ParaCinsi"));
                        cariborclist.Add(cahar);
                    }
                    dr.Close();



                }
            }
            catch (Exception ex)
            {
                return null;

            }
            return cariborclist;
        }

        public static List<Cahar> GetCaharGelecekBorcAlacak(DateTime? enddate)
        {
            var cariborclist = new List<Cahar>();
            try
            {
                using (var conn = new SQLiteConnection(Constr))
                {
                    var cmd = new SQLiteCommand(conn);

                    cmd.CommandText = "SELECT CariKod,Borc,Alacak,ParaCinsi,VadeTarihi,OdemeSekli FROM Cahar WHERE VadeTarihi>=@vadetarihi AND VadeTarihi<=@soondate";
                    cmd.Parameters.AddWithValue("@vadetarihi", DateTime.Now);
                    cmd.Parameters.AddWithValue("@soondate", enddate);


                    conn.Open();
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        var cahar = new Cahar();
                        cahar.CariKod = dr.GetString(dr.GetOrdinal("CariKod"));
                        cahar.Borc = dr.GetDecimal(dr.GetOrdinal("Borc"));
                        cahar.Alacak = dr.GetDecimal(dr.GetOrdinal("Alacak"));
                        cahar.ParaCinsi = dr.GetString(dr.GetOrdinal("ParaCinsi"));
                        cahar.VadeTarihi = dr.GetDateTime(dr.GetOrdinal("VadeTarihi"));
                        cahar.OdemeSekli = dr.GetString(dr.GetOrdinal("OdemeSekli"));
                        cariborclist.Add(cahar);
                    }
                    dr.Close();



                }
            }
            catch (Exception ex)
            {
                return null;

            }
            return cariborclist;
        }

        public static bool UpdateCahar(Cahar model)
        {
            bool result = false;

            try
            {
                using (var conn = new SQLiteConnection(Constr))
                {
                    var cmd = new SQLiteCommand(conn);

                    cmd.CommandText = "UPDATE Cahar SET CariKod=@CariKod, Borc=@Borc, Alacak=@Alacak, Tarih=@Tarih, VadeTarihi=@VadeTarihi, Aciklama=@Aciklama, Tip=@Tip, ParaCinsi=@ParaCinsi, BirimFiyat=@BirimFiyat, Adet=@Adet, OdemeSekli=@OdemeSekli WHERE Id=@id";
                    cmd.Parameters.AddWithValue("@id", model.Id);
                    cmd.Parameters.AddWithValue("@CariKod", model.CariKod);
                    cmd.Parameters.AddWithValue("@Borc", model.Borc);
                    cmd.Parameters.AddWithValue("@Alacak", model.Alacak);
                    cmd.Parameters.AddWithValue("@Tarih", model.Tarih);
                    cmd.Parameters.AddWithValue("@VadeTarihi", model.VadeTarihi);
                    cmd.Parameters.AddWithValue("@Aciklama", model.Aciklama);
                    cmd.Parameters.AddWithValue("@Tip", model.Tip);
                    cmd.Parameters.AddWithValue("@ParaCinsi", model.ParaCinsi);
                    cmd.Parameters.AddWithValue("@BirimFiyat", model.BirimFiyat);
                    cmd.Parameters.AddWithValue("@Adet", model.Adet);
                    cmd.Parameters.AddWithValue("@OdemeSekli", model.OdemeSekli);


                    conn.Open();
                    var res = cmd.ExecuteNonQuery();
                    result = res > 0 ? true : false;

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                return false;

            }


            return result;
        }
    }
}