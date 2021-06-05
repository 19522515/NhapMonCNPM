using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.DTO
{
    public class DetailBillBorrow
    {
        private int idDetailBillBorrow;
        private int idBook;
        private int idBillBorrow;
        private int returned;

        public DetailBillBorrow(int idDetailBillBorrow, int idBook,int idBillBorrow,int returned)
        {
            this.idDetailBillBorrow = idDetailBillBorrow;
            this.idBook = idBook;
            this.idBillBorrow = idBillBorrow;
            this.returned = returned;
        }
        public DetailBillBorrow(DataRow row)
        {
            this.idDetailBillBorrow = Convert.ToInt32(row["mactphieumuon"]);
            this.idBook = Convert.ToInt32(row["masach"]);
            this.idBillBorrow = Convert.ToInt32(row["maphieumuon"]);
            this.returned = Convert.ToInt32(row["tinhtrangpm"]);
        }
    

        public int IdDetailBillBorrow { get => idDetailBillBorrow; set => idDetailBillBorrow = value; }
        public int IdBook { get => idBook; set => idBook = value; }
        public int IdBillBorrow { get => idBillBorrow; set => idBillBorrow = value; }
        public int Returned { get => returned; set => returned = value; }
    }
}
