using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.DTO
{
    public class StatusBook
    {
        private int idStatusBook;
        private string nameStatusBook;
        public StatusBook(DataRow row)
        {
            this.idStatusBook = Convert.ToInt32(row["Mahientrang"]);
            this.nameStatusBook = row["tenhientrang"].ToString();
        }

        public StatusBook(int idStatusBook, string nameStatusBook)
        {
            this.idStatusBook = idStatusBook;
            this.nameStatusBook = nameStatusBook;
        }

        public int IdStatusBook { get => idStatusBook; set => idStatusBook = value; }
        public string NameStatusBook { get => nameStatusBook; set => nameStatusBook = value; }
    }
}
