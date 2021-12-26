using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DangNhapDAL : DatabaseAccess
    {
        public NhanVien GetNhanVien(String username, String password)
        {
            OpenConnection();
            NhanVien nhanvien = new NhanVien();
            //Tao doi tuong sql command
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            // Cau truy van du lieu
            String query = @"Select * from NhanVien where TenDangNhap = @username and MatKhau =@pwd";
            command.Parameters.Add("@username", username);
            command.Parameters.Add("@pwd", password);
            command.CommandText = query;

            //Kiem tra ket qua tra ve
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {

                while (reader.Read())
                {
                    int MaNhanVien = reader.GetInt32(0);
                    String TenNhanVien = reader.GetString(1);
                    String DiaChi = reader.GetString(2);
                    nhanvien.MaNhanVien = MaNhanVien;
                    nhanvien.HoTenNhanVien = TenNhanVien;
                    nhanvien.DiaChi = DiaChi;
                }
                return nhanvien;
            }
            else
            {
                return null;
            }


        }
    }

}



