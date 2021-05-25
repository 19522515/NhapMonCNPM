﻿using System;
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
            LoadBindingData();
            LoadHeading();
        }
        void LoadReader()
        {
            dtgvReader.DataSource = ReaderDAO.Instance.LoadReaderList();
        }
        void LoadHeading()
        {
            dtgvReader.Columns[0].HeaderText = "Mã Độc Giả";
            dtgvReader.Columns[1].HeaderText = "Tên Độc Giả";
            dtgvReader.Columns[2].HeaderText = "Địa Chỉ";
            dtgvReader.Columns[3].HeaderText = "Công Việc";
            dtgvReader.Columns[4].HeaderText = "Email";
            dtgvReader.Columns[5].HeaderText = "Giới Tính";
            dtgvReader.Columns[6].HeaderText = "Số điện thoại";
            dtgvReader.Columns[7].HeaderText = "Ngày sinh";
        }
        void LoadBindingData()
        {
            txbID.DataBindings.Add(new Binding("Text", dtgvReader.DataSource, "ID"));
            dtpBirdthday.DataBindings.Add(new Binding("Text", dtgvReader.DataSource, "Birthday"));
            txbName.DataBindings.Add(new Binding("Text", dtgvReader.DataSource, "Name"));
            txbEmail.DataBindings.Add(new Binding("Text", dtgvReader.DataSource, "Email"));
            txbJob.DataBindings.Add(new Binding("Text", dtgvReader.DataSource, "Job"));
            txbAddress.DataBindings.Add(new Binding("Text", dtgvReader.DataSource, "Address"));
            txbPhoneNumber.DataBindings.Add(new Binding("Text", dtgvReader.DataSource, "PhoneNumber"));
            cbGender.DataBindings.Add(new Binding("Text", dtgvReader.DataSource, "Gender"));
        }
        void clearBindingData()
        {
            txbID.DataBindings.Clear();
            txbName.DataBindings.Clear();
            txbEmail.DataBindings.Clear();
            dtpBirdthday.DataBindings.Clear();
            txbJob.DataBindings.Clear();
            txbAddress.DataBindings.Clear();
            txbPhoneNumber.DataBindings.Clear();
            cbGender.DataBindings.Clear();
        }
        void ClearReaderCard()
        {
            clearBindingData();
            // add auto increment ID
            int IDNumber = ReaderDAO.Instance.GetLastIDNumber() + 1;
            string IDPrefix = "";
            if (IDNumber >0)
            {
                IDPrefix = "DG00";
            } else if (IDNumber >=100)
            {
                IDPrefix= "DG0";
            } else
            {
                IDPrefix = "DG";
            }
            string ID = IDPrefix + IDNumber.ToString();
            txbID.Text = ID;
            txbID.ReadOnly = true;
            dtpBirdthday.Value = new DateTime(2000,01,01);
            txbName.Text = "";
            txbEmail.Text = "";
            txbJob.Text = "";
            txbAddress.Text = "";
            txbPhoneNumber.Text = "";
            cbGender.Text="Chọn";
        }
        void OnAddReader()
        {
            int result= ReaderDAO.Instance.InsertReader(txbID.Text, txbName.Text, txbAddress.Text, txbJob.Text, txbEmail.Text, cbGender.Text,txbPhoneNumber.Text, dtpBirdthday.Value);
            dtgvReader.DataSource= ReaderDAO.Instance.LoadReaderList();
            ClearReaderCard();
        }
        #endregion
        #region Event
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }
            private void button1_Click(object sender, EventArgs e)
        {
            PreviousForm.Show();
            this.Hide();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.ReadOnly = false;
            LoadBindingData();
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

        
        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txbAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txbID.ReadOnly == true)
            {
                OnAddReader();
            }
            else
            {
                labelCard.Text = "Thêm độc giả";
                ClearReaderCard();
            }
        }

        private void dtpBirdthday_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
