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
    public partial class DangNhap : Form
    {
        DangNhapBus bus = new DangNhapBus();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            NhanVien nhanvien = new NhanVien();
            nhanvien = bus.GetNhanVien(txtUsername.Text, txtPassword.Text);
            if (nhanvien != null)
            {
                this.Hide();
                ManHinhChinh manHinhChinh = new ManHinhChinh();
                manHinhChinh.HoTen = nhanvien.HoTenNhanVien;
                manHinhChinh.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai thông tin đăng nhập");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
