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
    public partial class ucQuanLyKhachHang_GUI : UserControl
    {
        private KhachHangBLL khachHangBLL = new KhachHangBLL();
        public ucQuanLyKhachHang_GUI()
        {
            InitializeComponent();
            LoadKhachHang();
        }
        private void LoadKhachHang()
        {
            dgvKhachHang.DataSource = khachHangBLL.LayDanhSachKhachHang();
        }
        private void ClearText()
        {
            txtMaKH.Clear();
            txtHoTen.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                txtMaKH.Text = dgvKhachHang.Rows[i].Cells[0].Value.ToString();
                txtHoTen.Text = dgvKhachHang.Rows[i].Cells[1].Value.ToString();
                txtSDT.Text = dgvKhachHang.Rows[i].Cells[2].Value.ToString();
                txtDiaChi.Text = dgvKhachHang.Rows[i].Cells[3].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            KhachHangDTO kh = new KhachHangDTO()
            {
                MaKhachHang = int.Parse(txtMaKH.Text),
                HoTen = txtHoTen.Text,
                SoDienThoai = txtSDT.Text,

                DiaChi = txtDiaChi.Text
            };
            if (khachHangBLL.ThemKhachHang(kh))
            {
                MessageBox.Show("Thêm thành công");
                LoadKhachHang();
                ClearText();
            }
            else
                MessageBox.Show("Thêm thất bại");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            KhachHangDTO kh = new KhachHangDTO()
            {
                MaKhachHang = int.Parse(txtMaKH.Text),
                HoTen = txtHoTen.Text,
                SoDienThoai = txtSDT.Text,

                DiaChi = txtDiaChi.Text
            };
            if (khachHangBLL.CapNhatKhachHang(kh))
            {
                MessageBox.Show("Sửa thành công");
                LoadKhachHang();
                ClearText();
            }
            else
                MessageBox.Show("Sửa thất bại");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int maKH = int.Parse(txtMaKH.Text);
                if (khachHangBLL.XoaKhachHang(maKH))
                {
                    MessageBox.Show("Xóa thành công");
                    LoadKhachHang();
                    ClearText();
                }
                else
                    MessageBox.Show("Xóa thất bại");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text;
            DataTable dt = khachHangBLL.LayDanhSachKhachHang();

            DataView dv = dt.DefaultView;
            dv.RowFilter = $"HoTen LIKE '%{keyword}%' OR SoDienThoai LIKE '%{keyword}%'";

            dgvKhachHang.DataSource = dv.ToTable();
        }
    }
}
