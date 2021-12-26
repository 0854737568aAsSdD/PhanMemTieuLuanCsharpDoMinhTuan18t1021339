using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
   public class DoanhThuDAL : DatabaseAccess
    {
        public List<DoanhThuDTO> getThongTin()
        {
            List<DoanhThuDTO> ds = new List<DoanhThuDTO>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from DoanhThu";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {    
                String madoanhthu = reader.GetString(0);
                int tongdoanhthu = reader.GetInt32(1);
                DoanhThuDTO dto = new DoanhThuDTO();
               dto.MaDoanhThu = madoanhthu;
                dto.TongDoanhThu = tongdoanhthu;
                ds.Add(dto);
            }
            reader.Close();
            return ds;
        }
    }
}
