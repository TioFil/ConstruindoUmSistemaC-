using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudCSharp.Classes
{
    public class Dal
    {

        public static string conection = ConfigurationManager
      .ConnectionStrings["conString"].ConnectionString;

        public static DataTable ExecuteDataTable(string connectionString, string cmdText,
CommandType type, SqlParameter[] prms)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(cmdText, conn))
                {
                    cmd.CommandType = type;
                    if (prms != null)
                    {
                        foreach (SqlParameter p in prms)
                        {
                            cmd.Parameters.Add(p);
                        }
                    }
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }
        public static DataTable ExecuteDataTable(string connectionString, string cmdText,
CommandType type)
        {
            return ExecuteDataTable(connectionString, cmdText, type, null);
        }

        public static SqlDataReader ExecuteReader(string connectionString, string cmdText,
CommandType type, SqlParameter[] prms)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            using (SqlCommand cmd = new SqlCommand(cmdText, conn))
            {
                cmd.CommandType = type;

                if (prms != null)
                {
                    foreach (SqlParameter p in prms)
                    {
                        cmd.Parameters.Add(p);
                    }
                }
                conn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
        }
        public static SqlDataReader ExecuteReader(string connectionString, string cmdText,
CommandType type)
        {
            return ExecuteReader(connectionString, cmdText, type, null);
        }

        public static int ExecuteNonQuery(string connectionString, string cmdText, CommandType type,
SqlParameter[] prms)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(cmdText, conn))
                {
                    cmd.CommandType = type;

                    if (prms != null)
                    {
                        foreach (SqlParameter p in prms)
                        {
                            cmd.Parameters.Add(p);
                        }
                    }
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static int ExecuteNonQuery(string connectionString, string cmdText, CommandType type)
        {
            return ExecuteNonQuery(connectionString, cmdText, type, null);
        }

        public static object ExecuteScalar(string connectionString, string cmdText, CommandType type,
 SqlParameter[] prms)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(cmdText, conn))
                {
                    cmd.CommandType = type;
                    if (prms != null)
                    {
                        foreach (SqlParameter p in prms)
                        {
                            cmd.Parameters.Add(p);
                        }
                    }
                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }

        public static object ExecuteScalar(string connectionString, string cmdText, CommandType type)
        {
            return ExecuteScalar(connectionString, cmdText, type, null);
        }
    }
}


