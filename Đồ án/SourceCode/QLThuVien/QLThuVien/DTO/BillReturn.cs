using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.DTO
{
    public class BillReturn
    {
        private int idBillreturn;
        private int idReader;
        private DateTime returndate;
        private int sumfine;

        public BillReturn(int idBillreturn, int idReader, DateTime returndate, int sumfine)
        {
            this.idBillreturn = idBillreturn;
            this.idReader = idReader;
            this.returndate = returndate;
            this.sumfine = sumfine;
        }

        public BillReturn(DataRow row)
        {
            this.idBillreturn = Convert.ToInt32(row["maphieutra"]);
            this.idReader = Convert.ToInt32(row["madocgia"]);
            this.returndate = Convert.ToDateTime(row["ngaytra"]);
            this.sumfine = Convert.ToInt32(row["tongtienphat"]);
        }

        public int IdBillreturn { get => idBillreturn; set => idBillreturn = value; }
        public int IdReader { get => idReader; set => idReader = value; }
        public DateTime Returndate { get => returndate; set => returndate = value; }
        public int Sumfine { get => sumfine; set => sumfine = value; }
    }
}
