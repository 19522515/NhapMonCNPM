using QLThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance 
        {
            get 
            {
                if (instance == null)
                {
                    instance = new NhanVienDAO();
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
        public NhanVien GetNhanVienByTaiKhoan(string TaiKhoan)
        {
            DataSet data = DataProvider.Instance.ExecuteQuery("Select * from NhanVien where taikhoan = '" + TaiKhoan + "'");
            foreach (DataRow item in data.Tables[0].Rows)
            {
                return new NhanVien(item);
            }
            return null;
        }
        public DataTable GetListNhanVien()
        {
            DataSet data = DataProvider.Instance.ExecuteQuery("SELECT MANV , TENNV, NGAYSINH ,EMAIL, GIOITINH ,SODT,TAIKHOAN,TYPE  from NhanVien");
            return data.Tables[0];
        }
    }
}
