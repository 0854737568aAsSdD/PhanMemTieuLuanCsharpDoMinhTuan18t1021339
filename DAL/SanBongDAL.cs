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
    public class SanBongDAL : DatabaseAccess
    {
        public List<SanBong> getToanBoSanBong()
        {
            List<SanBong> ds = new List<SanBong>();
            OpenConnection();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from SanBong";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                String ma = reader.GetString(0);
                String tensan = reader.GetString(1);
                String kichthuoc = reader.GetString(2);
                String giathue = reader.GetString(3);
                SanBong sanbong = new SanBong();
                sanbong.MaSan = ma;
                sanbong.TenSan = tensan;
                sanbong.KichThuoc = kichthuoc;
                sanbong.GiaThue = giathue;
                ds.Add(sanbong);
            }
            reader.Close();
            return ds;
        }

        public bool XoaSanBong(String ma)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from SanBong where MaSan = @masan";
            command.Connection = conn;
            command.Parameters.Add("@masan", ma);
            int kq = command.ExecuteNonQuery();
            return kq > 0;

        }
        public bool ThemSanBong(SanBong sb)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = "insert into SanBong(MaSan,TenSan,KichThuoc,GiaThue) values (@ma,@ten,@kt,@gia)";
            command.Connection = conn;
            command.Parameters.Add("@ma", sb.MaSan);
            command.Parameters.Add("@ten", sb.TenSan);
            command.Parameters.Add("@kt", sb.KichThuoc);
            command.Parameters.Add("@gia", sb.GiaThue);
            int kq = command.ExecuteNonQuery();
            return kq > 0;
        }
        public SanBong HienThiChiTiet(String ma)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from SanBong where MaSan = @ma";
            command.Connection = conn;
            command.Parameters.Add("@ma", ma);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                SanBong sanbong = new SanBong();
                if (reader.Read())
                {
                    String masan = reader.GetString(0);
                    String tensan = reader.GetString(1);
                    String kichthuoc = reader.GetString(2);
                    String giathue = reader.GetString(3);
                    sanbong.MaSan = masan;
                    sanbong.TenSan = tensan;
                    sanbong.KichThuoc = kichthuoc;
                    sanbong.GiaThue = giathue;              
                }
                return sanbong;
            }
            else
            {
                return null;
            }


        }
        public bool CapNhatSanBong(SanBong sb)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = "update SanBong set TenSan = @ten , KichThuoc =@kt,GiaThue=@gia where MaSan = @ma";
            command.Connection = conn;
            command.Parameters.Add("@ma", sb.MaSan);
            command.Parameters.Add("@ten", sb.TenSan);
            command.Parameters.Add("@kt", sb.KichThuoc);
            command.Parameters.Add("@gia", sb.GiaThue);
            int kq = command.ExecuteNonQuery();
            return kq > 0;
        }

        public bool TimKiemSanBong(String tensan)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from SanBong where TenSan like '%"+tensan+"%'";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if(reader.HasRows)
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
