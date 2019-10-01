using GelirGiderTablo.Dtos;
using GelirGiderTablo.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Management;

namespace GelirGiderTablo.Data
{
    public static class auth
    {
        private static string Constr = ConfigurationManager.ConnectionStrings["GelirGider"].ConnectionString;

        public static User GetUser()
        {
            var user = new User();
            try
            {
                using (var conn = new SQLiteConnection(Constr))
                {


                    var cmd = new SQLiteCommand("SELECT * FROM User", conn);

                    conn.Open();
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        user.Id = dr.GetInt32(dr.GetOrdinal("Id"));
                        user.Username = dr.GetString(dr.GetOrdinal("UserName"));
                        user.Password = dr.GetString(dr.GetOrdinal("Password"));
                        user.DateBegin = dr.GetDateTime(dr.GetOrdinal("DateBegin"));
                        user.DateEnd = dr.GetDateTime(dr.GetOrdinal("DateEnd"));
                        user.Cpu = dr.GetString(dr.GetOrdinal("Cpu"));
                    }
                    dr.Close();

                    if (user.Id == 0)
                    {
                        user.DateBegin = DateTime.Now;
                        user.DateEnd = DateTime.Now.AddMonths(1);
                        user.Cpu = getCPUID();
                        var cmdinsert = new SQLiteCommand("INSERT INTO User (UserName,Password,DateBegin,DateEnd,Cpu) values (@UserName,@Password,@DateBegin,@DateEnd,@Cpu)", conn);
                        cmdinsert.Parameters.AddWithValue("@UserName", "");
                        cmdinsert.Parameters.AddWithValue("@Password", "");
                        cmdinsert.Parameters.AddWithValue("@DateBegin", user.DateBegin);
                        cmdinsert.Parameters.AddWithValue("@DateEnd", user.DateEnd);
                        cmdinsert.Parameters.AddWithValue("@Cpu", user.Cpu);
                        cmdinsert.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception)
            {
                user = null;
            }
            return user;
        }

        public static DateTime GetUserDate()
        {
            var result = new DateTime();
            try
            {
                using (var conn = new SQLiteConnection(Constr))
                {

                    var id = 0;
                    var cmd = new SQLiteCommand("SELECT Id,DateEnd FROM User Limit 1", conn);

                    conn.Open();
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        id = dr.GetInt32(dr.GetOrdinal("Id"));
                        result = dr.GetDateTime(dr.GetOrdinal("DateEnd"));
                    }
                    dr.Close();

                    if (id == 0)
                    {
                        var cmdinsert = new SQLiteCommand("INSERT INTO User (UserName,Password,DateBegin,DateEnd,Cpu) values (@UserName,@Password,@DateBegin,@DateEnd,@Cpu)",conn);
                        cmdinsert.Parameters.AddWithValue("@UserName", "");
                        cmdinsert.Parameters.AddWithValue("@Password", "");
                        cmdinsert.Parameters.AddWithValue("@DateBegin", DateTime.Now);
                        cmdinsert.Parameters.AddWithValue("@DateEnd", DateTime.Now.AddMonths(1));
                        cmdinsert.Parameters.AddWithValue("@Cpu", getCPUID());
                        cmdinsert.ExecuteNonQuery();
                        result = DateTime.Now.AddMonths(1);
                    }

                }
            }
            catch (Exception ex)
            {
                throw new ArgumentNullException("Kullanıcı bilgilerine ulaşılamadı");
            }
            return result;
        }



        public static string getCPUID()
        {
            string cpuInfo = "";
            ManagementClass managClass = new ManagementClass("win32_processor");
            ManagementObjectCollection managCollec = managClass.GetInstances();

            foreach (ManagementObject managObj in managCollec)
            {
                if (cpuInfo == "")
                {
                    //Get only the first CPU's ID
                    cpuInfo = managObj.Properties["processorID"].Value.ToString();
                    break;
                }
            }

            return cpuInfo;
        }
    }
}