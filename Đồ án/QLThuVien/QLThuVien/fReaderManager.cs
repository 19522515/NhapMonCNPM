using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLThuVien.DTO;
using QLThuVien.DAO;

namespace QLThuVien
{
    public partial class fReaderManager : Form
    {
        Manager PreviousForm;
        public fReaderManager(Manager Previous)
        {
            InitializeComponent();
            PreviousForm = Previous;
            /*Rectangle screen = Screen.FromControl(this).Bounds;
            Width = screen.Width;
            Height = screen.Height; */
            this.Size = new Size(1710, 800);
            //WindowState = FormWindowState.Minimized;
            LoadReader();
        }
        #region Method
        void LoadReader()
        {
            List<Reader> readerList = ReaderDAO.Instance.LoadReaderList();
            foreach (Reader item in readerList)
            {
                ListViewItem lsvItem = new ListViewItem(item.ID.ToString());
                lsvItem.SubItems.Add(item.Name.ToString());
                lsvItem.SubItems.Add(item.Address.ToString());
                lsvItem.SubItems.Add(item.Email.ToString());
                lsvItem.SubItems.Add(item.Job.ToString());
                lsvItem.SubItems.Add(item.Birthday.ToString());
                //lsvItem.SubItems.Add(item.Gender.ToString());
                lsvItem.SubItems.Add(item.PhoneNumber.ToString());
                lsvReader.Items.Add(lsvItem);
            }
        }
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            PreviousForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Readers_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {


        }
    }
}
