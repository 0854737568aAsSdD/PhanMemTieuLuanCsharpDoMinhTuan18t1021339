using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class ThongTinBUS
    {
        ThongTinNhanVienDAL dal = new ThongTinNhanVienDAL();
        public List<ThongTinNhanVien> GetThongTinNhanViens()
        {
            return dal.getThongTin();
        }
    }
}
