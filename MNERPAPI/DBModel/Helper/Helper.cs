using Dapper;
using DBModel.Utility;
using Microsoft.Extensions.Configuration;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBModel
{
    public interface IHelper
    {
        DataTable sc(string c, string cs);
    }

   public class Helper: BaseRepository, IHelper
    {
       
        public Helper(IConfiguration configuration) :
          base(configuration)
        {
        }
        private readonly IConfiguration _configuration;
        public string FicheNo()
        {
            string fat =selectstring("Select isnull(MAX(FIS_ID), 0) from Fisler");
            fat = ("0000000000000001").Remove(("0000000000000001").Length - fat.Length) + fat;
            string FO = Helper.incStr(fat, true, 16);
            return FO;
        }

        protected SqlConnection CreateConnection()
        {

            return new SqlConnection(_configuration.GetConnectionString("ConnStr"));
        }
        

        public  DataTable sc(string c, string cs)
        {

            DataTable dt = new DataTable();
            using (SqlConnection conn = CreateSQLConnection())
            {
                using (SqlDataAdapter adap = new SqlDataAdapter(c, conn))
                {
                    try
                    {
                        conn.Open();
                        adap.Fill(dt);
                    }
                    catch (Exception e)
                    {

                    }
                }
            }
            return dt;
        }

        public  decimal sdbdec(string sorgu, string connstr)
        {
            using (SqlConnection conn = (SqlConnection)CreateConnection())
            {
                using (SqlCommand comm = new SqlCommand(sorgu, conn))
                {
                    try
                    {
                        conn.Open();
                        var value = (decimal)comm.ExecuteScalar();
                        conn.Close();
                        return value;
                    }
                    catch (Exception ex)
                    {
                        return 0m;
                    }
                }
            }
        }

        public  int sdbint(string sorgu)
        {
            using (SqlConnection conn = (SqlConnection)CreateConnection())
            {
                using (SqlCommand comm = new SqlCommand(sorgu, conn))
                {
                    try
                    {
                        conn.Open();
                        var value = (int)comm.ExecuteScalar();
                        conn.Close();
                        return value;
                    }
                    catch (Exception ex)
                    {
                        return 0;
                    }
                }
            }
        }

        public  string scs(string c)
        {
            using (SqlConnection conn = (SqlConnection)CreateConnection())
            {
                using (SqlCommand comm = new SqlCommand(c, conn))
                {
                    try
                    {
                        conn.Open();
                        return comm.ExecuteScalar().ToString();
                    }
                    catch (Exception ex)
                    {
                        return "";
                    }
                }
            }
        }

        public  int scn(string c)
        {
            using (SqlConnection conn = (SqlConnection)CreateConnection())
            {
                using (SqlCommand comm = new SqlCommand(c, conn))
                {
                    try
                    {
                        conn.Open();
                        return comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        return 0;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        public  bool ExecuteQuery(string c)
        {
            using (SqlConnection conn = (SqlConnection)CreateConnection())
            {
                using (SqlCommand comm = new SqlCommand(c, conn))
                {
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                        conn.Close();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
            }
        }
       
        public string selectstring(string c)
        {
            using (SqlConnection conn = (SqlConnection)CreateConnection())
            {
                using (SqlCommand comm = new SqlCommand(c, conn))
                {
                    try
                    {
                        conn.Open();
                        return comm.ExecuteScalar().ToString();
                    }
                    catch (Exception ex)
                    {
                        return "";
                    }
                }
            }
        }

        public static string setofchars(char startchar, char stopchar)
        {
            string tmp = "";
            if (Convert.ToByte(startchar) < Convert.ToByte(stopchar))
                for (int i = Convert.ToByte(startchar); i <= Convert.ToByte(stopchar); i++)
                    tmp += (char)i;
            else
                for (int i = Convert.ToByte(stopchar); i <= Convert.ToByte(startchar); i++)
                    tmp += (char)i;
            return tmp;
        }

        public static string incStr(string ck, bool lead, int len)
        {
            int say, ln;
            string tmp = "";
            string str = setofchars('0', '9');
            while (ck != "" && (str.IndexOf(ck[ck.Length - 1]) != -1))
            {
                tmp = ck[ck.Length - 1] + tmp;
                ck = ck.Remove(ck.Length - 1, 1);
            }

            if (tmp == "") tmp = "00001";
            ln = tmp.Length;
            say = Convert.ToInt32(tmp);
            say++;
            tmp = say.ToString();
            while (tmp.Length < ln) tmp = "0" + tmp;
            tmp = ck + tmp;
            if (lead)
            {
                while (tmp.Length < len) tmp = "0" + tmp;
            }
            return tmp;
        }

    }
}
