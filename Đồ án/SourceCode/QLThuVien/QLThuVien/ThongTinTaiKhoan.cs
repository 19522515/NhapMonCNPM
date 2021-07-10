using QLThuVien.DAO;
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
        Staff loginaccount;

        private event EventHandler closeForm;
        public event EventHandler CloseForm
        {
            add { closeForm += value; }
            remove { closeForm -= value; }
        }
        public ThongTinTaiKhoan(Staff acc)
        {
            InitializeComponent();
            loginaccount = acc;
            load_infor();
        }

        private void ThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
                    

        }
        void load_infor()
        {
            tb_manv.Text = loginaccount.IdStaff.ToString();
            tb_tennhanvien.Text = loginaccount.NameStaff;
            tb_ngaysinh.Text = loginaccount.DobStaff.ToString().Substring(0,9);
            tb_diachi.Text = loginaccount.AddressStaff;
            tb_email.Text = loginaccount.EmailStaff;
            tb_gioitinh.Text = loginaccount.SexStaff;
            tb_sodt.Text = loginaccount.PhonenumberStaff;
            tb_taikhoan.Text = loginaccount.Account;
            tb_chucvu.Text = StaffDAO.Instance.GePermissionByIdPermission(loginaccount.IdPermission).NamePermission;
        }

        private void bt_capnhat_Click(object sender, EventArgs e)
        {
            
            FChangePassword f = new FChangePassword(loginaccount);
            this.Hide();          
            f.Show();
            f.CloseForm += f_close;

        }
       void f_close(object sender, EventArgs e)
        {
            if (closeForm != null)
            {
                closeForm(this, new EventArgs());
            }
            this.Close();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
