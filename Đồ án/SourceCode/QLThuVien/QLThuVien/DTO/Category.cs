using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.DTO
{
    public class Category
    {
        private int idCategory;
        private string nameCategory;

        public Category(int idCategory, string nameCategory)
        {
            this.idCategory = idCategory;
            this.nameCategory = nameCategory;
        }
        public Category (DataRow row)
        {
            this.idCategory = Convert.ToInt32(row["matheloaisach"]);
            this.nameCategory = row["tentheloai"].ToString();
        }
        public int IdCategory { get => idCategory; set => idCategory = value; }
        public string NameCategory { get => nameCategory; set => nameCategory = value; }
    }
}
