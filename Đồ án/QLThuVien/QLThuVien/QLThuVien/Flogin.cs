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
    public partial class Flogin : Form
    {
        public Flogin()
        {
            InitializeComponent();
            
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_dangnhap_Click(object sender, EventArgs e)
        {
            string TaiKhoan = tb_username.Text;
            string Matkhau = tb_password.Text;
            if (StaffDAO.Instance.Login(TaiKhoan,Matkhau))
            {
                Staff acc = StaffDAO.Instance.GetNhanVienByTaiKhoan(TaiKhoan);
                Manager f = new Manager(acc);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Thông báo" );
            }
        }

        private void Flogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Flogin_Load(object sender, EventArgs e)
        {

        }

        private void checkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShow.Checked)
            {
                tb_password.UseSystemPasswordChar = false;
            }    
            else
            {
                tb_password.UseSystemPasswordChar = true;
            }    
        }
    }
}
