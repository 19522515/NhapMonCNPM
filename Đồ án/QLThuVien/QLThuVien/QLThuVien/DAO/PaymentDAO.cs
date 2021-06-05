using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.DAO
{
    public class PaymentDAO
    {
        private static PaymentDAO instance;

        public static PaymentDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PaymentDAO();
                }
                return instance;
            }
            private set => instance = value;
        }

        public bool InsertPayment(int idStaff, int idReader, int Money, DateTime DatePayment, string Note )
        {
            string query = "EXEC INSERTPAYMENT @idstaff = " + idStaff + " , @idreader = " + idReader + " , @MONEY = " + Money + "  , @DATEPAYMENT = '" + DatePayment + "'" + "  , @Note = N'" + Note +"'";
            int data = DataProvider.Instance.ExecutenonQuery(query);
            return data > 0;
        }
        public DataTable GetListPayment()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from Phieuthanhtoan").Tables[0];
            return data;            
        }
    }
}
