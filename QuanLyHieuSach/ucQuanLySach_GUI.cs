using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;  // Dùng lớp BLL để thực hiện các thao tác với dữ liệu

namespace QuanLyHieuSach
{
    public partial class ucQuanLySach_GUI : UserControl
    {
        // Khai báo đối tượng BLL
        private SachBLL sachBLL = new SachBLL();
        TheLoaiBLL theloaiBLL = new TheLoaiBLL();
        public ucQuanLySach_GUI()
        {
            InitializeComponent();
        }

        private void dataGridViewSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ucQuanLySach_GUI_Load(object sender, EventArgs e)
        {
            LoadDanhSachSach();
            LoadCmbTheLoai();
            LamMoi();
        }
        private void LoadDanhSachSach()
        {
            dgvSach.DataSource = sachBLL.GetDanhSachSach();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int maSach = Convert.ToInt32(txtMaSach.Text); // Mã sách cần sửa
            string tenSach = txtTenSach.Text;
            string tacGia = txtTacGia.Text;
            int maTheLoai = Convert.ToInt32(cmbTheLoai.SelectedValue);
            int namXuatBan = Convert.ToInt32(txtNamXuatBan.Text);
            decimal giaBan = Convert.ToDecimal(txtGiaBan.Text);
            int soLuongTon = Convert.ToInt32(txtSoLuongTon.Text);

            sachBLL.SuaSach(maSach, tenSach, tacGia, maTheLoai, namXuatBan, giaBan, soLuongTon);
            LoadDanhSachSach();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maSach = Convert.ToInt32(txtMaSach.Text);
            sachBLL.XoaSach(maSach);
            LoadDanhSachSach();
        }

        private void dgvSach_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSach.SelectedRows.Count > 0)
            {
                txtMaSach.Text = dgvSach.SelectedRows[0].Cells["MaSach"].Value.ToString();
                txtTenSach.Text = dgvSach.SelectedRows[0].Cells["TenSach"].Value.ToString();
                txtTacGia.Text = dgvSach.SelectedRows[0].Cells["TacGia"].Value.ToString();
                cmbTheLoai.SelectedValue = dgvSach.SelectedRows[0].Cells["MaTheLoai"].Value;
                txtNamXuatBan.Text = dgvSach.SelectedRows[0].Cells["NamXuatBan"].Value.ToString();
                txtGiaBan.Text = dgvSach.SelectedRows[0].Cells["GiaBan"].Value.ToString();
                txtSoLuongTon.Text = dgvSach.SelectedRows[0].Cells["SoLuongTon"].Value.ToString();
            }
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu không phải header
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu của dòng đã chọn
                DataGridViewRow row = dgvSach.Rows[e.RowIndex];

                // Cập nhật thông tin vào các TextBox tương ứng
                txtMaSach.Text = row.Cells["MaSach"].Value.ToString();
                txtTenSach.Text = row.Cells["TenSach"].Value.ToString();
                txtTacGia.Text = row.Cells["TacGia"].Value.ToString();
                txtNamXuatBan.Text = row.Cells["NamXuatBan"].Value.ToString();
                txtGiaBan.Text = row.Cells["GiaBan"].Value.ToString();
                txtSoLuongTon.Text = row.Cells["SoLuongTon"].Value.ToString();
                cmbTheLoai.Text = row.Cells["MaTheLoai"].Value.ToString();
            }
        }

        private void cmbTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void LoadCmbTheLoai()
        {
            cmbTheLoai.DataSource = theloaiBLL.GetAllTheLoai();
            cmbTheLoai.DisplayMember = "MaTheLoai";  // Cái hiển thị
            cmbTheLoai.ValueMember = "MaTheLoai";     // Giá trị lấy ra
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            string tenSach = txtTenSach.Text;
            string tacGia = txtTacGia.Text;
            int maTheLoai = Convert.ToInt32(cmbTheLoai.SelectedValue); // Giả sử có ComboBox cho thể loại
            int namXuatBan = Convert.ToInt32(txtNamXuatBan.Text);
            decimal giaBan = Convert.ToDecimal(txtGiaBan.Text);
            int soLuongTon = Convert.ToInt32(txtSoLuongTon.Text);

            sachBLL.ThemSach(tenSach, tacGia, maTheLoai, namXuatBan, giaBan, soLuongTon);
            LoadDanhSachSach(); // Cập nhật lại danh sách sách
        }
        private void LamMoi()
        {
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtTacGia.Clear();
            txtGiaBan.Clear();
            txtNamXuatBan.Clear();
            txtSoLuongTon.Clear();
            txtTimKiem.Clear();
            cmbTheLoai.SelectedIndex = -1; // Không chọn gì
            dgvSach.DataSource = sachBLL.GetDanhSachSach();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            dgvSach.DataSource = sachBLL.TimKiemSach(keyword);
        }
    }
}
