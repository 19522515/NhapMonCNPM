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
    public partial class Manager : Form
    {

        private NhanVien loginaccount;

        public NhanVien Loginaccount
        {
            get { return loginaccount; }
            set { loginaccount = value; ChangeAccount(loginaccount.Type1); }
        }
        void ChangeAccount(int type)
        {
            xemThôngTinTàiKhoảnToolStripMenuItem.Enabled = (type == 1);
            menustrip_baocaothongke.Enabled = (type == 1);
            menustrip_hethong.Enabled = (type == 1);
            
        }
        public Manager(NhanVien acc)
        {
            this.loginaccount = acc;
            InitializeComponent();
            ChangeAccount(loginaccount.Type1);
            
            
        }

     

        private void xemThôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinTaiKhoan f = new ThongTinTaiKhoan(Loginaccount);
            f.Show();
        }

        private void Manager_Load(object sender, EventArgs e)
        {

           
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lb_tienich_Click(object sender, EventArgs e)
        {

        }

        private void tp_bienbansuco_Click(object sender, EventArgs e)
        {
            
        }
    }
}
