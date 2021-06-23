using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.DTO
{
    public class Author
    {
        private int idAuthor;
        private string nameAuthor;

        public Author(int idAuthor, string nameAuthor)
        {
            this.idAuthor = idAuthor;
            this.nameAuthor = nameAuthor;
        }
        public Author(DataRow row)
        {
            this.idAuthor = Convert.ToInt32(row["matacgia"]);
            this.nameAuthor = row["tentacgia"].ToString();
        }
        public int IdAuthor { get => idAuthor; set => idAuthor = value; }
        public string NameAuthor { get => nameAuthor; set => nameAuthor = value; }
    }
}
