﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using theloai_dto;
using BLL;

namespace QuanLyHieuSach
{
    public partial class frmThemKhachHang : Form
    {
        KhachHangBLL khBLL = new KhachHangBLL();
        public frmThemKhachHang()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            KhachHangDTO kh = new KhachHangDTO();
            kh.HoTen = txtTenKH.Text.Trim();
            kh.SoDienThoai = txtSDT.Text.Trim();
            kh.DiaChi = txtDiaChi.Text.Trim();

            if (khBLL.ThemKhachHang(kh))
            {
                MessageBox.Show("Thêm khách hàng thành công!");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }
    }
}
