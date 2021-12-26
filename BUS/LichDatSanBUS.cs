using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class LichDatSanBUS
    {
        LichDatSanDAL lich = new LichDatSanDAL();
        public List<LichDatSanDTO> getLichDatSan()
        {
            return lich.getToanBoLichDatSan();
        }
        public bool ThemSan(LichDatSanDTO dto)
        {
            return lich.ThemLichDatSan(dto);
        }
        public LichDatSanDTO HienThi(String ma)
        {
            return lich.HienThiChiTiet(ma);
        }
        public bool CapNhatLich(LichDatSanDTO dto)
        {
            return lich.CapNhatLich(dto);
        }
        public bool XoaLich(String ma)
        {
            return lich.XoaLichSan(ma);
        }
        public bool TimKiem(String hoten)
        {
            return lich.TimKiem(hoten);
        }

    }
}