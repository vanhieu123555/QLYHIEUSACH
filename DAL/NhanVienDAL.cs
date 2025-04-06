using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using theloai_dto;

namespace DAL
{
    public class NhanVienDAL
    {
        DataProvider dp = new DataProvider();

        public bool KiemTraDangNhap(string email, string matkhau)
        {
            string query = "SELECT COUNT(*) FROM NhanVien WHERE Email = @Email AND MatKhau = @MatKhau";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@Email", email),
                new SqlParameter("@MatKhau", matkhau)
            };

            object result = dp.ExecuteScalar(query, parameters.ToArray());
            int count = (result == null || result == DBNull.Value) ? 0 : Convert.ToInt32(result);

            return count > 0;
        }
        public DataTable LayDanhSachNhanVien()
        {
            string query = "SELECT * FROM NhanVien";
            return DataProvider.ExecuteQuery(query);
        }
        public bool ThemNhanVien(NhanVienDTO nv)
        {
            string query = "INSERT INTO NhanVien VALUES (@HoTen, @SoDienThoai, @Email, @ChucVu, @MatKhau, @MaVaiTro)";
            SqlParameter[] parameters = {
            new SqlParameter("@MaNhanVien", nv.MaNhanVien),
            new SqlParameter("@HoTen", nv.HoTen),
            new SqlParameter("@SoDienThoai", nv.SoDienThoai),
            new SqlParameter("@Email", nv.Email),
            new SqlParameter("@ChucVu", nv.ChucVu),
            new SqlParameter("@MatKhau", nv.MatKhau),
            new SqlParameter("@MaVaiTro", nv.MaVaiTro)
        };
            return DataProvider.ExecuteNonQuery(query, parameters) > 0;
        }
        public bool XoaNhanVien(int maNV)
        {
            string query = "DELETE FROM NhanVien WHERE MaNhanVien = @MaNV";
            SqlParameter[] parameters = { new SqlParameter("@MaNV", maNV) };
            return DataProvider.ExecuteNonQuery(query, parameters) > 0;
        }
        public bool CapNhatNhanVien(NhanVienDTO nv)
        {
            string query = "UPDATE NhanVien SET HoTen=@HoTen, SoDienThoai=@SoDienThoai, Email=@Email, ChucVu=@ChucVu, MatKhau=@MatKhau, MaVaiTro=@MaVaiTro WHERE MaNhanVien=@MaNV";
            SqlParameter[] parameters = {
            new SqlParameter("@MaNV", nv.MaNhanVien),
            new SqlParameter("@HoTen", nv.HoTen),
            new SqlParameter("@SoDienThoai", nv.SoDienThoai),
            new SqlParameter("@Email", nv.Email),
            new SqlParameter("@ChucVu", nv.ChucVu),
            new SqlParameter("@MatKhau", nv.MatKhau),
            new SqlParameter("@MaVaiTro", nv.MaVaiTro),
            new SqlParameter("@MaNV", nv.MaNhanVien)
        };
            return DataProvider.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}
