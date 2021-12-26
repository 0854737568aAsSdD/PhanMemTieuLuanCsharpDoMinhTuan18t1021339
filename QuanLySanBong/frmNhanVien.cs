using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace QuanLySanBong
{
    public partial class frmNhanVien : Form
    {
        public String sinhvien;
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            ThongTinBUS bus = new ThongTinBUS();
            List<ThongTinNhanVien> ds = bus.GetThongTinNhanViens();
            lvNhanVien.Items.Clear();
            foreach (ThongTinNhanVien sb in ds)
            {
                ListViewItem lv = new ListViewItem(sb.Ma + "");
                lv.SubItems.Add(sb.Hoten);
                lv.SubItems.Add(sb.SoDienThoai.ToString());
                lv.SubItems.Add(sb.DiaChi);
                lvNhanVien.Items.Add(lv);
                lv.Tag = sb;
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            ManHinhChinh frm = new ManHinhChinh();
            frm.HoTen = sinhvien;
            this.Hide();
            frm.ShowDialog();
        }
    }
}
