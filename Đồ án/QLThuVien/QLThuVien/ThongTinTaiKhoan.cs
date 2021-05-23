using QLThuVien.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien
{
    public partial class ThongTinTaiKhoan : Form
    {
        NhanVien loginaccount;
        public ThongTinTaiKhoan(NhanVien acc)
        {
            InitializeComponent();
            loginaccount = acc;
        }

        private void ThongTinTaiKhoan_Load(object sender, EventArgs e)
        {

            tb_manv.Text = loginaccount.Manv1.ToString();
            tb_tennhanvien.Text = loginaccount.Tennv1.ToString();
            tb_ngaysinh.Text = loginaccount.Ngaysinh1.ToString().Substring(0,9);
            tb_email.Text = loginaccount.Email1.ToString();
            tb_gioitinh.Text = loginaccount.Gioitinh1.ToString();
            tb_sodt.Text = loginaccount.SODT1.ToString();
            tb_taikhoan.Text = loginaccount.TaiKhoan1.ToString();
            if (loginaccount.Type1 == 1)
            {
                tb_chucvu.Text = "Thủ thư";
            }
            else
            {
                tb_chucvu.Text = "Nhân viên";
            }    

        }

        private void tb_manv_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
