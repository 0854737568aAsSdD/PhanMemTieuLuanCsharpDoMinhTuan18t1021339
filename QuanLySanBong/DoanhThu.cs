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
    public partial class DoanhThu : Form
    {
        public String doanhthu;
        public DoanhThu()
        {
            InitializeComponent();
        }

        private void DoanhThu_Load(object sender, EventArgs e)
        {
            DoanhThuBUS bus = new DoanhThuBUS();
            List<DoanhThuDTO> ds = bus.GetDoanhThuDTOs();
            listViewEx1.Items.Clear();
            foreach (DoanhThuDTO sb in ds)
            {
                ListViewItem lv = new ListViewItem(sb.MaDoanhThu + "");
                lv.SubItems.Add(sb.TongDoanhThu.ToString());
                listViewEx1.Items.Add(lv);
                lv.Tag = sb;
            }

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            ManHinhChinh frm = new ManHinhChinh();
            frm.HoTen = doanhthu;
            this.Hide();
            frm.ShowDialog();
        }
    }
}
