using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyHieuSach
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void panelSach_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //// Tạo instance của ucQuanLySach
            //ucQuanLySach_GUI ucSach = new ucQuanLySach_GUI();

            //// Đặt ucQuanLySach vào panelContent
            //ucSach.Dock = DockStyle.Fill;  // Đảm bảo UserControl chiếm toàn bộ diện tích Panel
            //panelSach.Controls.Clear(); // Xóa các điều khiển cũ trước khi thêm
            //panelSach.Controls.Add(ucSach); // Thêm ucQuanLySach vào panelContent
        }

        private void btnQuanLySach_Click(object sender, EventArgs e)
        {
            ucQuanLySach_GUI ucSach = new ucQuanLySach_GUI();
            ucSach.Dock = DockStyle.Fill;
            panelSach.Controls.Clear(); // Xóa các điều khiển cũ
            panelSach.Controls.Add(ucSach); // Thêm ucQuanLySach mới vào panelContent
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ucQuanLyNhanVien_GUI ucNhanVien = new ucQuanLyNhanVien_GUI();
            ucNhanVien.Dock = DockStyle.Fill;
            panelSach.Controls.Clear(); // Xóa các điều khiển cũ
            panelSach.Controls.Add(ucNhanVien); // Thêm ucQuanLySach mới vào panelContent
        }

        private void btnQuanLyKH_Click(object sender, EventArgs e)
        {
            ucQuanLyKhachHang_GUI ucQuanLyKhachHang = new ucQuanLyKhachHang_GUI();
            ucQuanLyKhachHang.Dock = DockStyle.Fill;
            panelSach.Controls.Clear(); // Xóa các điều khiển cũ
            panelSach.Controls.Add(ucQuanLyKhachHang); // Thêm ucQuanLySach mới vào panelContent
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ucBanSach_GUI ucBanSach_GUI = new ucBanSach_GUI();
            ucBanSach_GUI.Dock = DockStyle.Fill;
            panelSach.Controls.Clear(); // Xóa các điều khiển cũ
            panelSach.Controls.Add(ucBanSach_GUI); // Thêm ucQuanLySach mới vào panelContent
        }
    }
}
