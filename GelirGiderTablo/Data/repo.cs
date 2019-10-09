using GelirGiderTablo.Dtos;
using GelirGiderTablo.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;

namespace GelirGiderTablo.Data
{
    public static class repo
    {
        private static string Constr = ConfigurationManager.ConnectionStrings["GelirGider"].ConnectionString;

        public static long AddCahar(Cahar model)
        {
            long result = 0;
            try
            {
                using (var conn = new SQLiteConnection(Constr))
                {

                    var cmd = new SQLiteCommand("INSERT INTO Cahar (CariKod,Aciklama,Borc,Alacak,Tarih,VadeTarihi,ParaCinsi,Tip,BirimFiyat,Adet,OdemeSekli,Crt_tst) values (@CariKod,@Aciklama,@Borc,@Alacak,@Tarih,@VadeTarihi,@ParaCinsi,@Tip,@BirimFiyat,@Adet,@OdemeSekli,@Crt_tst);SELECT last_insert_rowid();", conn);
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
                    //SQLiteTransaction transaction = null;
                    //transaction = conn.BeginTransaction();

                    result = (long)cmd.ExecuteScalar();

                    //result = conn.LastInsertRowId;
                    //transaction.Commit();

                }
            }
            catch (Exception ex)
            {
                result = 0;
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


                    var cmd = new SQLiteCommand("UPDATE Cariler SET Ad=@Ad,Telefon=@Telefon,Adres=@Adres,Ilce=@Ilce,Il=@Il,Email=@Email,Upt_tst=@Upt_tst WHERE CariKod=@CariKod", conn);
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

                    cmd.CommandText = "SELECT CariKod,Borc,Alacak,ParaCinsi,VadeTarihi,OdemeSekli,Tip FROM Cahar WHERE VadeTarihi>=@vadetarihi AND VadeTarihi<=@soondate";
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
                        cahar.Tip = dr.GetString(dr.GetOrdinal("Tip"));
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

        public static bool AddStok(Stok model)
        {
            var result = false;
            try
            {
                using (var conn = new SQLiteConnection(Constr))
                {

                    var cmd = new SQLiteCommand("INSERT INTO Stok (StokKodu,StokAdi,Crt_tst) values (@StokKodu,@StokAdi,@Crt_tst)", conn);
                    cmd.Parameters.AddWithValue("@StokKodu", model.StokKodu);
                    cmd.Parameters.AddWithValue("@StokAdi", model.StokAdi);
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

        public static bool AddStokHar(StokHar model)
        {
            var result = false;
            try
            {
                using (var conn = new SQLiteConnection(Constr))
                {

                    var cmd = new SQLiteCommand("INSERT INTO Stokhar (StokKodu,Giren,Cikan,Tarih,Aciklama,Caharid) values (@StokKodu,@Giren,@Cikan,@Tarih,@Aciklama,@Caharid)", conn);
                    cmd.Parameters.AddWithValue("@StokKodu", model.StokKodu);
                    cmd.Parameters.AddWithValue("@Giren", model.Giren);
                    cmd.Parameters.AddWithValue("@Cikan", model.Cikan);
                    cmd.Parameters.AddWithValue("@Aciklama", model.Aciklama);
                    cmd.Parameters.AddWithValue("@Tarih", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Caharid", model.Cahar);

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

        public static List<Stok> GetStok(string searchstr)
        {
            var result = new List<Stok>();
            try
            {
                using (var conn = new SQLiteConnection(Constr))
                {
                    var cmd = new SQLiteCommand(conn);
                    if (string.IsNullOrEmpty(searchstr))
                    {
                        cmd.CommandText = "SELECT StokKodu,StokAdi FROM Stok";
                    }
                    else
                    {
                        cmd.CommandText = "SELECT StokKodu,StokAdi FROM Stok WHERE StokKodu LIKE @src or StokAdi LIKE @src";
                        cmd.Parameters.AddWithValue("@src", "%" + searchstr + "%");
                    }


                    conn.Open();
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        var stok = new Stok();
                        stok.StokKodu = dr.GetString(dr.GetOrdinal("StokKodu"));
                        stok.StokAdi= dr.GetString(dr.GetOrdinal("StokAdi"));
                        result.Add(stok);
                    }
                    dr.Close();
                }
            }
            catch (Exception)
            {
                result = null;
            }
            return result;
        }
        public static Stok GetStok_stokkodu(string stokkodu)
        {
            var result = new Stok();
            try
            {
                using (var conn = new SQLiteConnection(Constr))
                {
                    var cmd = new SQLiteCommand(conn);

                    cmd.CommandText = "SELECT StokKodu,StokAdi FROM Stok WHERE StokKodu LIKE @src";
                    cmd.Parameters.AddWithValue("@src", "%" + stokkodu + "%");


                    conn.Open();
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        result.StokKodu = dr.GetString(dr.GetOrdinal("StokKodu"));
                        result.StokAdi = dr.GetString(dr.GetOrdinal("StokAdi"));
                    }
                    dr.Close();
                }
            }
            catch (Exception)
            {
                result.StokKodu="";
            }
            return result;
        }

        public static List<StokHar> GetStokHar_tek(string stokkodu)
        {
            var list = new List<StokHar>();
            try
            {
                using (var conn = new SQLiteConnection(Constr))
                {
                    var cmd = new SQLiteCommand(conn);
                    if (string.IsNullOrEmpty(stokkodu))
                    {
                        cmd.CommandText = "SELECT * FROM Stokhar";
                    }
                    else
                    {
                        cmd.CommandText = "SELECT * FROM Stokhar WHERE StokKodu LIKE @src";
                        cmd.Parameters.AddWithValue("@src", stokkodu);
                    }


                    conn.Open();
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        var stokhar = new StokHar();
                        //stokhar.Id = dr.GetInt32(dr.GetOrdinal("Id"));
                        stokhar.StokKodu = dr.GetString(dr.GetOrdinal("StokKodu"));
                        stokhar.Giren = dr.GetDecimal(dr.GetOrdinal("Giren"));
                        stokhar.Cikan = dr.GetDecimal(dr.GetOrdinal("Cikan"));
                        stokhar.Tarih = dr.GetDateTime(dr.GetOrdinal("Tarih"));
                        stokhar.Aciklama = dr.GetString(dr.GetOrdinal("Aciklama"));
                        stokhar.Cahar = dr.GetInt32(dr.GetOrdinal("Caharid"));
                        list.Add(stokhar);
                    }
                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                list = null;
            }
            return list;
        }

        public static List<StokHarGroup> GetStokHar_group(string stokkodu, DateTime? baslangic, DateTime? bitis)
        {
            var list = new List<StokHarGroup>();
            try
            {
                using (var conn = new SQLiteConnection(Constr))
                {
                    var cmd = new SQLiteCommand(conn);
                    if (string.IsNullOrEmpty(stokkodu))
                    {
                        if(baslangic!=null && bitis != null)
                        {
                            cmd.CommandText = "SELECT StokKodu,SUM(Giren) as Giren, Sum(Cikan) as Cikan FROM Stokhar where Tarih>=@baslangic and Tarih<=@bitis Group by StokKodu";
                            cmd.Parameters.AddWithValue("@baslangic", baslangic);
                            cmd.Parameters.AddWithValue("@bitis", bitis);
                        } 
                        else
                            cmd.CommandText = "SELECT StokKodu,SUM(Giren) as Giren, Sum(Cikan) as Cikan FROM Stokhar Group by StokKodu";
                    }
                    else
                    {
                        if (baslangic != null && bitis != null)
                        {
                            cmd.CommandText = "SELECT StokKodu,SUM(Giren) as Giren, Sum(Cikan) as Cikan FROM Stokhar WHERE StokKodu LIKE @src and Tarih>=@baslangic and Tarih<=@bitis group by StokKodu";
                            cmd.Parameters.AddWithValue("@src", stokkodu);
                            cmd.Parameters.AddWithValue("@baslangic", baslangic);
                            cmd.Parameters.AddWithValue("@bitis", bitis);
                        }
                        else
                        {
                            cmd.CommandText = "SELECT StokKodu,SUM(Giren) as Giren, Sum(Cikan) as Cikan FROM Stokhar WHERE StokKodu LIKE @src group by StokKodu";
                            cmd.Parameters.AddWithValue("@src", stokkodu);
                        }
                    }


                    conn.Open();
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        var stokhar = new StokHarGroup();
                        stokhar.StokKodu = dr.GetString(dr.GetOrdinal("StokKodu"));
                        stokhar.Giren = dr.GetDecimal(dr.GetOrdinal("Giren"));
                        stokhar.Cikan = dr.GetDecimal(dr.GetOrdinal("Cikan"));
                        list.Add(stokhar);
                    }
                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                list = null;
            }
            return list;
        }
        public static List<StokHarRemain> GetStokHarKalan(string stokkodu)
        {
            var list = new List<StokHarRemain>();
            try
            {
                using (var conn = new SQLiteConnection(Constr))
                {
                    var cmd = new SQLiteCommand(conn);
                    if (string.IsNullOrEmpty(stokkodu))
                    {
                        cmd.CommandText = "SELECT h.StokKodu,StokAdi,sum(Giren)-sum(Cikan) as Kalan from Stokhar as h join Stok as s on h.StokKodu=s.StokKodu group by h.StokKodu";
                    }
                    else
                    {
                        cmd.CommandText = "SELECT h.StokKodu,StokAdi,sum(Giren)-sum(Cikan) as Kalan from Stokhar as h join Stok as s on h.StokKodu=s.StokKodu WHERE h.StokKodu LIKE @src group by h.StokKodu";
                        cmd.Parameters.AddWithValue("@src", "%" + stokkodu + "%");
                    }


                    conn.Open();
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        var stokhar = new StokHarRemain();
                        stokhar.StokKodu = dr.GetString(dr.GetOrdinal("StokKodu"));
                        stokhar.StokAdi = dr.GetString(dr.GetOrdinal("StokAdi"));
                        stokhar.Kalan = dr.GetDecimal(dr.GetOrdinal("Kalan"));
                        list.Add(stokhar);
                    }
                    dr.Close();
                }
            }
            catch (Exception)
            {
                list = null;
            }
            return list;
        }
    }
}