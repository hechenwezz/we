using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL
{
   /// <summary>
    /// 连接数据库的类
   /// </summary>
  public static class SqlHelper
    {
        /// <summary>
        /// 获取配置文件中的连接字符串
        /// </summary>
        private static readonly string constr = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
        /// <summary>
        /// 执行insert,delete,update的方法
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="pms"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql, params SqlParameter[] pms)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    if (pms != null)
                    {
                        cmd.Parameters.AddRange(pms);
                    }
                    con.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }
        /// <summary>
        /// 执行sql语句，返回单个值。
        /// </summary>
        /// <param name="sql">要执行的sql语句</param>
        /// <param name="pms">sql语句中的参数</param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql, params SqlParameter[] pms)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    if (pms != null)
                    {
                        cmd.Parameters.AddRange(pms);

                    }
                    con.Open();
                    return cmd.ExecuteScalar();
                }
            }


        }
        /// <summary>
        /// 执行sql语句返回一个DataReader
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="pms"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string sql, params SqlParameter[] pms)
        {
            SqlConnection con = new SqlConnection(constr);
            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    if (pms != null)
                    {
                        cmd.Parameters.AddRange(pms);
                    }
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    return reader;

                }
            }
            catch
            {
                if (con != null)
                {
                    con.Close(); con.Dispose();
                }
                throw;
            }
        }
        /// <summary>
        /// 执行sql返回一个DataTable
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="pms"></param>
        /// <returns></returns>
        public static DataTable ExecuteDataTable(string sql, params SqlParameter[] pms)
        {
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sql, constr);
            if (pms != null)
            {
                sqlAdapter.SelectCommand.Parameters.AddRange(pms);
            }
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            return dt;
        }
        /// <summary>
        /// 测试连接数据库是否成功
        /// </summary>
        /// <returns></returns>
        public static bool ConnectDB()
        {
            try
            {
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                con.Close();
                con.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
