using QLThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.DAO
{
    public class StaffDAO
    {
        private static StaffDAO instance;

        public static StaffDAO Instance 
        {
            get 
            {
                if (instance == null)
                {
                    instance = new StaffDAO();
                }
                return instance;
                    } 
           private set => instance = value; 
        }

        public bool Login(string TaiKhoan, string MatKhau)
        {
            string query = ("EXEC USP_LOGIN @TAIKHOAN , @MATKHAU");
            DataSet result = DataProvider.Instance.ExecuteQuery(query, new object[] { TaiKhoan, MatKhau });
            return result.Tables[0].Rows.Count > 0;
        }
        public Staff GetNhanVienByTaiKhoan(string TaiKhoan)
        {
            DataSet data = DataProvider.Instance.ExecuteQuery("Select * from NhanVien where taikhoan = '" + TaiKhoan + "'");
            foreach (DataRow item in data.Tables[0].Rows)
            {
                return new Staff(item);
            }
            return null;
        }
        public bool ChangPassByAccount(string account, string password)
        {
            int data = DataProvider.Instance.ExecutenonQuery("EXEC USP_CHANGEPASSWORD @account , @password ", new object[] { account,password });
            return data > 0;
        }
        public List<Staff> Getlistnhanvien()
        {
            List<Staff> Listnhanvien = new List<Staff>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from nhanvien").Tables[0];
            foreach (DataRow item in data.Rows)
            {
                Staff infor = new Staff(item);
                Listnhanvien.Add(infor);
            }
            return Listnhanvien;
        }
        public Permission GePermissionByIdPermission(int id)
        {
           DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GET_PERMISSION_BY_IDPERMISSION @IDPERMISSION  ", new object[] { id }).Tables[0];
           foreach(DataRow item in data.Rows)
            {
                Permission a = new Permission(item);
                return a;
            }
            return null;
        }

        public DataTable GetListStaff()
        {
            string query = "select manv, tennv,ngaysinh, diachi, email, gioitinh, sodt, taikhoan, TENQUYEN  from nhanvien join quyenhan on nhanvien.MAQUYEN  = QUYENHAN.MAQUYEN";
            DataTable data = DataProvider.Instance.ExecuteQuery(query).Tables[0];
            return data;
        }

        public bool InsertStaff( string name, DateTime dob, string address, string email, string sex, string nbphone, string account, int per)
        {
            string query = string.Format("EXEC INSERTSTAFF @NAME = N'{0}' ,@DOB = '{1}', @ADDRESS = N'{2}', @EMAIL = '{3}', @SEX = '{4}', @PHONE = '{5}', @ACCOUNT = '{6}', @IDPER ={7}",name, dob,address,email,sex,nbphone,account,per);
            int data = DataProvider.Instance.ExecutenonQuery(query);
            return data > 0;
        }
        public bool DeleteStaff(int idstaff)
        {
           
            string query = string.Format("EXEC DELETESTAFF @IDSTAFF = "+ idstaff);
            int data = DataProvider.Instance.ExecutenonQuery(query);
            return data > 0;
        }
        public bool UpdateStaff(int idstaff, string name, DateTime dob, string address, string email, string sex, string nbphone, string account, int per)
        {
            string query = string.Format("EXEC UPDATESTAFF @IDSTAFF = {8}, @NAME = N'{0}' ,@DOB = '{1}', @ADDRESS = N'{2}', @EMAIL = '{3}', @SEX = '{4}', @PHONE = '{5}', @ACCOUNT = '{6}', @IDPER ={7}", name, dob, address, email, sex, nbphone, account, per,idstaff);
            int data = DataProvider.Instance.ExecutenonQuery(query);
            return data > 0;
        }
       
    }
}
