using QLThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.DAO
{
    public class BillBorrowDAO
    {
        private static BillBorrowDAO instance;

        public static BillBorrowDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BillBorrowDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        public List<BillBorrow> GetListBillBorrow()
        {
            List<BillBorrow> list = new List<BillBorrow>();
            string query = "EXEC USP_GETLISTBILLBORROW";
            DataTable data = DataProvider.Instance.ExecuteQuery(query).Tables[0];
            foreach (DataRow item in data.Rows)
            {
                BillBorrow billBorrow = new BillBorrow(item);
                list.Add(billBorrow);
            }
            return list;
        }    
        public bool InsertBillBorrow(DateTime date, int idReader)
        {
            int data = DataProvider.Instance.ExecutenonQuery("EXEC USP_INSERTBILLBORROW @IDREADER , @DATEINSERT  ", new object[] {idReader, date});
            return data > 0;
        }

        public List<BillBorrow> GetListBillBorrowByIdReader(int idreader)
        {
            List<BillBorrow> list = new List<BillBorrow>();
            string query = "EXEC USP_GETLISTBILLBORROWBYIDREADER @idreader  = "+ idreader;
            DataTable data = DataProvider.Instance.ExecuteQuery(query).Tables[0];
            foreach (DataRow item in data.Rows)
            {
                BillBorrow billBorrow = new BillBorrow(item);
                list.Add(billBorrow);
            }
            return list;
        }
        public BillBorrow GetBillBorrowByIDBillBorrow(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from phieumuon where maphieumuon = " + id).Tables[0];
            BillBorrow bill = new BillBorrow(data.Rows[0]);
            return bill;

        }


    }
}
