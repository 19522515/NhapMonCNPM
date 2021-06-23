using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.DTO
{
    public class Compose
    {
        private int idAuthor;
        private int idBook;

        public Compose(int idAuthor, int idBook)
        {
            this.idAuthor = idAuthor;
            this.idBook = idBook;
        }
        public Compose(DataRow row)
        {
            this.idAuthor = Convert.ToInt32(row["matacgia"]);
            this.idBook = Convert.ToInt32(row["masach"]);
        }
        public int IdAuthor { get => idAuthor; set => idAuthor = value; }
        public int IdBook { get => idBook; set => idBook = value; }
    }
}
