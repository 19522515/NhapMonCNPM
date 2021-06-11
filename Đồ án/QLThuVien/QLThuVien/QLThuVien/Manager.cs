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
    public partial class Manager : Form
    {

        private Staff loginaccount;

        public Staff Loginaccount
        {
            get { return loginaccount; }
            set { loginaccount = value; ChangeAccount(loginaccount.IdPermission); }
        }
       
        public Manager(Staff acc)
        {
            this.loginaccount = acc;
            InitializeComponent();
            ChangeAccount(loginaccount.IdPermission);
            LoadCombobox();
            cb_idReaderBorrow.SelectedIndex = cb_idReaderBorrow.FindStringExact("6");
            load_dgvbillborrow();
            Load_dgv_BillReturn();
            Load_dgv_Payment();
            load_combobox_manager_book();
            load_dgv_mnb();
            load_dgv_manager_reader();
            load_work();
        }


        #region method

        void LoadCombobox()
        {            
            cb_idReaderBorrow.DataSource = ReaderDAO.Instance.GetListReader();
            cb_idReaderBorrow.DisplayMember = "IdReader";
            
            cb_idbookdtbb.DataSource = BookDAO.Instance.GetListBookForcombobox();
            cb_idbookdtbb.DisplayMember = "idBook";

            cb_idReaderReturn.DataSource = ReaderDAO.Instance.GetListReaderFromBillBorrow();
            cb_idReaderReturn.DisplayMember = "IdReader";

            cb_idreaderpayment.DataSource = ReaderDAO.Instance.GetListReader();
            cb_idreaderpayment.DisplayMember = "idreader";

            tb_idstaff.Text = loginaccount.IdStaff.ToString();
        }

        void load_combox_idBookreturn(int id)
        {
            cb_idBookreturn.DataSource = BookDAO.Instance.GetListBookForComboboxDetailBillReturn(id);
            cb_idBookreturn.DisplayMember = "idBook";
        }

        void load_dgvbillborrow()
        {
            dgv_billborrow.DataSource = BillBorrowDAO.Instance.GetListBillBorrow();
            dgv_billborrow.Columns[0].HeaderText = "Mã phiếu mượn";
            dgv_billborrow.Columns[1].HeaderText = "Ngày mượn";
            dgv_billborrow.Columns[2].HeaderText = "Mã độc giả";
        }
       void load_cb_idbillborrow_return()
        {
            
            int idreader = (cb_idReaderReturn.SelectedItem as Reader).IdReader;
            cb_idbillborrow_return.DataSource = BillBorrowDAO.Instance.GetListBillBorrowByIdReader(idreader);
            cb_idbillborrow_return.DisplayMember = "idBillBorrow";
        }
        void ChangeAccount(int type)
        {
            thủThưToolStripMenuItem.Enabled = (type == 1);
        }
        void LoadListBook()
        {
            if (cb_sachby.SelectedItem.ToString().Equals("Mã sách"))
            {
                dgv_listsach.DataSource = BookDAO.Instance.GetListBookByidBook(tb_timkiemsach.Text);
            }    
            else if (cb_sachby.SelectedItem.ToString().Equals("Tên sách"))
            {
                dgv_listsach.DataSource = BookDAO.Instance.GetListBookByNamedBook(tb_timkiemsach.Text);
            }
            else if (cb_sachby.SelectedItem.ToString().Equals("Tên tác giả"))
            {
                dgv_listsach.DataSource = BookDAO.Instance.GetListBookByNameAuthor(tb_timkiemsach.Text);
            }
            else if (cb_sachby.SelectedItem.ToString().Equals("Loại sách"))
            {
                dgv_listsach.DataSource = BookDAO.Instance.GetListBookByCategory(tb_timkiemsach.Text);
            }
        }

        void Load_dgv_DetailBillBorrowByIdBillBorrow(int id)
        {
            dgv_detailbillborrow.DataSource = DetailBillBorrowDAO.Instance.GetDetailBillBorrowByID(id);
            dgv_detailbillborrow.Columns[0].HeaderText = "Mã chi tiết phiếu mượn";
            dgv_detailbillborrow.Columns[1].HeaderText = "Mã sách";
            dgv_detailbillborrow.Columns[2].HeaderText = "Mã phiếu mượn";
            dgv_detailbillborrow.Columns[3].HeaderText = "Tình trạng phiếu mượn";
        }
        void Load_dgv_BillReturn()
        {
            dgv_billreturn.DataSource = BillReturnDAO.Instance.GetListBillReturn();
            dgv_billreturn.Columns[0].HeaderText = "Mã phiếu trả";
            dgv_billreturn.Columns[1].HeaderText = "Mã độc giả";
            dgv_billreturn.Columns[2].HeaderText = "Ngày trả";
            dgv_billreturn.Columns[3].HeaderText = "Tổng tiền phạt";
        }

        void InsertBillBorrow()
        {
            DateTime date = dtp_borrow.Value;
            int idReader = (cb_idReaderBorrow.SelectedItem as Reader).IdReader;
            bool result = BillBorrowDAO.Instance.InsertBillBorrow(date, idReader);
            if (result)
            {
                MessageBox.Show("Thêm phiếu mượn thành công", "Thông báo");
            }    
            else
            {
                MessageBox.Show("Thêm phiếu mượn không thành công", "Thông báo");
            }    
        }
        void InsertBillReturn()
        {
            DateTime datereturn = Convert.ToDateTime(dtp_datereturn.Value);
            int idreader = (cb_idReaderReturn.SelectedItem as Reader).IdReader;
            bool result = BillReturnDAO.Instance.InsertBillReturn(idreader, datereturn);
            if (result)
            {
                MessageBox.Show("Thêm phiếu trả thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm phiếu trả không thành công", "Thông báo");
            }
        }

        void Load_dgv_detailbillreturn()
        {
            int idbillreturn = Convert.ToInt32(tb_idBillReturn.Text);
            dgv_detailbillreturn.DataSource = DetailBillReturnDAO.Instance.GetTableDetailBillReturnByIdBillReturn(idbillreturn);
            dgv_detailbillreturn.Columns[0].HeaderText = "Mã CT phiếu trả";
            dgv_detailbillreturn.Columns[1].HeaderText = "Mã sách";
            dgv_detailbillreturn.Columns[2].HeaderText = "Mã phiếu trả";
            dgv_detailbillreturn.Columns[3].HeaderText = "Mã phiếu mượn";
            dgv_detailbillreturn.Columns[4].HeaderText = "Tiền phạt";
            



        }

        void InsertDetailBillReturn()
        {
            if (string.IsNullOrEmpty(tb_idbillreturn2.Text))
            {
                MessageBox.Show("Vui lòng chọn phiếu trả");
            }
            else
            {
                int IdBillReturn = Convert.ToInt32(tb_idbillreturn2.Text);
                if ((cb_idBookreturn.SelectedItem as Book) == null)
                {
                    MessageBox.Show("Thêm chi tiết phiếu trả không thành công", "Thông báo");
                    return;
                }
                int IdBook = Convert.ToInt32((cb_idBookreturn.SelectedItem as Book).IdBook);
                int IdBillBorrow = (cb_idbillborrow_return.SelectedItem as BillBorrow).IdBillBorrow;
                int fine = Convert.ToInt32((num_fine.Value));

                if (DetailBillReturnDAO.Instance.InsertDetailBillReturn(IdBillReturn, IdBook, IdBillBorrow, fine))
                {
                    MessageBox.Show("Thêm chi tiết phiếu trả thành công");
                }
                else
                {
                    MessageBox.Show("Thêm chi tiết phiếu trả không thành công", "Thông báo");
                }
            }
        }

       void InsertPayment()
        {
            int idStaff = Convert.ToInt32(tb_idstaff.Text);
            int idReader = (cb_idreaderpayment.SelectedItem as Reader).IdReader;
            int Debt = (cb_idreaderpayment.SelectedItem as Reader).Debt;
            int MoneyPayment = Convert.ToInt32(sum_moneypayment.Value);
            DateTime datepayment = dtp_payment.Value;
            string note;
            if (tb_notepayment.Text != null)
            {
                 note = tb_notepayment.Text;
            }    
            else
            {
                 note = " ";
            }    

            if (MoneyPayment> Debt)
            {
                MessageBox.Show("Số tiền thanh toán không được lớn hơn số tiền độc giả đang nợ", "Thông báo");
            }    
            else
            {
                if (PaymentDAO.Instance.InsertPayment(idStaff, idReader, MoneyPayment,datepayment,note))
                {
                    MessageBox.Show("Thanh toán thành công");
                }    
                else
                {
                    MessageBox.Show("Thanh toán không thành công");
                }    
            }    
        }
        void Load_dgv_Payment()
        {
            dgv_payment.DataSource = PaymentDAO.Instance.GetListPayment();

        }

        void load_combobox_manager_book()
        {
            cb_categorybook_mnb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb_categorybook_mnb.DisplayMember = "Namecategory";

            cb_publisher_mnb.DataSource = PublisherDAO.Instance.GetListPublisher();
            cb_publisher_mnb.DisplayMember = "namePublisher";

            cb_author_mnb.DataSource = AuthorDAO.Instance.GetListAuthor();
            cb_author_mnb.DisplayMember = "nameAuthor";
        }

        void insertBook()
        {
            string namebook = tb_namebook_mnb.Text;
            DateTime datepub = Convert.ToDateTime(dtp_datepublisher_mnb.Value.ToString().Substring(0,9));
            DateTime dateadd = dtp_dateaddbook_mnb.Value;
            int value = Convert.ToInt32(num_valuebook_mnb.Value);
            string ISBN = tb_isbn.Text;
            int idcate = (cb_categorybook_mnb.SelectedItem as Category).IdCategory;
            int idpu = (cb_publisher_mnb.SelectedItem as Publisher).IdPublisher;
            int idauthor = (cb_author_mnb.SelectedItem as Author).IdAuthor;
            if (BookDAO.Instance.InsertBook(namebook, datepub, dateadd, value, ISBN, idcate, idpu, idauthor))
            {
                MessageBox.Show("Thêm sách thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm sách không thành công", "Thông báo");
            }    
        }
        void load_dgv_mnb()
        {
            dgv_mnb.DataSource = BookDAO.Instance.GetListBook();
        }

        void delBook()
        {
            int idbook = Convert.ToInt32(tb_idbook_mnb.Text);
            int idAuthor = (cb_author_mnb.SelectedItem as Author).IdAuthor;
            if(BookDAO.Instance.delBook(idbook, idAuthor))
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Xóa không thành công", "Thông báo");
            }    
        }

        void updatebook()
        {
            int idbook = Convert.ToInt32(tb_idbook_mnb.Text);
            string namebook = tb_namebook_mnb.Text;
            DateTime datepub = Convert.ToDateTime(dtp_datepublisher_mnb.Value.ToString().Substring(0, 9));
            DateTime dateadd = dtp_dateaddbook_mnb.Value;
            int value = Convert.ToInt32(num_valuebook_mnb.Value);
            string ISBN = tb_isbn.Text;
            int idcate = (cb_categorybook_mnb.SelectedItem as Category).IdCategory;
            int idpu = (cb_publisher_mnb.SelectedItem as Publisher).IdPublisher;
            int idauthor = (cb_author_mnb.SelectedItem as Author).IdAuthor;
            if (BookDAO.Instance.updateBook(idbook, namebook, datepub, dateadd, value, ISBN, idcate, idpu, idauthor))
            {
                MessageBox.Show("Cập nhật sách thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Cập nhật sách không thành công", "Thông báo");
            }    

        }

        void insertReader()
        {
            string name = tb_namereader_mnr.Text;
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Vui lòng nhập tên độc giả");
            }
            else
            {
                string address = tb_address_mnr.Text;
                string email = tb_email_mnr.Text;
                int idwork = (cb_work_mnr.SelectedItem as Work).IdWork;
                DateTime dob = Convert.ToDateTime(dtp_bob_mnr.Value.ToString().Substring(0, 9));
                string sex = cb_sex_mnr.Text;
                string phone = tb_phone_mnr.Text;
                DateTime datecreate = dtp_datecreate_mnr.Value;
                int debt = Convert.ToInt32(num_debt.Value);
                List<ParaMeters> list = ParameterDAO.Instance.GetListParameter();
                DateTime today = DateTime.Now;
                int age = Convert.ToInt32(today.Year) - Convert.ToInt32(dob.Year);
                if (age < list[0].ValueParameter || age > list[1].ValueParameter)
                {
                    MessageBox.Show("Độ tuổi không phù hợp");
                }
                else
                {

                    if (ReaderDAO.Instance.InsertReader(name, address, email, idwork, dob, sex, phone, datecreate, debt))
                    {
                        MessageBox.Show("Thêm độc giả thành công", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Thêm độc giả không thành công", "Thông báo");
                    }
                }
            }
        }

        void updateReader()
        {
            
            string idreader = tb_idreader_mnr.Text;
            if (string.IsNullOrWhiteSpace(idreader))
            {
                MessageBox.Show("Vui lòng chọn độc giả cần cập nhật");
            }
            else
            {
                int idreader2 = Convert.ToInt32(idreader);
                string name = tb_namereader_mnr.Text;
                string address = tb_address_mnr.Text;
                string email = tb_email_mnr.Text;
                int idwork = (cb_work_mnr.SelectedItem as Work).IdWork;
                DateTime dob = Convert.ToDateTime(dtp_bob_mnr.Value.ToString().Substring(0, 9));
                string sex = cb_sex_mnr.Text;
                string phone = tb_phone_mnr.Text;
                DateTime datecreate = dtp_datecreate_mnr.Value;
                int debt = Convert.ToInt32(num_debt.Value);

                if (ReaderDAO.Instance.updateReader(idreader2, name, address, email, idwork, dob, sex, phone, datecreate, debt))
                {
                    MessageBox.Show("Cập nhật độc giả thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Cập nhật độc giả không thành công", "Thông báo");
                }
            }
        }
        void load_work()
        {
            cb_work_mnr.DataSource = WorkDAO.Instance.GetListWork();
            cb_work_mnr.DisplayMember = "typework";
        }
        

        void load_dgv_manager_reader()
        {
            dgv_manager_reader.DataSource = ReaderDAO.Instance.GetListReader2();
            dgv_manager_reader.Columns[0].HeaderText = "Mã độc giả";
            dgv_manager_reader.Columns[1].HeaderText = "Họ tên";
            dgv_manager_reader.Columns[2].HeaderText = "Địa chỉ ";
            dgv_manager_reader.Columns[3].HeaderText = "Email";
            dgv_manager_reader.Columns[4].HeaderText = "Công việc";
            dgv_manager_reader.Columns[5].HeaderText = "Ngày sinh";
            dgv_manager_reader.Columns[6].HeaderText = "Giới tính";
            dgv_manager_reader.Columns[7].HeaderText = "Số điện thoại";
            dgv_manager_reader.Columns[8].HeaderText = "Ngày tạo thẻ";
            dgv_manager_reader.Columns[9].HeaderText = "Số nợ";


        }

        void deleteReader()
        {
            if (string.IsNullOrWhiteSpace(tb_idreader_mnr.Text))
            {
                MessageBox.Show("Vui lòng chọn độc giả cần xóa");
            }
            else
            {
                int idreader = Convert.ToInt32(tb_idreader_mnr.Text);
                if (ReaderDAO.Instance.deleteReader(idreader))
                {
                    MessageBox.Show("Xóa độc giả thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Xóa độc giả không thành công", "Thông báo");
                }
            }
        }

        void deletedetailbillreturn()
        {
            int id = Convert.ToInt32(tb_iddetailbillreturn.Text);
            if (DetailBillReturnDAO.Instance.DeleteDetailBillReturn(id))
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
            }    
            else
            {
                MessageBox.Show("Xóa không thành công", "Thông báo");
            }    
        }

        #endregion



        #region event

        private void xemThôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinTaiKhoan f = new ThongTinTaiKhoan(Loginaccount);
            f.Show();
            f.CloseForm += f_close;         
        }
        void f_close(object sender, EventArgs e)
        {
            this.Close();
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

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FChangePassword f = new FChangePassword(Loginaccount);
            f.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        

        private void bt_timkiemsach_Click(object sender, EventArgs e)
        {
            if (cb_sachby.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn loại tìm kiếm");
            }
            else if (tb_timkiemsach.Text == "")
            {
                dgv_listsach.DataSource = BookDAO.Instance.GetListBook();
            }    
            else
            {
                LoadListBook();
            }
        }

        private void menuStrip_manager_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_addBillBorrow_Click(object sender, EventArgs e)
        {
            InsertBillBorrow();
            load_dgvbillborrow();
            LoadCombobox();
        }

        private void dgv_billborrow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                DataGridViewRow row = dgv_billborrow.Rows[e.RowIndex];
                tb_idBillBorrow2.Text = row.Cells[0].Value.ToString();
                tb_idbillBorrow.Text = row.Cells[0].Value.ToString();
                cb_idReaderBorrow.Text = row.Cells[2].Value.ToString();
                dtp_borrow.Value = Convert.ToDateTime(row.Cells[1].Value);
                int id = Convert.ToInt32(row.Cells[0].Value);
                Load_dgv_DetailBillBorrowByIdBillBorrow(id);
            }
        }

        private void bt_adddetailBillBorrow_Click(object sender, EventArgs e)
        {   
            int idbillborrow = Convert.ToInt32(tb_idBillBorrow2.Text);
            int idbook = (cb_idbookdtbb.SelectedItem as Book).IdBook;
            if (DetailBillBorrowDAO.Instance.InsertDetailBillBorrow(idbook, idbillborrow))
            {
                MessageBox.Show("Thêm chi tiết phiếu mượn thành công", "Thông báo");
                Load_dgv_DetailBillBorrowByIdBillBorrow(idbillborrow);
                LoadCombobox();
            }    
            else
            {
                MessageBox.Show("Thêm chi tiết phiếu mượn không thành công", "Thông báo");
            }    
        }

        private void dgv_detailbillborrow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                DataGridViewRow row = dgv_detailbillborrow.Rows[e.RowIndex];
                tb_idbilldetailborrow.Text = row.Cells[0].Value.ToString();
                cb_idbookdtbb.Text = row.Cells[1].Value.ToString();
                if (row.Cells[3].Value.ToString() == "1")
                {
                    tb_idsttBBorrow.Text = "Chưa trả";
                }
                else
                {
                    tb_idsttBBorrow.Text = "Đã trả";
                }
            }
        }

        private void bt_addbillreturn_Click(object sender, EventArgs e)
        {
            InsertBillReturn();
            Load_dgv_BillReturn();           
        }

        private void dgv_billreturn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_billreturn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                DataGridViewRow row = dgv_billreturn.Rows[e.RowIndex];
                tb_idBillReturn.Text = row.Cells[0].Value.ToString();
                tb_sumfine.Text = row.Cells[3].Value.ToString();
                cb_idReaderReturn.Text = row.Cells[1].Value.ToString();
                tb_idbillreturn2.Text = row.Cells[0].Value.ToString();
                dtp_datereturn.Value = Convert.ToDateTime(row.Cells[2].Value);
                load_cb_idbillborrow_return();
                Load_dgv_detailbillreturn();
                int idbillreturn = Convert.ToInt32(tb_idbillreturn2.Text);
                int idbillborrow = (cb_idbillborrow_return.SelectedItem as BillBorrow).IdBillBorrow;
                DateTime dateborrow = BillBorrowDAO.Instance.GetBillBorrowByIDBillBorrow(idbillborrow).Borrowdate1;
                DateTime datereturn = BillReturnDAO.Instance.GetBillReturnByIDBillReturn(idbillreturn).Returndate;
                dateborrow = Convert.ToDateTime(dateborrow.ToString().Substring(0, 9));
                datereturn = Convert.ToDateTime(datereturn.ToString().Substring(0, 9));
                TimeSpan a = datereturn - dateborrow;
                int time = (int)a.TotalMinutes / 1440;
                List<ParaMeters> list = ParameterDAO.Instance.GetListParameter();
                if ((time - list[2].ValueParameter) > 0)
                {
                    int sum = (time - list[2].ValueParameter) * list[3].ValueParameter;
                    num_fine.Value = sum;
                }
                else
                {
                    int sum = 0;
                    num_fine.Value = sum;
                }

            }
        }
        

        private void quyĐịnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FParameter f = new FParameter();
            f.Show();
        }

        private void cb_idbillborrow_return_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (cb_idbillborrow_return.SelectedItem as BillBorrow).IdBillBorrow;
            load_combox_idBookreturn(id);
        }

        private void cb_idBookreturn_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        

        private void bt_adddetailbillreturn_Click(object sender, EventArgs e)
        {

            InsertDetailBillReturn();
            Load_dgv_detailbillreturn();
            load_cb_idbillborrow_return();
            int id = (cb_idbillborrow_return.SelectedItem as BillBorrow).IdBillBorrow;
            load_combox_idBookreturn(id);
            Load_dgv_BillReturn();            
        }


        private void dgv_detailbillreturn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if( e.RowIndex == -1)
            {
                return;
            }
            else 
            {
                DataGridViewRow row = dgv_detailbillreturn.Rows[e.RowIndex];
                tb_iddetailbillreturn.Text = row.Cells[0].Value.ToString();
                tb_idBillReturn.Text = row.Cells[2].Value.ToString();
                cb_idBookreturn.Text = row.Cells[1].Value.ToString();
                cb_idbillborrow_return.Text = row.Cells[3].Value.ToString();
                num_fine.Value = Convert.ToInt32(row.Cells[4].Value);
            }
        }

        #endregion

        private void bt_thanhtoan_Click(object sender, EventArgs e)
        {
            InsertPayment();
            Load_dgv_Payment();
            load_dgv_manager_reader();
            Load_dgv_BillReturn();
        }

        private void bt_addbook_Click(object sender, EventArgs e)
        {
            insertBook();
            load_dgv_mnb();
            LoadCombobox();
        }

        private void dgv_mnb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                DataGridViewRow row = dgv_mnb.Rows[e.RowIndex];
                tb_idbook_mnb.Text = row.Cells[0].Value.ToString();
                tb_namebook_mnb.Text = row.Cells[1].Value.ToString();
                cb_author_mnb.Text = row.Cells[2].Value.ToString();
                cb_publisher_mnb.Text = row.Cells[3].Value.ToString();
                dtp_datepublisher_mnb.Value = Convert.ToDateTime(row.Cells[4].Value);
                dtp_dateaddbook_mnb.Value = Convert.ToDateTime(row.Cells[5].Value);
                num_valuebook_mnb.Value = Convert.ToInt32(row.Cells[6].Value);
                tb_isbn.Text = row.Cells[7].Value.ToString();
                tb_sttbook_mnb.Text = row.Cells[9].Value.ToString();
                cb_categorybook_mnb.Text = row.Cells[8].Value.ToString();
            }
        }

        private void bt_deletebook_Click(object sender, EventArgs e)
        {
            delBook();
            load_dgv_mnb();
            LoadCombobox();
            
        }

        private void bt_updatebook_Click(object sender, EventArgs e)
        {
            updatebook();
            load_dgv_mnb();
            LoadCombobox();
        }

        private void bt_add_mnr_Click(object sender, EventArgs e)
        {
            insertReader();
            load_dgv_manager_reader();
            LoadCombobox();
            
        }

        private void bt_update_mnr_Click(object sender, EventArgs e)
        {
            updateReader();
            load_dgv_manager_reader();
            LoadCombobox();
        }

        private void dgv_manager_reader_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }    
            else
            {
                DataGridViewRow row = dgv_manager_reader.Rows[e.RowIndex];
                tb_idreader_mnr.Text = row.Cells[0].Value.ToString();
                tb_namereader_mnr.Text = row.Cells[1].Value.ToString();
                tb_address_mnr.Text = row.Cells[2].Value.ToString();
                tb_email_mnr.Text = row.Cells[3].Value.ToString();
                cb_work_mnr.Text = row.Cells[4].Value.ToString();
                dtp_bob_mnr.Value = Convert.ToDateTime(row.Cells[5].Value);
                cb_sex_mnr.Text = row.Cells[6].Value.ToString();
                tb_phone_mnr.Text = row.Cells[7].Value.ToString();
                dtp_datecreate_mnr.Value = Convert.ToDateTime(row.Cells[8].Value);
                num_debt.Value = Convert.ToInt32(row.Cells[9].Value);

            }    
        }

        private void bt_del_mnr_Click(object sender, EventArgs e)
        {
            deleteReader();
            LoadCombobox();
            load_dgv_manager_reader();
            load_dgvbillborrow();
            Load_dgv_BillReturn();

        }

        private void quảnLýNhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FManagerStaff f = new FManagerStaff(loginaccount);
            f.ShowDialog();
        }

        private void bt_deletedetailbillreturn_Click(object sender, EventArgs e)
        {
            deletedetailbillreturn();
            load_dgvbillborrow();
            Load_dgv_BillReturn();
            Load_dgv_detailbillreturn();
        }

        private void báoCáoThốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report f = new Report();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        
    }
}
