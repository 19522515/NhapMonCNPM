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
            LoadElements();
        }
        #region Method
        void LoadElements()
        {
            LoadReader();
            AddReaderBinding();
        }
        void LoadReader()
        {
            dtgvReader.DataSource = ReaderDAO.Instance.LoadReaderList();
        }
        void AddReaderBinding()
        {
            txbID.DataBindings.Add(new Binding("Text", dtgvReader.DataSource, "ID"));
            txbBirthday.DataBindings.Add(new Binding("Text", dtgvReader.DataSource, "Birthday"));
            txbName.DataBindings.Add(new Binding("Text", dtgvReader.DataSource, "Name"));
            txbEmail.DataBindings.Add(new Binding("Text", dtgvReader.DataSource, "Email"));
            txbJob.DataBindings.Add(new Binding("Text", dtgvReader.DataSource, "Job"));
            txbAddress.DataBindings.Add(new Binding("Text", dtgvReader.DataSource, "Address"));
            txbPhoneNumber.DataBindings.Add(new Binding("Text", dtgvReader.DataSource, "PhoneNumber"));
            //string ID = (string)dtgvReader.SelectedCells[0].OwningRow.Cells["ID"].Value;
            //LoadSelectedGender(ID);
        }
        void LoadSelectedGender(string id)
        {
            string gender = ReaderDAO.Instance.GetGenderByID(id);
            cbGender.SelectedItem = gender;
        }
        #endregion
        #region Event
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (dtgvReader.SelectedCells.Count > 0)
            {
                string id = (string)dtgvReader.SelectedCells[0].OwningRow.Cells["ID"].Value;
                txbBirthday.Text = id;
                string gender = ReaderDAO.Instance.GetGenderByID(id);
                cbGender.SelectedItem = gender;
                int index = -1;
                int i = 0;
                foreach (string item in cbGender.Items)
                {
                    if (item == gender)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                cbGender.SelectedIndex = index;
            }
        }
        /*private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }*/
        private void button1_Click(object sender, EventArgs e)
        {
            PreviousForm.Show();
            this.Hide();
        }
        #endregion
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
