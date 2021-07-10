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
    public partial class FChangePassword : Form
    {
        Staff loginaccount;
        private event EventHandler closeForm;
        public event EventHandler CloseForm
        {
            add { closeForm += value; }
            remove { closeForm -= value; }
        }

       
        public FChangePassword(Staff acc)
        {
            loginaccount = acc;
            InitializeComponent();
        }

        void ChangePassword()
        {
            string account = loginaccount.Account;
            string matkhau = loginaccount.Password;
            string pass = tb_pass.Text;
            string newpass = tb_newpass.Text;
            string renewpass = tb_renewpass.Text;
            if (pass.Equals(matkhau))
            {
                if (newpass.Equals(renewpass))
                {
                    if (StaffDAO.Instance.ChangPassByAccount(account, newpass))
                    {
                        if (MessageBox.Show("Đổi mật khẩu thành công, vui lòng đăng nhập lại!", "Thông báo") == System.Windows.Forms.DialogResult.OK) ;
                        {
                            if (closeForm != null)
                            {
                                closeForm(this, new EventArgs());
                            }
                            this.Close();
                        }
                        
                    }    
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu không thành công");                        
                    }    
                }
                else
                {
                    MessageBox.Show("Mật khẩu không khớp nhau, vui lòng nhập lại!");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu không đúng, vui lòng nhập lại mật khẩu!");
            }
        }

        private void FChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_capnhat_Click(object sender, EventArgs e)
        {
            ChangePassword();
        }

        private void lbdangnhap_Click(object sender, EventArgs e)
        {

        }
    }
}
