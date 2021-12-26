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
    public class LichDatSanDAL:DatabaseAccess
    {
        public List<LichDatSanDTO> getToanBoLichDatSan()
        {       
            List<LichDatSanDTO> ds = new List<LichDatSanDTO>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select  MaPhieuDatSan,QuanLySan.MaSan,HoTenKhachHang,NgayDat,TenSan from QuanLySan inner join SanBong on QuanLySan.MaSan = SanBong.MaSan";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                String maphieudatsan = reader.GetString(0);
                String masan = reader.GetString(1);
                String HoTenKhachHang = reader.GetString(2);
                DateTime NgayDat = reader.GetDateTime(3);
                String TenSan = reader.GetString(4);
                LichDatSanDTO datSan = new LichDatSanDTO();
                datSan.MaPhieu = maphieudatsan;
                datSan.HoTenKhachHang = HoTenKhachHang;
                datSan.MaSan = masan;
                datSan.NgayDat = NgayDat;
                datSan.TenSan = TenSan;              
                ds.Add(datSan);
            }
            reader.Close();
            return ds;
        }
        public bool ThemLichDatSan(LichDatSanDTO lich)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = "insert into QuanLySan(MaPhieuDatSan,MaSan,HoTenKhachHang,NgayDat) values (@ma,@ten,@kt,@gia)";
            command.Connection = conn;
            command.Parameters.Add("@ma", lich.MaPhieu);
            command.Parameters.Add("@ten", lich.MaSan);
            command.Parameters.Add("@kt", lich.HoTenKhachHang);
            command.Parameters.Add("@gia", lich.NgayDat);
            int kq = command.ExecuteNonQuery();
            return kq > 0;
        }
        public LichDatSanDTO HienThiChiTiet(String ma)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from QuanLySan where MaPhieuDatSan = @ma";
            command.Connection = conn;
            command.Parameters.Add("@ma", ma);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                LichDatSanDTO dto = new LichDatSanDTO();
                if (reader.Read())
                {
                    String maphieu = reader.GetString(0);
                    String masan = reader.GetString(1);
                    String HoTenKhachHang = reader.GetString(2);
                    DateTime date = reader.GetDateTime(3);
                    dto.MaPhieu = maphieu;
                    dto.MaSan = masan;
                    dto.HoTenKhachHang = HoTenKhachHang;
                    dto.NgayDat = date;
                    dto.TenSan = null;
                }
                return dto;
            }
            else
            {
                return null;
            }
        }
        public bool CapNhatLich(LichDatSanDTO lich)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = "update QuanLySan set MaSan = @masan , HoTenKhachHang =@hoten,NgayDat=@ngay where MaPhieuDatSan = @ma";
            command.Connection = conn;
            command.Parameters.Add("@ma", lich.MaPhieu);
            command.Parameters.Add("@masan", lich.MaSan);
            command.Parameters.Add("@hoten", lich.HoTenKhachHang);
            command.Parameters.Add("@ngay", lich.NgayDat);
            int kq = command.ExecuteNonQuery();
            return kq > 0;
        }
        public bool XoaLichSan(String ma)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from QuanLySan where MaSan = @masan";
            command.Connection = conn;
            command.Parameters.Add("@masan", ma);
            int kq = command.ExecuteNonQuery();
            return kq > 0;
        }
        public bool TimKiem(String tenkhachhang)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from QuanLySan where HoTenKhachHang like N'%"+tenkhachhang+"%'";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
