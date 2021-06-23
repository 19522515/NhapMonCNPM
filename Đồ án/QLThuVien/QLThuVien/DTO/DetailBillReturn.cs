using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.DTO
{
    public class DetailBillReturn
    {
        int idDetailBillReturn;
        int idBook;
        int idBillReturn;
        int idBillBorrow;
        int fine;

        public DetailBillReturn(int idDetailBillReturn,int idBook,int idBillReturn,int idBillBorrow,  int fine)
        {
            this.idDetailBillReturn = idDetailBillReturn;
            this.idBook = idBook;
            this.idBillReturn = idBillReturn;
            this.idBillBorrow = idBillBorrow;
            this.fine = fine;
        }

        public DetailBillReturn(DataRow row)
        {
            this.idDetailBillReturn = Convert.ToInt32(row["mactphieutra"]);
            this.idBook = Convert.ToInt32(row["masach"]);
            this.idBillReturn = Convert.ToInt32(row["maphieutra"]);
            this.idBillBorrow = Convert.ToInt32(row["maphieumuon"]);
            this.fine = Convert.ToInt32(row["tienphat"]);
        }

 
        public int IdDetailBillReturn { get => idDetailBillReturn; set => idDetailBillReturn = value; }
        public int IdBook { get => idBook; set => idBook = value; }
        public int IdBillReturn { get => idBillReturn; set => idBillReturn = value; }
        public int IdBillBorrow { get => idBillBorrow; set => idBillBorrow = value; }
        public int Fine { get => fine; set => fine = value; }
    }
}
