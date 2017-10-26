using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 产品销售管理系统.Database
{
  class connect
    {
        //储存用户名
        public static string user;
        public static string password;
        public static string AddType;
        public static string userType;
        private string constr = "Server=.;DataBase=Login;Trusted_Connection=SSPI";
             
        /// <summary>
        /// 连接数据库方法
        /// </summary>
        /// <returns></returns>
        public static SqlConnection Clink()
        {
            Database.connect date = new Database.connect();
            SqlConnection con = new SqlConnection(date.constr);
            con.Open();
            return con;
        }
    }
    
   
}
