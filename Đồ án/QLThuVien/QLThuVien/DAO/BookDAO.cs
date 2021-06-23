using QLThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien.DAO
{
    public class BookDAO
    {
        private static BookDAO instance;

        public static BookDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BookDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        public DataTable GetListBookByidBook(string search)
        {

            try
            {
                int searchs = Convert.ToInt32(search);
                string query = string.Format("EXec USP_GETLISTBOOKBYIDBOOK @idbook = {0} ", searchs);
                DataSet data = DataProvider.Instance.ExecuteQuery(query);
                return data.Tables[0];
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập định dạng số để tìm sách theo mã sách", "Thông báo");
                return null;
            }
        }
        public DataTable GetListBookByCategory(string search)
        {
            
            string query = string.Format("EXEC USP_GETLISTBOOKBYNAMECATEGORY @NAMECATEGORY  = '{0}' ", search);
            DataSet data = DataProvider.Instance.ExecuteQuery(query);
            return data.Tables[0];

        }
        public DataTable GetListBookByNamedBook( string search)
        {
            
            string query = string.Format("EXEC USP_GETLISTBOOKBYNAMEBOOK @NAMEBOOK = '{0}' ", search);
            DataSet data = DataProvider.Instance.ExecuteQuery(query);
            return data.Tables[0];
        }
        public DataTable GetListBookByNameAuthor( string search)
        {
            string query = string.Format("EXEC USP_GETLISTBOOKBYNAMEAUTHOR @NAMEAUTHOR = '{0}' ", search);
            DataSet data = DataProvider.Instance.ExecuteQuery(query);
            return data.Tables[0];
           
        }
        public DataTable GetListBook()
        {
            
            string query = string.Format("EXEC USP_GETLISTBOOK ");
            DataTable data = DataProvider.Instance.ExecuteQuery(query).Tables[0];
            return data;
        }
        public List<Book> GetListBookForcombobox()
        {
            List <Book> list = new List<Book>();
            string query = "SELECT masach,CAST(masach as nvarchar(100)) + ' ' +  tensach as tensach, ngayxuatban, ngaythemsach, giatri, isbn, matheloaisach, manhaxuatban,mahientrang FROM SACH where mahientrang = 2";
            DataTable data = DataProvider.Instance.ExecuteQuery(query).Tables[0];
            foreach(DataRow item in data.Rows)
            {
                Book book = new Book(item);
                list.Add(book);
            }    
            return list;
        }
        public List<Book> GetListBookForComboboxDetailBillReturn(int idbillborrow)
        {
            List<Book> list = new List<Book>();
            string query = "EXEC GETLISTBOOKFORDETAILBILLRETURN @idbillborrow = " + idbillborrow;
            DataTable data = DataProvider.Instance.ExecuteQuery(query).Tables[0];
            foreach (DataRow item in data.Rows)
            {
                Book book = new Book(item);
                list.Add(book);
            }
            return list;
        }

        public bool InsertBook(string namebook, DateTime datepublisher, DateTime dateadd, int valuebook, string isbn, int idcate, int idpublisher, int idauthor)
        {
            string query = string.Format("exec INSERTINTOBOOK @NAMEBOOK = N'{0}', @DATEPUBLISHER = '{1}', @DATEADD = '{2}' , @VALUE ={3}, @ISBN = N'{4}', @IDCATE ={5}, @IDPUBLISHER ={6}, @idauthor ={7}", namebook, datepublisher, dateadd, valuebook, isbn, idcate, idpublisher, idauthor);
            int data = DataProvider.Instance.ExecutenonQuery(query);
            return data > 0;
        }

        public bool delBook(int idBook, int idAuthor)
        {
            string query = string.Format("EXEC DELBOOK @IDBOOK = {0} , @IDAUTHOR = {1}",idBook, idAuthor);
            int data = DataProvider.Instance.ExecutenonQuery(query);
            return data > 0;
        }
        public bool updateBook(int idbook, string namebook, DateTime datepublisher, DateTime dateadd, int valuebook, string isbn, int idcate, int idpublisher, int idauthor)
        {
            string query = string.Format("exec UPDATEBOOK @idbook = {8},  @NAMEBOOK = N'{0}', @DATEPUBLISHER = '{1}', @DATEADD = '{2}' , @VALUE ={3}, @ISBN = N'{4}', @IDCATE ={5}, @IDPUBLISHER ={6}, @idauthor ={7}", namebook, datepublisher, dateadd, valuebook, isbn, idcate, idpublisher, idauthor, idbook);
            int data = DataProvider.Instance.ExecutenonQuery(query);
            return data > 0;
        }
    }
}
