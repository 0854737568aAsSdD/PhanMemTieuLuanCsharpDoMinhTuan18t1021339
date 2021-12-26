using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
   public class DatabaseAccess
    {
            String strConn = "server=DESKTOP-RE8HTG2;uid=sa;pwd=123;database=QuanLySanBong";
            protected  SqlConnection conn = null;
            public void OpenConnection() {
                if (conn == null)
                {
                    conn = new SqlConnection(strConn);
                }
                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
           
            }
            public void CloseConnection()
            {
                if (conn != null && conn.State == ConnectionState.Open)
                    conn.Close();
            }
      

        }
   }

