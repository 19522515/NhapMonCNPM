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
        public Manager()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void xemThôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinTaiKhoan f = new ThongTinTaiKhoan();
            f.Show();
        }

        private void Manager_Load(object sender, EventArgs e)
        {

           
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void mộtSốPhímTắtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýBạnĐộcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Readers f = new Readers(this);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
