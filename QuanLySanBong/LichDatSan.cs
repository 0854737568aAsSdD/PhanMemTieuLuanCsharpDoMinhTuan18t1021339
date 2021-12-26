using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QuanLySanBong
{
    public partial class LichDatSan : Form
    {
        public String HoTenLichDatSan;
        public LichDatSan()
        {
            InitializeComponent();
        }


        private void LichDatSan_Load(object sender, EventArgs e)
        {
            lblMaPhieu.Visible = false;
            lblMaSan.Visible = false;
            lblKhachHang.Visible = false;
            lblNgayDat.Visible = false;
            dtpNgayDat.Visible = false;
            txtKhachHang.Visible = false;
            txtMaPhieu.Visible = false;
            txtMaSan.Visible = false;
            LichDatSanBUS bus = new LichDatSanBUS();
            List<LichDatSanDTO> list = bus.getLichDatSan();
            LvLichDatSan.Items.Clear();
            foreach (LichDatSanDTO lich in list)
            {
                ListViewItem lv = new ListViewItem(lich.MaPhieu + "");
                lv.SubItems.Add(lich.MaSan);
                lv.SubItems.Add(lich.TenSan);
                lv.SubItems.Add(lich.HoTenKhachHang);
                lv.SubItems.Add(lich.NgayDat.ToString());
                LvLichDatSan.Items.Add(lv);
                lv.Tag = lich;
            }
        }

        private void btnTrungGian_Click(object sender, EventArgs e)
        {
            lblMaPhieu.Visible = true;
            lblMaSan.Visible = true;
            lblKhachHang.Visible = true;
            lblNgayDat.Visible = true;
            dtpNgayDat.Visible = true;
            txtKhachHang.Visible = true;
            txtMaPhieu.Visible = true;
            txtMaSan.Visible = true;
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            String masan = txtMaSan.Text;
            String maPhieu = txtMaPhieu.Text;
            String KhachHang = txtKhachHang.Text;
            DateTime dateTime = dtpNgayDat.Value;
            LichDatSanDTO dto  = new LichDatSanDTO();
            dto.MaPhieu = maPhieu;
            dto.MaSan = masan;
            dto.HoTenKhachHang = KhachHang;
            dto.NgayDat = dateTime;
            LichDatSanBUS lich = new LichDatSanBUS();
            bool kq = lich.ThemSan(dto);
            if (kq)
            {
                MessageBox.Show("Đã thêm 1 lịch", "Insert");
                LichDatSan frm = new LichDatSan();
                this.Hide();
                frm.ShowDialog();
            }
        }

        private void LvLichDatSan_SelectedIndexChanged(object sender, EventArgs e)
        {
            LichDatSanBUS bus = new LichDatSanBUS();
            if (LvLichDatSan.SelectedItems.Count == 0) return;
            ListViewItem lvi = LvLichDatSan.SelectedItems[0];
            LichDatSanDTO sb = (LichDatSanDTO)lvi.Tag;
            MessageBox.Show(sb.MaPhieu);
            String ma = sb.MaPhieu;    
            LichDatSanDTO a = bus.HienThi(ma);
            txtMaPhieu.Text = a.MaPhieu;
            txtMaSan.Text = a.MaSan;
            txtKhachHang.Text = a.HoTenKhachHang;
            dtpNgayDat.Value = a.NgayDat;
        }

        private void picUpdate_Click(object sender, EventArgs e)
        {
            LichDatSanDTO sb = new LichDatSanDTO();
            sb.MaPhieu = txtMaPhieu.Text;
            sb.MaSan = txtMaSan.Text;
            sb.HoTenKhachHang = txtKhachHang.Text;
            sb.NgayDat = dtpNgayDat.Value;
            LichDatSanBUS bus = new LichDatSanBUS();
            bool kq = bus.CapNhatLich(sb);
            if (kq)
            {
                MessageBox.Show("Đã cập nhật 1 sân bóng", "Update");
                LichDatSan frm = new LichDatSan();
                this.Hide();
                frm.ShowDialog();
            }
        }

        private void picDelete_Click(object sender, EventArgs e)
        {
            if (LvLichDatSan.SelectedItems.Count > 0)
            {
                ListViewItem lvi = LvLichDatSan.SelectedItems[0];
                LichDatSanDTO sb = lvi.Tag as LichDatSanDTO;
                LichDatSanBUS bus = new LichDatSanBUS();
                bool kq = bus.XoaLich(sb.MaSan);
                if (kq)
                {
                    MessageBox.Show("Đã xóa 1 sân bóng", "Delete");
                    LichDatSan frm = new LichDatSan();
                    this.Hide();
                    frm.ShowDialog();
                }
            }
        }

        private void picSearch_Click(object sender, EventArgs e)
        {
            LichDatSanBUS bus = new LichDatSanBUS();
            String hoten = txtTim.Text;
            bool kq = bus.TimKiem(hoten);
            if (kq == true)
            {
                MessageBox.Show("Đã có khách đặt lịch ngày hôm nay", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tìm Kiếm Thất Bại", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            ManHinhChinh frm = new ManHinhChinh();
            frm.HoTen = HoTenLichDatSan;
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
