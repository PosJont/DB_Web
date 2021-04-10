using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Http;
using System.Web;

namespace DB_WEB.Models
{
    public class Comm
    {

        /// <summary>
        /// 與資料庫做連線
        /// </summary>
        /// <returns>回傳一個SqlConnection的物件</returns>
        public SqlConnection Set_DBConnection(string connStr)
        {
            SqlConnection Connection_Db;
            Connection_Db = new SqlConnection(connStr);
            Connection_Db.Open();
            return Connection_Db;
        }


        /// <summary>
        /// 與資料庫做連線
        /// </summary>
        /// <returns>回傳一個SqlConnection的物件</returns>
        public bool Chk_DBConnection(string connStr)
        {
            try
            {
                SqlConnection Connection_Db;
                Connection_Db = new SqlConnection(connStr);
                Connection_Db.Open();
                return true;
            }
            catch { return false; }
        }
    }
}
