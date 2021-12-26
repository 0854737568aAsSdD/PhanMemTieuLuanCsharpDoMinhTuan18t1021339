using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class SanBongBus
    {
        SanBongDAL sanbong = new SanBongDAL();
        public List<SanBong> getToanBoSanBong()
        {
            return sanbong.getToanBoSanBong();
        }
        public bool XoaSanBong(String ma)
        {
            return sanbong.XoaSanBong(ma);
        }
        public bool ThemSanBong(SanBong sb)
        {
            return sanbong.ThemSanBong(sb);
        }
        public SanBong HienThiChiTiet(String ma)
        {
            return sanbong.HienThiChiTiet(ma);
        }
        public bool CapNhatSanBong(SanBong sb)
        {
            return sanbong.CapNhatSanBong(sb);
        }
        public bool TimKiemSanBong(String tensan)
        {
            return sanbong.TimKiemSanBong(tensan);
        }
    }
}

