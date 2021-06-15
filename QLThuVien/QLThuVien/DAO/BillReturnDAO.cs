using QLThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.DAO
{
    public class BillReturnDAO
    {
        private static BillReturnDAO instance;

        public static BillReturnDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BillReturnDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        public List<BillReturn> GetListBillReturn()
        {
            List<BillReturn> list = new List<BillReturn>();
            string query = "EXEC USP_GETLISTBILLRETURN";
            DataTable data = DataProvider.Instance.ExecuteQuery(query).Tables[0];
            foreach (DataRow item in data.Rows)
            {
                BillReturn billreturn = new BillReturn(item);
                list.Add(billreturn);
            }
            return list;
        }

        public bool InsertBillReturn(int idreader, DateTime datereturn)
        {
           
            int data = DataProvider.Instance.ExecutenonQuery("EXEC USP_INSERTBILLRETURN @idreader , @datereturn  ", new object[] {idreader, datereturn});
            return data > 0;
        }
        public BillReturn GetBillReturnByIDBillReturn(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from phieutra where maphieutra = " + id).Tables[0];
            BillReturn bill = new BillReturn(data.Rows[0]);
            return bill;
        }
       
    }
}
