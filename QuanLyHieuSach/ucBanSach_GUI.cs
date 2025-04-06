using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using theloai_dto;

namespace QuanLyHieuSach
{
    public partial class ucBanSach_GUI : UserControl
    {
        KhachHangBLL khBLL = new KhachHangBLL();
        NhanVienBLL nvBLL = new NhanVienBLL();
        SachBLL sachBLL = new SachBLL();

        public ucBanSach_GUI()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void LoadKhachHang()
        {
            cboKhachHang.DataSource = khBLL.LayDanhSachKhachHang();  // Trả về DataTable/List
            cboKhachHang.DisplayMember = "TenKhachHang";
            cboKhachHang.ValueMember = "MaKhachHang";
        }
        private void LoadNhanVien()
        {
            cboNhanVien.DataSource = nvBLL.LayDanhSachNhanVien();  // Trả về DataTable/List
            cboNhanVien.DisplayMember = "TenNhanVien";
            cboNhanVien.ValueMember = "MaNhanVien";
        }
        private void LoadSach()
        {
            
            cboSach.DataSource = sachBLL.GetDanhSachSach();
            cboSach.DisplayMember = "TenSach";
            cboSach.ValueMember = "MaSach";
        }


        private void ucBanSach_GUI_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
            LoadNhanVien();
            LoadSach();
            ResetForm();
        }

        private void btnKhachMoi_Click(object sender, EventArgs e)
        {
            frmThemKhachHang frm = new frmThemKhachHang();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadKhachHang();  // Load lại danh sách khách hàng sau khi thêm
            }
        }

        private void btnThemVaoGio_Click(object sender, EventArgs e)
        {
            int maSach = Convert.ToInt32(cboSach.SelectedValue);
            string tenSach = cboSach.Text;
            int soLuong = Convert.ToInt32(txtSoLuong.Text);
            decimal donGia = sachBLL.LayDonGia(maSach);
            decimal thanhTien = soLuong * donGia;

            // Thêm vào DataGridView
            dgvGioHang.Rows.Add(maSach, tenSach, soLuong, donGia, thanhTien);

            TinhTongTien();
        }
        private void TinhTongTien()
        {
            decimal tongTien = 0;
            foreach (DataGridViewRow row in dgvGioHang.Rows)
            {
                tongTien += Convert.ToDecimal(row.Cells["ThanhTien"].Value);
            }
            lblTongTien.Text = tongTien.ToString("N0") + " VNĐ";
        }
        private void ResetForm()
        {
            dgvGioHang.Rows.Clear();
            lblTongTien.Text = "0 VNĐ";
            txtSoLuong.Clear();
            cboSach.SelectedIndex = 0;
            cboKhachHang.SelectedIndex = 0;
        }


        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            HoaDonDTO hd = new HoaDonDTO();
            hd.MaKhachHang = Convert.ToInt32(cboKhachHang.SelectedValue);
            hd.MaNhanVien = maNhanVienDangNhap; // lấy mã nhân viên đăng nhập
            hd.NgayLap = DateTime.Now;
            hd.TongTien = LayTongTien();

            int maHD = hoaDonBLL.ThemHoaDon(hd); // Trả về mã hóa đơn mới tạo

            foreach (DataGridViewRow row in dgvGioHang.Rows)
            {
                ChiTietHoaDonDTO ct = new ChiTietHoaDonDTO();
                ct.MaHoaDon = maHD;
                ct.MaSach = Convert.ToInt32(row.Cells["MaSach"].Value);
                ct.SoLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                ct.DonGia = Convert.ToDecimal(row.Cells["DonGia"].Value);

                chiTietHoaDonBLL.ThemChiTietHoaDon(ct);
            }

            MessageBox.Show("Thanh toán thành công!");
            ResetForm();
        }
    }
}
