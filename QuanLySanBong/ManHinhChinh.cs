using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySanBong
{
    public partial class ManHinhChinh : Form
    {
        public String HoTen;
        public ManHinhChinh()
        {
            InitializeComponent();
        }

        private void ManHinhChinh_Load(object sender, EventArgs e)
        {
            lblHoten.Text = HoTen;
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thật sự muốn đăng xuất?", "Đăng Xuất", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                DangNhap form = new DangNhap();
                form.ShowDialog();
            
            }
            else if (result == DialogResult.No)
            {
                
            }
        }

        private void thêmSânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSan san = new frmSan();
            san.HoTenLichDatSan = HoTen;
            this.Hide();
            san.ShowDialog();
        }

        private void sửaSânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LichDatSan lich = new LichDatSan();
            lich.HoTenLichDatSan = HoTen;
            lich.ShowDialog();
        }

        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien san = new frmNhanVien();
            san.sinhvien = HoTen;
            this.Hide();
            san.ShowDialog();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tổngDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoanhThu doanh = new DoanhThu();
            doanh.doanhthu = HoTen;
            this.Hide();
            doanh.ShowDialog();

        }
    }
}
