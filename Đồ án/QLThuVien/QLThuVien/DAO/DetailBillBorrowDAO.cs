using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien.DAO
{
    public class DetailBillBorrowDAO
    {
        private static DetailBillBorrowDAO instance;

        public static DetailBillBorrowDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DetailBillBorrowDAO();
                }
                return instance;
            }
            private set => instance = value;
        }

        public DataTable GetDetailBillBorrowByID(int id)
        {
            string query = String.Format("USP_GETDETAILBILLBORROWBYIDBILLBORROW @IDBILLBORROW = {0} ", id);
            DataTable data = DataProvider.Instance.ExecuteQuery(query).Tables[0];
            return data;

        }
        public bool InsertDetailBillBorrow(int IdBook , int idBillBorrow)
        {
            string query = string.Format("EXEC USP_INSERTDETAILBILLBORROW @IDBOOK = {0}, @IDBILLBORROW = {1} ", IdBook, idBillBorrow);
            int data = DataProvider.Instance.ExecutenonQuery(query);
            return data > 0;
        }
      
    }
}
