using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.DAO
{
    public class DetailBillReturnDAO
    {
        private static DetailBillReturnDAO instance;

        public static DetailBillReturnDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DetailBillReturnDAO();
                }
                return instance;
            }
            private set => instance = value;
        }

        public DataTable GetTableDetailBillReturnByIdBillReturn(int IdBillReturn)
        {
            string query = "Exec USP_GETLISTDETAILBILLRETURNBYIDBILLRETURN @idbillreturn = " + IdBillReturn;
            DataTable data = DataProvider.Instance.ExecuteQuery(query).Tables[0];
            return data;
        }
        public bool InsertDetailBillReturn(int idBillReturn, int IdBook, int IdBillBorrow, int fine)
        {
            string query = string.Format("EXEC USP_INSERTDETAILBILLRETURN @IDBILLRETURN = {0}, @IDBOOK = {1} , @IDBILLBORROW = {2} , @FINE = {3}",idBillReturn,IdBook, IdBillBorrow, fine);
            int data = DataProvider.Instance.ExecutenonQuery(query);
            return data > 0;
        }

        public bool DeleteDetailBillReturn(int iddetailbillreturn)
        {
            int data = DataProvider.Instance.ExecutenonQuery("Exec DELETE_DETAILBILLRETURN  @iddetailbillreturn = " + iddetailbillreturn);
            return data > 0;
        }
    }
}
