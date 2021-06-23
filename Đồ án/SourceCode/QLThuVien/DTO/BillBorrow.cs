using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.DTO
{
    public class BillBorrow
    {
        private int idBillBorrow;
        private DateTime Borrowdate;
        private int idReader;

        public BillBorrow(int idBillBorrow, DateTime Borrowdate, int idreader)
        {
            this.idBillBorrow = idBillBorrow;
            this.Borrowdate = Borrowdate;
            this.idReader = idreader;
        }
        public BillBorrow (DataRow row)
        {
            this.idBillBorrow = Convert.ToInt32(row["maphieumuon"]);
            this.Borrowdate = Convert.ToDateTime(row["ngaymuon"]);
            this.idReader = Convert.ToInt32(row["madocgia"]);

        }
        public int IdBillBorrow { get => idBillBorrow; set => idBillBorrow = value; }
        public DateTime Borrowdate1 { get => Borrowdate; set => Borrowdate = value; }
        public int IdReader { get => idReader; set => idReader = value; }
    }
}
