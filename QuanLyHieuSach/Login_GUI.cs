using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace QuanLyHieuSach
{
    public partial class frmDangNhap : Form
    {
        NhanVienBLL bllNV = new NhanVienBLL();

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string email = txtTaiKhoan.Text;
            string matkhau = txtMatKhau.Text;

            if (bllNV.DangNhap(email, matkhau))
            {
                MessageBox.Show("Đăng nhập thành công!");
                this.Hide();
                frmMain frm = new frmMain(); // Mở form chính
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {           
            txtTaiKhoan.Text = "chu@hieusach.com"; // Đặt sẵn tài khoản
            txtMatKhau.Text = "1234"; // Đặt sẵn mật khẩu
            txtMatKhau.UseSystemPasswordChar = false; // Hiện mật khẩu để dễ copy
        }
    }
}
