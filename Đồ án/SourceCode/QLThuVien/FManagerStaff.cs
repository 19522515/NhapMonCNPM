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
    public partial class FManagerStaff : Form
    {
        private Staff loginaccount;
        public FManagerStaff(Staff loginaccount)
        {
            InitializeComponent();
            load_dgv();
            cb_permission.DataSource = PermissionDAO.Instance.GetListPermission();
            cb_permission.DisplayMember = "namePermission";
            DateTime date1 = new DateTime(2000, 1, 1);
            dtp_dob.Value = date1;

        }

        void load_dgv()
        {
            dgv_staff.DataSource = StaffDAO.Instance.GetListStaff();
            this.dgv_staff.DefaultCellStyle.Font = new Font("Times New Roman", 12);
            foreach (DataGridViewColumn col in dgv_staff.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            }
            dgv_staff.Columns[0].HeaderText = "Mã NV";
            dgv_staff.Columns[1].HeaderText = "Họ và tên";
            dgv_staff.Columns[2].HeaderText = "Ngày sinh";
            dgv_staff.Columns[3].HeaderText = "Địa chỉ";
            dgv_staff.Columns[4].HeaderText = "Email";
            dgv_staff.Columns[5].HeaderText = "Giới tính";
            dgv_staff.Columns[6].HeaderText = "Số điện thoại";
            dgv_staff.Columns[7].HeaderText = "Tài khoản";
            dgv_staff.Columns[8].HeaderText = "Chức vụ";
        }
        

        void InsertStaff()
        {
            if (string.IsNullOrWhiteSpace(tb_name.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên");

            }
            else
                if (Convert.ToInt32(DateTime.Now.Year) - Convert.ToInt32(dtp_dob.Value.Year) < 18 || Convert.ToInt32(DateTime.Now.Year) - Convert.ToInt32(dtp_dob.Value.Year) > 55)
                {
                    MessageBox.Show("Độ tuổi không phù hợp");
                }
            
            else
            {
                string name = tb_name.Text;
                DateTime dob = dtp_dob.Value;
                string address = tb_address.Text;
                string email = tb_email.Text;
                string sex = cb_sex.Text;
                string phone = tb_phone.Text;
                string account = tb_account.Text;
                int idper = (cb_permission.SelectedItem as Permission).IdPermission;
                if (StaffDAO.Instance.InsertStaff(name, dob, address, email, sex, phone, account, idper))
                {
                    MessageBox.Show("Thêm nhân viên thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên không thành công", "Thông báo");
                } 
            }
        }
        void deletestaff()
        {
            if (string.IsNullOrEmpty(tb_idstaff.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa");
            }
            else
            {
                int idstaff = Convert.ToInt32(tb_idstaff.Text);
                if (StaffDAO.Instance.DeleteStaff(idstaff))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Xóa không thành công", "Thông báo");
                }
            }
          
        }
        void updatestaff()
        {
            if (string.IsNullOrEmpty(tb_idstaff.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần cập nhật");
            }
            else
            {
                if (string.IsNullOrWhiteSpace(tb_name.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên nhân viên");
                }
                else
                {
                    int idstaff = Convert.ToInt32(tb_idstaff.Text);
                    string name = tb_name.Text;
                    DateTime dob = dtp_dob.Value;
                    string address = tb_address.Text;
                    string email = tb_email.Text;
                    string sex = cb_sex.Text;
                    string phone = tb_phone.Text;
                    string account = tb_account.Text;
                    int idper = (cb_permission.SelectedItem as Permission).IdPermission;
                    if (StaffDAO.Instance.UpdateStaff(idstaff, name, dob, address, email, sex, phone, account, idper))
                    {
                        MessageBox.Show("Cập nhật thành công", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật không thành công", "Thông báo");
                    }
                }
            }    

        }
        

        private void bt_update_mnr_Click(object sender, EventArgs e)
        {
            updatestaff();
            load_dgv();
        }

        private void bt_add_mnr_Click(object sender, EventArgs e)
        {
            InsertStaff();
            load_dgv();
        }

        private void bt_del_mnr_Click(object sender, EventArgs e)
        {
            deletestaff();
            load_dgv();
        }

        private void dgv_staff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                DataGridViewRow row = dgv_staff.Rows[e.RowIndex];
                tb_idstaff.Text = row.Cells[0].Value.ToString();
                tb_name.Text = row.Cells[1].Value.ToString();
                dtp_dob.Value = Convert.ToDateTime(row.Cells[2].Value);
                tb_address.Text = row.Cells[3].Value.ToString();
                tb_email.Text = row.Cells[4].Value.ToString();
                cb_sex.Text = row.Cells[5].Value.ToString();
                tb_phone.Text = row.Cells[6].Value.ToString();
                tb_account.Text = row.Cells[7].Value.ToString();
                cb_permission.Text = row.Cells[8].Value.ToString();
            }
        }
    }
}
