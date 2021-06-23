using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.DTO
{
    public class Book
    {
		private int idBook;
		private string nameBook;
		private DateTime dateManufacture;
		private DateTime dateAddBook;
		private int valueBook;
		private string ISBN;
		private int idCategory;
		private int idPulisher;
		private int idStatusBook;
        public Book ( int idBook,string nameBook,DateTime dateManufacture,DateTime dateAddBook,int valueBook, string ISBN,int idCategory,int idPulisher,int idStatusBook)
		{
		this.idBook = idBook;
		this.nameBook=  nameBook;
		this.dateManufacture =  dateManufacture;
		this.dateAddBook =  dateAddBook;
		this.valueBook =  valueBook;
		this.ISBN =  ISBN;
		this.idCategory=  idCategory;
		this.idPulisher = idPulisher;
		this.idStatusBook = idStatusBook;
		}

		public Book(DataRow row)
        {
			this.idBook = Convert.ToInt32(row["masach"]);
			this.nameBook = row["tensach"].ToString();
			this.dateManufacture = Convert.ToDateTime(row["ngayxuatban"]);
			this.dateAddBook = Convert.ToDateTime(row["ngaythemsach"]);
			this.valueBook = Convert.ToInt32(row["giatri"]);
			this.ISBN = row["ISBN"].ToString();
			this.idCategory = Convert.ToInt32(row["matheloaisach"]);
			this.idPulisher = Convert.ToInt32(row["manhaxuatban"]);
			this.idStatusBook = Convert.ToInt32(row["mahientrang"]);
		}
        public int IdBook { get => idBook; set => idBook = value; }
        public string NameBook { get => nameBook; set => nameBook = value; }
        public DateTime DateManufacture { get => dateManufacture; set => dateManufacture = value; }
        public DateTime DateAddBook { get => dateAddBook; set => dateAddBook = value; }
        public int ValueBook { get => valueBook; set => valueBook = value; }
        public string ISBN1 { get => ISBN; set => ISBN = value; }
        public int IdCategory { get => idCategory; set => idCategory = value; }
        public int IdPulisher { get => idPulisher; set => idPulisher = value; }
        public int IdStatusBook { get => idStatusBook; set => idStatusBook = value; }
    }
}
