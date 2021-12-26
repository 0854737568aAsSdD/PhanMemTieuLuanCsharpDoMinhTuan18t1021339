using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    public class DangNhapBus
    {
        public NhanVien GetNhanVien(String username, String password)
        {
            DangNhapDAL dangnhap = new DangNhapDAL();
            return dangnhap.GetNhanVien(username, password);
        }
    }
}