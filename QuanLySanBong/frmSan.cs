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
    public partial class frmSan : Form
    {
        public String HoTenLichDatSan;
        public frmSan()
        {
            InitializeComponent();
        }


        private void frmSan_Load(object sender, EventArgs e)
        {
            lblTim.Visible = false;
            txtTim.Visible = false;
            lblMaSan.Visible = false;
            lblTenSan.Visible = false;
            lblKichThuoc.Visible = false;
            lblGiaThue.Visible = false;
            txtMaSan.Visible = false;
            txtTenSan.Visible = false;
            txtKichThuoc.Visible = false;
            txtGiaThue.Visible = false;
            SanBongBus bus = new SanBongBus();
            List<SanBong> ds = bus.getToanBoSanBong();
            lvSanBong.Items.Clear();
            foreach (SanBong sb in ds)
            {
                ListViewItem lv = new ListViewItem(sb.MaSan + "");
                lv.SubItems.Add(sb.TenSan);
                lv.SubItems.Add(sb.KichThuoc);
                lv.SubItems.Add(sb.GiaThue);
                lvSanBong.Items.Add(lv);
                lv.Tag = sb;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(lvSanBong.SelectedItems.Count>0)
            {
                ListViewItem lvi = lvSanBong.SelectedItems[0];
                SanBong sb = lvi.Tag as SanBong;
                SanBongBus bus = new SanBongBus();
                bool kq = bus.XoaSanBong(sb.MaSan);
                if (kq)
                {
                    MessageBox.Show("Đã xóa 1 sân bóng", "Delete");
                    frmSan frm = new frmSan();
                    this.Hide();
                    frm.ShowDialog();
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            String ma = txtMaSan.Text;
            String ten = txtTenSan.Text;
            String kichthuoc = txtKichThuoc.Text;
            String giathue = txtGiaThue.Text;
            SanBong sb = new SanBong();
            sb.MaSan = ma;
            sb.TenSan = ten;
            sb.KichThuoc = kichthuoc;
            sb.GiaThue = giathue;
            SanBongBus bus = new SanBongBus();
            bool kq = bus.ThemSanBong(sb);
            if (kq)
            {
                MessageBox.Show("Đã thêm 1 sân bóng", "Insert");
                frmSan frm = new frmSan();
                this.Hide();
                frm.ShowDialog();
            }
        }

        private void btnTrungGian_Click(object sender, EventArgs e)
        {
            lblTim.Visible = true;
            txtTim.Visible = true;
            lblMaSan.Visible = true;
            lblTenSan.Visible = true;
            lblKichThuoc.Visible = true;
            lblGiaThue.Visible = true;
            txtMaSan.Visible = true;
            txtTenSan.Visible = true;
            txtKichThuoc.Visible = true;
            txtGiaThue.Visible = true;
        }

        private void lvSanBong_SelectedIndexChanged(object sender, EventArgs e)
        {
            SanBongBus bus = new SanBongBus();
            if (lvSanBong.SelectedItems.Count == 0) return ;
            ListViewItem lvi = lvSanBong.SelectedItems[0];
            SanBong sb = (SanBong)lvi.Tag;
            String ma = sb.MaSan;
            SanBong a = bus.HienThiChiTiet(ma);
            txtMaSan.Text = a.MaSan;
            txtTenSan.Text = a.TenSan;
            txtKichThuoc.Text = a.KichThuoc;
            txtGiaThue.Text = a.GiaThue;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            SanBong sb = new SanBong();
            sb.MaSan = txtMaSan.Text;
            sb.TenSan = txtTenSan.Text;
            sb.KichThuoc = txtKichThuoc.Text;
            sb.GiaThue = txtGiaThue.Text;
            SanBongBus bus = new SanBongBus();
            bool kq = bus.CapNhatSanBong(sb);
            if(kq)
            {
                MessageBox.Show("Đã cập nhật 1 sân bóng", "Update");
                frmSan frm = new frmSan();
                this.Hide();
                frm.ShowDialog();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SanBongBus bus = new SanBongBus();
            String tensan = txtTim.Text;
            bool kq = bus.TimKiemSanBong(tensan);
            if(kq == true)
            {
                MessageBox.Show("Tìm Kiếm Thành Công","Search",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
        }
    }
}
