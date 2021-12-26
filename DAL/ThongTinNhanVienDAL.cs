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
    public class ThongTinNhanVienDAL : DatabaseAccess
    {
        public List<ThongTinNhanVien> getThongTin()
        {
            List<ThongTinNhanVien> ds = new List<ThongTinNhanVien>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from Nhanvien";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int ma = reader.GetInt32(0);
                String HoTen = reader.GetString(1);
                String diachi = reader.GetString(2);
                int sodienthoai = reader.GetInt32(3);
                ThongTinNhanVien thongtin = new ThongTinNhanVien();
                thongtin.Ma = ma;
                thongtin.Hoten = HoTen;
                thongtin.DiaChi = diachi;
                thongtin.SoDienThoai = sodienthoai;
                ds.Add(thongtin);
            }
            reader.Close();
            return ds;
        }
    }
}
