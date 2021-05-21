using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.DTO
{
    public class NhanVien
    {
        public NhanVien() {  }
        public NhanVien(string Manv, string Tennv, DateTime Ngaysinh, string Email, string Gioitinh, string SODT, string TaiKhoan, string MatKhau, int Type)
        {
            this.Manv = Manv;
            this.Tennv = Tennv;
            this.Ngaysinh = Ngaysinh;
            this.Email = Email;
            this.Gioitinh = Gioitinh;
            this.SODT = SODT;
            this.TaiKhoan = TaiKhoan;
            this.MatKhau = MatKhau;
            this.Type = Type;
        }

        public NhanVien(DataRow row)
        {
            this.Manv = row["MANV"].ToString();
            this.Tennv = row["TENNV"].ToString();
            this.Ngaysinh = Convert.ToDateTime(row["NGAYSINH"]);
            this.Email = row["EMAIL"].ToString();
            this.Gioitinh = row["GIOITINH"].ToString();
            this.SODT = row["SODT"].ToString();
            this.TaiKhoan = row["TAIKHOAN"].ToString();
            this.MatKhau = row["MATKHAU"].ToString();
            this.Type = (int)row["TYPE"];
        }

        string Manv;
        string Tennv;
        DateTime Ngaysinh;
        string Email;
        string Gioitinh;
        string SODT;
        string TaiKhoan;
        string MatKhau;
        int Type;

        public string Manv1 { get => Manv; set => Manv = value; }
        public string Tennv1 { get => Tennv; set => Tennv = value; }
        public DateTime Ngaysinh1 { get => Ngaysinh; set => Ngaysinh = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string Gioitinh1 { get => Gioitinh; set => Gioitinh = value; }
        public string SODT1 { get => SODT; set => SODT = value; }
        public string TaiKhoan1 { get => TaiKhoan; set => TaiKhoan = value; }
        public string MatKhau1 { get => MatKhau; set => MatKhau = value; }
        public int Type1 { get => Type; set => Type = value; }
    }
}
